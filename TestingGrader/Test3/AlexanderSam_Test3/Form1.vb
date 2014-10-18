Public Class Form1
    Dim root, input As Double
 
    Private Sub txtInput_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtInput.KeyPress
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
        frmBack.Show()
        frmBack.BringToFront()
    End Sub

    Private Sub btnCompute_Click(sender As System.Object, e As System.EventArgs) Handles btnCompute.Click
        input = Convert.ToDouble(txtInput.Text)
        root = Math.Sqrt(input)
        txtSquare.Text = Format(root, "Standard")
    End Sub

    Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Dim formwidth As Integer
        Dim formheight As Integer
        Dim temp As Integer

        formwidth = Me.ClientSize.Width
        formheight = Me.ClientSize.Height

        temp = (formwidth - (2 * txtInput.Width)) / (5 / 2)
        txtInput.Left = temp
        txtSquare.Left = txtInput.Right + temp / 2
        lblInput.Left = txtInput.Left
        lblSqrt.Left = txtSquare.Left
        temp = (formheight - lblInput.Height - txtInput.Height - btnCompute.Height) / 4
        lblInput.Top = temp
        lblSqrt.Top = temp
        txtInput.Top = lblInput.Bottom + temp
        txtSquare.Top = txtInput.Top
        btnCompute.Top = txtSquare.Bottom + temp
        btnExit.Top = btnCompute.Top
        btnSwitch.Top = btnCompute.Top
        temp = (formwidth - btnCompute.Width * 3) / 2
        btnCompute.Left = temp
        btnSwitch.Left = btnCompute.Right
        btnExit.Left = btnSwitch.Right

    End Sub
End Class
