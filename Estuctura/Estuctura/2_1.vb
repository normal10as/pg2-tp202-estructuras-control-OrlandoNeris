Module _2_1

    Sub main()

        Console.WriteLine("Ingrese un numero a evaluar: ")
        Dim valor1 As Integer = Console.ReadLine

        Console.WriteLine("Ingrese otro numero a evaluar: ")
        Dim valor2 As Integer = Console.ReadLine

        If valor1 > valor2 Then
            Console.WriteLine("El primer valor ' {0} ' es mayor al segundo ' {1} '", valor1, valor2)

        ElseIf valor2 > valor1 Then
            Console.WriteLine("El segundo valor ' {0} ', es mayor al primero ' {1} '. ", valor2, valor1)

        Else
            Console.WriteLine("Los dos numeros ingresados son iguales. ")

        End If


        Console.ReadKey()

    End Sub
End Module
