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
End Module
