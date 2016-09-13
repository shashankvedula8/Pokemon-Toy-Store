Imports System
Imports System.Collections.Generic


Public Module ToySale
    Private Function GetDiscountInformation() As Integer(,)
        Dim array As Integer(,) = New Integer(3 - 1, 1 - 1) {}
        array(0, 0) = 0
        array(1, 0) = 10
        array(2, 0) = 20
        Return array
    End Function

    Public Function CalculateTotalCost(toyCart As Dictionary(Of Pokemon, Integer)) As Decimal
        Dim discountInformation As Integer(,) = ToySale.GetDiscountInformation()
        Dim num As Decimal = 0D
        While toyCart.Count > 0
            Dim count As Integer = toyCart.Count
            Dim num2 As Integer = discountInformation(count - 1, 0)
            Dim array As Integer() = New Integer(toyCart.Count - 1) {}
            Dim num3 As Integer = 0
            For Each current As KeyValuePair(Of Pokemon, Integer) In toyCart
                Dim flag As Boolean = current.Value > 0
                If flag Then
                    array(num3) = current.Value
                    num3 += 1
                End If
            Next
            Dim num4 As Integer = ToySale.CalculateGCD(array)
            Dim array2 As Pokemon() = New Pokemon(toyCart.Count - 1) {}
            toyCart.Keys.CopyTo(array2, 0)
            Dim array3 As Pokemon() = array2
            For i As Integer = 0 To array3.Length - 1
                Dim pokemon As Pokemon = array3(i)
                Dim flag2 As Boolean = toyCart(pokemon) >= num4
                If flag2 Then
                    num += pokemon.Cost * num4
                    Dim key As Pokemon = pokemon
                    toyCart(key) -= num4
                End If
                Dim flag3 As Boolean = toyCart(pokemon) = 0
                If flag3 Then
                    toyCart.Remove(pokemon)
                End If
            Next
            num *= (100 - num2) / 100D
        End While
        Return num
    End Function

    Private Function CalculateGCD(inputNumbers As Integer()) As Integer
        Dim flag As Boolean = inputNumbers.Length = 1
        Dim result As Integer
        If flag Then
            result = inputNumbers(0)
        Else
            Dim num As Integer = ToySale.CalculateGCD(inputNumbers(0), inputNumbers(1))
            For i As Integer = 2 To inputNumbers.Length - 1
                num = ToySale.CalculateGCD(num, inputNumbers(i))
            Next
            result = num
        End If
        Return result
    End Function

    Private Function CalculateGCD(firstNumber As Integer, secondNumber As Integer) As Integer
        Dim result As Integer = 1
        Dim num As Integer = If((firstNumber > secondNumber), secondNumber, firstNumber)
        For i As Integer = 2 To num
            Dim flag As Boolean = firstNumber Mod i = 0 AndAlso secondNumber Mod i = 0
            If flag Then
                result = i
            End If
        Next
        Return result
    End Function
End Module