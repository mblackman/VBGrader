Public Class Lab8

    Private Sub SalesStaffBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.SalesStaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MyCompanyDataSet)

    End Sub

    Private Sub Lab8_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyCompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
        Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)

        lblQuery.Text = "All Employees"
        lblDate.Text = Now.ToLongDateString
        lblTime.Text = Now.ToLongTimeString

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lblDate.Text = Now.ToLongDateString
        lblTime.Text = Now.ToLongTimeString

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Me.SalesStaffTableAdapter.FullTime(Me.MyCompanyDataSet.SalesStaff)
            lblQuery.Text = "Full Time Employees"
            lblDate.Text = Now.ToLongDateString
            lblTime.Text = Now.ToLongTimeString
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Application.Exit()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        Try
            Dim str As String

            str = InputBox("Enter the starting part of last name:", "Lab 8").Trim



            If str <> "" Then

                Me.SalesStaffTableAdapter.LastName(Me.MyCompanyDataSet.SalesStaff, str)
                lblQuery.Text = "Last Name starting with " + str

            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Try
            Me.SalesStaffTableAdapter.PartTime(Me.MyCompanyDataSet.SalesStaff)
            lblQuery.Text = "Part Time Employees"
            lblDate.Text = Now.ToLongDateString
            lblTime.Text = Now.ToLongTimeString
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)
        lblQuery.Text = "All Employees"
        lblDate.Text = Now.ToLongDateString
        lblTime.Text = Now.ToLongTimeString
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        Dim limit As String
        limit = InputBox("Enter the salary low limit: ", "Search on Salary")

        If IsNumeric(limit) And InStr(limit, "e", CompareMethod.Text) = 0 Then
            Try
                Me.SalesStaffTableAdapter.Salary(Me.MyCompanyDataSet.SalesStaff, CType(limit, Decimal))

                lblQuery.Text = "Salary >= " & Format(limit, "Currency")
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

        End If

    End Sub

    Private Sub Lab8_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim FormWidth As Integer
        Dim FormHeight As Integer
        Dim temp As Integer

        FormWidth = Me.ClientSize.Width
        FormHeight = Me.ClientSize.Height


        temp = (FormWidth - SalesStaffDataGridView.Width) / 2
        SalesStaffDataGridView.Left = temp
        temp = (FormWidth - lblEmployees.Width) / 2
        lblEmployees.Left = temp
        temp = (FormWidth - Label2.Width) / 2
        Label2.Left = temp


        temp = (FormHeight - lblEmployees.Height - SalesStaffDataGridView.Height - SalesStaffBindingNavigator.Height - Label2.Height) / 4
        lblEmployees.Top = temp + SalesStaffBindingNavigator.Height

        Label2.Top = temp + lblEmployees.Height + SalesStaffBindingNavigator.Height + (temp * 1 / 3)

        SalesStaffDataGridView.Top = temp * 2 + lblEmployees.Height + SalesStaffBindingNavigator.Height + Label2.Height
    End Sub
End Class
