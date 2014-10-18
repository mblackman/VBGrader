Public Class Form1

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        UserClosingForm(e)


    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnData_Click(sender As System.Object, e As System.EventArgs) Handles btnData.Click
        Me.Hide()
        frmData.Show()
        frmData.BringToFront()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Dim FormWidth As Integer
        Dim FormHeight As Integer
        Dim temp As Integer

        FormWidth = Me.ClientSize.Width
        FormHeight = Me.ClientSize.Height

        temp = (FormWidth - ListBox1.Width - btnNew.Width) / 2
        ListBox1.Left = temp
        btnNew.Left = temp + ListBox1.Width + (temp / 2)
        btnRemove.Left = temp + ListBox1.Width + (temp / 2)
        btnRemoveAll.Left = temp + ListBox1.Width + (temp / 2)
        btnData.Left = temp + ListBox1.Width + (temp / 2)
        btnExit.Left = temp + ListBox1.Width + (temp / 2)

        temp = (FormWidth - lblUser.Width - lblPassword.Width - 100) / 2
        lblUser.Left = temp
        lblPassword.Left = temp + lblUser.Width + 100

        temp = (FormWidth - txtUser.Width - txtPassword.Width - 50) / 2
        txtUser.Left = temp
        txtPassword.Left = temp + txtUser.Width + 50

        temp = (FormHeight - lblUser.Height - txtUser.Height - ListBox1.Height) / 3
        lblUser.Top = temp
        txtUser.Top = temp + lblUser.Height
        ListBox1.Top = temp * 2 + lblUser.Height + txtUser.Height
        lblPassword.Top = temp
        txtPassword.Top = temp + lblUser.Height

        temp = (FormHeight - txtPassword.Height - lblPassword.Height - btnNew.Height - btnRemove.Height - btnRemoveAll.Height - btnData.Height - btnExit.Height - 8)
        btnNew.Top = temp
        btnRemove.Top = temp + btnNew.Height + 8
        btnRemoveAll.Top = temp + btnNew.Height + btnRemove.Height + 8
        btnData.Top = temp + btnNew.Height + btnRemove.Height + btnRemoveAll.Height + 8
        btnExit.Top = temp + btnNew.Height + btnRemove.Height + btnRemoveAll.Height + btnData.Height + 8



    End Sub
End Class
