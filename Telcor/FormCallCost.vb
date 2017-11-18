Public Class FormCallCost
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub FormCallCost_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbCallType.DataSource = [Enum].GetValues(GetType(TTCall.CallType))

    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click

        Dim cost As Decimal = TTCall.CalculateCost(CmbCallType.SelectedItem, Integer.Parse(TxtDuration.Text))

        Dim calculatedCost As String
        Dim duration As String = TTCall.Format(TxtDuration.Text, 1)
        Dim callType As String = CmbCallType.SelectedValue.ToString

        calculatedCost = String.Format("Call Duration [in seconds] : {0}" & vbCr &
            "Call Type : {1} " & vbCr &
            "A  {2}" & vbCr &
            "{3} costs {4}", TxtDuration.Text, callType, duration, callType, cost)

        RtbResponse.Text = calculatedCost
    End Sub
End Class