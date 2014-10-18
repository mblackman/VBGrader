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
      Me.components = New System.ComponentModel.Container()
      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
      Me.rdoInter = New System.Windows.Forms.RadioButton()
      Me.rdoNon = New System.Windows.Forms.RadioButton()
      Me.rdoTri = New System.Windows.Forms.RadioButton()
      Me.rdoMinn = New System.Windows.Forms.RadioButton()
      Me.rdoWis = New System.Windows.Forms.RadioButton()
      Me.GroupBox2 = New System.Windows.Forms.GroupBox()
      Me.rdoNo1 = New System.Windows.Forms.RadioButton()
      Me.rdoYes1 = New System.Windows.Forms.RadioButton()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.cboMeal = New System.Windows.Forms.ComboBox()
      Me.GroupBox3 = New System.Windows.Forms.GroupBox()
      Me.rdoNo2 = New System.Windows.Forms.RadioButton()
      Me.rdoYes2 = New System.Windows.Forms.RadioButton()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.txtTotal = New System.Windows.Forms.TextBox()
      Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
      Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.GroupBox1.SuspendLayout()
      Me.GroupBox2.SuspendLayout()
      Me.GroupBox3.SuspendLayout()
      Me.ContextMenuStrip1.SuspendLayout()
      Me.SuspendLayout()
      '
      'GroupBox1
      '
      Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
      Me.GroupBox1.Controls.Add(Me.rdoInter)
      Me.GroupBox1.Controls.Add(Me.rdoNon)
      Me.GroupBox1.Controls.Add(Me.rdoTri)
      Me.GroupBox1.Controls.Add(Me.rdoMinn)
      Me.GroupBox1.Controls.Add(Me.rdoWis)
      Me.GroupBox1.Location = New System.Drawing.Point(135, 32)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(440, 60)
      Me.GroupBox1.TabIndex = 0
      Me.GroupBox1.TabStop = False
      Me.GroupBox1.Text = "Where do you live?"
      '
      'rdoInter
      '
      Me.rdoInter.AutoSize = True
      Me.rdoInter.Location = New System.Drawing.Point(342, 22)
      Me.rdoInter.Name = "rdoInter"
      Me.rdoInter.Size = New System.Drawing.Size(83, 17)
      Me.rdoInter.TabIndex = 4
      Me.rdoInter.Text = "International"
      Me.rdoInter.UseVisualStyleBackColor = True
      '
      'rdoNon
      '
      Me.rdoNon.AutoSize = True
      Me.rdoNon.Location = New System.Drawing.Point(246, 22)
      Me.rdoNon.Name = "rdoNon"
      Me.rdoNon.Size = New System.Drawing.Size(90, 17)
      Me.rdoNon.TabIndex = 3
      Me.rdoNon.Text = "Non-Resident"
      Me.rdoNon.UseVisualStyleBackColor = True
      '
      'rdoTri
      '
      Me.rdoTri.AutoSize = True
      Me.rdoTri.Location = New System.Drawing.Point(175, 22)
      Me.rdoTri.Name = "rdoTri"
      Me.rdoTri.Size = New System.Drawing.Size(65, 17)
      Me.rdoTri.TabIndex = 2
      Me.rdoTri.Text = "Tri-State"
      Me.rdoTri.UseVisualStyleBackColor = True
      '
      'rdoMinn
      '
      Me.rdoMinn.AutoSize = True
      Me.rdoMinn.Location = New System.Drawing.Point(95, 22)
      Me.rdoMinn.Name = "rdoMinn"
      Me.rdoMinn.Size = New System.Drawing.Size(74, 17)
      Me.rdoMinn.TabIndex = 1
      Me.rdoMinn.Text = "Minnesota"
      Me.rdoMinn.UseVisualStyleBackColor = True
      '
      'rdoWis
      '
      Me.rdoWis.AutoSize = True
      Me.rdoWis.Location = New System.Drawing.Point(15, 22)
      Me.rdoWis.Name = "rdoWis"
      Me.rdoWis.Size = New System.Drawing.Size(74, 17)
      Me.rdoWis.TabIndex = 0
      Me.rdoWis.Text = "Wisconsin"
      Me.rdoWis.UseVisualStyleBackColor = True
      '
      'GroupBox2
      '
      Me.GroupBox2.Controls.Add(Me.rdoNo1)
      Me.GroupBox2.Controls.Add(Me.rdoYes1)
      Me.GroupBox2.Location = New System.Drawing.Point(135, 110)
      Me.GroupBox2.Name = "GroupBox2"
      Me.GroupBox2.Size = New System.Drawing.Size(300, 60)
      Me.GroupBox2.TabIndex = 1
      Me.GroupBox2.TabStop = False
      Me.GroupBox2.Text = "Will you be staying in the Resident Halls?"
      '
      'rdoNo1
      '
      Me.rdoNo1.AutoSize = True
      Me.rdoNo1.Location = New System.Drawing.Point(95, 22)
      Me.rdoNo1.Name = "rdoNo1"
      Me.rdoNo1.Size = New System.Drawing.Size(39, 17)
      Me.rdoNo1.TabIndex = 1
      Me.rdoNo1.Text = "No"
      Me.rdoNo1.UseVisualStyleBackColor = True
      '
      'rdoYes1
      '
      Me.rdoYes1.AutoSize = True
      Me.rdoYes1.Location = New System.Drawing.Point(15, 22)
      Me.rdoYes1.Name = "rdoYes1"
      Me.rdoYes1.Size = New System.Drawing.Size(43, 17)
      Me.rdoYes1.TabIndex = 0
      Me.rdoYes1.Text = "Yes"
      Me.rdoYes1.UseVisualStyleBackColor = True
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(132, 188)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(100, 13)
      Me.Label1.TabIndex = 2
      Me.Label1.Text = "Choose a meal plan"
      Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'cboMeal
      '
      Me.cboMeal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboMeal.FormattingEnabled = True
      Me.cboMeal.Items.AddRange(New Object() {"Regular", "     19 meals per week", "     15 meals per week", "     14 meals per week and $50 per semester", "     110 meals and $125 per semester", "     90 meals and $100 per semester", "     150 meals and $100 per semester", "     175 meals and $100 per semester", "Commute and off-campus only meal plan", "     No meal plan", "     50 meals per semester", "     50 meals and $75 per semester", "     75 meals and $100 per semester"})
      Me.cboMeal.Location = New System.Drawing.Point(150, 219)
      Me.cboMeal.Name = "cboMeal"
      Me.cboMeal.Size = New System.Drawing.Size(220, 21)
      Me.cboMeal.TabIndex = 2
      '
      'GroupBox3
      '
      Me.GroupBox3.Controls.Add(Me.rdoNo2)
      Me.GroupBox3.Controls.Add(Me.rdoYes2)
      Me.GroupBox3.Location = New System.Drawing.Point(135, 258)
      Me.GroupBox3.Name = "GroupBox3"
      Me.GroupBox3.Size = New System.Drawing.Size(300, 60)
      Me.GroupBox3.TabIndex = 3
      Me.GroupBox3.TabStop = False
      Me.GroupBox3.Text = "Are you planning to park your car on campus?"
      '
      'rdoNo2
      '
      Me.rdoNo2.AutoSize = True
      Me.rdoNo2.Location = New System.Drawing.Point(95, 22)
      Me.rdoNo2.Name = "rdoNo2"
      Me.rdoNo2.Size = New System.Drawing.Size(39, 17)
      Me.rdoNo2.TabIndex = 1
      Me.rdoNo2.Text = "No"
      Me.rdoNo2.UseVisualStyleBackColor = True
      '
      'rdoYes2
      '
      Me.rdoYes2.AutoSize = True
      Me.rdoYes2.Location = New System.Drawing.Point(15, 22)
      Me.rdoYes2.Name = "rdoYes2"
      Me.rdoYes2.Size = New System.Drawing.Size(43, 17)
      Me.rdoYes2.TabIndex = 0
      Me.rdoYes2.Text = "Yes"
      Me.rdoYes2.UseVisualStyleBackColor = True
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(132, 336)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(146, 13)
      Me.Label2.TabIndex = 5
      Me.Label2.Text = "Your payment this semester is"
      Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'txtTotal
      '
      Me.txtTotal.BackColor = System.Drawing.SystemColors.Window
      Me.txtTotal.Location = New System.Drawing.Point(150, 367)
      Me.txtTotal.Name = "txtTotal"
      Me.txtTotal.ReadOnly = True
      Me.txtTotal.Size = New System.Drawing.Size(100, 20)
      Me.txtTotal.TabIndex = 0
      Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'ContextMenuStrip1
      '
      Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem, Me.ExitToolStripMenuItem})
      Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
      Me.ContextMenuStrip1.Size = New System.Drawing.Size(141, 48)
      '
      'BackToolStripMenuItem
      '
      Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
      Me.BackToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
      Me.BackToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
      Me.BackToolStripMenuItem.Text = "Back"
      '
      'ExitToolStripMenuItem
      '
      Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
      Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
      Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
      Me.ExitToolStripMenuItem.Text = "Exit"
      '
      'Form2
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(710, 418)
      Me.Controls.Add(Me.txtTotal)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.GroupBox3)
      Me.Controls.Add(Me.cboMeal)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.GroupBox2)
      Me.Controls.Add(Me.GroupBox1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
      Me.MinimumSize = New System.Drawing.Size(450, 350)
      Me.Name = "Form2"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Lab6 (Sammy Alexander)"
      Me.GroupBox1.ResumeLayout(False)
      Me.GroupBox1.PerformLayout()
      Me.GroupBox2.ResumeLayout(False)
      Me.GroupBox2.PerformLayout()
      Me.GroupBox3.ResumeLayout(False)
      Me.GroupBox3.PerformLayout()
      Me.ContextMenuStrip1.ResumeLayout(False)
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Friend WithEvents rdoInter As System.Windows.Forms.RadioButton
   Friend WithEvents rdoNon As System.Windows.Forms.RadioButton
   Friend WithEvents rdoTri As System.Windows.Forms.RadioButton
   Friend WithEvents rdoMinn As System.Windows.Forms.RadioButton
   Friend WithEvents rdoWis As System.Windows.Forms.RadioButton
   Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
   Friend WithEvents rdoNo1 As System.Windows.Forms.RadioButton
   Friend WithEvents rdoYes1 As System.Windows.Forms.RadioButton
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cboMeal As System.Windows.Forms.ComboBox
   Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
   Friend WithEvents rdoNo2 As System.Windows.Forms.RadioButton
   Friend WithEvents rdoYes2 As System.Windows.Forms.RadioButton
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtTotal As System.Windows.Forms.TextBox
   Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
   Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
