Public Class frmMembershipList

    Dim file() As String = IO.File.ReadAllLines("MembersPhones.txt")

    Private Sub Display()

        lstMembers.Items.Clear()
        For Each n In file
            lstMembers.Items.Add(n.Split(","c)(0))
        Next
        lstMembers.Sorted = True

        txtName.Clear()
        msktxtPhone.Clear()
    End Sub
    Private Sub frmMembershipList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
    End Sub

    Private Sub lstMembers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMembers.SelectedIndexChanged
        Dim query = From n In file
                    Let name As String = n.Split(","c)(0)
                    Let phone As String = n.Split(","c)(1)
                    Where name = lstMembers.SelectedItem.ToString()
                    Select name, phone

        txtName.Text = query.ToList().ElementAt(0).name
        msktxtPhone.Text = query.ToList().ElementAt(0).phone

    End Sub

    Private Sub mnuAdd_Click(sender As Object, e As EventArgs) Handles mnuAdd.Click
        If (txtName.Text <> "") And (msktxtPhone.Text <> "") Then
            ReDim Preserve file(file.Count()) 'add one more index to array, preserve the data
            file(file.Count() - 1) = txtName.Text + "," + msktxtPhone.Text
            Display()
        Else
            MessageBox.Show("Please enter name and phone number to add", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub mnuDelete_Click(sender As Object, e As EventArgs) Handles mnuDelete.Click
        Dim nameTODelete As String = lstMembers.SelectedItem.ToString()

        If nameTODelete <> "" Then
            Dim query = From n In file
                        Let name As String = n.Split(","c)(0)
                        Let phone As String = n.Split(","c)(1)
                        Where name <> nameTODelete
                        Select n

            ReDim file(file.Count() - 1)
            file = query.ToArray()
            Display()
        Else
            MessageBox.Show("Please enter name and phone number to delete", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub mnuModify_Click(sender As Object, e As EventArgs) Handles mnuModify.Click
        If lstMembers.Text <> "" Then
            For i As Integer = 0 To file.Count() - 1
                If file(i).Split(","c)(0) = lstMembers.Text Then
                    file(i) = txtName.Text + "," + msktxtPhone.Text
                End If
            Next

            Display()
        Else
            MessageBox.Show("Please enter name and phone number to modify", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        IO.File.WriteAllLines("MembersPhones.txt", file)
        End
    End Sub
End Class
