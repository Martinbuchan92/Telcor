Imports System.IO

Public Class FormTelcorMenu

    Private Sub LoadFileDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadFileDataToolStripMenuItem.Click
        Telcor.LoadFileData()
        ToolStripStatusLabel1.Text = "File Loaded successfully"
    End Sub

    Private Sub AddCustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCustomersToolStripMenuItem.Click
        FormAddCustomer.Show()
    End Sub

    Private Sub DisplayCustomersAndSortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayCustomersAndSortToolStripMenuItem.Click
        FormDisplayAndSort.Show()
    End Sub

    Private Sub EnterCallsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterCallsToolStripMenuItem.Click
        FormEnterCalls.Show()
    End Sub

    Private Sub ViewCustomersCallsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCustomersCallsToolStripMenuItem.Click
        FormViewCustomersCalls.Show()
    End Sub

    Private Sub CalculateCallCostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateCallCostToolStripMenuItem.Click
        FormCallCost.Show()
    End Sub

    Private Sub SaveFileDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveFileDataToolStripMenuItem.Click
        Telcor.SaveFileData(0)
        Telcor.SaveFileData(1)
        ToolStripStatusLabel1.Text = "Data saved to file successfully"
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        FormAbout.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
