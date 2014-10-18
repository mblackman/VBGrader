Module Module1
    Friend frmGrid As FormClassGrid
    Friend frmIndividual As FormClassIndividual

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


    Sub main()
        frmGrid = New FormClassGrid
        frmIndividual = New FormClassIndividual

        Application.Run(frmGrid)
        'Application.Run(frmPayment)

    End Sub

End Module
