Imports System.Text
Imports WWWBuilder
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ComponentModel.Collection.Generic

Public Class Menu

    Dim __ulst As Dictionary(Of MenuItem)

    Public Property ulist As MenuItem()
        Get
            If __ulst Is Nothing Then
                __ulst = New Dictionary(Of MenuItem)
            End If

            Return __ulst.Values.ToArray
        End Get
        Set(value As MenuItem())
            If value Is Nothing Then
                __ulst = New Dictionary(Of MenuItem)
            Else
                __ulst = value.ToDictionary
            End If
        End Set
    End Property

    Public Property [class] As String

    Public Sub Add(name As String, [class] As String, action As String)
        Dim item As New MenuItem With {
            .Name = name,
            .Link = New HrefLink With {
                .ResourceId = [class],
                .Value = action
            }
        }

        __ulst += item
    End Sub
End Class

Public Class MenuItem : Implements sIdEnumerable

    Public Property Link As HrefLink
    Public Property Name As String Implements sIdEnumerable.Identifier

    Public Function BuildHTML(active As Boolean) As String
        Dim html As StringBuilder = New StringBuilder()

        If active Then
            Call html.AppendLine("<li class=""active"">")
        Else
            Call html.AppendLine("<li>")
        End If
        Call html.AppendLine($"<a href=""{Link.Value}""><i class=""{Link.ResourceId}""></i>{Name}</a>")
        Call html.AppendLine("</li>")

        Return html.ToString
    End Function
End Class