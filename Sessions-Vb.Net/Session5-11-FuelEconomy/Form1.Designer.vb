<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuelEconomy
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
        Me.dgvOutput = New System.Windows.Forms.DataGridView()
        Me.btnCompute = New System.Windows.Forms.Button()
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvOutput
        '
        Me.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOutput.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOutput.ColumnHeadersVisible = False
        Me.dgvOutput.Location = New System.Drawing.Point(60, 164)
        Me.dgvOutput.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvOutput.Name = "dgvOutput"
        Me.dgvOutput.RowHeadersVisible = False
        Me.dgvOutput.RowHeadersWidth = 62
        Me.dgvOutput.Size = New System.Drawing.Size(254, 208)
        Me.dgvOutput.TabIndex = 5
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(60, 79)
        Me.btnCompute.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(254, 57)
        Me.btnCompute.TabIndex = 4
        Me.btnCompute.Text = "Compute MPG"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'frmFuelEconomy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 450)
        Me.Controls.Add(Me.dgvOutput)
        Me.Controls.Add(Me.btnCompute)
        Me.Name = "frmFuelEconomy"
        Me.Text = "Fuel Economy"
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvOutput As DataGridView
    Friend WithEvents btnCompute As Button
End Class
