Public NotInheritable Class AboutBox12

    Private Sub AboutBox12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.Close()
        Form1.Show()
        Form1.Button2.Visible = True
        If Form1.Button10.Visible = True Then
            Form1.Button10.Visible = False
        End If
        Me.Close()
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

End Class
