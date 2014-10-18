Module Module1
    Friend Const MENU_HEIGHT As Integer = 24
    Friend Const MIN_MARGIN As Integer = 20
    Friend Const SPACE_BETWEEN_LABEL_TEXTBOX As Integer = 20
    Friend Const EXTRA_SPACE_DIVIDE_BY As Integer = 6

    Friend Const DeductionRate As Double = 0.33
    Friend Const regularHours As Double = 40.0
    Friend Const overTimeRate As Double = 1.5

    Friend frmPayroll As New frmPayRoll()
    Friend frmStats As New frmStats()

    Friend Count As Integer = 0
    Friend Lowest As Double
    Friend Highest As Double
    Friend Average As Double

    Private Sum As Double = 0

    ' Computes the gross pay, deduction and net pay based on hours and rate.
    ' Hours over 40 shall be paid 1.5 times the regular rate.
    Friend Sub Compute(ByVal rate As Double, ByVal hours As Double, _
                       ByRef gross As Double, ByRef deduction As Double, _
                       ByRef net As Double)
        If (hours > regularHours) Then
            gross = (hours - regularHours) * (rate + rate / 2) + (regularHours * rate)
        Else
            gross = rate * hours
        End If
        deduction = gross * DeductionRate
        net = gross - deduction
        

    End Sub

    ' Updates all stats values: highest, lowest, average, sum, and count.
    Friend Sub UpdateStats(ByVal NewGross As Double)
        Count = Count + 1
        If Count = 1 Then
            Highest = NewGross
            Lowest = NewGross
            Average = NewGross
            Sum = Sum + NewGross
            Exit Sub
        End If
        If NewGross > Highest Then
            Highest = NewGross
        End If
        If NewGross < Lowest Then
            Lowest = NewGross
        End If
        Sum = Sum + NewGross
        Average = Sum / Count
    End Sub

    Sub main()
        Application.Run(frmPayroll)
    End Sub

End Module
