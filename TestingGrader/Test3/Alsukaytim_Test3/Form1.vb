Public Class Form1

 
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnCompute_Click(sender As System.Object, e As System.EventArgs) Handles btnCompute.Click
        Dim num As Double

        num = txtInput.Text
        num = Math.Sqrt(num)

        txtSquare.Text = Format(num, "n")

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

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

        temp = (FormWidth - txtInput.Width - txtSquare.Width) / 3
        txtInput.Left = temp
        txtSquare.Left = temp + txtInput.Width + txtInput.Left

        temp = (FormWidth - lblInput.Width - lblSqrt.Width) / 3
        lblInput.Left = temp
        lblSqrt.Left = temp + lblInput.Width + lblInput.Left

        temp = (FormHeight - btnCompute.Height - txtInput.Height - lblInput.Height) / 2
        lblInput.Top = temp
        txtInput.Top = temp + lblInput.Height + 10
        btnCompute.Top = temp + lblInput.Height + 10 + lblInput.Height + temp / 2
        lblSqrt.Top = temp
        txtSquare.Top = temp + lblInput.Height + 10
        btnSwitch.Top = temp + lblInput.Height + 10 + lblInput.Height + temp / 2
        btnExit.Top = temp + lblInput.Height + 10 + lblInput.Height + temp / 2
    End Sub

    Private Sub btnSwitch_Click(sender As System.Object, e As System.EventArgs) Handles btnSwitch.Click
        Me.Hide()
        frmSec.Show()
        frmSec.BringToFront()
    End Sub
End Class
