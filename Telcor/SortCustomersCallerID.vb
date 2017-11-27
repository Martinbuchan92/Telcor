Imports Telcor

''' <summary>
''' Class for sorting customers by CallerID
''' </summary>
Public Class SortCustomersCallerID
    Implements IComparer(Of Customer)

    ''' <summary>
    ''' Creates a Compare for the IComparer to allow comparison of Customers for sorting
    ''' </summary>
    ''' <param name="x">first customer</param>
    ''' <param name="y">second customer</param>
    ''' <returns></returns>
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
