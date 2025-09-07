Public NotInheritable Class Restartform

    Private Sub AboutBox10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.Close()
        If Form1.PictureBox2.Visible = True Then
            Form1.PictureBox2.Visible = True
            Form1.PictureBox3.Visible = False
            Form1.PictureBox4.Visible = False
            Form1.PictureBox5.Visible = False
            Form1.PictureBox6.Visible = False
            Form1.PictureBox7.Visible = False
            Form1.PictureBox8.Visible = False
            Form1.PictureBox9.Visible = False
        End If
        Form1.Show()
        If Form1.PictureBox2.Visible = True Then
            Form1.PictureBox2.Visible = True
            Form1.PictureBox3.Visible = False
            Form1.PictureBox4.Visible = False
            Form1.PictureBox5.Visible = False
            Form1.PictureBox6.Visible = False
            Form1.PictureBox7.Visible = False
            Form1.PictureBox8.Visible = False
            Form1.PictureBox9.Visible = False
        End If
        Me.Close()
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
