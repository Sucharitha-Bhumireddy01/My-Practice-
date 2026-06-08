Public Class frmRestaurantBillSec4
    Const pizzaPrice As Double = 100
    Const friesPrice As Double = 120
    Const drinkPrice As Double = 80

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim pizza, fries, drinks As Integer
        Dim total As Double

        If Integer.TryParse(txtNumOfPizza.Text, pizza) And Integer.TryParse(txtNumOfFries.Text, fries) And Integer.TryParse(txtNumOfDrinks.Text, drinks) Then
            total = Calculate(pizza, fries, drinks)
            displayBill(pizza, fries, drinks, total)

        Else
            MessageBox.Show("Please correct your input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Function Calculate(pizza As Integer, fries As Integer, drinks As Integer) As Double
        Dim total As Double

        total = (pizza * pizzaPrice) + (fries * friesPrice) + (drinks + drinkPrice)

        Return total
    End Function

    Private Sub displayBill(pizza As Integer, fries As Integer, drinks As Integer, total As Double)
        If pizza > 0 Then
            gridDisplayBill.Rows.Add("Pizza", pizza.ToString(), FormatCurrency(pizza * pizzaPrice))
        End If
        If fries > 0 Then
            gridDisplayBill.Rows.Add("Fries", fries.ToString(), FormatCurrency(fries * friesPrice))
        End If
        If drinks > 0 Then
            gridDisplayBill.Rows.Add("Drinks", drinks.ToString(), FormatCurrency(drinks * drinkPrice))
        End If
        gridDisplayBill.Rows.Add("Total Price", "-", FormatCurrency(total))
    End Sub

End Class
