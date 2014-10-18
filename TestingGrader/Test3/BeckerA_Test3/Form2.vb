Public Class frmBack


    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Me.Hide()
        SquareRootForm.Show()
        SquareRootForm.BringToFront()
    End Sub
End Class