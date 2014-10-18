<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
      Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle44 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle45 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Me.MyCompanyDataSet = New AlexanderSam_Lab8.MyCompanyDataSet()
      Me.SalesStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.SalesStaffTableAdapter = New AlexanderSam_Lab8.MyCompanyDataSetTableAdapters.SalesStaffTableAdapter()
      Me.TableAdapterManager = New AlexanderSam_Lab8.MyCompanyDataSetTableAdapters.TableAdapterManager()
      Me.SalesStaffBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
      Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
      Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
      Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
      Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
      Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
      Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
      Me.SalesStaffDataGridView = New System.Windows.Forms.DataGridView()
      Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
      Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
      Me.lblQuery = New System.Windows.Forms.ToolStripStatusLabel()
      Me.lblSpring = New System.Windows.Forms.ToolStripStatusLabel()
      Me.lblDate = New System.Windows.Forms.ToolStripStatusLabel()
      Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
      Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
      Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
      CType(Me.MyCompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.SalesStaffBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SalesStaffBindingNavigator.SuspendLayout()
      CType(Me.SalesStaffDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.StatusStrip1.SuspendLayout()
      Me.SuspendLayout()
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
      Me.TableAdapterManager.UpdateOrder = AlexanderSam_Lab8.MyCompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
      '
      'SalesStaffBindingNavigator
      '
      Me.SalesStaffBindingNavigator.AddNewItem = Nothing
      Me.SalesStaffBindingNavigator.BackColor = System.Drawing.SystemColors.ControlDark
      Me.SalesStaffBindingNavigator.BindingSource = Me.SalesStaffBindingSource
      Me.SalesStaffBindingNavigator.CountItem = Me.BindingNavigatorCountItem
      Me.SalesStaffBindingNavigator.DeleteItem = Nothing
      Me.SalesStaffBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripButton6})
      Me.SalesStaffBindingNavigator.Location = New System.Drawing.Point(0, 0)
      Me.SalesStaffBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
      Me.SalesStaffBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
      Me.SalesStaffBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
      Me.SalesStaffBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
      Me.SalesStaffBindingNavigator.Name = "SalesStaffBindingNavigator"
      Me.SalesStaffBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
      Me.SalesStaffBindingNavigator.Size = New System.Drawing.Size(784, 25)
      Me.SalesStaffBindingNavigator.TabIndex = 0
      Me.SalesStaffBindingNavigator.Text = "BindingNavigator1"
      '
      'BindingNavigatorCountItem
      '
      Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
      Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
      Me.BindingNavigatorCountItem.Text = "of {0}"
      Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
      '
      'BindingNavigatorMoveFirstItem
      '
      Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
      Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorMoveFirstItem.Text = "Move first"
      '
      'BindingNavigatorMovePreviousItem
      '
      Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
      Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
      '
      'BindingNavigatorSeparator
      '
      Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
      Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
      '
      'BindingNavigatorPositionItem
      '
      Me.BindingNavigatorPositionItem.AccessibleName = "Position"
      Me.BindingNavigatorPositionItem.AutoSize = False
      Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
      Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
      Me.BindingNavigatorPositionItem.Text = "0"
      Me.BindingNavigatorPositionItem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
      Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
      '
      'BindingNavigatorSeparator1
      '
      Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
      Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
      '
      'BindingNavigatorMoveNextItem
      '
      Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
      Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorMoveNextItem.Text = "Move next"
      '
      'BindingNavigatorMoveLastItem
      '
      Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
      Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorMoveLastItem.Text = "Move last"
      '
      'BindingNavigatorSeparator2
      '
      Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
      Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
      '
      'ToolStripButton1
      '
      Me.ToolStripButton1.AutoSize = False
      Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
      Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton1.Name = "ToolStripButton1"
      Me.ToolStripButton1.Size = New System.Drawing.Size(75, 22)
      Me.ToolStripButton1.Text = "Full Time"
      '
      'ToolStripButton2
      '
      Me.ToolStripButton2.AutoSize = False
      Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
      Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton2.Name = "ToolStripButton2"
      Me.ToolStripButton2.Size = New System.Drawing.Size(75, 22)
      Me.ToolStripButton2.Text = "Part Time"
      '
      'ToolStripButton3
      '
      Me.ToolStripButton3.AutoSize = False
      Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
      Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton3.Name = "ToolStripButton3"
      Me.ToolStripButton3.Size = New System.Drawing.Size(100, 22)
      Me.ToolStripButton3.Text = "All Employees"
      '
      'ToolStripButton4
      '
      Me.ToolStripButton4.AutoSize = False
      Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
      Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton4.Name = "ToolStripButton4"
      Me.ToolStripButton4.Size = New System.Drawing.Size(100, 22)
      Me.ToolStripButton4.Text = "Search on Salary"
      '
      'ToolStripButton5
      '
      Me.ToolStripButton5.AutoSize = False
      Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
      Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton5.Name = "ToolStripButton5"
      Me.ToolStripButton5.Size = New System.Drawing.Size(130, 22)
      Me.ToolStripButton5.Text = "Search on Last Name"
      Me.ToolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
      '
      'ToolStripButton6
      '
      Me.ToolStripButton6.AutoSize = False
      Me.ToolStripButton6.BackColor = System.Drawing.SystemColors.ControlDark
      Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
      Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton6.Name = "ToolStripButton6"
      Me.ToolStripButton6.Size = New System.Drawing.Size(100, 22)
      Me.ToolStripButton6.Text = "Exit"
      '
      'SalesStaffDataGridView
      '
      Me.SalesStaffDataGridView.AutoGenerateColumns = False
      Me.SalesStaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.SalesStaffDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
      Me.SalesStaffDataGridView.DataSource = Me.SalesStaffBindingSource
      Me.SalesStaffDataGridView.Location = New System.Drawing.Point(132, 93)
      Me.SalesStaffDataGridView.Name = "SalesStaffDataGridView"
      Me.SalesStaffDataGridView.ReadOnly = True
      Me.SalesStaffDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.SalesStaffDataGridView.Size = New System.Drawing.Size(520, 220)
      Me.SalesStaffDataGridView.TabIndex = 1
      '
      'DataGridViewTextBoxColumn1
      '
      Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
      DataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle41
      Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
      Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
      Me.DataGridViewTextBoxColumn1.ReadOnly = True
      Me.DataGridViewTextBoxColumn1.Width = 50
      '
      'DataGridViewTextBoxColumn2
      '
      Me.DataGridViewTextBoxColumn2.DataPropertyName = "LastName"
      DataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle42
      Me.DataGridViewTextBoxColumn2.HeaderText = "LastName"
      Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
      Me.DataGridViewTextBoxColumn2.ReadOnly = True
      Me.DataGridViewTextBoxColumn2.Width = 95
      '
      'DataGridViewTextBoxColumn3
      '
      Me.DataGridViewTextBoxColumn3.DataPropertyName = "FirstName"
      DataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle43
      Me.DataGridViewTextBoxColumn3.HeaderText = "FirstName"
      Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
      Me.DataGridViewTextBoxColumn3.ReadOnly = True
      Me.DataGridViewTextBoxColumn3.Width = 95
      '
      'DataGridViewCheckBoxColumn1
      '
      Me.DataGridViewCheckBoxColumn1.DataPropertyName = "FullTime"
      Me.DataGridViewCheckBoxColumn1.HeaderText = "FullTime"
      Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
      Me.DataGridViewCheckBoxColumn1.ReadOnly = True
      Me.DataGridViewCheckBoxColumn1.Width = 70
      '
      'DataGridViewTextBoxColumn4
      '
      Me.DataGridViewTextBoxColumn4.DataPropertyName = "HireDate"
      DataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
      DataGridViewCellStyle44.Format = "d"
      DataGridViewCellStyle44.NullValue = Nothing
      Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle44
      Me.DataGridViewTextBoxColumn4.HeaderText = "HireDate"
      Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
      Me.DataGridViewTextBoxColumn4.ReadOnly = True
      Me.DataGridViewTextBoxColumn4.Width = 80
      '
      'DataGridViewTextBoxColumn5
      '
      Me.DataGridViewTextBoxColumn5.DataPropertyName = "Salary"
      DataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
      DataGridViewCellStyle45.Format = "C0"
      DataGridViewCellStyle45.NullValue = Nothing
      Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle45
      Me.DataGridViewTextBoxColumn5.HeaderText = "Salary"
      Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
      Me.DataGridViewTextBoxColumn5.ReadOnly = True
      Me.DataGridViewTextBoxColumn5.Width = 70
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(233, 32)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(127, 25)
      Me.Label1.TabIndex = 2
      Me.Label1.Text = "Employees"
      Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(234, 57)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(261, 24)
      Me.Label2.TabIndex = 3
      Me.Label2.Text = "Created by Sammy Alexander"
      Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'StatusStrip1
      '
      Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ControlDark
      Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblQuery, Me.lblSpring, Me.ToolStripStatusLabel1, Me.lblDate, Me.lblTime})
      Me.StatusStrip1.Location = New System.Drawing.Point(0, 390)
      Me.StatusStrip1.Name = "StatusStrip1"
      Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
      Me.StatusStrip1.TabIndex = 4
      Me.StatusStrip1.Text = "StatusStrip1"
      '
      'lblQuery
      '
      Me.lblQuery.AutoSize = False
      Me.lblQuery.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
      Me.lblQuery.Name = "lblQuery"
      Me.lblQuery.Size = New System.Drawing.Size(150, 17)
      Me.lblQuery.Text = "ToolStripStatusLabel1"
      '
      'lblSpring
      '
      Me.lblSpring.Name = "lblSpring"
      Me.lblSpring.Size = New System.Drawing.Size(0, 17)
      '
      'lblDate
      '
      Me.lblDate.AutoSize = False
      Me.lblDate.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner
      Me.lblDate.Name = "lblDate"
      Me.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.lblDate.Size = New System.Drawing.Size(180, 17)
      Me.lblDate.Text = "ToolStripStatusLabel3"
      '
      'lblTime
      '
      Me.lblTime.AutoSize = False
      Me.lblTime.BorderStyle = System.Windows.Forms.Border3DStyle.Raised
      Me.lblTime.Name = "lblTime"
      Me.lblTime.Size = New System.Drawing.Size(120, 17)
      Me.lblTime.Text = "ToolStripStatusLabel4"
      '
      'Timer1
      '
      Me.Timer1.Enabled = True
      Me.Timer1.Interval = 2000
      '
      'ToolStripStatusLabel1
      '
      Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
      Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(375, 17)
      Me.ToolStripStatusLabel1.Spring = True
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.AutoScroll = True
      Me.ClientSize = New System.Drawing.Size(784, 412)
      Me.ControlBox = False
      Me.Controls.Add(Me.StatusStrip1)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.SalesStaffDataGridView)
      Me.Controls.Add(Me.SalesStaffBindingNavigator)
      Me.MinimumSize = New System.Drawing.Size(530, 380)
      Me.Name = "Form1"
      Me.RightToLeftLayout = True
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Lab8 (Sammy Alexander)"
      CType(Me.MyCompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.SalesStaffBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
      Me.SalesStaffBindingNavigator.ResumeLayout(False)
      Me.SalesStaffBindingNavigator.PerformLayout()
      CType(Me.SalesStaffDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
      Me.StatusStrip1.ResumeLayout(False)
      Me.StatusStrip1.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents MyCompanyDataSet As AlexanderSam_Lab8.MyCompanyDataSet
   Friend WithEvents SalesStaffBindingSource As System.Windows.Forms.BindingSource
   Friend WithEvents SalesStaffTableAdapter As AlexanderSam_Lab8.MyCompanyDataSetTableAdapters.SalesStaffTableAdapter
   Friend WithEvents TableAdapterManager As AlexanderSam_Lab8.MyCompanyDataSetTableAdapters.TableAdapterManager
   Friend WithEvents SalesStaffBindingNavigator As System.Windows.Forms.BindingNavigator
   Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
   Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
   Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents SalesStaffDataGridView As System.Windows.Forms.DataGridView
   Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
   Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
   Friend WithEvents lblQuery As System.Windows.Forms.ToolStripStatusLabel
   Friend WithEvents lblSpring As System.Windows.Forms.ToolStripStatusLabel
   Friend WithEvents lblDate As System.Windows.Forms.ToolStripStatusLabel
   Friend WithEvents lblTime As System.Windows.Forms.ToolStripStatusLabel
   Friend WithEvents Timer1 As System.Windows.Forms.Timer
   Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel

End Class
