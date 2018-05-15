Module _2_9

    '    Presentar un menú y preguntar que unidad de medida desea convertir, el valor a convertir y
    '   después mostrar las equivalencias. 

    '   1 pie = 12 pulgadas, 1 yarda = 3 pies, 1
    '   pulgada = 2.54 cm, 1 metro = 100 cm.

    Enum Medidas

        Pulgada = 1
        Pie = 2
        Yarda = 3
        Metro = 4

    End Enum

    Sub main()

        ' Primero convertire todo a cm

        Dim Pulgada As Single = 2.4
        Dim Pie As Single = Pulgada * 12
        Dim Yarda As Single = Pie * 3
        Dim Metro = 100


        Console.WriteLine("Unidad que unidad de medida desea convertir?  ")
        Console.WriteLine("1 Pulgada, 2 pie, yarda 3, metro 4 ... ")
        Dim op As Medidas = Console.ReadLine
        Console.WriteLine("Ingrese cantidad a convertir: ")
        Dim cantidad As UInt16 = Console.ReadLine
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine(" >>>>> Equivalencias <<<<<<")
        Console.WriteLine("Cantidad en Metros: ", cantidad)

    End Sub

End Module
