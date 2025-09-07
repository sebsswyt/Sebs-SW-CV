Public Class Form30

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Form31.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Form35.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Form39.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Form1.Button1.Visible = False Then
            Form1.Show()
            Form1.Panel3.Visible = True
        Else
            If Form1.Panel3.Visible = False Then
                Form1.Panel3.Visible = True
            Else
                Form1.Panel3.Visible = False
            End If
        End If
        If Form1.Panel3.Visible = False Then
            Form1.Panel3.Visible = True
        Else
            Form1.Panel3.Visible = False
        End If
        Form1.Panel3.Visible = True
        Form1.Panel3.Visible = True
        Form1.Panel3.Visible = True
    End Sub

    Private Sub Form30_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Stopmenub.Text = "stop" Then
            Form2.Show()
            Close()
        End If
        Label2.Text = form1Pad.Username1.Text
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Form35.Show()
        Form35.WebBrowser1.Navigate("https://sebs-sw-b.tk/info-sebs-sw-1.html")
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.AliceBlue
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.LightGray
    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.BackColor = Color.AliceBlue
    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.BackColor = Color.AliceBlue
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.BackColor = Color.AliceBlue
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.BackColor = Color.LightGray
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.BackColor = Color.LightGray
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.BackColor = Color.LightGray
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Close()
    End Sub

    Private Sub PictureBox6_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseEnter
        PictureBox6.BackColor = Color.AliceBlue
    End Sub

    Private Sub PictureBox6_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseLeave
        PictureBox6.BackColor = Color.LightGray
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        If Stopmenub.Text = "0" Then
            Stopmenub.Text = "1"
        Else
            If Stopmenub.Text = "1" Then
                Stopmenub.Text = "2"
            Else
                If Stopmenub.Text = "2" Then
                    Stopmenub.Text = "3"
                Else
                    If Stopmenub.Text = "3" Then
                        Stopmenub.Text = "4"
                    Else
                        If Stopmenub.Text = "4" Then
                            WindowState = FormWindowState.Normal
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub PictureBox5_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseEnter
        PictureBox5.BackColor = Color.AliceBlue
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.BackColor = Color.LightGray
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Form20.Show()
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        Form22.Show()
    End Sub

    Private Sub PictureBox7_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseEnter
        PictureBox7.BackColor = Color.AliceBlue
    End Sub

    Private Sub PictureBox7_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseLeave
        PictureBox7.BackColor = Color.LightGray
    End Sub

    Private Sub PictureBox8_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseEnter
        PictureBox8.BackColor = Color.AliceBlue
    End Sub

    Private Sub PictureBox8_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseLeave
        PictureBox8.BackColor = Color.LightGray
    End Sub

    Private Sub panalp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panalp.Click
        Form17.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Form17.Show()
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        Form17.Show()
    End Sub

    Private Sub Label1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseEnter, panalp.MouseEnter, Label1.MouseEnter
        CMDPanalButton.BackColor = Color.AliceBlue
    End Sub

    Private Sub Label1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseLeave, panalp.MouseLeave, Label1.MouseLeave
        CMDPanalButton.BackColor = Color.LightGray
    End Sub
End Class