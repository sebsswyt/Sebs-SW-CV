Public NotInheritable Class AboutBox1

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        If Form20.ProgressBar1.Value = 100 Then
            Form8.Show()
        End If
        Me.Close()
        If Form28.PictureBox1.Visible = True Then
            AboutBox20.Show()
        End If
    End Sub

    Private Sub TableLayoutPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TableLayoutPanel.Paint

    End Sub

    Private Sub LabelVersion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelVersion.Click

    End Sub
End Class
