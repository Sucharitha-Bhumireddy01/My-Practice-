<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaffeineAbsorption
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
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.lbl65mg = New System.Windows.Forms.Label()
        Me.lbl1CupQuantity = New System.Windows.Forms.Label()
        Me.lblHourlycupsQuantity = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(79, 330)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(367, 53)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate Value"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(267, 89)
        Me.txt1.Name = "txt1"
        Me.txt1.ReadOnly = True
        Me.txt1.Size = New System.Drawing.Size(179, 26)
        Me.txt1.TabIndex = 1
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(267, 171)
        Me.txt2.Name = "txt2"
        Me.txt2.ReadOnly = True
        Me.txt2.Size = New System.Drawing.Size(179, 26)
        Me.txt2.TabIndex = 2
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(267, 263)
        Me.txt3.Name = "txt3"
        Me.txt3.ReadOnly = True
        Me.txt3.Size = New System.Drawing.Size(179, 26)
        Me.txt3.TabIndex = 3
        '
        'lbl65mg
        '
        Me.lbl65mg.AutoSize = True
        Me.lbl65mg.Location = New System.Drawing.Point(75, 95)
        Me.lbl65mg.Name = "lbl65mg"
        Me.lbl65mg.Size = New System.Drawing.Size(125, 40)
        Me.lbl65mg.TabIndex = 4
        Me.lbl65mg.Text = "1 Cup: When will" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "65 mg. remain?"
        '
        'lbl1CupQuantity
        '
        Me.lbl1CupQuantity.AutoSize = True
        Me.lbl1CupQuantity.Location = New System.Drawing.Point(75, 172)
        Me.lbl1CupQuantity.Name = "lbl1CupQuantity"
        Me.lbl1CupQuantity.Size = New System.Drawing.Size(118, 40)
        Me.lbl1CupQuantity.TabIndex = 5
        Me.lbl1CupQuantity.Text = "1 Cup: Quantity" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "after 24 hours:"
        '
        'lblHourlycupsQuantity
        '
        Me.lblHourlycupsQuantity.AutoSize = True
        Me.lblHourlycupsQuantity.Location = New System.Drawing.Point(75, 269)
        Me.lblHourlycupsQuantity.Name = "lblHourlycupsQuantity"
        Me.lblHourlycupsQuantity.Size = New System.Drawing.Size(159, 40)
        Me.lblHourlycupsQuantity.TabIndex = 6
        Me.lblHourlycupsQuantity.Text = "Hourly cups: Quantity" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "after 24 hours:"
        '
        'frmCaffeineAbsorption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblHourlycupsQuantity)
        Me.Controls.Add(Me.lbl1CupQuantity)
        Me.Controls.Add(Me.lbl65mg)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frmCaffeineAbsorption"
        Me.Text = "Caffeine Absorption"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txt3 As TextBox
    Friend WithEvents lbl65mg As Label
    Friend WithEvents lbl1CupQuantity As Label
    Friend WithEvents lblHourlycupsQuantity As Label
End Class
