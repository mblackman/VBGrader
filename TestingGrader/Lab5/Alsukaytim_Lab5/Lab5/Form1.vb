Public Class form1


    Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.TextChanged
        txtID.Focus()

    End Sub

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub txtRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRate.KeyPress
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

    Private Sub txtHours_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHours.KeyPress
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

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            If MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub frmLab2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NextToolStripMenuItem.Enabled = False
    End Sub

    ' Friend Sub ComputeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComputeToolStripMenuItem.Click
    Friend Sub ComputeToolStripMenuItem_Click(ByVal rate As Double, ByVal hours As Double, _
                 ByRef gross As Double, ByRef deduction As Double, _
                 ByRef net As Double)


        ' Dim rate, hours, grossPay, deduction, netPay As Double

        Dim input As String

        input = txtID.Text.Trim()

        If IsNumeric(input) And InStr(input, "e") = 0 Then


        ElseIf (input = "") Then

            MessageBox.Show("Enter the ID please!" + vbCrLf & _
                               "", "Lab 5", _
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtID.Focus()
            Exit Sub


        End If


        input = txtRate.Text.Trim()

        If IsNumeric(input) And _
        InStr(input, "e", CompareMethod.Text) = 0 Then

            rate = Convert.ToDouble(input)
            If rate <= 0 Then
                MessageBox.Show("Invalid Rate!" + vbCrLf & _
                                "Rate must be positive!", "Lab 5", _
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtRate.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Invalid Rate!" + Chr(Keys.LineFeed) & _
                            "Rate must be a number!", "Lab 5", _
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRate.Focus()
            Exit Sub
        End If


        input = txtHours.Text.Trim()
        If IsNumeric(txtHours.Text) Then


            hours = Convert.ToDouble(input)


        Else
            MessageBox.Show("Invalid Hours!" + vbCrLf + _
                "hours must be a number!", _
                "Lab 5", MessageBoxButtons.OK, MessageBoxIcon.Error)

            txtHours.Focus()
            Exit Sub

        End If

        If hours < 0 Then
            MessageBox.Show("Invalid Hours!" + vbCrLf + _
                 "Hours must be non-negative!", _
                 "Lab 5", MessageBoxButtons.OK, MessageBoxIcon.Error)

            txtHours.Focus()
            Exit Sub

        End If

        If txtHours.Text <= 40 Then


            gross = rate * hours

            txtGrossPay.Text = Format(gross, "Currency")

            deduction = gross * (33 / 100)

            txtDeduction.Text = Format(deduction, "Currency")
            net = gross - deduction
            txtNetPay.Text = Format(net, "Currency")

        ElseIf txtHours.Text > 40 Then

            Dim OverTime As Double
            OverTime = (hours - 40) * (rate / 2)
            gross = (hours * rate) + OverTime
            txtGrossPay.Text = Format(gross, "Currency")
            deduction = gross * (33 / 100)

            txtDeduction.Text = Format(deduction, "Currency")
            net = gross - deduction
            txtNetPay.Text = Format(net, "Currency")
        End If
        ComputeToolStripMenuItem.Enabled = False
        NextToolStripMenuItem.Enabled = True

    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click



        txtRate.Text = ""
        txtGrossPay.Text = ""
        txtID.Text = ""
        txtHours.Text = ""
        txtDeduction.Text = ""
        txtNetPay.Text = ""

        txtID.Focus()
        Count += 1



        ComputeToolStripMenuItem.Enabled = True
        NextToolStripMenuItem.Enabled = False
    End Sub

    Private Sub StatsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatsToolStripMenuItem.Click
        Me.Hide()
        frmStats.Show()
        frmStats.BringToFront()
    End Sub

    Friend Sub ComputeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComputeToolStripMenuItem.Click

    End Sub
End Class
