<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Me.cxtMenuPayment = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbLocation = New System.Windows.Forms.GroupBox()
        Me.rbInternational = New System.Windows.Forms.RadioButton()
        Me.rbNonResident = New System.Windows.Forms.RadioButton()
        Me.rbTriState = New System.Windows.Forms.RadioButton()
        Me.rbMinnesota = New System.Windows.Forms.RadioButton()
        Me.rbWisconsin = New System.Windows.Forms.RadioButton()
        Me.gbResHall = New System.Windows.Forms.GroupBox()
        Me.rbResNo = New System.Windows.Forms.RadioButton()
        Me.rbResYes = New System.Windows.Forms.RadioButton()
        Me.cbMealPlan = New System.Windows.Forms.ComboBox()
        Me.lblMealPlan = New System.Windows.Forms.Label()
        Me.gbParking = New System.Windows.Forms.GroupBox()
        Me.rbParkingNo = New System.Windows.Forms.RadioButton()
        Me.rbParkingYes = New System.Windows.Forms.RadioButton()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.cxtMenuPayment.SuspendLayout()
        Me.gbLocation.SuspendLayout()
        Me.gbResHall.SuspendLayout()
        Me.gbParking.SuspendLayout()
        Me.SuspendLayout()
        '
        'cxtMenuPayment
        '
        Me.cxtMenuPayment.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.cxtMenuPayment.Name = "cxtMenuPayment"
        Me.cxtMenuPayment.Size = New System.Drawing.Size(153, 70)
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
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'gbLocation
        '
        Me.gbLocation.Controls.Add(Me.rbInternational)
        Me.gbLocation.Controls.Add(Me.rbNonResident)
        Me.gbLocation.Controls.Add(Me.rbTriState)
        Me.gbLocation.Controls.Add(Me.rbMinnesota)
        Me.gbLocation.Controls.Add(Me.rbWisconsin)
        Me.gbLocation.Location = New System.Drawing.Point(113, 34)
        Me.gbLocation.Name = "gbLocation"
        Me.gbLocation.Size = New System.Drawing.Size(440, 60)
        Me.gbLocation.TabIndex = 1
        Me.gbLocation.TabStop = False
        Me.gbLocation.Text = "Where Do You Live?"
        '
        'rbInternational
        '
        Me.rbInternational.AutoSize = True
        Me.rbInternational.Location = New System.Drawing.Point(333, 28)
        Me.rbInternational.Name = "rbInternational"
        Me.rbInternational.Size = New System.Drawing.Size(83, 17)
        Me.rbInternational.TabIndex = 4
        Me.rbInternational.TabStop = True
        Me.rbInternational.Text = "International"
        Me.rbInternational.UseVisualStyleBackColor = True
        '
        'rbNonResident
        '
        Me.rbNonResident.AutoSize = True
        Me.rbNonResident.Location = New System.Drawing.Point(237, 28)
        Me.rbNonResident.Name = "rbNonResident"
        Me.rbNonResident.Size = New System.Drawing.Size(90, 17)
        Me.rbNonResident.TabIndex = 3
        Me.rbNonResident.TabStop = True
        Me.rbNonResident.Text = "Non-Resident"
        Me.rbNonResident.UseVisualStyleBackColor = True
        '
        'rbTriState
        '
        Me.rbTriState.AutoSize = True
        Me.rbTriState.Location = New System.Drawing.Point(166, 28)
        Me.rbTriState.Name = "rbTriState"
        Me.rbTriState.Size = New System.Drawing.Size(65, 17)
        Me.rbTriState.TabIndex = 2
        Me.rbTriState.TabStop = True
        Me.rbTriState.Text = "Tri-State"
        Me.rbTriState.UseVisualStyleBackColor = True
        '
        'rbMinnesota
        '
        Me.rbMinnesota.AutoSize = True
        Me.rbMinnesota.Location = New System.Drawing.Point(86, 28)
        Me.rbMinnesota.Name = "rbMinnesota"
        Me.rbMinnesota.Size = New System.Drawing.Size(74, 17)
        Me.rbMinnesota.TabIndex = 1
        Me.rbMinnesota.TabStop = True
        Me.rbMinnesota.Text = "Minnesota"
        Me.rbMinnesota.UseVisualStyleBackColor = True
        '
        'rbWisconsin
        '
        Me.rbWisconsin.AutoSize = True
        Me.rbWisconsin.Location = New System.Drawing.Point(6, 28)
        Me.rbWisconsin.Name = "rbWisconsin"
        Me.rbWisconsin.Size = New System.Drawing.Size(74, 17)
        Me.rbWisconsin.TabIndex = 0
        Me.rbWisconsin.TabStop = True
        Me.rbWisconsin.Text = "Wisconsin"
        Me.rbWisconsin.UseVisualStyleBackColor = True
        '
        'gbResHall
        '
        Me.gbResHall.Controls.Add(Me.rbResNo)
        Me.gbResHall.Controls.Add(Me.rbResYes)
        Me.gbResHall.Location = New System.Drawing.Point(113, 116)
        Me.gbResHall.Name = "gbResHall"
        Me.gbResHall.Size = New System.Drawing.Size(300, 60)
        Me.gbResHall.TabIndex = 2
        Me.gbResHall.TabStop = False
        Me.gbResHall.Text = "Will you be staying in the Residence Halls?"
        '
        'rbResNo
        '
        Me.rbResNo.AutoSize = True
        Me.rbResNo.Location = New System.Drawing.Point(125, 29)
        Me.rbResNo.Name = "rbResNo"
        Me.rbResNo.Size = New System.Drawing.Size(39, 17)
        Me.rbResNo.TabIndex = 1
        Me.rbResNo.TabStop = True
        Me.rbResNo.Text = "No"
        Me.rbResNo.UseVisualStyleBackColor = True
        '
        'rbResYes
        '
        Me.rbResYes.AutoSize = True
        Me.rbResYes.Location = New System.Drawing.Point(7, 29)
        Me.rbResYes.Name = "rbResYes"
        Me.rbResYes.Size = New System.Drawing.Size(43, 17)
        Me.rbResYes.TabIndex = 0
        Me.rbResYes.TabStop = True
        Me.rbResYes.Text = "Yes"
        Me.rbResYes.UseVisualStyleBackColor = True
        '
        'cbMealPlan
        '
        Me.cbMealPlan.FormattingEnabled = True
        Me.cbMealPlan.Location = New System.Drawing.Point(110, 211)
        Me.cbMealPlan.Name = "cbMealPlan"
        Me.cbMealPlan.Size = New System.Drawing.Size(220, 21)
        Me.cbMealPlan.TabIndex = 3
        '
        'lblMealPlan
        '
        Me.lblMealPlan.AutoSize = True
        Me.lblMealPlan.Location = New System.Drawing.Point(110, 192)
        Me.lblMealPlan.Name = "lblMealPlan"
        Me.lblMealPlan.Size = New System.Drawing.Size(100, 13)
        Me.lblMealPlan.TabIndex = 4
        Me.lblMealPlan.Text = "Choose a meal plan"
        '
        'gbParking
        '
        Me.gbParking.Controls.Add(Me.rbParkingNo)
        Me.gbParking.Controls.Add(Me.rbParkingYes)
        Me.gbParking.Location = New System.Drawing.Point(113, 254)
        Me.gbParking.Name = "gbParking"
        Me.gbParking.Size = New System.Drawing.Size(300, 60)
        Me.gbParking.TabIndex = 5
        Me.gbParking.TabStop = False
        Me.gbParking.Text = "Are you planning on parking your car on campus?"
        '
        'rbParkingNo
        '
        Me.rbParkingNo.AutoSize = True
        Me.rbParkingNo.Location = New System.Drawing.Point(103, 29)
        Me.rbParkingNo.Name = "rbParkingNo"
        Me.rbParkingNo.Size = New System.Drawing.Size(39, 17)
        Me.rbParkingNo.TabIndex = 1
        Me.rbParkingNo.TabStop = True
        Me.rbParkingNo.Text = "No"
        Me.rbParkingNo.UseVisualStyleBackColor = True
        '
        'rbParkingYes
        '
        Me.rbParkingYes.AutoSize = True
        Me.rbParkingYes.Location = New System.Drawing.Point(7, 29)
        Me.rbParkingYes.Name = "rbParkingYes"
        Me.rbParkingYes.Size = New System.Drawing.Size(43, 17)
        Me.rbParkingYes.TabIndex = 0
        Me.rbParkingYes.TabStop = True
        Me.rbParkingYes.Text = "Yes"
        Me.rbParkingYes.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(113, 332)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(146, 13)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "Your payment this semester is"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotal.Location = New System.Drawing.Point(130, 349)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 7
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 418)
        Me.ContextMenuStrip = Me.cxtMenuPayment
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.gbLocation)
        Me.Controls.Add(Me.lblMealPlan)
        Me.Controls.Add(Me.gbParking)
        Me.Controls.Add(Me.gbResHall)
        Me.Controls.Add(Me.cbMealPlan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MinimumSize = New System.Drawing.Size(450, 350)
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lab6 (Alex Becker)"
        Me.cxtMenuPayment.ResumeLayout(False)
        Me.gbLocation.ResumeLayout(False)
        Me.gbLocation.PerformLayout()
        Me.gbResHall.ResumeLayout(False)
        Me.gbResHall.PerformLayout()
        Me.gbParking.ResumeLayout(False)
        Me.gbParking.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cxtMenuPayment As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gbLocation As System.Windows.Forms.GroupBox
    Friend WithEvents rbInternational As System.Windows.Forms.RadioButton
    Friend WithEvents rbNonResident As System.Windows.Forms.RadioButton
    Friend WithEvents rbTriState As System.Windows.Forms.RadioButton
    Friend WithEvents rbMinnesota As System.Windows.Forms.RadioButton
    Friend WithEvents rbWisconsin As System.Windows.Forms.RadioButton
    Friend WithEvents gbResHall As System.Windows.Forms.GroupBox
    Friend WithEvents rbResNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbResYes As System.Windows.Forms.RadioButton
    Friend WithEvents cbMealPlan As System.Windows.Forms.ComboBox
    Friend WithEvents lblMealPlan As System.Windows.Forms.Label
    Friend WithEvents gbParking As System.Windows.Forms.GroupBox
    Friend WithEvents rbParkingNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbParkingYes As System.Windows.Forms.RadioButton
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
End Class
