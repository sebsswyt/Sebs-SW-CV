Public Class Form50
    Dim mouse_move As System.Drawing.Point
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If FormBorderStyle = Windows.Forms.FormBorderStyle.None Then
        Else

        End If
    End Sub

    Private Sub Form50_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MsgBox("", MsgBoxStyle.Information)
        'Close()
        'Button4.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            '1
            If RichTextBox1.Text = "id(15264326543=P1)" Then
                If one.ShowDialog = Windows.Forms.DialogResult.OK Then
                    RichTextBox2.Text = one.FileName
                    form1Pad.Picture1.Load(RichTextBox2.Text)
                    Form49.Show()
                    Form49.PictureBox1.Image = form1Pad.Picture1.Image
                End If
            End If
            '2
            If RichTextBox1.Text = "id(152423235343=P2)" Then
                If two.ShowDialog = Windows.Forms.DialogResult.OK Then
                    RichTextBox2.Text = two.FileName
                    form1Pad.Picture2.Load(RichTextBox2.Text)
                    Form49.PictureBox2.Image = form1Pad.Picture2.Image
                End If
            End If
            '3
            If RichTextBox1.Text = "id(1593490575343=P3)" Then
                If three.ShowDialog = Windows.Forms.DialogResult.OK Then
                    RichTextBox2.Text = three.FileName
                    form1Pad.Picture3.Load(RichTextBox2.Text)
                    Form49.PictureBox3.Image = form1Pad.Picture3.Image
                End If
            End If
            '4
            If RichTextBox1.Text = "id(159343467953=P4)" Then
                If four.ShowDialog = Windows.Forms.DialogResult.OK Then
                    RichTextBox2.Text = four.FileName
                    form1Pad.Picture4.Load(RichTextBox2.Text)
                    Form49.PictureBox4.Image = form1Pad.Picture4.Image
                End If
            End If
            '5
            If RichTextBox1.Text = "id(157358323=P5)" Then
                If five.ShowDialog = Windows.Forms.DialogResult.OK Then
                    RichTextBox2.Text = five.FileName
                    form1Pad.Picture5.Load(RichTextBox2.Text)
                    Form49.PictureBox5.Image = form1Pad.Picture5.Image
                End If
            End If
            '6
            If RichTextBox1.Text = "B6-c" Then
                'MsgBox("?", MsgBoxStyle.Exclamation)
                Form43.Show()
                'If Form43.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                'form1Pad.Picture1.Visible = False
                'form1Pad.Picture2.Visible = False
                ' form1Pad.Picture3.Visible = False
                ' form1Pad.Picture4.Visible = False
                'form1Pad.Picture5.Visible = False
                'form1Pad.Picture6.Visible = True
                'form1Pad.Picture6.Load(Me.OpenFileDialog1.FileName)
                'Form43.PictureBox6.Load(Me.OpenFileDialog1.FileName)
                'End If
            End If
            If RichTextBox1.Text = "id(15345213=P7)" Then
                If sev.ShowDialog = Windows.Forms.DialogResult.OK Then
                    RichTextBox2.Text = sev.FileName
                    form1Pad.Picture7.Load(RichTextBox2.Text)
                    Form49.PictureBox7.Image = form1Pad.Picture7.Image
                End If
            End If
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub one_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles one.FileOk

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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form43.Show()
    End Sub
End Class