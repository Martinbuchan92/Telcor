Imports Telcor

Public Class SortCustomersName
    Implements IComparer(Of Customer)

    Public Function Compare(x As Customer, y As Customer) As Integer Implements IComparer(Of Customer).Compare
        If (x.CustName > y.CustName) Then
            Return 1
        ElseIf (x.CustName < y.CustName) Then
            Return -1
        Else
            Return 0
        End If
    End Function
End Class
