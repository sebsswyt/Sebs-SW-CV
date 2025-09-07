Public Class Form26

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form29.Show()
        Form29.PictureBox1.Visible = True
        Form1.PictureBox2.Visible = True
        Form1.PictureBox3.Visible = False
        Form1.PictureBox4.Visible = False
        Form1.PictureBox5.Visible = False
        Form1.PictureBox6.Visible = False
        Form1.PictureBox7.Visible = False
        Form1.PictureBox8.Visible = False
        Form1.PictureBox9.Visible = False
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form29.Show()
        Form29.PictureBox2.Visible = True
        Form1.PictureBox2.Visible = False
        Form1.PictureBox3.Visible = True
        Form1.PictureBox4.Visible = False
        Form1.PictureBox5.Visible = False
        Form1.PictureBox6.Visible = False
        Form1.PictureBox7.Visible = False
        Form1.PictureBox8.Visible = False
        Form1.PictureBox9.Visible = False
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form29.Show()
        Form29.PictureBox3.Visible = True
        Form1.PictureBox2.Visible = False
        Form1.PictureBox3.Visible = False
        Form1.PictureBox4.Visible = True
        Form1.PictureBox5.Visible = False
        Form1.PictureBox6.Visible = False
        Form1.PictureBox7.Visible = False
        Form1.PictureBox8.Visible = False
        Form1.PictureBox9.Visible = False
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form29.Show()
        Form29.PictureBox4.Visible = True
        Form1.PictureBox2.Visible = False
        Form1.PictureBox3.Visible = False
        Form1.PictureBox4.Visible = False
        Form1.PictureBox5.Visible = True
        Form1.PictureBox6.Visible = False
        Form1.PictureBox7.Visible = False
        Form1.PictureBox8.Visible = False
        Form1.PictureBox9.Visible = False
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form29.Show()
        Form29.PictureBox5.Visible = True
        Form1.PictureBox2.Visible = False
        Form1.PictureBox3.Visible = False
        Form1.PictureBox4.Visible = False
        Form1.PictureBox5.Visible = False
        Form1.PictureBox6.Visible = True
        Form1.PictureBox7.Visible = False
        Form1.PictureBox8.Visible = False
        Form1.PictureBox9.Visible = False
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form29.Show()
        Form29.PictureBox6.Visible = True
        Form1.PictureBox2.Visible = False
        Form1.PictureBox3.Visible = False
        Form1.PictureBox4.Visible = False
        Form1.PictureBox5.Visible = False
        Form1.PictureBox6.Visible = False
        Form1.PictureBox7.Visible = True
        Form1.PictureBox8.Visible = False
        Form1.PictureBox9.Visible = False
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Form29.Show()
        Form29.PictureBox7.Visible = True
        Form1.PictureBox2.Visible = False
        Form1.PictureBox3.Visible = False
        Form1.PictureBox4.Visible = False
        Form1.PictureBox5.Visible = False
        Form1.PictureBox6.Visible = False
        Form1.PictureBox7.Visible = False
        Form1.PictureBox8.Visible = True
        Form1.PictureBox9.Visible = False
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Form29.Show()
        Form29.PictureBox8.Visible = True
        Form1.PictureBox2.Visible = False
        Form1.PictureBox3.Visible = False
        Form1.PictureBox4.Visible = False
        Form1.PictureBox5.Visible = False
        Form1.PictureBox6.Visible = False
        Form1.PictureBox7.Visible = False
        Form1.PictureBox8.Visible = False
        Form1.PictureBox9.Visible = True
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Form20.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Form21_Old.Show()
        Form21_Old.Panel1.Visible = True
        Form21_Old.Panel2.Visible = False
        Form21_Old.ggg.Visible = False
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Form21_Old.Show()
        Form21_Old.Panel1.Visible = False
        Form21_Old.Panel2.Visible = True
        Form21_Old.ggg.Visible = False
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Form21_Old.Show()
        Form21_Old.Panel1.Visible = False
        Form21_Old.Panel2.Visible = False
        Form21_Old.ggg.Visible = True
    End Sub
End Class