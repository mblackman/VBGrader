Public Class FormClassIndividual

    Private Sub SalesStaffBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.Validate()
            Me.SalesStaffBindingSource.EndEdit()
            Me.SalesStaffTableAdapter.Update(Me.MyCompanyDataSet.SalesStaff)

            tslMax.Text = "of " + Me.SalesStaffBindingSource.Count.ToString
            tstCurrent.Text = (Me.SalesStaffBindingSource.Position + 1).ToString

            If Me.SalesStaffBindingSource.Position = 0 Then
                tsbFirst.Enabled = False
                tsbPrevious.Enabled = False
            Else
                tsbFirst.Enabled = True
                tsbPrevious.Enabled = True
            End If

            If Me.SalesStaffBindingSource.Position = Me.SalesStaffBindingSource.Count Then
                tsbNext.Enabled = False
                tsbLast.Enabled = False
            Else
                tsbNext.Enabled = True
                tsbLast.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FormClassIndividual_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyCompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
        Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)
        tslMax.Text = "of " + Me.SalesStaffBindingSource.Count.ToString
        tstCurrent.Text = (Me.SalesStaffBindingSource.Position + 1).ToString
        If Me.SalesStaffBindingSource.Position = 0 Then
            tsbFirst.Enabled = False
            tsbPrevious.Enabled = False
        Else
            tsbFirst.Enabled = True
            tsbPrevious.Enabled = True
        End If

        If Me.SalesStaffBindingSource.Position = Me.SalesStaffBindingSource.Count Then
            tsbNext.Enabled = False
            tsbLast.Enabled = False
        Else
            tsbNext.Enabled = True
            tsbLast.Enabled = True
        End If

        Format("C", SalaryTextBox.Text)
    End Sub

    Private Sub tsbRefresh_Click(sender As System.Object, e As System.EventArgs) Handles tsbRefresh.Click
        Try
            Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)
            tslMax.Text = "of " + Me.SalesStaffBindingSource.Count.ToString
            tstCurrent.Text = (Me.SalesStaffBindingSource.Position + 1).ToString

            If Me.SalesStaffBindingSource.Position = 0 Then
                tsbFirst.Enabled = False
                tsbPrevious.Enabled = False
            Else
                tsbFirst.Enabled = True
                tsbPrevious.Enabled = True
            End If

            If Me.SalesStaffBindingSource.Position = Me.SalesStaffBindingSource.Count Then
                tsbNext.Enabled = False
                tsbLast.Enabled = False
            Else
                tsbNext.Enabled = True
                tsbLast.Enabled = True
            End If

            Format("C", SalaryTextBox.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tsbFirst_Click(sender As System.Object, e As System.EventArgs) Handles tsbFirst.Click
        Me.SalesStaffBindingSource.MoveFirst()
        tsbFirst.Enabled = False
        tsbPrevious.Enabled = False
        tsbNext.Enabled = True
        tsbLast.Enabled = True
        tstCurrent.Text = (Me.SalesStaffBindingSource.Position + 1).ToString
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub GridToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GridToolStripMenuItem.Click
        Me.Hide()
        frmGrid.Show()
        frmGrid.BringToFront()
    End Sub

    Private Sub tsbNext_Click(sender As System.Object, e As System.EventArgs) Handles tsbNext.Click
        Me.SalesStaffBindingSource.MoveNext()
        If Me.SalesStaffBindingSource.Position = Me.SalesStaffBindingSource.Count Then
            tsbNext.Enabled = False
            tsbLast.Enabled = False
        End If
        tsbFirst.Enabled = True
        tsbPrevious.Enabled = True
        tstCurrent.Text = (Me.SalesStaffBindingSource.Position + 1).ToString
    End Sub

    Private Sub tsbLast_Click(sender As System.Object, e As System.EventArgs) Handles tsbLast.Click
        Me.SalesStaffBindingSource.MoveLast()
        tsbFirst.Enabled = True
        tsbPrevious.Enabled = True
        tsbNext.Enabled = False
        tsbLast.Enabled = False
        tstCurrent.Text = (Me.SalesStaffBindingSource.Position + 1).ToString
    End Sub

    Private Sub tsbPrevious_Click(sender As System.Object, e As System.EventArgs) Handles tsbPrevious.Click
        Me.SalesStaffBindingSource.MovePrevious()
        If Me.SalesStaffBindingSource.Position = 0 Then
            tsbFirst.Enabled = False
            tsbPrevious.Enabled = False
        End If
        tsbNext.Enabled = True
        tsbLast.Enabled = True
        tstCurrent.Text = (Me.SalesStaffBindingSource.Position + 1).ToString
    End Sub

    Private Sub tsbNew_Click(sender As System.Object, e As System.EventArgs) Handles tsbNew.Click
        Try
            Me.SalesStaffBindingSource.AddNew()
            tsbFirst.Enabled = False
            tsbPrevious.Enabled = False
            tsbNext.Enabled = False
            tsbLast.Enabled = False
            tsbRefresh.Enabled = False
            tsbNew.Enabled = False
            tslMax.Text = "of " + Me.SalesStaffBindingSource.Count.ToString
            tstCurrent.Text = (Me.SalesStaffBindingSource.Position + 1).ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tsbSave_Click(sender As System.Object, e As System.EventArgs) Handles tsbSave.Click
        Try
            Me.Validate()
            Me.SalesStaffBindingSource.EndEdit()
            Me.SalesStaffTableAdapter.Update(Me.MyCompanyDataSet.SalesStaff)

            tsbRefresh.Enabled = True
            tsbNew.Enabled = True

            If Me.SalesStaffBindingSource.Position = 0 Then
                tsbFirst.Enabled = False
                tsbPrevious.Enabled = False
            Else
                tsbFirst.Enabled = True
                tsbPrevious.Enabled = True
            End If

            If Me.SalesStaffBindingSource.Position = Me.SalesStaffBindingSource.Count Then
                tsbNext.Enabled = False
                tsbLast.Enabled = False
            Else
                tsbNext.Enabled = True
                tsbLast.Enabled = True
            End If

            tslMax.Text = "of " + Me.SalesStaffBindingSource.Count.ToString
            tstCurrent.Text = (Me.SalesStaffBindingSource.Position + 1).ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tsbDelete_Click(sender As System.Object, e As System.EventArgs) Handles tsbDelete.Click
        Try
            Me.SalesStaffBindingSource.RemoveCurrent()
            Me.Validate()
            Me.SalesStaffBindingSource.EndEdit()
            Me.SalesStaffTableAdapter.Update(Me.MyCompanyDataSet.SalesStaff)

            tslMax.Text = "of " + Me.SalesStaffBindingSource.Count.ToString
            tstCurrent.Text = (Me.SalesStaffBindingSource.Position + 1).ToString

            tsbRefresh.Enabled = True
            tsbNew.Enabled = True

            If Me.SalesStaffBindingSource.Position = 0 Then
                tsbFirst.Enabled = False
                tsbPrevious.Enabled = False
            Else
                tsbFirst.Enabled = True
                tsbPrevious.Enabled = True
            End If

            If Me.SalesStaffBindingSource.Position = Me.SalesStaffBindingSource.Count Then
                tsbNext.Enabled = False
                tsbLast.Enabled = False
            Else
                tsbNext.Enabled = True
                tsbLast.Enabled = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FormClassIndividual_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.ApplicationExitCall Then
            End
        Else
            e.Cancel = True
        End If
    End Sub
End Class