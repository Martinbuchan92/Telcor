''' <summary>
''' Form that allows the user to view and sort the list of customers by either name or phone number
''' </summary>
Public Class FormDisplayAndSort

    ''' <summary>
    ''' Sorts the customers alphabetically by name
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnSortName_Click(sender As Object, e As EventArgs) Handles BtnSortName.Click
        LbxResultSet.Items.Clear()

        customers.Sort(New SortCustomersName)
        For Each person In Telcor.customers
            LbxResultSet.Items.Add(person)
        Next
    End Sub

    ''' <summary>
    ''' Sorts the customers by number
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnSortNumber_Click(sender As Object, e As EventArgs) Handles BtnSortNumber.Click
        LbxResultSet.Items.Clear()

        customers.Sort(New SortCustomersCallerID)
        For Each person In Telcor.customers
            LbxResultSet.Items.Add(person)
        Next
    End Sub

    ''' <summary>
    ''' Closes the form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class