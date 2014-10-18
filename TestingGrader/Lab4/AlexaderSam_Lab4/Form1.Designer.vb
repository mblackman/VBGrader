<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab4
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
      Me.ComputeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
      Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.PeriodsPerYearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.ToolStripPPY1 = New System.Windows.Forms.ToolStripMenuItem()
      Me.ToolStripPPY4 = New System.Windows.Forms.ToolStripMenuItem()
      Me.ToolStripPPY12 = New System.Windows.Forms.ToolStripMenuItem()
      Me.ToolStripPPY365 = New System.Windows.Forms.ToolStripMenuItem()
      Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.lstFutureValues = New System.Windows.Forms.ListBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.txtPrinciple = New System.Windows.Forms.TextBox()
      Me.txtStart = New System.Windows.Forms.TextBox()
      Me.txtEnd = New System.Windows.Forms.TextBox()
      Me.cboRate = New System.Windows.Forms.ComboBox()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.lblPrinciple = New System.Windows.Forms.Label()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.MenuStrip1.SuspendLayout()
      Me.SuspendLayout()
      '
      'MenuStrip1
      '
      Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PeriodsPerYearToolStripMenuItem, Me.HelpToolStripMenuItem})
      Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
      Me.MenuStrip1.Name = "MenuStrip1"
      Me.MenuStrip1.Size = New System.Drawing.Size(604, 24)
      Me.MenuStrip1.TabIndex = 0
      Me.MenuStrip1.Text = "MenuStrip1"
      '
      'FileToolStripMenuItem
      '
      Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComputeToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
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
      'ToolStripMenuItem1
      '
      Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
      Me.ToolStripMenuItem1.Size = New System.Drawing.Size(163, 6)
      '
      'ExitToolStripMenuItem
      '
      Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
      Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
      Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
      Me.ExitToolStripMenuItem.Text = "E&xit"
      '
      'PeriodsPerYearToolStripMenuItem
      '
      Me.PeriodsPerYearToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripPPY1, Me.ToolStripPPY4, Me.ToolStripPPY12, Me.ToolStripPPY365})
      Me.PeriodsPerYearToolStripMenuItem.Name = "PeriodsPerYearToolStripMenuItem"
      Me.PeriodsPerYearToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
      Me.PeriodsPerYearToolStripMenuItem.Text = "&Periods Per Year"
      '
      'ToolStripPPY1
      '
      Me.ToolStripPPY1.CheckOnClick = True
      Me.ToolStripPPY1.Name = "ToolStripPPY1"
      Me.ToolStripPPY1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
      Me.ToolStripPPY1.Size = New System.Drawing.Size(134, 22)
      Me.ToolStripPPY1.Text = "1"
      '
      'ToolStripPPY4
      '
      Me.ToolStripPPY4.CheckOnClick = True
      Me.ToolStripPPY4.Name = "ToolStripPPY4"
      Me.ToolStripPPY4.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
      Me.ToolStripPPY4.Size = New System.Drawing.Size(134, 22)
      Me.ToolStripPPY4.Text = "4"
      '
      'ToolStripPPY12
      '
      Me.ToolStripPPY12.Checked = True
      Me.ToolStripPPY12.CheckOnClick = True
      Me.ToolStripPPY12.CheckState = System.Windows.Forms.CheckState.Checked
      Me.ToolStripPPY12.Name = "ToolStripPPY12"
      Me.ToolStripPPY12.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
      Me.ToolStripPPY12.Size = New System.Drawing.Size(134, 22)
      Me.ToolStripPPY12.Text = "12"
      '
      'ToolStripPPY365
      '
      Me.ToolStripPPY365.CheckOnClick = True
      Me.ToolStripPPY365.Name = "ToolStripPPY365"
      Me.ToolStripPPY365.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
      Me.ToolStripPPY365.Size = New System.Drawing.Size(134, 22)
      Me.ToolStripPPY365.Text = "365"
      '
      'HelpToolStripMenuItem
      '
      Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
      Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
      Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
      Me.HelpToolStripMenuItem.Text = "&Help"
      '
      'AboutToolStripMenuItem
      '
      Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
      Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
      Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
      Me.AboutToolStripMenuItem.Text = "&About"
      '
      'lstFutureValues
      '
      Me.lstFutureValues.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lstFutureValues.FormattingEnabled = True
      Me.lstFutureValues.ItemHeight = 21
      Me.lstFutureValues.Location = New System.Drawing.Point(117, 67)
      Me.lstFutureValues.Name = "lstFutureValues"
      Me.lstFutureValues.ScrollAlwaysVisible = True
      Me.lstFutureValues.Size = New System.Drawing.Size(370, 193)
      Me.lstFutureValues.TabIndex = 4
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(232, 40)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(141, 24)
      Me.Label1.TabIndex = 2
      Me.Label1.Text = "Future Values"
      '
      'txtPrinciple
      '
      Me.txtPrinciple.Location = New System.Drawing.Point(164, 306)
      Me.txtPrinciple.Name = "txtPrinciple"
      Me.txtPrinciple.Size = New System.Drawing.Size(100, 20)
      Me.txtPrinciple.TabIndex = 0
      '
      'txtStart
      '
      Me.txtStart.Location = New System.Drawing.Point(164, 355)
      Me.txtStart.Name = "txtStart"
      Me.txtStart.Size = New System.Drawing.Size(100, 20)
      Me.txtStart.TabIndex = 2
      '
      'txtEnd
      '
      Me.txtEnd.Location = New System.Drawing.Point(320, 355)
      Me.txtEnd.Name = "txtEnd"
      Me.txtEnd.Size = New System.Drawing.Size(100, 20)
      Me.txtEnd.TabIndex = 3
      '
      'cboRate
      '
      Me.cboRate.FormattingEnabled = True
      Me.cboRate.Items.AddRange(New Object() {"5", "6", "7", "8", "9", "10", "11", "12"})
      Me.cboRate.Location = New System.Drawing.Point(320, 306)
      Me.cboRate.Name = "cboRate"
      Me.cboRate.Size = New System.Drawing.Size(121, 21)
      Me.cboRate.TabIndex = 1
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(339, 290)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(83, 13)
      Me.Label2.TabIndex = 5
      Me.Label2.Text = "Annual Rate (%)"
      '
      'lblPrinciple
      '
      Me.lblPrinciple.AutoSize = True
      Me.lblPrinciple.Location = New System.Drawing.Point(191, 290)
      Me.lblPrinciple.Name = "lblPrinciple"
      Me.lblPrinciple.Size = New System.Drawing.Size(47, 13)
      Me.lblPrinciple.TabIndex = 6
      Me.lblPrinciple.Text = "Principle"
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Location = New System.Drawing.Point(187, 339)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(54, 13)
      Me.Label4.TabIndex = 7
      Me.Label4.Text = "Start Year"
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.Location = New System.Drawing.Point(345, 339)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(51, 13)
      Me.Label5.TabIndex = 8
      Me.Label5.Text = "End Year"
      '
      'frmLab4
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(604, 462)
      Me.ControlBox = False
      Me.Controls.Add(Me.Label5)
      Me.Controls.Add(Me.Label4)
      Me.Controls.Add(Me.lblPrinciple)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.cboRate)
      Me.Controls.Add(Me.txtEnd)
      Me.Controls.Add(Me.txtStart)
      Me.Controls.Add(Me.txtPrinciple)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.lstFutureValues)
      Me.Controls.Add(Me.MenuStrip1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.MainMenuStrip = Me.MenuStrip1
      Me.Name = "frmLab4"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Lab4 Sammy Alexander"
      Me.MenuStrip1.ResumeLayout(False)
      Me.MenuStrip1.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
   Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ComputeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents PeriodsPerYearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ToolStripPPY1 As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ToolStripPPY4 As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ToolStripPPY12 As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ToolStripPPY365 As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents lstFutureValues As System.Windows.Forms.ListBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtPrinciple As System.Windows.Forms.TextBox
   Friend WithEvents txtStart As System.Windows.Forms.TextBox
   Friend WithEvents txtEnd As System.Windows.Forms.TextBox
   Friend WithEvents cboRate As System.Windows.Forms.ComboBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents lblPrinciple As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
