Public Class FormClassGrid

    Private Sub FormClassGrid_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyCompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
        Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)
    End Sub

    Private Sub SalesStaffBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles SalesStaffBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.SalesStaffBindingSource.EndEdit()
            Me.SalesStaffTableAdapter.Update(Me.MyCompanyDataSet.SalesStaff)

            ' We added the button
            ToolStripButton1.Enabled = True
            BindingNavigatorMovePreviousItem.Enabled = True
            BindingNavigatorMoveFirstItem.Enabled = True
            BindingNavigatorMoveNextItem.Enabled = True
            BindingNavigatorMoveLastItem.Enabled = True

            SalesStaffBindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem
            SalesStaffBindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem
            SalesStaffBindingNavigator.MoveNextItem = BindingNavigatorMoveNextItem
            SalesStaffBindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FormClassGrid_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        Dim x As Integer
        Dim FormWidth As Integer = Me.ClientSize.Width
        Dim FormHeight As Integer = Me.ClientSize.Height

        x = (FormWidth - lblEmployees.Width) / 2
        lblEmployees.Left = x

        x = (FormWidth - SalesStaffDataGridView.Width) / 2
        SalesStaffDataGridView.Left = x

        x = (FormHeight - lblEmployees.Height - SalesStaffDataGridView.Height - SalesStaffBindingNavigator.Height) / 8
        lblEmployees.Top = 3 * x + SalesStaffBindingNavigator.Height
        SalesStaffDataGridView.Top = lblEmployees.Height + lblEmployees.Top + 2 * x
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        ' Have to set to Nothing first
        SalesStaffBindingNavigator.MovePreviousItem = Nothing
        SalesStaffBindingNavigator.MoveFirstItem = Nothing
        SalesStaffBindingNavigator.MoveNextItem = Nothing
        SalesStaffBindingNavigator.MoveLastItem = Nothing

        BindingNavigatorMovePreviousItem.Enabled = False
        BindingNavigatorMoveFirstItem.Enabled = False
        BindingNavigatorMoveNextItem.Enabled = False
        BindingNavigatorMoveLastItem.Enabled = False

        ' We added the button
        ToolStripButton1.Enabled = False
    End Sub

    Private Sub IndividualToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IndividualToolStripMenuItem.Click
        Me.Hide()
        frmIndividual.Show()
        frmIndividual.BringToFront()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        ToolStripButton1.Enabled = True
        BindingNavigatorMovePreviousItem.Enabled = True
        BindingNavigatorMoveFirstItem.Enabled = True
        BindingNavigatorMoveNextItem.Enabled = True
        BindingNavigatorMoveLastItem.Enabled = True

        SalesStaffBindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem
        SalesStaffBindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem
        SalesStaffBindingNavigator.MoveNextItem = BindingNavigatorMoveNextItem
        SalesStaffBindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem
    End Sub

    Private Sub FormClassGrid_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.ApplicationExitCall Then
            End
        Else
            e.Cancel = True
        End If
    End Sub
End Class
