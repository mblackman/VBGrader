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
        If ListBox1.SelectedIndex < 1 Then
            MessageBox.Show("Select a user from teh list please!", "AlexanderSam_Lab6", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
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

    Private Sub txtUser_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtUser.KeyPress
        If txtUser.TextLength > 6 Then
            Beep()
            e.Handled = True

        End If
        Select Case e.KeyChar
            Case Chr(Keys.Back)
            Case Chr(Keys.A) To Chr(Keys.Z)

            Case "0" To "9"
                'If InStr(txtUser.Text, 1) = IsNumeric() Then

                ' End If
            Case Else
                Beep()
                e.Handled = True

        End Select

    End Sub

    Private Sub txtUser_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If txtPassword.TextLength > 8 Then
            Beep()
            e.Handled = True

        End If
        Select Case e.KeyChar
            Case Chr(Keys.Back)
            Case Chr(Keys.A) To Chr(Keys.Z)
            Case "0" To "9"
            Case Else
                Beep()
                e.Handled = True

        End Select
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        If Not txtPassword.Text = "" And Not txtUser.Text = "" Then
            ListBox1.Items.Add(txtUser.Text.PadLeft(6) & "".PadLeft(4) & txtPassword.Text.PadRight(8))

        End If
    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        For x = ListBox1.Items.Count - 1 To 0 Step -1
            If ListBox1.GetSelected(x) Then
                ListBox1.Items.RemoveAt(x)
            End If
        Next
    End Sub

    Private Sub btnRemoveAll_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveAll.Click
        For x = ListBox1.Items.Count - 1 To 0 Step -1

            ListBox1.Items.RemoveAt(x)

        Next
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        If e.Button <> Windows.Forms.MouseButtons.Right Then Return
        ContextMenuStrip1.Show(Me, e.Location)

    End Sub

    Private Sub SortedToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles SortedToolStripMenuItem.Click


    End Sub
End Class
