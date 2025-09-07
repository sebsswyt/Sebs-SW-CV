Public Class Form16

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
       

    End Sub

    Private Sub FormatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormatToolStripMenuItem.Click

    End Sub

    Private Sub AsSaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsSaveToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub TheWebToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheWebToolStripMenuItem.Click
        Form19.Show()
    End Sub

    Private Sub FileExplorerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileExplorerToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutUsToolStripMenuItem.Click
        AboutBox7.Show()
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)
    End Sub

    Private Sub TheWebToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheWebToolStripMenuItem1.Click
        Form19.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub BSODTestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSODTestToolStripMenuItem.Click
        Form1.Close()
        Form28.Show()
        AboutBox17.Show()
        Form17.Show()
        Me.Close()
    End Sub
End Class