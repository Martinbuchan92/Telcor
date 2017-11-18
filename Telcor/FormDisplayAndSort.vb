Public Class FormDisplayAndSort

    Private Sub BtnSortName_Click(sender As Object, e As EventArgs) Handles BtnSortName.Click
        LbxResultSet.Items.Clear()

        Telcor.customers.Sort()
        For Each person In Telcor.customers
            LbxResultSet.Items.Add(person)
        Next
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSortNumber_Click(sender As Object, e As EventArgs) Handles BtnSortNumber.Click
        For Each person In Telcor.customers
            LbxResultSet.Items.Add(person)
        Next
    End Sub

    Private Sub FormDisplayAndSort_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class