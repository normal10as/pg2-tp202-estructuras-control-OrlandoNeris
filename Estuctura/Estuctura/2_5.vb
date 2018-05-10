Module _2_5

    '.CASE.Crear un programa con una enumeración para los meses del año. Ingresar un valor
    'numérico y mostrar a que mes corresponde. Si el valor es inválido mostrar el mensaje
    'correspondiente.


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
        Noviembre
        Diciembre

    End Enum

    Sub main()

        Dim meses = New Meses

        Console.WriteLine("Ingrese un numero de mes: ")
        meses = Console.ReadLine

        If meses > 0 And meses < 13 Then
            Console.WriteLine("El mes ingresado es ' {0} ' ", meses.ToString)
        Else
            Console.WriteLine("Valor fuera ded rango, ingreselo nuevamente...")
        End If

        Console.ReadKey()

    End Sub

End Module
