<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSqrt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtSquare = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.lblSqrt = New System.Windows.Forms.Label()
        Me.btnSwitch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(130, 126)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 0
        '
        'txtSquare
        '
        Me.txtSquare.BackColor = System.Drawing.SystemColors.Window
        Me.txtSquare.Location = New System.Drawing.Point(262, 126)
        Me.txtSquare.Name = "txtSquare"
        Me.txtSquare.ReadOnly = True
        Me.txtSquare.Size = New System.Drawing.Size(100, 20)
        Me.txtSquare.TabIndex = 3
        Me.txtSquare.TabStop = False
        Me.txtSquare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(116, 190)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(75, 23)
        Me.btnCompute.TabIndex = 1
        Me.btnCompute.Text = "&Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(287, 190)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(127, 110)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(31, 13)
        Me.lblInput.TabIndex = 4
        Me.lblInput.Text = "Input"
        Me.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSqrt
        '
        Me.lblSqrt.AutoSize = True
        Me.lblSqrt.Location = New System.Drawing.Point(259, 110)
        Me.lblSqrt.Name = "lblSqrt"
        Me.lblSqrt.Size = New System.Drawing.Size(67, 13)
        Me.lblSqrt.TabIndex = 5
        Me.lblSqrt.Text = "Square Root"
        Me.lblSqrt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSwitch
        '
        Me.btnSwitch.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSwitch.Location = New System.Drawing.Point(197, 190)
        Me.btnSwitch.Name = "btnSwitch"
        Me.btnSwitch.Size = New System.Drawing.Size(75, 23)
        Me.btnSwitch.TabIndex = 6
        Me.btnSwitch.Text = "&Switch"
        Me.btnSwitch.UseVisualStyleBackColor = True
        '
        'frmSqrt
        '
        Me.AcceptButton = Me.btnCompute
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(484, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSwitch)
        Me.Controls.Add(Me.lblSqrt)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtSquare)
        Me.Controls.Add(Me.txtInput)
        Me.MinimumSize = New System.Drawing.Size(300, 120)
        Me.Name = "frmSqrt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Test 3 (Michael Ababio)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents txtSquare As System.Windows.Forms.TextBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblInput As System.Windows.Forms.Label
    Friend WithEvents lblSqrt As System.Windows.Forms.Label
    Friend WithEvents btnSwitch As System.Windows.Forms.Button

End Class
