'----------------------------------------------
' Name       : Sammy Alexander
' Course     : CS2340, Section 1, Fall 2012
' Description: Lab 4
'              Form frmLab 4
'----------------------------------------------
Public Class frmLab4
   Dim PMT, principle, futureValue As Double
   Dim percent As Double = 100.0
   Dim newrate, rate As Double
   Dim StartYear, EndYear, period As Integer
   Dim MAX_YEAR As Integer = 99
   

   Private Sub ToolStripMenuItem4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripPPY4.Click
      ToolStripPPY1.Checked = False
      ToolStripPPY4.Checked = True
      ToolStripPPY12.Checked = False
      ToolStripPPY365.Checked = False
      period = 4
      ComputeFutureValues()
   End Sub
   Private Sub ComputeFutureValues()

      StartYear = Convert.ToInt16(txtStart.Text)
      EndYear = Convert.ToInt16(txtEnd.Text)
      principle = Convert.ToDouble(txtPrinciple.Text)
      rate = Convert.ToDouble(cboRate.Text)
      lstFutureValues.Items.Clear()
      newrate = Convert.ToDouble(rate / percent)
      lstFutureValues.Items.Add("Number of Years".PadLeft(8) & "Future Values".PadLeft(16))
      lstFutureValues.Items.Add(" in the future".PadLeft(8))
      For myyear As Integer = StartYear To EndYear
         futureValue = -FV(newrate / period, myyear * period, 0, principle)
         lstFutureValues.Items.Add(myyear.ToString.PadLeft(8) & Format(futureValue, "c").PadLeft(23))
      Next
   End Sub
    Private Sub cboRate_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cboRate.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Back)

            Case "0" To "9"

            Case "."
                If InStr(cboRate.Text, ".") > 0 Then
                    Beep()
                    e.Handled = True
                End If
            Case Else
                Beep()
                e.Handled = True
        End Select
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboRate.SelectedIndexChanged
      ComputeFutureValues()

    End Sub

    Private Sub frmLab4_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

      If e.CloseReason = CloseReason.ApplicationExitCall Then
         End
      Else
         e.Cancel = True
      End If

   End Sub

    Private Sub frmLab4_Load(sender As Object, e As System.EventArgs) Handles Me.Load
      period = 12
      cboRate.SelectedIndex = 2
   End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Qi Yang" + Chr(Keys.LineFeed) +
                        "Department of Computer Science and Software Engineering" +
                        Chr(Keys.LineFeed) + "UW - Platteville",
                        "Future Values Program (Sammy Alexander)", MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        )
    End Sub

    Private Sub ComputeToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles ComputeToolStripMenuItem.Click
      
      If txtPrinciple.Text = "" Then
         MessageBox.Show("Enter the principle please!", "Lab 4",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                         )
      ElseIf cboRate.Text = "" Then
         MessageBox.Show("Enter or select a rate!", "Lab 4",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                        )
      ElseIf txtStart.Text = "" Then
         MessageBox.Show("Enter a start year!", "Lab 4",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                        )
      ElseIf txtEnd.Text = "" Then
         MessageBox.Show("Enter a end year!", "Lab 4",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                        )
      ElseIf EndYear < StartYear Then
         MessageBox.Show("End year can NOT be smaller than the start !", "Lab 4",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                         )

      elseif EndYear > MAX_YEAR Then
      MessageBox.Show("End year can NOT be more than start!", "Lab 4",
                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                      )
      Else
         ComputeFutureValues()
      End If
   End Sub


   Private Sub txtPrinciple_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrinciple.KeyPress
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

   Private Sub txtStart_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtStart.KeyPress
      Select Case e.KeyChar
         Case Chr(Keys.Back)

         Case "0" To "9"
         Case Else
            Beep()
            e.Handled = True
      End Select

   End Sub

   Private Sub txtEnd_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtEnd.KeyPress
      Select Case e.KeyChar
         Case Chr(Keys.Back)

         Case "0" To "9"
         Case Else
            Beep()
            e.Handled = True
      End Select

   End Sub


   Private Sub ToolStripPPY1_Click(sender As Object, e As System.EventArgs) Handles ToolStripPPY1.Click
      ToolStripPPY1.Checked = True
      ToolStripPPY4.Checked = False
      ToolStripPPY12.Checked = False
      ToolStripPPY365.Checked = False
      period = 1
      ComputeFutureValues()
   End Sub

   Private Sub ToolStripPPY12_Click(sender As Object, e As System.EventArgs) Handles ToolStripPPY12.Click
      ToolStripPPY1.Checked = False

      ToolStripPPY4.Checked = False
      ToolStripPPY12.Checked = True

      ToolStripPPY365.Checked = False
      period = 12

   End Sub

   Private Sub ToolStripPPY365_Click(sender As Object, e As System.EventArgs) Handles ToolStripPPY365.Click
      ToolStripPPY1.Checked = False
      ToolStripPPY4.Checked = False
      ToolStripPPY12.Checked = False
      ToolStripPPY365.Checked = True
      period = 365
      ComputeFutureValues()
   End Sub

   
End Class
