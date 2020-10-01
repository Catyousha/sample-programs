Option Explicit On
Module FizzBuzz
    Public Sub Main()
        FizzBuzz()
    End Sub
    Sub FizzBuzz()
        Dim first = True
        Dim i As Integer
        For i = 0 To 99
            If i Mod 15 = 0 Then
                If first Then
                    System.Console.Write("FizzBuzz")
                    first = False
                Else
                    System.Console.Write(", FizzBuzz")
                End If

            ElseIf i Mod 5 = 0 Then
                If first Then
                    System.Console.Write("Buzz")
                    first = False
                Else
                    System.Console.Write(", Buzz")
                End If
            ElseIf i Mod 3 = 0 Then
                If first Then
                    System.Console.Write("Fizz")
                    first = False
                Else
                    System.Console.Write(", Fizz")
                End If
            End If
        Next
    End Sub
End Module
