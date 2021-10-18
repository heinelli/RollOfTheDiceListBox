'Elliot Heiner
'RCET 0265
'Roll of the Dice - List Box
'

Option Strict On
Option Explicit On
Public Class RollOfTheDiceListBox
    Private Sub RollOfTheDiceListBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DiceRollsListBox.Items.Add("Line 1")
        DiceRollsListBox.Items.Add("Line 2")
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
