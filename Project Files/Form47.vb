Public Class Form47

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            If Label2.Text = "1" Then
                Form33.Show()
                Form33.Label4.Text = "1"
                Form33.Timer1.Start()
                Close()
            Else
                Form57.Show()
                Form57.StartingTimer.Start()
                'Form33.PictureBox1.Visible = False
                'Form33.PictureBox2.Visible = True
                Close()
            End If
        End If
    End Sub

    Private Sub Form47_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DebuggerForm.Show()
    End Sub
End Class