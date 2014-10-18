Public Class FormEmployees

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyCompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
        Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)
        stbTime.Text = TimeOfDay
        stbDate.Text = Format(Today, "D")
        stbQuery.Text = "All Employees"
    End Sub

    Private Sub tsbExit_Click(sender As System.Object, e As System.EventArgs) Handles tlbExit.Click
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        stbTime.Text = TimeOfDay
    End Sub

    Private Sub tlbPartTime_Click(sender As System.Object, e As System.EventArgs) Handles tlbPartTime.Click
        Try
            Me.SalesStaffTableAdapter.PartTime(Me.MyCompanyDataSet.SalesStaff)
            stbQuery.Text = "Part Time"
            stbTime.Text = TimeOfDay
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tlbAll_Click(sender As System.Object, e As System.EventArgs) Handles tlbAll.Click
        Try
            Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)
            stbTime.Text = TimeOfDay
            stbQuery.Text = "All Employees"
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tlbFullTime_Click(sender As System.Object, e As System.EventArgs) Handles tlbFullTime.Click
        Try
            Me.SalesStaffTableAdapter.FullTime(Me.MyCompanyDataSet.SalesStaff)
            stbTime.Text = TimeOfDay
            stbQuery.Text = "Full Time"
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tlbSalary_Click(sender As System.Object, e As System.EventArgs) Handles tlbSalary.Click
        Dim limit As String
        limit = InputBox("Enter the salary lower limit: ", "Search on Salary")
        If Not IsNumeric(limit) Or Not InStr(limit, "e", CompareMethod.Text) = 0 Then
            Exit Sub
        End If
        Try
            Me.SalesStaffTableAdapter.SalaryGreaterThanOrEqualTo(Me.MyCompanyDataSet.SalesStaff, CType(limit, Decimal))
            stbQuery.Text = "Salary >= " & Format(limit, "Currency")
            stbTime.Text = TimeOfDay
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tlbLastName_Click(sender As System.Object, e As System.EventArgs) Handles tlbLastName.Click
        Dim Name As String
        Name = InputBox("Enter the starting part of last name: ", "Search on Last Name")
        If Name.Trim = "" Then
            Exit Sub
        End If
        Try
            Me.SalesStaffTableAdapter.LastNameStartWith(Me.MyCompanyDataSet.SalesStaff, Name.Trim)
            stbQuery.Text = "Last Name Starting with """ + Name.Trim + """"
            stbTime.Text = TimeOfDay
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form1_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.ApplicationExitCall Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub FormEmployees_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        Dim x As Integer
        Dim FormWidth As Integer = Me.ClientSize.Width
        Dim FormHeight As Integer = Me.ClientSize.Height

        x = (FormWidth - lblEmployees.Width) / 8
        lblEmployees.Left = 3 * x

        x = (FormWidth - lblName.Width) / 5
        lblName.Left = 2 * x

        x = (FormWidth - SalesStaffDataGridView.Width) / 13
        SalesStaffDataGridView.Left = 8 * x

        x = (FormHeight - StatusStrip1.Height - SalesStaffBindingNavigator.Height -
             lblEmployees.Height - lblName.Height - SalesStaffDataGridView.Height) / 8

        lblEmployees.Top = SalesStaffBindingNavigator.Height + 3 * x
        lblName.Top = lblEmployees.Top + lblEmployees.Height + x
        SalesStaffDataGridView.Top = lblName.Top + lblName.Height + 2 * x
    End Sub
End Class
