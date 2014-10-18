'----------------------------------------------
' Name       : Sammy Alexander
' Course     : CS2340, Section 1, Fall 2012
' Description: Lab 8
'              Form Form1
'----------------------------------------------
Public Class Form1
   Dim CaseSensitive As CompareMethod
   Private Sub SalesStaffBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
      Me.Validate()
      Me.SalesStaffBindingSource.EndEdit()
      Me.TableAdapterManager.UpdateAll(Me.MyCompanyDataSet)

   End Sub

   Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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

   Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

   End Sub

   Private Sub StatusStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

   End Sub

   Private Sub FillByToolStripButton_Click(sender As System.Object, e As System.EventArgs)
      Try
         Me.SalesStaffTableAdapter.FillBy(Me.MyCompanyDataSet.SalesStaff)
      Catch ex As System.Exception
         System.Windows.Forms.MessageBox.Show(ex.Message)
      End Try

   End Sub

   Private Sub ToolStripButton6_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton6.Click
      Application.Exit()

   End Sub

   Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
      Dim formwidth As Integer
      Dim formheight As Integer
      Dim temp As Integer
      formwidth = Me.ClientSize.Width
      formheight = Me.ClientSize.Height

      'resize width
      temp = (5 / 8) * (formwidth - Label1.Width)
      Label1.Left = temp * (3 / 5)
      temp = (3 / 5) * (formwidth - Label2.Width)
      Label2.Left = temp * (2 / 3)
      temp = (8 / 13) * (formwidth - SalesStaffDataGridView.Width)
      SalesStaffDataGridView.Left = temp * (5 / 8)
      'resize height
      temp = (3 / 8) * (formheight - SalesStaffBindingNavigator.Height - StatusStrip1.Height - _
                        Label1.Height - Label2.Height - SalesStaffDataGridView.Height)
      Label1.Top = SalesStaffBindingNavigator.Bottom + temp
      Label2.Top = Label1.Bottom + (1 / 3) * temp
      SalesStaffDataGridView.Top = Label2.Bottom + (2 / 3) * temp

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

   Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
      lblDate.Text = Now.ToLongDateString
      lblTime.Text = Now.ToLongTimeString
   End Sub

   Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
      Try
         Me.SalesStaffTableAdapter.AllEmployees(Me.MyCompanyDataSet.SalesStaff)
         lblQuery.Text = "All Employees"
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

   Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
      Dim limit As String
      limit = InputBox("Enter the salary lower limit: ", "Search on Salary")

      If IsNumeric(limit) And InStr(limit, "e", CompareMethod.Text) = 0 Then
         Try
            Me.SalesStaffTableAdapter.salaryis(Me.MyCompanyDataSet.SalesStaff, CType(limit, Decimal))


            lblQuery.Text = "Salary >= " & FormatCurrency(limit, 0, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault)
            'Format(limit, "Currency")
            lblDate.Text = Now.ToLongDateString
            lblTime.Text = Now.ToLongTimeString
         Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
         End Try

      End If
   End Sub

   Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click

      CaseSensitive = CompareMethod.Binary

      Try
         Dim str As String
         'Dim pos As Integer
         str = InputBox("Enter the start of last name:", "Lab 8").Trim
         'pos = InStr(1, str, str, CompareMethod.Binary)
         If str <> "" Then
            Me.SalesStaffTableAdapter.LastNameStartWith(Me.MyCompanyDataSet.SalesStaff, str)
            lblQuery.Text = "Last Name starting with " + """" + str + """"
            lblDate.Text = Now.ToLongDateString
            lblTime.Text = Now.ToLongTimeString
         End If
      Catch ex As System.Exception
         System.Windows.Forms.MessageBox.Show(ex.Message)
      End Try
   End Sub
End Class
