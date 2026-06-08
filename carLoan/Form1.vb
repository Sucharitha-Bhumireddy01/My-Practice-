Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim monthlyPayment, loanAmount, interestRate As Double
        Dim numOfYears As Integer

        loanAmount = CDbl(txtAmount.Text)
        interestRate = CDbl(txtInterest.Text)
        numOfYears = CInt(txtYears.Text)

        Dim i As Double = interestRate / 1200

        monthlyPayment = (i / (1 - Math.Pow((1 + i), -12 * numOfYears))) * loanAmount
        txtPayment.Text = monthlyPayment.ToString("C2")
    End Sub
End Class
