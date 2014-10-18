<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGraderClass
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.txtFileFolder = New System.Windows.Forms.TextBox()
        Me.txtInputFile = New System.Windows.Forms.TextBox()
        Me.rdoFile = New System.Windows.Forms.RadioButton()
        Me.rdoFolder = New System.Windows.Forms.RadioButton()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(800, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Single EXE File"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(800, 127)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Multiple EXE Files"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(800, 178)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Single Solution"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(800, 229)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(114, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Multiple Solutions"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(800, 280)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(114, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "EXIT"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(117, 55)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(133, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Find File or Folder"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(117, 248)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(133, 23)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Find Input File"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'txtFileFolder
        '
        Me.txtFileFolder.Location = New System.Drawing.Point(22, 147)
        Me.txtFileFolder.Name = "txtFileFolder"
        Me.txtFileFolder.Size = New System.Drawing.Size(323, 20)
        Me.txtFileFolder.TabIndex = 7
        '
        'txtInputFile
        '
        Me.txtInputFile.Location = New System.Drawing.Point(22, 314)
        Me.txtInputFile.Name = "txtInputFile"
        Me.txtInputFile.Size = New System.Drawing.Size(323, 20)
        Me.txtInputFile.TabIndex = 8
        '
        'rdoFile
        '
        Me.rdoFile.AutoSize = True
        Me.rdoFile.Checked = True
        Me.rdoFile.Location = New System.Drawing.Point(99, 97)
        Me.rdoFile.Name = "rdoFile"
        Me.rdoFile.Size = New System.Drawing.Size(62, 17)
        Me.rdoFile.TabIndex = 9
        Me.rdoFile.TabStop = True
        Me.rdoFile.Text = "Exe File"
        Me.rdoFile.UseVisualStyleBackColor = True
        '
        'rdoFolder
        '
        Me.rdoFolder.AutoSize = True
        Me.rdoFolder.Location = New System.Drawing.Point(211, 97)
        Me.rdoFolder.Name = "rdoFolder"
        Me.rdoFolder.Size = New System.Drawing.Size(54, 17)
        Me.rdoFolder.TabIndex = 10
        Me.rdoFolder.Text = "Folder"
        Me.rdoFolder.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(401, 12)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(354, 400)
        Me.txtOutput.TabIndex = 11
        '
        'FormGraderClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 438)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.rdoFolder)
        Me.Controls.Add(Me.rdoFile)
        Me.Controls.Add(Me.txtInputFile)
        Me.Controls.Add(Me.txtFileFolder)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FormGraderClass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UWP CSSE - VB Grader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents Button1 As System.Windows.Forms.Button
   Friend WithEvents Button2 As System.Windows.Forms.Button
   Friend WithEvents Button3 As System.Windows.Forms.Button
   Friend WithEvents Button4 As System.Windows.Forms.Button
   Friend WithEvents Button5 As System.Windows.Forms.Button
   Friend WithEvents Button6 As System.Windows.Forms.Button
   Friend WithEvents Button7 As System.Windows.Forms.Button
   Friend WithEvents txtFileFolder As System.Windows.Forms.TextBox
   Friend WithEvents txtInputFile As System.Windows.Forms.TextBox
   Friend WithEvents rdoFile As System.Windows.Forms.RadioButton
   Friend WithEvents rdoFolder As System.Windows.Forms.RadioButton
   Friend WithEvents txtOutput As System.Windows.Forms.TextBox
End Class
