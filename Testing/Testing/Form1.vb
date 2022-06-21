Public Class Form1
    Dim customernumb As Decimal
    Dim balance As Single
    Dim customername As String
    Dim customernumbint As Integer
    Dim customernumbcorrect As Integer
    Private Sub CmdStart_Click(sender As Object, e As EventArgs) Handles CmdStart.Click
        LSTDisplay.Items.Clear()
        customernumb = InputBox("What's Your Customer Number?")
        customernumbint = customernumb.ToString.Length 'finding if xour account number is already long enough to be accepted first try'
        If customernumbint = 10 Then
            LSTDisplay.Items.Add("Welcome to The Bank. Your Account Number Is Valid.")
        Else
            MsgBox("You Have Many Too Characters Or Too Little Characters, The Maximum Is 10 And The Minimum is 10.")
            Do Until customernumbint = 10
                customernumb = InputBox("What's Your Customer Number?") 'if it isn't you'll get a reapated question to give acustomer number and answer which sazs it too large or too small' 
                customernumbint = customernumb.ToString.Length
                MsgBox("You Have Many Too Characters Or Too Little Characters, The Maximum Is 10 And The Minimum is 10.")
                LSTDisplay.Items.Clear()
            Loop
        End If
        customernumbcorrect = MsgBox("Is This Customer Number Correct? Customer Number Entered:" & customernumb, vbQuestion + vbYesNo + vbDefaultButton2, "Is This Correct?") 'asking weather or not the provided number is correct'
        If customernumbcorrect = vbNo Then
            Do Until customernumbcorrect = vbYes
                LSTDisplay.Items.Clear()
                MsgBox("Please Re-Input Your Account Number")
                customernumb = InputBox("What's Your Customer Number?")
                customernumbint = customernumb.ToString.Length
                ElseIf customernumbint < 9 Or customernumbint > 11 Then
                Do Until customernumbint = 10
                    customernumb = InputBox("What's Your Customer Number?")
                    customernumbint = customernumb.ToString.Length
                    MsgBox("You Have Many Too Characters Or Too Little Characters, The Maximum Is 10 And The Minimum is 10.")
                    LSTDisplay.Items.Clear()
                    Else customernumbcorrect = MsgBox("Is This Customer Number Correct? Customer Number Entered:" & customernumb, vbQuestion + vbYesNo + vbDefaultButton2, "Is This Correct?")
             Loop
            Loop
        End If
        customernumbcorrect = MsgBox("Is This Customer Number Correct? Customer Number Entered:" & customernumb, vbQuestion + vbYesNo + vbDefaultButton2, "Is This Correct?")
            If customernumbcorrect = vbYes Then

        End If
    End Sub

    Private Sub CmdEnd_Click(sender As Object, e As EventArgs) Handles CmdEnd.Click
        End
    End Sub
End Class
