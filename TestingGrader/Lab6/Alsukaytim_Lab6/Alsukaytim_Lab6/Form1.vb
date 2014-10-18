Public Class Form1

    Private Sub lstAvailable_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstAvailable.DoubleClick
        For index As Integer = lstAvailable.Items.Count - 1 To 0 Step -1
            If lstAvailable.GetSelected(index) Then
                lstSelected.Items.Add(lstAvailable.Items(index))
                lstAvailable.Items.RemoveAt(index)
            End If
        Next

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        UserClosingForm(e)


    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstAvailable.Items.Add("CS143")
        lstAvailable.Items.Add("CS234")
        lstAvailable.Items.Add("CS334")
        lstAvailable.Items.Add("CS243")
        lstAvailable.Items.Add("CS323")
        lstAvailable.Items.Add("CS363")
        lstAvailable.Items.Add("CS387")
        lstAvailable.Items.Add("MATH264")
        lstAvailable.Items.Add("MATH274")
        lstAvailable.Items.Add("CHEM105")
        lstAvailable.Items.Add("BIO115")

    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim FormWidth As Integer
        Dim FormHeight As Integer
        Dim temp As Integer

        FormWidth = Me.ClientSize.Width
        FormHeight = Me.ClientSize.Height

        temp = (FormWidth - lblSelectClasses.Width) / 2
        lblSelectClasses.Left = temp

        temp = (FormWidth - lblAvailableClasses.Width - lblCelectedClasses.Width) / 3
        lblAvailableClasses.Left = temp
        lblCelectedClasses.Left = temp * 2 + lblAvailableClasses.Width

        temp = (FormWidth - lstAvailable.Width - btnSelect.Width - lstSelected.Width) / 3
        lstAvailable.Left = temp
        btnSelect.Left = temp + lstAvailable.Width + (temp / 2)
        lstSelected.Left = temp + lstAvailable.Width + btnSelect.Width + (temp)
        btnRemove.Left = temp + lstAvailable.Width + temp / 2
        btnRemoveAll.Left = temp + lstAvailable.Width + temp / 2

        'temp = (FormWidth - lblAvailableClasses.Width - lblSelectClasses.Width) / 2
        '' lblAvailableClasses.Left = temp
        ''lblSelectClasses.Left = temp + lblAvailableClasses.Width
        temp = (FormHeight - lstAvailable.Height - lblAvailableClasses.Height - lblSelectClasses.Height) / 3
        lblSelectClasses.Top = temp

        lblAvailableClasses.Top = temp + lblSelectClasses.Height + temp / 2
        lblCelectedClasses.Top = temp + lblSelectClasses.Height + temp / 2

        lstAvailable.Top = temp + lblSelectClasses.Height + 30 + lblAvailableClasses.Height + temp / 2
        lstSelected.Top = temp + lblSelectClasses.Height + 30 + lblAvailableClasses.Height + temp / 2

        btnSelect.Top = temp + lblSelectClasses.Height + 30 + lblAvailableClasses.Height + temp / 2
        btnRemove.Top = temp + lblSelectClasses.Height + 40 + lblAvailableClasses.Height + btnSelect.Height + temp / 2
        btnRemoveAll.Top = temp + btnSelect.Height + lblSelectClasses.Height + 50 + lblAvailableClasses.Height + btnRemove.Height + temp / 2

    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmPayment.Show()
        frmPayment.BringToFront()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        For x = lstAvailable.Items.Count - 1 To 0 Step -1
            If lstAvailable.GetSelected(x) Then
                lstSelected.Items.Add(lstAvailable.Items(x))
                lstAvailable.Items.RemoveAt(x)
            End If
        Next
    End Sub

    Private Sub SortClassesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SortClassesToolStripMenuItem.Click
        lstAvailable.Sorted() = True



    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        For x = lstSelected.Items.Count - 1 To 0 Step -1
            If lstSelected.GetSelected(x) Then
                lstAvailable.Items.Add(lstSelected.Items(x))
                lstSelected.Items.RemoveAt(x)
            End If
        Next

    End Sub

    Private Sub btnRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveAll.Click
        For x = lstSelected.Items.Count - 1 To 0 Step -1
                lstAvailable.Items.Add(lstSelected.Items(x))
                lstSelected.Items.RemoveAt(x)

        Next
    End Sub

    Private Sub RestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestToolStripMenuItem.Click
        For x = lstSelected.Items.Count - 1 To 0 Step -1
            lstAvailable.Items.Add(lstSelected.Items(x))
            lstSelected.Items.RemoveAt(x)

        Next

    End Sub
End Class
