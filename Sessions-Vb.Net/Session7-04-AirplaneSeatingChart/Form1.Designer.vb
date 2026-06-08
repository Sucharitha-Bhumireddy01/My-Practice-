<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeatingChart
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
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.txtF = New System.Windows.Forms.TextBox()
        Me.txtE = New System.Windows.Forms.TextBox()
        Me.txtD = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.lblF = New System.Windows.Forms.Label()
        Me.lblE = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lblRow = New System.Windows.Forms.Label()
        Me.txtRow = New System.Windows.Forms.TextBox()
        Me.lstRows = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstDisplay
        '
        Me.lstDisplay.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 20
        Me.lstDisplay.Location = New System.Drawing.Point(17, 214)
        Me.lstDisplay.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(276, 84)
        Me.lstDisplay.TabIndex = 51
        '
        'txtF
        '
        Me.txtF.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtF.Location = New System.Drawing.Point(532, 625)
        Me.txtF.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtF.Name = "txtF"
        Me.txtF.ReadOnly = True
        Me.txtF.Size = New System.Drawing.Size(56, 48)
        Me.txtF.TabIndex = 50
        Me.txtF.TabStop = False
        Me.txtF.Text = "."
        Me.txtF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtE
        '
        Me.txtE.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtE.Location = New System.Drawing.Point(451, 625)
        Me.txtE.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtE.Name = "txtE"
        Me.txtE.ReadOnly = True
        Me.txtE.Size = New System.Drawing.Size(58, 48)
        Me.txtE.TabIndex = 49
        Me.txtE.TabStop = False
        Me.txtE.Text = "."
        Me.txtE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtD
        '
        Me.txtD.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtD.Location = New System.Drawing.Point(370, 625)
        Me.txtD.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtD.Name = "txtD"
        Me.txtD.ReadOnly = True
        Me.txtD.Size = New System.Drawing.Size(58, 48)
        Me.txtD.TabIndex = 48
        Me.txtD.TabStop = False
        Me.txtD.Text = "."
        Me.txtD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtC
        '
        Me.txtC.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC.Location = New System.Drawing.Point(259, 625)
        Me.txtC.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtC.Name = "txtC"
        Me.txtC.ReadOnly = True
        Me.txtC.Size = New System.Drawing.Size(56, 48)
        Me.txtC.TabIndex = 47
        Me.txtC.TabStop = False
        Me.txtC.Text = "."
        Me.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtA
        '
        Me.txtA.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA.Location = New System.Drawing.Point(97, 625)
        Me.txtA.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtA.Name = "txtA"
        Me.txtA.ReadOnly = True
        Me.txtA.Size = New System.Drawing.Size(58, 48)
        Me.txtA.TabIndex = 46
        Me.txtA.TabStop = False
        Me.txtA.Text = "."
        Me.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtB
        '
        Me.txtB.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB.Location = New System.Drawing.Point(178, 625)
        Me.txtB.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtB.Name = "txtB"
        Me.txtB.ReadOnly = True
        Me.txtB.Size = New System.Drawing.Size(58, 48)
        Me.txtB.TabIndex = 45
        Me.txtB.TabStop = False
        Me.txtB.Text = "."
        Me.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblF
        '
        Me.lblF.AutoSize = True
        Me.lblF.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblF.Location = New System.Drawing.Point(546, 583)
        Me.lblF.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblF.Name = "lblF"
        Me.lblF.Size = New System.Drawing.Size(39, 39)
        Me.lblF.TabIndex = 44
        Me.lblF.Text = "F"
        '
        'lblE
        '
        Me.lblE.AutoSize = True
        Me.lblE.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblE.Location = New System.Drawing.Point(464, 583)
        Me.lblE.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblE.Name = "lblE"
        Me.lblE.Size = New System.Drawing.Size(39, 39)
        Me.lblE.TabIndex = 43
        Me.lblE.Text = "E"
        '
        'lblD
        '
        Me.lblD.AutoSize = True
        Me.lblD.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblD.Location = New System.Drawing.Point(384, 583)
        Me.lblD.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(39, 39)
        Me.lblD.TabIndex = 42
        Me.lblD.Text = "D"
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC.Location = New System.Drawing.Point(272, 583)
        Me.lblC.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(39, 39)
        Me.lblC.TabIndex = 41
        Me.lblC.Text = "C"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.Location = New System.Drawing.Point(192, 583)
        Me.lblB.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(39, 39)
        Me.lblB.TabIndex = 40
        Me.lblB.Text = "B"
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.Location = New System.Drawing.Point(110, 583)
        Me.lblA.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(39, 39)
        Me.lblA.TabIndex = 39
        Me.lblA.Text = "A"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(15, 128)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(278, 45)
        Me.btnDisplay.TabIndex = 38
        Me.btnDisplay.Text = "Display Statistics"
        '
        'lblRow
        '
        Me.lblRow.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRow.Location = New System.Drawing.Point(0, 590)
        Me.lblRow.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblRow.Name = "lblRow"
        Me.lblRow.Size = New System.Drawing.Size(80, 29)
        Me.lblRow.TabIndex = 37
        Me.lblRow.Text = "Row #"
        '
        'txtRow
        '
        Me.txtRow.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRow.Location = New System.Drawing.Point(8, 625)
        Me.txtRow.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtRow.Name = "txtRow"
        Me.txtRow.ReadOnly = True
        Me.txtRow.Size = New System.Drawing.Size(68, 48)
        Me.txtRow.TabIndex = 36
        Me.txtRow.TabStop = False
        '
        'lstRows
        '
        Me.lstRows.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRows.FormattingEnabled = True
        Me.lstRows.ItemHeight = 32
        Me.lstRows.Location = New System.Drawing.Point(384, 30)
        Me.lstRows.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.lstRows.Name = "lstRows"
        Me.lstRows.Size = New System.Drawing.Size(199, 516)
        Me.lstRows.TabIndex = 35
        '
        'frmSeatingChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 699)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.txtF)
        Me.Controls.Add(Me.txtE)
        Me.Controls.Add(Me.txtD)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.lblF)
        Me.Controls.Add(Me.lblE)
        Me.Controls.Add(Me.lblD)
        Me.Controls.Add(Me.lblC)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblRow)
        Me.Controls.Add(Me.txtRow)
        Me.Controls.Add(Me.lstRows)
        Me.Name = "frmSeatingChart"
        Me.Text = "Seating Chart"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents txtF As TextBox
    Friend WithEvents txtE As TextBox
    Friend WithEvents txtD As TextBox
    Friend WithEvents txtC As TextBox
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents lblF As Label
    Friend WithEvents lblE As Label
    Friend WithEvents lblD As Label
    Friend WithEvents lblC As Label
    Friend WithEvents lblB As Label
    Friend WithEvents lblA As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents lblRow As Label
    Friend WithEvents txtRow As TextBox
    Friend WithEvents lstRows As ListBox
End Class
