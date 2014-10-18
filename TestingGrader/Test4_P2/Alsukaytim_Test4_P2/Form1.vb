Public Class Form1

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        UserClosingForm(e)

    End Sub
    Private Sub btnData_Click(sender As System.Object, e As System.EventArgs) Handles btnData.Click
        For x = ListBox1.Items.Count - 1 To 0 Step -1
            If ListBox1.GetSelected(x) Then
                Me.Hide()
                frmData.Show()
                frmData.BringToFront()
            Else
                MsgBox("Select a user from the list please!")

            End If
        Next


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

        temp = (FormHeight - lblPassword.Height - txtPassword.Height - btnNew.Height - btnRemove.Height - btnRemoveAll.Height - btnData.Height - btnExit.Height - 8 * 4) / 3
        btnNew.Top = temp * 2 + lblPassword.Height + txtPassword.Height
        btnRemove.Top = temp * 2 + btnNew.Height + lblPassword.Height + txtPassword.Height + 8
        btnRemoveAll.Top = temp * 2 + btnNew.Height + btnRemove.Height + lblPassword.Height + txtPassword.Height + (8 * 2)
        btnData.Top = temp * 2 + btnNew.Height + btnRemove.Height + btnRemoveAll.Height + lblPassword.Height + txtPassword.Height + (8 * 3)
        btnExit.Top = temp * 2 + btnNew.Height + btnRemove.Height + btnRemoveAll.Height + btnData.Height + lblPassword.Height + txtPassword.Height + (8 * 4)
    End Sub

    Private Sub btnRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveAll.Click
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

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Dim name1, name2, sum As String

        If txtUser.Text = "" Or txtPassword.Text = "" Then
            Exit Sub
            txtUser.Focus()
        Else
            name1 = txtUser.Text + "    "
            name2 = txtPassword.Text

            sum = name1 + name2
            ListBox1.Items.Add(sum)

        End If


    End Sub

    Private Sub txtUser_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtUser.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Back)

            Case "0" To "9"
                'good
            Case "."
                Beep()
                e.Handled = True
                If InStr(txtUser.Text, ".") Then
                    Beep()
                    e.Handled = True
                End If

                If (e.KeyChar > "6" Or e.KeyChar < "0") Then
                    Beep()
                    e.Handled = True
                End If



        End Select
    End Sub
    Private Sub SortedToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SortedToolStripMenuItem.Click
        ListBox1.Sorted = True
    End Sub

    Private Sub NotSortedToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NotSortedToolStripMenuItem.Click
        ListBox1.Sorted = False

    End Sub

    Private Sub txtUser_Leave(sender As Object, e As System.EventArgs) Handles txtUser.Leave
        
    End Sub

    Public Function IsInteger(ByVal str As String) As Boolean
        If IsInteger(txtUser.Text) Or txtUser.Text.Length > 6 Then
            Return False
        Else
            Return True
        End If
    End Function

End Class
