Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports CV.My
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x0200004D RID: 77
	<DesignerGenerated()>
	Public Partial Class Form31
		Inherits Form

		' Token: 0x06000C8D RID: 3213 RVA: 0x03DCBCA0 File Offset: 0x03DCA0A0
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form31_Load
			Dim _ENCList As List(Of WeakReference) = Form31.__ENCList
			SyncLock _ENCList
				Form31.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000429 RID: 1065
		' (get) Token: 0x06000C90 RID: 3216 RVA: 0x03DCDE60 File Offset: 0x03DCC260
		' (set) Token: 0x06000C91 RID: 3217 RVA: 0x03DCDE78 File Offset: 0x03DCC278
		Friend Overridable Property Button11 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button11_Click
				Dim flag As Boolean = Me._Button11 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button11.Click, eventHandler
				End If
				Me._Button11 = value
				flag = Me._Button11 IsNot Nothing
				If flag Then
					AddHandler Me._Button11.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700042A RID: 1066
		' (get) Token: 0x06000C92 RID: 3218 RVA: 0x03DCDED8 File Offset: 0x03DCC2D8
		' (set) Token: 0x06000C93 RID: 3219 RVA: 0x03DCDEF0 File Offset: 0x03DCC2F0
		Friend Overridable Property Panel4 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel4 = value
			End Set
		End Property

		' Token: 0x1700042B RID: 1067
		' (get) Token: 0x06000C94 RID: 3220 RVA: 0x03DCDEFC File Offset: 0x03DCC2FC
		' (set) Token: 0x06000C95 RID: 3221 RVA: 0x03DCDF14 File Offset: 0x03DCC314
		Friend Overridable Property Button7 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button7_Click
				Dim flag As Boolean = Me._Button7 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button7.Click, eventHandler
				End If
				Me._Button7 = value
				flag = Me._Button7 IsNot Nothing
				If flag Then
					AddHandler Me._Button7.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700042C RID: 1068
		' (get) Token: 0x06000C96 RID: 3222 RVA: 0x03DCDF74 File Offset: 0x03DCC374
		' (set) Token: 0x06000C97 RID: 3223 RVA: 0x03DCDF8C File Offset: 0x03DCC38C
		Friend Overridable Property Button20 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button20
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button20 = value
			End Set
		End Property

		' Token: 0x1700042D RID: 1069
		' (get) Token: 0x06000C98 RID: 3224 RVA: 0x03DCDF98 File Offset: 0x03DCC398
		' (set) Token: 0x06000C99 RID: 3225 RVA: 0x03DCDFB0 File Offset: 0x03DCC3B0
		Friend Overridable Property Button19 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button19
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button19 = value
			End Set
		End Property

		' Token: 0x1700042E RID: 1070
		' (get) Token: 0x06000C9A RID: 3226 RVA: 0x03DCDFBC File Offset: 0x03DCC3BC
		' (set) Token: 0x06000C9B RID: 3227 RVA: 0x03DCDFD4 File Offset: 0x03DCC3D4
		Friend Overridable Property Button18 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button18
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button18_Click
				Dim flag As Boolean = Me._Button18 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button18.Click, eventHandler
				End If
				Me._Button18 = value
				flag = Me._Button18 IsNot Nothing
				If flag Then
					AddHandler Me._Button18.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700042F RID: 1071
		' (get) Token: 0x06000C9C RID: 3228 RVA: 0x03DCE034 File Offset: 0x03DCC434
		' (set) Token: 0x06000C9D RID: 3229 RVA: 0x03DCE04C File Offset: 0x03DCC44C
		Friend Overridable Property Button17 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button17
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button17_Click
				Dim flag As Boolean = Me._Button17 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button17.Click, eventHandler
				End If
				Me._Button17 = value
				flag = Me._Button17 IsNot Nothing
				If flag Then
					AddHandler Me._Button17.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000430 RID: 1072
		' (get) Token: 0x06000C9E RID: 3230 RVA: 0x03DCE0AC File Offset: 0x03DCC4AC
		' (set) Token: 0x06000C9F RID: 3231 RVA: 0x03DCE0C4 File Offset: 0x03DCC4C4
		Friend Overridable Property Panel3 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel3 = value
			End Set
		End Property

		' Token: 0x17000431 RID: 1073
		' (get) Token: 0x06000CA0 RID: 3232 RVA: 0x03DCE0D0 File Offset: 0x03DCC4D0
		' (set) Token: 0x06000CA1 RID: 3233 RVA: 0x03DCE0E8 File Offset: 0x03DCC4E8
		Friend Overridable Property Button1 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button1 = value
			End Set
		End Property

		' Token: 0x17000432 RID: 1074
		' (get) Token: 0x06000CA2 RID: 3234 RVA: 0x03DCE0F4 File Offset: 0x03DCC4F4
		' (set) Token: 0x06000CA3 RID: 3235 RVA: 0x03DCE10C File Offset: 0x03DCC50C
		Friend Overridable Property Button15 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button15
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button15 = value
			End Set
		End Property

		' Token: 0x17000433 RID: 1075
		' (get) Token: 0x06000CA4 RID: 3236 RVA: 0x03DCE118 File Offset: 0x03DCC518
		' (set) Token: 0x06000CA5 RID: 3237 RVA: 0x03DCE130 File Offset: 0x03DCC530
		Friend Overridable Property Button14 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button14
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button14 = value
			End Set
		End Property

		' Token: 0x17000434 RID: 1076
		' (get) Token: 0x06000CA6 RID: 3238 RVA: 0x03DCE13C File Offset: 0x03DCC53C
		' (set) Token: 0x06000CA7 RID: 3239 RVA: 0x03DCE154 File Offset: 0x03DCC554
		Friend Overridable Property Button13 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button13
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button13_Click
				Dim flag As Boolean = Me._Button13 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button13.Click, eventHandler
				End If
				Me._Button13 = value
				flag = Me._Button13 IsNot Nothing
				If flag Then
					AddHandler Me._Button13.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000435 RID: 1077
		' (get) Token: 0x06000CA8 RID: 3240 RVA: 0x03DCE1B4 File Offset: 0x03DCC5B4
		' (set) Token: 0x06000CA9 RID: 3241 RVA: 0x03DCE1CC File Offset: 0x03DCC5CC
		Friend Overridable Property Button12 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button12_Click
				Dim flag As Boolean = Me._Button12 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button12.Click, eventHandler
				End If
				Me._Button12 = value
				flag = Me._Button12 IsNot Nothing
				If flag Then
					AddHandler Me._Button12.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000436 RID: 1078
		' (get) Token: 0x06000CAA RID: 3242 RVA: 0x03DCE22C File Offset: 0x03DCC62C
		' (set) Token: 0x06000CAB RID: 3243 RVA: 0x03DCE244 File Offset: 0x03DCC644
		Friend Overridable Property Panel2 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel2 = value
			End Set
		End Property

		' Token: 0x17000437 RID: 1079
		' (get) Token: 0x06000CAC RID: 3244 RVA: 0x03DCE250 File Offset: 0x03DCC650
		' (set) Token: 0x06000CAD RID: 3245 RVA: 0x03DCE268 File Offset: 0x03DCC668
		Friend Overridable Property Button10 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button10 = value
			End Set
		End Property

		' Token: 0x17000438 RID: 1080
		' (get) Token: 0x06000CAE RID: 3246 RVA: 0x03DCE274 File Offset: 0x03DCC674
		' (set) Token: 0x06000CAF RID: 3247 RVA: 0x03DCE28C File Offset: 0x03DCC68C
		Friend Overridable Property Button9 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button9 = value
			End Set
		End Property

		' Token: 0x17000439 RID: 1081
		' (get) Token: 0x06000CB0 RID: 3248 RVA: 0x03DCE298 File Offset: 0x03DCC698
		' (set) Token: 0x06000CB1 RID: 3249 RVA: 0x03DCE2B0 File Offset: 0x03DCC6B0
		Friend Overridable Property Button8 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.Button8_MouseClick
				Dim eventHandler As EventHandler = AddressOf Me.Button8_Click
				Dim flag As Boolean = Me._Button8 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button8.MouseClick, mouseEventHandler
					RemoveHandler Me._Button8.Click, eventHandler
				End If
				Me._Button8 = value
				flag = Me._Button8 IsNot Nothing
				If flag Then
					AddHandler Me._Button8.MouseClick, mouseEventHandler
					AddHandler Me._Button8.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700043A RID: 1082
		' (get) Token: 0x06000CB2 RID: 3250 RVA: 0x03DCE338 File Offset: 0x03DCC738
		' (set) Token: 0x06000CB3 RID: 3251 RVA: 0x03DCE350 File Offset: 0x03DCC750
		Friend Overridable Property Button5 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button5_Click
				Dim flag As Boolean = Me._Button5 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button5.Click, eventHandler
				End If
				Me._Button5 = value
				flag = Me._Button5 IsNot Nothing
				If flag Then
					AddHandler Me._Button5.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700043B RID: 1083
		' (get) Token: 0x06000CB4 RID: 3252 RVA: 0x03DCE3B0 File Offset: 0x03DCC7B0
		' (set) Token: 0x06000CB5 RID: 3253 RVA: 0x03DCE3C8 File Offset: 0x03DCC7C8
		Friend Overridable Property Button4 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button4_Click
				Dim flag As Boolean = Me._Button4 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button4.Click, eventHandler
				End If
				Me._Button4 = value
				flag = Me._Button4 IsNot Nothing
				If flag Then
					AddHandler Me._Button4.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700043C RID: 1084
		' (get) Token: 0x06000CB6 RID: 3254 RVA: 0x03DCE428 File Offset: 0x03DCC828
		' (set) Token: 0x06000CB7 RID: 3255 RVA: 0x03DCE440 File Offset: 0x03DCC840
		Friend Overridable Property Button3 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button3_Click
				Dim flag As Boolean = Me._Button3 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button3.Click, eventHandler
				End If
				Me._Button3 = value
				flag = Me._Button3 IsNot Nothing
				If flag Then
					AddHandler Me._Button3.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700043D RID: 1085
		' (get) Token: 0x06000CB8 RID: 3256 RVA: 0x03DCE4A0 File Offset: 0x03DCC8A0
		' (set) Token: 0x06000CB9 RID: 3257 RVA: 0x03DCE4B8 File Offset: 0x03DCC8B8
		Friend Overridable Property Button2 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button2_Click
				Dim flag As Boolean = Me._Button2 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button2.Click, eventHandler
				End If
				Me._Button2 = value
				flag = Me._Button2 IsNot Nothing
				If flag Then
					AddHandler Me._Button2.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700043E RID: 1086
		' (get) Token: 0x06000CBA RID: 3258 RVA: 0x03DCE518 File Offset: 0x03DCC918
		' (set) Token: 0x06000CBB RID: 3259 RVA: 0x03DCE530 File Offset: 0x03DCC930
		Friend Overridable Property MenuStrip1 As MenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuStrip1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuStrip)
				Me._MenuStrip1 = value
			End Set
		End Property

		' Token: 0x1700043F RID: 1087
		' (get) Token: 0x06000CBC RID: 3260 RVA: 0x03DCE53C File Offset: 0x03DCC93C
		' (set) Token: 0x06000CBD RID: 3261 RVA: 0x03DCE554 File Offset: 0x03DCC954
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

		' Token: 0x17000440 RID: 1088
		' (get) Token: 0x06000CBE RID: 3262 RVA: 0x03DCE560 File Offset: 0x03DCC960
		' (set) Token: 0x06000CBF RID: 3263 RVA: 0x03DCE578 File Offset: 0x03DCC978
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

		' Token: 0x17000441 RID: 1089
		' (get) Token: 0x06000CC0 RID: 3264 RVA: 0x03DCE584 File Offset: 0x03DCC984
		' (set) Token: 0x06000CC1 RID: 3265 RVA: 0x03DCE59C File Offset: 0x03DCC99C
		Friend Overridable Property FormatToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FormatToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._FormatToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000442 RID: 1090
		' (get) Token: 0x06000CC2 RID: 3266 RVA: 0x03DCE5A8 File Offset: 0x03DCC9A8
		' (set) Token: 0x06000CC3 RID: 3267 RVA: 0x03DCE5C0 File Offset: 0x03DCC9C0
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

		' Token: 0x17000443 RID: 1091
		' (get) Token: 0x06000CC4 RID: 3268 RVA: 0x03DCE5CC File Offset: 0x03DCC9CC
		' (set) Token: 0x06000CC5 RID: 3269 RVA: 0x03DCE5E4 File Offset: 0x03DCC9E4
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

		' Token: 0x17000444 RID: 1092
		' (get) Token: 0x06000CC6 RID: 3270 RVA: 0x03DCE5F0 File Offset: 0x03DCC9F0
		' (set) Token: 0x06000CC7 RID: 3271 RVA: 0x03DCE608 File Offset: 0x03DCCA08
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

		' Token: 0x17000445 RID: 1093
		' (get) Token: 0x06000CC8 RID: 3272 RVA: 0x03DCE668 File Offset: 0x03DCCA68
		' (set) Token: 0x06000CC9 RID: 3273 RVA: 0x03DCE680 File Offset: 0x03DCCA80
		Friend Overridable Property SaveToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SaveToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.SaveToolStripMenuItem_Click
				Dim flag As Boolean = Me._SaveToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._SaveToolStripMenuItem.Click, eventHandler
				End If
				Me._SaveToolStripMenuItem = value
				flag = Me._SaveToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._SaveToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000446 RID: 1094
		' (get) Token: 0x06000CCA RID: 3274 RVA: 0x03DCE6E0 File Offset: 0x03DCCAE0
		' (set) Token: 0x06000CCB RID: 3275 RVA: 0x03DCE6F8 File Offset: 0x03DCCAF8
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

		' Token: 0x17000447 RID: 1095
		' (get) Token: 0x06000CCC RID: 3276 RVA: 0x03DCE758 File Offset: 0x03DCCB58
		' (set) Token: 0x06000CCD RID: 3277 RVA: 0x03DCE770 File Offset: 0x03DCCB70
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

		' Token: 0x17000448 RID: 1096
		' (get) Token: 0x06000CCE RID: 3278 RVA: 0x03DCE77C File Offset: 0x03DCCB7C
		' (set) Token: 0x06000CCF RID: 3279 RVA: 0x03DCE794 File Offset: 0x03DCCB94
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

		' Token: 0x17000449 RID: 1097
		' (get) Token: 0x06000CD0 RID: 3280 RVA: 0x03DCE7A0 File Offset: 0x03DCCBA0
		' (set) Token: 0x06000CD1 RID: 3281 RVA: 0x03DCE7B8 File Offset: 0x03DCCBB8
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

		' Token: 0x1700044A RID: 1098
		' (get) Token: 0x06000CD2 RID: 3282 RVA: 0x03DCE7C4 File Offset: 0x03DCCBC4
		' (set) Token: 0x06000CD3 RID: 3283 RVA: 0x03DCE7DC File Offset: 0x03DCCBDC
		Friend Overridable Property PictureBox2 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox2_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox2_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox2_Click
				Dim flag As Boolean = Me._PictureBox2 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox2.MouseLeave, eventHandler
					RemoveHandler Me._PictureBox2.MouseEnter, eventHandler2
					RemoveHandler Me._PictureBox2.Click, eventHandler3
				End If
				Me._PictureBox2 = value
				flag = Me._PictureBox2 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox2.MouseLeave, eventHandler
					AddHandler Me._PictureBox2.MouseEnter, eventHandler2
					AddHandler Me._PictureBox2.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x1700044B RID: 1099
		' (get) Token: 0x06000CD4 RID: 3284 RVA: 0x03DCE88C File Offset: 0x03DCCC8C
		' (set) Token: 0x06000CD5 RID: 3285 RVA: 0x03DCE8A4 File Offset: 0x03DCCCA4
		Friend Overridable Property PictureBox3 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox3_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox3_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox3_Click
				Dim flag As Boolean = Me._PictureBox3 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox3.MouseLeave, eventHandler
					RemoveHandler Me._PictureBox3.MouseEnter, eventHandler2
					RemoveHandler Me._PictureBox3.Click, eventHandler3
				End If
				Me._PictureBox3 = value
				flag = Me._PictureBox3 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox3.MouseLeave, eventHandler
					AddHandler Me._PictureBox3.MouseEnter, eventHandler2
					AddHandler Me._PictureBox3.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x1700044C RID: 1100
		' (get) Token: 0x06000CD6 RID: 3286 RVA: 0x03DCE954 File Offset: 0x03DCCD54
		' (set) Token: 0x06000CD7 RID: 3287 RVA: 0x03DCE96C File Offset: 0x03DCCD6C
		Friend Overridable Property PictureBox4 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox4_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox4_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox4_Click
				Dim flag As Boolean = Me._PictureBox4 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox4.MouseLeave, eventHandler
					RemoveHandler Me._PictureBox4.MouseEnter, eventHandler2
					RemoveHandler Me._PictureBox4.Click, eventHandler3
				End If
				Me._PictureBox4 = value
				flag = Me._PictureBox4 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox4.MouseLeave, eventHandler
					AddHandler Me._PictureBox4.MouseEnter, eventHandler2
					AddHandler Me._PictureBox4.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x1700044D RID: 1101
		' (get) Token: 0x06000CD8 RID: 3288 RVA: 0x03DCEA1C File Offset: 0x03DCCE1C
		' (set) Token: 0x06000CD9 RID: 3289 RVA: 0x03DCEA34 File Offset: 0x03DCCE34
		Friend Overridable Property Panel1 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.Panel1_MouseMove
				Dim mouseEventHandler2 As MouseEventHandler = AddressOf Me.Panel1_MouseDown
				Dim flag As Boolean = Me._Panel1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Panel1.MouseMove, mouseEventHandler
					RemoveHandler Me._Panel1.MouseDown, mouseEventHandler2
				End If
				Me._Panel1 = value
				flag = Me._Panel1 IsNot Nothing
				If flag Then
					AddHandler Me._Panel1.MouseMove, mouseEventHandler
					AddHandler Me._Panel1.MouseDown, mouseEventHandler2
				End If
			End Set
		End Property

		' Token: 0x1700044E RID: 1102
		' (get) Token: 0x06000CDA RID: 3290 RVA: 0x03DCEABC File Offset: 0x03DCCEBC
		' (set) Token: 0x06000CDB RID: 3291 RVA: 0x03DCEAD4 File Offset: 0x03DCCED4
		Friend Overridable Property Button16 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button16
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button16_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.Button16_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.Button16_Click
				Dim flag As Boolean = Me._Button16 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button16.MouseLeave, eventHandler
					RemoveHandler Me._Button16.MouseEnter, eventHandler2
					RemoveHandler Me._Button16.Click, eventHandler3
				End If
				Me._Button16 = value
				flag = Me._Button16 IsNot Nothing
				If flag Then
					AddHandler Me._Button16.MouseLeave, eventHandler
					AddHandler Me._Button16.MouseEnter, eventHandler2
					AddHandler Me._Button16.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x1700044F RID: 1103
		' (get) Token: 0x06000CDC RID: 3292 RVA: 0x03DCEB84 File Offset: 0x03DCCF84
		' (set) Token: 0x06000CDD RID: 3293 RVA: 0x03DCEB9C File Offset: 0x03DCCF9C
		Friend Overridable Property Button6 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button6_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.Button6_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.Button6_Click
				Dim flag As Boolean = Me._Button6 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button6.MouseLeave, eventHandler
					RemoveHandler Me._Button6.MouseEnter, eventHandler2
					RemoveHandler Me._Button6.Click, eventHandler3
				End If
				Me._Button6 = value
				flag = Me._Button6 IsNot Nothing
				If flag Then
					AddHandler Me._Button6.MouseLeave, eventHandler
					AddHandler Me._Button6.MouseEnter, eventHandler2
					AddHandler Me._Button6.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x17000450 RID: 1104
		' (get) Token: 0x06000CDE RID: 3294 RVA: 0x03DCEC4C File Offset: 0x03DCD04C
		' (set) Token: 0x06000CDF RID: 3295 RVA: 0x03DCEC64 File Offset: 0x03DCD064
		Friend Overridable Property Panel5 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel5 = value
			End Set
		End Property

		' Token: 0x17000451 RID: 1105
		' (get) Token: 0x06000CE0 RID: 3296 RVA: 0x03DCEC70 File Offset: 0x03DCD070
		' (set) Token: 0x06000CE1 RID: 3297 RVA: 0x03DCEC88 File Offset: 0x03DCD088
		Friend Overridable Property Button21 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button21
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button21_Click
				Dim flag As Boolean = Me._Button21 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button21.Click, eventHandler
				End If
				Me._Button21 = value
				flag = Me._Button21 IsNot Nothing
				If flag Then
					AddHandler Me._Button21.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000452 RID: 1106
		' (get) Token: 0x06000CE2 RID: 3298 RVA: 0x03DCECE8 File Offset: 0x03DCD0E8
		' (set) Token: 0x06000CE3 RID: 3299 RVA: 0x03DCED00 File Offset: 0x03DCD100
		Friend Overridable Property Panel6 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel6 = value
			End Set
		End Property

		' Token: 0x17000453 RID: 1107
		' (get) Token: 0x06000CE4 RID: 3300 RVA: 0x03DCED0C File Offset: 0x03DCD10C
		' (set) Token: 0x06000CE5 RID: 3301 RVA: 0x03DCED24 File Offset: 0x03DCD124
		Friend Overridable Property OpenFileToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenFileToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.OpenFileToolStripMenuItem1_Click
				Dim flag As Boolean = Me._OpenFileToolStripMenuItem1 IsNot Nothing
				If flag Then
					RemoveHandler Me._OpenFileToolStripMenuItem1.Click, eventHandler
				End If
				Me._OpenFileToolStripMenuItem1 = value
				flag = Me._OpenFileToolStripMenuItem1 IsNot Nothing
				If flag Then
					AddHandler Me._OpenFileToolStripMenuItem1.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000454 RID: 1108
		' (get) Token: 0x06000CE6 RID: 3302 RVA: 0x03DCED84 File Offset: 0x03DCD184
		' (set) Token: 0x06000CE7 RID: 3303 RVA: 0x03DCED9C File Offset: 0x03DCD19C
		Friend Overridable Property SaveToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SaveToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._SaveToolStripMenuItem1 = value
			End Set
		End Property

		' Token: 0x17000455 RID: 1109
		' (get) Token: 0x06000CE8 RID: 3304 RVA: 0x03DCEDA8 File Offset: 0x03DCD1A8
		' (set) Token: 0x06000CE9 RID: 3305 RVA: 0x03DCEDC0 File Offset: 0x03DCD1C0
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

		' Token: 0x17000456 RID: 1110
		' (get) Token: 0x06000CEA RID: 3306 RVA: 0x03DCEDCC File Offset: 0x03DCD1CC
		' (set) Token: 0x06000CEB RID: 3307 RVA: 0x03DCEDE4 File Offset: 0x03DCD1E4
		Friend Overridable Property OpenProgramToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenProgramToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.OpenProgramToolStripMenuItem_Click
				Dim flag As Boolean = Me._OpenProgramToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._OpenProgramToolStripMenuItem.Click, eventHandler
				End If
				Me._OpenProgramToolStripMenuItem = value
				flag = Me._OpenProgramToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._OpenProgramToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000457 RID: 1111
		' (get) Token: 0x06000CEC RID: 3308 RVA: 0x03DCEE44 File Offset: 0x03DCD244
		' (set) Token: 0x06000CED RID: 3309 RVA: 0x03DCEE5C File Offset: 0x03DCD25C
		Friend Overridable Property OpenCMDWindowsToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenCMDWindowsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.OpenCMDWindowsToolStripMenuItem_Click
				Dim flag As Boolean = Me._OpenCMDWindowsToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._OpenCMDWindowsToolStripMenuItem.Click, eventHandler
				End If
				Me._OpenCMDWindowsToolStripMenuItem = value
				flag = Me._OpenCMDWindowsToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._OpenCMDWindowsToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000458 RID: 1112
		' (get) Token: 0x06000CEE RID: 3310 RVA: 0x03DCEEBC File Offset: 0x03DCD2BC
		' (set) Token: 0x06000CEF RID: 3311 RVA: 0x03DCEED4 File Offset: 0x03DCD2D4
		Friend Overridable Property Button22 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button22
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button22 = value
			End Set
		End Property

		' Token: 0x17000459 RID: 1113
		' (get) Token: 0x06000CF0 RID: 3312 RVA: 0x03DCEEE0 File Offset: 0x03DCD2E0
		' (set) Token: 0x06000CF1 RID: 3313 RVA: 0x03DCEEF8 File Offset: 0x03DCD2F8
		Friend Overridable Property Panel7 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel7 = value
			End Set
		End Property

		' Token: 0x1700045A RID: 1114
		' (get) Token: 0x06000CF2 RID: 3314 RVA: 0x03DCEF04 File Offset: 0x03DCD304
		' (set) Token: 0x06000CF3 RID: 3315 RVA: 0x03DCEF1C File Offset: 0x03DCD31C
		Friend Overridable Property Button23 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button23
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button23_Click
				Dim flag As Boolean = Me._Button23 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button23.Click, eventHandler
				End If
				Me._Button23 = value
				flag = Me._Button23 IsNot Nothing
				If flag Then
					AddHandler Me._Button23.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700045B RID: 1115
		' (get) Token: 0x06000CF4 RID: 3316 RVA: 0x03DCEF7C File Offset: 0x03DCD37C
		' (set) Token: 0x06000CF5 RID: 3317 RVA: 0x03DCEF94 File Offset: 0x03DCD394
		Friend Overridable Property Button25 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button25
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button25_Click
				Dim flag As Boolean = Me._Button25 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button25.Click, eventHandler
				End If
				Me._Button25 = value
				flag = Me._Button25 IsNot Nothing
				If flag Then
					AddHandler Me._Button25.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700045C RID: 1116
		' (get) Token: 0x06000CF6 RID: 3318 RVA: 0x03DCEFF4 File Offset: 0x03DCD3F4
		' (set) Token: 0x06000CF7 RID: 3319 RVA: 0x03DCF00C File Offset: 0x03DCD40C
		Friend Overridable Property Button24 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button24
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button24_Click
				Dim flag As Boolean = Me._Button24 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button24.Click, eventHandler
				End If
				Me._Button24 = value
				flag = Me._Button24 IsNot Nothing
				If flag Then
					AddHandler Me._Button24.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700045D RID: 1117
		' (get) Token: 0x06000CF8 RID: 3320 RVA: 0x03DCF06C File Offset: 0x03DCD46C
		' (set) Token: 0x06000CF9 RID: 3321 RVA: 0x03DCF084 File Offset: 0x03DCD484
		Friend Overridable Property Timer1 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._Timer1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim eventHandler As EventHandler = AddressOf Me.Timer1_Tick
				Dim flag As Boolean = Me._Timer1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Timer1.Tick, eventHandler
				End If
				Me._Timer1 = value
				flag = Me._Timer1 IsNot Nothing
				If flag Then
					AddHandler Me._Timer1.Tick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x06000CFA RID: 3322 RVA: 0x03DCF0E4 File Offset: 0x03DCD4E4
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox1.Show()
		End Sub

		' Token: 0x06000CFB RID: 3323 RVA: 0x03DCF0F8 File Offset: 0x03DCD4F8
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form18.Show()
		End Sub

		' Token: 0x06000CFC RID: 3324 RVA: 0x03DCF10C File Offset: 0x03DCD50C
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form5.Show()
		End Sub

		' Token: 0x06000CFD RID: 3325 RVA: 0x03DCF120 File Offset: 0x03DCD520
		Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form22.Show()
		End Sub

		' Token: 0x06000CFE RID: 3326 RVA: 0x03DCF134 File Offset: 0x03DCD534
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form15.Show()
		End Sub

		' Token: 0x06000CFF RID: 3327 RVA: 0x03DCF148 File Offset: 0x03DCD548
		Private Sub Button8_Click(sender As Object, e As EventArgs)
			Interaction.MsgBox("Fail to Open Menu", MsgBoxStyle.OkOnly, Nothing)
		End Sub

		' Token: 0x06000D00 RID: 3328 RVA: 0x03DCF15C File Offset: 0x03DCD55C
		Private Sub Button8_MouseClick(sender As Object, e As MouseEventArgs)
			Dim visible As Boolean = Me.Panel2.Visible
			If visible Then
				Me.Panel2.Visible = False
			Else
				Me.Panel2.Visible = True
			End If
		End Sub

		' Token: 0x06000D01 RID: 3329 RVA: 0x03DCF198 File Offset: 0x03DCD598
		Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000D02 RID: 3330 RVA: 0x03DCF1A4 File Offset: 0x03DCD5A4
		Private Sub Button12_Click(sender As Object, e As EventArgs)
			Dim visible As Boolean = Me.Panel3.Visible
			If visible Then
				Me.Panel3.Visible = False
			Else
				Me.Panel3.Visible = True
			End If
		End Sub

		' Token: 0x06000D03 RID: 3331 RVA: 0x03DCF1E0 File Offset: 0x03DCD5E0
		Private Sub Button11_Click(sender As Object, e As EventArgs)
			Dim visible As Boolean = Me.Panel4.Visible
			If visible Then
				Me.Panel4.Visible = False
			Else
				Me.Panel4.Visible = True
			End If
		End Sub

		' Token: 0x06000D04 RID: 3332 RVA: 0x03DCF21C File Offset: 0x03DCD61C
		Private Sub Button13_Click(sender As Object, e As EventArgs)
			Interaction.MsgBox("the program explorer.exe is replaced with Desktopcv.exe and Explorertaskbar.exe", MsgBoxStyle.Critical, Nothing)
			Dim visible As Boolean = MyProject.Forms.Form_1pad.Panel1.Visible
			If visible Then
				Interaction.MsgBox("Your Running New user interface", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		' Token: 0x06000D05 RID: 3333 RVA: 0x03DCF260 File Offset: 0x03DCD660
		Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form18.Show()
		End Sub

		' Token: 0x06000D06 RID: 3334 RVA: 0x03DCF274 File Offset: 0x03DCD674
		Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form22.Show()
		End Sub

		' Token: 0x06000D07 RID: 3335 RVA: 0x03DCF288 File Offset: 0x03DCD688
		Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
			Dim visible As Boolean = MyProject.Forms.Form_1pad.Panel1.Visible
			If visible Then
				MyProject.Forms.Form21.Show()
			Else
				MyProject.Forms.Form39.Show()
			End If
		End Sub

		' Token: 0x06000D08 RID: 3336 RVA: 0x03DCF2D4 File Offset: 0x03DCD6D4
		Private Sub Button17_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form19.Show()
		End Sub

		' Token: 0x06000D09 RID: 3337 RVA: 0x03DCF2E8 File Offset: 0x03DCD6E8
		Private Sub Button7_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form9.Show()
		End Sub

		' Token: 0x06000D0A RID: 3338 RVA: 0x03DCF2FC File Offset: 0x03DCD6FC
		Private Sub Button18_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form35.Show()
		End Sub

		' Token: 0x06000D0B RID: 3339 RVA: 0x03DCF310 File Offset: 0x03DCD710
		Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000D0C RID: 3340 RVA: 0x03DCF314 File Offset: 0x03DCD714
		Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox2.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000D0D RID: 3341 RVA: 0x03DCF32C File Offset: 0x03DCD72C
		Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox2.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000D0E RID: 3342 RVA: 0x03DCF344 File Offset: 0x03DCD744
		Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox3.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000D0F RID: 3343 RVA: 0x03DCF35C File Offset: 0x03DCD75C
		Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox3.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000D10 RID: 3344 RVA: 0x03DCF374 File Offset: 0x03DCD774
		Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox4.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000D11 RID: 3345 RVA: 0x03DCF38C File Offset: 0x03DCD78C
		Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox4.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000D12 RID: 3346 RVA: 0x03DCF3A4 File Offset: 0x03DCD7A4
		Private Sub Button6_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000D13 RID: 3347 RVA: 0x03DCF3B0 File Offset: 0x03DCD7B0
		Private Sub Button6_MouseEnter(sender As Object, e As EventArgs)
			Me.Button6.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000D14 RID: 3348 RVA: 0x03DCF3C8 File Offset: 0x03DCD7C8
		Private Sub Button6_MouseLeave(sender As Object, e As EventArgs)
			Me.Button6.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000D15 RID: 3349 RVA: 0x03DCF3E0 File Offset: 0x03DCD7E0
		Private Sub Button16_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.WindowState = FormWindowState.Normal
			If flag Then
				Me.WindowState = FormWindowState.Maximized
			Else
				Me.WindowState = FormWindowState.Normal
			End If
		End Sub

		' Token: 0x06000D16 RID: 3350 RVA: 0x03DCF410 File Offset: 0x03DCD810
		Private Sub Button16_MouseEnter(sender As Object, e As EventArgs)
			Me.Button16.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000D17 RID: 3351 RVA: 0x03DCF428 File Offset: 0x03DCD828
		Private Sub Button16_MouseLeave(sender As Object, e As EventArgs)
			Me.Button16.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000D18 RID: 3352 RVA: 0x03DCF440 File Offset: 0x03DCD840
		Private Sub Form31_Load(sender As Object, e As EventArgs)
			Dim flag As Boolean = MyProject.Forms.Form1.Button1.Visible
			If flag Then
				Interaction.MsgBox("New File explorer hates explorer for SCSW", MsgBoxStyle.OkOnly, Nothing)
				MyProject.Forms.Form3.Show()
				Me.Close()
			End If
			flag = MyProject.Forms.Form_1pad.startbutton1.Visible
			If flag Then
				Me.Panel7.Visible = True
			End If
		End Sub

		' Token: 0x06000D19 RID: 3353 RVA: 0x03DCF4B4 File Offset: 0x03DCD8B4
		Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form45.Show()
		End Sub

		' Token: 0x06000D1A RID: 3354 RVA: 0x03DCF4C8 File Offset: 0x03DCD8C8
		Private Sub Button21_Click(sender As Object, e As EventArgs)
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x06000D1B RID: 3355 RVA: 0x03DCF4D4 File Offset: 0x03DCD8D4
		Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs)
			' The following expression was wrapped in a checked-expression
			Me.mouse_move = New Point(0 - e.X, 0 - e.Y)
		End Sub

		' Token: 0x06000D1C RID: 3356 RVA: 0x03DCF4F4 File Offset: 0x03DCD8F4
		Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = e.Button = MouseButtons.Left
			If flag Then
				Dim mousePosition As Point = Control.MousePosition
				mousePosition.Offset(Me.mouse_move.X, Me.mouse_move.Y)
				Me.Location = mousePosition
			End If
		End Sub

		' Token: 0x06000D1D RID: 3357 RVA: 0x03DCF544 File Offset: 0x03DCD944
		Private Sub OpenProgramToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form41.Show()
		End Sub

		' Token: 0x06000D1E RID: 3358 RVA: 0x03DCF558 File Offset: 0x03DCD958
		Private Sub OpenCMDWindowsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Process.Start("cmd.exe")
		End Sub

		' Token: 0x06000D1F RID: 3359 RVA: 0x03DCF568 File Offset: 0x03DCD968
		Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Interaction.MsgBox("Error with Window", MsgBoxStyle.Critical, Nothing)
		End Sub

		' Token: 0x06000D20 RID: 3360 RVA: 0x03DCF57C File Offset: 0x03DCD97C
		Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Interaction.MsgBox("Error with Window", MsgBoxStyle.Critical, Nothing)
		End Sub

		' Token: 0x06000D21 RID: 3361 RVA: 0x03DCF590 File Offset: 0x03DCD990
		Private Sub OpenFileToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Explorer1.Show()
		End Sub

		' Token: 0x06000D22 RID: 3362 RVA: 0x03DCF5A4 File Offset: 0x03DCD9A4
		Private Sub closebutton_MouseEnter(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000D23 RID: 3363 RVA: 0x03DCF5A8 File Offset: 0x03DCD9A8
		Private Sub closebutton_MouseLeave(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000D24 RID: 3364 RVA: 0x03DCF5AC File Offset: 0x03DCD9AC
		Private Sub Button25_Click(sender As Object, e As EventArgs)
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x06000D25 RID: 3365 RVA: 0x03DCF5B8 File Offset: 0x03DCD9B8
		Private Sub Button24_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.WindowState = FormWindowState.Normal
			If flag Then
				Me.WindowState = FormWindowState.Maximized
			Else
				Me.WindowState = FormWindowState.Normal
			End If
		End Sub

		' Token: 0x06000D26 RID: 3366 RVA: 0x03DCF5E8 File Offset: 0x03DCD9E8
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Me.Panel7.BackColor = MyProject.Forms.Form_1pad.Panel1.BackColor
		End Sub

		' Token: 0x06000D27 RID: 3367 RVA: 0x03DCF60C File Offset: 0x03DCDA0C
		Private Sub Button23_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x040004A4 RID: 1188
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040004A6 RID: 1190
		<AccessedThroughProperty("Button11")>
		Private _Button11 As Button

		' Token: 0x040004A7 RID: 1191
		<AccessedThroughProperty("Panel4")>
		Private _Panel4 As Panel

		' Token: 0x040004A8 RID: 1192
		<AccessedThroughProperty("Button7")>
		Private _Button7 As Button

		' Token: 0x040004A9 RID: 1193
		<AccessedThroughProperty("Button20")>
		Private _Button20 As Button

		' Token: 0x040004AA RID: 1194
		<AccessedThroughProperty("Button19")>
		Private _Button19 As Button

		' Token: 0x040004AB RID: 1195
		<AccessedThroughProperty("Button18")>
		Private _Button18 As Button

		' Token: 0x040004AC RID: 1196
		<AccessedThroughProperty("Button17")>
		Private _Button17 As Button

		' Token: 0x040004AD RID: 1197
		<AccessedThroughProperty("Panel3")>
		Private _Panel3 As Panel

		' Token: 0x040004AE RID: 1198
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040004AF RID: 1199
		<AccessedThroughProperty("Button15")>
		Private _Button15 As Button

		' Token: 0x040004B0 RID: 1200
		<AccessedThroughProperty("Button14")>
		Private _Button14 As Button

		' Token: 0x040004B1 RID: 1201
		<AccessedThroughProperty("Button13")>
		Private _Button13 As Button

		' Token: 0x040004B2 RID: 1202
		<AccessedThroughProperty("Button12")>
		Private _Button12 As Button

		' Token: 0x040004B3 RID: 1203
		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel

		' Token: 0x040004B4 RID: 1204
		<AccessedThroughProperty("Button10")>
		Private _Button10 As Button

		' Token: 0x040004B5 RID: 1205
		<AccessedThroughProperty("Button9")>
		Private _Button9 As Button

		' Token: 0x040004B6 RID: 1206
		<AccessedThroughProperty("Button8")>
		Private _Button8 As Button

		' Token: 0x040004B7 RID: 1207
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x040004B8 RID: 1208
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x040004B9 RID: 1209
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x040004BA RID: 1210
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x040004BB RID: 1211
		<AccessedThroughProperty("MenuStrip1")>
		Private _MenuStrip1 As MenuStrip

		' Token: 0x040004BC RID: 1212
		<AccessedThroughProperty("FileToolStripMenuItem")>
		Private _FileToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040004BD RID: 1213
		<AccessedThroughProperty("EditToolStripMenuItem")>
		Private _EditToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040004BE RID: 1214
		<AccessedThroughProperty("FormatToolStripMenuItem")>
		Private _FormatToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040004BF RID: 1215
		<AccessedThroughProperty("ViewToolStripMenuItem")>
		Private _ViewToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040004C0 RID: 1216
		<AccessedThroughProperty("HelpToolStripMenuItem")>
		Private _HelpToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040004C1 RID: 1217
		<AccessedThroughProperty("AboutToolStripMenuItem")>
		Private _AboutToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040004C2 RID: 1218
		<AccessedThroughProperty("SaveToolStripMenuItem")>
		Private _SaveToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040004C3 RID: 1219
		<AccessedThroughProperty("ExitToolStripMenuItem")>
		Private _ExitToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040004C4 RID: 1220
		<AccessedThroughProperty("CutToolStripMenuItem")>
		Private _CutToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040004C5 RID: 1221
		<AccessedThroughProperty("CopyToolStripMenuItem")>
		Private _CopyToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040004C6 RID: 1222
		<AccessedThroughProperty("PasteToolStripMenuItem")>
		Private _PasteToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040004C7 RID: 1223
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x040004C8 RID: 1224
		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		' Token: 0x040004C9 RID: 1225
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x040004CA RID: 1226
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x040004CB RID: 1227
		<AccessedThroughProperty("Button16")>
		Private _Button16 As Button

		' Token: 0x040004CC RID: 1228
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x040004CD RID: 1229
		<AccessedThroughProperty("Panel5")>
		Private _Panel5 As Panel

		' Token: 0x040004CE RID: 1230
		<AccessedThroughProperty("Button21")>
		Private _Button21 As Button

		' Token: 0x040004CF RID: 1231
		<AccessedThroughProperty("Panel6")>
		Private _Panel6 As Panel

		' Token: 0x040004D0 RID: 1232
		<AccessedThroughProperty("OpenFileToolStripMenuItem1")>
		Private _OpenFileToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x040004D1 RID: 1233
		<AccessedThroughProperty("SaveToolStripMenuItem1")>
		Private _SaveToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x040004D2 RID: 1234
		<AccessedThroughProperty("ToolStripSeparator2")>
		Private _ToolStripSeparator2 As ToolStripSeparator

		' Token: 0x040004D3 RID: 1235
		<AccessedThroughProperty("OpenProgramToolStripMenuItem")>
		Private _OpenProgramToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040004D4 RID: 1236
		<AccessedThroughProperty("OpenCMDWindowsToolStripMenuItem")>
		Private _OpenCMDWindowsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040004D5 RID: 1237
		<AccessedThroughProperty("Button22")>
		Private _Button22 As Button

		' Token: 0x040004D6 RID: 1238
		<AccessedThroughProperty("Panel7")>
		Private _Panel7 As Panel

		' Token: 0x040004D7 RID: 1239
		<AccessedThroughProperty("Button23")>
		Private _Button23 As Button

		' Token: 0x040004D8 RID: 1240
		<AccessedThroughProperty("Button25")>
		Private _Button25 As Button

		' Token: 0x040004D9 RID: 1241
		<AccessedThroughProperty("Button24")>
		Private _Button24 As Button

		' Token: 0x040004DA RID: 1242
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x040004DB RID: 1243
		Private mouse_move As Point
	End Class
End Namespace
