<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtCreditHour = New System.Windows.Forms.TextBox()
        Me.txtGPA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbGrades = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnRecord
        '
        Me.btnRecord.Location = New System.Drawing.Point(202, 233)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(182, 56)
        Me.btnRecord.TabIndex = 0
        Me.btnRecord.Text = "Record This Course"
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(202, 315)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(182, 53)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Calculate GPA"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtCreditHour
        '
        Me.txtCreditHour.Location = New System.Drawing.Point(223, 151)
        Me.txtCreditHour.Name = "txtCreditHour"
        Me.txtCreditHour.Size = New System.Drawing.Size(129, 26)
        Me.txtCreditHour.TabIndex = 3
        '
        'txtGPA
        '
        Me.txtGPA.Location = New System.Drawing.Point(223, 401)
        Me.txtGPA.Name = "txtGPA"
        Me.txtGPA.Size = New System.Drawing.Size(129, 26)
        Me.txtGPA.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(141, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Grade"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Credit Hours"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(152, 404)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "GPA"
        '
        'cmbGrades
        '
        Me.cmbGrades.FormattingEnabled = True
        Me.cmbGrades.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F"})
        Me.cmbGrades.Location = New System.Drawing.Point(223, 90)
        Me.cmbGrades.Name = "cmbGrades"
        Me.cmbGrades.Size = New System.Drawing.Size(129, 28)
        Me.cmbGrades.TabIndex = 8
        Me.cmbGrades.Tag = ""
        Me.cmbGrades.Text = "Select Grade"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 507)
        Me.Controls.Add(Me.cmbGrades)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGPA)
        Me.Controls.Add(Me.txtCreditHour)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnRecord)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRecord As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtCreditHour As TextBox
    Friend WithEvents txtGPA As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbGrades As ComboBox
End Class
