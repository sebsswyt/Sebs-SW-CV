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
	' Token: 0x0200005A RID: 90
	<DesignerGenerated()>
	Public Partial Class Form43
		Inherits Form

		' Token: 0x06000F5E RID: 3934 RVA: 0x03DDED24 File Offset: 0x03DDD124
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form43_Load
			Dim _ENCList As List(Of WeakReference) = Form43.__ENCList
			SyncLock _ENCList
				Form43.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000513 RID: 1299
		' (get) Token: 0x06000F61 RID: 3937 RVA: 0x03DE08B4 File Offset: 0x03DDECB4
		' (set) Token: 0x06000F62 RID: 3938 RVA: 0x03DE08CC File Offset: 0x03DDECCC
		Friend Overridable Property Button1 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button1_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.Button1_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.Button1_Click
				Dim flag As Boolean = Me._Button1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button1.MouseLeave, eventHandler
					RemoveHandler Me._Button1.MouseEnter, eventHandler2
					RemoveHandler Me._Button1.Click, eventHandler3
				End If
				Me._Button1 = value
				flag = Me._Button1 IsNot Nothing
				If flag Then
					AddHandler Me._Button1.MouseLeave, eventHandler
					AddHandler Me._Button1.MouseEnter, eventHandler2
					AddHandler Me._Button1.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x17000514 RID: 1300
		' (get) Token: 0x06000F63 RID: 3939 RVA: 0x03DE097C File Offset: 0x03DDED7C
		' (set) Token: 0x06000F64 RID: 3940 RVA: 0x03DE0994 File Offset: 0x03DDED94
		Friend Overridable Property Panel1 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.Label1_MouseMove
				Dim mouseEventHandler2 As MouseEventHandler = AddressOf Me.Label1_MouseDown
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

		' Token: 0x17000515 RID: 1301
		' (get) Token: 0x06000F65 RID: 3941 RVA: 0x03DE0A1C File Offset: 0x03DDEE1C
		' (set) Token: 0x06000F66 RID: 3942 RVA: 0x03DE0A34 File Offset: 0x03DDEE34
		Friend Overridable Property Button2 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button2_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.Button2_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.Button2_Click
				Dim flag As Boolean = Me._Button2 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button2.MouseLeave, eventHandler
					RemoveHandler Me._Button2.MouseEnter, eventHandler2
					RemoveHandler Me._Button2.Click, eventHandler3
				End If
				Me._Button2 = value
				flag = Me._Button2 IsNot Nothing
				If flag Then
					AddHandler Me._Button2.MouseLeave, eventHandler
					AddHandler Me._Button2.MouseEnter, eventHandler2
					AddHandler Me._Button2.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x17000516 RID: 1302
		' (get) Token: 0x06000F67 RID: 3943 RVA: 0x03DE0AE4 File Offset: 0x03DDEEE4
		' (set) Token: 0x06000F68 RID: 3944 RVA: 0x03DE0AFC File Offset: 0x03DDEEFC
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

		' Token: 0x17000517 RID: 1303
		' (get) Token: 0x06000F69 RID: 3945 RVA: 0x03DE0B5C File Offset: 0x03DDEF5C
		' (set) Token: 0x06000F6A RID: 3946 RVA: 0x03DE0B74 File Offset: 0x03DDEF74
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

		' Token: 0x17000518 RID: 1304
		' (get) Token: 0x06000F6B RID: 3947 RVA: 0x03DE0B80 File Offset: 0x03DDEF80
		' (set) Token: 0x06000F6C RID: 3948 RVA: 0x03DE0B98 File Offset: 0x03DDEF98
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

		' Token: 0x17000519 RID: 1305
		' (get) Token: 0x06000F6D RID: 3949 RVA: 0x03DE0BA4 File Offset: 0x03DDEFA4
		' (set) Token: 0x06000F6E RID: 3950 RVA: 0x03DE0BBC File Offset: 0x03DDEFBC
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

		' Token: 0x1700051A RID: 1306
		' (get) Token: 0x06000F6F RID: 3951 RVA: 0x03DE0C1C File Offset: 0x03DDF01C
		' (set) Token: 0x06000F70 RID: 3952 RVA: 0x03DE0C34 File Offset: 0x03DDF034
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

		' Token: 0x1700051B RID: 1307
		' (get) Token: 0x06000F71 RID: 3953 RVA: 0x03DE0C40 File Offset: 0x03DDF040
		' (set) Token: 0x06000F72 RID: 3954 RVA: 0x03DE0C58 File Offset: 0x03DDF058
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

		' Token: 0x1700051C RID: 1308
		' (get) Token: 0x06000F73 RID: 3955 RVA: 0x03DE0CB8 File Offset: 0x03DDF0B8
		' (set) Token: 0x06000F74 RID: 3956 RVA: 0x03DE0CD0 File Offset: 0x03DDF0D0
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

		' Token: 0x1700051D RID: 1309
		' (get) Token: 0x06000F75 RID: 3957 RVA: 0x03DE0CDC File Offset: 0x03DDF0DC
		' (set) Token: 0x06000F76 RID: 3958 RVA: 0x03DE0CF4 File Offset: 0x03DDF0F4
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

		' Token: 0x1700051E RID: 1310
		' (get) Token: 0x06000F77 RID: 3959 RVA: 0x03DE0D54 File Offset: 0x03DDF154
		' (set) Token: 0x06000F78 RID: 3960 RVA: 0x03DE0D6C File Offset: 0x03DDF16C
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

		' Token: 0x1700051F RID: 1311
		' (get) Token: 0x06000F79 RID: 3961 RVA: 0x03DE0D78 File Offset: 0x03DDF178
		' (set) Token: 0x06000F7A RID: 3962 RVA: 0x03DE0D90 File Offset: 0x03DDF190
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

		' Token: 0x17000520 RID: 1312
		' (get) Token: 0x06000F7B RID: 3963 RVA: 0x03DE0DF0 File Offset: 0x03DDF1F0
		' (set) Token: 0x06000F7C RID: 3964 RVA: 0x03DE0E08 File Offset: 0x03DDF208
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

		' Token: 0x17000521 RID: 1313
		' (get) Token: 0x06000F7D RID: 3965 RVA: 0x03DE0E68 File Offset: 0x03DDF268
		' (set) Token: 0x06000F7E RID: 3966 RVA: 0x03DE0E80 File Offset: 0x03DDF280
		Friend Overridable Property OpenFileDialog1 As OpenFileDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenFileDialog1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As OpenFileDialog)
				Dim cancelEventHandler As CancelEventHandler = AddressOf Me.OpenFileDialog1_FileOk
				Dim flag As Boolean = Me._OpenFileDialog1 IsNot Nothing
				If flag Then
					RemoveHandler Me._OpenFileDialog1.FileOk, cancelEventHandler
				End If
				Me._OpenFileDialog1 = value
				flag = Me._OpenFileDialog1 IsNot Nothing
				If flag Then
					AddHandler Me._OpenFileDialog1.FileOk, cancelEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000522 RID: 1314
		' (get) Token: 0x06000F7F RID: 3967 RVA: 0x03DE0EE0 File Offset: 0x03DDF2E0
		' (set) Token: 0x06000F80 RID: 3968 RVA: 0x03DE0EF8 File Offset: 0x03DDF2F8
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

		' Token: 0x17000523 RID: 1315
		' (get) Token: 0x06000F81 RID: 3969 RVA: 0x03DE0F04 File Offset: 0x03DDF304
		' (set) Token: 0x06000F82 RID: 3970 RVA: 0x03DE0F1C File Offset: 0x03DDF31C
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

		' Token: 0x17000524 RID: 1316
		' (get) Token: 0x06000F83 RID: 3971 RVA: 0x03DE0F7C File Offset: 0x03DDF37C
		' (set) Token: 0x06000F84 RID: 3972 RVA: 0x03DE0F94 File Offset: 0x03DDF394
		Friend Overridable Property ColorDialog1 As ColorDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._ColorDialog1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColorDialog)
				Me._ColorDialog1 = value
			End Set
		End Property

		' Token: 0x17000525 RID: 1317
		' (get) Token: 0x06000F85 RID: 3973 RVA: 0x03DE0FA0 File Offset: 0x03DDF3A0
		' (set) Token: 0x06000F86 RID: 3974 RVA: 0x03DE0FB8 File Offset: 0x03DDF3B8
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

		' Token: 0x17000526 RID: 1318
		' (get) Token: 0x06000F87 RID: 3975 RVA: 0x03DE1018 File Offset: 0x03DDF418
		' (set) Token: 0x06000F88 RID: 3976 RVA: 0x03DE1030 File Offset: 0x03DDF430
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

		' Token: 0x17000527 RID: 1319
		' (get) Token: 0x06000F89 RID: 3977 RVA: 0x03DE103C File Offset: 0x03DDF43C
		' (set) Token: 0x06000F8A RID: 3978 RVA: 0x03DE1054 File Offset: 0x03DDF454
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

		' Token: 0x17000528 RID: 1320
		' (get) Token: 0x06000F8B RID: 3979 RVA: 0x03DE10B4 File Offset: 0x03DDF4B4
		' (set) Token: 0x06000F8C RID: 3980 RVA: 0x03DE10CC File Offset: 0x03DDF4CC
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

		' Token: 0x17000529 RID: 1321
		' (get) Token: 0x06000F8D RID: 3981 RVA: 0x03DE112C File Offset: 0x03DDF52C
		' (set) Token: 0x06000F8E RID: 3982 RVA: 0x03DE1144 File Offset: 0x03DDF544
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

		' Token: 0x1700052A RID: 1322
		' (get) Token: 0x06000F8F RID: 3983 RVA: 0x03DE11A4 File Offset: 0x03DDF5A4
		' (set) Token: 0x06000F90 RID: 3984 RVA: 0x03DE11BC File Offset: 0x03DDF5BC
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

		' Token: 0x1700052B RID: 1323
		' (get) Token: 0x06000F91 RID: 3985 RVA: 0x03DE121C File Offset: 0x03DDF61C
		' (set) Token: 0x06000F92 RID: 3986 RVA: 0x03DE1234 File Offset: 0x03DDF634
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

		' Token: 0x1700052C RID: 1324
		' (get) Token: 0x06000F93 RID: 3987 RVA: 0x03DE1240 File Offset: 0x03DDF640
		' (set) Token: 0x06000F94 RID: 3988 RVA: 0x03DE1258 File Offset: 0x03DDF658
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

		' Token: 0x1700052D RID: 1325
		' (get) Token: 0x06000F95 RID: 3989 RVA: 0x03DE12B8 File Offset: 0x03DDF6B8
		' (set) Token: 0x06000F96 RID: 3990 RVA: 0x03DE12D0 File Offset: 0x03DDF6D0
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

		' Token: 0x1700052E RID: 1326
		' (get) Token: 0x06000F97 RID: 3991 RVA: 0x03DE12DC File Offset: 0x03DDF6DC
		' (set) Token: 0x06000F98 RID: 3992 RVA: 0x03DE12F4 File Offset: 0x03DDF6F4
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

		' Token: 0x1700052F RID: 1327
		' (get) Token: 0x06000F99 RID: 3993 RVA: 0x03DE1354 File Offset: 0x03DDF754
		' (set) Token: 0x06000F9A RID: 3994 RVA: 0x03DE136C File Offset: 0x03DDF76C
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

		' Token: 0x17000530 RID: 1328
		' (get) Token: 0x06000F9B RID: 3995 RVA: 0x03DE13CC File Offset: 0x03DDF7CC
		' (set) Token: 0x06000F9C RID: 3996 RVA: 0x03DE13E4 File Offset: 0x03DDF7E4
		Friend Overridable Property PictureBox8 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.Label1_MouseMove
				Dim mouseEventHandler2 As MouseEventHandler = AddressOf Me.Label1_MouseDown
				Dim flag As Boolean = Me._PictureBox8 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox8.MouseMove, mouseEventHandler
					RemoveHandler Me._PictureBox8.MouseDown, mouseEventHandler2
				End If
				Me._PictureBox8 = value
				flag = Me._PictureBox8 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox8.MouseMove, mouseEventHandler
					AddHandler Me._PictureBox8.MouseDown, mouseEventHandler2
				End If
			End Set
		End Property

		' Token: 0x17000531 RID: 1329
		' (get) Token: 0x06000F9D RID: 3997 RVA: 0x03DE146C File Offset: 0x03DDF86C
		' (set) Token: 0x06000F9E RID: 3998 RVA: 0x03DE1484 File Offset: 0x03DDF884
		Friend Overridable Property Label1 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.Label1_MouseMove
				Dim mouseEventHandler2 As MouseEventHandler = AddressOf Me.Label1_MouseDown
				Dim flag As Boolean = Me._Label1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Label1.MouseMove, mouseEventHandler
					RemoveHandler Me._Label1.MouseDown, mouseEventHandler2
				End If
				Me._Label1 = value
				flag = Me._Label1 IsNot Nothing
				If flag Then
					AddHandler Me._Label1.MouseMove, mouseEventHandler
					AddHandler Me._Label1.MouseDown, mouseEventHandler2
				End If
			End Set
		End Property

		' Token: 0x17000532 RID: 1330
		' (get) Token: 0x06000F9F RID: 3999 RVA: 0x03DE150C File Offset: 0x03DDF90C
		' (set) Token: 0x06000FA0 RID: 4000 RVA: 0x03DE1524 File Offset: 0x03DDF924
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

		' Token: 0x17000533 RID: 1331
		' (get) Token: 0x06000FA1 RID: 4001 RVA: 0x03DE1584 File Offset: 0x03DDF984
		' (set) Token: 0x06000FA2 RID: 4002 RVA: 0x03DE159C File Offset: 0x03DDF99C
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

		' Token: 0x17000534 RID: 1332
		' (get) Token: 0x06000FA3 RID: 4003 RVA: 0x03DE15FC File Offset: 0x03DDF9FC
		' (set) Token: 0x06000FA4 RID: 4004 RVA: 0x03DE1614 File Offset: 0x03DDFA14
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

		' Token: 0x17000535 RID: 1333
		' (get) Token: 0x06000FA5 RID: 4005 RVA: 0x03DE1674 File Offset: 0x03DDFA74
		' (set) Token: 0x06000FA6 RID: 4006 RVA: 0x03DE168C File Offset: 0x03DDFA8C
		Friend Overridable Property PictureBox10 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.PictureBox10_MouseMove
				Dim mouseEventHandler2 As MouseEventHandler = AddressOf Me.PictureBox10_MouseDown
				Dim flag As Boolean = Me._PictureBox10 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox10.MouseMove, mouseEventHandler
					RemoveHandler Me._PictureBox10.MouseDown, mouseEventHandler2
				End If
				Me._PictureBox10 = value
				flag = Me._PictureBox10 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox10.MouseMove, mouseEventHandler
					AddHandler Me._PictureBox10.MouseDown, mouseEventHandler2
				End If
			End Set
		End Property

		' Token: 0x06000FA7 RID: 4007 RVA: 0x03DE1714 File Offset: 0x03DDFB14
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000FA8 RID: 4008 RVA: 0x03DE1720 File Offset: 0x03DDFB20
		Private Sub Button1_MouseEnter(sender As Object, e As EventArgs)
			Me.Button1.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000FA9 RID: 4009 RVA: 0x03DE1738 File Offset: 0x03DDFB38
		Private Sub Button1_MouseLeave(sender As Object, e As EventArgs)
			Me.Button1.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000FAA RID: 4010 RVA: 0x03DE1750 File Offset: 0x03DDFB50
		Private Sub Button2_MouseEnter(sender As Object, e As EventArgs)
			Me.Button2.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000FAB RID: 4011 RVA: 0x03DE1768 File Offset: 0x03DDFB68
		Private Sub Button2_MouseLeave(sender As Object, e As EventArgs)
			Me.Button2.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000FAC RID: 4012 RVA: 0x03DE1780 File Offset: 0x03DDFB80
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.WindowState = FormWindowState.Normal
			If flag Then
				Me.WindowState = FormWindowState.Maximized
			Else
				Me.WindowState = FormWindowState.Normal
			End If
		End Sub

		' Token: 0x06000FAD RID: 4013 RVA: 0x03DE17B0 File Offset: 0x03DDFBB0
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			Dim visible As Boolean = MyProject.Forms.form1Pad.Picture1.Visible
			If Not visible Then
				MyProject.Forms.form1Pad.Picture1.Visible = True
				MyProject.Forms.form1Pad.Picture2.Visible = False
				MyProject.Forms.form1Pad.Picture3.Visible = False
				MyProject.Forms.form1Pad.Picture4.Visible = False
				MyProject.Forms.form1Pad.Picture5.Visible = False
				MyProject.Forms.form1Pad.Picture6.Visible = False
				MyProject.Forms.form1Pad.Picture7.Visible = False
			End If
		End Sub

		' Token: 0x06000FAE RID: 4014 RVA: 0x03DE1878 File Offset: 0x03DDFC78
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			Dim visible As Boolean = MyProject.Forms.form1Pad.Picture2.Visible
			If Not visible Then
				MyProject.Forms.form1Pad.Picture1.Visible = False
				MyProject.Forms.form1Pad.Picture2.Visible = True
				MyProject.Forms.form1Pad.Picture3.Visible = False
				MyProject.Forms.form1Pad.Picture4.Visible = False
				MyProject.Forms.form1Pad.Picture5.Visible = False
				MyProject.Forms.form1Pad.Picture6.Visible = False
				MyProject.Forms.form1Pad.Picture7.Visible = False
			End If
		End Sub

		' Token: 0x06000FAF RID: 4015 RVA: 0x03DE1940 File Offset: 0x03DDFD40
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			Dim visible As Boolean = MyProject.Forms.form1Pad.Picture3.Visible
			If Not visible Then
				MyProject.Forms.form1Pad.Picture1.Visible = False
				MyProject.Forms.form1Pad.Picture2.Visible = False
				MyProject.Forms.form1Pad.Picture3.Visible = True
				MyProject.Forms.form1Pad.Picture4.Visible = False
				MyProject.Forms.form1Pad.Picture5.Visible = False
				MyProject.Forms.form1Pad.Picture6.Visible = False
				MyProject.Forms.form1Pad.Picture7.Visible = False
			End If
		End Sub

		' Token: 0x06000FB0 RID: 4016 RVA: 0x03DE1A08 File Offset: 0x03DDFE08
		Private Sub Button6_Click(sender As Object, e As EventArgs)
			Dim visible As Boolean = MyProject.Forms.form1Pad.Picture4.Visible
			If Not visible Then
				MyProject.Forms.form1Pad.Picture1.Visible = False
				MyProject.Forms.form1Pad.Picture2.Visible = False
				MyProject.Forms.form1Pad.Picture3.Visible = False
				MyProject.Forms.form1Pad.Picture4.Visible = True
				MyProject.Forms.form1Pad.Picture5.Visible = False
				MyProject.Forms.form1Pad.Picture6.Visible = False
				MyProject.Forms.form1Pad.Picture7.Visible = False
			End If
		End Sub

		' Token: 0x06000FB1 RID: 4017 RVA: 0x03DE1AD0 File Offset: 0x03DDFED0
		Private Sub Button7_Click(sender As Object, e As EventArgs)
			Dim visible As Boolean = MyProject.Forms.form1Pad.Picture5.Visible
			If Not visible Then
				MyProject.Forms.form1Pad.Picture1.Visible = False
				MyProject.Forms.form1Pad.Picture2.Visible = False
				MyProject.Forms.form1Pad.Picture3.Visible = False
				MyProject.Forms.form1Pad.Picture4.Visible = False
				MyProject.Forms.form1Pad.Picture5.Visible = True
				MyProject.Forms.form1Pad.Picture6.Visible = False
				MyProject.Forms.form1Pad.Picture7.Visible = False
			End If
		End Sub

		' Token: 0x06000FB2 RID: 4018 RVA: 0x03DE1B98 File Offset: 0x03DDFF98
		Private Sub OpenFileDialog1_FileOk(sender As Object, e As CancelEventArgs)
		End Sub

		' Token: 0x06000FB3 RID: 4019 RVA: 0x03DE1B9C File Offset: 0x03DDFF9C
		Private Sub Button8_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Interaction.MsgBox("New wallpaper?", MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.Yes
			If flag Then
				Dim flag2 As Boolean = Me.OpenFileDialog1.ShowDialog() = DialogResult.OK
				If flag2 Then
					MyProject.Forms.form1Pad.Picture1.Visible = False
					MyProject.Forms.form1Pad.Picture2.Visible = False
					MyProject.Forms.form1Pad.Picture3.Visible = False
					MyProject.Forms.form1Pad.Picture4.Visible = False
					MyProject.Forms.form1Pad.Picture5.Visible = False
					MyProject.Forms.form1Pad.Picture6.Visible = True
					MyProject.Forms.form1Pad.Picture7.Visible = False
					MyProject.Forms.form1Pad.Picture6.Load(Me.OpenFileDialog1.FileName)
					Me.PictureBox6.Load(Me.OpenFileDialog1.FileName)
				End If
			Else
				MyProject.Forms.form1Pad.Picture1.Visible = False
				MyProject.Forms.form1Pad.Picture2.Visible = False
				MyProject.Forms.form1Pad.Picture3.Visible = False
				MyProject.Forms.form1Pad.Picture4.Visible = False
				MyProject.Forms.form1Pad.Picture5.Visible = False
				MyProject.Forms.form1Pad.Picture6.Visible = True
				MyProject.Forms.form1Pad.Picture7.Visible = False
			End If
		End Sub

		' Token: 0x06000FB4 RID: 4020 RVA: 0x03DE1D4C File Offset: 0x03DE014C
		Private Sub Form43_Load(sender As Object, e As EventArgs)
			Dim flag As Boolean = MyProject.Forms.form1Pad.Picture6.Visible
			If flag Then
				Me.PictureBox6.Image = MyProject.Forms.form1Pad.Picture6.Image
			End If
			Me.PictureBox7.BackColor = MyProject.Forms.form1Pad.cvtaskbar.BackColor
			Me.ColorDialog1.Color = MyProject.Forms.form1Pad.cvtaskbar.BackColor
			flag = Operators.CompareString(MyProject.Forms.form1Pad.Label11.Text, "Dev = true", False) = 0
			If flag Then
				Me.Button3.Enabled = False
				Me.Button4.Enabled = False
				Me.Button5.Enabled = False
				Me.Button6.Enabled = False
				Me.Button7.Enabled = False
				Me.Button8.Enabled = False
				Me.Button10.Enabled = False
			End If
		End Sub

		' Token: 0x06000FB5 RID: 4021 RVA: 0x03DE1E58 File Offset: 0x03DE0258
		Private Sub Button9_Click(sender As Object, e As EventArgs)
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x06000FB6 RID: 4022 RVA: 0x03DE1E64 File Offset: 0x03DE0264
		Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs)
		End Sub

		' Token: 0x06000FB7 RID: 4023 RVA: 0x03DE1E68 File Offset: 0x03DE0268
		Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs)
		End Sub

		' Token: 0x06000FB8 RID: 4024 RVA: 0x03DE1E6C File Offset: 0x03DE026C
		Private Sub Button10_Click(sender As Object, e As EventArgs)
			Dim visible As Boolean = Me.Panel2.Visible
			If visible Then
				Me.Panel2.Visible = False
			Else
				Me.Panel2.Visible = True
			End If
		End Sub

		' Token: 0x06000FB9 RID: 4025 RVA: 0x03DE1EA8 File Offset: 0x03DE02A8
		Private Sub Button11_Click(sender As Object, e As EventArgs)
			MyProject.Forms.form1Pad.cvtaskbar.BackColor = Color.Red
		End Sub

		' Token: 0x06000FBA RID: 4026 RVA: 0x03DE1EC8 File Offset: 0x03DE02C8
		Private Sub Button12_Click(sender As Object, e As EventArgs)
			MyProject.Forms.form1Pad.cvtaskbar.BackColor = Color.Blue
		End Sub

		' Token: 0x06000FBB RID: 4027 RVA: 0x03DE1EE8 File Offset: 0x03DE02E8
		Private Sub Button13_Click(sender As Object, e As EventArgs)
			MyProject.Forms.form1Pad.cvtaskbar.BackColor = Color.DarkBlue
		End Sub

		' Token: 0x06000FBC RID: 4028 RVA: 0x03DE1F08 File Offset: 0x03DE0308
		Private Sub Button15_Click(sender As Object, e As EventArgs)
			Dim visible As Boolean = MyProject.Forms.form1Pad.Picture7.Visible
			If Not visible Then
				MyProject.Forms.form1Pad.Picture1.Visible = False
				MyProject.Forms.form1Pad.Picture2.Visible = False
				MyProject.Forms.form1Pad.Picture3.Visible = False
				MyProject.Forms.form1Pad.Picture4.Visible = False
				MyProject.Forms.form1Pad.Picture5.Visible = False
				MyProject.Forms.form1Pad.Picture6.Visible = False
				MyProject.Forms.form1Pad.Picture7.Visible = True
			End If
		End Sub

		' Token: 0x06000FBD RID: 4029 RVA: 0x03DE1FD0 File Offset: 0x03DE03D0
		Private Sub Button14_Click(sender As Object, e As EventArgs)
			MyProject.Forms.form1Pad.cvtaskbar.BackColor = Color.DarkRed
		End Sub

		' Token: 0x06000FBE RID: 4030 RVA: 0x03DE1FF0 File Offset: 0x03DE03F0
		Private Sub Button16_Click(sender As Object, e As EventArgs)
			Me.Panel2.Visible = False
		End Sub

		' Token: 0x06000FBF RID: 4031 RVA: 0x03DE2004 File Offset: 0x03DE0404
		Private Sub Button17_Click(sender As Object, e As EventArgs)
			MyProject.Forms.form1Pad.cvtaskbar.BackColor = Color.Silver
			MyProject.Forms.Form_1pad.Panel1.BackColor = Color.Silver
		End Sub

		' Token: 0x06000FC0 RID: 4032 RVA: 0x03DE203C File Offset: 0x03DE043C
		Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs)
		End Sub

		' Token: 0x06000FC1 RID: 4033 RVA: 0x03DE2040 File Offset: 0x03DE0440
		Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs)
		End Sub

		' Token: 0x06000FC2 RID: 4034 RVA: 0x03DE2044 File Offset: 0x03DE0444
		Private Sub Button20_Click(sender As Object, e As EventArgs)
			MyProject.Forms.form1Pad.cvtaskbar.BackColor = Color.Silver
			MyProject.Forms.Form_1pad.Panel1.BackColor = Color.Silver
		End Sub

		' Token: 0x06000FC3 RID: 4035 RVA: 0x03DE207C File Offset: 0x03DE047C
		Private Sub Button18_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form_1pad.Panel1.BackColor = Color.WhiteSmoke
			MyProject.Forms.form1Pad.cvtaskbar.BackColor = Color.WhiteSmoke
		End Sub

		' Token: 0x06000FC4 RID: 4036 RVA: 0x03DE20B4 File Offset: 0x03DE04B4
		Private Sub Button19_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form_1pad.Panel1.BackColor = Color.Black
			MyProject.Forms.form1Pad.cvtaskbar.BackColor = Color.Black
		End Sub

		' Token: 0x06000FC5 RID: 4037 RVA: 0x03DE20EC File Offset: 0x03DE04EC
		Private Sub PictureBox10_MouseDown(sender As Object, e As MouseEventArgs)
			' The following expression was wrapped in a checked-expression
			Me.mouse_move = New Point(0 - e.X, 0 - e.Y)
		End Sub

		' Token: 0x06000FC6 RID: 4038 RVA: 0x03DE210C File Offset: 0x03DE050C
		Private Sub PictureBox10_MouseMove(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = e.Button = MouseButtons.Left
			If flag Then
				Dim mousePosition As Point = Control.MousePosition
				mousePosition.Offset(Me.mouse_move.X, Me.mouse_move.Y)
				Me.Location = mousePosition
			End If
		End Sub

		' Token: 0x040005AE RID: 1454
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040005B0 RID: 1456
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040005B1 RID: 1457
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x040005B2 RID: 1458
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x040005B3 RID: 1459
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x040005B4 RID: 1460
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x040005B5 RID: 1461
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x040005B6 RID: 1462
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x040005B7 RID: 1463
		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		' Token: 0x040005B8 RID: 1464
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x040005B9 RID: 1465
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x040005BA RID: 1466
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x040005BB RID: 1467
		<AccessedThroughProperty("PictureBox5")>
		Private _PictureBox5 As PictureBox

		' Token: 0x040005BC RID: 1468
		<AccessedThroughProperty("Button7")>
		Private _Button7 As Button

		' Token: 0x040005BD RID: 1469
		<AccessedThroughProperty("Button8")>
		Private _Button8 As Button

		' Token: 0x040005BE RID: 1470
		<AccessedThroughProperty("OpenFileDialog1")>
		Private _OpenFileDialog1 As OpenFileDialog

		' Token: 0x040005BF RID: 1471
		<AccessedThroughProperty("PictureBox6")>
		Private _PictureBox6 As PictureBox

		' Token: 0x040005C0 RID: 1472
		<AccessedThroughProperty("Button9")>
		Private _Button9 As Button

		' Token: 0x040005C1 RID: 1473
		<AccessedThroughProperty("ColorDialog1")>
		Private _ColorDialog1 As ColorDialog

		' Token: 0x040005C2 RID: 1474
		<AccessedThroughProperty("Button10")>
		Private _Button10 As Button

		' Token: 0x040005C3 RID: 1475
		<AccessedThroughProperty("PictureBox7")>
		Private _PictureBox7 As PictureBox

		' Token: 0x040005C4 RID: 1476
		<AccessedThroughProperty("Button11")>
		Private _Button11 As Button

		' Token: 0x040005C5 RID: 1477
		<AccessedThroughProperty("Button12")>
		Private _Button12 As Button

		' Token: 0x040005C6 RID: 1478
		<AccessedThroughProperty("Button13")>
		Private _Button13 As Button

		' Token: 0x040005C7 RID: 1479
		<AccessedThroughProperty("Button14")>
		Private _Button14 As Button

		' Token: 0x040005C8 RID: 1480
		<AccessedThroughProperty("PictureBox9")>
		Private _PictureBox9 As PictureBox

		' Token: 0x040005C9 RID: 1481
		<AccessedThroughProperty("Button15")>
		Private _Button15 As Button

		' Token: 0x040005CA RID: 1482
		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel

		' Token: 0x040005CB RID: 1483
		<AccessedThroughProperty("Button16")>
		Private _Button16 As Button

		' Token: 0x040005CC RID: 1484
		<AccessedThroughProperty("Button17")>
		Private _Button17 As Button

		' Token: 0x040005CD RID: 1485
		<AccessedThroughProperty("PictureBox8")>
		Private _PictureBox8 As PictureBox

		' Token: 0x040005CE RID: 1486
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x040005CF RID: 1487
		<AccessedThroughProperty("Button20")>
		Private _Button20 As Button

		' Token: 0x040005D0 RID: 1488
		<AccessedThroughProperty("Button19")>
		Private _Button19 As Button

		' Token: 0x040005D1 RID: 1489
		<AccessedThroughProperty("Button18")>
		Private _Button18 As Button

		' Token: 0x040005D2 RID: 1490
		<AccessedThroughProperty("PictureBox10")>
		Private _PictureBox10 As PictureBox

		' Token: 0x040005D3 RID: 1491
		Private mouse_move As Point
	End Class
End Namespace
