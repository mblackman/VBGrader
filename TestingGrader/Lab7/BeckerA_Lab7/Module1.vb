Module Module1
    Friend frmGrid As FormClassGrid
    Friend frmIndividual As FormClassIndividual

    Sub Main()
        frmGrid = New FormClassGrid
        frmIndividual = New FormClassIndividual

        Application.Run(frmGrid)
    End Sub
End Module
