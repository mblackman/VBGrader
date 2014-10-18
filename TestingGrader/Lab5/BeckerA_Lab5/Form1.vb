Public Class Form1
    Private Sub menuCompute_Click(sender As System.Object, e As System.EventArgs) Handles menuCompute.Click
        Dim ID As String
        Dim rate As Double
        Dim hours As Double
        Dim grossPay As Double
        Dim deduction As Double
        Dim net As Double

        'check for valid ID
        ID = txtID.Text.Trim
        If ID = "" Then
            MessageBox.Show("Enter the ID please!", "Lab 5", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'check for valid rate
        If txtRate.Text.Trim = "" Then
            MessageBox.Show("Invalid Rate!",
                            "Lab 5", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRate.Focus()
            Exit Sub
        End If

        rate = Convert.ToDouble(txtRate.Text.Trim)
        If rate <= 0 Then
            MessageBox.Show("Invalid Rate!",
                            "Lab 5", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRate.Focus()
            Exit Sub
        End If

        'Check for valid hours
        If txtHours.Text.Trim = "" Then
            MessageBox.Show("Invalid Hours!",
                            "Lab 5", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtHours.Focus()
            Exit Sub
        End If

        hours = Convert.ToDouble(txtHours.Text.Trim)
        If hours < 0 Then
            MessageBox.Show("Invalid Hours!",
                            "Lab 5", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Calculate gross
        Compute(rate, hours, grossPay, deduction, net)
        txtGrossPay.Text = Format(grossPay, "c")
        txtDeduction.Text = Format(deduction, "c")
        txtNetPay.Text = Format(net, "c")


        menuNext.Enabled = True
        menuCompute.Enabled = False
        txtID.ReadOnly = True
        txtRate.ReadOnly = True
        txtHours.ReadOnly = True
        txtID.BackColor = SystemColors.Window
        txtRate.BackColor = SystemColors.Window
        txtHours.BackColor = SystemColors.Window
    End Sub

    Private Sub menuNext_Click(sender As System.Object, e As System.EventArgs) Handles menuNext.Click
        txtDeduction.Text = ""
        txtGrossPay.Text = ""
        txtHours.Text = ""
        txtID.Text = ""
        txtNetPay.Text = ""
        txtRate.Text = ""
        txtID.Focus()
        menuNext.Enabled = False
        menuCompute.Enabled = True
        txtID.ReadOnly = False
        txtRate.ReadOnly = False
        txtHours.ReadOnly = False
    End Sub

    Private Sub txtRate_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtRate.KeyPress
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

    Private Sub txtHours_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtHours.KeyPress
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

    Private Sub menuExit_Click(sender As System.Object, e As System.EventArgs) Handles menuExit.Click
        If MessageBox.Show("This Program is going to terminate." + vbCrLf +
                           "Do you really want to exit?", "BeckerA_Lab5", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub menuStats_Click(sender As System.Object, e As System.EventArgs) Handles menuStats.Click
        Me.Hide()
        frmStats.Show()
        frmStats.BringToFront()
    End Sub

    Private Sub Form1_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.ApplicationExitCall Then
            End
        Else
            e.Cancel = True
        End If
    End Sub
End Class
