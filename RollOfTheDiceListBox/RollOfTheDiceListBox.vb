'Elliot Heiner
'RCET 0265
'Roll of the Dice - List Box
'https://github.com/heinelli/RollOfTheDiceListBox.git

Option Strict On
Option Explicit On
Public Class RollOfTheDiceListBox
    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        Dim diceNumbers(10) As Integer
        Dim headerRow As String
        Dim dataRow As String

        'Total the number of times that each combination is rolled.
        For i = 0 To 1000
            diceNumbers(RandomNumber()) += 1
        Next

        'Create a header with the proper amount of columns.
        DiceRollsListBox.Items.Add("Roll of the Dice".PadLeft(43))
        DiceRollsListBox.Items.Add(StrDup(66, "-"))
        For i = 0 To 10
            headerRow &= CStr(i + 2).PadLeft(5) & "|"
        Next
        DiceRollsListBox.Items.Add(headerRow)
        DiceRollsListBox.Items.Add(StrDup(66, "-"))

        'Concatenate the total of each dice roll into one formatted line.
        For i = 0 To 10
            dataRow &= CStr(diceNumbers(i)).PadLeft(5) & "|"
        Next
        DiceRollsListBox.Items.Add(dataRow)
        DiceRollsListBox.Items.Add(StrDup(66, "-"))
        RollButton.Enabled = False
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
        'Close program
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'Clear all listbox data.
        DiceRollsListBox.Items.Clear()
        RollButton.Enabled = True
    End Sub
End Class
