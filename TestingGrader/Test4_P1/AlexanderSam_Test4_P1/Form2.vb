'----------------------------------------------
' Name       : Sammy Alexander
' Course     : CS2340, Section 1, Fall 2012
' Description: Test 4I
'              Form frmData
'----------------------------------------------
Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Form1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        If e.Button <> Windows.Forms.MouseButtons.Right Then Return
        ContextMenuStrip1.Show(Me, e.Location)

    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
        Form1.BringToFront()

    End Sub

    
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

    End Sub
End Class