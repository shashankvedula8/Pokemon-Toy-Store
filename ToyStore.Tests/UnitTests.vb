Imports System
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting


<TestClass()>
Public Class UnitTests
    <TestMethod()>
    Public Sub ExampleOne()
        Dim dictionary As Dictionary(Of Pokemon, Integer) = New Dictionary(Of Pokemon, Integer)()
        Dim availablePokemon As List(Of Pokemon) = Program.GetAvailablePokemon()
        For Each current As Pokemon In availablePokemon
            Dim flag As Boolean = current.Name = "Pikachu"
            If flag Then
                dictionary.Add(current, 1)
            End If
        Next
        Assert.AreEqual(Of Decimal)(6D, ToySale.CalculateTotalCost(dictionary))
    End Sub

    <TestMethod()>
    Public Sub ExampleTwo()
        Dim dictionary As Dictionary(Of Pokemon, Integer) = New Dictionary(Of Pokemon, Integer)()
        Dim availablePokemon As List(Of Pokemon) = Program.GetAvailablePokemon()
        For Each current As Pokemon In availablePokemon
            Dim flag As Boolean = current.Name = "Pikachu"
            If flag Then
                dictionary.Add(current, 2)
            End If
        Next
        Assert.AreEqual(Of Decimal)(12D, ToySale.CalculateTotalCost(dictionary))
    End Sub

    <TestMethod()>
    Public Sub ExampleThree()
        Dim dictionary As Dictionary(Of Pokemon, Integer) = New Dictionary(Of Pokemon, Integer)()
        Dim availablePokemon As List(Of Pokemon) = Program.GetAvailablePokemon()
        For Each current As Pokemon In availablePokemon
            Dim flag As Boolean = current.Name = "Pikachu"
            If flag Then
                dictionary.Add(current, 1)
            Else
                Dim flag2 As Boolean = current.Name = "Squirtle"
                If flag2 Then
                    dictionary.Add(current, 1)
                End If
            End If
        Next
        Assert.AreEqual(Of Decimal)(9.9D, ToySale.CalculateTotalCost(dictionary))
    End Sub

    <TestMethod()>
    Public Sub ExampleFour()
        Dim dictionary As Dictionary(Of Pokemon, Integer) = New Dictionary(Of Pokemon, Integer)()
        Dim availablePokemon As List(Of Pokemon) = Program.GetAvailablePokemon()
        For Each current As Pokemon In availablePokemon
            Dim flag As Boolean = current.Name = "Pikachu"
            If flag Then
                dictionary.Add(current, 2)
            Else
                Dim flag2 As Boolean = current.Name = "Squirtle"
                If flag2 Then
                    dictionary.Add(current, 2)
                End If
            End If
        Next
        Assert.AreEqual(Of Decimal)(19.8D, ToySale.CalculateTotalCost(dictionary))
    End Sub

    <TestMethod()>
    Public Sub ExampleFive()
        Dim dictionary As Dictionary(Of Pokemon, Integer) = New Dictionary(Of Pokemon, Integer)()
        Dim availablePokemon As List(Of Pokemon) = Program.GetAvailablePokemon()
        For Each current As Pokemon In availablePokemon
            Dim flag As Boolean = current.Name = "Pikachu"
            If flag Then
                dictionary.Add(current, 3)
            Else
                Dim flag2 As Boolean = current.Name = "Squirtle"
                If flag2 Then
                    dictionary.Add(current, 3)
                End If
            End If
        Next
        Assert.AreEqual(Of Decimal)(29.7D, ToySale.CalculateTotalCost(dictionary))
    End Sub

    <TestMethod()>
    Public Sub ExampleSix()
        Dim dictionary As Dictionary(Of Pokemon, Integer) = New Dictionary(Of Pokemon, Integer)()
        Dim availablePokemon As List(Of Pokemon) = Program.GetAvailablePokemon()
        For Each current As Pokemon In availablePokemon
            Dim flag As Boolean = current.Name = "Pikachu"
            If flag Then
                dictionary.Add(current, 2)
            Else
                Dim flag2 As Boolean = current.Name = "Squirtle"
                If flag2 Then
                    dictionary.Add(current, 1)
                End If
            End If
        Next
        Assert.AreEqual(Of Decimal)(15.9D, ToySale.CalculateTotalCost(dictionary))
    End Sub

    <TestMethod()>
    Public Sub ExampleSeven()
        Dim dictionary As Dictionary(Of Pokemon, Integer) = New Dictionary(Of Pokemon, Integer)()
        Dim availablePokemon As List(Of Pokemon) = Program.GetAvailablePokemon()
        For Each current As Pokemon In availablePokemon
            Dim flag As Boolean = current.Name = "Pikachu"
            Dim flag2 As Boolean = current.Name = "Squirtle"
            Dim flag3 As Boolean = current.Name = "Charmander"
            If flag Then
                dictionary.Add(current, 1)
            ElseIf flag2 Then
                If flag2 Then
                    dictionary.Add(current, 1)
                End If
            Else
                If flag3 Then
                    dictionary.Add(current, 1)
                End If
            End If
        Next
        Assert.AreEqual(Of Decimal)(12.8D, ToySale.CalculateTotalCost(dictionary))
    End Sub

    <TestMethod()>
    Public Sub ExampleEight()
        Dim dictionary As Dictionary(Of Pokemon, Integer) = New Dictionary(Of Pokemon, Integer)()
        Dim availablePokemon As List(Of Pokemon) = Program.GetAvailablePokemon()
        For Each current As Pokemon In availablePokemon
            Dim flag As Boolean = current.Name = "Pikachu"
            Dim flag2 As Boolean = current.Name = "Squirtle"
            Dim flag3 As Boolean = current.Name = "Charmander"
            If flag Then
                dictionary.Add(current, 2)
            ElseIf flag2 Then
                If flag2 Then
                    dictionary.Add(current, 1)
                End If
            Else
                If flag3 Then
                    dictionary.Add(current, 1)
                End If
            End If
        Next
        Assert.AreEqual(Of Decimal)(18.8D, ToySale.CalculateTotalCost(dictionary))
    End Sub
End Class