Public NotInheritable Class AboutBox11

    Private Sub AboutBox11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.Close()
        Form1.Show()
        Form1.Button10.Visible = True
        If Form1.Button2.Visible = True Then
            Form1.Button2.Visible = False
        End If
        Me.Close()
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class
