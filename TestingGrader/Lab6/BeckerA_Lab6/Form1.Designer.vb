<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClasses
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
        Me.lblAvailable = New System.Windows.Forms.Label()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.lblClasses = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnRemoveAll = New System.Windows.Forms.Button()
        Me.cxtMenuClasses = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SortClassesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetListBoxesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cxtMenuClasses.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstAvailable
        '
        Me.lstAvailable.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAvailable.FormattingEnabled = True
        Me.lstAvailable.ItemHeight = 14
        Me.lstAvailable.Location = New System.Drawing.Point(63, 136)
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
        Me.lstSelected.Location = New System.Drawing.Point(316, 136)
        Me.lstSelected.Name = "lstSelected"
        Me.lstSelected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstSelected.Size = New System.Drawing.Size(160, 88)
        Me.lstSelected.TabIndex = 1
        '
        'lblAvailable
        '
        Me.lblAvailable.AutoSize = True
        Me.lblAvailable.Location = New System.Drawing.Point(63, 117)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(89, 13)
        Me.lblAvailable.TabIndex = 2
        Me.lblAvailable.Text = "Available Classes"
        Me.lblAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(316, 116)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(88, 13)
        Me.lblSelected.TabIndex = 3
        Me.lblSelected.Text = "Selected Classes"
        Me.lblSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblClasses
        '
        Me.lblClasses.AutoSize = True
        Me.lblClasses.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClasses.Location = New System.Drawing.Point(77, 49)
        Me.lblClasses.Name = "lblClasses"
        Me.lblClasses.Size = New System.Drawing.Size(146, 24)
        Me.lblClasses.TabIndex = 4
        Me.lblClasses.Text = "Select Classes"
        Me.lblClasses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(229, 136)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 5
        Me.btnSelect.Text = "&Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(229, 165)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnRemoveAll
        '
        Me.btnRemoveAll.Location = New System.Drawing.Point(229, 201)
        Me.btnRemoveAll.Name = "btnRemoveAll"
        Me.btnRemoveAll.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveAll.TabIndex = 7
        Me.btnRemoveAll.Text = "Remove &All"
        Me.btnRemoveAll.UseVisualStyleBackColor = True
        '
        'cxtMenuClasses
        '
        Me.cxtMenuClasses.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SortClassesToolStripMenuItem, Me.ResetListBoxesToolStripMenuItem, Me.NextToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.cxtMenuClasses.Name = "cxtMenuClasses"
        Me.cxtMenuClasses.Size = New System.Drawing.Size(195, 98)
        '
        'SortClassesToolStripMenuItem
        '
        Me.SortClassesToolStripMenuItem.Name = "SortClassesToolStripMenuItem"
        Me.SortClassesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SortClassesToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.SortClassesToolStripMenuItem.Text = "Sort Classes"
        '
        'ResetListBoxesToolStripMenuItem
        '
        Me.ResetListBoxesToolStripMenuItem.Name = "ResetListBoxesToolStripMenuItem"
        Me.ResetListBoxesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ResetListBoxesToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ResetListBoxesToolStripMenuItem.Text = "Reset ListBoxes"
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.NextToolStripMenuItem.Text = "Next"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(191, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'frmClasses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 362)
        Me.ContextMenuStrip = Me.cxtMenuClasses
        Me.Controls.Add(Me.btnRemoveAll)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.lblClasses)
        Me.Controls.Add(Me.lblAvailable)
        Me.Controls.Add(Me.lstSelected)
        Me.Controls.Add(Me.lstAvailable)
        Me.MinimumSize = New System.Drawing.Size(400, 200)
        Me.Name = "frmClasses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lab6 (Alex Becker)"
        Me.cxtMenuClasses.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstAvailable As System.Windows.Forms.ListBox
    Friend WithEvents lstSelected As System.Windows.Forms.ListBox
    Friend WithEvents lblAvailable As System.Windows.Forms.Label
    Friend WithEvents lblSelected As System.Windows.Forms.Label
    Friend WithEvents lblClasses As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnRemoveAll As System.Windows.Forms.Button
    Friend WithEvents cxtMenuClasses As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SortClassesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetListBoxesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
