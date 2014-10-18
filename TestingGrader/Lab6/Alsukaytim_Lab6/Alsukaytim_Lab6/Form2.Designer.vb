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
        Me.RadioInt = New System.Windows.Forms.RadioButton()
        Me.RadioNon = New System.Windows.Forms.RadioButton()
        Me.RadioTri = New System.Windows.Forms.RadioButton()
        Me.RadioMin = New System.Windows.Forms.RadioButton()
        Me.RadioWI = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioNoHalls = New System.Windows.Forms.RadioButton()
        Me.RadioYesHalls = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMealPlan = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioNoPark = New System.Windows.Forms.RadioButton()
        Me.RadioYpark = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boxPayment = New System.Windows.Forms.TextBox()
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
        Me.GroupBox1.Controls.Add(Me.RadioInt)
        Me.GroupBox1.Controls.Add(Me.RadioNon)
        Me.GroupBox1.Controls.Add(Me.RadioTri)
        Me.GroupBox1.Controls.Add(Me.RadioMin)
        Me.GroupBox1.Controls.Add(Me.RadioWI)
        Me.GroupBox1.Location = New System.Drawing.Point(129, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 60)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Where do you live?"
        '
        'RadioInt
        '
        Me.RadioInt.AutoSize = True
        Me.RadioInt.Location = New System.Drawing.Point(333, 24)
        Me.RadioInt.Name = "RadioInt"
        Me.RadioInt.Size = New System.Drawing.Size(83, 17)
        Me.RadioInt.TabIndex = 4
        Me.RadioInt.TabStop = True
        Me.RadioInt.Text = "International"
        Me.RadioInt.UseVisualStyleBackColor = True
        '
        'RadioNon
        '
        Me.RadioNon.AutoSize = True
        Me.RadioNon.Location = New System.Drawing.Point(237, 24)
        Me.RadioNon.Name = "RadioNon"
        Me.RadioNon.Size = New System.Drawing.Size(90, 17)
        Me.RadioNon.TabIndex = 3
        Me.RadioNon.TabStop = True
        Me.RadioNon.Text = "Non-Resident"
        Me.RadioNon.UseVisualStyleBackColor = True
        '
        'RadioTri
        '
        Me.RadioTri.AutoSize = True
        Me.RadioTri.Location = New System.Drawing.Point(166, 24)
        Me.RadioTri.Name = "RadioTri"
        Me.RadioTri.Size = New System.Drawing.Size(65, 17)
        Me.RadioTri.TabIndex = 2
        Me.RadioTri.TabStop = True
        Me.RadioTri.Text = "Tri-State"
        Me.RadioTri.UseVisualStyleBackColor = True
        '
        'RadioMin
        '
        Me.RadioMin.AutoSize = True
        Me.RadioMin.Location = New System.Drawing.Point(86, 24)
        Me.RadioMin.Name = "RadioMin"
        Me.RadioMin.Size = New System.Drawing.Size(74, 17)
        Me.RadioMin.TabIndex = 1
        Me.RadioMin.TabStop = True
        Me.RadioMin.Text = "Minnesota"
        Me.RadioMin.UseVisualStyleBackColor = True
        '
        'RadioWI
        '
        Me.RadioWI.AutoSize = True
        Me.RadioWI.Location = New System.Drawing.Point(6, 24)
        Me.RadioWI.Name = "RadioWI"
        Me.RadioWI.Size = New System.Drawing.Size(74, 17)
        Me.RadioWI.TabIndex = 0
        Me.RadioWI.TabStop = True
        Me.RadioWI.Text = "Wisconsin"
        Me.RadioWI.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioNoHalls)
        Me.GroupBox2.Controls.Add(Me.RadioYesHalls)
        Me.GroupBox2.Location = New System.Drawing.Point(129, 111)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 60)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Will you be staying in the Residence Halls?"
        '
        'RadioNoHalls
        '
        Me.RadioNoHalls.AutoSize = True
        Me.RadioNoHalls.Location = New System.Drawing.Point(96, 24)
        Me.RadioNoHalls.Name = "RadioNoHalls"
        Me.RadioNoHalls.Size = New System.Drawing.Size(39, 17)
        Me.RadioNoHalls.TabIndex = 4
        Me.RadioNoHalls.Text = "No"
        Me.RadioNoHalls.UseVisualStyleBackColor = True
        '
        'RadioYesHalls
        '
        Me.RadioYesHalls.AutoSize = True
        Me.RadioYesHalls.Location = New System.Drawing.Point(6, 24)
        Me.RadioYesHalls.Name = "RadioYesHalls"
        Me.RadioYesHalls.Size = New System.Drawing.Size(43, 17)
        Me.RadioYesHalls.TabIndex = 0
        Me.RadioYesHalls.Text = "Yes"
        Me.RadioYesHalls.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Choose a meal plan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboMealPlan
        '
        Me.cboMealPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMealPlan.FormattingEnabled = True
        Me.cboMealPlan.Items.AddRange(New Object() {" Regular", "           19 meals per week", "           15 meals per week", "           14 meals per week and $50 per semester", "           110 meals and $125 per semester", "           90 meals and $100 per semester", "           150 meals and $100 per semester", "           175 meals and $100 per semester", "      Commute and off-campus only meal plan", "           No meal plan", "           50 meals per semester", "           50 meals and $75 per semester", "           75 meals and $100 per semester"})
        Me.cboMealPlan.Location = New System.Drawing.Point(150, 216)
        Me.cboMealPlan.Name = "cboMealPlan"
        Me.cboMealPlan.Size = New System.Drawing.Size(220, 21)
        Me.cboMealPlan.TabIndex = 7
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioNoPark)
        Me.GroupBox3.Controls.Add(Me.RadioYpark)
        Me.GroupBox3.Location = New System.Drawing.Point(135, 263)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(300, 60)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Are you planning to park your car on campus?"
        '
        'RadioNoPark
        '
        Me.RadioNoPark.AutoSize = True
        Me.RadioNoPark.Location = New System.Drawing.Point(96, 24)
        Me.RadioNoPark.Name = "RadioNoPark"
        Me.RadioNoPark.Size = New System.Drawing.Size(39, 17)
        Me.RadioNoPark.TabIndex = 4
        Me.RadioNoPark.TabStop = True
        Me.RadioNoPark.Text = "No"
        Me.RadioNoPark.UseVisualStyleBackColor = True
        '
        'RadioYpark
        '
        Me.RadioYpark.AutoSize = True
        Me.RadioYpark.Location = New System.Drawing.Point(6, 24)
        Me.RadioYpark.Name = "RadioYpark"
        Me.RadioYpark.Size = New System.Drawing.Size(43, 17)
        Me.RadioYpark.TabIndex = 0
        Me.RadioYpark.TabStop = True
        Me.RadioYpark.Text = "Yes"
        Me.RadioYpark.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 352)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Your payment this semester is"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'boxPayment
        '
        Me.boxPayment.BackColor = System.Drawing.SystemColors.Window
        Me.boxPayment.Location = New System.Drawing.Point(149, 377)
        Me.boxPayment.Name = "boxPayment"
        Me.boxPayment.ReadOnly = True
        Me.boxPayment.Size = New System.Drawing.Size(100, 20)
        Me.boxPayment.TabIndex = 10
        Me.boxPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 70)
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BackToolStripMenuItem.Text = "&Back"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(710, 418)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.boxPayment)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cboMealPlan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MinimumSize = New System.Drawing.Size(450, 350)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lab6_Alsukayti Mazen"
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
    Friend WithEvents RadioInt As System.Windows.Forms.RadioButton
    Friend WithEvents RadioNon As System.Windows.Forms.RadioButton
    Friend WithEvents RadioTri As System.Windows.Forms.RadioButton
    Friend WithEvents RadioMin As System.Windows.Forms.RadioButton
    Friend WithEvents RadioWI As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioNoHalls As System.Windows.Forms.RadioButton
    Friend WithEvents RadioYesHalls As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboMealPlan As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioNoPark As System.Windows.Forms.RadioButton
    Friend WithEvents RadioYpark As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents boxPayment As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
