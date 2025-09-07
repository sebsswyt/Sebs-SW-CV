Namespace CV
	' Token: 0x02000046 RID: 70
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form25
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000B08 RID: 2824 RVA: 0x03DC1F30 File Offset: 0x03DC0330
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

		' Token: 0x06000B09 RID: 2825 RVA: 0x03DC1F80 File Offset: 0x03DC0380
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.Form25))
			Me.MenuStrip1 = New Global.System.Windows.Forms.MenuStrip()
			Me.FileToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.NewTaskToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ExitToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.OptionsToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.NOMenuToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ViewToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.NOMenuToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ProgramToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.RestartToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.SToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.HelpToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.AboutToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.Button3 = New Global.System.Windows.Forms.Button()
			Me.Button4 = New Global.System.Windows.Forms.Button()
			Me.Button5 = New Global.System.Windows.Forms.Button()
			Me.Button6 = New Global.System.Windows.Forms.Button()
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.MenuStrip1.SuspendLayout()
			Me.SuspendLayout()
			Me.MenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ProgramToolStripMenuItem, Me.HelpToolStripMenuItem })
			Dim menuStrip As Global.System.Windows.Forms.Control = Me.MenuStrip1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			menuStrip.Location = point
			Me.MenuStrip1.Name = "MenuStrip1"
			Dim menuStrip2 As Global.System.Windows.Forms.Control = Me.MenuStrip1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(481, 24)
			menuStrip2.Size = size
			Me.MenuStrip1.TabIndex = 0
			Me.MenuStrip1.Text = "MenuStrip1"
			Me.FileToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.NewTaskToolStripMenuItem, Me.ExitToolStripMenuItem })
			Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
			Dim fileToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.FileToolStripMenuItem
			size = New Global.System.Drawing.Size(37, 20)
			fileToolStripMenuItem.Size = size
			Me.FileToolStripMenuItem.Text = "File"
			Me.NewTaskToolStripMenuItem.Name = "NewTaskToolStripMenuItem"
			Dim newTaskToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.NewTaskToolStripMenuItem
			size = New Global.System.Drawing.Size(154, 22)
			newTaskToolStripMenuItem.Size = size
			Me.NewTaskToolStripMenuItem.Text = "New task (Run)"
			Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
			Dim exitToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.ExitToolStripMenuItem
			size = New Global.System.Drawing.Size(154, 22)
			exitToolStripMenuItem.Size = size
			Me.ExitToolStripMenuItem.Text = "Exit"
			Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.NOMenuToolStripMenuItem })
			Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
			Dim optionsToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.OptionsToolStripMenuItem
			size = New Global.System.Drawing.Size(61, 20)
			optionsToolStripMenuItem.Size = size
			Me.OptionsToolStripMenuItem.Text = "Options"
			Me.NOMenuToolStripMenuItem.Name = "NOMenuToolStripMenuItem"
			Dim nomenuToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.NOMenuToolStripMenuItem
			size = New Global.System.Drawing.Size(129, 22)
			nomenuToolStripMenuItem.Size = size
			Me.NOMenuToolStripMenuItem.Text = "NO Menu!"
			Me.ViewToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.NOMenuToolStripMenuItem1 })
			Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
			Dim viewToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.ViewToolStripMenuItem
			size = New Global.System.Drawing.Size(44, 20)
			viewToolStripMenuItem.Size = size
			Me.ViewToolStripMenuItem.Text = "View"
			Me.NOMenuToolStripMenuItem1.Name = "NOMenuToolStripMenuItem1"
			Me.NOMenuToolStripMenuItem1.ShortcutKeys = Global.System.Windows.Forms.Keys.F5
			Dim nomenuToolStripMenuItem2 As Global.System.Windows.Forms.ToolStripItem = Me.NOMenuToolStripMenuItem1
			size = New Global.System.Drawing.Size(160, 22)
			nomenuToolStripMenuItem2.Size = size
			Me.NOMenuToolStripMenuItem1.Text = "Refresh Now"
			Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.RestartToolStripMenuItem, Me.SToolStripMenuItem })
			Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
			Dim programToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.ProgramToolStripMenuItem
			size = New Global.System.Drawing.Size(65, 20)
			programToolStripMenuItem.Size = size
			Me.ProgramToolStripMenuItem.Text = "Program"
			Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
			Dim restartToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.RestartToolStripMenuItem
			size = New Global.System.Drawing.Size(128, 22)
			restartToolStripMenuItem.Size = size
			Me.RestartToolStripMenuItem.Text = "Restart"
			Me.SToolStripMenuItem.Name = "SToolStripMenuItem"
			Dim stoolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.SToolStripMenuItem
			size = New Global.System.Drawing.Size(128, 22)
			stoolStripMenuItem.Size = size
			Me.SToolStripMenuItem.Text = "Shutdown"
			Me.HelpToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.AboutToolStripMenuItem })
			Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
			Dim helpToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.HelpToolStripMenuItem
			size = New Global.System.Drawing.Size(44, 20)
			helpToolStripMenuItem.Size = size
			Me.HelpToolStripMenuItem.Text = "Help"
			Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
			Dim aboutToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.AboutToolStripMenuItem
			size = New Global.System.Drawing.Size(107, 22)
			aboutToolStripMenuItem.Size = size
			Me.AboutToolStripMenuItem.Text = "About"
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			point = New Global.System.Drawing.Point(13, 28)
			button.Location = point
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(93, 23)
			button2.Size = size
			Me.Button1.TabIndex = 1
			Me.Button1.Text = "Lions Explorer"
			Me.Button1.UseVisualStyleBackColor = True
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button2
			point = New Global.System.Drawing.Point(13, 57)
			button3.Location = point
			Me.Button2.Name = "Button2"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button2
			size = New Global.System.Drawing.Size(113, 23)
			button4.Size = size
			Me.Button2.TabIndex = 2
			Me.Button2.Text = "Not internet Explorer"
			Me.Button2.UseVisualStyleBackColor = True
			Dim button5 As Global.System.Windows.Forms.Control = Me.Button3
			point = New Global.System.Drawing.Point(13, 86)
			button5.Location = point
			Me.Button3.Name = "Button3"
			Dim button6 As Global.System.Windows.Forms.Control = Me.Button3
			size = New Global.System.Drawing.Size(75, 23)
			button6.Size = size
			Me.Button3.TabIndex = 3
			Me.Button3.Text = "Bug fix"
			Me.Button3.UseVisualStyleBackColor = True
			Dim button7 As Global.System.Windows.Forms.Control = Me.Button4
			point = New Global.System.Drawing.Point(263, 59)
			button7.Location = point
			Me.Button4.Name = "Button4"
			Dim button8 As Global.System.Windows.Forms.Control = Me.Button4
			size = New Global.System.Drawing.Size(75, 23)
			button8.Size = size
			Me.Button4.TabIndex = 4
			Me.Button4.Text = "Button4"
			Me.Button4.UseVisualStyleBackColor = True
			Dim button9 As Global.System.Windows.Forms.Control = Me.Button5
			point = New Global.System.Drawing.Point(13, 115)
			button9.Location = point
			Me.Button5.Name = "Button5"
			Dim button10 As Global.System.Windows.Forms.Control = Me.Button5
			size = New Global.System.Drawing.Size(113, 23)
			button10.Size = size
			Me.Button5.TabIndex = 5
			Me.Button5.Text = "form1Pad.exe"
			Me.Button5.UseVisualStyleBackColor = True
			Dim button11 As Global.System.Windows.Forms.Control = Me.Button6
			point = New Global.System.Drawing.Point(13, 144)
			button11.Location = point
			Me.Button6.Name = "Button6"
			Dim button12 As Global.System.Windows.Forms.Control = Me.Button6
			size = New Global.System.Drawing.Size(164, 23)
			button12.Size = size
			Me.Button6.TabIndex = 6
			Me.Button6.Text = "form1Pad.exe stop taskbar"
			Me.Button6.UseVisualStyleBackColor = True
			Dim progressBar As Global.System.Windows.Forms.Control = Me.ProgressBar1
			point = New Global.System.Drawing.Point(461, 455)
			progressBar.Location = point
			Me.ProgressBar1.Name = "ProgressBar1"
			Dim progressBar2 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			size = New Global.System.Drawing.Size(20, 23)
			progressBar2.Size = size
			Me.ProgressBar1.TabIndex = 7
			Me.ProgressBar1.Visible = False
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(481, 477)
			Me.ClientSize = size
			Me.Controls.Add(Me.ProgressBar1)
			Me.Controls.Add(Me.Button6)
			Me.Controls.Add(Me.Button5)
			Me.Controls.Add(Me.Button4)
			Me.Controls.Add(Me.Button3)
			Me.Controls.Add(Me.Button2)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.MenuStrip1)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.MainMenuStrip = Me.MenuStrip1
			Me.Name = "Form25"
			Me.Text = "Taskman"
			Me.MenuStrip1.ResumeLayout(False)
			Me.MenuStrip1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x04000410 RID: 1040
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
