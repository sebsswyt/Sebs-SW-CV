Public Class Form61

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        Replace(Label1.Text, "C:/Sebs-SW-CV/-install h.p from github.com -app text", " ")
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            If Label1.Text = "C:/Sebs-SW-CV/-install h.p from github.com -app text(hack SOE)" Then
                'Dim url4 As String = "https://youaregod666.github.io/se/"
                'Process.Start(url4)
                'Hack_seb_os_Explorer.Show()
            End If
            If Label1.Text = "C:/Sebs-SW-CV/-install newapp(???)" Then
                'Dim url4 As String = "https://sebs-sw-b.tk/internet++-program.html"
                'Process.Start(url4)
                'Process.Start("Internet++.exe")
                Dim newapp As New expansionpack
                newapp.Show()
            End If
        End If
    End Sub

    Private Sub Form61_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Replace(Label1.Text, "C:/Sebs-SW-CV/-install h.p from github.com -app text", " ")
        Replace(Label1.Text, "C:/Sebs-SW-CV/-install h.p from github.com -app text", " ")
        Replace(Label1.Text, "C/Sebs-SW-CV/-install h.p from github.com -app text", " ")
        Replace(Label1.Text, "C/Sebs-SW-CV/-install h.p from github.com -app text", " ")
    End Sub
End Class