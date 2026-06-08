Public Class frmCollegeAdmissions
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim gpa, sum1, sum2 As Double

        If Double.TryParse(txtGPAScore.Text, gpa) Then
            If gpa >= 2 And gpa <= 4 Then
                For Each rad In grpSAT.Controls.OfType(Of RadioButton)
                    If rad.Checked Then
                        sum1 += rad.Tag
                    End If
                Next
                For Each rad In grpHighSchoolQuality.Controls.OfType(Of RadioButton)
                    If rad.Checked Then
                        sum1 += rad.Tag
                    End If
                Next
                For Each rad In grpDifficultyofCurriculum.Controls.OfType(Of RadioButton)
                    If rad.Checked Then
                        sum1 += rad.Tag
                    End If
                Next
                For Each chk In grpGeography.Controls.OfType(Of CheckBox)
                    If chk.Checked Then
                        sum2 += chk.Tag
                    End If
                Next
                For Each rad In grpEssay.Controls.OfType(Of RadioButton)
                    If rad.Checked Then
                        sum2 += rad.Tag
                    End If
                Next
                For Each rad In grpSAT.Controls.OfType(Of RadioButton)
                    If rad.Checked Then
                        sum1 += rad.Tag
                    End If
                Next
                For Each rad In grpMiscellaneous.Controls.OfType(Of RadioButton)
                    If rad.Checked Then
                        sum2 += rad.Tag
                    End If
                Next
                For Each chk In grpLeardershipandService.Controls.OfType(Of CheckBox)
                    If chk.Checked Then
                        sum2 += chk.Tag
                    End If
                Next
                For Each chk In grpAlumini.Controls.OfType(Of CheckBox)
                    If chk.Checked Then
                        sum2 += chk.Tag

                    End If
                Next
                If sum2 > 40 Then
                    sum2 = 40
                End If
                Dim totalscore = sum1 + sum2 + (gpa * 20)
                Dim admitted As String
                If totalscore >= 100 Then
                    admitted = "Admitted"
                Else
                    admitted = "not Admitted"
                End If
                txtOutput.Text = "Total Score: " & totalscore & vbNewLine & "Student is " & admitted

            Else
                    MessageBox.Show("Invalid GPA", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("GPA must be in numeric format", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
