'----------------------------------------------
' Name       : Sammy Alexander
' Course     : CS2340, Section 1, Fall 2012
' Description: Lab 6
'              Form frmClasses
'----------------------------------------------
Public Class Form1

   Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) _
      Handles Me.FormClosing
      UserClosingForm(e)

   End Sub


   Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
      resetList()
   End Sub
   Private Sub resetList()
      lstSelected.Items.Clear()
      lstAvailable.Items.Clear()
      lstAvailable.Items.Add("CS143" & "3".PadLeft(14))
      lstAvailable.Items.Add("CS234" & "3".PadLeft(14))
      lstAvailable.Items.Add("CS334" & "3".PadLeft(14))
      lstAvailable.Items.Add("CS243" & "3".PadLeft(14))
      lstAvailable.Items.Add("CS323" & "3".PadLeft(14))
      lstAvailable.Items.Add("CS363" & "3".PadLeft(14))
      lstAvailable.Items.Add("CS387" & "3".PadLeft(14))
      lstAvailable.Items.Add("MATH264" & "4".PadLeft(12))
      lstAvailable.Items.Add("MATH274" & "4".PadLeft(12))
      lstAvailable.Items.Add("CHEM105" & "5".PadLeft(12))
      lstAvailable.Items.Add("BIO115" & "5".PadLeft(13))
   End Sub

   Private Sub btnSelect_Click(sender As System.Object, e As System.EventArgs) Handles btnSelect.Click
      availableToSelectedLoop()
   End Sub

   Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
      selectedToAvailableLoop()
   End Sub

   Private Sub lstAvailable_DoubleClick(sender As Object, e As System.EventArgs) _
      Handles lstAvailable.DoubleClick
      availableToSelectedLoop()
   End Sub

   Private Sub lstSelected_DoubleClick(sender As Object, e As System.EventArgs) _
      Handles lstSelected.DoubleClick
      selectedToAvailableLoop()
   End Sub

   Private Sub btnRemoveAll_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveAll.Click
      For x = lstSelected.Items.Count - 1 To 0 Step -1
         lstAvailable.Items.Add(lstSelected.Items(x))
         lstSelected.Items.RemoveAt(x)
      Next
   End Sub
   Private Sub availableToSelectedLoop()
      For x = lstAvailable.Items.Count - 1 To 0 Step -1
         If lstAvailable.GetSelected(x) Then
            lstSelected.Items.Add(lstAvailable.Items(x))
            lstAvailable.Items.RemoveAt(x)
         End If
      Next
   End Sub
   Private Sub selectedToAvailableLoop()
      For x = lstSelected.Items.Count - 1 To 0 Step -1
         If lstSelected.GetSelected(x) Then
            lstAvailable.Items.Add(lstAvailable.Items(x))
            lstSelected.Items.RemoveAt(x)
         End If
      Next
   End Sub


   Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) _
      Handles ExitToolStripMenuItem.Click
      Application.Exit()

   End Sub

   Private Sub ResetToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) _
      Handles ResetToolStripMenuItem.Click
      resetList()

   End Sub

   Private Sub btnRemoveAll_Click()
      Throw New NotImplementedException
   End Sub



   Private Sub Form1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
      If e.Button <> Windows.Forms.MouseButtons.Right Then Return
      ContextMenuStrip1.Show(Me, e.Location)

   End Sub

   Private Sub SortClassesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) _
      Handles SortClassesToolStripMenuItem.Click
      lstAvailable.Sorted = True
      lstSelected.Sorted = True
      lstAvailable.Sorted = False
      lstSelected.Sorted = False
   End Sub


   Private Sub NextToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) _
                                          Handles NextToolStripMenuItem.Click
      Me.Hide()
      frmPayment.Show()
      frmPayment.BringToFront()

   End Sub

   Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
      Dim FormWidth As Integer
      Dim FormHeight As Integer
      Dim temp As Integer
      Dim temp2 As Integer
      'resize width 
      FormWidth = Me.ClientSize.Width
      FormHeight = Me.ClientSize.Height
      lblTitle.Left = (FormWidth - lblTitle.Width) / half
      temp = (FormWidth - (half * lstAvailable.Width) - btnRemove.Width) / third
      lstAvailable.Left = temp
      btnRemove.Left = lstAvailable.Right + temp / half
      btnRemoveAll.Left = btnRemove.Left
      btnSelect.Left = btnRemove.Left
      lstSelected.Left = btnRemove.Right + temp / half
      lblAvailable.Left = lstAvailable.Right - lstAvailable.Width / half - lblAvailable.Width / half
      lblSelected.Left = lstSelected.Right - lstSelected.Width / half - lblSelected.Width / half
      'resize height
      temp = (FormHeight - lblTitle.Height - lblAvailable.Height - space - lstAvailable.Height) * _
             (half / fifth)
      lblTitle.Top = temp
      lblAvailable.Top = lblTitle.Bottom + temp / half
      lstAvailable.Top = lblAvailable.Bottom + space
      lblSelected.Top = lblAvailable.Top
      lstSelected.Top = lstAvailable.Top
      btnSelect.Top = lstAvailable.Top
      temp2 = (lstAvailable.Height - third * btnSelect.Height) / half
      btnRemove.Top = btnSelect.Bottom + temp2
      btnRemoveAll.Top = btnRemove.Bottom + temp2

   End Sub

End Class
