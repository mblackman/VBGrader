Public Class Form2

   
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
        Form1.BringToFront()
    End Sub
End Class