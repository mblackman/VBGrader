Public Class frmPayment
    Dim meals As Double = 0
    Dim fees As Double = 0

    ''' <summary>
    ''' Updates the cost
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdateCost()
        Dim total As Double

        total = fees
        total += meals
        If (rbResYes.Checked) Then
            total += ResHallFees
        End If

        If rbParkingYes.Checked Then
            total += ParkingFees
        End If
        txtTotal.Text = Format(total, "c")
    End Sub

    ''' <summary>
    ''' Switches back to the first form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BackToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Hide()
        FormClasses.Show()
        FormClasses.BringToFront()
    End Sub

    ''' <summary>
    ''' Updates the total witht he new meal plan
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cbMealPlan_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbMealPlan.SelectedIndexChanged
        If cbMealPlan.SelectedIndex = cbMealPlan.Items.IndexOf("     No meal plan") Then
            Exit Sub
        End If

        meals = MealsCost(cbMealPlan.SelectedIndex)
        If meals = 0 Then
            cbMealPlan.SelectedIndex = cbMealPlan.Items.IndexOf("     No meal plan")
        End If
        UpdateCost()
    End Sub

    ''' <summary>
    ''' Checks to see if the button is selected, then updates the cost if it is
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rbWisconsin_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbWisconsin.CheckedChanged
        If rbWisconsin.Checked Then
            fees = WisconsinFees
            UpdateCost()
        End If
    End Sub

    ''' <summary>
    ''' Checks to see if the button is selected, then updates the cost if it is
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rbResYes_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbResYes.CheckedChanged
        If rbResYes.Checked Then
            UpdateCost()
        End If
    End Sub

    ''' <summary>
    ''' Checks to see if the button is selected, then updates the cost if it is
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rbResNo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbResNo.CheckedChanged
        If rbResNo.Checked Then
            UpdateCost()
        End If
    End Sub

    ''' <summary>
    ''' Checks to see if the button is selected, then updates the cost if it is
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rbParkingYes_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbParkingYes.CheckedChanged
        If rbParkingYes.Checked Then
            UpdateCost()
        End If
    End Sub

    ''' <summary>
    ''' Checks to see if the button is selected, then updates the cost if it is
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rbParkingNo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbParkingNo.CheckedChanged
        If rbParkingNo.Checked Then
            UpdateCost()
        End If
    End Sub

    ''' <summary>
    ''' Checks to see if the button is selected, then updates the cost if it is
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rbMinnesota_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbMinnesota.CheckedChanged
        If rbMinnesota.Checked Then
            fees = MinnesotaFees
            UpdateCost()
        End If

    End Sub

    ''' <summary>
    ''' Checks to see if the button is selected, then updates the cost if it is
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rbTriState_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbTriState.CheckedChanged
        If rbTriState.Checked Then
            fees = TriStateFees
            UpdateCost()
        End If
    End Sub

    ''' <summary>
    ''' Checks to see if the button is selected, then updates the cost if it is
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rbNonResident_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbNonResident.CheckedChanged
        If rbNonResident.Checked Then
            fees = NonResidentialFees
            UpdateCost()
        End If
    End Sub

    ''' <summary>
    ''' Checks to see if the button is selected, then updates the cost if it is
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rbInternational_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbInternational.CheckedChanged
        If rbInternational.Checked Then
            fees = InternationalFees
            UpdateCost()
        End if
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
    ''' Checks to see if we're properly closing
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmPayment_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        UserClosingForm(e)
    End Sub

    ''' <summary>
    ''' Set up the combo box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmPayment_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cbMealPlan.Items.Add("Regular")
        cbMealPlan.Items.Add("     19 meals per week")
        cbMealPlan.Items.Add("     15 meals per week")
        cbMealPlan.Items.Add("     14 meals per week and $50 per semester")
        cbMealPlan.Items.Add("     110 meals and $125 per semester")
        cbMealPlan.Items.Add("     90 Meals and $100 per semester")
        cbMealPlan.Items.Add("     150 Meals and $100 per semester")
        cbMealPlan.Items.Add("     175 Meals and $100 per semester")
        cbMealPlan.Items.Add("Commute and off-campus only meal plan")
        cbMealPlan.Items.Add("     No meal plan")
        cbMealPlan.Items.Add("     50 meals per semester")
        cbMealPlan.Items.Add("     50 meals and $75 per semester")
        cbMealPlan.Items.Add("     75 meals and $100 per semester")
    End Sub
End Class