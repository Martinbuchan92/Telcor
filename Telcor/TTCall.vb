Public Class TTCall

    Enum CallType
        LOCAL_CALL
        NAT_CALL
        ISD_CALL
        MOBILE_CALL
        DEFAULT_CALL
    End Enum

    Dim callID As Integer
    Dim thisCallType As CallType
    Dim duration As Integer
    Dim numberCalled As String
    ReadOnly Cost As Double
    Shared nextCallID As Integer = 1

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
        Dim span As TimeSpan = TimeSpan.FromSeconds(seconds)
        Dim myTime As DateTime = New DateTime(span.Ticks)

        If pattern = 0 Then
            formattedTime = myTime.ToString(("mm:ss"))
        ElseIf pattern = 1 Then
            formattedTime = String.Format("{0} Minute(s) and {1} Second(s)", myTime.ToString("mm"), myTime.ToString("ss"))
        Else
            formattedTime = "null"
        End If

        Return formattedTime
    End Function

    Public Overrides Function ToString() As String
        Dim objectData = String.Format("{0}, {1}, {2}, {3}, {4}", numberCalled, thisCallType, Format(duration, 0), Cost)
        Return objectData
    End Function

#Region "Get Sets"
    Public ReadOnly Property GetSetCallID() As Integer
        Get
            Return callID
        End Get

    End Property

    Public Property GetSetCallType() As CallType
        Get
            Return thisCallType
        End Get
        Set(ByVal value As CallType)
            Dim ctArray As Array
            ctArray = System.Enum.GetValues(GetType(CallType))

            Dim item As CallType
            For Each item In ctArray
                If value = item Then
                    thisCallType = item
                Else
                    thisCallType = CallType.DEFAULT_CALL
                End If
            Next

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
