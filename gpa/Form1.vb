Public Class Form1
    Dim floatingSum As Double
    Dim numberOfCourses As Integer

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        Dim grades As String
        Dim gradeValue, hours As Integer
        Dim courseGrade As Double

        If (cmbGrades.SelectedIndex > -1) And (txtCreditHour.Text = "1" Or txtCreditHour.Text = "2" Or txtCreditHour.Text = "3" Or txtCreditHour.Text = "4") Then
            grades = cmbGrades.Text
            gradeValue = CalculateGrade(grades)

            hours = CInt(txtCreditHour.Text)
            courseGrade = CalculateCourseGrade(gradeValue, hours)
            numberOfCourses += 1
            floatingSum += courseGrade

            ResetForm()

        Else
            MessageBox.Show("Please correct your inout", "Invalid Inout", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ResetForm()
        cmbGrades.SelectedIndex = -1
        cmbGrades.Text = "Select Grade"
        txtCreditHour.Clear()
    End Sub

    Function CalculateCourseGrade(gradeValue As Integer, hours As Integer) As Double
        Dim courseGrade, finalGrade As Double
        Dim maxPossibleGrade As Integer

        maxPossibleGrade = 4 * hours '4 represents A
        courseGrade = gradeValue * hours
        finalGrade = (courseGrade / maxPossibleGrade) * 4
        Return finalGrade
    End Function
    Function CalculateGrade(grades As String)
        Dim gradeValue As Integer

        Select Case (grades)
            Case "A"
                gradeValue = 4
            Case "B"
                gradeValue = 3
            Case "C"
                gradeValue = 2
            Case "D"
                gradeValue = 1
            Case Else
                gradeValue = 0
        End Select

        Return gradeValue
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim gpa As Double

        If numberOfCourses > 0 Then
            gpa = floatingSum / numberOfCourses
            txtGPA.Text = gpa.ToString("N2")
            ResetForm()
        Else
            MessageBox.Show("Please enter some grades first ", "Nothing to calculate", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
