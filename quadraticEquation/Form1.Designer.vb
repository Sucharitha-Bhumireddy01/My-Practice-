<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuadraticEquation
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
        Me.btnQuadraticEquation = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.txtSolutions = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnQuadraticEquation
        '
        Me.btnQuadraticEquation.Location = New System.Drawing.Point(17, 101)
        Me.btnQuadraticEquation.Name = "btnQuadraticEquation"
        Me.btnQuadraticEquation.Size = New System.Drawing.Size(403, 72)
        Me.btnQuadraticEquation.TabIndex = 0
        Me.btnQuadraticEquation.Text = "Find Solution"
        Me.btnQuadraticEquation.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "a"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "b"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(317, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "c"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Solutions"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(37, 27)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(100, 26)
        Me.txtA.TabIndex = 5
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(184, 27)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(100, 26)
        Me.txtB.TabIndex = 6
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(340, 27)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(100, 26)
        Me.txtC.TabIndex = 7
        '
        'txtSolutions
        '
        Me.txtSolutions.Location = New System.Drawing.Point(131, 241)
        Me.txtSolutions.Name = "txtSolutions"
        Me.txtSolutions.ReadOnly = True
        Me.txtSolutions.Size = New System.Drawing.Size(309, 26)
        Me.txtSolutions.TabIndex = 8
        '
        'frmQuadraticEquation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtSolutions)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnQuadraticEquation)
        Me.Name = "frmQuadraticEquation"
        Me.Text = "Quadratic Equation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnQuadraticEquation As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents txtC As TextBox
    Friend WithEvents txtSolutions As TextBox
End Class
