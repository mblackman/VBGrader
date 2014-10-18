Public Class Form1
   Dim temp As Double
   'Saves the current table and data
    Private Sub SalesStaffBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesStaffBindingNavigatorSaveItem.Click
      Try
         Me.Validate()
         Me.SalesStaffBindingSource.EndEdit()
         Me.TableAdapterManager.UpdateAll(Me.MyCompanyDataSet)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

    End Sub
   'Prevents the user from closing the program with the Close button or presing Alt+F4
    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        UserClosingForm(e)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      'This line of code loads data into the 'MyCompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
        Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)

    End Sub
   'This refreshes the table, showing the current data for each column as saved
    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
   'Exits the program
    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
   'Shows the frmIndividual window after hiding the current window
    Private Sub IndividualToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IndividualToolStripMenuItem.Click
        frmGrid.Hide()
        frmIndividual.Show()
        frmIndividual.BringToFront()
    End Sub
   'Resizes the FrmGrid window
   Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
      Dim FormWidth As Integer
      Dim FormHeight As Integer

      FormWidth = Me.ClientSize.Width
      FormHeight = Me.ClientSize.Height

      temp = ((FormWidth - Label1.Width) / 2)
      Label1.Left = temp

      temp = ((FormWidth - SalesStaffDataGridView.Width) / 2)
      SalesStaffDataGridView.Left = temp

      temp = ((FormHeight - Label1.Height - SalesStaffDataGridView.Height) / (8 / 3))
      Label1.Top = temp / (2 / 3)
      SalesStaffDataGridView.Top = temp + Label1.Height + temp
   End Sub
End Class
