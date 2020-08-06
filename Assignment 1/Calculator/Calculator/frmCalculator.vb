'Affirmation of Authorship:

'Name: Aaron Alvarez

'Date: 05/18/2020

'I affirm that this program was created by me. It is solely my work and ‘does not include any work done by anyone else.

Public Class frmCalculator
    ' Declaration of Global Variables
    Dim Number1 As Double = 0.0
    Dim Number2 As Double = 0.0
    Dim Operator1 As String = ""
    ' This variable will serve to validate that only two numbers are used in the equation
    Dim count As Integer = 0

    Private Sub lblInput_Click(sender As Object, e As EventArgs) Handles lblInput.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lblMemoryLabel_Click(sender As Object, e As EventArgs) Handles lblMemoryLabel.Click

    End Sub

    Private Sub lblResultLabel_Click_1(sender As Object, e As EventArgs) Handles lblResultLabel.Click

    End Sub

    Private Sub lblEquationLabel_Click(sender As Object, e As EventArgs) Handles lblEquationLabel.Click

    End Sub

    Private Sub btnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click
        ' Clear the Input
        txtInput.Text = ""

        ' Set focus for input
        txtInput.Focus()
    End Sub

    Private Sub frmCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set focus for input
        txtInput.Focus()
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        ' Variable
        Dim strMessage As String = ""

        ' Validate that only two numbers are used in the equation
        If count = 0 Then
            ' Validate Input type
            If txtInput.Text = String.Empty Then
                strMessage = "Please enter a value"
            ElseIf Not IsNumeric(txtInput.Text) Then
                strMessage = "Please enter a numeric value"
                txtInput.Text = ""
            Else
                ' Get the Input from the user.
                If Double.TryParse(txtInput.Text, Number1) Then
                    count += 1
                Else
                    strMessage = "Cannot convert to double"
                End If
            End If
        Else
            ' Validate that operator is selected
            If Operator1 <> "+" And txtInput.Text = "" Then
                Operator1 = "+"
            Else
                strMessage = "Please press = to finih your calculation"
            End If
        End If

        ' If error show message 
        ' Else get Operator sign and clear Input.
        If strMessage <> "" Then
            MessageBox.Show(strMessage)
        Else
            Operator1 = "+"
            txtInput.Text = ""
        End If

        ' Set focus for input
        txtInput.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear values in Number1,2, Operator, Input, Equation and Result
        txtInput.Text = ""
        Number1 = 0.0
        Number2 = 0.0
        Operator1 = ""
        lblEquation.Text = ""
        lblResult.Text = ""
        count= 0

        ' Set focus for input
        txtInput.Focus()
    End Sub

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        ' Variables
        Dim strMessage As String = ""
        Dim result As Double = 0.0

        ' Validate that an Operator is selected
        If Operator1 <> "" Then
            ' Validate Input type
            If txtInput.Text = String.Empty Then
                strMessage = "Please enter a value"
            ElseIf Not IsNumeric(txtInput.Text) Then
                strMessage = "Please enter a numeric value"
            Else
                ' Get the Input from the user.
                If Double.TryParse(txtInput.Text, Number2) Then
                    ' Clear Input
                    txtInput.Text = ""
                Else
                    strMessage = "Cannot convert to double"
                End If
            End If
        End If

        ' If error show message 
        ' Else perform calculation based on Operator type.
        If strMessage <> "" Then
            MessageBox.Show(strMessage)
        Else
            If Operator1 = "+" Then
                ' Perform calculation based on Number1, Operator and Number2
                result = Number1 + Number2
                ' Set the Equation to string of calculation
                lblEquation.Text = Number1.ToString & " " & Operator1.ToString & " " & Number2.ToString
                ' Result to numeric value of calculation
                lblResult.Text = result.ToString
                ' Set 0 to count
                count = 0
                ' Clear operator
                Operator1 = ""
            ElseIf Operator1 = "-" Then
                ' Perform calculation based on Number1, Operator and Number2
                result = Number1 - Number2
                ' Set the Equation to string of calculation
                lblEquation.Text = Number1.ToString & " " & Operator1.ToString & " " & Number2.ToString
                ' Result to numeric value of calculation
                lblResult.Text = result.ToString
                ' Set 0 to count
                count = 0
                ' Clear operator
                Operator1 = ""
            ElseIf Operator1 = "*" Then
                ' Perform calculation based on Number1, Operator and Number2
                result = Number1 * Number2
                ' Set the Equation to string of calculation
                lblEquation.Text = Number1.ToString & " " & Operator1.ToString & " " & Number2.ToString
                ' Result to numeric value of calculation
                lblResult.Text = result.ToString
                ' Set 0 to count
                count = 0
                ' Clear operator
                Operator1 = ""
            ElseIf Operator1 = "^" Then
                ' Perform calculation based on Number1, Operator and Number2
                result = Math.Pow(Number1, Number2)
                ' Set the Equation to string of calculation
                lblEquation.Text = Number1.ToString & " " & Operator1.ToString & " " & Number2.ToString
                ' Result to numeric value of calculation
                lblResult.Text = result.ToString
                ' Set 0 to count
                count = 0
                ' Clear operator
                Operator1 = ""
            ElseIf Operator1 = "/" Then
                If Number2 = 0 Then
                    MessageBox.Show("You can't divide by zero, please write a different number")
                Else
                    ' Perform calculation based on Number1, Operator and Number2
                    result = Number1 / Number2
                    ' Set the Equation to string of calculation
                    lblEquation.Text = Number1.ToString & " " & Operator1.ToString & " " & Number2.ToString
                    ' Result to numeric value of calculation
                    lblResult.Text = result.ToString
                    ' Set 0 to count
                    count = 0
                    ' Clear operator
                    Operator1 = ""
                End If
            ElseIf Operator1 = "Mod" Then
                ' Perform calculation based on Number1, Operator and Number2
                result = Number1 Mod Number2
                ' Set the Equation to string of calculation
                lblEquation.Text = Number1.ToString & " " & Operator1.ToString & " " & Number2.ToString
                ' Result to numeric value of calculation
                lblResult.Text = result.ToString
                ' Set 0 to count
                count = 0
                ' Clear operator
                Operator1 = ""
            End If
        End If

        ' Set focus for input
        txtInput.Focus()

    End Sub

    Private Sub btnNegative_Click(sender As Object, e As EventArgs) Handles btnNegative.Click
        ' Variables
        Dim strMessage As String = ""
        Dim result As Double = 0.0

        ' Validate Input type
        If txtInput.Text = String.Empty Then
            strMessage = "Please enter a value"
        ElseIf Not IsNumeric(txtInput.Text) Then
            strMessage = "Please enter a numeric value"
            txtInput.Text = ""
        Else
            ' Get the Input from the user.
            If Double.TryParse(txtInput.Text, result) Then
            Else
                strMessage = "Cannot convert to double"
            End If
        End If

        ' If error show message 
        ' Else perform calculation based on Operator type.
        If strMessage <> "" Then
            MessageBox.Show(strMessage)
        Else
            ' Perform change of sign
            result = result * (-1)
            txtInput.Text = result.ToString
        End If

        ' Set focus for input
        txtInput.Focus()
    End Sub

    Private Sub btnMC_Click(sender As Object, e As EventArgs) Handles btnMC.Click
        ' Set memory to 0
        lblMemory.Text = "0"

        ' Set focus for input
        txtInput.Focus()
    End Sub

    Private Sub btnMS_Click(sender As Object, e As EventArgs) Handles btnMS.Click
        ' Validate that Input is not empty
        If txtInput.Text <> "" Then
            lblMemory.Text = txtInput.Text
        End If

        ' Set focus for input
        txtInput.Focus()
    End Sub

    Private Sub btnMR_Click(sender As Object, e As EventArgs) Handles btnMR.Click
        ' Validate that Memory is not empty
        If lblMemory.Text <> "" Then
            txtInput.Text = lblMemory.Text
        End If

        ' Set focus for input
        txtInput.Focus()
    End Sub

    Private Sub btnRest_Click(sender As Object, e As EventArgs) Handles btnRest.Click
        ' Variable
        Dim strMessage As String = ""

        ' Validate that only two numbers are used in the equation
        If count = 0 Then
            ' Validate Input type
            If txtInput.Text = String.Empty Then
                strMessage = "Please enter a value"
            ElseIf Not IsNumeric(txtInput.Text) Then
                strMessage = "Please enter a numeric value"
                txtInput.Text = ""
            Else
                ' Get the Input from the user.
                If Double.TryParse(txtInput.Text, Number1) Then
                    count += 1
                Else
                    strMessage = "Cannot convert to double"
                End If
            End If
        Else
            ' Validate that operator is selected
            If Operator1 <> "-" And txtInput.Text = "" Then
                Operator1 = "-"
            Else
                strMessage = "Please press = to finih your calculation"
            End If
        End If

        ' If error show message 
        ' Else get Operator sign and clear Input.
        If strMessage <> "" Then
            MessageBox.Show(strMessage)
        Else
            Operator1 = "-"
            txtInput.Text = ""
        End If

        ' Set focus for input
        txtInput.Focus()
    End Sub

    Private Sub btnMultiplication_Click(sender As Object, e As EventArgs) Handles btnMultiplication.Click
        ' Variable
        Dim strMessage As String = ""

        ' Validate that only two numbers are used in the equation
        If count = 0 Then
            ' Validate Input type
            If txtInput.Text = String.Empty Then
                strMessage = "Please enter a value"
            ElseIf Not IsNumeric(txtInput.Text) Then
                strMessage = "Please enter a numeric value"
                txtInput.Text = ""
            Else
                ' Get the Input from the user.
                If Double.TryParse(txtInput.Text, Number1) Then
                    count += 1
                Else
                    strMessage = "Cannot convert to double"
                End If
            End If
        Else
            ' Validate that operator is selected
            If Operator1 <> "*" And txtInput.Text = "" Then
                Operator1 = "*"
            Else
                strMessage = "Please press = to finih your calculation"
            End If
        End If

        ' If error show message 
        ' Else get Operator sign and clear Input.
        If strMessage <> "" Then
            MessageBox.Show(strMessage)
        Else
            Operator1 = "*"
            txtInput.Text = ""
        End If

        ' Set focus for input
        txtInput.Focus()
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        ' Message variable
        Dim strMessage As String = ""

        ' Validate that only two numbers are used in the equation
        If count = 0 Then
            ' Validate Input type
            If txtInput.Text = String.Empty Then
                strMessage = "Please enter a value"
            ElseIf Not IsNumeric(txtInput.Text) Then
                strMessage = "Please enter a numeric value"
                txtInput.Text = ""
            Else
                ' Get the Input from the user.
                If Double.TryParse(txtInput.Text, Number1) Then
                    count += 1
                Else
                    strMessage = "Cannot convert to double"
                End If
            End If
        Else
            ' Validate that operator is selected
            If Operator1 <> "/" And txtInput.Text = "" Then
                Operator1 = "/"
            Else
                strMessage = "Please press = to finih your calculation"
            End If
        End If

        ' If error show message 
        ' Else get Operator sign and clear Input.
        If strMessage <> "" Then
            MessageBox.Show(strMessage)
        Else
            Operator1 = "/"
            txtInput.Text = ""
        End If

        ' Set focus for input
        txtInput.Focus()
    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged

    End Sub

    Private Sub btnModulo_Click(sender As Object, e As EventArgs) Handles btnModulo.Click
        ' Variable
        Dim strMessage As String = ""

        ' Validate that only two numbers are used in the equation
        If count = 0 Then
            ' Validate Input type
            If txtInput.Text = String.Empty Then
                strMessage = "Please enter a value"
            ElseIf Not IsNumeric(txtInput.Text) Then
                strMessage = "Please enter a numeric value"
                txtInput.Text = ""
            Else
                ' Get the Input from the user.
                If Double.TryParse(txtInput.Text, Number1) Then
                    count += 1
                Else
                    strMessage = "Cannot convert to double"
                End If
            End If
        Else
            ' Validate that operator is selected
            If Operator1 <> "Mod" And txtInput.Text = "" Then
                Operator1 = "Mod"
            Else
                strMessage = "Please press = to finih your calculation"
            End If
        End If

        ' If error show message 
        ' Else get Operator sign and clear Input.
        If strMessage <> "" Then
            MessageBox.Show(strMessage)
        Else
            Operator1 = "Mod"
            txtInput.Text = ""
        End If

        ' Set focus for input
        txtInput.Focus()
    End Sub

    Private Sub btnLogarithm_Click(sender As Object, e As EventArgs) Handles btnLogarithm.Click
        ' Variables
        Dim strMessage As String = ""
        Dim result As Double = 0.0

        ' Verify that only one number is in the equation
        If count = 0 Then
            ' Validate Input type
            If txtInput.Text = String.Empty Then
                strMessage = "Please enter a value"
            ElseIf Not IsNumeric(txtInput.Text) Then
                strMessage = "Please enter a numeric value"
                txtInput.Text = ""
            Else
                ' Get the Input from the user.
                If Double.TryParse(txtInput.Text, Number1) Then
                    count += 1
                Else
                    strMessage = "Cannot convert to double"
                End If
            End If
        Else
            strMessage = "Please finih your calculation"
        End If

        ' If error show message
        ' Else get Operator sign and clear Input.
        If strMessage <> "" Then
            MessageBox.Show(strMessage)
        Else
            Operator1 = "Log"
            ' Perform calculation based on Number1, Operator and Number2
            result = Math.Log10(Number1)
            ' Set the Equation to string of calculation
            lblEquation.Text = Operator1.ToString & " " & Number1.ToString
            ' Result to numeric value of calculation
            lblResult.Text = result.ToString
            ' Clear operator
            Operator1 = ""
            ' Clear Input
            txtInput.Text = ""
            ' Set count to 0
            count = 0
        End If

        ' Set focus for input
        txtInput.Focus()
    End Sub

    Private Sub btnSquareRoot_Click(sender As Object, e As EventArgs) Handles btnSquareRoot.Click
        ' Variables
        Dim strMessage As String = ""
        Dim result As Double = 0.0

        ' Verify that only one number is in the equation
        If count = 0 Then
            ' Validate Input type
            If txtInput.Text = String.Empty Then
                strMessage = "Please enter a value"
            ElseIf Not IsNumeric(txtInput.Text) Then
                strMessage = "Please enter a numeric value"
                txtInput.Text = ""
            Else
                ' Get the Input from the user.
                If Double.TryParse(txtInput.Text, Number1) Then
                    count += 1
                Else
                    strMessage = "Cannot convert to double"
                End If
            End If
        Else
            strMessage = "Please finih your calculation"
        End If

        ' If error show message
        ' Else get Operator sign and clear Input.
        If strMessage <> "" Then
            MessageBox.Show(strMessage)
        Else
            Operator1 = "√"
            ' Perform calculation based on Number1, Operator and Number2
            result = Math.Sqrt(Number1)
            ' Set the Equation to string of calculation
            lblEquation.Text = Operator1.ToString & " " & Number1.ToString
            ' Result to numeric value of calculation
            lblResult.Text = result.ToString
            ' Clear operator
            Operator1 = ""
            ' Clear Input
            txtInput.Text = ""
            ' Set count to 0
            count = 0
        End If

        ' Set focus for input
        txtInput.Focus()
    End Sub

    Private Sub btnExponential_Click(sender As Object, e As EventArgs) Handles btnExponential.Click
        ' Variable
        Dim strMessage As String = ""

        ' Validate that only two numbers are used in the equation
        If count = 0 Then
            ' Validate Input type
            If txtInput.Text = String.Empty Then
                strMessage = "Please enter a value"
            ElseIf Not IsNumeric(txtInput.Text) Then
                strMessage = "Please enter a numeric value"
                txtInput.Text = ""
            Else
                ' Get the Input from the user.
                If Double.TryParse(txtInput.Text, Number1) Then
                    count += 1
                Else
                    strMessage = "Cannot convert to double"
                End If
            End If
        Else
            ' Validate that operator is selected
            If Operator1 <> "^" And txtInput.Text = "" Then
                Operator1 = "^"
            Else
                strMessage = "Please press = to finih your calculation"
            End If
        End If

        ' If error show message 
        ' Else get Operator sign and clear Input.
        If strMessage <> "" Then
            MessageBox.Show(strMessage)
        Else
            Operator1 = "^"
            txtInput.Text = ""
        End If

        ' Set focus for input
        txtInput.Focus()
    End Sub
End Class
