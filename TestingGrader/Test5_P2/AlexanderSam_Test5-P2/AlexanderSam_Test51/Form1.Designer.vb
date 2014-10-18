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
      Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Me.Test5DataSet = New AlexanderSam_Test51.Test5DataSet()
      Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.EmployeeTableAdapter = New AlexanderSam_Test51.Test5DataSetTableAdapters.EmployeeTableAdapter()
      Me.TableAdapterManager = New AlexanderSam_Test51.Test5DataSetTableAdapters.TableAdapterManager()
      Me.EmployeeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
      Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
      Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
      Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
      Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
      Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
      Me.EmployeeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
      Me.btnReload = New System.Windows.Forms.ToolStripButton()
      Me.btnList = New System.Windows.Forms.ToolStripButton()
      Me.btnExit = New System.Windows.Forms.ToolStripButton()
      Me.EmployeeDataGridView = New System.Windows.Forms.DataGridView()
      Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
      Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.lblTitle = New System.Windows.Forms.Label()
      CType(Me.Test5DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.EmployeeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.EmployeeBindingNavigator.SuspendLayout()
      CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
      Me.TableAdapterManager.UpdateOrder = AlexanderSam_Test51.Test5DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
      '
      'EmployeeBindingNavigator
      '
      Me.EmployeeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
      Me.EmployeeBindingNavigator.BackColor = System.Drawing.SystemColors.ButtonShadow
      Me.EmployeeBindingNavigator.BindingSource = Me.EmployeeBindingSource
      Me.EmployeeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
      Me.EmployeeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
      Me.EmployeeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmployeeBindingNavigatorSaveItem, Me.btnReload, Me.btnList, Me.btnExit})
      Me.EmployeeBindingNavigator.Location = New System.Drawing.Point(0, 0)
      Me.EmployeeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
      Me.EmployeeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
      Me.EmployeeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
      Me.EmployeeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
      Me.EmployeeBindingNavigator.Name = "EmployeeBindingNavigator"
      Me.EmployeeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
      Me.EmployeeBindingNavigator.Size = New System.Drawing.Size(844, 25)
      Me.EmployeeBindingNavigator.TabIndex = 0
      Me.EmployeeBindingNavigator.Text = "BindingNavigator1"
      '
      'BindingNavigatorAddNewItem
      '
      Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
      Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorAddNewItem.Text = "Add new"
      '
      'BindingNavigatorCountItem
      '
      Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
      Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
      Me.BindingNavigatorCountItem.Text = "of {0}"
      Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
      '
      'BindingNavigatorDeleteItem
      '
      Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
      Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorDeleteItem.Text = "Delete"
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
      Me.BindingNavigatorPositionItem.ReadOnly = True
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
      'EmployeeBindingNavigatorSaveItem
      '
      Me.EmployeeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.EmployeeBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmployeeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
      Me.EmployeeBindingNavigatorSaveItem.Name = "EmployeeBindingNavigatorSaveItem"
      Me.EmployeeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
      Me.EmployeeBindingNavigatorSaveItem.Text = "Save Data"
      '
      'btnReload
      '
      Me.btnReload.AutoSize = False
      Me.btnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.btnReload.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnReload.Name = "btnReload"
      Me.btnReload.Size = New System.Drawing.Size(100, 22)
      Me.btnReload.Text = "&Reload"
      '
      'btnList
      '
      Me.btnList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.btnList.Image = CType(resources.GetObject("btnList.Image"), System.Drawing.Image)
      Me.btnList.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnList.Name = "btnList"
      Me.btnList.Size = New System.Drawing.Size(29, 22)
      Me.btnList.Text = "List"
      '
      'btnExit
      '
      Me.btnExit.AutoSize = False
      Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
      Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnExit.Name = "btnExit"
      Me.btnExit.Size = New System.Drawing.Size(100, 22)
      Me.btnExit.Text = "E&xit"
      '
      'EmployeeDataGridView
      '
      Me.EmployeeDataGridView.AutoGenerateColumns = False
      Me.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.EmployeeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn6})
      Me.EmployeeDataGridView.DataSource = Me.EmployeeBindingSource
      Me.EmployeeDataGridView.Location = New System.Drawing.Point(77, 146)
      Me.EmployeeDataGridView.Name = "EmployeeDataGridView"
      Me.EmployeeDataGridView.Size = New System.Drawing.Size(690, 170)
      Me.EmployeeDataGridView.TabIndex = 1
      '
      'DataGridViewTextBoxColumn1
      '
      Me.DataGridViewTextBoxColumn1.DataPropertyName = "EmpID"
      DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle7
      Me.DataGridViewTextBoxColumn1.HeaderText = "     ID"
      Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
      Me.DataGridViewTextBoxColumn1.Width = 60
      '
      'DataGridViewTextBoxColumn2
      '
      Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
      DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle8
      Me.DataGridViewTextBoxColumn2.HeaderText = "     FirstName"
      Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
      '
      'DataGridViewTextBoxColumn3
      '
      Me.DataGridViewTextBoxColumn3.DataPropertyName = "LastName"
      DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle9
      Me.DataGridViewTextBoxColumn3.HeaderText = "     LastName"
      Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
      '
      'DataGridViewTextBoxColumn5
      '
      Me.DataGridViewTextBoxColumn5.DataPropertyName = "Password"
      DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle10
      Me.DataGridViewTextBoxColumn5.HeaderText = "Password"
      Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
      Me.DataGridViewTextBoxColumn5.Width = 60
      '
      'DataGridViewTextBoxColumn4
      '
      Me.DataGridViewTextBoxColumn4.DataPropertyName = "Rate"
      DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
      DataGridViewCellStyle11.Format = "C2"
      DataGridViewCellStyle11.NullValue = Nothing
      Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle11
      Me.DataGridViewTextBoxColumn4.HeaderText = "  Pay Rate"
      Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
      Me.DataGridViewTextBoxColumn4.Width = 80
      '
      'DataGridViewCheckBoxColumn1
      '
      Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Admin"
      Me.DataGridViewCheckBoxColumn1.HeaderText = "Admin"
      Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
      Me.DataGridViewCheckBoxColumn1.Width = 50
      '
      'DataGridViewTextBoxColumn6
      '
      Me.DataGridViewTextBoxColumn6.DataPropertyName = "HireDate"
      DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
      DataGridViewCellStyle12.Format = "D"
      DataGridViewCellStyle12.NullValue = Nothing
      Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle12
      Me.DataGridViewTextBoxColumn6.HeaderText = "              HireDate"
      Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
      Me.DataGridViewTextBoxColumn6.Width = 180
      '
      'lblTitle
      '
      Me.lblTitle.AutoSize = True
      Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTitle.Location = New System.Drawing.Point(400, 100)
      Me.lblTitle.Name = "lblTitle"
      Me.lblTitle.Size = New System.Drawing.Size(120, 24)
      Me.lblTitle.TabIndex = 2
      Me.lblTitle.Text = "All Emplyees"
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(844, 416)
      Me.ControlBox = False
      Me.Controls.Add(Me.lblTitle)
      Me.Controls.Add(Me.EmployeeDataGridView)
      Me.Controls.Add(Me.EmployeeBindingNavigator)
      Me.MinimumSize = New System.Drawing.Size(720, 260)
      Me.Name = "Form1"
      Me.Text = "Test5 (Sammy Alexander)"
      CType(Me.Test5DataSet, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.EmployeeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
      Me.EmployeeBindingNavigator.ResumeLayout(False)
      Me.EmployeeBindingNavigator.PerformLayout()
      CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents Test5DataSet As AlexanderSam_Test51.Test5DataSet
   Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
   Friend WithEvents EmployeeTableAdapter As AlexanderSam_Test51.Test5DataSetTableAdapters.EmployeeTableAdapter
   Friend WithEvents TableAdapterManager As AlexanderSam_Test51.Test5DataSetTableAdapters.TableAdapterManager
   Friend WithEvents EmployeeBindingNavigator As System.Windows.Forms.BindingNavigator
   Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
   Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
   Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents EmployeeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnReload As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
   Friend WithEvents EmployeeDataGridView As System.Windows.Forms.DataGridView
   Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents lblTitle As System.Windows.Forms.Label
   Friend WithEvents btnList As System.Windows.Forms.ToolStripButton

End Class
