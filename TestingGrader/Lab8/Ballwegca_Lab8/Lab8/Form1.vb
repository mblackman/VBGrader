Public Class Form1

   Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
      If e.CloseReason = CloseReason.ApplicationExitCall Then
         End
      Else
         e.Cancel = True
      End If
   End Sub
   Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      Try
         Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)
         lblQuery.Text = "All Employees"
         lblDate.Text = Now.ToLongDateString
         lblTime.Text = Now.ToLongTimeString

      Catch ex As Exception
         System.Windows.Forms.MessageBox.Show(ex.Message)
      End Try
   End Sub

   Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
      Try
         Me.SalesStaffTableAdapter.FullTime(Me.MyCompanyDataSet.SalesStaff)
         lblQuery.Text = "Full Time Employees"
         lblDate.Text = Now.ToLongDateString
         lblTime.Text = Now.ToLongTimeString
      Catch ex As System.Exception
         System.Windows.Forms.MessageBox.Show(ex.Message)
      End Try
   End Sub

   Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
      Try
         Me.SalesStaffTableAdapter.PartTime(Me.MyCompanyDataSet.SalesStaff)
         lblQuery.Text = "Part Time Employees"
         lblDate.Text = Now.ToLongDateString
         lblTime.Text = Now.ToLongTimeString
      Catch ex As System.Exception
         System.Windows.Forms.MessageBox.Show(ex.Message)
      End Try
   End Sub

   Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
      Try
         Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)
         lblQuery.Text = "All Employees"
         lblDate.Text = Now.ToLongDateString
         lblTime.Text = Now.ToLongTimeString
      Catch ex As Exception
         System.Windows.Forms.MessageBox.Show(ex.Message)
      End Try
   End Sub

   Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
        Dim limit As String
        limit = InputBox("Enter the salary lower limit: ", "Search on Salary")

        If IsNumeric(limit) And InStr(limit, "e", CompareMethod.Text) = 0 Then
            Try
                Me.SalesStaffTableAdapter.SalaryGreaterThanOrEqualTo(Me.MyCompanyDataSet.SalesStaff, CType(limit, Decimal))

                lblQuery.Text = "Salary >= " & Format(limit, "Currency")
                lblDate.Text = Now.ToLongDateString
                lblTime.Text = Now.ToLongTimeString
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

   Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click
        Try
            Dim str As String
            str = InputBox("Enter the start of last name:", "Lab 8").Trim
            If str <> "" Then
                Me.SalesStaffTableAdapter.LastNameStartWith(Me.MyCompanyDataSet.SalesStaff, str)

            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
   End Sub

   Private Sub ToolStripButton6_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton6.Click
      End
   End Sub

   Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
      lblDate.Text = Now.ToLongDateString
      lblTime.Text = Now.ToLongTimeString
   End Sub

   Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
      Dim FormWidth As Integer
      Dim FormHeight As Integer
      Dim temp As Integer

      FormWidth = Me.ClientSize.Width
      FormHeight = Me.ClientSize.Height


      temp = (FormWidth - Label1.Width + (FormWidth * (2 / 5))) / 4
      Label1.Left = temp
      temp = (FormWidth - Label2.Width + (FormWidth * (1 / 3))) / 4
      Label2.Left = temp
      temp = (FormWidth - SalesStaffDataGridView.Width + (FormWidth * (3 / 8))) / 3
      SalesStaffDataGridView.Left = temp

      temp = (FormHeight - Label1.Height - Label2.Height - SalesStaffDataGridView.Height - SalesStaffBindingNavigator.Height) / 5
      Label1.Top = temp + (FormHeight * (1 / 3) / 2) - SalesStaffBindingNavigator.Height
      Label2.Top = temp + (FormHeight * (1 / 3) / 2) - SalesStaffBindingNavigator.Height + (FormHeight * (1 / 3) / 4)
      SalesStaffDataGridView.Top = temp + (FormHeight * (1 / 3) / 2) - SalesStaffBindingNavigator.Height + (FormHeight * (1 / 3) / 4) + (FormHeight * (1 / 3) / 3)


   End Sub
End Class
