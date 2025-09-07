Public Class Form48
    'Dim mouse_move As System.Drawing.Point
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "dev111" Then
            MsgBox("Welcome Dev User to old user interface")
            form1Pad.Show()
            Module2.se()
            Close()
        Else
            If TextBox1.Text = "CMD" Then
                Dim CMD As New Form17
                CMD.Show()
            Else
                If TextBox1.Text = "admin" Then
                    Dim AdminPad As New form1Pad
                    AdminPad.Show()
                    AdminPad.NO1.Visible = True
                    AdminPad.NO1.Text = "Your a Admin ;)"
                Else
                    Form_1pad.Show()
                    

                End If
            End If
            

            Close()
        End If
    End Sub

    Private Sub RestartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartToolStripMenuItem.Click
        'Form33.Show()
        'Form33.Timer1.Start()
        Form57.Show()
        Form57.RestartTimer.Start()
    End Sub

    Private Sub ShutdownToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShutdownToolStripMenuItem.Click
        Form33.Show()
        Form33.Timer3.Stop()
        Form33.Timer2.Start()
    End Sub

    Private Sub Form48_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "admin" Then
            MsgBox("Velkommen Sebastian")
            Form_1pad.Show()
            Close()
        Else
            Form53.Show()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("Restart program", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Form57.Show()
            Form57.RestartTimer.Start()
        End If
    End Sub

    Private Sub ReloadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReloadToolStripMenuItem.Click
        Panel1.Visible = False
        PictureBox1.Visible = False
        Panel1.Visible = True
        PictureBox1.Visible = True
    End Sub

    Private Sub Panel2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseDown
        'mouse_move = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Panel2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseMove
        'If (e.Button = Windows.Forms.MouseButtons.Left) Then
        'Dim mposition As Point
        'mposition = Control.MousePosition
        'mposition.Offset(mouse_move.X, mouse_move.Y)
        'Me.Location = mposition
        'End If
    End Sub
End Class