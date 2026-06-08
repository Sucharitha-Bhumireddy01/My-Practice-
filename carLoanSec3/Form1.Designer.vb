<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarLoan
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
        Me.btnAnalyze = New System.Windows.Forms.Button()
        Me.txtAmountOfLoan = New System.Windows.Forms.TextBox()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.txtMonthlyPayment = New System.Windows.Forms.TextBox()
        Me.txtInterestPaid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAnalyze
        '
        Me.btnAnalyze.Location = New System.Drawing.Point(176, 203)
        Me.btnAnalyze.Name = "btnAnalyze"
        Me.btnAnalyze.Size = New System.Drawing.Size(256, 71)
        Me.btnAnalyze.TabIndex = 0
        Me.btnAnalyze.Text = "Analyze"
        Me.btnAnalyze.UseVisualStyleBackColor = True
        '
        'txtAmountOfLoan
        '
        Me.txtAmountOfLoan.Location = New System.Drawing.Point(216, 37)
        Me.txtAmountOfLoan.Name = "txtAmountOfLoan"
        Me.txtAmountOfLoan.Size = New System.Drawing.Size(142, 26)
        Me.txtAmountOfLoan.TabIndex = 1
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Location = New System.Drawing.Point(216, 87)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(142, 26)
        Me.txtInterestRate.TabIndex = 2
        '
        'txtDuration
        '
        Me.txtDuration.Location = New System.Drawing.Point(216, 152)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(142, 26)
        Me.txtDuration.TabIndex = 3
        '
        'txtMonthlyPayment
        '
        Me.txtMonthlyPayment.Location = New System.Drawing.Point(216, 293)
        Me.txtMonthlyPayment.Name = "txtMonthlyPayment"
        Me.txtMonthlyPayment.ReadOnly = True
        Me.txtMonthlyPayment.Size = New System.Drawing.Size(142, 26)
        Me.txtMonthlyPayment.TabIndex = 4
        '
        'txtInterestPaid
        '
        Me.txtInterestPaid.Location = New System.Drawing.Point(216, 352)
        Me.txtInterestPaid.Name = "txtInterestPaid"
        Me.txtInterestPaid.ReadOnly = True
        Me.txtInterestPaid.Size = New System.Drawing.Size(142, 26)
        Me.txtInterestPaid.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Amount of Loan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Interest Rate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Duration in  months"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 293)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = " Monthly Payments"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 352)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total Interest Paid"
        '
        'frmCarLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInterestPaid)
        Me.Controls.Add(Me.txtMonthlyPayment)
        Me.Controls.Add(Me.txtDuration)
        Me.Controls.Add(Me.txtInterestRate)
        Me.Controls.Add(Me.txtAmountOfLoan)
        Me.Controls.Add(Me.btnAnalyze)
        Me.Name = "frmCarLoan"
        Me.Text = " Car Loan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAnalyze As Button
    Friend WithEvents txtAmountOfLoan As TextBox
    Friend WithEvents txtInterestRate As TextBox
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents txtMonthlyPayment As TextBox
    Friend WithEvents txtInterestPaid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
