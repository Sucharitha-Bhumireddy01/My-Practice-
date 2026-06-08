Public Class frmWizard1
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If IsNumeric(txtShipSize.Text) Then
            lblMessage.Visible = False
            frmMain.UserSelections.NumOfPassengers = CInt(txtShipSize.Text)
            frmMain.NextStep()
        Else
            lblMessage.Visible = True
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        frmMain.PreviousStep()
    End Sub
End Class