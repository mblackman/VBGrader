<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.txtHighest = New System.Windows.Forms.TextBox()
        Me.txtLowest = New System.Windows.Forms.TextBox()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblHighest = New System.Windows.Forms.Label()
        Me.lblLowest = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCount
        '
        Me.txtCount.BackColor = System.Drawing.SystemColors.Window
        Me.txtCount.Location = New System.Drawing.Point(218, 143)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.ReadOnly = True
        Me.txtCount.Size = New System.Drawing.Size(100, 20)
        Me.txtCount.TabIndex = 1
        Me.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHighest
        '
        Me.txtHighest.BackColor = System.Drawing.SystemColors.Window
        Me.txtHighest.Location = New System.Drawing.Point(218, 185)
        Me.txtHighest.Name = "txtHighest"
        Me.txtHighest.ReadOnly = True
        Me.txtHighest.Size = New System.Drawing.Size(100, 20)
        Me.txtHighest.TabIndex = 2
        Me.txtHighest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLowest
        '
        Me.txtLowest.BackColor = System.Drawing.SystemColors.Window
        Me.txtLowest.Location = New System.Drawing.Point(218, 227)
        Me.txtLowest.Name = "txtLowest"
        Me.txtLowest.ReadOnly = True
        Me.txtLowest.Size = New System.Drawing.Size(100, 20)
        Me.txtLowest.TabIndex = 3
        Me.txtLowest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAverage
        '
        Me.txtAverage.BackColor = System.Drawing.SystemColors.Window
        Me.txtAverage.Location = New System.Drawing.Point(218, 269)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.ReadOnly = True
        Me.txtAverage.Size = New System.Drawing.Size(100, 20)
        Me.txtAverage.TabIndex = 4
        Me.txtAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(159, 143)
        Me.lblCount.MaximumSize = New System.Drawing.Size(50, 25)
        Me.lblCount.MinimumSize = New System.Drawing.Size(50, 25)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(50, 25)
        Me.lblCount.TabIndex = 5
        Me.lblCount.Text = "Count"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHighest
        '
        Me.lblHighest.AutoSize = True
        Me.lblHighest.Location = New System.Drawing.Point(151, 185)
        Me.lblHighest.MaximumSize = New System.Drawing.Size(50, 25)
        Me.lblHighest.MinimumSize = New System.Drawing.Size(50, 25)
        Me.lblHighest.Name = "lblHighest"
        Me.lblHighest.Size = New System.Drawing.Size(50, 25)
        Me.lblHighest.TabIndex = 6
        Me.lblHighest.Text = "Highest"
        Me.lblHighest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLowest
        '
        Me.lblLowest.AutoSize = True
        Me.lblLowest.Location = New System.Drawing.Point(153, 227)
        Me.lblLowest.MaximumSize = New System.Drawing.Size(50, 25)
        Me.lblLowest.MinimumSize = New System.Drawing.Size(50, 25)
        Me.lblLowest.Name = "lblLowest"
        Me.lblLowest.Size = New System.Drawing.Size(50, 25)
        Me.lblLowest.TabIndex = 7
        Me.lblLowest.Text = "Lowest"
        Me.lblLowest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(147, 269)
        Me.lblAverage.MaximumSize = New System.Drawing.Size(50, 25)
        Me.lblAverage.MinimumSize = New System.Drawing.Size(50, 25)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(50, 25)
        Me.lblAverage.TabIndex = 8
        Me.lblAverage.Text = "Average"
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(151, 73)
        Me.lblTitle.MaximumSize = New System.Drawing.Size(170, 40)
        Me.lblTitle.MinimumSize = New System.Drawing.Size(170, 40)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(170, 40)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "Gross Pay Stats"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.BackToolStripMenuItem.Text = "&Back"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(464, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 342)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblLowest)
        Me.Controls.Add(Me.lblHighest)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.txtAverage)
        Me.Controls.Add(Me.txtLowest)
        Me.Controls.Add(Me.txtHighest)
        Me.Controls.Add(Me.txtCount)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(180, 254)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stats (Sammy Alexander)"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCount As System.Windows.Forms.TextBox
    Friend WithEvents txtHighest As System.Windows.Forms.TextBox
    Friend WithEvents txtLowest As System.Windows.Forms.TextBox
    Friend WithEvents txtAverage As System.Windows.Forms.TextBox
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents lblHighest As System.Windows.Forms.Label
    Friend WithEvents lblLowest As System.Windows.Forms.Label
    Friend WithEvents lblAverage As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
End Class
