Public Class RepairBill
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim name As String
        Dim labor, parts, total As Double

        lstDisplay.Items.Clear()
        If IsNumeric(txtParts.Text) And IsNumeric(txtLabor.Text) And txtName.Text <> "" Then
            name = txtName.Text
            labor = CDbl(txtLabor.Text)
            parts = CDbl(txtParts.Text)

            Dim laborCost As Double = labor * 90
            Dim partsCost As Double = parts + (parts * 0.05)
            total = laborCost + partsCost

            lstDisplay.Items.Add("Customer: " & name)
            lstDisplay.Items.Add("Labor Cost: " & FormatCurrency(laborCost))
            lstDisplay.Items.Add("Parts Cost: " & FormatCurrency(partsCost))
            lstDisplay.Items.Add("Total Cost: " & FormatCurrency(total))
        Else
            MessageBox.Show("Please Enter Valid Input")

        End If

    End Sub
End Class
