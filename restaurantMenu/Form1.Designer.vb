<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRestaurantMenu
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
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkBurgers = New System.Windows.Forms.CheckBox()
        Me.chkFries = New System.Windows.Forms.CheckBox()
        Me.chkDrinks = New System.Windows.Forms.CheckBox()
        Me.grpBurgers = New System.Windows.Forms.GroupBox()
        Me.radBacon = New System.Windows.Forms.RadioButton()
        Me.radBaconCheese = New System.Windows.Forms.RadioButton()
        Me.radCheese = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.grpFries = New System.Windows.Forms.GroupBox()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.grpDrinks = New System.Windows.Forms.GroupBox()
        Me.radBottledWater = New System.Windows.Forms.RadioButton()
        Me.radSoda = New System.Windows.Forms.RadioButton()
        Me.grpBurgers.SuspendLayout()
        Me.grpFries.SuspendLayout()
        Me.grpDrinks.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(503, 354)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(219, 81)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate Cost of the Meal"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(603, 469)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(142, 26)
        Me.txtCost.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(406, 472)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cost of the Meal is:"
        '
        'chkBurgers
        '
        Me.chkBurgers.AutoSize = True
        Me.chkBurgers.Location = New System.Drawing.Point(12, 24)
        Me.chkBurgers.Name = "chkBurgers"
        Me.chkBurgers.Size = New System.Drawing.Size(91, 24)
        Me.chkBurgers.TabIndex = 18
        Me.chkBurgers.Text = "Burgers"
        Me.chkBurgers.UseVisualStyleBackColor = True
        '
        'chkFries
        '
        Me.chkFries.AutoSize = True
        Me.chkFries.Location = New System.Drawing.Point(12, 197)
        Me.chkFries.Name = "chkFries"
        Me.chkFries.Size = New System.Drawing.Size(70, 24)
        Me.chkFries.TabIndex = 19
        Me.chkFries.Text = "Fries"
        Me.chkFries.UseVisualStyleBackColor = True
        '
        'chkDrinks
        '
        Me.chkDrinks.AutoSize = True
        Me.chkDrinks.Location = New System.Drawing.Point(12, 372)
        Me.chkDrinks.Name = "chkDrinks"
        Me.chkDrinks.Size = New System.Drawing.Size(80, 24)
        Me.chkDrinks.TabIndex = 20
        Me.chkDrinks.Text = "Drinks"
        Me.chkDrinks.UseVisualStyleBackColor = True
        '
        'grpBurgers
        '
        Me.grpBurgers.Controls.Add(Me.radBacon)
        Me.grpBurgers.Controls.Add(Me.radBaconCheese)
        Me.grpBurgers.Controls.Add(Me.radCheese)
        Me.grpBurgers.Controls.Add(Me.radRegular)
        Me.grpBurgers.Location = New System.Drawing.Point(126, 24)
        Me.grpBurgers.Name = "grpBurgers"
        Me.grpBurgers.Size = New System.Drawing.Size(250, 148)
        Me.grpBurgers.TabIndex = 21
        Me.grpBurgers.TabStop = False
        Me.grpBurgers.Text = "Choices for Burgers"
        Me.grpBurgers.Visible = False
        '
        'radBacon
        '
        Me.radBacon.AutoSize = True
        Me.radBacon.Location = New System.Drawing.Point(11, 86)
        Me.radBacon.Name = "radBacon"
        Me.radBacon.Size = New System.Drawing.Size(130, 24)
        Me.radBacon.TabIndex = 2
        Me.radBacon.TabStop = True
        Me.radBacon.Text = "w/bacon(250)"
        Me.radBacon.UseVisualStyleBackColor = True
        '
        'radBaconCheese
        '
        Me.radBaconCheese.AutoSize = True
        Me.radBaconCheese.Location = New System.Drawing.Point(12, 117)
        Me.radBaconCheese.Name = "radBaconCheese"
        Me.radBaconCheese.Size = New System.Drawing.Size(237, 24)
        Me.radBaconCheese.TabIndex = 2
        Me.radBaconCheese.TabStop = True
        Me.radBaconCheese.Text = "w/bacon and cheese(Rs400)"
        Me.radBaconCheese.UseVisualStyleBackColor = True
        '
        'radCheese
        '
        Me.radCheese.AutoSize = True
        Me.radCheese.Location = New System.Drawing.Point(11, 56)
        Me.radCheese.Name = "radCheese"
        Me.radCheese.Size = New System.Drawing.Size(158, 24)
        Me.radCheese.TabIndex = 1
        Me.radCheese.TabStop = True
        Me.radCheese.Text = "w/cheese(Rs250)"
        Me.radCheese.UseVisualStyleBackColor = True
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Location = New System.Drawing.Point(11, 26)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(146, 24)
        Me.radRegular.TabIndex = 0
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "Regular(₨200)"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'grpFries
        '
        Me.grpFries.Controls.Add(Me.radLarge)
        Me.grpFries.Controls.Add(Me.radMedium)
        Me.grpFries.Controls.Add(Me.radSmall)
        Me.grpFries.Location = New System.Drawing.Point(120, 197)
        Me.grpFries.Name = "grpFries"
        Me.grpFries.Size = New System.Drawing.Size(256, 137)
        Me.grpFries.TabIndex = 22
        Me.grpFries.TabStop = False
        Me.grpFries.Text = "Choices for Fries"
        Me.grpFries.Visible = False
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Location = New System.Drawing.Point(14, 99)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(132, 24)
        Me.radLarge.TabIndex = 4
        Me.radLarge.TabStop = True
        Me.radLarge.Text = "Large(Rs200)"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Location = New System.Drawing.Point(13, 68)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(147, 24)
        Me.radMedium.TabIndex = 3
        Me.radMedium.TabStop = True
        Me.radMedium.Text = "Medium(Rs160)"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.Location = New System.Drawing.Point(13, 38)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(130, 24)
        Me.radSmall.TabIndex = 2
        Me.radSmall.TabStop = True
        Me.radSmall.Text = "Small(Rs100)"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'grpDrinks
        '
        Me.grpDrinks.Controls.Add(Me.radBottledWater)
        Me.grpDrinks.Controls.Add(Me.radSoda)
        Me.grpDrinks.Location = New System.Drawing.Point(126, 372)
        Me.grpDrinks.Name = "grpDrinks"
        Me.grpDrinks.Size = New System.Drawing.Size(250, 113)
        Me.grpDrinks.TabIndex = 23
        Me.grpDrinks.TabStop = False
        Me.grpDrinks.Text = "Choices for Drinks"
        Me.grpDrinks.Visible = False
        '
        'radBottledWater
        '
        Me.radBottledWater.AutoSize = True
        Me.radBottledWater.Location = New System.Drawing.Point(8, 56)
        Me.radBottledWater.Name = "radBottledWater"
        Me.radBottledWater.Size = New System.Drawing.Size(180, 24)
        Me.radBottledWater.TabIndex = 3
        Me.radBottledWater.TabStop = True
        Me.radBottledWater.Text = "Bottled Water(Rs50)"
        Me.radBottledWater.UseVisualStyleBackColor = True
        '
        'radSoda
        '
        Me.radSoda.AutoSize = True
        Me.radSoda.Location = New System.Drawing.Point(7, 25)
        Me.radSoda.Name = "radSoda"
        Me.radSoda.Size = New System.Drawing.Size(120, 24)
        Me.radSoda.TabIndex = 2
        Me.radSoda.TabStop = True
        Me.radSoda.Text = "Soda(Rs70)"
        Me.radSoda.UseVisualStyleBackColor = True
        '
        'frmRestaurantMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 515)
        Me.Controls.Add(Me.grpDrinks)
        Me.Controls.Add(Me.grpFries)
        Me.Controls.Add(Me.grpBurgers)
        Me.Controls.Add(Me.chkDrinks)
        Me.Controls.Add(Me.chkFries)
        Me.Controls.Add(Me.chkBurgers)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frmRestaurantMenu"
        Me.Text = "Restaurant Menu"
        Me.grpBurgers.ResumeLayout(False)
        Me.grpBurgers.PerformLayout()
        Me.grpFries.ResumeLayout(False)
        Me.grpFries.PerformLayout()
        Me.grpDrinks.ResumeLayout(False)
        Me.grpDrinks.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtCost As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkBurgers As CheckBox
    Friend WithEvents chkFries As CheckBox
    Friend WithEvents chkDrinks As CheckBox
    Friend WithEvents grpBurgers As GroupBox
    Friend WithEvents radBacon As RadioButton
    Friend WithEvents radBaconCheese As RadioButton
    Friend WithEvents radCheese As RadioButton
    Friend WithEvents radRegular As RadioButton
    Friend WithEvents grpFries As GroupBox
    Friend WithEvents radLarge As RadioButton
    Friend WithEvents radMedium As RadioButton
    Friend WithEvents radSmall As RadioButton
    Friend WithEvents grpDrinks As GroupBox
    Friend WithEvents radBottledWater As RadioButton
    Friend WithEvents radSoda As RadioButton
End Class
