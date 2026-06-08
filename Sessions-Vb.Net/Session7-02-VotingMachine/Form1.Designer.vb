<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVotingMachine
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
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lstCandidates = New System.Windows.Forms.ListBox()
        Me.lstVotes = New System.Windows.Forms.ListBox()
        Me.btnNominate = New System.Windows.Forms.Button()
        Me.btnVote = New System.Windows.Forms.Button()
        Me.btnTally = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(13, 13)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(389, 40)
        Me.lblInstructions.TabIndex = 0
        Me.lblInstructions.Text = "Click ""Nominate Candidate"" to enter a candidate. or" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """Start Voting"" to end nomina" &
    "tions and start the voting."
        '
        'lstCandidates
        '
        Me.lstCandidates.FormattingEnabled = True
        Me.lstCandidates.ItemHeight = 20
        Me.lstCandidates.Location = New System.Drawing.Point(17, 87)
        Me.lstCandidates.Name = "lstCandidates"
        Me.lstCandidates.Size = New System.Drawing.Size(246, 164)
        Me.lstCandidates.TabIndex = 1
        '
        'lstVotes
        '
        Me.lstVotes.FormattingEnabled = True
        Me.lstVotes.ItemHeight = 20
        Me.lstVotes.Location = New System.Drawing.Point(291, 87)
        Me.lstVotes.Name = "lstVotes"
        Me.lstVotes.Size = New System.Drawing.Size(120, 164)
        Me.lstVotes.TabIndex = 2
        '
        'btnNominate
        '
        Me.btnNominate.Location = New System.Drawing.Point(17, 304)
        Me.btnNominate.Name = "btnNominate"
        Me.btnNominate.Size = New System.Drawing.Size(115, 94)
        Me.btnNominate.TabIndex = 3
        Me.btnNominate.Text = "Nominate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Candidate"
        Me.btnNominate.UseVisualStyleBackColor = True
        '
        'btnVote
        '
        Me.btnVote.Location = New System.Drawing.Point(161, 304)
        Me.btnVote.Name = "btnVote"
        Me.btnVote.Size = New System.Drawing.Size(102, 94)
        Me.btnVote.TabIndex = 4
        Me.btnVote.Text = "Start Voting"
        Me.btnVote.UseVisualStyleBackColor = True
        '
        'btnTally
        '
        Me.btnTally.Location = New System.Drawing.Point(291, 304)
        Me.btnTally.Name = "btnTally"
        Me.btnTally.Size = New System.Drawing.Size(111, 94)
        Me.btnTally.TabIndex = 5
        Me.btnTally.Text = "Tally Votes"
        Me.btnTally.UseVisualStyleBackColor = True
        '
        'frmVotingMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 424)
        Me.Controls.Add(Me.btnTally)
        Me.Controls.Add(Me.btnVote)
        Me.Controls.Add(Me.btnNominate)
        Me.Controls.Add(Me.lstVotes)
        Me.Controls.Add(Me.lstCandidates)
        Me.Controls.Add(Me.lblInstructions)
        Me.Name = "frmVotingMachine"
        Me.Text = "Voting Machine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstructions As Label
    Friend WithEvents lstCandidates As ListBox
    Friend WithEvents lstVotes As ListBox
    Friend WithEvents btnNominate As Button
    Friend WithEvents btnVote As Button
    Friend WithEvents btnTally As Button
End Class
