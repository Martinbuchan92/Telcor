''' <summary>
''' TTCall Class for creating call objects.
''' </summary>
Public Class TTCall
    '''
    Enum _CallType
        LOCAL_CALL
        NAT_CALL
        ISD_CALL
        MOBILE_CALL
        DEFAULT_CALL
    End Enum

    Dim callDescriptions() As String = {"Local Call", "National Call", "International Call", "Mobile Call", "Default Call"}

    Private ReadOnly _callID As Integer
    Private _thisCallType As CallType
    Private _duration As Integer
    Private _numberCalled As String
    Private ReadOnly _Cost As Double
    Private Shared _nextCallID As Integer = 1
    Const SHORT_TIME = 0
    Const LONG_Time = 1

    ''' <summary>
    ''' Constructor for new calls
    ''' </summary>
    ''' <param name="ct">Call Type as one of the CallType Enum</param>
    ''' <param name="c_duration">Duration of the call being documented to be used in other methods for calculations</param>
    ''' <param name="c_numberCalled">The phone number the customer called for documentation</param>
    Public Sub New(ByVal ct As CallType, ByVal c_duration As Integer, ByVal c_numberCalled As String)
        CallType = ct
        Duration = c_duration
        NumberCalled = c_numberCalled
        _callID = _nextCallID ' get next call ID
        _nextCallID += 1
        _Cost = CalculateCost(_thisCallType, _duration)
    End Sub

    ''' <summary>
    ''' Calculates the cost of calls given inputs.  Can be called independently of TTCall objects
    ''' </summary>
    ''' <param name="ct">Call Type as per the call type Enun to decide call rates</param>
    ''' <param name="duration">Duration of call to calculate cost</param>
    ''' <returns>Returns the calculated cost in a 2 decimal Double format for easy use as currency</returns>
    Public Shared Function CalculateCost(ByVal ct As CallType, ByVal duration As Integer) As Double
        Const LOCAL_RATE = 0.001
        Const NAT_RATE = 0.009
        Const ISD_RATE = 0.015
        Const MOBILE_RATE = 0.019
        Const DEFAULT_RATE = MOBILE_RATE
        Dim calcCost As Double

        Select Case ct
            Case _CallType.LOCAL_CALL
                calcCost = (duration * LOCAL_RATE)
            Case _CallType.NAT_CALL
                calcCost = (duration * NAT_RATE)
            Case _CallType.ISD_CALL
                calcCost = (duration * ISD_RATE)
            Case _CallType.MOBILE_CALL
                calcCost = (duration * MOBILE_RATE)
            Case Else
                calcCost = (duration * DEFAULT_RATE)
        End Select
        calcCost = Math.Round(calcCost, 2)
        Return calcCost
    End Function

    ''' <summary>
    ''' Allows the call duration to be displayed in short or long form Strings
    ''' </summary>
    ''' <param name="seconds">Length of the call in seconds</param>
    ''' <param name="pattern">Short or Long form string for the call length to be converted to.  0 for short and 1 for long.</param>
    ''' <returns>Returns the requested formatted time as a String</returns>
    Public Shared Function Format(ByVal seconds As Integer, ByVal pattern As Integer) As String
        Dim formattedTime As String
        Dim span As TimeSpan = TimeSpan.FromSeconds(seconds)
        Dim myTime As DateTime = New DateTime(span.Ticks)

        If pattern = SHORT_TIME Then
            formattedTime = myTime.ToString(("mm:ss"))
        ElseIf pattern = LONG_Time Then
            formattedTime = String.Format("{0} Minute(s) and {1} Second(s)", myTime.ToString("mm"), myTime.ToString("ss"))
        Else
            formattedTime = "null"
        End If

        Return formattedTime
    End Function

    ''' <summary>
    ''' Allows the call to be printed in full for easy display and export.
    ''' </summary>
    ''' <returns>The Call instance data as a string</returns>
    Public Overrides Function ToString() As String
        Dim objectData = String.Format("{0}, {1}, {2}, {3}", _numberCalled, _thisCallType, Format(_duration, 0), (FormatCurrency(CDbl(_Cost), 2)))
        Return objectData
    End Function

#Region "properties"
    Public ReadOnly Property CallID() As Integer
        Get
            Return _callID
        End Get

    End Property

    Public Property CallType() As CallType
        Get
            Return _thisCallType
        End Get
        Set(ByVal value As CallType)
            Dim ctArray As Array
            ctArray = System.Enum.GetValues(GetType(CallType))

            Dim item As CallType
            For Each item In ctArray
                If value = item Then
                    _thisCallType = item
                Else
                    _thisCallType = _CallType.DEFAULT_CALL
                End If
            Next

        End Set
    End Property

    Public Property Duration() As Integer
        Get
            Return _duration
        End Get
        Set(value As Integer)
            If value >= 0 Then
                _duration = value
            Else
                _duration = 0
            End If

        End Set
    End Property

    Public Property NumberCalled() As String
        Get
            Return _numberCalled
        End Get
        Set(value As String)
            _numberCalled = value
        End Set
    End Property

    Public ReadOnly Property Cost() As Double
        Get
            Return _Cost
        End Get
    End Property
#End Region

End Class