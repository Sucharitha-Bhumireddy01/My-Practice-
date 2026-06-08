<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCurveGrades
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
        Me.btnAnalyze = New System.Windows.Forms.Button()
        Me.txtNumOfExams = New System.Windows.Forms.TextBox()
        Me.txtMean = New System.Windows.Forms.TextBox()
        Me.txtStDev = New System.Windows.Forms.TextBox()
        Me.lblNumOfExams = New System.Windows.Forms.Label()
        Me.lblMean = New System.Windows.Forms.Label()
        Me.lblStDev = New System.Windows.Forms.Label()
        Me.grdScores = New System.Windows.Forms.DataGridView()
        CType(Me.grdScores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAnalyze
        '
        Me.btnAnalyze.Location = New System.Drawing.Point(12, 23)
        Me.btnAnalyze.Name = "btnAnalyze"
        Me.btnAnalyze.Size = New System.Drawing.Size(312, 65)
        Me.btnAnalyze.TabIndex = 0
        Me.btnAnalyze.Text = "Analyze Grades"
        Me.btnAnalyze.UseVisualStyleBackColor = True
        '
        'txtNumOfExams
        '
        Me.txtNumOfExams.Location = New System.Drawing.Point(171, 150)
        Me.txtNumOfExams.Name = "txtNumOfExams"
        Me.txtNumOfExams.Size = New System.Drawing.Size(100, 26)
        Me.txtNumOfExams.TabIndex = 1
        '
        'txtMean
        '
        Me.txtMean.Location = New System.Drawing.Point(171, 222)
        Me.txtMean.Name = "txtMean"
        Me.txtMean.ReadOnly = True
        Me.txtMean.Size = New System.Drawing.Size(100, 26)
        Me.txtMean.TabIndex = 2
        '
        'txtStDev
        '
        Me.txtStDev.Location = New System.Drawing.Point(171, 284)
        Me.txtStDev.Name = "txtStDev"
        Me.txtStDev.ReadOnly = True
        Me.txtStDev.Size = New System.Drawing.Size(100, 26)
        Me.txtStDev.TabIndex = 3
        '
        'lblNumOfExams
        '
        Me.lblNumOfExams.AutoSize = True
        Me.lblNumOfExams.Location = New System.Drawing.Point(8, 156)
        Me.lblNumOfExams.Name = "lblNumOfExams"
        Me.lblNumOfExams.Size = New System.Drawing.Size(139, 20)
        Me.lblNumOfExams.TabIndex = 4
        Me.lblNumOfExams.Text = "Number of Exams:"
        '
        'lblMean
        '
        Me.lblMean.AutoSize = True
        Me.lblMean.Location = New System.Drawing.Point(22, 225)
        Me.lblMean.Name = "lblMean"
        Me.lblMean.Size = New System.Drawing.Size(53, 20)
        Me.lblMean.TabIndex = 5
        Me.lblMean.Text = "Mean:"
        '
        'lblStDev
        '
        Me.lblStDev.AutoSize = True
        Me.lblStDev.Location = New System.Drawing.Point(8, 287)
        Me.lblStDev.Name = "lblStDev"
        Me.lblStDev.Size = New System.Drawing.Size(149, 20)
        Me.lblStDev.TabIndex = 6
        Me.lblStDev.Text = "Standard Deviation:"
        '
        'grdScores
        '
        Me.grdScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdScores.Location = New System.Drawing.Point(360, 23)
        Me.grdScores.Name = "grdScores"
        Me.grdScores.RowHeadersWidth = 62
        Me.grdScores.RowTemplate.Height = 28
        Me.grdScores.Size = New System.Drawing.Size(361, 380)
        Me.grdScores.TabIndex = 7
        '
        'frmCurveGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grdScores)
        Me.Controls.Add(Me.lblStDev)
        Me.Controls.Add(Me.lblMean)
        Me.Controls.Add(Me.lblNumOfExams)
        Me.Controls.Add(Me.txtStDev)
        Me.Controls.Add(Me.txtMean)
        Me.Controls.Add(Me.txtNumOfExams)
        Me.Controls.Add(Me.btnAnalyze)
        Me.Name = "frmCurveGrades"
        Me.Text = "Curve Grades"
        CType(Me.grdScores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAnalyze As Button
    Friend WithEvents txtNumOfExams As TextBox
    Friend WithEvents txtMean As TextBox
    Friend WithEvents txtStDev As TextBox
    Friend WithEvents lblNumOfExams As Label
    Friend WithEvents lblMean As Label
    Friend WithEvents lblStDev As Label
    Friend WithEvents grdScores As DataGridView
End Class
