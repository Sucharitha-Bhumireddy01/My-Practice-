Public Class frmRestaurantMenu
    Private Sub chkBurgers_CheckedChanged(sender As Object, e As EventArgs) Handles chkBurgers.CheckedChanged
        If chkBurgers.Checked Then
            grpBurgers.Visible = True
            radRegular.Checked = True
        Else
            grpBurgers.Visible = False

        End If
    End Sub

    Private Sub chkFries_CheckedChanged(sender As Object, e As EventArgs) Handles chkFries.CheckedChanged
        If chkFries.Checked Then
            grpFries.Visible = True
            radSmall.Checked = True
        Else
            grpFries.Visible = False

        End If
    End Sub

    Private Sub chkDrinks_CheckedChanged(sender As Object, e As EventArgs) Handles chkDrinks.CheckedChanged
        If chkDrinks.Checked Then
            grpDrinks.Visible = True
            radSoda.Checked = True
        Else
            grpDrinks.Visible = False

        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim sum As Double = 0

        If chkBurgers.Checked Then
            If radRegular.Checked Then
                sum += 200
            ElseIf radCheese.Checked Or radBacon.Checked Then
                sum += 250
            ElseIf radBaconCheese.Checked Then
                sum += 400

            End If
        End If
        If chkFries.Checked Then
            If radSmall.Checked Then
                sum += 100
            ElseIf radMedium.Checked Then
                sum += 160
            ElseIf radLarge.Checked Then
                sum += 200

            End If
        End If
        If chkDrinks.Checked Then
            If radSoda.Checked Then
                sum += 70
            ElseIf radBottledWater.Checked Then
                sum += 50
            End If
        End If
        txtCost.Text = sum.ToString("C2")
    End Sub
End Class
