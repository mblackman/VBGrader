Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      'TODO: This line of code loads data into the 'MyCompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
      Try
         Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)

      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
      SalesStaffDataGridView.Focus()
      Dim formwidth As Integer
      Dim formheight As Integer
      Dim temp As Integer
      formwidth = Me.ClientSize.Width
      formheight = Me.ClientSize.Height
      'resize height

      temp = (3 / 8) * (formheight - lbltitle.Height - bndNavigator.Height - SalesStaffDataGridView.Height)
      bndNavigator.Top = formheight
      lbltitle.Top = bndNavigator.Bottom + temp
      SalesStaffDataGridView.Top = lbltitle.Bottom + (2 / 3) * temp

      'resize width
      lbltitle.Left = (formwidth - lbltitle.Width) / 2
      SalesStaffDataGridView.Left = (formwidth - SalesStaffDataGridView.Width) / 2

   End Sub
   Private Sub SalesStaffBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                Handles SalesStaffBindingNavigatorSaveItem.Click
      Try
         Me.Validate()
         Me.SalesStaffBindingSource.EndEdit()
         Me.SalesStaffTableAdapter.Update(Me.MyCompanyDataSet.SalesStaff)
         BindingNavigatorAddNewItem.Enabled = True
         BindingNavigatorMovePreviousItem.Enabled = True
         bndNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

   End Sub
   Private Sub BindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
      BindingNavigatorAddNewItem.Enabled = False

      bndNavigator.MoveFirstItem = Nothing
      BindingNavigatorMoveFirstItem.Enabled = False
      bndNavigator.MovePreviousItem = Nothing
      BindingNavigatorMovePreviousItem.Enabled = False
   End Sub
   Private Sub BindingNavigatorDeleteItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
      BindingNavigatorAddNewItem.Enabled = True

      bndNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem
      BindingNavigatorMoveFirstItem.Enabled = True
   End Sub
   Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
      Try
         Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
   End Sub
   Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

   End Sub

    Private Sub BindingNavigatorCountItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorCountItem.Click

   End Sub

   Private Sub Form1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

   End Sub

   Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
      Dim formwidth As Integer
      Dim formheight As Integer
      Dim temp As Integer
      formwidth = Me.ClientSize.Width
      formheight = Me.ClientSize.Height
      'resize height

      temp = (3 / 8) * (formheight - lbltitle.Height - bndNavigator.Height - SalesStaffDataGridView.Height)
      bndNavigator.Top = formheight
      lbltitle.Top = bndNavigator.Bottom + temp
      SalesStaffDataGridView.Top = lbltitle.Bottom + (2 / 3) * temp

      'resize width
      lbltitle.Left = (formwidth - lbltitle.Width) / 2
      SalesStaffDataGridView.Left = (formwidth - SalesStaffDataGridView.Width) / 2

   End Sub

   Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
      Application.Exit()

   End Sub

   Private Sub IndividualToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IndividualToolStripMenuItem.Click
      Me.Hide()
      Form2.Show()
      Form2.BringToFront()

   End Sub
   Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) _
   Handles Me.FormClosing
      UserClosingForm(e)

   End Sub
End Class
