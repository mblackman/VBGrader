Module Module1
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
    Friend Const Wisconsin As Double = 2725
    Friend Const Minnesota As Double = 3021
    Friend Const Tri_State As Double = 4725
    Friend Const Non_Resident As Double = 6463
    Friend Const International As Double = 6463
    Friend Const Residence_Halls As Double = 1312
   Friend Const Parking As Double = 30
   Friend Const FIXED_SPACE_BETWEEN = 20
    Friend MealsCost() As Double = {0, 1128.0, 1083.0, 1110.0, 771.0, 626.0, 1068.0, 1122.0, 0.0, 0.0, 316.0, 372.0, 528.0}
    Friend frmClasses As Form1
    Friend frmPayments As Form2

    ''' <summary>
    ''' Refuses to close a form when the user tries to close it
    ''' by clicking on the form close button or press Alt+F4.
    ''' </summary>
    ''' <param name="e"> Copied from the FormClosing event procedure of any form. </param>
    Friend Sub UserClosingForm(ByVal e As System.Windows.Forms.FormClosingEventArgs)
        If e.CloseReason = CloseReason.UserClosing Then
            MessageBox.Show("Sorry, the form cannot be closed this way!" + vbCrLf + "Use the form Shortcut menu please.",
                           "AbabioM_Lab6", MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Cancel = True
        End If
    End Sub

    Sub Main()
        frmClasses = New Form1
        frmPayments = New Form2
        Application.Run(frmClasses)
    End Sub

End Module
