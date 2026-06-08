<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIRA
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblAmountDeposited = New System.Windows.Forms.Label()
        Me.lblEarl = New System.Windows.Forms.Label()
        Me.lblLarry = New System.Windows.Forms.Label()
        Me.lblAmountinIRA = New System.Windows.Forms.Label()
        Me.labelEarl = New System.Windows.Forms.Label()
        Me.labelLarry = New System.Windows.Forms.Label()
        Me.txtEarlTotalDeposits = New System.Windows.Forms.TextBox()
        Me.txtLarryTotalDeposits = New System.Windows.Forms.TextBox()
        Me.txtEarlTotalIRA = New System.Windows.Forms.TextBox()
        Me.txtLarryTotalIRA = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(213, 336)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(217, 58)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate Amounts"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblAmountDeposited
        '
        Me.lblAmountDeposited.AutoSize = True
        Me.lblAmountDeposited.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountDeposited.Location = New System.Drawing.Point(234, 33)
        Me.lblAmountDeposited.Name = "lblAmountDeposited"
        Me.lblAmountDeposited.Size = New System.Drawing.Size(223, 29)
        Me.lblAmountDeposited.TabIndex = 1
        Me.lblAmountDeposited.Text = "Amounts Deposited" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblEarl
        '
        Me.lblEarl.AutoSize = True
        Me.lblEarl.Location = New System.Drawing.Point(48, 119)
        Me.lblEarl.Name = "lblEarl"
        Me.lblEarl.Size = New System.Drawing.Size(37, 20)
        Me.lblEarl.TabIndex = 2
        Me.lblEarl.Text = "Earl"
        '
        'lblLarry
        '
        Me.lblLarry.AutoSize = True
        Me.lblLarry.Location = New System.Drawing.Point(376, 119)
        Me.lblLarry.Name = "lblLarry"
        Me.lblLarry.Size = New System.Drawing.Size(44, 20)
        Me.lblLarry.TabIndex = 3
        Me.lblLarry.Text = "Larry"
        '
        'lblAmountinIRA
        '
        Me.lblAmountinIRA.AutoSize = True
        Me.lblAmountinIRA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountinIRA.Location = New System.Drawing.Point(182, 194)
        Me.lblAmountinIRA.Name = "lblAmountinIRA"
        Me.lblAmountinIRA.Size = New System.Drawing.Size(350, 29)
        Me.lblAmountinIRA.TabIndex = 4
        Me.lblAmountinIRA.Text = "Amounts in IRA upon retirement"
        '
        'labelEarl
        '
        Me.labelEarl.AutoSize = True
        Me.labelEarl.Location = New System.Drawing.Point(60, 269)
        Me.labelEarl.Name = "labelEarl"
        Me.labelEarl.Size = New System.Drawing.Size(37, 20)
        Me.labelEarl.TabIndex = 5
        Me.labelEarl.Text = "Earl"
        '
        'labelLarry
        '
        Me.labelLarry.AutoSize = True
        Me.labelLarry.Location = New System.Drawing.Point(376, 263)
        Me.labelLarry.Name = "labelLarry"
        Me.labelLarry.Size = New System.Drawing.Size(44, 20)
        Me.labelLarry.TabIndex = 6
        Me.labelLarry.Text = "Larry"
        '
        'txtEarlTotalDeposits
        '
        Me.txtEarlTotalDeposits.Location = New System.Drawing.Point(148, 119)
        Me.txtEarlTotalDeposits.Name = "txtEarlTotalDeposits"
        Me.txtEarlTotalDeposits.ReadOnly = True
        Me.txtEarlTotalDeposits.Size = New System.Drawing.Size(132, 26)
        Me.txtEarlTotalDeposits.TabIndex = 7
        '
        'txtLarryTotalDeposits
        '
        Me.txtLarryTotalDeposits.Location = New System.Drawing.Point(460, 113)
        Me.txtLarryTotalDeposits.Name = "txtLarryTotalDeposits"
        Me.txtLarryTotalDeposits.ReadOnly = True
        Me.txtLarryTotalDeposits.Size = New System.Drawing.Size(127, 26)
        Me.txtLarryTotalDeposits.TabIndex = 8
        '
        'txtEarlTotalIRA
        '
        Me.txtEarlTotalIRA.Location = New System.Drawing.Point(148, 266)
        Me.txtEarlTotalIRA.Name = "txtEarlTotalIRA"
        Me.txtEarlTotalIRA.ReadOnly = True
        Me.txtEarlTotalIRA.Size = New System.Drawing.Size(132, 26)
        Me.txtEarlTotalIRA.TabIndex = 9
        '
        'txtLarryTotalIRA
        '
        Me.txtLarryTotalIRA.Location = New System.Drawing.Point(460, 263)
        Me.txtLarryTotalIRA.Name = "txtLarryTotalIRA"
        Me.txtLarryTotalIRA.ReadOnly = True
        Me.txtLarryTotalIRA.Size = New System.Drawing.Size(127, 26)
        Me.txtLarryTotalIRA.TabIndex = 10
        '
        'frmIRA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtLarryTotalIRA)
        Me.Controls.Add(Me.txtEarlTotalIRA)
        Me.Controls.Add(Me.txtLarryTotalDeposits)
        Me.Controls.Add(Me.txtEarlTotalDeposits)
        Me.Controls.Add(Me.labelLarry)
        Me.Controls.Add(Me.labelEarl)
        Me.Controls.Add(Me.lblAmountinIRA)
        Me.Controls.Add(Me.lblLarry)
        Me.Controls.Add(Me.lblEarl)
        Me.Controls.Add(Me.lblAmountDeposited)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frmIRA"
        Me.Text = "IRA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblAmountDeposited As Label
    Friend WithEvents lblEarl As Label
    Friend WithEvents lblLarry As Label
    Friend WithEvents lblAmountinIRA As Label
    Friend WithEvents labelEarl As Label
    Friend WithEvents labelLarry As Label
    Friend WithEvents txtEarlTotalDeposits As TextBox
    Friend WithEvents txtLarryTotalDeposits As TextBox
    Friend WithEvents txtEarlTotalIRA As TextBox
    Friend WithEvents txtLarryTotalIRA As TextBox
End Class
