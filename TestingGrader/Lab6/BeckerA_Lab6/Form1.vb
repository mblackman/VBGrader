Public Class frmClasses

    ''' <summary>
    ''' Sets up the available listbox when loaded
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmClasses_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Spacing and proper formatting!
        lstAvailable.Items.Add("CS143             3")
        lstAvailable.Items.Add("CS234             3")
        lstAvailable.Items.Add("CS334             3")
        lstAvailable.Items.Add("CS243             3")
        lstAvailable.Items.Add("CS323             3")
        lstAvailable.Items.Add("CS363             3")
        lstAvailable.Items.Add("CS387             3")
        lstAvailable.Items.Add("MATH267           3")
        lstAvailable.Items.Add("MATH274           3")
        lstAvailable.Items.Add("CHEM105           3")
        lstAvailable.Items.Add("BIO115            3")
    End Sub

    ''' <summary>
    ''' Move the selected classes from lstAvailable to lstSelected
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSelect_Click(sender As System.Object, e As System.EventArgs) Handles btnSelect.Click
        For x = lstAvailable.Items.Count - 1 To 0 Step -1
            If lstAvailable.GetSelected(x) Then
                lstSelected.Items.Add(lstAvailable.Items.Item(x))
                lstAvailable.Items.RemoveAt(x)
            End If
        Next
    End Sub

    ''' <summary>
    ''' Moves the selected class to the selected listbox then removes it
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub lstAvailable_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles lstAvailable.MouseDoubleClick
        Dim Index As Integer

        Index = lstAvailable.IndexFromPoint(e.X, e.Y)
        lstSelected.Items.Add(lstAvailable.Items.Item(Index))
        lstAvailable.Items.RemoveAt(Index)
    End Sub

    ''' <summary>
    ''' Moves the selected classes back to the available listbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        For x = lstSelected.Items.Count - 1 To 0 Step -1
            If lstSelected.GetSelected(x) Then
                lstAvailable.Items.Add(lstSelected.Items.Item(x))
                lstSelected.Items.RemoveAt(x)
            End If
        Next
    End Sub

    ''' <summary>
    ''' Removes all the items from the selected class listbox and puts them back
    ''' in the available classes box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRemoveAll_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveAll.Click
        For x = lstSelected.Items.Count - 1 To 0 Step -1
            lstAvailable.Items.Add(lstSelected.Items.Item(x))
            lstSelected.Items.RemoveAt(x)
        Next
    End Sub

    ''' <summary>
    ''' Removes the item double clicked on and puts it back in the available box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub lstSelected_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles lstSelected.MouseDoubleClick
        Dim Index As Integer

        Index = lstSelected.IndexFromPoint(e.X, e.Y)
        lstAvailable.Items.Add(lstSelected.Items.Item(Index))
        lstSelected.Items.RemoveAt(Index)
    End Sub

    ''' <summary>
    ''' Resets the list boxes.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Same functionality as the Remove All button</remarks>
    Private Sub ResetListBoxesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ResetListBoxesToolStripMenuItem.Click
        For x = lstSelected.Items.Count - 1 To 0 Step -1
            lstAvailable.Items.Add(lstSelected.Items.Item(x))
            lstSelected.Items.RemoveAt(x)
        Next
    End Sub

    ''' <summary>
    ''' Dynamically positions the elements of the form as it's resized
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmClasses_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        Dim x As Integer
        Dim FormWidth As Integer = Me.ClientSize.Width
        Dim FormHeight As Integer = Me.ClientSize.Height

        'Left/Right margins for the "Select Classes" label
        x = (FormWidth - lblClasses.Width) / 2
        lblClasses.Left = x

        'List boxes and buttons left/right positioning
        x = (FormWidth - lstAvailable.Width - btnSelect.Width - lstSelected.Width) / 6
        lstAvailable.Left = 2 * x
        btnSelect.Left = lstAvailable.Left + lstAvailable.Width + x
        btnRemove.Left = btnSelect.Left
        btnRemoveAll.Left = btnRemove.Left
        lstSelected.Left = btnSelect.Left + btnSelect.Width + x

        'left/right positioning for the "Avaiable Classes" and "Selected Classes" labels
        x = (lstAvailable.Left + (lstAvailable.Width / 2) - (lblAvailable.Width / 2))
        lblAvailable.Left = x

        x = (lstSelected.Left + (lstSelected.Width / 2) - (lblSelected.Width / 2))
        lblSelected.Left = x

        'Top/Bottom positioning (everything but buttons)
        x = (FormHeight - lblClasses.Height - lblAvailable.Height - 30 - lstAvailable.Height) / 5
        lblClasses.Top = 2 * x
        lblAvailable.Top = lblClasses.Top + lblClasses.Height + x
        lblSelected.Top = lblAvailable.Top
        lstAvailable.Top = lblAvailable.Top + lblAvailable.Height + 30
        lstSelected.Top = lstAvailable.Top

        'Button top/bottom positioning
        x = (lstAvailable.Height - btnSelect.Height - btnRemove.Height - btnRemoveAll.Height) / 2
        btnSelect.Top = lstAvailable.Top
        btnRemove.Top = btnSelect.Top + btnSelect.Height + x
        btnRemoveAll.Top = btnRemove.Top + btnRemove.Height + x
    End Sub

    ''' <summary>
    ''' Switches to the next form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub NextToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        FormPayment.Show()
        FormPayment.BringToFront()
    End Sub

    ''' <summary>
    ''' Exits the program
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    ''' <summary>
    ''' Checks to see if we're exiting properly
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmClasses_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        UserClosingForm(e)
    End Sub
End Class
