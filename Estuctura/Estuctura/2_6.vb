Module _2_6

    Sub main()

        Console.WriteLine("Ingrese Cantidad del Producto: ")
        Dim Cantidad As Integer = Console.ReadLine
        Console.WriteLine("Ingrese Precio Unitario del Producto: ")
        Dim Punit As Double = Console.ReadLine

        Dim descuento As Double


        Select Case Cantidad
            Case 0 To 9
                descuento = 0
            Case 10 To 50
                descuento = 0.05
            Case 51 To 250
                descuento = 0.1
            Case Else
                descuento = 0.2
        End Select

        Console.WriteLine("Cantidad del Producto Ingresado: " & Cantidad)
        Console.WriteLine("Precio Unitario: " & Punit)
        Console.WriteLine("Subtotal: " & (Cantidad * Punit))
        Console.WriteLine("¨Porcentaje de Descuento Aplicado: " & descuento * 100)
        Dim totaldesc As Double = (Cantidad * Punit) * descuento
        Console.WriteLine("Total de Descuento: " & totaldesc)
        Console.WriteLine("Total a Pagar: " & (Cantidad * Punit) - totaldesc)

        Console.ReadKey()


    End Sub


End Module
