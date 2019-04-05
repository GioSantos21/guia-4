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
            ElseIf respuesta = 3 Then
                Dim numGenerado As Int16 = New Random().Next(11)
                Dim num As Integer
                Do Until num = numGenerado
                    While True
                        Console.WriteLine("" + vbCrLf + "!Prueba suerte e intenta si puedes adivinar el número entre <0-10>¡ :")
                        num = Console.ReadLine()
                        If num < 0 Or num > 10 Then
                            Console.WriteLine("" + vbCrLf + "ERROR. Opción invalida, número fuera de rango. intentalo de nuevo")
                        Else Exit While
                        End If
                    End While
                    If num <> numGenerado Then
                        Console.WriteLine("" + vbCrLf + "SORRY PERDISTE :C , sigue intentando.")
                    Else
                        Console.WriteLine("" + vbCrLf + "!!!YEAHH!!! :D ganaste." + vbCrLf + "")
                    End If
                Loop
            ElseIf respuesta = 4 Then
                Dim numero As Integer
                While True
                    Console.WriteLine("" + vbCrLf + "Ingrese un número positivo y te mostraremos el factorial: ")
                    numero = Console.ReadLine()
                    If numero <= 0 Then
                        Console.WriteLine("" + vbCrLf + "ERROR. El número ingresado es <0> o es negativo. Vuelve a intentarlo.")
                    Else
                        Exit While
                    End If
                End While
                Dim i As Integer = 2
                Dim total As Integer = 1
                For numero = i To numero
                    total = i * total
                    Console.WriteLine("" + vbCrLf + $" El proceso es :{total}")
                    i = i + 1
                Next
                Console.WriteLine("" + vbCrLf + $" El factorial de {numero - 1 } es: {total}")
                Console.WriteLine()
            ElseIf respuesta = 5 Then
                Console.WriteLine("" + vbCrLf + "Ingrese un número positivo para ver la tabla de multiplicar: ")
                Dim numero As Integer = Console.ReadLine()
                Dim num As Integer = numero
                Dim i As Integer = 1
                Dim total As Integer = 1
                Console.WriteLine()
                For numero = 1 To 10
                    total = num * i
                    Console.WriteLine(total)
                    i = i + 1
                Next
                Console.WriteLine()
            ElseIf respuesta = 6 Then

            End If
        End While
    End Sub
End Module
