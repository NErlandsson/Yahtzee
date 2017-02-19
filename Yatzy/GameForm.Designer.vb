<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameForm))
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.picDie5 = New System.Windows.Forms.PictureBox()
        Me.picDie2 = New System.Windows.Forms.PictureBox()
        Me.picDie4 = New System.Windows.Forms.PictureBox()
        Me.picDie3 = New System.Windows.Forms.PictureBox()
        Me.picDie1 = New System.Windows.Forms.PictureBox()
        Me.btnAces = New System.Windows.Forms.Button()
        Me.lblAces = New System.Windows.Forms.Label()
        Me.lblAcesScore = New System.Windows.Forms.Label()
        Me.lblThreesScore = New System.Windows.Forms.Label()
        Me.lblThrees = New System.Windows.Forms.Label()
        Me.btnThrees = New System.Windows.Forms.Button()
        Me.lblTwosScore = New System.Windows.Forms.Label()
        Me.lblTwos = New System.Windows.Forms.Label()
        Me.btnTwos = New System.Windows.Forms.Button()
        Me.lblFoursScore = New System.Windows.Forms.Label()
        Me.lblFours = New System.Windows.Forms.Label()
        Me.btnFours = New System.Windows.Forms.Button()
        Me.lblFIvesScore = New System.Windows.Forms.Label()
        Me.lblFives = New System.Windows.Forms.Label()
        Me.btnFives = New System.Windows.Forms.Button()
        Me.lblSixesScore = New System.Windows.Forms.Label()
        Me.lblSixes = New System.Windows.Forms.Label()
        Me.btnSixes = New System.Windows.Forms.Button()
        Me.lblTotalUpPreScore = New System.Windows.Forms.Label()
        Me.lblTotalUpPre = New System.Windows.Forms.Label()
        Me.lblBonusUp = New System.Windows.Forms.Label()
        Me.lblBonusUpScore = New System.Windows.Forms.Label()
        Me.btn3Kind = New System.Windows.Forms.Button()
        Me.lbl3KindScore = New System.Windows.Forms.Label()
        Me.lblTotalUpPost = New System.Windows.Forms.Label()
        Me.lblTotalUpPostScore = New System.Windows.Forms.Label()
        Me.lbl3Kind = New System.Windows.Forms.Label()
        Me.grpboxUppSec = New System.Windows.Forms.GroupBox()
        Me.grpboxResults = New System.Windows.Forms.GroupBox()
        Me.lblGrandTotalScore = New System.Windows.Forms.Label()
        Me.grpboxLowSec = New System.Windows.Forms.GroupBox()
        Me.lblTotalLowScore = New System.Windows.Forms.Label()
        Me.lblTotalLow = New System.Windows.Forms.Label()
        Me.btnChance = New System.Windows.Forms.Button()
        Me.lblChanceScore = New System.Windows.Forms.Label()
        Me.lblChance = New System.Windows.Forms.Label()
        Me.btnYahtzee = New System.Windows.Forms.Button()
        Me.lblYahtzeeScore = New System.Windows.Forms.Label()
        Me.lblYahtzee = New System.Windows.Forms.Label()
        Me.btnLgStraight = New System.Windows.Forms.Button()
        Me.lblLgStraightScore = New System.Windows.Forms.Label()
        Me.lblLgStraight = New System.Windows.Forms.Label()
        Me.btnSmStraight = New System.Windows.Forms.Button()
        Me.lblSmStraightScore = New System.Windows.Forms.Label()
        Me.lblSmStraight = New System.Windows.Forms.Label()
        Me.btnFullHouse = New System.Windows.Forms.Button()
        Me.lblFullHouseScore = New System.Windows.Forms.Label()
        Me.lblFullHouse = New System.Windows.Forms.Label()
        Me.btn4Kind = New System.Windows.Forms.Button()
        Me.lbl4KindScore = New System.Windows.Forms.Label()
        Me.lbl4Kind = New System.Windows.Forms.Label()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.picHold1 = New System.Windows.Forms.PictureBox()
        Me.picHold2 = New System.Windows.Forms.PictureBox()
        Me.picHold3 = New System.Windows.Forms.PictureBox()
        Me.picHold4 = New System.Windows.Forms.PictureBox()
        Me.picHold5 = New System.Windows.Forms.PictureBox()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picDie5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDie2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDie4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDie3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDie1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpboxUppSec.SuspendLayout()
        Me.grpboxResults.SuspendLayout()
        Me.grpboxLowSec.SuspendLayout()
        CType(Me.picHold1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHold2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHold3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHold4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHold5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(154, 12)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(222, 71)
        Me.btnRoll.TabIndex = 1
        Me.btnRoll.Text = "Roll"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'picDie5
        '
        Me.picDie5.Location = New System.Drawing.Point(424, 129)
        Me.picDie5.Name = "picDie5"
        Me.picDie5.Size = New System.Drawing.Size(97, 97)
        Me.picDie5.TabIndex = 5
        Me.picDie5.TabStop = False
        '
        'picDie2
        '
        Me.picDie2.Location = New System.Drawing.Point(115, 129)
        Me.picDie2.Name = "picDie2"
        Me.picDie2.Size = New System.Drawing.Size(97, 97)
        Me.picDie2.TabIndex = 4
        Me.picDie2.TabStop = False
        '
        'picDie4
        '
        Me.picDie4.Location = New System.Drawing.Point(321, 129)
        Me.picDie4.Name = "picDie4"
        Me.picDie4.Size = New System.Drawing.Size(97, 97)
        Me.picDie4.TabIndex = 3
        Me.picDie4.TabStop = False
        '
        'picDie3
        '
        Me.picDie3.Location = New System.Drawing.Point(218, 129)
        Me.picDie3.Name = "picDie3"
        Me.picDie3.Size = New System.Drawing.Size(97, 97)
        Me.picDie3.TabIndex = 2
        Me.picDie3.TabStop = False
        '
        'picDie1
        '
        Me.picDie1.Location = New System.Drawing.Point(12, 129)
        Me.picDie1.Name = "picDie1"
        Me.picDie1.Size = New System.Drawing.Size(97, 97)
        Me.picDie1.TabIndex = 0
        Me.picDie1.TabStop = False
        '
        'btnAces
        '
        Me.btnAces.Enabled = False
        Me.btnAces.Location = New System.Drawing.Point(6, 19)
        Me.btnAces.Name = "btnAces"
        Me.btnAces.Size = New System.Drawing.Size(62, 23)
        Me.btnAces.TabIndex = 6
        Me.btnAces.UseVisualStyleBackColor = True
        '
        'lblAces
        '
        Me.lblAces.AutoSize = True
        Me.lblAces.Location = New System.Drawing.Point(100, 24)
        Me.lblAces.Name = "lblAces"
        Me.lblAces.Size = New System.Drawing.Size(43, 13)
        Me.lblAces.TabIndex = 7
        Me.lblAces.Text = "Aces ->"
        Me.toolTip.SetToolTip(Me.lblAces, "Add together all aces")
        '
        'lblAcesScore
        '
        Me.lblAcesScore.AllowDrop = True
        Me.lblAcesScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAcesScore.Location = New System.Drawing.Point(149, 19)
        Me.lblAcesScore.Name = "lblAcesScore"
        Me.lblAcesScore.Size = New System.Drawing.Size(33, 23)
        Me.lblAcesScore.TabIndex = 8
        Me.lblAcesScore.Text = "-"
        Me.lblAcesScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblThreesScore
        '
        Me.lblThreesScore.AllowDrop = True
        Me.lblThreesScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblThreesScore.Location = New System.Drawing.Point(149, 77)
        Me.lblThreesScore.Name = "lblThreesScore"
        Me.lblThreesScore.Size = New System.Drawing.Size(33, 23)
        Me.lblThreesScore.TabIndex = 11
        Me.lblThreesScore.Text = "-"
        Me.lblThreesScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblThrees
        '
        Me.lblThrees.AutoSize = True
        Me.lblThrees.Location = New System.Drawing.Point(91, 82)
        Me.lblThrees.Name = "lblThrees"
        Me.lblThrees.Size = New System.Drawing.Size(52, 13)
        Me.lblThrees.TabIndex = 10
        Me.lblThrees.Text = "Threes ->"
        Me.toolTip.SetToolTip(Me.lblThrees, "Add together all threes")
        '
        'btnThrees
        '
        Me.btnThrees.Enabled = False
        Me.btnThrees.Location = New System.Drawing.Point(6, 77)
        Me.btnThrees.Name = "btnThrees"
        Me.btnThrees.Size = New System.Drawing.Size(62, 23)
        Me.btnThrees.TabIndex = 9
        Me.btnThrees.UseVisualStyleBackColor = True
        '
        'lblTwosScore
        '
        Me.lblTwosScore.AllowDrop = True
        Me.lblTwosScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTwosScore.Location = New System.Drawing.Point(149, 48)
        Me.lblTwosScore.Name = "lblTwosScore"
        Me.lblTwosScore.Size = New System.Drawing.Size(33, 23)
        Me.lblTwosScore.TabIndex = 14
        Me.lblTwosScore.Text = "-"
        Me.lblTwosScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTwos
        '
        Me.lblTwos.AutoSize = True
        Me.lblTwos.Location = New System.Drawing.Point(98, 53)
        Me.lblTwos.Name = "lblTwos"
        Me.lblTwos.Size = New System.Drawing.Size(45, 13)
        Me.lblTwos.TabIndex = 13
        Me.lblTwos.Text = "Twos ->"
        Me.toolTip.SetToolTip(Me.lblTwos, "Add together all twos")
        '
        'btnTwos
        '
        Me.btnTwos.Enabled = False
        Me.btnTwos.Location = New System.Drawing.Point(6, 48)
        Me.btnTwos.Name = "btnTwos"
        Me.btnTwos.Size = New System.Drawing.Size(62, 23)
        Me.btnTwos.TabIndex = 12
        Me.btnTwos.UseVisualStyleBackColor = True
        '
        'lblFoursScore
        '
        Me.lblFoursScore.AllowDrop = True
        Me.lblFoursScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFoursScore.Location = New System.Drawing.Point(149, 106)
        Me.lblFoursScore.Name = "lblFoursScore"
        Me.lblFoursScore.Size = New System.Drawing.Size(33, 23)
        Me.lblFoursScore.TabIndex = 20
        Me.lblFoursScore.Text = "-"
        Me.lblFoursScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFours
        '
        Me.lblFours.AutoSize = True
        Me.lblFours.Location = New System.Drawing.Point(98, 111)
        Me.lblFours.Name = "lblFours"
        Me.lblFours.Size = New System.Drawing.Size(45, 13)
        Me.lblFours.TabIndex = 19
        Me.lblFours.Text = "Fours ->"
        Me.toolTip.SetToolTip(Me.lblFours, "Add together all fours")
        '
        'btnFours
        '
        Me.btnFours.Enabled = False
        Me.btnFours.Location = New System.Drawing.Point(6, 106)
        Me.btnFours.Name = "btnFours"
        Me.btnFours.Size = New System.Drawing.Size(62, 23)
        Me.btnFours.TabIndex = 18
        Me.btnFours.UseVisualStyleBackColor = True
        '
        'lblFIvesScore
        '
        Me.lblFIvesScore.AllowDrop = True
        Me.lblFIvesScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFIvesScore.Location = New System.Drawing.Point(149, 135)
        Me.lblFIvesScore.Name = "lblFIvesScore"
        Me.lblFIvesScore.Size = New System.Drawing.Size(33, 23)
        Me.lblFIvesScore.TabIndex = 17
        Me.lblFIvesScore.Text = "-"
        Me.lblFIvesScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFives
        '
        Me.lblFives.AutoSize = True
        Me.lblFives.Location = New System.Drawing.Point(99, 140)
        Me.lblFives.Name = "lblFives"
        Me.lblFives.Size = New System.Drawing.Size(44, 13)
        Me.lblFives.TabIndex = 16
        Me.lblFives.Text = "Fives ->"
        Me.toolTip.SetToolTip(Me.lblFives, "Add together all fives")
        '
        'btnFives
        '
        Me.btnFives.Enabled = False
        Me.btnFives.Location = New System.Drawing.Point(6, 135)
        Me.btnFives.Name = "btnFives"
        Me.btnFives.Size = New System.Drawing.Size(62, 23)
        Me.btnFives.TabIndex = 15
        Me.btnFives.UseVisualStyleBackColor = True
        '
        'lblSixesScore
        '
        Me.lblSixesScore.AllowDrop = True
        Me.lblSixesScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSixesScore.Location = New System.Drawing.Point(149, 164)
        Me.lblSixesScore.Name = "lblSixesScore"
        Me.lblSixesScore.Size = New System.Drawing.Size(33, 23)
        Me.lblSixesScore.TabIndex = 23
        Me.lblSixesScore.Text = "-"
        Me.lblSixesScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSixes
        '
        Me.lblSixes.AutoSize = True
        Me.lblSixes.Location = New System.Drawing.Point(99, 169)
        Me.lblSixes.Name = "lblSixes"
        Me.lblSixes.Size = New System.Drawing.Size(44, 13)
        Me.lblSixes.TabIndex = 22
        Me.lblSixes.Text = "Sixes ->"
        Me.toolTip.SetToolTip(Me.lblSixes, "Add together all sixes")
        '
        'btnSixes
        '
        Me.btnSixes.Enabled = False
        Me.btnSixes.Location = New System.Drawing.Point(6, 164)
        Me.btnSixes.Name = "btnSixes"
        Me.btnSixes.Size = New System.Drawing.Size(62, 23)
        Me.btnSixes.TabIndex = 21
        Me.btnSixes.UseVisualStyleBackColor = True
        '
        'lblTotalUpPreScore
        '
        Me.lblTotalUpPreScore.AllowDrop = True
        Me.lblTotalUpPreScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalUpPreScore.Location = New System.Drawing.Point(149, 193)
        Me.lblTotalUpPreScore.Name = "lblTotalUpPreScore"
        Me.lblTotalUpPreScore.Size = New System.Drawing.Size(33, 23)
        Me.lblTotalUpPreScore.TabIndex = 24
        Me.lblTotalUpPreScore.Text = "0"
        Me.lblTotalUpPreScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalUpPre
        '
        Me.lblTotalUpPre.AutoSize = True
        Me.lblTotalUpPre.Location = New System.Drawing.Point(109, 198)
        Me.lblTotalUpPre.Name = "lblTotalUpPre"
        Me.lblTotalUpPre.Size = New System.Drawing.Size(34, 13)
        Me.lblTotalUpPre.TabIndex = 25
        Me.lblTotalUpPre.Text = "Total:"
        Me.toolTip.SetToolTip(Me.lblTotalUpPre, "Total upper section before bonus")
        '
        'lblBonusUp
        '
        Me.lblBonusUp.AutoSize = True
        Me.lblBonusUp.Location = New System.Drawing.Point(103, 227)
        Me.lblBonusUp.Name = "lblBonusUp"
        Me.lblBonusUp.Size = New System.Drawing.Size(40, 13)
        Me.lblBonusUp.TabIndex = 27
        Me.lblBonusUp.Text = "Bonus:"
        Me.toolTip.SetToolTip(Me.lblBonusUp, "If total upper section is 63 or greater a 35p bonus is applied")
        '
        'lblBonusUpScore
        '
        Me.lblBonusUpScore.AllowDrop = True
        Me.lblBonusUpScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBonusUpScore.Location = New System.Drawing.Point(149, 222)
        Me.lblBonusUpScore.Name = "lblBonusUpScore"
        Me.lblBonusUpScore.Size = New System.Drawing.Size(33, 23)
        Me.lblBonusUpScore.TabIndex = 26
        Me.lblBonusUpScore.Text = "0"
        Me.lblBonusUpScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn3Kind
        '
        Me.btn3Kind.Enabled = False
        Me.btn3Kind.Location = New System.Drawing.Point(6, 19)
        Me.btn3Kind.Name = "btn3Kind"
        Me.btn3Kind.Size = New System.Drawing.Size(62, 23)
        Me.btn3Kind.TabIndex = 34
        Me.btn3Kind.UseVisualStyleBackColor = True
        '
        'lbl3KindScore
        '
        Me.lbl3KindScore.AllowDrop = True
        Me.lbl3KindScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl3KindScore.Location = New System.Drawing.Point(149, 19)
        Me.lbl3KindScore.Name = "lbl3KindScore"
        Me.lbl3KindScore.Size = New System.Drawing.Size(33, 23)
        Me.lbl3KindScore.TabIndex = 32
        Me.lbl3KindScore.Text = "-"
        Me.lbl3KindScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalUpPost
        '
        Me.lblTotalUpPost.AutoSize = True
        Me.lblTotalUpPost.Location = New System.Drawing.Point(109, 256)
        Me.lblTotalUpPost.Name = "lblTotalUpPost"
        Me.lblTotalUpPost.Size = New System.Drawing.Size(34, 13)
        Me.lblTotalUpPost.TabIndex = 31
        Me.lblTotalUpPost.Text = "Total:"
        Me.toolTip.SetToolTip(Me.lblTotalUpPost, "Total upper section with bonus")
        '
        'lblTotalUpPostScore
        '
        Me.lblTotalUpPostScore.AllowDrop = True
        Me.lblTotalUpPostScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalUpPostScore.Location = New System.Drawing.Point(149, 251)
        Me.lblTotalUpPostScore.Name = "lblTotalUpPostScore"
        Me.lblTotalUpPostScore.Size = New System.Drawing.Size(33, 23)
        Me.lblTotalUpPostScore.TabIndex = 30
        Me.lblTotalUpPostScore.Text = "0"
        Me.lblTotalUpPostScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl3Kind
        '
        Me.lbl3Kind.AutoSize = True
        Me.lbl3Kind.Location = New System.Drawing.Point(74, 24)
        Me.lbl3Kind.Name = "lbl3Kind"
        Me.lbl3Kind.Size = New System.Drawing.Size(69, 13)
        Me.lbl3Kind.TabIndex = 35
        Me.lbl3Kind.Text = "3 of a kind ->"
        Me.toolTip.SetToolTip(Me.lbl3Kind, "Add together 3 of the same kind")
        '
        'grpboxUppSec
        '
        Me.grpboxUppSec.Controls.Add(Me.btnAces)
        Me.grpboxUppSec.Controls.Add(Me.lblAces)
        Me.grpboxUppSec.Controls.Add(Me.lblAcesScore)
        Me.grpboxUppSec.Controls.Add(Me.btnThrees)
        Me.grpboxUppSec.Controls.Add(Me.lblThrees)
        Me.grpboxUppSec.Controls.Add(Me.lblTotalUpPost)
        Me.grpboxUppSec.Controls.Add(Me.lblThreesScore)
        Me.grpboxUppSec.Controls.Add(Me.lblTotalUpPostScore)
        Me.grpboxUppSec.Controls.Add(Me.btnTwos)
        Me.grpboxUppSec.Controls.Add(Me.lblTwos)
        Me.grpboxUppSec.Controls.Add(Me.lblTwosScore)
        Me.grpboxUppSec.Controls.Add(Me.lblBonusUp)
        Me.grpboxUppSec.Controls.Add(Me.btnFives)
        Me.grpboxUppSec.Controls.Add(Me.lblBonusUpScore)
        Me.grpboxUppSec.Controls.Add(Me.lblFives)
        Me.grpboxUppSec.Controls.Add(Me.lblTotalUpPre)
        Me.grpboxUppSec.Controls.Add(Me.lblFIvesScore)
        Me.grpboxUppSec.Controls.Add(Me.lblTotalUpPreScore)
        Me.grpboxUppSec.Controls.Add(Me.btnFours)
        Me.grpboxUppSec.Controls.Add(Me.lblSixesScore)
        Me.grpboxUppSec.Controls.Add(Me.lblFours)
        Me.grpboxUppSec.Controls.Add(Me.lblSixes)
        Me.grpboxUppSec.Controls.Add(Me.lblFoursScore)
        Me.grpboxUppSec.Controls.Add(Me.btnSixes)
        Me.grpboxUppSec.Location = New System.Drawing.Point(6, 19)
        Me.grpboxUppSec.Name = "grpboxUppSec"
        Me.grpboxUppSec.Size = New System.Drawing.Size(190, 281)
        Me.grpboxUppSec.TabIndex = 36
        Me.grpboxUppSec.TabStop = False
        Me.grpboxUppSec.Text = "Upper section"
        '
        'grpboxResults
        '
        Me.grpboxResults.Controls.Add(Me.lblGrandTotalScore)
        Me.grpboxResults.Controls.Add(Me.grpboxLowSec)
        Me.grpboxResults.Controls.Add(Me.lblGrandTotal)
        Me.grpboxResults.Controls.Add(Me.grpboxUppSec)
        Me.grpboxResults.Location = New System.Drawing.Point(527, 12)
        Me.grpboxResults.Name = "grpboxResults"
        Me.grpboxResults.Size = New System.Drawing.Size(398, 338)
        Me.grpboxResults.TabIndex = 37
        Me.grpboxResults.TabStop = False
        Me.grpboxResults.Text = "Results"
        '
        'lblGrandTotalScore
        '
        Me.lblGrandTotalScore.AllowDrop = True
        Me.lblGrandTotalScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrandTotalScore.Location = New System.Drawing.Point(337, 308)
        Me.lblGrandTotalScore.Name = "lblGrandTotalScore"
        Me.lblGrandTotalScore.Size = New System.Drawing.Size(47, 23)
        Me.lblGrandTotalScore.TabIndex = 60
        Me.lblGrandTotalScore.Text = "0"
        Me.lblGrandTotalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpboxLowSec
        '
        Me.grpboxLowSec.Controls.Add(Me.lblTotalLowScore)
        Me.grpboxLowSec.Controls.Add(Me.lblTotalLow)
        Me.grpboxLowSec.Controls.Add(Me.btnChance)
        Me.grpboxLowSec.Controls.Add(Me.lblChanceScore)
        Me.grpboxLowSec.Controls.Add(Me.lblChance)
        Me.grpboxLowSec.Controls.Add(Me.btnYahtzee)
        Me.grpboxLowSec.Controls.Add(Me.lblYahtzeeScore)
        Me.grpboxLowSec.Controls.Add(Me.lblYahtzee)
        Me.grpboxLowSec.Controls.Add(Me.btnLgStraight)
        Me.grpboxLowSec.Controls.Add(Me.lblLgStraightScore)
        Me.grpboxLowSec.Controls.Add(Me.lblLgStraight)
        Me.grpboxLowSec.Controls.Add(Me.btnSmStraight)
        Me.grpboxLowSec.Controls.Add(Me.lblSmStraightScore)
        Me.grpboxLowSec.Controls.Add(Me.lblSmStraight)
        Me.grpboxLowSec.Controls.Add(Me.btnFullHouse)
        Me.grpboxLowSec.Controls.Add(Me.lblFullHouseScore)
        Me.grpboxLowSec.Controls.Add(Me.lblFullHouse)
        Me.grpboxLowSec.Controls.Add(Me.btn4Kind)
        Me.grpboxLowSec.Controls.Add(Me.lbl4KindScore)
        Me.grpboxLowSec.Controls.Add(Me.lbl4Kind)
        Me.grpboxLowSec.Controls.Add(Me.btn3Kind)
        Me.grpboxLowSec.Controls.Add(Me.lbl3KindScore)
        Me.grpboxLowSec.Controls.Add(Me.lbl3Kind)
        Me.grpboxLowSec.Location = New System.Drawing.Point(202, 19)
        Me.grpboxLowSec.Name = "grpboxLowSec"
        Me.grpboxLowSec.Size = New System.Drawing.Size(190, 282)
        Me.grpboxLowSec.TabIndex = 38
        Me.grpboxLowSec.TabStop = False
        Me.grpboxLowSec.Text = "Lower section"
        '
        'lblTotalLowScore
        '
        Me.lblTotalLowScore.AllowDrop = True
        Me.lblTotalLowScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalLowScore.Location = New System.Drawing.Point(149, 251)
        Me.lblTotalLowScore.Name = "lblTotalLowScore"
        Me.lblTotalLowScore.Size = New System.Drawing.Size(33, 23)
        Me.lblTotalLowScore.TabIndex = 57
        Me.lblTotalLowScore.Text = "0"
        Me.lblTotalLowScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalLow
        '
        Me.lblTotalLow.AutoSize = True
        Me.lblTotalLow.Location = New System.Drawing.Point(109, 256)
        Me.lblTotalLow.Name = "lblTotalLow"
        Me.lblTotalLow.Size = New System.Drawing.Size(34, 13)
        Me.lblTotalLow.TabIndex = 59
        Me.lblTotalLow.Text = "Total:"
        Me.toolTip.SetToolTip(Me.lblTotalLow, "Total on lower section")
        '
        'btnChance
        '
        Me.btnChance.Enabled = False
        Me.btnChance.Location = New System.Drawing.Point(6, 193)
        Me.btnChance.Name = "btnChance"
        Me.btnChance.Size = New System.Drawing.Size(62, 23)
        Me.btnChance.TabIndex = 52
        Me.btnChance.UseVisualStyleBackColor = True
        '
        'lblChanceScore
        '
        Me.lblChanceScore.AllowDrop = True
        Me.lblChanceScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChanceScore.Location = New System.Drawing.Point(149, 193)
        Me.lblChanceScore.Name = "lblChanceScore"
        Me.lblChanceScore.Size = New System.Drawing.Size(33, 23)
        Me.lblChanceScore.TabIndex = 51
        Me.lblChanceScore.Text = "-"
        Me.lblChanceScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblChance
        '
        Me.lblChance.AutoSize = True
        Me.lblChance.Location = New System.Drawing.Point(87, 198)
        Me.lblChance.Name = "lblChance"
        Me.lblChance.Size = New System.Drawing.Size(56, 13)
        Me.lblChance.TabIndex = 53
        Me.lblChance.Text = "Chance ->"
        Me.toolTip.SetToolTip(Me.lblChance, "Add together all values")
        '
        'btnYahtzee
        '
        Me.btnYahtzee.Enabled = False
        Me.btnYahtzee.Location = New System.Drawing.Point(6, 164)
        Me.btnYahtzee.Name = "btnYahtzee"
        Me.btnYahtzee.Size = New System.Drawing.Size(62, 23)
        Me.btnYahtzee.TabIndex = 49
        Me.btnYahtzee.UseVisualStyleBackColor = True
        '
        'lblYahtzeeScore
        '
        Me.lblYahtzeeScore.AllowDrop = True
        Me.lblYahtzeeScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYahtzeeScore.Location = New System.Drawing.Point(149, 164)
        Me.lblYahtzeeScore.Name = "lblYahtzeeScore"
        Me.lblYahtzeeScore.Size = New System.Drawing.Size(33, 23)
        Me.lblYahtzeeScore.TabIndex = 48
        Me.lblYahtzeeScore.Text = "-"
        Me.lblYahtzeeScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblYahtzee
        '
        Me.lblYahtzee.AutoSize = True
        Me.lblYahtzee.Location = New System.Drawing.Point(85, 169)
        Me.lblYahtzee.Name = "lblYahtzee"
        Me.lblYahtzee.Size = New System.Drawing.Size(58, 13)
        Me.lblYahtzee.TabIndex = 50
        Me.lblYahtzee.Text = "Yahtzee ->"
        Me.toolTip.SetToolTip(Me.lblYahtzee, "50p for 5 of the same kind")
        '
        'btnLgStraight
        '
        Me.btnLgStraight.Enabled = False
        Me.btnLgStraight.Location = New System.Drawing.Point(6, 135)
        Me.btnLgStraight.Name = "btnLgStraight"
        Me.btnLgStraight.Size = New System.Drawing.Size(62, 23)
        Me.btnLgStraight.TabIndex = 46
        Me.btnLgStraight.UseVisualStyleBackColor = True
        '
        'lblLgStraightScore
        '
        Me.lblLgStraightScore.AllowDrop = True
        Me.lblLgStraightScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLgStraightScore.Location = New System.Drawing.Point(149, 135)
        Me.lblLgStraightScore.Name = "lblLgStraightScore"
        Me.lblLgStraightScore.Size = New System.Drawing.Size(33, 23)
        Me.lblLgStraightScore.TabIndex = 45
        Me.lblLgStraightScore.Text = "-"
        Me.lblLgStraightScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLgStraight
        '
        Me.lblLgStraight.AutoSize = True
        Me.lblLgStraight.Location = New System.Drawing.Point(72, 140)
        Me.lblLgStraight.Name = "lblLgStraight"
        Me.lblLgStraight.Size = New System.Drawing.Size(71, 13)
        Me.lblLgStraight.TabIndex = 47
        Me.lblLgStraight.Text = "Lg. straight ->"
        Me.toolTip.SetToolTip(Me.lblLgStraight, "40p for 5 values in a row")
        '
        'btnSmStraight
        '
        Me.btnSmStraight.Enabled = False
        Me.btnSmStraight.Location = New System.Drawing.Point(6, 106)
        Me.btnSmStraight.Name = "btnSmStraight"
        Me.btnSmStraight.Size = New System.Drawing.Size(62, 23)
        Me.btnSmStraight.TabIndex = 43
        Me.btnSmStraight.UseVisualStyleBackColor = True
        '
        'lblSmStraightScore
        '
        Me.lblSmStraightScore.AllowDrop = True
        Me.lblSmStraightScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSmStraightScore.Location = New System.Drawing.Point(149, 106)
        Me.lblSmStraightScore.Name = "lblSmStraightScore"
        Me.lblSmStraightScore.Size = New System.Drawing.Size(33, 23)
        Me.lblSmStraightScore.TabIndex = 42
        Me.lblSmStraightScore.Text = "-"
        Me.lblSmStraightScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSmStraight
        '
        Me.lblSmStraight.AutoSize = True
        Me.lblSmStraight.Location = New System.Drawing.Point(69, 111)
        Me.lblSmStraight.Name = "lblSmStraight"
        Me.lblSmStraight.Size = New System.Drawing.Size(74, 13)
        Me.lblSmStraight.TabIndex = 44
        Me.lblSmStraight.Text = "Sm. straight ->"
        Me.toolTip.SetToolTip(Me.lblSmStraight, "30p for 4 values in a row")
        '
        'btnFullHouse
        '
        Me.btnFullHouse.Enabled = False
        Me.btnFullHouse.Location = New System.Drawing.Point(6, 77)
        Me.btnFullHouse.Name = "btnFullHouse"
        Me.btnFullHouse.Size = New System.Drawing.Size(62, 23)
        Me.btnFullHouse.TabIndex = 40
        Me.btnFullHouse.UseVisualStyleBackColor = True
        '
        'lblFullHouseScore
        '
        Me.lblFullHouseScore.AllowDrop = True
        Me.lblFullHouseScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFullHouseScore.Location = New System.Drawing.Point(149, 77)
        Me.lblFullHouseScore.Name = "lblFullHouseScore"
        Me.lblFullHouseScore.Size = New System.Drawing.Size(33, 23)
        Me.lblFullHouseScore.TabIndex = 39
        Me.lblFullHouseScore.Text = "-"
        Me.lblFullHouseScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFullHouse
        '
        Me.lblFullHouse.AutoSize = True
        Me.lblFullHouse.Location = New System.Drawing.Point(74, 82)
        Me.lblFullHouse.Name = "lblFullHouse"
        Me.lblFullHouse.Size = New System.Drawing.Size(67, 13)
        Me.lblFullHouse.TabIndex = 41
        Me.lblFullHouse.Text = "Full house ->"
        Me.toolTip.SetToolTip(Me.lblFullHouse, "25p for a 3 of a kind and 2 of a kind together")
        '
        'btn4Kind
        '
        Me.btn4Kind.Enabled = False
        Me.btn4Kind.Location = New System.Drawing.Point(6, 48)
        Me.btn4Kind.Name = "btn4Kind"
        Me.btn4Kind.Size = New System.Drawing.Size(62, 23)
        Me.btn4Kind.TabIndex = 37
        Me.btn4Kind.UseVisualStyleBackColor = True
        '
        'lbl4KindScore
        '
        Me.lbl4KindScore.AllowDrop = True
        Me.lbl4KindScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl4KindScore.Location = New System.Drawing.Point(149, 48)
        Me.lbl4KindScore.Name = "lbl4KindScore"
        Me.lbl4KindScore.Size = New System.Drawing.Size(33, 23)
        Me.lbl4KindScore.TabIndex = 36
        Me.lbl4KindScore.Text = "-"
        Me.lbl4KindScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl4Kind
        '
        Me.lbl4Kind.AutoSize = True
        Me.lbl4Kind.Location = New System.Drawing.Point(74, 53)
        Me.lbl4Kind.Name = "lbl4Kind"
        Me.lbl4Kind.Size = New System.Drawing.Size(69, 13)
        Me.lbl4Kind.TabIndex = 38
        Me.lbl4Kind.Text = "4 of a kind ->"
        Me.toolTip.SetToolTip(Me.lbl4Kind, "Add together 4 of the same kind")
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.AutoSize = True
        Me.lblGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandTotal.Location = New System.Drawing.Point(207, 310)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(100, 17)
        Me.lblGrandTotal.TabIndex = 62
        Me.lblGrandTotal.Text = "Grand Total:"
        '
        'picHold1
        '
        Me.picHold1.Location = New System.Drawing.Point(12, 226)
        Me.picHold1.Name = "picHold1"
        Me.picHold1.Size = New System.Drawing.Size(97, 28)
        Me.picHold1.TabIndex = 38
        Me.picHold1.TabStop = False
        '
        'picHold2
        '
        Me.picHold2.Location = New System.Drawing.Point(115, 226)
        Me.picHold2.Name = "picHold2"
        Me.picHold2.Size = New System.Drawing.Size(97, 28)
        Me.picHold2.TabIndex = 39
        Me.picHold2.TabStop = False
        '
        'picHold3
        '
        Me.picHold3.Location = New System.Drawing.Point(218, 226)
        Me.picHold3.Name = "picHold3"
        Me.picHold3.Size = New System.Drawing.Size(97, 28)
        Me.picHold3.TabIndex = 40
        Me.picHold3.TabStop = False
        '
        'picHold4
        '
        Me.picHold4.Location = New System.Drawing.Point(321, 226)
        Me.picHold4.Name = "picHold4"
        Me.picHold4.Size = New System.Drawing.Size(97, 28)
        Me.picHold4.TabIndex = 41
        Me.picHold4.TabStop = False
        '
        'picHold5
        '
        Me.picHold5.Location = New System.Drawing.Point(424, 226)
        Me.picHold5.Name = "picHold5"
        Me.picHold5.Size = New System.Drawing.Size(97, 28)
        Me.picHold5.TabIndex = 42
        Me.picHold5.TabStop = False
        '
        'GameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(946, 362)
        Me.Controls.Add(Me.picHold5)
        Me.Controls.Add(Me.picHold4)
        Me.Controls.Add(Me.picHold3)
        Me.Controls.Add(Me.picHold2)
        Me.Controls.Add(Me.picHold1)
        Me.Controls.Add(Me.grpboxResults)
        Me.Controls.Add(Me.picDie5)
        Me.Controls.Add(Me.picDie2)
        Me.Controls.Add(Me.picDie4)
        Me.Controls.Add(Me.picDie3)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.picDie1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GameForm"
        Me.Text = "Yahtzee"
        CType(Me.picDie5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDie2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDie4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDie3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDie1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpboxUppSec.ResumeLayout(False)
        Me.grpboxUppSec.PerformLayout()
        Me.grpboxResults.ResumeLayout(False)
        Me.grpboxResults.PerformLayout()
        Me.grpboxLowSec.ResumeLayout(False)
        Me.grpboxLowSec.PerformLayout()
        CType(Me.picHold1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHold2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHold3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHold4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHold5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picDie1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnRoll As System.Windows.Forms.Button
    Friend WithEvents picDie3 As System.Windows.Forms.PictureBox
    Friend WithEvents picDie4 As System.Windows.Forms.PictureBox
    Friend WithEvents picDie2 As System.Windows.Forms.PictureBox
    Friend WithEvents picDie5 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAces As System.Windows.Forms.Button
    Friend WithEvents lblAces As System.Windows.Forms.Label
    Friend WithEvents lblAcesScore As System.Windows.Forms.Label
    Friend WithEvents lblThreesScore As System.Windows.Forms.Label
    Friend WithEvents lblThrees As System.Windows.Forms.Label
    Friend WithEvents btnThrees As System.Windows.Forms.Button
    Friend WithEvents lblTwosScore As System.Windows.Forms.Label
    Friend WithEvents lblTwos As System.Windows.Forms.Label
    Friend WithEvents btnTwos As System.Windows.Forms.Button
    Friend WithEvents lblFoursScore As System.Windows.Forms.Label
    Friend WithEvents lblFours As System.Windows.Forms.Label
    Friend WithEvents btnFours As System.Windows.Forms.Button
    Friend WithEvents lblFIvesScore As System.Windows.Forms.Label
    Friend WithEvents lblFives As System.Windows.Forms.Label
    Friend WithEvents btnFives As System.Windows.Forms.Button
    Friend WithEvents lblSixesScore As System.Windows.Forms.Label
    Friend WithEvents lblSixes As System.Windows.Forms.Label
    Friend WithEvents btnSixes As System.Windows.Forms.Button
    Friend WithEvents lblTotalUpPreScore As System.Windows.Forms.Label
    Friend WithEvents lblTotalUpPre As System.Windows.Forms.Label
    Friend WithEvents lblBonusUp As System.Windows.Forms.Label
    Friend WithEvents lblBonusUpScore As System.Windows.Forms.Label
    Friend WithEvents btn3Kind As System.Windows.Forms.Button
    Friend WithEvents lbl3KindScore As System.Windows.Forms.Label
    Friend WithEvents lblTotalUpPost As System.Windows.Forms.Label
    Friend WithEvents lblTotalUpPostScore As System.Windows.Forms.Label
    Friend WithEvents lbl3Kind As System.Windows.Forms.Label
    Friend WithEvents grpboxUppSec As System.Windows.Forms.GroupBox
    Friend WithEvents grpboxResults As System.Windows.Forms.GroupBox
    Friend WithEvents grpboxLowSec As System.Windows.Forms.GroupBox
    Friend WithEvents btnChance As System.Windows.Forms.Button
    Friend WithEvents lblChanceScore As System.Windows.Forms.Label
    Friend WithEvents lblChance As System.Windows.Forms.Label
    Friend WithEvents btnYahtzee As System.Windows.Forms.Button
    Friend WithEvents lblYahtzeeScore As System.Windows.Forms.Label
    Friend WithEvents lblYahtzee As System.Windows.Forms.Label
    Friend WithEvents btnLgStraight As System.Windows.Forms.Button
    Friend WithEvents lblLgStraightScore As System.Windows.Forms.Label
    Friend WithEvents lblLgStraight As System.Windows.Forms.Label
    Friend WithEvents btnSmStraight As System.Windows.Forms.Button
    Friend WithEvents lblSmStraightScore As System.Windows.Forms.Label
    Friend WithEvents lblSmStraight As System.Windows.Forms.Label
    Friend WithEvents btnFullHouse As System.Windows.Forms.Button
    Friend WithEvents lblFullHouseScore As System.Windows.Forms.Label
    Friend WithEvents lblFullHouse As System.Windows.Forms.Label
    Friend WithEvents btn4Kind As System.Windows.Forms.Button
    Friend WithEvents lbl4KindScore As System.Windows.Forms.Label
    Friend WithEvents lbl4Kind As System.Windows.Forms.Label
    Friend WithEvents lblGrandTotalScore As System.Windows.Forms.Label
    Friend WithEvents lblTotalLowScore As System.Windows.Forms.Label
    Friend WithEvents lblTotalLow As System.Windows.Forms.Label
    Friend WithEvents lblGrandTotal As System.Windows.Forms.Label
    Friend WithEvents picHold1 As System.Windows.Forms.PictureBox
    Friend WithEvents picHold2 As System.Windows.Forms.PictureBox
    Friend WithEvents picHold3 As System.Windows.Forms.PictureBox
    Friend WithEvents picHold4 As System.Windows.Forms.PictureBox
    Friend WithEvents picHold5 As System.Windows.Forms.PictureBox
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip

End Class
