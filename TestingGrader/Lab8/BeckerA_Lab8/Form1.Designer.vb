<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEmployees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEmployees))
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SalesStaffBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.SalesStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyCompanyDataSet = New BeckerA_Lab8.MyCompanyDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbFullTime = New System.Windows.Forms.ToolStripButton()
        Me.tlbPartTime = New System.Windows.Forms.ToolStripButton()
        Me.tlbAll = New System.Windows.Forms.ToolStripButton()
        Me.tlbSalary = New System.Windows.Forms.ToolStripButton()
        Me.tlbLastName = New System.Windows.Forms.ToolStripButton()
        Me.tlbExit = New System.Windows.Forms.ToolStripButton()
        Me.SalesStaffDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblEmployees = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stbQuery = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stbDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stbTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SalesStaffTableAdapter = New BeckerA_Lab8.MyCompanyDataSetTableAdapters.SalesStaffTableAdapter()
        Me.TableAdapterManager = New BeckerA_Lab8.MyCompanyDataSetTableAdapters.TableAdapterManager()
        CType(Me.SalesStaffBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SalesStaffBindingNavigator.SuspendLayout()
        CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyCompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesStaffDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SalesStaffBindingNavigator
        '
        Me.SalesStaffBindingNavigator.AddNewItem = Nothing
        Me.SalesStaffBindingNavigator.BindingSource = Me.SalesStaffBindingSource
        Me.SalesStaffBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SalesStaffBindingNavigator.DeleteItem = Nothing
        Me.SalesStaffBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.tlbFullTime, Me.tlbPartTime, Me.tlbAll, Me.tlbSalary, Me.tlbLastName, Me.tlbExit})
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
        'SalesStaffBindingSource
        '
        Me.SalesStaffBindingSource.DataMember = "SalesStaff"
        Me.SalesStaffBindingSource.DataSource = Me.MyCompanyDataSet
        '
        'MyCompanyDataSet
        '
        Me.MyCompanyDataSet.DataSetName = "MyCompanyDataSet"
        Me.MyCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'tlbFullTime
        '
        Me.tlbFullTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlbFullTime.Image = CType(resources.GetObject("tlbFullTime.Image"), System.Drawing.Image)
        Me.tlbFullTime.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbFullTime.Name = "tlbFullTime"
        Me.tlbFullTime.Size = New System.Drawing.Size(60, 22)
        Me.tlbFullTime.Text = "Full Time"
        '
        'tlbPartTime
        '
        Me.tlbPartTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlbPartTime.Image = CType(resources.GetObject("tlbPartTime.Image"), System.Drawing.Image)
        Me.tlbPartTime.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbPartTime.Name = "tlbPartTime"
        Me.tlbPartTime.Size = New System.Drawing.Size(62, 22)
        Me.tlbPartTime.Text = "Part Time"
        '
        'tlbAll
        '
        Me.tlbAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlbAll.Image = CType(resources.GetObject("tlbAll.Image"), System.Drawing.Image)
        Me.tlbAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbAll.Name = "tlbAll"
        Me.tlbAll.Size = New System.Drawing.Size(85, 22)
        Me.tlbAll.Text = "All Employees"
        '
        'tlbSalary
        '
        Me.tlbSalary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlbSalary.Image = CType(resources.GetObject("tlbSalary.Image"), System.Drawing.Image)
        Me.tlbSalary.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbSalary.Name = "tlbSalary"
        Me.tlbSalary.Size = New System.Drawing.Size(97, 22)
        Me.tlbSalary.Text = "Search on Salary"
        '
        'tlbLastName
        '
        Me.tlbLastName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlbLastName.Image = CType(resources.GetObject("tlbLastName.Image"), System.Drawing.Image)
        Me.tlbLastName.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbLastName.Name = "tlbLastName"
        Me.tlbLastName.Size = New System.Drawing.Size(122, 22)
        Me.tlbLastName.Text = "Search on Last Name"
        '
        'tlbExit
        '
        Me.tlbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlbExit.Image = CType(resources.GetObject("tlbExit.Image"), System.Drawing.Image)
        Me.tlbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbExit.Name = "tlbExit"
        Me.tlbExit.Size = New System.Drawing.Size(29, 22)
        Me.tlbExit.Text = "Exit"
        '
        'SalesStaffDataGridView
        '
        Me.SalesStaffDataGridView.AutoGenerateColumns = False
        Me.SalesStaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalesStaffDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.SalesStaffDataGridView.DataSource = Me.SalesStaffBindingSource
        Me.SalesStaffDataGridView.Location = New System.Drawing.Point(142, 139)
        Me.SalesStaffDataGridView.Name = "SalesStaffDataGridView"
        Me.SalesStaffDataGridView.ReadOnly = True
        Me.SalesStaffDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SalesStaffDataGridView.Size = New System.Drawing.Size(520, 220)
        Me.SalesStaffDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "LastName"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn2.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 95
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FirstName"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn3.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 95
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "FullTime"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Full Time"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "HireDate"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle19.Format = "d"
        DataGridViewCellStyle19.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn4.HeaderText = "HireDate"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Salary"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle20.Format = "C0"
        DataGridViewCellStyle20.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewTextBoxColumn5.HeaderText = "Salary"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'lblEmployees
        '
        Me.lblEmployees.AutoSize = True
        Me.lblEmployees.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployees.Location = New System.Drawing.Point(291, 46)
        Me.lblEmployees.Name = "lblEmployees"
        Me.lblEmployees.Size = New System.Drawing.Size(127, 25)
        Me.lblEmployees.TabIndex = 2
        Me.lblEmployees.Text = "Employees"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(282, 90)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(208, 24)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Created by Alex Becker"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stbQuery, Me.ToolStripStatusLabel1, Me.stbDate, Me.stbTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 390)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stbQuery
        '
        Me.stbQuery.AutoSize = False
        Me.stbQuery.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.stbQuery.Name = "stbQuery"
        Me.stbQuery.Size = New System.Drawing.Size(150, 17)
        Me.stbQuery.Text = "Query"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(319, 17)
        Me.ToolStripStatusLabel1.Spring = True
        '
        'stbDate
        '
        Me.stbDate.AutoSize = False
        Me.stbDate.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner
        Me.stbDate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.stbDate.Name = "stbDate"
        Me.stbDate.Size = New System.Drawing.Size(180, 17)
        Me.stbDate.Text = "Date"
        '
        'stbTime
        '
        Me.stbTime.AutoSize = False
        Me.stbTime.BorderStyle = System.Windows.Forms.Border3DStyle.Raised
        Me.stbTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.stbTime.Name = "stbTime"
        Me.stbTime.Size = New System.Drawing.Size(120, 17)
        Me.stbTime.Text = "Time"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'SalesStaffTableAdapter
        '
        Me.SalesStaffTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SalesStaffTableAdapter = Me.SalesStaffTableAdapter
        Me.TableAdapterManager.UpdateOrder = BeckerA_Lab8.MyCompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FormEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 412)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblEmployees)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SalesStaffDataGridView)
        Me.Controls.Add(Me.SalesStaffBindingNavigator)
        Me.MinimumSize = New System.Drawing.Size(530, 380)
        Me.Name = "FormEmployees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lab8"
        CType(Me.SalesStaffBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SalesStaffBindingNavigator.ResumeLayout(False)
        Me.SalesStaffBindingNavigator.PerformLayout()
        CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyCompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesStaffDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MyCompanyDataSet As BeckerA_Lab8.MyCompanyDataSet
    Friend WithEvents SalesStaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesStaffTableAdapter As BeckerA_Lab8.MyCompanyDataSetTableAdapters.SalesStaffTableAdapter
    Friend WithEvents TableAdapterManager As BeckerA_Lab8.MyCompanyDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents lblEmployees As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents tlbFullTime As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbPartTime As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbSalary As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbLastName As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stbQuery As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stbDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stbTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
