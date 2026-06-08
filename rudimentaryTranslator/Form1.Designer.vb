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
        Me.btnTranslate = New System.Windows.Forms.Button()
        Me.lblEngSentence = New System.Windows.Forms.Label()
        Me.lblFrenchSentence = New System.Windows.Forms.Label()
        Me.lblGermanSentence = New System.Windows.Forms.Label()
        Me.txtEnglish = New System.Windows.Forms.TextBox()
        Me.txtFrench = New System.Windows.Forms.TextBox()
        Me.txtGerman = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnTranslate
        '
        Me.btnTranslate.Location = New System.Drawing.Point(226, 103)
        Me.btnTranslate.Name = "btnTranslate"
        Me.btnTranslate.Size = New System.Drawing.Size(375, 42)
        Me.btnTranslate.TabIndex = 0
        Me.btnTranslate.Text = "Translate Sentence"
        Me.btnTranslate.UseVisualStyleBackColor = True
        '
        'lblEngSentence
        '
        Me.lblEngSentence.AutoSize = True
        Me.lblEngSentence.Location = New System.Drawing.Point(12, 35)
        Me.lblEngSentence.Name = "lblEngSentence"
        Me.lblEngSentence.Size = New System.Drawing.Size(134, 20)
        Me.lblEngSentence.TabIndex = 1
        Me.lblEngSentence.Text = "English Sentence"
        '
        'lblFrenchSentence
        '
        Me.lblFrenchSentence.AutoSize = True
        Me.lblFrenchSentence.Location = New System.Drawing.Point(12, 221)
        Me.lblFrenchSentence.Name = "lblFrenchSentence"
        Me.lblFrenchSentence.Size = New System.Drawing.Size(132, 20)
        Me.lblFrenchSentence.TabIndex = 2
        Me.lblFrenchSentence.Text = "French Sentence"
        '
        'lblGermanSentence
        '
        Me.lblGermanSentence.AutoSize = True
        Me.lblGermanSentence.Location = New System.Drawing.Point(12, 295)
        Me.lblGermanSentence.Name = "lblGermanSentence"
        Me.lblGermanSentence.Size = New System.Drawing.Size(140, 20)
        Me.lblGermanSentence.TabIndex = 3
        Me.lblGermanSentence.Text = "German Sentence"
        '
        'txtEnglish
        '
        Me.txtEnglish.Location = New System.Drawing.Point(169, 29)
        Me.txtEnglish.Name = "txtEnglish"
        Me.txtEnglish.Size = New System.Drawing.Size(480, 26)
        Me.txtEnglish.TabIndex = 4
        '
        'txtFrench
        '
        Me.txtFrench.Location = New System.Drawing.Point(171, 215)
        Me.txtFrench.Name = "txtFrench"
        Me.txtFrench.ReadOnly = True
        Me.txtFrench.Size = New System.Drawing.Size(478, 26)
        Me.txtFrench.TabIndex = 5
        '
        'txtGerman
        '
        Me.txtGerman.Location = New System.Drawing.Point(169, 292)
        Me.txtGerman.Name = "txtGerman"
        Me.txtGerman.ReadOnly = True
        Me.txtGerman.Size = New System.Drawing.Size(480, 26)
        Me.txtGerman.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtGerman)
        Me.Controls.Add(Me.txtFrench)
        Me.Controls.Add(Me.txtEnglish)
        Me.Controls.Add(Me.lblGermanSentence)
        Me.Controls.Add(Me.lblFrenchSentence)
        Me.Controls.Add(Me.lblEngSentence)
        Me.Controls.Add(Me.btnTranslate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTranslate As Button
    Friend WithEvents lblEngSentence As Label
    Friend WithEvents lblFrenchSentence As Label
    Friend WithEvents lblGermanSentence As Label
    Friend WithEvents txtEnglish As TextBox
    Friend WithEvents txtFrench As TextBox
    Friend WithEvents txtGerman As TextBox
End Class
