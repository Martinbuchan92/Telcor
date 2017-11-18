Public Class FormEnterCalls
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Customer.FindCustomer(Telcor.customers, CmbCustomer.SelectedText, True)
        Dim newCall As New TTCall(CmbCallType.SelectedItem, NupDuration.Value, txtNumberCalled.Text)
        Dim index As Integer = CmbCustomer.SelectedIndex
        Telcor.customers(index).TelcorCall.Add(newCall)
        Telcor.customers(index).CustCallCount += 1
        BtnClear.PerformClick()
    End Sub

    Private Sub FormEnterCalls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each person In Telcor.customers
            CmbCustomer.Items.Add(person.CustName)
        Next

        CmbCallType.DataSource = [Enum].GetValues(GetType(TTCall.CallType))

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        CmbCustomer.SelectedIndex = -1
        CmbCallType.SelectedIndex = -1
        NupDuration.Value = 0
        txtNumberCalled.Clear()

    End Sub

End Class