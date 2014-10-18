Module Module1

    Friend frmLab6 As Form1
    Friend frmReg As Form2

    Friend State As Integer
    Friend Residence As Integer
    Friend Parking As Integer
    Friend Meals As Integer

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
   ''' runs the program and starts it with Form1
   ''' </summary>
   ''' <remarks>    </remarks>
   Sub main()
      frmLab6 = New Form1
      frmReg = New Form2

      Application.Run(frmLab6)

   End Sub

   ''' <summary>
   ''' Refuses to close a form when the user tries to close it
   ''' by clicking on the form close button or press Alt+F4.
   ''' </summary>
   ''' <param name="e"> Copied from the FormClosing event procedure of any form. </param>
   ''' <remarks>You add remarks here</remarks>
   Friend Sub UserClosingForm(ByVal e As System.Windows.Forms.FormClosingEventArgs)
      If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
      End If
   End Sub

End Module
