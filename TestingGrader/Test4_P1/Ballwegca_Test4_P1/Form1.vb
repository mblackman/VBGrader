Public Class Form1

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.ApplicationExitCall Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnData_Click(sender As System.Object, e As System.EventArgs) Handles btnData.Click
        Me.Hide()
        frmData.Show()
        frmData.BringToFront()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Dim FormWidth As Integer
        Dim FormHeight As Integer
        Dim temp As Integer

        FormWidth = Me.ClientSize.Width
        FormHeight = Me.ClientSize.Height

        temp = (FormWidth - lblUser.Width - lblPassword.Width) / 3
        lblUser.Left = temp + 20
        txtUser.Left = temp
        lblPassword.Left = lblPassword.Width + temp + 120
        txtPassword.Left = txtUser.Width + temp + 50

        temp = (FormWidth - ListBox1.Width - btnNew.Width) / 3
        ListBox1.Left = temp
        btnNew.Left = temp + ListBox1.Width + ListBox1.Left * (3 / 2)
        btnRemove.Left = temp + ListBox1.Width + ListBox1.Left * (3 / 2)
        btnRemoveAll.Left = temp + ListBox1.Width + ListBox1.Left * (3 / 2)
        btnData.Left = temp + ListBox1.Width + ListBox1.Left * (3 / 2)
        btnExit.Left = temp + ListBox1.Width + ListBox1.Left * (3 / 2)

        temp = (FormHeight - lblUser.Height - txtUser.Height - ListBox1.Height) / 4
        lblUser.Top = temp
        txtUser.Top = temp + lblUser.Height + 4
        ListBox1.Top = temp + 8 + lblUser.Height + txtUser.Height + txtUser.Top * (1 / 2)
        lblPassword.Top = temp
        txtPassword.Top = temp + lblPassword.Height + 4

        btnNew.Top = temp + 8 + lblUser.Height + txtUser.Height + txtUser.Top * (1 / 2)
        btnRemove.Top = btnNew.Height + temp + 16 + lblUser.Height + txtUser.Height + txtUser.Top * (1 / 2)
        btnRemoveAll.Top = 2 * btnNew.Height + temp + 24 + lblUser.Height + txtUser.Height + txtUser.Top * (1 / 2)
        btnData.Top = 3 * btnNew.Height + temp + 32 + lblUser.Height + txtUser.Height + txtUser.Top * (1 / 2)
        btnExit.Top = 4 * btnNew.Height + temp + 40 + lblUser.Height + txtUser.Height + txtUser.Top * (1 / 2)

    End Sub
End Class
