
' Author: Lindsay Allen (Jackson)
' Date: 03/02/21
' Assignment: Chapter 5 - Comic Convention Registration


Public Class ComicConventionRegistrationForm
    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click

        ' Initializes totalCost variable
        Dim totalCost As Decimal

        ' Checks if groupSize is a numeric value, otherwise displays error message
        If IsNumeric(groupSizeInput.Text) Then
            ' Initializes groupSize variable based on user input
            Dim groupSize As Integer = groupSizeInput.Text

            ' Checks if groupSize is a positive number no greater than 20, otherwise displays error message
            If groupSize > 0 AndAlso groupSize <= 20 Then

                ' Calculates the total cost based on the badge type selected
                If conventionRadio.Checked Then
                    totalCost = groupSize * 209
                ElseIf conventionAutographRadio.Checked Then
                    totalCost = groupSize * 275
                ElseIf conventionSuperheroRadio.Checked Then
                    totalCost = groupSize * 380
                Else
                    MsgBox("Please select a badge type")
                End If

            Else
                MsgBox("Please enter a valid numeric value (1-20)")
            End If

        Else
            MsgBox("Please enter a valid numeric value (1-20)")
        End If

        ' Displays the total registration cost
        registrationCostOutputLabel.Text = totalCost.ToString("C")

    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click

        ' Resets the groupSize text field
        groupSizeInput.Text = ""

        ' Resets the registration cost
        registrationCostOutputLabel.Text = ""

    End Sub
End Class
