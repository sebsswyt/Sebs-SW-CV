Public Class Form44

    Private Sub Form44_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox3.Text = ""
        TextBox3.Text = ""
        TextBox3.Text = ""
        TextBox3.Text = ""
        TextBox3.Text = ""
        TextBox3.Text = ""
        TextBox3.Text = ""
        Timer1.Stop()
        Timer2.Stop()
        If Form31.Button22.Text = "0" Then
            Timer1.Start()
        End If
        If Form31.Button22.Text = "1" Then
            Timer2.Start()
        End If
       
        
        

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

        TextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If form1Pad.Picture2.Visible = True Then
            TextBox3.Text = "B-2"
        End If
        If form1Pad.Picture3.Visible = True Then
            TextBox3.Text = "B-3"
        End If
        If form1Pad.Picture4.Visible = True Then
            TextBox3.Text = "B-4"
        End If

    End Sub

    Private Sub OpenFileDialog2_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog2.FileOk
        TextBox2.Visible = True
        TextBox2.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog2.FileName)
        form1Pad.Picture6.Load(TextBox2.Text)
        Close()
    End Sub

    Private Sub OpenFileDialog2_HelpRequest(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFileDialog2.HelpRequest
        Form15.Show()
        Form15.Close()
        Form15.Show()
        Form15.TextBox1.Text = "Make a text document with Path to the Picture"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()

        OpenFileDialog1.ShowDialog()
        If TextBox1.Text = "" Then
            OpenFileDialog1.ShowDialog()
        End If
        If TextBox1.Text = "B-2" Then
            form1Pad.Picture1.Visible = False
            form1Pad.Picture2.Visible = True
        End If
        If TextBox1.Text = "B-3" Then
            form1Pad.Picture1.Visible = False
            form1Pad.Picture3.Visible = True
        End If
        If TextBox1.Text = "B-4" Then
            form1Pad.Picture1.Visible = False
            form1Pad.Picture4.Visible = True
        End If
        If TextBox1.Text = "B-5" Then
            form1Pad.Picture1.Visible = False
            form1Pad.Picture5.Visible = True
        End If
        If TextBox1.Text = "B-6" Then
            form1Pad.Picture1.Visible = False
            form1Pad.Picture6.Visible = True
            Form43.Show()
            If Form43.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                form1Pad.Picture1.Visible = False
                form1Pad.Picture2.Visible = False
                form1Pad.Picture3.Visible = False
                form1Pad.Picture4.Visible = False
                form1Pad.Picture5.Visible = False
                form1Pad.Picture6.Visible = True
                form1Pad.Picture6.Load(Form43.OpenFileDialog1.FileName)
                Form43.Close()
                Close()
            End If
        End If
        If TextBox1.Text = "B-7" & vbNewLine _
        & "B-7-N" & vbNewLine _
        & "" Then

            form1Pad.Picture1.Visible = False
            form1Pad.Picture6.Visible = True
            OpenFileDialog2.ShowDialog()

        End If
        Timer2.Stop()
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Timer2.Stop()

        'SaveFileDialog1.ShowDialog()
        Timer2.Stop()

    End Sub
End Class