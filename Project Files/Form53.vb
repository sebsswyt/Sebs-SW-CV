Public Class Form53

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If MsgBox("please Log on to Sebs SW CV", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)
        End If

    End Sub

    Private Sub GroupBox2_LocationChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.LocationChanged
        Dim index As Integer = 0
        While index < RichTextBox1.Text.LastIndexOf(TextBox1.Text)
            RichTextBox1.Find(TextBox1.Text, index, RichTextBox1.TextLength, RichTextBoxFinds.None)
            RichTextBox1.SelectionBackColor = Color.Blue
            index = RichTextBox1.Text.IndexOf(TextBox1.Text, index) + 1


        End While
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None Then
            Panel1.Visible = True
        Else
            Panel1.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub
End Class