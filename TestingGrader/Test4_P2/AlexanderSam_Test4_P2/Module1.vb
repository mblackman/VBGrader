Module Module1
    Friend frmUsers As Form1
    Friend frmData As Form2
    Friend smSpace As Integer = 8
    Friend lrgSapce As Integer = 50
    Friend small As Integer = 2
    Friend large As Integer = 5
    Friend user As String
    Friend password As String




    Sub main()
        frmUsers = New Form1
        frmData = New Form2

        Application.Run(frmUsers)

    End Sub

End Module
