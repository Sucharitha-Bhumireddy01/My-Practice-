Public Class frmCarLoan
    Private Sub btnAnalyze_Click(sender As Object, e As EventArgs) Handles btnAnalyze.Click
        Dim loanAmount, months As Integer
        Dim interestRate, monthlyPayments, totalInterestPaid As Double

        If Integer.TryParse(txtAmountOfLoan.Text, loanAmount) And Integer.TryParse(txtDuration.Text, months) And
            Double.TryParse(txtInterestRate.Text, interestRate) Then
            Dim r As Double = (interestRate / 100) / 12

            monthlyPayments = (loanAmount * r) / (1 - Math.Pow(1 + r, months * -1))
            totalInterestPaid = months * monthlyPayments - loanAmount

            txtMonthlyPayment.Text = FormatCurrency(monthlyPayments, 2)
            txtInterestPaid.Text = FormatCurrency(totalInterestPaid, 2)
        Else
            MessageBox.Show("Please Correct Your Input", "Invalide Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
