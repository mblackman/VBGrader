'----------------------------------------------
' Name       : Sammy Eagle Alexander
' Course     : CS2340, Section 1, Fall 2012
' Description: Lab 2
'              Form frmLab2
'----------------------------------------------
Public Class Form1


    Dim id As String


    Private Sub Label1_Click(ByVal sender As System.Object,
                             ByVal e As System.EventArgs) Handles lblPayRoll.Click

    End Sub

    Private Sub txtNetPay_TextChanged(ByVal sender As System.Object,
                                      ByVal e As System.EventArgs) Handles txtNetPay.TextChanged

    End Sub

    Private Sub txtDeduction_TextChanged(ByVal sender As System.Object,
                                         ByVal e As System.EventArgs) Handles txtDeduction.TextChanged

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.ApplicationExitCall Then
            Application.Exit()
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub frmLab2_Load(ByVal sender As System.Object,
                             ByVal e As System.EventArgs) Handles MyBase.Load
        NextToolStripMenuItem.Enabled = False
    End Sub

    Private Sub txtGrossPay_TextChanged(ByVal sender As System.Object,
                                        ByVal e As System.EventArgs) Handles txtGrossPay.TextChanged

    End Sub


    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

   Private Sub ComputeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComputeToolStripMenuItem.Click
      Dim rate, hours, gross, deduction, net As Double

      id = txtID.Text.Trim

      If id = "" Then
         MessageBox.Show("Enter ID first!", "Lab2",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Stop
                         )
         txtID.Focus()
         Exit Sub
      ElseIf Not IsNumeric(txtRate.Text) Then
         MessageBox.Show("Incorrect Rate!",
                         "Lab2",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information)
         txtRate.Focus()
         Exit Sub
      ElseIf txtRate.Text = 0 Then
         MessageBox.Show("Incorrect Rate!",
                         "Lab2",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information)
         txtRate.Focus()
         Exit Sub
      ElseIf Not IsNumeric(txtHours.Text) Or InStr(txtHours.Text, "e", CompareMethod.Text) Then
         MessageBox.Show("Invalid Hours!" + Chr(Keys.LineFeed) + _
                         "Hours must be a number!",
                         "Lab2", MessageBoxButtons.OK,
                         MessageBoxIcon.Stop
                         )
         txtHours.Focus()
         Exit Sub
      ElseIf txtHours.Text < 0 Then
         MessageBox.Show("Enter Hours!", "Lab2",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Stop
                         )
         txtHours.Focus()
         Exit Sub
      End If

      rate = Convert.ToDouble(txtRate.Text)
      hours = Convert.ToDouble(txtHours.Text)

      Compute(rate, hours, gross, deduction, net)

      txtGrossPay.Text = Format(gross, "C")
      txtDeduction.Text = Format(deduction, "C")
      txtNetPay.Text = Format(net, "C")
      NextToolStripMenuItem.Enabled = True
      UpdateStats(gross)
      txtID.ReadOnly = True
      txtID.BackColor = SystemColors.Window
      txtHours.ReadOnly = True
      txtHours.BackColor = SystemColors.Window
      txtRate.ReadOnly = True
      txtRate.BackColor = SystemColors.Window


   End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Dim intResult As DialogResult
        intResult = MessageBox.Show("The program is going to terminate." + vbCrLf + "Do you really want to exit?", "AlexanderS_Lab5",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If intResult = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub txtRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRate.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Back)
            Case "0" To "9"
            Case "."
                If InStr(txtRate.Text, ".") > 0 Then
                    Beep()
                    e.Handled = True
                End If
            Case Else
                Beep()
                e.Handled = True

        End Select
    End Sub


    Private Sub txtHours_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHours.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Back)
            Case "0" To "9"
            Case "."
                If InStr(txtHours.Text, ".") > 0 Then
                    Beep()
                    e.Handled = True
                End If
            Case Else
                Beep()
                e.Handled = True

        End Select
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        txtRate.Text = ""
        txtGrossPay.Text = ""
        txtID.Text = ""
        txtHours.Text = ""
        txtNetPay.Text = ""
        txtDeduction.Text = ""
        txtID.ReadOnly = False
        txtHours.ReadOnly = False
        txtRate.ReadOnly = False
        NextToolStripMenuItem.Enabled = False
        txtID.Focus()
    End Sub

    Private Sub StatsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatsToolStripMenuItem.Click
        Me.Hide()
        frmStats.Show()
        frmStats.BringToFront()

    End Sub
End Class
