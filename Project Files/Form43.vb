Public Class Form43
    Dim mouse_move As System.Drawing.Point
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Theme Settings
        Close()
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.AliceBlue
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Transparent
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Button2.BackColor = Color.AliceBlue
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.Transparent
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If form1Pad.Picture1.Visible = True Then
        Else
            form1Pad.Picture1.Visible = True
            form1Pad.Picture2.Visible = False
            form1Pad.Picture3.Visible = False
            form1Pad.Picture4.Visible = False
            form1Pad.Picture5.Visible = False
            form1Pad.Picture6.Visible = False
            form1Pad.Picture7.Visible = False
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If form1Pad.Picture2.Visible = True Then
        Else
            form1Pad.Picture1.Visible = False
            form1Pad.Picture2.Visible = True
            form1Pad.Picture3.Visible = False
            form1Pad.Picture4.Visible = False
            form1Pad.Picture5.Visible = False
            form1Pad.Picture6.Visible = False
            form1Pad.Picture7.Visible = False
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If form1Pad.Picture3.Visible = True Then
        Else
            form1Pad.Picture1.Visible = False
            form1Pad.Picture2.Visible = False
            form1Pad.Picture3.Visible = True
            form1Pad.Picture4.Visible = False
            form1Pad.Picture5.Visible = False
            form1Pad.Picture6.Visible = False
            form1Pad.Picture7.Visible = False
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If form1Pad.Picture4.Visible = True Then
        Else
            form1Pad.Picture1.Visible = False
            form1Pad.Picture2.Visible = False
            form1Pad.Picture3.Visible = False
            form1Pad.Picture4.Visible = True
            form1Pad.Picture5.Visible = False
            form1Pad.Picture6.Visible = False
            form1Pad.Picture7.Visible = False
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If form1Pad.Picture5.Visible = True Then
        Else
            form1Pad.Picture1.Visible = False
            form1Pad.Picture2.Visible = False
            form1Pad.Picture3.Visible = False
            form1Pad.Picture4.Visible = False
            form1Pad.Picture5.Visible = True
            form1Pad.Picture6.Visible = False
            form1Pad.Picture7.Visible = False
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        'form1Pad.Picture6.Image = OpenFileDialog1.
        'If form1Pad.Picture6.Visible = True Then
        'Else
        'form1Pad.Picture1.Visible = False
        'form1Pad.Picture2.Visible = False
        'form1Pad.Picture3.Visible = False
        'form1Pad.Picture4.Visible = False
        'form1Pad.Picture5.Visible = False
        'form1Pad.Picture6.Visible = True
        'End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If MsgBox("New wallpaper?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                form1Pad.Picture1.Visible = False
                form1Pad.Picture2.Visible = False
                form1Pad.Picture3.Visible = False
                form1Pad.Picture4.Visible = False
                form1Pad.Picture5.Visible = False
                form1Pad.Picture6.Visible = True
                form1Pad.Picture7.Visible = False
                form1Pad.Picture6.Load(Me.OpenFileDialog1.FileName)
                PictureBox6.Load(Me.OpenFileDialog1.FileName)
            End If
        Else
            form1Pad.Picture1.Visible = False
            form1Pad.Picture2.Visible = False
            form1Pad.Picture3.Visible = False
            form1Pad.Picture4.Visible = False
            form1Pad.Picture5.Visible = False
            form1Pad.Picture6.Visible = True
            form1Pad.Picture7.Visible = False
        End If
    End Sub

    Private Sub Form43_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If form1Pad.Picture6.Visible = True Then
            PictureBox6.Image = form1Pad.Picture6.Image
        End If
        PictureBox7.BackColor = form1Pad.cvtaskbar.BackColor
        ColorDialog1.Color = form1Pad.cvtaskbar.BackColor

        If form1Pad.Label11.Text = "Dev = true" Then
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button10.Enabled = False
        End If

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        'form1Pad.Panel2.BackColor = ColorDialog1.Color
        'ColorDialog1.Color = form1Pad.Panel2.BackColor
        'End If
        'Panel2.Visible = True
        If Panel2.Visible = True Then
            Panel2.Visible = False
        Else
            Panel2.Visible = True
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        form1Pad.cvtaskbar.BackColor = Color.Red
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        form1Pad.cvtaskbar.BackColor = Color.Blue
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        form1Pad.cvtaskbar.BackColor = Color.DarkBlue
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If form1Pad.Picture7.Visible = True Then
        Else
            form1Pad.Picture1.Visible = False
            form1Pad.Picture2.Visible = False
            form1Pad.Picture3.Visible = False
            form1Pad.Picture4.Visible = False
            form1Pad.Picture5.Visible = False
            form1Pad.Picture6.Visible = False
            form1Pad.Picture7.Visible = True
        End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        form1Pad.cvtaskbar.BackColor = Color.DarkRed
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Panel2.Visible = False
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        form1Pad.cvtaskbar.BackColor = Color.Silver
        Form_1pad.Panel1.BackColor = Color.Silver
    End Sub

    Private Sub Label1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox8.MouseDown, Panel1.MouseDown, Label1.MouseDown

    End Sub

    Private Sub Label1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox8.MouseMove, Panel1.MouseMove, Label1.MouseMove
        
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        form1Pad.cvtaskbar.BackColor = Color.Silver
        Form_1pad.Panel1.BackColor = Color.Silver
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Form_1pad.Panel1.BackColor = Color.WhiteSmoke
        form1Pad.cvtaskbar.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Form_1pad.Panel1.BackColor = Color.Black
        form1Pad.cvtaskbar.BackColor = Color.Black
    End Sub

    Private Sub PictureBox10_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox10.MouseDown
        mouse_move = New Point(-e.X, -e.Y)
    End Sub

    Private Sub PictureBox10_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox10.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Dim mposition As Point
            mposition = Control.MousePosition
            mposition.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mposition
        End If
    End Sub
End Class