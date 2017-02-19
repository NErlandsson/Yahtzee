' Created by: NiklasErlandsson
' Date: 05-2015 
Option Strict On
Option Explicit On
''' <summary>
''' Menu form has 3 buttons, one opens a GameForm the Other HighScoreForm and a last to open about box
''' </summary>
''' <remarks></remarks>
Public Class MenuForm
    ''' <summary>
    ''' constructor
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()
        InitializeComponent()
    End Sub
    ''' <summary>
    ''' Yahtzee button starts GameForm
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnYahtzee_Click(sender As Object, e As EventArgs) Handles btnYahtzee.Click
        Dim gameForm As GameForm
        gameForm = New GameForm()
        gameForm.Show()
    End Sub
    ''' <summary>
    ''' High score button starts HighScoreForm
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnHighScore_Click(sender As Object, e As EventArgs) Handles btnHighScore.Click
        Dim highScoreForm As HighScoreForm
        highScoreForm = New HighScoreForm()
        highScoreForm.Show()
    End Sub


    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Dim aboutForm As New AboutBox
        aboutForm.ShowDialog()
    End Sub
End Class