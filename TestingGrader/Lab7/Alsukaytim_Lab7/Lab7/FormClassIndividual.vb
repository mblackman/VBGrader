Public Class FormClassIndividual

    Private Sub FormClassIndividual_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        UserClosingForm(e)
    End Sub

    Private Sub FormClassIndividual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyCompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
        Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)


        ToolStripTextBox1.Text = SalesStaffBindingSource.Position + 1
        ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count
    End Sub

    Private Sub ToolStripTextBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SalesStaffBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SalesStaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MyCompanyDataSet)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        SalesStaffBindingSource.MoveFirst()

        ToolStripTextBox1.Text = 1
        ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        btnNext.Enabled = True
        btnLast.Enabled = True
        SalesStaffBindingSource.MovePrevious()

        ToolStripTextBox1.Text = SalesStaffBindingSource.Position + 1
        ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        SalesStaffBindingSource.MoveNext()

        If (SalesStaffBindingSource.Position + 1) = (SalesStaffBindingSource.Count) Then

            btnLast.Enabled = False
            btnNext.Enabled = False

            ToolStripTextBox1.Text = SalesStaffBindingSource.Position + 1
            ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count
        End If

        ToolStripTextBox1.Text = SalesStaffBindingSource.Position + 1
        ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count
       
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click

        btnNext.Enabled = False
        btnLast.Enabled = False
        SalesStaffBindingSource.MoveLast()

        ToolStripTextBox1.Text = SalesStaffBindingSource.Position + 1
        ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count
        


    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        SalesStaffBindingSource.AddNew()
        btnAdd.Enabled = False

        'btnFirst = Nothing
        btnFirst.Enabled = False
        btnRefresh.Enabled = False
        btnNext.Enabled = False
        btnLast.Enabled = False
        btnPrevious.Enabled = False

        ToolStripTextBox1.Text = SalesStaffBindingSource.Position + 1
        ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count

    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        SalesStaffBindingSource.RemoveCurrent()

        ToolStripTextBox1.Text = SalesStaffBindingSource.Position + 1
        ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count

        btnFirst.Enabled = True
        btnPrevious.Enabled = True
        btnRefresh.Enabled = True
        btnAdd.Enabled = True
        'SalesStaffBindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem
        'BindingNavigatorMoveFirstItem.Enabled = True
        'BindingNavigatorMovePreviousItem.Enabled = True

    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Me.Validate()
            Me.SalesStaffBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MyCompanyDataSet)
            btnFirst.Enabled = True
            btnPrevious.Enabled = True
            btnRefresh.Enabled = True
            btnAdd.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()


    End Sub

    Private Sub IndividualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndividualToolStripMenuItem.Click
        Me.Hide()
        frmGrid.Show()
        frmGrid.BringToFront()

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        SalesStaffBindingSource.MoveFirst()

        btnFirst.Enabled = False
        btnPrevious.Enabled = False
        btnNext.Enabled = True
        btnLast.Enabled = True

        ToolStripTextBox1.Text = 1
        ToolStripLabel1.Text = " of " & SalesStaffBindingSource.Count
    End Sub
End Class