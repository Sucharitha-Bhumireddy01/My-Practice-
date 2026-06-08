Public Class frmAlphabeticalOrder
    Private Sub btnDetermine_Click(sender As Object, e As EventArgs) Handles btnDetermine.Click
        Dim word As String = txtWord.Text

        If isTrippleConsecutive(word) Then
            txtOutput.Text = "YES"
        Else
            txtOutput.Text = "NO"
        End If
    End Sub

    Private Function isTrippleConsecutive(word As String) As Boolean
        Dim result As Boolean = False
        Dim L1, l2, l3 As Integer

        For i As Integer = 0 To word.Length - 3
            L1 = Asc(word.ToUpper().Substring(i, 1))
            l2 = Asc(word.ToUpper().Substring(i + 1, 1))
            l3 = Asc(word.ToUpper().Substring(i + 2, 1))

            If L1 + 1 = l2 And l2 + 1 = l3 Then
                result = True
            End If

        Next

        Return result
    End Function
End Class
