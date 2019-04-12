Imports System

Module Program
    Sub Main()
        While True
            Console.WriteLine("Elija una opción <1-9>:")
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
                    Console.WriteLine($"la suma de {numero} + {inicio} es : {total}")
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
                Dim contador As Integer = 1
                For numero = i To numero
                    total = i * total
                    Console.WriteLine("" + vbCrLf + $" El proceso es: {contador} * {numero} = {total}")
                    i = i + 1
                    contador = total
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
                Console.WriteLine("" + vbCrLf + "Escriba una frase o palabra: ")
                Dim palabra As String = Console.ReadLine()
                Console.WriteLine()
                For index = 0 To palabra.Length() - 1
                    Console.Write(palabra.Reverse(index))
                Next
                Console.WriteLine()
                Console.WriteLine()
            ElseIf respuesta = 7 Then
                Dim cuates() As String = {"Gerardo", "Glenda", "Luna", "Fran", "Molina"}
                Console.WriteLine("Los mejores programadores de POO :D " + vbCrLf + "")
                For Each nombres As String In cuates
                    Console.WriteLine(nombres + vbCrLf + "")
                Next
            ElseIf respuesta = 8 Then
                Console.WriteLine("" + vbCrLf + "Escriba una frase o palabra: ")
                Dim palabra As String = Console.ReadLine()
                Dim convertir() As String = palabra.Split()
                palabra.Split()
                Dim contador As Integer = 1
                For Each palabras As String In palabra
                    If palabras = " " Then
                        contador = contador + 1
                    End If
                Next
                Console.WriteLine($"la frase {palabra} tiene {contador} palabras")
                For Each palabras As String In convertir
                    Console.WriteLine($"La palabra {palabras} tiene { palabras.Length } letras.")
                Next
            ElseIf respuesta = 9 Then
                Dim fin As Integer = 0
                Dim aumento As Integer = 1
                Dim arre1(2) As Integer
                Dim arre2(2) As Integer
                Console.WriteLine("Ingresa los primeros 3 números" + vbCrLf + "")
                While fin <> 3
                    Console.WriteLine($"Ingrese el número {aumento}: ")
                    Dim numeros As Double = Console.ReadLine()
                    arre1(fin) = numeros
                    aumento = aumento + 1
                    fin = fin + 1
                End While
                Console.WriteLine()
                Console.WriteLine("Hecho, ahora ingresa los 3 números restantes" + vbCrLf + "")
                Dim fin2 As Integer = 0
                Dim aumento2 As Integer = 1
                While fin2 <> 3
                    Console.WriteLine($"Ingrese el número {aumento2}: ")
                    Dim numeros As Double = Console.ReadLine()
                    arre2(fin2) = numeros
                    aumento2 = aumento2 + 1
                    fin2 = fin2 + 1
                End While
                Console.WriteLine()
                For i = 0 To arre1.Length - 1
                    Dim uno As Double = arre1(i)
                    ' ---------------- SUMA ----------------
                    Dim contador As Integer = 0
                    For e = 0 To arre2.Length - 1
                        Dim one As Double = arre2(e)
                        Dim suma As Double = (uno + one)
                        Console.WriteLine($"la suma de {uno} + {one} es: {suma}")
                        contador = contador + 1
                        If contador Mod 3 = 0 Then
                            Console.WriteLine()
                        End If
                    Next
                    ' ------------------------- RESTA ------------
                    Dim dos As Double = arre1(i)
                    Dim contador2 As Integer = 0
                    For a = 0 To arre2.Length - 1
                        Dim two As Double = arre2(a)
                        Dim resta As Double = (dos - two)
                        Console.WriteLine($"la resta de {dos} - {two} es: {resta}")
                        contador2 = contador2 + 1
                        If contador2 Mod 3 = 0 Then
                            Console.WriteLine()
                        End If
                    Next
                    ' ---------------- MULTIPLICACIÓN -----------
                    Dim tres As Double = arre1(i)
                    Dim contador3 As Integer = 0
                    For o = 0 To arre2.Length - 1
                        Dim three As Double = arre2(o)
                        Dim multiplicacion As Double = (tres * three)
                        Console.WriteLine($"la multiplicación de {tres} * {three} es: {multiplicacion}")
                        contador3 = contador3 + 1
                        If contador3 Mod 3 = 0 Then
                            Console.WriteLine()
                        End If
                        ' ------------------ DIVISIÓN ------------
                    Next
                    Dim cuatro As Double = arre1(i)
                    Dim contador4 As Integer = 0
                    For u = 0 To arre2.Length - 1
                        Dim four As Double = arre2(u)
                        Dim division As Double = (cuatro / four)
                        Console.WriteLine($"la división de {cuatro} / {four} es: {division}")
                        contador4 = contador4 + 1
                        If contador4 Mod 3 = 0 Then
                            Console.WriteLine()
                        End If
                    Next
                Next
            End If
        End While
    End Sub
End Module
