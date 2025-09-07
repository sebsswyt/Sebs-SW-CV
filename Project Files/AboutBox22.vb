Public NotInheritable Class AboutBox22

    Private Sub AboutBox22_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Close()
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'If MsgBox("custom background doesn't get Save", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        If form1Pad.Picture1.Visible = True Then
            PictureBox1.Visible = True
        Else
            If form1Pad.Picture2.Visible = True Then
                PictureBox2.Visible = True
                PictureBox1.Visible = False
            Else
                If form1Pad.Picture3.Visible = True Then
                    PictureBox3.Visible = True
                    PictureBox1.Visible = False
                Else
                    If form1Pad.Picture4.Visible = True Then
                        PictureBox4.Visible = True
                        PictureBox1.Visible = False
                    Else
                        If form1Pad.Picture5.Visible = True Then
                            PictureBox5.Visible = True
                            PictureBox1.Visible = False
                        Else
                            If form1Pad.Picture6.Visible = True Then
                                PictureBox6.Visible = True
                                PictureBox1.Visible = False
                                PictureBox6.Image = form1Pad.Picture6.Image
                            Else

                            End If

                        End If
                    End If
                End If
            End If
        End If
        If PictureBox1.Visible = True Then
        Else
            If PictureBox2.Visible = True Then
            Else
                If PictureBox3.Visible = True Then
                Else
                    If PictureBox4.Visible = True Then
                    Else
                        If PictureBox5.Visible = True Then
                        Else
                            If PictureBox6.Visible = True Then
                            Else
                                form1Pad.Show()
                                Form33.Close()
                                Close()
                            End If
                        End If
                    End If
                End If
            End If
        End If
        'End If
    End Sub
End Class
