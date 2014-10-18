Module Module1
    Friend UserForm As frmUsers
    Friend DataForm As frmData

    Sub main()
        UserForm = New frmUsers
        DataForm = New frmData

        Application.Run(UserForm)
    End Sub
End Module
