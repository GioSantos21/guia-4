Imports System

Module Program
    Sub Main()
        While True
            Console.WriteLine("Elija una opción <1-5>:")
            Dim respuesta As Integer = Console.ReadLine()
            Console.WriteLine()
            If respuesta = 1 Then
                Dim i As Integer = 1
                While i <= 40
                    Console.WriteLine(i)
                    i = i + 2
                End While
            End If
        End While
    End Sub
End Module
