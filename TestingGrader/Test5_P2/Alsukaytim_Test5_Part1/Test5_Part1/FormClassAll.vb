Public Class FormClassAll


    Private Sub EmployeeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Test5DataSet)

        BindingNavigatorAddNewItem.Enabled = True
        BindingNavigatorMoveFirstItem.Enabled = True
        BindingNavigatorMovePreviousItem.Enabled = True
        ToolStripButton1.Enabled = True
        ToolStripButton2.Enabled = True
        EmployeeBindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem
        EmployeeBindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        UserClosingForm(e)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Test5DataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.Test5DataSet.Employee)

    End Sub

    Private Sub EmployeeDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles EmployeeDataGridView.CellContentClick

    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim FormWidth As Integer
        Dim FormHeight As Integer
        Dim temp As Integer

        FormWidth = Me.ClientSize.Width
        FormHeight = Me.ClientSize.Height


        temp = (FormWidth - EmployeeDataGridView.Width) / 2
        EmployeeDataGridView.Left = temp
        temp = (FormWidth - lblEmployees.Width) / 2
        lblEmployees.Left = temp

        temp = (FormHeight - lblEmployees.Height - EmployeeDataGridView.Height - EmployeeBindingNavigator.Height) / 3
        lblEmployees.Top = temp + EmployeeBindingNavigator.Height
        EmployeeDataGridView.Top = temp * 2 + lblEmployees.Height + EmployeeBindingNavigator.Height
    End Sub

    Private Sub EmployeeBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeBindingNavigator.RefreshItems

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Application.Exit()

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        Me.EmployeeTableAdapter.Fill(Me.Test5DataSet.Employee)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

        BindingNavigatorAddNewItem.Enabled = False
        EmployeeBindingNavigator.MoveFirstItem = Nothing
        EmployeeBindingNavigator.MovePreviousItem = Nothing
        BindingNavigatorMoveFirstItem.Enabled = False
        ToolStripButton1.Enabled = False
        ToolStripButton2.Enabled = False

        BindingNavigatorMovePreviousItem.Enabled = False
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        BindingNavigatorAddNewItem.Enabled = True
        BindingNavigatorMoveFirstItem.Enabled = True
        BindingNavigatorMovePreviousItem.Enabled = True
        ToolStripButton1.Enabled = True
        ToolStripButton2.Enabled = True
        EmployeeBindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem
        EmployeeBindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem


    End Sub
    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        Me.Hide()
        frmList.Show()
        frmList.BringToFront()

    End Sub
End Class