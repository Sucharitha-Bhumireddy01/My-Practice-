<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLengthConversion
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
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.lstMetric = New System.Windows.Forms.ListBox()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.txtYards = New System.Windows.Forms.TextBox()
        Me.txtFeet = New System.Windows.Forms.TextBox()
        Me.txtInches = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(451, 78)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(179, 86)
        Me.btnConvert.TabIndex = 0
        Me.btnConvert.Text = "Convert To Metric"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'lstMetric
        '
        Me.lstMetric.FormattingEnabled = True
        Me.lstMetric.ItemHeight = 20
        Me.lstMetric.Location = New System.Drawing.Point(399, 198)
        Me.lstMetric.Name = "lstMetric"
        Me.lstMetric.Size = New System.Drawing.Size(296, 184)
        Me.lstMetric.TabIndex = 1
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(177, 78)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(140, 26)
        Me.txtMiles.TabIndex = 2
        '
        'txtYards
        '
        Me.txtYards.Location = New System.Drawing.Point(177, 138)
        Me.txtYards.Name = "txtYards"
        Me.txtYards.Size = New System.Drawing.Size(140, 26)
        Me.txtYards.TabIndex = 3
        '
        'txtFeet
        '
        Me.txtFeet.Location = New System.Drawing.Point(177, 192)
        Me.txtFeet.Name = "txtFeet"
        Me.txtFeet.Size = New System.Drawing.Size(140, 26)
        Me.txtFeet.TabIndex = 4
        '
        'txtInches
        '
        Me.txtInches.Location = New System.Drawing.Point(177, 264)
        Me.txtInches.Name = "txtInches"
        Me.txtInches.Size = New System.Drawing.Size(140, 26)
        Me.txtInches.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Miles"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Yards"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Feet"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Inches"
        '
        'FrmLengthConversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInches)
        Me.Controls.Add(Me.txtFeet)
        Me.Controls.Add(Me.txtYards)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.lstMetric)
        Me.Controls.Add(Me.btnConvert)
        Me.Name = "FrmLengthConversion"
        Me.Text = "Length Coversion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConvert As Button
    Friend WithEvents lstMetric As ListBox
    Friend WithEvents txtMiles As TextBox
    Friend WithEvents txtYards As TextBox
    Friend WithEvents txtFeet As TextBox
    Friend WithEvents txtInches As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
