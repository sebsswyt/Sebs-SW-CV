Namespace CV
	' Token: 0x0200003B RID: 59
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form17
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600072B RID: 1835 RVA: 0x03DA5A68 File Offset: 0x03DA3E68
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

		' Token: 0x0600072C RID: 1836 RVA: 0x03DA5AB8 File Offset: 0x03DA3EB8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.Form17))
			Me.RichTextBox1 = New Global.System.Windows.Forms.RichTextBox()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.MenuStrip1 = New Global.System.Windows.Forms.MenuStrip()
			Me.SettingsToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.FontToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripMenuItem2 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.WindowsCMDToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripSeparator1 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.ExitToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.FontDialog1 = New Global.System.Windows.Forms.FontDialog()
			Me.Timer2 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.MenuStrip1.SuspendLayout()
			Me.SuspendLayout()
			Me.RichTextBox1.BackColor = Global.System.Drawing.Color.Black
			Me.RichTextBox1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.RichTextBox1.Font = New Global.System.Drawing.Font("Trebuchet MS", 18F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.RichTextBox1.ForeColor = Global.System.Drawing.Color.White
			Dim richTextBox As Global.System.Windows.Forms.Control = Me.RichTextBox1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 33)
			richTextBox.Location = point
			Me.RichTextBox1.Name = "RichTextBox1"
			Dim richTextBox2 As Global.System.Windows.Forms.Control = Me.RichTextBox1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(1038, 568)
			richTextBox2.Size = size
			Me.RichTextBox1.TabIndex = 0
			Me.RichTextBox1.Text = "C:/Sebs-SW-CV/"
			Me.MenuStrip1.BackColor = Global.System.Drawing.Color.Silver
			Me.MenuStrip1.Font = New Global.System.Drawing.Font("Segoe UI", 14.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.MenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.SettingsToolStripMenuItem })
			Dim menuStrip As Global.System.Windows.Forms.Control = Me.MenuStrip1
			point = New Global.System.Drawing.Point(0, 0)
			menuStrip.Location = point
			Me.MenuStrip1.Name = "MenuStrip1"
			Dim menuStrip2 As Global.System.Windows.Forms.Control = Me.MenuStrip1
			size = New Global.System.Drawing.Size(1038, 33)
			menuStrip2.Size = size
			Me.MenuStrip1.TabIndex = 1
			Me.MenuStrip1.Text = "MenuStrip1"
			Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.FontToolStripMenuItem, Me.ToolStripMenuItem2, Me.WindowsCMDToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem })
			Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
			Dim settingsToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.SettingsToolStripMenuItem
			size = New Global.System.Drawing.Size(91, 29)
			settingsToolStripMenuItem.Size = size
			Me.SettingsToolStripMenuItem.Text = "Settings"
			Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
			Dim fontToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.FontToolStripMenuItem
			size = New Global.System.Drawing.Size(209, 30)
			fontToolStripMenuItem.Size = size
			Me.FontToolStripMenuItem.Text = "Font"
			Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
			Dim toolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripMenuItem2
			size = New Global.System.Drawing.Size(209, 30)
			toolStripMenuItem.Size = size
			Me.ToolStripMenuItem2.Text = "Paste text"
			Me.WindowsCMDToolStripMenuItem.Name = "WindowsCMDToolStripMenuItem"
			Dim windowsCMDToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.WindowsCMDToolStripMenuItem
			size = New Global.System.Drawing.Size(209, 30)
			windowsCMDToolStripMenuItem.Size = size
			Me.WindowsCMDToolStripMenuItem.Text = "Windows CMD"
			Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
			Dim toolStripSeparator As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripSeparator1
			size = New Global.System.Drawing.Size(206, 6)
			toolStripSeparator.Size = size
			Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
			Dim exitToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.ExitToolStripMenuItem
			size = New Global.System.Drawing.Size(209, 30)
			exitToolStripMenuItem.Size = size
			Me.ExitToolStripMenuItem.Text = "Exit"
			Me.FontDialog1.Font = New Global.System.Drawing.Font("Trebuchet MS", 18F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.FontDialog1.ShowApply = True
			Me.FontDialog1.ShowColor = True
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.SystemColors.Control
			size = New Global.System.Drawing.Size(1038, 601)
			Me.ClientSize = size
			Me.Controls.Add(Me.RichTextBox1)
			Me.Controls.Add(Me.MenuStrip1)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.MainMenuStrip = Me.MenuStrip1
			Me.Name = "Form17"
			Me.Text = "Command Prompt"
			Me.MenuStrip1.ResumeLayout(False)
			Me.MenuStrip1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x040002BB RID: 699
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
