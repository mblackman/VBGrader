Public Class FormClassGrid

    Private Sub SalesStaffBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesStaffBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SalesStaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MyCompanyDataSet)

        BindingNavigatorAddNewItem.Enabled = True

        SalesStaffBindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem
        SalesStaffBindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem
        BindingNavigatorMoveFirstItem.Enabled = True
        BindingNavigatorMovePreviousItem.Enabled = True

    End Sub

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        UserClosingForm(e)
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyCompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
        Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)



    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub IndividualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndividualToolStripMenuItem.Click
        Me.Hide()
        FormClassIndividual.Show()
        FormClassIndividual.BringToFront()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        BindingNavigatorAddNewItem.Enabled = False

        SalesStaffBindingNavigator.MoveFirstItem = Nothing
        SalesStaffBindingNavigator.MovePreviousItem = Nothing
        BindingNavigatorMoveFirstItem.Enabled = False
        ToolStripButton1.Enabled = False
        BindingNavigatorMovePreviousItem.Enabled = False




    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BindingNavigatorMoveFirstItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMoveFirstItem.Click

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        BindingNavigatorAddNewItem.Enabled = True

        SalesStaffBindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem
        SalesStaffBindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem
        BindingNavigatorMoveFirstItem.Enabled = True
        BindingNavigatorMovePreviousItem.Enabled = True

    End Sub

    Private Sub SalesStaffBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesStaffBindingNavigator.RefreshItems

    End Sub

    Private Sub Form2_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim FormWidth As Integer
        Dim FormHeight As Integer
        Dim temp As Integer

        FormWidth = Me.ClientSize.Width
        FormHeight = Me.ClientSize.Height


        temp = (FormWidth - SalesStaffDataGridView.Width) / 2
        SalesStaffDataGridView.Left = temp
        temp = (FormWidth - lblEmployees.Width) / 2
        lblEmployees.Left = temp

        temp = (FormHeight - lblEmployees.Height - SalesStaffDataGridView.Height - SalesStaffBindingNavigator.Height) / 3
        lblEmployees.Top = temp + SalesStaffBindingNavigator.Height
        SalesStaffDataGridView.Top = temp * 2 + lblEmployees.Height + SalesStaffBindingNavigator.Height

    End Sub
End Class