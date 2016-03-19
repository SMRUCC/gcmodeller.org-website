Imports Microsoft.VisualBasic.CommandLine.Reflection

Module CLI

    Sub New()

    End Sub

    <ExportAPI("--New.Project", Usage:="--New.Project [--Export <DIR>]")>
    Public Function NewProject(args As CommandLine.CommandLine) As Integer
        Dim outDIR As String = args.GetValue("--export", App.CurrentWork)

    End Function

    <ExportAPI("/compile",
               Usage:="/compile /in <proj.xml> [/out <outDIR>]")>
    Public Function Compile(args As CommandLine.CommandLine) As Integer
        Dim inProj As String = args("/in")
        Dim outDIR As String = args.GetValue("/out", inProj.ParentPath)
        Dim doc As Project = Project.Load(inProj)
        Return doc.Build(outDIR).CLICode
    End Function

    <ExportAPI("/menu.add",
               Usage:="/menu.add /proj <proj.xml> /name <name> /class <class> /action <link>")>
    Public Function AddMenuItem(args As CommandLine.CommandLine) As Integer
        Dim inProj As String = args("/proj")
        Dim proj As Project = Project.Load(inProj)

        If proj.HTML Is Nothing Then
            proj.HTML = New Doc
        End If
        If proj.HTML.Menu Is Nothing Then
            proj.HTML.Menu = New Menu
        End If
        Call proj.HTML.Menu.Add(args("/name"), args("/class"), args("/action"))

        Return proj.Save.CLICode
    End Function
End Module
