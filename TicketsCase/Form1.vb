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


            Dim breakpoint(4) As Integer
            breakpoint = {100, 500, 1000, 10000}

            'select case for different ranges of tickets and the prizes they can earn 
            Select Case tickets
                Case 0 To breakpoint(0) - 1
                    MsgBox("You don't have enough tickets for a prize. Go play some more games and come back later!", , "Not yet...")
                Case breakpoint(0) To breakpoint(1) - 1
                    MsgBox("You can choose a keychain, bag of chips, mood ring or bouncy ball!", , "Small prize")
                Case breakpoint(1) To breakpoint(2) - 1
                    MsgBox("You can choose a teddy bear, goldfish, ring pop, bag of marbles or a printed t-shirt!", , "Medium prize")
                Case breakpoint(2) To breakpoint(3) - 1
                    MsgBox("You can choose a video game, a slice of pizza, a water bottle or an ice cream cone!", , "Large Prize")

                Case Is >= breakpoint(3)

                    MsgBox("Congrats! You can choose an iPad, a laptop or an ice cube tray!", , "Crazy prize!")
            End Select

        Else
            'if it is not numeric, show an error message
            MsgBox("Please enter a valid number.", , "Error")
        End If

    End Sub
End Class
