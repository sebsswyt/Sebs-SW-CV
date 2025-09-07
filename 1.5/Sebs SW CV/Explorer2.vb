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
	' Token: 0x02000031 RID: 49
	<DesignerGenerated()>
	Public Partial Class Explorer2
		Inherits Form

		' Token: 0x060003E6 RID: 998 RVA: 0x03D91D44 File Offset: 0x03D90144
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Explorer2_Load
			Dim _ENCList As List(Of WeakReference) = Explorer2.__ENCList
			SyncLock _ENCList
				Explorer2.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000148 RID: 328
		' (get) Token: 0x060003E8 RID: 1000 RVA: 0x03D91E00 File Offset: 0x03D90200
		' (set) Token: 0x060003E9 RID: 1001 RVA: 0x03D91E18 File Offset: 0x03D90218
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

		' Token: 0x17000149 RID: 329
		' (get) Token: 0x060003EA RID: 1002 RVA: 0x03D91E24 File Offset: 0x03D90224
		' (set) Token: 0x060003EB RID: 1003 RVA: 0x03D91E3C File Offset: 0x03D9023C
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

		' Token: 0x1700014A RID: 330
		' (get) Token: 0x060003EC RID: 1004 RVA: 0x03D91E48 File Offset: 0x03D90248
		' (set) Token: 0x060003ED RID: 1005 RVA: 0x03D91E60 File Offset: 0x03D90260
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

		' Token: 0x1700014B RID: 331
		' (get) Token: 0x060003EE RID: 1006 RVA: 0x03D91E6C File Offset: 0x03D9026C
		' (set) Token: 0x060003EF RID: 1007 RVA: 0x03D91E84 File Offset: 0x03D90284
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

		' Token: 0x1700014C RID: 332
		' (get) Token: 0x060003F0 RID: 1008 RVA: 0x03D91E90 File Offset: 0x03D90290
		' (set) Token: 0x060003F1 RID: 1009 RVA: 0x03D91EA8 File Offset: 0x03D902A8
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

		' Token: 0x1700014D RID: 333
		' (get) Token: 0x060003F2 RID: 1010 RVA: 0x03D91EB4 File Offset: 0x03D902B4
		' (set) Token: 0x060003F3 RID: 1011 RVA: 0x03D91ECC File Offset: 0x03D902CC
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

		' Token: 0x1700014E RID: 334
		' (get) Token: 0x060003F4 RID: 1012 RVA: 0x03D91ED8 File Offset: 0x03D902D8
		' (set) Token: 0x060003F5 RID: 1013 RVA: 0x03D91EF0 File Offset: 0x03D902F0
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

		' Token: 0x1700014F RID: 335
		' (get) Token: 0x060003F6 RID: 1014 RVA: 0x03D91EFC File Offset: 0x03D902FC
		' (set) Token: 0x060003F7 RID: 1015 RVA: 0x03D91F14 File Offset: 0x03D90314
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

		' Token: 0x17000150 RID: 336
		' (get) Token: 0x060003F8 RID: 1016 RVA: 0x03D91F74 File Offset: 0x03D90374
		' (set) Token: 0x060003F9 RID: 1017 RVA: 0x03D91F8C File Offset: 0x03D9038C
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

		' Token: 0x17000151 RID: 337
		' (get) Token: 0x060003FA RID: 1018 RVA: 0x03D91F98 File Offset: 0x03D90398
		' (set) Token: 0x060003FB RID: 1019 RVA: 0x03D91FB0 File Offset: 0x03D903B0
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

		' Token: 0x17000152 RID: 338
		' (get) Token: 0x060003FC RID: 1020 RVA: 0x03D92010 File Offset: 0x03D90410
		' (set) Token: 0x060003FD RID: 1021 RVA: 0x03D92028 File Offset: 0x03D90428
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

		' Token: 0x17000153 RID: 339
		' (get) Token: 0x060003FE RID: 1022 RVA: 0x03D92088 File Offset: 0x03D90488
		' (set) Token: 0x060003FF RID: 1023 RVA: 0x03D920A0 File Offset: 0x03D904A0
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

		' Token: 0x17000154 RID: 340
		' (get) Token: 0x06000400 RID: 1024 RVA: 0x03D92100 File Offset: 0x03D90500
		' (set) Token: 0x06000401 RID: 1025 RVA: 0x03D92118 File Offset: 0x03D90518
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

		' Token: 0x17000155 RID: 341
		' (get) Token: 0x06000402 RID: 1026 RVA: 0x03D92178 File Offset: 0x03D90578
		' (set) Token: 0x06000403 RID: 1027 RVA: 0x03D92190 File Offset: 0x03D90590
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

		' Token: 0x17000156 RID: 342
		' (get) Token: 0x06000404 RID: 1028 RVA: 0x03D921F0 File Offset: 0x03D905F0
		' (set) Token: 0x06000405 RID: 1029 RVA: 0x03D92208 File Offset: 0x03D90608
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

		' Token: 0x17000157 RID: 343
		' (get) Token: 0x06000406 RID: 1030 RVA: 0x03D92214 File Offset: 0x03D90614
		' (set) Token: 0x06000407 RID: 1031 RVA: 0x03D9222C File Offset: 0x03D9062C
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

		' Token: 0x17000158 RID: 344
		' (get) Token: 0x06000408 RID: 1032 RVA: 0x03D92238 File Offset: 0x03D90638
		' (set) Token: 0x06000409 RID: 1033 RVA: 0x03D92250 File Offset: 0x03D90650
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

		' Token: 0x17000159 RID: 345
		' (get) Token: 0x0600040A RID: 1034 RVA: 0x03D922B0 File Offset: 0x03D906B0
		' (set) Token: 0x0600040B RID: 1035 RVA: 0x03D922C8 File Offset: 0x03D906C8
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

		' Token: 0x1700015A RID: 346
		' (get) Token: 0x0600040C RID: 1036 RVA: 0x03D92328 File Offset: 0x03D90728
		' (set) Token: 0x0600040D RID: 1037 RVA: 0x03D92340 File Offset: 0x03D90740
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

		' Token: 0x1700015B RID: 347
		' (get) Token: 0x0600040E RID: 1038 RVA: 0x03D9234C File Offset: 0x03D9074C
		' (set) Token: 0x0600040F RID: 1039 RVA: 0x03D92364 File Offset: 0x03D90764
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

		' Token: 0x1700015C RID: 348
		' (get) Token: 0x06000410 RID: 1040 RVA: 0x03D92370 File Offset: 0x03D90770
		' (set) Token: 0x06000411 RID: 1041 RVA: 0x03D92388 File Offset: 0x03D90788
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

		' Token: 0x1700015D RID: 349
		' (get) Token: 0x06000412 RID: 1042 RVA: 0x03D923E8 File Offset: 0x03D907E8
		' (set) Token: 0x06000413 RID: 1043 RVA: 0x03D92400 File Offset: 0x03D90800
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

		' Token: 0x1700015E RID: 350
		' (get) Token: 0x06000414 RID: 1044 RVA: 0x03D9240C File Offset: 0x03D9080C
		' (set) Token: 0x06000415 RID: 1045 RVA: 0x03D92424 File Offset: 0x03D90824
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

		' Token: 0x1700015F RID: 351
		' (get) Token: 0x06000416 RID: 1046 RVA: 0x03D92430 File Offset: 0x03D90830
		' (set) Token: 0x06000417 RID: 1047 RVA: 0x03D92448 File Offset: 0x03D90848
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

		' Token: 0x17000160 RID: 352
		' (get) Token: 0x06000418 RID: 1048 RVA: 0x03D92454 File Offset: 0x03D90854
		' (set) Token: 0x06000419 RID: 1049 RVA: 0x03D9246C File Offset: 0x03D9086C
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

		' Token: 0x17000161 RID: 353
		' (get) Token: 0x0600041A RID: 1050 RVA: 0x03D92478 File Offset: 0x03D90878
		' (set) Token: 0x0600041B RID: 1051 RVA: 0x03D92490 File Offset: 0x03D90890
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

		' Token: 0x17000162 RID: 354
		' (get) Token: 0x0600041C RID: 1052 RVA: 0x03D924F0 File Offset: 0x03D908F0
		' (set) Token: 0x0600041D RID: 1053 RVA: 0x03D92508 File Offset: 0x03D90908
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

		' Token: 0x17000163 RID: 355
		' (get) Token: 0x0600041E RID: 1054 RVA: 0x03D92514 File Offset: 0x03D90914
		' (set) Token: 0x0600041F RID: 1055 RVA: 0x03D9252C File Offset: 0x03D9092C
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

		' Token: 0x17000164 RID: 356
		' (get) Token: 0x06000420 RID: 1056 RVA: 0x03D92538 File Offset: 0x03D90938
		' (set) Token: 0x06000421 RID: 1057 RVA: 0x03D92550 File Offset: 0x03D90950
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

		' Token: 0x17000165 RID: 357
		' (get) Token: 0x06000422 RID: 1058 RVA: 0x03D9255C File Offset: 0x03D9095C
		' (set) Token: 0x06000423 RID: 1059 RVA: 0x03D92574 File Offset: 0x03D90974
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

		' Token: 0x17000166 RID: 358
		' (get) Token: 0x06000424 RID: 1060 RVA: 0x03D92580 File Offset: 0x03D90980
		' (set) Token: 0x06000425 RID: 1061 RVA: 0x03D92598 File Offset: 0x03D90998
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

		' Token: 0x17000167 RID: 359
		' (get) Token: 0x06000426 RID: 1062 RVA: 0x03D925A4 File Offset: 0x03D909A4
		' (set) Token: 0x06000427 RID: 1063 RVA: 0x03D925BC File Offset: 0x03D909BC
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

		' Token: 0x17000168 RID: 360
		' (get) Token: 0x06000428 RID: 1064 RVA: 0x03D925C8 File Offset: 0x03D909C8
		' (set) Token: 0x06000429 RID: 1065 RVA: 0x03D925E0 File Offset: 0x03D909E0
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

		' Token: 0x17000169 RID: 361
		' (get) Token: 0x0600042A RID: 1066 RVA: 0x03D925EC File Offset: 0x03D909EC
		' (set) Token: 0x0600042B RID: 1067 RVA: 0x03D92604 File Offset: 0x03D90A04
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

		' Token: 0x1700016A RID: 362
		' (get) Token: 0x0600042C RID: 1068 RVA: 0x03D92610 File Offset: 0x03D90A10
		' (set) Token: 0x0600042D RID: 1069 RVA: 0x03D92628 File Offset: 0x03D90A28
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

		' Token: 0x1700016B RID: 363
		' (get) Token: 0x0600042E RID: 1070 RVA: 0x03D92634 File Offset: 0x03D90A34
		' (set) Token: 0x0600042F RID: 1071 RVA: 0x03D9264C File Offset: 0x03D90A4C
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

		' Token: 0x1700016C RID: 364
		' (get) Token: 0x06000430 RID: 1072 RVA: 0x03D92658 File Offset: 0x03D90A58
		' (set) Token: 0x06000431 RID: 1073 RVA: 0x03D92670 File Offset: 0x03D90A70
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

		' Token: 0x1700016D RID: 365
		' (get) Token: 0x06000432 RID: 1074 RVA: 0x03D926D0 File Offset: 0x03D90AD0
		' (set) Token: 0x06000433 RID: 1075 RVA: 0x03D926E8 File Offset: 0x03D90AE8
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

		' Token: 0x1700016E RID: 366
		' (get) Token: 0x06000434 RID: 1076 RVA: 0x03D92748 File Offset: 0x03D90B48
		' (set) Token: 0x06000435 RID: 1077 RVA: 0x03D92760 File Offset: 0x03D90B60
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

		' Token: 0x1700016F RID: 367
		' (get) Token: 0x06000436 RID: 1078 RVA: 0x03D927C0 File Offset: 0x03D90BC0
		' (set) Token: 0x06000437 RID: 1079 RVA: 0x03D927D8 File Offset: 0x03D90BD8
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

		' Token: 0x17000170 RID: 368
		' (get) Token: 0x06000438 RID: 1080 RVA: 0x03D927E4 File Offset: 0x03D90BE4
		' (set) Token: 0x06000439 RID: 1081 RVA: 0x03D927FC File Offset: 0x03D90BFC
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

		' Token: 0x17000171 RID: 369
		' (get) Token: 0x0600043A RID: 1082 RVA: 0x03D92808 File Offset: 0x03D90C08
		' (set) Token: 0x0600043B RID: 1083 RVA: 0x03D92820 File Offset: 0x03D90C20
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

		' Token: 0x17000172 RID: 370
		' (get) Token: 0x0600043C RID: 1084 RVA: 0x03D9282C File Offset: 0x03D90C2C
		' (set) Token: 0x0600043D RID: 1085 RVA: 0x03D92844 File Offset: 0x03D90C44
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

		' Token: 0x17000173 RID: 371
		' (get) Token: 0x0600043E RID: 1086 RVA: 0x03D92850 File Offset: 0x03D90C50
		' (set) Token: 0x0600043F RID: 1087 RVA: 0x03D92868 File Offset: 0x03D90C68
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

		' Token: 0x17000174 RID: 372
		' (get) Token: 0x06000440 RID: 1088 RVA: 0x03D92874 File Offset: 0x03D90C74
		' (set) Token: 0x06000441 RID: 1089 RVA: 0x03D9288C File Offset: 0x03D90C8C
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

		' Token: 0x17000175 RID: 373
		' (get) Token: 0x06000442 RID: 1090 RVA: 0x03D92898 File Offset: 0x03D90C98
		' (set) Token: 0x06000443 RID: 1091 RVA: 0x03D928B0 File Offset: 0x03D90CB0
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

		' Token: 0x17000176 RID: 374
		' (get) Token: 0x06000444 RID: 1092 RVA: 0x03D928BC File Offset: 0x03D90CBC
		' (set) Token: 0x06000445 RID: 1093 RVA: 0x03D928D4 File Offset: 0x03D90CD4
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

		' Token: 0x17000177 RID: 375
		' (get) Token: 0x06000446 RID: 1094 RVA: 0x03D92934 File Offset: 0x03D90D34
		' (set) Token: 0x06000447 RID: 1095 RVA: 0x03D9294C File Offset: 0x03D90D4C
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

		' Token: 0x17000178 RID: 376
		' (get) Token: 0x06000448 RID: 1096 RVA: 0x03D92958 File Offset: 0x03D90D58
		' (set) Token: 0x06000449 RID: 1097 RVA: 0x03D92970 File Offset: 0x03D90D70
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

		' Token: 0x17000179 RID: 377
		' (get) Token: 0x0600044A RID: 1098 RVA: 0x03D9297C File Offset: 0x03D90D7C
		' (set) Token: 0x0600044B RID: 1099 RVA: 0x03D92994 File Offset: 0x03D90D94
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

		' Token: 0x1700017A RID: 378
		' (get) Token: 0x0600044C RID: 1100 RVA: 0x03D929A0 File Offset: 0x03D90DA0
		' (set) Token: 0x0600044D RID: 1101 RVA: 0x03D929B8 File Offset: 0x03D90DB8
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

		' Token: 0x1700017B RID: 379
		' (get) Token: 0x0600044E RID: 1102 RVA: 0x03D929C4 File Offset: 0x03D90DC4
		' (set) Token: 0x0600044F RID: 1103 RVA: 0x03D929DC File Offset: 0x03D90DDC
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

		' Token: 0x1700017C RID: 380
		' (get) Token: 0x06000451 RID: 1105 RVA: 0x03D94350 File Offset: 0x03D92750
		' (set) Token: 0x06000452 RID: 1106 RVA: 0x03D94368 File Offset: 0x03D92768
		Friend Overridable Property SaveFileDialog1 As SaveFileDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._SaveFileDialog1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As SaveFileDialog)
				Dim cancelEventHandler As CancelEventHandler = AddressOf Me.SaveFileDialog1_FileOk
				Dim flag As Boolean = Me._SaveFileDialog1 IsNot Nothing
				If flag Then
					RemoveHandler Me._SaveFileDialog1.FileOk, cancelEventHandler
				End If
				Me._SaveFileDialog1 = value
				flag = Me._SaveFileDialog1 IsNot Nothing
				If flag Then
					AddHandler Me._SaveFileDialog1.FileOk, cancelEventHandler
				End If
			End Set
		End Property

		' Token: 0x1700017D RID: 381
		' (get) Token: 0x06000453 RID: 1107 RVA: 0x03D943C8 File Offset: 0x03D927C8
		' (set) Token: 0x06000454 RID: 1108 RVA: 0x03D943E0 File Offset: 0x03D927E0
		Friend Overridable Property RichTextBox1 As RichTextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._RichTextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Me._RichTextBox1 = value
			End Set
		End Property

		' Token: 0x06000455 RID: 1109 RVA: 0x03D943EC File Offset: 0x03D927EC
		Private Sub Explorer2_Load(sender As Object, e As EventArgs)
			Me.SetUpListViewColumns()
			Me.LoadTree()
		End Sub

		' Token: 0x06000456 RID: 1110 RVA: 0x03D94400 File Offset: 0x03D92800
		Private Sub LoadTree()
		End Sub

		' Token: 0x06000457 RID: 1111 RVA: 0x03D94404 File Offset: 0x03D92804
		Private Sub LoadListView()
		End Sub

		' Token: 0x06000458 RID: 1112 RVA: 0x03D94408 File Offset: 0x03D92808
		Private Sub SetUpListViewColumns()
		End Sub

		' Token: 0x06000459 RID: 1113 RVA: 0x03D9440C File Offset: 0x03D9280C
		Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x0600045A RID: 1114 RVA: 0x03D94418 File Offset: 0x03D92818
		Private Sub ToolBarToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.ToolBarToolStripMenuItem.Checked = Not Me.ToolBarToolStripMenuItem.Checked
			Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
		End Sub

		' Token: 0x0600045B RID: 1115 RVA: 0x03D94450 File Offset: 0x03D92850
		Private Sub StatusBarToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.StatusBarToolStripMenuItem.Checked = Not Me.StatusBarToolStripMenuItem.Checked
			Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
		End Sub

		' Token: 0x0600045C RID: 1116 RVA: 0x03D94488 File Offset: 0x03D92888
		Private Sub ToggleFoldersVisible()
		End Sub

		' Token: 0x0600045D RID: 1117 RVA: 0x03D9448C File Offset: 0x03D9288C
		Private Sub FoldersToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.ToggleFoldersVisible()
		End Sub

		' Token: 0x0600045E RID: 1118 RVA: 0x03D94498 File Offset: 0x03D92898
		Private Sub FoldersToolStripButton_Click(sender As Object, e As EventArgs)
			Me.ToggleFoldersVisible()
		End Sub

		' Token: 0x0600045F RID: 1119 RVA: 0x03D944A4 File Offset: 0x03D928A4
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
		End Sub

		' Token: 0x06000460 RID: 1120 RVA: 0x03D945A0 File Offset: 0x03D929A0
		Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.SetView(View.List)
		End Sub

		' Token: 0x06000461 RID: 1121 RVA: 0x03D945AC File Offset: 0x03D929AC
		Private Sub DetailsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.SetView(View.Details)
		End Sub

		' Token: 0x06000462 RID: 1122 RVA: 0x03D945B8 File Offset: 0x03D929B8
		Private Sub LargeIconsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.SetView(View.LargeIcon)
		End Sub

		' Token: 0x06000463 RID: 1123 RVA: 0x03D945C4 File Offset: 0x03D929C4
		Private Sub SmallIconsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.SetView(View.SmallIcon)
		End Sub

		' Token: 0x06000464 RID: 1124 RVA: 0x03D945D0 File Offset: 0x03D929D0
		Private Sub TileToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.SetView(View.Tile)
		End Sub

		' Token: 0x06000465 RID: 1125 RVA: 0x03D945DC File Offset: 0x03D929DC
		Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			openFileDialog.InitialDirectory = MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments
			openFileDialog.Filter = "Text Files (*.txt)|*.txt"
			openFileDialog.ShowDialog(Me)
			Dim fileName As String = openFileDialog.FileName
		End Sub

		' Token: 0x06000466 RID: 1126 RVA: 0x03D94628 File Offset: 0x03D92A28
		Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
			saveFileDialog.InitialDirectory = MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments
			saveFileDialog.Filter = "Text Files (*.txt)|*.txt"
			saveFileDialog.ShowDialog(Me)
			Dim fileName As String = saveFileDialog.FileName
		End Sub

		' Token: 0x06000467 RID: 1127 RVA: 0x03D94674 File Offset: 0x03D92A74
		Private Sub TreeView_AfterSelect(sender As Object, e As TreeViewEventArgs)
			Me.LoadListView()
		End Sub

		' Token: 0x06000468 RID: 1128 RVA: 0x03D94680 File Offset: 0x03D92A80
		Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox1.Show()
		End Sub

		' Token: 0x06000469 RID: 1129 RVA: 0x03D94694 File Offset: 0x03D92A94
		Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600046A RID: 1130 RVA: 0x03D94698 File Offset: 0x03D92A98
		Private Sub SaveFileDialog1_FileOk(sender As Object, e As CancelEventArgs)
		End Sub

		' Token: 0x04000185 RID: 389
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000186 RID: 390
		<AccessedThroughProperty("ToolStripContainer")>
		Private _ToolStripContainer As ToolStripContainer

		' Token: 0x04000187 RID: 391
		<AccessedThroughProperty("TreeNodeImageList")>
		Private _TreeNodeImageList As ImageList

		' Token: 0x04000188 RID: 392
		<AccessedThroughProperty("ToolStripSeparator7")>
		Private _ToolStripSeparator7 As ToolStripSeparator

		' Token: 0x04000189 RID: 393
		<AccessedThroughProperty("ToolStripSeparator8")>
		Private _ToolStripSeparator8 As ToolStripSeparator

		' Token: 0x0400018A RID: 394
		<AccessedThroughProperty("ToolStrip")>
		Private _ToolStrip As ToolStrip

		' Token: 0x0400018B RID: 395
		<AccessedThroughProperty("BackToolStripButton")>
		Private _BackToolStripButton As ToolStripButton

		' Token: 0x0400018C RID: 396
		<AccessedThroughProperty("ForwardToolStripButton")>
		Private _ForwardToolStripButton As ToolStripButton

		' Token: 0x0400018D RID: 397
		<AccessedThroughProperty("FoldersToolStripButton")>
		Private _FoldersToolStripButton As ToolStripButton

		' Token: 0x0400018E RID: 398
		<AccessedThroughProperty("ListViewToolStripButton")>
		Private _ListViewToolStripButton As ToolStripDropDownButton

		' Token: 0x0400018F RID: 399
		<AccessedThroughProperty("ListToolStripMenuItem")>
		Private _ListToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000190 RID: 400
		<AccessedThroughProperty("DetailsToolStripMenuItem")>
		Private _DetailsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000191 RID: 401
		<AccessedThroughProperty("LargeIconsToolStripMenuItem")>
		Private _LargeIconsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000192 RID: 402
		<AccessedThroughProperty("SmallIconsToolStripMenuItem")>
		Private _SmallIconsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000193 RID: 403
		<AccessedThroughProperty("TileToolStripMenuItem")>
		Private _TileToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000194 RID: 404
		<AccessedThroughProperty("MenuStrip")>
		Private _MenuStrip As MenuStrip

		' Token: 0x04000195 RID: 405
		<AccessedThroughProperty("FileToolStripMenuItem")>
		Private _FileToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000196 RID: 406
		<AccessedThroughProperty("NewToolStripMenuItem")>
		Private _NewToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000197 RID: 407
		<AccessedThroughProperty("OpenToolStripMenuItem")>
		Private _OpenToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000198 RID: 408
		<AccessedThroughProperty("ToolStripSeparator1")>
		Private _ToolStripSeparator1 As ToolStripSeparator

		' Token: 0x04000199 RID: 409
		<AccessedThroughProperty("SaveToolStripMenuItem")>
		Private _SaveToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400019A RID: 410
		<AccessedThroughProperty("SaveAsToolStripMenuItem")>
		Private _SaveAsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400019B RID: 411
		<AccessedThroughProperty("ToolStripSeparator2")>
		Private _ToolStripSeparator2 As ToolStripSeparator

		' Token: 0x0400019C RID: 412
		<AccessedThroughProperty("PrintToolStripMenuItem")>
		Private _PrintToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400019D RID: 413
		<AccessedThroughProperty("PrintPreviewToolStripMenuItem")>
		Private _PrintPreviewToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400019E RID: 414
		<AccessedThroughProperty("ToolStripSeparator3")>
		Private _ToolStripSeparator3 As ToolStripSeparator

		' Token: 0x0400019F RID: 415
		<AccessedThroughProperty("ExitToolStripMenuItem")>
		Private _ExitToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001A0 RID: 416
		<AccessedThroughProperty("EditToolStripMenuItem")>
		Private _EditToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001A1 RID: 417
		<AccessedThroughProperty("UndoToolStripMenuItem")>
		Private _UndoToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001A2 RID: 418
		<AccessedThroughProperty("RedoToolStripMenuItem")>
		Private _RedoToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001A3 RID: 419
		<AccessedThroughProperty("ToolStripSeparator4")>
		Private _ToolStripSeparator4 As ToolStripSeparator

		' Token: 0x040001A4 RID: 420
		<AccessedThroughProperty("CutToolStripMenuItem")>
		Private _CutToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001A5 RID: 421
		<AccessedThroughProperty("CopyToolStripMenuItem")>
		Private _CopyToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001A6 RID: 422
		<AccessedThroughProperty("PasteToolStripMenuItem")>
		Private _PasteToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001A7 RID: 423
		<AccessedThroughProperty("ToolStripSeparator5")>
		Private _ToolStripSeparator5 As ToolStripSeparator

		' Token: 0x040001A8 RID: 424
		<AccessedThroughProperty("SelectAllToolStripMenuItem")>
		Private _SelectAllToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001A9 RID: 425
		<AccessedThroughProperty("ViewToolStripMenuItem")>
		Private _ViewToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001AA RID: 426
		<AccessedThroughProperty("ToolBarToolStripMenuItem")>
		Private _ToolBarToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001AB RID: 427
		<AccessedThroughProperty("StatusBarToolStripMenuItem")>
		Private _StatusBarToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001AC RID: 428
		<AccessedThroughProperty("FoldersToolStripMenuItem")>
		Private _FoldersToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001AD RID: 429
		<AccessedThroughProperty("ToolsToolStripMenuItem")>
		Private _ToolsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001AE RID: 430
		<AccessedThroughProperty("OptionsToolStripMenuItem")>
		Private _OptionsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001AF RID: 431
		<AccessedThroughProperty("HelpToolStripMenuItem")>
		Private _HelpToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001B0 RID: 432
		<AccessedThroughProperty("ContentsToolStripMenuItem")>
		Private _ContentsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001B1 RID: 433
		<AccessedThroughProperty("IndexToolStripMenuItem")>
		Private _IndexToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001B2 RID: 434
		<AccessedThroughProperty("SearchToolStripMenuItem")>
		Private _SearchToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001B3 RID: 435
		<AccessedThroughProperty("ToolStripSeparator6")>
		Private _ToolStripSeparator6 As ToolStripSeparator

		' Token: 0x040001B4 RID: 436
		<AccessedThroughProperty("AboutToolStripMenuItem")>
		Private _AboutToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001B5 RID: 437
		<AccessedThroughProperty("StatusStrip")>
		Private _StatusStrip As StatusStrip

		' Token: 0x040001B6 RID: 438
		<AccessedThroughProperty("ToolStripStatusLabel")>
		Private _ToolStripStatusLabel As ToolStripStatusLabel

		' Token: 0x040001B7 RID: 439
		<AccessedThroughProperty("ToolTip")>
		Private _ToolTip As ToolTip

		' Token: 0x040001B8 RID: 440
		<AccessedThroughProperty("ListViewLargeImageList")>
		Private _ListViewLargeImageList As ImageList

		' Token: 0x040001B9 RID: 441
		<AccessedThroughProperty("ListViewSmallImageList")>
		Private _ListViewSmallImageList As ImageList

		' Token: 0x040001BB RID: 443
		<AccessedThroughProperty("SaveFileDialog1")>
		Private _SaveFileDialog1 As SaveFileDialog

		' Token: 0x040001BC RID: 444
		<AccessedThroughProperty("RichTextBox1")>
		Private _RichTextBox1 As RichTextBox
	End Class
End Namespace
