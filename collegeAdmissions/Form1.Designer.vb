<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollegeAdmissions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCollegeAdmissions))
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGPAScore = New System.Windows.Forms.TextBox()
        Me.grpSAT = New System.Windows.Forms.GroupBox()
        Me.rad1360to1600 = New System.Windows.Forms.RadioButton()
        Me.rad1200to1350 = New System.Windows.Forms.RadioButton()
        Me.rad1010to1190 = New System.Windows.Forms.RadioButton()
        Me.rad930to1000 = New System.Windows.Forms.RadioButton()
        Me.rad400to920 = New System.Windows.Forms.RadioButton()
        Me.grpHighSchoolQuality = New System.Windows.Forms.GroupBox()
        Me.ard5 = New System.Windows.Forms.RadioButton()
        Me.rad4 = New System.Windows.Forms.RadioButton()
        Me.rad3 = New System.Windows.Forms.RadioButton()
        Me.rad2 = New System.Windows.Forms.RadioButton()
        Me.rad1 = New System.Windows.Forms.RadioButton()
        Me.rad0 = New System.Windows.Forms.RadioButton()
        Me.grpDifficultyofCurriculum = New System.Windows.Forms.GroupBox()
        Me.rad4Difficulty = New System.Windows.Forms.RadioButton()
        Me.rad3Difficulty = New System.Windows.Forms.RadioButton()
        Me.rad2Difficulty = New System.Windows.Forms.RadioButton()
        Me.rad1Difficulty = New System.Windows.Forms.RadioButton()
        Me.rad0Difficulty = New System.Windows.Forms.RadioButton()
        Me.radneg1Difficulty = New System.Windows.Forms.RadioButton()
        Me.radneg2Difficulty = New System.Windows.Forms.RadioButton()
        Me.grpGeography = New System.Windows.Forms.GroupBox()
        Me.chkUnderrepresentedState = New System.Windows.Forms.CheckBox()
        Me.chkUnderrepresentedStateCountry = New System.Windows.Forms.CheckBox()
        Me.chkStateResident = New System.Windows.Forms.CheckBox()
        Me.grpEssay = New System.Windows.Forms.GroupBox()
        Me.adOutstanding = New System.Windows.Forms.RadioButton()
        Me.radExcellent = New System.Windows.Forms.RadioButton()
        Me.radVeryGood = New System.Windows.Forms.RadioButton()
        Me.grpMiscellaneous = New System.Windows.Forms.GroupBox()
        Me.radProvotsdiscretion = New System.Windows.Forms.RadioButton()
        Me.radScholarshipAthlete = New System.Windows.Forms.RadioButton()
        Me.radMeninNursing = New System.Windows.Forms.RadioButton()
        Me.radSocioeconomicDisadvantage = New System.Windows.Forms.RadioButton()
        Me.grpAlumini = New System.Windows.Forms.GroupBox()
        Me.chkOthers = New System.Windows.Forms.CheckBox()
        Me.chkLegacy = New System.Windows.Forms.CheckBox()
        Me.grpLeardershipandService = New System.Windows.Forms.GroupBox()
        Me.chkNational = New System.Windows.Forms.CheckBox()
        Me.chkRegional = New System.Windows.Forms.CheckBox()
        Me.chkState = New System.Windows.Forms.CheckBox()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.lblMax40Points = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.grpSAT.SuspendLayout()
        Me.grpHighSchoolQuality.SuspendLayout()
        Me.grpDifficultyofCurriculum.SuspendLayout()
        Me.grpGeography.SuspendLayout()
        Me.grpEssay.SuspendLayout()
        Me.grpMiscellaneous.SuspendLayout()
        Me.grpAlumini.SuspendLayout()
        Me.grpLeardershipandService.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCalculate.FlatAppearance.BorderSize = 2
        Me.btnCalculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCalculate.Location = New System.Drawing.Point(881, 25)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(221, 74)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate Score"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(881, 145)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(221, 110)
        Me.txtOutput.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter GPA Score"
        '
        'txtGPAScore
        '
        Me.txtGPAScore.Location = New System.Drawing.Point(273, 25)
        Me.txtGPAScore.Multiline = True
        Me.txtGPAScore.Name = "txtGPAScore"
        Me.txtGPAScore.Size = New System.Drawing.Size(111, 47)
        Me.txtGPAScore.TabIndex = 3
        '
        'grpSAT
        '
        Me.grpSAT.Controls.Add(Me.rad1360to1600)
        Me.grpSAT.Controls.Add(Me.rad1200to1350)
        Me.grpSAT.Controls.Add(Me.rad1010to1190)
        Me.grpSAT.Controls.Add(Me.rad930to1000)
        Me.grpSAT.Controls.Add(Me.rad400to920)
        Me.grpSAT.Location = New System.Drawing.Point(12, 123)
        Me.grpSAT.Name = "grpSAT"
        Me.grpSAT.Size = New System.Drawing.Size(164, 208)
        Me.grpSAT.TabIndex = 4
        Me.grpSAT.TabStop = False
        Me.grpSAT.Text = "SAT"
        '
        'rad1360to1600
        '
        Me.rad1360to1600.AutoSize = True
        Me.rad1360to1600.Location = New System.Drawing.Point(6, 168)
        Me.rad1360to1600.Name = "rad1360to1600"
        Me.rad1360to1600.Size = New System.Drawing.Size(141, 24)
        Me.rad1360to1600.TabIndex = 4
        Me.rad1360to1600.TabStop = True
        Me.rad1360to1600.Tag = "12"
        Me.rad1360to1600.Text = "1360-1600 [12]"
        Me.rad1360to1600.UseVisualStyleBackColor = True
        '
        'rad1200to1350
        '
        Me.rad1200to1350.AutoSize = True
        Me.rad1200to1350.Location = New System.Drawing.Point(6, 138)
        Me.rad1200to1350.Name = "rad1200to1350"
        Me.rad1200to1350.Size = New System.Drawing.Size(141, 24)
        Me.rad1200to1350.TabIndex = 3
        Me.rad1200to1350.TabStop = True
        Me.rad1200to1350.Tag = "11"
        Me.rad1200to1350.Text = "1200-1350 [11]"
        Me.rad1200to1350.UseVisualStyleBackColor = True
        '
        'rad1010to1190
        '
        Me.rad1010to1190.AutoSize = True
        Me.rad1010to1190.Location = New System.Drawing.Point(6, 108)
        Me.rad1010to1190.Name = "rad1010to1190"
        Me.rad1010to1190.Size = New System.Drawing.Size(141, 24)
        Me.rad1010to1190.TabIndex = 2
        Me.rad1010to1190.TabStop = True
        Me.rad1010to1190.Tag = "10"
        Me.rad1010to1190.Text = "1010-1190 [10]"
        Me.rad1010to1190.UseVisualStyleBackColor = True
        '
        'rad930to1000
        '
        Me.rad930to1000.AutoSize = True
        Me.rad930to1000.Location = New System.Drawing.Point(6, 78)
        Me.rad930to1000.Name = "rad930to1000"
        Me.rad930to1000.Size = New System.Drawing.Size(123, 24)
        Me.rad930to1000.TabIndex = 1
        Me.rad930to1000.TabStop = True
        Me.rad930to1000.Tag = "6"
        Me.rad930to1000.Text = "930-1000 [6]"
        Me.rad930to1000.UseVisualStyleBackColor = True
        '
        'rad400to920
        '
        Me.rad400to920.AutoSize = True
        Me.rad400to920.Location = New System.Drawing.Point(6, 48)
        Me.rad400to920.Name = "rad400to920"
        Me.rad400to920.Size = New System.Drawing.Size(114, 24)
        Me.rad400to920.TabIndex = 0
        Me.rad400to920.TabStop = True
        Me.rad400to920.Tag = "0"
        Me.rad400to920.Text = "400-920 [0]"
        Me.rad400to920.UseVisualStyleBackColor = True
        '
        'grpHighSchoolQuality
        '
        Me.grpHighSchoolQuality.Controls.Add(Me.ard5)
        Me.grpHighSchoolQuality.Controls.Add(Me.rad4)
        Me.grpHighSchoolQuality.Controls.Add(Me.rad3)
        Me.grpHighSchoolQuality.Controls.Add(Me.rad2)
        Me.grpHighSchoolQuality.Controls.Add(Me.rad1)
        Me.grpHighSchoolQuality.Controls.Add(Me.rad0)
        Me.grpHighSchoolQuality.Location = New System.Drawing.Point(204, 132)
        Me.grpHighSchoolQuality.Name = "grpHighSchoolQuality"
        Me.grpHighSchoolQuality.Size = New System.Drawing.Size(279, 208)
        Me.grpHighSchoolQuality.TabIndex = 5
        Me.grpHighSchoolQuality.TabStop = False
        Me.grpHighSchoolQuality.Text = "High School Quality"
        '
        'ard5
        '
        Me.ard5.AutoSize = True
        Me.ard5.Location = New System.Drawing.Point(161, 121)
        Me.ard5.Name = "ard5"
        Me.ard5.Size = New System.Drawing.Size(73, 24)
        Me.ard5.TabIndex = 6
        Me.ard5.TabStop = True
        Me.ard5.Tag = "10"
        Me.ard5.Text = "5 [10]"
        Me.ard5.UseVisualStyleBackColor = True
        '
        'rad4
        '
        Me.rad4.AutoSize = True
        Me.rad4.Location = New System.Drawing.Point(161, 77)
        Me.rad4.Name = "rad4"
        Me.rad4.Size = New System.Drawing.Size(64, 24)
        Me.rad4.TabIndex = 5
        Me.rad4.TabStop = True
        Me.rad4.Tag = "8"
        Me.rad4.Text = "4 [8]"
        Me.rad4.UseVisualStyleBackColor = True
        '
        'rad3
        '
        Me.rad3.AutoSize = True
        Me.rad3.Location = New System.Drawing.Point(161, 40)
        Me.rad3.Name = "rad3"
        Me.rad3.Size = New System.Drawing.Size(64, 24)
        Me.rad3.TabIndex = 4
        Me.rad3.TabStop = True
        Me.rad3.Tag = "6"
        Me.rad3.Text = "3 [6]"
        Me.rad3.UseVisualStyleBackColor = True
        '
        'rad2
        '
        Me.rad2.AutoSize = True
        Me.rad2.Location = New System.Drawing.Point(15, 121)
        Me.rad2.Name = "rad2"
        Me.rad2.Size = New System.Drawing.Size(64, 24)
        Me.rad2.TabIndex = 3
        Me.rad2.TabStop = True
        Me.rad2.Tag = "4"
        Me.rad2.Text = "2 [4]"
        Me.rad2.UseVisualStyleBackColor = True
        '
        'rad1
        '
        Me.rad1.AutoSize = True
        Me.rad1.Location = New System.Drawing.Point(15, 77)
        Me.rad1.Name = "rad1"
        Me.rad1.Size = New System.Drawing.Size(64, 24)
        Me.rad1.TabIndex = 2
        Me.rad1.TabStop = True
        Me.rad1.Tag = "2"
        Me.rad1.Text = "1 [2]"
        Me.rad1.UseVisualStyleBackColor = True
        '
        'rad0
        '
        Me.rad0.AutoSize = True
        Me.rad0.Location = New System.Drawing.Point(15, 40)
        Me.rad0.Name = "rad0"
        Me.rad0.Size = New System.Drawing.Size(64, 24)
        Me.rad0.TabIndex = 1
        Me.rad0.TabStop = True
        Me.rad0.Tag = "0"
        Me.rad0.Text = "0 [0]"
        Me.rad0.UseVisualStyleBackColor = True
        '
        'grpDifficultyofCurriculum
        '
        Me.grpDifficultyofCurriculum.Controls.Add(Me.rad4Difficulty)
        Me.grpDifficultyofCurriculum.Controls.Add(Me.rad3Difficulty)
        Me.grpDifficultyofCurriculum.Controls.Add(Me.rad2Difficulty)
        Me.grpDifficultyofCurriculum.Controls.Add(Me.rad1Difficulty)
        Me.grpDifficultyofCurriculum.Controls.Add(Me.rad0Difficulty)
        Me.grpDifficultyofCurriculum.Controls.Add(Me.radneg1Difficulty)
        Me.grpDifficultyofCurriculum.Controls.Add(Me.radneg2Difficulty)
        Me.grpDifficultyofCurriculum.Location = New System.Drawing.Point(515, 132)
        Me.grpDifficultyofCurriculum.Name = "grpDifficultyofCurriculum"
        Me.grpDifficultyofCurriculum.Size = New System.Drawing.Size(310, 208)
        Me.grpDifficultyofCurriculum.TabIndex = 5
        Me.grpDifficultyofCurriculum.TabStop = False
        Me.grpDifficultyofCurriculum.Text = "Difficulty of Curriculum"
        '
        'rad4Difficulty
        '
        Me.rad4Difficulty.AutoSize = True
        Me.rad4Difficulty.Location = New System.Drawing.Point(155, 121)
        Me.rad4Difficulty.Name = "rad4Difficulty"
        Me.rad4Difficulty.Size = New System.Drawing.Size(64, 24)
        Me.rad4Difficulty.TabIndex = 7
        Me.rad4Difficulty.TabStop = True
        Me.rad4Difficulty.Tag = "8"
        Me.rad4Difficulty.Text = "4 [8]"
        Me.rad4Difficulty.UseVisualStyleBackColor = True
        '
        'rad3Difficulty
        '
        Me.rad3Difficulty.AutoSize = True
        Me.rad3Difficulty.Location = New System.Drawing.Point(154, 77)
        Me.rad3Difficulty.Name = "rad3Difficulty"
        Me.rad3Difficulty.Size = New System.Drawing.Size(64, 24)
        Me.rad3Difficulty.TabIndex = 6
        Me.rad3Difficulty.TabStop = True
        Me.rad3Difficulty.Tag = "6"
        Me.rad3Difficulty.Text = "3 [6]"
        Me.rad3Difficulty.UseVisualStyleBackColor = True
        '
        'rad2Difficulty
        '
        Me.rad2Difficulty.AutoSize = True
        Me.rad2Difficulty.Location = New System.Drawing.Point(154, 39)
        Me.rad2Difficulty.Name = "rad2Difficulty"
        Me.rad2Difficulty.Size = New System.Drawing.Size(64, 24)
        Me.rad2Difficulty.TabIndex = 5
        Me.rad2Difficulty.TabStop = True
        Me.rad2Difficulty.Tag = "4"
        Me.rad2Difficulty.Text = "2 [4]"
        Me.rad2Difficulty.UseVisualStyleBackColor = True
        '
        'rad1Difficulty
        '
        Me.rad1Difficulty.AutoSize = True
        Me.rad1Difficulty.Location = New System.Drawing.Point(6, 159)
        Me.rad1Difficulty.Name = "rad1Difficulty"
        Me.rad1Difficulty.Size = New System.Drawing.Size(64, 24)
        Me.rad1Difficulty.TabIndex = 4
        Me.rad1Difficulty.TabStop = True
        Me.rad1Difficulty.Tag = "2"
        Me.rad1Difficulty.Text = "1 [2]"
        Me.rad1Difficulty.UseVisualStyleBackColor = True
        '
        'rad0Difficulty
        '
        Me.rad0Difficulty.AutoSize = True
        Me.rad0Difficulty.Location = New System.Drawing.Point(6, 121)
        Me.rad0Difficulty.Name = "rad0Difficulty"
        Me.rad0Difficulty.Size = New System.Drawing.Size(64, 24)
        Me.rad0Difficulty.TabIndex = 3
        Me.rad0Difficulty.TabStop = True
        Me.rad0Difficulty.Tag = "0"
        Me.rad0Difficulty.Text = "0 [0]"
        Me.rad0Difficulty.UseVisualStyleBackColor = True
        '
        'radneg1Difficulty
        '
        Me.radneg1Difficulty.AutoSize = True
        Me.radneg1Difficulty.Location = New System.Drawing.Point(6, 77)
        Me.radneg1Difficulty.Name = "radneg1Difficulty"
        Me.radneg1Difficulty.Size = New System.Drawing.Size(74, 24)
        Me.radneg1Difficulty.TabIndex = 2
        Me.radneg1Difficulty.TabStop = True
        Me.radneg1Difficulty.Tag = "-2"
        Me.radneg1Difficulty.Text = "-1 [-2]"
        Me.radneg1Difficulty.UseVisualStyleBackColor = True
        '
        'radneg2Difficulty
        '
        Me.radneg2Difficulty.AutoSize = True
        Me.radneg2Difficulty.Location = New System.Drawing.Point(6, 40)
        Me.radneg2Difficulty.Name = "radneg2Difficulty"
        Me.radneg2Difficulty.Size = New System.Drawing.Size(74, 24)
        Me.radneg2Difficulty.TabIndex = 1
        Me.radneg2Difficulty.TabStop = True
        Me.radneg2Difficulty.Tag = "-4"
        Me.radneg2Difficulty.Text = "-2 [-4]"
        Me.radneg2Difficulty.UseVisualStyleBackColor = True
        '
        'grpGeography
        '
        Me.grpGeography.Controls.Add(Me.chkUnderrepresentedState)
        Me.grpGeography.Controls.Add(Me.chkUnderrepresentedStateCountry)
        Me.grpGeography.Controls.Add(Me.chkStateResident)
        Me.grpGeography.Location = New System.Drawing.Point(26, 498)
        Me.grpGeography.Name = "grpGeography"
        Me.grpGeography.Size = New System.Drawing.Size(311, 208)
        Me.grpGeography.TabIndex = 5
        Me.grpGeography.TabStop = False
        Me.grpGeography.Text = "Geography"
        '
        'chkUnderrepresentedState
        '
        Me.chkUnderrepresentedState.AutoSize = True
        Me.chkUnderrepresentedState.Location = New System.Drawing.Point(15, 143)
        Me.chkUnderrepresentedState.Name = "chkUnderrepresentedState"
        Me.chkUnderrepresentedState.Size = New System.Drawing.Size(229, 24)
        Me.chkUnderrepresentedState.TabIndex = 2
        Me.chkUnderrepresentedState.Tag = "2"
        Me.chkUnderrepresentedState.Text = "Underrepresented State [2]"
        Me.chkUnderrepresentedState.UseVisualStyleBackColor = True
        '
        'chkUnderrepresentedStateCountry
        '
        Me.chkUnderrepresentedStateCountry.AutoSize = True
        Me.chkUnderrepresentedStateCountry.Location = New System.Drawing.Point(15, 99)
        Me.chkUnderrepresentedStateCountry.Name = "chkUnderrepresentedStateCountry"
        Me.chkUnderrepresentedStateCountry.Size = New System.Drawing.Size(292, 24)
        Me.chkUnderrepresentedStateCountry.TabIndex = 1
        Me.chkUnderrepresentedStateCountry.Tag = "6"
        Me.chkUnderrepresentedStateCountry.Text = "Underrepresemted State Country [6]"
        Me.chkUnderrepresentedStateCountry.UseVisualStyleBackColor = True
        '
        'chkStateResident
        '
        Me.chkStateResident.AutoSize = True
        Me.chkStateResident.Location = New System.Drawing.Point(15, 54)
        Me.chkStateResident.Name = "chkStateResident"
        Me.chkStateResident.Size = New System.Drawing.Size(228, 24)
        Me.chkStateResident.TabIndex = 0
        Me.chkStateResident.Tag = "10"
        Me.chkStateResident.Text = "CheckBState Resident [10]"
        Me.chkStateResident.UseVisualStyleBackColor = True
        '
        'grpEssay
        '
        Me.grpEssay.Controls.Add(Me.adOutstanding)
        Me.grpEssay.Controls.Add(Me.radExcellent)
        Me.grpEssay.Controls.Add(Me.radVeryGood)
        Me.grpEssay.Location = New System.Drawing.Point(365, 507)
        Me.grpEssay.Name = "grpEssay"
        Me.grpEssay.Size = New System.Drawing.Size(245, 219)
        Me.grpEssay.TabIndex = 6
        Me.grpEssay.TabStop = False
        Me.grpEssay.Text = "Essay"
        '
        'adOutstanding
        '
        Me.adOutstanding.AutoSize = True
        Me.adOutstanding.Location = New System.Drawing.Point(6, 165)
        Me.adOutstanding.Name = "adOutstanding"
        Me.adOutstanding.Size = New System.Drawing.Size(142, 24)
        Me.adOutstanding.TabIndex = 3
        Me.adOutstanding.TabStop = True
        Me.adOutstanding.Tag = "3"
        Me.adOutstanding.Text = "Outstanding [3]"
        Me.adOutstanding.UseVisualStyleBackColor = True
        '
        'radExcellent
        '
        Me.radExcellent.AutoSize = True
        Me.radExcellent.Location = New System.Drawing.Point(6, 108)
        Me.radExcellent.Name = "radExcellent"
        Me.radExcellent.Size = New System.Drawing.Size(119, 24)
        Me.radExcellent.TabIndex = 2
        Me.radExcellent.TabStop = True
        Me.radExcellent.Tag = "2"
        Me.radExcellent.Text = "Excellent [2]"
        Me.radExcellent.UseVisualStyleBackColor = True
        '
        'radVeryGood
        '
        Me.radVeryGood.AutoSize = True
        Me.radVeryGood.Location = New System.Drawing.Point(6, 45)
        Me.radVeryGood.Name = "radVeryGood"
        Me.radVeryGood.Size = New System.Drawing.Size(131, 24)
        Me.radVeryGood.TabIndex = 1
        Me.radVeryGood.TabStop = True
        Me.radVeryGood.Tag = "1"
        Me.radVeryGood.Text = "Very Good [1]"
        Me.radVeryGood.UseVisualStyleBackColor = True
        '
        'grpMiscellaneous
        '
        Me.grpMiscellaneous.Controls.Add(Me.radProvotsdiscretion)
        Me.grpMiscellaneous.Controls.Add(Me.radScholarshipAthlete)
        Me.grpMiscellaneous.Controls.Add(Me.radMeninNursing)
        Me.grpMiscellaneous.Controls.Add(Me.radSocioeconomicDisadvantage)
        Me.grpMiscellaneous.Location = New System.Drawing.Point(643, 516)
        Me.grpMiscellaneous.Name = "grpMiscellaneous"
        Me.grpMiscellaneous.Size = New System.Drawing.Size(318, 460)
        Me.grpMiscellaneous.TabIndex = 5
        Me.grpMiscellaneous.TabStop = False
        Me.grpMiscellaneous.Text = "Miscellaneous"
        '
        'radProvotsdiscretion
        '
        Me.radProvotsdiscretion.AutoSize = True
        Me.radProvotsdiscretion.Location = New System.Drawing.Point(20, 304)
        Me.radProvotsdiscretion.Name = "radProvotsdiscretion"
        Me.radProvotsdiscretion.Size = New System.Drawing.Size(188, 24)
        Me.radProvotsdiscretion.TabIndex = 4
        Me.radProvotsdiscretion.TabStop = True
        Me.radProvotsdiscretion.Tag = "20"
        Me.radProvotsdiscretion.Text = "Provot's discretion[20]"
        Me.radProvotsdiscretion.UseVisualStyleBackColor = True
        '
        'radScholarshipAthlete
        '
        Me.radScholarshipAthlete.AutoSize = True
        Me.radScholarshipAthlete.Location = New System.Drawing.Point(20, 215)
        Me.radScholarshipAthlete.Name = "radScholarshipAthlete"
        Me.radScholarshipAthlete.Size = New System.Drawing.Size(202, 24)
        Me.radScholarshipAthlete.TabIndex = 3
        Me.radScholarshipAthlete.TabStop = True
        Me.radScholarshipAthlete.Tag = "20"
        Me.radScholarshipAthlete.Text = "Scholarship Athlete [20]"
        Me.radScholarshipAthlete.UseVisualStyleBackColor = True
        '
        'radMeninNursing
        '
        Me.radMeninNursing.AutoSize = True
        Me.radMeninNursing.Location = New System.Drawing.Point(20, 134)
        Me.radMeninNursing.Name = "radMeninNursing"
        Me.radMeninNursing.Size = New System.Drawing.Size(160, 24)
        Me.radMeninNursing.TabIndex = 2
        Me.radMeninNursing.TabStop = True
        Me.radMeninNursing.Tag = "5"
        Me.radMeninNursing.Text = "Men in Nursing [5]"
        Me.radMeninNursing.UseVisualStyleBackColor = True
        '
        'radSocioeconomicDisadvantage
        '
        Me.radSocioeconomicDisadvantage.AutoSize = True
        Me.radSocioeconomicDisadvantage.Location = New System.Drawing.Point(20, 55)
        Me.radSocioeconomicDisadvantage.Name = "radSocioeconomicDisadvantage"
        Me.radSocioeconomicDisadvantage.Size = New System.Drawing.Size(283, 24)
        Me.radSocioeconomicDisadvantage.TabIndex = 1
        Me.radSocioeconomicDisadvantage.TabStop = True
        Me.radSocioeconomicDisadvantage.Tag = "20"
        Me.radSocioeconomicDisadvantage.Text = "Sociaoeconomic Disadvantage [20]"
        Me.radSocioeconomicDisadvantage.UseVisualStyleBackColor = True
        '
        'grpAlumini
        '
        Me.grpAlumini.Controls.Add(Me.chkOthers)
        Me.grpAlumini.Controls.Add(Me.chkLegacy)
        Me.grpAlumini.Location = New System.Drawing.Point(26, 768)
        Me.grpAlumini.Name = "grpAlumini"
        Me.grpAlumini.Size = New System.Drawing.Size(282, 208)
        Me.grpAlumini.TabIndex = 5
        Me.grpAlumini.TabStop = False
        Me.grpAlumini.Text = "Alumini"
        '
        'chkOthers
        '
        Me.chkOthers.AutoSize = True
        Me.chkOthers.Location = New System.Drawing.Point(8, 116)
        Me.chkOthers.Name = "chkOthers"
        Me.chkOthers.Size = New System.Drawing.Size(265, 24)
        Me.chkOthers.TabIndex = 2
        Me.chkOthers.Tag = "1"
        Me.chkOthers.Text = "Other (grandparents, siblings) [1]"
        Me.chkOthers.UseVisualStyleBackColor = True
        '
        'chkLegacy
        '
        Me.chkLegacy.AutoSize = True
        Me.chkLegacy.Location = New System.Drawing.Point(8, 55)
        Me.chkLegacy.Name = "chkLegacy"
        Me.chkLegacy.Size = New System.Drawing.Size(268, 24)
        Me.chkLegacy.TabIndex = 1
        Me.chkLegacy.Tag = "4"
        Me.chkLegacy.Text = "Legacy (parents, stepparents) [4]"
        Me.chkLegacy.UseVisualStyleBackColor = True
        '
        'grpLeardershipandService
        '
        Me.grpLeardershipandService.Controls.Add(Me.chkNational)
        Me.grpLeardershipandService.Controls.Add(Me.chkRegional)
        Me.grpLeardershipandService.Controls.Add(Me.chkState)
        Me.grpLeardershipandService.Location = New System.Drawing.Point(371, 768)
        Me.grpLeardershipandService.Name = "grpLeardershipandService"
        Me.grpLeardershipandService.Size = New System.Drawing.Size(200, 208)
        Me.grpLeardershipandService.TabIndex = 5
        Me.grpLeardershipandService.TabStop = False
        Me.grpLeardershipandService.Text = "Leadership and Service"
        '
        'chkNational
        '
        Me.chkNational.AutoSize = True
        Me.chkNational.Location = New System.Drawing.Point(18, 152)
        Me.chkNational.Name = "chkNational"
        Me.chkNational.Size = New System.Drawing.Size(114, 24)
        Me.chkNational.TabIndex = 3
        Me.chkNational.Tag = "3"
        Me.chkNational.Text = "National [3]"
        Me.chkNational.UseVisualStyleBackColor = True
        '
        'chkRegional
        '
        Me.chkRegional.AutoSize = True
        Me.chkRegional.Location = New System.Drawing.Point(18, 95)
        Me.chkRegional.Name = "chkRegional"
        Me.chkRegional.Size = New System.Drawing.Size(119, 24)
        Me.chkRegional.TabIndex = 2
        Me.chkRegional.Tag = "2"
        Me.chkRegional.Text = "Regional [2]"
        Me.chkRegional.UseVisualStyleBackColor = True
        '
        'chkState
        '
        Me.chkState.AutoSize = True
        Me.chkState.Location = New System.Drawing.Point(18, 43)
        Me.chkState.Name = "chkState"
        Me.chkState.Size = New System.Drawing.Size(95, 24)
        Me.chkState.TabIndex = 1
        Me.chkState.Tag = "1"
        Me.chkState.Text = "State [1]"
        Me.chkState.UseVisualStyleBackColor = True
        '
        'lblLine
        '
        Me.lblLine.AutoSize = True
        Me.lblLine.Location = New System.Drawing.Point(14, 374)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(1149, 20)
        Me.lblLine.TabIndex = 7
        Me.lblLine.Text = resources.GetString("lblLine.Text")
        '
        'lblMax40Points
        '
        Me.lblMax40Points.AutoSize = True
        Me.lblMax40Points.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMax40Points.Location = New System.Drawing.Point(351, 426)
        Me.lblMax40Points.Name = "lblMax40Points"
        Me.lblMax40Points.Size = New System.Drawing.Size(267, 29)
        Me.lblMax40Points.TabIndex = 8
        Me.lblMax40Points.Text = "Maximum of 40 Points"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(435, 25)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(78, 47)
        Me.TextBox1.TabIndex = 9
        '
        'frmCollegeAdmissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 1020)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblMax40Points)
        Me.Controls.Add(Me.lblLine)
        Me.Controls.Add(Me.grpLeardershipandService)
        Me.Controls.Add(Me.grpAlumini)
        Me.Controls.Add(Me.grpMiscellaneous)
        Me.Controls.Add(Me.grpEssay)
        Me.Controls.Add(Me.grpGeography)
        Me.Controls.Add(Me.grpDifficultyofCurriculum)
        Me.Controls.Add(Me.grpHighSchoolQuality)
        Me.Controls.Add(Me.grpSAT)
        Me.Controls.Add(Me.txtGPAScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frmCollegeAdmissions"
        Me.Text = "College Admissions"
        Me.grpSAT.ResumeLayout(False)
        Me.grpSAT.PerformLayout()
        Me.grpHighSchoolQuality.ResumeLayout(False)
        Me.grpHighSchoolQuality.PerformLayout()
        Me.grpDifficultyofCurriculum.ResumeLayout(False)
        Me.grpDifficultyofCurriculum.PerformLayout()
        Me.grpGeography.ResumeLayout(False)
        Me.grpGeography.PerformLayout()
        Me.grpEssay.ResumeLayout(False)
        Me.grpEssay.PerformLayout()
        Me.grpMiscellaneous.ResumeLayout(False)
        Me.grpMiscellaneous.PerformLayout()
        Me.grpAlumini.ResumeLayout(False)
        Me.grpAlumini.PerformLayout()
        Me.grpLeardershipandService.ResumeLayout(False)
        Me.grpLeardershipandService.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGPAScore As TextBox
    Friend WithEvents grpSAT As GroupBox
    Friend WithEvents grpHighSchoolQuality As GroupBox
    Friend WithEvents grpDifficultyofCurriculum As GroupBox
    Friend WithEvents grpGeography As GroupBox
    Friend WithEvents grpEssay As GroupBox
    Friend WithEvents grpMiscellaneous As GroupBox
    Friend WithEvents grpAlumini As GroupBox
    Friend WithEvents grpLeardershipandService As GroupBox
    Friend WithEvents rad1360to1600 As RadioButton
    Friend WithEvents rad1200to1350 As RadioButton
    Friend WithEvents rad1010to1190 As RadioButton
    Friend WithEvents rad930to1000 As RadioButton
    Friend WithEvents rad400to920 As RadioButton
    Friend WithEvents rad2 As RadioButton
    Friend WithEvents rad1 As RadioButton
    Friend WithEvents rad0 As RadioButton
    Friend WithEvents ard5 As RadioButton
    Friend WithEvents rad4 As RadioButton
    Friend WithEvents rad3 As RadioButton
    Friend WithEvents rad4Difficulty As RadioButton
    Friend WithEvents rad3Difficulty As RadioButton
    Friend WithEvents rad2Difficulty As RadioButton
    Friend WithEvents rad1Difficulty As RadioButton
    Friend WithEvents rad0Difficulty As RadioButton
    Friend WithEvents radneg1Difficulty As RadioButton
    Friend WithEvents radneg2Difficulty As RadioButton
    Friend WithEvents chkUnderrepresentedStateCountry As CheckBox
    Friend WithEvents chkStateResident As CheckBox
    Friend WithEvents adOutstanding As RadioButton
    Friend WithEvents radExcellent As RadioButton
    Friend WithEvents radVeryGood As RadioButton
    Friend WithEvents radProvotsdiscretion As RadioButton
    Friend WithEvents radScholarshipAthlete As RadioButton
    Friend WithEvents radMeninNursing As RadioButton
    Friend WithEvents radSocioeconomicDisadvantage As RadioButton
    Friend WithEvents chkUnderrepresentedState As CheckBox
    Friend WithEvents chkOthers As CheckBox
    Friend WithEvents chkLegacy As CheckBox
    Friend WithEvents chkNational As CheckBox
    Friend WithEvents chkRegional As CheckBox
    Friend WithEvents chkState As CheckBox
    Friend WithEvents lblLine As Label
    Friend WithEvents lblMax40Points As Label
    Friend WithEvents TextBox1 As TextBox
End Class
