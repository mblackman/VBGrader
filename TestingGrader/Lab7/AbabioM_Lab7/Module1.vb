﻿Module Module1
   Friend frmGrid As Form1
   Friend frmIndividual As Form2

   Friend Sub UserClosingForm(ByVal e As System.Windows.Forms.FormClosingEventArgs)
      If e.CloseReason = CloseReason.UserClosing Then
         e.Cancel = True
      End If
   End Sub

   Sub Main()
      frmGrid = New Form1
      frmIndividual = New Form2
      Application.Run(frmGrid)
   End Sub
End Module
