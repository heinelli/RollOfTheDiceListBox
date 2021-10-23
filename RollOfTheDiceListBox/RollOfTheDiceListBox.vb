﻿'Elliot Heiner
'RCET 0265
'Roll of the Dice - List Box
'

Option Strict On
Option Explicit On
Public Class RollOfTheDiceListBox
    Private Sub RollOfTheDiceListBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Function RandomNumber() As Integer
        Dim rndNumber1 As Single
        Dim rndNumber2 As Single

        'Create two random values from 1-6 and add them together.
        Randomize()
        rndNumber1 = Int((6 * Rnd()) + 1)
        rndNumber2 = Int((6 * Rnd()) + 1)
        Return CInt(rndNumber1 + rndNumber2 - 2)
    End Function

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        Dim diceNumbers(10) As Integer

        'Total the number of times that each combination is rolled.
        For i = 0 To 1000
            diceNumbers(RandomNumber()) += 1
        Next



        'Create a header with the proper amount of columns
        Dim rowData As String
        For i = 0 To 10
            rowData &= CStr(i + 2).PadLeft(5) & "|"
        Next
        DiceRollsListBox.Items.Add(rowData)
        DiceRollsListBox.Items.Add(StrDup(66, "-"))

        Dim diceData As String
        For i = 0 To 10
            diceData &= CStr(diceNumbers(i)).PadLeft(5) & "|"
        Next
        DiceRollsListBox.Items.Add(diceData)
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

    End Sub
End Class
