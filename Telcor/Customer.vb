Public Class Customer
    Dim callerID As String
    Dim customerName As String
    Dim callCount As Integer
    Dim calls As New List(Of TTCall)

    Public Sub New(ByVal c_callerID As String, ByVal c_custName As String)
        callerID = c_callerID
        customerName = c_custName
    End Sub

    Public Overrides Function ToString() As String
        Dim objectData = String.Format("{0}, {1}", callerID, customerName)
        Return objectData
    End Function

    Public Shared Function Format(ByVal customers As List(Of Customer), ByVal withCallData As Boolean, ByVal zeroCalls As Boolean) As String
        Dim returnData As String = ""
        'Remove duplicate code/siplify 
        If withCallData And zeroCalls Then
            For Each person In customers
                returnData += person.ToString
                returnData += Environment.NewLine
                If person.callCount > 0 Then
                    For Each phoneCall In person.calls
                        returnData += person.calls.ToString
                        returnData += Environment.NewLine
                    Next
                End If
            Next
        ElseIf withCallData And Not zeroCalls Then
            For Each person In customers
                If person.callCount > 0 Then
                    returnData += person.ToString
                    For Each phoneCall In person.calls
                        returnData += person.calls.ToString
                        returnData += Environment.NewLine
                    Next
                End If
            Next
        ElseIf Not withCallData And zeroCalls Then
            For Each person In customers
                If person.callCount = 0 Then
                    returnData += person.ToString
                    returnData += Environment.NewLine
                End If
            Next
        ElseIf Not withCallData And Not zeroCalls Then
            For Each person In customers
                If person.callCount > 0 Then
                    returnData += person.ToString
                    returnData += Environment.NewLine
                End If
            Next
        End If

        Return returnData
    End Function

    Public Shared Function FindCustomer(ByVal customers As List(Of Customer), ByVal search As String, ByVal byName As Boolean) As String
        Dim details As String
        'TODO Fix Duplicate code 
        'add boolean flag for if not found
        If byName = True Then
            For Each person In customers
                If person.CustName.Equals(search) Then
                    details = PrintDetails(person)
                End If
            Next
        Else
            For Each person In customers
                If person.CustCallerID.Equals(search) Then
                    details = PrintDetails(person)
                End If
            Next
        End If

        Return details
    End Function

    Private Shared Function PrintDetails(person As Customer) As String
        Dim callDetails As String = ""
        callDetails = person.ToString()
        For Each item In person.calls
            callDetails += item.ToString
            callDetails += Environment.NewLine
        Next
        Return callDetails
    End Function

#Region "Get Sets"
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
