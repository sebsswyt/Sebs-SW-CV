Public Class Form28

    Private Sub Form28_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form27.Close()
        form1Pad.Label7.Text = "ON"
        form1Pad.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = 40 Then
            Timer1.Stop()
            Button1.Text = "??? "
        End If
    End Sub

    Private Sub Form28_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Button1.Text = "??? " Then
            Form1.Show()
            Form1.Timer3.Start()
        Else
            AboutBox25.Show()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class