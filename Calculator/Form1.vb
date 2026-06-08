Public Class FormCalculator
    Dim firstNum, secondNum, result As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btnminus_Click(sender As Object, e As EventArgs) Handles Btnminus.Click
        If TextFirst.Text <> "" And TextSecond.Text <> "" Then
            firstNum = CDbl(TextFirst.Text)
            secondNum = CDbl(TextSecond.Text)

            result = firstNum - secondNum
            TextResult.Text = "The result of " & firstNum & "-" & secondNum & "=" & result
        Else
            MessageBox.Show("Please Enter Both Numbers")
        End If
        Btnminus.BackColor = Color.CornflowerBlue
        Btnmultiply.BackColor = Color.FromArgb(224, 224, 224)
        Btnplus.BackColor = Color.FromArgb(224, 224, 224)
    End Sub

    Private Sub Btnmultiply_Click(sender As Object, e As EventArgs) Handles Btnmultiply.Click
        If TextFirst.Text <> "" And TextSecond.Text <> "" Then
            firstNum = CDbl(TextFirst.Text)
            secondNum = CDbl(TextSecond.Text)

            result = firstNum * secondNum
            TextResult.Text = "The result of " & firstNum & "*" & secondNum & "=" & result
        Else
            MessageBox.Show("Please Enter Both Numbers")
        End If
        Btnminus.BackColor = Color.FromArgb(224, 224, 224)
        Btnmultiply.BackColor = Color.CornflowerBlue
        Btnplus.BackColor = Color.FromArgb(224, 224, 224)
    End Sub

    Private Sub TextFirst_TextChanged(sender As Object, e As EventArgs) Handles TextFirst.TextChanged
        TextResult.Clear()
    End Sub

    Private Sub TextSecond_TextChanged(sender As Object, e As EventArgs) Handles TextSecond.TextChanged
        TextResult.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btnplus_Click(sender As Object, e As EventArgs) Handles Btnplus.Click
        If TextFirst.Text <> "" And TextSecond.Text <> "" Then
            firstNum = CDbl(TextFirst.Text)
            secondNum = CDbl(TextSecond.Text)

            result = firstNum + secondNum
            TextResult.Text = "The result of " & firstNum & "+" & secondNum & "=" & result
        Else
            MessageBox.Show("Please Enter Both Numbers")

        End If
        Btnminus.BackColor = Color.FromArgb(224, 224, 224)
        Btnmultiply.BackColor = Color.FromArgb(224, 224, 224)
        Btnplus.BackColor = Color.CornflowerBlue

    End Sub
End Class
