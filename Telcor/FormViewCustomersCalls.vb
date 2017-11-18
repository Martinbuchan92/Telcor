Public Class FormViewCustomersCalls
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()

    End Sub

    Private Sub CmbSelectOption_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSelectOption.SelectedIndexChanged

        If CmbSelectOption.SelectedIndex = 4 Then
            TxtSearchBox.Enabled = True
            RbName.Enabled = True
            RbNumber.Enabled = True
        Else
            TxtSearchBox.Enabled = False
            RbName.Enabled = False
            RbNumber.Enabled = False
        End If

    End Sub
End Class