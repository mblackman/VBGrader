'----------------------------------------------
' Name       : Sammy Alexander
' Course     : CS2340, Section 1, Fall 2012
' Description: Lab 6
'              Form frmPayment
'----------------------------------------------
Public Class Form2

   Dim temptotal As Double
   Dim meals As Double
   Dim housing As Double
   Dim park As Double

   Private Sub GroupBox2_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox2.Enter

   End Sub
   Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

   End Sub

   Private Sub Form2_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) _
      Handles Me.FormClosing
      UserClosingForm(e)

   End Sub
   Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      txtTotal.Focus()
      rdoWis.TabStop() = True
      rdoYes1.TabStop() = True
      rdoYes2.TabStop() = True

   End Sub

   Private Sub BackToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) _
      Handles BackToolStripMenuItem.Click
      Me.Hide()
      frmClasses.Show()
      frmClasses.BringToFront()

   End Sub

   Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) _
      Handles ExitToolStripMenuItem.Click
      Application.Exit()

   End Sub

   Private Sub Form2_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
      If e.Button <> Windows.Forms.MouseButtons.Right Then Return
      ContextMenuStrip1.Show(Me, e.Location)
   End Sub

   Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) _
      Handles rdoTri.CheckedChanged
      If rdoTri.Checked = True Then

         temptotal = tristate

         showTotal()

      End If
   End Sub

   Private Sub RadioButton5_CheckedChanged(sender As System.Object, e As System.EventArgs) _
      Handles rdoInter.CheckedChanged
      If rdoInter.Checked = True Then

         temptotal = international
         showTotal()

      End If
   End Sub

   Private Sub rdoWis_CheckedChanged(sender As Object, e As System.EventArgs) Handles rdoWis.CheckedChanged
      If rdoWis.Checked = True Then

         temptotal = wisconsin
         showTotal()

      End If
   End Sub

   Private Sub rdoMinn_CheckedChanged(sender As Object, e As System.EventArgs) _
      Handles rdoMinn.CheckedChanged
      If rdoMinn.Checked = True Then

         temptotal = minnesota
         showTotal()

      End If
   End Sub

   Private Sub rdoNon_CheckedChanged(sender As Object, e As System.EventArgs) Handles rdoNon.CheckedChanged
      If rdoNon.Checked = True Then

         temptotal = nonresident
         showTotal()

      End If
   End Sub

   Private Sub cboMeal_SelectedIndexChanged(sender As Object, e As System.EventArgs) _
      Handles cboMeal.SelectedIndexChanged
      If cboMeal.SelectedIndex = 0 Or cboMeal.SelectedIndex = 8 Then
         cboMeal.SelectedIndex = 9
      End If
      meals = MealsCost(cboMeal.SelectedIndex)
      showTotal()

   End Sub

   Private Sub rdoYes1_CheckedChanged(sender As Object, e As System.EventArgs) Handles rdoYes1.CheckedChanged
      If rdoYes1.Checked = True Then

         housing = reshall
      ElseIf rdoNo1.Checked = True Then

      End If
      showTotal()

   End Sub

   Private Sub rdoYes2_CheckedChanged(sender As Object, e As System.EventArgs) Handles rdoYes2.CheckedChanged
      If rdoYes2.Checked = True Then

         park = parking
      ElseIf rdoNo2.Checked = True Then

         park = 0
      End If
      showTotal()

   End Sub
   Private Sub showTotal()
      txtTotal.Text = Format(temptotal + meals + housing + park, "c")
   End Sub
End Class