' Created by: NiklasErlandsson
' Date: 05-2015 
Option Strict On
Option Explicit On

Imports System.IO
''' <summary>
''' HighScoreReader reads the current records and formats it for a list box
''' </summary>
''' <remarks></remarks>
Public Class HighScoreReader
    Private highScore As List(Of HighScoreEntry)
    ''' <summary>
    ''' Constructor declares list of HighScoreEntry reads the records
    ''' and puts them in list and after that sorts them in order based on their score.
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()
        highScore = New List(Of HighScoreEntry)
        OpenFileAndSaveToList()
        highScore.Sort(Function(x, y) y.score.CompareTo(x.score))
    End Sub
    ''' <summary>
    ''' Reads file and saves to List
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub OpenFileAndSaveToList()
        Dim fileName As String = Application.StartupPath + "\HighScore.txt" 'filepath to saved file
        Dim reader As StreamReader = Nothing 'the reader
        Try
            Dim textInName, textInScore As String
            reader = New StreamReader(fileName) 'try to read the saved file
            While Not reader.EndOfStream 'as long as there are unread lines
                textInName = reader.ReadLine() 'read name of line
                textInScore = reader.ReadLine() ' read score after
                Dim entry = New HighScoreEntry(textInName, CInt(textInScore)) 'Create HighScoreEntry with the read info
                highScore.Add(entry) 'put entry into list
            End While
        Catch
            MessageBox.Show("Problem reading from file") 'if the reader cant find the file or any other error

        Finally
            If reader IsNot Nothing Then
                reader.Close() 'close the reader
            End If
        End Try
    End Sub
    ''' <summary>
    ''' Sends array with strings formated for list box
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetList() As String()
        Dim output(highScore.Count() - 1) As String
        Dim counter As Integer = 0
        For Each entry As HighScoreEntry In highScore
            output(counter) = String.Format("{0,-3}{1,-30}{2, -10}", counter + 1, entry.name, entry.score)
            counter = counter + 1
        Next
        Return output
    End Function
    ''' <summary>
    ''' Clears the high score records
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ClearHighScore()
        Dim fileName As String = Application.StartupPath + "\HighScore.txt"
        Dim writer As StreamWriter = Nothing 'the writer
        Try
            writer = New StreamWriter(fileName, False) 'put writer on the save file / create save file if needed
            writer.Write("") 'write nothing
        Catch e As Exception
            MessageBox.Show("Problem saving data to file!" + e.Message) 'if error occurs
        Finally
            If writer IsNot Nothing Then
                writer.Close() 'close writer
            End If
        End Try
    End Sub
End Class

