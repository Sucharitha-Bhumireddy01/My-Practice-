<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAirlineReservation
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
        Me.mtbSeatCol = New System.Windows.Forms.MaskedTextBox()
        Me.mtbSeatRow = New System.Windows.Forms.MaskedTextBox()
        Me.lstWaitingList = New System.Windows.Forms.ListBox()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'mtbSeatCol
        '
        Me.mtbSeatCol.Location = New System.Drawing.Point(471, 73)
        Me.mtbSeatCol.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtbSeatCol.Mask = "L"
        Me.mtbSeatCol.Name = "mtbSeatCol"
        Me.mtbSeatCol.Size = New System.Drawing.Size(28, 26)
        Me.mtbSeatCol.TabIndex = 27
        '
        'mtbSeatRow
        '
        Me.mtbSeatRow.Location = New System.Drawing.Point(430, 73)
        Me.mtbSeatRow.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtbSeatRow.Mask = "##"
        Me.mtbSeatRow.Name = "mtbSeatRow"
        Me.mtbSeatRow.Size = New System.Drawing.Size(30, 26)
        Me.mtbSeatRow.TabIndex = 25
        '
        'lstWaitingList
        '
        Me.lstWaitingList.Enabled = False
        Me.lstWaitingList.FormattingEnabled = True
        Me.lstWaitingList.ItemHeight = 20
        Me.lstWaitingList.Location = New System.Drawing.Point(129, 279)
        Me.lstWaitingList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstWaitingList.Name = "lstWaitingList"
        Me.lstWaitingList.Size = New System.Drawing.Size(178, 104)
        Me.lstWaitingList.TabIndex = 34
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 20
        Me.lstOutput.Location = New System.Drawing.Point(361, 159)
        Me.lstOutput.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(138, 224)
        Me.lstOutput.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(327, 118)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 20)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "(1A, 1B, 1C, 2A, 2B,...10D)"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(133, 68)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(148, 26)
        Me.txtName.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(155, 255)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Waiting List"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(129, 204)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(158, 35)
        Me.btnQuit.TabIndex = 31
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(129, 159)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(158, 35)
        Me.btnDelete.TabIndex = 29
        Me.btnDelete.Text = "Delete Passenger"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(129, 115)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(158, 35)
        Me.btnAdd.TabIndex = 28
        Me.btnAdd.Text = "Add Passenger"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(373, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Seat:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 73)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Name:"
        '
        'frmAirlineReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 450)
        Me.Controls.Add(Me.mtbSeatCol)
        Me.Controls.Add(Me.mtbSeatRow)
        Me.Controls.Add(Me.lstWaitingList)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAirlineReservation"
        Me.Text = "Airline Reservation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mtbSeatCol As MaskedTextBox
    Friend WithEvents mtbSeatRow As MaskedTextBox
    Friend WithEvents lstWaitingList As ListBox
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
