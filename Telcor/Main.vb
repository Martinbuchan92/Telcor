Module Main
    Sub Main()
        MsgBox("The Main procedure is starting the application.")

        'Test the CalculateCost method
        'MsgBox(TTCall.CalculateCost(TTCall.CallType.MOBILE_CALL, 1000))

        'Test the format function
        MsgBox(TTCall.Format(80, 1))

        Application.Run(FormTelcorMenu)

        MsgBox("The application is terminating.")
    End Sub
End Module