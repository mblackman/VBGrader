<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClassList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormClassList))
        Dim EmpIDLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim RateLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim AdminLabel As System.Windows.Forms.Label
        Dim HireDateLabel As System.Windows.Forms.Label
        Me.Test5DataSet = New BeckerA_Test5.Test5DataSet()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New BeckerA_Test5.Test5DataSetTableAdapters.EmployeeTableAdapter()
        Me.TableAdapterManager = New BeckerA_Test5.Test5DataSetTableAdapters.TableAdapterManager()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.navFirst = New System.Windows.Forms.ToolStripButton()
        Me.navPrevious = New System.Windows.Forms.ToolStripButton()
        Me.navCurrent = New System.Windows.Forms.ToolStripTextBox()
        Me.navNext = New System.Windows.Forms.ToolStripButton()
        Me.navLast = New System.Windows.Forms.ToolStripButton()
        Me.navMax = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.navAdd = New System.Windows.Forms.ToolStripButton()
        Me.navDelete = New System.Windows.Forms.ToolStripButton()
        Me.navSave = New System.Windows.Forms.ToolStripButton()
        Me.navRefresh = New System.Windows.Forms.ToolStripButton()
        Me.navAllEmployees = New System.Windows.Forms.ToolStripButton()
        Me.navExit = New System.Windows.Forms.ToolStripButton()
        Me.EmpIDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.RateTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.AdminCheckBox = New System.Windows.Forms.CheckBox()
        Me.HireDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
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
        Me.SuspendLayout()
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
        Me.TableAdapterManager.UpdateOrder = BeckerA_Test5.Test5DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.navFirst, Me.navPrevious, Me.navCurrent, Me.navMax, Me.navNext, Me.navLast, Me.ToolStripSeparator1, Me.navAdd, Me.navDelete, Me.navSave, Me.navRefresh, Me.navAllEmployees, Me.navExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(740, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'navFirst
        '
        Me.navFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.navFirst.Image = CType(resources.GetObject("navFirst.Image"), System.Drawing.Image)
        Me.navFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.navFirst.Name = "navFirst"
        Me.navFirst.Size = New System.Drawing.Size(33, 22)
        Me.navFirst.Text = "First"
        '
        'navPrevious
        '
        Me.navPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.navPrevious.Image = CType(resources.GetObject("navPrevious.Image"), System.Drawing.Image)
        Me.navPrevious.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.navPrevious.Name = "navPrevious"
        Me.navPrevious.Size = New System.Drawing.Size(56, 22)
        Me.navPrevious.Text = "Previous"
        '
        'navCurrent
        '
        Me.navCurrent.BackColor = System.Drawing.SystemColors.Window
        Me.navCurrent.Name = "navCurrent"
        Me.navCurrent.ReadOnly = True
        Me.navCurrent.Size = New System.Drawing.Size(100, 25)
        Me.navCurrent.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'navNext
        '
        Me.navNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.navNext.Image = CType(resources.GetObject("navNext.Image"), System.Drawing.Image)
        Me.navNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.navNext.Name = "navNext"
        Me.navNext.Size = New System.Drawing.Size(35, 22)
        Me.navNext.Text = "Next"
        '
        'navLast
        '
        Me.navLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.navLast.Image = CType(resources.GetObject("navLast.Image"), System.Drawing.Image)
        Me.navLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.navLast.Name = "navLast"
        Me.navLast.Size = New System.Drawing.Size(32, 22)
        Me.navLast.Text = "Last"
        '
        'navMax
        '
        Me.navMax.Name = "navMax"
        Me.navMax.Size = New System.Drawing.Size(89, 22)
        Me.navMax.Text = "ToolStripLabel1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'navAdd
        '
        Me.navAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.navAdd.Image = CType(resources.GetObject("navAdd.Image"), System.Drawing.Image)
        Me.navAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.navAdd.Name = "navAdd"
        Me.navAdd.Size = New System.Drawing.Size(23, 22)
        Me.navAdd.Text = "Add"
        '
        'navDelete
        '
        Me.navDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.navDelete.Image = CType(resources.GetObject("navDelete.Image"), System.Drawing.Image)
        Me.navDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.navDelete.Name = "navDelete"
        Me.navDelete.Size = New System.Drawing.Size(23, 22)
        Me.navDelete.Text = "Delete"
        '
        'navSave
        '
        Me.navSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.navSave.Image = CType(resources.GetObject("navSave.Image"), System.Drawing.Image)
        Me.navSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.navSave.Name = "navSave"
        Me.navSave.Size = New System.Drawing.Size(23, 22)
        Me.navSave.Text = "Save"
        '
        'navRefresh
        '
        Me.navRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.navRefresh.Image = CType(resources.GetObject("navRefresh.Image"), System.Drawing.Image)
        Me.navRefresh.ImageTransparentColor = System.Drawing.Color.Black
        Me.navRefresh.Name = "navRefresh"
        Me.navRefresh.Size = New System.Drawing.Size(23, 22)
        Me.navRefresh.Text = "Refresh"
        '
        'navAllEmployees
        '
        Me.navAllEmployees.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.navAllEmployees.Image = CType(resources.GetObject("navAllEmployees.Image"), System.Drawing.Image)
        Me.navAllEmployees.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.navAllEmployees.Name = "navAllEmployees"
        Me.navAllEmployees.Size = New System.Drawing.Size(85, 22)
        Me.navAllEmployees.Text = "All Employees"
        '
        'navExit
        '
        Me.navExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.navExit.Image = CType(resources.GetObject("navExit.Image"), System.Drawing.Image)
        Me.navExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.navExit.Name = "navExit"
        Me.navExit.Size = New System.Drawing.Size(29, 22)
        Me.navExit.Text = "Exit"
        '
        'EmpIDLabel
        '
        EmpIDLabel.AutoSize = True
        EmpIDLabel.Location = New System.Drawing.Point(374, 101)
        EmpIDLabel.Name = "EmpIDLabel"
        EmpIDLabel.Size = New System.Drawing.Size(45, 13)
        EmpIDLabel.TabIndex = 1
        EmpIDLabel.Text = "Emp ID:"
        EmpIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmpIDTextBox
        '
        Me.EmpIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "EmpID", True))
        Me.EmpIDTextBox.Location = New System.Drawing.Point(441, 98)
        Me.EmpIDTextBox.Name = "EmpIDTextBox"
        Me.EmpIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmpIDTextBox.TabIndex = 2
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(374, 127)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 3
        FirstNameLabel.Text = "First Name:"
        FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(441, 124)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FirstNameTextBox.TabIndex = 4
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(374, 153)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 5
        LastNameLabel.Text = "Last Name:"
        LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(441, 150)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LastNameTextBox.TabIndex = 6
        '
        'RateLabel
        '
        RateLabel.AutoSize = True
        RateLabel.Location = New System.Drawing.Point(374, 179)
        RateLabel.Name = "RateLabel"
        RateLabel.Size = New System.Drawing.Size(33, 13)
        RateLabel.TabIndex = 7
        RateLabel.Text = "Rate:"
        RateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RateTextBox
        '
        Me.RateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Rate", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.RateTextBox.Location = New System.Drawing.Point(441, 176)
        Me.RateTextBox.Name = "RateTextBox"
        Me.RateTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RateTextBox.TabIndex = 8
        Me.RateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(374, 205)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 9
        PasswordLabel.Text = "Password:"
        PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(441, 202)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PasswordTextBox.TabIndex = 10
        '
        'AdminLabel
        '
        AdminLabel.AutoSize = True
        AdminLabel.Location = New System.Drawing.Point(374, 233)
        AdminLabel.Name = "AdminLabel"
        AdminLabel.Size = New System.Drawing.Size(39, 13)
        AdminLabel.TabIndex = 11
        AdminLabel.Text = "Admin:"
        AdminLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdminCheckBox
        '
        Me.AdminCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EmployeeBindingSource, "Admin", True))
        Me.AdminCheckBox.Location = New System.Drawing.Point(441, 228)
        Me.AdminCheckBox.Name = "AdminCheckBox"
        Me.AdminCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.AdminCheckBox.TabIndex = 12
        Me.AdminCheckBox.UseVisualStyleBackColor = True
        '
        'HireDateLabel
        '
        HireDateLabel.AutoSize = True
        HireDateLabel.Location = New System.Drawing.Point(374, 261)
        HireDateLabel.Name = "HireDateLabel"
        HireDateLabel.Size = New System.Drawing.Size(55, 13)
        HireDateLabel.TabIndex = 13
        HireDateLabel.Text = "Hire Date:"
        HireDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HireDateDateTimePicker
        '
        Me.HireDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeeBindingSource, "HireDate", True))
        Me.HireDateDateTimePicker.Location = New System.Drawing.Point(441, 258)
        Me.HireDateDateTimePicker.Name = "HireDateDateTimePicker"
        Me.HireDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.HireDateDateTimePicker.TabIndex = 14
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.EmployeeBindingSource
        Me.ListBox1.DisplayMember = "EmpID"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(110, 101)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(159, 186)
        Me.ListBox1.TabIndex = 15
        Me.ListBox1.ValueMember = "EmpID"
        '
        'FormClassList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 368)
        Me.ControlBox = False
        Me.Controls.Add(Me.ListBox1)
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
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormClassList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Test5 (Alex Becker)"
        CType(Me.Test5DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Test5DataSet As BeckerA_Test5.Test5DataSet
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTableAdapter As BeckerA_Test5.Test5DataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents TableAdapterManager As BeckerA_Test5.Test5DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents navFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents navPrevious As System.Windows.Forms.ToolStripButton
    Friend WithEvents navCurrent As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents navMax As System.Windows.Forms.ToolStripLabel
    Friend WithEvents navNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents navLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents navAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents navDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents navSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents navRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents navAllEmployees As System.Windows.Forms.ToolStripButton
    Friend WithEvents navExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents EmpIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdminCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents HireDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
