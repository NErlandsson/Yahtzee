' Created by: NiklasErlandsson
' Date: 05-2015 
Option Explicit On
Option Strict On
Public Class GameForm
    Private engine As GameEngine
    Private rollCount As Integer
    Private gameDone As Boolean
    ''' <summary>
    ''' Constructor initalizes game engine, gameDone as false and rollcount as 0
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        engine = New GameEngine()
        gameDone = False
        rollCount = 0
        InitializeComponent()
    End Sub
    ''' <summary>
    ''' Roll button calls engine.roll and displays the pictures representing the values
    ''' and calculates how much points this roll would give in all the fields.
    ''' when rolled 3 times inactivates roll button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        rollCount = rollCount + 1
        SetPics(engine.Roll())
        CalculateScoreActivateButtons()
        If rollCount = 3 Then
            btnRoll.Enabled = False
        End If
    End Sub
    ''' <summary>
    ''' Every new round UI is updated for new round and checks with engine if game is done
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub NewRound()
        DeactivateResultButtons()
        rollCount = 0
        UpdateTotals()
        engine.UnHoldAll()
        btnRoll.Enabled = True
        picDie1.Image = Nothing
        picDie2.Image = Nothing
        picDie3.Image = Nothing
        picDie4.Image = Nothing
        picDie5.Image = Nothing
        picHold1.Image = Nothing
        picHold2.Image = Nothing
        picHold3.Image = Nothing
        picHold4.Image = Nothing
        picHold5.Image = Nothing
        btnAces.Text = Nothing
        btnTwos.Text = Nothing
        btnThrees.Text = Nothing
        btnFours.Text = Nothing
        btnFives.Text = Nothing
        btnSixes.Text = Nothing
        btn3Kind.Text = Nothing
        btn4Kind.Text = Nothing
        btnFullHouse.Text = Nothing
        btnSmStraight.Text = Nothing
        btnLgStraight.Text = Nothing
        btnYahtzee.Text = Nothing
        btnChance.Text = Nothing
        If engine.AreWeDone() Then
            gameDone = True
            Me.Close()
        End If
    End Sub
    ''' <summary>
    ''' calls engine to calculates all totals and bonus and puts it on the screen
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdateTotals()
        Dim total(5) As Integer
        total = engine.GetTotalsAndBonus()
        lblTotalUpPreScore.Text = CStr(total(0))
        lblBonusUpScore.Text = CStr(total(1))
        lblTotalUpPostScore.Text = CStr(total(2))
        lblTotalLowScore.Text = CStr(total(3))
        lblGrandTotalScore.Text = CStr(total(4))
    End Sub
    ''' <summary>
    ''' if the picturebox holds a picture hold the die and show hold sign
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub picDie1_Click(sender As Object, e As EventArgs) Handles picDie1.Click
        If picHold1.Image Is Nothing And picDie1.Image IsNot Nothing Then
            picHold1.Image = My.Resources.hold
            engine.Hold(0)
        Else
            picHold1.Image = Nothing
            engine.Unhold(0)
        End If
    End Sub
    ''' <summary>
    ''' if the picturebox holds a picture hold the die and show hold sign
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub picDie2_Click(sender As Object, e As EventArgs) Handles picDie2.Click
        If picHold2.Image Is Nothing And picDie2.Image IsNot Nothing Then
            picHold2.Image = My.Resources.hold
            engine.Hold(1)
        Else
            picHold2.Image = Nothing
            engine.Unhold(1)
        End If
    End Sub
    ''' <summary>
    ''' if the picturebox holds a picture hold the die and show hold sign
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub picDie3_Click(sender As Object, e As EventArgs) Handles picDie3.Click
        If picHold3.Image Is Nothing And picDie3.Image IsNot Nothing Then
            picHold3.Image = My.Resources.hold
            engine.Hold(2)
        Else
            picHold3.Image = Nothing
            engine.Unhold(2)
        End If
    End Sub
    ''' <summary>
    ''' if the picturebox holds a picture hold the die and show hold sign
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub picDie4_Click(sender As Object, e As EventArgs) Handles picDie4.Click
        If picHold4.Image Is Nothing And picDie4.Image IsNot Nothing Then
            picHold4.Image = My.Resources.hold
            engine.Hold(3)
        Else
            picHold4.Image = Nothing
            engine.Unhold(3)
        End If
    End Sub
    ''' <summary>
    ''' if the picturebox holds a picture hold the die and show hold sign
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub picDie5_Click(sender As Object, e As EventArgs) Handles picDie5.Click
        If picHold5.Image Is Nothing And picDie5.Image IsNot Nothing Then
            picHold5.Image = My.Resources.hold
            engine.Hold(4)
        Else
            picHold5.Image = Nothing
            engine.Unhold(4)
        End If
    End Sub
    ''' <summary>
    ''' tell engine to put score in aces field and then start new round
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAces_Click(sender As Object, e As EventArgs) Handles btnAces.Click
        lblAcesScore.Text = btnAces.Text
        engine.SavePoints(CInt(btnAces.Text), 0)
        NewRound()
    End Sub
    ''' <summary>
    ''' tell engine to put score in twos field and then start new round
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnTwos_Click(sender As Object, e As EventArgs) Handles btnTwos.Click
        lblTwosScore.Text = btnTwos.Text
        engine.SavePoints(CInt(btnTwos.Text), 1)
        NewRound()
    End Sub
    ''' <summary>
    ''' tell engine to put score in threes field and then start new round
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnThrees_Click(sender As Object, e As EventArgs) Handles btnThrees.Click
        lblThreesScore.Text = btnThrees.Text
        engine.SavePoints(CInt(btnThrees.Text), 2)
        NewRound()
    End Sub
    ''' <summary>
    ''' tell engine to put score in fours field and then start new round
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnFours_Click(sender As Object, e As EventArgs) Handles btnFours.Click
        lblFoursScore.Text = btnFours.Text
        engine.SavePoints(CInt(btnFours.Text), 3)
        NewRound()
    End Sub
    ''' <summary>
    ''' tell engine to put score in fives field and then start new round
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnFives_Click(sender As Object, e As EventArgs) Handles btnFives.Click
        lblFIvesScore.Text = btnFives.Text
        engine.SavePoints(CInt(btnFives.Text), 4)
        NewRound()
    End Sub
    ''' <summary>
    ''' tell engine to put score in sixes field and then start new round
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSixes_Click(sender As Object, e As EventArgs) Handles btnSixes.Click
        lblSixesScore.Text = btnSixes.Text
        engine.SavePoints(CInt(btnSixes.Text), 5)
        NewRound()
    End Sub
    ''' <summary>
    ''' tell engine to put score in 3 of a kind field and then start new round
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn3Kind_Click(sender As Object, e As EventArgs) Handles btn3Kind.Click
        lbl3KindScore.Text = btn3Kind.Text
        engine.SavePoints(CInt(btn3Kind.Text), 6)
        NewRound()
    End Sub
    ''' <summary>
    ''' tell engine to put score in 4 of a kind field and then start new round
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn4Kind_Click(sender As Object, e As EventArgs) Handles btn4Kind.Click
        lbl4KindScore.Text = btn4Kind.Text
        engine.SavePoints(CInt(btn4Kind.Text), 7)
        NewRound()
    End Sub
    ''' <summary>
    ''' tell engine to put score in full house field and then start new round
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnFullHouse_Click(sender As Object, e As EventArgs) Handles btnFullHouse.Click
        lblFullHouseScore.Text = btnFullHouse.Text
        engine.SavePoints(CInt(btnFullHouse.Text), 8)
        NewRound()
    End Sub
    ''' <summary>
    ''' tell engine to put score in small straight field and then start new round
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSmStraight_Click(sender As Object, e As EventArgs) Handles btnSmStraight.Click
        lblSmStraightScore.Text = btnSmStraight.Text
        engine.SavePoints(CInt(btnSmStraight.Text), 9)
        NewRound()
    End Sub
    ''' <summary>
    ''' tell engine to put score in large straight field and then start new round
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnLgStraight_Click(sender As Object, e As EventArgs) Handles btnLgStraight.Click
        lblLgStraightScore.Text = btnLgStraight.Text
        engine.SavePoints(CInt(btnLgStraight.Text), 10)
        NewRound()
    End Sub
    ''' <summary>
    ''' tell engine to put score in yahtzee field and then start new round
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnYahtzee_Click(sender As Object, e As EventArgs) Handles btnYahtzee.Click
        lblYahtzeeScore.Text = btnYahtzee.Text
        engine.SavePoints(CInt(btnYahtzee.Text), 11)
        NewRound()
    End Sub
    ''' <summary>
    ''' tell engine to put score in chance field and then start new round
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnChance_Click(sender As Object, e As EventArgs) Handles btnChance.Click
        lblChanceScore.Text = btnChance.Text
        engine.SavePoints(CInt(btnChance.Text), 12)
        NewRound()
    End Sub
    ''' <summary>
    ''' Sets pics based on array of integers received
    ''' </summary>
    ''' <param name="rolls">dice values</param>
    ''' <remarks></remarks>
    Private Sub SetPics(rolls() As Integer)
        Select Case rolls(0)
            Case 1
                picDie1.Image = My.Resources.one
            Case 2
                picDie1.Image = My.Resources.two
            Case 3
                picDie1.Image = My.Resources.three
            Case 4
                picDie1.Image = My.Resources.four
            Case 5
                picDie1.Image = My.Resources.five
            Case 6
                picDie1.Image = My.Resources.six
        End Select
        Select Case rolls(1)
            Case 1
                picDie2.Image = My.Resources.one
            Case 2
                picDie2.Image = My.Resources.two
            Case 3
                picDie2.Image = My.Resources.three
            Case 4
                picDie2.Image = My.Resources.four
            Case 5
                picDie2.Image = My.Resources.five
            Case 6
                picDie2.Image = My.Resources.six
        End Select
        Select Case rolls(2)
            Case 1
                picDie3.Image = My.Resources.one
            Case 2
                picDie3.Image = My.Resources.two
            Case 3
                picDie3.Image = My.Resources.three
            Case 4
                picDie3.Image = My.Resources.four
            Case 5
                picDie3.Image = My.Resources.five
            Case 6
                picDie3.Image = My.Resources.six
        End Select
        Select Case rolls(3)
            Case 1
                picDie4.Image = My.Resources.one
            Case 2
                picDie4.Image = My.Resources.two
            Case 3
                picDie4.Image = My.Resources.three
            Case 4
                picDie4.Image = My.Resources.four
            Case 5
                picDie4.Image = My.Resources.five
            Case 6
                picDie4.Image = My.Resources.six
        End Select
        Select Case rolls(4)
            Case 1
                picDie5.Image = My.Resources.one
            Case 2
                picDie5.Image = My.Resources.two
            Case 3
                picDie5.Image = My.Resources.three
            Case 4
                picDie5.Image = My.Resources.four
            Case 5
                picDie5.Image = My.Resources.five
            Case 6
                picDie5.Image = My.Resources.six
        End Select
    End Sub
    ''' <summary>
    ''' Calculates how much this roll would give in each field and activate buttons
    ''' based on if the field already is filled or not.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CalculateScoreActivateButtons()
        If (lblAcesScore.Text = "-") Then
            btnAces.Enabled = True
            btnAces.Text = CStr(engine.AddUppSec(1))
        End If
        If (lblTwosScore.Text = "-") Then
            btnTwos.Enabled = True
            btnTwos.Text = CStr(engine.AddUppSec(2))
        End If
        If (lblThreesScore.Text = "-") Then
            btnThrees.Enabled = True
            btnThrees.Text = CStr(engine.AddUppSec(3))
        End If
        If (lblFoursScore.Text = "-") Then
            btnFours.Enabled = True
            btnFours.Text = CStr(engine.AddUppSec(4))
        End If
        If (lblFIvesScore.Text = "-") Then
            btnFives.Enabled = True
            btnFives.Text = CStr(engine.AddUppSec(5))
        End If
        If (lblSixesScore.Text = "-") Then
            btnSixes.Enabled = True
            btnSixes.Text = CStr(engine.AddUppSec(6))
        End If
        If (lbl3KindScore.Text = "-") Then
            btn3Kind.Enabled = True
            btn3Kind.Text = CStr(engine.AddThreeKind())
        End If
        If (lbl4KindScore.Text = "-") Then
            btn4Kind.Enabled = True
            btn4Kind.Text = CStr(engine.AddFourKind())
        End If
        If (lblFullHouseScore.Text = "-") Then
            btnFullHouse.Enabled = True
            btnFullHouse.Text = CStr(engine.AddFullHouse())
        End If
        If (lblSmStraightScore.Text = "-") Then
            btnSmStraight.Enabled = True
            btnSmStraight.Text = CStr(engine.AddSmStraight())
        End If
        If (lblLgStraightScore.Text = "-") Then
            btnLgStraight.Enabled = True
            btnLgStraight.Text = CStr(engine.AddLgStraight())
        End If
        If (lblYahtzeeScore.Text = "-") Then
            btnYahtzee.Enabled = True
            btnYahtzee.Text = CStr(engine.addYahtzee())
        End If
        If (lblChanceScore.Text = "-") Then
            btnChance.Enabled = True
            btnChance.Text = CStr(engine.addChance())
        End If
    End Sub
    ''' <summary>
    ''' When new round starts deactivate all result buttons
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DeactivateResultButtons()
        btnAces.Enabled = False
        btnTwos.Enabled = False
        btnThrees.Enabled = False
        btnFours.Enabled = False
        btnFives.Enabled = False
        btnSixes.Enabled = False
        btn3Kind.Enabled = False
        btn4Kind.Enabled = False
        btnFullHouse.Enabled = False
        btnSmStraight.Enabled = False
        btnLgStraight.Enabled = False
        btnYahtzee.Enabled = False
        btnChance.Enabled = False
    End Sub
    ''' <summary>
    ''' When the form is about to be closed and gameDone is not true ask for confirmation.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub GameForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If gameDone = False Then
            Dim response = MsgBox("Are you sure you want to exit mid game?", vbYesNo)
            If response = vbNo Then
                e.Cancel = True 'Cancel FormClosingEvent
            End If
        End If
    End Sub
End Class
