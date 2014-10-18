Public Class Form1
    Dim formWidth, FormHeight, temp, lbltemp, count As Integer

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        UserClosingForm(e)
    End Sub

    Private Sub btnData_Click(sender As System.Object, e As System.EventArgs) Handles btnData.Click
        count = 0
        For x = ListBox1.Items.Count - 1 To 0 Step -1
            If ListBox1.GetSelected(x) Then
                count = count + 1
            End If
        Next
        If count = 0 Then
            MessageBox.Show("Select a user from the list please!", "AbabioM_Test4_P2", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.Hide()
            Form2.Show()
            Form2.BringToFront()
        End If

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnRemoveAll_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveAll.Click
        For x = ListBox1.Items.Count - 1 To 0 Step -1
            ListBox1.Items.RemoveAt(x)
        Next
    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        For x = ListBox1.Items.Count - 1 To 0 Step -1
            If ListBox1.GetSelected(x) Then
                ListBox1.Items.RemoveAt(x)
            End If
        Next
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

        temp = ((formWidth - SPACE_BETWEEN_TEXTBOXES - txtUser.Width - txtUser.Width) / 2)
        lbltemp = ((txtUser.Width - lblUser.Width) / 2)
        txtUser.Left = temp
        txtPassword.Left = temp + txtUser.Width + SPACE_BETWEEN_TEXTBOXES
        lblUser.Left = temp + lbltemp
        lblPassword.Left = temp + txtUser.Width + SPACE_BETWEEN_TEXTBOXES + ((txtUser.Width - lblPassword.Width) / 2)

        temp = ((formWidth - ListBox1.Width - btnNew.Width) / 2.5)
        ListBox1.Left = temp
        btnNew.Left = temp * 2 + ListBox1.Width
        btnRemove.Left = temp * 2 + ListBox1.Width
        btnRemoveAll.Left = temp * 2 + ListBox1.Width
        btnData.Left = temp * 2 + ListBox1.Width
        btnExit.Left = temp * 2 + ListBox1.Width


    End Sub

    Private Sub txtUser_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtUser.KeyPress
        txtUser.MaxLength = 6
        Select Case e.KeyChar
            Case Chr(Keys.Back)
            Case "0" To "9"
                If txtUser.Text = "" Then
                    Beep()
                    e.Handled = True
                End If
            Case "."
                Beep()
                e.Handled = True
        End Select
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        txtPassword.MaxLength = 8
        Select Case e.KeyChar
            Case Chr(Keys.Back)
            Case "0" To "9"
                If txtPassword.Text = "" Then
                    Beep()
                    e.Handled = True
                End If
            Case "."
                Beep()
                e.Handled = True
        End Select
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Dim person As String
        If txtUser.Text = "" Then
        ElseIf txtPassword.Text = "" Then
        Else
            person = txtUser.Text + "    " + txtPassword.Text
            ListBox1.Items.Add(person)
        End If

    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As System.EventArgs) Handles ListBox1.DoubleClick
        For index As Integer = ListBox1.Items.Count - 1 To 0 Step -1
            If ListBox1.GetSelected(index) Then
                ListBox1.Items.RemoveAt(index)
            End If
        Next
    End Sub

    Private Sub SortedToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SortedToolStripMenuItem.Click
        ListBox1.Sorted = True
    End Sub

    Private Sub NotSortedToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NotSortedToolStripMenuItem.Click
        ListBox1.Sorted = False
    End Sub
End Class
