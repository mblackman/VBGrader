Public Class Form2
   Dim TotalCost, Meals As Double
   'This function Updates the total cost for the semester.
   Private Sub UpdateCost()
      If rdoWisconsin.Checked = True Then
         TotalCost = Wisconsin
      ElseIf rdoMinnesota.Checked = True Then
         TotalCost = Minnesota
      ElseIf rdoTriState.Checked = True Then
         TotalCost = Tri_State
      ElseIf rdoNonResident.Checked = True Then
         TotalCost = Non_Resident
      Else
         TotalCost = International
      End If
      If rdoResYes.Checked = True Then
         TotalCost += Residence_Halls
      End If
      If rdoCarYes.Checked = True Then
         TotalCost += Parking
      End If
      txtPayment.Text = FormatCurrency(TotalCost + Meals)
   End Sub
    Private Sub Form2_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        UserClosingForm(e)
    End Sub
   'This makes sure that all the Radio Buttons are unchecked when the Window is loaded.
    Private Sub frmPayment_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        rdoWisconsin.Checked = False
        rdoMinnesota.Checked = False
        rdoTriState.Checked = False
        rdoNonResident.Checked = False
        rdoInternational.Checked = False
        rdoResYes.Checked = False
        rdoResNo.Checked = False
        rdoCarYes.Checked = False
        rdoCarNo.Checked = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
        Form1.BringToFront()
    End Sub

    Private Sub rdoWisconsin_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdoWisconsin.CheckedChanged
      UpdateCost()
    End Sub

    Private Sub rdoMinnesota_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdoMinnesota.CheckedChanged
      UpdateCost()
    End Sub

    Private Sub rdoTriState_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdoTriState.CheckedChanged
      UpdateCost()
    End Sub

    Private Sub rdoNonResident_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdoNonResident.CheckedChanged
      UpdateCost()
    End Sub

    Private Sub rdoInternational_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdoInternational.CheckedChanged
      UpdateCost()
    End Sub

   Private Sub cboMealPlan_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboMealPlan.SelectedIndexChanged
      Meals = MealsCost(cboMealPlan.SelectedIndex)
      UpdateCost()
   End Sub

   Private Sub rdoResYes_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdoResYes.CheckedChanged
      UpdateCost()
   End Sub

   Private Sub rdoCarYes_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdoCarYes.CheckedChanged
      UpdateCost()
   End Sub
End Class