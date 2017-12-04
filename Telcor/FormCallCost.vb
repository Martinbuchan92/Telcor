''' <summary>
''' Allows the calculating of a phone calls cost
''' </summary>
Public Class FormCallCost

    ''' <summary>
    ''' Populates the call type combobox with the contents of the call type enum
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FormCallCost_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbCallType.DataSource = [Enum].GetValues(GetType(TTCall.CallType))
    End Sub

    ''' <summary>
    ''' Takes the users input information and displays the costs in a readable format
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        If IsNumeric(TxtDuration.Text) Then
            Dim calculatedCost As String
            Dim cost As Decimal = TTCall.CalculateCost(CmbCallType.SelectedItem, Integer.Parse(TxtDuration.Text))
            Dim callLength As Integer = CInt(TxtDuration.Text)
            Dim duration As String = TTCall.Format(callLength, 1)
            Dim callType As String = CmbCallType.SelectedValue.ToString

            calculatedCost = String.Format("Call Duration [in seconds] : {0}" & vbCr &
            "Call Type : {1} " & vbCr &
            "A  {2}" & vbCr &
            "{3} costs {4}", TxtDuration.Text, callType, duration, callType, cost)
            RtbResponse.Text = calculatedCost
        Else
            MsgBox("Please enter a number")
            TxtDuration.Focus()
        End If

    End Sub

    ''' <summary>
    ''' Clears all user inputs
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        CmbCallType.SelectedIndex = 0
        TxtDuration.Text = ""
        RtbResponse.Text = ""
    End Sub

    ''' <summary>
    ''' Closes the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class