<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUSSenate
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
        Me.lstState = New System.Windows.Forms.ListBox()
        Me.lstSenators = New System.Windows.Forms.ListBox()
        Me.lblStates = New System.Windows.Forms.Label()
        Me.lblSenators = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstState
        '
        Me.lstState.FormattingEnabled = True
        Me.lstState.ItemHeight = 20
        Me.lstState.Location = New System.Drawing.Point(48, 94)
        Me.lstState.Name = "lstState"
        Me.lstState.Size = New System.Drawing.Size(196, 324)
        Me.lstState.TabIndex = 0
        '
        'lstSenators
        '
        Me.lstSenators.FormattingEnabled = True
        Me.lstSenators.ItemHeight = 20
        Me.lstSenators.Location = New System.Drawing.Point(287, 94)
        Me.lstSenators.Name = "lstSenators"
        Me.lstSenators.Size = New System.Drawing.Size(290, 164)
        Me.lstSenators.TabIndex = 1
        '
        'lblStates
        '
        Me.lblStates.AutoSize = True
        Me.lblStates.Location = New System.Drawing.Point(44, 59)
        Me.lblStates.Name = "lblStates"
        Me.lblStates.Size = New System.Drawing.Size(56, 20)
        Me.lblStates.TabIndex = 2
        Me.lblStates.Text = "States"
        '
        'lblSenators
        '
        Me.lblSenators.AutoSize = True
        Me.lblSenators.Location = New System.Drawing.Point(283, 59)
        Me.lblSenators.Name = "lblSenators"
        Me.lblSenators.Size = New System.Drawing.Size(74, 20)
        Me.lblSenators.TabIndex = 3
        Me.lblSenators.Text = "Senators"
        '
        'frmUSSenate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 450)
        Me.Controls.Add(Me.lblSenators)
        Me.Controls.Add(Me.lblStates)
        Me.Controls.Add(Me.lstSenators)
        Me.Controls.Add(Me.lstState)
        Me.Name = "frmUSSenate"
        Me.Text = "U. S. Senate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstState As ListBox
    Friend WithEvents lstSenators As ListBox
    Friend WithEvents lblStates As Label
    Friend WithEvents lblSenators As Label
End Class
