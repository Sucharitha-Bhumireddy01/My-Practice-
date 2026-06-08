<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBankAccount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbboxAccount = New System.Windows.Forms.ComboBox()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.lblTodayDate = New System.Windows.Forms.Label()
        Me.txtTodayDate = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grpDeposit = New System.Windows.Forms.GroupBox()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.lblDeposit = New System.Windows.Forms.Label()
        Me.grpWithdrawal = New System.Windows.Forms.GroupBox()
        Me.btnWithdrawal = New System.Windows.Forms.Button()
        Me.txtWithdrawal = New System.Windows.Forms.TextBox()
        Me.lblWithdrawal = New System.Windows.Forms.Label()
        Me.grpTransfer = New System.Windows.Forms.GroupBox()
        Me.lblTransfer3 = New System.Windows.Forms.Label()
        Me.cmbboxTransfer = New System.Windows.Forms.ComboBox()
        Me.lblTransfer2 = New System.Windows.Forms.Label()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.txtTransfer = New System.Windows.Forms.TextBox()
        Me.lblTransfer1 = New System.Windows.Forms.Label()
        Me.grpCheck = New System.Windows.Forms.GroupBox()
        Me.btnSignCheck = New System.Windows.Forms.Button()
        Me.txtCheckTo = New System.Windows.Forms.TextBox()
        Me.txtCheckPayment = New System.Windows.Forms.TextBox()
        Me.lblCheck3 = New System.Windows.Forms.Label()
        Me.lblCheck2 = New System.Windows.Forms.Label()
        Me.lblCheck1 = New System.Windows.Forms.Label()
        Me.dgvDisplay = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.grpDeposit.SuspendLayout()
        Me.grpWithdrawal.SuspendLayout()
        Me.grpTransfer.SuspendLayout()
        Me.grpCheck.SuspendLayout()
        CType(Me.dgvDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbboxAccount
        '
        Me.cmbboxAccount.FormattingEnabled = True
        Me.cmbboxAccount.Items.AddRange(New Object() {"Checking", "Savings"})
        Me.cmbboxAccount.Location = New System.Drawing.Point(108, 25)
        Me.cmbboxAccount.Name = "cmbboxAccount"
        Me.cmbboxAccount.Size = New System.Drawing.Size(121, 28)
        Me.cmbboxAccount.TabIndex = 0
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.Location = New System.Drawing.Point(15, 28)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(72, 20)
        Me.lblAccount.TabIndex = 1
        Me.lblAccount.Text = "Account:"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Location = New System.Drawing.Point(300, 25)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(71, 20)
        Me.lblBalance.TabIndex = 2
        Me.lblBalance.Text = "Balance:"
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(377, 25)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(131, 26)
        Me.txtBalance.TabIndex = 3
        '
        'lblTodayDate
        '
        Me.lblTodayDate.AutoSize = True
        Me.lblTodayDate.Location = New System.Drawing.Point(573, 22)
        Me.lblTodayDate.Name = "lblTodayDate"
        Me.lblTodayDate.Size = New System.Drawing.Size(106, 20)
        Me.lblTodayDate.TabIndex = 4
        Me.lblTodayDate.Text = "Today's Date:"
        '
        'txtTodayDate
        '
        Me.txtTodayDate.Location = New System.Drawing.Point(685, 19)
        Me.txtTodayDate.Name = "txtTodayDate"
        Me.txtTodayDate.Size = New System.Drawing.Size(97, 26)
        Me.txtTodayDate.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTodayDate)
        Me.GroupBox1.Controls.Add(Me.lblAccount)
        Me.GroupBox1.Controls.Add(Me.lblBalance)
        Me.GroupBox1.Controls.Add(Me.cmbboxAccount)
        Me.GroupBox1.Controls.Add(Me.txtBalance)
        Me.GroupBox1.Controls.Add(Me.lblTodayDate)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(859, 63)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'grpDeposit
        '
        Me.grpDeposit.Controls.Add(Me.btnDeposit)
        Me.grpDeposit.Controls.Add(Me.txtDeposit)
        Me.grpDeposit.Controls.Add(Me.lblDeposit)
        Me.grpDeposit.Location = New System.Drawing.Point(16, 149)
        Me.grpDeposit.Name = "grpDeposit"
        Me.grpDeposit.Size = New System.Drawing.Size(293, 75)
        Me.grpDeposit.TabIndex = 7
        Me.grpDeposit.TabStop = False
        Me.grpDeposit.Text = "Deposit"
        '
        'btnDeposit
        '
        Me.btnDeposit.Location = New System.Drawing.Point(175, 19)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(100, 41)
        Me.btnDeposit.TabIndex = 2
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(43, 26)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(100, 26)
        Me.txtDeposit.TabIndex = 1
        '
        'lblDeposit
        '
        Me.lblDeposit.AutoSize = True
        Me.lblDeposit.Location = New System.Drawing.Point(7, 26)
        Me.lblDeposit.Name = "lblDeposit"
        Me.lblDeposit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDeposit.Size = New System.Drawing.Size(18, 20)
        Me.lblDeposit.TabIndex = 0
        Me.lblDeposit.Text = "₹"
        '
        'grpWithdrawal
        '
        Me.grpWithdrawal.Controls.Add(Me.btnWithdrawal)
        Me.grpWithdrawal.Controls.Add(Me.txtWithdrawal)
        Me.grpWithdrawal.Controls.Add(Me.lblWithdrawal)
        Me.grpWithdrawal.Location = New System.Drawing.Point(16, 239)
        Me.grpWithdrawal.Name = "grpWithdrawal"
        Me.grpWithdrawal.Size = New System.Drawing.Size(293, 75)
        Me.grpWithdrawal.TabIndex = 8
        Me.grpWithdrawal.TabStop = False
        Me.grpWithdrawal.Text = "Withdrawal"
        '
        'btnWithdrawal
        '
        Me.btnWithdrawal.Location = New System.Drawing.Point(175, 22)
        Me.btnWithdrawal.Name = "btnWithdrawal"
        Me.btnWithdrawal.Size = New System.Drawing.Size(100, 42)
        Me.btnWithdrawal.TabIndex = 5
        Me.btnWithdrawal.Text = "Withdrawal"
        Me.btnWithdrawal.UseVisualStyleBackColor = True
        '
        'txtWithdrawal
        '
        Me.txtWithdrawal.Location = New System.Drawing.Point(43, 30)
        Me.txtWithdrawal.Name = "txtWithdrawal"
        Me.txtWithdrawal.Size = New System.Drawing.Size(100, 26)
        Me.txtWithdrawal.TabIndex = 4
        '
        'lblWithdrawal
        '
        Me.lblWithdrawal.AutoSize = True
        Me.lblWithdrawal.Location = New System.Drawing.Point(7, 30)
        Me.lblWithdrawal.Name = "lblWithdrawal"
        Me.lblWithdrawal.Size = New System.Drawing.Size(18, 20)
        Me.lblWithdrawal.TabIndex = 3
        Me.lblWithdrawal.Text = "₹"
        '
        'grpTransfer
        '
        Me.grpTransfer.Controls.Add(Me.lblTransfer3)
        Me.grpTransfer.Controls.Add(Me.cmbboxTransfer)
        Me.grpTransfer.Controls.Add(Me.lblTransfer2)
        Me.grpTransfer.Controls.Add(Me.btnTransfer)
        Me.grpTransfer.Controls.Add(Me.txtTransfer)
        Me.grpTransfer.Controls.Add(Me.lblTransfer1)
        Me.grpTransfer.Location = New System.Drawing.Point(333, 160)
        Me.grpTransfer.Name = "grpTransfer"
        Me.grpTransfer.Size = New System.Drawing.Size(273, 165)
        Me.grpTransfer.TabIndex = 8
        Me.grpTransfer.TabStop = False
        Me.grpTransfer.Text = "Transfer"
        '
        'lblTransfer3
        '
        Me.lblTransfer3.AutoSize = True
        Me.lblTransfer3.Location = New System.Drawing.Point(102, 79)
        Me.lblTransfer3.Name = "lblTransfer3"
        Me.lblTransfer3.Size = New System.Drawing.Size(18, 20)
        Me.lblTransfer3.TabIndex = 8
        Me.lblTransfer3.Text = "₹"
        '
        'cmbboxTransfer
        '
        Me.cmbboxTransfer.FormattingEnabled = True
        Me.cmbboxTransfer.Items.AddRange(New Object() {"Checking", "Savings"})
        Me.cmbboxTransfer.Location = New System.Drawing.Point(126, 25)
        Me.cmbboxTransfer.Name = "cmbboxTransfer"
        Me.cmbboxTransfer.Size = New System.Drawing.Size(121, 28)
        Me.cmbboxTransfer.TabIndex = 7
        '
        'lblTransfer2
        '
        Me.lblTransfer2.AutoSize = True
        Me.lblTransfer2.Location = New System.Drawing.Point(21, 79)
        Me.lblTransfer2.Name = "lblTransfer2"
        Me.lblTransfer2.Size = New System.Drawing.Size(23, 20)
        Me.lblTransfer2.TabIndex = 6
        Me.lblTransfer2.Text = "to"
        '
        'btnTransfer
        '
        Me.btnTransfer.Location = New System.Drawing.Point(126, 120)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(121, 34)
        Me.btnTransfer.TabIndex = 5
        Me.btnTransfer.Text = "Transfer"
        Me.btnTransfer.UseVisualStyleBackColor = True
        '
        'txtTransfer
        '
        Me.txtTransfer.Location = New System.Drawing.Point(126, 79)
        Me.txtTransfer.Name = "txtTransfer"
        Me.txtTransfer.Size = New System.Drawing.Size(121, 26)
        Me.txtTransfer.TabIndex = 4
        '
        'lblTransfer1
        '
        Me.lblTransfer1.AutoSize = True
        Me.lblTransfer1.Location = New System.Drawing.Point(6, 28)
        Me.lblTransfer1.Name = "lblTransfer1"
        Me.lblTransfer1.Size = New System.Drawing.Size(104, 20)
        Me.lblTransfer1.TabIndex = 3
        Me.lblTransfer1.Text = "Transfer from"
        '
        'grpCheck
        '
        Me.grpCheck.Controls.Add(Me.btnSignCheck)
        Me.grpCheck.Controls.Add(Me.txtCheckTo)
        Me.grpCheck.Controls.Add(Me.txtCheckPayment)
        Me.grpCheck.Controls.Add(Me.lblCheck3)
        Me.grpCheck.Controls.Add(Me.lblCheck2)
        Me.grpCheck.Controls.Add(Me.lblCheck1)
        Me.grpCheck.Location = New System.Drawing.Point(632, 160)
        Me.grpCheck.Name = "grpCheck"
        Me.grpCheck.Size = New System.Drawing.Size(275, 165)
        Me.grpCheck.TabIndex = 9
        Me.grpCheck.TabStop = False
        Me.grpCheck.Text = "Check"
        '
        'btnSignCheck
        '
        Me.btnSignCheck.Location = New System.Drawing.Point(148, 120)
        Me.btnSignCheck.Name = "btnSignCheck"
        Me.btnSignCheck.Size = New System.Drawing.Size(121, 34)
        Me.btnSignCheck.TabIndex = 13
        Me.btnSignCheck.Text = "Sign Check"
        Me.btnSignCheck.UseVisualStyleBackColor = True
        '
        'txtCheckTo
        '
        Me.txtCheckTo.Location = New System.Drawing.Point(121, 79)
        Me.txtCheckTo.Name = "txtCheckTo"
        Me.txtCheckTo.Size = New System.Drawing.Size(148, 26)
        Me.txtCheckTo.TabIndex = 12
        '
        'txtCheckPayment
        '
        Me.txtCheckPayment.Location = New System.Drawing.Point(148, 25)
        Me.txtCheckPayment.Name = "txtCheckPayment"
        Me.txtCheckPayment.Size = New System.Drawing.Size(121, 26)
        Me.txtCheckPayment.TabIndex = 11
        '
        'lblCheck3
        '
        Me.lblCheck3.AutoSize = True
        Me.lblCheck3.Location = New System.Drawing.Point(6, 79)
        Me.lblCheck3.Name = "lblCheck3"
        Me.lblCheck3.Size = New System.Drawing.Size(109, 20)
        Me.lblCheck3.TabIndex = 10
        Me.lblCheck3.Text = "to the order of"
        '
        'lblCheck2
        '
        Me.lblCheck2.AutoSize = True
        Me.lblCheck2.Location = New System.Drawing.Point(132, 29)
        Me.lblCheck2.Name = "lblCheck2"
        Me.lblCheck2.Size = New System.Drawing.Size(18, 20)
        Me.lblCheck2.TabIndex = 9
        Me.lblCheck2.Text = "₹"
        '
        'lblCheck1
        '
        Me.lblCheck1.AutoSize = True
        Me.lblCheck1.Location = New System.Drawing.Point(6, 29)
        Me.lblCheck1.Name = "lblCheck1"
        Me.lblCheck1.Size = New System.Drawing.Size(120, 20)
        Me.lblCheck1.TabIndex = 4
        Me.lblCheck1.Text = "Pay the amount"
        '
        'dgvDisplay
        '
        Me.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDisplay.Location = New System.Drawing.Point(27, 357)
        Me.dgvDisplay.Name = "dgvDisplay"
        Me.dgvDisplay.RowHeadersWidth = 62
        Me.dgvDisplay.RowTemplate.Height = 28
        Me.dgvDisplay.Size = New System.Drawing.Size(842, 157)
        Me.dgvDisplay.TabIndex = 10
        '
        'frmBankAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 526)
        Me.Controls.Add(Me.dgvDisplay)
        Me.Controls.Add(Me.grpCheck)
        Me.Controls.Add(Me.grpTransfer)
        Me.Controls.Add(Me.grpWithdrawal)
        Me.Controls.Add(Me.grpDeposit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmBankAccount"
        Me.Text = "Bank Account"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpDeposit.ResumeLayout(False)
        Me.grpDeposit.PerformLayout()
        Me.grpWithdrawal.ResumeLayout(False)
        Me.grpWithdrawal.PerformLayout()
        Me.grpTransfer.ResumeLayout(False)
        Me.grpTransfer.PerformLayout()
        Me.grpCheck.ResumeLayout(False)
        Me.grpCheck.PerformLayout()
        CType(Me.dgvDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbboxAccount As ComboBox
    Friend WithEvents lblAccount As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents lblTodayDate As Label
    Friend WithEvents txtTodayDate As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grpDeposit As GroupBox
    Friend WithEvents btnDeposit As Button
    Friend WithEvents txtDeposit As TextBox
    Friend WithEvents lblDeposit As Label
    Friend WithEvents grpWithdrawal As GroupBox
    Friend WithEvents btnWithdrawal As Button
    Friend WithEvents txtWithdrawal As TextBox
    Friend WithEvents lblWithdrawal As Label
    Friend WithEvents grpTransfer As GroupBox
    Friend WithEvents lblTransfer3 As Label
    Friend WithEvents cmbboxTransfer As ComboBox
    Friend WithEvents lblTransfer2 As Label
    Friend WithEvents btnTransfer As Button
    Friend WithEvents txtTransfer As TextBox
    Friend WithEvents lblTransfer1 As Label
    Friend WithEvents grpCheck As GroupBox
    Friend WithEvents dgvDisplay As DataGridView
    Friend WithEvents btnSignCheck As Button
    Friend WithEvents txtCheckTo As TextBox
    Friend WithEvents txtCheckPayment As TextBox
    Friend WithEvents lblCheck3 As Label
    Friend WithEvents lblCheck2 As Label
    Friend WithEvents lblCheck1 As Label


End Class
