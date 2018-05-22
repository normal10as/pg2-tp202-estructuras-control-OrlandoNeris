Module _2_8

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
        Dim mes As New Meses
        Dim aux As Integer
        Do
            Console.WriteLine("Ingrese un numero de mes: ")
            aux = Console.ReadLine
        Loop Until aux > 0 And aux < 13
        mes = aux


        Select Case mes
            Case mes.Enero, mes.Marzo, mes.Mayo, mes.Julio, mes.Agosto, mes.Octubre, mes.Diciembre
                Console.WriteLine("El mes de {0} tiene 31 dias. ", mes.ToString)
            Case mes.Febrero
                Console.WriteLine("Ingrese año del mes: ")
                Dim año As Integer = Console.ReadLine
                Console.WriteLine("El mes de febrero del año {0}  tiene {1} dias", año, DateTime.DaysInMonth(año, mes.Febrero))
            Case mes.Abril, mes.Marzo, mes.Septiembre, mes.Noviembre
                Console.WriteLine("El mes de {0} tiene 30 dias. ", mes.ToString)
        End Select

        Console.ReadKey()

    End Sub

End Module
