Public Class frmUsers

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnData_Click(sender As System.Object, e As System.EventArgs) Handles btnData.Click
        Me.Hide()
        DataForm.Show()
        DataForm.BringToFront()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub frmUsers_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.ApplicationExitCall Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub frmUsers_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        Dim x As Integer
        Dim FormWidth As Integer = Me.ClientSize.Width
        Dim FormHeight As Integer = Me.ClientSize.Height

        'Position the .top property of each element
        x = (FormHeight - lblUser.Height - txtUser.Height - lstUsers.Height) / 3

        lblUser.Top = x
        lblPassword.Top = x

        txtUser.Top = lblUser.Top + lblUser.Height
        txtPassword.Top = lblPassword.Top + lblPassword.Height

        lstUsers.Top = txtUser.Top + txtUser.Height + x

        btnNew.Top = lstUsers.Top
        btnRemove.Top = btnNew.Top + btnNew.Height + 8 'const
        btnRemoveAll.Top = btnRemove.Top + btnRemove.Height + 8
        btnData.Top = btnRemoveAll.Top + btnRemoveAll.Height + 8
        btnExit.Top = btnData.Top + btnData.Height + 8

        'Position the .left property of each element
        x = (FormWidth - lstUsers.Width - btnNew.Width) / 5
        lstUsers.Left = (2 * x)
        btnNew.Left = lstUsers.Left + lstUsers.Width + (2 * x)
        btnRemove.Left = btnNew.Left
        btnRemoveAll.Left = btnRemove.Left
        btnData.Left = btnRemoveAll.Left
        btnExit.Left = btnData.Left

        x = FormWidth / 2
        txtPassword.Left = x + 25
        txtUser.Left = x - 25 - txtUser.Width
        lblUser.Left = txtUser.Left + (txtUser.Width / 2) - (lblUser.Width / 2)
        lblPassword.Left = txtPassword.Left + (txtPassword.Width / 2) - (lblPassword.Width / 2)
    End Sub
End Class
