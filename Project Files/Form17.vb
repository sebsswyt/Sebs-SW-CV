Public Class Form17

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If RichTextBox1.Text = "C:/Sebs-SW-CV/Lions explorer2" Then
            Form19.Show()
            Form19.Button6.Enabled = True
        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/-install newapp(???)" Then
            If Text = "Command Prompt " Then
                Form61.Show()
                Form61.Label1.Text = RichTextBox1.Text
            Else
                MsgBox("", MsgBoxStyle.Critical)
            End If
        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/Old-CMD" Then
            MenuStrip1.Visible = False
            RichTextBox1.Text = "C:/Sebs-SW"
            Text = "CMD"
            Timer2.Start()
            Timer1.Stop()
            If Form1.Button1.Visible = True Then
            Else
                If MsgBox("You need Form1. Start Form1", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Form1.Show()
                End If
            End If

        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/-install h.p from github.com -app text(new apps beta) " Then
            Text = "Command Prompt "
        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/restart -mi" Then
            Form33.Show()
            Form33.Label4.Text = "1"
            RichTextBox1.Text = "C:/Sebs-SW-CV/restart -mi - Done"
        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/install CP1.0 -1" Then
            Form5.Show()
            RichTextBox1.Text = "C:/Sebs-SW-CV/install CP1.0 - Done"
        End If
        'If RichTextBox1.Text = "C:/Sebs-SW-CV/install .exe" Then
        'Form41.Show()
        'RichTextBox1.Text = "C:/Sebs-SW-CV/install .exe - Done"
        'End If
        'If RichTextBox1.Text = "C:/Sebs-SW-CV/install .exe" Then
        'Form41.Show()
        'RichTextBox1.Text = "C:/Sebs-SW-CV/install .exe - Done"
        'End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/ONKey" Then
            Form60.Show()
            RichTextBox1.Text = "C:/Sebs-SW-CV/ONKey - Done"
        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/explorer" Then
            Form1.Show()
            Form1.Timer3.Start()
            RichTextBox1.Text = "C:/Sebs-SW-CV/explorer - Done"
        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/install CMD-internet++" Then
            Form35.Show()
            RichTextBox1.Text = "C:/Sebs-SW-CV/install CMD-internet++ - Done"
        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/sebs sw b" Then

            RichTextBox1.Text = "C:/Sebs-SW-CV/sebs sw b - Done"
            If MsgBox("back old default wallpaper", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                form1Pad.Picture6.Visible = False
                form1Pad.Picture1.Visible = True
                form1Pad.Picture6.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/13.F" Then
            form1Pad.Panel1.BackColor = Color.DarkGray
            RichTextBox1.Text = "C:/Sebs-SW-CV"
        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/taskman" Then
            Form25.Show()
            RichTextBox1.Text = "C:/Sebs-SW-CV/taskman - Done"
        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/Time13" Then
            form1Pad.Label3.Text = "fredag:13"
            RichTextBox1.Text = "C:/Sebs-SW-CV/Time13 - Done"
            RichTextBox1.Font = New System.Drawing.Font("Trebuchet MS", 18.0!)
        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/B1" Then
            Loginz.Show()
            RichTextBox1.Text = "C:/Sebs-SW-CV/B1 - Done"
        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/Time13" Then
            RichTextBox1.Font = New System.Drawing.Font("Trebuchet MS", 18.0!)

        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/CMD2" Then
            cmdpad.Show()
            RichTextBox1.Text = "C:/Sebs-SW-CV/CMD2 - Done"
        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/Dev -d -f exit" Then
            If MsgBox("Exit Yes or No", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                form1Pad.Label11.Text = "Dev = false"
                RichTextBox1.Text = "C:/Sebs-SW-CV/Dev -d -f exit - Done"
            Else
                RichTextBox1.Text = "C:/Sebs-SW-CV/Dev -d -f exit - Stopped"
            End If

        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/LogTime13" Then
            form1Pad.Panel3.Visible = True
            RichTextBox1.Text = "C:/Sebs-SW-CV/LogTime13 - Done"
        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/startup" Then
            If Form33.Label1.Visible = True Then
                RichTextBox1.Text = "C:/Sebs-SW-CV/startup - Fail"
                MsgBox("Sorry Fail to go to Startup", MsgBoxStyle.Critical)
            Else
                Form48.Show()
                Close()
            End If
            'RichTextBox1.Text = "C:/Sebs-SW-CV/install CMD-internet++ - Done"
        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/help" Then
            Form15.Show()
            Form15.Show()
            Form15.Show()
            Form15.TextBox1.ReadOnly = True
            Form15.WindowState = FormWindowState.Normal

            Form15.TextBox1.Text = "C:/Sebs-SW-CV/install .exe" & vbNewLine _
        & "C:/Sebs-SW-CV/explorer" & vbNewLine _
        & "C:/Sebs-SW-CV/install CMD-internet++" & vbNewLine _
        & "C:/Sebs-SW-CV/13.F" & vbNewLine _
        & "C:/Sebs-SW-CV/Time13" & vbNewLine _
        & "C:/Sebs-SW-CV/13.F" & vbNewLine _
        & "C:/Sebs-SW-CV/LogTime13" & vbNewLine _
        & "C:/Sebs-SW-CV/startup" & vbNewLine _
        & "C:/Sebs-SW-CV/taskman"
            Form39.LinkLabel1.Enabled = False
            RichTextBox1.Text = "C:/Sebs-SW-CV/help - Done"
        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/back" Then
            Form15.Show()
            Form15.TextBox1.Text = "Dev 18 - add new Form1-pad"
            Form15.TextBox1.Text = "Dev 18 - add new Form1-pad"
            Form15.TextBox1.Text = "Dev 18 - add new Form1-pad"
            Form15.TextBox1.Text = "Dev 18 - add new Form1-pad"
            Form15.TextBox1.Text = "Dev 18 - add new Form1-pad"
            Form15.TextBox1.ReadOnly = True
            RichTextBox1.Text = "C:/"
        End If
        If RichTextBox1.Text = "C:/Form1_pad" Then
            Form_1pad.Show()
            RichTextBox1.Text = "C:/Dev Error"
        End If
        If RichTextBox1.Text = "C:/form1pad" Then
            form1Pad.Show()
            RichTextBox1.Text = "C:/Dev Error"
        End If
        If RichTextBox1.Text = "C:/settings" Then
            RichTextBox1.Text = "C:/settings "
            If MsgBox("New settings", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Form39.Show()
            Else
                Form21_Old.Show()
            End If
            RichTextBox1.Text = "C:/Dev Error"
        End If
        If RichTextBox1.ForeColor = Color.Black Then
            RichTextBox1.ForeColor = Color.White

        End If
        
    End Sub

    Private Sub Form17_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.Font = FontDialog1.Font
            RichTextBox1.ForeColor = FontDialog1.Color
        End If
    End Sub

    Private Sub FontDialog1_Apply(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontDialog1.Apply
        RichTextBox1.Font = FontDialog1.Font
        RichTextBox1.ForeColor = FontDialog1.Color
    End Sub

    Private Sub WindowsCMDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsCMDToolStripMenuItem.Click
        Process.Start("cmd.exe")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
        SettingsToolStripMenuItem.HideDropDown()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        RichTextBox1.Text = Form60.TextBox1.Text + Replace(sender.text, "CmD", "C:/Sebs-SW-CV/")
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If RichTextBox1.Text = "C:/Sebs-SW/Lions explorer2" Then
            Form19.Show()
            Form19.Button6.Enabled = True
        End If
        If RichTextBox1.Text = "C:/Sebs-SW/install CP1.0 -1" Then
            Form5.Show()
            RichTextBox1.Text = "C:/Sebs-SW/install CP1.0 - Done"
        End If
        If RichTextBox1.Text = "C:/Sebs-SW/restart -mi" Then
            Form33.Show()
            Form33.Label1.Text = "Restart"
            RichTextBox1.Text = "C:/Sebs-SW/restart -mi - Done"
        End If
        If RichTextBox1.Text = "C:/Sebs-SW/download update 2.8" Then
            Form8.Show()
            RichTextBox1.Text = "C:/Sebs-SW/download update 2.8 - Done"
        End If
        If RichTextBox1.Text = "SW.???.About" Then
            RichTextBox1.Text = "C:/Sebs-SW"
            MsgBox("??? is an Error for Programs in Sebs SW (Sebs Web)")
            RichTextBox1.Text = "C:/Sebs-SW"
            'SW.???.About
        End If
        If RichTextBox1.Text = "C:/Sebs-SW/download update sebs sw b -1" Then
            Form1.Text = "Sebs SW B"
        End If
        If RichTextBox1.Text = "C:/Sebs-SW/sebs sw b" Then
            RichTextBox1.Text = "C:/Sebs-SW/sebs sw b - Done"
            MsgBox("Program Builder is activated-Sebs SW B", MsgBoxStyle.Information)
            Form1.Text = "Sebs SW B"
            RichTextBox1.Text = "C:/Sebs-SW/sebs sw b - Done"
            'download update sebs sw b -1
        End If
        If RichTextBox1.Text = "C:/Sebs-SW/New User Program" Then
            RichTextBox1.Text = "C:/Sebs-SW/New User Program - Done"
            Form1.Text = "Sebs SW 3.6"
            'download update sebs sw b -1
        End If
        If RichTextBox1.Text = "C:/Sebs-SW/download Lions1.0 -install" Then
            AboutBox12.Show()
            Form9.Show()
            Form1.Panel1.Visible = False
            Form1.Panel3.Visible = False
            Form1.Panel4.Visible = False
            RichTextBox1.Text = "C:/Sebs-SW/download Lions1.0 -install - Done"
        End If
        If RichTextBox1.Text = "C:/Sebs-SW/download Lions2.0 -install" Then
            AboutBox11.Show()
            Form1.Panel1.Visible = False
            Form1.Panel3.Visible = False
            Form1.Panel4.Visible = False
            RichTextBox1.Text = "C:/Sebs-SW/download Lions2.0 -install - Done"
        End If
        If RichTextBox1.Text = "C:/Sebs-SW/OLD WEB" Then
            Form35.Show()
            Form35.Panel5.Visible = False
            RichTextBox1.Text = "C:/Sebs-SW/OLD WEB - Done"
        End If
        If RichTextBox1.ForeColor = Color.Black Then
            RichTextBox1.ForeColor = Color.White

        End If
    End Sub
End Class