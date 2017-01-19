


Class MainWindow

    Private Sub textBox_KeyDown(sender As Object, e As KeyEventArgs) Handles textBox.KeyDown


    End Sub



    Private Sub textBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles textBox.TextChanged
        Dim cursorPos = textBox.SelectionStart
        Dim input = textBox.Text
        Dim output = ""
        For i = 0 To input.Length - 1
            If "ΑΒΓΔΕΖΗΘΙΚΛΜΝΞΟΠΡΣΤΥΦΧΨΩ".IndexOf(input.Chars(i)) >= 0 Then
                output &= input.Chars(i)
            ElseIf "αβγδεζηθικλμνξοπρστυφχψω".IndexOf(input.Chars(i)) >= 0 Then

                output &= StrConv(input.Chars(i), VbStrConv.Uppercase)



            Else
                cursorPos -= 1
            End If
        Next
        textBox.Text = output
        textBox.SelectionStart = cursorPos
    End Sub
End Class
