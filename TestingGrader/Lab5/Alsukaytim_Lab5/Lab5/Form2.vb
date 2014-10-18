Public Class Form2

    Private Sub Form2_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        TextBox4.Text = Count
        TextBox3.Text = Highest
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Hide()
        frmPayRoll.Show()
        frmPayRoll.BringToFront()


    End Sub

    Private Sub Form2_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim FormWidth As Integer
        Dim FormHeight As Integer
        Dim temp As Integer

        FormWidth = Me.ClientSize.Width
        FormHeight = Me.ClientSize.Height

        'lblGrossPay.Top = (FormHeight - lblGrossPay.Height) / 2
        lblGrossPay.Left = (FormWidth - lblGrossPay.Width) / 2

        temp = (FormWidth - 5 * lblcount.Width - SPACE_BETWEEN_LABEL_TEXTBOX) / 6

        lblcount.Left = temp
        lblcount.Left = lblcount.Left + lblcount.Width + temp + SPACE_BETWEEN_LABEL_TEXTBOX


        temp = (FormWidth - 5 * lblLowest.Width - SPACE_BETWEEN_LABEL_TEXTBOX) / 6

        lblLowest.Left = temp
        lblLowest.Left = lblLowest.Left + lblLowest.Width + temp + SPACE_BETWEEN_LABEL_TEXTBOX


        temp = (FormWidth - 5 * lblHighest.Width - SPACE_BETWEEN_LABEL_TEXTBOX) / 6

        lblHighest.Left = temp
        lblHighest.Left = lblHighest.Left + lblHighest.Width + temp + SPACE_BETWEEN_LABEL_TEXTBOX
        

        temp = (FormWidth - 5 * lblAverage.Width - SPACE_BETWEEN_LABEL_TEXTBOX) / 6

        lblAverage.Left = temp
        lblAverage.Left = lblAverage.Left + lblAverage.Width + temp + SPACE_BETWEEN_LABEL_TEXTBOX

        temp = (FormWidth - 5 * lblAverage.Width - SPACE_BETWEEN_LABEL_TEXTBOX) / 6

        TextBox4.Left = temp
        TextBox4.Left = TextBox4.Left + TextBox4.Width + temp + SPACE_BETWEEN_LABEL_TEXTBOX

        TextBox3.Left = temp
        TextBox3.Left = TextBox3.Left + TextBox3.Width + temp + SPACE_BETWEEN_LABEL_TEXTBOX

        TextBox2.Left = temp
        TextBox2.Left = TextBox2.Left + TextBox2.Width + temp + SPACE_BETWEEN_LABEL_TEXTBOX

        TextBox1.Left = temp
        TextBox1.Left = TextBox1.Left + TextBox1.Width + temp + SPACE_BETWEEN_LABEL_TEXTBOX
    End Sub
End Class