'Name: Raven Sim
'Date: March 14th, 2019
'Description: Tells you what prizes you can have based on the tickets you won.

Public Class frmTickets

    'VARIABLES
    'How many tickets they have
    Dim tickets As Integer


    Private Sub btnPrize_Click(sender As Object, e As EventArgs) Handles btnPrize.Click

        'check if the textbox is numeric
        If IsNumeric(txtTickets.Text) Then
            'assign the number as the tickets they've earned
            tickets = txtTickets.Text

            'select case for different ranges of tickets and the prizes they can earn 
            Select Case tickets
                Case 0 To 9
                    MsgBox("You don't have enough tickets for a prize. Go play some more games and come back later!", , "Not yet...")
                Case 10 To 49
                    MsgBox("You can choose a keychain, bag of chips, mood ring or bouncy ball!", , "Small prize")
                Case 50 To 99
                    MsgBox("You can choose a teddy bear, goldfish, ring pop, bag of marbles or a printed t-shirt!", , "Medium prize")
                Case 100 To 999
                    MsgBox("You can choose a video game, a slice of pizza, a water bottle or an ice cream cone!", , "Large Prize")
                Case Is >= 100
                    MsgBox("Congrats! You can choose an iPad, a laptop or an ice cube tray!", , "Crazy prize!")
            End Select

        Else
            'if it is not numeric, show an error message
            MsgBox("Please enter a valid number.", , "Error")
        End If

    End Sub
End Class
