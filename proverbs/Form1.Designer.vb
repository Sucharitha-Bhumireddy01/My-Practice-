<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProverbs
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
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.lblProverb = New System.Windows.Forms.Label()
        Me.lblTrueFalse = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(48, 240)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(187, 52)
        Me.btnDisplay.TabIndex = 0
        Me.btnDisplay.Text = "Display Proverb"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnAnswer
        '
        Me.btnAnswer.Location = New System.Drawing.Point(261, 240)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(183, 52)
        Me.btnAnswer.TabIndex = 1
        Me.btnAnswer.Text = "Record Answer"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'lblProverb
        '
        Me.lblProverb.AutoSize = True
        Me.lblProverb.Location = New System.Drawing.Point(189, 59)
        Me.lblProverb.Name = "lblProverb"
        Me.lblProverb.Size = New System.Drawing.Size(0, 20)
        Me.lblProverb.TabIndex = 2
        '
        'lblTrueFalse
        '
        Me.lblTrueFalse.AutoSize = True
        Me.lblTrueFalse.Location = New System.Drawing.Point(110, 143)
        Me.lblTrueFalse.Name = "lblTrueFalse"
        Me.lblTrueFalse.Size = New System.Drawing.Size(149, 20)
        Me.lblTrueFalse.TabIndex = 3
        Me.lblTrueFalse.Text = "True (T) or Flase (F)"
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(276, 129)
        Me.txtAnswer.Multiline = True
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(78, 47)
        Me.txtAnswer.TabIndex = 4
        '
        'frmProverbs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.lblTrueFalse)
        Me.Controls.Add(Me.lblProverb)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.btnDisplay)
        Me.Name = "frmProverbs"
        Me.Text = "s"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnAnswer As Button
    Friend WithEvents lblProverb As Label
    Friend WithEvents lblTrueFalse As Label
    Friend WithEvents txtAnswer As TextBox
End Class
