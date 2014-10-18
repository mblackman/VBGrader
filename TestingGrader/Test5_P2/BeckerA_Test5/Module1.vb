Module Module1
    Friend frmAll As FormClassAll
    Friend frmList As FormClassList

    Sub main()
        frmAll = New FormClassAll
        frmList = New FormClassList

        Application.Run(frmAll)
    End Sub
End Module
