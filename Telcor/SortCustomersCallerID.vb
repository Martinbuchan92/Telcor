Imports Telcor

Public Class SortCustomersCallerID
    Implements IComparer(Of Customer)

    Public Function Compare(x As Customer, y As Customer) As Integer Implements IComparer(Of Customer).Compare
        If (x.CustCallerID > y.CustCallerID) Then
            Return 1
        ElseIf (x.custCallerID < y.custCallerID) Then
            Return -1
        Else
            Return 0
        End If

    End Function


End Class
