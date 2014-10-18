Public Class Form1

   Dim Scores(10) As Single

   Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs)
      UserClosingForm(e)
    End Sub

    Private Sub Form1_FormClosing1(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.ApplicationExitCall Then
            End
        Else
            e.Cancel = True
            MessageBox.Show("Sorry, the form cannot be closed this way!" & vbCrLf & "Use the form Shortcut menu please.", "Lab 6", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

   Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      Available.Items.Clear()

      Available.Items.Add("CS143             3")
      Available.Items.Add("CS234             3")
      Available.Items.Add("CS334             3")
      Available.Items.Add("CS243             3")
      Available.Items.Add("CS323             3")
      Available.Items.Add("CS363             3")
      Available.Items.Add("CS387             3")
      Available.Items.Add("MATH264           4")
      Available.Items.Add("MATH274           4")
      Available.Items.Add("CHEM105           5")
      Available.Items.Add("BIO115            5")

   End Sub

   Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)

      For x = Available.Items.Count - 1 To 0 Step -1
         If Available.GetSelected(x) Then
            Selected.Items.Add(Available.Items(x))
            Available.Items.RemoveAt(x)
         End If
      Next
   End Sub


   Private Sub ListBox1_DoubleClick(sender As Object, e As System.EventArgs) Handles Available.DoubleClick
      For index As Integer = Available.Items.Count - 1 To 0 Step -1
         If Available.GetSelected(index) Then
            Selected.Items.Add(Available.Items(index))
            Available.Items.RemoveAt(index)
         End If
      Next
   End Sub

   Private Sub SortClassesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SortClassesToolStripMenuItem.Click
        Available.Sorted() = True
        Selected.Sorted() = True
   End Sub

    Private Sub ResetListBoxesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ResetListBoxesToolStripMenuItem.Click
        Available.Items.Clear()
        Selected.Items.Clear()

        Available.Sorted() = False
        Selected.Sorted() = False

        Available.Items.Add("CS143             3")
        Available.Items.Add("CS234             3")
        Available.Items.Add("CS334             3")
        Available.Items.Add("CS243             3")
        Available.Items.Add("CS323             3")
        Available.Items.Add("CS363             3")
        Available.Items.Add("CS387             3")
        Available.Items.Add("MATH264           4")
        Available.Items.Add("MATH274           4")
        Available.Items.Add("CHEM105           5")
        Available.Items.Add("BIO115            5")
    End Sub

   Private Sub NextToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles NextToolStripMenuItem.Click
      Me.Hide()
      frmReg.Show()
      frmReg.BringToFront()
   End Sub

   Private Sub ExitToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
      Application.Exit()
   End Sub

    Private Sub Selected_DoubleClick(sender As Object, e As System.EventArgs) Handles Selected.DoubleClick
        For index As Integer = Selected.Items.Count - 1 To 0 Step -1
            If Selected.GetSelected(index) Then
                Available.Items.Add(Available.Items(index))
                Selected.Items.RemoveAt(index)
            End If
        Next
    End Sub

    Private Sub btnSelect_Click(sender As System.Object, e As System.EventArgs) Handles btnSelect.Click
        For index As Integer = Available.Items.Count - 1 To 0 Step -1
            If Available.GetSelected(index) Then
                Selected.Items.Add(Available.Items(index))
                Available.Items.RemoveAt(index)
            End If
        Next
    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        For index As Integer = Selected.Items.Count - 1 To 0 Step -1
            If Selected.GetSelected(index) Then
                Available.Items.Add(Available.Items(index))
                Selected.Items.RemoveAt(index)
            End If
        Next
    End Sub

    Private Sub btnRemoveAll_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveAll.Click
        For index As Integer = Selected.Items.Count - 1 To 0 Step -1
            Available.Items.Add(Selected.Items(index))
            Selected.Items.RemoveAt(index)
        Next
    End Sub

    Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Dim FormWidth As Integer
        Dim FormHeight As Integer
        Dim temp As Integer

        FormWidth = Me.ClientSize.Width
        FormHeight = Me.ClientSize.Height

        temp = (FormWidth - Label3.Width) / 2
        Label3.Left = temp

        temp = (FormWidth - 2 * Available.Width - btnSelect.Width) / 4
        Available.Left = temp
        Label1.Left = temp + 30
        Label2.Left = temp + Available.Width + btnSelect.Width + 90
        btnSelect.Left = temp + Available.Width + 30
        btnRemove.Left = temp + Available.Width + 30
        btnRemoveAll.Left = temp + Available.Width + 30
        Selected.Left = temp + Available.Width + btnSelect.Width + 60

    End Sub
End Class
