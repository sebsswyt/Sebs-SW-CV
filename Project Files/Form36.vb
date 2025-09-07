Public Class Form36

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form30.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click



    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form19.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Form21_Old.Button1.Visible = True Then
            Form21_Old.Close()
            Form21_Old.Show()
            Form21_Old.Panel2.Visible = True
        Else
            Form21_Old.Show()
            Form21_Old.Panel2.Visible = True
        End If
        
    End Sub

    Private Sub Form36_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class