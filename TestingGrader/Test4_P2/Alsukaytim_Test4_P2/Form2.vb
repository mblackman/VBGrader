Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Hide()
        frmUser.Show()
        frmUser.BringToFront()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Back)
                'good
            Case "0" To "9"
                Beep()
                e.Handled = True
            Case "."
                Beep()
                e.Handled = True
                If InStr(TextBox2.Text, ".") Then
                    Beep()
                    e.Handled = True
                End If
        End Select

    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Back)
                'good
            Case "0" To "9"
                'good
                If InStr(TextBox5.Text, ".") Then
                    Beep()
                    e.Handled = True
                End If
            Case Else
                Beep()
                e.Handled = True
        End Select
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Back)
                'good
            Case "0" To "9"
                Beep()
                e.Handled = True
            Case "."
                Beep()
                e.Handled = True
                If InStr(TextBox7.Text, ".") Then
                    Beep()
                    e.Handled = True
                End If
        End Select
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class