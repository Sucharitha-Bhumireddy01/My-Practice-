Public Class frmWizard2
    Private Sub frmWizard2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstRegion.DataSource = RegionInfo.Names
        lstRegion.SelectedIndex = -1
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        frmMain.PreviousStep()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If lstRegion.SelectedIndex = -1 Then
            lblMessage.Visible = True
        Else
            lblMessage.Visible = False
            frmMain.UserSelections.Region = lstRegion.SelectedItem.ToString()
            frmMain.NextStep()
        End If
    End Sub
End Class