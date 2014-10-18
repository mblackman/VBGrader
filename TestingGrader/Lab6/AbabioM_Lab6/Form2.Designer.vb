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
      Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
      Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
      Me.rdoInternational = New System.Windows.Forms.RadioButton()
      Me.rdoNonResident = New System.Windows.Forms.RadioButton()
      Me.rdoTriState = New System.Windows.Forms.RadioButton()
      Me.rdoMinnesota = New System.Windows.Forms.RadioButton()
      Me.rdoWisconsin = New System.Windows.Forms.RadioButton()
      Me.GroupBox2 = New System.Windows.Forms.GroupBox()
      Me.rdoResNo = New System.Windows.Forms.RadioButton()
      Me.rdoResYes = New System.Windows.Forms.RadioButton()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.cboMealPlan = New System.Windows.Forms.ComboBox()
      Me.GroupBox3 = New System.Windows.Forms.GroupBox()
      Me.rdoCarNo = New System.Windows.Forms.RadioButton()
      Me.rdoCarYes = New System.Windows.Forms.RadioButton()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.txtPayment = New System.Windows.Forms.TextBox()
      Me.ContextMenuStrip1.SuspendLayout()
      Me.GroupBox1.SuspendLayout()
      Me.GroupBox2.SuspendLayout()
      Me.GroupBox3.SuspendLayout()
      Me.SuspendLayout()
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
      'GroupBox1
      '
      Me.GroupBox1.Controls.Add(Me.rdoInternational)
      Me.GroupBox1.Controls.Add(Me.rdoNonResident)
      Me.GroupBox1.Controls.Add(Me.rdoTriState)
      Me.GroupBox1.Controls.Add(Me.rdoMinnesota)
      Me.GroupBox1.Controls.Add(Me.rdoWisconsin)
      Me.GroupBox1.Location = New System.Drawing.Point(128, 39)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(440, 60)
      Me.GroupBox1.TabIndex = 1
      Me.GroupBox1.TabStop = False
      Me.GroupBox1.Text = "Where do you live?"
      '
      'rdoInternational
      '
      Me.rdoInternational.AutoSize = True
      Me.rdoInternational.Location = New System.Drawing.Point(341, 38)
      Me.rdoInternational.Name = "rdoInternational"
      Me.rdoInternational.Size = New System.Drawing.Size(83, 17)
      Me.rdoInternational.TabIndex = 4
      Me.rdoInternational.TabStop = True
      Me.rdoInternational.Text = "International"
      Me.rdoInternational.UseVisualStyleBackColor = True
      '
      'rdoNonResident
      '
      Me.rdoNonResident.AutoSize = True
      Me.rdoNonResident.Location = New System.Drawing.Point(243, 38)
      Me.rdoNonResident.Name = "rdoNonResident"
      Me.rdoNonResident.Size = New System.Drawing.Size(90, 17)
      Me.rdoNonResident.TabIndex = 3
      Me.rdoNonResident.Text = "Non-Resident"
      Me.rdoNonResident.UseVisualStyleBackColor = True
      '
      'rdoTriState
      '
      Me.rdoTriState.AutoSize = True
      Me.rdoTriState.Location = New System.Drawing.Point(170, 37)
      Me.rdoTriState.Name = "rdoTriState"
      Me.rdoTriState.Size = New System.Drawing.Size(65, 17)
      Me.rdoTriState.TabIndex = 2
      Me.rdoTriState.Text = "Tri-State"
      Me.rdoTriState.UseVisualStyleBackColor = True
      '
      'rdoMinnesota
      '
      Me.rdoMinnesota.AutoSize = True
      Me.rdoMinnesota.Location = New System.Drawing.Point(88, 38)
      Me.rdoMinnesota.Name = "rdoMinnesota"
      Me.rdoMinnesota.Size = New System.Drawing.Size(74, 17)
      Me.rdoMinnesota.TabIndex = 1
      Me.rdoMinnesota.Text = "Minnesota"
      Me.rdoMinnesota.UseVisualStyleBackColor = True
      '
      'rdoWisconsin
      '
      Me.rdoWisconsin.AutoSize = True
      Me.rdoWisconsin.Location = New System.Drawing.Point(6, 37)
      Me.rdoWisconsin.Name = "rdoWisconsin"
      Me.rdoWisconsin.Size = New System.Drawing.Size(74, 17)
      Me.rdoWisconsin.TabIndex = 0
      Me.rdoWisconsin.Text = "Wisconsin"
      Me.rdoWisconsin.UseVisualStyleBackColor = True
      '
      'GroupBox2
      '
      Me.GroupBox2.Controls.Add(Me.rdoResNo)
      Me.GroupBox2.Controls.Add(Me.rdoResYes)
      Me.GroupBox2.Location = New System.Drawing.Point(128, 130)
      Me.GroupBox2.Name = "GroupBox2"
      Me.GroupBox2.Size = New System.Drawing.Size(300, 60)
      Me.GroupBox2.TabIndex = 2
      Me.GroupBox2.TabStop = False
      Me.GroupBox2.Text = "Will you be staying in the Residence Halls?"
      '
      'rdoResNo
      '
      Me.rdoResNo.AutoSize = True
      Me.rdoResNo.Location = New System.Drawing.Point(88, 19)
      Me.rdoResNo.Name = "rdoResNo"
      Me.rdoResNo.Size = New System.Drawing.Size(39, 17)
      Me.rdoResNo.TabIndex = 1
      Me.rdoResNo.TabStop = True
      Me.rdoResNo.Text = "No"
      Me.rdoResNo.UseVisualStyleBackColor = True
      '
      'rdoResYes
      '
      Me.rdoResYes.AutoSize = True
      Me.rdoResYes.Location = New System.Drawing.Point(6, 19)
      Me.rdoResYes.Name = "rdoResYes"
      Me.rdoResYes.Size = New System.Drawing.Size(43, 17)
      Me.rdoResYes.TabIndex = 0
      Me.rdoResYes.TabStop = True
      Me.rdoResYes.Text = "Yes"
      Me.rdoResYes.UseVisualStyleBackColor = True
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(125, 219)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(100, 13)
      Me.Label1.TabIndex = 3
      Me.Label1.Text = "Choose a meal plan"
      Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'cboMealPlan
      '
      Me.cboMealPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboMealPlan.FormattingEnabled = True
      Me.cboMealPlan.Items.AddRange(New Object() {"Regular", "     19 meals per week", "     15 meals per week", "     14 meals per week and $50 per semester", "     110 meals and $125 per semester", "     90 meals and $100 per semester", "     150 meals and $100 per semester", "     175 meals and $100 per semester", "Commute and off-campus only meal plan", "     No meal plan", "     50 meals per semester", "     50 meals and $75 per semester", "     75 meals and $100 per semester"})
      Me.cboMealPlan.Location = New System.Drawing.Point(143, 248)
      Me.cboMealPlan.Name = "cboMealPlan"
      Me.cboMealPlan.Size = New System.Drawing.Size(220, 21)
      Me.cboMealPlan.TabIndex = 4
      '
      'GroupBox3
      '
      Me.GroupBox3.Controls.Add(Me.rdoCarNo)
      Me.GroupBox3.Controls.Add(Me.rdoCarYes)
      Me.GroupBox3.Location = New System.Drawing.Point(128, 291)
      Me.GroupBox3.Name = "GroupBox3"
      Me.GroupBox3.Size = New System.Drawing.Size(300, 60)
      Me.GroupBox3.TabIndex = 5
      Me.GroupBox3.TabStop = False
      Me.GroupBox3.Text = "Are you planning to park your car on campus?"
      '
      'rdoCarNo
      '
      Me.rdoCarNo.AutoSize = True
      Me.rdoCarNo.Location = New System.Drawing.Point(88, 19)
      Me.rdoCarNo.Name = "rdoCarNo"
      Me.rdoCarNo.Size = New System.Drawing.Size(39, 17)
      Me.rdoCarNo.TabIndex = 1
      Me.rdoCarNo.TabStop = True
      Me.rdoCarNo.Text = "No"
      Me.rdoCarNo.UseVisualStyleBackColor = True
      '
      'rdoCarYes
      '
      Me.rdoCarYes.AutoSize = True
      Me.rdoCarYes.Location = New System.Drawing.Point(6, 19)
      Me.rdoCarYes.Name = "rdoCarYes"
      Me.rdoCarYes.Size = New System.Drawing.Size(43, 17)
      Me.rdoCarYes.TabIndex = 0
      Me.rdoCarYes.TabStop = True
      Me.rdoCarYes.Text = "Yes"
      Me.rdoCarYes.UseVisualStyleBackColor = True
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(131, 363)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(146, 13)
      Me.Label2.TabIndex = 6
      Me.Label2.Text = "Your payment this semester is"
      Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'txtPayment
      '
      Me.txtPayment.BackColor = System.Drawing.SystemColors.Window
      Me.txtPayment.Location = New System.Drawing.Point(155, 388)
      Me.txtPayment.Name = "txtPayment"
      Me.txtPayment.ReadOnly = True
      Me.txtPayment.Size = New System.Drawing.Size(100, 20)
      Me.txtPayment.TabIndex = 0
      Me.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'Form2
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(710, 418)
      Me.ContextMenuStrip = Me.ContextMenuStrip1
      Me.Controls.Add(Me.GroupBox1)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.txtPayment)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.GroupBox3)
      Me.Controls.Add(Me.GroupBox2)
      Me.Controls.Add(Me.cboMealPlan)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
      Me.MinimumSize = New System.Drawing.Size(450, 350)
      Me.Name = "Form2"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Lab6 (Michael Ababio)"
      Me.ContextMenuStrip1.ResumeLayout(False)
      Me.GroupBox1.ResumeLayout(False)
      Me.GroupBox1.PerformLayout()
      Me.GroupBox2.ResumeLayout(False)
      Me.GroupBox2.PerformLayout()
      Me.GroupBox3.ResumeLayout(False)
      Me.GroupBox3.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoInternational As System.Windows.Forms.RadioButton
    Friend WithEvents rdoNonResident As System.Windows.Forms.RadioButton
    Friend WithEvents rdoTriState As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMinnesota As System.Windows.Forms.RadioButton
    Friend WithEvents rdoWisconsin As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoResNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdoResYes As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboMealPlan As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoCarNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCarYes As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPayment As System.Windows.Forms.TextBox
End Class
