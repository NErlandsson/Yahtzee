' Created by: NiklasErlandsson
' Date: 05-2015 
Option Explicit On
Option Strict On
''' <summary>
''' Represents a die, has a value and a boolean for if it is to be re-rolled or not.
''' </summary>
''' <remarks></remarks>
Public Class Die
    Public Sub New()
        Value = 1
        Hold = False
    End Sub
    Public Property Value As Integer
    Public Property Hold As Boolean
    ''' <summary>
    ''' Roll a new value if hold = false
    ''' </summary>
    ''' <returns>value</returns>
    ''' <remarks></remarks>
    Public Function Roll() As Integer
        Randomize()
        If Hold = False Then
            Value = CInt(Int((6 * Rnd()) + 1))
        End If
        Return Value
    End Function
End Class
