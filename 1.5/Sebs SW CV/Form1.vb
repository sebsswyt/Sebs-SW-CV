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
	' Token: 0x02000033 RID: 51
	<DesignerGenerated()>
	Public Partial Class Form1
		Inherits Form

		' Token: 0x060004F4 RID: 1268 RVA: 0x03D9823C File Offset: 0x03D9663C
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form1_Load
			Dim _ENCList As List(Of WeakReference) = Form1.__ENCList
			SyncLock _ENCList
				Form1.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170001AC RID: 428
		' (get) Token: 0x060004F7 RID: 1271 RVA: 0x03D9B588 File Offset: 0x03D99988
		' (set) Token: 0x060004F8 RID: 1272 RVA: 0x03D9B5A0 File Offset: 0x03D999A0
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

		' Token: 0x170001AD RID: 429
		' (get) Token: 0x060004F9 RID: 1273 RVA: 0x03D9B600 File Offset: 0x03D99A00
		' (set) Token: 0x060004FA RID: 1274 RVA: 0x03D9B618 File Offset: 0x03D99A18
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

		' Token: 0x170001AE RID: 430
		' (get) Token: 0x060004FB RID: 1275 RVA: 0x03D9B678 File Offset: 0x03D99A78
		' (set) Token: 0x060004FC RID: 1276 RVA: 0x03D9B690 File Offset: 0x03D99A90
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

		' Token: 0x170001AF RID: 431
		' (get) Token: 0x060004FD RID: 1277 RVA: 0x03D9B6F0 File Offset: 0x03D99AF0
		' (set) Token: 0x060004FE RID: 1278 RVA: 0x03D9B708 File Offset: 0x03D99B08
		Friend Overridable Property PictureBox2 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox2 = value
			End Set
		End Property

		' Token: 0x170001B0 RID: 432
		' (get) Token: 0x060004FF RID: 1279 RVA: 0x03D9B714 File Offset: 0x03D99B14
		' (set) Token: 0x06000500 RID: 1280 RVA: 0x03D9B72C File Offset: 0x03D99B2C
		Friend Overridable Property PictureBox3 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox3 = value
			End Set
		End Property

		' Token: 0x170001B1 RID: 433
		' (get) Token: 0x06000501 RID: 1281 RVA: 0x03D9B738 File Offset: 0x03D99B38
		' (set) Token: 0x06000502 RID: 1282 RVA: 0x03D9B750 File Offset: 0x03D99B50
		Friend Overridable Property Button4 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button4_Click_1
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

		' Token: 0x170001B2 RID: 434
		' (get) Token: 0x06000503 RID: 1283 RVA: 0x03D9B7B0 File Offset: 0x03D99BB0
		' (set) Token: 0x06000504 RID: 1284 RVA: 0x03D9B7C8 File Offset: 0x03D99BC8
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

		' Token: 0x170001B3 RID: 435
		' (get) Token: 0x06000505 RID: 1285 RVA: 0x03D9B828 File Offset: 0x03D99C28
		' (set) Token: 0x06000506 RID: 1286 RVA: 0x03D9B840 File Offset: 0x03D99C40
		Friend Overridable Property PictureBox4 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox4 = value
			End Set
		End Property

		' Token: 0x170001B4 RID: 436
		' (get) Token: 0x06000507 RID: 1287 RVA: 0x03D9B84C File Offset: 0x03D99C4C
		' (set) Token: 0x06000508 RID: 1288 RVA: 0x03D9B864 File Offset: 0x03D99C64
		Friend Overridable Property PictureBox5 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox5 = value
			End Set
		End Property

		' Token: 0x170001B5 RID: 437
		' (get) Token: 0x06000509 RID: 1289 RVA: 0x03D9B870 File Offset: 0x03D99C70
		' (set) Token: 0x0600050A RID: 1290 RVA: 0x03D9B888 File Offset: 0x03D99C88
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

		' Token: 0x170001B6 RID: 438
		' (get) Token: 0x0600050B RID: 1291 RVA: 0x03D9B894 File Offset: 0x03D99C94
		' (set) Token: 0x0600050C RID: 1292 RVA: 0x03D9B8AC File Offset: 0x03D99CAC
		Friend Overridable Property PictureBox7 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox7 = value
			End Set
		End Property

		' Token: 0x170001B7 RID: 439
		' (get) Token: 0x0600050D RID: 1293 RVA: 0x03D9B8B8 File Offset: 0x03D99CB8
		' (set) Token: 0x0600050E RID: 1294 RVA: 0x03D9B8D0 File Offset: 0x03D99CD0
		Friend Overridable Property PictureBox8 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox8 = value
			End Set
		End Property

		' Token: 0x170001B8 RID: 440
		' (get) Token: 0x0600050F RID: 1295 RVA: 0x03D9B8DC File Offset: 0x03D99CDC
		' (set) Token: 0x06000510 RID: 1296 RVA: 0x03D9B8F4 File Offset: 0x03D99CF4
		Friend Overridable Property PictureBox1 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox1 = value
			End Set
		End Property

		' Token: 0x170001B9 RID: 441
		' (get) Token: 0x06000511 RID: 1297 RVA: 0x03D9B900 File Offset: 0x03D99D00
		' (set) Token: 0x06000512 RID: 1298 RVA: 0x03D9B918 File Offset: 0x03D99D18
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

		' Token: 0x170001BA RID: 442
		' (get) Token: 0x06000513 RID: 1299 RVA: 0x03D9B978 File Offset: 0x03D99D78
		' (set) Token: 0x06000514 RID: 1300 RVA: 0x03D9B990 File Offset: 0x03D99D90
		Friend Overridable Property Button10 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button10_Click_2
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

		' Token: 0x170001BB RID: 443
		' (get) Token: 0x06000515 RID: 1301 RVA: 0x03D9B9F0 File Offset: 0x03D99DF0
		' (set) Token: 0x06000516 RID: 1302 RVA: 0x03D9BA08 File Offset: 0x03D99E08
		Friend Overridable Property PictureBox9 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox9 = value
			End Set
		End Property

		' Token: 0x170001BC RID: 444
		' (get) Token: 0x06000517 RID: 1303 RVA: 0x03D9BA14 File Offset: 0x03D99E14
		' (set) Token: 0x06000518 RID: 1304 RVA: 0x03D9BA2C File Offset: 0x03D99E2C
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

		' Token: 0x170001BD RID: 445
		' (get) Token: 0x06000519 RID: 1305 RVA: 0x03D9BA38 File Offset: 0x03D99E38
		' (set) Token: 0x0600051A RID: 1306 RVA: 0x03D9BA50 File Offset: 0x03D99E50
		Friend Overridable Property Button12 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button12_Click_1
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

		' Token: 0x170001BE RID: 446
		' (get) Token: 0x0600051B RID: 1307 RVA: 0x03D9BAB0 File Offset: 0x03D99EB0
		' (set) Token: 0x0600051C RID: 1308 RVA: 0x03D9BAC8 File Offset: 0x03D99EC8
		Friend Overridable Property ProgressBar2 As ProgressBar
			<DebuggerNonUserCode()>
			Get
				Return Me._ProgressBar2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ProgressBar)
				Me._ProgressBar2 = value
			End Set
		End Property

		' Token: 0x170001BF RID: 447
		' (get) Token: 0x0600051D RID: 1309 RVA: 0x03D9BAD4 File Offset: 0x03D99ED4
		' (set) Token: 0x0600051E RID: 1310 RVA: 0x03D9BAEC File Offset: 0x03D99EEC
		Friend Overridable Property Label3 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label3 = value
			End Set
		End Property

		' Token: 0x170001C0 RID: 448
		' (get) Token: 0x0600051F RID: 1311 RVA: 0x03D9BAF8 File Offset: 0x03D99EF8
		' (set) Token: 0x06000520 RID: 1312 RVA: 0x03D9BB10 File Offset: 0x03D99F10
		Friend Overridable Property Button13 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button13
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button13_Click_1
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

		' Token: 0x170001C1 RID: 449
		' (get) Token: 0x06000521 RID: 1313 RVA: 0x03D9BB70 File Offset: 0x03D99F70
		' (set) Token: 0x06000522 RID: 1314 RVA: 0x03D9BB88 File Offset: 0x03D99F88
		Friend Overridable Property Button14 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button14
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button14_Click_1
				Dim flag As Boolean = Me._Button14 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button14.Click, eventHandler
				End If
				Me._Button14 = value
				flag = Me._Button14 IsNot Nothing
				If flag Then
					AddHandler Me._Button14.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001C2 RID: 450
		' (get) Token: 0x06000523 RID: 1315 RVA: 0x03D9BBE8 File Offset: 0x03D99FE8
		' (set) Token: 0x06000524 RID: 1316 RVA: 0x03D9BC00 File Offset: 0x03D9A000
		Friend Overridable Property Label4 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label4 = value
			End Set
		End Property

		' Token: 0x170001C3 RID: 451
		' (get) Token: 0x06000525 RID: 1317 RVA: 0x03D9BC0C File Offset: 0x03D9A00C
		' (set) Token: 0x06000526 RID: 1318 RVA: 0x03D9BC24 File Offset: 0x03D9A024
		Friend Overridable Property Button15 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button15
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button15_Click_1
				Dim flag As Boolean = Me._Button15 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button15.Click, eventHandler
				End If
				Me._Button15 = value
				flag = Me._Button15 IsNot Nothing
				If flag Then
					AddHandler Me._Button15.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001C4 RID: 452
		' (get) Token: 0x06000527 RID: 1319 RVA: 0x03D9BC84 File Offset: 0x03D9A084
		' (set) Token: 0x06000528 RID: 1320 RVA: 0x03D9BC9C File Offset: 0x03D9A09C
		Friend Overridable Property Label1 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim eventHandler As EventHandler = AddressOf Me.Label1_Click
				Dim flag As Boolean = Me._Label1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Label1.Click, eventHandler
				End If
				Me._Label1 = value
				flag = Me._Label1 IsNot Nothing
				If flag Then
					AddHandler Me._Label1.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001C5 RID: 453
		' (get) Token: 0x06000529 RID: 1321 RVA: 0x03D9BCFC File Offset: 0x03D9A0FC
		' (set) Token: 0x0600052A RID: 1322 RVA: 0x03D9BD14 File Offset: 0x03D9A114
		Friend Overridable Property Label2 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim eventHandler As EventHandler = AddressOf Me.Label2_Click
				Dim flag As Boolean = Me._Label2 IsNot Nothing
				If flag Then
					RemoveHandler Me._Label2.Click, eventHandler
				End If
				Me._Label2 = value
				flag = Me._Label2 IsNot Nothing
				If flag Then
					AddHandler Me._Label2.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001C6 RID: 454
		' (get) Token: 0x0600052B RID: 1323 RVA: 0x03D9BD74 File Offset: 0x03D9A174
		' (set) Token: 0x0600052C RID: 1324 RVA: 0x03D9BD8C File Offset: 0x03D9A18C
		Friend Overridable Property Timer2 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._Timer2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim eventHandler As EventHandler = AddressOf Me.Timer2_Tick
				Dim flag As Boolean = Me._Timer2 IsNot Nothing
				If flag Then
					RemoveHandler Me._Timer2.Tick, eventHandler
				End If
				Me._Timer2 = value
				flag = Me._Timer2 IsNot Nothing
				If flag Then
					AddHandler Me._Timer2.Tick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001C7 RID: 455
		' (get) Token: 0x0600052D RID: 1325 RVA: 0x03D9BDEC File Offset: 0x03D9A1EC
		' (set) Token: 0x0600052E RID: 1326 RVA: 0x03D9BE04 File Offset: 0x03D9A204
		Friend Overridable Property Button5 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button5_Click_4
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

		' Token: 0x170001C8 RID: 456
		' (get) Token: 0x0600052F RID: 1327 RVA: 0x03D9BE64 File Offset: 0x03D9A264
		' (set) Token: 0x06000530 RID: 1328 RVA: 0x03D9BE7C File Offset: 0x03D9A27C
		Friend Overridable Property Button6 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button6 = value
			End Set
		End Property

		' Token: 0x170001C9 RID: 457
		' (get) Token: 0x06000531 RID: 1329 RVA: 0x03D9BE88 File Offset: 0x03D9A288
		' (set) Token: 0x06000532 RID: 1330 RVA: 0x03D9BEA0 File Offset: 0x03D9A2A0
		Friend Overridable Property Button8 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button8_Click_3
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

		' Token: 0x170001CA RID: 458
		' (get) Token: 0x06000533 RID: 1331 RVA: 0x03D9BF00 File Offset: 0x03D9A300
		' (set) Token: 0x06000534 RID: 1332 RVA: 0x03D9BF18 File Offset: 0x03D9A318
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

		' Token: 0x170001CB RID: 459
		' (get) Token: 0x06000535 RID: 1333 RVA: 0x03D9BF24 File Offset: 0x03D9A324
		' (set) Token: 0x06000536 RID: 1334 RVA: 0x03D9BF3C File Offset: 0x03D9A33C
		Friend Overridable Property Startbutton As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Startbutton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.Startbutton_Click
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.PictureBox10_MouseClick
				Dim flag As Boolean = Me._Startbutton IsNot Nothing
				If flag Then
					RemoveHandler Me._Startbutton.Click, eventHandler
					RemoveHandler Me._Startbutton.MouseClick, mouseEventHandler
				End If
				Me._Startbutton = value
				flag = Me._Startbutton IsNot Nothing
				If flag Then
					AddHandler Me._Startbutton.Click, eventHandler
					AddHandler Me._Startbutton.MouseClick, mouseEventHandler
				End If
			End Set
		End Property

		' Token: 0x170001CC RID: 460
		' (get) Token: 0x06000537 RID: 1335 RVA: 0x03D9BFC4 File Offset: 0x03D9A3C4
		' (set) Token: 0x06000538 RID: 1336 RVA: 0x03D9BFDC File Offset: 0x03D9A3DC
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

		' Token: 0x170001CD RID: 461
		' (get) Token: 0x06000539 RID: 1337 RVA: 0x03D9C03C File Offset: 0x03D9A43C
		' (set) Token: 0x0600053A RID: 1338 RVA: 0x03D9C054 File Offset: 0x03D9A454
		Friend Overridable Property PictureBox11 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox11_Click
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

		' Token: 0x170001CE RID: 462
		' (get) Token: 0x0600053B RID: 1339 RVA: 0x03D9C0B4 File Offset: 0x03D9A4B4
		' (set) Token: 0x0600053C RID: 1340 RVA: 0x03D9C0CC File Offset: 0x03D9A4CC
		Friend Overridable Property Label6 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim eventHandler As EventHandler = AddressOf Me.Label6_Click
				Dim flag As Boolean = Me._Label6 IsNot Nothing
				If flag Then
					RemoveHandler Me._Label6.Click, eventHandler
				End If
				Me._Label6 = value
				flag = Me._Label6 IsNot Nothing
				If flag Then
					AddHandler Me._Label6.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001CF RID: 463
		' (get) Token: 0x0600053D RID: 1341 RVA: 0x03D9C12C File Offset: 0x03D9A52C
		' (set) Token: 0x0600053E RID: 1342 RVA: 0x03D9C144 File Offset: 0x03D9A544
		Friend Overridable Property Label5 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label5 = value
			End Set
		End Property

		' Token: 0x170001D0 RID: 464
		' (get) Token: 0x0600053F RID: 1343 RVA: 0x03D9C150 File Offset: 0x03D9A550
		' (set) Token: 0x06000540 RID: 1344 RVA: 0x03D9C168 File Offset: 0x03D9A568
		Friend Overridable Property PictureBox12 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox12_Click
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

		' Token: 0x170001D1 RID: 465
		' (get) Token: 0x06000541 RID: 1345 RVA: 0x03D9C1C8 File Offset: 0x03D9A5C8
		' (set) Token: 0x06000542 RID: 1346 RVA: 0x03D9C1E0 File Offset: 0x03D9A5E0
		Friend Overridable Property Panel3 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim paintEventHandler As PaintEventHandler = AddressOf Me.Panel3_Paint
				Dim flag As Boolean = Me._Panel3 IsNot Nothing
				If flag Then
					RemoveHandler Me._Panel3.Paint, paintEventHandler
				End If
				Me._Panel3 = value
				flag = Me._Panel3 IsNot Nothing
				If flag Then
					AddHandler Me._Panel3.Paint, paintEventHandler
				End If
			End Set
		End Property

		' Token: 0x170001D2 RID: 466
		' (get) Token: 0x06000543 RID: 1347 RVA: 0x03D9C240 File Offset: 0x03D9A640
		' (set) Token: 0x06000544 RID: 1348 RVA: 0x03D9C258 File Offset: 0x03D9A658
		Friend Overridable Property startbutton2 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._startbutton2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.startbutton2_Click
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

		' Token: 0x170001D3 RID: 467
		' (get) Token: 0x06000545 RID: 1349 RVA: 0x03D9C2B8 File Offset: 0x03D9A6B8
		' (set) Token: 0x06000546 RID: 1350 RVA: 0x03D9C2D0 File Offset: 0x03D9A6D0
		Friend Overridable Property settings1 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._settings1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.settings1_Click
				Dim flag As Boolean = Me._settings1 IsNot Nothing
				If flag Then
					RemoveHandler Me._settings1.Click, eventHandler
				End If
				Me._settings1 = value
				flag = Me._settings1 IsNot Nothing
				If flag Then
					AddHandler Me._settings1.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001D4 RID: 468
		' (get) Token: 0x06000547 RID: 1351 RVA: 0x03D9C330 File Offset: 0x03D9A730
		' (set) Token: 0x06000548 RID: 1352 RVA: 0x03D9C348 File Offset: 0x03D9A748
		Friend Overridable Property lionsexplorer1 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._lionsexplorer1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.lionsexplorer1_Click
				Dim flag As Boolean = Me._lionsexplorer1 IsNot Nothing
				If flag Then
					RemoveHandler Me._lionsexplorer1.Click, eventHandler
				End If
				Me._lionsexplorer1 = value
				flag = Me._lionsexplorer1 IsNot Nothing
				If flag Then
					AddHandler Me._lionsexplorer1.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001D5 RID: 469
		' (get) Token: 0x06000549 RID: 1353 RVA: 0x03D9C3A8 File Offset: 0x03D9A7A8
		' (set) Token: 0x0600054A RID: 1354 RVA: 0x03D9C3C0 File Offset: 0x03D9A7C0
		Friend Overridable Property TextBox1 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim eventHandler As EventHandler = AddressOf Me.TextBox1_Enter
				Dim flag As Boolean = Me._TextBox1 IsNot Nothing
				If flag Then
					RemoveHandler Me._TextBox1.Enter, eventHandler
				End If
				Me._TextBox1 = value
				flag = Me._TextBox1 IsNot Nothing
				If flag Then
					AddHandler Me._TextBox1.Enter, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001D6 RID: 470
		' (get) Token: 0x0600054B RID: 1355 RVA: 0x03D9C420 File Offset: 0x03D9A820
		' (set) Token: 0x0600054C RID: 1356 RVA: 0x03D9C438 File Offset: 0x03D9A838
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

		' Token: 0x170001D7 RID: 471
		' (get) Token: 0x0600054D RID: 1357 RVA: 0x03D9C498 File Offset: 0x03D9A898
		' (set) Token: 0x0600054E RID: 1358 RVA: 0x03D9C4B0 File Offset: 0x03D9A8B0
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

		' Token: 0x170001D8 RID: 472
		' (get) Token: 0x0600054F RID: 1359 RVA: 0x03D9C510 File Offset: 0x03D9A910
		' (set) Token: 0x06000550 RID: 1360 RVA: 0x03D9C528 File Offset: 0x03D9A928
		Friend Overridable Property restartbutton As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._restartbutton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.restartbutton_Click
				Dim flag As Boolean = Me._restartbutton IsNot Nothing
				If flag Then
					RemoveHandler Me._restartbutton.Click, eventHandler
				End If
				Me._restartbutton = value
				flag = Me._restartbutton IsNot Nothing
				If flag Then
					AddHandler Me._restartbutton.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001D9 RID: 473
		' (get) Token: 0x06000551 RID: 1361 RVA: 0x03D9C588 File Offset: 0x03D9A988
		' (set) Token: 0x06000552 RID: 1362 RVA: 0x03D9C5A0 File Offset: 0x03D9A9A0
		Friend Overridable Property More As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._More
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.More_Click
				Dim flag As Boolean = Me._More IsNot Nothing
				If flag Then
					RemoveHandler Me._More.Click, eventHandler
				End If
				Me._More = value
				flag = Me._More IsNot Nothing
				If flag Then
					AddHandler Me._More.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001DA RID: 474
		' (get) Token: 0x06000553 RID: 1363 RVA: 0x03D9C600 File Offset: 0x03D9AA00
		' (set) Token: 0x06000554 RID: 1364 RVA: 0x03D9C618 File Offset: 0x03D9AA18
		Friend Overridable Property shutdownbutton As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._shutdownbutton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.shutdownbutton_Click
				Dim flag As Boolean = Me._shutdownbutton IsNot Nothing
				If flag Then
					RemoveHandler Me._shutdownbutton.Click, eventHandler
				End If
				Me._shutdownbutton = value
				flag = Me._shutdownbutton IsNot Nothing
				If flag Then
					AddHandler Me._shutdownbutton.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001DB RID: 475
		' (get) Token: 0x06000555 RID: 1365 RVA: 0x03D9C678 File Offset: 0x03D9AA78
		' (set) Token: 0x06000556 RID: 1366 RVA: 0x03D9C690 File Offset: 0x03D9AA90
		Friend Overridable Property Button9 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button9_Click_3
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

		' Token: 0x170001DC RID: 476
		' (get) Token: 0x06000557 RID: 1367 RVA: 0x03D9C6F0 File Offset: 0x03D9AAF0
		' (set) Token: 0x06000558 RID: 1368 RVA: 0x03D9C708 File Offset: 0x03D9AB08
		Friend Overridable Property Button11 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button11_Click_3
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

		' Token: 0x170001DD RID: 477
		' (get) Token: 0x06000559 RID: 1369 RVA: 0x03D9C768 File Offset: 0x03D9AB68
		' (set) Token: 0x0600055A RID: 1370 RVA: 0x03D9C780 File Offset: 0x03D9AB80
		Friend Overridable Property Button18 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button18
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button18_Click_1
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

		' Token: 0x170001DE RID: 478
		' (get) Token: 0x0600055B RID: 1371 RVA: 0x03D9C7E0 File Offset: 0x03D9ABE0
		' (set) Token: 0x0600055C RID: 1372 RVA: 0x03D9C7F8 File Offset: 0x03D9ABF8
		Friend Overridable Property Settinsp As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Settinsp
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.Settinsp_Click
				Dim flag As Boolean = Me._Settinsp IsNot Nothing
				If flag Then
					RemoveHandler Me._Settinsp.Click, eventHandler
				End If
				Me._Settinsp = value
				flag = Me._Settinsp IsNot Nothing
				If flag Then
					AddHandler Me._Settinsp.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001DF RID: 479
		' (get) Token: 0x0600055D RID: 1373 RVA: 0x03D9C858 File Offset: 0x03D9AC58
		' (set) Token: 0x0600055E RID: 1374 RVA: 0x03D9C870 File Offset: 0x03D9AC70
		Friend Overridable Property SearchFN As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._SearchFN
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim eventHandler As EventHandler = AddressOf Me.SearchFN_Tick
				Dim flag As Boolean = Me._SearchFN IsNot Nothing
				If flag Then
					RemoveHandler Me._SearchFN.Tick, eventHandler
				End If
				Me._SearchFN = value
				flag = Me._SearchFN IsNot Nothing
				If flag Then
					AddHandler Me._SearchFN.Tick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001E0 RID: 480
		' (get) Token: 0x0600055F RID: 1375 RVA: 0x03D9C8D0 File Offset: 0x03D9ACD0
		' (set) Token: 0x06000560 RID: 1376 RVA: 0x03D9C8E8 File Offset: 0x03D9ACE8
		Friend Overridable Property Timer3 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._Timer3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim eventHandler As EventHandler = AddressOf Me.Timer3_Tick
				Dim flag As Boolean = Me._Timer3 IsNot Nothing
				If flag Then
					RemoveHandler Me._Timer3.Tick, eventHandler
				End If
				Me._Timer3 = value
				flag = Me._Timer3 IsNot Nothing
				If flag Then
					AddHandler Me._Timer3.Tick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001E1 RID: 481
		' (get) Token: 0x06000561 RID: 1377 RVA: 0x03D9C948 File Offset: 0x03D9AD48
		' (set) Token: 0x06000562 RID: 1378 RVA: 0x03D9C960 File Offset: 0x03D9AD60
		Friend Overridable Property V As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._V
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._V = value
			End Set
		End Property

		' Token: 0x170001E2 RID: 482
		' (get) Token: 0x06000563 RID: 1379 RVA: 0x03D9C96C File Offset: 0x03D9AD6C
		' (set) Token: 0x06000564 RID: 1380 RVA: 0x03D9C984 File Offset: 0x03D9AD84
		Friend Overridable Property PictureBox16 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox16
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox16_Click
				Dim flag As Boolean = Me._PictureBox16 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox16.Click, eventHandler
				End If
				Me._PictureBox16 = value
				flag = Me._PictureBox16 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox16.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001E3 RID: 483
		' (get) Token: 0x06000565 RID: 1381 RVA: 0x03D9C9E4 File Offset: 0x03D9ADE4
		' (set) Token: 0x06000566 RID: 1382 RVA: 0x03D9C9FC File Offset: 0x03D9ADFC
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

		' Token: 0x170001E4 RID: 484
		' (get) Token: 0x06000567 RID: 1383 RVA: 0x03D9CA08 File Offset: 0x03D9AE08
		' (set) Token: 0x06000568 RID: 1384 RVA: 0x03D9CA20 File Offset: 0x03D9AE20
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

		' Token: 0x170001E5 RID: 485
		' (get) Token: 0x06000569 RID: 1385 RVA: 0x03D9CA80 File Offset: 0x03D9AE80
		' (set) Token: 0x0600056A RID: 1386 RVA: 0x03D9CA98 File Offset: 0x03D9AE98
		Friend Overridable Property PictureBox19 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox19
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox19_Click
				Dim flag As Boolean = Me._PictureBox19 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox19.Click, eventHandler
				End If
				Me._PictureBox19 = value
				flag = Me._PictureBox19 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox19.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001E6 RID: 486
		' (get) Token: 0x0600056B RID: 1387 RVA: 0x03D9CAF8 File Offset: 0x03D9AEF8
		' (set) Token: 0x0600056C RID: 1388 RVA: 0x03D9CB10 File Offset: 0x03D9AF10
		Friend Overridable Property PictureBox20 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox20
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox20_Click
				Dim flag As Boolean = Me._PictureBox20 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox20.Click, eventHandler
				End If
				Me._PictureBox20 = value
				flag = Me._PictureBox20 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox20.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001E7 RID: 487
		' (get) Token: 0x0600056D RID: 1389 RVA: 0x03D9CB70 File Offset: 0x03D9AF70
		' (set) Token: 0x0600056E RID: 1390 RVA: 0x03D9CB88 File Offset: 0x03D9AF88
		Friend Overridable Property StartBt As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._StartBt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox17_Click
				Dim flag As Boolean = Me._StartBt IsNot Nothing
				If flag Then
					RemoveHandler Me._StartBt.Click, eventHandler
				End If
				Me._StartBt = value
				flag = Me._StartBt IsNot Nothing
				If flag Then
					AddHandler Me._StartBt.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001E8 RID: 488
		' (get) Token: 0x0600056F RID: 1391 RVA: 0x03D9CBE8 File Offset: 0x03D9AFE8
		' (set) Token: 0x06000570 RID: 1392 RVA: 0x03D9CC00 File Offset: 0x03D9B000
		Friend Overridable Property Label8 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label8 = value
			End Set
		End Property

		' Token: 0x170001E9 RID: 489
		' (get) Token: 0x06000571 RID: 1393 RVA: 0x03D9CC0C File Offset: 0x03D9B00C
		' (set) Token: 0x06000572 RID: 1394 RVA: 0x03D9CC24 File Offset: 0x03D9B024
		Friend Overridable Property Label7 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label7 = value
			End Set
		End Property

		' Token: 0x170001EA RID: 490
		' (get) Token: 0x06000573 RID: 1395 RVA: 0x03D9CC30 File Offset: 0x03D9B030
		' (set) Token: 0x06000574 RID: 1396 RVA: 0x03D9CC48 File Offset: 0x03D9B048
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

		' Token: 0x170001EB RID: 491
		' (get) Token: 0x06000575 RID: 1397 RVA: 0x03D9CC54 File Offset: 0x03D9B054
		' (set) Token: 0x06000576 RID: 1398 RVA: 0x03D9CC6C File Offset: 0x03D9B06C
		Friend Overridable Property StartBF As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._StartBF
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.StartBF_Click
				Dim flag As Boolean = Me._StartBF IsNot Nothing
				If flag Then
					RemoveHandler Me._StartBF.Click, eventHandler
				End If
				Me._StartBF = value
				flag = Me._StartBF IsNot Nothing
				If flag Then
					AddHandler Me._StartBF.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001EC RID: 492
		' (get) Token: 0x06000577 RID: 1399 RVA: 0x03D9CCCC File Offset: 0x03D9B0CC
		' (set) Token: 0x06000578 RID: 1400 RVA: 0x03D9CCE4 File Offset: 0x03D9B0E4
		Friend Overridable Property PictureBox17 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox17
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox17_Click_1
				Dim flag As Boolean = Me._PictureBox17 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox17.Click, eventHandler
				End If
				Me._PictureBox17 = value
				flag = Me._PictureBox17 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox17.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001ED RID: 493
		' (get) Token: 0x06000579 RID: 1401 RVA: 0x03D9CD44 File Offset: 0x03D9B144
		' (set) Token: 0x0600057A RID: 1402 RVA: 0x03D9CD5C File Offset: 0x03D9B15C
		Friend Overridable Property Label9 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label9 = value
			End Set
		End Property

		' Token: 0x170001EE RID: 494
		' (get) Token: 0x0600057B RID: 1403 RVA: 0x03D9CD68 File Offset: 0x03D9B168
		' (set) Token: 0x0600057C RID: 1404 RVA: 0x03D9CD80 File Offset: 0x03D9B180
		Friend Overridable Property PictureBox13 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox13
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox13_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox13_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox13_Click_1
				Dim flag As Boolean = Me._PictureBox13 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox13.MouseLeave, eventHandler
					RemoveHandler Me._PictureBox13.MouseEnter, eventHandler2
					RemoveHandler Me._PictureBox13.Click, eventHandler3
				End If
				Me._PictureBox13 = value
				flag = Me._PictureBox13 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox13.MouseLeave, eventHandler
					AddHandler Me._PictureBox13.MouseEnter, eventHandler2
					AddHandler Me._PictureBox13.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x170001EF RID: 495
		' (get) Token: 0x0600057D RID: 1405 RVA: 0x03D9CE30 File Offset: 0x03D9B230
		' (set) Token: 0x0600057E RID: 1406 RVA: 0x03D9CE48 File Offset: 0x03D9B248
		Friend Overridable Property PictureBox21 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox21
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox21_Click
				Dim flag As Boolean = Me._PictureBox21 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox21.Click, eventHandler
				End If
				Me._PictureBox21 = value
				flag = Me._PictureBox21 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox21.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001F0 RID: 496
		' (get) Token: 0x0600057F RID: 1407 RVA: 0x03D9CEA8 File Offset: 0x03D9B2A8
		' (set) Token: 0x06000580 RID: 1408 RVA: 0x03D9CEC0 File Offset: 0x03D9B2C0
		Friend Overridable Property PictureBox22 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox22
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox22_Click
				Dim flag As Boolean = Me._PictureBox22 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox22.Click, eventHandler
				End If
				Me._PictureBox22 = value
				flag = Me._PictureBox22 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox22.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x06000581 RID: 1409 RVA: 0x03D9CF20 File Offset: 0x03D9B320
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form2.Show()
		End Sub

		' Token: 0x06000582 RID: 1410 RVA: 0x03D9CF34 File Offset: 0x03D9B334
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form3.Show()
		End Sub

		' Token: 0x06000583 RID: 1411 RVA: 0x03D9CF48 File Offset: 0x03D9B348
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Interaction.MsgBox("Sorry Lions explorer 1.0 and 2.0 are removed", MsgBoxStyle.OkOnly, Nothing)
		End Sub

		' Token: 0x06000584 RID: 1412 RVA: 0x03D9CF5C File Offset: 0x03D9B35C
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Explorer1.Show()
		End Sub

		' Token: 0x06000585 RID: 1413 RVA: 0x03D9CF70 File Offset: 0x03D9B370
		Private Sub Button5_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000586 RID: 1414 RVA: 0x03D9CF74 File Offset: 0x03D9B374
		Private Sub Button9_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000587 RID: 1415 RVA: 0x03D9CF78 File Offset: 0x03D9B378
		Private Sub Button8_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000588 RID: 1416 RVA: 0x03D9CF7C File Offset: 0x03D9B37C
		Private Sub Button11_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000589 RID: 1417 RVA: 0x03D9CF80 File Offset: 0x03D9B380
		Private Sub Button10_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600058A RID: 1418 RVA: 0x03D9CF84 File Offset: 0x03D9B384
		Private Sub Button4_Click_1(sender As Object, e As EventArgs)
			MyProject.Forms.backgroundBox1.Show()
		End Sub

		' Token: 0x0600058B RID: 1419 RVA: 0x03D9CF98 File Offset: 0x03D9B398
		Private Sub Button6_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600058C RID: 1420 RVA: 0x03D9CF9C File Offset: 0x03D9B39C
		Private Sub Button5_Click_1(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600058D RID: 1421 RVA: 0x03D9CFA0 File Offset: 0x03D9B3A0
		Private Sub Button7_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form14.Show()
		End Sub

		' Token: 0x0600058E RID: 1422 RVA: 0x03D9CFB4 File Offset: 0x03D9B3B4
		Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x0600058F RID: 1423 RVA: 0x03D9CFB8 File Offset: 0x03D9B3B8
		Private Sub Button14_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000590 RID: 1424 RVA: 0x03D9CFBC File Offset: 0x03D9B3BC
		Private Sub Button15_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000591 RID: 1425 RVA: 0x03D9CFC0 File Offset: 0x03D9B3C0
		Private Sub Button13_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000592 RID: 1426 RVA: 0x03D9CFC4 File Offset: 0x03D9B3C4
		Private Sub Button12_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000593 RID: 1427 RVA: 0x03D9CFC8 File Offset: 0x03D9B3C8
		Private Sub Button16_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000594 RID: 1428 RVA: 0x03D9CFCC File Offset: 0x03D9B3CC
		Private Sub Button17_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000595 RID: 1429 RVA: 0x03D9CFD0 File Offset: 0x03D9B3D0
		Private Sub Button5_Click_2(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000596 RID: 1430 RVA: 0x03D9CFD4 File Offset: 0x03D9B3D4
		Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x06000597 RID: 1431 RVA: 0x03D9CFD8 File Offset: 0x03D9B3D8
		Private Sub Button18_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000598 RID: 1432 RVA: 0x03D9CFDC File Offset: 0x03D9B3DC
		Private Sub Button19_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000599 RID: 1433 RVA: 0x03D9CFE0 File Offset: 0x03D9B3E0
		Private Sub Button11_Click_1(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600059A RID: 1434 RVA: 0x03D9CFE4 File Offset: 0x03D9B3E4
		Private Sub Button10_Click_1(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600059B RID: 1435 RVA: 0x03D9CFE8 File Offset: 0x03D9B3E8
		Private Sub Button8_Click_1(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600059C RID: 1436 RVA: 0x03D9CFEC File Offset: 0x03D9B3EC
		Private Sub Button6_Click_1(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600059D RID: 1437 RVA: 0x03D9CFF0 File Offset: 0x03D9B3F0
		Private Sub Button9_Click_1(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600059E RID: 1438 RVA: 0x03D9CFF4 File Offset: 0x03D9B3F4
		Private Sub Button5_Click_3(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600059F RID: 1439 RVA: 0x03D9CFF8 File Offset: 0x03D9B3F8
		Private Sub Button6_Click_2(sender As Object, e As EventArgs)
			MyProject.Forms.Form3.Close()
			MyProject.Forms.Form4.Close()
			MyProject.Forms.Form5.Close()
			MyProject.Forms.Form6.Close()
			MyProject.Forms.Form7.Close()
			MyProject.Forms.Explorer1.Close()
			MyProject.Forms.Explorer2.Close()
			MyProject.Forms.AboutBox1.Show()
			MyProject.Forms.AboutBox1.Close()
			MyProject.Forms.AboutBox3.Show()
			MyProject.Forms.AboutBox3.Close()
			MyProject.Forms.AboutBox5.Show()
			MyProject.Forms.AboutBox5.Close()
			MyProject.Forms.AboutBox7.Show()
			MyProject.Forms.AboutBox7.Close()
			MyProject.Forms.AboutBox8.Show()
			MyProject.Forms.AboutBox8.Close()
			MyProject.Forms.AboutBox9.Show()
			MyProject.Forms.AboutBox9.Close()
			MyProject.Forms.Form9.Close()
			MyProject.Forms.Form10.Close()
			MyProject.Forms.Form11.Close()
			MyProject.Forms.Form12.Close()
			MyProject.Forms.Form13.Close()
			MyProject.Forms.Form14.Close()
			MyProject.Forms.Form15.Close()
			MyProject.Forms.Form16.Close()
			MyProject.Forms.Form17.Close()
			MyProject.Forms.Form18.Close()
			MyProject.Forms.Form19.Close()
			MyProject.Forms.Form20.Close()
			MyProject.Forms.Form21.Close()
			MyProject.Forms.Errorbox1.Close()
			MyProject.Forms.Restartform.Show()
		End Sub

		' Token: 0x060005A0 RID: 1440 RVA: 0x03D9D228 File Offset: 0x03D9B628
		Private Sub Button8_Click_2(sender As Object, e As EventArgs)
			MyProject.Forms.Form9.Show()
		End Sub

		' Token: 0x060005A1 RID: 1441 RVA: 0x03D9D23C File Offset: 0x03D9B63C
		Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060005A2 RID: 1442 RVA: 0x03D9D240 File Offset: 0x03D9B640
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar2.Increment(3)
		End Sub

		' Token: 0x060005A3 RID: 1443 RVA: 0x03D9D254 File Offset: 0x03D9B654
		Private Sub Form1_Load(sender As Object, e As EventArgs)
			Me.Show()
			Dim flag As Boolean = Operators.CompareString(Me.V.Text, "???", False) = 0
			If flag Then
				Me.Panel1.Visible = False
			Else
				Me.Panel1.Visible = True
			End If
			Me.PictureBox2.Visible = False
			Me.PictureBox8.Visible = True
			flag = MyProject.Forms.Form29.PictureBox1.Visible
			If flag Then
				Me.PictureBox2.Visible = True
				Me.PictureBox3.Visible = False
				Me.PictureBox4.Visible = False
				Me.PictureBox5.Visible = False
				Me.PictureBox6.Visible = False
				Me.PictureBox7.Visible = False
				Me.PictureBox8.Visible = False
				Me.PictureBox9.Visible = False
				Me.WindowState = FormWindowState.Minimized
			End If
			flag = MyProject.Forms.Form29.PictureBox2.Visible
			If flag Then
				Me.PictureBox2.Visible = False
				Me.PictureBox3.Visible = True
				Me.PictureBox4.Visible = False
				Me.PictureBox5.Visible = False
				Me.PictureBox6.Visible = False
				Me.PictureBox7.Visible = False
				Me.PictureBox8.Visible = False
				Me.PictureBox9.Visible = False
				Me.WindowState = FormWindowState.Minimized
			End If
			flag = MyProject.Forms.Form29.PictureBox3.Visible
			If flag Then
				Me.PictureBox2.Visible = False
				Me.PictureBox3.Visible = False
				Me.PictureBox4.Visible = True
				Me.PictureBox5.Visible = False
				Me.PictureBox6.Visible = False
				Me.PictureBox7.Visible = False
				Me.PictureBox8.Visible = False
				Me.PictureBox9.Visible = False
				Me.WindowState = FormWindowState.Minimized
			End If
			flag = MyProject.Forms.Form29.PictureBox4.Visible
			If flag Then
				Me.PictureBox2.Visible = False
				Me.PictureBox3.Visible = False
				Me.PictureBox4.Visible = False
				Me.PictureBox5.Visible = True
				Me.PictureBox6.Visible = False
				Me.PictureBox7.Visible = False
				Me.PictureBox8.Visible = False
				Me.PictureBox9.Visible = False
				Me.WindowState = FormWindowState.Minimized
			End If
			flag = MyProject.Forms.Form29.PictureBox5.Visible
			If flag Then
				Me.PictureBox2.Visible = False
				Me.PictureBox3.Visible = False
				Me.PictureBox4.Visible = False
				Me.PictureBox5.Visible = False
				Me.PictureBox6.Visible = True
				Me.PictureBox7.Visible = False
				Me.PictureBox8.Visible = False
				Me.PictureBox9.Visible = False
				Me.WindowState = FormWindowState.Minimized
			End If
			flag = MyProject.Forms.Form29.PictureBox6.Visible
			If flag Then
				Me.PictureBox2.Visible = False
				Me.PictureBox3.Visible = False
				Me.PictureBox4.Visible = False
				Me.PictureBox5.Visible = False
				Me.PictureBox6.Visible = False
				Me.PictureBox7.Visible = True
				Me.PictureBox8.Visible = False
				Me.PictureBox9.Visible = False
				Me.WindowState = FormWindowState.Minimized
			End If
			flag = MyProject.Forms.Form29.PictureBox7.Visible
			If flag Then
				Me.PictureBox2.Visible = False
				Me.PictureBox3.Visible = False
				Me.PictureBox4.Visible = False
				Me.PictureBox5.Visible = False
				Me.PictureBox6.Visible = False
				Me.PictureBox7.Visible = False
				Me.PictureBox8.Visible = True
				Me.PictureBox9.Visible = False
				Me.WindowState = FormWindowState.Minimized
			End If
			flag = MyProject.Forms.Form29.PictureBox8.Visible
			If flag Then
				Me.PictureBox2.Visible = False
				Me.PictureBox3.Visible = False
				Me.PictureBox4.Visible = False
				Me.PictureBox5.Visible = False
				Me.PictureBox6.Visible = False
				Me.PictureBox7.Visible = False
				Me.PictureBox8.Visible = False
				Me.PictureBox9.Visible = True
				Me.WindowState = FormWindowState.Minimized
			End If
		End Sub

		' Token: 0x060005A4 RID: 1444 RVA: 0x03D9D708 File Offset: 0x03D9BB08
		Private Sub Button9_Click_2(sender As Object, e As EventArgs)
			MyProject.Forms.Form16.Show()
		End Sub

		' Token: 0x060005A5 RID: 1445 RVA: 0x03D9D71C File Offset: 0x03D9BB1C
		Private Sub Button10_Click_2(sender As Object, e As EventArgs)
			MyProject.Forms.Form35.Show()
		End Sub

		' Token: 0x060005A6 RID: 1446 RVA: 0x03D9D730 File Offset: 0x03D9BB30
		Private Sub Button11_Click_2(sender As Object, e As EventArgs)
			MyProject.Forms.Form19.Show()
		End Sub

		' Token: 0x060005A7 RID: 1447 RVA: 0x03D9D744 File Offset: 0x03D9BB44
		Private Sub Button14_Click_1(sender As Object, e As EventArgs)
			Me.Timer1.Start()
			Me.Button14.Text = "Click her"
			Dim flag As Boolean = Me.ProgressBar2.Value = 100
			If flag Then
				Me.Button13.Visible = True
				Me.Button14.Text = "No click her"
			End If
		End Sub

		' Token: 0x060005A8 RID: 1448 RVA: 0x03D9D7A4 File Offset: 0x03D9BBA4
		Private Sub Button12_Click_1(sender As Object, e As EventArgs)
			MyProject.Forms.Form16.Show()
		End Sub

		' Token: 0x060005A9 RID: 1449 RVA: 0x03D9D7B8 File Offset: 0x03D9BBB8
		Private Sub Button13_Click_1(sender As Object, e As EventArgs)
			MyProject.Forms.Restartform.Show()
		End Sub

		' Token: 0x060005AA RID: 1450 RVA: 0x03D9D7CC File Offset: 0x03D9BBCC
		Private Sub Button15_Click_1(sender As Object, e As EventArgs)
			MyProject.Forms.Errorbox1.Show()
			MyProject.Forms.Errorbox1.al.Text = "Bug fix program remove from Sebs SW"
			MyProject.Forms.Errorbox1.Text = "remove from Sebs SW"
		End Sub

		' Token: 0x060005AB RID: 1451 RVA: 0x03D9D81C File Offset: 0x03D9BC1C
		Private Sub Button16_Click_1(sender As Object, e As EventArgs)
			MyProject.Forms.Form9.Show()
		End Sub

		' Token: 0x060005AC RID: 1452 RVA: 0x03D9D830 File Offset: 0x03D9BC30
		Private Sub Button17_Click_1(sender As Object, e As EventArgs)
			MyProject.Forms.Form19.Show()
		End Sub

		' Token: 0x060005AD RID: 1453 RVA: 0x03D9D844 File Offset: 0x03D9BC44
		Private Sub Timer2_Tick(sender As Object, e As EventArgs)
			Me.Label2.Text = Strings.Format(DateAndTime.Now, "HH:mm:ss")
			Me.Label1.Text = Strings.Format(DateAndTime.Now, "dddd MMMM yyyy")
			Me.Label6.Text = Strings.Format(DateAndTime.Now, "HH:mm:ss")
			Me.Label5.Text = Strings.Format(DateAndTime.Now, "dddd MMMM yyyy")
		End Sub

		' Token: 0x060005AE RID: 1454 RVA: 0x03D9D8D4 File Offset: 0x03D9BCD4
		Private Sub Label1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060005AF RID: 1455 RVA: 0x03D9D8D8 File Offset: 0x03D9BCD8
		Private Sub Button5_Click_4(sender As Object, e As EventArgs)
			MyProject.Forms.Form27.Show()
			MyProject.Forms.Form27.Label1.Text = "???"
		End Sub

		' Token: 0x060005B0 RID: 1456 RVA: 0x03D9D908 File Offset: 0x03D9BD08
		Private Sub Button8_Click_3(sender As Object, e As EventArgs)
			MyProject.Forms.Form23.Show()
		End Sub

		' Token: 0x060005B1 RID: 1457 RVA: 0x03D9D91C File Offset: 0x03D9BD1C
		Private Sub PictureBox10_MouseClick(sender As Object, e As MouseEventArgs)
		End Sub

		' Token: 0x060005B2 RID: 1458 RVA: 0x03D9D920 File Offset: 0x03D9BD20
		Private Sub PictureBox10_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form35.Show()
		End Sub

		' Token: 0x060005B3 RID: 1459 RVA: 0x03D9D934 File Offset: 0x03D9BD34
		Private Sub PictureBox11_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form31.Show()
		End Sub

		' Token: 0x060005B4 RID: 1460 RVA: 0x03D9D948 File Offset: 0x03D9BD48
		Private Sub Label2_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060005B5 RID: 1461 RVA: 0x03D9D94C File Offset: 0x03D9BD4C
		Private Sub Label6_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060005B6 RID: 1462 RVA: 0x03D9D950 File Offset: 0x03D9BD50
		Private Sub PictureBox12_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form5.Show()
		End Sub

		' Token: 0x060005B7 RID: 1463 RVA: 0x03D9D964 File Offset: 0x03D9BD64
		Private Sub Startbutton_Click(sender As Object, e As EventArgs)
			Me.Panel3.Visible = True
			Me.SearchFN.Start()
			Me.startbutton2.Visible = True
			Me.Startbutton.Visible = False
			Dim visible As Boolean = Me.PictureBox9.Visible
			If visible Then
				Me.Panel3.BackColor = Color.DimGray
			Else
				Me.Panel3.BackColor = Color.DarkGray
			End If
		End Sub

		' Token: 0x060005B8 RID: 1464 RVA: 0x03D9D9DC File Offset: 0x03D9BDDC
		Private Sub startbutton2_Click(sender As Object, e As EventArgs)
			Me.Panel3.Visible = False
			Me.SearchFN.[Stop]()
			Me.startbutton2.Visible = False
			Me.Startbutton.Visible = True
		End Sub

		' Token: 0x060005B9 RID: 1465 RVA: 0x03D9DA14 File Offset: 0x03D9BE14
		Private Sub settings1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form39.Show()
		End Sub

		' Token: 0x060005BA RID: 1466 RVA: 0x03D9DA28 File Offset: 0x03D9BE28
		Private Sub lionsexplorer1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form35.Show()
		End Sub

		' Token: 0x060005BB RID: 1467 RVA: 0x03D9DA3C File Offset: 0x03D9BE3C
		Private Sub PictureBox13_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form35.Show()
		End Sub

		' Token: 0x060005BC RID: 1468 RVA: 0x03D9DA50 File Offset: 0x03D9BE50
		Private Sub PictureBox14_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form35.Show()
		End Sub

		' Token: 0x060005BD RID: 1469 RVA: 0x03D9DA64 File Offset: 0x03D9BE64
		Private Sub PictureBox15_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form5.Show()
		End Sub

		' Token: 0x060005BE RID: 1470 RVA: 0x03D9DA78 File Offset: 0x03D9BE78
		Private Sub TextBox1_Enter(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.TextBox1.Text, "web", False) = 0
			If flag Then
				Me.PictureBox14.Visible = True
			Else
				Me.PictureBox14.Visible = False
			End If
			flag = Operators.CompareString(Me.TextBox1.Text, "settings", False) = 0
			If flag Then
				Me.PictureBox15.Visible = True
			Else
				Me.PictureBox15.Visible = False
			End If
		End Sub

		' Token: 0x060005BF RID: 1471 RVA: 0x03D9DB00 File Offset: 0x03D9BF00
		Private Sub More_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Me.shutdownbutton.Visible
			If flag Then
				Me.shutdownbutton.Visible = True
				Me.restartbutton.Visible = True
			Else
				Me.shutdownbutton.Visible = False
				Me.restartbutton.Visible = False
			End If
		End Sub

		' Token: 0x060005C0 RID: 1472 RVA: 0x03D9DB5C File Offset: 0x03D9BF5C
		Private Sub restartbutton_Click(sender As Object, e As EventArgs)
			Interaction.MsgBox("Sorry. Restart the program in settings or New Start menu on form1pad", MsgBoxStyle.OkOnly, Nothing)
		End Sub

		' Token: 0x060005C1 RID: 1473 RVA: 0x03D9DB70 File Offset: 0x03D9BF70
		Private Sub Button9_Click_3(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.TextBox1.Text, "run", False) = 0
			If flag Then
				Me.Button11.Visible = True
			Else
				Me.Button11.Visible = False
			End If
			flag = Operators.CompareString(Me.TextBox1.Text, "Run", False) = 0
			If flag Then
				Me.Button11.Visible = True
			Else
				Me.Button11.Visible = False
			End If
		End Sub

		' Token: 0x060005C2 RID: 1474 RVA: 0x03D9DBF8 File Offset: 0x03D9BFF8
		Private Sub Button11_Click_3(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox17.Show()
			MyProject.Forms.AboutBox17.Button10.Enabled = False
		End Sub

		' Token: 0x060005C3 RID: 1475 RVA: 0x03D9DC24 File Offset: 0x03D9C024
		Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x060005C4 RID: 1476 RVA: 0x03D9DC28 File Offset: 0x03D9C028
		Private Sub Button18_Click_1(sender As Object, e As EventArgs)
			MyProject.Forms.Form37.Show()
			MyProject.Forms.Form37.TextBox1.Text = "You can click on the start button " & vbCrLf & "and now you can see all your Programs " & vbCrLf & "do you want to see the web " & vbCrLf & "click on the Lion "
		End Sub

		' Token: 0x060005C5 RID: 1477 RVA: 0x03D9DC58 File Offset: 0x03D9C058
		Private Sub shutdownbutton_Click(sender As Object, e As EventArgs)
			Interaction.MsgBox("Sorry. Shutdown the program in settings or New Start menu on form1pad", MsgBoxStyle.OkOnly, Nothing)
		End Sub

		' Token: 0x060005C6 RID: 1478 RVA: 0x03D9DC6C File Offset: 0x03D9C06C
		Private Sub Settinsp_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form21.Show()
		End Sub

		' Token: 0x060005C7 RID: 1479 RVA: 0x03D9DC80 File Offset: 0x03D9C080
		Private Sub SearchFN_Tick(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.TextBox1.Text, "web", False) = 0
			If flag Then
				Me.PictureBox14.Visible = True
			Else
				Me.PictureBox14.Visible = False
			End If
			flag = Operators.CompareString(Me.TextBox1.Text, "42", False) = 0
			If flag Then
				MyProject.Forms.Form42.Show()
				Me.TextBox1.Text = ""
			End If
			flag = Operators.CompareString(Me.TextBox1.Text, "vc", False) = 0
			If flag Then
				MyProject.Forms.Form38.Show()
				Me.TextBox1.Text = ""
			End If
			flag = Operators.CompareString(Me.TextBox1.Text, "webpad", False) = 0
			If flag Then
				Me.PictureBox13.Visible = True
			Else
				Me.PictureBox13.Visible = False
			End If
			flag = Operators.CompareString(Me.TextBox1.Text, "settings", False) = 0
			If flag Then
				Me.PictureBox15.Visible = True
			Else
				Me.PictureBox15.Visible = False
			End If
			flag = Operators.CompareString(Me.TextBox1.Text, "settings1", False) = 0
			If flag Then
				Me.Settinsp.Visible = True
			Else
				Me.Settinsp.Visible = False
			End If
			flag = Operators.CompareString(Me.TextBox1.Text, "settings2", False) = 0
			If flag Then
				MyProject.Forms.Form20.Show()
			End If
			flag = Operators.CompareString(Me.TextBox1.Text, "Update", False) = 0
			If flag Then
				MyProject.Forms.updaterform1.Show()
			Else
				Me.SearchFN.Start()
			End If
		End Sub

		' Token: 0x060005C8 RID: 1480 RVA: 0x03D9DE64 File Offset: 0x03D9C264
		Private Sub Timer3_Tick(sender As Object, e As EventArgs)
			Dim visible As Boolean = Me.Panel1.Visible
			If visible Then
				Me.Panel1.Visible = False
			End If
			MyProject.Forms.Form2.Button7.Enabled = True
			MyProject.Forms.Form2.Button4.Enabled = True
			MyProject.Forms.Form2.Button1.Enabled = True
			MyProject.Forms.Form2.Button3.Enabled = True
		End Sub

		' Token: 0x060005C9 RID: 1481 RVA: 0x03D9DEE8 File Offset: 0x03D9C2E8
		Private Sub PictureBox16_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form21.Show()
		End Sub

		' Token: 0x060005CA RID: 1482 RVA: 0x03D9DEFC File Offset: 0x03D9C2FC
		Private Sub PictureBox17_Click(sender As Object, e As EventArgs)
			Me.StartBF.Visible = True
			Me.StartBt.Visible = False
			Me.Panel3.Visible = False
			Me.Panel5.Visible = True
		End Sub

		' Token: 0x060005CB RID: 1483 RVA: 0x03D9DF34 File Offset: 0x03D9C334
		Private Sub StartBF_Click(sender As Object, e As EventArgs)
			Me.StartBF.Visible = False
			Me.StartBt.Visible = True
			Me.Panel5.Visible = False
		End Sub

		' Token: 0x060005CC RID: 1484 RVA: 0x03D9DF60 File Offset: 0x03D9C360
		Private Sub PictureBox20_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form35.Show()
		End Sub

		' Token: 0x060005CD RID: 1485 RVA: 0x03D9DF74 File Offset: 0x03D9C374
		Private Sub PictureBox19_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form31.Show()
		End Sub

		' Token: 0x060005CE RID: 1486 RVA: 0x03D9DF88 File Offset: 0x03D9C388
		Private Sub PictureBox18_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form21.Show()
		End Sub

		' Token: 0x060005CF RID: 1487 RVA: 0x03D9DF9C File Offset: 0x03D9C39C
		Private Sub PictureBox13_Click_1(sender As Object, e As EventArgs)
			MyProject.Forms.Form35.Show()
		End Sub

		' Token: 0x060005D0 RID: 1488 RVA: 0x03D9DFB0 File Offset: 0x03D9C3B0
		Private Sub PictureBox13_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox13.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x060005D1 RID: 1489 RVA: 0x03D9DFC8 File Offset: 0x03D9C3C8
		Private Sub PictureBox13_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox13.BackColor = Color.Transparent
		End Sub

		' Token: 0x060005D2 RID: 1490 RVA: 0x03D9DFE0 File Offset: 0x03D9C3E0
		Private Sub PictureBox22_Click(sender As Object, e As EventArgs)
			MyProject.Forms.form1Pad.Show()
		End Sub

		' Token: 0x060005D3 RID: 1491 RVA: 0x03D9DFF4 File Offset: 0x03D9C3F4
		Private Sub PictureBox21_Click(sender As Object, e As EventArgs)
			MyProject.Forms.form1Pad.Show()
		End Sub

		' Token: 0x060005D4 RID: 1492 RVA: 0x03D9E008 File Offset: 0x03D9C408
		Private Sub PictureBox17_Click_1(sender As Object, e As EventArgs)
			MyProject.Forms.Form21.Show()
		End Sub

		' Token: 0x040001ED RID: 493
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040001EF RID: 495
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040001F0 RID: 496
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x040001F1 RID: 497
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x040001F2 RID: 498
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x040001F3 RID: 499
		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		' Token: 0x040001F4 RID: 500
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x040001F5 RID: 501
		<AccessedThroughProperty("Button7")>
		Private _Button7 As Button

		' Token: 0x040001F6 RID: 502
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x040001F7 RID: 503
		<AccessedThroughProperty("PictureBox5")>
		Private _PictureBox5 As PictureBox

		' Token: 0x040001F8 RID: 504
		<AccessedThroughProperty("PictureBox6")>
		Private _PictureBox6 As PictureBox

		' Token: 0x040001F9 RID: 505
		<AccessedThroughProperty("PictureBox7")>
		Private _PictureBox7 As PictureBox

		' Token: 0x040001FA RID: 506
		<AccessedThroughProperty("PictureBox8")>
		Private _PictureBox8 As PictureBox

		' Token: 0x040001FB RID: 507
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x040001FC RID: 508
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x040001FD RID: 509
		<AccessedThroughProperty("Button10")>
		Private _Button10 As Button

		' Token: 0x040001FE RID: 510
		<AccessedThroughProperty("PictureBox9")>
		Private _PictureBox9 As PictureBox

		' Token: 0x040001FF RID: 511
		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel

		' Token: 0x04000200 RID: 512
		<AccessedThroughProperty("Button12")>
		Private _Button12 As Button

		' Token: 0x04000201 RID: 513
		<AccessedThroughProperty("ProgressBar2")>
		Private _ProgressBar2 As ProgressBar

		' Token: 0x04000202 RID: 514
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x04000203 RID: 515
		<AccessedThroughProperty("Button13")>
		Private _Button13 As Button

		' Token: 0x04000204 RID: 516
		<AccessedThroughProperty("Button14")>
		Private _Button14 As Button

		' Token: 0x04000205 RID: 517
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x04000206 RID: 518
		<AccessedThroughProperty("Button15")>
		Private _Button15 As Button

		' Token: 0x04000207 RID: 519
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000208 RID: 520
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x04000209 RID: 521
		<AccessedThroughProperty("Timer2")>
		Private _Timer2 As Timer

		' Token: 0x0400020A RID: 522
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x0400020B RID: 523
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x0400020C RID: 524
		<AccessedThroughProperty("Button8")>
		Private _Button8 As Button

		' Token: 0x0400020D RID: 525
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x0400020E RID: 526
		<AccessedThroughProperty("Startbutton")>
		Private _Startbutton As PictureBox

		' Token: 0x0400020F RID: 527
		<AccessedThroughProperty("PictureBox10")>
		Private _PictureBox10 As PictureBox

		' Token: 0x04000210 RID: 528
		<AccessedThroughProperty("PictureBox11")>
		Private _PictureBox11 As PictureBox

		' Token: 0x04000211 RID: 529
		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		' Token: 0x04000212 RID: 530
		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		' Token: 0x04000213 RID: 531
		<AccessedThroughProperty("PictureBox12")>
		Private _PictureBox12 As PictureBox

		' Token: 0x04000214 RID: 532
		<AccessedThroughProperty("Panel3")>
		Private _Panel3 As Panel

		' Token: 0x04000215 RID: 533
		<AccessedThroughProperty("startbutton2")>
		Private _startbutton2 As PictureBox

		' Token: 0x04000216 RID: 534
		<AccessedThroughProperty("settings1")>
		Private _settings1 As PictureBox

		' Token: 0x04000217 RID: 535
		<AccessedThroughProperty("lionsexplorer1")>
		Private _lionsexplorer1 As PictureBox

		' Token: 0x04000218 RID: 536
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x04000219 RID: 537
		<AccessedThroughProperty("PictureBox14")>
		Private _PictureBox14 As PictureBox

		' Token: 0x0400021A RID: 538
		<AccessedThroughProperty("PictureBox15")>
		Private _PictureBox15 As PictureBox

		' Token: 0x0400021B RID: 539
		<AccessedThroughProperty("restartbutton")>
		Private _restartbutton As Button

		' Token: 0x0400021C RID: 540
		<AccessedThroughProperty("More")>
		Private _More As Button

		' Token: 0x0400021D RID: 541
		<AccessedThroughProperty("shutdownbutton")>
		Private _shutdownbutton As Button

		' Token: 0x0400021E RID: 542
		<AccessedThroughProperty("Button9")>
		Private _Button9 As Button

		' Token: 0x0400021F RID: 543
		<AccessedThroughProperty("Button11")>
		Private _Button11 As Button

		' Token: 0x04000220 RID: 544
		<AccessedThroughProperty("Button18")>
		Private _Button18 As Button

		' Token: 0x04000221 RID: 545
		<AccessedThroughProperty("Settinsp")>
		Private _Settinsp As PictureBox

		' Token: 0x04000222 RID: 546
		<AccessedThroughProperty("SearchFN")>
		Private _SearchFN As Timer

		' Token: 0x04000223 RID: 547
		<AccessedThroughProperty("Timer3")>
		Private _Timer3 As Timer

		' Token: 0x04000224 RID: 548
		<AccessedThroughProperty("V")>
		Private _V As Label

		' Token: 0x04000225 RID: 549
		<AccessedThroughProperty("PictureBox16")>
		Private _PictureBox16 As PictureBox

		' Token: 0x04000226 RID: 550
		<AccessedThroughProperty("Panel4")>
		Private _Panel4 As Panel

		' Token: 0x04000227 RID: 551
		<AccessedThroughProperty("PictureBox18")>
		Private _PictureBox18 As PictureBox

		' Token: 0x04000228 RID: 552
		<AccessedThroughProperty("PictureBox19")>
		Private _PictureBox19 As PictureBox

		' Token: 0x04000229 RID: 553
		<AccessedThroughProperty("PictureBox20")>
		Private _PictureBox20 As PictureBox

		' Token: 0x0400022A RID: 554
		<AccessedThroughProperty("StartBt")>
		Private _StartBt As PictureBox

		' Token: 0x0400022B RID: 555
		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		' Token: 0x0400022C RID: 556
		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		' Token: 0x0400022D RID: 557
		<AccessedThroughProperty("Panel5")>
		Private _Panel5 As Panel

		' Token: 0x0400022E RID: 558
		<AccessedThroughProperty("StartBF")>
		Private _StartBF As PictureBox

		' Token: 0x0400022F RID: 559
		<AccessedThroughProperty("PictureBox17")>
		Private _PictureBox17 As PictureBox

		' Token: 0x04000230 RID: 560
		<AccessedThroughProperty("Label9")>
		Private _Label9 As Label

		' Token: 0x04000231 RID: 561
		<AccessedThroughProperty("PictureBox13")>
		Private _PictureBox13 As PictureBox

		' Token: 0x04000232 RID: 562
		<AccessedThroughProperty("PictureBox21")>
		Private _PictureBox21 As PictureBox

		' Token: 0x04000233 RID: 563
		<AccessedThroughProperty("PictureBox22")>
		Private _PictureBox22 As PictureBox
	End Class
End Namespace
