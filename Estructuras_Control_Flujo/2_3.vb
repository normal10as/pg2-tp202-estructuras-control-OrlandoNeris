
Module _2_3

    '.IF: Crear un programa que se ingresen 5 valores enteros e informar cual es el mayor por su
    'posición de ingreso, por ejemplo, dado los siguientes valores: 3,7,12,5,9 informar: “El tercer
    'número es el mayor valor”

    Sub main()

        Dim valor, max As Integer
        Dim pos As Byte

        Console.WriteLine("Ingrese El Primer Valor: ")
        valor = Console.ReadLine
        pos = 1
        max = valor

        Console.WriteLine("Ingrese El Segundo Valor: ")
        valor = Console.ReadLine
        If valor > max Then
            pos = 2
            max = valor
        End If

        Console.WriteLine("Ingrese El Tercer Valor: ")
        valor = Console.ReadLine
        If valor > max Then
            pos = 3
            max = valor
        End If

        Console.WriteLine("Ingrese El Cuarto Valor: ")
        valor = Console.ReadLine
        If valor > max Then
            pos = 4
            max = valor
        End If


        Console.WriteLine("Ingrese El Quinto Valor: ")
        valor = Console.ReadLine
        If valor > max Then
            pos = 5
            max = valor
        End If

        Console.WriteLine("El Mayor de los Numeros Ingresados es el {0} Ingresado en la Posicion {1}", max, pos)
        Console.ReadKey()

    End Sub



End Module
