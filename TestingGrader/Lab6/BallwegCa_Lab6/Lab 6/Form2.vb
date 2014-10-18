Public Class Form2

   Private Sub Form2_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs)
      UserClosingForm(e)
   End Sub

   Private Sub BakcToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BakcToolStripMenuItem.Click
      Me.Hide()
      frmLab6.Show()
      frmLab6.BringToFront()
   End Sub

   Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
      Application.Exit()
   End Sub

    Private Sub computeAndDisplayFutureValues()
        txtPayment.Text = FormatCurrency(Int(Val(txtPayment.Text)) + State + Residence + Parking + Meals)
    End Sub

    Private Sub cboMealPlan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboMealPlan.SelectedIndexChanged
        Meals = MealsCost(CboMealPlan.SelectedIndex)
        If MealsCost(0) Or MealsCost(8) Then
            CboMealPlan.Text = MealsCost(9)
        End If
        computeAndDisplayFutureValues()
    End Sub

    Private Sub Form2_FormClosing1(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.ApplicationExitCall Then
            End
        Else
            e.Cancel = True
            MessageBox.Show("Sorry, the form cannot be closed this way!" & vbCrLf & "Use the form Shortcut menu please.", "Lab 6", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        State = 2725
        computeAndDisplayFutureValues()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        State = 3021
        computeAndDisplayFutureValues()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        State = 4725
        computeAndDisplayFutureValues()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged
        State = 6463
        computeAndDisplayFutureValues()
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton5.CheckedChanged
        State = 6463
        computeAndDisplayFutureValues()
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton6.CheckedChanged
        Residence = 1312
        computeAndDisplayFutureValues()
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton7.CheckedChanged
        Residence = 0
        computeAndDisplayFutureValues()
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton8.CheckedChanged
        Parking = 30
        computeAndDisplayFutureValues()
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton9.CheckedChanged
        Parking = 0
        computeAndDisplayFutureValues()
    End Sub
End Class