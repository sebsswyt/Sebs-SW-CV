Public Class Form10

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form11.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Explorer2.Show()
    End Sub

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If form1Pad.Username1.Text = "CV" Then
            Label2.Text = "CV"
        Else
            Label2.Text = form1Pad.Username1.Text
        End If
    End Sub
End Class