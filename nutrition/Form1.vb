Public Class frmNutrition
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Const fatcaloriesperGram = 9
        Dim food As String = txtNameOfFood.Text
        Dim AHAapproved As String
        Dim caloriesPerServing, gramsOfFatPerServing, totalcaloriesFromFat As Integer
        Dim percentCaloriesFromFat As Double

        If food <> "" And Integer.TryParse(txtCaloriesPerServing.Text, caloriesPerServing) And Integer.TryParse(txtGramsOfFat.Text, gramsOfFatPerServing) Then
            totalcaloriesFromFat = gramsOfFatPerServing * fatcaloriesperGram
            percentCaloriesFromFat = totalcaloriesFromFat / caloriesPerServing

            If percentCaloriesFromFat < 0.3 Then
                AHAapproved = "AHA Approved"
            Else
                AHAapproved = "NOT AHA Approved"
            End If
            txtDisplay.Text = food & " contains " & FormatPercent(percentCaloriesFromFat, 2) & " calories from fat. " & vbNewLine &
                "It is " & AHAapproved & "."
        Else
            MessageBox.Show("Please enter valid input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
