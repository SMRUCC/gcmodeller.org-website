Imports System.IO
Imports Microsoft.VisualBasic.ComponentModel

Public Class HrefLink : Inherits Href

    ''' <summary>
    ''' 编译所需要的资源文件的文件路径
    ''' </summary>
    ''' <returns></returns>
    Public Property Resource As String

    Public Function Link(DIR As String, skip As Boolean) As String
        Dim target As String = DIR & "/" & Me.Value
        If target.FileExists Then
            If skip Then
                GoTo Link
            End If
        End If

        Call FileIO.FileSystem.CreateDirectory(target.ParentPath)
        Call SafeCopyTo(Resource, target)

Link:   Return $"<a href=""{Value}"">{Annotations}</a>"
    End Function
End Class
