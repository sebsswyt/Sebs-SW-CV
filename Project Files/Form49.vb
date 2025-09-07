Public Class Form49

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        Label1.Text = ProgressBar1.Value
        If ProgressBar1.Value = 10 Then
            Timer1.Stop()
            If form1Pad.Picture1.Visible = True Then
                PictureBox1.Image = form1Pad.Picture1.Image
            Else
                If form1Pad.Picture2.Visible = True Then
                    PictureBox2.Image = form1Pad.Picture2.Image
                Else
                    If form1Pad.Picture3.Visible = True Then
                        PictureBox3.Image = form1Pad.Picture3.Image
                    Else
                        If form1Pad.Picture4.Visible = True Then
                            PictureBox4.Image = form1Pad.Picture4.Image
                        Else
                            If form1Pad.Picture5.Visible = True Then
                                PictureBox5.Image = form1Pad.Picture5.Image
                            Else
                                PictureBox6.Image = form1Pad.Picture6.Image
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Form49_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load 
        PictureBox1.Image = form1Pad.Picture1.Image
        PictureBox2.Image = form1Pad.Picture2.Image
        PictureBox3.Image = form1Pad.Picture3.Image
        PictureBox4.Image = form1Pad.Picture4.Image
        PictureBox5.Image = form1Pad.Picture5.Image
        PictureBox6.Image = form1Pad.Picture6.Image
        PictureBox7.Image = form1Pad.Picture7.Image
        If form1Pad.Picture1.Visible = True Then
            Label2.Text = "B1"
        Else
            If form1Pad.Picture2.Visible = True Then
                Label2.Text = "B2"
            Else
                If form1Pad.Picture3.Visible = True Then
                    Label2.Text = "B3"
                Else
                    If form1Pad.Picture4.Visible = True Then
                        Label2.Text = "B4"
                    Else
                        If form1Pad.Picture5.Visible = True Then
                            Label2.Text = "B5"
                        Else
                            If form1Pad.Picture6.Visible = True Then
                                Label2.Text = "B6"
                                PictureBox6.Image = form1Pad.Picture6.Image
                            Else
                                If form1Pad.Picture7.Visible = True Then
                                    Label2.Text = "B7"
                                    PictureBox7.Image = form1Pad.Picture7.Image
                                Else
                                    Label2.Text = "B1"
                                End If
                            End If

                        End If
                    End If
                End If
            End If
        End If

        If form1Pad.Picture1.Visible = True Then
            PictureBox1.Image = form1Pad.Picture1.Image
        Else
            If form1Pad.Picture2.Visible = True Then
                PictureBox2.Image = form1Pad.Picture2.Image
            Else
                If form1Pad.Picture3.Visible = True Then
                    PictureBox3.Image = form1Pad.Picture3.Image
                Else
                    If form1Pad.Picture4.Visible = True Then
                        PictureBox4.Image = form1Pad.Picture4.Image
                    Else
                        If form1Pad.Picture5.Visible = True Then
                            PictureBox5.Image = form1Pad.Picture5.Image
                        Else
                            PictureBox6.Image = form1Pad.Picture6.Image
                        End If
                    End If
                End If
            End If
        End If
        
        'Form33.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Loginz.Show()
    End Sub
End Class