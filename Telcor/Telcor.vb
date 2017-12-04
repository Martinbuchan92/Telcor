Imports System.IO
''' <summary>
''' conducts IO for the program and holds the main method and customer data arraylist
''' </summary>
Module Telcor
    Public customers As New List(Of Customer)

    ''' <summary>
    ''' Separates from ShowMenu as per assignment specs
    ''' </summary>
    Sub Main()
        Try
            ShowMenu()
        Catch ex As Exception
            MsgBox("There was an unknown exception, restarting program")
            ShowMenu()
        End Try
    End Sub

    ''' <summary>
    ''' Loads the main menu as a dialog box
    ''' </summary>
    Sub ShowMenu()
        FormTelcorMenu.ShowDialog()
    End Sub

    ''' <summary>
    ''' Loads the customer information into an arraylist so it can be manipulated.
    ''' If the customer.txt file can not be found in the default folder the user is prompted to select one.
    ''' </summary>
    Sub LoadFileData()
        If customers.Count > 0 Then
            customers.Clear()
        End If

        Dim cf As String = "customers.txt"
        Dim dir As String = Application.StartupPath & "\" & cf

        Try
            Dim textIn As New StreamReader(
            New FileStream(
            dir, FileMode.Open, FileAccess.Read))

            Do While textIn.Peek <> -1
                Dim row As String = textIn.ReadLine
                Dim columns() As String = row.Split(", ")
                columns(1) = columns(1).Replace(" '", "")
                columns(1) = columns(1).Replace("'", "")
                Dim customer As New Customer(columns(0), columns(1))
                customers.Add(customer)
            Loop

            textIn.Close()
        Catch e As IndexOutOfRangeException
            MsgBox("Error loading File - Loading seed data", MessageBoxButtons.OK)
            Telcor.LoadTestData()
        Catch e As FileNotFoundException
            MsgBox("File not found - Loading seed data", MessageBoxButtons.OK)
            Telcor.LoadTestData()
        Catch e As IOException
            MsgBox("Error loading File - Loading seed data", MessageBoxButtons.OK)
            Telcor.LoadTestData()
        Finally

        End Try
    End Sub

    ''' <summary>
    ''' inserts seed data in case of errors
    ''' </summary>
    Sub LoadTestData()
        customers.Add(New Customer("0241 444 111", "Kara Thrace"))
        customers.Add(New Customer("0321 222 111", "Karl Agathon"))
        customers.Add(New Customer("0411 111 111", "Laura Roslin"))
        customers.Add(New Customer("0412 111 222", "William Adama"))
        customers.Add(New Customer("0414 111 444", "Sharon Valerii"))
        customers.Add(New Customer("0438 333 888", "Lee Adama"))
        customers.Add(New Customer("0457 555 777", "Saul Tigh"))
        customers.Add(New Customer("0478 777 888", "Sam Anders"))
    End Sub

    ''' <summary>
    ''' Save the data input by the user in the program that is stored in the Customer and Calls arrayLists to txt file as CSV
    ''' </summary>
    ''' <param name="type">Determines if the data being saved is customer or calls with 0 being customer and 1 being calls</param>
    Sub SaveFileData(type As Integer)

        Dim cf As String
        Dim dir As String

        If type = 0 Then
            cf = "customers.txt"
        Else
            cf = "calls.txt"
        End If

        Try
            dir = Application.StartupPath & "\" & cf
            If File.Exists(dir) Then
                File.Delete(dir)
            End If
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
        Catch
            '

        End Try

    End Sub

End Module