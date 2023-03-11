' Program Name: Conversion App
' Date: March 11, 2023
' developer: Maria Jackson
' Purpose: This program converts entered values from inches to meters, or from meters
'       to inches. Conversion mode is set via radio btns by user.
'       User can also clear all input via the clear btn and exit the window via exit btn.

Public Class frmConversion

    Dim strConversion As String = ""

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
    End Sub

    Private Sub frmConversion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' sets rad ToMeters to checked
        ' sets focus onto txtInput  
        ' sets lblConversion txt to start value (empty)
        radToMeters.Checked = True
        txtInput.Focus()
        lblConversion.Text = strConversion
    End Sub
End Class
