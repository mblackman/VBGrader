Public Class FormClassAll

    Private Sub EmployeeBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles EmployeeBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.EmployeeBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Test5DataSet)

            BindingNavigatorMovePreviousItem.Enabled = True
            BindingNavigatorMoveFirstItem.Enabled = True
            BindingNavigatorMoveNextItem.Enabled = True
            BindingNavigatorMoveLastItem.Enabled = True
            BindingNavigatorAddNewItem.Enabled = True
            navReload.Enabled = True
            navList.Enabled = True
            navExit.Enabled = True

            EmployeeBindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem
            EmployeeBindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem
            EmployeeBindingNavigator.MoveNextItem = BindingNavigatorMoveNextItem
            EmployeeBindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem
            EmployeeBindingNavigator.AddNewItem = BindingNavigatorAddNewItem
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FormClassAll_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Test5DataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.Test5DataSet.Employee)
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles navReload.Click
        Try
            Me.EmployeeTableAdapter.Fill(Me.Test5DataSet.Employee)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles navExit.Click
        Application.Exit()
    End Sub

    Private Sub FormClassAll_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.ApplicationExitCall Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        EmployeeBindingNavigator.MoveFirstItem = Nothing
        EmployeeBindingNavigator.MovePreviousItem = Nothing
        EmployeeBindingNavigator.MoveNextItem = Nothing
        EmployeeBindingNavigator.MoveLastItem = Nothing
        EmployeeBindingNavigator.AddNewItem = Nothing

        BindingNavigatorMovePreviousItem.Enabled = False
        BindingNavigatorMoveFirstItem.Enabled = False
        BindingNavigatorMoveNextItem.Enabled = False
        BindingNavigatorMoveLastItem.Enabled = False
        BindingNavigatorAddNewItem.Enabled = False
        navReload.Enabled = False
        navList.Enabled = False
        navExit.Enabled = False
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        BindingNavigatorMovePreviousItem.Enabled = True
        BindingNavigatorMoveFirstItem.Enabled = True
        BindingNavigatorMoveNextItem.Enabled = True
        BindingNavigatorMoveLastItem.Enabled = True
        BindingNavigatorAddNewItem.Enabled = True
        navReload.Enabled = True
        navList.Enabled = True
        navExit.Enabled = True

        EmployeeBindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem
        EmployeeBindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem
        EmployeeBindingNavigator.MoveNextItem = BindingNavigatorMoveNextItem
        EmployeeBindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem
        EmployeeBindingNavigator.AddNewItem = BindingNavigatorAddNewItem
    End Sub

    Private Sub FormClassAll_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        Dim x As Integer
        Dim FormWidth As Integer = Me.ClientSize.Width
        Dim FormHeight As Integer = Me.ClientSize.Height

        x = (FormWidth - lblEmployees.Width) / 2
        lblEmployees.Left = x

        x = (FormWidth - EmployeeDataGridView.Width) / 2
        EmployeeDataGridView.Left = x

        x = (FormHeight - lblEmployees.Height - EmployeeDataGridView.Height - EmployeeBindingNavigator.Height) / 3
        lblEmployees.Top = EmployeeBindingNavigator.Height + x
        EmployeeDataGridView.Top = lblEmployees.Top + lblEmployees.Height + x
    End Sub

    Private Sub navList_Click(sender As System.Object, e As System.EventArgs) Handles navList.Click
        Me.Hide()
        frmList.Show()
        frmList.BringToFront()
    End Sub
End Class
