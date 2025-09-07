Public Class cmdpad
    Dim mouse_move As System.Drawing.Point
    Private Sub WindowsCMDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsCMDToolStripMenuItem.Click
        Process.Start("cmd.exe")
    End Sub

    Private Sub MenuStrip1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuStrip1.MouseDown
        mouse_move = New Point(-e.X, -e.Y)
    End Sub

    Private Sub MenuStrip1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuStrip1.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Dim mposition As Point
            mposition = Control.MousePosition
            mposition.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mposition
            If RichTextBox1.Text = "Friday" Then
                'SettingsToolStripMenuItem.DropDownItems
            Else
                SettingsToolStripMenuItem.HideDropDown()
            End If
        End If
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

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
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
        & "C:/Sebs-SW-CV/startup"
            Form39.LinkLabel1.Enabled = False
            RichTextBox1.Text = "C:/Sebs-SW-CV/help - Done"
        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/taskman" Then
            Form25.Show()
            RichTextBox1.Text = "C:/Sebs-SW-CV/taskman - Done"
        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/Lions explorer2" Then
            Form19.Show()
            Form19.Button6.Enabled = True
        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/install .exe" Then
            Form41.Show()
            RichTextBox1.Text = "C:/Sebs-SW-CV/install .exe - Done"
        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/install .exe" Then
            Form41.Show()
            RichTextBox1.Text = "C:/Sebs-SW-CV/install .exe - Done"
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
        If RichTextBox1.Text = "C:/Sebs-SW-CV/13.F" Then
            form1Pad.Panel1.BackColor = Color.DarkGray
            RichTextBox1.Text = "C:/Sebs-SW-CV"
        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/Time13" Then
            form1Pad.Label3.Text = "fredag:13"
            RichTextBox1.Text = "C:/Sebs-SW-CV/Time13 - Done"
            'RichTextBox1.Font = New System.Drawing.Font("Trebuchet MS", 18.0!)
        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/Time13" Then
            'RichTextBox1.Font = New System.Drawing.Font("Trebuchet MS", 18.0!)

        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/LogTime13" Then
            form1Pad.Panel3.Visible = True
            RichTextBox1.Text = "C:/Sebs-SW-CV/LogTime13 - Done"
        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/startup" Then
            If Form33.Label1.Visible = True Then
                MsgBox("Sorry Fail to go to Startup", MsgBoxStyle.Critical)
                RichTextBox1.Text = "C:/Sebs-SW-CV/startup - Fail"
            Else
                Form48.Show()
                Close()
            End If
            RichTextBox1.Text = "C:/Sebs-SW-CV/install CMD-internet++ - Done"
        End If
        If RichTextBox1.Text = "C:/Sebs-SW-CV/B1" Then
            Loginz.Show()
        End If
        If RichTextBox1.ForeColor = Color.Black Then
            RichTextBox1.ForeColor = Color.White

        End If
    End Sub

    Private Sub OldCMDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OldCMDToolStripMenuItem.Click
        Form17.Show()
        Close()
    End Sub
End Class