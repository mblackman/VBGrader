Public Class frmSqrt

    Private Sub txtInput_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtInput.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Back)
            Case "0" To "9"
            Case "."
                If InStr(txtInput.Text, ".") > 0 Then
                    Beep()
                    e.Handled = True
                End If
            Case Else
                Beep()
                e.Handled = True
        End Select
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnSwitch_Click(sender As System.Object, e As System.EventArgs) Handles btnSwitch.Click
        Me.Hide()
        BackForm.Show()
        BackForm.BringToFront()
    End Sub

    Private Sub btnCompute_Click(sender As System.Object, e As System.EventArgs) Handles btnCompute.Click
        Dim Input As Double
        Dim Result As Double

        If (txtInput.Text = "") Then
            Exit Sub
        End If

        Input = Convert.ToDouble(txtInput.Text)
        Result = Math.Sqrt(Input)
        txtSquare.Text = Format(Result, "n")
    End Sub

    Private Sub frmSqrt_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        Dim FormWidth As Integer = Me.ClientSize.Width
        Dim FormHeight As Integer = Me.ClientSize.Height
        Dim x As Integer

        'calculate L/R positions of buttons
        x = (FormWidth - btnCompute.Width - btnSwitch.Width - btnExit.Width) / 2

        btnCompute.Left = x
        btnSwitch.Left = btnCompute.Left + btnCompute.Width
        btnExit.Left = btnSwitch.Left + btnSwitch.Width

        'Calculate L/R of text boxes
        x = (FormWidth - txtInput.Width - txtSquare.Width) / 5

        txtInput.Left = 2 * x
        lblInput.Left = 2 * x

        txtSquare.Left = txtInput.Left + txtInput.Width + x
        lblSqrt.Left = txtInput.Left + txtInput.Width + x

        'Calculate T/B
        x = (FormHeight - lblInput.Height - txtInput.Height - btnCompute.Height - 10) / 3

        lblInput.Top = x
        lblSqrt.Top = x

        txtInput.Top = lblInput.Top + 10 + lblInput.Height
        txtSquare.Top = lblSqrt.Top + 10 + lblSqrt.Height

        btnCompute.Top = x + txtSquare.Top + txtSquare.Height
        btnSwitch.Top = x + txtSquare.Top + txtSquare.Height
        btnExit.Top = x + txtSquare.Top + txtSquare.Height
    End Sub
End Class
