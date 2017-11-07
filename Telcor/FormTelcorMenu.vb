Imports System.IO

Public Class FormTelcorMenu
    Private Sub LoadFileDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadFileDataToolStripMenuItem.Click
        'Read Customers file.  If not found, display prompt to load data from a function within application

        'surround with exceptions
        Dim fileReader As System.IO.StreamReader
        fileReader =
        My.Computer.FileSystem.OpenTextFileReader("customers.txt")
        Dim stringReader As String
        stringReader = fileReader.ReadLine()
        MsgBox("The first line of the file is " & stringReader)


    End Sub

    Private Sub AddCustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCustomersToolStripMenuItem.Click
        'Show form that allows entry of customers details and add the new customer to the customer list.
        'Allows continuous entry of new customers. a New button that clears controls for next customer and close button to return to main menu.
    End Sub

    Private Sub DisplayCustomersAndSortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayCustomersAndSortToolStripMenuItem.Click
        'Display a form that will prompt the user for sorting of customers by name or phone number.  Allow for repeated sorts.
        'Will need to implement one or more interfaces.
    End Sub

    Private Sub EnterCallsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterCallsToolStripMenuItem.Click
        'Display form that allows entry of one or more calls for a Customer.  Add controls to select a customer (print list into a combo)
        'Allow for the continous entry of new calls. Each call entered by the user is to become a TTCall object in a list of TTCall objets
        'in the customer class.
    End Sub

    Private Sub ViewCustomersCallsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCustomersCallsToolStripMenuItem.Click
        'Display Form that allows further choices as shown in spec.
    End Sub

    Private Sub CalculateCallCostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateCallCostToolStripMenuItem.Click
        'Display form to enter duration of a call in seconds and the call type.  After validating that the duration is numeric, use the calculate Cost
        'Method of the TTCall class and display a user-friendly summary of the call and the cost with formatting.  See Spec.
    End Sub

    Private Sub SaveFileDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveFileDataToolStripMenuItem.Click
        'Save current customer details to the customers text file, orverwriting previous contents.  Write calls to another text file called calls.txt
    End Sub
End Class
