Public Class Customer
    Private callerID As String
    Private customerName As String
    Private callCount As Integer
    Private calls As New List(Of TTCall)

    Public Sub New(ByVal c_callerID As String, ByVal c_custName As String)
        callerID = c_callerID
        customerName = c_custName
    End Sub

    Public Overrides Function ToString() As String
        Dim objectData = String.Format("{0}, '{1}'", callerID, customerName)
        Return objectData
    End Function

    Public Shared Function Format(ByVal customers As List(Of Customer), ByVal withCallData As Boolean, ByVal zeroCalls As Boolean) As String
        Dim formatted As String = ""

        For Each Person In customers
            If withCallData And zeroCalls Then
                formatted += PrintDetails(Person, True)
            ElseIf withCallData And Not zeroCalls Then
                If Person.callCount > 0 Then
                    formatted += PrintDetails(Person, True)
                End If
            ElseIf Not withCallData And zeroCalls Then
                If Person.callCount = 0 Then
                    formatted += PrintDetails(Person, False)
                End If
            ElseIf Not withCallData And Not zeroCalls Then
                If Person.callCount > 0 Then
                    formatted += PrintDetails(Person, False)
                End If
            End If
        Next

        Return formatted
    End Function

    Public Shared Function FindCustomer(ByVal customers As List(Of Customer), ByVal search As String, ByVal byName As Boolean) As String
        Dim details As String = ""
        Dim found As Boolean = False
        For Each person In customers
            If byName = True Then
                If person.CustName.Equals(search) Then
                    found = True
                    details = PrintDetails(person, True)
                End If
            Else 'searching by ID
                If person.CustCallerID.Equals(search) Then
                    found = True
                    details = PrintDetails(person, True)
                End If
            End If
        Next
        If found = True Then
            Return details
        End If
        Return ""
    End Function

    Public Shared Function PrintDetails(person As Customer, withCalls As Boolean) As String
        Dim callDetails As String = ""
        callDetails += person.ToString()
        callDetails += Environment.NewLine
        If withCalls = True Then
            For Each item In person.calls
                callDetails += item.ToString
                callDetails += Environment.NewLine
                If item Is person.calls.Last Then
                    callDetails += Environment.NewLine
                End If
            Next
        End If
        Return callDetails
    End Function

#Region "Properties"
    Public Property TelcorCall() As List(Of TTCall)
        Get
            Return calls
        End Get
        Set(ByVal value As List(Of TTCall))
            calls = value
        End Set
    End Property

    Public Property CustCallerID() As String
        Get
            Return callerID
        End Get
        Set(value As String)
            callerID = value
        End Set
    End Property

    Public Property CustName() As String
        Get
            Return customerName
        End Get
        Set(value As String)
            customerName = value
        End Set
    End Property

    Public Property CustCallCount() As Integer
        Get
            Return callCount
        End Get
        Set(value As Integer)
            callCount = value
        End Set
    End Property
#End Region


End Class