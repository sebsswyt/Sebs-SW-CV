Public Class Form35

    Dim mouse_move As System.Drawing.Point

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        WebBrowser1.Navigate(TextBox1.Text)
        If TextBox1.Text = "CMD" Then
            Form17.Show()
            WebBrowser1.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        WebBrowser1.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        WebBrowser2.GoBack()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        WebBrowser2.GoForward()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        WebBrowser2.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        WebBrowser2.Navigate(TextBox2.Text)
        If TextBox2.Text = "CMD" Then
            Form17.Show()
            WebBrowser2.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
        End If

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        WebBrowser3.GoBack()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        WebBrowser3.GoForward()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        WebBrowser3.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        WebBrowser3.Navigate(TextBox3.Text)
        If TextBox3.Text = "CMD" Then
            Form17.Show()
            WebBrowser3.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
        End If
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        WebBrowser4.GoBack()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        WebBrowser4.GoForward()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        WebBrowser4.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        WebBrowser4.Navigate(TextBox4.Text)
        If TextBox4.Text = "CMD" Then
            Form17.Show()
            WebBrowser4.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
        End If
    End Sub

    Private Sub Form35_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Me.Close()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button19_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.MouseEnter
        Button19.BackColor = Color.AliceBlue
    End Sub

    Private Sub Button19_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.MouseLeave
        Button19.BackColor = Color.Transparent
    End Sub

    Private Sub Button18_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.MouseEnter
        Button18.BackColor = Color.AliceBlue
    End Sub

    Private Sub Button18_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.MouseLeave
        Button18.BackColor = Color.Transparent
    End Sub

    Private Sub Button17_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.MouseEnter
        Button17.BackColor = Color.AliceBlue
    End Sub

    Private Sub Button17_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.MouseLeave
        Button17.BackColor = Color.Transparent
    End Sub

    Private Sub Panel5_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel5.MouseDown
        mouse_move = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Panel5_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel5.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Dim mposition As Point
            mposition = Control.MousePosition
            mposition.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mposition
        End If
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        WebBrowser5.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        WebBrowser6.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            WebBrowser1.Navigate(TextBox1.Text)
        End If
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            WebBrowser2.Navigate(TextBox1.Text)
        End If
    End Sub

    Private Sub TabControl1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TabControl1.KeyDown
        
    End Sub

    Private Sub TextBox3_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            WebBrowser3.Navigate(TextBox1.Text)
        End If
    End Sub

    Private Sub TextBox4_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            WebBrowser4.Navigate(TextBox1.Text)
        End If
    End Sub

    Private Sub TextBox5_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox5.KeyDown
        If e.KeyCode = Keys.Enter Then
            WebBrowser5.Navigate(TextBox1.Text)
        End If
    End Sub

    Private Sub TextBox6_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox6.KeyDown
        If e.KeyCode = Keys.Enter Then
            WebBrowser6.Navigate(TextBox1.Text)
        End If
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        WebBrowser5.GoBack()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        WebBrowser5.GoForward()
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        WebBrowser5.Navigate(TextBox5.Text)
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        WebBrowser6.GoBack()
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        WebBrowser6.GoForward()
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        WebBrowser6.Navigate(TextBox6.Text)
    End Sub

    Private Sub WebBrowser1_Navigating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        TextBox1.Text = WebBrowser1.Url.ToString
    End Sub

    Private Sub WebBrowser2_Navigating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebBrowser2.Navigated
        TextBox2.Text = WebBrowser2.Url.ToString
    End Sub

    Private Sub WebBrowser3_Navigating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebBrowser3.Navigated
        TextBox3.Text = WebBrowser3.Url.ToString
    End Sub

    Private Sub WebBrowser4_Navigating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebBrowser4.Navigated
        TextBox4.Text = WebBrowser4.Url.ToString
    End Sub

    Private Sub WebBrowser5_Navigating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebBrowser5.Navigated
        TextBox5.Text = WebBrowser5.Url.ToString
    End Sub

    Private Sub WebBrowser6_Navigating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebBrowser6.Navigated
        TextBox6.Text = WebBrowser6.Url.ToString
    End Sub
End Class