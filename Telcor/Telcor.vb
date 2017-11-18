Imports System.IO

Module Telcor
    Public customers As New List(Of Customer)

    Sub Main()
        Application.Run(FormTelcorMenu)
    End Sub

    Sub LoadFileData()
        'Read Customers file.  If not found, display prompt to load data from a function within application
        If customers.Count > 0 Then
            customers.Clear()
        End If

        Dim cf As String
        Dim dir As String

        cf = "customers.txt"
        dir = Application.StartupPath & "\" & cf

        Dim textIn As New StreamReader(
            New FileStream(
           dir, FileMode.OpenOrCreate, FileAccess.Read))

        Do While textIn.Peek <> -1
            Dim row As String = textIn.ReadLine
            Dim columns() As String = row.Split(", ")
            columns(1) = columns(1).Replace(" '", "")
            columns(1) = columns(1).Replace("'", "")
            Dim customer As New Customer(columns(0), columns(1))
            customers.Add(customer)
        Loop

        textIn.Close()
    End Sub

    Sub SaveFileData(type As Integer)
        Try
            Dim cf As String
            Dim dir As String

            If type = 0 Then
                cf = "customers.txt"
            Else
                cf = "calls.txt"
            End If

            dir = Application.StartupPath & "\" & cf
            File.Delete(dir)
            Dim textOut As New StreamWriter(
                New FileStream(dir, FileMode.Create, FileAccess.Write))

            For Each person In customers
                If type = 0 Then
                    textOut.WriteLine(person.ToString)
                Else
                    For Each phonecall In person.TelcorCall
                        textOut.WriteLine(phonecall.ToString)
                    Next
                End If
            Next

            textOut.Close()
        Catch ex As IOException
        End Try
    End Sub

End Module