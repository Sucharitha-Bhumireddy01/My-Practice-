<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBalckJack
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
        Me.btnHitMe = New System.Windows.Forms.Button()
        Me.btnNewHand = New System.Windows.Forms.Button()
        Me.btnHold = New System.Windows.Forms.Button()
        Me.lblPlayer = New System.Windows.Forms.Label()
        Me.lblDealer = New System.Windows.Forms.Label()
        Me.txtPlayer = New System.Windows.Forms.TextBox()
        Me.txtDealer = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.lstPlayer = New System.Windows.Forms.ListBox()
        Me.lstDealer = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnHitMe
        '
        Me.btnHitMe.Location = New System.Drawing.Point(43, 262)
        Me.btnHitMe.Name = "btnHitMe"
        Me.btnHitMe.Size = New System.Drawing.Size(125, 42)
        Me.btnHitMe.TabIndex = 0
        Me.btnHitMe.Text = "Hit Me"
        Me.btnHitMe.UseVisualStyleBackColor = True
        '
        'btnNewHand
        '
        Me.btnNewHand.Location = New System.Drawing.Point(254, 262)
        Me.btnNewHand.Name = "btnNewHand"
        Me.btnNewHand.Size = New System.Drawing.Size(132, 42)
        Me.btnNewHand.TabIndex = 1
        Me.btnNewHand.Text = "New Hand"
        Me.btnNewHand.UseVisualStyleBackColor = True
        '
        'btnHold
        '
        Me.btnHold.Location = New System.Drawing.Point(434, 262)
        Me.btnHold.Name = "btnHold"
        Me.btnHold.Size = New System.Drawing.Size(126, 42)
        Me.btnHold.TabIndex = 2
        Me.btnHold.Text = "Hold"
        Me.btnHold.UseVisualStyleBackColor = True
        '
        'lblPlayer
        '
        Me.lblPlayer.AutoSize = True
        Me.lblPlayer.Location = New System.Drawing.Point(39, 195)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(95, 20)
        Me.lblPlayer.TabIndex = 3
        Me.lblPlayer.Text = "Player Total:"
        '
        'lblDealer
        '
        Me.lblDealer.AutoSize = True
        Me.lblDealer.Location = New System.Drawing.Point(392, 195)
        Me.lblDealer.Name = "lblDealer"
        Me.lblDealer.Size = New System.Drawing.Size(99, 20)
        Me.lblDealer.TabIndex = 4
        Me.lblDealer.Text = "Dealer Total:"
        '
        'txtPlayer
        '
        Me.txtPlayer.Location = New System.Drawing.Point(140, 182)
        Me.txtPlayer.Multiline = True
        Me.txtPlayer.Name = "txtPlayer"
        Me.txtPlayer.ReadOnly = True
        Me.txtPlayer.Size = New System.Drawing.Size(100, 45)
        Me.txtPlayer.TabIndex = 5
        '
        'txtDealer
        '
        Me.txtDealer.Location = New System.Drawing.Point(510, 182)
        Me.txtDealer.Multiline = True
        Me.txtDealer.Name = "txtDealer"
        Me.txtDealer.ReadOnly = True
        Me.txtDealer.Size = New System.Drawing.Size(100, 45)
        Me.txtDealer.TabIndex = 6
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(43, 342)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(517, 39)
        Me.txtOutput.TabIndex = 7
        '
        'lstPlayer
        '
        Me.lstPlayer.FormattingEnabled = True
        Me.lstPlayer.ItemHeight = 20
        Me.lstPlayer.Location = New System.Drawing.Point(43, 30)
        Me.lstPlayer.Name = "lstPlayer"
        Me.lstPlayer.Size = New System.Drawing.Size(234, 124)
        Me.lstPlayer.TabIndex = 8
        '
        'lstDealer
        '
        Me.lstDealer.FormattingEnabled = True
        Me.lstDealer.ItemHeight = 20
        Me.lstDealer.Location = New System.Drawing.Point(373, 30)
        Me.lstDealer.Name = "lstDealer"
        Me.lstDealer.Size = New System.Drawing.Size(237, 124)
        Me.lstDealer.TabIndex = 9
        '
        'frmBalckJack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 401)
        Me.Controls.Add(Me.lstDealer)
        Me.Controls.Add(Me.lstPlayer)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtDealer)
        Me.Controls.Add(Me.txtPlayer)
        Me.Controls.Add(Me.lblDealer)
        Me.Controls.Add(Me.lblPlayer)
        Me.Controls.Add(Me.btnHold)
        Me.Controls.Add(Me.btnNewHand)
        Me.Controls.Add(Me.btnHitMe)
        Me.Name = "frmBalckJack"
        Me.Text = "Black Jack"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHitMe As Button
    Friend WithEvents btnNewHand As Button
    Friend WithEvents btnHold As Button
    Friend WithEvents lblPlayer As Label
    Friend WithEvents lblDealer As Label
    Friend WithEvents txtPlayer As TextBox
    Friend WithEvents txtDealer As TextBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents lstPlayer As ListBox
    Friend WithEvents lstDealer As ListBox
End Class
