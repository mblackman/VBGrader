Public Class Form1
   Dim newlst As New ListBox
   Dim FormWidth As Integer
   Dim FormHeight As Integer
   Dim Temp, Temp2 As Integer

   'This handles what happens when the Select button is clicked.
    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        For x = lstAvailable.Items.Count - 1 To 0 Step -1
            If lstAvailable.GetSelected(x) Then
                lstSelected.Items.Add(lstAvailable.Items(x))
                lstAvailable.Items.RemoveAt(x)
            End If
        Next
    End Sub

   'This handles what happens when the Remove button is clicked.
    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        For x = lstSelected.Items.Count - 1 To 0 Step -1
            If lstSelected.GetSelected(x) Then
                lstAvailable.Items.Add(lstSelected.Items(x))
                lstSelected.Items.RemoveAt(x)
            End If
        Next
    End Sub

   'This handles what happens when the RemoveAll button is clicked.
    Private Sub btnRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveAll.Click
        For x = lstSelected.Items.Count - 1 To 0 Step -1
            lstAvailable.Items.Add(lstSelected.Items(x))
            lstSelected.Items.RemoveAt(x)
        Next
    End Sub

   'This handles what happens when the Sort Classes button on the ToolStrip Menu is clicked.
    Private Sub SortClassesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SortClassesToolStripMenuItem.Click
        lstAvailable.Sorted = True
        lstSelected.Sorted = True
    End Sub

   'This handles what happens when the Reset Listboxes button on the ToolStrip Menu is clicked.
    Private Sub ResetListBoxesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetListBoxesToolStripMenuItem.Click
        lstSelected.Items.Clear()
      lstAvailable.Items.Clear()
      lstAvailable.Sorted = False
      For x = 0 To newlst.Items.Count - 1 Step 1
         lstAvailable.Items.Add(newlst.Items(x))
      Next
   End Sub
   'Prevents the user to close the program by presing Alt+F4 or hitting the close button on the current window
    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        UserClosingForm(e)
    End Sub

    Private Sub frmClasses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For x = 0 To lstAvailable.Items.Count - 1 Step 1
            newlst.Items.Add(lstAvailable.Items(x))
        Next
    End Sub

   'This handles what happens when the Next button on the ToolStrip Menu is clicked.
    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
        Form2.BringToFront()
    End Sub

   'This handles what happens when the Exit button on the ToolStrip Menu is clicked.
    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

   'This handles what happens when an item in the lstAvailable listbox is double-clicked.
    Private Sub lstAvailable_DoubleClick(sender As Object, e As System.EventArgs) Handles lstAvailable.DoubleClick
        For index As Integer = lstAvailable.Items.Count - 1 To 0 Step -1
            If lstAvailable.GetSelected(index) Then
                lstSelected.Items.Add(lstAvailable.Items(index))
                lstAvailable.Items.RemoveAt(index)
            End If
        Next
    End Sub

   'This handles what happens when an item in the lstSelected listbox is double-clicked.
   Private Sub lstSelected_DoubleClick(sender As Object, e As System.EventArgs) Handles lstSelected.DoubleClick
      For index As Integer = lstSelected.Items.Count - 1 To 0 Step -1
         If lstSelected.GetSelected(index) Then
            lstAvailable.Items.Add(lstSelected.Items(index))
            lstSelected.Items.RemoveAt(index)
         End If
      Next
   End Sub
   'Resizes the window
   Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
      FormWidth = Me.ClientSize.Width
      FormHeight = Me.ClientSize.Height

      Temp = (FormWidth - lstAvailable.Width - btnSelect.Width - lstSelected.Width) / 3
      Temp2 = Temp / 2

      lstAvailable.Left = Temp
      btnSelect.Left = lstAvailable.Right + Temp2
      lstSelected.Left = btnSelect.Right + Temp2

      btnRemove.Left = btnSelect.Left
      btnRemoveAll.Left = btnSelect.Left

      lblTitle.Left = (FormWidth / 2) - (lblTitle.Width / 2)

      lblAvailable.Left = lstAvailable.Left + (lstAvailable.Width - lblAvailable.Width) / 2
      lblSelected.Left = lstSelected.Left + (lstSelected.Width - lblSelected.Width) / 2

      Temp = (FormHeight - FIXED_SPACE_BETWEEN - lblTitle.Height - lblAvailable.Height - lstAvailable.Height) * (2 / 5)

      lblTitle.Top = Temp

      lblAvailable.Top = lblTitle.Bottom + Temp / 2
      lblSelected.Top = lblTitle.Bottom + Temp / 2

      lstAvailable.Top = lblAvailable.Bottom + FIXED_SPACE_BETWEEN
      lstSelected.Top = lblAvailable.Bottom + FIXED_SPACE_BETWEEN

      btnSelect.Top = lstAvailable.Top

      Temp2 = (lstAvailable.Height - btnRemove.Height - btnRemoveAll.Height - btnSelect.Height) / 2

      btnRemove.Top = btnSelect.Bottom + Temp2
      btnRemoveAll.Top = btnRemove.Bottom + Temp2
   End Sub
End Class
