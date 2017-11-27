''' <summary>
''' Used for Customer Objects. 
''' </summary>
Public Class Customer
    Private callerID As String
    Private customerName As String
    Private callCount As Integer
    Private calls As New List(Of TTCall)

    ''' <summary>
    ''' Constructor for creating customer instances
    ''' </summary>
    ''' <param name="c_callerID">Customer phone number</param>
    ''' <param name="c_custName">Customer Name</param>
    Public Sub New(ByVal c_callerID As String, ByVal c_custName As String)
        callerID = c_callerID
        customerName = c_custName
    End Sub

    ''' <summary>
    ''' Allows the customers information to be printed or exported in an easy format as a single string
    ''' </summary>
    ''' <returns>String containing the customers details</returns>
    Public Overrides Function ToString() As String
        Dim objectData = String.Format("{0}, '{1}'", callerID, customerName)
        Return objectData
    End Function

    ''' <summary>
    ''' Formats the customer data as per requirements to enable printing of various information
    ''' </summary>
    ''' <param name="customers">Inserts the Customer List to print from</param>
    ''' <param name="withCallData">Select if the exported string should include call data</param>
    ''' <param name="zeroCalls">select if the exported string should include customers with no calls recorded</param>
    ''' <returns>Requested information in correct format.</returns>
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

    ''' <summary>
    ''' Searches a list of customers to find a specific one
    ''' </summary>
    ''' <param name="customers">List of customers to be searched for</param>
    ''' <param name="search">Value to look for</param>
    ''' <param name="byName">If the search value is a name or a number with true being to search by name and false being to search by customer ID</param>
    ''' <returns>Returns the found customers details as a string</returns>
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

    ''' <summary>
    ''' Returns The formated string of customer information including calls to be easily called for populating views
    ''' </summary>
    ''' <param name="person">The instance of customer to be printed to string</param>
    ''' <param name="withCalls">If this persons calls are to be included in the returned string</param>
    ''' <returns>Returns the details of the selected customer instance with or without calls following their name, as user requests</returns>
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