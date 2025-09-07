Namespace CV
	' Token: 0x02000031 RID: 49
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Explorer2
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060003E7 RID: 999 RVA: 0x03D91DB0 File Offset: 0x03D901B0
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

		' Token: 0x06000450 RID: 1104 RVA: 0x03D929E8 File Offset: 0x03D90DE8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.Explorer2))
			Me.StatusStrip = New Global.System.Windows.Forms.StatusStrip()
			Me.ToolStripStatusLabel = New Global.System.Windows.Forms.ToolStripStatusLabel()
			Me.TreeNodeImageList = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.ToolStrip = New Global.System.Windows.Forms.ToolStrip()
			Me.BackToolStripButton = New Global.System.Windows.Forms.ToolStripButton()
			Me.ForwardToolStripButton = New Global.System.Windows.Forms.ToolStripButton()
			Me.ToolStripSeparator7 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.FoldersToolStripButton = New Global.System.Windows.Forms.ToolStripButton()
			Me.ToolStripSeparator8 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.ListViewToolStripButton = New Global.System.Windows.Forms.ToolStripDropDownButton()
			Me.ListToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.DetailsToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.LargeIconsToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.SmallIconsToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.TileToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.MenuStrip = New Global.System.Windows.Forms.MenuStrip()
			Me.FileToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.NewToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.OpenToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripSeparator1 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.SaveToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.SaveAsToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripSeparator2 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.PrintToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.PrintPreviewToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripSeparator3 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.ExitToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.EditToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.UndoToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.RedoToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripSeparator4 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.CutToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CopyToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.PasteToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripSeparator5 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.SelectAllToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ViewToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolBarToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.StatusBarToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.FoldersToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolsToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.OptionsToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.HelpToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ContentsToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.IndexToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.SearchToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripSeparator6 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.AboutToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolTip = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.ToolStripContainer = New Global.System.Windows.Forms.ToolStripContainer()
			Me.ListViewLargeImageList = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.ListViewSmallImageList = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.SaveFileDialog1 = New Global.System.Windows.Forms.SaveFileDialog()
			Me.RichTextBox1 = New Global.System.Windows.Forms.RichTextBox()
			Me.StatusStrip.SuspendLayout()
			Me.ToolStrip.SuspendLayout()
			Me.MenuStrip.SuspendLayout()
			Me.ToolStripContainer.BottomToolStripPanel.SuspendLayout()
			Me.ToolStripContainer.ContentPanel.SuspendLayout()
			Me.ToolStripContainer.TopToolStripPanel.SuspendLayout()
			Me.ToolStripContainer.SuspendLayout()
			Me.SuspendLayout()
			Me.StatusStrip.Dock = Global.System.Windows.Forms.DockStyle.None
			Me.StatusStrip.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.ToolStripStatusLabel })
			Dim statusStrip As Global.System.Windows.Forms.Control = Me.StatusStrip
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			statusStrip.Location = point
			Me.StatusStrip.Name = "StatusStrip"
			Dim statusStrip2 As Global.System.Windows.Forms.Control = Me.StatusStrip
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(632, 22)
			statusStrip2.Size = size
			Me.StatusStrip.TabIndex = 6
			Me.StatusStrip.Text = "StatusStrip"
			Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
			Dim toolStripStatusLabel As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripStatusLabel
			size = New Global.System.Drawing.Size(39, 17)
			toolStripStatusLabel.Size = size
			Me.ToolStripStatusLabel.Text = "Status"
			Me.TreeNodeImageList.ImageStream = CType(componentResourceManager.GetObject("TreeNodeImageList.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.TreeNodeImageList.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.TreeNodeImageList.Images.SetKeyName(0, "ClosedFolder")
			Me.TreeNodeImageList.Images.SetKeyName(1, "OpenFolder")
			Me.ToolStrip.Anchor = Global.System.Windows.Forms.AnchorStyles.Right
			Me.ToolStrip.Dock = Global.System.Windows.Forms.DockStyle.None
			Me.ToolStrip.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.BackToolStripButton, Me.ForwardToolStripButton, Me.ToolStripSeparator7, Me.FoldersToolStripButton, Me.ToolStripSeparator8, Me.ListViewToolStripButton })
			Dim toolStrip As Global.System.Windows.Forms.Control = Me.ToolStrip
			point = New Global.System.Drawing.Point(3, 24)
			toolStrip.Location = point
			Me.ToolStrip.Name = "ToolStrip"
			Dim toolStrip2 As Global.System.Windows.Forms.Control = Me.ToolStrip
			size = New Global.System.Drawing.Size(240, 25)
			toolStrip2.Size = size
			Me.ToolStrip.TabIndex = 0
			Me.ToolStrip.Text = "ToolStrip1"
			Me.BackToolStripButton.Enabled = False
			Me.BackToolStripButton.Image = CType(componentResourceManager.GetObject("BackToolStripButton.Image"), Global.System.Drawing.Image)
			Me.BackToolStripButton.ImageTransparentColor = Global.System.Drawing.Color.Black
			Me.BackToolStripButton.Name = "BackToolStripButton"
			Dim backToolStripButton As Global.System.Windows.Forms.ToolStripItem = Me.BackToolStripButton
			size = New Global.System.Drawing.Size(52, 22)
			backToolStripButton.Size = size
			Me.BackToolStripButton.Text = "Back"
			Me.BackToolStripButton.ToolTipText = "Back to the previous item"
			Me.ForwardToolStripButton.Enabled = False
			Me.ForwardToolStripButton.Image = CType(componentResourceManager.GetObject("ForwardToolStripButton.Image"), Global.System.Drawing.Image)
			Me.ForwardToolStripButton.ImageTransparentColor = Global.System.Drawing.Color.Black
			Me.ForwardToolStripButton.Name = "ForwardToolStripButton"
			Dim forwardToolStripButton As Global.System.Windows.Forms.ToolStripItem = Me.ForwardToolStripButton
			size = New Global.System.Drawing.Size(70, 22)
			forwardToolStripButton.Size = size
			Me.ForwardToolStripButton.Text = "Forward"
			Me.ForwardToolStripButton.ToolTipText = "Move forward to the next item"
			Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
			Dim toolStripSeparator As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripSeparator7
			size = New Global.System.Drawing.Size(6, 25)
			toolStripSeparator.Size = size
			Me.FoldersToolStripButton.Checked = True
			Me.FoldersToolStripButton.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.FoldersToolStripButton.Image = CType(componentResourceManager.GetObject("FoldersToolStripButton.Image"), Global.System.Drawing.Image)
			Me.FoldersToolStripButton.ImageTransparentColor = Global.System.Drawing.Color.Black
			Me.FoldersToolStripButton.Name = "FoldersToolStripButton"
			Dim foldersToolStripButton As Global.System.Windows.Forms.ToolStripItem = Me.FoldersToolStripButton
			size = New Global.System.Drawing.Size(65, 22)
			foldersToolStripButton.Size = size
			Me.FoldersToolStripButton.Text = "Folders"
			Me.FoldersToolStripButton.ToolTipText = "Toggle Folders View"
			Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
			Dim toolStripSeparator2 As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripSeparator8
			size = New Global.System.Drawing.Size(6, 25)
			toolStripSeparator2.Size = size
			Me.ListViewToolStripButton.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.ListViewToolStripButton.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.ListToolStripMenuItem, Me.DetailsToolStripMenuItem, Me.LargeIconsToolStripMenuItem, Me.SmallIconsToolStripMenuItem, Me.TileToolStripMenuItem })
			Me.ListViewToolStripButton.Image = CType(componentResourceManager.GetObject("ListViewToolStripButton.Image"), Global.System.Drawing.Image)
			Me.ListViewToolStripButton.ImageTransparentColor = Global.System.Drawing.Color.Black
			Me.ListViewToolStripButton.Name = "ListViewToolStripButton"
			Dim listViewToolStripButton As Global.System.Windows.Forms.ToolStripItem = Me.ListViewToolStripButton
			size = New Global.System.Drawing.Size(29, 22)
			listViewToolStripButton.Size = size
			Me.ListViewToolStripButton.Text = "Views"
			Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
			Dim listToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.ListToolStripMenuItem
			size = New Global.System.Drawing.Size(134, 22)
			listToolStripMenuItem.Size = size
			Me.ListToolStripMenuItem.Text = "List"
			Me.DetailsToolStripMenuItem.Checked = True
			Me.DetailsToolStripMenuItem.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
			Dim detailsToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.DetailsToolStripMenuItem
			size = New Global.System.Drawing.Size(134, 22)
			detailsToolStripMenuItem.Size = size
			Me.DetailsToolStripMenuItem.Text = "Details"
			Me.LargeIconsToolStripMenuItem.Name = "LargeIconsToolStripMenuItem"
			Dim largeIconsToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.LargeIconsToolStripMenuItem
			size = New Global.System.Drawing.Size(134, 22)
			largeIconsToolStripMenuItem.Size = size
			Me.LargeIconsToolStripMenuItem.Text = "Large Icons"
			Me.SmallIconsToolStripMenuItem.Name = "SmallIconsToolStripMenuItem"
			Dim smallIconsToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.SmallIconsToolStripMenuItem
			size = New Global.System.Drawing.Size(134, 22)
			smallIconsToolStripMenuItem.Size = size
			Me.SmallIconsToolStripMenuItem.Text = "Small Icons"
			Me.TileToolStripMenuItem.Name = "TileToolStripMenuItem"
			Dim tileToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.TileToolStripMenuItem
			size = New Global.System.Drawing.Size(134, 22)
			tileToolStripMenuItem.Size = size
			Me.TileToolStripMenuItem.Text = "Tile"
			Me.MenuStrip.Dock = Global.System.Windows.Forms.DockStyle.None
			Me.MenuStrip.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem })
			Dim menuStrip As Global.System.Windows.Forms.Control = Me.MenuStrip
			point = New Global.System.Drawing.Point(0, 0)
			menuStrip.Location = point
			Me.MenuStrip.Name = "MenuStrip"
			Dim menuStrip2 As Global.System.Windows.Forms.Control = Me.MenuStrip
			size = New Global.System.Drawing.Size(632, 24)
			menuStrip2.Size = size
			Me.MenuStrip.TabIndex = 0
			Me.MenuStrip.Text = "MenuStrip1"
			Me.FileToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ToolStripSeparator1, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator2, Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.ToolStripSeparator3, Me.ExitToolStripMenuItem })
			Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
			Dim fileToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.FileToolStripMenuItem
			size = New Global.System.Drawing.Size(37, 20)
			fileToolStripMenuItem.Size = size
			Me.FileToolStripMenuItem.Text = "&File"
			Me.NewToolStripMenuItem.Image = CType(componentResourceManager.GetObject("NewToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.NewToolStripMenuItem.ImageTransparentColor = Global.System.Drawing.Color.Black
			Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
			Me.NewToolStripMenuItem.ShortcutKeys = CType(131150, Global.System.Windows.Forms.Keys)
			Dim newToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.NewToolStripMenuItem
			size = New Global.System.Drawing.Size(146, 22)
			newToolStripMenuItem.Size = size
			Me.NewToolStripMenuItem.Text = "&New"
			Me.OpenToolStripMenuItem.Image = CType(componentResourceManager.GetObject("OpenToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.OpenToolStripMenuItem.ImageTransparentColor = Global.System.Drawing.Color.Black
			Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
			Me.OpenToolStripMenuItem.ShortcutKeys = CType(131151, Global.System.Windows.Forms.Keys)
			Dim openToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.OpenToolStripMenuItem
			size = New Global.System.Drawing.Size(146, 22)
			openToolStripMenuItem.Size = size
			Me.OpenToolStripMenuItem.Text = "&Open"
			Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
			Dim toolStripSeparator3 As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripSeparator1
			size = New Global.System.Drawing.Size(143, 6)
			toolStripSeparator3.Size = size
			Me.SaveToolStripMenuItem.Image = CType(componentResourceManager.GetObject("SaveToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.SaveToolStripMenuItem.ImageTransparentColor = Global.System.Drawing.Color.Black
			Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
			Me.SaveToolStripMenuItem.ShortcutKeys = CType(131155, Global.System.Windows.Forms.Keys)
			Dim saveToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.SaveToolStripMenuItem
			size = New Global.System.Drawing.Size(146, 22)
			saveToolStripMenuItem.Size = size
			Me.SaveToolStripMenuItem.Text = "&Save"
			Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
			Dim saveAsToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.SaveAsToolStripMenuItem
			size = New Global.System.Drawing.Size(146, 22)
			saveAsToolStripMenuItem.Size = size
			Me.SaveAsToolStripMenuItem.Text = "Save &As"
			Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
			Dim toolStripSeparator4 As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripSeparator2
			size = New Global.System.Drawing.Size(143, 6)
			toolStripSeparator4.Size = size
			Me.PrintToolStripMenuItem.Image = CType(componentResourceManager.GetObject("PrintToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.PrintToolStripMenuItem.ImageTransparentColor = Global.System.Drawing.Color.Black
			Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
			Me.PrintToolStripMenuItem.ShortcutKeys = CType(131152, Global.System.Windows.Forms.Keys)
			Dim printToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.PrintToolStripMenuItem
			size = New Global.System.Drawing.Size(146, 22)
			printToolStripMenuItem.Size = size
			Me.PrintToolStripMenuItem.Text = "&Print"
			Me.PrintPreviewToolStripMenuItem.Image = CType(componentResourceManager.GetObject("PrintPreviewToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = Global.System.Drawing.Color.Black
			Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
			Dim printPreviewToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.PrintPreviewToolStripMenuItem
			size = New Global.System.Drawing.Size(146, 22)
			printPreviewToolStripMenuItem.Size = size
			Me.PrintPreviewToolStripMenuItem.Text = "Print Pre&view"
			Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
			Dim toolStripSeparator5 As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripSeparator3
			size = New Global.System.Drawing.Size(143, 6)
			toolStripSeparator5.Size = size
			Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
			Dim exitToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.ExitToolStripMenuItem
			size = New Global.System.Drawing.Size(146, 22)
			exitToolStripMenuItem.Size = size
			Me.ExitToolStripMenuItem.Text = "E&xit"
			Me.EditToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.ToolStripSeparator4, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ToolStripSeparator5, Me.SelectAllToolStripMenuItem })
			Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
			Dim editToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.EditToolStripMenuItem
			size = New Global.System.Drawing.Size(39, 20)
			editToolStripMenuItem.Size = size
			Me.EditToolStripMenuItem.Text = "&Edit"
			Me.UndoToolStripMenuItem.Image = CType(componentResourceManager.GetObject("UndoToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.UndoToolStripMenuItem.ImageTransparentColor = Global.System.Drawing.Color.Black
			Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
			Me.UndoToolStripMenuItem.ShortcutKeys = CType(131162, Global.System.Windows.Forms.Keys)
			Dim undoToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.UndoToolStripMenuItem
			size = New Global.System.Drawing.Size(164, 22)
			undoToolStripMenuItem.Size = size
			Me.UndoToolStripMenuItem.Text = "&Undo"
			Me.RedoToolStripMenuItem.Image = CType(componentResourceManager.GetObject("RedoToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.RedoToolStripMenuItem.ImageTransparentColor = Global.System.Drawing.Color.Black
			Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
			Me.RedoToolStripMenuItem.ShortcutKeys = CType(131161, Global.System.Windows.Forms.Keys)
			Dim redoToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.RedoToolStripMenuItem
			size = New Global.System.Drawing.Size(164, 22)
			redoToolStripMenuItem.Size = size
			Me.RedoToolStripMenuItem.Text = "&Redo"
			Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
			Dim toolStripSeparator6 As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripSeparator4
			size = New Global.System.Drawing.Size(161, 6)
			toolStripSeparator6.Size = size
			Me.CutToolStripMenuItem.Image = CType(componentResourceManager.GetObject("CutToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.CutToolStripMenuItem.ImageTransparentColor = Global.System.Drawing.Color.Black
			Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
			Me.CutToolStripMenuItem.ShortcutKeys = CType(131160, Global.System.Windows.Forms.Keys)
			Dim cutToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.CutToolStripMenuItem
			size = New Global.System.Drawing.Size(164, 22)
			cutToolStripMenuItem.Size = size
			Me.CutToolStripMenuItem.Text = "Cu&t"
			Me.CopyToolStripMenuItem.Image = CType(componentResourceManager.GetObject("CopyToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.CopyToolStripMenuItem.ImageTransparentColor = Global.System.Drawing.Color.Black
			Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
			Me.CopyToolStripMenuItem.ShortcutKeys = CType(131139, Global.System.Windows.Forms.Keys)
			Dim copyToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.CopyToolStripMenuItem
			size = New Global.System.Drawing.Size(164, 22)
			copyToolStripMenuItem.Size = size
			Me.CopyToolStripMenuItem.Text = "&Copy"
			Me.PasteToolStripMenuItem.Image = CType(componentResourceManager.GetObject("PasteToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.PasteToolStripMenuItem.ImageTransparentColor = Global.System.Drawing.Color.Black
			Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
			Me.PasteToolStripMenuItem.ShortcutKeys = CType(131158, Global.System.Windows.Forms.Keys)
			Dim pasteToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.PasteToolStripMenuItem
			size = New Global.System.Drawing.Size(164, 22)
			pasteToolStripMenuItem.Size = size
			Me.PasteToolStripMenuItem.Text = "&Paste"
			Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
			Dim toolStripSeparator7 As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripSeparator5
			size = New Global.System.Drawing.Size(161, 6)
			toolStripSeparator7.Size = size
			Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
			Me.SelectAllToolStripMenuItem.ShortcutKeys = CType(131137, Global.System.Windows.Forms.Keys)
			Dim selectAllToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.SelectAllToolStripMenuItem
			size = New Global.System.Drawing.Size(164, 22)
			selectAllToolStripMenuItem.Size = size
			Me.SelectAllToolStripMenuItem.Text = "Select &All"
			Me.ViewToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.ToolBarToolStripMenuItem, Me.StatusBarToolStripMenuItem, Me.FoldersToolStripMenuItem })
			Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
			Dim viewToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.ViewToolStripMenuItem
			size = New Global.System.Drawing.Size(44, 20)
			viewToolStripMenuItem.Size = size
			Me.ViewToolStripMenuItem.Text = "&View"
			Me.ToolBarToolStripMenuItem.Checked = True
			Me.ToolBarToolStripMenuItem.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.ToolBarToolStripMenuItem.Name = "ToolBarToolStripMenuItem"
			Dim toolBarToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.ToolBarToolStripMenuItem
			size = New Global.System.Drawing.Size(126, 22)
			toolBarToolStripMenuItem.Size = size
			Me.ToolBarToolStripMenuItem.Text = "&Toolbar"
			Me.StatusBarToolStripMenuItem.Checked = True
			Me.StatusBarToolStripMenuItem.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
			Dim statusBarToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.StatusBarToolStripMenuItem
			size = New Global.System.Drawing.Size(126, 22)
			statusBarToolStripMenuItem.Size = size
			Me.StatusBarToolStripMenuItem.Text = "&Status Bar"
			Me.FoldersToolStripMenuItem.Checked = True
			Me.FoldersToolStripMenuItem.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.FoldersToolStripMenuItem.Name = "FoldersToolStripMenuItem"
			Dim foldersToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.FoldersToolStripMenuItem
			size = New Global.System.Drawing.Size(126, 22)
			foldersToolStripMenuItem.Size = size
			Me.FoldersToolStripMenuItem.Text = "&Folders"
			Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.OptionsToolStripMenuItem })
			Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
			Dim toolsToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.ToolsToolStripMenuItem
			size = New Global.System.Drawing.Size(48, 20)
			toolsToolStripMenuItem.Size = size
			Me.ToolsToolStripMenuItem.Text = "&Tools"
			Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
			Dim optionsToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.OptionsToolStripMenuItem
			size = New Global.System.Drawing.Size(116, 22)
			optionsToolStripMenuItem.Size = size
			Me.OptionsToolStripMenuItem.Text = "&Options"
			Me.HelpToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ToolStripSeparator6, Me.AboutToolStripMenuItem })
			Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
			Dim helpToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.HelpToolStripMenuItem
			size = New Global.System.Drawing.Size(44, 20)
			helpToolStripMenuItem.Size = size
			Me.HelpToolStripMenuItem.Text = "&Help"
			Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
			Me.ContentsToolStripMenuItem.ShortcutKeys = CType(131184, Global.System.Windows.Forms.Keys)
			Dim contentsToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.ContentsToolStripMenuItem
			size = New Global.System.Drawing.Size(168, 22)
			contentsToolStripMenuItem.Size = size
			Me.ContentsToolStripMenuItem.Text = "&Contents"
			Me.IndexToolStripMenuItem.Image = CType(componentResourceManager.GetObject("IndexToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.IndexToolStripMenuItem.ImageTransparentColor = Global.System.Drawing.Color.Black
			Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
			Dim indexToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.IndexToolStripMenuItem
			size = New Global.System.Drawing.Size(168, 22)
			indexToolStripMenuItem.Size = size
			Me.IndexToolStripMenuItem.Text = "&Index"
			Me.SearchToolStripMenuItem.Image = CType(componentResourceManager.GetObject("SearchToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.SearchToolStripMenuItem.ImageTransparentColor = Global.System.Drawing.Color.Black
			Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
			Dim searchToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.SearchToolStripMenuItem
			size = New Global.System.Drawing.Size(168, 22)
			searchToolStripMenuItem.Size = size
			Me.SearchToolStripMenuItem.Text = "&Search"
			Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
			Dim toolStripSeparator8 As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripSeparator6
			size = New Global.System.Drawing.Size(165, 6)
			toolStripSeparator8.Size = size
			Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
			Dim aboutToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.AboutToolStripMenuItem
			size = New Global.System.Drawing.Size(168, 22)
			aboutToolStripMenuItem.Size = size
			Me.AboutToolStripMenuItem.Text = "&About ..."
			Me.ToolStripContainer.BottomToolStripPanel.Controls.Add(Me.StatusStrip)
			Me.ToolStripContainer.ContentPanel.Controls.Add(Me.RichTextBox1)
			Dim contentPanel As Global.System.Windows.Forms.Control = Me.ToolStripContainer.ContentPanel
			size = New Global.System.Drawing.Size(632, 382)
			contentPanel.Size = size
			Me.ToolStripContainer.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim toolStripContainer As Global.System.Windows.Forms.Control = Me.ToolStripContainer
			point = New Global.System.Drawing.Point(0, 0)
			toolStripContainer.Location = point
			Me.ToolStripContainer.Name = "ToolStripContainer"
			Dim toolStripContainer2 As Global.System.Windows.Forms.Control = Me.ToolStripContainer
			size = New Global.System.Drawing.Size(632, 453)
			toolStripContainer2.Size = size
			Me.ToolStripContainer.TabIndex = 7
			Me.ToolStripContainer.Text = "ToolStripContainer1"
			Me.ToolStripContainer.TopToolStripPanel.Controls.Add(Me.MenuStrip)
			Me.ToolStripContainer.TopToolStripPanel.Controls.Add(Me.ToolStrip)
			Me.ListViewLargeImageList.ImageStream = CType(componentResourceManager.GetObject("ListViewLargeImageList.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.ListViewLargeImageList.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.ListViewLargeImageList.Images.SetKeyName(0, "Graph1")
			Me.ListViewLargeImageList.Images.SetKeyName(1, "Graph2")
			Me.ListViewLargeImageList.Images.SetKeyName(2, "Graph3")
			Me.ListViewSmallImageList.ImageStream = CType(componentResourceManager.GetObject("ListViewSmallImageList.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.ListViewSmallImageList.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.ListViewSmallImageList.Images.SetKeyName(0, "Graph1")
			Me.ListViewSmallImageList.Images.SetKeyName(1, "Graph2")
			Me.ListViewSmallImageList.Images.SetKeyName(2, "Graph3")
			Dim richTextBox As Global.System.Windows.Forms.Control = Me.RichTextBox1
			point = New Global.System.Drawing.Point(3, 3)
			richTextBox.Location = point
			Me.RichTextBox1.Name = "RichTextBox1"
			Dim richTextBox2 As Global.System.Windows.Forms.Control = Me.RichTextBox1
			size = New Global.System.Drawing.Size(617, 376)
			richTextBox2.Size = size
			Me.RichTextBox1.TabIndex = 0
			Me.RichTextBox1.Text = ""
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(632, 453)
			Me.ClientSize = size
			Me.Controls.Add(Me.ToolStripContainer)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.Name = "Explorer2"
			Me.Text = "Sebs SW E"
			Me.StatusStrip.ResumeLayout(False)
			Me.StatusStrip.PerformLayout()
			Me.ToolStrip.ResumeLayout(False)
			Me.ToolStrip.PerformLayout()
			Me.MenuStrip.ResumeLayout(False)
			Me.MenuStrip.PerformLayout()
			Me.ToolStripContainer.BottomToolStripPanel.ResumeLayout(False)
			Me.ToolStripContainer.BottomToolStripPanel.PerformLayout()
			Me.ToolStripContainer.ContentPanel.ResumeLayout(False)
			Me.ToolStripContainer.TopToolStripPanel.ResumeLayout(False)
			Me.ToolStripContainer.TopToolStripPanel.PerformLayout()
			Me.ToolStripContainer.ResumeLayout(False)
			Me.ToolStripContainer.PerformLayout()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x040001BA RID: 442
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
