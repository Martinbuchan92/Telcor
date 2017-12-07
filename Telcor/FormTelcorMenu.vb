Imports System.IO
''' <summary>
''' Form holding the main menu for navigating the system
''' </summary>
Public Class FormTelcorMenu

    ''' <summary>
    ''' Calls a function to load data from a text file.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LoadFileDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadFileDataToolStripMenuItem.Click
        Telcor.LoadFileData()
        ToolStripStatusLabel1.Text = "File Loaded successfully"
    End Sub

    ''' <summary>
    ''' Shows the Form to add new customers
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AddCustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCustomersToolStripMenuItem.Click
        FormAddCustomer.Show()
    End Sub

    ''' <summary>
    ''' Shows the form for displaying and sorting customers
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DisplayCustomersAndSortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayCustomersAndSortToolStripMenuItem.Click
        FormDisplayAndSort.Show()
    End Sub

    ''' <summary>
    ''' Shows the form for adding a new call to the system
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EnterCallsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterCallsToolStripMenuItem.Click
        FormEnterCalls.Show()
    End Sub

    ''' <summary>
    ''' Shows the form that displays customers calls
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ViewCustomersCallsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCustomersCallsToolStripMenuItem.Click
        FormViewCustomersCalls.Show()
    End Sub

    ''' <summary>
    ''' Shows the form that allows call costs to be calculated
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CalculateCallCostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateCallCostToolStripMenuItem.Click
        FormCallCost.Show()
    End Sub

    ''' <summary>
    ''' Calls the function that saves the data from customer and calls to a txt file 0 being customers and 1 being calls
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SaveFileDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveFileDataToolStripMenuItem.Click
        Telcor.SaveFileData(0)
        Telcor.SaveFileData(1)
        ToolStripStatusLabel1.Text = "Data saved to file successfully"
    End Sub

    ''' <summary>
    ''' Shows the About window
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        FormAbout.Show()
    End Sub

    ''' <summary>
    ''' Closes the main menu form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If (Telcor.GetCustomerList.Count > 0) Then
            Telcor.SaveFileData(0)
            Telcor.SaveFileData(1)
        End If
        Me.Close()
    End Sub
End Class
