Public Class Form1
    Dim customernumb As Decimal
    Dim balance As Single
    Dim customername As String
    Dim customernumbcount As Decimal
    Dim customernumbcorrect As Integer
    Dim customerpass As Boolean
    Dim useracc As Integer
    Dim signup As Integer
    Dim password As Object = 123
    Dim fname As String
    Dim lname As String
    Dim correctpassword As Object
    Private Sub CmdStart_Click(sender As Object, e As EventArgs) Handles CmdStart.Click
        LSTDisplay.Items.Clear()
        useracc = MsgBox("Do You Have An Acoount?", vbQuestion + vbYesNo + vbDefaultButton2, "Do You Have An Account?")
        If useracc = vbNo Then
            signup = MsgBox("Would You Like To Make An Account?", vbQuestion + vbYesNo + vbDefaultButton2, "Sign Up?")
            If signup = vbNo Then
                MsgBox("This Application Will Now Close.")
                End
            ElseIf signup = vbYes Then
                fname = InputBox("Please Enter Your First Name")
                    lname = InputBox("Please Enter Your Second name")
                    password = InputBox("Please Enter A New Password For Your Account")
                    customernumb = InputBox("Please Enter A New Customer Number (10 Digits Max)")
                    customernumbcount = customernumb.ToString.Length
                    If customernumbcount <> 10 Then
                        Do Until customernumbcount = 10
                            MsgBox("You Cannot Use This Customer Number, Because, The Maximum Is 10 And The Minimum Is 10.")
                            customernumb = InputBox("Please Enter A New Customer Number")
                        Loop
                    ElseIf customernumbcount = 10 Then
                        MsgBox("Registration Successful!")
                        LSTDisplay.Items.Add("Your New Customer Number Is " & customernumb)
                    End If
                End If
            End If
            customernumb = InputBox("What's Your Customer Number?")
                customernumbcount = customernumb.ToString.Length 'finding if xour account number is already long enough to be accepted first try'
        If customernumbcount = 10 Then
            LSTDisplay.Items.Add("Welcome to The Bank. Your Account Number Is Valid.")
        Else
            Do Until customernumbcount = 10
                customernumb = InputBox("What's Your Customer Number?") 'if it isn't you'll get a reapated question to give acustomer number and answer which sazs it too large or too small' 
                customernumbcount = customernumb.ToString.Length
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
                customernumbcount = customernumb.ToString.Length
            Loop
            If customernumbcount <> 10 Then
                Do Until customernumbcount = 10
                    customernumb = InputBox("What's Your Customer Number?")
                    customernumbcount = customernumb.ToString.Length
                    MsgBox("You Have Many Too Characters Or Too Little Characters, The Maximum Is 10 And The Minimum is 10.")
                    LSTDisplay.Items.Clear()
                Loop
            Else
                customernumbcorrect = MsgBox("Is This Customer Number Correct? Customer Number Entered: " & customernumb, vbQuestion + vbYesNo + vbDefaultButton2, "Is This Correct?")
            End If
        End If
        If customernumbcorrect = vbYes Then
            customerpass = InputBox("Whats Is The Password To This Account?")
            correctpassword = InputBox("What's The Password? (Default Is 123)")
            If correctpassword = password Then
                MsgBox("Password Is Correct!")
            End If
        ElseIf correctpassword <> password Then
            Do Until correctpassword = password
                MsgBox("Password Is Incorrect!")
                correctpassword = InputBox("What's The Password? (Default Is 123)")
            Loop
        End If

    End Sub

    Private Sub CmdEnd_Click(sender As Object, e As EventArgs) Handles CmdEnd.Click
        End
    End Sub
End Class
