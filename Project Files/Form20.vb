Public Class Form20
    Dim mouse_move As System.Drawing.Point
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
        Button3.Visible = True

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Button2.Enabled = True
            WebBrowser1.Visible = True
        End If
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click
        'If ProgressBar1.Value = 100 Then
        'Button2.Enabled = True
        'End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Timer1.Stop()
        Button3.Visible = False
        Button1.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "Update is Done " Then
            Form28.Show()
        Else
            Form2.Close()
            Form3.Close()
            Form4.Close()
            Form5.Close()
            Form6.Close()
            Form7.Close()
            Explorer1.Close()
            Explorer2.Close()
            Form9.Close()
            Form10.Close()
            Form11.Close()
            Form12.Close()
            Form13.Close()
            Form14.Close()
            Form15.Close()
            Form16.Close()
            Form17.Close()
            Form18.Close()
            Form19.Close()
            'Form1.Show()
            Errorbox1.Close()
            AboutBox1.Close()
            AboutBox3.Close()
            AboutBox5.Close()
            AboutBox7.Close()
            AboutBox8.Close()
            'Button2.Text = "Update is Done "
            If MsgBox("Restart Program", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Form57.Show()
                Form57.StartingTimer.Stop()
                'Form33.Timer3.Stop()
                updaterform1.Show()
                updaterform1.Timer1.Start()
                updaterform1.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                updaterform1.Text = "Update Sebs SW CV"
            End If
            'Form1.Timer3.Start()
            'Form1.V.Text = "???"
            'Form1.Panel3.Visible = False
            'Form1.Panel1.Visible = False
            'MsgBox("Virus in Form1 Form3 Form5 in All Forms. : your on 3.0. update to 3.2 - 3.3", MsgBoxStyle.Critical)
        End If
        

    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form21_Old.Show()
        'easycode.openChildForm(New theme_window())
        'Form21.Panel1.Visible = True
        'Form21.Panel2.Visible = False
        'Form21.ggg.Visible = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form22.Show()
        'Form21.Show()
        'Form21.Panel1.Visible = False
        'Form21.Panel2.Visible = True
        'Form21.ggg.Visible = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form51.Show()
        'Form21.Panel1.Visible = False
        'Form21.Panel2.Visible = False
        'Form21.ggg.Visible = True
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Close()
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

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Panel2.BackColor = Form_1pad.Panel1.BackColor
    End Sub

    Private Sub Form20_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class