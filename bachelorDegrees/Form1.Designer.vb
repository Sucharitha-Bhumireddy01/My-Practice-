<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBachelorDegrees
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
        Me.btnTable1 = New System.Windows.Forms.Button()
        Me.btnTable2 = New System.Windows.Forms.Button()
        Me.btnTable3 = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.grdOutput = New System.Windows.Forms.DataGridView()
        CType(Me.grdOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTable1
        '
        Me.btnTable1.Location = New System.Drawing.Point(245, 30)
        Me.btnTable1.Name = "btnTable1"
        Me.btnTable1.Size = New System.Drawing.Size(360, 59)
        Me.btnTable1.TabIndex = 0
        Me.btnTable1.Text = "Bachelor Degrees Conferred in" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Certain Fields"
        Me.btnTable1.UseVisualStyleBackColor = True
        '
        'btnTable2
        '
        Me.btnTable2.Location = New System.Drawing.Point(245, 111)
        Me.btnTable2.Name = "btnTable2"
        Me.btnTable2.Size = New System.Drawing.Size(360, 63)
        Me.btnTable2.TabIndex = 1
        Me.btnTable2.Text = "Percentage Change in Bachelor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Degrees COnferred"
        Me.btnTable2.UseVisualStyleBackColor = True
        '
        'btnTable3
        '
        Me.btnTable3.Location = New System.Drawing.Point(245, 190)
        Me.btnTable3.Name = "btnTable3"
        Me.btnTable3.Size = New System.Drawing.Size(360, 64)
        Me.btnTable3.TabIndex = 2
        Me.btnTable3.Text = "Bachelor Degrees Conferred in 2010" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in Certain Fields"
        Me.btnTable3.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(235, 308)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(360, 55)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'grdOutput
        '
        Me.grdOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdOutput.Location = New System.Drawing.Point(12, 381)
        Me.grdOutput.Name = "grdOutput"
        Me.grdOutput.RowHeadersWidth = 62
        Me.grdOutput.RowTemplate.Height = 28
        Me.grdOutput.Size = New System.Drawing.Size(776, 266)
        Me.grdOutput.TabIndex = 4
        '
        'frmBachelorDegrees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 659)
        Me.Controls.Add(Me.grdOutput)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnTable3)
        Me.Controls.Add(Me.btnTable2)
        Me.Controls.Add(Me.btnTable1)
        Me.Name = "frmBachelorDegrees"
        Me.Text = "Bachelor Degrees"
        CType(Me.grdOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTable1 As Button
    Friend WithEvents btnTable2 As Button
    Friend WithEvents btnTable3 As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents grdOutput As DataGridView
End Class
