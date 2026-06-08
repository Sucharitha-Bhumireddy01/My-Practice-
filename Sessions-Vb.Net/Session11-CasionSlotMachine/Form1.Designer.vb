<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlotMachine
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
        Me.components = New System.ComponentModel.Container()
        Me.picSlot0 = New System.Windows.Forms.PictureBox()
        Me.picSlot1 = New System.Windows.Forms.PictureBox()
        Me.picSlot2 = New System.Windows.Forms.PictureBox()
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.picChoice0 = New System.Windows.Forms.PictureBox()
        Me.picChoice1 = New System.Windows.Forms.PictureBox()
        Me.picChoice2 = New System.Windows.Forms.PictureBox()
        Me.picChoice3 = New System.Windows.Forms.PictureBox()
        Me.timSpin = New System.Windows.Forms.Timer(Me.components)
        Me.timeDone = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picSlot0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSlot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSlot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChoice0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChoice1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChoice2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChoice3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSlot0
        '
        Me.picSlot0.Location = New System.Drawing.Point(32, 108)
        Me.picSlot0.Name = "picSlot0"
        Me.picSlot0.Size = New System.Drawing.Size(350, 350)
        Me.picSlot0.TabIndex = 0
        Me.picSlot0.TabStop = False
        '
        'picSlot1
        '
        Me.picSlot1.Location = New System.Drawing.Point(418, 108)
        Me.picSlot1.Name = "picSlot1"
        Me.picSlot1.Size = New System.Drawing.Size(350, 350)
        Me.picSlot1.TabIndex = 1
        Me.picSlot1.TabStop = False
        '
        'picSlot2
        '
        Me.picSlot2.Location = New System.Drawing.Point(806, 108)
        Me.picSlot2.Name = "picSlot2"
        Me.picSlot2.Size = New System.Drawing.Size(350, 350)
        Me.picSlot2.TabIndex = 2
        Me.picSlot2.TabStop = False
        '
        'btnSpin
        '
        Me.btnSpin.Location = New System.Drawing.Point(418, 492)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(350, 47)
        Me.btnSpin.TabIndex = 3
        Me.btnSpin.Text = "Spin It"
        Me.btnSpin.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(542, 551)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(99, 37)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(462, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Bankroll"
        '
        'lblBank
        '
        Me.lblBank.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBank.Location = New System.Drawing.Point(534, 18)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(134, 68)
        Me.lblBank.TabIndex = 6
        Me.lblBank.Text = "100"
        Me.lblBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picChoice0
        '
        Me.picChoice0.Image = Global.Session11_CasionSlotMachine.My.Resources.Resources.arrow
        Me.picChoice0.Location = New System.Drawing.Point(40, 501)
        Me.picChoice0.Name = "picChoice0"
        Me.picChoice0.Size = New System.Drawing.Size(37, 38)
        Me.picChoice0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChoice0.TabIndex = 7
        Me.picChoice0.TabStop = False
        Me.picChoice0.Visible = False
        '
        'picChoice1
        '
        Me.picChoice1.Image = Global.Session11_CasionSlotMachine.My.Resources.Resources.ball
        Me.picChoice1.Location = New System.Drawing.Point(83, 501)
        Me.picChoice1.Name = "picChoice1"
        Me.picChoice1.Size = New System.Drawing.Size(37, 38)
        Me.picChoice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChoice1.TabIndex = 8
        Me.picChoice1.TabStop = False
        Me.picChoice1.Visible = False
        '
        'picChoice2
        '
        Me.picChoice2.Image = Global.Session11_CasionSlotMachine.My.Resources.Resources.bullsey
        Me.picChoice2.Location = New System.Drawing.Point(126, 501)
        Me.picChoice2.Name = "picChoice2"
        Me.picChoice2.Size = New System.Drawing.Size(37, 38)
        Me.picChoice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChoice2.TabIndex = 9
        Me.picChoice2.TabStop = False
        Me.picChoice2.Visible = False
        '
        'picChoice3
        '
        Me.picChoice3.Image = Global.Session11_CasionSlotMachine.My.Resources.Resources.jackpot
        Me.picChoice3.Location = New System.Drawing.Point(169, 501)
        Me.picChoice3.Name = "picChoice3"
        Me.picChoice3.Size = New System.Drawing.Size(37, 38)
        Me.picChoice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChoice3.TabIndex = 10
        Me.picChoice3.TabStop = False
        Me.picChoice3.Visible = False
        '
        'timSpin
        '
        '
        'timeDone
        '
        Me.timeDone.Interval = 2000
        '
        'frmSlotMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 600)
        Me.Controls.Add(Me.picChoice3)
        Me.Controls.Add(Me.picChoice2)
        Me.Controls.Add(Me.picChoice1)
        Me.Controls.Add(Me.picChoice0)
        Me.Controls.Add(Me.lblBank)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSpin)
        Me.Controls.Add(Me.picSlot2)
        Me.Controls.Add(Me.picSlot1)
        Me.Controls.Add(Me.picSlot0)
        Me.Name = "frmSlotMachine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Slot Machine"
        CType(Me.picSlot0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSlot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSlot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChoice0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChoice1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChoice2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChoice3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picSlot0 As PictureBox
    Friend WithEvents picSlot1 As PictureBox
    Friend WithEvents picSlot2 As PictureBox
    Friend WithEvents btnSpin As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblBank As Label
    Friend WithEvents picChoice0 As PictureBox
    Friend WithEvents picChoice1 As PictureBox
    Friend WithEvents picChoice2 As PictureBox
    Friend WithEvents picChoice3 As PictureBox
    Friend WithEvents timSpin As Timer
    Friend WithEvents timeDone As Timer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
