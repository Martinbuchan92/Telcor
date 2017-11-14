Public Class TTCall

    Enum CallType
        LOCAL_CALL
        NAT_CALL
        ISD_CALL
        MOBILE_CALL
    End Enum

    'call description array
    Dim callID As Integer
    Dim thisCallType As CallType
    Dim duration As Integer
    Dim numberCalled As String
    ReadOnly Cost As Double
    Shared nextCallID As Integer = 1

    Public Sub New()

    End Sub

    Public Sub New(ByVal ct As CallType, ByVal c_duration As Integer, ByVal c_numberCalled As String)
        thisCallType = ct
        duration = c_duration
        numberCalled = c_numberCalled
        callID = nextCallID
        nextCallID += 1
        Cost = CalculateCost(thisCallType, duration)
    End Sub

    Public Shared Function CalculateCost(ByVal ct As CallType, ByVal duration As Integer) As Decimal
        Dim LOCAL_RATE = 0.001
        Dim NAT_RATE = 0.009
        Dim ISD_RATE = 0.015
        Dim MOBILE_RATE = 0.019
        Dim DEFAULT_RATE = MOBILE_RATE

        Select Case ct
            Case CallType.LOCAL_CALL
                Return (duration * LOCAL_RATE)
            Case CallType.NAT_CALL
                Return (duration * NAT_RATE)
            Case CallType.ISD_CALL
                Return (duration * ISD_RATE)
            Case CallType.MOBILE_CALL
                Return (duration * MOBILE_RATE)
        End Select
        Return (duration * DEFAULT_RATE)
    End Function

    Public Shared Function Format(ByVal seconds As Integer, ByVal pattern As Integer) As String
        Dim formattedTime As String

        If pattern = 0 Then
            formattedTime = String.Format("mm:ss", seconds)
        ElseIf pattern = 1 Then
            formattedTime = String.Format("{mm} minute(s) and {ss} second(s)", seconds)
        Else
            formattedTime = "null"
        End If

        Return formattedTime
    End Function

    Public Overrides Function ToString() As String

        Return ""
    End Function

#Region "Get Sets"
    Public Property GetSetCallID() As Integer
        Get
            Return callID
        End Get
        Set(value As Integer)
            callID = value
        End Set
    End Property

    Public Property GetSetCallType() As CallType
        Get
            Return thisCallType
        End Get
        Set(value As CallType)
            thisCallType = value
        End Set
    End Property

    Public Property GetSetDuration() As Integer
        Get
            Return duration
        End Get
        Set(value As Integer)
            duration = value
        End Set
    End Property

    Public Property GetSetNumberCalled() As String
        Get
            Return numberCalled
        End Get
        Set(value As String)
            numberCalled = value
        End Set
    End Property

    Public ReadOnly Property GetSetCost() As Double
        Get
            Return Cost
        End Get
    End Property
#End Region

End Class
