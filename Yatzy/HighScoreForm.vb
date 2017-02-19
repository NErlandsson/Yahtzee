' Created by: NiklasErlandsson
' Date: 05-2015 
Option Strict On
Option Explicit On
''' <summary>
''' High score form displays all high score entries and gives the option erase current records
''' </summary>
''' <remarks></remarks>
Public Class HighScoreForm
    Private reader As HighScoreReader
    ''' <summary>
    ''' constructor declares HighScoreReader and adds readers get list to the list box
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()
        InitializeComponent()
        reader = New HighScoreReader()
        lstboxHighScores.Items.AddRange(reader.GetList())
    End Sub
    ''' <summary>
    ''' Resets current high score
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        reader.ClearHighScore()
        lstboxHighScores.Items.Clear()
    End Sub
End Class