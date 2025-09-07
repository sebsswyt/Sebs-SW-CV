Public Class Form54

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Form33.ProgressBar3.Value = 5 Then
            Label1.Text = "Starting up."
        End If
        If Form33.ProgressBar3.Value = 10 Then
            Label1.Text = "Starting up.."
        End If
        If Form33.ProgressBar3.Value = 15 Then
            Label1.Text = "Starting up..."
        End If
        If Form33.ProgressBar3.Value = 20 Then
            Label1.Text = "Starting up.."
        End If
        If Form33.ProgressBar3.Value = 25 Then
            Label1.Text = "Starting up."
        End If
        If Form33.ProgressBar3.Value = 30 Then
            Label1.Text = "Starting up.."
        End If
        If Form33.ProgressBar3.Value = 35 Then
            Label1.Text = "Starting up..."
        End If
        If Form33.ProgressBar3.Value = 40 Then
            Label1.Text = "Starting up.."
        End If
    End Sub

    Private Sub Form54_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Close()
    End Sub
End Class