Public Class Form2

   
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        frmTest3.Show()
        frmTest3.BringToFront()
    End Sub
End Class