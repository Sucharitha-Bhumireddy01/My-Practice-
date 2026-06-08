<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMembershipList
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
        Me.lstMembers = New System.Windows.Forms.ListBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.msktxtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModify = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstMembers
        '
        Me.lstMembers.FormattingEnabled = True
        Me.lstMembers.ItemHeight = 20
        Me.lstMembers.Location = New System.Drawing.Point(85, 76)
        Me.lstMembers.Name = "lstMembers"
        Me.lstMembers.Size = New System.Drawing.Size(326, 264)
        Me.lstMembers.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(177, 385)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(269, 26)
        Me.txtName.TabIndex = 1
        '
        'msktxtPhone
        '
        Me.msktxtPhone.Location = New System.Drawing.Point(177, 434)
        Me.msktxtPhone.Mask = "000-0000"
        Me.msktxtPhone.Name = "msktxtPhone"
        Me.msktxtPhone.Size = New System.Drawing.Size(92, 26)
        Me.msktxtPhone.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(94, 385)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 20)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(81, 434)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(55, 20)
        Me.lblPhone.TabIndex = 4
        Me.lblPhone.Text = "Phone"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem, Me.mnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(490, 33)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModify, Me.mnuAdd, Me.mnuDelete})
        Me.UpdateToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(86, 29)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'mnuModify
        '
        Me.mnuModify.ForeColor = System.Drawing.SystemColors.Highlight
        Me.mnuModify.Name = "mnuModify"
        Me.mnuModify.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.mnuModify.Size = New System.Drawing.Size(270, 34)
        Me.mnuModify.Text = "Modify"
        '
        'mnuAdd
        '
        Me.mnuAdd.ForeColor = System.Drawing.SystemColors.Highlight
        Me.mnuAdd.Name = "mnuAdd"
        Me.mnuAdd.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.mnuAdd.Size = New System.Drawing.Size(270, 34)
        Me.mnuAdd.Text = "Add"
        '
        'mnuDelete
        '
        Me.mnuDelete.ForeColor = System.Drawing.SystemColors.Highlight
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F3), System.Windows.Forms.Keys)
        Me.mnuDelete.Size = New System.Drawing.Size(270, 34)
        Me.mnuDelete.Text = "Delete"
        '
        'mnuExit
        '
        Me.mnuExit.ForeColor = System.Drawing.SystemColors.Highlight
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(55, 29)
        Me.mnuExit.Text = "Exit"
        '
        'frmMembershipList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 472)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.msktxtPhone)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lstMembers)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmMembershipList"
        Me.Text = "Membership List"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstMembers As ListBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents msktxtPhone As MaskedTextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuModify As ToolStripMenuItem
    Friend WithEvents mnuAdd As ToolStripMenuItem
    Friend WithEvents mnuDelete As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
End Class
