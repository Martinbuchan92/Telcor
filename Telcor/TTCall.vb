﻿Imports System.ComponentModel

Public Class TTCall

    Enum CallType
        LOCAL_CALL
        NAT_CALL
        ISD_CALL
        MOBILE_CALL
        DEFAULT_CALL
    End Enum

    Dim callDescriptions() As String = {"Local Call", "National Call", "International Call", "Mobile Call", "Default Call"}

    Private ReadOnly callID As Integer
    Private thisCallType As CallType
    Private duration As Integer
    Private numberCalled As String
    Private ReadOnly Cost As Double
    Private Shared nextCallID As Integer = 1
    Const SHORT_TIME = 0
    Const LONG_Time = 1

    Public Sub New(ByVal ct As CallType, ByVal c_duration As Integer, ByVal c_numberCalled As String)
        thisCallType = ct
        duration = c_duration
        numberCalled = c_numberCalled
        callID = nextCallID ' get next call ID
        nextCallID += 1
        Cost = CalculateCost(thisCallType, duration)
    End Sub

    Public Shared Function CalculateCost(ByVal ct As CallType, ByVal duration As Integer) As Double
        'Make Constants
        Const LOCAL_RATE = 0.001
        Const NAT_RATE = 0.009
        Const ISD_RATE = 0.015
        Const MOBILE_RATE = 0.019
        Const DEFAULT_RATE = MOBILE_RATE
        Dim calcCost As Double

        Select Case ct
            Case CallType.LOCAL_CALL
                calcCost = (duration * LOCAL_RATE)
            Case CallType.NAT_CALL
                calcCost = (duration * NAT_RATE)
            Case CallType.ISD_CALL
                calcCost = (duration * ISD_RATE)
            Case CallType.MOBILE_CALL
                calcCost = (duration * MOBILE_RATE)
            Case Else
                calcCost = (duration * DEFAULT_RATE)
        End Select
        calcCost = Math.Round(calcCost, 2)
        Return calcCost
    End Function

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

    Public Overrides Function ToString() As String
        Dim objectData = String.Format("{0}, {1}, {2}, {3}", numberCalled, thisCallType, Format(duration, 0), (FormatCurrency(CDbl(Cost), 2)))
        Return objectData
    End Function

#Region "Get Sets"
    Public ReadOnly Property PropCallID() As Integer
        Get
            Return callID
        End Get

    End Property

    Public Property PropCallType() As CallType
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

    Public Property PropDuration() As Integer
        Get
            Return duration
        End Get
        Set(value As Integer)
            duration = value
        End Set
    End Property

    Public Property PropNumberCalled() As String
        Get
            Return numberCalled
        End Get
        Set(value As String)
            numberCalled = value
        End Set
    End Property

    Public ReadOnly Property PropCost() As Double
        Get
            Return Cost
        End Get
    End Property
#End Region

End Class