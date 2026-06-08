Public Class frmWizard4
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        frmMain.PreviousStep()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If IsNumeric(txtAverageAge.Text) Then
            lblMessage.Visible = False
            frmMain.UserSelections.AverageAge = CSng(txtAverageAge.Text)
            frmMain.NextStep()
        Else
            lblMessage.Visible = True
        End If
    End Sub
End Class