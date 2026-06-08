Public Class frmQuadraticEquation
    Private Sub btnQuadraticEquation_Click(sender As Object, e As EventArgs) Handles btnQuadraticEquation.Click
        Dim a, b, c As Double

        If Double.TryParse(txtA.Text, a) And Double.TryParse(txtB.Text, b) And Double.TryParse(txtC.Text, c) Then

            If a = 0 Then
                MessageBox.Show("Please enter non-zero value", "Invalide inpiut for 'a'", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtA.Clear()
            Else
                Dim determinant As Double = b ^ 2 - 4 * a * c
                Select Case determinant
                    Case < 0
                        txtSolutions.Text = "There are no solutions"
                    Case = 0
                        txtSolutions.Text = "The Solution is: " & ((-b) / (2 * a)).ToString("N")
                    Case > 0
                        txtSolutions.Text = "Solution 1: " & ((-b + Math.Sqrt(determinant)) / (2 * a)).ToString("N") & " " &
                                            "Solution 2: " & ((-b - Math.Sqrt(determinant)) / (2 * a)).ToString("N")
                End Select
            End If
        Else
            MessageBox.Show("Please correct your input", "Invalide Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
