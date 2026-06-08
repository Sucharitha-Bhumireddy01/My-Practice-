<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusinessTravelExpenses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusinessTravelExpenses))
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.txtOrg = New System.Windows.Forms.TextBox()
        Me.txtPlace = New System.Windows.Forms.TextBox()
        Me.txtDates = New System.Windows.Forms.TextBox()
        Me.txtTaxi = New System.Windows.Forms.TextBox()
        Me.txtMealsEnt = New System.Windows.Forms.TextBox()
        Me.txtAirFare = New System.Windows.Forms.TextBox()
        Me.txtLodging = New System.Windows.Forms.TextBox()
        Me.lblTaxi = New System.Windows.Forms.Label()
        Me.lblLodging = New System.Windows.Forms.Label()
        Me.lblAirfare = New System.Windows.Forms.Label()
        Me.lblMealsEnt = New System.Windows.Forms.Label()
        Me.lblPlace = New System.Windows.Forms.Label()
        Me.lblDates = New System.Windows.Forms.Label()
        Me.lblOrg = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.SuspendLayout()
        '
        'btnPreview
        '
        Me.btnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.Location = New System.Drawing.Point(94, 370)
        Me.btnPreview.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(374, 55)
        Me.btnPreview.TabIndex = 48
        Me.btnPreview.Text = "Preview Business Travel Expenses Attachment"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'txtOrg
        '
        Me.txtOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrg.Location = New System.Drawing.Point(260, 34)
        Me.txtOrg.Margin = New System.Windows.Forms.Padding(6)
        Me.txtOrg.Name = "txtOrg"
        Me.txtOrg.Size = New System.Drawing.Size(139, 26)
        Me.txtOrg.TabIndex = 34
        '
        'txtPlace
        '
        Me.txtPlace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlace.Location = New System.Drawing.Point(262, 108)
        Me.txtPlace.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPlace.Name = "txtPlace"
        Me.txtPlace.Size = New System.Drawing.Size(139, 26)
        Me.txtPlace.TabIndex = 38
        '
        'txtDates
        '
        Me.txtDates.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDates.Location = New System.Drawing.Point(260, 67)
        Me.txtDates.Margin = New System.Windows.Forms.Padding(6)
        Me.txtDates.Name = "txtDates"
        Me.txtDates.Size = New System.Drawing.Size(139, 26)
        Me.txtDates.TabIndex = 36
        '
        'txtTaxi
        '
        Me.txtTaxi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaxi.Location = New System.Drawing.Point(262, 272)
        Me.txtTaxi.Margin = New System.Windows.Forms.Padding(6)
        Me.txtTaxi.Name = "txtTaxi"
        Me.txtTaxi.Size = New System.Drawing.Size(139, 26)
        Me.txtTaxi.TabIndex = 46
        '
        'txtMealsEnt
        '
        Me.txtMealsEnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMealsEnt.Location = New System.Drawing.Point(262, 150)
        Me.txtMealsEnt.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMealsEnt.Name = "txtMealsEnt"
        Me.txtMealsEnt.Size = New System.Drawing.Size(139, 26)
        Me.txtMealsEnt.TabIndex = 40
        '
        'txtAirFare
        '
        Me.txtAirFare.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAirFare.Location = New System.Drawing.Point(262, 191)
        Me.txtAirFare.Margin = New System.Windows.Forms.Padding(6)
        Me.txtAirFare.Name = "txtAirFare"
        Me.txtAirFare.Size = New System.Drawing.Size(139, 26)
        Me.txtAirFare.TabIndex = 42
        '
        'txtLodging
        '
        Me.txtLodging.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLodging.Location = New System.Drawing.Point(260, 234)
        Me.txtLodging.Margin = New System.Windows.Forms.Padding(6)
        Me.txtLodging.Name = "txtLodging"
        Me.txtLodging.Size = New System.Drawing.Size(139, 26)
        Me.txtLodging.TabIndex = 44
        '
        'lblTaxi
        '
        Me.lblTaxi.AutoSize = True
        Me.lblTaxi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxi.Location = New System.Drawing.Point(164, 272)
        Me.lblTaxi.Margin = New System.Windows.Forms.Padding(8, 6, 4, 6)
        Me.lblTaxi.Name = "lblTaxi"
        Me.lblTaxi.Size = New System.Drawing.Size(88, 20)
        Me.lblTaxi.TabIndex = 45
        Me.lblTaxi.Text = "Taxi fares:"
        '
        'lblLodging
        '
        Me.lblLodging.AutoSize = True
        Me.lblLodging.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLodging.Location = New System.Drawing.Point(179, 240)
        Me.lblLodging.Margin = New System.Windows.Forms.Padding(8, 6, 4, 6)
        Me.lblLodging.Name = "lblLodging"
        Me.lblLodging.Size = New System.Drawing.Size(73, 20)
        Me.lblLodging.TabIndex = 43
        Me.lblLodging.Text = "Lodging:"
        '
        'lblAirfare
        '
        Me.lblAirfare.AutoSize = True
        Me.lblAirfare.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAirfare.Location = New System.Drawing.Point(143, 197)
        Me.lblAirfare.Margin = New System.Windows.Forms.Padding(8, 6, 4, 6)
        Me.lblAirfare.Name = "lblAirfare"
        Me.lblAirfare.Size = New System.Drawing.Size(109, 20)
        Me.lblAirfare.TabIndex = 41
        Me.lblAirfare.Text = "Airplane fare:"
        '
        'lblMealsEnt
        '
        Me.lblMealsEnt.AutoSize = True
        Me.lblMealsEnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMealsEnt.Location = New System.Drawing.Point(54, 150)
        Me.lblMealsEnt.Margin = New System.Windows.Forms.Padding(8, 6, 4, 6)
        Me.lblMealsEnt.Name = "lblMealsEnt"
        Me.lblMealsEnt.Size = New System.Drawing.Size(198, 20)
        Me.lblMealsEnt.TabIndex = 39
        Me.lblMealsEnt.Text = "Meals and entertainment:"
        '
        'lblPlace
        '
        Me.lblPlace.AutoSize = True
        Me.lblPlace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlace.Location = New System.Drawing.Point(174, 108)
        Me.lblPlace.Margin = New System.Windows.Forms.Padding(8, 6, 4, 6)
        Me.lblPlace.Name = "lblPlace"
        Me.lblPlace.Size = New System.Drawing.Size(78, 20)
        Me.lblPlace.TabIndex = 37
        Me.lblPlace.Text = "Location:"
        '
        'lblDates
        '
        Me.lblDates.AutoSize = True
        Me.lblDates.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDates.Location = New System.Drawing.Point(193, 67)
        Me.lblDates.Margin = New System.Windows.Forms.Padding(8, 6, 2, 6)
        Me.lblDates.Name = "lblDates"
        Me.lblDates.Size = New System.Drawing.Size(59, 20)
        Me.lblDates.TabIndex = 35
        Me.lblDates.Text = "Dates:"
        '
        'lblOrg
        '
        Me.lblOrg.AutoSize = True
        Me.lblOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrg.Location = New System.Drawing.Point(90, 34)
        Me.lblOrg.Margin = New System.Windows.Forms.Padding(8, 6, 2, 6)
        Me.lblOrg.Name = "lblOrg"
        Me.lblOrg.Size = New System.Drawing.Size(162, 20)
        Me.lblOrg.TabIndex = 33
        Me.lblOrg.Text = "Organization visited:"
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(94, 304)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(374, 55)
        Me.btnPrint.TabIndex = 47
        Me.btnPrint.Text = "Print Business Travel Expenses Attachment"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'frmBusinessTravelExpenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 450)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.txtOrg)
        Me.Controls.Add(Me.txtPlace)
        Me.Controls.Add(Me.txtDates)
        Me.Controls.Add(Me.txtTaxi)
        Me.Controls.Add(Me.txtMealsEnt)
        Me.Controls.Add(Me.txtAirFare)
        Me.Controls.Add(Me.txtLodging)
        Me.Controls.Add(Me.lblTaxi)
        Me.Controls.Add(Me.lblLodging)
        Me.Controls.Add(Me.lblAirfare)
        Me.Controls.Add(Me.lblMealsEnt)
        Me.Controls.Add(Me.lblPlace)
        Me.Controls.Add(Me.lblDates)
        Me.Controls.Add(Me.lblOrg)
        Me.Controls.Add(Me.btnPrint)
        Me.Name = "frmBusinessTravelExpenses"
        Me.Text = "Business Travel Expenses"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPreview As Button
    Friend WithEvents txtOrg As TextBox
    Friend WithEvents txtPlace As TextBox
    Friend WithEvents txtDates As TextBox
    Friend WithEvents txtTaxi As TextBox
    Friend WithEvents txtMealsEnt As TextBox
    Friend WithEvents txtAirFare As TextBox
    Friend WithEvents txtLodging As TextBox
    Friend WithEvents lblTaxi As Label
    Friend WithEvents lblLodging As Label
    Friend WithEvents lblAirfare As Label
    Friend WithEvents lblMealsEnt As Label
    Friend WithEvents lblPlace As Label
    Friend WithEvents lblDates As Label
    Friend WithEvents lblOrg As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
