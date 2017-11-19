Imports Telcor

Public Class SortCustomers
    Implements IComparer

    Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare

        If (x > y) Then
            Return 1
        ElseIf (x < y) Then
            Return -1
        Else
            Return 0
        End If
    End Function

    Public Function Compare(x As Object, y As Object, comparisonType As Integer) As Integer

    End Function

    Public Function SortName()
        For Each person In customers
            Compare(person.CustName, "a")
        Next
    End Function
End Class
