Public Class Form1
    'Variable declaration
    Dim principal, rate, result As Double
    Dim StartYear, EndYear, numPeriods As Integer

    'This will prevent you from using alt+F4 to exit the program
    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.ApplicationExitCall Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    'This sets the rate to display 7 at the beginning of the program.
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboRate.Text = 7
    End Sub

    'This lets the Exit button on the MenuStrip actually close the program
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    'This allows you to only input numbers 0 to 9, one decimal point, and the backspace key in the "Principle" textbox. anything else will create a beeping
    'sound.
    Private Sub txtPrinciple_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrincipal.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Back)
            Case "0" To "9"
            Case "."
                If InStr(txtPrincipal.Text, ".") Then
                    Beep()
                    e.Handled = True
                End If
            Case Else
                Beep()
                e.Handled = True
        End Select
    End Sub

    'This checks to see if there is anything inputted in all the txtboxes, and also if the Start year and End year inputs are valid
    Private Sub ComputeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComputeToolStripMenuItem.Click
        If txtPrincipal.Text = "" Then
            MessageBox.Show("Enter the principle please!", "Lab 4", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrincipal.Focus()
        ElseIf cboRate.Text = "" Then
            MessageBox.Show("Enter or select a rate!", "Lab 4", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboRate.Focus()
        ElseIf txtBegin.Text = "" Then
            MessageBox.Show("Enter a start year!", "Lab 4", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBegin.Focus()
        ElseIf txtEnd.Text = "" Then
            MessageBox.Show("Enter an end year!", "Lab 4", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEnd.Focus()
        Else
            principal = txtPrincipal.Text
            rate = cboRate.Text / 100.0
            StartYear = txtBegin.Text
            EndYear = txtEnd.Text
            lstFuture.Items.Clear()
        End If
        If EndYear < StartYear Then
            MessageBox.Show("End year can NOT be smaller than the start year!", "Lab 4", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEnd.Focus()
        ElseIf EndYear > 99 Then
            MessageBox.Show("End year can NOT be more than 99!", "Lab 4", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            computeAndDisplayFutureValues()
        End If

    End Sub

    'This allows you to only input numbers 0 to 9, one decimal point, and the backspace key in the "Annual Rate (%)" textbox. anything else will create
    'a beeping sound.
    Private Sub cboRate_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cboRate.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Back)
            Case "0" To "9"
            Case "."
                If InStr(cboRate.Text, ".") Then
                    Beep()
                    e.Handled = True
                End If
            Case Else
                Beep()
                e.Handled = True
        End Select
    End Sub

    'This allows you to only input numbers 0 to 9 and the backspace key in the "Principle" textbox. anything else will create a beeping
    'sound.
    Private Sub txtBegin_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtBegin.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Back)
            Case "0" To "9"
            Case Else
                Beep()
                e.Handled = True
        End Select
    End Sub

    'This allows you to only input numbers 0 to 9 and the backspace key in the "Principle" textbox. anything else will create a beeping
    'sound.
    Private Sub txtEnd_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtEnd.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Back)
            Case "0" To "9"
            Case Else
                Beep()
                e.Handled = True
        End Select
    End Sub

    'This displays the "About" window with the following information
    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Michael Ababio" + vbCrLf + "Department of Computer Science and Software Engineering" + vbCrLf +
                        "UW - Platteville", "Future Values Program", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Called when user inputs into the start year and end year textboxes.
    Private Sub CheckPositiveIntegers(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'function not needed. Since you already cannot add a minus sign to any of the TxtBoxes, this function isnt needed. As proof of this, Your
        'YangQ_Lab4 program does not allow you to add a minus sign either to any of the TxtBoxes.
    End Sub

    ' Called when to compute and display the future values
    Private Sub computeAndDisplayFutureValues()
        lstFuture.Items.Clear()
        If MnuYearly.Checked = True Then
            numPeriods = 1
        ElseIf MnuQuarterly.Checked = True Then
            numPeriods = 4
        ElseIf MnuMonthly.Checked = True Then
            numPeriods = 12
        ElseIf MnuDaily.Checked = True Then
            numPeriods = 365
        End If

        lstFuture.Items.Add("Number of Years".PadLeft(8) & "Future Values".PadLeft(16))
        lstFuture.Items.Add(" in the future".PadLeft(8))
        For myYear As Integer = StartYear To EndYear

            result = -FV(rate / numPeriods, myYear * numPeriods, 0, principal)

            lstFuture.Items.Add((myYear.ToString.PadLeft(8) & Format(result, "c").PadLeft(23)))
        Next
    End Sub

    'This checks the "Yearly" button on the MenuStrip, and makes sure that the other buttons are and remain unchecked. Then the values are recomputed.
    Private Sub ToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles MnuYearly.Click
        MnuYearly.Checked = True
        MnuDaily.Checked = False
        MnuMonthly.Checked = False
        MnuQuarterly.Checked = False
        computeAndDisplayFutureValues()
    End Sub

    'This checks the "Quarterly" button on the MenuStrip, and makes sure that the other buttons are and remain unchecked. Then the values are recomputed.
    Private Sub MnuQuarterly_Click(sender As System.Object, e As System.EventArgs) Handles MnuQuarterly.Click
        MnuYearly.Checked = False
        MnuDaily.Checked = False
        MnuMonthly.Checked = False
        MnuQuarterly.Checked = True
        computeAndDisplayFutureValues()
    End Sub

    'This checks the "Monthly" button on the MenuStrip, and makes sure that the other buttons are and remain unchecked. Then the values are recomputed.
    Private Sub MnuMonthly_Click(sender As System.Object, e As System.EventArgs) Handles MnuMonthly.Click
        MnuYearly.Checked = False
        MnuDaily.Checked = False
        MnuMonthly.Checked = True
        MnuQuarterly.Checked = False
        computeAndDisplayFutureValues()
    End Sub

    'This checks the "Daily" button on the MenuStrip, and makes sure that the other buttons are and remain unchecked. Then the values are recomputed.
    Private Sub MnuDaily_Click(sender As System.Object, e As System.EventArgs) Handles MnuDaily.Click
        MnuYearly.Checked = False
        MnuDaily.Checked = True
        MnuMonthly.Checked = False
        MnuQuarterly.Checked = False
        computeAndDisplayFutureValues()
    End Sub
End Class
