<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container()
      Dim EmpIDLabel As System.Windows.Forms.Label
      Dim FirstNameLabel As System.Windows.Forms.Label
      Dim LastNameLabel As System.Windows.Forms.Label
      Dim RateLabel As System.Windows.Forms.Label
      Dim PasswordLabel As System.Windows.Forms.Label
      Dim AdminLabel As System.Windows.Forms.Label
      Dim HireDateLabel As System.Windows.Forms.Label
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
      Me.Test5DataSet = New AlexanderSam_Test51.Test5DataSet()
      Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.EmployeeTableAdapter = New AlexanderSam_Test51.Test5DataSetTableAdapters.EmployeeTableAdapter()
      Me.TableAdapterManager = New AlexanderSam_Test51.Test5DataSetTableAdapters.TableAdapterManager()
      Me.EmpIDTextBox = New System.Windows.Forms.TextBox()
      Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
      Me.LastNameTextBox = New System.Windows.Forms.TextBox()
      Me.RateTextBox = New System.Windows.Forms.TextBox()
      Me.PasswordTextBox = New System.Windows.Forms.TextBox()
      Me.AdminCheckBox = New System.Windows.Forms.CheckBox()
      Me.HireDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
      Me.EmpIDListBox = New System.Windows.Forms.ListBox()
      Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
      Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
      Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
      Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
      Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
      Me.EmployeeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
      EmpIDLabel = New System.Windows.Forms.Label()
      FirstNameLabel = New System.Windows.Forms.Label()
      LastNameLabel = New System.Windows.Forms.Label()
      RateLabel = New System.Windows.Forms.Label()
      PasswordLabel = New System.Windows.Forms.Label()
      AdminLabel = New System.Windows.Forms.Label()
      HireDateLabel = New System.Windows.Forms.Label()
      CType(Me.Test5DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ToolStrip1.SuspendLayout()
      CType(Me.EmployeeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'EmpIDLabel
      '
      EmpIDLabel.AutoSize = True
      EmpIDLabel.Location = New System.Drawing.Point(353, 75)
      EmpIDLabel.Name = "EmpIDLabel"
      EmpIDLabel.Size = New System.Drawing.Size(45, 13)
      EmpIDLabel.TabIndex = 1
      EmpIDLabel.Text = "Emp ID:"
      '
      'FirstNameLabel
      '
      FirstNameLabel.AutoSize = True
      FirstNameLabel.Location = New System.Drawing.Point(353, 108)
      FirstNameLabel.Name = "FirstNameLabel"
      FirstNameLabel.Size = New System.Drawing.Size(60, 13)
      FirstNameLabel.TabIndex = 2
      FirstNameLabel.Text = "First Name:"
      '
      'LastNameLabel
      '
      LastNameLabel.AutoSize = True
      LastNameLabel.Location = New System.Drawing.Point(353, 141)
      LastNameLabel.Name = "LastNameLabel"
      LastNameLabel.Size = New System.Drawing.Size(61, 13)
      LastNameLabel.TabIndex = 4
      LastNameLabel.Text = "Last Name:"
      '
      'RateLabel
      '
      RateLabel.AutoSize = True
      RateLabel.Location = New System.Drawing.Point(353, 174)
      RateLabel.Name = "RateLabel"
      RateLabel.Size = New System.Drawing.Size(33, 13)
      RateLabel.TabIndex = 6
      RateLabel.Text = "Rate:"
      '
      'PasswordLabel
      '
      PasswordLabel.AutoSize = True
      PasswordLabel.Location = New System.Drawing.Point(353, 207)
      PasswordLabel.Name = "PasswordLabel"
      PasswordLabel.Size = New System.Drawing.Size(56, 13)
      PasswordLabel.TabIndex = 8
      PasswordLabel.Text = "Password:"
      '
      'AdminLabel
      '
      AdminLabel.AutoSize = True
      AdminLabel.Location = New System.Drawing.Point(353, 240)
      AdminLabel.Name = "AdminLabel"
      AdminLabel.Size = New System.Drawing.Size(39, 13)
      AdminLabel.TabIndex = 10
      AdminLabel.Text = "Admin:"
      '
      'HireDateLabel
      '
      HireDateLabel.AutoSize = True
      HireDateLabel.Location = New System.Drawing.Point(353, 273)
      HireDateLabel.Name = "HireDateLabel"
      HireDateLabel.Size = New System.Drawing.Size(55, 13)
      HireDateLabel.TabIndex = 12
      HireDateLabel.Text = "Hire Date:"
      '
      'Test5DataSet
      '
      Me.Test5DataSet.DataSetName = "Test5DataSet"
      Me.Test5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
      '
      'EmployeeBindingSource
      '
      Me.EmployeeBindingSource.DataMember = "Employee"
      Me.EmployeeBindingSource.DataSource = Me.Test5DataSet
      '
      'EmployeeTableAdapter
      '
      Me.EmployeeTableAdapter.ClearBeforeFill = True
      '
      'TableAdapterManager
      '
      Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
      Me.TableAdapterManager.EmployeeTableAdapter = Me.EmployeeTableAdapter
      Me.TableAdapterManager.UpdateOrder = AlexanderSam_Test51.Test5DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
      '
      'EmpIDTextBox
      '
      Me.EmpIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "EmpID", True))
      Me.EmpIDTextBox.Location = New System.Drawing.Point(419, 72)
      Me.EmpIDTextBox.Name = "EmpIDTextBox"
      Me.EmpIDTextBox.Size = New System.Drawing.Size(100, 20)
      Me.EmpIDTextBox.TabIndex = 2
      '
      'FirstNameTextBox
      '
      Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "FirstName", True))
      Me.FirstNameTextBox.Location = New System.Drawing.Point(419, 105)
      Me.FirstNameTextBox.Name = "FirstNameTextBox"
      Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
      Me.FirstNameTextBox.TabIndex = 3
      '
      'LastNameTextBox
      '
      Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "LastName", True))
      Me.LastNameTextBox.Location = New System.Drawing.Point(419, 138)
      Me.LastNameTextBox.Name = "LastNameTextBox"
      Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
      Me.LastNameTextBox.TabIndex = 5
      '
      'RateTextBox
      '
      Me.RateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Rate", True))
      Me.RateTextBox.Location = New System.Drawing.Point(419, 171)
      Me.RateTextBox.Name = "RateTextBox"
      Me.RateTextBox.Size = New System.Drawing.Size(100, 20)
      Me.RateTextBox.TabIndex = 7
      '
      'PasswordTextBox
      '
      Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Password", True))
      Me.PasswordTextBox.Location = New System.Drawing.Point(419, 204)
      Me.PasswordTextBox.Name = "PasswordTextBox"
      Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
      Me.PasswordTextBox.TabIndex = 9
      '
      'AdminCheckBox
      '
      Me.AdminCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EmployeeBindingSource, "Admin", True))
      Me.AdminCheckBox.Location = New System.Drawing.Point(419, 237)
      Me.AdminCheckBox.Name = "AdminCheckBox"
      Me.AdminCheckBox.Size = New System.Drawing.Size(104, 25)
      Me.AdminCheckBox.TabIndex = 11
      Me.AdminCheckBox.UseVisualStyleBackColor = True
      '
      'HireDateDateTimePicker
      '
      Me.HireDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeeBindingSource, "HireDate", True))
      Me.HireDateDateTimePicker.Location = New System.Drawing.Point(419, 268)
      Me.HireDateDateTimePicker.Name = "HireDateDateTimePicker"
      Me.HireDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
      Me.HireDateDateTimePicker.TabIndex = 13
      '
      'EmpIDListBox
      '
      Me.EmpIDListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmployeeBindingSource, "EmpID", True))
      Me.EmpIDListBox.DataSource = Me.EmployeeBindingSource1
      Me.EmpIDListBox.DisplayMember = "EmpID"
      Me.EmpIDListBox.FormattingEnabled = True
      Me.EmpIDListBox.Location = New System.Drawing.Point(121, 105)
      Me.EmpIDListBox.Name = "EmpIDListBox"
      Me.EmpIDListBox.Size = New System.Drawing.Size(150, 186)
      Me.EmpIDListBox.TabIndex = 15
      '
      'ToolStrip1
      '
      Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripButton7, Me.ToolStripButton8, Me.ToolStripButton10, Me.ToolStripButton11})
      Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
      Me.ToolStrip1.Name = "ToolStrip1"
      Me.ToolStrip1.Size = New System.Drawing.Size(740, 25)
      Me.ToolStrip1.TabIndex = 16
      Me.ToolStrip1.Text = "ToolStrip1"
      '
      'ToolStripButton1
      '
      Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
      Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton1.Name = "ToolStripButton1"
      Me.ToolStripButton1.Size = New System.Drawing.Size(33, 22)
      Me.ToolStripButton1.Text = "First"
      '
      'ToolStripButton2
      '
      Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
      Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton2.Name = "ToolStripButton2"
      Me.ToolStripButton2.Size = New System.Drawing.Size(56, 22)
      Me.ToolStripButton2.Text = "Previous"
      '
      'ToolStripTextBox1
      '
      Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
      Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
      Me.ToolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'ToolStripLabel1
      '
      Me.ToolStripLabel1.Name = "ToolStripLabel1"
      Me.ToolStripLabel1.Size = New System.Drawing.Size(18, 22)
      Me.ToolStripLabel1.Text = "of"
      '
      'ToolStripButton4
      '
      Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
      Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton4.Name = "ToolStripButton4"
      Me.ToolStripButton4.Size = New System.Drawing.Size(32, 22)
      Me.ToolStripButton4.Text = "Last"
      '
      'ToolStripSeparator1
      '
      Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
      Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
      '
      'ToolStripButton5
      '
      Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.ToolStripButton5.Image = Global.AlexanderSam_Test51.My.Resources.Resources.AddTable
      Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton5.Name = "ToolStripButton5"
      Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
      Me.ToolStripButton5.Text = "Add New"
      '
      'ToolStripButton6
      '
      Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.ToolStripButton6.Image = Global.AlexanderSam_Test51.My.Resources.Resources.Delete
      Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton6.Name = "ToolStripButton6"
      Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
      Me.ToolStripButton6.Text = "Delete"
      '
      'ToolStripButton8
      '
      Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.ToolStripButton8.Image = Global.AlexanderSam_Test51.My.Resources.Resources.RefreshDocViewHS
      Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton8.Name = "ToolStripButton8"
      Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
      Me.ToolStripButton8.Text = "Reload"
      '
      'ToolStripButton7
      '
      Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.ToolStripButton7.Image = Global.AlexanderSam_Test51.My.Resources.Resources.Save
      Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton7.Name = "ToolStripButton7"
      Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
      Me.ToolStripButton7.Text = "Save"
      '
      'ToolStripButton10
      '
      Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
      Me.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton10.Name = "ToolStripButton10"
      Me.ToolStripButton10.Size = New System.Drawing.Size(78, 22)
      Me.ToolStripButton10.Text = "All Emplyees"
      '
      'ToolStripButton11
      '
      Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
      Me.ToolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton11.Name = "ToolStripButton11"
      Me.ToolStripButton11.Size = New System.Drawing.Size(29, 22)
      Me.ToolStripButton11.Text = "Exit"
      '
      'ToolStripButton3
      '
      Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
      Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton3.Name = "ToolStripButton3"
      Me.ToolStripButton3.Size = New System.Drawing.Size(35, 22)
      Me.ToolStripButton3.Text = "Next"
      '
      'EmployeeBindingSource1
      '
      Me.EmployeeBindingSource1.DataMember = "Employee"
      Me.EmployeeBindingSource1.DataSource = Me.Test5DataSet
      '
      'Form2
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(740, 368)
      Me.ControlBox = False
      Me.Controls.Add(Me.ToolStrip1)
      Me.Controls.Add(Me.EmpIDListBox)
      Me.Controls.Add(HireDateLabel)
      Me.Controls.Add(Me.HireDateDateTimePicker)
      Me.Controls.Add(AdminLabel)
      Me.Controls.Add(Me.AdminCheckBox)
      Me.Controls.Add(PasswordLabel)
      Me.Controls.Add(Me.PasswordTextBox)
      Me.Controls.Add(RateLabel)
      Me.Controls.Add(Me.RateTextBox)
      Me.Controls.Add(LastNameLabel)
      Me.Controls.Add(Me.LastNameTextBox)
      Me.Controls.Add(FirstNameLabel)
      Me.Controls.Add(Me.FirstNameTextBox)
      Me.Controls.Add(EmpIDLabel)
      Me.Controls.Add(Me.EmpIDTextBox)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
      Me.Name = "Form2"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Test5 (Sammy Alexander)"
      CType(Me.Test5DataSet, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ToolStrip1.ResumeLayout(False)
      Me.ToolStrip1.PerformLayout()
      CType(Me.EmployeeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents Test5DataSet As AlexanderSam_Test51.Test5DataSet
   Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
   Friend WithEvents EmployeeTableAdapter As AlexanderSam_Test51.Test5DataSetTableAdapters.EmployeeTableAdapter
   Friend WithEvents TableAdapterManager As AlexanderSam_Test51.Test5DataSetTableAdapters.TableAdapterManager
   Friend WithEvents EmpIDTextBox As System.Windows.Forms.TextBox
   Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
   Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
   Friend WithEvents RateTextBox As System.Windows.Forms.TextBox
   Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
   Friend WithEvents AdminCheckBox As System.Windows.Forms.CheckBox
   Friend WithEvents HireDateDateTimePicker As System.Windows.Forms.DateTimePicker
   Friend WithEvents EmpIDListBox As System.Windows.Forms.ListBox
   Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
   Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
   Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripButton11 As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
   Friend WithEvents EmployeeBindingSource1 As System.Windows.Forms.BindingSource
End Class
