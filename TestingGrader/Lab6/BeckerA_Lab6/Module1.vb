Module Module1
    'Variables
    Friend FormClasses As New frmClasses()
    Friend FormPayment As New frmPayment()

    Friend Const WisconsinFees = 2725.0
    Friend Const MinnesotaFees = 3021.0
    Friend Const TriStateFees = 4725.0
    Friend Const NonResidentialFees = 6463.0
    Friend Const InternationalFees = 6463.0

    Friend Const ResHallFees = 1312

    Friend Const Meals19 = 1128.0
    Friend Const Meals15 = 1083.0
    Friend Const Meals14 = 110.0
    Friend Const Meals110 = 774.0
    Friend Const Meals90 = 626.0
    Friend Const Meals150 = 1068.0
    Friend Const Meals175 = 1122.0
    Friend Const Meals50 = 316.0
    Friend Const Meals50And70 = 372.0
    Friend Const Meals75 = 528.0

    Friend Const ParkingFees = 30.0

    Friend MealsCost() As Double = {0, 1128.0, 1083.0, 1110.0, 771.0, 626.0, 1068.0, 1122.0, 0.0, 0.0, 316.0, 372.0, 528.0}
    Friend FeesCost() As Double = {WisconsinFees, MinnesotaFees, TriStateFees, NonResidentialFees, InternationalFees}

    ''' <summary>
    ''' Refuses to close a form when the user tries to close it
    ''' by clicking on the form close button or press Alt+F4.
    ''' </summary>
    ''' <param name="e"> Copied from the FormClosing event procedure of any form. </param>
    ''' <remarks>You add remarks here</remarks>
    Friend Sub UserClosingForm(ByVal e As System.Windows.Forms.FormClosingEventArgs)
        If e.CloseReason = CloseReason.ApplicationExitCall Then
            End
        Else
            e.Cancel = True
            MessageBox.Show("Sorry, the form cannot be closed this way!" +
                            vbCrLf + "Use the form Shortcut menu please.",
                            "Lab6_BeckerA", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If
    End Sub

    ''' <summary>
    ''' Runs the program, starting with the FormClasses form
    ''' </summary>
    ''' <remarks></remarks>
    Sub Main()
        Application.Run(FormClasses)
    End Sub
End Module
