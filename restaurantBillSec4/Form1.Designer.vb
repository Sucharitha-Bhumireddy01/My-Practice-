<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRestaurantBillSec4
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
        Me.txtNumOfPizza = New System.Windows.Forms.TextBox()
        Me.txtNumOfFries = New System.Windows.Forms.TextBox()
        Me.txtNumOfDrinks = New System.Windows.Forms.TextBox()
        Me.txtPizza = New System.Windows.Forms.Label()
        Me.txtFries = New System.Windows.Forms.Label()
        Me.txtDrinks = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.gridDisplayBill = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.gridDisplayBill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNumOfPizza
        '
        Me.txtNumOfPizza.Location = New System.Drawing.Point(236, 66)
        Me.txtNumOfPizza.Name = "txtNumOfPizza"
        Me.txtNumOfPizza.Size = New System.Drawing.Size(77, 26)
        Me.txtNumOfPizza.TabIndex = 0
        '
        'txtNumOfFries
        '
        Me.txtNumOfFries.Location = New System.Drawing.Point(236, 113)
        Me.txtNumOfFries.Name = "txtNumOfFries"
        Me.txtNumOfFries.Size = New System.Drawing.Size(77, 26)
        Me.txtNumOfFries.TabIndex = 1
        '
        'txtNumOfDrinks
        '
        Me.txtNumOfDrinks.Location = New System.Drawing.Point(236, 168)
        Me.txtNumOfDrinks.Name = "txtNumOfDrinks"
        Me.txtNumOfDrinks.Size = New System.Drawing.Size(77, 26)
        Me.txtNumOfDrinks.TabIndex = 2
        '
        'txtPizza
        '
        Me.txtPizza.AutoSize = True
        Me.txtPizza.Location = New System.Drawing.Point(25, 69)
        Me.txtPizza.Name = "txtPizza"
        Me.txtPizza.Size = New System.Drawing.Size(167, 20)
        Me.txtPizza.TabIndex = 3
        Me.txtPizza.Text = "How many pizza slices"
        '
        'txtFries
        '
        Me.txtFries.AutoSize = True
        Me.txtFries.Location = New System.Drawing.Point(75, 119)
        Me.txtFries.Name = "txtFries"
        Me.txtFries.Size = New System.Drawing.Size(117, 20)
        Me.txtFries.TabIndex = 4
        Me.txtFries.Text = "How many fries"
        '
        'txtDrinks
        '
        Me.txtDrinks.AutoSize = True
        Me.txtDrinks.Location = New System.Drawing.Point(32, 168)
        Me.txtDrinks.Name = "txtDrinks"
        Me.txtDrinks.Size = New System.Drawing.Size(160, 20)
        Me.txtDrinks.TabIndex = 5
        Me.txtDrinks.Text = "How many soft drinks"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(380, 66)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(159, 128)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate Total Cost"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'gridDisplayBill
        '
        Me.gridDisplayBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridDisplayBill.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.gridDisplayBill.Location = New System.Drawing.Point(29, 257)
        Me.gridDisplayBill.Name = "gridDisplayBill"
        Me.gridDisplayBill.RowHeadersWidth = 62
        Me.gridDisplayBill.RowTemplate.Height = 28
        Me.gridDisplayBill.Size = New System.Drawing.Size(644, 150)
        Me.gridDisplayBill.TabIndex = 7
        '
        'Column1
        '
        Me.Column1.HeaderText = "ITEM"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "QUANTITY"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "PRICE"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'frmRestaurantBillSec4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gridDisplayBill)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtDrinks)
        Me.Controls.Add(Me.txtFries)
        Me.Controls.Add(Me.txtPizza)
        Me.Controls.Add(Me.txtNumOfDrinks)
        Me.Controls.Add(Me.txtNumOfFries)
        Me.Controls.Add(Me.txtNumOfPizza)
        Me.Name = "frmRestaurantBillSec4"
        Me.Text = "Restaurant Bill"
        CType(Me.gridDisplayBill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNumOfPizza As TextBox
    Friend WithEvents txtNumOfFries As TextBox
    Friend WithEvents txtNumOfDrinks As TextBox
    Friend WithEvents txtPizza As Label
    Friend WithEvents txtFries As Label
    Friend WithEvents txtDrinks As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents gridDisplayBill As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
