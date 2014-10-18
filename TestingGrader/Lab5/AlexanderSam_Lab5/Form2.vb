Public Class Form2

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim intResult As DialogResult
        intResult = MessageBox.Show("The program is going to terminate." + vbCrLf + "Do you really want to exit?", "AlexanderS_Lab5",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If intResult = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub Form2_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        
        txtAverage.Text = Format(Average, "C")
        txtCount.Text = Count
        txtHighest.Text = Format(Highest, "C")
        txtLowest.Text = Format(Lowest, "C")
    End Sub

    Private Sub Form2_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim formwidth As Integer
        Dim formheight As Integer
        Dim temp As Integer
        Dim temp2 As Integer



        formwidth = Me.ClientSize.Width
        formheight = Me.ClientSize.Height

        'Top label control
        lblTitle.Left = (formwidth - lblTitle.Width) / 2

        'txt boxes width
        temp = (formwidth - lblAverage.Width - MIN_MARGIN - txtAverage.Width) / 2
        temp2 = temp + MIN_MARGIN + lblAverage.Width
        txtAverage.Left = temp2
        lblAverage.Left = temp
        txtCount.Left = temp2
        lblCount.Left = temp
        txtHighest.Left = temp2
        lblHighest.Left = temp
        txtLowest.Left = temp2
        lblLowest.Left = temp
        'txt boxes hight
        temp = (formheight - Me.MinimumSize.Height) / EXTRA_SPACE_DIVIDE_BY
        lblTitle.Top = temp + MIN_MARGIN + MENU_HEIGHT
        lblCount.Top = temp + lblTitle.Bottom + MIN_MARGIN
        txtCount.Top = lblCount.Top
        lblHighest.Top = temp + lblCount.Bottom
        txtHighest.Top = lblHighest.Top
        lblLowest.Top = temp + lblHighest.Bottom
        txtLowest.Top = lblLowest.Top
        lblAverage.Top = temp + lblLowest.Bottom
        txtAverage.Top = lblAverage.Top


    End Sub

    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Hide()
        frmPayRoll.Show()
        frmPayRoll.BringToFront()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTitle.Top = 65
        lblCount.Top = 146
        lblHighest.Top = 187
        lblLowest.Top = 228
        lblAverage.Top = 269
        txtCount.Top = 146
        txtHighest.Top = 187
        txtLowest.Top = 228
        txtAverage.Top = 269
        
    End Sub

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.ApplicationExitCall Then
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub
End Class