Module _2_7

    Sub main()

        Console.WriteLine("Ingrese lado del Angulo: ")
        Dim lado As Integer = Console.ReadLine

        Console.WriteLine()

        Select Case lado
            Case 1 To 89
                Console.WriteLine("El valor ingresado corresponde a un Angulo Agudo ")

            Case 90
                Console.WriteLine("El valor ingresado corresponde a un Angulo Recto ")

            Case 91 To 179
                Console.WriteLine("El valor ingresado corresponde a un Angulo Obtuso ")

            Case 180
                Console.WriteLine("El valor ingresado corresponde a un Angulo Llano ")

            Case 181 To 359
                Console.WriteLine("El valor ingresado corresponde a un Angulo Concavo ")

            Case Else
                Console.WriteLine("El valor ingresado esta fuera de los parametros  ")

        End Select

        Console.ReadKey()

    End Sub
End Module
