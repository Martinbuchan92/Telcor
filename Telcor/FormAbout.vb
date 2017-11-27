''' <summary>
''' Shows information about the program
''' </summary>
Public Class FormAbout
    ''' <summary>
    ''' creates and handles clicking a link to an external website. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Code adapted from:
        'https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/link-to-an-object-or-web-page-with-wf-linklabel-control
        Try
            VisitLink()
        Catch ex As Exception
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub

    ''' <summary>
    ''' Opens the link in the default browser
    ''' </summary>
    Sub VisitLink()
        LinkLabel1.LinkVisited = True
        System.Diagnostics.Process.Start("https://www.flaticon.com/authors/smashicons")
    End Sub

    ''' <summary>
    ''' Closes the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class