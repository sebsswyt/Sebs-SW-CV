Public Class updaterform1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            ProgressBar2.Increment(1)
            If ProgressBar2.Value = 100 Then
                AboutBox19.Show()
                If Form57.Label1.Visible = True Then
                    'Form33.Timer1.Start()
                    Form57.RestartTimer.Start()
                    AboutBox19.Close()
                End If
                Me.Close()
            End If
        End If
    End Sub

    Private Sub updaterform1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        form1Pad.Label7.Text = "ON"
        form1Pad.Close()
        If Form33.Label1.Visible = True Then
            FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.BackColor = Color.CornflowerBlue
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class