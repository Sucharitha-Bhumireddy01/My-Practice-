<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmISBNValidator
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
        Me.btnCheckValidity = New System.Windows.Forms.Button()
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.lblValid = New System.Windows.Forms.Label()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.mtbISBN = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'btnCheckValidity
        '
        Me.btnCheckValidity.Location = New System.Drawing.Point(115, 111)
        Me.btnCheckValidity.Name = "btnCheckValidity"
        Me.btnCheckValidity.Size = New System.Drawing.Size(168, 68)
        Me.btnCheckValidity.TabIndex = 0
        Me.btnCheckValidity.Text = "Check Validate"
        Me.btnCheckValidity.UseVisualStyleBackColor = True
        '
        'lblISBN
        '
        Me.lblISBN.AutoSize = True
        Me.lblISBN.Location = New System.Drawing.Point(36, 55)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(107, 20)
        Me.lblISBN.TabIndex = 1
        Me.lblISBN.Text = "ISBN Number"
        '
        'lblValid
        '
        Me.lblValid.AutoSize = True
        Me.lblValid.Location = New System.Drawing.Point(69, 210)
        Me.lblValid.Name = "lblValid"
        Me.lblValid.Size = New System.Drawing.Size(95, 20)
        Me.lblValid.TabIndex = 2
        Me.lblValid.Text = "Valid ISBN?"
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(166, 210)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(224, 26)
        Me.txtOutput.TabIndex = 3
        '
        'mtbISBN
        '
        Me.mtbISBN.Location = New System.Drawing.Point(166, 52)
        Me.mtbISBN.Mask = "0-00-000000-&"
        Me.mtbISBN.Name = "mtbISBN"
        Me.mtbISBN.Size = New System.Drawing.Size(224, 26)
        Me.mtbISBN.TabIndex = 4
        '
        'frmISBNValidator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.mtbISBN)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.lblValid)
        Me.Controls.Add(Me.lblISBN)
        Me.Controls.Add(Me.btnCheckValidity)
        Me.Name = "frmISBNValidator"
        Me.Text = "ISBN Validator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCheckValidity As Button
    Friend WithEvents lblISBN As Label
    Friend WithEvents lblValid As Label
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents mtbISBN As MaskedTextBox
End Class
