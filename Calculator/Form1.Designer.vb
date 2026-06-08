<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextFirst = New System.Windows.Forms.TextBox()
        Me.TextSecond = New System.Windows.Forms.TextBox()
        Me.TextResult = New System.Windows.Forms.TextBox()
        Me.Btnplus = New System.Windows.Forms.Button()
        Me.Btnminus = New System.Windows.Forms.Button()
        Me.Btnmultiply = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextFirst
        '
        Me.TextFirst.Location = New System.Drawing.Point(63, 186)
        Me.TextFirst.Name = "TextFirst"
        Me.TextFirst.Size = New System.Drawing.Size(100, 26)
        Me.TextFirst.TabIndex = 0
        '
        'TextSecond
        '
        Me.TextSecond.Location = New System.Drawing.Point(419, 186)
        Me.TextSecond.Name = "TextSecond"
        Me.TextSecond.Size = New System.Drawing.Size(100, 26)
        Me.TextSecond.TabIndex = 1
        '
        'TextResult
        '
        Me.TextResult.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextResult.Location = New System.Drawing.Point(174, 91)
        Me.TextResult.Name = "TextResult"
        Me.TextResult.ReadOnly = True
        Me.TextResult.Size = New System.Drawing.Size(244, 26)
        Me.TextResult.TabIndex = 2
        '
        'Btnplus
        '
        Me.Btnplus.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Btnplus.Location = New System.Drawing.Point(88, 291)
        Me.Btnplus.Name = "Btnplus"
        Me.Btnplus.Size = New System.Drawing.Size(75, 44)
        Me.Btnplus.TabIndex = 3
        Me.Btnplus.Text = "+"
        Me.Btnplus.UseVisualStyleBackColor = False
        '
        'Btnminus
        '
        Me.Btnminus.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Btnminus.Location = New System.Drawing.Point(245, 291)
        Me.Btnminus.Name = "Btnminus"
        Me.Btnminus.Size = New System.Drawing.Size(75, 44)
        Me.Btnminus.TabIndex = 4
        Me.Btnminus.Text = "-"
        Me.Btnminus.UseVisualStyleBackColor = False
        '
        'Btnmultiply
        '
        Me.Btnmultiply.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Btnmultiply.Location = New System.Drawing.Point(419, 291)
        Me.Btnmultiply.Name = "Btnmultiply"
        Me.Btnmultiply.Size = New System.Drawing.Size(75, 44)
        Me.Btnmultiply.TabIndex = 5
        Me.Btnmultiply.Text = "⨉"
        Me.Btnmultiply.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "First Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(415, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Second Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(266, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Result"
        '
        'FormCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btnmultiply)
        Me.Controls.Add(Me.Btnminus)
        Me.Controls.Add(Me.Btnplus)
        Me.Controls.Add(Me.TextResult)
        Me.Controls.Add(Me.TextSecond)
        Me.Controls.Add(Me.TextFirst)
        Me.Name = "FormCalculator"
        Me.Text = "FormCalculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextFirst As TextBox
    Friend WithEvents TextSecond As TextBox
    Friend WithEvents TextResult As TextBox
    Friend WithEvents Btnplus As Button
    Friend WithEvents Btnminus As Button
    Friend WithEvents Btnmultiply As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
