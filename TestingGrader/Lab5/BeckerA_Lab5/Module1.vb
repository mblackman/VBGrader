Module Module1
    Friend Const MENU_HEIGHT As Integer = 24
    Friend Const MIN_MARGIN As Integer = 20
    Friend Const SPACE_BETWEEN_LABLE_TEXTBOX As Integer = 20
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
        Dim otHours As Double

        If hours <= regularHours Then
            gross = rate * hours
        Else
            otHours = hours - regularHours
            gross = (otHours * overTimeRate * rate) + (rate * regularHours)
        End If
        deduction = gross * DeductionRate
        net = gross - deduction

        UpdateStats(gross)
    End Sub

    ' Updates all stats values: highest, lowest, average, sum, and count.
    Friend Sub UpdateStats(ByVal NewGross As Double)
        If Count = 0 Then
            Lowest = NewGross
            Highest = NewGross
        Else
            If NewGross < Lowest Then
                Lowest = NewGross
            End If

            If NewGross > Highest Then
                Highest = NewGross
            End If
        End If

        Sum += NewGross
        Count += 1
        Average = Sum / Count
    End Sub

    Sub Main()
        Application.Run(frmPayRoll)
    End Sub
End Module
