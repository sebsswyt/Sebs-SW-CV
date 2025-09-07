Public Class Form41
    Dim mouse_move As System.Drawing.Point
    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        System.Diagnostics.Process.Start(OpenFileDialog1.FileName)
        If Label1.Text = "Label1" Then
            Label1.Text = "1"
            Button2.Visible = True
            Button2.Text = OpenFileDialog1.FileName
        Else
            If Label2.Text = "Label2" Then
                Label2.Text = "2"
                Button3.Visible = True
                Button3.Text = OpenFileDialog1.FileName
            Else
                If Label3.Text = "Label3" Then
                    Label3.Text = "3"
                    Button4.Visible = True
                    Button4.Text = OpenFileDialog1.FileName
                Else
                    If Label4.Text = "Label4" Then
                        Label4.Text = "4"
                        Button5.Visible = True
                        Button5.Text = OpenFileDialog1.FileName
                    Else
                        If Label5.Text = "Label5" Then
                            Label5.Text = "5"
                            Button7.Visible = True
                            Button7.Text = OpenFileDialog1.FileName
                        Else
                            If Label6.Text = "Label6" Then
                                Label6.Text = "6"
                                Button8.Visible = True
                                Button8.Text = OpenFileDialog1.FileName
                            Else
                                If Label7.Text = "Label7" Then
                                    Label7.Text = "7"
                                    Button9.Visible = True
                                    Button9.Text = OpenFileDialog1.FileName
                                Else
                                    If Label8.Text = "Label8" Then
                                        Label8.Text = "8"
                                        Button10.Visible = True
                                        Button10.Text = OpenFileDialog1.FileName
                                    Else

                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Form41_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "Button2" Then
        Else
            System.Diagnostics.Process.Start(Button2.Text)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Text = "Button3" Then
        Else
            System.Diagnostics.Process.Start(Button3.Text)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button4.Text = "Button4" Then
        Else
            System.Diagnostics.Process.Start(Button4.Text)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Button5.Text = "Button5" Then
        Else
            System.Diagnostics.Process.Start(Button5.Text)
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Close()
    End Sub

    Private Sub Button6_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.MouseEnter
        Button6.BackColor = Color.AliceBlue
    End Sub

    Private Sub Button6_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.MouseLeave
        Button6.BackColor = Color.Transparent
    End Sub

    Private Sub Button11_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.MouseLeave
        Button11.BackColor = Color.Transparent
    End Sub

    Private Sub Button11_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.MouseEnter
        Button11.BackColor = Color.AliceBlue
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        mouse_move = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Dim mposition As Point
            mposition = Control.MousePosition
            mposition.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mposition
        End If
    End Sub

    Private Sub Form41_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Form55.Show()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Form_1pad.Panel1.Visible = True Then
            Panel2.Visible = True
        End If
        Panel2.BackColor = Form_1pad.Panel1.BackColor
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseDown
        mouse_move = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Panel2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Dim mposition As Point
            mposition = Control.MousePosition
            mposition.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mposition
        End If
    End Sub
End Class