Public Class frmPayRoll

    Private Sub ComputeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCompute.Click
        Dim rate, hours, gross, deduction, netpay As Double

        txtID.Text = txtID.Text.Trim
        txtRate.Text = txtRate.Text.Trim
        txtHours.Text = txtHours.Text.Trim
        If (txtID.Text = "") Then
            MessageBox.Show("Enter ID first!", "Payroll", MessageBoxButtons.OK, _
                            MessageBoxIcon.Warning)
            txtID.Focus()
        ElseIf (txtRate.Text = "") Then
            MessageBox.Show("Incorrect Rate!", "Payroll", MessageBoxButtons.OK, _
                            MessageBoxIcon.Information)
            txtRate.Focus()
        ElseIf (txtHours.Text = "") Then
            MessageBox.Show("Enter Hours!", "Payroll", MessageBoxButtons.OK, _
                            MessageBoxIcon.Warning)
            txtHours.Focus()
        Else
            mnuNext.Enabled = True
            rate = Convert.ToDouble(txtRate.Text)
            hours = Convert.ToDouble(txtHours.Text)
            Compute(rate, hours, gross, deduction, netpay)
            txtGrossPay.Text = FormatCurrency(gross)
            txtDeduction.Text = FormatCurrency(deduction)
            txtNetPay.Text = FormatCurrency(netpay)
            mnuCompute.Enabled = False
            UpdateStats(gross)
            txtID.ReadOnly = True
            txtID.BackColor = Color.White
            txtRate.ReadOnly = True
            txtRate.BackColor = Color.White
            txtHours.ReadOnly = True
            txtHours.BackColor = Color.White
        End If

    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNext.Click
        txtID.Text = ""
        txtRate.Text = ""
        txtHours.Text = ""
        txtGrossPay.Text = ""
        txtDeduction.Text = ""
        txtNetPay.Text = ""
        txtID.Focus()
        mnuCompute.Enabled = True
        mnuNext.Enabled = False
        txtID.ReadOnly = False
        txtRate.ReadOnly = False
        txtHours.ReadOnly = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        If MessageBox.Show("The program is going to terminate." + vbCrLf + "Do you really want to exit?", "AbabioM_Lab5", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            End
        Else
        End If
    End Sub

    Private Sub frmPayRoll_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.ApplicationExitCall Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub frmPayRoll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mnuNext.Enabled = False
    End Sub

    Private Sub txtRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRate.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Back)
            Case "0" To "9"
            Case "."
                If InStr(txtRate.Text, ".") Then
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
                If InStr(txtRate.Text, ".") Then
                    Beep()
                    e.Handled = True
                End If
            Case Else
                Beep()
                e.Handled = True
        End Select
    End Sub

    Private Sub mnuStats_Click(sender As System.Object, e As System.EventArgs) Handles mnuStats.Click
        Me.Hide()
        frmStats.Show()
        frmStats.BringToFront()
    End Sub
End Class
