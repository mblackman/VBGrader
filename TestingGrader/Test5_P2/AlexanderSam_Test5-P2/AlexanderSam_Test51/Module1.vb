Module Module1
   Friend frmClassAll As Form1
   Friend frmList As Form2
   Friend ofNum As Integer
   Friend Sub UserClosingForm(ByVal e As System.Windows.Forms.FormClosingEventArgs)
      If e.CloseReason = CloseReason.UserClosing Then
         e.Cancel = True
      End If
   End Sub

   Sub main()
      frmClassAll = New Form1
      frmList = New Form2

      Application.Run(frmClassAll)

   End Sub


End Module
