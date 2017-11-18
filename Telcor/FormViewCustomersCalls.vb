Public Class FormViewCustomersCalls
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub CmbSelectOption_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSelectOption.SelectedIndexChanged
        If CmbSelectOption.SelectedIndex = 0 Then

            Dim Test As String = Customer.Format(customers, True, True)
            RichTextBox1.Text = Test

        ElseIf CmbSelectOption.SelectedIndex = 4 Then
            For Each person In customers
                RichTextBox1.Text += person.ToString
                RichTextBox1.Text += Environment.NewLine
                For Each phonecall In person.TelcorCall
                    RichTextBox1.Text = phonecall.ToString
                    RichTextBox1.Text += Environment.NewLine

                Next
            Next

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