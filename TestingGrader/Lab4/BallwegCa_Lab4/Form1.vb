Public Class Form1

    Private Sub computeAndDisplayFutureValues()
        Dim pricipal, rate, result As Double
        Dim startYear, endYear As Integer

        If TextBox1.Text = "" Then
            Exit Sub
        End If
        pricipal = TextBox1.Text

        rate = ComboBox1.Text / 100.0
    
        If TextBox2.Text = "" Then
            Exit Sub
        End If
        startYear = TextBox2.Text

        If TextBox3.Text = "" Then
            Exit Sub
        End If
        If TextBox3.Text < startYear Then
            ListBox1.Items.Clear()
            Exit Sub
        End If
        endYear = TextBox3.Text

        ListBox1.Items.Clear()
        ListBox1.Items.Add("Number Of years".PadLeft(8) & "     future values".PadRight(23))
        ListBox1.Items.Add(" in the future".PadLeft(8))

        If ToolStripMenuItem2.Checked = True Then
            For index As Integer = startYear To endYear
                result = -FV(rate / 1, index * 1, 0, pricipal)
                ListBox1.Items.Add(index.ToString.PadLeft(8) & Format(result, "c").PadLeft(23))
            Next
        ElseIf ToolStripMenuItem3.Checked = True Then
            For index As Integer = startYear To endYear
                result = -FV(rate / 4, index * 4, 0, pricipal)
                ListBox1.Items.Add(index.ToString.PadLeft(8) & Format(result, "c").PadLeft(23))
            Next
        ElseIf ToolStripMenuItem4.Checked = True Then
            For index As Integer = startYear To endYear
                result = -FV(rate / 12, index * 12, 0, pricipal)
                ListBox1.Items.Add(index.ToString.PadLeft(8) & Format(result, "c").PadLeft(23))
            Next
        ElseIf ToolStripMenuItem5.Checked = True Then
            For index As Integer = startYear To endYear
                result = -FV(rate / 365, index * 365, 0, pricipal)
                ListBox1.Items.Add(index.ToString.PadLeft(8) & Format(result, "c").PadLeft(23))
            Next
        End If
    End Sub

   Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
      MessageBox.Show("Qi Yang" & vbCrLf & "Department of Computer Science and Software Engineering" _
                      & vbCrLf & "UW-Platteville", "Lab4", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

   Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
      End
    End Sub

    Private Sub frmLab3_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.ApplicationExitCall Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

   Private Sub ComputeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ComputeToolStripMenuItem.Click
        computeAndDisplayFutureValues()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        computeAndDisplayFutureValues()
    End Sub

   Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
      Select Case e.KeyChar
         Case Chr(Keys.Back)
            'good
         Case "0" To "9"
            'good
         Case "."
            ' allow the first one
            If InStr(TextBox1.Text, ".") Then
               Beep()
               e.Handled = True
            End If
         Case Else
            Beep()
            e.Handled = True
      End Select
   End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Back)
                'good
            Case "0" To "9"
                'good
            Case Else
                Beep()
                e.Handled = True
        End Select
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Back)
                'good
            Case "0" To "9"
                'good
            Case Else
                Beep()
                e.Handled = True
        End Select
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Back)
                'good
            Case "0" To "9"
                'good
            Case "."
                ' allow the first one
                If InStr(TextBox1.Text, ".") Then
                    Beep()
                    e.Handled = True
                End If
            Case Else
                Beep()
                e.Handled = True
        End Select
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem4.Click
        If ToolStripMenuItem4.Checked Then
            ToolStripMenuItem3.Checked = False
            ToolStripMenuItem2.Checked = False
            ToolStripMenuItem5.Checked = False
        End If
        computeAndDisplayFutureValues()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem2.Click
        If ToolStripMenuItem2.Checked Then
            ToolStripMenuItem3.Checked = False
            ToolStripMenuItem4.Checked = False
            ToolStripMenuItem5.Checked = False
        End If
        computeAndDisplayFutureValues()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem3.Click
        If ToolStripMenuItem3.Checked Then
            ToolStripMenuItem2.Checked = False
            ToolStripMenuItem4.Checked = False
            ToolStripMenuItem5.Checked = False
        End If
        computeAndDisplayFutureValues()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem5.Click
        If ToolStripMenuItem5.Checked Then
            ToolStripMenuItem2.Checked = False
            ToolStripMenuItem3.Checked = False
            ToolStripMenuItem4.Checked = False
        End If
        computeAndDisplayFutureValues()
    End Sub
End Class
