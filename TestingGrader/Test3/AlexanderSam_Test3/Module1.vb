Module Module1
    Friend frmSqrt As New Form1()
    Friend frmBack As New Form2()

    Sub main()
        frmSqrt = New Form1
        frmBack = New Form2

        Application.Run(frmSqrt)
    End Sub
End Module
