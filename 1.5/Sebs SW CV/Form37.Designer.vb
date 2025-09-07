Namespace CV
	' Token: 0x02000053 RID: 83
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form37
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000E54 RID: 3668 RVA: 0x03DD8164 File Offset: 0x03DD6564
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

		' Token: 0x06000E55 RID: 3669 RVA: 0x03DD81B4 File Offset: 0x03DD65B4
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.Form37))
			Me.MenuStrip1 = New Global.System.Windows.Forms.MenuStrip()
			Me.FileToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.OpenFileToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.SaveToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.SaveAsToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripSeparator1 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.ExitToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.EditToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CutToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CopyToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.PasteToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.SelectAllToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.AboutToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.AboutToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.OpenFileDialog1 = New Global.System.Windows.Forms.OpenFileDialog()
			Me.SaveFileDialog1 = New Global.System.Windows.Forms.SaveFileDialog()
			Me.MenuStrip1.SuspendLayout()
			Me.SuspendLayout()
			Me.MenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.AboutToolStripMenuItem })
			Dim menuStrip As Global.System.Windows.Forms.Control = Me.MenuStrip1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			menuStrip.Location = point
			Me.MenuStrip1.Name = "MenuStrip1"
			Dim menuStrip2 As Global.System.Windows.Forms.Control = Me.MenuStrip1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(1546, 24)
			menuStrip2.Size = size
			Me.MenuStrip1.TabIndex = 0
			Me.MenuStrip1.Text = "MenuStrip1"
			Me.FileToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.OpenFileToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem })
			Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
			Dim fileToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.FileToolStripMenuItem
			size = New Global.System.Drawing.Size(37, 20)
			fileToolStripMenuItem.Size = size
			Me.FileToolStripMenuItem.Text = "File"
			Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
			Me.OpenFileToolStripMenuItem.ShortcutKeys = CType(131151, Global.System.Windows.Forms.Keys)
			Dim openFileToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.OpenFileToolStripMenuItem
			size = New Global.System.Drawing.Size(175, 22)
			openFileToolStripMenuItem.Size = size
			Me.OpenFileToolStripMenuItem.Text = "Open File"
			Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
			Me.SaveToolStripMenuItem.ShortcutKeys = CType(131155, Global.System.Windows.Forms.Keys)
			Dim saveToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.SaveToolStripMenuItem
			size = New Global.System.Drawing.Size(175, 22)
			saveToolStripMenuItem.Size = size
			Me.SaveToolStripMenuItem.Text = "Save"
			Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
			Me.SaveAsToolStripMenuItem.ShortcutKeys = CType(393299, Global.System.Windows.Forms.Keys)
			Dim saveAsToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.SaveAsToolStripMenuItem
			size = New Global.System.Drawing.Size(175, 22)
			saveAsToolStripMenuItem.Size = size
			Me.SaveAsToolStripMenuItem.Text = "Save as"
			Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
			Dim toolStripSeparator As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripSeparator1
			size = New Global.System.Drawing.Size(172, 6)
			toolStripSeparator.Size = size
			Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
			Dim exitToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.ExitToolStripMenuItem
			size = New Global.System.Drawing.Size(175, 22)
			exitToolStripMenuItem.Size = size
			Me.ExitToolStripMenuItem.Text = "Exit"
			Me.EditToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.SelectAllToolStripMenuItem })
			Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
			Dim editToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.EditToolStripMenuItem
			size = New Global.System.Drawing.Size(39, 20)
			editToolStripMenuItem.Size = size
			Me.EditToolStripMenuItem.Text = "Edit"
			Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
			Me.CutToolStripMenuItem.ShortcutKeys = CType(131160, Global.System.Windows.Forms.Keys)
			Dim cutToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.CutToolStripMenuItem
			size = New Global.System.Drawing.Size(164, 22)
			cutToolStripMenuItem.Size = size
			Me.CutToolStripMenuItem.Text = "Cut"
			Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
			Me.CopyToolStripMenuItem.ShortcutKeys = CType(131139, Global.System.Windows.Forms.Keys)
			Dim copyToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.CopyToolStripMenuItem
			size = New Global.System.Drawing.Size(164, 22)
			copyToolStripMenuItem.Size = size
			Me.CopyToolStripMenuItem.Text = "Copy"
			Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
			Me.PasteToolStripMenuItem.ShortcutKeys = CType(131158, Global.System.Windows.Forms.Keys)
			Dim pasteToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.PasteToolStripMenuItem
			size = New Global.System.Drawing.Size(164, 22)
			pasteToolStripMenuItem.Size = size
			Me.PasteToolStripMenuItem.Text = "Paste"
			Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
			Me.SelectAllToolStripMenuItem.ShortcutKeys = CType(131137, Global.System.Windows.Forms.Keys)
			Dim selectAllToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.SelectAllToolStripMenuItem
			size = New Global.System.Drawing.Size(164, 22)
			selectAllToolStripMenuItem.Size = size
			Me.SelectAllToolStripMenuItem.Text = "Select All"
			Me.AboutToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.AboutToolStripMenuItem1 })
			Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
			Dim aboutToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.AboutToolStripMenuItem
			size = New Global.System.Drawing.Size(52, 20)
			aboutToolStripMenuItem.Size = size
			Me.AboutToolStripMenuItem.Text = "About"
			Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
			Dim aboutToolStripMenuItem2 As Global.System.Windows.Forms.ToolStripItem = Me.AboutToolStripMenuItem1
			size = New Global.System.Drawing.Size(107, 22)
			aboutToolStripMenuItem2.Size = size
			Me.AboutToolStripMenuItem1.Text = "About"
			Me.TextBox1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.TextBox1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 15.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim textBox As Global.System.Windows.Forms.Control = Me.TextBox1
			point = New Global.System.Drawing.Point(0, 27)
			textBox.Location = point
			Me.TextBox1.Multiline = True
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.[ReadOnly] = True
			Dim textBox2 As Global.System.Windows.Forms.Control = Me.TextBox1
			size = New Global.System.Drawing.Size(1534, 609)
			textBox2.Size = size
			Me.TextBox1.TabIndex = 4
			Me.OpenFileDialog1.FileName = "OpenFileDialog1"
			Me.OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt"
			Me.SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt"
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(1546, 648)
			Me.ClientSize = size
			Me.Controls.Add(Me.TextBox1)
			Me.Controls.Add(Me.MenuStrip1)
			Me.HelpButton = True
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.MainMenuStrip = Me.MenuStrip1
			Me.Name = "Form37"
			Me.Text = "Text Editor"
			Me.MenuStrip1.ResumeLayout(False)
			Me.MenuStrip1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x0400054C RID: 1356
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
