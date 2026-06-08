<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepairBill
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtLabor = New System.Windows.Forms.TextBox()
        Me.txtParts = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(270, 39)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(335, 26)
        Me.txtName.TabIndex = 0
        '
        'txtLabor
        '
        Me.txtLabor.Location = New System.Drawing.Point(270, 110)
        Me.txtLabor.Name = "txtLabor"
        Me.txtLabor.Size = New System.Drawing.Size(100, 26)
        Me.txtLabor.TabIndex = 1
        '
        'txtParts
        '
        Me.txtParts.Location = New System.Drawing.Point(270, 185)
        Me.txtParts.Name = "txtParts"
        Me.txtParts.Size = New System.Drawing.Size(100, 26)
        Me.txtParts.TabIndex = 2
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(126, 315)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 91)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "Display Bill"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Customer Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Hours of Labor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(100, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cost of Parts"
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 20
        Me.lstDisplay.Location = New System.Drawing.Point(324, 262)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(388, 164)
        Me.lstDisplay.TabIndex = 8
        '
        'RepairBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtParts)
        Me.Controls.Add(Me.txtLabor)
        Me.Controls.Add(Me.txtName)
        Me.Name = "RepairBill"
        Me.Text = "RepairBill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtLabor As TextBox
    Friend WithEvents txtParts As TextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstDisplay As ListBox
End Class
