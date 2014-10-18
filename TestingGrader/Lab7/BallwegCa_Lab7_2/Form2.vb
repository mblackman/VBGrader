Public Class Form2

    Private Sub Form2_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.ApplicationExitCall Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

   Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      'TODO: This line of code loads data into the 'MyCompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
      Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)
      ToolStripTextBox1.Text = SalesStaffBindingSource.Position + 1
      ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count
   End Sub

   Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
      SalesStaffBindingSource.MoveFirst()
      ToolStripTextBox1.Text = 1
      ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count
   End Sub

   Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
      SalesStaffBindingSource.MovePrevious()
      ToolStripTextBox1.Text = SalesStaffBindingSource.Position + 1
      ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count
   End Sub

   Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
      SalesStaffBindingSource.MoveNext()
      ToolStripTextBox1.Text = SalesStaffBindingSource.Position + 1
      ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count
   End Sub

   Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
      SalesStaffBindingSource.MoveLast()
      ToolStripTextBox1.Text = SalesStaffBindingSource.Position + 1
      ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count
   End Sub

   Private Sub ToolStripButton7_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton7.Click
      Try
         Me.Validate()
         Me.SalesStaffBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MyCompanyDataSet)

            ToolStripButton5.Enabled = True
            ToolStripButton8.Enabled = True
            ToolStripButton1.Enabled = True
            ToolStripButton2.Enabled = True
            ToolStripButton3.Enabled = True
            ToolStripButton4.Enabled = True
            ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count

      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
   End Sub

   Private Sub ToolStripButton8_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton8.Click
      Try
         Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
   End Sub

   Private Sub ToolStripButton6_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton6.Click
        SalesStaffBindingSource.RemoveCurrent()
        ToolStripButton5.Enabled = True
        ToolStripButton8.Enabled = True
        ToolStripButton1.Enabled = True
        ToolStripButton2.Enabled = True
        ToolStripButton3.Enabled = True
        ToolStripButton4.Enabled = True
      ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count
   End Sub

   Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click
        SalesStaffBindingSource.AddNew()
        ToolStripButton5.Enabled = False
        ToolStripButton8.Enabled = False
        ToolStripButton1.Enabled = False
        ToolStripButton2.Enabled = False
        ToolStripButton3.Enabled = False
        ToolStripButton4.Enabled = False
   End Sub

   Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
      End
   End Sub

   Private Sub GridToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GridToolStripMenuItem.Click
      Me.Hide()
      frmGrid.Show()
      frmGrid.BringToFront()
   End Sub
End Class