Public Class Form1
    Dim temp As Integer

    Private Sub EmployeeBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles EmployeeBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.EmployeeBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Test5DataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Test5DataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.Test5DataSet.Employee)

    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Application.Exit()
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Me.EmployeeTableAdapter.Fill(Me.Test5DataSet.Employee)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Dim FormWidth As Integer
        Dim FormHeight As Integer

        FormWidth = Me.ClientSize.Width
        FormHeight = Me.ClientSize.Height

        temp = ((FormWidth - Label1.Width) / 2)
        Label1.Left = temp

        temp = ((FormWidth - EmployeeDataGridView.Width) / 2)
        EmployeeDataGridView.Left = temp

        temp = ((FormHeight - EmployeeBindingNavigator.Height - Label1.Height - EmployeeDataGridView.Height) / 3)
        Label1.Top = EmployeeBindingNavigator.Height + temp
        EmployeeDataGridView.Top = EmployeeBindingNavigator.Height + temp + Label1.Height + temp
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        frmAll.Hide()
        frmList.Show()
        frmList.BringToFront()
    End Sub
End Class
