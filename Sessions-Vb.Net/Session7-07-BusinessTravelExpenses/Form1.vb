'purpose: how to format document and print it
'so we didn't focus on input validation
Public Class frmBusinessTravelExpenses

    Const OneInch As Integer = 75 '75 pixels = 1 inch
    Const LineHeight As Integer = 15 '1/4 of 1 inch (space between columns)
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim g As Graphics = e.Graphics 'gets the graphics used for printing
        Dim str As String 'used to concanate the labels
        Dim x1 As Integer = OneInch ' left margin
        Dim x2 As Integer = 5 * OneInch ' to format the documnet into columns
        Dim y As Integer = 2 * OneInch 'top margin
        Dim font As New Font("Courier New", 10, FontStyle.Bold)

        str = "Business Travel Expenses" 'header
        g.DrawString(str, font, Brushes.Black, x1, y) 'displying the header in the page
        font = New Font("Curier New", 10, FontStyle.Regular) 'resetting the font to regular font after displying the header in bold
        y += 2 * LineHeight 'moving down  2 LineHeight
        str = "Trip to attend meeting of"
        g.DrawString(str, font, Brushes.Black, x1, y) 'display
        y += LineHeight 'move down 1 LinehHight
        g.DrawString(txtOrg.Text, font, Brushes.Black, x1, y) 'display
        y += LineHeight 'move down 1 LineHeight
        str = txtDates.Text + " in " & txtPlace.Text
        g.DrawString(str, font, Brushes.Black, x1, y)
        y += 2 * LineHeight 'moving down 2 LineHeight
        g.DrawString(lblMealsEnt.Text, font, Brushes.Black, x1, y)
        g.DrawString((CDbl(txtMealsEnt.Text)).ToString("C"), font, Brushes.Black, x2, y)
        y += LineHeight
        g.DrawString(lblAirfare.Text, font, Brushes.Black, x1, y)
        g.DrawString((CDbl(txtAirFare.Text)).ToString("C"), font, Brushes.Black, x2, y)
        y += LineHeight
        g.DrawString(lblLodging.Text, font, Brushes.Black, x1, y)
        g.DrawString((CDbl(txtLodging.Text)).ToString("C"), font, Brushes.Black, x2, y)
        y += LineHeight
        g.DrawString(lblTaxi.Text, font, Brushes.Black, x1, y)
        g.DrawString((CDbl(txtTaxi.Text)).ToString("C"), font, Brushes.Black, x2, y)
        y += 2 * LineHeight
        Dim other As Double = CDbl(txtAirFare.Text) + CDbl(txtLodging.Text) + CDbl(txtTaxi.Text)
        str = "Total other than meal and entertainment: " & other.ToString("C")
        g.DrawString(str, font, Brushes.Black, x1, y)
        y += LineHeight
        Dim mealEntertainmentDesuction As Double = 0.5 * CDbl(txtMealsEnt.Text)
        str = "50% of meals and entertainment: " & (CDbl(mealEntertainmentDesuction)).ToString("C")
        g.DrawString(str, font, Brushes.Black, x1, y)
        y += 2 * LineHeight
        str = "TOTAL DEDUCTIBLE EXPENSES: " & (CDbl(other + mealEntertainmentDesuction)).ToString("C")
        g.DrawString(str, font, Brushes.Black, x1, y)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDocument1.Print() 'starts the document printing process
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class
