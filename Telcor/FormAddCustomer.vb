''' <summary>
''' Form to allow adding new customers to the system
''' </summary>
Public Class FormAddCustomer
    ''' <summary>
    ''' Takes the information from the user inputs and creates a new customer object
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If txtName.TextLength > 0 And txtPhoneNumber.TextLength > 0 Then
            Dim number = txtPhoneNumber.Text
            Dim custName = "'" + txtName.Text + "'"

            Dim customer As New Customer(number, custName)
            Telcor.customers.Add(customer)
        End If
        BtnClear.PerformClick()
    End Sub

    ''' <summary>
    ''' Clears the fields without saving
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        txtName.Clear()
        txtPhoneNumber.Clear()
    End Sub

    ''' <summary>
    ''' Closes the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class