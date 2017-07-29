Module Module1

    Sub Main()
        Dim a, digit, large As Integer
        large = 0

        Console.Write("enter a number")
        a = Console.ReadLine


        While a > 0

            digit = a Mod 10

            If (digit > large) Then
                large = digit

            End If

            a = a / 10

        End While
        Console.WriteLine(large)
        Console.ReadKey()


    End Sub


End Module

