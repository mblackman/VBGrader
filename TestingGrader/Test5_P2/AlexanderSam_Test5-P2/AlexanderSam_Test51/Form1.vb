Public Class Form1

    Private Sub EmployeeBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles EmployeeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Test5DataSet)
        BindingNavigatorAddNewItem.Enabled = True
        BindingNavigatorMoveFirstItem.Enabled = True
        BindingNavigatorMovePreviousItem.Enabled = True
        btnExit.Enabled = True
      btnReload.Enabled = True
      btnList.Enabled = True
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        UserClosingForm(e)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Test5DataSet.Employee' table. You can move, or remove it, as needed.
        Try
            Me.EmployeeTableAdapter.Fill(Me.Test5DataSet.Employee)
            btnReload.Width = 100
            btnExit.Width = 100
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub

    Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Dim formwidth As Integer
        Dim formheight As Integer
        Dim temp As Integer
        formwidth = Me.ClientSize.Width
        formheight = Me.ClientSize.Height
        'resize height
        temp = (formheight - EmployeeBindingNavigator.Height - lblTitle.Height - _
                EmployeeDataGridView.Height) / 3
        lblTitle.Top = EmployeeBindingNavigator.Bottom + temp
        EmployeeDataGridView.Top = lblTitle.Bottom + temp
        'resize width
        EmployeeDataGridView.Left = (formwidth - EmployeeDataGridView.Width) / 2
        lblTitle.Left = (formwidth - lblTitle.Width) / 2

    End Sub

    Private Sub btnReload_Click(sender As System.Object, e As System.EventArgs) Handles btnReload.Click
        Try
            Me.EmployeeTableAdapter.Fill(Me.Test5DataSet.Employee)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        BindingNavigatorAddNewItem.Enabled = False
      BindingNavigatorMoveFirstItem = Nothing
        BindingNavigatorMoveLastItem.Enabled = False
        BindingNavigatorMoveNextItem.Enabled = False
      BindingNavigatorMovePreviousItem = Nothing

        btnExit.Enabled = False
      btnReload.Enabled = False
      btnList.Enabled = False


    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        BindingNavigatorAddNewItem.Enabled = True
        BindingNavigatorMoveFirstItem.Enabled = True
        BindingNavigatorMovePreviousItem.Enabled = True
        btnExit.Enabled = True
      btnReload.Enabled = True
      btnList.Enabled = True

    End Sub

   Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles btnList.Click
      Me.Hide()
      Form2.Show()
      Form2.BringToFront()

   End Sub
End Class
