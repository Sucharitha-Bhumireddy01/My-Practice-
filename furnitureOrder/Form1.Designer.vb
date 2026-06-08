<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFurnitureOrder
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
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtChairs = New System.Windows.Forms.TextBox()
        Me.txtSofas = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.lblChairs = New System.Windows.Forms.Label()
        Me.lblSofas = New System.Windows.Forms.Label()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(16, 360)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(85, 64)
        Me.btnProcess.TabIndex = 0
        Me.btnProcess.Text = "Process Order"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(210, 360)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(92, 64)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear Order Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(687, 360)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(84, 64)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(227, 56)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(266, 26)
        Me.txtName.TabIndex = 3
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(227, 118)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(266, 26)
        Me.txtAddress.TabIndex = 4
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(227, 170)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(266, 26)
        Me.txtCity.TabIndex = 5
        '
        'txtChairs
        '
        Me.txtChairs.Location = New System.Drawing.Point(227, 230)
        Me.txtChairs.Name = "txtChairs"
        Me.txtChairs.Size = New System.Drawing.Size(100, 26)
        Me.txtChairs.TabIndex = 6
        '
        'txtSofas
        '
        Me.txtSofas.Location = New System.Drawing.Point(227, 293)
        Me.txtSofas.Name = "txtSofas"
        Me.txtSofas.Size = New System.Drawing.Size(100, 26)
        Me.txtSofas.TabIndex = 7
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 62)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(208, 20)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Customer Name (Last, First)"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(88, 124)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(68, 20)
        Me.lblAddress.TabIndex = 9
        Me.lblAddress.Text = "Address"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(88, 173)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(115, 20)
        Me.lbl.TabIndex = 10
        Me.lbl.Text = "City, State, ZIP"
        '
        'lblChairs
        '
        Me.lblChairs.AutoSize = True
        Me.lblChairs.Location = New System.Drawing.Point(9, 230)
        Me.lblChairs.Name = "lblChairs"
        Me.lblChairs.Size = New System.Drawing.Size(194, 20)
        Me.lblChairs.TabIndex = 11
        Me.lblChairs.Text = "Number of Chairs Ordered"
        '
        'lblSofas
        '
        Me.lblSofas.AutoSize = True
        Me.lblSofas.Location = New System.Drawing.Point(12, 299)
        Me.lblSofas.Name = "lblSofas"
        Me.lblSofas.Size = New System.Drawing.Size(191, 20)
        Me.lblSofas.TabIndex = 12
        Me.lblSofas.Text = "Number of Sofas Ordered"
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 20
        Me.lstDisplay.Location = New System.Drawing.Point(509, 12)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(279, 304)
        Me.lstDisplay.TabIndex = 13
        '
        'frmFurnitureOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.lblSofas)
        Me.Controls.Add(Me.lblChairs)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtSofas)
        Me.Controls.Add(Me.txtChairs)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnProcess)
        Me.Name = "frmFurnitureOrder"
        Me.Text = "Furniture Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnProcess As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtChairs As TextBox
    Friend WithEvents txtSofas As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lbl As Label
    Friend WithEvents lblChairs As Label
    Friend WithEvents lblSofas As Label
    Friend WithEvents lstDisplay As ListBox
End Class
