Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form3.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("Sorry Lions explorer 1.0 and 2.0 are removed")
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
        Form14.Show()
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
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        If V.Text = "???" Then
            Panel1.Visible = False
        Else
            Panel1.Visible = True
        End If
        PictureBox2.Visible = False
        PictureBox8.Visible = True
        If Form29.PictureBox1.Visible = True Then
            PictureBox2.Visible = True
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            WindowState = FormWindowState.Minimized
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
            WindowState = FormWindowState.Minimized
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
            WindowState = FormWindowState.Minimized
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
            WindowState = FormWindowState.Minimized
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
            WindowState = FormWindowState.Minimized
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
            WindowState = FormWindowState.Minimized
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
            WindowState = FormWindowState.Minimized
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
            WindowState = FormWindowState.Minimized
        End If
    End Sub

    Private Sub Button9_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form16.Show()
    End Sub

    Private Sub Button10_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Form35.Show()
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
        Restartform.Show()
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
        Label1.Text = Format(Now, "dddd MMMM yyyy")
        Label6.Text = Format(Now, "HH:mm:ss")
        Label5.Text = Format(Now, "dddd MMMM yyyy")
        
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button5_Click_4(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form27.Show()
        Form27.Label1.Text = "???"
    End Sub

    Private Sub Button8_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Form23.Show()
    End Sub

    Private Sub PictureBox10_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Startbutton.MouseClick
        
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        Form35.Show()
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        Form31.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        Form5.Show()
    End Sub

    Private Sub Startbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Startbutton.Click
        Panel3.Visible = True
        SearchFN.Start()
        startbutton2.Visible = True
        Startbutton.Visible = False
        If PictureBox9.Visible = True Then
            Panel3.BackColor = Color.DimGray
        Else
            Panel3.BackColor = Color.DarkGray
        End If
    End Sub

    Private Sub startbutton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startbutton2.Click
        Panel3.Visible = False
        SearchFN.Stop()
        startbutton2.Visible = False
        Startbutton.Visible = True
    End Sub

    Private Sub settings1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settings1.Click
        Form39.Show()
    End Sub

    Private Sub lionsexplorer1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lionsexplorer1.Click
        Form35.Show()
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form35.Show()
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        Form35.Show()
    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        Form5.Show()
    End Sub

    Private Sub TextBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Enter
        If TextBox1.Text = "web" Then
            PictureBox14.Visible = True
        Else
            PictureBox14.Visible = False
        End If
        If TextBox1.Text = "settings" Then
            PictureBox15.Visible = True
        Else
            PictureBox15.Visible = False
        End If
        
    End Sub

    Private Sub More_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles More.Click
        If shutdownbutton.Visible = False Then
            shutdownbutton.Visible = True
            restartbutton.Visible = True
        Else
            shutdownbutton.Visible = False
            restartbutton.Visible = False
        End If
    End Sub

    Private Sub restartbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles restartbutton.Click
        MsgBox("Sorry. Restart the program in settings or New Start menu on form1pad")
    End Sub

    Private Sub Button9_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        
        
        If TextBox1.Text = "run" Then
            Button11.Visible = True
        Else
            Button11.Visible = False
        End If
        If TextBox1.Text = "Run" Then
            Button11.Visible = True
        Else
            Button11.Visible = False
        End If
    End Sub

    Private Sub Button11_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        AboutBox17.Show()
        AboutBox17.Button10.Enabled = False
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Form37.Show()
        Form37.TextBox1.Text = "You can click on the start button " & vbNewLine _
        & "and now you can see all your Programs " & vbNewLine _
        & "do you want to see the web " & vbNewLine _
        & "click on the Lion "

    End Sub

    Private Sub shutdownbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles shutdownbutton.Click
        MsgBox("Sorry. Shutdown the program in settings or New Start menu on form1pad")
    End Sub

    Private Sub Settinsp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Settinsp.Click
        Form21_Old.Show()
    End Sub

    Private Sub SearchFN_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchFN.Tick
        If TextBox1.Text = "web" Then
            PictureBox14.Visible = True
        Else
            PictureBox14.Visible = False
        End If
        If TextBox1.Text = "42" Then
            Form42.Show()
            TextBox1.Text = ""
        End If
        If TextBox1.Text = "vc" Then
            Form38.Show()
            TextBox1.Text = ""
        End If
        If TextBox1.Text = "webpad" Then
            PictureBox13.Visible = True
        Else
            PictureBox13.Visible = False
        End If
        If TextBox1.Text = "settings" Then
            PictureBox15.Visible = True
        Else
            PictureBox15.Visible = False
        End If
        If TextBox1.Text = "settings1" Then
            Settinsp.Visible = True
        Else
            Settinsp.Visible = False
        End If
        If TextBox1.Text = "settings2" Then
            Form20.Show()

        End If
        If TextBox1.Text = "Update" Then
            'TextBox1.Text = ""
            'MsgBox("Error with Open Form", MsgBoxStyle.Critical)
            'SearchFN.Stop()
            updaterform1.Show()
        Else
            SearchFN.Start()
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If Panel1.Visible = True Then
            Panel1.Visible = False
        End If
        Form2.Button7.Enabled = True
        Form2.Button4.Enabled = True
        Form2.Button1.Enabled = True
        Form2.Button3.Enabled = True
    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        Form21_Old.Show()
    End Sub

    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartBt.Click
        StartBF.Visible = True
        StartBt.Visible = False
        Panel3.Visible = False
        Panel5.Visible = True
    End Sub

    Private Sub StartBF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartBF.Click
        StartBF.Visible = False
        StartBt.Visible = True
        Panel5.Visible = False
    End Sub

    Private Sub PictureBox20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox20.Click
        Form35.Show()
    End Sub

    Private Sub PictureBox19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox19.Click
        Form31.Show()
    End Sub

    Private Sub PictureBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.Click
        Form21_Old.Show()
    End Sub

    Private Sub PictureBox13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        Form35.Show()
    End Sub

    Private Sub PictureBox13_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.MouseEnter
        PictureBox13.BackColor = Color.AliceBlue
    End Sub

    Private Sub PictureBox13_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.MouseLeave
        PictureBox13.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox22.Click
        form1Pad.Show()
    End Sub

    Private Sub PictureBox21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox21.Click
        form1Pad.Show()
    End Sub

    Private Sub PictureBox17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox17.Click
        Form21_Old.Show()
    End Sub
End Class
