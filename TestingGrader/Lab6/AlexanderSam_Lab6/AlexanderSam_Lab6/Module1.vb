'----------------------------------------------
' Name       : Sammy Alexander
' Course     : CS2340, Section 1, Fall 2012
' Description: Lab 6
'              Module Module1
'----------------------------------------------
Module Module1
   Friend frmClasses As Form1
   Friend frmPayment As Form2
   Friend space As Integer = 30
   Friend half As Integer = 2
   Friend third As Integer = 3
   Friend fifth As Integer = 5
   'living locations
   Friend Const wisconsin As Double = 2725.0
   Friend Const minnesota As Double = 3021.0
   Friend Const tristate As Double = 4725.0
   Friend Const nonresident As Double = 6463.0
   Friend Const international As Double = 6463.0
   Friend Const reshall As Double = 1312.0
   'meal plan
   Friend Const meal19 As Double = 1128.0
   Friend Const meal15 As Double = 1083.0
   Friend Const meal14 As Double = 1110.0
   Friend Const meal110 As Double = 771.0
   Friend Const meal90 As Double = 626.0
   Friend Const meal150 As Double = 1068.0
   Friend Const meal175 As Double = 1122.0
   Friend Const meal50 As Double = 316.0
   Friend Const meal50points As Double = 372.0
   Friend Const meal75 As Double = 528.0
   Friend Const parking As Double = 30.0

   Friend MealsCost() As Double = {0, 1128.0, 1083.0, 1110.0, 771.0,
                                   626.0, 1068.0, 1122.0, 0.0, 0.0,
                                   316.0, 372.0, 528.0}


   ''' <summary>
   ''' Refuses to close a form when the user tries to close it
   ''' by clicking on the form close button or press Alt+F4.
   ''' </summary>
   ''' <param name="e"> Copied from the FormClosing event procedure of any form. </param>
   ''' <remarks>You add remarks here</remarks>
   Friend Sub UserClosingForm(ByVal e As System.Windows.Forms.FormClosingEventArgs)
      If e.CloseReason = CloseReason.UserClosing Then
         MessageBox.Show("Sorry, the form cannot be closed this way!" + vbNewLine + _
                         "Use the form Shortcut menu please",
                                  "AlexanderSam_Lab6", MessageBoxButtons.OK, MessageBoxIcon.Information
                                  )
         e.Cancel = True
      End If
   End Sub
   Sub main()
      frmClasses = New Form1
      frmPayment = New Form2

      Application.Run(frmClasses)

   End Sub
End Module
