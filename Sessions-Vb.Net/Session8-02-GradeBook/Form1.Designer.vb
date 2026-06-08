<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGradeBook
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dgvOutput = New System.Windows.Forms.DataGridView()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.GradebookDataSet = New Session8_02_GradeBook.GradebookDataSet()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GradesTableAdapter = New Session8_02_GradeBook.GradebookDataSetTableAdapters.GradesTableAdapter()
        Me.StudentsTableAdapter = New Session8_02_GradeBook.GradebookDataSetTableAdapters.StudentsTableAdapter()
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradebookDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvOutput
        '
        Me.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOutput.Location = New System.Drawing.Point(75, 144)
        Me.dgvOutput.Name = "dgvOutput"
        Me.dgvOutput.RowHeadersVisible = False
        Me.dgvOutput.RowHeadersWidth = 62
        Me.dgvOutput.RowTemplate.Height = 24
        Me.dgvOutput.Size = New System.Drawing.Size(373, 226)
        Me.dgvOutput.TabIndex = 31
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(120, 54)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(262, 61)
        Me.btnDisplay.TabIndex = 30
        Me.btnDisplay.Text = "Display Student Grades"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'GradebookDataSet
        '
        Me.GradebookDataSet.DataSetName = "GradebookDataSet"
        Me.GradebookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Students"
        Me.BindingSource1.DataSource = Me.GradebookDataSet
        '
        'GradesTableAdapter
        '
        Me.GradesTableAdapter.ClearBeforeFill = True
        '
        'StudentsTableAdapter
        '
        Me.StudentsTableAdapter.ClearBeforeFill = True
        '
        'frmGradeBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 450)
        Me.Controls.Add(Me.dgvOutput)
        Me.Controls.Add(Me.btnDisplay)
        Me.Name = "frmGradeBook"
        Me.Text = "Grade Book"
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradebookDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvOutput As DataGridView
    Friend WithEvents btnDisplay As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents GradebookDataSet As GradebookDataSet
    Friend WithEvents GradesTableAdapter As GradebookDataSetTableAdapters.GradesTableAdapter
    Friend WithEvents StudentsTableAdapter As GradebookDataSetTableAdapters.StudentsTableAdapter
End Class
