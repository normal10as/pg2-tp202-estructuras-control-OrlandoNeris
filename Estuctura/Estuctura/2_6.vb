Module _2_6


    Enum Meses

        Enero = 1
        Febrero
        Marzo
        Abril
        Mayo
        Junio
        Julio
        Agosto
        Septiembre
        Octubre
        Noviembre
        Diciembre

    End Enum

    Sub main()

        Dim meses = New Meses

        Console.WriteLine("Ingrese un numero de mes: ")
        meses = Console.ReadLine

        Select Case meses
            Case 1 To 12
                Console.WriteLine("El mes ingresado es ' {0} ' ", meses.ToString)
            Case Else
                Console.WriteLine("Valor fuera ded rango, ingreselo nuevamente...")
        End Select

        Console.ReadKey()

    End Sub


End Module
