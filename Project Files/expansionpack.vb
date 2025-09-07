Public Class expansionpack

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("No Link in alpha 1 or 2", MsgBoxStyle.Information)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "Ix&bEhjR" Then
            Form_1pad.Text = "Form_1pad "
        End If
    End Sub
End Class