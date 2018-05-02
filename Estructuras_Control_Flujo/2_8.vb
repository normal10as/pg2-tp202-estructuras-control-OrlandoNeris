Module _2_8
    '    .Elabore un programa que indique cuantos días tiene un mes respetando las siguientes
    'condiciones:
    ' El flujo normal solo se ingresa el número de mes a evaluar y validar con una enumeración.
    ' En el caso de febrero ingresar el año y tener en cuenta que un año bisiesto tiene 29 días. Un
    'año bisiesto es aquél que es múltiplo de 4 y no de 100 o cuando es múltiplo de 400. Por
    'ejemplo, el año 2000 si bisiesto pero el 2100 no lo es.


    Enum Meses As Byte
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
        Dim meses As Meses

        'procedimiento en construccion : V

        'Dim año As Integer
        'Do
        '    Console.Write("Ingrese el valor numerico del año: ")
        '    año = Console.ReadLine
        '    For Each mes In meses

        '    Next

        'Loop Until (año > 1900 And mes <= 9999 And )

        Console.WriteLine("El mes tiene " & DateTime.DaysInMonth(2018, 4) & " Dias. ")



        Console.ReadKey()

    End Sub

End Module
