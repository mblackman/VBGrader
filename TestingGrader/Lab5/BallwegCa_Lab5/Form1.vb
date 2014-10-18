'----------------------------------------------
' Name       : Caleb Ballweg
' Course     : CS2340, Section 1, Fall 2012
' Description: Lab 2
'              Form frmPayRoll
'----------------------------------------------
Public Class Form1

   Private Sub ComputeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ComputeToolStripMenuItem.Click
        Try
            Dim rate, hours, grossPay, deduction, netPay As Double
            Dim input As String
            input = txtID.Text.Trim()
            If input = "" Then
                MessageBox.Show("Enter ID first!", "Lab5", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtID.Focus()
                Exit Sub
            End If

            If txtRate.Text = "" Then
                MessageBox.Show("Incorrect Rate!", "Lab 5", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtRate.Focus()
                Exit Sub
            End If
            input = txtRate.Text.Trim()
            rate = Convert.ToDouble(input)

            If txtHours.Text = "" Then
                MessageBox.Show("Enter Hours!", "Lad5", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtHours.Focus()
                Exit Sub
            End If
            input = txtHours.Text.Trim()
            hours = Convert.ToDouble(input)

            Compute(rate, hours, grossPay, deduction, netPay)
            UpdateStats(grossPay)
            

            txtGrossPay.Text = FormatCurrency(grossPay)
            txtGrossPay.Text = FormatCurrency(grossPay)
            txtDeduction.Text = FormatCurrency(deduction)
            txtNetPay.Text = FormatCurrency(netPay)
            ComputeToolStripMenuItem.Enabled = False
            NextToolStripMenuItem.Enabled = True
            txtID.ReadOnly = True
            txtHours.ReadOnly = True
            txtRate.ReadOnly = True

        Catch
        End Try
    End Sub

   Private Sub NextToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NextToolStripMenuItem.Click
      txtID.Text = ""
      txtRate.Text = ""
      txtHours.Text = ""
      txtGrossPay.Text = ""
      txtDeduction.Text = ""
      txtNetPay.Text = ""

        txtID.Focus()
        ComputeToolStripMenuItem.Enabled = True
        NextToolStripMenuItem.Enabled = False
        txtID.ReadOnly = False
        txtHours.ReadOnly = False
        txtRate.ReadOnly = False
   End Sub

   Private Sub StatsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StatsToolStripMenuItem.Click
      Me.Hide()
      Form2.Show()
      Form2.BringToFront()
   End Sub

   Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim result As MsgBoxResult
        result = MessageBox.Show("The program is going to terminate." & vbCrLf & "Do you really want to exit?", "Lab5", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = MsgBoxResult.Yes Then
            end
        End If
    End Sub

   Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
      If e.CloseReason = CloseReason.UserClosing Then
         If MsgBox("The program is going to terminate." & vbCrLf & "Do you really want to exit?", "Lab5", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            e.Cancel = True
         End If
      End If
   End Sub

   Private Sub txtRate_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtRate.KeyPress
      Select Case e.KeyChar
         Case Chr(Keys.Back)
            'good
         Case "0" To "9"
            'good
         Case "."
            ' allow the first one
            If InStr(txtRate.Text, ".") Then
               Beep()
               e.Handled = True
            End If
         Case Else
            Beep()
            e.Handled = True
      End Select
   End Sub

   Private Sub txtHours_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtHours.KeyPress
      Select Case e.KeyChar
         Case Chr(Keys.Back)
            'good
         Case "0" To "9"
            'good
         Case "."
            ' allow the first one
            If InStr(txtHours.Text, ".") Then
               Beep()
               e.Handled = True
            End If
         Case Else
            Beep()
            e.Handled = True
      End Select
   End Sub

   Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

   End Sub
End Class