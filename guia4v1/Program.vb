Imports System

Module Program
    Sub Main()
        While True
            Console.Write("Presione <0> si desea salir del programa." + vbCrLf + "" + vbCrLf + "1. Números impares del 1 al 40." + vbCrLf + "2. Suma de números." + vbCrLf + "3. Adivinanza." + vbCrLf + "4. Factorial." + vbCrLf + "5. Tablas de múltiplicar." + vbCrLf + "6. Cadenas inversas." + vbCrLf + "7. Estudiantes de POO1." + vbCrLf + "8. Contar palabras y caracteres." + vbCrLf + "9. Aritmética con conjuntos" + vbCrLf + "" + vbCrLf + "Elija una opción <1-9> :")
            Dim respuesta As Integer = Console.ReadLine()
            Console.WriteLine()
            If respuesta = 1 Then
                Console.Write("Los números impares, del 1 40 son los siguientes:  " + vbCrLf + "" + vbCrLf + "")
                Dim i As Integer = 1
                While i <= 40
                    Console.WriteLine(i)
                    i = i + 2
                End While
                Console.WriteLine()
            ElseIf respuesta = 2 Then
                While True
                    Console.Write("Ingresa un número y veras la sumas iniciando de 1 hasta el número que ingresaste " + vbCrLf + "" + vbCrLf + "Ingrese un número entero positivo: ")
                    Dim numero As Integer = Console.ReadLine()
                    If numero <= 0 Then
                        Console.WriteLine("" + vbCrLf + "ERROR. Opción invalida, ingresa un número positivo" + vbCrLf + "")
                        Continue While
                    End If
                    Dim inicio As Integer = 1
                    Dim total As Integer = 0
                    Console.WriteLine()
                    While numero >= inicio
                        total = inicio + numero
                        Console.WriteLine($"la suma de {numero} + {inicio} es : {total}")
                        inicio = inicio + 1
                    End While
                    Console.Write("" + vbCrLf + "¿Quiere volver al menú principal? " + vbCrLf + "Presione la tecla <Y> para continuar, si no preciona cualquier otra letra <X>: ")
                    Dim sigo As String = Console.ReadLine()
                    Console.WriteLine()
                    If sigo = "y" Or sigo = "Y" Then
                        Exit While
                    Else
                        Continue While
                    End If
                End While
            ElseIf respuesta = 3 Then
                While True
                    Dim numGenerado As Int16 = New Random().Next(11)
                    Dim num As Integer
                    Do Until num = numGenerado
                        While True
                            Console.Write("!Prueba suerte e intenta si puedes adivinar el número entre <0-10>¡ : ")
                            num = Console.ReadLine()
                            If num < 0 Or num > 10 Then
                                Console.Write("" + vbCrLf + "ERROR. Opción invalida, número fuera de rango. intentalo de nuevo" + vbCrLf + "" + vbCrLf + "")
                            Else Exit While
                            End If
                        End While
                        If num <> numGenerado Then
                            Console.WriteLine("" + vbCrLf + "SORRY PERDISTE :C , sigue intentando." + vbCrLf + "")
                        Else
                            Console.WriteLine("" + vbCrLf + "!!!YEAHH!!! :D ganaste." + vbCrLf + "")
                            Console.Write("¿Quiere volver al menú principal? " + vbCrLf + "Presione la tecla <Y> para continuar, si no preciona cualquier otra letra <X>: ")
                            Dim sigo As String = Console.ReadLine()
                            If sigo = "y" Or sigo = "Y" Then
                                Exit While
                            Else
                                Continue While
                            End If
                        End If
                    Loop
                End While
            ElseIf respuesta = 4 Then
                Dim numero As Double
                While True
                    Console.Write("Ingrese un número positivo y te mostraremos el factorial: ")
                    numero = Console.ReadLine()
                    If numero <= 0 Then
                        Console.WriteLine("" + vbCrLf + "ERROR. El número ingresado es <0> o es negativo. Vuelve a intentarlo." + vbCrLf + "")
                    Else
                        Exit While
                    End If
                End While
                Dim i As Integer = 2
                Dim total As Double = 1
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
                While True
                    Console.Write("Ingrese un número positivo para ver la tabla de multiplicar: ")
                    Dim numero As Double = Console.ReadLine()
                    Dim num As Double = numero
                    Dim i As Integer = 1
                    Dim total As Double = 1
                    Console.WriteLine()
                    For numero = 1 To 10
                        total = num * i
                        Console.WriteLine($"La multiplicación de {num} * {i} es igual a: {total}")
                        i = i + 1
                    Next
                    Console.WriteLine()
                    Console.Write("¿Quiere volver al menú principal? " + vbCrLf + "Presione la tecla <Y> para continuar, si no preciona cualquier otra letra <X>: ")
                    Dim sigo As String = Console.ReadLine()
                    If sigo = "y" Or sigo = "Y" Then
                        Exit While
                    Else
                        Continue While
                    End If
                End While
            ElseIf respuesta = 6 Then
                While True
                    Console.Write("Escriba una frase o palabra: ")
                    Dim palabra As String = Console.ReadLine()
                    Console.WriteLine()
                    For index = 0 To palabra.Length() - 1
                        Console.Write(palabra.Reverse(index))
                    Next
                    Console.Write("" + vbCrLf + "" + vbCrLf + "¿Quiere volver al menú principal? " + vbCrLf + "Presione la tecla <Y> para continuar, si no preciona cualquier otra letra <X>: ")
                    Dim sigo As String = Console.ReadLine()
                    If sigo = "y" Or sigo = "Y" Then
                        Exit While
                    Else
                        Continue While
                    End If
                End While
            ElseIf respuesta = 7 Then
                Dim cuates() As String = {"1. Gerardo", "2. Glenda", "3. Luna", "4. Fran", "5. Molina"}
                Console.WriteLine("Los mejores programadores de POO :D " + vbCrLf + "")
                For Each nombres As String In cuates
                    Console.WriteLine(nombres + vbCrLf + "")
                Next
            ElseIf respuesta = 8 Then
                While True
                    Console.Write("Escriba una frase o palabra: ")
                    Dim palabra As String = Console.ReadLine()
                    Dim convertir() As String = palabra.Split()
                    palabra.Split()
                    Dim contador As Integer = 1
                    For Each palabras As String In palabra
                        If palabras = " " Then
                            contador = contador + 1
                        End If
                    Next
                    Console.Write("" + vbCrLf + $"la frase <{palabra}> tiene {contador} palabras" + vbCrLf + "" + vbCrLf + "")
                    For Each palabras As String In convertir
                        Console.Write($"La palabra {palabras} tiene { palabras.Length } letras." + vbCrLf + "" + vbCrLf + "")
                    Next
                    Console.Write("¿Quiere volver al menú principal? " + vbCrLf + "Presione la tecla <Y> para continuar, si no preciona cualquier otra letra <X>: ")
                    Dim sigo As String = Console.ReadLine()
                    If sigo = "y" Or sigo = "Y" Then
                        Exit While
                    Else
                        Continue While
                    End If
                End While
            ElseIf respuesta = 9 Then
                While True
                    Dim fin As Integer = 0
                    Dim aumento As Integer = 1
                    Dim arre1(2) As Double
                    Dim arre2(2) As Double
                    Console.Write("Ingresa los primeros 3 números" + vbCrLf + "" + vbCrLf + "")
                    While fin <> 3
                        Console.Write($"Ingrese el número {aumento}: ")
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
                        Console.Write($"Ingrese el número {aumento2}: ")
                        Dim numeros As Double = Console.ReadLine()
                        arre2(fin2) = numeros
                        aumento2 = aumento2 + 1
                        fin2 = fin2 + 1
                    End While
                    Console.WriteLine()
                    For i = 0 To arre1.Length - 1
                        Dim uno As Double = arre1(i)
                        Console.WriteLine("-----------------------------")
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
                    Console.Write("¿Quiere volver al menú principal? " + vbCrLf + "Presione la tecla <Y> para continuar, si no preciona cualquier otra letra <X>: ")
                    Dim sigo As String = Console.ReadLine()
                    If sigo = "y" Or sigo = "Y" Then
                        Exit While
                    Else
                        Continue While
                    End If
                End While
        ElseIf respuesta = 0 Then
                Exit While
            Else
                Console.Write("ERROR. Opción fuera de rango." + vbCrLf + "" + vbCrLf + "")
            End If
        End While
    End Sub
End Module
