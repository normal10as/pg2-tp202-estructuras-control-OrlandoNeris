Module _2_7

    Sub main()

        Console.Write("Ingrese valor del angulo: ")
        Dim angulo As Int16 = Console.ReadLine

        Select Case angulo
            Case 1 To 89
                Console.WriteLine("El Angulo Ingresado es Agudo")
            Case 90
                Console.WriteLine("El Angulo Ingresado es Recto")
            Case 91 To 179
                Console.WriteLine("El Angulo Ingresado es Obstuso")
            Case 180
                Console.WriteLine("El Angulo Ingresado es Llano")
            Case 181 To 359
                Console.WriteLine("El Angulo Ingresado es Concavo")
            Case Else
                Console.WriteLine("El valor ingresado no esta en los parametros establecidos.! ")

        End Select

        Console.ReadKey()

    End Sub

End Module
