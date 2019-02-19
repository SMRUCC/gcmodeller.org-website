var vscode;
(function (vscode) {
    function defaultStyle() {
        return {
            string: "#a31515",
            comment: "#008000",
            keyword: "#0000ff",
            attribute: "#2b91af",
            type: "#2b91af",
            directive: "grey",
            globalFont: {
                fontName: "Consolas",
                size: { pixel: 12 }
            }
        };
    }
    vscode.defaultStyle = defaultStyle;
    function applyStyle(div, style) {
        if (style === void 0) { style = vscode.VisualStudio; }
        var preview = typeof div == "string" ? $ts(div) : div;
        $ts.select(".string").attr("style", "color: " + style.string + ";");
        $ts.select(".comment").attr("style", "color: " + style.comment + ";");
        $ts.select(".keyword").attr("style", "color: " + style.keyword);
        $ts.select(".attribute").attr("style", "color: " + style.attribute);
        $ts.select(".type").attr("style", "color: " + style.type);
        $ts.select(".directive").attr("style", "color: " + style.directive);
        $ts.select(".line-hash").attr("style", "color: #3c3e3e; text-decoration: none;");
        CanvasHelper.CSSFont.applyCSS(preview, style.globalFont);
    }
    vscode.applyStyle = applyStyle;
})(vscode || (vscode = {}));
var vscode;
(function (vscode) {
    /**
     * The VB code syntax token generator
    */
    var VBParser = /** @class */ (function () {
        /**
         * @param chars A chars enumerator
        */
        function VBParser(chars) {
            this.chars = chars;
            this.code = new vscode.tokenStyler();
            this.escapes = {
                string: false,
                comment: false,
                keyword: false // VB之中使用[]进行关键词的转义操作
            };
            this.token = [];
        }
        VBParser.prototype.GetTokens = function () {
            while (!this.chars.EndRead) {
                this.walkChar(this.chars.Next);
            }
            return this.code;
        };
        VBParser.peekNextToken = function (chars, allowNewLine) {
            if (allowNewLine === void 0) { allowNewLine = false; }
            var i = 0;
            var c = null;
            while ((c = chars.Peek(i++)) == " " || c == "\n") {
                if ((c == "\n") && !allowNewLine) {
                    break;
                }
            }
            return c;
        };
        Object.defineProperty(VBParser.prototype, "isKeyWord", {
            get: function () {
                return vscode.VBKeywords.indexOf(this.token.join("")) > -1;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(VBParser.prototype, "isAttribute", {
            get: function () {
                var token = this.token;
                var haveTagEnd = token[token.length - 1] == ">" || this.chars.Peek(-1) == "("; // token[token.length - 1] == "(";
                return token[0] == "&lt;" && haveTagEnd;
            },
            enumerable: true,
            configurable: true
        });
        VBParser.prototype.endToken = function () {
            var code = this.code, token = this.token;
            if (this.isAttribute) {
                // 自定义属性需要一些额外的处理
                // 不渲染符号，只渲染单词
                code.append(token[0]);
                if (token[token.length - 1] == ">") {
                    code.attribute($ts(token).Skip(1).Take(token.length - 2).JoinBy(""));
                    code.append(token[token.length - 1]);
                }
                else {
                    code.attribute($ts(token).Skip(1).Take(token.length - 1).JoinBy(""));
                }
            }
            else if (code.LastNewLine && token[0] == "#") {
                code.directive(token.join(""));
            }
            else {
                // 结束当前的单词
                var word = token.join("");
                if (code.LastDirective) {
                    code.directive(word);
                }
                else if (vscode.VBKeywords.indexOf(word) > -1) {
                    // 当前的单词是一个关键词
                    code.keyword(word);
                }
                else if (code.LastTypeKeyword) {
                    if (code.LastAddedToken == "Imports") {
                        // Imports xxx = yyyy
                        if (VBParser.peekNextToken(this.chars) == "=") {
                            code.type(word);
                        }
                        else {
                            code.append(word);
                        }
                    }
                    else if (word == "(") {
                        code.append(word);
                    }
                    else {
                        code.type(word);
                    }
                }
                else {
                    code.append(word);
                }
            }
            this.token = [];
        };
        /**
         * 处理当前的这个换行符
        */
        VBParser.prototype.walkNewLine = function () {
            // 是一个换行符
            if (this.escapes.comment) {
                // vb之中注释只有单行注释，换行之后就结束了                    
                this.code.comment(this.token.join("").replace("<", "&lt;"));
                this.escapes.comment = false;
                this.token = [];
            }
            else if (this.escapes.string) {
                // vb之中支持多行文本字符串，所以继续添加
                // this.token.push("<br />");
                this.code.string(this.token.join(""));
                this.code.appendLine();
                this.token = [];
            }
            else {
                // 结束当前的token
                this.endToken();
                this.code.appendLine();
            }
        };
        VBParser.prototype.walkStringQuot = function () {
            // 可能是字符串的起始
            if (!this.escapes.string) {
                this.escapes.string = true;
                this.endToken();
                this.token.push('"');
            }
            else if (this.escapes.string) {
                // 是字符串的结束符号
                this.escapes.string = false;
                this.token.push('"');
                this.code.string(this.token.join(""));
                this.token = [];
            }
        };
        VBParser.prototype.walkChar = function (c) {
            var escapes = this.escapes;
            var code = this.code;
            if (c == "\n") {
                this.walkNewLine();
            }
            else if (this.escapes.comment) {
                // 当前的内容是注释的一部分，则直接添加内容
                this.token.push(c);
                // 下面的所有代码都是处理的非注释部分的内容了
                // 代码注释部分的内容已经在处理换行符和上面的代码之中完成了处理操作
            }
            else if (c == '"') {
                this.walkStringQuot();
            }
            else if (c == "'") {
                if (!escapes.string) {
                    // 是注释的起始
                    escapes.comment = true;
                    this.endToken();
                    this.token.push(c);
                }
                else {
                    this.token.push(c);
                }
            }
            else if (c == " " || c == "\t") {
                // 使用空格进行分词
                if (!escapes.string) {
                    this.endToken();
                    code.append(c);
                    // 是字符串的一部分
                }
                else if (c == " ") {
                    this.token.push("&nbsp;");
                }
                else {
                    // 是一个TAB
                    // 则插入4个空格
                    for (var i = 0; i < 4; i++) {
                        this.token.push("&nbsp;");
                    }
                }
            }
            else if (c in vscode.delimiterSymbols) {
                // 也会使用小数点进行分词
                if (!escapes.string) {
                    if (c == "(") {
                        //if (this.isKeyWord) {
                        this.endToken();
                        this.token.push("(");
                        this.endToken();
                        //} else {
                        //    this.endToken();
                        //    this.token.push("(");
                        //    this.endToken();
                        //}
                    }
                    else {
                        this.endToken();
                        code.append(c);
                    }
                }
                else {
                    this.token.push(c);
                }
            }
            else if (c == "<" || c == "&") {
                this.token.push(Strings.escapeXml(c));
            }
            else {
                this.token.push(c);
            }
        };
        return VBParser;
    }());
    vscode.VBParser = VBParser;
})(vscode || (vscode = {}));
var vscode;
(function (vscode) {
    /**
     * 输出的是一个``table``对象的html文本
    */
    var tokenStyler = /** @class */ (function () {
        function tokenStyler() {
            this.code = new StringBuilder("", "<br />\n");
            this.rowList = [];
            this.lastTypeKeyword = false;
            this.lastNewLine = true;
            this.lastDirective = false;
            this.lastToken = null;
        }
        Object.defineProperty(tokenStyler.prototype, "rows", {
            //#region "status"
            get: function () {
                return this.rowList;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(tokenStyler.prototype, "LastAddedToken", {
            get: function () {
                return this.lastToken;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(tokenStyler.prototype, "LastTypeKeyword", {
            /**
             * 上一个追加的单词是一个类型定义或者引用的关键词
            */
            get: function () {
                return this.lastTypeKeyword;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(tokenStyler.prototype, "LastNewLine", {
            get: function () {
                return this.lastNewLine;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(tokenStyler.prototype, "LastDirective", {
            get: function () {
                return this.lastDirective;
            },
            enumerable: true,
            configurable: true
        });
        //#endregion
        tokenStyler.prototype.tagClass = function (token, cls) {
            this.lastToken = token;
            return "<span class=\"" + cls + "\">" + token + "</span>";
        };
        tokenStyler.prototype.append = function (token) {
            if (token == " ") {
                this.code.Append("&nbsp;");
            }
            else if (token == "\t") {
                // 是一个TAB
                // 则插入4个空格
                for (var i = 0; i < 4; i++) {
                    this.code.Append("&nbsp;");
                }
            }
            else if (token == "(" || token == "{" || token == ",") {
                this.code.Append(token);
            }
            else {
                // 不计算空格
                this.code.Append(token);
                this.lastTypeKeyword = false;
                this.lastDirective = false;
                this.lastToken = token;
            }
            this.lastNewLine = false;
        };
        /**
         * 生成一个新的table的行对象
        */
        tokenStyler.prototype.appendLine = function (token) {
            if (token === void 0) { token = ""; }
            this.code.AppendLine(token);
            this.lastTypeKeyword = false;
            this.lastNewLine = true;
            this.lastDirective = false;
            this.lastToken = token;
            this.appendNewRow();
        };
        tokenStyler.prototype.appendNewRow = function () {
            // 构建新的row对象，然后将原来的代码字符串缓存清空
            var L = this.rowList.length + 1;
            var line = $ts("<span>", { class: "line" }).display(L + ": ");
            var hash = $ts("<a>", { id: "L" + L, href: "#L" + L, class: "line-hash" }).display(line);
            var snippet = $ts("<td>", { class: "snippet" }).display(this.code.toString());
            var tr = $ts("<tr>").asExtends
                .append($ts("<td>", { class: "lines" }).display(hash))
                .append(snippet);
            this.rowList.push(tr.HTMLElement);
            this.code = new StringBuilder("", "<br />\n");
        };
        tokenStyler.prototype.directive = function (token) {
            this.code.Append(this.tagClass(token, "directive"));
            this.lastTypeKeyword = false;
            this.lastNewLine = false;
            this.lastDirective = true;
        };
        tokenStyler.prototype.type = function (token) {
            this.code.Append(this.tagClass(token, "type"));
            this.lastTypeKeyword = false;
            this.lastNewLine = false;
            this.lastDirective = false;
        };
        tokenStyler.prototype.comment = function (token) {
            this.code.AppendLine(this.tagClass(tokenStyler.highlightURLs(token), "comment"));
            this.lastTypeKeyword = false;
            this.lastNewLine = true;
            this.lastDirective = false;
            this.appendNewRow();
        };
        tokenStyler.highlightURLs = function (token) {
            var urls = TypeScript.URL.ParseAllUrlStrings(token);
            var a;
            if (Internal.outputEverything()) {
                console.log(urls);
            }
            for (var _i = 0, urls_1 = urls; _i < urls_1.length; _i++) {
                var url = urls_1[_i];
                a = "<a href=\"" + url + "\">" + url + "</a>";
                token = token.replace(url, a);
            }
            return token;
        };
        /**
         * 可能会存在url
        */
        tokenStyler.prototype.string = function (token) {
            this.code.Append(this.tagClass(tokenStyler.highlightURLs(token), "string"));
            this.lastTypeKeyword = false;
            this.lastNewLine = false;
            this.lastDirective = false;
        };
        tokenStyler.prototype.keyword = function (token) {
            this.code.Append(this.tagClass(token, "keyword"));
            if (vscode.TypeDefine.indexOf(token) > -1) {
                this.lastTypeKeyword = true;
            }
            else {
                this.lastTypeKeyword = false;
            }
            this.lastNewLine = false;
            this.lastDirective = false;
        };
        tokenStyler.prototype.attribute = function (token) {
            this.code.Append(this.tagClass(token, "attribute"));
            this.lastTypeKeyword = false;
            this.lastNewLine = false;
            this.lastDirective = false;
        };
        return tokenStyler;
    }());
    vscode.tokenStyler = tokenStyler;
})(vscode || (vscode = {}));
/// <reference path="../build/linq.d.ts" />
/// <reference path="CSS.ts" />
/// <reference path="tokenStyler.ts" />
/// <reference path="VBparser.ts" />
$ts.mode = Modes.debug;
// $ts.mode = Modes.production;
var vscode;
(function (vscode) {
    vscode.VisualStudio = vscode.defaultStyle();
    /**
     * All of the VB keywords that following type names
    */
    vscode.TypeDefine = [
        "As", "Class", "Structure", "Module", "Imports", "Of", "New", "GetType"
    ];
    vscode.delimiterSymbols = {
        ".": true,
        ",": true,
        "=": true,
        "(": true,
        ")": true,
        "{": true,
        "}": true
    };
    /**
     * List of VB.NET language keywords
    */
    vscode.VBKeywords = (function (str) {
        var lines = Strings.lineTokens(str.trim());
        var words = $ts(lines)
            .Select(function (s) { return s.split("|"); })
            .Unlist(function (s) { return s; })
            .Where(function (s) { return !Strings.Empty(s) && !Strings.Blank(s); })
            .ToArray();
        if (Internal.outputEverything()) {
            console.log(words);
        }
        return words;
    })("\n        |AddHandler|AddressOf|Alias|And|AndAlso|As|\n        |Boolean|ByRef|Byte|\n        |Call|Case|Catch|CBool|CByte|CChar|CDate|CDec|CDbl|Char|CInt|Class|CLng|CObj|Const|Continue|CSByte|CShort|CSng|CStr|CType|CUInt|CULng|CUShort|\n        |Date|Decimal|Declare|Default|Delegate|Dim|DirectCast|Do|Double|\n        |Each|Else|ElseIf|End|EndIf|Enum|Erase|Error|Event|Exit|\n        |False|Finally|For|Friend|Function|\n        |Get|GetType|GetXMLNamespace|Global|GoSub|GoTo|\n        |Handles|\n        |If|Implements|Imports|In|Inherits|Integer|Interface|Is|IsNot|\n        |Let|Lib|Like|Long|Loop|\n        |Me|Mod|Module|MustInherit|MustOverride|MyBase|MyClass|My|\n        |Namespace|Narrowing|New|Next|Not|Nothing|NotInheritable|NotOverridable|NameOf|\n        |Object|Of|On|Operator|Option|Optional|Or|OrElse|Overloads|Overridable|Overrides|\n        |ParamArray|Partial|Private|Property|Protected|Public|\n        |RaiseEvent|ReadOnly|ReDim|REM|RemoveHandler|Resume|Return|\n        |SByte|Select|Set|Shadows|Shared|Short|Single|Static|Step|Stop|String|Structure|Sub|SyncLock|\n        |Then|Throw|To|True|Try|TryCast|TypeOf|\n        |Variant|\n        |Wend|\n        |UInteger|ULong|UShort|Using|\n        |When|While|Widening|With|WithEvents|WriteOnly|\n        |Xor|\n        |Yield|\n    ");
    /**
     * <pre class="vbnet">
    */
    function highlightVB(style) {
        if (style === void 0) { style = vscode.VisualStudio; }
        var codeList = $ts.select(".vbnet");
        for (var _i = 0, _a = codeList.ToArray(); _i < _a.length; _i++) {
            var code = _a[_i];
            vscode.highlight(code.innerText, code, style);
        }
    }
    vscode.highlightVB = highlightVB;
    function highlightGithub(github, filename, display, style) {
        if (style === void 0) { style = vscode.VisualStudio; }
        HttpHelpers.GetAsyn(github.fileURL(filename), function (code) { return vscode.highlight(code, display, style); });
    }
    vscode.highlightGithub = highlightGithub;
    /**
     * @param style 可以传递一个null值来使用css进行样式的渲染
    */
    function highlight(code, display, style) {
        if (style === void 0) { style = vscode.VisualStudio; }
        var pcode = new Pointer(Strings.ToCharArray(code));
        var html = new vscode.VBParser(pcode).GetTokens();
        var container = $ts("<tbody>");
        var preview = $ts("<table>", { class: "pre" }).display(container);
        for (var _i = 0, _a = html.rows; _i < _a.length; _i++) {
            var row = _a[_i];
            container.append(row);
        }
        if (typeof display == "string") {
            $ts(display).display(preview);
        }
        else {
            if (display.tagName == "pre") {
                preview.className = "";
            }
            display.clear();
            display.display(preview);
        }
        if (style) {
            vscode.applyStyle(display, style);
        }
        if (Internal.outputEverything()) {
            console.log(html.rows);
        }
    }
    vscode.highlight = highlight;
})(vscode || (vscode = {}));
var vscode;
(function (vscode) {
    var github;
    (function (github) {
        var raw = /** @class */ (function () {
            function raw(user, repo, commit) {
                if (commit === void 0) { commit = "master"; }
                this.commit = "master";
                this.username = user;
                this.repo = repo;
                this.commit = commit;
            }
            raw.prototype.fileURL = function (path) {
                return "https://raw.githubusercontent.com/" + this.username + "/" + this.repo + "/" + this.commit + "/" + path;
            };
            raw.prototype.highlightCode = function (fileName, display, style) {
                if (style === void 0) { style = vscode.VisualStudio; }
                vscode.highlightGithub(this, fileName, display, style);
            };
            return raw;
        }());
        github.raw = raw;
    })(github = vscode.github || (vscode.github = {}));
})(vscode || (vscode = {}));
//# sourceMappingURL=vbcode.js.map