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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCompute = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeriodsPerYearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuYearly = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuQuarterly = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuMonthly = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuDaily = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbFV = New System.Windows.Forms.ListBox()
        Me.lblFV = New System.Windows.Forms.Label()
        Me.txtPrinciple = New System.Windows.Forms.TextBox()
        Me.txtStart = New System.Windows.Forms.TextBox()
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.cmbRate = New System.Windows.Forms.ComboBox()
        Me.lblPrinciple = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PeriodsPerYearToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(614, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCompute, Me.ToolStripSeparator1, Me.menuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'menuCompute
        '
        Me.menuCompute.Name = "menuCompute"
        Me.menuCompute.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.menuCompute.Size = New System.Drawing.Size(166, 22)
        Me.menuCompute.Text = "&Compute"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(163, 6)
        '
        'menuExit
        '
        Me.menuExit.Name = "menuExit"
        Me.menuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.menuExit.Size = New System.Drawing.Size(166, 22)
        Me.menuExit.Text = "&Exit"
        '
        'PeriodsPerYearToolStripMenuItem
        '
        Me.PeriodsPerYearToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuYearly, Me.menuQuarterly, Me.menuMonthly, Me.menuDaily})
        Me.PeriodsPerYearToolStripMenuItem.Name = "PeriodsPerYearToolStripMenuItem"
        Me.PeriodsPerYearToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.PeriodsPerYearToolStripMenuItem.Text = "&PeriodsPerYear"
        '
        'menuYearly
        '
        Me.menuYearly.Name = "menuYearly"
        Me.menuYearly.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.menuYearly.Size = New System.Drawing.Size(134, 22)
        Me.menuYearly.Text = "1"
        '
        'menuQuarterly
        '
        Me.menuQuarterly.Name = "menuQuarterly"
        Me.menuQuarterly.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.menuQuarterly.Size = New System.Drawing.Size(134, 22)
        Me.menuQuarterly.Text = "4"
        '
        'menuMonthly
        '
        Me.menuMonthly.Checked = True
        Me.menuMonthly.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menuMonthly.Name = "menuMonthly"
        Me.menuMonthly.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.menuMonthly.Size = New System.Drawing.Size(134, 22)
        Me.menuMonthly.Text = "12"
        '
        'menuDaily
        '
        Me.menuDaily.Name = "menuDaily"
        Me.menuDaily.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.menuDaily.Size = New System.Drawing.Size(134, 22)
        Me.menuDaily.Text = "365"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuAbout})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'menuAbout
        '
        Me.menuAbout.Name = "menuAbout"
        Me.menuAbout.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.menuAbout.Size = New System.Drawing.Size(149, 22)
        Me.menuAbout.Text = "&About"
        '
        'lbFV
        '
        Me.lbFV.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFV.FormattingEnabled = True
        Me.lbFV.ItemHeight = 21
        Me.lbFV.Location = New System.Drawing.Point(122, 103)
        Me.lbFV.Name = "lbFV"
        Me.lbFV.ScrollAlwaysVisible = True
        Me.lbFV.Size = New System.Drawing.Size(370, 193)
        Me.lbFV.TabIndex = 4
        '
        'lblFV
        '
        Me.lblFV.AutoSize = True
        Me.lblFV.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFV.Location = New System.Drawing.Point(237, 61)
        Me.lblFV.Name = "lblFV"
        Me.lblFV.Size = New System.Drawing.Size(141, 24)
        Me.lblFV.TabIndex = 2
        Me.lblFV.Text = "Future Values"
        '
        'txtPrinciple
        '
        Me.txtPrinciple.Location = New System.Drawing.Point(175, 332)
        Me.txtPrinciple.Name = "txtPrinciple"
        Me.txtPrinciple.Size = New System.Drawing.Size(100, 20)
        Me.txtPrinciple.TabIndex = 0
        '
        'txtStart
        '
        Me.txtStart.Location = New System.Drawing.Point(175, 386)
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(100, 20)
        Me.txtStart.TabIndex = 2
        '
        'txtEnd
        '
        Me.txtEnd.Location = New System.Drawing.Point(329, 386)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(100, 20)
        Me.txtEnd.TabIndex = 3
        '
        'cmbRate
        '
        Me.cmbRate.FormattingEnabled = True
        Me.cmbRate.Location = New System.Drawing.Point(319, 331)
        Me.cmbRate.Name = "cmbRate"
        Me.cmbRate.Size = New System.Drawing.Size(121, 21)
        Me.cmbRate.TabIndex = 1
        '
        'lblPrinciple
        '
        Me.lblPrinciple.AutoSize = True
        Me.lblPrinciple.Location = New System.Drawing.Point(202, 316)
        Me.lblPrinciple.Name = "lblPrinciple"
        Me.lblPrinciple.Size = New System.Drawing.Size(47, 13)
        Me.lblPrinciple.TabIndex = 8
        Me.lblPrinciple.Text = "Principle"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(338, 315)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(83, 13)
        Me.lblRate.TabIndex = 9
        Me.lblRate.Text = "Annual Rate (%)"
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Location = New System.Drawing.Point(198, 370)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(54, 13)
        Me.lblStart.TabIndex = 10
        Me.lblStart.Text = "Start Year"
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Location = New System.Drawing.Point(350, 370)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(51, 13)
        Me.lblEnd.TabIndex = 11
        Me.lblEnd.Text = "End Year"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 472)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblEnd)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblPrinciple)
        Me.Controls.Add(Me.cmbRate)
        Me.Controls.Add(Me.txtEnd)
        Me.Controls.Add(Me.txtStart)
        Me.Controls.Add(Me.txtPrinciple)
        Me.Controls.Add(Me.lblFV)
        Me.Controls.Add(Me.lbFV)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lab4 (Alex Becker)"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCompute As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PeriodsPerYearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuYearly As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuQuarterly As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuMonthly As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuDaily As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbFV As System.Windows.Forms.ListBox
    Friend WithEvents lblFV As System.Windows.Forms.Label
    Friend WithEvents txtPrinciple As System.Windows.Forms.TextBox
    Friend WithEvents txtStart As System.Windows.Forms.TextBox
    Friend WithEvents txtEnd As System.Windows.Forms.TextBox
    Friend WithEvents cmbRate As System.Windows.Forms.ComboBox
    Friend WithEvents lblPrinciple As System.Windows.Forms.Label
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents lblEnd As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator

End Class
