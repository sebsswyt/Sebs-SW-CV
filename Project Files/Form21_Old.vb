Public Class Form21_Old

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form41.Show()
        Panel1.Visible = False
        Panel2.Visible = False
        ggg.Visible = False
        Panel3.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Panel1.Visible = True
        Panel2.Visible = False
        ggg.Visible = False
        Panel3.Visible = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Panel1.Visible = False
        Panel2.Visible = False
        ggg.Visible = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        AboutBox12.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        AboutBox11.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'LoginForm1.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
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
        Form20.Close()
        Errorbox1.Close()
        AboutBox3.Close()
        AboutBox5.Close()
        AboutBox7.Close()
        AboutBox8.Close()
        Form1.Show()
        Form1.Panel2.Visible = True
        Form1.PictureBox1.Visible = False
        Form1.PictureBox2.Visible = False
        Form1.PictureBox3.Visible = False
        Form1.PictureBox4.Visible = False
        Form1.PictureBox5.Visible = False
        Form1.PictureBox6.Visible = False
        Form1.PictureBox7.Visible = False
        Form1.PictureBox8.Visible = False
        Form1.PictureBox9.Visible = False
        Form1.Button1.Visible = False
        Form1.Button2.Visible = False
        Form1.Button3.Visible = False
        Form1.Button4.Visible = False
        Form1.Button7.Visible = False
        Form1.Button10.Visible = False
        Form1.Button6.Visible = False
        Form1.Panel2.Visible = True
        Form1.Label1.Visible = False
        Form1.Label2.Visible = False
        Form1.Panel1.Visible = False
        Form1.Text = "Stopped Desktroy Error"
        Me.Close()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Panel2.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Panel1.Visible = False
        Panel2.Visible = True
        ggg.Visible = False
        Panel3.Visible = False
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form10.Show()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Panel2.Visible = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form26.Show()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form22.Show()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Form1.Button15.Visible = True
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Panel1.Visible = False
        Panel2.Visible = False
        ggg.Visible = True
        Panel3.Visible = False
        'Form43.Show()
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Panel1.Visible = False
        Panel2.Visible = False
        ggg.Visible = False
        Button21.Enabled = False
        Label15.Visible = False
        Panel3.Visible = False
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Button21.Enabled = True
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Button21.Enabled = False

        If TextBox2.Text = "Silan" Then
            AboutBox18.Show()
        End If
        If TextBox2.Text = "silan" Then
            AboutBox18.Show()
        End If
        If TextBox2.Text = "Display" Then
            Form6.Show()
        End If
        If TextBox2.Text = "display" Then
            Form6.Show()
        End If
        If TextBox2.Text = "Programs" Then
            Form7.Show()
        End If
        If TextBox2.Text = "programs" Then
            Form7.Show()
        End If
        If TextBox2.Text = "User" Then
            Form10.Show()
        End If
        If TextBox2.Text = "user" Then
            Form10.Show()
        End If
        If TextBox2.Text = "Desktroy" Then
            Form12.Show()
        End If
        If TextBox2.Text = "desktroy" Then
            Form12.Show()
        End If ' Tristan
        If TextBox2.Text = "Tristan" Then
            MsgBox("Tristan!!")
        End If
        If TextBox2.Text = "tristan" Then
            MsgBox("Tristan!!")
        End If
        
        'Me.Label12.Text = TextBox2.Text
        'Form2.Label1.Text = TextBox2.Text
        'Form27.Show()

        'Username to Form1
        If TextBox2.Text = "" Then
            MsgBox("Sorry Ned 1 Character")
        Else
            'Form1.Username1.Text = TextBox2.Text
        End If
        'Update Username in Panal3
        If Form1.Panel3.Visible = True Then
            'Form1.Username2.Text = TextBox2.Text
        End If
        'New Code?
        If TextBox2.Text = "???" Then
            'Form1.Username1.Text = "Sebs SW"
        End If
        If TextBox2.Text = "???" Then
            MsgBox("Can't Display User Name!", MsgBoxStyle.Critical)
            Form2.Label1.Text = "Sebs SW"
            Me.Label12.Text = "Sebs SW"
        End If
        
        If Form27.Label1.Text = "Display" Then
            Form27.Label1.Text = "???"
            Form2.Label1.Text = Form27.Label1.Text
            Me.Label12.Text = Form1.Label1.Text
        End If
        If Form27.Label1.Text = "display" Then
            'Form1.nameline.Text = "???"
            'Me.Label12.Text = Form1.nameline.Text
        End If
        If Form27.Label1.Text = "User" Then
            Form27.Label1.Text = "???"
            Form2.Label1.Text = Form1.Label1.Text
            'Me.Label12.Text = Form1.nameline.Text
        End If
        If Form27.Label1.Text = "user" Then
            Form27.Label1.Text = "???"
            'Form2.Label1.Text = Form1.nameline.Text
            'Me.Label12.Text = Form1.nameline.Text
        End If
        If Form27.Label1.Text = "Programs" Then
            Form27.Label1.Text = "???"
            Form2.Label1.Text = Form1.Label1.Text
            Me.Label12.Text = Form1.Label1.Text
        End If
        If Form27.Label1.Text = "programs" Then
            Form27.Label1.Text = "???"
            Form2.Label1.Text = Form27.Label1.Text
            Me.Label12.Text = Form27.Label1.Text
        End If
        If Form27.Label1.Text = "Desktroy" Then
            Form27.Label1.Text = "???"
            Form2.Label1.Text = Form27.Label1.Text
            Me.Label12.Text = Form27.Label1.Text
        End If
        If Form27.Label1.Text = "desktroy" Then
            Form27.Label1.Text = "???"
            Form2.Label1.Text = Form27.Label1.Text
            Me.Label12.Text = Form27.Label1.Text
        End If

    End Sub

    Private Sub Button12_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click

        Panel1.Visible = False
        Panel2.Visible = False
        ggg.Visible = False
        Panel3.Visible = False
    End Sub

    Private Sub Form21_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        If Form1.Panel1.Visible = False Then
            Label13.Text = "Classic"
        Else
            Label13.Text = "Modern"
        End If
        If Form1.Panel4.Visible = False Then
            Label13.Text = "Tablet Mode"
        End If
        If Form27.Label1.Visible = False Then
            Me.Label12.Text = "Sebs SW"
        End If

        If Form27.Label1.Visible = True Then
            Label12.Text = TextBox2.Text
        Else
            Me.Label12.Text = "Sebs SW"
        End If
        If Form27.Button1.Text = ":) :(" Then
            'Label12.Text = Form1.nameline.Text
            Form27.Close()
        End If

    End Sub

    Private Sub Button18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click

        Panel1.Visible = False
        Panel2.Visible = False
        ggg.Visible = False
        Panel3.Visible = False
    End Sub

    Private Sub Button14_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Panel1.Visible = False
        Panel2.Visible = False
        ggg.Visible = False
        Panel3.Visible = True
        If Form1.Panel1.Visible = False Then
            Label13.Text = "Classic"
        Else
            Label13.Text = "Modern"
        End If
    End Sub

    Private Sub Button19_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Form1.Panel1.Visible = False
        Form1.Panel3.Visible = False
        Form1.Panel4.Visible = False
        Label13.Text = "Classic"
    End Sub

    Private Sub Button20_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Timer1.Start()
        Form1.Panel1.Visible = True
        Form1.Panel3.Visible = False
        Form1.Panel4.Visible = False
        Label13.Text = "Modern"
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form6.Show()
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form7.Show()
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        Form1.WindowState = FormWindowState.Normal
        AboutBox23.Show()
        Form33.rest1.Text = "Normal"
        Form33.rest1.Text = "Normal"
        Form33.rest1.Text = "Normal"
        Form33.rest1.Text = "Normal"
        Form33.rest1.Text = "Normal"
        Form33.rest1.Text = "Normal"
        Form33.rest1.Text = "Normal"
        Form33.rest1.Text = "Normal"
        Form33.rest1.Text = "Normal"
        Form33.rest1.Text = "Normal"
        Form33.rest1.Text = "Normal"

    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        Form1.WindowState = FormWindowState.Maximized
        AboutBox23.Show()
        Form33.rest1.Text = "Maximized"
        Form33.rest1.Text = "Maximized"
        Form33.rest1.Text = "Maximized"
        Form33.rest1.Text = "Maximized"
        Form33.rest1.Text = "Maximized"
        Form33.rest1.Text = "Maximized"
        Form33.rest1.Text = "Maximized"
        Form33.rest1.Text = "Maximized"

    End Sub

    Private Sub Button24_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        Form1.Panel3.Visible = False
        Form1.Panel4.Visible = True
        Form1.Panel1.Visible = False
        Label13.Text = "Tablet Mode"
    End Sub

    Private Sub sysinfoB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sysinfoB.Click
        Form22.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Panel1.Visible = False
        Panel2.Visible = False
        ggg.Visible = True
        Panel3.Visible = False
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Panel1.Visible = False
        Panel2.Visible = True
        ggg.Visible = False
        Panel3.Visible = False
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Panel1.Visible = True
        Panel2.Visible = False
        ggg.Visible = False
        Panel3.Visible = False
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Form26.Show()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Panel1.Visible = False
        Panel2.Visible = False
        ggg.Visible = False
        Panel3.Visible = True
        If Form1.Panel1.Visible = False Then
            Label13.Text = "Classic"
        Else
            Label13.Text = "Modern"
        End If
        'theme_window.Show()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Form41.Show()
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form15.Show()
        Form15.TextBox1.ReadOnly = True
        Form15.TextBox1.Text = "if you have Windows 7" & vbNewLine _
        & "Go to your Settings" & vbNewLine _
        & "and now see all your PC Settings" '& vbNewLine _
        '& "About ??? Error"
    End Sub

    Private Sub Button13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        If Button1.Visible = False Then
            Button1.Visible = True
            Button2.Visible = True
            Button3.Visible = True
            Button17.Visible = True
            Button14.Visible = True
        Else
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button17.Visible = False
            Button14.Visible = False
        End If
        
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If Button19.Enabled = False Then
            Timer1.Stop()
        Else
            Button19.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Panel1.Visible = False Then
            If Panel4.Visible = False Then
                Timer1.Start()
            End If
        End If
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        If Form1.Text = "Sebs SW B" Then
            MsgBox("Program Builder is activated-Sebs SW B", MsgBoxStyle.Information)
        Else
            'LoginForm1.Show()
        End If
    End Sub
End Class