Public Class FormDisplayAndSort
    Private Sub btnSortName_Click(sender As Object, e As EventArgs) Handles btnSortName.Click
        For Each person In Telcor.customers
            ListBox1.Items.Add(person)
        Next
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class