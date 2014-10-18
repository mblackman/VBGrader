Public Class frmData

    Private Sub cxtMenuExit_Click(sender As System.Object, e As System.EventArgs) Handles cxtMenuExit.Click
        Application.Exit()
    End Sub

    Private Sub cxtMenuBack_Click(sender As System.Object, e As System.EventArgs) Handles cxtMenuBack.Click
        Me.Hide()
        UserForm.Show()
        UserForm.BringToFront()
    End Sub

    Private Sub frmData_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.ApplicationExitCall Then
            End
        Else
            e.Cancel = True
        End If
    End Sub
End Class