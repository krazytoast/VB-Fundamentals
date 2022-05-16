Module MainModule
    Dim Name As String = "Mountain Bike"

    Sub Main()
        If True Then
            Dim Name As String = "Tricycle"
            Dim ListPrice As Decimal = 59.99
        End If

        Console.WriteLine(Name)
        ' The following does not compile
        ' Console.WriteLine(ListPrice)

        Console.ReadKey()
    End Sub

End Module
