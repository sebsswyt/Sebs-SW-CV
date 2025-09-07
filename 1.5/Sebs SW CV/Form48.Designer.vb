Namespace CV
	' Token: 0x0200005F RID: 95
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form48
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06001040 RID: 4160 RVA: 0x03DE55C8 File Offset: 0x03DE39C8
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

		' Token: 0x06001041 RID: 4161 RVA: 0x03DE5618 File Offset: 0x03DE3A18
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.Form48))
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.MenuStrip1 = New Global.System.Windows.Forms.MenuStrip()
			Me.SToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.RestartToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ShutdownToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.Button3 = New Global.System.Windows.Forms.Button()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel1.SuspendLayout()
			Me.MenuStrip1.SuspendLayout()
			Me.SuspendLayout()
			Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.None
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Trebuchet MS", 72F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(145, 36)
			label.Location = point
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(403, 119)
			label2.Size = size
			Me.Label1.TabIndex = 0
			Me.Label1.Text = "Start Up"
			Me.PictureBox1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.PictureBox1.Image = CType(componentResourceManager.GetObject("PictureBox1.Image"), Global.System.Drawing.Image)
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox1
			point = New Global.System.Drawing.Point(0, 0)
			pictureBox.Location = point
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox1
			size = New Global.System.Drawing.Size(1158, 644)
			pictureBox2.Size = size
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 1
			Me.PictureBox1.TabStop = False
			Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Panel1.BackColor = Global.System.Drawing.Color.DodgerBlue
			Me.Panel1.Controls.Add(Me.Button3)
			Me.Panel1.Controls.Add(Me.TextBox1)
			Me.Panel1.Controls.Add(Me.Button1)
			Me.Panel1.Controls.Add(Me.Label1)
			Me.Panel1.Controls.Add(Me.MenuStrip1)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(208, 60)
			panel.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(692, 494)
			panel2.Size = size
			Me.Panel1.TabIndex = 2
			Me.TextBox1.Anchor = Global.System.Windows.Forms.AnchorStyles.None
			Me.TextBox1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 21.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim textBox As Global.System.Windows.Forms.Control = Me.TextBox1
			point = New Global.System.Drawing.Point(63, 304)
			textBox.Location = point
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.PasswordChar = "*"c
			Dim textBox2 As Global.System.Windows.Forms.Control = Me.TextBox1
			size = New Global.System.Drawing.Size(564, 40)
			textBox2.Size = size
			Me.TextBox1.TabIndex = 4
			Me.Button1.Anchor = Global.System.Windows.Forms.AnchorStyles.None
			Me.Button1.BackColor = Global.System.Drawing.Color.Silver
			Me.Button1.Cursor = Global.System.Windows.Forms.Cursors.Arrow
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.Font = New Global.System.Drawing.Font("Trebuchet MS", 48F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			point = New Global.System.Drawing.Point(63, 173)
			button.Location = point
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(564, 125)
			button2.Size = size
			Me.Button1.TabIndex = 1
			Me.Button1.Text = "Start CV or Login"
			Me.Button1.UseVisualStyleBackColor = False
			Me.MenuStrip1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.MenuStrip1.BackColor = Global.System.Drawing.Color.Transparent
			Me.MenuStrip1.Dock = Global.System.Windows.Forms.DockStyle.None
			Me.MenuStrip1.Font = New Global.System.Drawing.Font("Trebuchet MS", 18F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.MenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.SToolStripMenuItem })
			Dim menuStrip As Global.System.Windows.Forms.Control = Me.MenuStrip1
			point = New Global.System.Drawing.Point(620, 457)
			menuStrip.Location = point
			Me.MenuStrip1.Name = "MenuStrip1"
			Dim menuStrip2 As Global.System.Windows.Forms.Control = Me.MenuStrip1
			size = New Global.System.Drawing.Size(85, 37)
			menuStrip2.Size = size
			Me.MenuStrip1.TabIndex = 3
			Me.MenuStrip1.Text = "MenuStrip1"
			Me.SToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.RestartToolStripMenuItem, Me.ShutdownToolStripMenuItem })
			Me.SToolStripMenuItem.Name = "SToolStripMenuItem"
			Dim stoolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.SToolStripMenuItem
			size = New Global.System.Drawing.Size(77, 33)
			stoolStripMenuItem.Size = size
			Me.SToolStripMenuItem.Text = "More"
			Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
			Dim restartToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.RestartToolStripMenuItem
			size = New Global.System.Drawing.Size(191, 34)
			restartToolStripMenuItem.Size = size
			Me.RestartToolStripMenuItem.Text = "Restart"
			Me.ShutdownToolStripMenuItem.Name = "ShutdownToolStripMenuItem"
			Dim shutdownToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.ShutdownToolStripMenuItem
			size = New Global.System.Drawing.Size(191, 34)
			shutdownToolStripMenuItem.Size = size
			Me.ShutdownToolStripMenuItem.Text = "Shutdown"
			Me.Button2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Button2.BackColor = Global.System.Drawing.Color.Silver
			Me.Button2.Cursor = Global.System.Windows.Forms.Cursors.Arrow
			Me.Button2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button2.Font = New Global.System.Drawing.Font("Trebuchet MS", 21.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button2
			point = New Global.System.Drawing.Point(430, 575)
			button3.Location = point
			Me.Button2.Name = "Button2"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button2
			size = New Global.System.Drawing.Size(297, 69)
			button4.Size = size
			Me.Button2.TabIndex = 5
			Me.Button2.Text = "Login on CV"
			Me.Button2.UseVisualStyleBackColor = False
			Me.Button2.Visible = False
			Me.Button3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button3.BackgroundImage = CType(componentResourceManager.GetObject("Button3.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button3.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button3.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button5 As Global.System.Windows.Forms.Control = Me.Button3
			point = New Global.System.Drawing.Point(616, 3)
			button5.Location = point
			Me.Button3.Name = "Button3"
			Dim button6 As Global.System.Windows.Forms.Control = Me.Button3
			size = New Global.System.Drawing.Size(73, 68)
			button6.Size = size
			Me.Button3.TabIndex = 5
			Me.Button3.UseVisualStyleBackColor = True
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(1158, 644)
			Me.ClientSize = size
			Me.Controls.Add(Me.Button2)
			Me.Controls.Add(Me.Panel1)
			Me.Controls.Add(Me.PictureBox1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			Me.MainMenuStrip = Me.MenuStrip1
			Me.Name = "Form48"
			Me.Text = "StartupP"
			Me.WindowState = Global.System.Windows.Forms.FormWindowState.Maximized
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.MenuStrip1.ResumeLayout(False)
			Me.MenuStrip1.PerformLayout()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x04000602 RID: 1538
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
