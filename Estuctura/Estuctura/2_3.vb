Module _2_3

    '    If: Crear un programa que se ingresen 5 valores enteros e informar cual es el mayor por su
    '       posición de ingreso, por ejemplo, dado los siguientes valores: 3,7,12,5,9 informar: “El tercer
    '       número es el mayor valor”

    Sub main()


        Dim mayor, pos As Integer

        Console.WriteLine("Ingrese Primer Numero: ")
        Dim num1 As Integer = Console.ReadLine
        mayor = num1
        pos = 1

        Console.WriteLine("Ingrese Segundo Numero: ")
        Dim num2 As Integer = Console.ReadLine
        If num2 > mayor Then
            mayor = num2
            pos = 2
        End If

        Console.WriteLine("Ingrese Tercer Numero: ")
        Dim num3 As Integer = Console.ReadLine
        If num3 > mayor Then
            mayor = num3
            pos = 3
        End If

        Console.WriteLine("Ingrese Cuarto Numero: ")
        Dim num4 As Integer = Console.ReadLine
        If num4 > mayor Then
            mayor = num4
            pos = 4
        End If

        Console.WriteLine("Ingrese Quinto Numero: ")
        Dim num5 As Integer = Console.ReadLine
        If num5 > mayor Then
            mayor = num5
            pos = 5
        End If

        Console.WriteLine("El Mayor de los Numeros de Serie fue el " & mayor)
        Console.WriteLine("Ubicado en la " & pos & "°  Posicion.")


        Console.ReadKey()


    End Sub


End Module
