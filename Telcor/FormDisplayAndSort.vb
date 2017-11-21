Public Class FormDisplayAndSort

    Private Sub BtnSortName_Click(sender As Object, e As EventArgs) Handles BtnSortName.Click
        LbxResultSet.Items.Clear()

        customers.Sort(New SortCustomersName)
        For Each person In Telcor.customers
            LbxResultSet.Items.Add(person)
        Next
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSortNumber_Click(sender As Object, e As EventArgs) Handles BtnSortNumber.Click
        LbxResultSet.Items.Clear()

        customers.Sort(New SortCustomersCallerID)
        For Each person In Telcor.customers
            LbxResultSet.Items.Add(person)
        Next
    End Sub
End Class