Public Class Form2

   Private Sub BackToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
        Form1.BringToFront()

        txtcount.Text = count
        txthighest.Text = Highest
        txtlowest.Text = Lowest
        txtaverage.Text = Average
   End Sub

   Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim result As MsgBoxResult
        result = MessageBox.Show("The program is going to terminate." & vbCrLf & "Do you really want to exit?", "Lab5", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = MsgBoxResult.Yes Then
            End
        End If
   End Sub

   Private Sub Form2_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
      If e.CloseReason = CloseReason.UserClosing Then
         If MsgBox("The program is going to terminate." & vbCrLf & "Do you really want to exit?", "Lab5", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            e.Cancel = True
         End If
      End If
   End Sub

   Private Sub Form2_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
      Dim FormWidth As Integer
      Dim FormHeight As Integer
      Dim temp As Integer

      FormWidth = Me.ClientSize.Width
      FormHeight = Me.ClientSize.Height

        temp = (FormWidth - GrossPayStats.Width) / 2
        GrossPayStats.Left = temp

        Label1.Left = GrossPayStats.Left
        txtcount.Left = Label1.Right + SPACE_BETWEEN_LABEL_TEXTBOX
        Label2.Left = GrossPayStats.Left
        txthighest.Left = Label2.Right + SPACE_BETWEEN_LABEL_TEXTBOX
        Label3.Left = GrossPayStats.Left
        txtlowest.Left = Label3.Right + SPACE_BETWEEN_LABEL_TEXTBOX
        Label4.Left = GrossPayStats.Left
        txtaverage.Left = Label4.Right + SPACE_BETWEEN_LABEL_TEXTBOX

        temp = (FormHeight - GrossPayStats.Height - txtaverage.Height - txtcount.Height - txthighest.Height - txtlowest.Height) / EXTRA_SPACE_DIVIDE_BY
        GrossPayStats.Top = temp + MENU_HEIGHT + EXTRA_SPACE_DIVIDE_BY

        Label1.Top = temp + GrossPayStats.Height + 4 * MIN_MARGIN + 6
        txtcount.Top = temp + GrossPayStats.Height + 4 * MIN_MARGIN



   End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtcount.Text = count
        txthighest.Text = Highest
        txtlowest.Text = Lowest
        txtaverage.Text = Average
    End Sub
End Class