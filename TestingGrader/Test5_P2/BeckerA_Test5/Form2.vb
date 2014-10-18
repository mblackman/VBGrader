Public Class FormClassList

    Private Sub EmployeeBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.EmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Test5DataSet)

    End Sub

    Private Sub FormClassList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Test5DataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.Test5DataSet.Employee)

        navMax.Text = "of " + Me.EmployeeBindingSource.Count.ToString
        navCurrent.Text = (Me.EmployeeBindingSource.Position + 1).ToString

        navFirst.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> 0)
        navPrevious.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> 0)
        navNext.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> (Me.EmployeeBindingSource.Count - 1))
        navLast.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> (Me.EmployeeBindingSource.Count - 1))
    End Sub

    Private Sub navExit_Click(sender As System.Object, e As System.EventArgs) Handles navExit.Click
        Application.Exit()
    End Sub

    Private Sub FormClassList_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.ApplicationExitCall Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub navAllEmployees_Click(sender As System.Object, e As System.EventArgs) Handles navAllEmployees.Click
        Me.Hide()
        frmAll.Show()
        frmAll.BringToFront()
    End Sub

    Private Sub navRefresh_Click(sender As System.Object, e As System.EventArgs) Handles navRefresh.Click
        Try
            Me.EmployeeTableAdapter.Fill(Me.Test5DataSet.Employee)
            navMax.Text = "of " + Me.EmployeeBindingSource.Count.ToString
            navCurrent.Text = (Me.EmployeeBindingSource.Position + 1).ToString

            navFirst.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> 0)
            navPrevious.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> 0)
            navNext.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> (Me.EmployeeBindingSource.Count - 1))
            navLast.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> (Me.EmployeeBindingSource.Count - 1))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub navFirst_Click(sender As System.Object, e As System.EventArgs) Handles navFirst.Click
        Me.EmployeeBindingSource.MoveFirst()

        navFirst.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> 0)
        navPrevious.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> 0)
        navNext.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> (Me.EmployeeBindingSource.Count - 1))
        navLast.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> (Me.EmployeeBindingSource.Count - 1))

        navCurrent.Text = (Me.EmployeeBindingSource.Position + 1).ToString
    End Sub

    Private Sub navPrevious_Click(sender As System.Object, e As System.EventArgs) Handles navPrevious.Click
        Me.EmployeeBindingSource.MovePrevious()

        navFirst.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> 0)
        navPrevious.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> 0)
        navNext.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> (Me.EmployeeBindingSource.Count - 1))
        navLast.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> (Me.EmployeeBindingSource.Count - 1))

        navCurrent.Text = (Me.EmployeeBindingSource.Position + 1).ToString
    End Sub

    Private Sub navNext_Click(sender As System.Object, e As System.EventArgs) Handles navNext.Click
        Me.EmployeeBindingSource.MoveNext()
        navFirst.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> 0)
        navPrevious.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> 0)
        navNext.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> (Me.EmployeeBindingSource.Count - 1))
        navLast.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> (Me.EmployeeBindingSource.Count - 1))
        navCurrent.Text = (Me.EmployeeBindingSource.Position + 1).ToString
    End Sub

    Private Sub navLast_Click(sender As System.Object, e As System.EventArgs) Handles navLast.Click
        Me.EmployeeBindingSource.MoveLast()

        navFirst.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> 0)
        navPrevious.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> 0)
        navNext.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> (Me.EmployeeBindingSource.Count - 1))
        navLast.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> (Me.EmployeeBindingSource.Count - 1))

        navCurrent.Text = (Me.EmployeeBindingSource.Position + 1).ToString
    End Sub

    Private Sub navAdd_Click(sender As System.Object, e As System.EventArgs) Handles navAdd.Click
        Try
            Me.EmployeeBindingSource.AddNew()
            navFirst.Enabled = False
            navPrevious.Enabled = False
            navNext.Enabled = False
            navLast.Enabled = False
            navRefresh.Enabled = False
            navAdd.Enabled = False
            navMax.Text = "of " + Me.EmployeeBindingSource.Count.ToString
            navCurrent.Text = (Me.EmployeeBindingSource.Position + 1).ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub navSave_Click(sender As System.Object, e As System.EventArgs) Handles navSave.Click
        Try
            Me.Validate()
            Me.EmployeeBindingSource.EndEdit()
            Me.EmployeeTableAdapter.Update(Me.Test5DataSet.Employee)

            navRefresh.Enabled = True
            navAdd.Enabled = True

            navFirst.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> 0)
            navPrevious.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> 0)
            navNext.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> (Me.EmployeeBindingSource.Count - 1))
            navLast.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> (Me.EmployeeBindingSource.Count - 1))

            navMax.Text = "of " + Me.EmployeeBindingSource.Count.ToString
            navCurrent.Text = (Me.EmployeeBindingSource.Position + 1).ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub navDelete_Click(sender As System.Object, e As System.EventArgs) Handles navDelete.Click
        Try
            Me.EmployeeBindingSource.RemoveCurrent()
            Me.Validate()
            Me.EmployeeBindingSource.EndEdit()
            Me.EmployeeTableAdapter.Update(Me.Test5DataSet.Employee)

            navMax.Text = "of " + Me.EmployeeBindingSource.Count.ToString
            navCurrent.Text = (Me.EmployeeBindingSource.Position + 1).ToString

            navRefresh.Enabled = True
            navAdd.Enabled = True

            navFirst.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> 0)
            navPrevious.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> 0)
            navNext.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> (Me.EmployeeBindingSource.Count - 1))
            navLast.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> (Me.EmployeeBindingSource.Count - 1))

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        navFirst.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> 0)
        navPrevious.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> 0)
        navNext.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> (Me.EmployeeBindingSource.Count - 1))
        navLast.Enabled = Convert.ToBoolean(Me.EmployeeBindingSource.Position <> (Me.EmployeeBindingSource.Count - 1))

        navCurrent.Text = (Me.EmployeeBindingSource.Position + 1).ToString
    End Sub
End Class