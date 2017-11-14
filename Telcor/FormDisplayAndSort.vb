Public Class FormDisplayAndSort
    Private Sub btnSortName_Click(sender As Object, e As EventArgs) Handles btnSortName.Click
        dgvTest.DataSource = FormTelcorMenu.customers
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class