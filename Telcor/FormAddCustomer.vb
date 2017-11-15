﻿Public Class FormAddCustomer
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtName.TextLength > 0 And txtPhoneNumber.TextLength > 0 Then
            Dim customer As New Customer(txtPhoneNumber.Text, txtName.Text)
            FormTelcorMenu.customers.Add(customer)
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