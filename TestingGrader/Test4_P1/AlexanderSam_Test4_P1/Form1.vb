'----------------------------------------------
' Name       : Sammy Alexander
' Course     : CS2340, Section 1, Fall 2012
' Description: Test 4I
'              Form frmUsers
'----------------------------------------------
Public Class Form1

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnData_Click(sender As System.Object, e As System.EventArgs) Handles btnData.Click
        Me.Hide()
        Form2.Show()
        Form2.BringToFront()

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Dim formwidth As Integer
        Dim formheight As Integer
        Dim temp As Integer
        formheight = Me.ClientSize.Height
        formwidth = Me.ClientSize.Width
        'resize height
        temp = (formheight - txtPassword.Height - lblPassword.Height - ListBox1.Height) / 3
        lblPassword.Top = temp
        lblUser.Top = temp
        txtPassword.Top = lblPassword.Bottom
        txtUser.Top = lblUser.Bottom
        ListBox1.Top = txtUser.Bottom + temp
        btnNew.Top = ListBox1.Top
        btnRemove.Top = btnNew.Bottom + smSpace
        btnRemoveAll.Top = btnRemove.Bottom + smSpace
        btnData.Top = btnRemoveAll.Bottom + smSpace
        btnExit.Top = btnData.Bottom + smSpace
        'resize width
        temp = (formwidth - ListBox1.Width - btnData.Width) * (small / large)
        ListBox1.Left = temp
        btnData.Left = ListBox1.Right + temp
        btnExit.Left = btnData.Left
        btnNew.Left = btnData.Left
        btnRemove.Left = btnData.Left
        btnRemoveAll.Left = btnData.Left
        temp = (formwidth - txtPassword.Width * small - lrgSapce) / small
        txtUser.Left = temp
        txtPassword.Left = txtUser.Right + lrgSapce
        lblPassword.Left = txtPassword.Right - txtPassword.Width / small - lblPassword.Width / small
        lblUser.Left = txtUser.Right - txtUser.Width / small - lblUser.Width / small

    End Sub
End Class
