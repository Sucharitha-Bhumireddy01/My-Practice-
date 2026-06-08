<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetails
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
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.grpCategory = New System.Windows.Forms.GroupBox()
        Me.radNonFiction = New System.Windows.Forms.RadioButton()
        Me.radFiction = New System.Windows.Forms.RadioButton()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpCategory.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRecord
        '
        Me.btnRecord.Location = New System.Drawing.Point(116, 276)
        Me.btnRecord.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(291, 45)
        Me.btnRecord.TabIndex = 48
        Me.btnRecord.Text = "Record Details"
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'grpCategory
        '
        Me.grpCategory.Controls.Add(Me.radNonFiction)
        Me.grpCategory.Controls.Add(Me.radFiction)
        Me.grpCategory.Location = New System.Drawing.Point(111, 178)
        Me.grpCategory.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.grpCategory.Name = "grpCategory"
        Me.grpCategory.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.grpCategory.Size = New System.Drawing.Size(292, 89)
        Me.grpCategory.TabIndex = 43
        Me.grpCategory.TabStop = False
        Me.grpCategory.Text = "Category"
        '
        'radNonFiction
        '
        Me.radNonFiction.Location = New System.Drawing.Point(130, 37)
        Me.radNonFiction.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.radNonFiction.Name = "radNonFiction"
        Me.radNonFiction.Size = New System.Drawing.Size(144, 37)
        Me.radNonFiction.TabIndex = 1
        Me.radNonFiction.Text = "Nonfiction"
        '
        'radFiction
        '
        Me.radFiction.Checked = True
        Me.radFiction.Location = New System.Drawing.Point(12, 37)
        Me.radFiction.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.radFiction.Name = "radFiction"
        Me.radFiction.Size = New System.Drawing.Size(116, 37)
        Me.radFiction.TabIndex = 0
        Me.radFiction.TabStop = True
        Me.radFiction.Text = "Fiction"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(318, 130)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(84, 26)
        Me.txtPrice.TabIndex = 47
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(261, 135)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(48, 20)
        Me.lblPrice.TabIndex = 46
        Me.lblPrice.Text = "Price:"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(174, 130)
        Me.txtStock.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(55, 26)
        Me.txtStock.TabIndex = 45
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(111, 135)
        Me.lblStock.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(54, 20)
        Me.lblStock.TabIndex = 44
        Me.lblStock.Text = "Stock:"
        Me.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(174, 81)
        Me.txtAuthor.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(228, 26)
        Me.txtAuthor.TabIndex = 42
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Location = New System.Drawing.Point(106, 85)
        Me.lblAuthor.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(61, 20)
        Me.lblAuthor.TabIndex = 41
        Me.lblAuthor.Text = "Author:"
        Me.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(174, 31)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(228, 26)
        Me.txtTitle.TabIndex = 40
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(123, 36)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(42, 20)
        Me.lblTitle.TabIndex = 39
        Me.lblTitle.Text = "Title:"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 353)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.grpCategory)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmDetails"
        Me.Text = "Book Details"
        Me.grpCategory.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRecord As Button
    Friend WithEvents grpCategory As GroupBox
    Friend WithEvents radNonFiction As RadioButton
    Friend WithEvents radFiction As RadioButton
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents lblStock As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents lblAuthor As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents lblTitle As Label
End Class
