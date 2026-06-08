Public Class FrmRentalBill
    Private Sub btnDisplayRates_Click(sender As Object, e As EventArgs) Handles btnDisplayRates.Click
        'lstRentalRates.Items.Add("Price of Equipment" & vbTab & vbTab & "Half Day" & vbTab & "Full Day")
        'lstRentalRates.Items.Add("1. Rug Cleaner" & vbTab & vbTab & "$16.00" & vbTab & "$24.00")
        'lstRentalRates.Items.Add("2. Lawn Mover" & vbTab & vbTab & "$12.00" & vbTab & "$18.00")
        'lstRentalRates.Items.Add("3. Paint Sprayer" & vbTab & vbTab & "$20.00" & vbTab & "$30.00")
        DataGridView1.Rows.Add("1. Rug Cleaner", "$16.00", "$24.00")
        DataGridView1.Rows.Add("2. Lawn Mover", "$12.00", "$18.00")
        DataGridView1.Rows.Add("3. Rug Cleaner", "$20.00", "$30.00")

    End Sub

    Private Sub btnDisplayBill_Click(sender As Object, e As EventArgs) Handles btnDisplayBill.Click

        If (txtItem.Text = "1" Or txtItem.Text = "2" Or txtItem.Text = "3") And (txtDuration.Text.ToUpper() = "H" Or txtDuration.Text.ToUpper() = "F") Then
            Const deposit = 30
            Dim item, duration As String
            Dim itemCost As Double

            item = txtItem.Text
            duration = txtDuration.Text.ToUpper()

            Select Case item
                Case "1"
                    item = "Rug Cleaner"
                    itemCost = 16
                Case "2"
                    item = "Lawn Mover"
                    itemCost = 12
                Case "3"
                    item = "Paint Sprayer"
                    itemCost = 20

            End Select

            If duration = "F" Then
                itemCost = itemCost + (itemCost * 0.5)
                duration = "Full Day"
            Else
                duration = "Half Day"
            End If

            'lstBill.Items.Add("Receipt for your Equipment")
            'lstBill.Items.Add("")
            'lstBill.Items.Add(item & ":" & itemCost.ToString("C2") & " " & duration)
            'lstBill.Items.Add("Deposit: " & deposit.ToString("C2"))
            'lstBill.Items.Add("")
            'lstBill.Items.Add("Total: " & (itemCost + deposit).ToString("C2"))
            DataGridView2.Rows.Add(item, duration, itemCost.ToString("C2"), deposit.ToString("C2"), (itemCost + deposit).ToString("C2"))



        Else
            MessageBox.Show("Please correct your input", "Invalid Input", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
