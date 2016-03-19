Imports System.Text
Imports Microsoft.VisualBasic.ComponentModel

Public Class Project : Inherits ITextFile

    Public Property Title As String

    Public Property Resources As HrefLink()
        Get
            If __resHash Is Nothing Then
                Return New HrefLink() {}
            Else
                Return __resHash.Values.ToArray
            End If
        End Get
        Set(value As HrefLink())
            If value Is Nothing Then
                __resHash = New Dictionary(Of String, HrefLink)
            Else
                __resHash = value.ToDictionary(Function(x) x.ResourceId)
            End If
        End Set
    End Property
    Public Property HTML As Doc

    Dim __resHash As Dictionary(Of String, HrefLink)

    Public ReadOnly Property ResHash As IReadOnlyDictionary(Of String, HrefLink)
        Get
            Return __resHash
        End Get
    End Property

    Public Function CreateNew(DIR As String) As Project
        Dim proj As New Project With {
            .Title = "New HTML Template Project"
        }
        Return proj
    End Function

    ''' <summary>
    ''' 项目文件所在的文件夹
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property DIR As String
        Get
            Return FilePath.ParentPath
        End Get
    End Property

    Public ReadOnly Property PagesDIR As String
        Get
            Return DIR & "/pages/"
        End Get
    End Property

    Public ReadOnly Property TemplatesDIR As String
        Get
            Return DIR & "/templates/"
        End Get
    End Property

    Public ReadOnly Property HeaderTemplate As String
        Get
            Return TemplatesDIR & "/head.html"
        End Get
    End Property

    Public ReadOnly Property FooterTemplate As String
        Get
            Return TemplatesDIR & "/footer.html"
        End Get
    End Property

    Public ReadOnly Property AssetsDIR As String
        Get
            Return DIR & "/assets/"
        End Get
    End Property

    Public ReadOnly Property FontsDIR As String
        Get
            Return DIR & "/fonts/"
        End Get
    End Property

    Public Iterator Function Pages() As IEnumerable(Of String)
        Dim files = FileIO.FileSystem.GetFiles(PagesDIR, FileIO.SearchOption.SearchTopLevelOnly, "*.html")
        For Each s As String In files
            Yield s
        Next
    End Function

    ''' <summary>
    ''' 从项目文件数据之中生成HTML模板
    ''' </summary>
    ''' <returns></returns>
    Public Function Build(outDIR As String) As Boolean
        Dim head As String = Me.HeaderTemplate.ReadAllText
        Dim footer As String = Me.FooterTemplate.ReadAllText

        For Each file As String In Pages()
            Dim name As String = file.BaseName
            Dim html As String = head & vbCrLf & file.ReadAllText & vbCrLf & footer
            Dim path As String = outDIR & $"/{name}.html"
            Call html.SaveTo(path, Encoding:=System.Text.Encoding.UTF8)
        Next

        Call Process.Start(DIR & "/index.html")

        Return True
    End Function

    Public Shared Function Load(proj As String) As Project
        Dim doc As Project = proj.LoadTextDoc(Of Project)(ThrowEx:=False)
        If doc Is Nothing Then
            doc = New Project With {
                .FilePath = proj,
                .Title = proj.ToFileURL
            }
            Call doc.Save()
        End If

        Call "Place your html content files here.".SaveTo(doc.PagesDIR & "/ReadME.txt")
        Call "Place your assets content files here.".SaveTo(doc.AssetsDIR & "/ReadME.txt")
        Call "Place the required web font files here.".SaveTo(doc.FontsDIR & "/ReadME.txt")

        If Not doc.HeaderTemplate.FileExists Then
            Call "".SaveTo(doc.HeaderTemplate)
        End If
        If Not doc.FooterTemplate.FileExists Then
            Call "".SaveTo(doc.FooterTemplate)
        End If
        Return doc
    End Function

    Public Overrides Function Save(Optional FilePath As String = "", Optional Encoding As Encoding = Nothing) As Boolean
        Return Me.GetXml.SaveTo(getPath(FilePath), getEncoding(Encoding))
    End Function
End Class
