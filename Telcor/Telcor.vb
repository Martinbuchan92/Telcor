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
        ShowMenu()
    End Sub

    ''' <summary>
    ''' Loads the main menu as a dialog box
    ''' </summary>
    Sub ShowMenu()
        FormTelcorMenu.ShowDialog()
    End Sub

    ''' <summary>
    ''' Loads the customer information into an arraylist so it can be manipulated.
    ''' </summary>
    Sub LoadFileData()
        If customers.Count > 0 Then
            customers.Clear()
        End If

        Dim cf As String
        Dim dir As String


        cf = "customers.txt"
        dir = Application.StartupPath & "\" & cf

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
        Catch e As FileNotFoundException
            dir = OpenFile()
        End Try

    End Sub

    ''' <summary>
    ''' calls an open file dialog to allow the selecting of an input data file in case the default customer.txt can not be found
    ''' </summary>
    ''' <returns>Path of input file location</returns>
    Function OpenFile() As String
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String = ""

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        fd.Filter = "txt files (*.txt)|*.txt"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            Return strFileName = fd.FileName
        End If

        Return strFileName
    End Function

    ''' <summary>
    ''' Save the data input by the user in the program that is stored in the Customer and Calls arrayLists to txt file as CSV
    ''' </summary>
    ''' <param name="type">Determines if the data being saved is customer or calls with 0 being customer and 1 being calls</param>
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