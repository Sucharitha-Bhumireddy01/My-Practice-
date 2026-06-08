Public Class frmUnitPrice
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnUnitPrice_Click(sender As Object, e As EventArgs) Handles btnUnitPrice.Click
        Dim price, pricePerOunce As Double
        Dim pounds, ounces As Integer

        price = CDbl(txtPriceOfItem.Text)
        pounds = CInt(txtPounds.Text)
        ounces = CInt(txtOunces.Text)

        Dim totalOunces = ounces + (pounds * 16)

        pricePerOunce = price / totalOunces
        txtPricePerOunce.Text = pricePerOunce.ToString("C2")


    End Sub
End Class
