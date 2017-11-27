''' <summary>
''' Allows the user to enter call information for existing customers
''' </summary>
Public Class FormEnterCalls
    ''' <summary>
    ''' Saves the entered information into the TelcorCall field of the selected customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Customer.FindCustomer(Telcor.customers, CmbCustomer.SelectedText, True)
        Dim newCall As New TTCall(CmbCallType.SelectedItem, NupDuration.Value, txtNumberCalled.Text)
        Dim index As Integer = CmbCustomer.SelectedIndex
        Telcor.customers(index).TelcorCall.Add(newCall)
        Telcor.customers(index).CustCallCount += 1
        BtnClear.PerformClick()
    End Sub

    ''' <summary>
    ''' Populates the Call Type and Customer comboboxes on load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FormEnterCalls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each person In Telcor.customers
            CmbCustomer.Items.Add(person.CustName)
        Next

        CmbCallType.DataSource = [Enum].GetValues(GetType(TTCall.CallType))

    End Sub

    ''' <summary>
    ''' Closes the window
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Clears the current input data without saving.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        CmbCustomer.SelectedIndex = -1
        CmbCallType.SelectedIndex = -1
        NupDuration.Value = 0
        txtNumberCalled.Clear()
    End Sub
End Class