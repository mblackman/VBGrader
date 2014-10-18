Public Class Form2

   Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

   End Sub

   Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
      SalesStaffBindingSource.MoveFirst()

      ToolStripTextBox1.Text = 1
      ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count
      ToolStripButton1.Enabled = False
      ToolStripButton2.Enabled = False
      ToolStripButton3.Enabled = True
      ToolStripButton4.Enabled = True
   End Sub

    Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click
      SalesStaffBindingSource.RemoveCurrent()

      ToolStripTextBox1.Text = SalesStaffBindingSource.Position + 1
      ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count
      If SalesStaffBindingSource.Position + 1 = SalesStaffBindingSource.Count Then
         ToolStripButton4.Enabled = False
         ToolStripButton3.Enabled = False
         ToolStripButton1.Enabled = True
         ToolStripButton2.Enabled = True
      ElseIf SalesStaffBindingSource.Position < 1 Then
         ToolStripButton1.Enabled = False
         ToolStripButton2.Enabled = False
         ToolStripButton3.Enabled = True
         ToolStripButton4.Enabled = True
      Else
         EnableButtons()


      End If
      ToolStripButton6.Enabled = True
      ToolStripButton8.Enabled = True
   End Sub
   Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) _
Handles Me.FormClosing
      UserClosingForm(e)

   End Sub

   Private Sub SalesStaffBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
      Try
         Me.Validate()
         Me.SalesStaffBindingSource.EndEdit()
         Me.TableAdapterManager.UpdateAll(Me.MyCompanyDataSet)
         ShowRecordCount()
         EnableButtons()
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

   End Sub
   Private Sub EnableButtons()
      ToolStripButton1.Enabled = True
      ToolStripButton2.Enabled = True
      ToolStripButton3.Enabled = True
      ToolStripButton4.Enabled = True
      ToolStripButton6.Enabled = True
   End Sub
   Private Sub DisableButtons()
      ToolStripButton1.Enabled = False
      ToolStripButton2.Enabled = False
      ToolStripButton3.Enabled = False
      ToolStripButton4.Enabled = False
      ToolStripButton6.Enabled = False
   End Sub
   Private Sub ShowRecordCount()
      ToolStripTextBox1.Text = SalesStaffBindingSource.Position + 1
      ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count
   End Sub

   Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      'TODO: This line of code loads data into the 'MyCompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
      Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)

      ToolStripTextBox1.Text = SalesStaffBindingSource.Position + 1
      ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count
      ToolStripButton1.Enabled = False
      ToolStripButton2.Enabled = False
   End Sub

   Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
      Application.Exit()

   End Sub

   Private Sub GroupToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GroupToolStripMenuItem.Click
      Me.Hide()
      Form1.Show()
      Form1.BringToFront()

   End Sub

   Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
      SalesStaffBindingSource.MovePrevious()

      ToolStripTextBox1.Text = SalesStaffBindingSource.Position + 1
      ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count
      If SalesStaffBindingSource.Position < 1 Then
         ToolStripButton1.Enabled = False
         ToolStripButton2.Enabled = False
      Else
         EnableButtons()

      End If
   End Sub

   Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
      SalesStaffBindingSource.MoveNext()
      ToolStripTextBox1.Text = SalesStaffBindingSource.Position + 1
      ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count
      If SalesStaffBindingSource.Position + 1 = SalesStaffBindingSource.Count Then
         ToolStripButton3.Enabled = False
         ToolStripButton4.Enabled = False
      Else
         EnableButtons()
      End If
   End Sub

   Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
      SalesStaffBindingSource.MoveLast()

      ToolStripTextBox1.Text = SalesStaffBindingSource.Position + 1
      ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count
      ToolStripButton3.Enabled = False
      ToolStripButton4.Enabled = False
      ToolStripButton1.Enabled = True
      ToolStripButton2.Enabled = True
   End Sub

   Private Sub ToolStripButton6_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton6.Click
      SalesStaffBindingSource.AddNew()
      SalesStaffBindingSource.MoveLast()
      ToolStripTextBox1.Text = SalesStaffBindingSource.Position + 1
      ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count

      DisableButtons()
      ToolStripButton8.Enabled = False

   End Sub

   Private Sub ToolStripButton7_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton7.Click
      Try
         Me.Validate()
         Me.SalesStaffBindingSource.EndEdit()
         Me.TableAdapterManager.UpdateAll(Me.MyCompanyDataSet)
         EnableButtons()
         ShowRecordCount()
         ToolStripButton8.Enabled = True
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
   End Sub

   Private Sub ToolStripButton8_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton8.Click
      Try
         Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)
         EnableButtons()
         ShowRecordCount()

      Catch ex As Exception
         MessageBox.Show(ex.Message)

      End Try
   End Sub
End Class