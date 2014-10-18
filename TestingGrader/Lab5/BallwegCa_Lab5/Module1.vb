Module Module1

   Friend Const MENU_HEIGHT As Integer = 24
   Friend Const MIN_MARGIN As Integer = 20
   Friend Const SPACE_BETWEEN_LABEL_TEXTBOX As Integer = 20
   Friend Const EXTRA_SPACE_DIVIDE_BY As Integer = 6

   Friend Const DeductionRate As Double = 0.33
   Friend Const regularHours As Double = 40.0
   Friend Const overTimeRate As Double = 1.5

   Friend frmLab5 As Form1
   Friend frmStats As Form2

   Friend count As Integer = 0
   Friend Lowest As Double
   Friend Highest As Double
   Friend Average As Double

   Private Sum As Double = 0

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="rate"></param>
   ''' <param name="hours"></param>
   ''' <param name="gross"></param>
   ''' <param name="deduction"></param>
   ''' <param name="net"></param>
   ''' <remarks></remarks>
    Friend Sub Compute(ByVal rate As Double, ByVal hours As Double, _
                      ByRef gross As Double, ByRef deduction As Double, _
                      ByRef net As Double)

        If hours <= regularHours Then
            gross = hours * rate
        Else
            hours = hours - regularHours
            gross = ((hours * (rate * overTimeRate)) + (regularHours * rate))
        End If
        deduction = gross * DeductionRate
        net = gross - deduction
    End Sub

   ' Updateds the stats: Sum, Count, Highest, Lowest and Average
   ''' <summary>
   ''' This is my update function.
   ''' </summary>
    ''' <param name="NewGross">We cellect stats only for gross pay.</param>
   ''' <remarks>this is my remarks </remarks>
    Friend Sub UpdateStats(ByVal NewGross As Double)

        count = count + 1
        Sum = Sum + NewGross
        Average = Sum / count
        If Lowest <= 0 Then
            Lowest = NewGross
        End If
        If NewGross < Lowest Then
            Lowest = NewGross
        End If
        If NewGross > Highest Then
            Highest = NewGross
        End If

    End Sub

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <remarks></remarks>
   Sub main()
      frmLab5 = New Form1
      frmStats = New Form2

      Application.Run(frmLab5)

   End Sub
End Module