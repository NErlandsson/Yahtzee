' Created by: NiklasErlandsson
' Date: 05-2015 
Option Strict On
Option Explicit On
''' <summary>
''' Represents a high score entry with a name and a score
''' </summary>
''' <remarks></remarks>
Public Class HighScoreEntry
    Public Property name As String
    Public Property score As Integer
    Sub New(name As String, score As Integer)
        Me.name = name
        Me.score = score
    End Sub
End Class
