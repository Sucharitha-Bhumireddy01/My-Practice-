<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlphabeticalOrder
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
        Me.lblWord = New System.Windows.Forms.Label()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnDetermine = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWord
        '
        Me.lblWord.AutoSize = True
        Me.lblWord.Location = New System.Drawing.Point(8, 51)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(47, 20)
        Me.lblWord.TabIndex = 0
        Me.lblWord.Text = "Word"
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(71, 51)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(369, 26)
        Me.txtWord.TabIndex = 1
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(143, 249)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(172, 26)
        Me.txtOutput.TabIndex = 2
        '
        'btnDetermine
        '
        Me.btnDetermine.Location = New System.Drawing.Point(12, 97)
        Me.btnDetermine.Name = "btnDetermine"
        Me.btnDetermine.Size = New System.Drawing.Size(428, 127)
        Me.btnDetermine.TabIndex = 3
        Me.btnDetermine.Text = "Determine if the Word contains three" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "consecutive letters in consecutive" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "alphabe" &
    "tical order"
        Me.btnDetermine.UseVisualStyleBackColor = True
        '
        'frmAlphabeticalOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDetermine)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.lblWord)
        Me.Name = "frmAlphabeticalOrder"
        Me.Text = "Alphabetical Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWord As Label
    Friend WithEvents txtWord As TextBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents btnDetermine As Button
End Class
