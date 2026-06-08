<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPalindrome
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
        Me.btnDetermine = New System.Windows.Forms.Button()
        Me.lblWord = New System.Windows.Forms.Label()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnDetermine
        '
        Me.btnDetermine.Location = New System.Drawing.Point(141, 189)
        Me.btnDetermine.Name = "btnDetermine"
        Me.btnDetermine.Size = New System.Drawing.Size(413, 72)
        Me.btnDetermine.TabIndex = 0
        Me.btnDetermine.Text = "Determine if Palindrome"
        Me.btnDetermine.UseVisualStyleBackColor = True
        '
        'lblWord
        '
        Me.lblWord.AutoSize = True
        Me.lblWord.Location = New System.Drawing.Point(94, 59)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(189, 20)
        Me.lblWord.TabIndex = 1
        Me.lblWord.Text = "Enter the Word or Phrase"
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(98, 114)
        Me.txtWord.Multiline = True
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(539, 41)
        Me.txtWord.TabIndex = 2
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(233, 299)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(201, 34)
        Me.txtOutput.TabIndex = 3
        '
        'frmPalindrome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.lblWord)
        Me.Controls.Add(Me.btnDetermine)
        Me.Name = "frmPalindrome"
        Me.Text = "Palindrome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDetermine As Button
    Friend WithEvents lblWord As Label
    Friend WithEvents txtWord As TextBox
    Friend WithEvents txtOutput As TextBox
End Class
