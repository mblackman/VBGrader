Public Class Form2

    Private Sub BackToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Hide()
        frmPayRoll.Show()
        frmPayRoll.BringToFront()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If MessageBox.Show("This Program is going to terminate." + vbCrLf +
                           "Do you really want to exit?", "BeckerA_Lab5", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Form2_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        Dim FormWidth As Integer
        Dim FormHeight As Integer

        FormWidth = Me.ClientSize.Width
        FormHeight = Me.ClientSize.Height

        Dim x As Integer
        lblStats.Left = (FormWidth - lblStats.Width) / 2

        lblCount.Left = (FormWidth - lblCount.Width - SPACE_BETWEEN_LABLE_TEXTBOX - txtCount.Width) / 2
        txtCount.Left = lblCount.Left + lblCount.Width + SPACE_BETWEEN_LABLE_TEXTBOX

        lblHighest.Left = (FormWidth - lblHighest.Width - SPACE_BETWEEN_LABLE_TEXTBOX - txtHighest.Width) / 2
        txtHighest.Left = lblHighest.Left + lblHighest.Width + SPACE_BETWEEN_LABLE_TEXTBOX

        lblLowest.Left = (FormWidth - lblLowest.Width - SPACE_BETWEEN_LABLE_TEXTBOX - txtLowest.Width) / 2
        txtLowest.Left = lblLowest.Left + lblLowest.Width + SPACE_BETWEEN_LABLE_TEXTBOX

        lblAverage.Left = (FormWidth - lblAverage.Width - SPACE_BETWEEN_LABLE_TEXTBOX - txtAverage.Width) / 2
        txtAverage.Left = lblAverage.Left + lblAverage.Width + SPACE_BETWEEN_LABLE_TEXTBOX

        x = (FormHeight - (4 * lblCount.Height) - lblStats.Height - MENU_HEIGHT - MIN_MARGIN * 3) / EXTRA_SPACE_DIVIDE_BY

        If x < 0 Then
            x = 0
        End If

        lblStats.Top = MENU_HEIGHT + x + MIN_MARGIN

        lblCount.Top = lblStats.Top + lblStats.Height + x + MIN_MARGIN
        txtCount.Top = lblCount.Top

        lblHighest.Top = lblCount.Top + lblCount.Height + x
        txtHighest.Top = lblHighest.Top

        lblLowest.Top = lblHighest.Top + lblHighest.Height + x
        txtLowest.Top = lblLowest.Top

        lblAverage.Top = lblLowest.Top + lblLowest.Height + x
        txtAverage.Top = lblAverage.Top
        'End If
    End Sub

    Private Sub Form2_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.ApplicationExitCall Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Form2_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        txtCount.Text = Count
        txtLowest.Text = FormatCurrency(Lowest)
        txtHighest.Text = FormatCurrency(Highest)
        txtAverage.Text = FormatCurrency(Average)
    End Sub
End Class