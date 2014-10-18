Public Class frmSqrt
    Dim number, square_num As Double
    Private Sub txtInput_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtInput.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Back)
            Case "0" To "9"
            Case "."
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
        frmBack.Show()
        frmBack.BringToFront()
    End Sub

    Private Sub btnCompute_Click(sender As System.Object, e As System.EventArgs) Handles btnCompute.Click
        number = txtInput.Text
        square_num = Math.Sqrt(number)
        txtSquare.Text = Format(square_num, "n")
    End Sub

    Private Sub frmSqrt_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Dim FormWidth As Integer
        Dim FormHeight As Integer
        Dim temp As Integer

        FormWidth = Me.ClientSize.Width
        FormHeight = Me.ClientSize.Height

        temp = ((FormWidth - 3 * btnCompute.Width) / 2)
        btnCompute.Left = temp
        btnSwitch.Left = temp + btnCompute.Width
        btnExit.Left = temp + btnCompute.Width + btnSwitch.Width
        txtInput.Left = temp

        temp = FormHeight / 3
        txtInput.Top = temp
        txtSquare.Top = temp
        btnCompute.Top = 2 * txtInput.Top
        btnSwitch.Top = 2 * txtInput.Top
        btnExit.Top = 2 * txtInput.Top
        lblInput.Top = temp - txtInput.Height
        lblSqrt.Top = temp - txtSquare.Height



    End Sub
End Class
