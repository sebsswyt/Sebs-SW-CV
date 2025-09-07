Public Class Form34
    Dim mouse_move As System.Drawing.Point
    Private Sub Panalon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panalon.Click
        Panel1.Visible = True
        'Panaloff.Visible = True
        Panalon.Visible = False
    End Sub

    Private Sub Panaloff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Panel1.Visible = False
        'Panaloff.Visible = False
        Panalon.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Panel1.Visible = False
        Form1.Panel3.Visible = False
        Form1.Panel4.Visible = False
        Form1.Panel5.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Panel1.Visible = True
        Form1.Panel4.Visible = False
        Form1.Panel5.Visible = False
        Form2.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.Panel1.Visible = False
        Form1.Panel3.Visible = False
        Form1.Panel4.Visible = False
        Form1.Panel5.Visible = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form1.Panel1.Visible = True
        Form2.Close()
        Form1.Panel4.Visible = False
        Form1.Panel5.Visible = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form1.Panel1.Visible = False
        Form1.Panel4.Visible = True
        Form1.Panel3.Visible = False
        Form2.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form1.Panel1.Visible = False
        Form1.Panel4.Visible = True
        Form1.Panel3.Visible = False
        Form2.Close()
    End Sub

    Private Sub Button6_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.MouseEnter

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Panalon.Visible = True
        Button1.Visible = True
        Button2.Visible = True
        Button5.Visible = True
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Close()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseDown
        mouse_move = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Panel2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Dim mposition As Point
            mposition = Control.MousePosition
            mposition.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mposition
        End If
    End Sub
End Class