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
	' Token: 0x02000032 RID: 50
	<DesignerGenerated()>
	Public Partial Class Form_1pad
		Inherits Form

		' Token: 0x0600046C RID: 1132 RVA: 0x03D946AC File Offset: 0x03D92AAC
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form_1pad_Load
			Dim _ENCList As List(Of WeakReference) = Form_1pad.__ENCList
			SyncLock _ENCList
				Form_1pad.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700017E RID: 382
		' (get) Token: 0x0600046F RID: 1135 RVA: 0x03D96B40 File Offset: 0x03D94F40
		' (set) Token: 0x06000470 RID: 1136 RVA: 0x03D96B58 File Offset: 0x03D94F58
		Friend Overridable Property Picture1 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Picture1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._Picture1 = value
			End Set
		End Property

		' Token: 0x1700017F RID: 383
		' (get) Token: 0x06000471 RID: 1137 RVA: 0x03D96B64 File Offset: 0x03D94F64
		' (set) Token: 0x06000472 RID: 1138 RVA: 0x03D96B7C File Offset: 0x03D94F7C
		Friend Overridable Property Panel1 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel1 = value
			End Set
		End Property

		' Token: 0x17000180 RID: 384
		' (get) Token: 0x06000473 RID: 1139 RVA: 0x03D96B88 File Offset: 0x03D94F88
		' (set) Token: 0x06000474 RID: 1140 RVA: 0x03D96BA0 File Offset: 0x03D94FA0
		Friend Overridable Property StartMenu As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._StartMenu
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim eventHandler As EventHandler = AddressOf Me.StartMenu_VisibleChanged
				Dim flag As Boolean = Me._StartMenu IsNot Nothing
				If flag Then
					RemoveHandler Me._StartMenu.VisibleChanged, eventHandler
				End If
				Me._StartMenu = value
				flag = Me._StartMenu IsNot Nothing
				If flag Then
					AddHandler Me._StartMenu.VisibleChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000181 RID: 385
		' (get) Token: 0x06000475 RID: 1141 RVA: 0x03D96C00 File Offset: 0x03D95000
		' (set) Token: 0x06000476 RID: 1142 RVA: 0x03D96C18 File Offset: 0x03D95018
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

		' Token: 0x17000182 RID: 386
		' (get) Token: 0x06000477 RID: 1143 RVA: 0x03D96C24 File Offset: 0x03D95024
		' (set) Token: 0x06000478 RID: 1144 RVA: 0x03D96C3C File Offset: 0x03D9503C
		Friend Overridable Property SegToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SegToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._SegToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000183 RID: 387
		' (get) Token: 0x06000479 RID: 1145 RVA: 0x03D96C48 File Offset: 0x03D95048
		' (set) Token: 0x0600047A RID: 1146 RVA: 0x03D96C60 File Offset: 0x03D95060
		Friend Overridable Property ToolStripMenuItem2 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.ToolStripMenuItem2_Click
				Dim flag As Boolean = Me._ToolStripMenuItem2 IsNot Nothing
				If flag Then
					RemoveHandler Me._ToolStripMenuItem2.Click, eventHandler
				End If
				Me._ToolStripMenuItem2 = value
				flag = Me._ToolStripMenuItem2 IsNot Nothing
				If flag Then
					AddHandler Me._ToolStripMenuItem2.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000184 RID: 388
		' (get) Token: 0x0600047B RID: 1147 RVA: 0x03D96CC0 File Offset: 0x03D950C0
		' (set) Token: 0x0600047C RID: 1148 RVA: 0x03D96CD8 File Offset: 0x03D950D8
		Friend Overridable Property ToolStripMenuItem3 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.ToolStripMenuItem3_Click
				Dim flag As Boolean = Me._ToolStripMenuItem3 IsNot Nothing
				If flag Then
					RemoveHandler Me._ToolStripMenuItem3.Click, eventHandler
				End If
				Me._ToolStripMenuItem3 = value
				flag = Me._ToolStripMenuItem3 IsNot Nothing
				If flag Then
					AddHandler Me._ToolStripMenuItem3.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000185 RID: 389
		' (get) Token: 0x0600047D RID: 1149 RVA: 0x03D96D38 File Offset: 0x03D95138
		' (set) Token: 0x0600047E RID: 1150 RVA: 0x03D96D50 File Offset: 0x03D95150
		Friend Overridable Property ToolStripMenuItem4 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.ToolStripMenuItem4_Click
				Dim flag As Boolean = Me._ToolStripMenuItem4 IsNot Nothing
				If flag Then
					RemoveHandler Me._ToolStripMenuItem4.Click, eventHandler
				End If
				Me._ToolStripMenuItem4 = value
				flag = Me._ToolStripMenuItem4 IsNot Nothing
				If flag Then
					AddHandler Me._ToolStripMenuItem4.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000186 RID: 390
		' (get) Token: 0x0600047F RID: 1151 RVA: 0x03D96DB0 File Offset: 0x03D951B0
		' (set) Token: 0x06000480 RID: 1152 RVA: 0x03D96DC8 File Offset: 0x03D951C8
		Friend Overridable Property ToolStripMenuItem5 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._ToolStripMenuItem5 = value
			End Set
		End Property

		' Token: 0x17000187 RID: 391
		' (get) Token: 0x06000481 RID: 1153 RVA: 0x03D96DD4 File Offset: 0x03D951D4
		' (set) Token: 0x06000482 RID: 1154 RVA: 0x03D96DEC File Offset: 0x03D951EC
		Friend Overridable Property ToolStripMenuItem6 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._ToolStripMenuItem6 = value
			End Set
		End Property

		' Token: 0x17000188 RID: 392
		' (get) Token: 0x06000483 RID: 1155 RVA: 0x03D96DF8 File Offset: 0x03D951F8
		' (set) Token: 0x06000484 RID: 1156 RVA: 0x03D96E10 File Offset: 0x03D95210
		Friend Overridable Property CloseToForm1pad15ToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CloseToForm1pad15ToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.CloseToForm1pad15ToolStripMenuItem_Click
				Dim flag As Boolean = Me._CloseToForm1pad15ToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._CloseToForm1pad15ToolStripMenuItem.Click, eventHandler
				End If
				Me._CloseToForm1pad15ToolStripMenuItem = value
				flag = Me._CloseToForm1pad15ToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._CloseToForm1pad15ToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000189 RID: 393
		' (get) Token: 0x06000485 RID: 1157 RVA: 0x03D96E70 File Offset: 0x03D95270
		' (set) Token: 0x06000486 RID: 1158 RVA: 0x03D96E88 File Offset: 0x03D95288
		Friend Overridable Property Button1 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button1_Click
				Dim flag As Boolean = Me._Button1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button1.Click, eventHandler
				End If
				Me._Button1 = value
				flag = Me._Button1 IsNot Nothing
				If flag Then
					AddHandler Me._Button1.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700018A RID: 394
		' (get) Token: 0x06000487 RID: 1159 RVA: 0x03D96EE8 File Offset: 0x03D952E8
		' (set) Token: 0x06000488 RID: 1160 RVA: 0x03D96F00 File Offset: 0x03D95300
		Friend Overridable Property PictureBox2 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox2_Click
				Dim flag As Boolean = Me._PictureBox2 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox2.Click, eventHandler
				End If
				Me._PictureBox2 = value
				flag = Me._PictureBox2 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox2.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700018B RID: 395
		' (get) Token: 0x06000489 RID: 1161 RVA: 0x03D96F60 File Offset: 0x03D95360
		' (set) Token: 0x0600048A RID: 1162 RVA: 0x03D96F78 File Offset: 0x03D95378
		Friend Overridable Property PictureBox4 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox4_Click
				Dim flag As Boolean = Me._PictureBox4 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox4.Click, eventHandler
				End If
				Me._PictureBox4 = value
				flag = Me._PictureBox4 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox4.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700018C RID: 396
		' (get) Token: 0x0600048B RID: 1163 RVA: 0x03D96FD8 File Offset: 0x03D953D8
		' (set) Token: 0x0600048C RID: 1164 RVA: 0x03D96FF0 File Offset: 0x03D953F0
		Friend Overridable Property startbutton1 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._startbutton1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox3_Click
				Dim flag As Boolean = Me._startbutton1 IsNot Nothing
				If flag Then
					RemoveHandler Me._startbutton1.Click, eventHandler
				End If
				Me._startbutton1 = value
				flag = Me._startbutton1 IsNot Nothing
				If flag Then
					AddHandler Me._startbutton1.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700018D RID: 397
		' (get) Token: 0x0600048D RID: 1165 RVA: 0x03D97050 File Offset: 0x03D95450
		' (set) Token: 0x0600048E RID: 1166 RVA: 0x03D97068 File Offset: 0x03D95468
		Friend Overridable Property startbutton2 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._startbutton2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox5_Click
				Dim flag As Boolean = Me._startbutton2 IsNot Nothing
				If flag Then
					RemoveHandler Me._startbutton2.Click, eventHandler
				End If
				Me._startbutton2 = value
				flag = Me._startbutton2 IsNot Nothing
				If flag Then
					AddHandler Me._startbutton2.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700018E RID: 398
		' (get) Token: 0x0600048F RID: 1167 RVA: 0x03D970C8 File Offset: 0x03D954C8
		' (set) Token: 0x06000490 RID: 1168 RVA: 0x03D970E0 File Offset: 0x03D954E0
		Friend Overridable Property PictureBox9 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox9_Click
				Dim flag As Boolean = Me._PictureBox9 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox9.Click, eventHandler
				End If
				Me._PictureBox9 = value
				flag = Me._PictureBox9 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox9.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700018F RID: 399
		' (get) Token: 0x06000491 RID: 1169 RVA: 0x03D97140 File Offset: 0x03D95540
		' (set) Token: 0x06000492 RID: 1170 RVA: 0x03D97158 File Offset: 0x03D95558
		Friend Overridable Property PictureBox13 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox13
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox13_Click
				Dim flag As Boolean = Me._PictureBox13 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox13.Click, eventHandler
				End If
				Me._PictureBox13 = value
				flag = Me._PictureBox13 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox13.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000190 RID: 400
		' (get) Token: 0x06000493 RID: 1171 RVA: 0x03D971B8 File Offset: 0x03D955B8
		' (set) Token: 0x06000494 RID: 1172 RVA: 0x03D971D0 File Offset: 0x03D955D0
		Friend Overridable Property PictureBox14 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox14
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox14_Click
				Dim flag As Boolean = Me._PictureBox14 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox14.Click, eventHandler
				End If
				Me._PictureBox14 = value
				flag = Me._PictureBox14 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox14.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000191 RID: 401
		' (get) Token: 0x06000495 RID: 1173 RVA: 0x03D97230 File Offset: 0x03D95630
		' (set) Token: 0x06000496 RID: 1174 RVA: 0x03D97248 File Offset: 0x03D95648
		Friend Overridable Property PictureBox15 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox15
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox15_Click
				Dim flag As Boolean = Me._PictureBox15 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox15.Click, eventHandler
				End If
				Me._PictureBox15 = value
				flag = Me._PictureBox15 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox15.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000192 RID: 402
		' (get) Token: 0x06000497 RID: 1175 RVA: 0x03D972A8 File Offset: 0x03D956A8
		' (set) Token: 0x06000498 RID: 1176 RVA: 0x03D972C0 File Offset: 0x03D956C0
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

		' Token: 0x17000193 RID: 403
		' (get) Token: 0x06000499 RID: 1177 RVA: 0x03D972CC File Offset: 0x03D956CC
		' (set) Token: 0x0600049A RID: 1178 RVA: 0x03D972E4 File Offset: 0x03D956E4
		Friend Overridable Property Label9 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim eventHandler As EventHandler = AddressOf Me.Label9_Click
				Dim flag As Boolean = Me._Label9 IsNot Nothing
				If flag Then
					RemoveHandler Me._Label9.Click, eventHandler
				End If
				Me._Label9 = value
				flag = Me._Label9 IsNot Nothing
				If flag Then
					AddHandler Me._Label9.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000194 RID: 404
		' (get) Token: 0x0600049B RID: 1179 RVA: 0x03D97344 File Offset: 0x03D95744
		' (set) Token: 0x0600049C RID: 1180 RVA: 0x03D9735C File Offset: 0x03D9575C
		Friend Overridable Property PictureBox11 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.Label9_Click
				Dim flag As Boolean = Me._PictureBox11 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox11.Click, eventHandler
				End If
				Me._PictureBox11 = value
				flag = Me._PictureBox11 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox11.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000195 RID: 405
		' (get) Token: 0x0600049D RID: 1181 RVA: 0x03D973BC File Offset: 0x03D957BC
		' (set) Token: 0x0600049E RID: 1182 RVA: 0x03D973D4 File Offset: 0x03D957D4
		Friend Overridable Property PictureBox12 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.Label9_Click
				Dim flag As Boolean = Me._PictureBox12 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox12.Click, eventHandler
				End If
				Me._PictureBox12 = value
				flag = Me._PictureBox12 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox12.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000196 RID: 406
		' (get) Token: 0x0600049F RID: 1183 RVA: 0x03D97434 File Offset: 0x03D95834
		' (set) Token: 0x060004A0 RID: 1184 RVA: 0x03D9744C File Offset: 0x03D9584C
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

		' Token: 0x17000197 RID: 407
		' (get) Token: 0x060004A1 RID: 1185 RVA: 0x03D974AC File Offset: 0x03D958AC
		' (set) Token: 0x060004A2 RID: 1186 RVA: 0x03D974C4 File Offset: 0x03D958C4
		Friend Overridable Property PictureBox18 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox18
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox18_Click
				Dim flag As Boolean = Me._PictureBox18 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox18.Click, eventHandler
				End If
				Me._PictureBox18 = value
				flag = Me._PictureBox18 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox18.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000198 RID: 408
		' (get) Token: 0x060004A3 RID: 1187 RVA: 0x03D97524 File Offset: 0x03D95924
		' (set) Token: 0x060004A4 RID: 1188 RVA: 0x03D9753C File Offset: 0x03D9593C
		Friend Overridable Property PictureBox3 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox3_Click_1
				Dim flag As Boolean = Me._PictureBox3 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox3.Click, eventHandler
				End If
				Me._PictureBox3 = value
				flag = Me._PictureBox3 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox3.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000199 RID: 409
		' (get) Token: 0x060004A5 RID: 1189 RVA: 0x03D9759C File Offset: 0x03D9599C
		' (set) Token: 0x060004A6 RID: 1190 RVA: 0x03D975B4 File Offset: 0x03D959B4
		Friend Overridable Property PictureBox5 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox5_Click_1
				Dim flag As Boolean = Me._PictureBox5 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox5.Click, eventHandler
				End If
				Me._PictureBox5 = value
				flag = Me._PictureBox5 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox5.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700019A RID: 410
		' (get) Token: 0x060004A7 RID: 1191 RVA: 0x03D97614 File Offset: 0x03D95A14
		' (set) Token: 0x060004A8 RID: 1192 RVA: 0x03D9762C File Offset: 0x03D95A2C
		Friend Overridable Property settings As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._settings
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.settings_Click
				Dim flag As Boolean = Me._settings IsNot Nothing
				If flag Then
					RemoveHandler Me._settings.Click, eventHandler
				End If
				Me._settings = value
				flag = Me._settings IsNot Nothing
				If flag Then
					AddHandler Me._settings.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700019B RID: 411
		' (get) Token: 0x060004A9 RID: 1193 RVA: 0x03D9768C File Offset: 0x03D95A8C
		' (set) Token: 0x060004AA RID: 1194 RVA: 0x03D976A4 File Offset: 0x03D95AA4
		Friend Overridable Property OpenProgram As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenProgram
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.OpenProgram_Click
				Dim flag As Boolean = Me._OpenProgram IsNot Nothing
				If flag Then
					RemoveHandler Me._OpenProgram.Click, eventHandler
				End If
				Me._OpenProgram = value
				flag = Me._OpenProgram IsNot Nothing
				If flag Then
					AddHandler Me._OpenProgram.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700019C RID: 412
		' (get) Token: 0x060004AB RID: 1195 RVA: 0x03D97704 File Offset: 0x03D95B04
		' (set) Token: 0x060004AC RID: 1196 RVA: 0x03D9771C File Offset: 0x03D95B1C
		Friend Overridable Property Textbutton As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Textbutton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.Textbutton_Click
				Dim flag As Boolean = Me._Textbutton IsNot Nothing
				If flag Then
					RemoveHandler Me._Textbutton.Click, eventHandler
				End If
				Me._Textbutton = value
				flag = Me._Textbutton IsNot Nothing
				If flag Then
					AddHandler Me._Textbutton.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700019D RID: 413
		' (get) Token: 0x060004AD RID: 1197 RVA: 0x03D9777C File Offset: 0x03D95B7C
		' (set) Token: 0x060004AE RID: 1198 RVA: 0x03D97794 File Offset: 0x03D95B94
		Friend Overridable Property PictureBox10 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox10_Click
				Dim flag As Boolean = Me._PictureBox10 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox10.Click, eventHandler
				End If
				Me._PictureBox10 = value
				flag = Me._PictureBox10 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox10.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700019E RID: 414
		' (get) Token: 0x060004AF RID: 1199 RVA: 0x03D977F4 File Offset: 0x03D95BF4
		' (set) Token: 0x060004B0 RID: 1200 RVA: 0x03D9780C File Offset: 0x03D95C0C
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

		' Token: 0x1700019F RID: 415
		' (get) Token: 0x060004B1 RID: 1201 RVA: 0x03D9786C File Offset: 0x03D95C6C
		' (set) Token: 0x060004B2 RID: 1202 RVA: 0x03D97884 File Offset: 0x03D95C84
		Friend Overridable Property Label1 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label1 = value
			End Set
		End Property

		' Token: 0x170001A0 RID: 416
		' (get) Token: 0x060004B3 RID: 1203 RVA: 0x03D97890 File Offset: 0x03D95C90
		' (set) Token: 0x060004B4 RID: 1204 RVA: 0x03D978A8 File Offset: 0x03D95CA8
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

		' Token: 0x170001A1 RID: 417
		' (get) Token: 0x060004B5 RID: 1205 RVA: 0x03D97908 File Offset: 0x03D95D08
		' (set) Token: 0x060004B6 RID: 1206 RVA: 0x03D97920 File Offset: 0x03D95D20
		Friend Overridable Property Label12 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label12 = value
			End Set
		End Property

		' Token: 0x170001A2 RID: 418
		' (get) Token: 0x060004B7 RID: 1207 RVA: 0x03D9792C File Offset: 0x03D95D2C
		' (set) Token: 0x060004B8 RID: 1208 RVA: 0x03D97944 File Offset: 0x03D95D44
		Friend Overridable Property PictureBox6 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox6 = value
			End Set
		End Property

		' Token: 0x170001A3 RID: 419
		' (get) Token: 0x060004B9 RID: 1209 RVA: 0x03D97950 File Offset: 0x03D95D50
		' (set) Token: 0x060004BA RID: 1210 RVA: 0x03D97968 File Offset: 0x03D95D68
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

		' Token: 0x170001A4 RID: 420
		' (get) Token: 0x060004BB RID: 1211 RVA: 0x03D979C8 File Offset: 0x03D95DC8
		' (set) Token: 0x060004BC RID: 1212 RVA: 0x03D979E0 File Offset: 0x03D95DE0
		Friend Overridable Property Button6 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button6_Click
				Dim flag As Boolean = Me._Button6 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button6.Click, eventHandler
				End If
				Me._Button6 = value
				flag = Me._Button6 IsNot Nothing
				If flag Then
					AddHandler Me._Button6.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001A5 RID: 421
		' (get) Token: 0x060004BD RID: 1213 RVA: 0x03D97A40 File Offset: 0x03D95E40
		' (set) Token: 0x060004BE RID: 1214 RVA: 0x03D97A58 File Offset: 0x03D95E58
		Friend Overridable Property Button9 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button9_Click
				Dim flag As Boolean = Me._Button9 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button9.Click, eventHandler
				End If
				Me._Button9 = value
				flag = Me._Button9 IsNot Nothing
				If flag Then
					AddHandler Me._Button9.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001A6 RID: 422
		' (get) Token: 0x060004BF RID: 1215 RVA: 0x03D97AB8 File Offset: 0x03D95EB8
		' (set) Token: 0x060004C0 RID: 1216 RVA: 0x03D97AD0 File Offset: 0x03D95ED0
		Friend Overridable Property Button8 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button8_Click_1
				Dim flag As Boolean = Me._Button8 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button8.Click, eventHandler
				End If
				Me._Button8 = value
				flag = Me._Button8 IsNot Nothing
				If flag Then
					AddHandler Me._Button8.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001A7 RID: 423
		' (get) Token: 0x060004C1 RID: 1217 RVA: 0x03D97B30 File Offset: 0x03D95F30
		' (set) Token: 0x060004C2 RID: 1218 RVA: 0x03D97B48 File Offset: 0x03D95F48
		Friend Overridable Property Button5 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button5_Click_1
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

		' Token: 0x170001A8 RID: 424
		' (get) Token: 0x060004C3 RID: 1219 RVA: 0x03D97BA8 File Offset: 0x03D95FA8
		' (set) Token: 0x060004C4 RID: 1220 RVA: 0x03D97BC0 File Offset: 0x03D95FC0
		Friend Overridable Property Button7 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button7_Click_1
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

		' Token: 0x170001A9 RID: 425
		' (get) Token: 0x060004C5 RID: 1221 RVA: 0x03D97C20 File Offset: 0x03D96020
		' (set) Token: 0x060004C6 RID: 1222 RVA: 0x03D97C38 File Offset: 0x03D96038
		Friend Overridable Property Button10 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button10_Click
				Dim flag As Boolean = Me._Button10 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button10.Click, eventHandler
				End If
				Me._Button10 = value
				flag = Me._Button10 IsNot Nothing
				If flag Then
					AddHandler Me._Button10.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001AA RID: 426
		' (get) Token: 0x060004C7 RID: 1223 RVA: 0x03D97C98 File Offset: 0x03D96098
		' (set) Token: 0x060004C8 RID: 1224 RVA: 0x03D97CB0 File Offset: 0x03D960B0
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

		' Token: 0x170001AB RID: 427
		' (get) Token: 0x060004C9 RID: 1225 RVA: 0x03D97D10 File Offset: 0x03D96110
		' (set) Token: 0x060004CA RID: 1226 RVA: 0x03D97D28 File Offset: 0x03D96128
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

		' Token: 0x060004CB RID: 1227 RVA: 0x03D97D88 File Offset: 0x03D96188
		Private Sub CloseToForm1pad15ToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MyProject.Forms.form1Pad.Show()
			Me.Close()
		End Sub

		' Token: 0x060004CC RID: 1228 RVA: 0x03D97DA4 File Offset: 0x03D961A4
		Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
			Me.StartMenu.Visible = True
		End Sub

		' Token: 0x060004CD RID: 1229 RVA: 0x03D97DB8 File Offset: 0x03D961B8
		Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)
			Me.StartMenu.Visible = False
		End Sub

		' Token: 0x060004CE RID: 1230 RVA: 0x03D97DCC File Offset: 0x03D961CC
		Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs)
			Dim visible As Boolean = Me.MenuStrip1.Visible
			If visible Then
				Me.MenuStrip1.Visible = False
				Me.StartMenu.Visible = False
			Else
				Me.MenuStrip1.Visible = True
				Me.StartMenu.Visible = False
			End If
		End Sub

		' Token: 0x060004CF RID: 1231 RVA: 0x03D97E24 File Offset: 0x03D96224
		Private Sub StartMenu_VisibleChanged(sender As Object, e As EventArgs)
			Me.Button1.Text = MyProject.Computer.Info.OSFullName
		End Sub

		' Token: 0x060004D0 RID: 1232 RVA: 0x03D97E44 File Offset: 0x03D96244
		Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form17.Show()
		End Sub

		' Token: 0x060004D1 RID: 1233 RVA: 0x03D97E58 File Offset: 0x03D96258
		Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form35.Show()
		End Sub

		' Token: 0x060004D2 RID: 1234 RVA: 0x03D97E6C File Offset: 0x03D9626C
		Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
			Me.StartMenu.Visible = True
			Me.startbutton2.Visible = True
		End Sub

		' Token: 0x060004D3 RID: 1235 RVA: 0x03D97E8C File Offset: 0x03D9628C
		Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
			Me.StartMenu.Visible = False
			Me.startbutton2.Visible = False
		End Sub

		' Token: 0x060004D4 RID: 1236 RVA: 0x03D97EAC File Offset: 0x03D962AC
		Private Sub PictureBox15_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form35.Show()
			MyProject.Forms.Form35.WebBrowser1.Navigate("https://sebs-sw-b.tk/info-sebs-sw-1.html")
		End Sub

		' Token: 0x060004D5 RID: 1237 RVA: 0x03D97EDC File Offset: 0x03D962DC
		Private Sub PictureBox14_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form20.Show()
		End Sub

		' Token: 0x060004D6 RID: 1238 RVA: 0x03D97EF0 File Offset: 0x03D962F0
		Private Sub PictureBox13_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form22.Show()
		End Sub

		' Token: 0x060004D7 RID: 1239 RVA: 0x03D97F04 File Offset: 0x03D96304
		Private Sub PictureBox9_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form60.Show()
		End Sub

		' Token: 0x060004D8 RID: 1240 RVA: 0x03D97F18 File Offset: 0x03D96318
		Private Sub Label9_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form17.Show()
		End Sub

		' Token: 0x060004D9 RID: 1241 RVA: 0x03D97F2C File Offset: 0x03D9632C
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form30.Show()
		End Sub

		' Token: 0x060004DA RID: 1242 RVA: 0x03D97F40 File Offset: 0x03D96340
		Private Sub PictureBox18_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form31.Show()
		End Sub

		' Token: 0x060004DB RID: 1243 RVA: 0x03D97F54 File Offset: 0x03D96354
		Private Sub OpenProgram_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form41.Show()
		End Sub

		' Token: 0x060004DC RID: 1244 RVA: 0x03D97F68 File Offset: 0x03D96368
		Private Sub settings_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form21.Show()
		End Sub

		' Token: 0x060004DD RID: 1245 RVA: 0x03D97F7C File Offset: 0x03D9637C
		Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs)
			MyProject.Forms.Form20.Show()
		End Sub

		' Token: 0x060004DE RID: 1246 RVA: 0x03D97F90 File Offset: 0x03D96390
		Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs)
			MyProject.Forms.Form31.Show()
		End Sub

		' Token: 0x060004DF RID: 1247 RVA: 0x03D97FA4 File Offset: 0x03D963A4
		Private Sub PictureBox10_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form33.Show()
			MyProject.Forms.Form33.Timer2.Start()
		End Sub

		' Token: 0x060004E0 RID: 1248 RVA: 0x03D97FD0 File Offset: 0x03D963D0
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.form1Pad.Show()
			Me.Close()
		End Sub

		' Token: 0x060004E1 RID: 1249 RVA: 0x03D97FEC File Offset: 0x03D963EC
		Private Sub Textbutton_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form15.Show()
		End Sub

		' Token: 0x060004E2 RID: 1250 RVA: 0x03D98000 File Offset: 0x03D96400
		Private Sub PictureBox16_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060004E3 RID: 1251 RVA: 0x03D98004 File Offset: 0x03D96404
		Private Sub Form_1pad_Load(sender As Object, e As EventArgs)
			MyProject.Forms.WASD.Show()
			easycode.Start_up_load()
		End Sub

		' Token: 0x060004E4 RID: 1252 RVA: 0x03D98020 File Offset: 0x03D96420
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Interaction.MsgBox(MyProject.Computer.Info.OSFullName, MsgBoxStyle.OkOnly, Nothing)
		End Sub

		' Token: 0x060004E5 RID: 1253 RVA: 0x03D9803C File Offset: 0x03D9643C
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Me.StartMenu.BackColor = Me.Panel1.BackColor
			Me.BackColor = Me.Panel1.BackColor
			Me.Label1.Text = Strings.Format(DateAndTime.Now, "HH:mm:ss")
		End Sub

		' Token: 0x060004E6 RID: 1254 RVA: 0x03D98094 File Offset: 0x03D96494
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form21.Show()
		End Sub

		' Token: 0x060004E7 RID: 1255 RVA: 0x03D980A8 File Offset: 0x03D964A8
		Private Sub PictureBox17_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form35.Show()
		End Sub

		' Token: 0x060004E8 RID: 1256 RVA: 0x03D980BC File Offset: 0x03D964BC
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form35.Show()
		End Sub

		' Token: 0x060004E9 RID: 1257 RVA: 0x03D980D0 File Offset: 0x03D964D0
		Private Sub Button7_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form60.Show()
		End Sub

		' Token: 0x060004EA RID: 1258 RVA: 0x03D980E4 File Offset: 0x03D964E4
		Private Sub Button8_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form22.Show()
		End Sub

		' Token: 0x060004EB RID: 1259 RVA: 0x03D980F8 File Offset: 0x03D964F8
		Private Sub Button6_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form31.Show()
		End Sub

		' Token: 0x060004EC RID: 1260 RVA: 0x03D9810C File Offset: 0x03D9650C
		Private Sub Button9_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form17.Show()
		End Sub

		' Token: 0x060004ED RID: 1261 RVA: 0x03D98120 File Offset: 0x03D96520
		Private Sub Button11_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form17.Show()
		End Sub

		' Token: 0x060004EE RID: 1262 RVA: 0x03D98134 File Offset: 0x03D96534
		Private Sub Button5_Click_1(sender As Object, e As EventArgs)
			MyProject.Forms.Form35.Show()
		End Sub

		' Token: 0x060004EF RID: 1263 RVA: 0x03D98148 File Offset: 0x03D96548
		Private Sub Button10_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form21.Show()
		End Sub

		' Token: 0x060004F0 RID: 1264 RVA: 0x03D9815C File Offset: 0x03D9655C
		Private Sub Button7_Click_1(sender As Object, e As EventArgs)
			MyProject.Forms.Form60.Show()
		End Sub

		' Token: 0x060004F1 RID: 1265 RVA: 0x03D98170 File Offset: 0x03D96570
		Private Sub Button8_Click_1(sender As Object, e As EventArgs)
			MyProject.Forms.Form22.Show()
		End Sub

		' Token: 0x060004F2 RID: 1266 RVA: 0x03D98184 File Offset: 0x03D96584
		Private Sub Button12_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form30.Show()
			MyProject.Forms.Form30.BackColor = Me.Panel1.BackColor
			MyProject.Forms.Form30.BackColor = Me.Panel1.BackColor
			MyProject.Forms.Form30.BackColor = Me.Panel1.BackColor
			MyProject.Forms.Form30.BackColor = Me.Panel1.BackColor
			MyProject.Forms.Form30.BackColor = Me.Panel1.BackColor
		End Sub

		' Token: 0x040001BD RID: 445
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040001BF RID: 447
		<AccessedThroughProperty("Picture1")>
		Private _Picture1 As PictureBox

		' Token: 0x040001C0 RID: 448
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x040001C1 RID: 449
		<AccessedThroughProperty("StartMenu")>
		Private _StartMenu As Panel

		' Token: 0x040001C2 RID: 450
		<AccessedThroughProperty("MenuStrip1")>
		Private _MenuStrip1 As MenuStrip

		' Token: 0x040001C3 RID: 451
		<AccessedThroughProperty("SegToolStripMenuItem")>
		Private _SegToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001C4 RID: 452
		<AccessedThroughProperty("ToolStripMenuItem2")>
		Private _ToolStripMenuItem2 As ToolStripMenuItem

		' Token: 0x040001C5 RID: 453
		<AccessedThroughProperty("ToolStripMenuItem3")>
		Private _ToolStripMenuItem3 As ToolStripMenuItem

		' Token: 0x040001C6 RID: 454
		<AccessedThroughProperty("ToolStripMenuItem4")>
		Private _ToolStripMenuItem4 As ToolStripMenuItem

		' Token: 0x040001C7 RID: 455
		<AccessedThroughProperty("ToolStripMenuItem5")>
		Private _ToolStripMenuItem5 As ToolStripMenuItem

		' Token: 0x040001C8 RID: 456
		<AccessedThroughProperty("ToolStripMenuItem6")>
		Private _ToolStripMenuItem6 As ToolStripMenuItem

		' Token: 0x040001C9 RID: 457
		<AccessedThroughProperty("CloseToForm1pad15ToolStripMenuItem")>
		Private _CloseToForm1pad15ToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001CA RID: 458
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040001CB RID: 459
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x040001CC RID: 460
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x040001CD RID: 461
		<AccessedThroughProperty("startbutton1")>
		Private _startbutton1 As PictureBox

		' Token: 0x040001CE RID: 462
		<AccessedThroughProperty("startbutton2")>
		Private _startbutton2 As PictureBox

		' Token: 0x040001CF RID: 463
		<AccessedThroughProperty("PictureBox9")>
		Private _PictureBox9 As PictureBox

		' Token: 0x040001D0 RID: 464
		<AccessedThroughProperty("PictureBox13")>
		Private _PictureBox13 As PictureBox

		' Token: 0x040001D1 RID: 465
		<AccessedThroughProperty("PictureBox14")>
		Private _PictureBox14 As PictureBox

		' Token: 0x040001D2 RID: 466
		<AccessedThroughProperty("PictureBox15")>
		Private _PictureBox15 As PictureBox

		' Token: 0x040001D3 RID: 467
		<AccessedThroughProperty("Panel5")>
		Private _Panel5 As Panel

		' Token: 0x040001D4 RID: 468
		<AccessedThroughProperty("Label9")>
		Private _Label9 As Label

		' Token: 0x040001D5 RID: 469
		<AccessedThroughProperty("PictureBox11")>
		Private _PictureBox11 As PictureBox

		' Token: 0x040001D6 RID: 470
		<AccessedThroughProperty("PictureBox12")>
		Private _PictureBox12 As PictureBox

		' Token: 0x040001D7 RID: 471
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x040001D8 RID: 472
		<AccessedThroughProperty("PictureBox18")>
		Private _PictureBox18 As PictureBox

		' Token: 0x040001D9 RID: 473
		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		' Token: 0x040001DA RID: 474
		<AccessedThroughProperty("PictureBox5")>
		Private _PictureBox5 As PictureBox

		' Token: 0x040001DB RID: 475
		<AccessedThroughProperty("settings")>
		Private _settings As PictureBox

		' Token: 0x040001DC RID: 476
		<AccessedThroughProperty("OpenProgram")>
		Private _OpenProgram As PictureBox

		' Token: 0x040001DD RID: 477
		<AccessedThroughProperty("Textbutton")>
		Private _Textbutton As PictureBox

		' Token: 0x040001DE RID: 478
		<AccessedThroughProperty("PictureBox10")>
		Private _PictureBox10 As PictureBox

		' Token: 0x040001DF RID: 479
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x040001E0 RID: 480
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x040001E1 RID: 481
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x040001E2 RID: 482
		<AccessedThroughProperty("Label12")>
		Private _Label12 As Label

		' Token: 0x040001E3 RID: 483
		<AccessedThroughProperty("PictureBox6")>
		Private _PictureBox6 As PictureBox

		' Token: 0x040001E4 RID: 484
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x040001E5 RID: 485
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x040001E6 RID: 486
		<AccessedThroughProperty("Button9")>
		Private _Button9 As Button

		' Token: 0x040001E7 RID: 487
		<AccessedThroughProperty("Button8")>
		Private _Button8 As Button

		' Token: 0x040001E8 RID: 488
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x040001E9 RID: 489
		<AccessedThroughProperty("Button7")>
		Private _Button7 As Button

		' Token: 0x040001EA RID: 490
		<AccessedThroughProperty("Button10")>
		Private _Button10 As Button

		' Token: 0x040001EB RID: 491
		<AccessedThroughProperty("Button12")>
		Private _Button12 As Button

		' Token: 0x040001EC RID: 492
		<AccessedThroughProperty("Button11")>
		Private _Button11 As Button
	End Class
End Namespace
