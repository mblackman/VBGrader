Module Module1
    Friend Const MENU_HEIGHT As Integer = 24
    Friend Const MIN_MARGIN As Integer = 20
    Friend Const SPACE_BETWEEN_LABEL_TEXTBOX As Integer = 20
    Friend Const EXTRA_SPACE_DIVIDE_BY As Integer = 6

    Friend Const DeductionRate As Double = 0.33
    Friend Const regularHours As Double = 40.0
    Friend Const overTimeRate As Double = 1.5

    Friend frmPayRoll As New Form1()
    Friend frmStats As New Form2()

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

        If hours > regularHours Then
            gross = regularHours * rate + (hours - regularHours) * rate * overTimeRate
        Else
            gross = rate * hours
        End If

        deduction = gross * DeductionRate

        net = gross - deduction

        Count += 1


    End Sub
    ' Updates all stats values: highest, lowest, average, sum, and count.
    Friend Sub UpdateStats(ByVal NewGross As Double)
        If Count = 1 Then
            Lowest = NewGross
            Highest = NewGross
        ElseIf NewGross < Lowest Then
            Lowest = NewGross
        ElseIf NewGross > Highest Then
            Highest = NewGross
        End If
        Sum += NewGross
        Average = Sum / Count
    End Sub
    Sub main()
        frmPayRoll = New Form1
        frmStats = New Form2

        Application.Run(frmPayRoll)

    End Sub
End Module
