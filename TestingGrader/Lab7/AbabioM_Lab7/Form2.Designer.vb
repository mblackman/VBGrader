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
      Dim IDLabel As System.Windows.Forms.Label
      Dim LastNameLabel As System.Windows.Forms.Label
      Dim FirstNameLabel As System.Windows.Forms.Label
      Dim FullTimeLabel As System.Windows.Forms.Label
      Dim HireDateLabel As System.Windows.Forms.Label
      Dim SalaryLabel As System.Windows.Forms.Label
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
      Me.MyCompanyDataSet = New AbabioM_Lab7.MyCompanyDataSet()
      Me.SalesStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.SalesStaffTableAdapter = New AbabioM_Lab7.MyCompanyDataSetTableAdapters.SalesStaffTableAdapter()
      Me.TableAdapterManager = New AbabioM_Lab7.MyCompanyDataSetTableAdapters.TableAdapterManager()
      Me.IDTextBox = New System.Windows.Forms.TextBox()
      Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
      Me.GridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.LastNameTextBox = New System.Windows.Forms.TextBox()
      Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
      Me.FullTimeCheckBox = New System.Windows.Forms.CheckBox()
      Me.HireDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
      Me.SalaryTextBox = New System.Windows.Forms.TextBox()
      Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
      Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
      Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
      Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripLabel()
      Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
      Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
      Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
      Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
      IDLabel = New System.Windows.Forms.Label()
      LastNameLabel = New System.Windows.Forms.Label()
      FirstNameLabel = New System.Windows.Forms.Label()
      FullTimeLabel = New System.Windows.Forms.Label()
      HireDateLabel = New System.Windows.Forms.Label()
      SalaryLabel = New System.Windows.Forms.Label()
      CType(Me.MyCompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ContextMenuStrip1.SuspendLayout()
      Me.ToolStrip1.SuspendLayout()
      Me.SuspendLayout()
      '
      'IDLabel
      '
      IDLabel.AutoSize = True
      IDLabel.Location = New System.Drawing.Point(138, 76)
      IDLabel.Name = "IDLabel"
      IDLabel.Size = New System.Drawing.Size(21, 13)
      IDLabel.TabIndex = 1
      IDLabel.Text = "ID:"
      '
      'LastNameLabel
      '
      LastNameLabel.AutoSize = True
      LastNameLabel.Location = New System.Drawing.Point(138, 102)
      LastNameLabel.Name = "LastNameLabel"
      LastNameLabel.Size = New System.Drawing.Size(61, 13)
      LastNameLabel.TabIndex = 3
      LastNameLabel.Text = "Last Name:"
      '
      'FirstNameLabel
      '
      FirstNameLabel.AutoSize = True
      FirstNameLabel.Location = New System.Drawing.Point(138, 128)
      FirstNameLabel.Name = "FirstNameLabel"
      FirstNameLabel.Size = New System.Drawing.Size(60, 13)
      FirstNameLabel.TabIndex = 5
      FirstNameLabel.Text = "First Name:"
      '
      'FullTimeLabel
      '
      FullTimeLabel.AutoSize = True
      FullTimeLabel.Location = New System.Drawing.Point(138, 156)
      FullTimeLabel.Name = "FullTimeLabel"
      FullTimeLabel.Size = New System.Drawing.Size(52, 13)
      FullTimeLabel.TabIndex = 7
      FullTimeLabel.Text = "Full Time:"
      '
      'HireDateLabel
      '
      HireDateLabel.AutoSize = True
      HireDateLabel.Location = New System.Drawing.Point(138, 185)
      HireDateLabel.Name = "HireDateLabel"
      HireDateLabel.Size = New System.Drawing.Size(55, 13)
      HireDateLabel.TabIndex = 9
      HireDateLabel.Text = "Hire Date:"
      '
      'SalaryLabel
      '
      SalaryLabel.AutoSize = True
      SalaryLabel.Location = New System.Drawing.Point(138, 210)
      SalaryLabel.Name = "SalaryLabel"
      SalaryLabel.Size = New System.Drawing.Size(39, 13)
      SalaryLabel.TabIndex = 11
      SalaryLabel.Text = "Salary:"
      '
      'MyCompanyDataSet
      '
      Me.MyCompanyDataSet.DataSetName = "MyCompanyDataSet"
      Me.MyCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
      '
      'SalesStaffBindingSource
      '
      Me.SalesStaffBindingSource.DataMember = "SalesStaff"
      Me.SalesStaffBindingSource.DataSource = Me.MyCompanyDataSet
      '
      'SalesStaffTableAdapter
      '
      Me.SalesStaffTableAdapter.ClearBeforeFill = True
      '
      'TableAdapterManager
      '
      Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
      Me.TableAdapterManager.SalesStaffTableAdapter = Me.SalesStaffTableAdapter
      Me.TableAdapterManager.UpdateOrder = AbabioM_Lab7.MyCompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
      '
      'IDTextBox
      '
      Me.IDTextBox.ContextMenuStrip = Me.ContextMenuStrip1
      Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesStaffBindingSource, "ID", True))
      Me.IDTextBox.Location = New System.Drawing.Point(205, 73)
      Me.IDTextBox.Name = "IDTextBox"
      Me.IDTextBox.Size = New System.Drawing.Size(200, 20)
      Me.IDTextBox.TabIndex = 2
      '
      'ContextMenuStrip1
      '
      Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GridToolStripMenuItem, Me.ExitToolStripMenuItem})
      Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
      Me.ContextMenuStrip1.Size = New System.Drawing.Size(139, 48)
      '
      'GridToolStripMenuItem
      '
      Me.GridToolStripMenuItem.Name = "GridToolStripMenuItem"
      Me.GridToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
      Me.GridToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
      Me.GridToolStripMenuItem.Text = "Grid"
      '
      'ExitToolStripMenuItem
      '
      Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
      Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
      Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
      Me.ExitToolStripMenuItem.Text = "Exit"
      '
      'LastNameTextBox
      '
      Me.LastNameTextBox.ContextMenuStrip = Me.ContextMenuStrip1
      Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesStaffBindingSource, "LastName", True))
      Me.LastNameTextBox.Location = New System.Drawing.Point(205, 99)
      Me.LastNameTextBox.Name = "LastNameTextBox"
      Me.LastNameTextBox.Size = New System.Drawing.Size(200, 20)
      Me.LastNameTextBox.TabIndex = 4
      '
      'FirstNameTextBox
      '
      Me.FirstNameTextBox.ContextMenuStrip = Me.ContextMenuStrip1
      Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesStaffBindingSource, "FirstName", True))
      Me.FirstNameTextBox.Location = New System.Drawing.Point(205, 125)
      Me.FirstNameTextBox.Name = "FirstNameTextBox"
      Me.FirstNameTextBox.Size = New System.Drawing.Size(200, 20)
      Me.FirstNameTextBox.TabIndex = 6
      '
      'FullTimeCheckBox
      '
      Me.FullTimeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SalesStaffBindingSource, "FullTime", True))
      Me.FullTimeCheckBox.Location = New System.Drawing.Point(205, 151)
      Me.FullTimeCheckBox.Name = "FullTimeCheckBox"
      Me.FullTimeCheckBox.Size = New System.Drawing.Size(200, 24)
      Me.FullTimeCheckBox.TabIndex = 8
      Me.FullTimeCheckBox.UseVisualStyleBackColor = True
      '
      'HireDateDateTimePicker
      '
      Me.HireDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SalesStaffBindingSource, "HireDate", True))
      Me.HireDateDateTimePicker.Location = New System.Drawing.Point(205, 181)
      Me.HireDateDateTimePicker.Name = "HireDateDateTimePicker"
      Me.HireDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
      Me.HireDateDateTimePicker.TabIndex = 10
      '
      'SalaryTextBox
      '
      Me.SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesStaffBindingSource, "Salary", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C0"))
      Me.SalaryTextBox.Location = New System.Drawing.Point(205, 207)
      Me.SalaryTextBox.Name = "SalaryTextBox"
      Me.SalaryTextBox.Size = New System.Drawing.Size(200, 20)
      Me.SalaryTextBox.TabIndex = 12
      Me.SalaryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'ToolStrip1
      '
      Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripTextBox2, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripButton7, Me.ToolStripButton8})
      Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
      Me.ToolStrip1.Name = "ToolStrip1"
      Me.ToolStrip1.Size = New System.Drawing.Size(570, 25)
      Me.ToolStrip1.TabIndex = 13
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
      'ToolStripSeparator1
      '
      Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
      Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
      '
      'ToolStripTextBox1
      '
      Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
      Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
      Me.ToolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'ToolStripTextBox2
      '
      Me.ToolStripTextBox2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
      Me.ToolStripTextBox2.Size = New System.Drawing.Size(0, 22)
      '
      'ToolStripLabel1
      '
      Me.ToolStripLabel1.Name = "ToolStripLabel1"
      Me.ToolStripLabel1.Size = New System.Drawing.Size(89, 22)
      Me.ToolStripLabel1.Text = "ToolStripLabel1"
      '
      'ToolStripSeparator2
      '
      Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
      Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
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
      'ToolStripButton4
      '
      Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
      Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton4.Name = "ToolStripButton4"
      Me.ToolStripButton4.Size = New System.Drawing.Size(32, 22)
      Me.ToolStripButton4.Text = "Last"
      '
      'ToolStripSeparator3
      '
      Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
      Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
      '
      'ToolStripButton5
      '
      Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
      Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton5.Name = "ToolStripButton5"
      Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
      Me.ToolStripButton5.Text = "ToolStripButton5"
      Me.ToolStripButton5.ToolTipText = "Add New"
      '
      'ToolStripButton6
      '
      Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
      Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton6.Name = "ToolStripButton6"
      Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
      Me.ToolStripButton6.Text = "ToolStripButton6"
      Me.ToolStripButton6.ToolTipText = "Delete"
      '
      'ToolStripButton7
      '
      Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
      Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton7.Name = "ToolStripButton7"
      Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
      Me.ToolStripButton7.Text = "ToolStripButton7"
      Me.ToolStripButton7.ToolTipText = "Save"
      '
      'ToolStripButton8
      '
      Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
      Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton8.Name = "ToolStripButton8"
      Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
      Me.ToolStripButton8.Text = "ToolStripButton8"
      Me.ToolStripButton8.ToolTipText = "Refresh"
      '
      'Form2
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(570, 268)
      Me.ControlBox = False
      Me.Controls.Add(Me.ToolStrip1)
      Me.Controls.Add(IDLabel)
      Me.Controls.Add(Me.IDTextBox)
      Me.Controls.Add(LastNameLabel)
      Me.Controls.Add(Me.LastNameTextBox)
      Me.Controls.Add(FirstNameLabel)
      Me.Controls.Add(Me.FirstNameTextBox)
      Me.Controls.Add(FullTimeLabel)
      Me.Controls.Add(Me.FullTimeCheckBox)
      Me.Controls.Add(HireDateLabel)
      Me.Controls.Add(Me.HireDateDateTimePicker)
      Me.Controls.Add(SalaryLabel)
      Me.Controls.Add(Me.SalaryTextBox)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
      Me.Name = "Form2"
      Me.Text = "Lab7 (Michael Ababio)"
      CType(Me.MyCompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ContextMenuStrip1.ResumeLayout(False)
      Me.ToolStrip1.ResumeLayout(False)
      Me.ToolStrip1.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
    Friend WithEvents MyCompanyDataSet As AbabioM_Lab7.MyCompanyDataSet
    Friend WithEvents SalesStaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesStaffTableAdapter As AbabioM_Lab7.MyCompanyDataSetTableAdapters.SalesStaffTableAdapter
    Friend WithEvents TableAdapterManager As AbabioM_Lab7.MyCompanyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FullTimeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents HireDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SalaryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
   Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GridToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
End Class
