Module Module1

    Friend frmUser As Form1
    Friend frmData As Form2


    Friend Sub UserClosingForm(ByVal e As System.Windows.Forms.FormClosingEventArgs)

            e.Cancel = True
    End Sub

    Sub main()


        frmUser = New Form1
        frmData = New Form2

        Application.Run(frmUser)
        'Application.Run(frmPayment)

    End Sub

End Module
