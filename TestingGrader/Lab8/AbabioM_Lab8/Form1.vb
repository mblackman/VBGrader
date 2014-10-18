Public Class Form1
    Dim temp As Integer
    'This is the Binding Navigator of SalesStaff. Controls how the list of Employees is updated. 
    Private Sub SalesStaffBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SalesStaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MyCompanyDataSet)

    End Sub

    'Attempts to show the list of employees and their information when the program initializes.
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            'TODO: This line of code loads data into the 'MyCompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
            Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)

            lblQuery.Text = "All Employees"
            lblDate.Text = Now.ToLongDateString
            lblTime.Text = Now.ToLongTimeString

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    'Ends the program when the Exit button is clicked.
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    'Displays only the list of employees that are Full Time. Updates the Query label to say "Full Time Employees".
    Private Sub btnFullTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFullTime.Click
        Try
            Me.SalesStaffTableAdapter.FullTime(Me.MyCompanyDataSet.SalesStaff)
            lblQuery.Text = "Full Time Employees"
            lblDate.Text = Now.ToLongDateString
            lblTime.Text = Now.ToLongTimeString
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Updates the clock on the program. Updates every 2 seconds.
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblDate.Text = Now.ToLongDateString
        lblTime.Text = Now.ToLongTimeString
    End Sub

    'Displays only the list of employees that are Part Time. Updates the Query label to say "Part Time Employees".
    Private Sub btnPartTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPartTime.Click
        Try
            Me.SalesStaffTableAdapter.PartTime(Me.MyCompanyDataSet.SalesStaff)
            lblQuery.Text = "Part Time Employees"
            lblDate.Text = Now.ToLongDateString
            lblTime.Text = Now.ToLongTimeString
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Displays the list of all employees. Updates the Query label to say "All Employees".
    Private Sub btnAllEmployees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllEmployees.Click
        Try
            Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)

            lblQuery.Text = "All Employees"
            lblDate.Text = Now.ToLongDateString
            lblTime.Text = Now.ToLongTimeString

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Searches the current list of employees for employees whose salary is greater than or equal to the user-inputted salary.
    Private Sub btnSalary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalary.Click
        Dim limit As String
        limit = InputBox("Enter the salary lower limit: ", "Search on Salary")

        If IsNumeric(limit) And InStr(limit, "e", CompareMethod.Text) = 0 Then
            Try
                Me.SalesStaffTableAdapter.SalaryGreaterThanOrEqualTo(Me.MyCompanyDataSet.SalesStaff, CType(limit, Decimal))
                lblQuery.Text = "Salary >= " & limit
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    'Searches the current list of employees for employees whose last name contains or is equal to the user-inputted last name.
    Private Sub btnLastName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLastName.Click
        Try
            Dim name, casename As String
            name = InputBox("Enter the starting part of last name: ", "Search on Last Name").Trim
            casename = name.Substring(0, 1).ToUpper()
            If name <> "" And name.Substring(0, 1) = casename Then
                Me.SalesStaffTableAdapter.LastNameStartsWith(Me.MyCompanyDataSet.SalesStaff, name)
                lblQuery.Text = "Last Name starting with " & """" & name & """"
            End If
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Handles resizing the window.
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim FormWidth As Integer
        Dim FormHeight As Integer

        FormWidth = Me.ClientSize.Width
        FormHeight = Me.ClientSize.Height

        temp = ((FormWidth - lblEmployees.Width) / (8 / 5))
        lblEmployees.Left = (3 / 5) * temp

        temp = ((FormWidth - lblCreated.Width) / (5 / 2))
        lblCreated.Left = lblEmployees.Left + (2 / 3)

        temp = ((FormWidth - SalesStaffDataGridView.Width) / (13 / 8))
        SalesStaffDataGridView.Left = temp + (5 / 8)
    End Sub
End Class
