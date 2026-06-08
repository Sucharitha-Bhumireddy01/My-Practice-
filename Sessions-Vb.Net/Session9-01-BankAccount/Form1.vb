Public Class frmBankAccount
    Dim WithEvents checking As New Accounts("Checking")
    Dim WithEvents savings As New Accounts("Savings")
    Dim check As Boolean 'true if transaction was comitted
    Dim committed As Boolean 'true if transaction was committed
    Dim curDate As Date 'current date

    Structure Trans
        Dim dt As Date 'date
        Dim trsType As String 'transaction type (credit or debit)
        Dim newBal As Double 'amount of trnasaction
        Dim amt As Double 'amount of transaction
        Dim cred As Boolean 'credit(or debit)

    End Structure

    Dim trs() As Trans

    Private Sub frmBankAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setup user interface for Checking.
        'Load the transactions from the data files.
        checking.Load()
        savings.Load()
        'Select checking account as account to transfer from
        cmbboxTransfer.SelectedIndex = 0
        'Select checking account as the first account to see
        cmbboxAccount.SelectedIndex = 0
        txtTodayDate.Text = Today.ToString()
        UpdateGrid()
    End Sub

    Private Sub UpdateGrid()
        Dim temp() As String
        If cmbboxAccount.SelectedIndex = 0 Then
            temp = IO.File.ReadAllLines("Checking.txt")
        Else
            temp = IO.File.ReadAllLines("Savings.txt")
        End If

        Dim n = temp.Count() - 1
        Dim line() As String
        ReDim trs(n)

        For i As Integer = 0 To n
            Dim previousBalance As Double = 0
            line = temp(i).Split(","c)
            trs(i).dt = CDate(line(0))
            trs(i).trsType = line(1)
            trs(i).amt = CDbl(line(2))
            If i = 0 Then
                previousBalance = 0
            Else
                previousBalance = trs(i - 1).newBal
            End If
            If CBool(line(3)) Then
                trs(i).newBal = previousBalance + trs(i).amt
            Else
                trs(i).newBal = previousBalance - trs(i).amt
            End If
        Next

        Dim query = From s In trs
                    Let amt = s.amt.ToString("C")
                    Let newBal = s.newBal.ToString("C")
                    Select s.dt, s.trsType, s.amt, s.newBal

        dgvDisplay.DataSource = query.ToList
        dgvDisplay.Columns("dt").HeaderText = "Date"
        dgvDisplay.Columns("trsType").HeaderText = "Type of Transaction"
        dgvDisplay.Columns("amt").HeaderText = "Amount"
        dgvDisplay.Columns("newBal").HeaderText = "New Balance"
    End Sub

    Sub Insufficicient(over As Double) Handles checking.InsufficientFunds, savings.InsufficientFunds
        'if insufficient funds, set the commited flag to false and display message
        committed = False
        MessageBox.Show("Insufficeint Funds: " & over.ToString("C"), "Insufficent Funds")
    End Sub
    Private Sub CommitedTrans() Handles checking.TransactionCommitted, savings.TransactionCommitted
        'If transaction committed, set the committed flag to True
        committed = True
    End Sub

    Private Sub cmbboxAccount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbboxAccount.SelectedIndexChanged
        'Show the check group box if checking is enabled
        check = (cmbboxAccount.SelectedIndex = 0)
        grpCheck.Visible = check
        Display()
        UpdateGrid()
    End Sub

    Private Sub Display()
        'Display the transactions belonging to the account
        If check Then
            'Display the balance in the text box
            txtBalance.Text = checking.Balance.ToString("C")
        Else
            txtBalance.Text = (savings.Balance).ToString("C")
        End If
        UpdateGrid()
    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        'Deposit an amount into an account
        Dim trans As Transaction
        curDate = CDate(txtTodayDate.Text)
        trans = New Transaction(curDate, "Deposit", CDbl(txtDeposit.Text), True)
        'store transaction and update display
        If check Then
            checking.Add(trans)
            Dim sw As IO.StreamWriter = IO.File.AppendText("Checking.txt")
            sw.WriteLine(trans.Format())
            sw.Close()
        Else
            savings.Add(trans)
            Dim sw As IO.StreamWriter = IO.File.AppendText("Savings.txt")
            sw.WriteLine(trans.Format())
            sw.Close()
        End If
        'Display new transaction
        Display()
        txtDeposit.Clear()

    End Sub

    Private Sub btnWithdrawal_Click(sender As Object, e As EventArgs) Handles btnWithdrawal.Click
        'Withdraw an amount into an account
        Dim trans As Transaction
        curDate = CDate(txtTodayDate.Text)
        trans = New Transaction(curDate, "Withdrawal", CDbl(txtWithdrawal.Text), False)
        'store transaction and update display
        If check Then
            checking.Add(trans)
            If committed Then
                Dim sw As IO.StreamWriter = IO.File.AppendText("Checking.txt")
                sw.WriteLine(trans.Format())
                sw.Close()
            End If
        Else
            savings.Add(trans)
            If committed Then
                Dim sw As IO.StreamWriter = IO.File.AppendText("Savings.txt")
                sw.WriteLine(trans.Format())
                sw.Close()
            End If
        End If
        'Display new transaction
        Display()
        txtWithdrawal.Clear()

    End Sub

    Private Sub btnSignCheck_Click(sender As Object, e As EventArgs) Handles btnSignCheck.Click
        'Withdraw an amount into an account
        Dim trans As Transaction
        curDate = CDate(txtTodayDate.Text)
        trans = New Transaction(curDate, "Check cashed By " & txtCheckTo.Text, CDbl(txtCheckPayment.Text), False)
        'store transaction and update display
        checking.Add(trans)
        If committed Then
            Dim sw As IO.StreamWriter = IO.File.AppendText("Checking.txt")
            sw.WriteLine(trans.Format)
            sw.Close()
        End If
        'Display new transaction
        Display()
        txtCheckPayment.Clear()
        txtCheckTo.Clear()
    End Sub

    Private Sub cmbboxTransfer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbboxTransfer.SelectedIndexChanged
        'Display the proper account label caption.
        If cmbboxTransfer.SelectedIndex = 0 Then
            lblTransfer2.Text = "to Savings"
        Else
            lblTransfer2.Text = "to Checkings"
        End If
    End Sub

    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        'Transfer money from one to the other.
        Dim trans As Transaction
        Dim amount As Double = CDbl(txtTransfer.Text)
        curDate = CDate(txtTodayDate.Text)
        If cmbboxTransfer.SelectedIndex = 0 Then
            'store transaction from checking account
            trans = New Transaction(curDate, "Transfer to Savings", amount, False)
            checking.Add(trans)
            If committed Then
                Dim sw As IO.StreamWriter = IO.File.AppendText("Checking.txt")
                sw.WriteLine(trans.Format)
                sw.Close()
            End If
        Else
            'Store transaction from savings accounts
            trans = New Transaction(curDate, "Transfer to Checking", amount, False)
            savings.Add(trans)
            If committed Then
                Dim sw As IO.StreamWriter = IO.File.AppendText("Savings.txt")
                sw.WriteLine(trans.Format)
                sw.Close()
            End If
        End If


        'Deposit to other account only if last transaction was completed
        If committed Then
            If cmbboxTransfer.SelectedIndex = 0 Then
                'store transaction in savings
                trans = New Transaction(curDate, "Transfer from Checking", amount, True)
                savings.Add(trans)
                Dim sw As IO.StreamWriter = IO.File.AppendText("Savings.txt")
                sw.WriteLine(trans.Format)
                sw.Close()
            Else
                'store transaction in checking
                trans = New Transaction(curDate, "Transfer from Savings", amount, True)
                checking.Add(trans)
                Dim sw As IO.StreamWriter = IO.File.AppendText("Checking.txt")
                sw.WriteLine(trans.Format)
                sw.Close()
            End If
        End If
        Display()
        txtTransfer.Clear()
    End Sub

End Class
