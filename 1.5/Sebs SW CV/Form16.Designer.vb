Namespace CV
	' Token: 0x0200003A RID: 58
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form16
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060006F9 RID: 1785 RVA: 0x03DA4C14 File Offset: 0x03DA3014
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

		' Token: 0x060006FA RID: 1786 RVA: 0x03DA4C64 File Offset: 0x03DA3064
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.Form16))
			Me.MenuStrip1 = New Global.System.Windows.Forms.MenuStrip()
			Me.FileToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.OpenToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.NewToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.SaveToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.AsSaveToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripSeparator1 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.ExitToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.FormatToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.TheWebToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.FileExplorerToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.AboutToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.AboutUsToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.TheWebToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.SaveFileDialog1 = New Global.System.Windows.Forms.SaveFileDialog()
			Me.RichTextBox1 = New Global.System.Windows.Forms.RichTextBox()
			Me.ToolStripSeparator2 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.BSODTestToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.MenuStrip1.SuspendLayout()
			Me.SuspendLayout()
			Me.MenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.FileToolStripMenuItem, Me.FormatToolStripMenuItem, Me.AboutToolStripMenuItem })
			Dim menuStrip As Global.System.Windows.Forms.Control = Me.MenuStrip1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			menuStrip.Location = point
			Me.MenuStrip1.Name = "MenuStrip1"
			Dim menuStrip2 As Global.System.Windows.Forms.Control = Me.MenuStrip1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(893, 24)
			menuStrip2.Size = size
			Me.MenuStrip1.TabIndex = 0
			Me.MenuStrip1.Text = "MenuStrip1"
			Me.FileToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.OpenToolStripMenuItem, Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.AsSaveToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem })
			Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
			Dim fileToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.FileToolStripMenuItem
			size = New Global.System.Drawing.Size(37, 20)
			fileToolStripMenuItem.Size = size
			Me.FileToolStripMenuItem.Text = "File"
			Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
			Dim openToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.OpenToolStripMenuItem
			size = New Global.System.Drawing.Size(114, 22)
			openToolStripMenuItem.Size = size
			Me.OpenToolStripMenuItem.Text = "Open"
			Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
			Dim newToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.NewToolStripMenuItem
			size = New Global.System.Drawing.Size(114, 22)
			newToolStripMenuItem.Size = size
			Me.NewToolStripMenuItem.Text = "New"
			Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
			Dim saveToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.SaveToolStripMenuItem
			size = New Global.System.Drawing.Size(114, 22)
			saveToolStripMenuItem.Size = size
			Me.SaveToolStripMenuItem.Text = "Save"
			Me.AsSaveToolStripMenuItem.Name = "AsSaveToolStripMenuItem"
			Dim asSaveToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.AsSaveToolStripMenuItem
			size = New Global.System.Drawing.Size(114, 22)
			asSaveToolStripMenuItem.Size = size
			Me.AsSaveToolStripMenuItem.Text = "As Save"
			Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
			Dim toolStripSeparator As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripSeparator1
			size = New Global.System.Drawing.Size(111, 6)
			toolStripSeparator.Size = size
			Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
			Dim exitToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.ExitToolStripMenuItem
			size = New Global.System.Drawing.Size(114, 22)
			exitToolStripMenuItem.Size = size
			Me.ExitToolStripMenuItem.Text = "Exit"
			Me.FormatToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.TheWebToolStripMenuItem, Me.FileExplorerToolStripMenuItem })
			Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
			Dim formatToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.FormatToolStripMenuItem
			size = New Global.System.Drawing.Size(57, 20)
			formatToolStripMenuItem.Size = size
			Me.FormatToolStripMenuItem.Text = "Format"
			Me.TheWebToolStripMenuItem.Name = "TheWebToolStripMenuItem"
			Dim theWebToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.TheWebToolStripMenuItem
			size = New Global.System.Drawing.Size(137, 22)
			theWebToolStripMenuItem.Size = size
			Me.TheWebToolStripMenuItem.Text = "The Web"
			Me.FileExplorerToolStripMenuItem.Name = "FileExplorerToolStripMenuItem"
			Dim fileExplorerToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.FileExplorerToolStripMenuItem
			size = New Global.System.Drawing.Size(137, 22)
			fileExplorerToolStripMenuItem.Size = size
			Me.FileExplorerToolStripMenuItem.Text = "File Explorer"
			Me.AboutToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.AboutUsToolStripMenuItem, Me.TheWebToolStripMenuItem1, Me.ToolStripSeparator2, Me.BSODTestToolStripMenuItem })
			Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
			Dim aboutToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.AboutToolStripMenuItem
			size = New Global.System.Drawing.Size(52, 20)
			aboutToolStripMenuItem.Size = size
			Me.AboutToolStripMenuItem.Text = "About"
			Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
			Dim aboutUsToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.AboutUsToolStripMenuItem
			size = New Global.System.Drawing.Size(152, 22)
			aboutUsToolStripMenuItem.Size = size
			Me.AboutUsToolStripMenuItem.Text = "About us"
			Me.TheWebToolStripMenuItem1.Name = "TheWebToolStripMenuItem1"
			Dim theWebToolStripMenuItem2 As Global.System.Windows.Forms.ToolStripItem = Me.TheWebToolStripMenuItem1
			size = New Global.System.Drawing.Size(152, 22)
			theWebToolStripMenuItem2.Size = size
			Me.TheWebToolStripMenuItem1.Text = "The Web"
			Me.SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt"
			Me.RichTextBox1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim richTextBox As Global.System.Windows.Forms.Control = Me.RichTextBox1
			point = New Global.System.Drawing.Point(0, 24)
			richTextBox.Location = point
			Me.RichTextBox1.Name = "RichTextBox1"
			Dim richTextBox2 As Global.System.Windows.Forms.Control = Me.RichTextBox1
			size = New Global.System.Drawing.Size(893, 640)
			richTextBox2.Size = size
			Me.RichTextBox1.TabIndex = 1
			Me.RichTextBox1.Text = ""
			Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
			Dim toolStripSeparator2 As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripSeparator2
			size = New Global.System.Drawing.Size(149, 6)
			toolStripSeparator2.Size = size
			Me.BSODTestToolStripMenuItem.Name = "BSODTestToolStripMenuItem"
			Dim bsodtestToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.BSODTestToolStripMenuItem
			size = New Global.System.Drawing.Size(152, 22)
			bsodtestToolStripMenuItem.Size = size
			Me.BSODTestToolStripMenuItem.Text = "BSOD-Test"
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(893, 664)
			Me.ClientSize = size
			Me.Controls.Add(Me.RichTextBox1)
			Me.Controls.Add(Me.MenuStrip1)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.MainMenuStrip = Me.MenuStrip1
			Me.Name = "Form16"
			Me.Text = "Save Data Panal"
			Me.MenuStrip1.ResumeLayout(False)
			Me.MenuStrip1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x040002A7 RID: 679
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
