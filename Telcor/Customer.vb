Public Class Customer
    Dim callerID As String
    Dim customerName As String
    Dim callcount  'As TTCall List
    Dim calls As Integer

    Public Sub New(ByVal callerID As String, ByVal custName As String)

    End Sub

    Public Overrides Function ToString() As String

        Return ""
    End Function

    Public Shared Function FindCustomer(ByVal customers As List(Of Customer), ByVal search As String, ByVal byName As Boolean) As String
        'Search customer array for specific customer
        Return ""
    End Function



End Class
