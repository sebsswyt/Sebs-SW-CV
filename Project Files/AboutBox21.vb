Public NotInheritable Class AboutBox21

    Private Sub AboutBox21_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Form1.Close()
        form1Pad.Close()
        Form33.Show()
        Form33.Timer1.Start()
        If form1Pad.Picture6.Visible = True Then
            Button1.Text = "1"
        End If
        If form1Pad.Picture2.Visible = True Then
            Button1.Text = "2"
        Else
            If form1Pad.Picture3.Visible = True Then
                Button1.Text = "3"
            Else
                If form1Pad.Picture4.Visible = True Then
                    Button1.Text = "4"
                Else
                    If form1Pad.Picture5.Visible = True Then
                        Button1.Text = "5"
                    Else
                        If form1Pad.Picture6.Visible = True Then
                            PictureBox1.Image = form1Pad.Picture6.Image
                            Button1.Text = "6"
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If Form33.ProgressBar1.Value = 97 Then
            form1Pad.Show()
            If Button1.Text = "1" Then
                Form33.Close()
                Timer2.Start()
            End If
            If Button1.Text = "2" Then
                form1Pad.Picture2.Visible = True
                Form33.Close()
                Timer2.Start()
            Else
                If Button1.Text = "3" Then
                    form1Pad.Picture3.Visible = True
                    Form33.Close()
                    Timer2.Start()
                Else
                    If Button1.Text = "4" Then
                        Form33.Close()
                        Timer2.Start()
                        form1Pad.Picture4.Visible = True
                    Else
                        If Button1.Text = "5" Then
                            Form33.Close()
                            Timer2.Start()
                            form1Pad.Picture5.Visible = True
                        Else
                            If Button1.Text = "6" Then
                                form1Pad.Picture6.Image = PictureBox1.Image
                                'form1Pad.Picture6.Image
                                form1Pad.Picture6.Visible = True
                                Form33.Close()
                                Timer2.Start()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Form1.Button1.Visible = True Then
            Form33.Close()
            Form1.Close()
            Close()
        End If
    End Sub
End Class
