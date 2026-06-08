Public Class frmSpreadOfEpidemic
    Dim dayNumber As Integer
    Dim people() As Integer = {9700, 200, 100, 0}
    Private Sub btnDay0_Click(sender As Object, e As EventArgs) Handles btnDay0.Click
        DrawGraph()
    End Sub

    Private Sub DrawGraph()
        Dim g As Graphics = picOutput.CreateGraphics
        picOutput.Refresh()
        g.DrawLine(Pens.Black, 45, 100, picOutput.Width, 100) 'draws the x-axis
        g.DrawLine(Pens.Black, 45, 100, 45, 0) 'draws the y-axis
        g.DrawLine(Pens.Black, 45, 0, 50, 0) 'draws tick mark
        g.DrawString("10,000", Me.Font, Brushes.Blue, 0, 0) 'label tick mark
        g.DrawString("Susceptible    Sick 1 Day   Sick 2 Days   Immune", Me.Font, Brushes.Blue, 42, 102)

        For i As Integer = 0 To people.Count() - 1
            g.FillRectangle(Brushes.Blue, 60 + i * 75, CInt(100 - people(i) / 100), 25, CInt(people(i) / 100))
        Next

        g.DrawString("Day " & dayNumber, Me.Font, Brushes.Blue, 125, 0) 'label ticket mark
    End Sub

    Private Sub btnAdvance_Click(sender As Object, e As EventArgs) Handles btnAdvance.Click
        Dim totalSick As Integer
        dayNumber += 1
        totalSick = people(1) + people(2)
        people(3) = people(3) + people(2)
        people(2) = people(1)
        people(1) = CInt(0.0001735 * totalSick * people(0))
        people(0) = 10000 - people(1) - people(2) - people(3)
        DrawGraph()
    End Sub
End Class
