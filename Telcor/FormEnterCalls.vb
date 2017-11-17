Public Class FormEnterCalls
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        'CmbCustomer.SelectedItem

        BtnClear.PerformClick()

    End Sub

    Private Sub FormEnterCalls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each person In Telcor.customers
            CmbCustomer.Items.Add(person.CustName)
        Next

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class