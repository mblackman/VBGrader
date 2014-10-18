Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
        Form1.BringToFront()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class