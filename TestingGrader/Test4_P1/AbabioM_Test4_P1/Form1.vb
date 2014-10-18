Public Class Form1
    Dim formWidth, FormHeight, temp As Integer

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        UserClosingForm(e)
    End Sub

    Private Sub btnData_Click(sender As System.Object, e As System.EventArgs) Handles btnData.Click
        Me.Hide()
        Form2.Show()
        Form2.BringToFront()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnRemoveAll_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveAll.Click

    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click

    End Sub

    Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        FormWidth = Me.ClientSize.Width
        FormHeight = Me.ClientSize.Height

        temp = ((FormHeight - lblUser.Height - txtUser.Height - ListBox1.Height) / 3)
        lblUser.Top = temp
        lblPassword.Top = temp
        txtUser.Top = temp + lblUser.Height
        txtPassword.Top = temp + lblUser.Height
        ListBox1.Top = temp + lblUser.Height + txtUser.Height + temp
        btnNew.Top = ListBox1.Top
        btnRemove.Top = ListBox1.Top + btnRemove.Height + FIXED_SPACE_BETWEEN
        btnRemoveAll.Top = ListBox1.Top + (2 * btnRemove.Height) + (2 * FIXED_SPACE_BETWEEN)
        btnData.Top = ListBox1.Top + (3 * btnRemove.Height) + (3 * FIXED_SPACE_BETWEEN)
        btnExit.Top = ListBox1.Top + (4 * btnRemove.Height) + (4 * FIXED_SPACE_BETWEEN)

        temp = ((formWidth - ListBox1.Width - btnNew.Width) / 2.5)
    End Sub
End Class
