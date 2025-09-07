Public NotInheritable Class AboutBox16

    Private Sub AboutBox16_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form25.Close()
        Form25.Show()
        Me.Close()
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

End Class
