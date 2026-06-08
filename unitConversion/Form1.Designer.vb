<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnitConversion
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
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtOriginal = New System.Windows.Forms.TextBox()
        Me.txtDesired = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.lblLenght = New System.Windows.Forms.Label()
        Me.lblOriginal = New System.Windows.Forms.Label()
        Me.Desired = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lstUnits = New System.Windows.Forms.ListBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(402, 42)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(100, 26)
        Me.txtLength.TabIndex = 0
        '
        'txtOriginal
        '
        Me.txtOriginal.Location = New System.Drawing.Point(402, 97)
        Me.txtOriginal.Name = "txtOriginal"
        Me.txtOriginal.ReadOnly = True
        Me.txtOriginal.Size = New System.Drawing.Size(100, 26)
        Me.txtOriginal.TabIndex = 1
        '
        'txtDesired
        '
        Me.txtDesired.Location = New System.Drawing.Point(402, 151)
        Me.txtDesired.Name = "txtDesired"
        Me.txtDesired.ReadOnly = True
        Me.txtDesired.Size = New System.Drawing.Size(100, 26)
        Me.txtDesired.TabIndex = 2
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(272, 307)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(128, 26)
        Me.txtOutput.TabIndex = 3
        '
        'lblLenght
        '
        Me.lblLenght.AutoSize = True
        Me.lblLenght.Location = New System.Drawing.Point(233, 42)
        Me.lblLenght.Name = "lblLenght"
        Me.lblLenght.Size = New System.Drawing.Size(136, 20)
        Me.lblLenght.TabIndex = 4
        Me.lblLenght.Text = "Length to Convert"
        '
        'lblOriginal
        '
        Me.lblOriginal.AutoSize = True
        Me.lblOriginal.Location = New System.Drawing.Point(242, 103)
        Me.lblOriginal.Name = "lblOriginal"
        Me.lblOriginal.Size = New System.Drawing.Size(136, 20)
        Me.lblOriginal.TabIndex = 5
        Me.lblOriginal.Text = "Original Units(1-9)"
        '
        'Desired
        '
        Me.Desired.AutoSize = True
        Me.Desired.Location = New System.Drawing.Point(242, 157)
        Me.Desired.Name = "Desired"
        Me.Desired.Size = New System.Drawing.Size(138, 20)
        Me.Desired.TabIndex = 6
        Me.Desired.Text = "Desired Units(1-9)"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(148, 307)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(118, 20)
        Me.lblOutput.TabIndex = 7
        Me.lblOutput.Text = "Desired Length"
        '
        'lstUnits
        '
        Me.lstUnits.FormattingEnabled = True
        Me.lstUnits.ItemHeight = 20
        Me.lstUnits.Items.AddRange(New Object() {"1. inch", "2. fathon", "3. foot", "4. furlong", "5. kilometer", "6. meter", "7. mile", "8. rod", "9. yard"})
        Me.lstUnits.Location = New System.Drawing.Point(42, 47)
        Me.lstUnits.Name = "lstUnits"
        Me.lstUnits.Size = New System.Drawing.Size(163, 224)
        Me.lstUnits.TabIndex = 8
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(246, 199)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(269, 61)
        Me.btnConvert.TabIndex = 9
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'frmUnitConversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lstUnits)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Desired)
        Me.Controls.Add(Me.lblOriginal)
        Me.Controls.Add(Me.lblLenght)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtDesired)
        Me.Controls.Add(Me.txtOriginal)
        Me.Controls.Add(Me.txtLength)
        Me.Name = "frmUnitConversion"
        Me.Text = "Unit Conversion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtOriginal As TextBox
    Friend WithEvents txtDesired As TextBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents lblLenght As Label
    Friend WithEvents lblOriginal As Label
    Friend WithEvents Desired As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents lstUnits As ListBox
    Friend WithEvents btnConvert As Button
End Class
