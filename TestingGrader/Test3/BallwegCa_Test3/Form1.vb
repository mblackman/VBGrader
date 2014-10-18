Public Class Form1

    Private Sub txtInput_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtInput.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Back)
                'good
            Case "0" To "9"
                'good
            Case "."
                ' allow the first one
                If InStr(txtInput.Text, ".") Then
                    Beep()
                    e.Handled = True
                End If
            Case Else
                Beep()
                e.Handled = True
        End Select
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnSwitch_Click(sender As System.Object, e As System.EventArgs) Handles btnSwitch.Click
        Me.Hide()
        Form2.Show()
        Form2.BringToFront()
    End Sub

    Private Sub btnCompute_Click(sender As System.Object, e As System.EventArgs) Handles btnCompute.Click
        Dim squareRoot As Double
        Dim number As Integer
        If txtInput.Text = "" Then
            Exit Sub
        End If
        number = txtInput.Text
        squareRoot = Math.Sqrt(number)
        txtSquare.Text = Format(squareRoot, "n")
    End Sub

    Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Dim FormWidth As Integer
        Dim FormHeight As Integer
        Dim temp As Integer

        FormWidth = Me.ClientSize.Width
        FormHeight = Me.ClientSize.Height

        temp = (FormWidth - btnCompute.Width - btnSwitch.Width - btnExit.Width) / 2
        btnCompute.Left = temp
        btnSwitch.Left = temp + btnCompute.Width
        btnExit.Left = temp + btnCompute.Width + btnSwitch.Width

        temp = (FormHeight - lblInput.Height - txtInput.Height - btnCompute.Height) / 4
        lblInput.Top = temp
        lblSqrt.Top = temp
        txtInput.Top = temp + lblInput.Height
        txtSquare.Top = temp + txtInput.Height - 5
        btnCompute.Top = temp + txtInput.Height + txtSquare.Height + 30
        btnSwitch.Top = temp + txtInput.Height + txtSquare.Height + 30
        btnExit.Top = temp + txtInput.Height + txtSquare.Height + 30

        temp = (FormWidth - 2 * btnExit.Width - 10) / 3
        txtInput.Left = temp
        txtSquare.Left = txtInput.Right + temp + 10
        lblInput.Left = temp
        lblSqrt.Left = txtInput.Right + temp + 10



    End Sub
End Class
