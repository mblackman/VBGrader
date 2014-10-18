<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayRoll
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
        Me.lblPayRoll = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.txtDeduction = New System.Windows.Forms.TextBox()
        Me.txtNetPay = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.lblDeduction = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCompute = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNext = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStats = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPayRoll
        '
        Me.lblPayRoll.AutoSize = True
        Me.lblPayRoll.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayRoll.Location = New System.Drawing.Point(178, 54)
        Me.lblPayRoll.Name = "lblPayRoll"
        Me.lblPayRoll.Size = New System.Drawing.Size(138, 21)
        Me.lblPayRoll.TabIndex = 0
        Me.lblPayRoll.Text = "PayRoll Program"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(121, 141)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 0
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(121, 209)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(100, 20)
        Me.txtRate.TabIndex = 1
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(121, 277)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(100, 20)
        Me.txtHours.TabIndex = 2
        '
        'txtGrossPay
        '
        Me.txtGrossPay.BackColor = System.Drawing.SystemColors.Window
        Me.txtGrossPay.Location = New System.Drawing.Point(273, 141)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.ReadOnly = True
        Me.txtGrossPay.Size = New System.Drawing.Size(100, 20)
        Me.txtGrossPay.TabIndex = 8
        Me.txtGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDeduction
        '
        Me.txtDeduction.BackColor = System.Drawing.SystemColors.Window
        Me.txtDeduction.Location = New System.Drawing.Point(273, 209)
        Me.txtDeduction.Name = "txtDeduction"
        Me.txtDeduction.ReadOnly = True
        Me.txtDeduction.Size = New System.Drawing.Size(100, 20)
        Me.txtDeduction.TabIndex = 9
        Me.txtDeduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNetPay
        '
        Me.txtNetPay.BackColor = System.Drawing.SystemColors.Window
        Me.txtNetPay.Location = New System.Drawing.Point(273, 277)
        Me.txtNetPay.Name = "txtNetPay"
        Me.txtNetPay.ReadOnly = True
        Me.txtNetPay.Size = New System.Drawing.Size(100, 20)
        Me.txtNetPay.TabIndex = 10
        Me.txtNetPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(121, 125)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 13)
        Me.lblID.TabIndex = 7
        Me.lblID.Text = "ID"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(121, 193)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(30, 13)
        Me.lblRate.TabIndex = 8
        Me.lblRate.Text = "Rate"
        Me.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(121, 261)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(35, 13)
        Me.lblHours.TabIndex = 9
        Me.lblHours.Text = "Hours"
        Me.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Location = New System.Drawing.Point(273, 125)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(52, 13)
        Me.lblGrossPay.TabIndex = 10
        Me.lblGrossPay.Text = "GrossPay"
        Me.lblGrossPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDeduction
        '
        Me.lblDeduction.AutoSize = True
        Me.lblDeduction.Location = New System.Drawing.Point(273, 193)
        Me.lblDeduction.Name = "lblDeduction"
        Me.lblDeduction.Size = New System.Drawing.Size(56, 13)
        Me.lblDeduction.TabIndex = 11
        Me.lblDeduction.Text = "Deduction"
        Me.lblDeduction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.Location = New System.Drawing.Point(273, 261)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(42, 13)
        Me.lblNetPay.TabIndex = 12
        Me.lblNetPay.Text = "NetPay"
        Me.lblNetPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(498, 24)
        Me.menuStrip1.TabIndex = 13
        Me.menuStrip1.Text = "menuStrip1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCompute, Me.mnuNext, Me.mnuStats, Me.ToolStripMenuItem1, Me.mnuExit})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.fileToolStripMenuItem.Text = "&File"
        '
        'mnuCompute
        '
        Me.mnuCompute.Name = "mnuCompute"
        Me.mnuCompute.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCompute.Size = New System.Drawing.Size(166, 22)
        Me.mnuCompute.Text = "&Compute"
        '
        'mnuNext
        '
        Me.mnuNext.Enabled = False
        Me.mnuNext.Name = "mnuNext"
        Me.mnuNext.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuNext.Size = New System.Drawing.Size(166, 22)
        Me.mnuNext.Text = "&Next"
        '
        'mnuStats
        '
        Me.mnuStats.Name = "mnuStats"
        Me.mnuStats.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuStats.Size = New System.Drawing.Size(166, 22)
        Me.mnuStats.Text = "&Stats"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(163, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuExit.Size = New System.Drawing.Size(166, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'frmPayRoll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 448)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.lblDeduction)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtNetPay)
        Me.Controls.Add(Me.txtDeduction)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblPayRoll)
        Me.Controls.Add(Me.menuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.menuStrip1
        Me.Name = "frmPayRoll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lab5 (Michael Ababio)"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPayRoll As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents txtGrossPay As System.Windows.Forms.TextBox
    Friend WithEvents txtDeduction As System.Windows.Forms.TextBox
    Friend WithEvents txtNetPay As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents lblGrossPay As System.Windows.Forms.Label
    Friend WithEvents lblDeduction As System.Windows.Forms.Label
    Friend WithEvents lblNetPay As System.Windows.Forms.Label
    Friend WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCompute As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNext As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuStats As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem

End Class
