Namespace CV
	' Token: 0x0200004F RID: 79
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form33
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000D33 RID: 3379 RVA: 0x03DCF954 File Offset: 0x03DCDD54
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

		' Token: 0x06000D34 RID: 3380 RVA: 0x03DCF9A4 File Offset: 0x03DCDDA4
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.Form33))
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.ProgressBar2 = New Global.System.Windows.Forms.ProgressBar()
			Me.Timer2 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.rest1 = New Global.System.Windows.Forms.Label()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.Timer3 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.MenuStrip1 = New Global.System.Windows.Forms.MenuStrip()
			Me.ToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripMenuItem3 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripMenuItem4 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.V2 = New Global.System.Windows.Forms.Label()
			Me.ProgressBar3 = New Global.System.Windows.Forms.ProgressBar()
			Me.Timer4 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.PictureBox2 = New Global.System.Windows.Forms.PictureBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.PictureBox3 = New Global.System.Windows.Forms.PictureBox()
			Me.PictureBox4 = New Global.System.Windows.Forms.PictureBox()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.MenuStrip1.SuspendLayout()
			CType(Me.PictureBox2, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PictureBox3, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PictureBox4, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel1.SuspendLayout()
			Me.SuspendLayout()
			Me.ProgressBar1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim progressBar As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(12, 603)
			progressBar.Location = point
			Me.ProgressBar1.Name = "ProgressBar1"
			Dim progressBar2 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(1095, 23)
			progressBar2.Size = size
			Me.ProgressBar1.TabIndex = 1
			Me.ProgressBar1.Visible = False
			Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 18F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(434, 240)
			label.Location = point
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(128, 29)
			label2.Size = size
			Me.Label1.TabIndex = 3
			Me.Label1.Text = "Restarting."
			Me.Label2.AutoSize = True
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
			point = New Global.System.Drawing.Point(363, 443)
			label3.Location = point
			Me.Label2.Name = "Label2"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(39, 13)
			label4.Size = size
			Me.Label2.TabIndex = 4
			Me.Label2.Text = "Label2"
			Me.Label2.Visible = False
			Me.ProgressBar2.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim progressBar3 As Global.System.Windows.Forms.Control = Me.ProgressBar2
			point = New Global.System.Drawing.Point(12, 572)
			progressBar3.Location = point
			Me.ProgressBar2.Name = "ProgressBar2"
			Dim progressBar4 As Global.System.Windows.Forms.Control = Me.ProgressBar2
			size = New Global.System.Drawing.Size(1095, 23)
			progressBar4.Size = size
			Me.ProgressBar2.TabIndex = 5
			Me.Timer2.Interval = 40
			Me.rest1.AutoSize = True
			Dim rest As Global.System.Windows.Forms.Control = Me.rest1
			point = New Global.System.Drawing.Point(621, 208)
			rest.Location = point
			Me.rest1.Name = "rest1"
			Dim rest2 As Global.System.Windows.Forms.Control = Me.rest1
			size = New Global.System.Drawing.Size(39, 13)
			rest2.Size = size
			Me.rest1.TabIndex = 6
			Me.rest1.Text = "Label3"
			Me.rest1.Visible = False
			Me.PictureBox1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.PictureBox1.Image = CType(componentResourceManager.GetObject("PictureBox1.Image"), Global.System.Drawing.Image)
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox1
			point = New Global.System.Drawing.Point(400, 39)
			pictureBox.Location = point
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox1
			size = New Global.System.Drawing.Size(208, 198)
			pictureBox2.Size = size
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 7
			Me.PictureBox1.TabStop = False
			Me.MenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.ToolStripMenuItem1 })
			Dim menuStrip As Global.System.Windows.Forms.Control = Me.MenuStrip1
			point = New Global.System.Drawing.Point(0, 0)
			menuStrip.Location = point
			Me.MenuStrip1.Name = "MenuStrip1"
			Dim menuStrip2 As Global.System.Windows.Forms.Control = Me.MenuStrip1
			size = New Global.System.Drawing.Size(1119, 24)
			menuStrip2.Size = size
			Me.MenuStrip1.TabIndex = 8
			Me.MenuStrip1.Text = "MenuStrip1"
			Me.MenuStrip1.Visible = False
			Me.ToolStripMenuItem1.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.ToolStripMenuItem3, Me.ToolStripMenuItem4 })
			Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
			Dim toolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripMenuItem1
			size = New Global.System.Drawing.Size(126, 20)
			toolStripMenuItem.Size = size
			Me.ToolStripMenuItem1.Text = "ToolStripMenuItem1"
			Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
			Me.ToolStripMenuItem3.ShortcutKeys = CType(65657, Global.System.Windows.Forms.Keys)
			Me.ToolStripMenuItem3.ShowShortcutKeys = False
			Dim toolStripMenuItem2 As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripMenuItem3
			size = New Global.System.Drawing.Size(78, 22)
			toolStripMenuItem2.Size = size
			Me.ToolStripMenuItem3.Text = "?"
			Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
			Me.ToolStripMenuItem4.ShortcutKeys = Global.System.Windows.Forms.Keys.LButton Or Global.System.Windows.Forms.Keys.RButton Or Global.System.Windows.Forms.Keys.Space Or Global.System.Windows.Forms.Keys.Control
			Me.ToolStripMenuItem4.ShowShortcutKeys = False
			Dim toolStripMenuItem3 As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripMenuItem4
			size = New Global.System.Drawing.Size(78, 22)
			toolStripMenuItem3.Size = size
			Me.ToolStripMenuItem4.Text = "?2"
			Me.V2.AutoSize = True
			Dim v As Global.System.Windows.Forms.Control = Me.V2
			point = New Global.System.Drawing.Point(727, 373)
			v.Location = point
			Me.V2.Name = "V2"
			Dim v2 As Global.System.Windows.Forms.Control = Me.V2
			size = New Global.System.Drawing.Size(19, 13)
			v2.Size = size
			Me.V2.TabIndex = 9
			Me.V2.Text = "----"
			Me.V2.Visible = False
			Me.ProgressBar3.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim progressBar5 As Global.System.Windows.Forms.Control = Me.ProgressBar3
			point = New Global.System.Drawing.Point(12, 543)
			progressBar5.Location = point
			Me.ProgressBar3.Name = "ProgressBar3"
			Dim progressBar6 As Global.System.Windows.Forms.Control = Me.ProgressBar3
			size = New Global.System.Drawing.Size(1095, 23)
			progressBar6.Size = size
			Me.ProgressBar3.TabIndex = 10
			Me.ProgressBar3.Visible = False
			Me.PictureBox2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.PictureBox2.Image = CType(componentResourceManager.GetObject("PictureBox2.Image"), Global.System.Drawing.Image)
			Dim pictureBox3 As Global.System.Windows.Forms.Control = Me.PictureBox2
			point = New Global.System.Drawing.Point(353, 217)
			pictureBox3.Location = point
			Me.PictureBox2.Name = "PictureBox2"
			Dim pictureBox4 As Global.System.Windows.Forms.Control = Me.PictureBox2
			size = New Global.System.Drawing.Size(86, 76)
			pictureBox4.Size = size
			Me.PictureBox2.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox2.TabIndex = 11
			Me.PictureBox2.TabStop = False
			Me.PictureBox2.Visible = False
			Me.Label3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 18F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label3
			point = New Global.System.Drawing.Point(625, 382)
			label5.Location = point
			Me.Label3.Name = "Label3"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(26, 29)
			label6.Size = size
			Me.Label3.TabIndex = 12
			Me.Label3.Text = "0"
			Me.Label3.Visible = False
			Me.Label4.AutoSize = True
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label4
			point = New Global.System.Drawing.Point(540, 313)
			label7.Location = point
			Me.Label4.Name = "Label4"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label4
			size = New Global.System.Drawing.Size(39, 13)
			label8.Size = size
			Me.Label4.TabIndex = 13
			Me.Label4.Text = "Label4"
			Me.Label4.Visible = False
			Me.Label5.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label5.AutoSize = True
			Me.Label5.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 18F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label9 As Global.System.Windows.Forms.Control = Me.Label5
			point = New Global.System.Drawing.Point(625, 326)
			label9.Location = point
			Me.Label5.Name = "Label5"
			Dim label10 As Global.System.Windows.Forms.Control = Me.Label5
			size = New Global.System.Drawing.Size(28, 29)
			label10.Size = size
			Me.Label5.TabIndex = 14
			Me.Label5.Text = "F"
			Me.PictureBox3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.PictureBox3.Image = CType(componentResourceManager.GetObject("PictureBox3.Image"), Global.System.Drawing.Image)
			Dim pictureBox5 As Global.System.Windows.Forms.Control = Me.PictureBox3
			point = New Global.System.Drawing.Point(-2, 0)
			pictureBox5.Location = point
			Me.PictureBox3.Name = "PictureBox3"
			Dim pictureBox6 As Global.System.Windows.Forms.Control = Me.PictureBox3
			size = New Global.System.Drawing.Size(1122, 639)
			pictureBox6.Size = size
			Me.PictureBox3.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox3.TabIndex = 15
			Me.PictureBox3.TabStop = False
			Me.PictureBox4.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.PictureBox4.Image = CType(componentResourceManager.GetObject("PictureBox4.Image"), Global.System.Drawing.Image)
			Dim pictureBox7 As Global.System.Windows.Forms.Control = Me.PictureBox4
			point = New Global.System.Drawing.Point(99, 5)
			pictureBox7.Location = point
			Me.PictureBox4.Name = "PictureBox4"
			Dim pictureBox8 As Global.System.Windows.Forms.Control = Me.PictureBox4
			size = New Global.System.Drawing.Size(112, 111)
			pictureBox8.Size = size
			Me.PictureBox4.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox4.TabIndex = 16
			Me.PictureBox4.TabStop = False
			Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Panel1.BackColor = Global.System.Drawing.Color.DodgerBlue
			Me.Panel1.Controls.Add(Me.Label6)
			Me.Panel1.Controls.Add(Me.PictureBox4)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(379, 137)
			panel.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(300, 281)
			panel2.Size = size
			Me.Panel1.TabIndex = 17
			Me.Label6.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label6.AutoSize = True
			Me.Label6.Font = New Global.System.Drawing.Font("Trebuchet MS", 21.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label11 As Global.System.Windows.Forms.Control = Me.Label6
			point = New Global.System.Drawing.Point(52, 119)
			label11.Location = point
			Me.Label6.Name = "Label6"
			Dim label12 As Global.System.Windows.Forms.Control = Me.Label6
			size = New Global.System.Drawing.Size(193, 37)
			label12.Size = size
			Me.Label6.TabIndex = 17
			Me.Label6.Text = "Shuting down"
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.CornflowerBlue
			size = New Global.System.Drawing.Size(1119, 638)
			Me.ClientSize = size
			Me.Controls.Add(Me.Panel1)
			Me.Controls.Add(Me.PictureBox3)
			Me.Controls.Add(Me.Label5)
			Me.Controls.Add(Me.Label4)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.PictureBox2)
			Me.Controls.Add(Me.ProgressBar3)
			Me.Controls.Add(Me.V2)
			Me.Controls.Add(Me.PictureBox1)
			Me.Controls.Add(Me.rest1)
			Me.Controls.Add(Me.ProgressBar2)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.ProgressBar1)
			Me.Controls.Add(Me.MenuStrip1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			Me.MainMenuStrip = Me.MenuStrip1
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Form33"
			Me.Text = "Form33"
			Me.WindowState = Global.System.Windows.Forms.FormWindowState.Maximized
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.MenuStrip1.ResumeLayout(False)
			Me.MenuStrip1.PerformLayout()
			CType(Me.PictureBox2, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PictureBox3, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PictureBox4, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x040004E1 RID: 1249
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
