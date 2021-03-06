﻿''' <summary>
''' Allows the user to enter call information for existing customers
''' </summary>
Public Class FormEnterCalls
    ''' <summary>
    ''' Saves the entered information into the TelcorCall field of the selected customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Customer.FindCustomer(Telcor.GetCustomerList, CmbCustomer.SelectedText, True)
        If IsNumeric(txtNumberCalled.Text) Then
            MsgBox(CmbCallType.SelectedItem.ToString)
            Dim newCall As New TTCall(CmbCallType.SelectedItem, NupDuration.Value, txtNumberCalled.Text)
            Dim index As Integer = CmbCustomer.SelectedIndex
            Telcor.GetCustomerList(index).TelcorCall.Add(newCall)
            Telcor.GetCustomerList(index).CustCallCount += 1
            BtnClear.PerformClick()
        Else
            MsgBox("Please enter a valid phone number without spaces")
        End If
    End Sub

    ''' <summary>
    ''' Populates the Call Type and Customer comboboxes on load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FormEnterCalls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each person In Telcor.GetCustomerList
            CmbCustomer.Items.Add(person.CustName)
        Next

        If CmbCustomer.Items.Count <= 0 Then
            CmbCustomer.Items.Add("Please Load customers")
            BtnSave.Enabled = False
        End If
        CmbCustomer.SelectedIndex = 0

        CmbCallType.DataSource = [Enum].GetValues(GetType(TTCall._CallType))

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
        CmbCustomer.SelectedIndex = 0
        CmbCallType.SelectedIndex = 0
        NupDuration.Value = 0
        txtNumberCalled.Clear()
    End Sub
End Class