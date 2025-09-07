Namespace CV
	' Token: 0x02000024 RID: 36
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class cmdpad
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060002B4 RID: 692 RVA: 0x03D8DEA8 File Offset: 0x03D8C2A8
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

		' Token: 0x060002B5 RID: 693 RVA: 0x03D8DEF8 File Offset: 0x03D8C2F8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.cmdpad))
			Me.MenuStrip1 = New Global.System.Windows.Forms.MenuStrip()
			Me.SettingsToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.FontToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.WindowsCMDToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.RichTextBox1 = New Global.System.Windows.Forms.RichTextBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.Button3 = New Global.System.Windows.Forms.Button()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.OldCMDToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.MenuStrip1.SuspendLayout()
			Me.SuspendLayout()
			Me.MenuStrip1.BackColor = Global.System.Drawing.Color.Silver
			Me.MenuStrip1.Font = New Global.System.Drawing.Font("Trebuchet MS", 24F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.MenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.SettingsToolStripMenuItem })
			Dim menuStrip As Global.System.Windows.Forms.Control = Me.MenuStrip1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			menuStrip.Location = point
			Me.MenuStrip1.Name = "MenuStrip1"
			Dim menuStrip2 As Global.System.Windows.Forms.Control = Me.MenuStrip1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(1127, 48)
			menuStrip2.Size = size
			Me.MenuStrip1.TabIndex = 0
			Me.MenuStrip1.Text = "MenuStrip1"
			Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.FontToolStripMenuItem, Me.WindowsCMDToolStripMenuItem, Me.OldCMDToolStripMenuItem })
			Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
			Dim settingsToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.SettingsToolStripMenuItem
			size = New Global.System.Drawing.Size(142, 44)
			settingsToolStripMenuItem.Size = size
			Me.SettingsToolStripMenuItem.Text = "Settings"
			Me.FontToolStripMenuItem.BackColor = Global.System.Drawing.SystemColors.Control
			Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
			Dim fontToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.FontToolStripMenuItem
			size = New Global.System.Drawing.Size(291, 44)
			fontToolStripMenuItem.Size = size
			Me.FontToolStripMenuItem.Text = "Font"
			Me.WindowsCMDToolStripMenuItem.BackColor = Global.System.Drawing.SystemColors.Control
			Me.WindowsCMDToolStripMenuItem.Name = "WindowsCMDToolStripMenuItem"
			Dim windowsCMDToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.WindowsCMDToolStripMenuItem
			size = New Global.System.Drawing.Size(291, 44)
			windowsCMDToolStripMenuItem.Size = size
			Me.WindowsCMDToolStripMenuItem.Text = "Windows CMD"
			Me.RichTextBox1.BackColor = Global.System.Drawing.Color.Black
			Me.RichTextBox1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.RichTextBox1.Font = New Global.System.Drawing.Font("Trebuchet MS", 18F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.RichTextBox1.ForeColor = Global.System.Drawing.Color.White
			Dim richTextBox As Global.System.Windows.Forms.Control = Me.RichTextBox1
			point = New Global.System.Drawing.Point(0, 48)
			richTextBox.Location = point
			Me.RichTextBox1.Name = "RichTextBox1"
			Dim richTextBox2 As Global.System.Windows.Forms.Control = Me.RichTextBox1
			size = New Global.System.Drawing.Size(1127, 612)
			richTextBox2.Size = size
			Me.RichTextBox1.TabIndex = 1
			Me.RichTextBox1.Text = "C:/Sebs-SW-CV"
			Me.Button1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button1.BackColor = Global.System.Drawing.Color.Silver
			Me.Button1.BackgroundImage = CType(componentResourceManager.GetObject("Button1.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button1.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			point = New Global.System.Drawing.Point(1073, 0)
			button.Location = point
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(54, 48)
			button2.Size = size
			Me.Button1.TabIndex = 2
			Me.Button1.UseVisualStyleBackColor = False
			Me.Button2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button2.BackColor = Global.System.Drawing.Color.Silver
			Me.Button2.BackgroundImage = CType(componentResourceManager.GetObject("Button2.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button2.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button2
			point = New Global.System.Drawing.Point(1014, 0)
			button3.Location = point
			Me.Button2.Name = "Button2"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button2
			size = New Global.System.Drawing.Size(53, 48)
			button4.Size = size
			Me.Button2.TabIndex = 3
			Me.Button2.UseVisualStyleBackColor = False
			Me.Button3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button3.BackColor = Global.System.Drawing.Color.Silver
			Me.Button3.BackgroundImage = CType(componentResourceManager.GetObject("Button3.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button3.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button3.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button5 As Global.System.Windows.Forms.Control = Me.Button3
			point = New Global.System.Drawing.Point(959, 0)
			button5.Location = point
			Me.Button3.Name = "Button3"
			Dim button6 As Global.System.Windows.Forms.Control = Me.Button3
			size = New Global.System.Drawing.Size(49, 48)
			button6.Size = size
			Me.Button3.TabIndex = 4
			Me.Button3.UseVisualStyleBackColor = False
			Me.Timer1.Enabled = True
			Me.OldCMDToolStripMenuItem.Name = "OldCMDToolStripMenuItem"
			Dim oldCMDToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.OldCMDToolStripMenuItem
			size = New Global.System.Drawing.Size(291, 44)
			oldCMDToolStripMenuItem.Size = size
			Me.OldCMDToolStripMenuItem.Text = "Old CMD"
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(1127, 660)
			Me.ClientSize = size
			Me.Controls.Add(Me.Button3)
			Me.Controls.Add(Me.Button2)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.RichTextBox1)
			Me.Controls.Add(Me.MenuStrip1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.MainMenuStrip = Me.MenuStrip1
			Me.Name = "cmdpad"
			Me.Text = "cmdpad"
			Me.MenuStrip1.ResumeLayout(False)
			Me.MenuStrip1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x0400011C RID: 284
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
