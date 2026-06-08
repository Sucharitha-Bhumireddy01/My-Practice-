<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNutrition
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtNameOfFood = New System.Windows.Forms.TextBox()
        Me.txtCaloriesPerServing = New System.Windows.Forms.TextBox()
        Me.txtGramsOfFat = New System.Windows.Forms.TextBox()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalculate.Location = New System.Drawing.Point(53, 228)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(390, 61)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate Calories Button"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'txtNameOfFood
        '
        Me.txtNameOfFood.Location = New System.Drawing.Point(224, 44)
        Me.txtNameOfFood.Name = "txtNameOfFood"
        Me.txtNameOfFood.Size = New System.Drawing.Size(219, 26)
        Me.txtNameOfFood.TabIndex = 1
        '
        'txtCaloriesPerServing
        '
        Me.txtCaloriesPerServing.Location = New System.Drawing.Point(282, 102)
        Me.txtCaloriesPerServing.Name = "txtCaloriesPerServing"
        Me.txtCaloriesPerServing.Size = New System.Drawing.Size(161, 26)
        Me.txtCaloriesPerServing.TabIndex = 2
        '
        'txtGramsOfFat
        '
        Me.txtGramsOfFat.Location = New System.Drawing.Point(282, 169)
        Me.txtGramsOfFat.Name = "txtGramsOfFat"
        Me.txtGramsOfFat.Size = New System.Drawing.Size(161, 26)
        Me.txtGramsOfFat.TabIndex = 3
        '
        'txtDisplay
        '
        Me.txtDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtDisplay.Location = New System.Drawing.Point(53, 305)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ReadOnly = True
        Me.txtDisplay.Size = New System.Drawing.Size(390, 105)
        Me.txtDisplay.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Name Of Food"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Calories Per Serving"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Grams Of Fat Per serving"
        '
        'frmNutrition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.txtGramsOfFat)
        Me.Controls.Add(Me.txtCaloriesPerServing)
        Me.Controls.Add(Me.txtNameOfFood)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frmNutrition"
        Me.Text = "Nutrition"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtNameOfFood As TextBox
    Friend WithEvents txtCaloriesPerServing As TextBox
    Friend WithEvents txtGramsOfFat As TextBox
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
