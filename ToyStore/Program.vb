Imports System
Imports System.Collections.Generic


Public Class Program
    Public Shared Sub Main(args As String())
        Console.WriteLine("Welcome to the Toy Store. Please choose quantity of each of the available pokemons")
        Dim dictionary As Dictionary(Of Pokemon, Integer) = New Dictionary(Of Pokemon, Integer)()
        For Each current As Pokemon In Program.GetAvailablePokemon()
            Console.Write("How many of {0}'s do you want? ", current.Name)
            Dim text As String = Console.ReadLine()
            text = (If(text, ""))
            Dim num As Integer = Integer.Parse(text)
            Dim flag As Boolean = num > 0
            If flag Then
                dictionary.Add(current, num)
            End If
        Next
        Console.WriteLine("{0:.00}", ToySale.CalculateTotalCost(dictionary))
        Console.ReadLine()
    End Sub

    Public Shared Function GetAvailablePokemon() As List(Of Pokemon)
        Return New List(Of Pokemon)() From {New Pokemon() With {.Id = 1, .Name = "Pikachu", .Cost = 6D}, New Pokemon() With {.Id = 2, .Name = "Squirtle", .Cost = 5D}, New Pokemon() With {.Id = 3, .Name = "Charmander", .Cost = 5D}}
    End Function
End Class