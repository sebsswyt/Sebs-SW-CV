Public Class Form1old

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("Fail To Open Old File Explorer", MsgBoxStyle.Critical)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form9.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Explorer1.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        backgroundBox1.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        MsgBox("fail To Open Not Internet Explorer", MsgBoxStyle.Critical)
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub Button11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub Button8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub Button6_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
        Explorer1.Close()
        Explorer2.Close()
        AboutBox1.Show()
        AboutBox1.Close()
        AboutBox3.Show()
        AboutBox3.Close()
        AboutBox5.Show()
        AboutBox5.Close()
        AboutBox7.Show()
        AboutBox7.Close()
        AboutBox8.Show()
        AboutBox8.Close()
        AboutBox9.Show()
        AboutBox9.Close()
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
        Form20.Close()
        Form21_Old.Close()
        Errorbox1.Close()
        Restartform.Show()
    End Sub

    Private Sub Button8_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form9.Show()
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar2.Increment(3)
        If ProgressBar2.Value = 100 Then
            Timer1.Stop()
            Button13.Visible = True
        End If
    End Sub

    Private Sub Form1old_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        PictureBox9.Visible = False
        PictureBox4.Visible = True

        'If AboutBox24.Label1.Visible = True Then
        'LoginForm2.Close()
        'Else
        'If AboutBox24.Button1.Text = "Shutdown" Then

        'Else
        'LoginForm2.Show()
        'Close()
        'End If
        'LoginForm2.Show()
        'Close()
        'End If
        SWBTimer.Start()
        If Form33.rest1.Text = "Normal" Then

        End If
        'If AboutBox1.LabelVersion.Text = "Version 3.3" Then
        'MessageBox.Show("Your Version is 3.3")
        'If Form22.LabelVersion.Text = "Version 3.3" Then
        ' If Form3.Label3.Text = "Version 3.3" Then
        'MessageBox.Show("Your Version is 3.4")
        'MsgBox("Version is not Done", MsgBoxStyle.Information)
        'End If
        'End If
        'End If

        If Form29.PictureBox1.Visible = True Then
            PictureBox2.Visible = True
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            Form29.WindowState = FormWindowState.Minimized
        End If
        If Form29.PictureBox2.Visible = True Then
            PictureBox2.Visible = False
            PictureBox3.Visible = True
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            Form29.WindowState = FormWindowState.Minimized
        End If
        If Form29.PictureBox3.Visible = True Then
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = True
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            Form29.WindowState = FormWindowState.Minimized
        End If
        If Form29.PictureBox4.Visible = True Then
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = True
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            Form29.WindowState = FormWindowState.Minimized
        End If
        If Form29.PictureBox5.Visible = True Then
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = True
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            Form29.WindowState = FormWindowState.Minimized
        End If
        If Form29.PictureBox6.Visible = True Then
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = True
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            Form29.WindowState = FormWindowState.Minimized
        End If
        If Form29.PictureBox7.Visible = True Then
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = True
            PictureBox9.Visible = False
            Form29.WindowState = FormWindowState.Minimized
        End If
        If Form29.PictureBox8.Visible = True Then
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = True
            Form29.WindowState = FormWindowState.Minimized
        End If
    End Sub

    Private Sub Button9_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form16.Show()
    End Sub

    Private Sub Button10_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Form19.Show()
    End Sub

    Private Sub Button11_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form19.Show()
    End Sub

    Private Sub Button14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Timer1.Start()
        Button14.Text = "Click her"
        If ProgressBar2.Value = 100 Then
            Button13.Visible = True
            Button14.Text = "No click her"
        End If
    End Sub

    Private Sub Button12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Form16.Show()
    End Sub

    Private Sub Button13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        'Form33.Show()
        'Form33.Timer1.Start()
        'Me.Close()
        MsgBox("???")
    End Sub

    Private Sub Button15_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Errorbox1.Show()
        Errorbox1.al.Text = "Bug fix program remove from Sebs SW"
        Errorbox1.Text = "remove from Sebs SW"
    End Sub

    Private Sub Button16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form9.Show()
    End Sub

    Private Sub Button17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form19.Show()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label2.Text = Format(Now, "HH:mm:ss")
        Label1.Text = Format(Now, "dd-MM-yyyy")
        Label6.Text = Format(Now, "HH:mm:ss")
        Label5.Text = Format(Now, "dd-MM-yyyy")
        Label8.Text = Format(Now, "HH:mm:ss")
        Label9.Text = Format(Now, "dd-MM-yyyy")
        If TextBox1.Text = "" Then
            SearchSW.Stop()
        Else
            SearchSW.Start()
        End If
        If Username1.Text = "" Then
            Username1.Text = "Sebs SW"
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button5_Click_4(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form27.Show()
        Form27.Label1.Text = "???"
    End Sub

    Private Sub Button8_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form23.Show()
    End Sub

    Private Sub startbutton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startbutton2.Click
        Panel3.Visible = False
        'SearchSW.Stop()
        startbutton2.Visible = False
        Startbutton.Visible = True
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        Form34.Show()
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        Form3.Show()
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        Form21_Old.Show()
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        Form23.Show()
    End Sub

    Private Sub Startbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Startbutton.Click
        Panel3.Visible = True
        If Username1.Text = "" Then
        Else
            Username2.Text = Username1.Text
        End If
        'SearchSW.Start()
        startbutton2.Visible = True
        Startbutton.Visible = False
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        Form32.Show()
    End Sub

    Private Sub settings1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settings1.Click
        Form21_Old.Show()
    End Sub

    Private Sub lionsexplorer1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lionsexplorer1.Click
        Form34.Show()
    End Sub

    Private Sub Button9_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        
        
    End Sub

    Private Sub More_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles More.Click
        ShutdownB.Visible = True
        RestartB.Visible = True
        More.Visible = False
        more2.Visible = True
    End Sub

    Private Sub Button18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Form15.Show()
        Form15.TextBox1.ReadOnly = True
        Form15.TextBox1.Text = "You can click on the start button " & vbNewLine _
        & "and now you can see all your Programs " & vbNewLine _
        & "do you want to see the web " & vbNewLine _
        & "click on the Lion "
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click

    End Sub

    Private Sub PictureBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.Click
        Form38.Show()
    End Sub

    Private Sub tabletmodetimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabletmodetimer.Tick
        If Panel4.Visible = True Then
            'Form21.Button19.Enabled = False
        Else
            'Form21.Button19.Enabled = True
        End If
    End Sub

    Private Sub PictureBox24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox24.Click
        Panel3.Visible = True
        If Username1.Text = "" Then
        Else
            Username2.Text = Username1.Text
        End If
        'SearchSW.Start()
        PictureBox24.Visible = False
        PictureBox20.Visible = True
    End Sub

    Private Sub restartbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles restartbutton.Click
        Form33.Show()
        Form33.Timer1.Start()
    End Sub

    Private Sub shutdownbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles shutdownbutton.Click
        Form33.Show()
        Form33.Timer2.Start()
    End Sub

    Private Sub PictureBox20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox20.Click
        Panel3.Visible = False

        PictureBox24.Visible = True
        PictureBox20.Visible = False
        'SearchSW.Stop()
        PictureBox24.Visible = True
        PictureBox20.Visible = False
    End Sub

    Private Sub PictureBox23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox23.Click
        Form35.Show()
    End Sub

    Private Sub PictureBox19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox19.Click
        Form36.Show()
    End Sub

    Private Sub PictureBox21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox21.Click
        Form21_Old.Show()
    End Sub

    Private Sub PictureBox22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox22.Click
        Form31.Show()
    End Sub

    Private Sub SearchSW_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchSW.Tick
        If TextBox1.Text = "webt" Then
            PictureBox25.Visible = True
        Else
            PictureBox25.Visible = False
        End If
        If Panel4.Visible = True Then
            PictureBox16.Visible = False
        End If
        If TextBox1.Text = "Lions" Then
            PictureBox16.Visible = True
        Else
            PictureBox16.Visible = False
        End If
        If TextBox1.Text = "CMD" Then
            PictureBox26.Visible = True
        Else
            PictureBox26.Visible = False
        End If
        If TextBox1.Text = "Run" Then
            PictureBox17.Visible = True
        Else
            PictureBox17.Visible = False
        End If
        If TextBox1.Text = "settings" Then
            PictureBox15.Visible = True
        Else
            PictureBox15.Visible = False
        End If
        If TextBox1.Text = "run" Then
            PictureBox17.Visible = True
        Else
            PictureBox17.Visible = False
        End If
        If TextBox1.Text = "Run" Then
            PictureBox17.Visible = True
        Else
            PictureBox17.Visible = False
        End If
    End Sub

    Private Sub PictureBox26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox26.Click
        Form17.Show()
    End Sub

    Private Sub PictureBox27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox27.Click
        Form33.Show()
        Form33.Timer2.Start()
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        Form33.Show()
        Form33.Timer2.Start()
    End Sub

    Private Sub Panel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShutdownB.Click
        Form33.Show()
        Form33.Timer2.Start()
    End Sub

    Private Sub Panel6_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles RestartB.Paint

    End Sub

    Private Sub Panel6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartB.Click
        AboutBox23.Show()

    End Sub

    Private Sub PictureBox28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox28.Click
        'AboutBox23.Show()
        MsgBox("Start CV Window and then restart")
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        'AboutBox23.Show()
        MsgBox("Start CV Window and then restart")
    End Sub

    Private Sub more2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles more2.Click
        ShutdownB.Visible = False
        RestartB.Visible = False
        More.Visible = True
        more2.Visible = False
    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        Form21_Old.Show()
    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        Form19.Show()
    End Sub

    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox17.Click
        AboutBox17.Show()
    End Sub

    Private Sub PictureBox25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox25.Click
        Form34.Show()
    End Sub

    Private Sub SWBTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SWBTimer.Tick
        If Text = "Sebs SW B" Then
            PictureBox18.Visible = True
            PictureBox29.Visible = True
        End If
    End Sub

    Private Sub PictureBox29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox29.Click
        Panel4.Visible = True
        Panel1.Visible = False
    End Sub

    Private Sub PictureBox30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox30.Click
        'Form33.Show()
        'Form33.Timer2.Start()
        MsgBox("Start CV Window and then shutdown")
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
