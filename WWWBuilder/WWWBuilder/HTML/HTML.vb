Imports WWWBuilder

Public Class Menu : Implements IEnumerable(Of MenuItem)

    Public Iterator Function GetEnumerator() As IEnumerator(Of MenuItem) Implements IEnumerable(Of MenuItem).GetEnumerator

    End Function

    Private Iterator Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator

    End Function
End Class

Public Class MenuItem

End Class