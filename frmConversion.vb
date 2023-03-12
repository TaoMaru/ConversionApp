' Program Name: Conversion App
' Date: March 11, 2023
' developer: Maria Jackson
' Purpose: This program converts entered values from inches to meters, or from meters
'       to inches. Conversion mode is set via radio btns by user.
'       User can also clear all input via the clear btn and exit the window via exit btn.

Public Class frmConversion

    'declare/ set meter and inches conversion rates:
    Const decToMetersConversionRate As Decimal = 0.0254D
    Const decToInchesConversionRate As Decimal = 39.3701D

    'declare conversion variables:
    Dim strConversion As String = ""
    Dim decConversion As Decimal = 0D
    Dim strToInchesConversion As String = "{0} Meters is {1} Inches."
    Dim strToMetersConversion As String = "{0} Inches is {1} Meters."

    'declare user input variables
    Dim strInput As String
    Dim decInput As Decimal

    Dim strNotValidMsg As String = "Please enter a numeric value greater than 0."
    Dim alert 'alert for msgBox when invalid  input received

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
        'Converts values as needed, determined by radio btn selection
        'Displays converted value

        strInput = txtInput.Text

        If IsNumeric(strInput) Then
            decInput = Convert.ToDecimal(strInput)
            If decInput > 0 Then
                If radToInches.Checked Then
                    decConversion = decInput * decToInchesConversionRate
                    strConversion = decConversion.ToString("F2")
                    strConversion = String.Format(strToInchesConversion, strInput, strConversion)
                Else
                    decConversion = decInput * decToMetersConversionRate
                    strConversion = decConversion.ToString("F2")
                    strConversion = String.Format(strToMetersConversion, strInput, strConversion)
                End If
                lblConversion.Text = strConversion
            Else
                alert = MsgBox(strNotValidMsg)
                txtInput.Focus()
                txtInput.Clear()
            End If
        Else
            alert = MsgBox(strNotValidMsg)
            txtInput.Focus()
            txtInput.Clear()
        End If
    End Sub
End Class
