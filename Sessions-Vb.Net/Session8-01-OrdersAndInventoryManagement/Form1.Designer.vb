<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventoryManagement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnOutOfstock = New System.Windows.Forms.Button()
        Me.btnBills = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MacrolandDataSet1 = New Session8_01_OrdersAndInventoryManagement.MacrolandDataSet1()
        Me.CustomersTableAdapter = New Session8_01_OrdersAndInventoryManagement.MacrolandDataSet1TableAdapters.CustomersTableAdapter()
        Me.InventoryTableAdapter = New Session8_01_OrdersAndInventoryManagement.MacrolandDataSet1TableAdapters.InventoryTableAdapter()
        Me.OrdersTableAdapter = New Session8_01_OrdersAndInventoryManagement.MacrolandDataSet1TableAdapters.OrdersTableAdapter()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MacrolandDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOutOfstock
        '
        Me.btnOutOfstock.Location = New System.Drawing.Point(23, 37)
        Me.btnOutOfstock.Name = "btnOutOfstock"
        Me.btnOutOfstock.Size = New System.Drawing.Size(147, 60)
        Me.btnOutOfstock.TabIndex = 0
        Me.btnOutOfstock.Text = "Out of Stock" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Items"
        Me.btnOutOfstock.UseVisualStyleBackColor = True
        '
        'btnBills
        '
        Me.btnBills.Location = New System.Drawing.Point(282, 37)
        Me.btnBills.Name = "btnBills"
        Me.btnBills.Size = New System.Drawing.Size(143, 60)
        Me.btnBills.TabIndex = 1
        Me.btnBills.Text = "Bills for" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Today's Orders"
        Me.btnBills.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 20
        Me.lstOutput.Location = New System.Drawing.Point(23, 101)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(402, 344)
        Me.lstOutput.TabIndex = 2
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Orders"
        Me.BindingSource1.DataSource = Me.MacrolandDataSet1
        '
        'MacrolandDataSet1
        '
        Me.MacrolandDataSet1.DataSetName = "MacrolandDataSet1"
        Me.MacrolandDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'frmInventoryManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 498)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnBills)
        Me.Controls.Add(Me.btnOutOfstock)
        Me.Name = "frmInventoryManagement"
        Me.Text = "Inventory Management"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MacrolandDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOutOfstock As Button
    Friend WithEvents btnBills As Button
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents MacrolandDataSet1 As MacrolandDataSet1
    Friend WithEvents CustomersTableAdapter As MacrolandDataSet1TableAdapters.CustomersTableAdapter
    Friend WithEvents InventoryTableAdapter As MacrolandDataSet1TableAdapters.InventoryTableAdapter
    Friend WithEvents OrdersTableAdapter As MacrolandDataSet1TableAdapters.OrdersTableAdapter
End Class
