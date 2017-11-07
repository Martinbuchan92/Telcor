Public Class Customer
    Dim callerID As String
    Dim customerName As String
    Dim callCount  'As TTCall List
    Dim calls As Integer

    Public Sub New()

    End Sub

    Public Sub New(ByVal c_callerID As String, ByVal c_custName As String)
        callerID = c_callerID
        customerName = c_custName
    End Sub

    Public Overrides Function ToString() As String

        Return ""
    End Function

    Public Shared Function FindCustomer(ByVal customers As List(Of Customer), ByVal search As String, ByVal byName As Boolean) As String
        'Search customer array for specific customer
        Return ""
    End Function

#Region "Get Sets"
    Public Property GetSetCalls() As Integer
        Get
            Return calls
        End Get
        Set(value As Integer)
            calls = value
        End Set
    End Property

    Public Property GetSetCallerID() As String
        Get
            Return callerID
        End Get
        Set(value As String)
            callerID = value
        End Set
    End Property

    Public Property GetSetCustomerName() As String
        Get
            Return customerName
        End Get
        Set(value As String)
            customerName = value
        End Set
    End Property

    Public Property GetSetCallCount As Integer
        Get
            Return callCount
        End Get
        Set(value As Integer)
            callCount = value
        End Set
    End Property
#End Region


End Class
