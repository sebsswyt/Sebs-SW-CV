Namespace CV
	' Token: 0x02000041 RID: 65
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form20
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060009C6 RID: 2502 RVA: 0x03DB8BE8 File Offset: 0x03DB6FE8
		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				Dim flag As Boolean = disposing AndAlso Me.components IsNot Nothing
				If flag Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x060009C7 RID: 2503 RVA: 0x03DB8C38 File Offset: 0x03DB7038
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.Form20))
			Me.Button3 = New Global.System.Windows.Forms.Button()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.Button6 = New Global.System.Windows.Forms.Button()
			Me.Button5 = New Global.System.Windows.Forms.Button()
			Me.Button4 = New Global.System.Windows.Forms.Button()
			Me.Button7 = New Global.System.Windows.Forms.Button()
			Me.Button8 = New Global.System.Windows.Forms.Button()
			Me.Button9 = New Global.System.Windows.Forms.Button()
			Me.Timer2 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Panel2 = New Global.System.Windows.Forms.Panel()
			Me.WebBrowser1 = New Global.System.Windows.Forms.WebBrowser()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel1.SuspendLayout()
			Me.Panel2.SuspendLayout()
			Me.SuspendLayout()
			Me.Button3.Font = New Global.System.Drawing.Font("Trebuchet MS", 12F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button As Global.System.Windows.Forms.Control = Me.Button3
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(262, 88)
			button.Location = point
			Me.Button3.Name = "Button3"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button3
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(153, 95)
			button2.Size = size
			Me.Button3.TabIndex = 10
			Me.Button3.Text = "Stop Update"
			Me.Button3.UseVisualStyleBackColor = True
			Me.Button3.Visible = False
			Me.Button2.BackColor = Global.System.Drawing.SystemColors.ControlLight
			Me.Button2.Enabled = False
			Me.Button2.Font = New Global.System.Drawing.Font("Trebuchet MS", 15.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button2
			point = New Global.System.Drawing.Point(547, 189)
			button3.Location = point
			Me.Button2.Name = "Button2"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button2
			size = New Global.System.Drawing.Size(168, 63)
			button4.Size = size
			Me.Button2.TabIndex = 9
			Me.Button2.Text = "Update is Done"
			Me.Button2.UseVisualStyleBackColor = False
			Dim progressBar As Global.System.Windows.Forms.Control = Me.ProgressBar1
			point = New Global.System.Drawing.Point(432, 109)
			progressBar.Location = point
			Me.ProgressBar1.Name = "ProgressBar1"
			Me.ProgressBar1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim progressBar2 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			size = New Global.System.Drawing.Size(479, 50)
			progressBar2.Size = size
			Me.ProgressBar1.TabIndex = 8
			Me.PictureBox1.BackColor = Global.System.Drawing.SystemColors.ActiveBorder
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox1
			point = New Global.System.Drawing.Point(421, 88)
			pictureBox.Location = point
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox1
			size = New Global.System.Drawing.Size(499, 95)
			pictureBox2.Size = size
			Me.PictureBox1.TabIndex = 7
			Me.PictureBox1.TabStop = False
			Me.Button1.Font = New Global.System.Drawing.Font("Trebuchet MS", 12F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button5 As Global.System.Windows.Forms.Control = Me.Button1
			point = New Global.System.Drawing.Point(262, 88)
			button5.Location = point
			Me.Button1.Name = "Button1"
			Dim button6 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(153, 95)
			button6.Size = size
			Me.Button1.TabIndex = 6
			Me.Button1.Text = " Start Update"
			Me.Button1.UseVisualStyleBackColor = True
			Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
			Me.Panel1.BackColor = Global.System.Drawing.Color.LightGray
			Me.Panel1.Controls.Add(Me.Button6)
			Me.Panel1.Controls.Add(Me.Button5)
			Me.Panel1.Controls.Add(Me.Button4)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(0, 67)
			panel.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(200, 627)
			panel2.Size = size
			Me.Panel1.TabIndex = 11
			Me.Button6.BackColor = Global.System.Drawing.Color.LightGray
			Me.Button6.Cursor = Global.System.Windows.Forms.Cursors.Arrow
			Me.Button6.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button6.Font = New Global.System.Drawing.Font("Trebuchet MS", 21.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button7 As Global.System.Windows.Forms.Control = Me.Button6
			point = New Global.System.Drawing.Point(3, 199)
			button7.Location = point
			Me.Button6.Name = "Button6"
			Dim button8 As Global.System.Windows.Forms.Control = Me.Button6
			size = New Global.System.Drawing.Size(189, 89)
			button8.Size = size
			Me.Button6.TabIndex = 2
			Me.Button6.Text = "Username Settings"
			Me.Button6.UseVisualStyleBackColor = False
			Me.Button5.Cursor = Global.System.Windows.Forms.Cursors.Arrow
			Me.Button5.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button5.Font = New Global.System.Drawing.Font("Trebuchet MS", 21.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button9 As Global.System.Windows.Forms.Control = Me.Button5
			point = New Global.System.Drawing.Point(3, 104)
			button9.Location = point
			Me.Button5.Name = "Button5"
			Dim button10 As Global.System.Windows.Forms.Control = Me.Button5
			size = New Global.System.Drawing.Size(190, 89)
			button10.Size = size
			Me.Button5.TabIndex = 1
			Me.Button5.Text = "Info"
			Me.Button5.UseVisualStyleBackColor = True
			Me.Button4.Cursor = Global.System.Windows.Forms.Cursors.Arrow
			Me.Button4.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button4.Font = New Global.System.Drawing.Font("Trebuchet MS", 21.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button11 As Global.System.Windows.Forms.Control = Me.Button4
			point = New Global.System.Drawing.Point(3, 9)
			button11.Location = point
			Me.Button4.Name = "Button4"
			Dim button12 As Global.System.Windows.Forms.Control = Me.Button4
			size = New Global.System.Drawing.Size(190, 89)
			button12.Size = size
			Me.Button4.TabIndex = 0
			Me.Button4.Text = "Theme"
			Me.Button4.UseVisualStyleBackColor = True
			Me.Button7.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button7.BackgroundImage = CType(componentResourceManager.GetObject("Button7.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button7.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button7.Cursor = Global.System.Windows.Forms.Cursors.Arrow
			Me.Button7.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button13 As Global.System.Windows.Forms.Control = Me.Button7
			point = New Global.System.Drawing.Point(1109, 3)
			button13.Location = point
			Me.Button7.Name = "Button7"
			Dim button14 As Global.System.Windows.Forms.Control = Me.Button7
			size = New Global.System.Drawing.Size(65, 64)
			button14.Size = size
			Me.Button7.TabIndex = 12
			Me.Button7.UseVisualStyleBackColor = True
			Me.Button8.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button8.BackgroundImage = CType(componentResourceManager.GetObject("Button8.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button8.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button8.Cursor = Global.System.Windows.Forms.Cursors.Arrow
			Me.Button8.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button15 As Global.System.Windows.Forms.Control = Me.Button8
			point = New Global.System.Drawing.Point(1041, 3)
			button15.Location = point
			Me.Button8.Name = "Button8"
			Dim button16 As Global.System.Windows.Forms.Control = Me.Button8
			size = New Global.System.Drawing.Size(62, 64)
			button16.Size = size
			Me.Button8.TabIndex = 13
			Me.Button8.UseVisualStyleBackColor = True
			Me.Button9.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button9.BackgroundImage = CType(componentResourceManager.GetObject("Button9.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button9.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button9.Cursor = Global.System.Windows.Forms.Cursors.Arrow
			Me.Button9.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button17 As Global.System.Windows.Forms.Control = Me.Button9
			point = New Global.System.Drawing.Point(972, 3)
			button17.Location = point
			Me.Button9.Name = "Button9"
			Dim button18 As Global.System.Windows.Forms.Control = Me.Button9
			size = New Global.System.Drawing.Size(63, 64)
			button18.Size = size
			Me.Button9.TabIndex = 14
			Me.Button9.UseVisualStyleBackColor = True
			Me.Timer2.Enabled = True
			Me.Panel2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Panel2.BackColor = Global.System.Drawing.Color.Silver
			Me.Panel2.Controls.Add(Me.Button9)
			Me.Panel2.Controls.Add(Me.Button8)
			Me.Panel2.Controls.Add(Me.Button7)
			Dim panel3 As Global.System.Windows.Forms.Control = Me.Panel2
			point = New Global.System.Drawing.Point(0, -2)
			panel3.Location = point
			Me.Panel2.Name = "Panel2"
			Dim panel4 As Global.System.Windows.Forms.Control = Me.Panel2
			size = New Global.System.Drawing.Size(1184, 72)
			panel4.Size = size
			Me.Panel2.TabIndex = 15
			Dim webBrowser As Global.System.Windows.Forms.Control = Me.WebBrowser1
			point = New Global.System.Drawing.Point(274, 255)
			webBrowser.Location = point
			Dim webBrowser2 As Global.System.Windows.Forms.Control = Me.WebBrowser1
			size = New Global.System.Drawing.Size(20, 20)
			webBrowser2.MinimumSize = size
			Me.WebBrowser1.Name = "WebBrowser1"
			Dim webBrowser3 As Global.System.Windows.Forms.Control = Me.WebBrowser1
			size = New Global.System.Drawing.Size(824, 414)
			webBrowser3.Size = size
			Me.WebBrowser1.TabIndex = 16
			Me.WebBrowser1.Url = New Global.System.Uri("https://sebs-sw-b.netlify.app/sebs sw cv.html", Global.System.UriKind.Absolute)
			Me.WebBrowser1.Visible = False
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.WhiteSmoke
			size = New Global.System.Drawing.Size(1183, 694)
			Me.ClientSize = size
			Me.Controls.Add(Me.WebBrowser1)
			Me.Controls.Add(Me.Panel2)
			Me.Controls.Add(Me.Panel1)
			Me.Controls.Add(Me.Button3)
			Me.Controls.Add(Me.Button2)
			Me.Controls.Add(Me.ProgressBar1)
			Me.Controls.Add(Me.PictureBox1)
			Me.Controls.Add(Me.Button1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.Name = "Form20"
			Me.Text = "Sebs SW Update"
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel1.ResumeLayout(False)
			Me.Panel2.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x04000397 RID: 919
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
