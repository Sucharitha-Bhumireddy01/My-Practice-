Public Class frmGradeBook
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GradebookDataSet.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.GradebookDataSet.Students)
        'TODO: This line of code loads data into the 'GradebookDataSet.Grades' table. You can move, or remove it, as needed.
        Me.GradesTableAdapter.Fill(Me.GradebookDataSet.Grades)

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim query = From student1 In GradebookDataSet.Students
                    Join student2 In GradebookDataSet.Grades
                On student1.studentID Equals student2.studentID
                    Let finalGrade = ((student2.firstExam + student2.secondExam + 2 * student2.finalExam) / 4).ToString("N")
                    Let fullName = student1.firstName & " " & student1.lastName
                    Select fullName, finalGrade

        dgvOutput.DataSource = query.ToList
    End Sub

End Class
