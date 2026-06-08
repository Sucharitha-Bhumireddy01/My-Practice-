Public Class frmWizard3
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        frmMain.PreviousStep()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        frmMain.UserSelections.Formal = radFormal.Checked
        frmMain.NextStep()
    End Sub
End Class