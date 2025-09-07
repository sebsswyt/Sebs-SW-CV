Public Class Form57

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("No Exit Button here")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartTimer.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 10 Then
            Label1.Text = "Restarting.."
        End If
        If ProgressBar1.Value = 15 Then
            Label1.Text = "Restarting..."

        End If
        If ProgressBar1.Value = 20 Then
            Label1.Text = "Restarting.."

        End If
        If ProgressBar1.Value = 25 Then
            Label1.Text = "Restarting."

        End If
        If ProgressBar1.Value = 30 Then
            Label1.Text = "Restarting.."
        End If
        If ProgressBar1.Value = 35 Then
            Label1.Text = "Restarting..."
        End If
        If ProgressBar1.Value = 40 Then
            Label1.Text = "Restarting.."
        End If
        If ProgressBar1.Value = 45 Then
            Label1.Text = "Restarting."
        End If
        If ProgressBar1.Value = 50 Then
            Label1.Text = "Restarting.."
            form1Pad.Label7.Text = "ON"
            form1Pad.Close()
        End If
        If ProgressBar1.Value = 55 Then
            Label1.Text = "Restarting..."
        End If
        If ProgressBar1.Value = 60 Then
            Label1.Text = "Restarting.."
        End If
        If ProgressBar1.Value = 65 Then
            Label1.Text = "Restarting."
        End If
        If ProgressBar1.Value = 70 Then
            Label1.Text = "Restarting.."
        End If
        If ProgressBar1.Value = 75 Then
            Label1.Text = "Restarting..."
        End If
        If ProgressBar1.Value = 80 Then
            Label1.Text = "Restarting.."
        End If
        If ProgressBar1.Value = 85 Then
            Label1.Text = "Restarting."
        End If
        If ProgressBar1.Value = 90 Then
            Label1.Text = "Restarting.."
        End If
        If ProgressBar1.Value = 95 Then
            Label1.Text = "Restarting..."
        End If
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Form47.Show()
            RestartTimer.Stop()
            Close()
        End If
    End Sub

    Private Sub StartingTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartingTimer.Tick
        ProgressBar1.Increment(3)
        RestartTimer.Stop()

        If ProgressBar1.Value = 5 Then
            Label1.Text = "Starting up."
        End If
        If ProgressBar1.Value = 10 Then
            Label1.Text = "Starting up.."
        End If
        If ProgressBar1.Value = 15 Then
            Label1.Text = "Starting up..."
        End If
        If ProgressBar1.Value = 20 Then
            Label1.Text = "Starting up.."
        End If
        If ProgressBar1.Value = 25 Then
            Label1.Text = "Starting up."
        End If
        If ProgressBar1.Value = 30 Then
            Label1.Text = "Starting up.."
        End If
        If ProgressBar1.Value = 35 Then
            Label1.Text = "Starting up..."
        End If
        If ProgressBar1.Value = 40 Then
            Label1.Text = "Starting up.."
        End If
        If ProgressBar1.Value = 45 Then
            Label1.Text = "Starting up."
        End If
        If ProgressBar1.Value = 50 Then
            Label1.Text = "Starting up.."
        End If
        If ProgressBar1.Value = 55 Then
            Label1.Text = "Starting up..."
        End If
        If ProgressBar1.Value = 60 Then
            Label1.Text = "Starting up.."
        End If
        If ProgressBar1.Value = 65 Then
            Label1.Text = "Starting up."
        End If
        If ProgressBar1.Value = 70 Then
            Label1.Text = "Starting up.."
        End If
        If ProgressBar1.Value = 75 Then
            Label1.Text = "Starting up..."
        End If
        If ProgressBar1.Value = 80 Then
            Label1.Text = "Starting up.."
        End If
        If ProgressBar1.Value = 85 Then
            Label1.Text = "Starting up."
        End If
        If ProgressBar1.Value = 90 Then
            Label1.Text = "Starting up.."
        End If
        If ProgressBar1.Value = 95 Then
            Label1.Text = "Starting up..."
        End If
        'Label1.Text = "Starting up"
        If Label1.Text = "Restarting." Then
            Label1.Text = "Starting up"
        Else
            If Label1.Text = "Restarting.." Then
                Label1.Text = "Starting up"
            Else
                If Label1.Text = "Restarting..." Then
                    Label1.Text = "Starting up"
                End If
            End If
        End If
        If ProgressBar1.Value = 100 Then
            Form48.Show()
            Form54.Close()
            Close()
        End If
    End Sub

    Private Sub Form57_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form49.Show()
    End Sub
End Class