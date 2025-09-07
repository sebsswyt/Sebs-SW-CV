Module easycode

    Public currentForm As Form = Nothing
    Public Sub openChildForm(ByVal childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        'Form21.CVCforms.Controls.Add(childForm)
        'Form21.CVCforms.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        'childForm()

    End Sub

    Public Sub Start_up_load()

        If Form49.Label2.Text = "B2" Then
            'Picture1.Visible = False
            'Picture2.Visible = True
        Else
            If Form49.Label2.Text = "B3" Then
                'Picture1.Visible = False
                'Picture3.Visible = True
            Else
                If Form49.Label2.Text = "B4" Then
                    'Picture1.Visible = False
                    'Picture4.Visible = True
                Else
                    If Form49.Label2.Text = "B5" Then
                        'Picture1.Visible = False
                        'Picture5.Visible = True
                    Else
                        If Form49.Label2.Text = "B6" Then
                            'Picture1.Visible = False
                            'Picture6.Visible = True
                            'Picture6.Image = Form49.PictureBox6.Image
                        Else
                            If Form49.Label2.Text = "B7" Then
                                'Picture1.Visible = False
                                'Picture7.Visible = True

                            End If
                        End If
                    End If
                End If
            End If
        End If
        form1Pad.Picture1.Image = Form49.PictureBox1.Image
        'Picture2.Image = Form49.PictureBox2.Image
        'Picture3.Image = Form49.PictureBox3.Image
        'Picture4.Image = Form49.PictureBox4.Image
        'Picture5.Image = Form49.PictureBox5.Image
        'Picture6.Image = Form49.PictureBox6.Image
        form1Pad.Picture1.Image = Form49.PictureBox1.Image
        'Picture2.Image = Form49.PictureBox2.Image
        'Picture3.Image = Form49.PictureBox3.Image
        'Picture4.Image = Form49.PictureBox4.Image
        'Picture5.Image = Form49.PictureBox5.Image
        'Picture6.Image = Form49.PictureBox6.Image
        AboutBox22.Close()
        'If Form33.Label1.Visible = True Then
        'Else
        'Form49.Close()
        'End If
    End Sub
End Module
