Public Class Form_1pad

    Private Sub CloseToForm1pad15ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToForm1pad15ToolStripMenuItem.Click
        form1Pad.Show()
        Close()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        StartMenu.Visible = True
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        StartMenu.Visible = False
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click

        If MenuStrip1.Visible = True Then
            MenuStrip1.Visible = False
            StartMenu.Visible = False
        Else
            MenuStrip1.Visible = True
            StartMenu.Visible = False
        End If
        'StartMenu.Visible = True
    End Sub

    Private Sub StartMenu_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartMenu.VisibleChanged
        Button1.Text = My.Computer.Info.OSFullName
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Form17.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Form35.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startbutton1.Click
        StartMenu.Visible = True
        startbutton2.Visible = True
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startbutton2.Click
        StartMenu.Visible = False
        startbutton2.Visible = False
    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        Form35.Show()
        Form35.WebBrowser1.Navigate("https://sebs-sw-b.tk/info-sebs-sw-1.html")
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        Form20.Show()
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        Form22.Show()
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        Form60.Show()
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click, PictureBox11.Click, Label9.Click
        Form17.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form30.Show()
    End Sub

    Private Sub PictureBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.Click
        Form31.Show()
    End Sub

    Private Sub OpenProgram_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenProgram.Click
        Form41.Show()
    End Sub

    Private Sub settings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settings.Click
        Form21_Old.Show()
    End Sub

    Private Sub PictureBox5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Form20.Show()
    End Sub

    Private Sub PictureBox3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Form31.Show()
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        Form33.Show()
        Form33.Timer2.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        form1Pad.Show()
        Close()
    End Sub

    Private Sub Textbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Textbutton.Click
        Form15.Show()
    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form_1pad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'WASD.Show()
        easycode.Start_up_load()

        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        'Me.Panel1.Controls.Add(Me.Button14)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Textbutton)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.startbutton2)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.settings)
        Me.Panel1.Controls.Add(Me.OpenProgram)
        Me.Panel1.Controls.Add(Me.startbutton1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 619)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1281, 100)
        Me.Panel1.TabIndex = 1

        'Textbutton
        '
        Me.Textbutton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Textbutton.BackColor = System.Drawing.Color.Transparent
        Me.Textbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Textbutton.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Textbutton.Location = New System.Drawing.Point(630, 3)
        Me.Textbutton.Name = "Textbutton"
        Me.Textbutton.Size = New System.Drawing.Size(100, 94)
        Me.Textbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Textbutton.TabIndex = 44
        Me.Textbutton.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox3.Location = New System.Drawing.Point(326, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 94)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 43
        Me.PictureBox3.TabStop = False
        '
        'startbutton2
        '
        Me.startbutton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.startbutton2.BackColor = System.Drawing.Color.Transparent
        Me.startbutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.startbutton2.Location = New System.Drawing.Point(3, 3)
        Me.startbutton2.Name = "startbutton2"
        Me.startbutton2.Size = New System.Drawing.Size(100, 94)
        Me.startbutton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.startbutton2.TabIndex = 3
        Me.startbutton2.TabStop = False
        Me.startbutton2.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(220, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 94)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'settings
        '
        Me.settings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.settings.BackColor = System.Drawing.Color.Transparent
        Me.settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.settings.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.settings.Location = New System.Drawing.Point(432, 3)
        Me.settings.Name = "settings"
        Me.settings.Size = New System.Drawing.Size(88, 94)
        Me.settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.settings.TabIndex = 41
        Me.settings.TabStop = False
        '
        'OpenProgram
        '
        Me.OpenProgram.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.OpenProgram.BackColor = System.Drawing.Color.Transparent
        Me.OpenProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OpenProgram.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.OpenProgram.Location = New System.Drawing.Point(524, 3)
        Me.OpenProgram.Name = "OpenProgram"
        Me.OpenProgram.Size = New System.Drawing.Size(100, 94)
        Me.OpenProgram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OpenProgram.TabIndex = 40
        Me.OpenProgram.TabStop = False
        '
        'startbutton1
        '
        Me.startbutton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.startbutton1.BackColor = System.Drawing.Color.Transparent
        Me.startbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.startbutton1.Location = New System.Drawing.Point(3, 3)
        Me.startbutton1.Name = "startbutton1"
        Me.startbutton1.Size = New System.Drawing.Size(100, 94)
        Me.startbutton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.startbutton1.TabIndex = 1
        Me.startbutton1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(109, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(105, 94)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False

        If UI.GetInternalWebpageWebview2("Taskbar", "index.html", WebView21) = True Then
        Else
            WebView21.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox(My.Computer.Info.OSFullName)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        StartMenu.BackColor = Panel1.BackColor
        Me.BackColor = Panel1.BackColor
        'Label1.Text = Date.Now.ToString("dd-MM-yyyy")
        Label1.Text = "  " & Format(Now, "HH:mm:ss") & "
" & Format(Now, "dd-MM-yyyy")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form21_Old.Show()
    End Sub

    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form35.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form35.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form60.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form22.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form31.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Form17.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Form17.Show()
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Text = "Form_1pad " Then
            Process.Start("Internet++.exe")
        ElseIf Text = "Form_1pad  " Then
            MsgBox("No (Internet++) Program")
        ElseIf Text = "Form_1pad" Then
            Form35.Show()
        End If

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Form21_Old.Show()
    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Form60.Show()
    End Sub

    Private Sub Button8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Form22.Show()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Form30.Show()
        Form30.BackColor = Panel1.BackColor
        Form30.BackColor = Panel1.BackColor
        Form30.BackColor = Panel1.BackColor
        Form30.BackColor = Panel1.BackColor
        Form30.BackColor = Panel1.BackColor
    End Sub

    Private IsStartMenuOpen As Boolean = False
    Private Sub OpenStartMenu()
        If IsStartMenuOpen = False Then
            StartMenu.Visible = True
            startbutton2.Visible = True
            IsStartMenuOpen = True
        ElseIf IsStartMenuOpen = True Then
            StartMenu.Visible = False
            startbutton2.Visible = False
            IsStartMenuOpen = False
        End If
    End Sub

    Private Sub WebView21_CoreWebView2InitializationCompleted(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs) Handles WebView21.CoreWebView2InitializationCompleted
        If e.IsSuccess = True Then
            WebView21.CoreWebView2.Settings.AreDevToolsEnabled = False
            WebView21.CoreWebView2.Settings.AreDefaultContextMenusEnabled = False
            WebView21.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = False
            WebView21.CoreWebView2.Settings.AreDefaultScriptDialogsEnabled = False
            WebView21.CoreWebView2.Settings.IsZoomControlEnabled = False
            WebView21.CoreWebView2.Settings.UserAgent = "InternalWebview2-Edge"
            WebView21.CoreWebView2.Settings.IsStatusBarEnabled = False
            WebView21.CoreWebView2.Settings.IsPasswordAutosaveEnabled = False
            WebView21.CoreWebView2.Settings.IsGeneralAutofillEnabled = False

            AddHandler WebView21.CoreWebView2.ScriptDialogOpening, AddressOf CoreWebView2_ScriptDialogOpening
        Else
            MsgBox("Help")
        End If
    End Sub

    Private Sub CoreWebView2_ScriptDialogOpening(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2ScriptDialogOpeningEventArgs)
        If e.Message = "73037403784" Then
            OpenStartMenu()
        ElseIf e.Message = "93749373653" Then
            Form35.Show()
        ElseIf e.Message = "22438303855" Then
            Form17.Show()
        ElseIf e.Message = "28303745226" Then
            Form31.Show()
        ElseIf e.Message = "94749274533" Then
            Form21_Old.Show()
        ElseIf e.Message = "93659835647" Then
            Form55.Show()
        ElseIf e.Message = "74843937647" Then
            Form15.Show()
            'ElseIf e.Message = "73037403784" Then
        End If
        'MsgBox(e.Message)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        WebView21.Refresh()
    End Sub
End Class