Module Module2
    Public Sub se()
        If AboutBox22.PictureBox2.Visible = True Then
            form1Pad.Picture1.Visible = False
            form1Pad.Picture2.Visible = True
        Else
            If AboutBox22.PictureBox3.Visible = True Then
                form1Pad.Picture1.Visible = False
                form1Pad.Picture3.Visible = True
            Else
                If AboutBox22.PictureBox4.Visible = True Then
                    form1Pad.Picture1.Visible = False
                    form1Pad.Picture4.Visible = True
                Else
                    If AboutBox22.PictureBox5.Visible = True Then
                        form1Pad.Picture1.Visible = False
                        form1Pad.Picture5.Visible = True
                    Else
                        If AboutBox22.PictureBox6.Visible = True Then
                            form1Pad.Picture1.Visible = False
                            form1Pad.Picture6.Visible = True

                            form1Pad.Picture6.Image = AboutBox22.PictureBox6.Image
                        Else

                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Module
