<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBinarySearch
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lbl1st2letters = New System.Windows.Forms.Label()
        Me.lblStates = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.lstStates = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(235, 176)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(186, 48)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Search For State"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lbl1st2letters
        '
        Me.lbl1st2letters.AutoSize = True
        Me.lbl1st2letters.Location = New System.Drawing.Point(221, 80)
        Me.lbl1st2letters.Name = "lbl1st2letters"
        Me.lbl1st2letters.Size = New System.Drawing.Size(117, 40)
        Me.lbl1st2letters.TabIndex = 1
        Me.lbl1st2letters.Text = "First two letters" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of state:"
        '
        'lblStates
        '
        Me.lblStates.AutoSize = True
        Me.lblStates.Location = New System.Drawing.Point(47, 37)
        Me.lblStates.Name = "lblStates"
        Me.lblStates.Size = New System.Drawing.Size(60, 20)
        Me.lblStates.TabIndex = 2
        Me.lblStates.Text = "States:"
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(365, 80)
        Me.txtInput.MaxLength = 2
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(56, 40)
        Me.txtInput.TabIndex = 3
        '
        'txtOutput
        '
        Me.txtOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(145, 317)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(235, 32)
        Me.txtOutput.TabIndex = 4
        '
        'lstStates
        '
        Me.lstStates.FormattingEnabled = True
        Me.lstStates.ItemHeight = 20
        Me.lstStates.Items.AddRange(New Object() {"Andhra Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Arunachal Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Assam" & Global.Microsoft.VisualBasic.ChrW(9), "Bihar" & Global.Microsoft.VisualBasic.ChrW(9), "Chhattisgarh" & Global.Microsoft.VisualBasic.ChrW(9), "Goa" & Global.Microsoft.VisualBasic.ChrW(9), "Gujarat" & Global.Microsoft.VisualBasic.ChrW(9), "Haryana" & Global.Microsoft.VisualBasic.ChrW(9), "Himachal Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Jharkhand" & Global.Microsoft.VisualBasic.ChrW(9), "Karnataka" & Global.Microsoft.VisualBasic.ChrW(9), "Kerala" & Global.Microsoft.VisualBasic.ChrW(9), "Madhya Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Maharashtra" & Global.Microsoft.VisualBasic.ChrW(9), "Manipur", "Meghalaya" & Global.Microsoft.VisualBasic.ChrW(9), "Mizoram", "Nagaland" & Global.Microsoft.VisualBasic.ChrW(9), "Odisha" & Global.Microsoft.VisualBasic.ChrW(9), "Punjab" & Global.Microsoft.VisualBasic.ChrW(9), "Rajasthan" & Global.Microsoft.VisualBasic.ChrW(9), "Sikkim" & Global.Microsoft.VisualBasic.ChrW(9), "Tamil Nadu" & Global.Microsoft.VisualBasic.ChrW(9), "Telangana" & Global.Microsoft.VisualBasic.ChrW(9), "Tripura" & Global.Microsoft.VisualBasic.ChrW(9), "Uttar Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Uttarakhand" & Global.Microsoft.VisualBasic.ChrW(9), "West Bengal" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.lstStates.Location = New System.Drawing.Point(51, 73)
        Me.lstStates.Name = "lstStates"
        Me.lstStates.Size = New System.Drawing.Size(120, 224)
        Me.lstStates.TabIndex = 5
        '
        'frmBinarySearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstStates)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblStates)
        Me.Controls.Add(Me.lbl1st2letters)
        Me.Controls.Add(Me.btnSearch)
        Me.Name = "frmBinarySearch"
        Me.Text = "Binary Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents lbl1st2letters As Label
    Friend WithEvents lblStates As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents lstStates As ListBox
End Class
