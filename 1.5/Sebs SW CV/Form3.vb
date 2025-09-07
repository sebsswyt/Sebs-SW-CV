Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports CV.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x0200004B RID: 75
	<DesignerGenerated()>
	Public Partial Class Form3
		Inherits Form

		' Token: 0x06000BAC RID: 2988 RVA: 0x03DC6378 File Offset: 0x03DC4778
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Form3.__ENCList
			SyncLock _ENCList
				Form3.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170003DB RID: 987
		' (get) Token: 0x06000BAF RID: 2991 RVA: 0x03DC7EA0 File Offset: 0x03DC62A0
		' (set) Token: 0x06000BB0 RID: 2992 RVA: 0x03DC7EB8 File Offset: 0x03DC62B8
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

		' Token: 0x170003DC RID: 988
		' (get) Token: 0x06000BB1 RID: 2993 RVA: 0x03DC7EC4 File Offset: 0x03DC62C4
		' (set) Token: 0x06000BB2 RID: 2994 RVA: 0x03DC7EDC File Offset: 0x03DC62DC
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

		' Token: 0x170003DD RID: 989
		' (get) Token: 0x06000BB3 RID: 2995 RVA: 0x03DC7F3C File Offset: 0x03DC633C
		' (set) Token: 0x06000BB4 RID: 2996 RVA: 0x03DC7F54 File Offset: 0x03DC6354
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

		' Token: 0x170003DE RID: 990
		' (get) Token: 0x06000BB5 RID: 2997 RVA: 0x03DC7FB4 File Offset: 0x03DC63B4
		' (set) Token: 0x06000BB6 RID: 2998 RVA: 0x03DC7FCC File Offset: 0x03DC63CC
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

		' Token: 0x170003DF RID: 991
		' (get) Token: 0x06000BB7 RID: 2999 RVA: 0x03DC802C File Offset: 0x03DC642C
		' (set) Token: 0x06000BB8 RID: 3000 RVA: 0x03DC8044 File Offset: 0x03DC6444
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

		' Token: 0x170003E0 RID: 992
		' (get) Token: 0x06000BB9 RID: 3001 RVA: 0x03DC80A4 File Offset: 0x03DC64A4
		' (set) Token: 0x06000BBA RID: 3002 RVA: 0x03DC80BC File Offset: 0x03DC64BC
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

		' Token: 0x170003E1 RID: 993
		' (get) Token: 0x06000BBB RID: 3003 RVA: 0x03DC80C8 File Offset: 0x03DC64C8
		' (set) Token: 0x06000BBC RID: 3004 RVA: 0x03DC80E0 File Offset: 0x03DC64E0
		Friend Overridable Property Label2 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label2 = value
			End Set
		End Property

		' Token: 0x170003E2 RID: 994
		' (get) Token: 0x06000BBD RID: 3005 RVA: 0x03DC80EC File Offset: 0x03DC64EC
		' (set) Token: 0x06000BBE RID: 3006 RVA: 0x03DC8104 File Offset: 0x03DC6504
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

		' Token: 0x170003E3 RID: 995
		' (get) Token: 0x06000BBF RID: 3007 RVA: 0x03DC8110 File Offset: 0x03DC6510
		' (set) Token: 0x06000BC0 RID: 3008 RVA: 0x03DC8128 File Offset: 0x03DC6528
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

		' Token: 0x170003E4 RID: 996
		' (get) Token: 0x06000BC1 RID: 3009 RVA: 0x03DC8134 File Offset: 0x03DC6534
		' (set) Token: 0x06000BC2 RID: 3010 RVA: 0x03DC814C File Offset: 0x03DC654C
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

		' Token: 0x170003E5 RID: 997
		' (get) Token: 0x06000BC3 RID: 3011 RVA: 0x03DC8158 File Offset: 0x03DC6558
		' (set) Token: 0x06000BC4 RID: 3012 RVA: 0x03DC8170 File Offset: 0x03DC6570
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

		' Token: 0x170003E6 RID: 998
		' (get) Token: 0x06000BC5 RID: 3013 RVA: 0x03DC81D0 File Offset: 0x03DC65D0
		' (set) Token: 0x06000BC6 RID: 3014 RVA: 0x03DC81E8 File Offset: 0x03DC65E8
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

		' Token: 0x170003E7 RID: 999
		' (get) Token: 0x06000BC7 RID: 3015 RVA: 0x03DC81F4 File Offset: 0x03DC65F4
		' (set) Token: 0x06000BC8 RID: 3016 RVA: 0x03DC820C File Offset: 0x03DC660C
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

		' Token: 0x170003E8 RID: 1000
		' (get) Token: 0x06000BC9 RID: 3017 RVA: 0x03DC826C File Offset: 0x03DC666C
		' (set) Token: 0x06000BCA RID: 3018 RVA: 0x03DC8284 File Offset: 0x03DC6684
		Friend Overridable Property Button8 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button8_Click
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

		' Token: 0x170003E9 RID: 1001
		' (get) Token: 0x06000BCB RID: 3019 RVA: 0x03DC82E4 File Offset: 0x03DC66E4
		' (set) Token: 0x06000BCC RID: 3020 RVA: 0x03DC82FC File Offset: 0x03DC66FC
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

		' Token: 0x170003EA RID: 1002
		' (get) Token: 0x06000BCD RID: 3021 RVA: 0x03DC8308 File Offset: 0x03DC6708
		' (set) Token: 0x06000BCE RID: 3022 RVA: 0x03DC8320 File Offset: 0x03DC6720
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

		' Token: 0x170003EB RID: 1003
		' (get) Token: 0x06000BCF RID: 3023 RVA: 0x03DC8380 File Offset: 0x03DC6780
		' (set) Token: 0x06000BD0 RID: 3024 RVA: 0x03DC8398 File Offset: 0x03DC6798
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

		' Token: 0x170003EC RID: 1004
		' (get) Token: 0x06000BD1 RID: 3025 RVA: 0x03DC83F8 File Offset: 0x03DC67F8
		' (set) Token: 0x06000BD2 RID: 3026 RVA: 0x03DC8410 File Offset: 0x03DC6810
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

		' Token: 0x170003ED RID: 1005
		' (get) Token: 0x06000BD3 RID: 3027 RVA: 0x03DC8470 File Offset: 0x03DC6870
		' (set) Token: 0x06000BD4 RID: 3028 RVA: 0x03DC8488 File Offset: 0x03DC6888
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

		' Token: 0x170003EE RID: 1006
		' (get) Token: 0x06000BD5 RID: 3029 RVA: 0x03DC84E8 File Offset: 0x03DC68E8
		' (set) Token: 0x06000BD6 RID: 3030 RVA: 0x03DC8500 File Offset: 0x03DC6900
		Friend Overridable Property Button14 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button14
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button14_Click
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

		' Token: 0x170003EF RID: 1007
		' (get) Token: 0x06000BD7 RID: 3031 RVA: 0x03DC8560 File Offset: 0x03DC6960
		' (set) Token: 0x06000BD8 RID: 3032 RVA: 0x03DC8578 File Offset: 0x03DC6978
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

		' Token: 0x170003F0 RID: 1008
		' (get) Token: 0x06000BD9 RID: 3033 RVA: 0x03DC8584 File Offset: 0x03DC6984
		' (set) Token: 0x06000BDA RID: 3034 RVA: 0x03DC859C File Offset: 0x03DC699C
		Friend Overridable Property Button15 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button15
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button15_Click
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

		' Token: 0x170003F1 RID: 1009
		' (get) Token: 0x06000BDB RID: 3035 RVA: 0x03DC85FC File Offset: 0x03DC69FC
		' (set) Token: 0x06000BDC RID: 3036 RVA: 0x03DC8614 File Offset: 0x03DC6A14
		Friend Overridable Property Button16 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button16
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button16_Click
				Dim flag As Boolean = Me._Button16 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button16.Click, eventHandler
				End If
				Me._Button16 = value
				flag = Me._Button16 IsNot Nothing
				If flag Then
					AddHandler Me._Button16.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170003F2 RID: 1010
		' (get) Token: 0x06000BDD RID: 3037 RVA: 0x03DC8674 File Offset: 0x03DC6A74
		' (set) Token: 0x06000BDE RID: 3038 RVA: 0x03DC868C File Offset: 0x03DC6A8C
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

		' Token: 0x170003F3 RID: 1011
		' (get) Token: 0x06000BDF RID: 3039 RVA: 0x03DC8698 File Offset: 0x03DC6A98
		' (set) Token: 0x06000BE0 RID: 3040 RVA: 0x03DC86B0 File Offset: 0x03DC6AB0
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

		' Token: 0x170003F4 RID: 1012
		' (get) Token: 0x06000BE1 RID: 3041 RVA: 0x03DC8710 File Offset: 0x03DC6B10
		' (set) Token: 0x06000BE2 RID: 3042 RVA: 0x03DC8728 File Offset: 0x03DC6B28
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

		' Token: 0x170003F5 RID: 1013
		' (get) Token: 0x06000BE3 RID: 3043 RVA: 0x03DC8788 File Offset: 0x03DC6B88
		' (set) Token: 0x06000BE4 RID: 3044 RVA: 0x03DC87A0 File Offset: 0x03DC6BA0
		Friend Overridable Property Button20 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button20
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button20_Click
				Dim flag As Boolean = Me._Button20 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button20.Click, eventHandler
				End If
				Me._Button20 = value
				flag = Me._Button20 IsNot Nothing
				If flag Then
					AddHandler Me._Button20.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170003F6 RID: 1014
		' (get) Token: 0x06000BE5 RID: 3045 RVA: 0x03DC8800 File Offset: 0x03DC6C00
		' (set) Token: 0x06000BE6 RID: 3046 RVA: 0x03DC8818 File Offset: 0x03DC6C18
		Friend Overridable Property Button19 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button19
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button19_Click
				Dim flag As Boolean = Me._Button19 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button19.Click, eventHandler
				End If
				Me._Button19 = value
				flag = Me._Button19 IsNot Nothing
				If flag Then
					AddHandler Me._Button19.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170003F7 RID: 1015
		' (get) Token: 0x06000BE7 RID: 3047 RVA: 0x03DC8878 File Offset: 0x03DC6C78
		' (set) Token: 0x06000BE8 RID: 3048 RVA: 0x03DC8890 File Offset: 0x03DC6C90
		Friend Overridable Property Button2 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button2_Click_1
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

		' Token: 0x170003F8 RID: 1016
		' (get) Token: 0x06000BE9 RID: 3049 RVA: 0x03DC88F0 File Offset: 0x03DC6CF0
		' (set) Token: 0x06000BEA RID: 3050 RVA: 0x03DC8908 File Offset: 0x03DC6D08
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

		' Token: 0x170003F9 RID: 1017
		' (get) Token: 0x06000BEB RID: 3051 RVA: 0x03DC8914 File Offset: 0x03DC6D14
		' (set) Token: 0x06000BEC RID: 3052 RVA: 0x03DC892C File Offset: 0x03DC6D2C
		Friend Overridable Property JhjToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._JhjToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._JhjToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x170003FA RID: 1018
		' (get) Token: 0x06000BED RID: 3053 RVA: 0x03DC8938 File Offset: 0x03DC6D38
		' (set) Token: 0x06000BEE RID: 3054 RVA: 0x03DC8950 File Offset: 0x03DC6D50
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

		' Token: 0x170003FB RID: 1019
		' (get) Token: 0x06000BEF RID: 3055 RVA: 0x03DC895C File Offset: 0x03DC6D5C
		' (set) Token: 0x06000BF0 RID: 3056 RVA: 0x03DC8974 File Offset: 0x03DC6D74
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

		' Token: 0x170003FC RID: 1020
		' (get) Token: 0x06000BF1 RID: 3057 RVA: 0x03DC8980 File Offset: 0x03DC6D80
		' (set) Token: 0x06000BF2 RID: 3058 RVA: 0x03DC8998 File Offset: 0x03DC6D98
		Friend Overridable Property VierToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._VierToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.VierToolStripMenuItem_Click
				Dim flag As Boolean = Me._VierToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._VierToolStripMenuItem.Click, eventHandler
				End If
				Me._VierToolStripMenuItem = value
				flag = Me._VierToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._VierToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170003FD RID: 1021
		' (get) Token: 0x06000BF3 RID: 3059 RVA: 0x03DC89F8 File Offset: 0x03DC6DF8
		' (set) Token: 0x06000BF4 RID: 3060 RVA: 0x03DC8A10 File Offset: 0x03DC6E10
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

		' Token: 0x170003FE RID: 1022
		' (get) Token: 0x06000BF5 RID: 3061 RVA: 0x03DC8A1C File Offset: 0x03DC6E1C
		' (set) Token: 0x06000BF6 RID: 3062 RVA: 0x03DC8A34 File Offset: 0x03DC6E34
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

		' Token: 0x170003FF RID: 1023
		' (get) Token: 0x06000BF7 RID: 3063 RVA: 0x03DC8A94 File Offset: 0x03DC6E94
		' (set) Token: 0x06000BF8 RID: 3064 RVA: 0x03DC8AAC File Offset: 0x03DC6EAC
		Friend Overridable Property StatusStrip1 As StatusStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._StatusStrip1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As StatusStrip)
				Me._StatusStrip1 = value
			End Set
		End Property

		' Token: 0x17000400 RID: 1024
		' (get) Token: 0x06000BF9 RID: 3065 RVA: 0x03DC8AB8 File Offset: 0x03DC6EB8
		' (set) Token: 0x06000BFA RID: 3066 RVA: 0x03DC8AD0 File Offset: 0x03DC6ED0
		Friend Overridable Property ToolStripStatusLabel1 As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripStatusLabel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Dim eventHandler As EventHandler = AddressOf Me.ToolStripStatusLabel1_Click
				Dim flag As Boolean = Me._ToolStripStatusLabel1 IsNot Nothing
				If flag Then
					RemoveHandler Me._ToolStripStatusLabel1.Click, eventHandler
				End If
				Me._ToolStripStatusLabel1 = value
				flag = Me._ToolStripStatusLabel1 IsNot Nothing
				If flag Then
					AddHandler Me._ToolStripStatusLabel1.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000401 RID: 1025
		' (get) Token: 0x06000BFB RID: 3067 RVA: 0x03DC8B30 File Offset: 0x03DC6F30
		' (set) Token: 0x06000BFC RID: 3068 RVA: 0x03DC8B48 File Offset: 0x03DC6F48
		Friend Overridable Property NewToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._NewToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._NewToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000402 RID: 1026
		' (get) Token: 0x06000BFD RID: 3069 RVA: 0x03DC8B54 File Offset: 0x03DC6F54
		' (set) Token: 0x06000BFE RID: 3070 RVA: 0x03DC8B6C File Offset: 0x03DC6F6C
		Friend Overridable Property OpenToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._OpenToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000403 RID: 1027
		' (get) Token: 0x06000BFF RID: 3071 RVA: 0x03DC8B78 File Offset: 0x03DC6F78
		' (set) Token: 0x06000C00 RID: 3072 RVA: 0x03DC8B90 File Offset: 0x03DC6F90
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

		' Token: 0x17000404 RID: 1028
		' (get) Token: 0x06000C01 RID: 3073 RVA: 0x03DC8B9C File Offset: 0x03DC6F9C
		' (set) Token: 0x06000C02 RID: 3074 RVA: 0x03DC8BB4 File Offset: 0x03DC6FB4
		Friend Overridable Property SaveAsToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SaveAsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._SaveAsToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000405 RID: 1029
		' (get) Token: 0x06000C03 RID: 3075 RVA: 0x03DC8BC0 File Offset: 0x03DC6FC0
		' (set) Token: 0x06000C04 RID: 3076 RVA: 0x03DC8BD8 File Offset: 0x03DC6FD8
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

		' Token: 0x17000406 RID: 1030
		' (get) Token: 0x06000C05 RID: 3077 RVA: 0x03DC8BE4 File Offset: 0x03DC6FE4
		' (set) Token: 0x06000C06 RID: 3078 RVA: 0x03DC8BFC File Offset: 0x03DC6FFC
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

		' Token: 0x17000407 RID: 1031
		' (get) Token: 0x06000C07 RID: 3079 RVA: 0x03DC8C5C File Offset: 0x03DC705C
		' (set) Token: 0x06000C08 RID: 3080 RVA: 0x03DC8C74 File Offset: 0x03DC7074
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

		' Token: 0x17000408 RID: 1032
		' (get) Token: 0x06000C09 RID: 3081 RVA: 0x03DC8C80 File Offset: 0x03DC7080
		' (set) Token: 0x06000C0A RID: 3082 RVA: 0x03DC8C98 File Offset: 0x03DC7098
		Friend Overridable Property PasToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._PasToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._PasToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000409 RID: 1033
		' (get) Token: 0x06000C0B RID: 3083 RVA: 0x03DC8CA4 File Offset: 0x03DC70A4
		' (set) Token: 0x06000C0C RID: 3084 RVA: 0x03DC8CBC File Offset: 0x03DC70BC
		Friend Overridable Property FontToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FontToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._FontToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x1700040A RID: 1034
		' (get) Token: 0x06000C0D RID: 3085 RVA: 0x03DC8CC8 File Offset: 0x03DC70C8
		' (set) Token: 0x06000C0E RID: 3086 RVA: 0x03DC8CE0 File Offset: 0x03DC70E0
		Friend Overridable Property StatusBaToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._StatusBaToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.StatusBaToolStripMenuItem_Click
				Dim flag As Boolean = Me._StatusBaToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._StatusBaToolStripMenuItem.Click, eventHandler
				End If
				Me._StatusBaToolStripMenuItem = value
				flag = Me._StatusBaToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._StatusBaToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700040B RID: 1035
		' (get) Token: 0x06000C0F RID: 3087 RVA: 0x03DC8D40 File Offset: 0x03DC7140
		' (set) Token: 0x06000C10 RID: 3088 RVA: 0x03DC8D58 File Offset: 0x03DC7158
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

		' Token: 0x1700040C RID: 1036
		' (get) Token: 0x06000C11 RID: 3089 RVA: 0x03DC8DB8 File Offset: 0x03DC71B8
		' (set) Token: 0x06000C12 RID: 3090 RVA: 0x03DC8DD0 File Offset: 0x03DC71D0
		Friend Overridable Property Button11 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button11_Click_1
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

		' Token: 0x1700040D RID: 1037
		' (get) Token: 0x06000C13 RID: 3091 RVA: 0x03DC8E30 File Offset: 0x03DC7230
		' (set) Token: 0x06000C14 RID: 3092 RVA: 0x03DC8E48 File Offset: 0x03DC7248
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

		' Token: 0x06000C15 RID: 3093 RVA: 0x03DC8EA8 File Offset: 0x03DC72A8
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form18.Show()
		End Sub

		' Token: 0x06000C16 RID: 3094 RVA: 0x03DC8EBC File Offset: 0x03DC72BC
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Errorbox1.Show()
		End Sub

		' Token: 0x06000C17 RID: 3095 RVA: 0x03DC8ED0 File Offset: 0x03DC72D0
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form22.Show()
		End Sub

		' Token: 0x06000C18 RID: 3096 RVA: 0x03DC8EE4 File Offset: 0x03DC72E4
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form5.Show()
		End Sub

		' Token: 0x06000C19 RID: 3097 RVA: 0x03DC8EF8 File Offset: 0x03DC72F8
		Private Sub Button6_Click(sender As Object, e As EventArgs)
			Me.Panel1.Visible = False
		End Sub

		' Token: 0x06000C1A RID: 3098 RVA: 0x03DC8F0C File Offset: 0x03DC730C
		Private Sub Button7_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox1.Show()
		End Sub

		' Token: 0x06000C1B RID: 3099 RVA: 0x03DC8F20 File Offset: 0x03DC7320
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form37.Show()
			MyProject.Forms.Form37.TextBox1.[ReadOnly] = False
		End Sub

		' Token: 0x06000C1C RID: 3100 RVA: 0x03DC8F4C File Offset: 0x03DC734C
		Private Sub Button9_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form15.Show()
			MyProject.Forms.Form15.Text = "Bug in program"
			MyProject.Forms.Form15.TextBox1.Text = "Bug in program"
		End Sub

		' Token: 0x06000C1D RID: 3101 RVA: 0x03DC8F9C File Offset: 0x03DC739C
		Private Sub Button8_Click(sender As Object, e As EventArgs)
			Me.Panel2.Visible = True
		End Sub

		' Token: 0x06000C1E RID: 3102 RVA: 0x03DC8FB0 File Offset: 0x03DC73B0
		Private Sub Button10_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form15.Show()
			MyProject.Forms.Form15.Text = "Bug in program"
			MyProject.Forms.Form15.TextBox1.Text = "Bug in program"
			MyProject.Forms.Form15.TextBox1.[ReadOnly] = False
		End Sub

		' Token: 0x06000C1F RID: 3103 RVA: 0x03DC9014 File Offset: 0x03DC7414
		Private Sub Button11_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form17.Show()
		End Sub

		' Token: 0x06000C20 RID: 3104 RVA: 0x03DC9028 File Offset: 0x03DC7428
		Private Sub Button12_Click(sender As Object, e As EventArgs)
			Me.Panel3.Visible = True
		End Sub

		' Token: 0x06000C21 RID: 3105 RVA: 0x03DC903C File Offset: 0x03DC743C
		Private Sub Button15_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox5.Show()
		End Sub

		' Token: 0x06000C22 RID: 3106 RVA: 0x03DC9050 File Offset: 0x03DC7450
		Private Sub Button17_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form19.Show()
		End Sub

		' Token: 0x06000C23 RID: 3107 RVA: 0x03DC9064 File Offset: 0x03DC7464
		Private Sub Button18_Click(sender As Object, e As EventArgs)
			MyProject.Forms.error1.Show()
			MyProject.Forms.error1.Label1.Text = "can't open program with .exe in text"
		End Sub

		' Token: 0x06000C24 RID: 3108 RVA: 0x03DC9094 File Offset: 0x03DC7494
		Private Sub Button14_Click(sender As Object, e As EventArgs)
			Me.Panel4.Visible = True
			Me.Button11.Visible = True
			Me.Button14.Visible = False
		End Sub

		' Token: 0x06000C25 RID: 3109 RVA: 0x03DC90C0 File Offset: 0x03DC74C0
		Private Sub Button13_Click(sender As Object, e As EventArgs)
			MyProject.Forms.error1.Show()
			MyProject.Forms.error1.Label1.Text = "can't open program with .exe in text"
		End Sub

		' Token: 0x06000C26 RID: 3110 RVA: 0x03DC90F0 File Offset: 0x03DC74F0
		Private Sub Button19_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form15.Show()
			MyProject.Forms.Form15.Text = "Lionsexplorer.dll"
			MyProject.Forms.Form15.TextBox1.Text = "Form9.theweb = true"
		End Sub

		' Token: 0x06000C27 RID: 3111 RVA: 0x03DC9140 File Offset: 0x03DC7540
		Private Sub Button20_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form15.Show()
			MyProject.Forms.Form15.Text = "Lionsexplorer.ini"
			MyProject.Forms.Form15.TextBox1.Text = "Form9.not the web = false form1.icon.Visible = true"
		End Sub

		' Token: 0x06000C28 RID: 3112 RVA: 0x03DC9190 File Offset: 0x03DC7590
		Private Sub Button16_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form15.Show()
			MyProject.Forms.Form15.TextBox1.Text = "Form1.show() Button.start()"
		End Sub

		' Token: 0x06000C29 RID: 3113 RVA: 0x03DC91C0 File Offset: 0x03DC75C0
		Private Sub Label6_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000C2A RID: 3114 RVA: 0x03DC91C4 File Offset: 0x03DC75C4
		Private Sub Button2_Click_1(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox1.Show()
		End Sub

		' Token: 0x06000C2B RID: 3115 RVA: 0x03DC91D8 File Offset: 0x03DC75D8
		Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox1.Show()
		End Sub

		' Token: 0x06000C2C RID: 3116 RVA: 0x03DC91EC File Offset: 0x03DC75EC
		Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000C2D RID: 3117 RVA: 0x03DC91F0 File Offset: 0x03DC75F0
		Private Sub VierToolStripMenuItem_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000C2E RID: 3118 RVA: 0x03DC91F4 File Offset: 0x03DC75F4
		Private Sub StatusBaToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Me.StatusStrip1.Visible
			If flag Then
				Me.StatusStrip1.Visible = True
			End If
			flag = Me.StatusStrip1.Visible
			If flag Then
				Me.StatusStrip1.Visible = False
			End If
		End Sub

		' Token: 0x06000C2F RID: 3119 RVA: 0x03DC9240 File Offset: 0x03DC7640
		Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000C30 RID: 3120 RVA: 0x03DC924C File Offset: 0x03DC764C
		Private Sub Button7_Click_1(sender As Object, e As EventArgs)
			MyProject.Forms.Form9.Show()
		End Sub

		' Token: 0x06000C31 RID: 3121 RVA: 0x03DC9260 File Offset: 0x03DC7660
		Private Sub Button11_Click_1(sender As Object, e As EventArgs)
			Me.Panel4.Visible = False
			Me.Button11.Visible = False
			Me.Button14.Visible = True
		End Sub

		' Token: 0x06000C32 RID: 3122 RVA: 0x03DC928C File Offset: 0x03DC768C
		Private Sub Button21_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form31.Show()
		End Sub

		' Token: 0x04000452 RID: 1106
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000454 RID: 1108
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x04000455 RID: 1109
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000456 RID: 1110
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x04000457 RID: 1111
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x04000458 RID: 1112
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x04000459 RID: 1113
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x0400045A RID: 1114
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x0400045B RID: 1115
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x0400045C RID: 1116
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x0400045D RID: 1117
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x0400045E RID: 1118
		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		' Token: 0x0400045F RID: 1119
		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		' Token: 0x04000460 RID: 1120
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x04000461 RID: 1121
		<AccessedThroughProperty("Button8")>
		Private _Button8 As Button

		' Token: 0x04000462 RID: 1122
		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel

		' Token: 0x04000463 RID: 1123
		<AccessedThroughProperty("Button10")>
		Private _Button10 As Button

		' Token: 0x04000464 RID: 1124
		<AccessedThroughProperty("Button9")>
		Private _Button9 As Button

		' Token: 0x04000465 RID: 1125
		<AccessedThroughProperty("Button12")>
		Private _Button12 As Button

		' Token: 0x04000466 RID: 1126
		<AccessedThroughProperty("Button13")>
		Private _Button13 As Button

		' Token: 0x04000467 RID: 1127
		<AccessedThroughProperty("Button14")>
		Private _Button14 As Button

		' Token: 0x04000468 RID: 1128
		<AccessedThroughProperty("Panel3")>
		Private _Panel3 As Panel

		' Token: 0x04000469 RID: 1129
		<AccessedThroughProperty("Button15")>
		Private _Button15 As Button

		' Token: 0x0400046A RID: 1130
		<AccessedThroughProperty("Button16")>
		Private _Button16 As Button

		' Token: 0x0400046B RID: 1131
		<AccessedThroughProperty("Panel4")>
		Private _Panel4 As Panel

		' Token: 0x0400046C RID: 1132
		<AccessedThroughProperty("Button17")>
		Private _Button17 As Button

		' Token: 0x0400046D RID: 1133
		<AccessedThroughProperty("Button18")>
		Private _Button18 As Button

		' Token: 0x0400046E RID: 1134
		<AccessedThroughProperty("Button20")>
		Private _Button20 As Button

		' Token: 0x0400046F RID: 1135
		<AccessedThroughProperty("Button19")>
		Private _Button19 As Button

		' Token: 0x04000470 RID: 1136
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x04000471 RID: 1137
		<AccessedThroughProperty("MenuStrip1")>
		Private _MenuStrip1 As MenuStrip

		' Token: 0x04000472 RID: 1138
		<AccessedThroughProperty("JhjToolStripMenuItem")>
		Private _JhjToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000473 RID: 1139
		<AccessedThroughProperty("EditToolStripMenuItem")>
		Private _EditToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000474 RID: 1140
		<AccessedThroughProperty("FormatToolStripMenuItem")>
		Private _FormatToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000475 RID: 1141
		<AccessedThroughProperty("VierToolStripMenuItem")>
		Private _VierToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000476 RID: 1142
		<AccessedThroughProperty("HelpToolStripMenuItem")>
		Private _HelpToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000477 RID: 1143
		<AccessedThroughProperty("AboutToolStripMenuItem")>
		Private _AboutToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000478 RID: 1144
		<AccessedThroughProperty("StatusStrip1")>
		Private _StatusStrip1 As StatusStrip

		' Token: 0x04000479 RID: 1145
		<AccessedThroughProperty("ToolStripStatusLabel1")>
		Private _ToolStripStatusLabel1 As ToolStripStatusLabel

		' Token: 0x0400047A RID: 1146
		<AccessedThroughProperty("NewToolStripMenuItem")>
		Private _NewToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400047B RID: 1147
		<AccessedThroughProperty("OpenToolStripMenuItem")>
		Private _OpenToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400047C RID: 1148
		<AccessedThroughProperty("SaveToolStripMenuItem")>
		Private _SaveToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400047D RID: 1149
		<AccessedThroughProperty("SaveAsToolStripMenuItem")>
		Private _SaveAsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400047E RID: 1150
		<AccessedThroughProperty("ToolStripSeparator1")>
		Private _ToolStripSeparator1 As ToolStripSeparator

		' Token: 0x0400047F RID: 1151
		<AccessedThroughProperty("ExitToolStripMenuItem")>
		Private _ExitToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000480 RID: 1152
		<AccessedThroughProperty("CopyToolStripMenuItem")>
		Private _CopyToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000481 RID: 1153
		<AccessedThroughProperty("PasToolStripMenuItem")>
		Private _PasToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000482 RID: 1154
		<AccessedThroughProperty("FontToolStripMenuItem")>
		Private _FontToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000483 RID: 1155
		<AccessedThroughProperty("StatusBaToolStripMenuItem")>
		Private _StatusBaToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000484 RID: 1156
		<AccessedThroughProperty("Button7")>
		Private _Button7 As Button

		' Token: 0x04000485 RID: 1157
		<AccessedThroughProperty("Button11")>
		Private _Button11 As Button

		' Token: 0x04000486 RID: 1158
		<AccessedThroughProperty("Button21")>
		Private _Button21 As Button
	End Class
End Namespace
