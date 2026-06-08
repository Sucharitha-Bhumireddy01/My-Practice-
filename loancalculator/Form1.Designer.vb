<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoanCalculator
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
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.txtMonthlyPayment = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radMonthlyPayment = New System.Windows.Forms.RadioButton()
        Me.radDuration = New System.Windows.Forms.RadioButton()
        Me.radInterestRate = New System.Windows.Forms.RadioButton()
        Me.radAmountOfLoan = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(260, 59)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 26)
        Me.txtAmount.TabIndex = 0
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Location = New System.Drawing.Point(260, 115)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(100, 26)
        Me.txtInterestRate.TabIndex = 1
        '
        'txtDuration
        '
        Me.txtDuration.Location = New System.Drawing.Point(260, 174)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(100, 26)
        Me.txtDuration.TabIndex = 6
        '
        'txtMonthlyPayment
        '
        Me.txtMonthlyPayment.Location = New System.Drawing.Point(260, 230)
        Me.txtMonthlyPayment.Name = "txtMonthlyPayment"
        Me.txtMonthlyPayment.Size = New System.Drawing.Size(100, 26)
        Me.txtMonthlyPayment.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(229, 305)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(173, 50)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate Value"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(229, 389)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(173, 49)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear All Values"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radMonthlyPayment)
        Me.GroupBox1.Controls.Add(Me.radDuration)
        Me.GroupBox1.Controls.Add(Me.radInterestRate)
        Me.GroupBox1.Controls.Add(Me.radAmountOfLoan)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 230)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Check Value To Calculate"
        '
        'radMonthlyPayment
        '
        Me.radMonthlyPayment.AutoSize = True
        Me.radMonthlyPayment.Location = New System.Drawing.Point(6, 194)
        Me.radMonthlyPayment.Name = "radMonthlyPayment"
        Me.radMonthlyPayment.Size = New System.Drawing.Size(155, 24)
        Me.radMonthlyPayment.TabIndex = 3
        Me.radMonthlyPayment.TabStop = True
        Me.radMonthlyPayment.Text = "Monthly Payment"
        Me.radMonthlyPayment.UseVisualStyleBackColor = True
        '
        'radDuration
        '
        Me.radDuration.AutoSize = True
        Me.radDuration.Location = New System.Drawing.Point(6, 138)
        Me.radDuration.Name = "radDuration"
        Me.radDuration.Size = New System.Drawing.Size(156, 24)
        Me.radDuration.TabIndex = 2
        Me.radDuration.TabStop = True
        Me.radDuration.Text = "Duration Of Loan"
        Me.radDuration.UseVisualStyleBackColor = True
        '
        'radInterestRate
        '
        Me.radInterestRate.AutoSize = True
        Me.radInterestRate.Location = New System.Drawing.Point(6, 81)
        Me.radInterestRate.Name = "radInterestRate"
        Me.radInterestRate.Size = New System.Drawing.Size(128, 24)
        Me.radInterestRate.TabIndex = 1
        Me.radInterestRate.TabStop = True
        Me.radInterestRate.Text = "Interest Rate"
        Me.radInterestRate.UseVisualStyleBackColor = True
        '
        'radAmountOfLoan
        '
        Me.radAmountOfLoan.AutoSize = True
        Me.radAmountOfLoan.Location = New System.Drawing.Point(6, 23)
        Me.radAmountOfLoan.Name = "radAmountOfLoan"
        Me.radAmountOfLoan.Size = New System.Drawing.Size(151, 24)
        Me.radAmountOfLoan.TabIndex = 0
        Me.radAmountOfLoan.TabStop = True
        Me.radAmountOfLoan.Text = "Amount Of Loan"
        Me.radAmountOfLoan.UseVisualStyleBackColor = True
        '
        'frmLoanCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtMonthlyPayment)
        Me.Controls.Add(Me.txtDuration)
        Me.Controls.Add(Me.txtInterestRate)
        Me.Controls.Add(Me.txtAmount)
        Me.Name = "frmLoanCalculator"
        Me.Text = "Loan Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtInterestRate As TextBox
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents txtMonthlyPayment As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radMonthlyPayment As RadioButton
    Friend WithEvents radDuration As RadioButton
    Friend WithEvents radInterestRate As RadioButton
    Friend WithEvents radAmountOfLoan As RadioButton
End Class
