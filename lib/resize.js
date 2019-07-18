/// <reference path="../linq.d.ts" />
$ts.mode = Modes.debug;
$ts(function () {
    var size = DOM.clientSize();
    var iframe = document.getElementsByTagName("iframe");
    // fix for padding
    size[0] = size[0] * 0.95;
    if (TypeScript.logging.outputEverything) {
        console.log(iframe);
    }
    if (size[0] <= 500) {
        for (var i = 0; i < iframe.length; i++) {
            var frame = iframe.item(i);
            var w = parseInt((/\d+/ig).exec(frame.width)[0]);
            var h = parseInt((/\d+/ig).exec(frame.height)[0]);
            frame.width = size[0] + "px";
            frame.height = size[0] * h / w + "px";
        }
    }
    for (var i = 0; i < iframe.length; i++) {
        var frame = iframe.item(i);
        if (TypeScript.logging.outputEverything) {
            console.log(frame);
        }
        setTimeout(removeAD(frame), 3000);
    }
});
function removeAD(frame) {
    return function () {
        $ts(function () {
            // 移除推荐div
            var div = frame.contentDocument.getElementsByClassName("bilibili-player-video-recommend").item(0);
            var container = div.parentElement;
            container.removeChild(div);
        }, frame);
    };
}
//# sourceMappingURL=resize.js.map