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
      Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
      Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
      Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
      Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
      Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
      Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
      Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
      Me.MyCompanyDataSet = New AlexanderSam_Lab7.MyCompanyDataSet()
      Me.SalesStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.SalesStaffTableAdapter = New AlexanderSam_Lab7.MyCompanyDataSetTableAdapters.SalesStaffTableAdapter()
      Me.TableAdapterManager = New AlexanderSam_Lab7.MyCompanyDataSetTableAdapters.TableAdapterManager()
      Me.IDTextBox = New System.Windows.Forms.TextBox()
      Me.LastNameTextBox = New System.Windows.Forms.TextBox()
      Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
      Me.FullTimeCheckBox = New System.Windows.Forms.CheckBox()
      Me.HireDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
      Me.SalaryTextBox = New System.Windows.Forms.TextBox()
      Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
      Me.GroupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      IDLabel = New System.Windows.Forms.Label()
      LastNameLabel = New System.Windows.Forms.Label()
      FirstNameLabel = New System.Windows.Forms.Label()
      FullTimeLabel = New System.Windows.Forms.Label()
      HireDateLabel = New System.Windows.Forms.Label()
      SalaryLabel = New System.Windows.Forms.Label()
      Me.ToolStrip1.SuspendLayout()
      CType(Me.MyCompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ContextMenuStrip1.SuspendLayout()
      Me.SuspendLayout()
      '
      'IDLabel
      '
      IDLabel.AutoSize = True
      IDLabel.Location = New System.Drawing.Point(177, 51)
      IDLabel.Name = "IDLabel"
      IDLabel.Size = New System.Drawing.Size(21, 13)
      IDLabel.TabIndex = 12
      IDLabel.Text = "ID:"
      '
      'LastNameLabel
      '
      LastNameLabel.AutoSize = True
      LastNameLabel.Location = New System.Drawing.Point(177, 80)
      LastNameLabel.Name = "LastNameLabel"
      LastNameLabel.Size = New System.Drawing.Size(61, 13)
      LastNameLabel.TabIndex = 13
      LastNameLabel.Text = "Last Name:"
      '
      'FirstNameLabel
      '
      FirstNameLabel.AutoSize = True
      FirstNameLabel.Location = New System.Drawing.Point(177, 109)
      FirstNameLabel.Name = "FirstNameLabel"
      FirstNameLabel.Size = New System.Drawing.Size(60, 13)
      FirstNameLabel.TabIndex = 14
      FirstNameLabel.Text = "First Name:"
      '
      'FullTimeLabel
      '
      FullTimeLabel.AutoSize = True
      FullTimeLabel.Location = New System.Drawing.Point(177, 140)
      FullTimeLabel.Name = "FullTimeLabel"
      FullTimeLabel.Size = New System.Drawing.Size(52, 13)
      FullTimeLabel.TabIndex = 15
      FullTimeLabel.Text = "Full Time:"
      '
      'HireDateLabel
      '
      HireDateLabel.AutoSize = True
      HireDateLabel.Location = New System.Drawing.Point(177, 174)
      HireDateLabel.Name = "HireDateLabel"
      HireDateLabel.Size = New System.Drawing.Size(55, 13)
      HireDateLabel.TabIndex = 16
      HireDateLabel.Text = "Hire Date:"
      '
      'SalaryLabel
      '
      SalaryLabel.AutoSize = True
      SalaryLabel.Location = New System.Drawing.Point(177, 200)
      SalaryLabel.Name = "SalaryLabel"
      SalaryLabel.Size = New System.Drawing.Size(39, 13)
      SalaryLabel.TabIndex = 17
      SalaryLabel.Text = "Salary:"
      '
      'ToolStrip1
      '
      Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator3, Me.ToolStripButton4, Me.ToolStripButton3, Me.ToolStripSeparator2, Me.ToolStripButton6, Me.ToolStripButton5, Me.ToolStripButton7, Me.ToolStripButton8})
      Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
      Me.ToolStrip1.Name = "ToolStrip1"
      Me.ToolStrip1.Size = New System.Drawing.Size(623, 25)
      Me.ToolStrip1.TabIndex = 12
      Me.ToolStrip1.Text = "ToolStrip1"
      '
      'ToolStripButton1
      '
      Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
      Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton1.Name = "ToolStripButton1"
      Me.ToolStripButton1.Size = New System.Drawing.Size(57, 22)
      Me.ToolStripButton1.Text = "    First    "
      '
      'ToolStripButton2
      '
      Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
      Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton2.Name = "ToolStripButton2"
      Me.ToolStripButton2.Size = New System.Drawing.Size(62, 22)
      Me.ToolStripButton2.Text = "Previous  "
      '
      'ToolStripSeparator1
      '
      Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
      Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
      '
      'ToolStripTextBox1
      '
      Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
      Me.ToolStripTextBox1.ReadOnly = True
      Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
      Me.ToolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'ToolStripLabel1
      '
      Me.ToolStripLabel1.Name = "ToolStripLabel1"
      Me.ToolStripLabel1.Size = New System.Drawing.Size(51, 22)
      Me.ToolStripLabel1.Text = "    of 0    "
      '
      'ToolStripSeparator3
      '
      Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
      Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
      '
      'ToolStripButton4
      '
      Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
      Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton4.Name = "ToolStripButton4"
      Me.ToolStripButton4.Size = New System.Drawing.Size(53, 22)
      Me.ToolStripButton4.Text = "   Next   "
      '
      'ToolStripButton3
      '
      Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
      Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton3.Name = "ToolStripButton3"
      Me.ToolStripButton3.Size = New System.Drawing.Size(50, 22)
      Me.ToolStripButton3.Text = "   Last   "
      '
      'ToolStripSeparator2
      '
      Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
      Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
      '
      'ToolStripButton6
      '
      Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.ToolStripButton6.Image = Global.AlexanderSam_Lab7.My.Resources.Resources.AddTable
      Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton6.Name = "ToolStripButton6"
      Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
      Me.ToolStripButton6.Text = "ToolStripButton6"
      '
      'ToolStripButton5
      '
      Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.ToolStripButton5.Image = Global.AlexanderSam_Lab7.My.Resources.Resources.Delete
      Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton5.Name = "ToolStripButton5"
      Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
      Me.ToolStripButton5.Text = "ToolStripButton5"
      '
      'ToolStripButton7
      '
      Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.ToolStripButton7.Image = Global.AlexanderSam_Lab7.My.Resources.Resources.Save
      Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton7.Name = "ToolStripButton7"
      Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
      Me.ToolStripButton7.Text = "ToolStripButton7"
      '
      'ToolStripButton8
      '
      Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.ToolStripButton8.Image = Global.AlexanderSam_Lab7.My.Resources.Resources.RefreshDocViewHS
      Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton8.Name = "ToolStripButton8"
      Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
      Me.ToolStripButton8.Text = "ToolStripButton8"
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
      Me.TableAdapterManager.UpdateOrder = AlexanderSam_Lab7.MyCompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
      '
      'IDTextBox
      '
      Me.IDTextBox.ContextMenuStrip = Me.ContextMenuStrip1
      Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesStaffBindingSource, "ID", True))
      Me.IDTextBox.Location = New System.Drawing.Point(245, 48)
      Me.IDTextBox.Name = "IDTextBox"
      Me.IDTextBox.Size = New System.Drawing.Size(200, 20)
      Me.IDTextBox.TabIndex = 13
      '
      'LastNameTextBox
      '
      Me.LastNameTextBox.ContextMenuStrip = Me.ContextMenuStrip1
      Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesStaffBindingSource, "LastName", True))
      Me.LastNameTextBox.Location = New System.Drawing.Point(245, 77)
      Me.LastNameTextBox.Name = "LastNameTextBox"
      Me.LastNameTextBox.Size = New System.Drawing.Size(200, 20)
      Me.LastNameTextBox.TabIndex = 14
      '
      'FirstNameTextBox
      '
      Me.FirstNameTextBox.ContextMenuStrip = Me.ContextMenuStrip1
      Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesStaffBindingSource, "FirstName", True))
      Me.FirstNameTextBox.Location = New System.Drawing.Point(244, 106)
      Me.FirstNameTextBox.Name = "FirstNameTextBox"
      Me.FirstNameTextBox.Size = New System.Drawing.Size(200, 20)
      Me.FirstNameTextBox.TabIndex = 15
      '
      'FullTimeCheckBox
      '
      Me.FullTimeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SalesStaffBindingSource, "FullTime", True))
      Me.FullTimeCheckBox.Location = New System.Drawing.Point(245, 135)
      Me.FullTimeCheckBox.Name = "FullTimeCheckBox"
      Me.FullTimeCheckBox.Size = New System.Drawing.Size(104, 24)
      Me.FullTimeCheckBox.TabIndex = 16
      Me.FullTimeCheckBox.UseVisualStyleBackColor = True
      '
      'HireDateDateTimePicker
      '
      Me.HireDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SalesStaffBindingSource, "HireDate", True))
      Me.HireDateDateTimePicker.Location = New System.Drawing.Point(245, 168)
      Me.HireDateDateTimePicker.Name = "HireDateDateTimePicker"
      Me.HireDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
      Me.HireDateDateTimePicker.TabIndex = 17
      '
      'SalaryTextBox
      '
      Me.SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesStaffBindingSource, "Salary", True))
      Me.SalaryTextBox.Location = New System.Drawing.Point(244, 197)
      Me.SalaryTextBox.Name = "SalaryTextBox"
      Me.SalaryTextBox.Size = New System.Drawing.Size(200, 20)
      Me.SalaryTextBox.TabIndex = 18
      '
      'ContextMenuStrip1
      '
      Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GroupToolStripMenuItem, Me.ExitToolStripMenuItem})
      Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
      Me.ContextMenuStrip1.Size = New System.Drawing.Size(139, 48)
      '
      'GroupToolStripMenuItem
      '
      Me.GroupToolStripMenuItem.Name = "GroupToolStripMenuItem"
      Me.GroupToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
      Me.GroupToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
      Me.GroupToolStripMenuItem.Text = "Grid"
      '
      'ExitToolStripMenuItem
      '
      Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
      Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
      Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
      Me.ExitToolStripMenuItem.Text = "Exit"
      '
      'Form2
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(623, 264)
      Me.ControlBox = False
      Me.Controls.Add(SalaryLabel)
      Me.Controls.Add(Me.SalaryTextBox)
      Me.Controls.Add(HireDateLabel)
      Me.Controls.Add(Me.HireDateDateTimePicker)
      Me.Controls.Add(FullTimeLabel)
      Me.Controls.Add(Me.FullTimeCheckBox)
      Me.Controls.Add(FirstNameLabel)
      Me.Controls.Add(Me.FirstNameTextBox)
      Me.Controls.Add(LastNameLabel)
      Me.Controls.Add(Me.LastNameTextBox)
      Me.Controls.Add(IDLabel)
      Me.Controls.Add(Me.IDTextBox)
      Me.Controls.Add(Me.ToolStrip1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
      Me.Name = "Form2"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Lab 7 (Sammy Alexander)"
      Me.ToolStrip1.ResumeLayout(False)
      Me.ToolStrip1.PerformLayout()
      CType(Me.MyCompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ContextMenuStrip1.ResumeLayout(False)
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents MyCompanyDataSet As AlexanderSam_Lab7.MyCompanyDataSet
   Friend WithEvents SalesStaffBindingSource As System.Windows.Forms.BindingSource
   Friend WithEvents SalesStaffTableAdapter As AlexanderSam_Lab7.MyCompanyDataSetTableAdapters.SalesStaffTableAdapter
   Friend WithEvents TableAdapterManager As AlexanderSam_Lab7.MyCompanyDataSetTableAdapters.TableAdapterManager
   Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
   Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
   Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
   Friend WithEvents FullTimeCheckBox As System.Windows.Forms.CheckBox
   Friend WithEvents HireDateDateTimePicker As System.Windows.Forms.DateTimePicker
   Friend WithEvents SalaryTextBox As System.Windows.Forms.TextBox
   Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
   Friend WithEvents GroupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
