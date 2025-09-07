Public Class Form51
    Dim mouse_move As System.Drawing.Point
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Not on Add list", MsgBoxStyle.Information)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Username to Form1
        If TextBox1.Text = "" Then
            MsgBox("Sorry Ned 1 Character")
        Else
            If TextBox1.Text = "CVExplorer.exe" Then
                If form1Pad.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable Then
                    form1Pad.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                Else
                    form1Pad.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                End If
            Else
                form1Pad.Username1.Text = TextBox1.Text
            End If

        End If
        'Update Username in Panal3
        If Form1.Panel3.Visible = True Then
            'Form1.Username2.Text = TextBox1.Text
        End If
        'New Code?
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Form51_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'PictureBox1.BackColor = Color.AliceBlue
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'PictureBox1.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'PictureBox2.BackColor = Color.AliceBlue
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'PictureBox2.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'PictureBox3.BackColor = Color.AliceBlue
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'PictureBox3.BackColor = Color.Transparent
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox1.Text = Form60.TextBox1.Text
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Form60.Button1.Visible = True Then
            Button6.Visible = True
        Else
            Button6.Visible = False
        End If
        Panel2.BackColor = Form_1pad.Panel1.BackColor
        Panel1.BackColor = Form_1pad.Panel1.BackColor
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Form22.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Form20.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If Form_1pad.Label1.Visible = True Then
            Form21_Old.Show()
        Else
            Form43.Show()
        End If
    End Sub
End Class