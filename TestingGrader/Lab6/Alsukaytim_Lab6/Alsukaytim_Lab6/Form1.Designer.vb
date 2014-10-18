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
        Me.lstAvailable = New System.Windows.Forms.ListBox()
        Me.lstSelected = New System.Windows.Forms.ListBox()
        Me.lblAvailableClasses = New System.Windows.Forms.Label()
        Me.lblCelectedClasses = New System.Windows.Forms.Label()
        Me.lblSelectClasses = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnRemoveAll = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SortClassesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstAvailable
        '
        Me.lstAvailable.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAvailable.FormattingEnabled = True
        Me.lstAvailable.ItemHeight = 14
        Me.lstAvailable.Location = New System.Drawing.Point(70, 186)
        Me.lstAvailable.Name = "lstAvailable"
        Me.lstAvailable.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstAvailable.Size = New System.Drawing.Size(160, 88)
        Me.lstAvailable.TabIndex = 0
        '
        'lstSelected
        '
        Me.lstSelected.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSelected.FormattingEnabled = True
        Me.lstSelected.ItemHeight = 14
        Me.lstSelected.Location = New System.Drawing.Point(354, 186)
        Me.lstSelected.Name = "lstSelected"
        Me.lstSelected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstSelected.Size = New System.Drawing.Size(160, 88)
        Me.lstSelected.TabIndex = 1
        '
        'lblAvailableClasses
        '
        Me.lblAvailableClasses.AutoSize = True
        Me.lblAvailableClasses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailableClasses.Location = New System.Drawing.Point(115, 147)
        Me.lblAvailableClasses.Name = "lblAvailableClasses"
        Me.lblAvailableClasses.Size = New System.Drawing.Size(89, 13)
        Me.lblAvailableClasses.TabIndex = 2
        Me.lblAvailableClasses.Text = "Available Classes"
        Me.lblAvailableClasses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCelectedClasses
        '
        Me.lblCelectedClasses.AutoSize = True
        Me.lblCelectedClasses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelectedClasses.Location = New System.Drawing.Point(390, 147)
        Me.lblCelectedClasses.Name = "lblCelectedClasses"
        Me.lblCelectedClasses.Size = New System.Drawing.Size(88, 13)
        Me.lblCelectedClasses.TabIndex = 3
        Me.lblCelectedClasses.Text = "Celected Classes"
        Me.lblCelectedClasses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSelectClasses
        '
        Me.lblSelectClasses.AutoSize = True
        Me.lblSelectClasses.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectClasses.Location = New System.Drawing.Point(218, 67)
        Me.lblSelectClasses.Name = "lblSelectClasses"
        Me.lblSelectClasses.Size = New System.Drawing.Size(146, 24)
        Me.lblSelectClasses.TabIndex = 4
        Me.lblSelectClasses.Text = "Select Classes"
        Me.lblSelectClasses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(252, 186)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 5
        Me.btnSelect.Text = "&Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(252, 219)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnRemoveAll
        '
        Me.btnRemoveAll.Location = New System.Drawing.Point(252, 252)
        Me.btnRemoveAll.Name = "btnRemoveAll"
        Me.btnRemoveAll.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveAll.TabIndex = 7
        Me.btnRemoveAll.Text = "Remove &All"
        Me.btnRemoveAll.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SortClassesToolStripMenuItem, Me.RestToolStripMenuItem, Me.NextToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(195, 120)
        '
        'SortClassesToolStripMenuItem
        '
        Me.SortClassesToolStripMenuItem.Name = "SortClassesToolStripMenuItem"
        Me.SortClassesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SortClassesToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.SortClassesToolStripMenuItem.Text = "&Sort Classes"
        '
        'RestToolStripMenuItem
        '
        Me.RestToolStripMenuItem.Name = "RestToolStripMenuItem"
        Me.RestToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RestToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.RestToolStripMenuItem.Text = "&Reset Listboxes"
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.NextToolStripMenuItem.Text = "&Next"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(191, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 362)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.btnRemoveAll)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.lblSelectClasses)
        Me.Controls.Add(Me.lblCelectedClasses)
        Me.Controls.Add(Me.lblAvailableClasses)
        Me.Controls.Add(Me.lstSelected)
        Me.Controls.Add(Me.lstAvailable)
        Me.MinimumSize = New System.Drawing.Size(100, 80)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = """Lab6""_Alsukaytim"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstAvailable As System.Windows.Forms.ListBox
    Friend WithEvents lstSelected As System.Windows.Forms.ListBox
    Friend WithEvents lblAvailableClasses As System.Windows.Forms.Label
    Friend WithEvents lblCelectedClasses As System.Windows.Forms.Label
   Friend WithEvents lblSelectClasses As System.Windows.Forms.Label
   Friend WithEvents btnSelect As System.Windows.Forms.Button
   Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnRemoveAll As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SortClassesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
