Public NotInheritable Class AboutBox5

    Private Sub AboutBox5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form15.Show()
        Form15.Text = "Boot.dll"
        Form15.TextBox1.Text = "Form1.Show() = True "
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form15.Show()
        Form15.Text = "Boot.dll"
        Form15.TextBox1.Text = "Form1.Show() = True "
        Form15.TextBox1.ReadOnly = False
    End Sub
End Class
