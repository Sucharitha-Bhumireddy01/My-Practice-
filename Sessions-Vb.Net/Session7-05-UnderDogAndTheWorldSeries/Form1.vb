Public Class frmUnderdogWorldSeries
    'declaring a randomNumber that will beof use while getting the probability of winning rate
    Dim randomNumber As New Random
    Private Sub frmUnderdogWorldSeries_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSimulate_Click(sender As Object, e As EventArgs) Handles btnSimulate.Click

        'two varibles for number of games and winners
        Dim games As Integer
        Dim winner As String
        ResetControls()
        For i As Integer = 1 To 10000 'here 10000 is not game count, it's worldseries count, world series can be upto 4, 5 ,6 or max 7 games.
            PlaySeries(winner, games) 'calling sub to simulate all 10000 world series
            If winner = "Underdog Wins" Then
                hsbUnderdog.Value = hsbUnderdog.Value + 1 'horizantal scroll bar of unserdogs moves by 1
            Else
                hsbFavorite.Value = hsbFavorite.Value + 1 'horizantal scroll bar of favourite moves by 1
            End If

            Select Case games
                Case 4
                    hsbFour.Value += 1
                Case 5
                    hsbFive.Value += 1
                Case 6
                    hsbSix.Value += 1
                Case 7
                    hsbSeven.Value += 1
            End Select
            'refresh text box 
            ' txtUnderdog.Refresh(), it will take lot of computing power, since we have 10000 sereis
            ' so, after every 10th iteration,will refresh teh textboxes
            'refresh is done cause the txtboxes should update values for wvery 10 iterations of world series
            If i Mod 10 = 0 Then
                Updates(i)
                txtUnderdog.Refresh()
                txtFavorite.Refresh()
                txtFour.Refresh()
                txtFive.Refresh()
                txtSix.Refresh()
                txtSeven.Refresh()
                txtUnderdogPercent.Refresh()
                txtFavoritePercent.Refresh()
                txtFourPercent.Refresh()
                txtFivePercent.Refresh()
                txtSixPercent.Refresh()
                txtSevenPercent.Refresh()
            End If
        Next

        'Caculate Average Duaration of World Series
        txtAverageDuration.Text = ((4 * CDbl(hsbFour.Value) +
                                    5 * CDbl(hsbFive.Value) +
                                    6 * CDbl(hsbSix.Value) +
                                    7 * CDbl(hsbSeven.Value)) / 10000).ToString("N") & " games"
    End Sub

    'update sub procedure
    Private Sub Updates(ByRef numGames As Integer)
        txtUnderdog.Text = hsbUnderdog.Value.ToString()
        txtFavorite.Text = hsbFavorite.Value.ToString()
        txtFour.Text = hsbFour.Value.ToString()
        txtFive.Text = hsbFive.Value.ToString()
        txtSix.Text = hsbSix.Value.ToString()
        txtSeven.Text = hsbSeven.Value.ToString()
        txtUnderdogPercent.Text = (hsbUnderdog.Value / numGames).ToString("P")
        txtFavoritePercent.Text = (hsbFavorite.Value / numGames).ToString("P")
        txtFourPercent.Text = (hsbFour.Value / numGames).ToString("P")
        txtFivePercent.Text = (hsbFive.Value / numGames).ToString("P")
        txtSixPercent.Text = (hsbSix.Value / numGames).ToString("P")
        txtSevenPercent.Text = (hsbSeven.Value / numGames).ToString("P")

    End Sub

    'sub procedure that actually simulates single Series
    Private Sub PlaySeries(ByRef winner As String, ByRef games As Integer)
        Dim underdogWins As Integer = 0 'counter for wins of underdogs
        Dim favoriteWins As Integer = 0 'counter for wins of favourite
        Dim numGames As Integer = 0
        Dim probability As Integer = CDbl(txtProb.Text)
        Dim seriesOver As Boolean = False

        Do While seriesOver = False
            If randomNumber.Next(0, 100) < probability Then
                underdogWins += 1
            Else
                favoriteWins += 1
            End If

            If underdogWins = 4 Then
                winner = "Underdog Wins"
                seriesOver = True
            ElseIf favoriteWins = 4 Then
                winner = "Favourite Wins"
                seriesOver = True
            End If
            numGames += 1
        Loop
        games = numGames
    End Sub

    'sub procedure to reset the controlls beofore starting any simulation
    Private Sub ResetControls()
        hsbUnderdog.Value = 0
        hsbFavorite.Value = 0
        hsbFour.Value = 0
        hsbFive.Value = 0
        hsbSix.Value = 0
        hsbSeven.Value = 0
        Updates(1) 'reuse proecdure to set all percentages to zero
        txtAverageDuration.Clear()
    End Sub
End Class
