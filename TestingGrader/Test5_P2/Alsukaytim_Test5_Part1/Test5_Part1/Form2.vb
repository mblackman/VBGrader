Public Class FormClassList

    Private Sub BindingNavigator1_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub EmployeeBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.EmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Test5DataSet)

    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        UserClosingForm(e)
    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Test5DataSet.Employee' table. You can move, or remove it, as needed.

        Me.EmployeeTableAdapter.Fill(Me.Test5DataSet.Employee)

        ToolStripTextBox1.Text = EmployeeBindingSource.Position + 1
        ToolStripLabel1.Text = " of " & EmployeeBindingSource.Count
    End Sub

    Private Sub btnFirst_Click(sender As System.Object, e As System.EventArgs) Handles btnFirst.Click
        EmployeeBindingSource.MoveFirst()

        ToolStripTextBox1.Text = 1
        ToolStripLabel1.Text = " of " & EmployeeBindingSource.Count
    End Sub

    Private Sub btnPrevious_Click(sender As System.Object, e As System.EventArgs) Handles btnPrevious.Click
        btnNext.Enabled = True
        btnLast.Enabled = True
        EmployeeBindingSource.MovePrevious()

        ToolStripTextBox1.Text = EmployeeBindingSource.Position + 1
        ToolStripLabel1.Text = " of " & EmployeeBindingSource.Count
    End Sub

    Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click
        EmployeeBindingSource.MoveNext()

        If (EmployeeBindingSource.Position + 1) = (EmployeeBindingSource.Count) Then

            btnLast.Enabled = False
            btnNext.Enabled = False

            ToolStripTextBox1.Text = EmployeeBindingSource.Position + 1
            ToolStripLabel1.Text = " of " & EmployeeBindingSource.Count
        End If

        ToolStripTextBox1.Text = EmployeeBindingSource.Position + 1
        ToolStripLabel1.Text = " of " & EmployeeBindingSource.Count
    End Sub

    Private Sub btnLast_Click(sender As System.Object, e As System.EventArgs) Handles btnLast.Click
        btnNext.Enabled = False
        btnLast.Enabled = False
        EmployeeBindingSource.MoveLast()

        ToolStripTextBox1.Text = EmployeeBindingSource.Position + 1
        ToolStripLabel1.Text = " of " & EmployeeBindingSource.Count
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        EmployeeBindingSource.AddNew()
        btnAdd.Enabled = False

        'btnFirst = Nothing
        btnFirst.Enabled = False
        btnRefresh.Enabled = False
        btnNext.Enabled = False
        btnLast.Enabled = False
        btnPrevious.Enabled = False
        ToolStripButton2.Enabled = False
        ToolStripButton1.Enabled = False

        ToolStripTextBox1.Text = EmployeeBindingSource.Position + 1
        ToolStripLabel1.Text = " of " & EmployeeBindingSource.Count
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        EmployeeBindingSource.RemoveCurrent()

        ToolStripTextBox1.Text = EmployeeBindingSource.Position + 1
        ToolStripLabel1.Text = " of " & EmployeeBindingSource.Count

        btnFirst.Enabled = True
        btnPrevious.Enabled = True
        btnRefresh.Enabled = True
        btnAdd.Enabled = True
        ToolStripButton2.Enabled = True
        ToolStripButton1.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Try
            Me.Validate()
            Me.EmployeeBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Test5DataSet)
            btnFirst.Enabled = True
            btnPrevious.Enabled = True
            btnRefresh.Enabled = True
            btnAdd.Enabled = True
            ToolStripButton2.Enabled = True
            ToolStripButton1.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        EmployeeBindingSource.MoveFirst()

        btnFirst.Enabled = False
        btnPrevious.Enabled = False
        btnNext.Enabled = True
        btnLast.Enabled = True

        ToolStripTextBox1.Text = 1
        ToolStripLabel1.Text = " of " & EmployeeBindingSource.Count
    End Sub
    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Application.Exit()
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Hide()
        frmAll.Show()
        frmAll.BringToFront()

    End Sub

    Private Sub ToolStripTextBox1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripTextBox1.Click

    End Sub
End Class