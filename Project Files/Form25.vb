Public Class Form25

    Private Sub RestartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartToolStripMenuItem.Click
        Form33.Show()
        Form33.Timer1.Start()
    End Sub

    Private Sub SToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SToolStripMenuItem.Click
        Form33.Show()
        Form33.Timer2.Start()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox15.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form19.Close()
    End Sub

    Private Sub Form25_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Form19.Button1.Visible = False Then
            Button1.Visible = False
        End If
        If Form14.Button1.Visible = False Then
            Button2.Visible = False
        End If
        If Form24.Panel1.Visible = False Then
            Button3.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form14.Close()
    End Sub

    Private Sub NOMenuToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NOMenuToolStripMenuItem1.Click
        AboutBox16.Show()
    End Sub

    Private Sub NewTaskToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewTaskToolStripMenuItem.Click
        AboutBox17.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        form1Pad.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If form1Pad.cvtaskbar.Visible = True Then
            form1Pad.cvtaskbar.Visible = False
            Button6.Text = "form1Pad.exe start taskbar"
        Else
            Cursor = Cursors.AppStarting
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = 5 Then
            Cursor = Cursors.AppStarting
        End If
        If ProgressBar1.Value = 30 Then
            Cursor = Cursors.Default
            form1Pad.cvtaskbar.Visible = True
            Timer1.Stop()
            ProgressBar1.Value = 0
            Button6.Text = "form1Pad.exe stop taskbar"
        End If
    End Sub
End Class