Public Class Form39
    Dim mouse_move As System.Drawing.Point
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form22.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form20.Show()
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Form33.Show()
        Form33.Timer2.Start()
    End Sub

    Private Sub LinkLabel7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        Form33.Show()
        Form33.Timer1.Start()
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.AliceBlue
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Transparent
    End Sub

    Private Sub Button3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseEnter
        Button3.BackColor = Color.AliceBlue
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Color.Transparent
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Button2.BackColor = Color.AliceBlue
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.Transparent
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Form43.Show()
    End Sub

    Private Sub Panel1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        mouse_move = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Dim mposition As Point
            mposition = Control.MousePosition
            mposition.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mposition
        End If
    End Sub

    Private Sub LinkLabel8_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        Form21_Old.Show()
    End Sub

    Private Sub LinkLabel9_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        Form51.Show()
    End Sub

    Private Sub Form39_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form39_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If LinkLabel1.Enabled = False Then
            LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, FontStyle.Underline)
        End If
        If LinkLabel2.Enabled = False Then
            LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, FontStyle.Underline)
        End If
        If LinkLabel3.Enabled = False Then
            LinkLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, FontStyle.Underline)
        End If
        If LinkLabel4.Enabled = False Then
            LinkLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, FontStyle.Underline)
        End If
        If LinkLabel5.Enabled = False Then
            LinkLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, FontStyle.Underline)
        End If
        If LinkLabel6.Enabled = False Then
            LinkLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, FontStyle.Underline)
        End If
        If LinkLabel7.Enabled = False Then
            LinkLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, FontStyle.Underline)
        End If
        If LinkLabel8.Enabled = False Then
            LinkLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, FontStyle.Underline)
        End If
        If LinkLabel9.Enabled = False Then
            LinkLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, FontStyle.Underline)
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Form22.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Form21_Old.Show()
        easycode.openChildForm(New Form22)
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Form43.Show()
        If MsgBox("New Settings App", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

        End If
        'easycode.openChildForm(New theme_window())
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Form51.Show()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Form33.Show()
        Form33.Timer1.Start()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Form33.Show()
        Form33.Timer2.Start()
    End Sub
End Class