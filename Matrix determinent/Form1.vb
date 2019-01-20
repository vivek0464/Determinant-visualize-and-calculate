Public Class form
    'variable declaration to store cell values
    Dim R1C1 As Double
    Dim R1C2 As Double
    Dim R1C3 As Double
    Dim R2C1 As Double
    Dim R2C2 As Double
    Dim R2C3 As Double
    Dim R3C1 As Double
    Dim R3C2 As Double
    Dim R3C3 As Double

    'to store the final output
    Dim value As Double

    'useful in hiding and showing the formula
    Dim cnt As Integer = 0

    'useful in transitions in visualization
    Dim temp As Integer

    'btn to calculate the final output
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'to check error occured or not
        Dim check As Integer = 0

        'initially output should be empty
        textValue.Text = ""

        'try and catch for the bugs on conveting string in decimal form
        Try
            R1C1 = CDec(text11.Text)
            R1C2 = CDec(text12.Text)
            R1C3 = CDec(text13.Text)
            R2C1 = CDec(text21.Text)
            R2C2 = CDec(text22.Text)
            R2C3 = CDec(text23.Text)
            R3C1 = CDec(text31.Text)
            R3C2 = CDec(text32.Text)
            R3C3 = CDec(text33.Text)
        Catch ex As Exception
            'if input given in any cell is invalid
            MsgBox("please enter a valid input")

            'check goes high on detecting error
            check = 1
        End Try

        Try
            'applying formula to calculate the output
            value = R1C1 * (R2C2 * R3C3 - R2C3 * R3C2) - R1C2 * (R2C1 * R3C3 - R2C3 * R3C1) + R1C3 * (R2C1 * R3C2 - R3C1 * R2C2)
        Catch ex As Exception
            'if output goes out of range
            MsgBox("please check your input size")

            'check goes high on detecting error
            check = 1
        End Try

        If check = 1 Then
            'if error occured show no output
            textValue.Text = ""
        Else
            'else show the value calculated
            textValue.AppendText(CStr(value))
        End If

    End Sub

    Private Sub text11_TextChanged(sender As Object, e As EventArgs) Handles text11.TextChanged
        'if input in any cell changes make output empty
        textValue.Text = ""
    End Sub

    Private Sub text12_TextChanged(sender As Object, e As EventArgs) Handles text12.TextChanged
        'if input in any cell changes make output empty
        textValue.Text = ""
    End Sub

    Private Sub text13_TextChanged(sender As Object, e As EventArgs) Handles text13.TextChanged
        'if input in any cell changes make output empty
        textValue.Text = ""
    End Sub

    Private Sub text21_TextChanged(sender As Object, e As EventArgs) Handles text21.TextChanged
        'if input in any cell changes make output empty
        textValue.Text = ""
    End Sub

    Private Sub text22_TextChanged(sender As Object, e As EventArgs) Handles text22.TextChanged
        'if input in any cell changes make output empty
        textValue.Text = ""
    End Sub

    Private Sub text23_TextChanged(sender As Object, e As EventArgs) Handles text23.TextChanged
        'if input in any cell changes make output empty
        textValue.Text = ""
    End Sub

    Private Sub text31_TextChanged(sender As Object, e As EventArgs) Handles text31.TextChanged
        'if input in any cell changes make output empty
        textValue.Text = ""
    End Sub

    Private Sub text32_TextChanged(sender As Object, e As EventArgs) Handles text32.TextChanged
        'if input in any cell changes make output empty
        textValue.Text = ""
    End Sub

    Private Sub text33_TextChanged(sender As Object, e As EventArgs) Handles text33.TextChanged
        'if input in any cell changes make output empty
        textValue.Text = ""
    End Sub

    'Sub to clear all cells
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'to clear every cell
        text11.Text = ""
        text12.Text = ""
        text13.Text = ""
        text21.Text = ""
        text22.Text = ""
        text23.Text = ""
        text31.Text = ""
        text32.Text = ""
        text33.Text = ""
        textValue.Text = ""
    End Sub

    'Sub to redirect on clicking on the link
    Private Sub labelLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles labelLink.LinkClicked
        'link to redirect to wikipedia article
        Process.Start("https://en.wikipedia.org/wiki/Determinant")
    End Sub

    'to hide and show the formula
    Private Sub btnFormula_Click(sender As Object, e As EventArgs) Handles btnFormula.Click
        'if even clicks ,show the formula
        If cnt Mod 2 = 0 Then
            labelFormula.Text = "R1C1 * (R2C2 * R3C3 - R2C3 * R3C2) - R1C2 * (R2C1 * R3C3 - R2C3 * R3C1) + R1C3 * (R2C1 * R3C2 - R2C2 * R3C1)"
        Else
            'if odd clicks ,then hide formula
            labelFormula.Text = ""
        End If
        'incrementing cnt to alter the formula visibility on click
        cnt = cnt + 1
    End Sub

    Private Sub btnVisualize_Click(sender As Object, e As EventArgs) Handles btnVisualize.Click
        'to visualize the determinant finding process
        temp = 0

        'make background black for better visualization
        Me.BackColor = Color.Black

        'enable the timer
        Timer1.Enabled = True

    End Sub

    'Sub which starts executing when timer is enabled
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'initially start with R1C1 and its sub-matrix for finding determinant
        If temp = 0 Then
            text11.BackColor = Color.Green
            text12.BackColor = Color.White
            text13.BackColor = Color.White
            text21.BackColor = Color.White
            text22.BackColor = Color.Yellow
            text23.BackColor = Color.Cyan
            text31.BackColor = Color.White
            text32.BackColor = Color.Cyan
            text33.BackColor = Color.Yellow

            'move to R1C2 and its sub-matrix for finding determinant after 1 interval
        ElseIf temp = 1 Then
            text11.BackColor = Color.White
            text12.BackColor = Color.Green
            text13.BackColor = Color.White
            text21.BackColor = Color.Yellow
            text22.BackColor = Color.White
            text23.BackColor = Color.Cyan
            text31.BackColor = Color.Cyan
            text32.BackColor = Color.White
            text33.BackColor = Color.Yellow

            'move to R1C3 and its sub-matrix for finding determinant after 1 interval
        ElseIf temp = 2 Then
            text11.BackColor = Color.White
            text12.BackColor = Color.White
            text13.BackColor = Color.Green
            text21.BackColor = Color.Yellow
            text22.BackColor = Color.Cyan
            text23.BackColor = Color.White
            text31.BackColor = Color.Cyan
            text32.BackColor = Color.Yellow
            text33.BackColor = Color.White
        Else

            'come to initial state after visualization
            text11.BackColor = Color.White
            text12.BackColor = Color.White
            text13.BackColor = Color.White
            text21.BackColor = Color.White
            text22.BackColor = Color.White
            text23.BackColor = Color.White
            text31.BackColor = Color.White
            text32.BackColor = Color.White
            text33.BackColor = Color.White

            'initial background color
            Me.BackColor = Color.FromArgb(255, 192, 128)

            'stop the timer
            Timer1.Stop()
        End If

        'incrementing temp variable per interval
        temp = temp + 1
    End Sub

End Class