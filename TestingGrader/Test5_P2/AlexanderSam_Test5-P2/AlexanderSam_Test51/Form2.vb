Public Class Form2

    Private Sub EmployeeBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.EmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Test5DataSet)

    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Test5DataSet.Employee' table. You can move, or remove it, as needed.
      Me.EmployeeTableAdapter.Fill(Me.Test5DataSet.Employee)

      ToolStripTextBox1.Text = EmployeeBindingSource.Position + 1
      ToolStripLabel1.Text = " of " & EmployeeBindingSource.Count
      ToolStripButton1.Enabled = False
      ToolStripButton2.Enabled = False
    End Sub

   Private Sub ToolStripButton10_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton10.Click
      Me.Hide()
      Form1.Show()
      Form1.BringToFront()

   End Sub

   Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
      EmployeeBindingSource.MoveFirst()

      ToolStripTextBox1.Text = 1
      ToolStripLabel1.Text = "of " & EmployeeBindingSource.Count
      ToolStripButton1.Enabled = False
      ToolStripButton2.Enabled = False
      ToolStripButton3.Enabled = True
      ToolStripButton4.Enabled = True
   End Sub

   Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
      EmployeeBindingSource.MoveLast()

      ToolStripTextBox1.Text = EmployeeBindingSource.Position + 1
      ToolStripLabel1.Text = " of " & EmployeeBindingSource.Count
      ToolStripButton3.Enabled = False
      ToolStripButton4.Enabled = False
      ToolStripButton1.Enabled = True
      ToolStripButton2.Enabled = True
   End Sub

   Private Sub ToolStripButton11_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton11.Click
      Application.Exit()

   End Sub

   Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
      EmployeeBindingSource.MovePrevious()

      ToolStripTextBox1.Text = EmployeeBindingSource.Position + 1
      ToolStripLabel1.Text = " of " & EmployeeBindingSource.Count
      If EmployeeBindingSource.Position < 1 Then
         ToolStripButton1.Enabled = False
         ToolStripButton2.Enabled = False
      Else
         EnableButtons()

      End If
   End Sub
   Private Sub EnableButtons()
      ToolStripButton1.Enabled = True
      ToolStripButton2.Enabled = True
      ToolStripButton3.Enabled = True
      ToolStripButton4.Enabled = True
      ToolStripButton5.Enabled = True
   End Sub
   Private Sub DisableButtons()
      ToolStripButton1.Enabled = False
      ToolStripButton2.Enabled = False
      ToolStripButton3.Enabled = False
      ToolStripButton4.Enabled = False
      ToolStripButton5.Enabled = False
   End Sub

   Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
      EmployeeBindingSource.MoveNext()
      ToolStripTextBox1.Text = EmployeeBindingSource.Position + 1
      ToolStripLabel1.Text = " of " & EmployeeBindingSource.Count
      If EmployeeBindingSource.Position + 1 = EmployeeBindingSource.Count Then
         ToolStripButton3.Enabled = False
         ToolStripButton4.Enabled = False
      Else
         EnableButtons()
      End If
   End Sub

   Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click
      EmployeeBindingSource.AddNew()
      EmployeeBindingSource.MoveLast()
      ToolStripTextBox1.Text = EmployeeBindingSource.Position + 1
      ToolStripLabel1.Text = " of " & EmployeeBindingSource.Count

      DisableButtons()
      ToolStripButton8.Enabled = False
   End Sub
   Private Sub ShowRecordCount()
      ToolStripTextBox1.Text = EmployeeBindingSource.Position + 1
      ToolStripLabel1.Text = " of " & EmployeeBindingSource.Count
   End Sub
   Private Sub ToolStripButton7_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton7.Click
      Try
         Me.Validate()
         Me.EmployeeBindingSource.EndEdit()
         Me.TableAdapterManager.UpdateAll(Me.Test5DataSet)
         EnableButtons()
         ShowRecordCount()
         ToolStripButton8.Enabled = True
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
   End Sub

   Private Sub ToolStripButton6_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton6.Click
      EmployeeBindingSource.RemoveCurrent()

      ToolStripTextBox1.Text = EmployeeBindingSource.Position + 1
      ToolStripLabel1.Text = " of " & EmployeeBindingSource.Count
      If EmployeeBindingSource.Position + 1 = EmployeeBindingSource.Count Then
         ToolStripButton4.Enabled = False
         ToolStripButton3.Enabled = False
         ToolStripButton1.Enabled = True
         ToolStripButton2.Enabled = True
      ElseIf EmployeeBindingSource.Position < 1 Then
         ToolStripButton1.Enabled = False
         ToolStripButton2.Enabled = False
         ToolStripButton3.Enabled = True
         ToolStripButton4.Enabled = True
      Else
         EnableButtons()


      End If
      ToolStripButton5.Enabled = True
      ToolStripButton8.Enabled = True
   End Sub

   Private Sub ToolStripButton8_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton8.Click
      Try
         Me.EmployeeTableAdapter.Fill(Me.Test5DataSet.Employee)
         EnableButtons()
         ShowRecordCount()

      Catch ex As Exception
         MessageBox.Show(ex.Message)

      End Try
   End Sub

   Private Sub EmpIDListBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles EmpIDListBox.SelectedIndexChanged

   End Sub
End Class