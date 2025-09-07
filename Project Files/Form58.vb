Public Class Form58

    Private Sub Form58_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Minimized
    End Sub
    Public Sub startup()
        'AxWindowsMediaPlayer1.URL = "https://sebs-sw-b.tk/start-up-music.wma"
        'Timer1.Start()
    End Sub
    Public Sub Music1()
        'AxWindowsMediaPlayer1.URL = "https://sebs-sw-b.tk/title.wma"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Close()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayer1_MediaError(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_MediaErrorEvent) Handles AxWindowsMediaPlayer1.MediaError
        MsgBox("Can't play Music")
    End Sub
End Class