Module _2_2

    '    IF: ingresar tres valores y mostrar el menor.

    Sub main()

        Dim valor1, valor2, valor3 As Integer

        Console.WriteLine("Ingrese El Primer Valor:  ")
        valor1 = Console.ReadLine

        Console.WriteLine("Ingrese El Segundo Valor:  ")
        valor2 = Console.ReadLine

        Console.WriteLine("Ingrese El Tercer Valor:  ")
        valor3 = Console.ReadLine

        If valor1 > valor2 And valor1 > valor3 Then

            Console.WriteLine("El Numero {0}, es Mayor a los Numeros {1} y {2}. ", valor1, valor2, valor3)

        ElseIf valor2 > valor1 And valor2 > valor3 Then

            Console.WriteLine("El Numero {0}, es Mayor a los Numeros {1} y {2}. ", valor2, valor3, valor1)

        ElseIf valor3 > valor1 And valor3 > valor2 Then

            Console.WriteLine("El Numero {0}, es Mayor a los Numeros {1} y {2}. ", valor3, valor1, valor2)

        End If

        Console.ReadKey()

    End Sub
End Module
