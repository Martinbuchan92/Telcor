﻿''' <summary>
''' Form for viewing which calls a customer has made
''' </summary>
Public Class FormViewCustomersCalls

    ''' <summary>
    ''' Handles button click event for the close button.  Closes the Form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Combobox driver for selecting which details to display
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CmbSelectOption_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSelectOption.SelectedIndexChanged
        Dim results As String
        RtbResultsBox.Text = ""
        'List All
        TxtSearchBox.Enabled = False
        RbName.Enabled = False
        RbNumber.Enabled = False
        BtnSearch.Enabled = False
        If CmbSelectOption.SelectedIndex = 0 Then
            results = Customer.Format(Telcor.GetCustomerList, True, True)
            RtbResultsBox.Text += results

            'List all with call details
        ElseIf CmbSelectOption.SelectedIndex = 1 Then
            results = Customer.Format(Telcor.GetCustomerList, True, False)
            RtbResultsBox.Text = results

            'List all not contacted
        ElseIf CmbSelectOption.SelectedIndex = 2 Then
            results = Customer.Format(Telcor.GetCustomerList, False, True)
            RtbResultsBox.Text = results

            'List all contacted
        ElseIf CmbSelectOption.SelectedIndex = 3 Then
            results = Customer.Format(Telcor.GetCustomerList, False, False)
            RtbResultsBox.Text = results

            'Search
        ElseIf CmbSelectOption.SelectedIndex = 4 Then
            TxtSearchBox.Enabled = True
            RbName.Enabled = True
            RbNumber.Enabled = True
            BtnSearch.Enabled = True
        Else

        End If

    End Sub

    ''' <summary>
    ''' Buttons for driving the search bar, searching based on number of name.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If RbName.Checked Then
            RtbResultsBox.Text = Customer.FindCustomer(Telcor.GetCustomerList, TxtSearchBox.Text, True)
        Else
            RtbResultsBox.Text = Customer.FindCustomer(Telcor.GetCustomerList, TxtSearchBox.Text, False)
        End If
    End Sub
End Class