Imports System.IO

Module Telcor
    Public customers As New List(Of Customer)

    Sub Main()

        Application.Run(FormTelcorMenu)

    End Sub

    Sub showMenu()

    End Sub

    Sub loadFileData()
        'Read Customers file.  If not found, display prompt to load data from a function within application

        Try
            Dim cf As String
            Dim dir As String

            cf = "customers.txt"
            dir = Application.StartupPath & "\" & cf

            Dim textIn As New StreamReader(
            New FileStream(
           dir, FileMode.OpenOrCreate, FileAccess.Read))

            'change to constructor
            Do While textIn.Peek <> -1
                Dim row As String = textIn.ReadLine
                Dim columns() As String = row.Split(CChar(","))
                Dim customer As New Customer With {
                .CustCallerID = columns(0),
                .CustName = columns(1)
            }
                customers.Add(customer)
            Loop
            textIn.Close()
        Catch ex As IOException
        End Try

    End Sub
End Module