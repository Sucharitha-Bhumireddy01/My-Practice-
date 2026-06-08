<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMeal
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
        Me.radVeg = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.radLowCal = New System.Windows.Forms.RadioButton()
        Me.radUnoccupied = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'radVeg
        '
        Me.radVeg.Location = New System.Drawing.Point(271, 138)
        Me.radVeg.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.radVeg.Name = "radVeg"
        Me.radVeg.Size = New System.Drawing.Size(117, 43)
        Me.radVeg.TabIndex = 11
        Me.radVeg.Text = "Vegetarian"
        '
        'radRegular
        '
        Me.radRegular.Location = New System.Drawing.Point(271, 61)
        Me.radRegular.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(93, 43)
        Me.radRegular.TabIndex = 10
        Me.radRegular.Text = "Regular"
        '
        'radLowCal
        '
        Me.radLowCal.Location = New System.Drawing.Point(57, 138)
        Me.radLowCal.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.radLowCal.Name = "radLowCal"
        Me.radLowCal.Size = New System.Drawing.Size(123, 43)
        Me.radLowCal.TabIndex = 9
        Me.radLowCal.Text = "Low Calorie"
        '
        'radUnoccupied
        '
        Me.radUnoccupied.Location = New System.Drawing.Point(57, 61)
        Me.radUnoccupied.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.radUnoccupied.Name = "radUnoccupied"
        Me.radUnoccupied.Size = New System.Drawing.Size(132, 43)
        Me.radUnoccupied.TabIndex = 8
        Me.radUnoccupied.Text = "Unoccupied"
        '
        'frmMeal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 223)
        Me.Controls.Add(Me.radVeg)
        Me.Controls.Add(Me.radRegular)
        Me.Controls.Add(Me.radLowCal)
        Me.Controls.Add(Me.radUnoccupied)
        Me.Name = "frmMeal"
        Me.Text = "Meal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents radVeg As RadioButton
    Friend WithEvents radRegular As RadioButton
    Friend WithEvents radLowCal As RadioButton
    Friend WithEvents radUnoccupied As RadioButton
End Class
