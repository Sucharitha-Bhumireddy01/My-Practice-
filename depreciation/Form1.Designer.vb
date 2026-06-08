<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepreciation
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
        Me.btnStraight = New System.Windows.Forms.Button()
        Me.btnDouble = New System.Windows.Forms.Button()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtNumYears = New System.Windows.Forms.TextBox()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblEstimatedLife = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStraight
        '
        Me.btnStraight.Location = New System.Drawing.Point(157, 172)
        Me.btnStraight.Name = "btnStraight"
        Me.btnStraight.Size = New System.Drawing.Size(369, 54)
        Me.btnStraight.TabIndex = 0
        Me.btnStraight.Text = "Straight-Line Method"
        Me.btnStraight.UseVisualStyleBackColor = True
        '
        'btnDouble
        '
        Me.btnDouble.Location = New System.Drawing.Point(157, 246)
        Me.btnDouble.Name = "btnDouble"
        Me.btnDouble.Size = New System.Drawing.Size(369, 52)
        Me.btnDouble.TabIndex = 1
        Me.btnDouble.Text = "Double-Declining-Balance Method"
        Me.btnDouble.UseVisualStyleBackColor = True
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(141, 35)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(148, 39)
        Me.txtDesc.TabIndex = 2
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(410, 35)
        Me.txtCost.Multiline = True
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(100, 39)
        Me.txtCost.TabIndex = 3
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(185, 87)
        Me.txtYear.Multiline = True
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(62, 40)
        Me.txtYear.TabIndex = 4
        '
        'txtNumYears
        '
        Me.txtNumYears.Location = New System.Drawing.Point(472, 100)
        Me.txtNumYears.Multiline = True
        Me.txtNumYears.Name = "txtNumYears"
        Me.txtNumYears.Size = New System.Drawing.Size(38, 36)
        Me.txtNumYears.TabIndex = 5
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 20
        Me.lstOutput.Location = New System.Drawing.Point(157, 304)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(369, 224)
        Me.lstOutput.TabIndex = 6
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(90, 38)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(45, 20)
        Me.lblItem.TabIndex = 7
        Me.lblItem.Text = "Item:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(345, 38)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(46, 20)
        Me.lblCost.TabIndex = 8
        Me.lblCost.Text = "Cost:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(90, 87)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(80, 40)
        Me.lblYear.TabIndex = 9
        Me.lblYear.Text = "Year of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "purchage:"
        '
        'lblEstimatedLife
        '
        Me.lblEstimatedLife.AutoSize = True
        Me.lblEstimatedLife.Location = New System.Drawing.Point(332, 87)
        Me.lblEstimatedLife.Name = "lblEstimatedLife"
        Me.lblEstimatedLife.Size = New System.Drawing.Size(123, 40)
        Me.lblEstimatedLife.TabIndex = 10
        Me.lblEstimatedLife.Text = "Estimated life of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "item(years):"
        '
        'frmDepreciation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 538)
        Me.Controls.Add(Me.lblEstimatedLife)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.txtNumYears)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.btnDouble)
        Me.Controls.Add(Me.btnStraight)
        Me.Name = "frmDepreciation"
        Me.Text = "Depreciation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStraight As Button
    Friend WithEvents btnDouble As Button
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtNumYears As TextBox
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents lblItem As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblEstimatedLife As Label
End Class
