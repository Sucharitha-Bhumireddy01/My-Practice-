<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblSentence = New System.Windows.Forms.Label()
        Me.txtSentence = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(37, 218)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(516, 85)
        Me.btnRemove.TabIndex = 0
        Me.btnRemove.Text = "Remove Parantheses"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'lblSentence
        '
        Me.lblSentence.AutoSize = True
        Me.lblSentence.Location = New System.Drawing.Point(33, 66)
        Me.lblSentence.Name = "lblSentence"
        Me.lblSentence.Size = New System.Drawing.Size(78, 20)
        Me.lblSentence.TabIndex = 1
        Me.lblSentence.Text = "Sentence"
        '
        'txtSentence
        '
        Me.txtSentence.Location = New System.Drawing.Point(37, 132)
        Me.txtSentence.Multiline = True
        Me.txtSentence.Name = "txtSentence"
        Me.txtSentence.Size = New System.Drawing.Size(516, 42)
        Me.txtSentence.TabIndex = 2
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(37, 337)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(516, 39)
        Me.txtOutput.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtSentence)
        Me.Controls.Add(Me.lblSentence)
        Me.Controls.Add(Me.btnRemove)
        Me.Name = "Form1"
        Me.Text = "Parantheses"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRemove As Button
    Friend WithEvents lblSentence As Label
    Friend WithEvents txtSentence As TextBox
    Friend WithEvents txtOutput As TextBox
End Class
