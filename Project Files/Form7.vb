Public Class Form7

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        AboutBox12.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Button2.Enabled = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        AboutBox11.Show()
    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Form41.Show()
        'Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Start()
        Cursor = Cursors.AppStarting
        PictureBox1.Cursor = Cursors.AppStarting
        ProgressBar1.Cursor = Cursors.AppStarting
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(3)
        If ProgressBar1.Value = 100 Then
            Cursor = Cursors.Default
            PictureBox1.Cursor = Cursors.Default
            ProgressBar1.Cursor = Cursors.Default
            form1Pad.cvtaskbar.Visible = False
            Button2.Enabled = False
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        form1Pad.Picture1.Visible = False
        form1Pad.Picture2.Visible = False
        form1Pad.Picture3.Visible = False
        form1Pad.Picture4.Visible = False
        form1Pad.Picture5.Visible = False
        form1Pad.Picture6.Visible = False
        form1Pad.Picture7.Visible = False
        form1Pad.Start_menu.Visible = False
        form1Pad.Panel1.Visible = False
        form1Pad.BackColor = Color.Black
        MsgBox("you are dum. you can't start the program again")
    End Sub
End Class