Public Class Form1

    Private Sub EmployeeBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles EmployeeBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.EmployeeBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Test5DataSet)

            BindingNavigatorAddNewItem.Enabled = True
            ToolStripButton1.Enabled = True
            EmployeeBindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem
            EmployeeBindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem
            BindingNavigatorMoveFirstItem.Enabled = True
            BindingNavigatorMovePreviousItem.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'Test5DataSet.Employee' table. You can move, or remove it, as needed.
            Me.EmployeeTableAdapter.Fill(Me.Test5DataSet.Employee)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Me.EmployeeTableAdapter.Fill(Me.Test5DataSet.Employee)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        End
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        BindingNavigatorAddNewItem.Enabled = False
        ToolStripButton1.Enabled = False
        EmployeeBindingNavigator.MoveFirstItem = Nothing
        EmployeeBindingNavigator.MovePreviousItem = Nothing
        BindingNavigatorMoveFirstItem.Enabled = False
        BindingNavigatorMovePreviousItem.Enabled = False
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        BindingNavigatorAddNewItem.Enabled = True
        ToolStripButton1.Enabled = True
        EmployeeBindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem
        EmployeeBindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem
        BindingNavigatorMoveFirstItem.Enabled = True
        BindingNavigatorMovePreviousItem.Enabled = True
    End Sub

    Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Dim FormWidth As Integer
        Dim FormHeight As Integer
        Dim temp As Integer

        FormWidth = Me.ClientSize.Width
        FormHeight = Me.ClientSize.Height

        temp = (FormWidth - Label1.Width) / 2
        Label1.Left = temp
        temp = (FormWidth - EmployeeDataGridView.Width) / 2
        EmployeeDataGridView.Left = temp

        temp = (FormHeight - EmployeeBindingNavigator.Height - Label1.Height - EmployeeDataGridView.Height) / 4
        Label1.Top = temp + 2 * EmployeeBindingNavigator.Height * (2 / 3)
        temp = (FormHeight - EmployeeBindingNavigator.Height - Label1.Top - EmployeeDataGridView.Height) / 4
        EmployeeDataGridView.Top = temp + 15 + 2 * Label1.Top * (2 / 3)
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        Me.Hide()
        frmList.Show()
        frmList.BringToFront()
    End Sub
End Class
