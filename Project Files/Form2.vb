Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Explorer1.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form5.Show()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        If Form27.Label1.Visible = False Then
            Label1.Text = "CV"
        End If
        If Form27.Label1.Text = "???" Then
            Me.Label1.Text = "???"
        End If
        If Form21_Old.Label12.Visible = False Then
            Me.Label1.Text = Form27.Label1.Text
        End If

        If Form27.Label1.Visible = True Then
            Label1.Text = Form21_Old.TextBox2.Text
        
        End If


        If Form27.Label1.Text = "Display" Then
            Me.Label1.Text = "???"
        End If
        If Form27.Button1.Text = ":) :(" Then
            Label1.Text = Form27.Label1.Text
        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form21_Old.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
        Explorer1.Close()
        Explorer2.Close()
        AboutBox1.Show()
        AboutBox1.Close()
        AboutBox3.Show()
        AboutBox3.Close()
        AboutBox5.Show()
        AboutBox5.Close()
        AboutBox7.Show()
        AboutBox7.Close()
        AboutBox8.Show()
        AboutBox8.Close()
        AboutBox9.Show()
        AboutBox9.Close()
        AboutBox13.Close()
        AboutBox14.Close()
        AboutBox15.Close()
        Form9.Close()
        Form10.Close()
        Form11.Close()
        Form12.Close()
        Form13.Close()
        Form14.Close()
        Form15.Close()
        Form16.Close()
        Form17.Close()
        Form18.Close()
        Form19.Close()
        Form20.Close()
        Form21_Old.Close()
        Form22.Close()
        Form23.Close()
        Form24.Close()
        Form25.Close()
        Errorbox1.Close()
        Form33.Show()
        Form33.Timer1.Start()
        Me.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form25.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        AboutBox17.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        AboutBox1.Show()
    End Sub
End Class