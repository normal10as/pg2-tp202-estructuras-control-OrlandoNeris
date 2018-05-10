Module _2_4


    Sub main()

        Console.WriteLine("Ingrese Cantidad del Producto: ")
        Dim Cantidad As Integer = Console.ReadLine
        Console.WriteLine("Ingrese Precio Unitario del Producto: ")
        Dim Punit As Double = Console.ReadLine

        Dim descuento As Double

        If Cantidad > 10 And Cantidad <= 50 Then
            descuento = 0.05
        ElseIf Cantidad > 50 And Cantidad <= 250 Then
            descuento = 0.1
        ElseIf Cantidad > 250 Then
            descuento = 0.2
        End If

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
