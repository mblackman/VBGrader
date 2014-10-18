Public Class Form2
   'Prevents the user from closing the program with the Close button or presing Alt+F4
   Private Sub Form2_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
      UserClosingForm(e)
   End Sub

   Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      'This line of code loads data into the 'MyCompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
      Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)
      ToolStripTextBox1.Text = SalesStaffBindingSource.Position + 1
      ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count
      ToolStripButton1.Enabled = False
      ToolStripButton2.Enabled = False
   End Sub
   'Hides the frmIndividual window and shows the frmGrid window
   Private Sub GridToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GridToolStripMenuItem.Click
      frmIndividual.Hide()
      frmGrid.Show()
      frmGrid.BringToFront()
   End Sub
   'Exits the program
   Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
      Application.Exit()
   End Sub
   'Refreshes the window, updating all of the current data in the table
   Private Sub ToolStripButton8_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton8.Click
      Try
         Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)

      Catch ex As Exception
         MessageBox.Show(ex.Message)

      End Try

      ToolStripTextBox1.Text = 1
      ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count
      ToolStripButton1.Enabled = False
      ToolStripButton2.Enabled = False
      ToolStripButton3.Enabled = True
      ToolStripButton4.Enabled = True
      ToolStripButton5.Enabled = True
      ToolStripButton6.Enabled = True
      ToolStripButton7.Enabled = True
      ToolStripButton8.Enabled = True
   End Sub
   'Clicking this button will go back to the first item on the table
   Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
      SalesStaffBindingSource.MoveFirst()
      ToolStripTextBox1.Text = 1
      ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count
      ToolStripButton1.Enabled = False
      ToolStripButton2.Enabled = False
      ToolStripButton3.Enabled = True
      ToolStripButton4.Enabled = True
   End Sub
   'Clicking this button will go back to the previous item on the table
   Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
      SalesStaffBindingSource.MovePrevious()
      ToolStripTextBox1.Text = SalesStaffBindingSource.Position + 1
      If ToolStripTextBox1.Text = 1 Then
         ToolStripButton1.Enabled = False
         ToolStripButton2.Enabled = False
      Else
         ToolStripButton1.Enabled = True
         ToolStripButton2.Enabled = True
         ToolStripButton3.Enabled = True
         ToolStripButton4.Enabled = True
      End If
      ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count

   End Sub
   'Clicking this button will go back to the next item on the table
   Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
      SalesStaffBindingSource.MoveNext()
      ToolStripTextBox1.Text = SalesStaffBindingSource.Position + 1
      If ToolStripTextBox1.Text = SalesStaffBindingSource.Count Then
         ToolStripButton3.Enabled = False
         ToolStripButton4.Enabled = False
      Else
         ToolStripButton1.Enabled = True
         ToolStripButton2.Enabled = True
         ToolStripButton3.Enabled = True
         ToolStripButton4.Enabled = True
      End If
      ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count

   End Sub
   'Clicking this button will go back to the last item on the table
   Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
      SalesStaffBindingSource.MoveLast()
      ToolStripTextBox1.Text = SalesStaffBindingSource.Position + 1
      ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count
      ToolStripButton1.Enabled = True
      ToolStripButton2.Enabled = True
      ToolStripButton3.Enabled = False
      ToolStripButton4.Enabled = False
   End Sub
   'Saves all the data on the current table
   Private Sub ToolStripButton7_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton7.Click
      Try
         Me.Validate()
         Me.SalesStaffBindingSource.EndEdit()
         Me.TableAdapterManager.UpdateAll(Me.MyCompanyDataSet)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

      If ToolStripTextBox1.Text = SalesStaffBindingSource.Count Then
         ToolStripButton1.Enabled = True
         ToolStripButton2.Enabled = True
         ToolStripButton3.Enabled = False
         ToolStripButton4.Enabled = False
         ToolStripButton5.Enabled = True
         ToolStripButton8.Enabled = True
      End If
   End Sub
   'Adds a new person and their data to the table; Table size increases
   Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click
      ToolStripTextBox1.Text = SalesStaffBindingSource.Count + 1
      ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count + 1
      SalesStaffBindingSource.AddNew()
      ToolStripButton1.Enabled = False
      ToolStripButton2.Enabled = False
      ToolStripButton3.Enabled = False
      ToolStripButton4.Enabled = False
      ToolStripButton5.Enabled = False
      ToolStripButton8.Enabled = False
   End Sub
   'Removes a person and their data from the table; Table size decreases
   Private Sub ToolStripButton6_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton6.Click
      SalesStaffBindingSource.RemoveCurrent()
      ToolStripTextBox1.Text = SalesStaffBindingSource.Position + 1
      ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count
      If ToolStripTextBox1.Text = SalesStaffBindingSource.Count Then
         ToolStripButton1.Enabled = True
         ToolStripButton2.Enabled = True
         ToolStripButton3.Enabled = True
         ToolStripButton4.Enabled = True
         ToolStripButton5.Enabled = True
         ToolStripButton7.Enabled = True
         ToolStripButton8.Enabled = True
      End If

   End Sub
End Class