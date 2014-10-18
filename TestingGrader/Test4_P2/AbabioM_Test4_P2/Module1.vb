Module Module1
    Friend Const FIXED_SPACE_BETWEEN = 8
    Friend Const SPACE_BETWEEN_TEXTBOXES = 50
    Friend frmUsers As Form1
    Friend frmData As Form2

    Friend Sub UserClosingForm(ByVal e As System.Windows.Forms.FormClosingEventArgs)
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
        End If
    End Sub

    Sub Main()
        frmUsers = New Form1
        frmData = New Form2
        Application.Run(frmUsers)
    End Sub
End Module
