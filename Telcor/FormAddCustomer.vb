Public Class FormAddCustomer
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtName.TextLength > 0 And txtPhoneNumber.TextLength > 0 Then
            Dim number = txtPhoneNumber.Text
            Dim custName = " '" + txtName.Text + "'"

            Dim customer As New Customer(number, custName)
            Telcor.customers.Add(customer)
        End If
        btnClear.PerformClick()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtPhoneNumber.Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class