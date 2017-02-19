' Created by: NiklasErlandsson
' Date: 05-2015 
Option Explicit On
Option Strict On

Imports System.IO
''' <summary>
''' GameEngine runs the game through GameForm
''' Keeps an array of integers for the score and an array of the 5 dices.
''' Also keeps count of how many rounds has passed so it can cancel and save the score.
''' </summary>
''' <remarks></remarks>
Public Class GameEngine
    Private score(12) As Integer
    Private dice(4) As Die
    Private roundCount As Integer
    ''' <summary>
    ''' Constructor initates the dices and sets roundCount to 0
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        For index As Integer = 0 To 4
            dice(index) = New Die
            roundCount = 0
        Next
    End Sub
    ''' <summary>
    ''' Rolls all dices that arent being held and resturns the values
    ''' </summary>
    ''' <returns>values of all dices in an array</returns>
    ''' <remarks></remarks>
    Public Function Roll() As Integer()
        Dim output(4) As Integer
        For index As Integer = 0 To 4
            output(index) = dice(index).Roll
        Next
        Return output
    End Function
    ''' <summary>
    ''' Hold a specific die
    ''' </summary>
    ''' <param name="index">Die to be held</param>
    ''' <remarks></remarks>
    Public Sub Hold(index As Integer)
        dice(index).Hold = True
    End Sub
    ''' <summary>
    ''' Unhold a specific die
    ''' </summary>
    ''' <param name="index">Die to be released</param>
    ''' <remarks></remarks>
    Public Sub Unhold(index As Integer)
        dice(index).Hold = False
    End Sub
    ''' <summary>
    ''' Unhold all dices
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UnHoldAll()
        For index As Integer = 0 To 4
            dice(index).Hold = False
        Next
    End Sub
    ''' <summary>
    ''' Calculate points for all fields in upper section
    ''' </summary>
    ''' <param name="row">what value to count</param>
    ''' <returns>points</returns>
    ''' <remarks></remarks>
    Public Function AddUppSec(row As Integer) As Integer
        Dim counter As Integer = 0
        For index As Integer = 0 To 4
            If (dice(index).Value = row) Then
                counter = counter + 1
            End If
        Next
        Return counter * row
    End Function
    ''' <summary>
    ''' Calculate points for 3 of a kind
    ''' </summary>
    ''' <returns>points</returns>
    ''' <remarks></remarks>
    Public Function AddThreeKind() As Integer
        'place all value representing how many of that value it is among the dice in an array
        Dim counts() As Integer = {0, 0, 0, 0, 0, 0}
        For index As Integer = 0 To 4
            counts(dice(index).Value - 1) = counts(dice(index).Value - 1) + 1
        Next
        For index As Integer = 0 To 5 'check if there is 3 of any value
            If counts(index) >= 3 Then
                Return (3 * (index + 1))
            End If
        Next
        Return 0
    End Function
    ''' <summary>
    ''' Calculate points for 4 of a kind
    ''' </summary>
    ''' <returns>points</returns>
    ''' <remarks></remarks>
    Public Function AddFourKind() As Integer
        'place all value representing how many of that value it is among the dice in an array
        Dim counts() As Integer = {0, 0, 0, 0, 0, 0}
        For index As Integer = 0 To 4
            counts(dice(index).Value - 1) = counts(dice(index).Value - 1) + 1
        Next
        For index As Integer = 0 To 5
            If counts(index) >= 4 Then 'check if there is four of any value
                Return (4 * (index + 1))
            End If
        Next
        Return 0
    End Function
    ''' <summary>
    ''' Calculate points for full house
    ''' </summary>
    ''' <returns>points</returns>
    ''' <remarks></remarks>
    Public Function AddFullHouse() As Integer
        Dim TwoKind As Boolean = False
        Dim Threekind As Boolean = False
        'place all value representing how many of that value it is among the dice in an array
        Dim counts() As Integer = {0, 0, 0, 0, 0, 0}
        For index As Integer = 0 To 4
            counts(dice(index).Value - 1) = counts(dice(index).Value - 1) + 1
        Next
        For index As Integer = 0 To 5
            If counts(index) = 5 Then 'check if there is 5 of any value (counts as full house)
                Return 25
            ElseIf counts(index) >= 3 Then 'check for three of any value
                Threekind = True
            ElseIf counts(index) >= 2 Then 'check for two of any value
                TwoKind = True
            End If
        Next
        If TwoKind And Threekind Then 'if found three of one kind and two of another
            Return 25
        Else
            Return 0
        End If
    End Function
    ''' <summary>
    ''' Calculate points for small straight
    ''' </summary>
    ''' <returns>points</returns>
    ''' <remarks></remarks>
    Public Function AddSmStraight() As Integer
        Dim emptyValues As Integer = 0
        'place all value representing how many of that value it is among the dice in an array
        Dim counts() As Integer = {0, 0, 0, 0, 0, 0}
        For index As Integer = 0 To 4
            counts(dice(index).Value - 1) = counts(dice(index).Value - 1) + 1
        Next
        If (counts(0) > 0 And counts(1) > 0 And counts(2) > 0 And counts(3) > 0) Or
                (counts(1) > 0 And counts(2) > 0 And counts(3) > 0 And counts(4) > 0) Or
                (counts(2) > 0 And counts(3) > 0 And counts(4) > 0 And counts(5) > 0) Then 'check if there is more than one of the value 1234, 2345 or 3456
            Return 30
        Else
            Return 0
        End If
    End Function
    ''' <summary>
    ''' Calculate points for large straight
    ''' </summary>
    ''' <returns>points</returns>
    ''' <remarks></remarks>
    Public Function AddLgStraight() As Integer
        Dim emptyValues As Integer = 0
        'place all value representing how many of that value it is among the dice in an array
        Dim counts() As Integer = {0, 0, 0, 0, 0, 0}
        For index As Integer = 0 To 4
            counts(dice(index).Value - 1) = counts(dice(index).Value - 1) + 1
        Next
        For index As Integer = 0 To 5 'check if there are any values not represented
            If counts(index) = 0 Then
                emptyValues = emptyValues + 1
            End If
        Next
        If emptyValues > 1 Then
            Return 0
        Else
            If counts(0) = 0 Or counts(5) = 0 Then
                Return 40
            Else
                Return 0
            End If
        End If
    End Function
    ''' <summary>
    ''' Calculate points for yahtzee
    ''' </summary>
    ''' <returns>points</returns>
    ''' <remarks></remarks>
    Public Function addYahtzee() As Integer
        For index As Integer = 1 To 4 'are all values same as the previous one?
            If dice(index - 1).Value <> dice(index).Value Then
                Return 0
            End If
        Next
        Return 50
    End Function
    ''' <summary>
    ''' Calculate points for chance
    ''' </summary>
    ''' <returns>points</returns>
    ''' <remarks></remarks>
    Public Function addChance() As Integer
        Dim points As Integer = 0
        For index As Integer = 0 To 4
            points = points + dice(index).Value
        Next
        Return points
    End Function
    ''' <summary>
    ''' Save done points to points() array
    ''' </summary>
    ''' <param name="points"></param>
    ''' <param name="spot"></param>
    ''' <remarks></remarks>
    Public Sub SavePoints(points As Integer, spot As Integer)
        score(spot) = points
        roundCount = roundCount + 1
    End Sub
    ''' <summary>
    ''' Calculate totals för sections and bonus.
    ''' array(0)= total upper section without bonus
    ''' array(1)= bonus
    ''' array(2)= total upper section with bonus
    ''' array(3)= total lower section
    ''' array(4)= grand total
    ''' </summary>
    ''' <returns>totals and bonus</returns>
    ''' <remarks></remarks>
    Function GetTotalsAndBonus() As Integer()
        Dim total(5) As Integer
        For index As Integer = 0 To 5 'add together upper section
            total(0) = total(0) + score(index)
        Next
        If total(0) > 62 Then 'if 63 or greater add bonus
            total(1) = 35
        End If
        total(2) = total(0) + total(1) 'total of upper section + bonus
        For index As Integer = 6 To 12 'add together lower section
            total(3) = total(3) + score(index)
        Next
        total(4) = total(2) + total(3) 'add together grand total
        Return total
    End Function
    ''' <summary>
    ''' Checks if all 13 rounds have been played, saves down score if it has
    ''' </summary>
    ''' <returns>Yes, if we are done</returns>
    ''' <remarks></remarks>
    Public Function AreWeDone() As Boolean
        If roundCount = 13 Then
            Dim response As String = InputBox("Please enter your name for the high score!", "Game complete!", "")
            If response = "" Then
                Return True
            End If
            Dim score() As Integer = GetTotalsAndBonus()
            PrintToFile(response, score(4))
            Return True
        Else
            Return False
        End If
    End Function
    ''' <summary>
    ''' Prints the score with name to file
    ''' </summary>
    ''' <param name="name">Name</param>
    ''' <param name="score">Score</param>
    ''' <remarks></remarks>
    Private Sub PrintToFile(name As String, score As Integer)
        Dim fileName As String = Application.StartupPath + "\HighScore.txt" 'where to save the file
        Dim writer As StreamWriter = Nothing 'the writer
        Try
            writer = New StreamWriter(fileName, True) 'put writer on the save file / create save file if needed
            writer.WriteLine(name) 'Write to document
            writer.WriteLine(score)
        Catch e As Exception
            MessageBox.Show("Problem saving data to file!" + e.Message) 'if error occurs
        Finally
            If writer IsNot Nothing Then
                writer.Close() 'close writer
            End If
        End Try
    End Sub
End Class
