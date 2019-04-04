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
                Console.WriteLine()
            ElseIf respuesta = 2 Then
                Console.WriteLine("Ingrese un número entero positivo: ")
                Dim numero As Integer = Console.ReadLine()
                Dim inicio As Integer = 1
                Dim total As Integer = 0
                Console.WriteLine()
                While numero >= inicio
                    total = inicio + numero
                    Console.WriteLine(total)
                    inicio = inicio + 1
                End While
                Console.WriteLine()
            End If
        End While
    End Sub
End Module
