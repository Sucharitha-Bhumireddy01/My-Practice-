<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStickGame
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnOne = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.lblPickSticks = New System.Windows.Forms.Label()
        Me.lblStatusofPile = New System.Windows.Forms.Label()
        Me.txtPileStatus = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(372, 47)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(135, 60)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "New Game"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(619, 47)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(107, 60)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnOne
        '
        Me.btnOne.Location = New System.Drawing.Point(296, 152)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(104, 37)
        Me.btnOne.TabIndex = 2
        Me.btnOne.Text = "One Stick"
        Me.btnOne.UseVisualStyleBackColor = True
        '
        'btnTwo
        '
        Me.btnTwo.Location = New System.Drawing.Point(443, 152)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(117, 37)
        Me.btnTwo.TabIndex = 3
        Me.btnTwo.Text = "Two Sticks"
        Me.btnTwo.UseVisualStyleBackColor = True
        '
        'btnThree
        '
        Me.btnThree.Location = New System.Drawing.Point(606, 149)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(120, 37)
        Me.btnThree.TabIndex = 4
        Me.btnThree.Text = "Three Sticks"
        Me.btnThree.UseVisualStyleBackColor = True
        '
        'lblPickSticks
        '
        Me.lblPickSticks.AutoSize = True
        Me.lblPickSticks.Location = New System.Drawing.Point(27, 149)
        Me.lblPickSticks.Name = "lblPickSticks"
        Me.lblPickSticks.Size = New System.Drawing.Size(177, 40)
        Me.lblPickSticks.TabIndex = 5
        Me.lblPickSticks.Text = "How many Sticks" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Would You LIke To Pick"
        '
        'lblStatusofPile
        '
        Me.lblStatusofPile.AutoSize = True
        Me.lblStatusofPile.Location = New System.Drawing.Point(27, 274)
        Me.lblStatusofPile.Name = "lblStatusofPile"
        Me.lblStatusofPile.Size = New System.Drawing.Size(131, 40)
        Me.lblStatusofPile.TabIndex = 6
        Me.lblStatusofPile.Text = "Current Status of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the Pile"
        '
        'txtPileStatus
        '
        Me.txtPileStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPileStatus.Location = New System.Drawing.Point(178, 288)
        Me.txtPileStatus.Multiline = True
        Me.txtPileStatus.Name = "txtPileStatus"
        Me.txtPileStatus.Size = New System.Drawing.Size(561, 47)
        Me.txtPileStatus.TabIndex = 7
        Me.txtPileStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmStickGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtPileStatus)
        Me.Controls.Add(Me.lblStatusofPile)
        Me.Controls.Add(Me.lblPickSticks)
        Me.Controls.Add(Me.btnThree)
        Me.Controls.Add(Me.btnTwo)
        Me.Controls.Add(Me.btnOne)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "frmStickGame"
        Me.Text = "Stick Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnOne As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnThree As Button
    Friend WithEvents lblPickSticks As Label
    Friend WithEvents lblStatusofPile As Label
    Friend WithEvents txtPileStatus As TextBox
End Class
