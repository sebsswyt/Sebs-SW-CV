Public Class Form46

    Private Sub Form46_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If form1Pad.Picture2.Visible = True Then
            TextBox3.Text = "B-2"
        End If
        If form1Pad.Picture3.Visible = True Then
            TextBox3.Text = "B-3"
        End If
        If form1Pad.Picture4.Visible = True Then
            TextBox3.Text = "B-4"
        End If
        If form1Pad.Picture5.Visible = True Then
            TextBox3.Text = "B-5"
        End If
        If form1Pad.Picture6.Visible = True Then
            TextBox3.Text = "B-6"
        End If
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        If form1Pad.Picture1.Visible = True Then
            TextBox3.Text = "B-2"
        End If
        If form1Pad.Picture2.Visible = True Then
            TextBox3.Text = "B-2"
        End If
        If form1Pad.Picture3.Visible = True Then
            TextBox3.Text = "B-3"
        End If
        If form1Pad.Picture4.Visible = True Then
            TextBox3.Text = "B-4"
        End If
        If form1Pad.Picture5.Visible = True Then
            TextBox3.Text = "B-5"
        End If
        If form1Pad.Picture6.Visible = True Then
            TextBox3.Text = "B-6"
            MsgBox("Type the Path to the Picture")

        End If
        My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox3.Text, False)
    End Sub

    Private Sub TextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Click
        TextBox1.Text = ""
    End Sub

    Private Sub TextBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.MouseLeave
        
    End Sub

    Private Sub Form46_CausesValidationChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.CausesValidationChanged

    End Sub

    Private Sub Form46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        If TextBox1.Text = "13213" Then
            TextBox1.Text = "C:\User\(Your Username)\Pictures\"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SaveFileDialog2.ShowDialog()

    End Sub

    Private Sub SaveFileDialog2_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog2.FileOk
        My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)
    End Sub
End Class