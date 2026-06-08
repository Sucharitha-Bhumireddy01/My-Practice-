<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectileMotion
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
        Me.lblIntialHeight = New System.Windows.Forms.Label()
        Me.lblInitialVelocity = New System.Windows.Forms.Label()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.txtIntialHeight = New System.Windows.Forms.TextBox()
        Me.txtIntialVelocity = New System.Windows.Forms.TextBox()
        Me.btnMaxHeight = New System.Windows.Forms.Button()
        Me.btnApproxTime = New System.Windows.Forms.Button()
        Me.btnTable = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.gridvwTable = New System.Windows.Forms.DataGridView()
        Me.Time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Height = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.gridvwTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblIntialHeight
        '
        Me.lblIntialHeight.AutoSize = True
        Me.lblIntialHeight.Location = New System.Drawing.Point(264, 30)
        Me.lblIntialHeight.Name = "lblIntialHeight"
        Me.lblIntialHeight.Size = New System.Drawing.Size(60, 40)
        Me.lblIntialHeight.TabIndex = 0
        Me.lblIntialHeight.Text = "Intital" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Height:"
        '
        'lblInitialVelocity
        '
        Me.lblInitialVelocity.AutoSize = True
        Me.lblInitialVelocity.Location = New System.Drawing.Point(538, 27)
        Me.lblInitialVelocity.Name = "lblInitialVelocity"
        Me.lblInitialVelocity.Size = New System.Drawing.Size(68, 40)
        Me.lblInitialVelocity.TabIndex = 1
        Me.lblInitialVelocity.Text = "Initial" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Velocity:"
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 20
        Me.lstOutput.Location = New System.Drawing.Point(12, 263)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(366, 184)
        Me.lstOutput.TabIndex = 2
        '
        'txtIntialHeight
        '
        Me.txtIntialHeight.Location = New System.Drawing.Point(347, 27)
        Me.txtIntialHeight.Multiline = True
        Me.txtIntialHeight.Name = "txtIntialHeight"
        Me.txtIntialHeight.Size = New System.Drawing.Size(70, 40)
        Me.txtIntialHeight.TabIndex = 3
        '
        'txtIntialVelocity
        '
        Me.txtIntialVelocity.Location = New System.Drawing.Point(642, 27)
        Me.txtIntialVelocity.Multiline = True
        Me.txtIntialVelocity.Name = "txtIntialVelocity"
        Me.txtIntialVelocity.Size = New System.Drawing.Size(70, 40)
        Me.txtIntialVelocity.TabIndex = 4
        '
        'btnMaxHeight
        '
        Me.btnMaxHeight.Location = New System.Drawing.Point(70, 93)
        Me.btnMaxHeight.Name = "btnMaxHeight"
        Me.btnMaxHeight.Size = New System.Drawing.Size(185, 65)
        Me.btnMaxHeight.TabIndex = 5
        Me.btnMaxHeight.Text = "Determine Maximum" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       Height"
        Me.btnMaxHeight.UseVisualStyleBackColor = True
        '
        'btnApproxTime
        '
        Me.btnApproxTime.Location = New System.Drawing.Point(70, 179)
        Me.btnApproxTime.Name = "btnApproxTime"
        Me.btnApproxTime.Size = New System.Drawing.Size(185, 69)
        Me.btnApproxTime.TabIndex = 6
        Me.btnApproxTime.Text = "Determine Approximate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Time until Ball Hits Ground"
        Me.btnApproxTime.UseVisualStyleBackColor = True
        '
        'btnTable
        '
        Me.btnTable.Location = New System.Drawing.Point(670, 93)
        Me.btnTable.Name = "btnTable"
        Me.btnTable.Size = New System.Drawing.Size(110, 65)
        Me.btnTable.TabIndex = 7
        Me.btnTable.Text = "Display" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Table"
        Me.btnTable.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(670, 179)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(110, 58)
        Me.btnQuit.TabIndex = 8
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'gridvwTable
        '
        Me.gridvwTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridvwTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Time, Me.Height})
        Me.gridvwTable.Location = New System.Drawing.Point(419, 263)
        Me.gridvwTable.Name = "gridvwTable"
        Me.gridvwTable.RowHeadersWidth = 62
        Me.gridvwTable.RowTemplate.Height = 28
        Me.gridvwTable.Size = New System.Drawing.Size(464, 175)
        Me.gridvwTable.TabIndex = 9
        '
        'Time
        '
        Me.Time.HeaderText = "Time"
        Me.Time.MinimumWidth = 8
        Me.Time.Name = "Time"
        Me.Time.Width = 150
        '
        'Height
        '
        Me.Height.HeaderText = "Height"
        Me.Height.MinimumWidth = 8
        Me.Height.Name = "Height"
        Me.Height.Width = 150
        '
        'frmProjectileMotion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 450)
        Me.Controls.Add(Me.gridvwTable)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnTable)
        Me.Controls.Add(Me.btnApproxTime)
        Me.Controls.Add(Me.btnMaxHeight)
        Me.Controls.Add(Me.txtIntialVelocity)
        Me.Controls.Add(Me.txtIntialHeight)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.lblInitialVelocity)
        Me.Controls.Add(Me.lblIntialHeight)
        Me.Name = "frmProjectileMotion"
        Me.Text = "Projectile Motion"
        CType(Me.gridvwTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIntialHeight As Label
    Friend WithEvents lblInitialVelocity As Label
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents txtIntialHeight As TextBox
    Friend WithEvents txtIntialVelocity As TextBox
    Friend WithEvents btnMaxHeight As Button
    Friend WithEvents btnApproxTime As Button
    Friend WithEvents btnTable As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents gridvwTable As DataGridView
    Friend WithEvents Time As DataGridViewTextBoxColumn
    Friend WithEvents Height As DataGridViewTextBoxColumn
End Class
