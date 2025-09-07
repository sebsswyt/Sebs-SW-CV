Public Class Form8

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
        Button1.Visible = False
        Button3.Visible = True
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click
        If Me.ProgressBar1.Value = 100 Then
            Button2.Enabled = True
        End If
    End Sub

    

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
        Form2.Close()
        Explorer1.Close()
        Form9.Close()
        Form10.Close()
        Form11.Close()
        Form12.Close()
        Form13.Close()
        Form14.Close()
        Form15.Close()
        Errorbox1.Close()
        Restartform.Show()
        Me.Close()
        
        
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Timer1.Stop()
        Button3.Visible = False
        Button1.Visible = True
    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class