Public Class FormAbout
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/link-to-an-object-or-web-page-with-wf-linklabel-control
        Try
            VisitLink()
        Catch ex As Exception
            ' The error message  
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub

    Sub VisitLink()
        LinkLabel1.LinkVisited = True
        System.Diagnostics.Process.Start("https://www.flaticon.com/authors/smashicons")
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class