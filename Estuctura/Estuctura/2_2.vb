Module _2_2

    Sub main()

        Console.WriteLine("Ingrese un numero a evaluar: ")
        Dim valor1 As Integer = Console.ReadLine()


        Console.WriteLine("Ingrese un numero a evaluar: ")
        Dim valor2 As Integer = Console.ReadLine()

        Console.WriteLine("Ingrese un numero a evaluar: ")
        Dim valor3 As Integer = Console.ReadLine()

        If valor1 < valor2 And valor1 < valor3 Then
            Console.WriteLine("El primer valor ingresado es el menor... ")

        ElseIf valor2 < valor1 And valor2 < valor3 Then
            Console.WriteLine("El segundo valor ingresado es el menor... ")

        ElseIf valor3 < valor1 And valor3 < valor2 Then
            Console.WriteLine("El tercer valor ingresado es el menor... ")
        End If

        Console.ReadKey()

    End Sub

End Module
