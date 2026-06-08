<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTelephoneDirectories
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstPhoneDirectories = New System.Windows.Forms.ListBox()
        Me.btnAddListing = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnNewDirectory = New System.Windows.Forms.Button()
        Me.lblCurrentDirectory = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPhoneNum = New System.Windows.Forms.Label()
        Me.txtCurrentDirectory = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.dgvOutput = New System.Windows.Forms.DataGridView()
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Click on one of the existing phone directories" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "below to make it the current phon" &
    "e directory"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Phone Directories"
        '
        'lstPhoneDirectories
        '
        Me.lstPhoneDirectories.FormattingEnabled = True
        Me.lstPhoneDirectories.ItemHeight = 20
        Me.lstPhoneDirectories.Location = New System.Drawing.Point(37, 160)
        Me.lstPhoneDirectories.Name = "lstPhoneDirectories"
        Me.lstPhoneDirectories.Size = New System.Drawing.Size(345, 164)
        Me.lstPhoneDirectories.TabIndex = 2
        '
        'btnAddListing
        '
        Me.btnAddListing.Location = New System.Drawing.Point(166, 366)
        Me.btnAddListing.Name = "btnAddListing"
        Me.btnAddListing.Size = New System.Drawing.Size(216, 76)
        Me.btnAddListing.TabIndex = 3
        Me.btnAddListing.Text = "Add a Listing to the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Current Directory"
        Me.btnAddListing.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(503, 366)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(256, 76)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.Text = "Remove a Listing from" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the Current Directory"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnNewDirectory
        '
        Me.btnNewDirectory.Location = New System.Drawing.Point(491, 32)
        Me.btnNewDirectory.Name = "btnNewDirectory"
        Me.btnNewDirectory.Size = New System.Drawing.Size(359, 60)
        Me.btnNewDirectory.TabIndex = 5
        Me.btnNewDirectory.Text = "Create a New Phone Directory"
        Me.btnNewDirectory.UseVisualStyleBackColor = True
        '
        'lblCurrentDirectory
        '
        Me.lblCurrentDirectory.AutoSize = True
        Me.lblCurrentDirectory.Location = New System.Drawing.Point(422, 131)
        Me.lblCurrentDirectory.Name = "lblCurrentDirectory"
        Me.lblCurrentDirectory.Size = New System.Drawing.Size(179, 20)
        Me.lblCurrentDirectory.TabIndex = 6
        Me.lblCurrentDirectory.Text = "Current Phone Directory"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(550, 194)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 20)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Name"
        '
        'lblPhoneNum
        '
        Me.lblPhoneNum.AutoSize = True
        Me.lblPhoneNum.Location = New System.Drawing.Point(486, 255)
        Me.lblPhoneNum.Name = "lblPhoneNum"
        Me.lblPhoneNum.Size = New System.Drawing.Size(115, 20)
        Me.lblPhoneNum.TabIndex = 8
        Me.lblPhoneNum.Text = "Phone Number"
        '
        'txtCurrentDirectory
        '
        Me.txtCurrentDirectory.Location = New System.Drawing.Point(621, 131)
        Me.txtCurrentDirectory.Name = "txtCurrentDirectory"
        Me.txtCurrentDirectory.ReadOnly = True
        Me.txtCurrentDirectory.Size = New System.Drawing.Size(229, 26)
        Me.txtCurrentDirectory.TabIndex = 9
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(621, 188)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(229, 26)
        Me.txtName.TabIndex = 10
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(621, 249)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(229, 26)
        Me.txtPhone.TabIndex = 11
        '
        'dgvOutput
        '
        Me.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOutput.Location = New System.Drawing.Point(197, 477)
        Me.dgvOutput.Name = "dgvOutput"
        Me.dgvOutput.RowHeadersWidth = 62
        Me.dgvOutput.RowTemplate.Height = 28
        Me.dgvOutput.Size = New System.Drawing.Size(471, 232)
        Me.dgvOutput.TabIndex = 12
        '
        'frmTelephoneDirectories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 753)
        Me.Controls.Add(Me.dgvOutput)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtCurrentDirectory)
        Me.Controls.Add(Me.lblPhoneNum)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCurrentDirectory)
        Me.Controls.Add(Me.btnNewDirectory)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAddListing)
        Me.Controls.Add(Me.lstPhoneDirectories)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTelephoneDirectories"
        Me.Text = "Telephone Directories"
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lstPhoneDirectories As ListBox
    Friend WithEvents btnAddListing As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnNewDirectory As Button
    Friend WithEvents lblCurrentDirectory As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblPhoneNum As Label
    Friend WithEvents txtCurrentDirectory As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents dgvOutput As DataGridView
End Class
