Public Class frmStats

    Private Sub frmStats_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.ApplicationExitCall Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub frmStats_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCount.Text = Count
        txtHighest.Text = FormatCurrency(Highest)
        txtLowest.Text = FormatCurrency(Lowest)
        txtAverage.Text = FormatCurrency(Average)
    End Sub

    Private Sub mnuBack_Click(sender As System.Object, e As System.EventArgs) Handles mnuBack.Click
        Me.Hide()
        frmPayRoll.Show()
        frmPayRoll.BringToFront()
    End Sub

    Private Sub mnuExit_Click(sender As System.Object, e As System.EventArgs) Handles mnuExit.Click
        If MessageBox.Show("The program is going to terminate." + vbCrLf + "Do you really want to exit?", "AbabioM_Lab5", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            End
        Else
        End If
    End Sub

    Private Sub frmStats_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Dim FormWidth As Integer
        Dim FormHeight As Integer
        Dim temp As Integer

        FormWidth = Me.ClientSize.Width
        FormHeight = Me.ClientSize.Height

        temp = ((FormWidth - lblCount.Width - SPACE_BETWEEN_LABEL_TEXTBOX - txtCount.Width) / 2)
        lblCount.Left = temp
        txtCount.Left = lblCount.Width + temp + SPACE_BETWEEN_LABEL_TEXTBOX

        temp = ((FormWidth - lblHighest.Width - SPACE_BETWEEN_LABEL_TEXTBOX - txtHighest.Width) / 2)
        lblHighest.Left = temp
        txtHighest.Left = lblHighest.Width + temp + SPACE_BETWEEN_LABEL_TEXTBOX

        temp = ((FormWidth - lblLowest.Width - SPACE_BETWEEN_LABEL_TEXTBOX - txtLowest.Width) / 2)
        lblLowest.Left = temp
        txtLowest.Left = lblLowest.Width + temp + SPACE_BETWEEN_LABEL_TEXTBOX

        temp = ((FormWidth - lblAverage.Width - SPACE_BETWEEN_LABEL_TEXTBOX - txtAverage.Width) / 2)
        lblAverage.Left = temp
        txtAverage.Left = lblAverage.Width + temp + SPACE_BETWEEN_LABEL_TEXTBOX

        temp = ((FormWidth - lblGrossPayStats.Width) / 2)
        lblGrossPayStats.Left = temp

        temp = ((FormHeight - MENU_HEIGHT) - ((3 * MIN_MARGIN) + lblGrossPayStats.Height + (4 * txtCount.Height))) / EXTRA_SPACE_DIVIDE_BY
        lblGrossPayStats.Top = temp + MIN_MARGIN + MENU_HEIGHT
        lblCount.Top = (2 * temp) + (2 * MIN_MARGIN) + MENU_HEIGHT + lblGrossPayStats.Height
        txtCount.Top = (2 * temp) + (2 * MIN_MARGIN) + MENU_HEIGHT + lblGrossPayStats.Height

        lblHighest.Top = (3 * temp) + (2 * MIN_MARGIN) + MENU_HEIGHT + lblGrossPayStats.Height + txtCount.Height
        txtHighest.Top = (3 * temp) + (2 * MIN_MARGIN) + MENU_HEIGHT + lblGrossPayStats.Height + txtCount.Height

        lblLowest.Top = (4 * temp) + (2 * MIN_MARGIN) + MENU_HEIGHT + lblGrossPayStats.Height + (2 * txtCount.Height)
        txtLowest.Top = (4 * temp) + (2 * MIN_MARGIN) + MENU_HEIGHT + lblGrossPayStats.Height + (2 * txtCount.Height)

        lblAverage.Top = (5 * temp) + (2 * MIN_MARGIN) + MENU_HEIGHT + lblGrossPayStats.Height + (3 * txtCount.Height)
        txtAverage.Top = (5 * temp) + (2 * MIN_MARGIN) + MENU_HEIGHT + lblGrossPayStats.Height + (3 * txtCount.Height)
    End Sub
End Class