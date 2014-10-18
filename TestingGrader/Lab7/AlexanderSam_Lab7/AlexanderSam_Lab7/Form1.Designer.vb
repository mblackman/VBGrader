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
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Me.lbltitle = New System.Windows.Forms.Label()
      Me.bndNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
      Me.SalesStaffBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
      Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
      Me.IndividualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.MyCompanyDataSet = New AlexanderSam_Lab7.MyCompanyDataSet()
      Me.SalesStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.SalesStaffTableAdapter = New AlexanderSam_Lab7.MyCompanyDataSetTableAdapters.SalesStaffTableAdapter()
      Me.TableAdapterManager = New AlexanderSam_Lab7.MyCompanyDataSetTableAdapters.TableAdapterManager()
      Me.SalesStaffDataGridView = New System.Windows.Forms.DataGridView()
      Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
      Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      CType(Me.bndNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bndNavigator.SuspendLayout()
      Me.ContextMenuStrip1.SuspendLayout()
      CType(Me.MyCompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.SalesStaffDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'lbltitle
      '
      Me.lbltitle.AutoSize = True
      Me.lbltitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lbltitle.Location = New System.Drawing.Point(340, 34)
      Me.lbltitle.Name = "lbltitle"
      Me.lbltitle.Size = New System.Drawing.Size(105, 24)
      Me.lbltitle.TabIndex = 1
      Me.lbltitle.Text = "Employees"
      '
      'bndNavigator
      '
      Me.bndNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
      Me.bndNavigator.BindingSource = Me.SalesStaffBindingSource
      Me.bndNavigator.CountItem = Me.BindingNavigatorCountItem
      Me.bndNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
      Me.bndNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SalesStaffBindingNavigatorSaveItem, Me.ToolStripButton2})
      Me.bndNavigator.Location = New System.Drawing.Point(0, 0)
      Me.bndNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
      Me.bndNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
      Me.bndNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
      Me.bndNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
      Me.bndNavigator.Name = "bndNavigator"
      Me.bndNavigator.PositionItem = Me.BindingNavigatorPositionItem
      Me.bndNavigator.Size = New System.Drawing.Size(784, 25)
      Me.bndNavigator.TabIndex = 3
      Me.bndNavigator.Text = "BindingNavigator1"
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
      'SalesStaffBindingNavigatorSaveItem
      '
      Me.SalesStaffBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.SalesStaffBindingNavigatorSaveItem.Image = Global.AlexanderSam_Lab7.My.Resources.Resources.Save
      Me.SalesStaffBindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.SalesStaffBindingNavigatorSaveItem.Name = "SalesStaffBindingNavigatorSaveItem"
      Me.SalesStaffBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
      Me.SalesStaffBindingNavigatorSaveItem.Text = "Save"
      '
      'ToolStripButton2
      '
      Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.ToolStripButton2.Image = Global.AlexanderSam_Lab7.My.Resources.Resources.RefreshDocViewHS
      Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton2.Name = "ToolStripButton2"
      Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
      Me.ToolStripButton2.Text = "Refresh"
      '
      'ContextMenuStrip1
      '
      Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndividualToolStripMenuItem, Me.ExitToolStripMenuItem})
      Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
      Me.ContextMenuStrip1.Size = New System.Drawing.Size(164, 48)
      '
      'IndividualToolStripMenuItem
      '
      Me.IndividualToolStripMenuItem.Name = "IndividualToolStripMenuItem"
      Me.IndividualToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
      Me.IndividualToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
      Me.IndividualToolStripMenuItem.Text = "Individual"
      '
      'ExitToolStripMenuItem
      '
      Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
      Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
      Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
      Me.ExitToolStripMenuItem.Text = "Exit"
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
      'SalesStaffDataGridView
      '
      Me.SalesStaffDataGridView.AutoGenerateColumns = False
      Me.SalesStaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.SalesStaffDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
      Me.SalesStaffDataGridView.ContextMenuStrip = Me.ContextMenuStrip1
      Me.SalesStaffDataGridView.DataSource = Me.SalesStaffBindingSource
      Me.SalesStaffDataGridView.Location = New System.Drawing.Point(130, 94)
      Me.SalesStaffDataGridView.Name = "SalesStaffDataGridView"
      Me.SalesStaffDataGridView.Size = New System.Drawing.Size(524, 220)
      Me.SalesStaffDataGridView.TabIndex = 3
      '
      'DataGridViewTextBoxColumn1
      '
      Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
      DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
      Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
      Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
      Me.DataGridViewTextBoxColumn1.Width = 50
      '
      'DataGridViewTextBoxColumn2
      '
      Me.DataGridViewTextBoxColumn2.DataPropertyName = "LastName"
      DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
      Me.DataGridViewTextBoxColumn2.HeaderText = "LastName"
      Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
      Me.DataGridViewTextBoxColumn2.Width = 95
      '
      'DataGridViewTextBoxColumn3
      '
      Me.DataGridViewTextBoxColumn3.DataPropertyName = "FirstName"
      DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
      Me.DataGridViewTextBoxColumn3.HeaderText = "FirstName"
      Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
      Me.DataGridViewTextBoxColumn3.Width = 95
      '
      'DataGridViewCheckBoxColumn1
      '
      Me.DataGridViewCheckBoxColumn1.DataPropertyName = "FullTime"
      Me.DataGridViewCheckBoxColumn1.HeaderText = "FullTime"
      Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
      Me.DataGridViewCheckBoxColumn1.Width = 70
      '
      'DataGridViewTextBoxColumn4
      '
      Me.DataGridViewTextBoxColumn4.DataPropertyName = "HireDate"
      DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
      Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle4
      Me.DataGridViewTextBoxColumn4.HeaderText = "HireDate"
      Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
      Me.DataGridViewTextBoxColumn4.Width = 80
      '
      'DataGridViewTextBoxColumn5
      '
      Me.DataGridViewTextBoxColumn5.DataPropertyName = "Salary"
      DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
      DataGridViewCellStyle5.Format = "C2"
      DataGridViewCellStyle5.NullValue = Nothing
      Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle5
      Me.DataGridViewTextBoxColumn5.HeaderText = "Salary"
      Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
      Me.DataGridViewTextBoxColumn5.Width = 70
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(784, 349)
      Me.Controls.Add(Me.SalesStaffDataGridView)
      Me.Controls.Add(Me.bndNavigator)
      Me.Controls.Add(Me.lbltitle)
      Me.MinimumSize = New System.Drawing.Size(522, 320)
      Me.Name = "Form1"
      Me.Text = "Lab 7 (Sammy Alexander)"
      CType(Me.bndNavigator, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bndNavigator.ResumeLayout(False)
      Me.bndNavigator.PerformLayout()
      Me.ContextMenuStrip1.ResumeLayout(False)
      CType(Me.MyCompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.SalesStaffDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents lbltitle As System.Windows.Forms.Label
   Friend WithEvents bndNavigator As System.Windows.Forms.BindingNavigator
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
   Friend WithEvents SalesStaffBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
   Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
   Friend WithEvents IndividualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents MyCompanyDataSet As AlexanderSam_Lab7.MyCompanyDataSet
   Friend WithEvents SalesStaffBindingSource As System.Windows.Forms.BindingSource
   Friend WithEvents SalesStaffTableAdapter As AlexanderSam_Lab7.MyCompanyDataSetTableAdapters.SalesStaffTableAdapter
   Friend WithEvents TableAdapterManager As AlexanderSam_Lab7.MyCompanyDataSetTableAdapters.TableAdapterManager
   Friend WithEvents SalesStaffDataGridView As System.Windows.Forms.DataGridView
   Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
