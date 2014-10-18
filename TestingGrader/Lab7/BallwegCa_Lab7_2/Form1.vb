Public Class Form1

    Private Sub SalesStaffBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles SalesStaffBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.SalesStaffBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MyCompanyDataSet)

            BindingNavigatorAddNewItem.Enabled = True
            Refresh.Enabled = True

            SalesStaffBindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem
            SalesStaffBindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem
            BindingNavigatorMoveFirstItem.Enabled = True
            BindingNavigatorMovePreviousItem.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.ApplicationExitCall Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'MyCompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
            Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub IndividualToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IndividualToolStripMenuItem.Click
        Me.Hide()
        frmIndividual.Show()
        frmIndividual.BringToFront()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        BindingNavigatorAddNewItem.Enabled = False
        Refresh.Enabled = False

        SalesStaffBindingNavigator.MoveFirstItem = Nothing
        SalesStaffBindingNavigator.MovePreviousItem = Nothing
        BindingNavigatorMoveFirstItem.Enabled = False
        BindingNavigatorMovePreviousItem.Enabled = False

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        BindingNavigatorAddNewItem.Enabled = True
        Refresh.Enabled = True
        SalesStaffBindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem
        SalesStaffBindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem
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
        temp = (FormWidth - SalesStaffDataGridView.Width) / 2
        SalesStaffDataGridView.Left = temp

      temp = (FormHeight - SalesStaffBindingNavigator.Height - Label1.Height - SalesStaffDataGridView.Height) / 4
      Label1.Top = temp + 2 * SalesStaffBindingNavigator.Height * (2 / 3)
      temp = (FormHeight - SalesStaffBindingNavigator.Height - Label1.Top - SalesStaffDataGridView.Height) / 4
      SalesStaffDataGridView.Top = temp + 15 + 2 * Label1.Top * (2 / 3)
    End Sub
End Class
