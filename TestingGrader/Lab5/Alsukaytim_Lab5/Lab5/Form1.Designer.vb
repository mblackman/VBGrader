﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtNetPay = New System.Windows.Forms.TextBox()
        Me.txtDeduction = New System.Windows.Forms.TextBox()
        Me.lblPayRoll = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.lblDeduction = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComputeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(83, 118)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(106, 20)
        Me.txtID.TabIndex = 1
        '
        'txtGrossPay
        '
        Me.txtGrossPay.BackColor = System.Drawing.SystemColors.Window
        Me.txtGrossPay.Location = New System.Drawing.Point(261, 118)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.ReadOnly = True
        Me.txtGrossPay.Size = New System.Drawing.Size(106, 20)
        Me.txtGrossPay.TabIndex = 0
        Me.txtGrossPay.TabStop = False
        Me.txtGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(83, 295)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(106, 20)
        Me.txtHours.TabIndex = 3
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(83, 202)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(106, 20)
        Me.txtRate.TabIndex = 2
        '
        'txtNetPay
        '
        Me.txtNetPay.BackColor = System.Drawing.SystemColors.Window
        Me.txtNetPay.Location = New System.Drawing.Point(261, 295)
        Me.txtNetPay.Name = "txtNetPay"
        Me.txtNetPay.ReadOnly = True
        Me.txtNetPay.Size = New System.Drawing.Size(106, 20)
        Me.txtNetPay.TabIndex = 0
        Me.txtNetPay.TabStop = False
        Me.txtNetPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDeduction
        '
        Me.txtDeduction.BackColor = System.Drawing.SystemColors.Window
        Me.txtDeduction.Location = New System.Drawing.Point(261, 202)
        Me.txtDeduction.Name = "txtDeduction"
        Me.txtDeduction.ReadOnly = True
        Me.txtDeduction.Size = New System.Drawing.Size(106, 20)
        Me.txtDeduction.TabIndex = 0
        Me.txtDeduction.TabStop = False
        Me.txtDeduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPayRoll
        '
        Me.lblPayRoll.AutoSize = True
        Me.lblPayRoll.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayRoll.Location = New System.Drawing.Point(173, 43)
        Me.lblPayRoll.Name = "lblPayRoll"
        Me.lblPayRoll.Size = New System.Drawing.Size(138, 21)
        Me.lblPayRoll.TabIndex = 9
        Me.lblPayRoll.Text = "PayRoll Program"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(86, 98)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(20, 15)
        Me.lblID.TabIndex = 10
        Me.lblID.Text = "ID"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.Location = New System.Drawing.Point(86, 275)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(40, 15)
        Me.lblHours.TabIndex = 11
        Me.lblHours.Text = "Hours"
        Me.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRate.Location = New System.Drawing.Point(86, 182)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(31, 15)
        Me.lblRate.TabIndex = 12
        Me.lblRate.Text = "Rate"
        Me.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossPay.Location = New System.Drawing.Point(259, 98)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(61, 15)
        Me.lblGrossPay.TabIndex = 13
        Me.lblGrossPay.Text = "Gross Pay"
        Me.lblGrossPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDeduction
        '
        Me.lblDeduction.AutoSize = True
        Me.lblDeduction.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeduction.Location = New System.Drawing.Point(258, 182)
        Me.lblDeduction.Name = "lblDeduction"
        Me.lblDeduction.Size = New System.Drawing.Size(63, 15)
        Me.lblDeduction.TabIndex = 14
        Me.lblDeduction.Text = "Deduction"
        Me.lblDeduction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPay.Location = New System.Drawing.Point(259, 275)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(49, 15)
        Me.lblNetPay.TabIndex = 15
        Me.lblNetPay.Text = "Net Pay"
        Me.lblNetPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(484, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComputeToolStripMenuItem, Me.NextToolStripMenuItem, Me.StatsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ComputeToolStripMenuItem
        '
        Me.ComputeToolStripMenuItem.Name = "ComputeToolStripMenuItem"
        Me.ComputeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ComputeToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ComputeToolStripMenuItem.Text = "&Compute"
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.NextToolStripMenuItem.Text = "&Next"
        '
        'StatsToolStripMenuItem
        '
        Me.StatsToolStripMenuItem.Name = "StatsToolStripMenuItem"
        Me.StatsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.StatsToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.StatsToolStripMenuItem.Text = "&Stats"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 412)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.lblDeduction)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblPayRoll)
        Me.Controls.Add(Me.txtDeduction)
        Me.Controls.Add(Me.txtNetPay)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lab5(Alsukayti Mazen)"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtGrossPay As System.Windows.Forms.TextBox
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents txtNetPay As System.Windows.Forms.TextBox
    Friend WithEvents txtDeduction As System.Windows.Forms.TextBox
    Friend WithEvents lblPayRoll As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents lblGrossPay As System.Windows.Forms.Label
    Friend WithEvents lblDeduction As System.Windows.Forms.Label
    Friend WithEvents lblNetPay As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComputeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
