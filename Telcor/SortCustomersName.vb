Imports Telcor

''' <summary>
''' Class for sorting customers by name
''' </summary>
Public Class SortCustomersName
    Implements IComparer(Of Customer)

    ''' <summary>
    ''' Sets the comparer for IComparer to enable sorting
    ''' </summary>
    ''' <param name="x">First customer</param>
    ''' <param name="y">second customer</param>
    ''' <returns></returns>
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
