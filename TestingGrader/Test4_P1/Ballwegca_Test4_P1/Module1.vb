Module Module1

    Friend frmUsers As Form1
    Friend frmData As Form2


    Sub main()
        frmUsers = New Form1
        frmData = New Form2

        Application.Run(frmUsers)

    End Sub

End Module
