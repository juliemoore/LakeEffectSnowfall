' Program Name:     Lake Effect Snowfall
' Author:           Julie Moore
' Date:             February 22, 2018
' Purpose:          The Lake Effect Snowfall program enters the monthly snowfall from
'                   October through April. It display each month snowfall value. After all 
'                   snofall values have been entered, it display the total snowfall amount.

Option Strict On

Public Class frmSnowfall
    Private Sub btnSnowfall_Click(sender As Object, e As EventArgs) Handles btnSnowfall.Click
        ' The btnSnowfall_Click event accepts and display up to 7 months of snowfall values
        ' and then accumulates and displays the total snowfall amount.

        ' Declare and initialize variables

        Dim strSnowfall As String
        Dim decSnowfall As Decimal
        Dim decTotalSnowfall As Decimal = 0D    ' Accumulator
        Dim strInputMessage As String = "Enter the snowfall amount for month #"
        Dim strInputHeading As String = "Monthly Snowfall"
        Dim strNormalMessage As String = "Enter the snowfall amount for month #"
        Dim strNonNumericError As String = "Error - Enter a number for the snowfall amount for month #"
        Dim strNegativeError As String = "Error - Enter a positive number for the snowfall amount for month #"

        'Declar and initialize loop variable

        Dim strCancelClicked As String = ""
        Dim intMaxNumberofEntries As Integer = 7
        Dim intNumberOfEntries As Integer = 1

        ' This loop allows the user to enter the snowfall amount for up to 7 months.
        ' The loop terminates when the user has entered 7 months of snowfall amounts or
        ' the user taps or clicks the Cancel button or the Close button in the InputBox

        strSnowfall = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")

        Do Until intNumberOfEntries > intMaxNumberofEntries Or strSnowfall = strCancelClicked

            If IsNumeric(strSnowfall) Then
                decSnowfall = Convert.ToDecimal(strSnowfall)
                If decSnowfall > 0 Then
                    lstSnowfall.Items.Add("Month " & intNumberOfEntries & ": " & decSnowfall & " inches")
                    decTotalSnowfall += decSnowfall
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If

            If intNumberOfEntries <= intMaxNumberofEntries Then
                strSnowfall = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop

        ' Display total snowfall
        If intNumberOfEntries > 1 Then
            lblTotalSnowfall.Visible = True
            lblTotalSnowfall.Text = "Total snowfall is " & decTotalSnowfall & " inches"
        Else
            MsgBox("No snowfall value entered")
        End If

        ' Disable the snowfall button
        btnSnowfall.Enabled = False

    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        ' the mnuClear click event clears the ListBox object and hides
        ' the total snowfall label. It also enables the snowfall button

        lstSnowfall.Items.Clear()
        lblTotalSnowfall.Visible = False
        btnSnowfall.Enabled = True

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' The mnuExit click event closes the window and exits the application

        Close()
    End Sub
End Class
