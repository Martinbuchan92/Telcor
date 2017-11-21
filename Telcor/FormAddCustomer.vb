Public Class FormAddCustomer
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If txtName.TextLength > 0 And txtPhoneNumber.TextLength > 0 Then
            Dim number = txtPhoneNumber.Text
            Dim custName = "'" + txtName.Text + "'"

            Dim customer As New Customer(number, custName)
            Telcor.customers.Add(customer)
        End If
        BtnClear.PerformClick()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        txtName.Clear()
        txtPhoneNumber.Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub MaskedTextBox1_Click(sender As Object, e As EventArgs) Handles MaskedTextBox1.Click
        MaskedTextBox1.Select(0, 0)
    End Sub
End Class