Public Class Form12

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AboutBox3.Show()


    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub CheckBox1_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.PictureBox2.Visible = True
        Form1.PictureBox3.Visible = False
        Form1.PictureBox4.Visible = False
        Form1.PictureBox5.Visible = False
        Form1.PictureBox6.Visible = False
        Form1.PictureBox7.Visible = False
        Form1.PictureBox8.Visible = False
        Form1.PictureBox9.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.PictureBox2.Visible = False
        Form1.PictureBox3.Visible = True
        Form1.PictureBox4.Visible = False
        Form1.PictureBox5.Visible = False
        Form1.PictureBox6.Visible = False
        Form1.PictureBox7.Visible = False
        Form1.PictureBox8.Visible = False
        Form1.PictureBox9.Visible = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form1.PictureBox2.Visible = False
        Form1.PictureBox3.Visible = False
        Form1.PictureBox4.Visible = True
        Form1.PictureBox5.Visible = False
        Form1.PictureBox6.Visible = False
        Form1.PictureBox7.Visible = False
        Form1.PictureBox8.Visible = False
        Form1.PictureBox9.Visible = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form1.PictureBox2.Visible = False
        Form1.PictureBox3.Visible = False
        Form1.PictureBox4.Visible = False
        Form1.PictureBox5.Visible = True
        Form1.PictureBox6.Visible = False
        Form1.PictureBox7.Visible = False
        Form1.PictureBox8.Visible = False
        Form1.PictureBox9.Visible = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form1.PictureBox2.Visible = False
        Form1.PictureBox3.Visible = False
        Form1.PictureBox4.Visible = False
        Form1.PictureBox5.Visible = False
        Form1.PictureBox6.Visible = True
        Form1.PictureBox7.Visible = False
        Form1.PictureBox8.Visible = False
        Form1.PictureBox9.Visible = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Form1.PictureBox2.Visible = False
        Form1.PictureBox3.Visible = False
        Form1.PictureBox4.Visible = False
        Form1.PictureBox5.Visible = False
        Form1.PictureBox6.Visible = False
        Form1.PictureBox7.Visible = True
        Form1.PictureBox8.Visible = False
        Form1.PictureBox9.Visible = False
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Form1.PictureBox2.Visible = False
        Form1.PictureBox3.Visible = False
        Form1.PictureBox4.Visible = False
        Form1.PictureBox5.Visible = False
        Form1.PictureBox6.Visible = False
        Form1.PictureBox7.Visible = False
        Form1.PictureBox8.Visible = True
        Form1.PictureBox9.Visible = False
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form1.PictureBox1.Visible = False
        Form1.PictureBox2.Visible = False
        Form1.PictureBox3.Visible = False
        Form1.PictureBox4.Visible = False
        Form1.PictureBox5.Visible = False
        Form1.PictureBox6.Visible = False
        Form1.PictureBox7.Visible = False
        Form1.PictureBox8.Visible = False
        Form1.PictureBox9.Visible = False
        Form1.Button1.Visible = False
        Form1.Button2.Visible = False
        Form1.Button3.Visible = False
        Form1.Button4.Visible = False
        Form1.Button7.Visible = False
        Form1.Button10.Visible = False
        Form2.Close()
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
        Form8.Close()
        Form9.Close()
        Form10.Close()
        Form11.Close()
        Form13.Close()
        Form14.Close()
        Form1.Panel2.Visible = True
        Me.Close()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Form1.PictureBox2.Visible = False
        Form1.PictureBox3.Visible = False
        Form1.PictureBox4.Visible = False
        Form1.PictureBox5.Visible = False
        Form1.PictureBox6.Visible = False
        Form1.PictureBox7.Visible = False
        Form1.PictureBox8.Visible = False
        Form1.PictureBox9.Visible = True
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Form20.Show()
    End Sub
End Class