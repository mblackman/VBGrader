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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtcount = New System.Windows.Forms.TextBox()
        Me.txthighest = New System.Windows.Forms.TextBox()
        Me.txtaverage = New System.Windows.Forms.TextBox()
        Me.txtlowest = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GrossPayStats = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        'txtcount
        '
        Me.txtcount.BackColor = System.Drawing.SystemColors.Window
        Me.txtcount.Location = New System.Drawing.Point(216, 139)
        Me.txtcount.Name = "txtcount"
        Me.txtcount.ReadOnly = True
        Me.txtcount.Size = New System.Drawing.Size(100, 20)
        Me.txtcount.TabIndex = 1
        Me.txtcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txthighest
        '
        Me.txthighest.BackColor = System.Drawing.SystemColors.Window
        Me.txthighest.Location = New System.Drawing.Point(216, 180)
        Me.txthighest.Name = "txthighest"
        Me.txthighest.ReadOnly = True
        Me.txthighest.Size = New System.Drawing.Size(100, 20)
        Me.txthighest.TabIndex = 2
        Me.txthighest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtaverage
        '
        Me.txtaverage.BackColor = System.Drawing.SystemColors.Window
        Me.txtaverage.Location = New System.Drawing.Point(216, 262)
        Me.txtaverage.Name = "txtaverage"
        Me.txtaverage.ReadOnly = True
        Me.txtaverage.Size = New System.Drawing.Size(100, 20)
        Me.txtaverage.TabIndex = 3
        Me.txtaverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtlowest
        '
        Me.txtlowest.BackColor = System.Drawing.SystemColors.Window
        Me.txtlowest.Location = New System.Drawing.Point(216, 221)
        Me.txtlowest.Name = "txtlowest"
        Me.txtlowest.ReadOnly = True
        Me.txtlowest.Size = New System.Drawing.Size(100, 20)
        Me.txtlowest.TabIndex = 4
        Me.txtlowest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(160, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Count"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(157, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Highest"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(157, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Lowest"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(151, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Average"
        '
        'GrossPayStats
        '
        Me.GrossPayStats.AutoSize = True
        Me.GrossPayStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrossPayStats.Location = New System.Drawing.Point(149, 60)
        Me.GrossPayStats.Name = "GrossPayStats"
        Me.GrossPayStats.Size = New System.Drawing.Size(167, 25)
        Me.GrossPayStats.TabIndex = 9
        Me.GrossPayStats.Text = "Gross Pay Stats"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 342)
        Me.ControlBox = False
        Me.Controls.Add(Me.GrossPayStats)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtlowest)
        Me.Controls.Add(Me.txtaverage)
        Me.Controls.Add(Me.txthighest)
        Me.Controls.Add(Me.txtcount)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(180, 254)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stats (Caleb Ballweg)"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtcount As System.Windows.Forms.TextBox
    Friend WithEvents txthighest As System.Windows.Forms.TextBox
    Friend WithEvents txtaverage As System.Windows.Forms.TextBox
    Friend WithEvents txtlowest As System.Windows.Forms.TextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents GrossPayStats As System.Windows.Forms.Label
End Class
