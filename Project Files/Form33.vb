Public Class Form33

    Private Sub Form33_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Form49.Show()
        If Form50.Button1.Visible = True Then

        End If
        form1Pad.Label7.Text = "ON"
        V2.Text = Form1.V.Text
        Label2.Text = Form27.Label1.Text
        Timer3.Start()

        Form1.Close()
        Form2.Close()
        WindowState = FormWindowState.Maximized
        Form27.Close()


        AboutBox23.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Form57.Show()
        Form57.RestartTimer.Start()
        Timer1.Stop()
        Close()
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 1 Then
            'form1Pad.Show()
            'Form49.Show()
        End If
        If ProgressBar1.Value = 2 Then
            'form1Pad.Show()
            'Form49.Show()
        End If
        If ProgressBar1.Value = 3 Then
            'form1Pad.Show()
            'Form49.Show()
        End If
        If ProgressBar1.Value = 4 Then
            'form1Pad.Show()
            'Form49.Show()
        End If
        If ProgressBar1.Value = 5 Then
            'form1Pad.Show()
        End If
        'Me.Show()
        Form49.PictureBox1.Image = form1Pad.Picture1.Image
        Form49.PictureBox2.Image = form1Pad.Picture2.Image
        Form49.PictureBox3.Image = form1Pad.Picture3.Image
        Form49.PictureBox4.Image = form1Pad.Picture4.Image
        Form49.PictureBox5.Image = form1Pad.Picture5.Image
        Form49.PictureBox6.Image = form1Pad.Picture6.Image
        Form49.PictureBox7.Image = form1Pad.Picture7.Image
        Form49.PictureBox1.Image = form1Pad.Picture1.Image
        Form49.PictureBox2.Image = form1Pad.Picture2.Image
        Form49.PictureBox3.Image = form1Pad.Picture3.Image
        Form49.PictureBox4.Image = form1Pad.Picture4.Image
        Form49.PictureBox5.Image = form1Pad.Picture5.Image
        Form49.PictureBox6.Image = form1Pad.Picture6.Image
        Form49.PictureBox7.Image = form1Pad.Picture7.Image
        Form49.PictureBox1.Image = form1Pad.Picture1.Image
        Form49.PictureBox2.Image = form1Pad.Picture2.Image
        Form49.PictureBox3.Image = form1Pad.Picture3.Image
        Form49.PictureBox4.Image = form1Pad.Picture4.Image
        Form49.PictureBox5.Image = form1Pad.Picture5.Image
        Form49.PictureBox6.Image = form1Pad.Picture6.Image
        Form49.PictureBox7.Image = form1Pad.Picture7.Image
        Form49.PictureBox1.Image = form1Pad.Picture1.Image
        Form49.PictureBox2.Image = form1Pad.Picture2.Image
        Form49.PictureBox3.Image = form1Pad.Picture3.Image
        Form49.PictureBox4.Image = form1Pad.Picture4.Image
        Form49.PictureBox5.Image = form1Pad.Picture5.Image
        Form49.PictureBox6.Image = form1Pad.Picture6.Image
        Form49.PictureBox7.Image = form1Pad.Picture7.Image
        If ProgressBar1.Value = 10 Then
            Label1.Text = "Restarting.."
        End If
        If ProgressBar1.Value = 15 Then
            Label1.Text = "Restarting..."
            form1Pad.Label7.Text = "ON"
            form1Pad.Close()
        End If
        If ProgressBar1.Value = 20 Then
            Label1.Text = "Restarting.."
            form1Pad.Label7.Text = "ON"
            form1Pad.Close()
        End If
        If ProgressBar1.Value = 25 Then
            Label1.Text = "Restarting."
            form1Pad.Label7.Text = "ON"
            form1Pad.Close()
        End If
        If ProgressBar1.Value = 30 Then
            Label1.Text = "Restarting.."
        End If
        If ProgressBar1.Value = 35 Then
            Label1.Text = "Restarting..."
        End If
        If ProgressBar1.Value = 40 Then
            Label1.Text = "Restarting.."
        End If
        If ProgressBar1.Value = 45 Then
            Label1.Text = "Restarting."
        End If
        If ProgressBar1.Value = 50 Then
            Label1.Text = "Restarting.."
        End If
        If ProgressBar1.Value = 55 Then
            Label1.Text = "Restarting..."
        End If
        If ProgressBar1.Value = 60 Then
            Label1.Text = "Restarting.."
        End If
        If ProgressBar1.Value = 65 Then
            Label1.Text = "Restarting."
        End If
        If ProgressBar1.Value = 70 Then
            Label1.Text = "Restarting.."
        End If
        If ProgressBar1.Value = 75 Then
            Label1.Text = "Restarting..."
        End If
        If ProgressBar1.Value = 80 Then
            Label1.Text = "Restarting.."
        End If
        If ProgressBar1.Value = 85 Then
            Label1.Text = "Restarting."
        End If
        If ProgressBar1.Value = 90 Then
            Label1.Text = "Restarting.."
        End If
        If ProgressBar1.Value = 95 Then
            Label1.Text = "Restarting..."
        End If

        Form49.PictureBox1.Image = form1Pad.Picture1.Image
        Form49.PictureBox2.Image = form1Pad.Picture2.Image
        Form49.PictureBox3.Image = form1Pad.Picture3.Image
        Form49.PictureBox4.Image = form1Pad.Picture4.Image
        Form49.PictureBox5.Image = form1Pad.Picture5.Image
        Form49.PictureBox6.Image = form1Pad.Picture6.Image
        Form49.PictureBox7.Image = form1Pad.Picture7.Image
        Form49.PictureBox1.Image = form1Pad.Picture1.Image
        Form49.PictureBox2.Image = form1Pad.Picture2.Image
        Form49.PictureBox3.Image = form1Pad.Picture3.Image
        Form49.PictureBox4.Image = form1Pad.Picture4.Image
        Form49.PictureBox5.Image = form1Pad.Picture5.Image
        Form49.PictureBox6.Image = form1Pad.Picture6.Image
        Form49.PictureBox7.Image = form1Pad.Picture7.Image
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            form1Pad.Close()
            Form47.Show()
            Form47.Label2.Text = Label4.Text
            Timer1.Stop()
            Form1.V.Text = V2.Text
            If rest1.Text = "Maximized" Then
                form1Pad.WindowState = FormWindowState.Maximized
            End If
            Close()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar2.Increment(1)
        Timer1.Stop()
        Label1.Text = "Shutting down"

        If ProgressBar2.Value = ProgressBar1.Maximum Then
            Timer2.Stop()
            End
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Form1.Show()
        Form1.Panel3.Visible = True
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If Label3.Text = "1" Then

            If Form17.RichTextBox1.Visible = False Then
                Timer4.Start()
            Else
                Timer4.Stop()
            End If
        Else

        End If
        If Form1.Panel3.Visible = False Then
            Timer1.Start()
        Else
            Timer1.Stop()
        End If
        If Form17.RichTextBox1.Visible = False Then
            Timer1.Start()
        Else
            Timer1.Stop()
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Form17.Show()
        AboutBox17.Show()
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Form57.Show()
        Form57.StartingTimer.Start()
        Timer4.Stop()
        Close()
        ProgressBar3.Increment(1)
        If Form54.PictureBox1.Visible = True Then
        Else
            'Form54.Show()
        End If
        Timer1.Stop()
        Timer3.Stop()
        If ProgressBar3.Value = 5 Then
            Label1.Text = "Starting up."
        End If
        If ProgressBar3.Value = 10 Then
            Label1.Text = "Starting up.."
        End If
        If ProgressBar3.Value = 15 Then
            Label1.Text = "Starting up..."
        End If
        If ProgressBar3.Value = 20 Then
            Label1.Text = "Starting up.."
        End If
        If ProgressBar3.Value = 25 Then
            Label1.Text = "Starting up."
        End If
        If ProgressBar3.Value = 30 Then
            Label1.Text = "Starting up.."
        End If
        If ProgressBar3.Value = 35 Then
            Label1.Text = "Starting up..."
        End If
        'Label1.Text = "Starting up"
        If Label1.Text = "Restarting." Then
            Label1.Text = "Starting up"
        Else
            If Label1.Text = "Restarting.." Then
                Label1.Text = "Starting up"
            Else
                If Label1.Text = "Restarting..." Then
                    Label1.Text = "Starting up"
                End If
            End If
        End If
        If ProgressBar3.Value = 40 Then
            Form48.Show()
            Form54.Close()
            Close()
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click

        Label3.Text = "1"
        Timer3.Start()
        Form17.Show()
    End Sub
End Class