Public Class AP

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'about Program here
        AboutBox1.Show()
        VLabel.Text = AboutBox1.LabelVersion.Text
        VLabel.Text = AboutBox1.LabelVersion.Text
        VLabel.Text = AboutBox1.LabelVersion.Text
        VLabel.Text = AboutBox1.LabelVersion.Text
        AboutBox1.Close()
        'about program in VLabel
    End Sub

    Private Sub VLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VLabel.Click
        'MsgBox("Ha ha ha Click on my ###")
        Form19.Show()
        Form19.WebBrowser1.Navigate("https://www.google.com")
    End Sub
End Class
