Public Class Form60

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button29.Click, Button28.Click, Button27.Click, Button26.Click, Button25.Click, Button24.Click, Button23.Click, Button20.Click, Button2.Click, Button19.Click, Button18.Click, Button17.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click, Button12.Click, Button10.Click, Button1.Click
        TextBox1.Text = TextBox1.Text + Replace(sender.text, "Btn", "")
    End Sub

    Private Sub BC1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonback.Click, BS1.Click, BE1.Click, BC1.Click
        If sender Is BS1 Then TextBox1.Text = TextBox1.Text & " "
        If sender Is BE1 Then TextBox1.Text = TextBox1.Text & vbNewLine
        If sender Is Buttonback Then TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
        If sender Is BC1 Then TextBox1.Clear()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If Button1.Text = "Q" Then
            Button1.Text = "q"
            Button2.Text = "w"
            Button3.Text = "e"
            Button4.Text = "r"
            Button5.Text = "t"
            Button6.Text = "y"
            Button7.Text = "u"
            Button8.Text = "i"
            Button9.Text = "o"
            Button10.Text = "p"
            Button12.Text = "l"
            Button13.Text = "k"
            Button14.Text = "j"
            Button15.Text = "h"
            Button16.Text = "g"
            Button17.Text = "f"
            Button18.Text = "d"
            Button19.Text = "s"
            Button20.Text = "a"
            Button23.Text = "m"
            Button24.Text = "n"
            Button25.Text = "b"
            Button26.Text = "v"
            Button27.Text = "c"
            Button28.Text = "x"
            Button29.Text = "z"
        Else
            Button1.Text = "Q"
            Button2.Text = "W"
            Button3.Text = "E"
            Button4.Text = "R"
            Button5.Text = "T"
            Button6.Text = "Y"
            Button7.Text = "U"
            Button8.Text = "I"
            Button9.Text = "O"
            Button10.Text = "P"
            Button12.Text = "L"
            Button13.Text = "K"
            Button14.Text = "J"
            Button15.Text = "H"
            Button16.Text = "G"
            Button17.Text = "F"
            Button18.Text = "D"
            Button19.Text = "S"
            Button20.Text = "A"
            Button23.Text = "M"
            Button24.Text = "N"
            Button25.Text = "B"
            Button26.Text = "V"
            Button27.Text = "C"
            Button28.Text = "X"
            Button29.Text = "Z"
        End If
        
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        TextBox1.Copy()
        TextBox1.Copy()
        TextBox1.Copy()
        TextBox1.Copy()
        TextBox1.Copy()
        TextBox1.Copy()
        TextBox1.Copy()
        TextBox1.Copy()
        TextBox1.Copy()
        TextBox1.Copy()
        TextBox1.Copy()
        TextBox1.Copy()
        TextBox1.Copy()
    End Sub
End Class