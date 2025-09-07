Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports CV.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x02000030 RID: 48
	<DesignerGenerated()>
	Public Partial Class Explorer1
		Inherits Form

		' Token: 0x0600035C RID: 860 RVA: 0x03D8EEC0 File Offset: 0x03D8D2C0
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Explorer1_Load
			Dim _ENCList As List(Of WeakReference) = Explorer1.__ENCList
			SyncLock _ENCList
				Explorer1.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000110 RID: 272
		' (get) Token: 0x0600035E RID: 862 RVA: 0x03D8EF7C File Offset: 0x03D8D37C
		' (set) Token: 0x0600035F RID: 863 RVA: 0x03D8EF94 File Offset: 0x03D8D394
		Friend Overridable Property ToolStripContainer As ToolStripContainer
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripContainer
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripContainer)
				Me._ToolStripContainer = value
			End Set
		End Property

		' Token: 0x17000111 RID: 273
		' (get) Token: 0x06000360 RID: 864 RVA: 0x03D8EFA0 File Offset: 0x03D8D3A0
		' (set) Token: 0x06000361 RID: 865 RVA: 0x03D8EFB8 File Offset: 0x03D8D3B8
		Friend Overridable Property TreeNodeImageList As ImageList
			<DebuggerNonUserCode()>
			Get
				Return Me._TreeNodeImageList
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._TreeNodeImageList = value
			End Set
		End Property

		' Token: 0x17000112 RID: 274
		' (get) Token: 0x06000362 RID: 866 RVA: 0x03D8EFC4 File Offset: 0x03D8D3C4
		' (set) Token: 0x06000363 RID: 867 RVA: 0x03D8EFDC File Offset: 0x03D8D3DC
		Friend Overridable Property ToolStripSeparator7 As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripSeparator7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator7 = value
			End Set
		End Property

		' Token: 0x17000113 RID: 275
		' (get) Token: 0x06000364 RID: 868 RVA: 0x03D8EFE8 File Offset: 0x03D8D3E8
		' (set) Token: 0x06000365 RID: 869 RVA: 0x03D8F000 File Offset: 0x03D8D400
		Friend Overridable Property ToolStripSeparator8 As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripSeparator8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator8 = value
			End Set
		End Property

		' Token: 0x17000114 RID: 276
		' (get) Token: 0x06000366 RID: 870 RVA: 0x03D8F00C File Offset: 0x03D8D40C
		' (set) Token: 0x06000367 RID: 871 RVA: 0x03D8F024 File Offset: 0x03D8D424
		Friend Overridable Property ToolStrip As ToolStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStrip
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStrip)
				Me._ToolStrip = value
			End Set
		End Property

		' Token: 0x17000115 RID: 277
		' (get) Token: 0x06000368 RID: 872 RVA: 0x03D8F030 File Offset: 0x03D8D430
		' (set) Token: 0x06000369 RID: 873 RVA: 0x03D8F048 File Offset: 0x03D8D448
		Friend Overridable Property BackToolStripButton As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._BackToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Me._BackToolStripButton = value
			End Set
		End Property

		' Token: 0x17000116 RID: 278
		' (get) Token: 0x0600036A RID: 874 RVA: 0x03D8F054 File Offset: 0x03D8D454
		' (set) Token: 0x0600036B RID: 875 RVA: 0x03D8F06C File Offset: 0x03D8D46C
		Friend Overridable Property ForwardToolStripButton As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._ForwardToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Me._ForwardToolStripButton = value
			End Set
		End Property

		' Token: 0x17000117 RID: 279
		' (get) Token: 0x0600036C RID: 876 RVA: 0x03D8F078 File Offset: 0x03D8D478
		' (set) Token: 0x0600036D RID: 877 RVA: 0x03D8F090 File Offset: 0x03D8D490
		Friend Overridable Property FoldersToolStripButton As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._FoldersToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim eventHandler As EventHandler = AddressOf Me.FoldersToolStripButton_Click
				Dim flag As Boolean = Me._FoldersToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._FoldersToolStripButton.Click, eventHandler
				End If
				Me._FoldersToolStripButton = value
				flag = Me._FoldersToolStripButton IsNot Nothing
				If flag Then
					AddHandler Me._FoldersToolStripButton.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000118 RID: 280
		' (get) Token: 0x0600036E RID: 878 RVA: 0x03D8F0F0 File Offset: 0x03D8D4F0
		' (set) Token: 0x0600036F RID: 879 RVA: 0x03D8F108 File Offset: 0x03D8D508
		Friend Overridable Property ListViewToolStripButton As ToolStripDropDownButton
			<DebuggerNonUserCode()>
			Get
				Return Me._ListViewToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripDropDownButton)
				Me._ListViewToolStripButton = value
			End Set
		End Property

		' Token: 0x17000119 RID: 281
		' (get) Token: 0x06000370 RID: 880 RVA: 0x03D8F114 File Offset: 0x03D8D514
		' (set) Token: 0x06000371 RID: 881 RVA: 0x03D8F12C File Offset: 0x03D8D52C
		Friend Overridable Property ListToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ListToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.ListToolStripMenuItem_Click
				Dim flag As Boolean = Me._ListToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._ListToolStripMenuItem.Click, eventHandler
				End If
				Me._ListToolStripMenuItem = value
				flag = Me._ListToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._ListToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700011A RID: 282
		' (get) Token: 0x06000372 RID: 882 RVA: 0x03D8F18C File Offset: 0x03D8D58C
		' (set) Token: 0x06000373 RID: 883 RVA: 0x03D8F1A4 File Offset: 0x03D8D5A4
		Friend Overridable Property DetailsToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._DetailsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.DetailsToolStripMenuItem_Click
				Dim flag As Boolean = Me._DetailsToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._DetailsToolStripMenuItem.Click, eventHandler
				End If
				Me._DetailsToolStripMenuItem = value
				flag = Me._DetailsToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._DetailsToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700011B RID: 283
		' (get) Token: 0x06000374 RID: 884 RVA: 0x03D8F204 File Offset: 0x03D8D604
		' (set) Token: 0x06000375 RID: 885 RVA: 0x03D8F21C File Offset: 0x03D8D61C
		Friend Overridable Property LargeIconsToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._LargeIconsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.LargeIconsToolStripMenuItem_Click
				Dim flag As Boolean = Me._LargeIconsToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._LargeIconsToolStripMenuItem.Click, eventHandler
				End If
				Me._LargeIconsToolStripMenuItem = value
				flag = Me._LargeIconsToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._LargeIconsToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700011C RID: 284
		' (get) Token: 0x06000376 RID: 886 RVA: 0x03D8F27C File Offset: 0x03D8D67C
		' (set) Token: 0x06000377 RID: 887 RVA: 0x03D8F294 File Offset: 0x03D8D694
		Friend Overridable Property SmallIconsToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SmallIconsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.SmallIconsToolStripMenuItem_Click
				Dim flag As Boolean = Me._SmallIconsToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._SmallIconsToolStripMenuItem.Click, eventHandler
				End If
				Me._SmallIconsToolStripMenuItem = value
				flag = Me._SmallIconsToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._SmallIconsToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700011D RID: 285
		' (get) Token: 0x06000378 RID: 888 RVA: 0x03D8F2F4 File Offset: 0x03D8D6F4
		' (set) Token: 0x06000379 RID: 889 RVA: 0x03D8F30C File Offset: 0x03D8D70C
		Friend Overridable Property TileToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._TileToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.TileToolStripMenuItem_Click
				Dim flag As Boolean = Me._TileToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._TileToolStripMenuItem.Click, eventHandler
				End If
				Me._TileToolStripMenuItem = value
				flag = Me._TileToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._TileToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700011E RID: 286
		' (get) Token: 0x0600037A RID: 890 RVA: 0x03D8F36C File Offset: 0x03D8D76C
		' (set) Token: 0x0600037B RID: 891 RVA: 0x03D8F384 File Offset: 0x03D8D784
		Friend Overridable Property MenuStrip As MenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuStrip
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuStrip)
				Me._MenuStrip = value
			End Set
		End Property

		' Token: 0x1700011F RID: 287
		' (get) Token: 0x0600037C RID: 892 RVA: 0x03D8F390 File Offset: 0x03D8D790
		' (set) Token: 0x0600037D RID: 893 RVA: 0x03D8F3A8 File Offset: 0x03D8D7A8
		Friend Overridable Property FileToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FileToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._FileToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000120 RID: 288
		' (get) Token: 0x0600037E RID: 894 RVA: 0x03D8F3B4 File Offset: 0x03D8D7B4
		' (set) Token: 0x0600037F RID: 895 RVA: 0x03D8F3CC File Offset: 0x03D8D7CC
		Friend Overridable Property NewToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._NewToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.NewToolStripMenuItem_Click
				Dim flag As Boolean = Me._NewToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._NewToolStripMenuItem.Click, eventHandler
				End If
				Me._NewToolStripMenuItem = value
				flag = Me._NewToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._NewToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000121 RID: 289
		' (get) Token: 0x06000380 RID: 896 RVA: 0x03D8F42C File Offset: 0x03D8D82C
		' (set) Token: 0x06000381 RID: 897 RVA: 0x03D8F444 File Offset: 0x03D8D844
		Friend Overridable Property OpenToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.OpenToolStripMenuItem_Click
				Dim flag As Boolean = Me._OpenToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._OpenToolStripMenuItem.Click, eventHandler
				End If
				Me._OpenToolStripMenuItem = value
				flag = Me._OpenToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._OpenToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000122 RID: 290
		' (get) Token: 0x06000382 RID: 898 RVA: 0x03D8F4A4 File Offset: 0x03D8D8A4
		' (set) Token: 0x06000383 RID: 899 RVA: 0x03D8F4BC File Offset: 0x03D8D8BC
		Friend Overridable Property ToolStripSeparator1 As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripSeparator1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator1 = value
			End Set
		End Property

		' Token: 0x17000123 RID: 291
		' (get) Token: 0x06000384 RID: 900 RVA: 0x03D8F4C8 File Offset: 0x03D8D8C8
		' (set) Token: 0x06000385 RID: 901 RVA: 0x03D8F4E0 File Offset: 0x03D8D8E0
		Friend Overridable Property SaveToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SaveToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._SaveToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000124 RID: 292
		' (get) Token: 0x06000386 RID: 902 RVA: 0x03D8F4EC File Offset: 0x03D8D8EC
		' (set) Token: 0x06000387 RID: 903 RVA: 0x03D8F504 File Offset: 0x03D8D904
		Friend Overridable Property SaveAsToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SaveAsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.SaveAsToolStripMenuItem_Click
				Dim flag As Boolean = Me._SaveAsToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._SaveAsToolStripMenuItem.Click, eventHandler
				End If
				Me._SaveAsToolStripMenuItem = value
				flag = Me._SaveAsToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._SaveAsToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000125 RID: 293
		' (get) Token: 0x06000388 RID: 904 RVA: 0x03D8F564 File Offset: 0x03D8D964
		' (set) Token: 0x06000389 RID: 905 RVA: 0x03D8F57C File Offset: 0x03D8D97C
		Friend Overridable Property ToolStripSeparator2 As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripSeparator2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator2 = value
			End Set
		End Property

		' Token: 0x17000126 RID: 294
		' (get) Token: 0x0600038A RID: 906 RVA: 0x03D8F588 File Offset: 0x03D8D988
		' (set) Token: 0x0600038B RID: 907 RVA: 0x03D8F5A0 File Offset: 0x03D8D9A0
		Friend Overridable Property PrintToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._PrintToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._PrintToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000127 RID: 295
		' (get) Token: 0x0600038C RID: 908 RVA: 0x03D8F5AC File Offset: 0x03D8D9AC
		' (set) Token: 0x0600038D RID: 909 RVA: 0x03D8F5C4 File Offset: 0x03D8D9C4
		Friend Overridable Property PrintPreviewToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._PrintPreviewToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._PrintPreviewToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000128 RID: 296
		' (get) Token: 0x0600038E RID: 910 RVA: 0x03D8F5D0 File Offset: 0x03D8D9D0
		' (set) Token: 0x0600038F RID: 911 RVA: 0x03D8F5E8 File Offset: 0x03D8D9E8
		Friend Overridable Property ToolStripSeparator3 As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripSeparator3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator3 = value
			End Set
		End Property

		' Token: 0x17000129 RID: 297
		' (get) Token: 0x06000390 RID: 912 RVA: 0x03D8F5F4 File Offset: 0x03D8D9F4
		' (set) Token: 0x06000391 RID: 913 RVA: 0x03D8F60C File Offset: 0x03D8DA0C
		Friend Overridable Property ExitToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ExitToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.ExitToolStripMenuItem_Click
				Dim flag As Boolean = Me._ExitToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._ExitToolStripMenuItem.Click, eventHandler
				End If
				Me._ExitToolStripMenuItem = value
				flag = Me._ExitToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._ExitToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700012A RID: 298
		' (get) Token: 0x06000392 RID: 914 RVA: 0x03D8F66C File Offset: 0x03D8DA6C
		' (set) Token: 0x06000393 RID: 915 RVA: 0x03D8F684 File Offset: 0x03D8DA84
		Friend Overridable Property EditToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._EditToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._EditToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x1700012B RID: 299
		' (get) Token: 0x06000394 RID: 916 RVA: 0x03D8F690 File Offset: 0x03D8DA90
		' (set) Token: 0x06000395 RID: 917 RVA: 0x03D8F6A8 File Offset: 0x03D8DAA8
		Friend Overridable Property UndoToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._UndoToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._UndoToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x1700012C RID: 300
		' (get) Token: 0x06000396 RID: 918 RVA: 0x03D8F6B4 File Offset: 0x03D8DAB4
		' (set) Token: 0x06000397 RID: 919 RVA: 0x03D8F6CC File Offset: 0x03D8DACC
		Friend Overridable Property RedoToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RedoToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._RedoToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x1700012D RID: 301
		' (get) Token: 0x06000398 RID: 920 RVA: 0x03D8F6D8 File Offset: 0x03D8DAD8
		' (set) Token: 0x06000399 RID: 921 RVA: 0x03D8F6F0 File Offset: 0x03D8DAF0
		Friend Overridable Property ToolStripSeparator4 As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripSeparator4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator4 = value
			End Set
		End Property

		' Token: 0x1700012E RID: 302
		' (get) Token: 0x0600039A RID: 922 RVA: 0x03D8F6FC File Offset: 0x03D8DAFC
		' (set) Token: 0x0600039B RID: 923 RVA: 0x03D8F714 File Offset: 0x03D8DB14
		Friend Overridable Property CutToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CutToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._CutToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x1700012F RID: 303
		' (get) Token: 0x0600039C RID: 924 RVA: 0x03D8F720 File Offset: 0x03D8DB20
		' (set) Token: 0x0600039D RID: 925 RVA: 0x03D8F738 File Offset: 0x03D8DB38
		Friend Overridable Property CopyToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CopyToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._CopyToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000130 RID: 304
		' (get) Token: 0x0600039E RID: 926 RVA: 0x03D8F744 File Offset: 0x03D8DB44
		' (set) Token: 0x0600039F RID: 927 RVA: 0x03D8F75C File Offset: 0x03D8DB5C
		Friend Overridable Property PasteToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._PasteToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._PasteToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000131 RID: 305
		' (get) Token: 0x060003A0 RID: 928 RVA: 0x03D8F768 File Offset: 0x03D8DB68
		' (set) Token: 0x060003A1 RID: 929 RVA: 0x03D8F780 File Offset: 0x03D8DB80
		Friend Overridable Property ToolStripSeparator5 As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripSeparator5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator5 = value
			End Set
		End Property

		' Token: 0x17000132 RID: 306
		' (get) Token: 0x060003A2 RID: 930 RVA: 0x03D8F78C File Offset: 0x03D8DB8C
		' (set) Token: 0x060003A3 RID: 931 RVA: 0x03D8F7A4 File Offset: 0x03D8DBA4
		Friend Overridable Property SelectAllToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SelectAllToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._SelectAllToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000133 RID: 307
		' (get) Token: 0x060003A4 RID: 932 RVA: 0x03D8F7B0 File Offset: 0x03D8DBB0
		' (set) Token: 0x060003A5 RID: 933 RVA: 0x03D8F7C8 File Offset: 0x03D8DBC8
		Friend Overridable Property ViewToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ViewToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._ViewToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000134 RID: 308
		' (get) Token: 0x060003A6 RID: 934 RVA: 0x03D8F7D4 File Offset: 0x03D8DBD4
		' (set) Token: 0x060003A7 RID: 935 RVA: 0x03D8F7EC File Offset: 0x03D8DBEC
		Friend Overridable Property ToolBarToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolBarToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.ToolBarToolStripMenuItem_Click
				Dim flag As Boolean = Me._ToolBarToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._ToolBarToolStripMenuItem.Click, eventHandler
				End If
				Me._ToolBarToolStripMenuItem = value
				flag = Me._ToolBarToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._ToolBarToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000135 RID: 309
		' (get) Token: 0x060003A8 RID: 936 RVA: 0x03D8F84C File Offset: 0x03D8DC4C
		' (set) Token: 0x060003A9 RID: 937 RVA: 0x03D8F864 File Offset: 0x03D8DC64
		Friend Overridable Property StatusBarToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._StatusBarToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.StatusBarToolStripMenuItem_Click
				Dim flag As Boolean = Me._StatusBarToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._StatusBarToolStripMenuItem.Click, eventHandler
				End If
				Me._StatusBarToolStripMenuItem = value
				flag = Me._StatusBarToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._StatusBarToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000136 RID: 310
		' (get) Token: 0x060003AA RID: 938 RVA: 0x03D8F8C4 File Offset: 0x03D8DCC4
		' (set) Token: 0x060003AB RID: 939 RVA: 0x03D8F8DC File Offset: 0x03D8DCDC
		Friend Overridable Property FoldersToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FoldersToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.FoldersToolStripMenuItem_Click
				Dim flag As Boolean = Me._FoldersToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._FoldersToolStripMenuItem.Click, eventHandler
				End If
				Me._FoldersToolStripMenuItem = value
				flag = Me._FoldersToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._FoldersToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000137 RID: 311
		' (get) Token: 0x060003AC RID: 940 RVA: 0x03D8F93C File Offset: 0x03D8DD3C
		' (set) Token: 0x060003AD RID: 941 RVA: 0x03D8F954 File Offset: 0x03D8DD54
		Friend Overridable Property ToolsToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._ToolsToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000138 RID: 312
		' (get) Token: 0x060003AE RID: 942 RVA: 0x03D8F960 File Offset: 0x03D8DD60
		' (set) Token: 0x060003AF RID: 943 RVA: 0x03D8F978 File Offset: 0x03D8DD78
		Friend Overridable Property OptionsToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._OptionsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._OptionsToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000139 RID: 313
		' (get) Token: 0x060003B0 RID: 944 RVA: 0x03D8F984 File Offset: 0x03D8DD84
		' (set) Token: 0x060003B1 RID: 945 RVA: 0x03D8F99C File Offset: 0x03D8DD9C
		Friend Overridable Property HelpToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._HelpToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._HelpToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x1700013A RID: 314
		' (get) Token: 0x060003B2 RID: 946 RVA: 0x03D8F9A8 File Offset: 0x03D8DDA8
		' (set) Token: 0x060003B3 RID: 947 RVA: 0x03D8F9C0 File Offset: 0x03D8DDC0
		Friend Overridable Property ContentsToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ContentsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._ContentsToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x1700013B RID: 315
		' (get) Token: 0x060003B4 RID: 948 RVA: 0x03D8F9CC File Offset: 0x03D8DDCC
		' (set) Token: 0x060003B5 RID: 949 RVA: 0x03D8F9E4 File Offset: 0x03D8DDE4
		Friend Overridable Property IndexToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._IndexToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._IndexToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x1700013C RID: 316
		' (get) Token: 0x060003B6 RID: 950 RVA: 0x03D8F9F0 File Offset: 0x03D8DDF0
		' (set) Token: 0x060003B7 RID: 951 RVA: 0x03D8FA08 File Offset: 0x03D8DE08
		Friend Overridable Property SearchToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SearchToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._SearchToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x1700013D RID: 317
		' (get) Token: 0x060003B8 RID: 952 RVA: 0x03D8FA14 File Offset: 0x03D8DE14
		' (set) Token: 0x060003B9 RID: 953 RVA: 0x03D8FA2C File Offset: 0x03D8DE2C
		Friend Overridable Property ToolStripSeparator6 As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripSeparator6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator6 = value
			End Set
		End Property

		' Token: 0x1700013E RID: 318
		' (get) Token: 0x060003BA RID: 954 RVA: 0x03D8FA38 File Offset: 0x03D8DE38
		' (set) Token: 0x060003BB RID: 955 RVA: 0x03D8FA50 File Offset: 0x03D8DE50
		Friend Overridable Property AboutToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._AboutToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.AboutToolStripMenuItem_Click
				Dim flag As Boolean = Me._AboutToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._AboutToolStripMenuItem.Click, eventHandler
				End If
				Me._AboutToolStripMenuItem = value
				flag = Me._AboutToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._AboutToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700013F RID: 319
		' (get) Token: 0x060003BC RID: 956 RVA: 0x03D8FAB0 File Offset: 0x03D8DEB0
		' (set) Token: 0x060003BD RID: 957 RVA: 0x03D8FAC8 File Offset: 0x03D8DEC8
		Friend Overridable Property SplitContainer As SplitContainer
			<DebuggerNonUserCode()>
			Get
				Return Me._SplitContainer
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As SplitContainer)
				Me._SplitContainer = value
			End Set
		End Property

		' Token: 0x17000140 RID: 320
		' (get) Token: 0x060003BE RID: 958 RVA: 0x03D8FAD4 File Offset: 0x03D8DED4
		' (set) Token: 0x060003BF RID: 959 RVA: 0x03D8FAEC File Offset: 0x03D8DEEC
		Friend Overridable Property TreeView As TreeView
			<DebuggerNonUserCode()>
			Get
				Return Me._TreeView
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TreeView)
				Dim treeViewEventHandler As TreeViewEventHandler = AddressOf Me.TreeView_AfterSelect
				Dim flag As Boolean = Me._TreeView IsNot Nothing
				If flag Then
					RemoveHandler Me._TreeView.AfterSelect, treeViewEventHandler
				End If
				Me._TreeView = value
				flag = Me._TreeView IsNot Nothing
				If flag Then
					AddHandler Me._TreeView.AfterSelect, treeViewEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000141 RID: 321
		' (get) Token: 0x060003C0 RID: 960 RVA: 0x03D8FB4C File Offset: 0x03D8DF4C
		' (set) Token: 0x060003C1 RID: 961 RVA: 0x03D8FB64 File Offset: 0x03D8DF64
		Friend Overridable Property ListView As ListView
			<DebuggerNonUserCode()>
			Get
				Return Me._ListView
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListView)
				Me._ListView = value
			End Set
		End Property

		' Token: 0x17000142 RID: 322
		' (get) Token: 0x060003C2 RID: 962 RVA: 0x03D8FB70 File Offset: 0x03D8DF70
		' (set) Token: 0x060003C3 RID: 963 RVA: 0x03D8FB88 File Offset: 0x03D8DF88
		Friend Overridable Property StatusStrip As StatusStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._StatusStrip
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As StatusStrip)
				Me._StatusStrip = value
			End Set
		End Property

		' Token: 0x17000143 RID: 323
		' (get) Token: 0x060003C4 RID: 964 RVA: 0x03D8FB94 File Offset: 0x03D8DF94
		' (set) Token: 0x060003C5 RID: 965 RVA: 0x03D8FBAC File Offset: 0x03D8DFAC
		Friend Overridable Property ToolStripStatusLabel As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripStatusLabel
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._ToolStripStatusLabel = value
			End Set
		End Property

		' Token: 0x17000144 RID: 324
		' (get) Token: 0x060003C6 RID: 966 RVA: 0x03D8FBB8 File Offset: 0x03D8DFB8
		' (set) Token: 0x060003C7 RID: 967 RVA: 0x03D8FBD0 File Offset: 0x03D8DFD0
		Friend Overridable Property ToolTip As ToolTip
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolTip
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolTip)
				Me._ToolTip = value
			End Set
		End Property

		' Token: 0x17000145 RID: 325
		' (get) Token: 0x060003C8 RID: 968 RVA: 0x03D8FBDC File Offset: 0x03D8DFDC
		' (set) Token: 0x060003C9 RID: 969 RVA: 0x03D8FBF4 File Offset: 0x03D8DFF4
		Friend Overridable Property ListViewLargeImageList As ImageList
			<DebuggerNonUserCode()>
			Get
				Return Me._ListViewLargeImageList
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._ListViewLargeImageList = value
			End Set
		End Property

		' Token: 0x17000146 RID: 326
		' (get) Token: 0x060003CA RID: 970 RVA: 0x03D8FC00 File Offset: 0x03D8E000
		' (set) Token: 0x060003CB RID: 971 RVA: 0x03D8FC18 File Offset: 0x03D8E018
		Friend Overridable Property ListViewSmallImageList As ImageList
			<DebuggerNonUserCode()>
			Get
				Return Me._ListViewSmallImageList
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._ListViewSmallImageList = value
			End Set
		End Property

		' Token: 0x17000147 RID: 327
		' (get) Token: 0x060003CD RID: 973 RVA: 0x03D917CC File Offset: 0x03D8FBCC
		' (set) Token: 0x060003CE RID: 974 RVA: 0x03D917E4 File Offset: 0x03D8FBE4
		Friend Overridable Property TheWebToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._TheWebToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.TheWebToolStripMenuItem_Click
				Dim flag As Boolean = Me._TheWebToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._TheWebToolStripMenuItem.Click, eventHandler
				End If
				Me._TheWebToolStripMenuItem = value
				flag = Me._TheWebToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._TheWebToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x060003CF RID: 975 RVA: 0x03D91844 File Offset: 0x03D8FC44
		Private Sub Explorer1_Load(sender As Object, e As EventArgs)
			Me.SetUpListViewColumns()
			Me.LoadTree()
		End Sub

		' Token: 0x060003D0 RID: 976 RVA: 0x03D91858 File Offset: 0x03D8FC58
		Private Sub LoadTree()
			Dim treeNode As TreeNode = Me.TreeView.Nodes.Add("Root")
			Dim treeNode2 As TreeNode = treeNode.Nodes.Add("TreeItem1")
			treeNode2 = treeNode.Nodes.Add("TreeItem2")
			treeNode2 = treeNode.Nodes.Add("TreeItem3")
		End Sub

		' Token: 0x060003D1 RID: 977 RVA: 0x03D918B0 File Offset: 0x03D8FCB0
		Private Sub LoadListView()
			Me.ListView.Items.Clear()
			Dim listViewItem As ListViewItem = Me.ListView.Items.Add("ListViewItem1")
			listViewItem.ImageKey = "Graph1"
			listViewItem.SubItems.AddRange(New String() { "Column2", "Column3" })
			listViewItem = Me.ListView.Items.Add("ListViewItem2")
			listViewItem.ImageKey = "Graph2"
			listViewItem.SubItems.AddRange(New String() { "Column2", "Column3" })
			listViewItem = Me.ListView.Items.Add("ListViewItem3")
			listViewItem.ImageKey = "Graph3"
			listViewItem.SubItems.AddRange(New String() { "Column2", "Column3" })
		End Sub

		' Token: 0x060003D2 RID: 978 RVA: 0x03D919A8 File Offset: 0x03D8FDA8
		Private Sub SetUpListViewColumns()
			Me.SetView(View.SmallIcon)
			Dim columnHeader As ColumnHeader = Me.ListView.Columns.Add("Column1")
			columnHeader.Width = 90
			Me.SetView(View.Details)
			columnHeader.Width = 100
			columnHeader = Me.ListView.Columns.Add("Column2")
			columnHeader.Width = 70
			columnHeader = Me.ListView.Columns.Add("Column3")
			columnHeader.Width = 70
		End Sub

		' Token: 0x060003D3 RID: 979 RVA: 0x03D91A30 File Offset: 0x03D8FE30
		Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x060003D4 RID: 980 RVA: 0x03D91A3C File Offset: 0x03D8FE3C
		Private Sub ToolBarToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.ToolBarToolStripMenuItem.Checked = Not Me.ToolBarToolStripMenuItem.Checked
			Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
		End Sub

		' Token: 0x060003D5 RID: 981 RVA: 0x03D91A74 File Offset: 0x03D8FE74
		Private Sub StatusBarToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.StatusBarToolStripMenuItem.Checked = Not Me.StatusBarToolStripMenuItem.Checked
			Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
		End Sub

		' Token: 0x060003D6 RID: 982 RVA: 0x03D91AAC File Offset: 0x03D8FEAC
		Private Sub ToggleFoldersVisible()
			Me.FoldersToolStripMenuItem.Checked = Not Me.FoldersToolStripMenuItem.Checked
			Me.FoldersToolStripButton.Checked = Me.FoldersToolStripMenuItem.Checked
			Me.SplitContainer.Panel1Collapsed = Not Me.FoldersToolStripMenuItem.Checked
		End Sub

		' Token: 0x060003D7 RID: 983 RVA: 0x03D91B08 File Offset: 0x03D8FF08
		Private Sub FoldersToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.ToggleFoldersVisible()
		End Sub

		' Token: 0x060003D8 RID: 984 RVA: 0x03D91B14 File Offset: 0x03D8FF14
		Private Sub FoldersToolStripButton_Click(sender As Object, e As EventArgs)
			Me.ToggleFoldersVisible()
		End Sub

		' Token: 0x060003D9 RID: 985 RVA: 0x03D91B20 File Offset: 0x03D8FF20
		Private Sub SetView(View As View)
			Dim toolStripMenuItem As ToolStripMenuItem
			Select Case View
				Case View.LargeIcon
					toolStripMenuItem = Me.LargeIconsToolStripMenuItem
				Case View.Details
					toolStripMenuItem = Me.DetailsToolStripMenuItem
				Case View.SmallIcon
					toolStripMenuItem = Me.SmallIconsToolStripMenuItem
				Case View.List
					toolStripMenuItem = Me.ListToolStripMenuItem
				Case View.Tile
					toolStripMenuItem = Me.TileToolStripMenuItem
				Case Else
					Debug.Fail("Unexpected View")
					View = View.Details
					toolStripMenuItem = Me.DetailsToolStripMenuItem
			End Select
			Try
				For Each obj As Object In Me.ListViewToolStripButton.DropDownItems
					Dim toolStripMenuItem2 As ToolStripMenuItem = CType(obj, ToolStripMenuItem)
					Dim flag As Boolean = toolStripMenuItem2 Is toolStripMenuItem
					If flag Then
						toolStripMenuItem2.Checked = True
					Else
						toolStripMenuItem2.Checked = False
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Me.ListView.View = View
		End Sub

		' Token: 0x060003DA RID: 986 RVA: 0x03D91C28 File Offset: 0x03D90028
		Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.SetView(View.List)
		End Sub

		' Token: 0x060003DB RID: 987 RVA: 0x03D91C34 File Offset: 0x03D90034
		Private Sub DetailsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.SetView(View.Details)
		End Sub

		' Token: 0x060003DC RID: 988 RVA: 0x03D91C40 File Offset: 0x03D90040
		Private Sub LargeIconsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.SetView(View.LargeIcon)
		End Sub

		' Token: 0x060003DD RID: 989 RVA: 0x03D91C4C File Offset: 0x03D9004C
		Private Sub SmallIconsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.SetView(View.SmallIcon)
		End Sub

		' Token: 0x060003DE RID: 990 RVA: 0x03D91C58 File Offset: 0x03D90058
		Private Sub TileToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.SetView(View.Tile)
		End Sub

		' Token: 0x060003DF RID: 991 RVA: 0x03D91C64 File Offset: 0x03D90064
		Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			openFileDialog.InitialDirectory = MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments
			openFileDialog.Filter = "Text Files (*.txt)|*.txt"
			openFileDialog.ShowDialog(Me)
			Dim fileName As String = openFileDialog.FileName
		End Sub

		' Token: 0x060003E0 RID: 992 RVA: 0x03D91CB0 File Offset: 0x03D900B0
		Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
			saveFileDialog.InitialDirectory = MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments
			saveFileDialog.Filter = "Text Files (*.txt)|*.txt"
			saveFileDialog.ShowDialog(Me)
			Dim fileName As String = saveFileDialog.FileName
		End Sub

		' Token: 0x060003E1 RID: 993 RVA: 0x03D91CFC File Offset: 0x03D900FC
		Private Sub TreeView_AfterSelect(sender As Object, e As TreeViewEventArgs)
			Me.LoadListView()
		End Sub

		' Token: 0x060003E2 RID: 994 RVA: 0x03D91D08 File Offset: 0x03D90108
		Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form22.Show()
		End Sub

		' Token: 0x060003E3 RID: 995 RVA: 0x03D91D1C File Offset: 0x03D9011C
		Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060003E4 RID: 996 RVA: 0x03D91D20 File Offset: 0x03D90120
		Private Sub TheWebToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form35.Show()
		End Sub

		' Token: 0x0400014B RID: 331
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400014C RID: 332
		<AccessedThroughProperty("ToolStripContainer")>
		Private _ToolStripContainer As ToolStripContainer

		' Token: 0x0400014D RID: 333
		<AccessedThroughProperty("TreeNodeImageList")>
		Private _TreeNodeImageList As ImageList

		' Token: 0x0400014E RID: 334
		<AccessedThroughProperty("ToolStripSeparator7")>
		Private _ToolStripSeparator7 As ToolStripSeparator

		' Token: 0x0400014F RID: 335
		<AccessedThroughProperty("ToolStripSeparator8")>
		Private _ToolStripSeparator8 As ToolStripSeparator

		' Token: 0x04000150 RID: 336
		<AccessedThroughProperty("ToolStrip")>
		Private _ToolStrip As ToolStrip

		' Token: 0x04000151 RID: 337
		<AccessedThroughProperty("BackToolStripButton")>
		Private _BackToolStripButton As ToolStripButton

		' Token: 0x04000152 RID: 338
		<AccessedThroughProperty("ForwardToolStripButton")>
		Private _ForwardToolStripButton As ToolStripButton

		' Token: 0x04000153 RID: 339
		<AccessedThroughProperty("FoldersToolStripButton")>
		Private _FoldersToolStripButton As ToolStripButton

		' Token: 0x04000154 RID: 340
		<AccessedThroughProperty("ListViewToolStripButton")>
		Private _ListViewToolStripButton As ToolStripDropDownButton

		' Token: 0x04000155 RID: 341
		<AccessedThroughProperty("ListToolStripMenuItem")>
		Private _ListToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000156 RID: 342
		<AccessedThroughProperty("DetailsToolStripMenuItem")>
		Private _DetailsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000157 RID: 343
		<AccessedThroughProperty("LargeIconsToolStripMenuItem")>
		Private _LargeIconsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000158 RID: 344
		<AccessedThroughProperty("SmallIconsToolStripMenuItem")>
		Private _SmallIconsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000159 RID: 345
		<AccessedThroughProperty("TileToolStripMenuItem")>
		Private _TileToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400015A RID: 346
		<AccessedThroughProperty("MenuStrip")>
		Private _MenuStrip As MenuStrip

		' Token: 0x0400015B RID: 347
		<AccessedThroughProperty("FileToolStripMenuItem")>
		Private _FileToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400015C RID: 348
		<AccessedThroughProperty("NewToolStripMenuItem")>
		Private _NewToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400015D RID: 349
		<AccessedThroughProperty("OpenToolStripMenuItem")>
		Private _OpenToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400015E RID: 350
		<AccessedThroughProperty("ToolStripSeparator1")>
		Private _ToolStripSeparator1 As ToolStripSeparator

		' Token: 0x0400015F RID: 351
		<AccessedThroughProperty("SaveToolStripMenuItem")>
		Private _SaveToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000160 RID: 352
		<AccessedThroughProperty("SaveAsToolStripMenuItem")>
		Private _SaveAsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000161 RID: 353
		<AccessedThroughProperty("ToolStripSeparator2")>
		Private _ToolStripSeparator2 As ToolStripSeparator

		' Token: 0x04000162 RID: 354
		<AccessedThroughProperty("PrintToolStripMenuItem")>
		Private _PrintToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000163 RID: 355
		<AccessedThroughProperty("PrintPreviewToolStripMenuItem")>
		Private _PrintPreviewToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000164 RID: 356
		<AccessedThroughProperty("ToolStripSeparator3")>
		Private _ToolStripSeparator3 As ToolStripSeparator

		' Token: 0x04000165 RID: 357
		<AccessedThroughProperty("ExitToolStripMenuItem")>
		Private _ExitToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000166 RID: 358
		<AccessedThroughProperty("EditToolStripMenuItem")>
		Private _EditToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000167 RID: 359
		<AccessedThroughProperty("UndoToolStripMenuItem")>
		Private _UndoToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000168 RID: 360
		<AccessedThroughProperty("RedoToolStripMenuItem")>
		Private _RedoToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000169 RID: 361
		<AccessedThroughProperty("ToolStripSeparator4")>
		Private _ToolStripSeparator4 As ToolStripSeparator

		' Token: 0x0400016A RID: 362
		<AccessedThroughProperty("CutToolStripMenuItem")>
		Private _CutToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400016B RID: 363
		<AccessedThroughProperty("CopyToolStripMenuItem")>
		Private _CopyToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400016C RID: 364
		<AccessedThroughProperty("PasteToolStripMenuItem")>
		Private _PasteToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400016D RID: 365
		<AccessedThroughProperty("ToolStripSeparator5")>
		Private _ToolStripSeparator5 As ToolStripSeparator

		' Token: 0x0400016E RID: 366
		<AccessedThroughProperty("SelectAllToolStripMenuItem")>
		Private _SelectAllToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400016F RID: 367
		<AccessedThroughProperty("ViewToolStripMenuItem")>
		Private _ViewToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000170 RID: 368
		<AccessedThroughProperty("ToolBarToolStripMenuItem")>
		Private _ToolBarToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000171 RID: 369
		<AccessedThroughProperty("StatusBarToolStripMenuItem")>
		Private _StatusBarToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000172 RID: 370
		<AccessedThroughProperty("FoldersToolStripMenuItem")>
		Private _FoldersToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000173 RID: 371
		<AccessedThroughProperty("ToolsToolStripMenuItem")>
		Private _ToolsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000174 RID: 372
		<AccessedThroughProperty("OptionsToolStripMenuItem")>
		Private _OptionsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000175 RID: 373
		<AccessedThroughProperty("HelpToolStripMenuItem")>
		Private _HelpToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000176 RID: 374
		<AccessedThroughProperty("ContentsToolStripMenuItem")>
		Private _ContentsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000177 RID: 375
		<AccessedThroughProperty("IndexToolStripMenuItem")>
		Private _IndexToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000178 RID: 376
		<AccessedThroughProperty("SearchToolStripMenuItem")>
		Private _SearchToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000179 RID: 377
		<AccessedThroughProperty("ToolStripSeparator6")>
		Private _ToolStripSeparator6 As ToolStripSeparator

		' Token: 0x0400017A RID: 378
		<AccessedThroughProperty("AboutToolStripMenuItem")>
		Private _AboutToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400017B RID: 379
		<AccessedThroughProperty("SplitContainer")>
		Private _SplitContainer As SplitContainer

		' Token: 0x0400017C RID: 380
		<AccessedThroughProperty("TreeView")>
		Private _TreeView As TreeView

		' Token: 0x0400017D RID: 381
		<AccessedThroughProperty("ListView")>
		Private _ListView As ListView

		' Token: 0x0400017E RID: 382
		<AccessedThroughProperty("StatusStrip")>
		Private _StatusStrip As StatusStrip

		' Token: 0x0400017F RID: 383
		<AccessedThroughProperty("ToolStripStatusLabel")>
		Private _ToolStripStatusLabel As ToolStripStatusLabel

		' Token: 0x04000180 RID: 384
		<AccessedThroughProperty("ToolTip")>
		Private _ToolTip As ToolTip

		' Token: 0x04000181 RID: 385
		<AccessedThroughProperty("ListViewLargeImageList")>
		Private _ListViewLargeImageList As ImageList

		' Token: 0x04000182 RID: 386
		<AccessedThroughProperty("ListViewSmallImageList")>
		Private _ListViewSmallImageList As ImageList

		' Token: 0x04000184 RID: 388
		<AccessedThroughProperty("TheWebToolStripMenuItem")>
		Private _TheWebToolStripMenuItem As ToolStripMenuItem
	End Class
End Namespace
