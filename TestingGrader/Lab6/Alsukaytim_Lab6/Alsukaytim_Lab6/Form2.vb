Public Class Form2

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        UserClosingForm(e)
    End Sub
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Hide()
        frmLab6.Show()
        frmLab6.BringToFront()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub RadioMin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioMin.CheckedChanged
        boxPayment.Text = Format(3021, "Currency")
    End Sub

    Private Sub RadioTri_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioTri.CheckedChanged
        boxPayment.Text = Format(4725, "Currency")
    End Sub

    Private Sub RadioNon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioNon.CheckedChanged
        boxPayment.Text = Format(6463, "Currency")
    End Sub

    Private Sub RadioInt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioInt.CheckedChanged
        boxPayment.Text = Format(6463, "Currency")
    End Sub
    Private Sub RadioWI_ClientSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioWI.Click
        RadioYesHalls.Checked = False
        RadioNoHalls.Checked = False
        boxPayment.Text = Format(2725, "Currency")
    End Sub

    Private Sub RadioYesHalls_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioYesHalls.CheckedChanged
        Dim sum As Double
        If RadioWI.Checked Then
            sum = 2725 + 1312
            boxPayment.Text = Format(sum, "Currency")
        ElseIf RadioMin.Checked Then
            sum = 3021 + 1312
            boxPayment.Text = Format(sum, "Currency")
        ElseIf RadioTri.Checked Then
            sum = 4725 + 1312
            boxPayment.Text = Format(sum, "Currency")
        ElseIf RadioNon.Checked Then
            sum = 6463 + 1312
            boxPayment.Text = Format(sum, "Currency")
        ElseIf RadioInt.Checked Then
            sum = 6463 + 1312
            boxPayment.Text = Format(sum, "Currency")
        End If

    End Sub

    Private Sub RadioNoHalls_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioNoHalls.CheckedChanged
        If RadioWI.Checked Then

            boxPayment.Text = Format(2725, "Currency")
        ElseIf RadioMin.Checked Then
            boxPayment.Text = Format(3021, "Currency")
        ElseIf RadioTri.Checked Then
            boxPayment.Text = Format(4725, "Currency")
        ElseIf RadioNon.Checked Then
            boxPayment.Text = Format(6463, "Currency")
        ElseIf RadioInt.Checked Then
            boxPayment.Text = Format(6463, "Currency")
        End If
    End Sub
    Private Sub cboMealPlan_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMealPlan.SelectedIndexChanged
        Dim meals, sum As Integer

        meals = MealsCost(cboMealPlan.SelectedIndex)

        If RadioWI.Checked Then
            If RadioYpark.Checked Then
                If RadioYesHalls.Checked Then
                    sum = meals + 2725 + 1312
                    boxPayment.Text = Format(sum, "Currency")
                ElseIf RadioNoHalls.Checked Then
                    sum = meals + 2725
                    boxPayment.Text = Format(sum, "Currency")
                End If
            End If
        End If

        If RadioMin.Checked Then
            If RadioYesHalls.Checked Then
                sum = meals + 3021 + 1312
                boxPayment.Text = Format(sum, "Currency")
            ElseIf RadioNoHalls.Checked Then
                sum = meals + 3021
                boxPayment.Text = Format(sum, "Currency")
            End If
        End If

        If RadioTri.Checked Then
            If RadioYesHalls.Checked Then
                sum = meals + 4725 + 1312
                boxPayment.Text = Format(sum, "Currency")
            ElseIf RadioNoHalls.Checked Then
                sum = meals + 4725
                boxPayment.Text = Format(sum, "Currency")
            End If
        End If
        If RadioNon.Checked Then
            If RadioYesHalls.Checked Then
                sum = meals + 6463 + 1312
                boxPayment.Text = Format(sum, "Currency")
            ElseIf RadioNoHalls.Checked Then
                sum = meals + 6463
                boxPayment.Text = Format(sum, "Currency")
            End If
        End If
        If RadioInt.Checked Then
            If RadioYesHalls.Checked Then
                sum = meals + 6463 + 1312
                boxPayment.Text = Format(sum, "Currency")
            ElseIf RadioNoHalls.Checked Then
                sum = meals + 6463
                boxPayment.Text = Format(sum, "Currency")
            End If
        End If
    End Sub
End Class