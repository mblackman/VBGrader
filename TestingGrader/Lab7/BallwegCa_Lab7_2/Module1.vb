Module Module1

   Friend frmGrid As Form1
   Friend frmIndividual As Form2

   Sub main()
      frmGrid = New Form1
      frmIndividual = New Form2

      Application.Run(frmGrid)

    End Sub


    Friend Sub UserClosingForm(ByVal e As System.Windows.Forms.FormClosingEventArgs)
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
        End If
    End Sub

End Module
