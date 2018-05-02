Module _2_5

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

        Console.Write("Ingrese Un Valor para el mes: ")
        Dim op As Byte = Console.ReadLine

        Select Case op

            Case 1
                Console.WriteLine("Selecciono el Mes de " & Meses.Enero.ToString)
            Case 2
                Console.WriteLine("Selecciono el Mes de " & Meses.Febrero.ToString)
            Case 3
                Console.WriteLine("Selecciono el Mes de " & Meses.Marzo.ToString)
            Case 4
                Console.WriteLine("Selecciono el Mes de " & Meses.Abril.ToString)
            Case 5
                Console.WriteLine("Selecciono el Mes de " & Meses.Mayo.ToString)
            Case 6
                Console.WriteLine("Selecciono el Mes de " & Meses.Junio.ToString)
            Case 7
                Console.WriteLine("Selecciono el Mes de " & Meses.Julio.ToString)
            Case 8
                Console.WriteLine("Selecciono el Mes de " & Meses.Agosto.ToString)
            Case 9
                Console.WriteLine("Selecciono el Mes de " & Meses.Septiembre.ToString)
            Case 10
                Console.WriteLine("Selecciono el Mes de " & Meses.Octubre.ToString)
            Case 11
                Console.WriteLine("Selecciono el Mes de " & Meses.Noviembre.ToString)
            Case 12
                Console.WriteLine("Selecciono el Mes de " & Meses.Diciembre.ToString)

        End Select

        Console.ReadKey()


    End Sub

End Module
