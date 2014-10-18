Public Class Form1
    Dim numPeriods As Integer
    Private Sub computeFV(ByVal warnings As Boolean)
        Dim futureValue As Double
        Dim rate As Double
        Dim principle As Double

        If txtPrinciple.Text = "" Then
            'invalid principle!
            If warnings Then
                MessageBox.Show("Enter the principle please!", "Lab4 Alex Becker",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPrinciple.Focus()
            End If
            Exit Sub
        ElseIf cmbRate.Text = "" Then
            'invalid rate!
            If warnings Then
                MessageBox.Show("Enter or select a rate!", "Lab4 Alex Becker",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbRate.Focus()
            End If
            Exit Sub
        ElseIf txtStart.Text = "" Then
            'invalid start!
            If warnings Then
                MessageBox.Show("Enter a start year!", "Lab4 Alex Becker",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtStart.Focus()
            End If
            Exit Sub
        ElseIf txtEnd.Text = "" Then
            'invalid end
            If warnings Then
                MessageBox.Show("Enter a end year!", "Lab4 Alex Becker",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtEnd.Focus()
            End If
            Exit Sub
        ElseIf Convert.ToDouble(txtEnd.Text) > 99 Then
            'invalid end
            If warnings Then
                MessageBox.Show("End year can not be more than 99!", "Lab4 Alex Becker",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtEnd.Focus()
            End If
            Exit Sub
        ElseIf Convert.ToDouble(txtEnd.Text) < Convert.ToDouble(txtStart.Text) Then
            'end < start
            If warnings Then
                MessageBox.Show("End year can not be smaller than the start year!",
                                "Lab4 Alex Becker", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)
                txtEnd.Focus()
            End If
            Exit Sub
        End If
        lbFV.Items.Clear()

        lbFV.Items.Add("Number of Years".PadLeft(0) & "Future Values".PadLeft(16))
        lbFV.Items.Add(" in the future")

        rate = Convert.ToDouble(cmbRate.Text) / 100 / numPeriods
        principle = Convert.ToDouble(txtPrinciple.Text)

        For index As Integer = Convert.ToInt32(txtStart.Text) To Convert.ToInt32(txtEnd.Text)
            futureValue = -FV(rate, index * numPeriods, 0, principle)
            lbFV.Items.Add(index.ToString.PadLeft(8) & Format(futureValue, "c").PadLeft(23))
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rate As Integer = 5
        cmbRate.Items.Clear()

        While rate <= 12
            If rate < 10 Then
                cmbRate.Items.Add("  " + rate.ToString)
            Else
                cmbRate.Items.Add(" " + rate.ToString)
            End If
            rate += 1
        End While

        cmbRate.SelectedIndex = 2

        numPeriods = 12
    End Sub

    Private Sub menuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuAbout.Click
        MessageBox.Show("Alex Becker" + vbCrLf + "Department of Computer Science and Software Engineering" + vbCrLf + "UW - Platteville",
                        "Lab4 Alex Becker", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub menuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuExit.Click
        End
    End Sub

    Private Sub menuCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCompute.Click
        computeFV(True)
    End Sub

    Private Sub menuMonthly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuMonthly.Click
        menuYearly.Checked = False
        menuQuarterly.Checked = False
        menuMonthly.Checked = True
        menuDaily.Checked = False

        numPeriods = 12

        computeFV(False)
    End Sub

    Private Sub menuYearly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuYearly.Click
        menuYearly.Checked = True
        menuQuarterly.Checked = False
        menuMonthly.Checked = False
        menuDaily.Checked = False

        numPeriods = 1

        computeFV(False)
    End Sub

    Private Sub menuQuarterly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuQuarterly.Click
        menuYearly.Checked = False
        menuQuarterly.Checked = True
        menuMonthly.Checked = False
        menuDaily.Checked = False

        numPeriods = 4

        computeFV(False)
    End Sub

    Private Sub menuDaily_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuDaily.Click
        menuYearly.Checked = False
        menuQuarterly.Checked = False
        menuMonthly.Checked = False
        menuDaily.Checked = True

        numPeriods = 365

        computeFV(False)
    End Sub

    Private Sub txtPrinciple_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrinciple.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Back)
            Case "0" To "9"
            Case "."
                If InStr(txtPrinciple.Text, ".") > 0 Then
                    Beep()
                    e.Handled = True
                End If
            Case Else
                Beep()
                e.Handled = True
        End Select
    End Sub

    Private Sub cmbRate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbRate.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Back)
            Case "0" To "9"
            Case "."
                If InStr(cmbRate.Text, ".") > 0 Then
                    Beep()
                    e.Handled = True
                End If
            Case Else
                Beep()
                e.Handled = True
        End Select
    End Sub

    Private Sub txtStart_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStart.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Back)
            Case "0" To "9"
            Case Else
                Beep()
                e.Handled = True
        End Select
    End Sub

    Private Sub txtEnd_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEnd.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Back)
            Case "0" To "9"
            Case Else
                Beep()
                e.Handled = True
        End Select
    End Sub

    Private Sub cmbRate_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbRate.SelectedIndexChanged
        computeFV(False)
    End Sub

    Private Sub Form1_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.ApplicationExitCall Then
            End
        Else
            e.Cancel = True
        End If
    End Sub
End Class
