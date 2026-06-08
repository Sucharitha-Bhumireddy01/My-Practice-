<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPoker
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
        Me.mtbSuit5 = New System.Windows.Forms.MaskedTextBox()
        Me.mtbSuit4 = New System.Windows.Forms.MaskedTextBox()
        Me.mtbSuit3 = New System.Windows.Forms.MaskedTextBox()
        Me.mtbSuit2 = New System.Windows.Forms.MaskedTextBox()
        Me.mtbSuit1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.lblSuit = New System.Windows.Forms.Label()
        Me.txtDenomination5 = New System.Windows.Forms.TextBox()
        Me.lblDenomination5 = New System.Windows.Forms.Label()
        Me.txtDenomination4 = New System.Windows.Forms.TextBox()
        Me.lblDenomination4 = New System.Windows.Forms.Label()
        Me.txtDenomination3 = New System.Windows.Forms.TextBox()
        Me.lblDenomination3 = New System.Windows.Forms.Label()
        Me.txtDenomination2 = New System.Windows.Forms.TextBox()
        Me.lblDenomination2 = New System.Windows.Forms.Label()
        Me.lblDenomination = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.txtDenomination1 = New System.Windows.Forms.TextBox()
        Me.lblDenomination1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'mtbSuit5
        '
        Me.mtbSuit5.Location = New System.Drawing.Point(252, 273)
        Me.mtbSuit5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtbSuit5.Mask = "L"
        Me.mtbSuit5.Name = "mtbSuit5"
        Me.mtbSuit5.Size = New System.Drawing.Size(19, 26)
        Me.mtbSuit5.TabIndex = 54
        '
        'mtbSuit4
        '
        Me.mtbSuit4.Location = New System.Drawing.Point(252, 231)
        Me.mtbSuit4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtbSuit4.Mask = "L"
        Me.mtbSuit4.Name = "mtbSuit4"
        Me.mtbSuit4.Size = New System.Drawing.Size(19, 26)
        Me.mtbSuit4.TabIndex = 51
        '
        'mtbSuit3
        '
        Me.mtbSuit3.Location = New System.Drawing.Point(252, 194)
        Me.mtbSuit3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtbSuit3.Mask = "L"
        Me.mtbSuit3.Name = "mtbSuit3"
        Me.mtbSuit3.Size = New System.Drawing.Size(19, 26)
        Me.mtbSuit3.TabIndex = 48
        '
        'mtbSuit2
        '
        Me.mtbSuit2.Location = New System.Drawing.Point(252, 157)
        Me.mtbSuit2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtbSuit2.Mask = "L"
        Me.mtbSuit2.Name = "mtbSuit2"
        Me.mtbSuit2.Size = New System.Drawing.Size(19, 26)
        Me.mtbSuit2.TabIndex = 45
        '
        'mtbSuit1
        '
        Me.mtbSuit1.Location = New System.Drawing.Point(252, 122)
        Me.mtbSuit1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtbSuit1.Mask = "L"
        Me.mtbSuit1.Name = "mtbSuit1"
        Me.mtbSuit1.Size = New System.Drawing.Size(19, 26)
        Me.mtbSuit1.TabIndex = 42
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(56, 373)
        Me.txtOutput.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtOutput.MaxLength = 1
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(241, 26)
        Me.txtOutput.TabIndex = 56
        Me.txtOutput.TabStop = False
        '
        'lblSuit
        '
        Me.lblSuit.Location = New System.Drawing.Point(181, 51)
        Me.lblSuit.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSuit.Name = "lblSuit"
        Me.lblSuit.Size = New System.Drawing.Size(174, 63)
        Me.lblSuit.TabIndex = 39
        Me.lblSuit.Text = "Suit:  Diamonds=D, Hearts=H, Clubs=C, Spades=S"
        '
        'txtDenomination5
        '
        Me.txtDenomination5.Location = New System.Drawing.Point(115, 274)
        Me.txtDenomination5.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtDenomination5.MaxLength = 2
        Me.txtDenomination5.Name = "txtDenomination5"
        Me.txtDenomination5.Size = New System.Drawing.Size(55, 26)
        Me.txtDenomination5.TabIndex = 53
        '
        'lblDenomination5
        '
        Me.lblDenomination5.AutoSize = True
        Me.lblDenomination5.Location = New System.Drawing.Point(38, 274)
        Me.lblDenomination5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblDenomination5.Name = "lblDenomination5"
        Me.lblDenomination5.Size = New System.Drawing.Size(69, 20)
        Me.lblDenomination5.TabIndex = 52
        Me.lblDenomination5.Text = "Card #5:"
        Me.lblDenomination5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDenomination4
        '
        Me.txtDenomination4.Location = New System.Drawing.Point(115, 233)
        Me.txtDenomination4.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtDenomination4.MaxLength = 2
        Me.txtDenomination4.Name = "txtDenomination4"
        Me.txtDenomination4.Size = New System.Drawing.Size(55, 26)
        Me.txtDenomination4.TabIndex = 50
        '
        'lblDenomination4
        '
        Me.lblDenomination4.AutoSize = True
        Me.lblDenomination4.Location = New System.Drawing.Point(38, 237)
        Me.lblDenomination4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblDenomination4.Name = "lblDenomination4"
        Me.lblDenomination4.Size = New System.Drawing.Size(69, 20)
        Me.lblDenomination4.TabIndex = 49
        Me.lblDenomination4.Text = "Card #4:"
        Me.lblDenomination4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDenomination3
        '
        Me.txtDenomination3.Location = New System.Drawing.Point(115, 197)
        Me.txtDenomination3.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtDenomination3.MaxLength = 2
        Me.txtDenomination3.Name = "txtDenomination3"
        Me.txtDenomination3.Size = New System.Drawing.Size(55, 26)
        Me.txtDenomination3.TabIndex = 47
        '
        'lblDenomination3
        '
        Me.lblDenomination3.AutoSize = True
        Me.lblDenomination3.Location = New System.Drawing.Point(38, 201)
        Me.lblDenomination3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblDenomination3.Name = "lblDenomination3"
        Me.lblDenomination3.Size = New System.Drawing.Size(69, 20)
        Me.lblDenomination3.TabIndex = 46
        Me.lblDenomination3.Text = "Card #3:"
        Me.lblDenomination3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDenomination2
        '
        Me.txtDenomination2.Location = New System.Drawing.Point(115, 159)
        Me.txtDenomination2.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtDenomination2.MaxLength = 2
        Me.txtDenomination2.Name = "txtDenomination2"
        Me.txtDenomination2.Size = New System.Drawing.Size(55, 26)
        Me.txtDenomination2.TabIndex = 44
        '
        'lblDenomination2
        '
        Me.lblDenomination2.AutoSize = True
        Me.lblDenomination2.Location = New System.Drawing.Point(38, 164)
        Me.lblDenomination2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblDenomination2.Name = "lblDenomination2"
        Me.lblDenomination2.Size = New System.Drawing.Size(69, 20)
        Me.lblDenomination2.TabIndex = 43
        Me.lblDenomination2.Text = "Card #2:"
        Me.lblDenomination2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDenomination
        '
        Me.lblDenomination.Location = New System.Drawing.Point(18, 51)
        Me.lblDenomination.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblDenomination.Name = "lblDenomination"
        Me.lblDenomination.Size = New System.Drawing.Size(159, 63)
        Me.lblDenomination.TabIndex = 38
        Me.lblDenomination.Text = "Denomination: Ace=1, Jack=11, Queen=12, King=13"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(56, 319)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(240, 45)
        Me.btnDisplay.TabIndex = 55
        Me.btnDisplay.Text = "Display Type of Hand"
        '
        'txtDenomination1
        '
        Me.txtDenomination1.Location = New System.Drawing.Point(115, 122)
        Me.txtDenomination1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtDenomination1.MaxLength = 2
        Me.txtDenomination1.Name = "txtDenomination1"
        Me.txtDenomination1.Size = New System.Drawing.Size(55, 26)
        Me.txtDenomination1.TabIndex = 41
        '
        'lblDenomination1
        '
        Me.lblDenomination1.AutoSize = True
        Me.lblDenomination1.Location = New System.Drawing.Point(38, 127)
        Me.lblDenomination1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblDenomination1.Name = "lblDenomination1"
        Me.lblDenomination1.Size = New System.Drawing.Size(69, 20)
        Me.lblDenomination1.TabIndex = 40
        Me.lblDenomination1.Text = "Card #1:"
        Me.lblDenomination1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmPoker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 450)
        Me.Controls.Add(Me.mtbSuit5)
        Me.Controls.Add(Me.mtbSuit4)
        Me.Controls.Add(Me.mtbSuit3)
        Me.Controls.Add(Me.mtbSuit2)
        Me.Controls.Add(Me.mtbSuit1)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.lblSuit)
        Me.Controls.Add(Me.txtDenomination5)
        Me.Controls.Add(Me.lblDenomination5)
        Me.Controls.Add(Me.txtDenomination4)
        Me.Controls.Add(Me.lblDenomination4)
        Me.Controls.Add(Me.txtDenomination3)
        Me.Controls.Add(Me.lblDenomination3)
        Me.Controls.Add(Me.txtDenomination2)
        Me.Controls.Add(Me.lblDenomination2)
        Me.Controls.Add(Me.lblDenomination)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtDenomination1)
        Me.Controls.Add(Me.lblDenomination1)
        Me.Name = "frmPoker"
        Me.Text = "Poker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mtbSuit5 As MaskedTextBox
    Friend WithEvents mtbSuit4 As MaskedTextBox
    Friend WithEvents mtbSuit3 As MaskedTextBox
    Friend WithEvents mtbSuit2 As MaskedTextBox
    Friend WithEvents mtbSuit1 As MaskedTextBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents lblSuit As Label
    Friend WithEvents txtDenomination5 As TextBox
    Friend WithEvents lblDenomination5 As Label
    Friend WithEvents txtDenomination4 As TextBox
    Friend WithEvents lblDenomination4 As Label
    Friend WithEvents txtDenomination3 As TextBox
    Friend WithEvents lblDenomination3 As Label
    Friend WithEvents txtDenomination2 As TextBox
    Friend WithEvents lblDenomination2 As Label
    Friend WithEvents lblDenomination As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents txtDenomination1 As TextBox
    Friend WithEvents lblDenomination1 As Label
End Class
