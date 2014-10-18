Public Class frmUsers

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnData_Click(sender As System.Object, e As System.EventArgs) Handles btnData.Click
        Dim x As Integer
        Dim Data(2) As String

        For x = 0 To lstUsers.SelectedItems.Count - 1 Step 1
            If lstUsers.GetSelected(x) Then
                Data(0) = lstUsers.Items.Item(x).ToString.Substring(0, 6).Trim
                Data(1) = lstUsers.Items.Item(x).ToString.Substring(10, 8).Trim
                Me.Hide()
                DataForm.Show()
                DataForm.BringToFront()
                DataForm.txtUser.Text = Data(0)
                DataForm.txtPassword.Text = Data(1)
                Exit Sub
            End If
        Next
        MessageBox.Show("Select a user from the list please!", "BeckerA_Test4_P2", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub txtUser_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtUser.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Back)
            Case "0" To "9"
                If txtUser.Text.Length = 0 Or Len(txtUser.Text) = 6 Then
                    Beep()
                    e.Handled = True
                End If
            Case "a" To "z"
                If Len(txtUser.Text) = 6 Then
                    Beep()
                    e.Handled = True
                End If
            Case "A" To "Z"
                If Len(txtUser.Text) = 6 Then
                    Beep()
                    e.Handled = True
                End If
            Case Else
                Beep()
                e.Handled = True
        End Select
    End Sub

    Private Sub txtPassword_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Back)
            Case "0" To "9"
                If Len(txtPassword.Text) = 8 Then
                    Beep()
                    e.Handled = True
                End If
            Case "a" To "z"
                If Len(txtPassword.Text) = 8 Then
                    Beep()
                    e.Handled = True
                End If
            Case "A" To "Z"
                If Len(txtPassword.Text) = 8 Then
                    Beep()
                    e.Handled = True
                End If
            Case Else
                Beep()
                e.Handled = True
        End Select
    End Sub

    Private Sub btnRemoveAll_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveAll.Click
        For x = lstUsers.Items.Count - 1 To 0 Step -1
            lstUsers.Items.RemoveAt(x)
        Next
    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        For x = lstUsers.Items.Count - 1 To 0 Step -1
            If lstUsers.GetSelected(x) Then
                lstUsers.Items.RemoveAt(x)
            End If
        Next
    End Sub

    Private Sub lstUsers_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles lstUsers.MouseDoubleClick
        Dim Index As Integer

        Index = lstUsers.IndexFromPoint(e.X, e.Y)
        lstUsers.Items.RemoveAt(Index)
    End Sub

    Private Sub SortedToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SortedToolStripMenuItem.Click
        lstUsers.Sorted = True
    End Sub

    Private Sub NotSortedToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NotSortedToolStripMenuItem.Click
        lstUsers.Sorted = False
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        If txtUser.Text.Trim = "" Or txtPassword.Text.Trim = "" Then
            Exit Sub
        End If
        lstUsers.Items.Add(txtUser.Text.Trim.PadRight(6) + "    " + txtPassword.Text.Trim.PadRight(8))
    End Sub
End Class
