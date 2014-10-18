Module Module1
    Friend Const MENU_HEIGHT As Integer = 24
    Friend Const MIN_MARGIN As Integer = 20
    Friend Const SPACE_BETWEEN_LABEL_TEXTBOX As Integer = 20
    Friend Const EXTRA_SPACE_DIVIDE_BY As Integer = 6

    Friend Const DeductionRate As Double = 0.33
    Friend Const regularHours As Double = 40.0
    Friend Const overTimeRate As Double = 1.5

    Friend frmPayRoll As New form1()
    Friend frmStats As New Form2()

    Friend Count As Integer = 0
    Friend Lowest As Double
    Friend Highest As Double
    Friend Average As Double

    Private Sum As Double = 0


    ' Updateds the stats: Sum, Count, Highest, Lowest and Average
    ''' <summary>
    ''' This is my update function.
    ''' </summary>
    ''' <param name="newGross">We cellect stats only for gross pay.</param>
    ''' <remarks>this is my remarks </remarks>
    Friend Sub UpdateStats(ByVal NewGross As Double)
        '. . .
        Sum += NewGross
        If (Highest < NewGross) Then
            Highest = NewGross
            '   ElseIf (Lowest > NewGross) Then
            '     Lowest = NewGross

        End If





    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub main()
        'frmLab5 = New form1
        'frmStats = New Form2

        Application.Run(frmPayRoll)

    End Sub
End Module
