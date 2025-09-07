Public Class Form27

    Private Sub Form27_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Form21_Old.Visible = True Then
            Me.Label1.Text = Form21_Old.TextBox2.Text
        End If
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Errorbox1.Show()
        Errorbox1.al.Text = "for user Settings"
        Errorbox1.Text = ":) :("

    End Sub
End Class