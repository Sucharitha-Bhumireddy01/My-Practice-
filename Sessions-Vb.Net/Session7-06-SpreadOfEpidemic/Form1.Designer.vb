<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpreadOfEpidemic
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
        Me.picOutput = New System.Windows.Forms.PictureBox()
        Me.btnDay0 = New System.Windows.Forms.Button()
        Me.btnAdvance = New System.Windows.Forms.Button()
        CType(Me.picOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picOutput
        '
        Me.picOutput.Location = New System.Drawing.Point(45, 43)
        Me.picOutput.Name = "picOutput"
        Me.picOutput.Size = New System.Drawing.Size(505, 194)
        Me.picOutput.TabIndex = 0
        Me.picOutput.TabStop = False
        '
        'btnDay0
        '
        Me.btnDay0.Location = New System.Drawing.Point(45, 287)
        Me.btnDay0.Name = "btnDay0"
        Me.btnDay0.Size = New System.Drawing.Size(180, 52)
        Me.btnDay0.TabIndex = 1
        Me.btnDay0.Text = "Show Day 0"
        Me.btnDay0.UseVisualStyleBackColor = True
        '
        'btnAdvance
        '
        Me.btnAdvance.Location = New System.Drawing.Point(320, 287)
        Me.btnAdvance.Name = "btnAdvance"
        Me.btnAdvance.Size = New System.Drawing.Size(167, 52)
        Me.btnAdvance.TabIndex = 2
        Me.btnAdvance.Text = "Advance One"
        Me.btnAdvance.UseVisualStyleBackColor = True
        '
        'frmSpreadOfEpidemic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 379)
        Me.Controls.Add(Me.btnAdvance)
        Me.Controls.Add(Me.btnDay0)
        Me.Controls.Add(Me.picOutput)
        Me.Name = "frmSpreadOfEpidemic"
        Me.Text = "Spread Of Epidemic"
        CType(Me.picOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picOutput As PictureBox
    Friend WithEvents btnDay0 As Button
    Friend WithEvents btnAdvance As Button
End Class
