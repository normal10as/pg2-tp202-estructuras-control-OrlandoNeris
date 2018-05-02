Module Module1

    '.IF: Crear un módulo en el cual se ingresan dos valores numéricos e informar por pantalla cuál es
    'la relación entre ambos: mayor, menor o igual.


    Sub Main()

        Dim valor1, valor2 As Integer

        Console.WriteLine("Ingrese Primer Valor: ")
        valor1 = Console.ReadLine

        Console.WriteLine("Ingrese Segundo Valor: ")
        valor2 = Console.ReadLine

        If valor1 > valor2 Then
            Console.WriteLine("El Numero {0}  es Mayor al Numero {1} ", valor1, valor2)

        ElseIf valor2 > valor1 Then
            Console.WriteLine("El Numero {0}  es Mayor al Numero {1} ", valor2, valor1)

        Else
            Console.WriteLine("Los Numeros Ingresados son Iguales. ")
        End If





        Console.ReadKey()
    End Sub

End Module
