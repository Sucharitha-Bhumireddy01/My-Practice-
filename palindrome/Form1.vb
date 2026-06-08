Public Class frmPalindrome
    Private Sub btnDetermine_Click(sender As Object, e As EventArgs) Handles btnDetermine.Click
        Dim word As String = txtWord.Text
        Dim wordNoPunctuation As String

        For i As Integer = 0 To word.Length - 1
            Dim character As Char = CChar(word.Substring(i, 1).ToUpper())
            If Asc(character) >= 65 And Asc(character) <= 90 Then
                wordNoPunctuation += character
            End If
        Next

        If IsPalindrome(wordNoPunctuation) Then
            txtOutput.Text = "YES"
        Else
            txtOutput.Text = "NO"
        End If
    End Sub

    Private Function IsPalindrome(word As String) As Boolean
        Dim reversedWord As String = ""

        For i As Integer = word.Length To 1 Step -1
            reversedWord += word.Substring(i - 1, 1)
        Next

        If reversedWord = word Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
