Module Module1
    Friend frmLab6 As Form1
    Friend frmPayment As Form2
    Friend Const SPACE_BETWEEN_BOX As Integer = 30
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

    Friend MealsCost() As Double = {0, 1128.0, 1083.0, 1110.0, 771.0, 626.0, 1068.0, 1122.0, 0.0, 0.0, 316.0, 372.0, 528.0}

    
    ''' <summary>
    ''' Refuses to close a form when the user tries to close it
    ''' by clicking on the form close button or press Alt+F4.
    ''' </summary>
    ''' <param name="e"> Copied from the FormClosing event procedure of any form. </param>
    ''' <remarks>You add remarks here</remarks>
    Friend Sub UserClosingForm(ByVal e As System.Windows.Forms.FormClosingEventArgs)

        If e.CloseReason = CloseReason.UserClosing Then
            MsgBox("Sorry, the form cannot be closed this way!" + vbCrLf + _
                     " Use the form Shortcut menu please.")
            e.Cancel = True

        End If



    End Sub


    Sub main()
        frmLab6 = New Form1
        frmPayment = New Form2

        Application.Run(frmLab6)
        'Application.Run(frmPayment)

    End Sub
End Module
