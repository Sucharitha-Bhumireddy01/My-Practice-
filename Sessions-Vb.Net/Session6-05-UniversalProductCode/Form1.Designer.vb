<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUPC
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
        Me.mtbUPC = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstReceipt = New System.Windows.Forms.ListBox()
        Me.btnDisplayReceipt = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'mtbUPC
        '
        Me.mtbUPC.Location = New System.Drawing.Point(207, 165)
        Me.mtbUPC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtbUPC.Mask = "000000000000"
        Me.mtbUPC.Name = "mtbUPC"
        Me.mtbUPC.Size = New System.Drawing.Size(162, 26)
        Me.mtbUPC.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(154, 173)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "UPC"
        '
        'lstReceipt
        '
        Me.lstReceipt.FormattingEnabled = True
        Me.lstReceipt.ItemHeight = 20
        Me.lstReceipt.Location = New System.Drawing.Point(159, 216)
        Me.lstReceipt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstReceipt.Name = "lstReceipt"
        Me.lstReceipt.Size = New System.Drawing.Size(486, 184)
        Me.lstReceipt.TabIndex = 14
        Me.lstReceipt.TabStop = False
        '
        'btnDisplayReceipt
        '
        Me.btnDisplayReceipt.Location = New System.Drawing.Point(435, 131)
        Me.btnDisplayReceipt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDisplayReceipt.Name = "btnDisplayReceipt"
        Me.btnDisplayReceipt.Size = New System.Drawing.Size(212, 62)
        Me.btnDisplayReceipt.TabIndex = 13
        Me.btnDisplayReceipt.Text = "Display Receipt"
        Me.btnDisplayReceipt.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(435, 50)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(212, 68)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add to Receipt"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCustomer
        '
        Me.btnCustomer.Location = New System.Drawing.Point(159, 57)
        Me.btnCustomer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(212, 62)
        Me.btnCustomer.TabIndex = 15
        Me.btnCustomer.Text = "New Customer"
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'frmUPC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.mtbUPC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstReceipt)
        Me.Controls.Add(Me.btnDisplayReceipt)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnCustomer)
        Me.Name = "frmUPC"
        Me.Text = "UPC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mtbUPC As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lstReceipt As ListBox
    Friend WithEvents btnDisplayReceipt As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCustomer As Button
End Class
