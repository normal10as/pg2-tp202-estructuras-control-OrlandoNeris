Module _2_6


    '   .IF: Se ingresan dos valores relativos a un producto en venta: cantidad y precio unitario. Si la
    '   cantidad es entre a 10 y 50 el producto recibe un descuento de 5%, si es entre 51 y 250 el
    '   descuento es del 10% y si es 251 o más el descuento es del 20%. Informar subtotal (cantidad por
    '   precio unitario), porcentaje de descuento aplicado, monto descontado y el total (subtotal –
    '   monto descontado).

    Sub main()
        Dim descuento As Single
        Dim Cantidad, PUnit, SubTotal As Integer

        Console.WriteLine("Ingrese Cantidad del Producto: ")
        Cantidad = Console.ReadLine

        Console.WriteLine("Ingres Precio Unitario del Producto: ")
        PUnit = Console.ReadLine

        descuento = 0

        Select Case Cantidad
            Case 10 To 50
                descuento = 0.05

            Case 51 To 250
                descuento = 0.1

            Case Else
                descuento = 0.2
        End Select


        SubTotal = Cantidad * PUnit

        Console.WriteLine("Subtotal: " & SubTotal)
        Console.WriteLine("Porcentaje de Descuento aplicado: {0} %", descuento * 100)
        Console.WriteLine("Total Descuento: " & SubTotal * descuento)
        Console.WriteLine("Total A Pagar: " & SubTotal - (SubTotal * descuento))

        Console.ReadKey()

    End Sub


End Module
