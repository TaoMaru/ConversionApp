' Program Name: Building Plans Conversion App
' Date: March 11, 2023
' developer: Maria Jackson
' Purpose: This program converts entered values from inches to meters, or from meters
'       to inches. Conversion mode is set via radio btns by user as metersToInches or inchesToMeters
'       User can also clear all input via the clear btn and exit the window via exit btn.

Public Class frmConversion

    'declare/ set meter and inches conversion rates:
    Const _decToMetersConversionRate As Decimal = 0.0254D 'value of inches to meters conversion rate
    Const _decToInchesConversionRate As Decimal = 39.3701D 'value of meters to inches conversion rate

    'declare conversion variables:
    Dim strConversion As String = ""
    Dim decConversion As Decimal = 0D
    Dim strToInchesConversion As String = "{0} Meters is {1} Inches." 'msg for meters to inches conversion
    Dim strToMetersConversion As String = "{0} Inches is {1} Meters." 'msg for inchst to meters conversion

    'declare user input variables
    Dim strInput As String 'string user input
    Dim decInput As Decimal 'user input as decimal

    'declare invalid input variables:
    'error msg for non-numeric, empty, or less than 0 input values
    Dim strNotValidMsg As String = "Please enter a numeric value greater than 0."
    Dim msgAlert 'alert for msgBox when invalid input received

    Private Sub frmConversion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' sets rad ToMeters to checked
        ' sets focus onto txtInput  
        ' sets lblConversion txt to start value (empty)
        radToMeters.Checked = True
        txtInput.Focus()
        lblConversion.Text = strConversion
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Ends program and exits window
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clears input from txtInput, and resets focus to txtInput
        ' Resets radio btn selection to radToMeters
        txtInput.Clear()
        txtInput.Focus()
        radToMeters.Checked = True
        lblConversion.Text = ""
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        'Validates user input, Converts values as needed, determined by radio btn selection
        'Displays converted value within result msg

        strInput = txtInput.Text 'grab user input from txtInput field

        'perform conversion:
        If IsNumeric(strInput) Then
            decInput = Convert.ToDecimal(strInput) 'convert numeric input to decimal
            If decInput > 0 Then 'input is valid
                If radToInches.Checked Then
                    'perform meters to inches conversion
                    decConversion = decInput * _decToInchesConversionRate
                    strConversion = decConversion.ToString("F2") ' convert result to string, 2 dec places
                    ' format meters to inches result msg
                    strConversion = String.Format(strToInchesConversion, strInput, strConversion)
                Else
                    'perform inches to meters conversion
                    decConversion = decInput * _decToMetersConversionRate
                    strConversion = decConversion.ToString("F2") ' convert result to string, 2 dec places
                    'format inches to meters result msg
                    strConversion = String.Format(strToMetersConversion, strInput, strConversion)
                End If
                lblConversion.Text = strConversion 'display conversion result msg
            Else
                'alert user of invalid input & reset txtInput
                msgAlert = MsgBox(strNotValidMsg)
                txtInput.Focus()
                txtInput.Clear()
            End If
        Else
            'alert user of invalid input & reset txtInput
            msgAlert = MsgBox(strNotValidMsg)
            txtInput.Focus()
            txtInput.Clear()
        End If
    End Sub
End Class
