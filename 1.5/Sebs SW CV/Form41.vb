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
	' Token: 0x02000058 RID: 88
	<DesignerGenerated()>
	Public Partial Class Form41
		Inherits Form

		' Token: 0x06000EF7 RID: 3831 RVA: 0x03DDC068 File Offset: 0x03DDA468
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form41_Load
			AddHandler MyBase.Leave, AddressOf Me.Form41_Leave
			Dim _ENCList As List(Of WeakReference) = Form41.__ENCList
			SyncLock _ENCList
				Form41.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170004F1 RID: 1265
		' (get) Token: 0x06000EFA RID: 3834 RVA: 0x03DDD698 File Offset: 0x03DDBA98
		' (set) Token: 0x06000EFB RID: 3835 RVA: 0x03DDD6B0 File Offset: 0x03DDBAB0
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

		' Token: 0x170004F2 RID: 1266
		' (get) Token: 0x06000EFC RID: 3836 RVA: 0x03DDD710 File Offset: 0x03DDBB10
		' (set) Token: 0x06000EFD RID: 3837 RVA: 0x03DDD728 File Offset: 0x03DDBB28
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

		' Token: 0x170004F3 RID: 1267
		' (get) Token: 0x06000EFE RID: 3838 RVA: 0x03DDD788 File Offset: 0x03DDBB88
		' (set) Token: 0x06000EFF RID: 3839 RVA: 0x03DDD7A0 File Offset: 0x03DDBBA0
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

		' Token: 0x170004F4 RID: 1268
		' (get) Token: 0x06000F00 RID: 3840 RVA: 0x03DDD800 File Offset: 0x03DDBC00
		' (set) Token: 0x06000F01 RID: 3841 RVA: 0x03DDD818 File Offset: 0x03DDBC18
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

		' Token: 0x170004F5 RID: 1269
		' (get) Token: 0x06000F02 RID: 3842 RVA: 0x03DDD824 File Offset: 0x03DDBC24
		' (set) Token: 0x06000F03 RID: 3843 RVA: 0x03DDD83C File Offset: 0x03DDBC3C
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

		' Token: 0x170004F6 RID: 1270
		' (get) Token: 0x06000F04 RID: 3844 RVA: 0x03DDD848 File Offset: 0x03DDBC48
		' (set) Token: 0x06000F05 RID: 3845 RVA: 0x03DDD860 File Offset: 0x03DDBC60
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

		' Token: 0x170004F7 RID: 1271
		' (get) Token: 0x06000F06 RID: 3846 RVA: 0x03DDD86C File Offset: 0x03DDBC6C
		' (set) Token: 0x06000F07 RID: 3847 RVA: 0x03DDD884 File Offset: 0x03DDBC84
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

		' Token: 0x170004F8 RID: 1272
		' (get) Token: 0x06000F08 RID: 3848 RVA: 0x03DDD890 File Offset: 0x03DDBC90
		' (set) Token: 0x06000F09 RID: 3849 RVA: 0x03DDD8A8 File Offset: 0x03DDBCA8
		Friend Overridable Property FolderBrowserDialog1 As FolderBrowserDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._FolderBrowserDialog1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FolderBrowserDialog)
				Me._FolderBrowserDialog1 = value
			End Set
		End Property

		' Token: 0x170004F9 RID: 1273
		' (get) Token: 0x06000F0A RID: 3850 RVA: 0x03DDD8B4 File Offset: 0x03DDBCB4
		' (set) Token: 0x06000F0B RID: 3851 RVA: 0x03DDD8CC File Offset: 0x03DDBCCC
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

		' Token: 0x170004FA RID: 1274
		' (get) Token: 0x06000F0C RID: 3852 RVA: 0x03DDD92C File Offset: 0x03DDBD2C
		' (set) Token: 0x06000F0D RID: 3853 RVA: 0x03DDD944 File Offset: 0x03DDBD44
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

		' Token: 0x170004FB RID: 1275
		' (get) Token: 0x06000F0E RID: 3854 RVA: 0x03DDD9A4 File Offset: 0x03DDBDA4
		' (set) Token: 0x06000F0F RID: 3855 RVA: 0x03DDD9BC File Offset: 0x03DDBDBC
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

		' Token: 0x170004FC RID: 1276
		' (get) Token: 0x06000F10 RID: 3856 RVA: 0x03DDDA1C File Offset: 0x03DDBE1C
		' (set) Token: 0x06000F11 RID: 3857 RVA: 0x03DDDA34 File Offset: 0x03DDBE34
		Friend Overridable Property Button6 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button6_Click
				Dim eventHandler2 As EventHandler = AddressOf Me.Button6_MouseLeave
				Dim eventHandler3 As EventHandler = AddressOf Me.Button6_MouseEnter
				Dim flag As Boolean = Me._Button6 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button6.Click, eventHandler
					RemoveHandler Me._Button6.MouseLeave, eventHandler2
					RemoveHandler Me._Button6.MouseEnter, eventHandler3
				End If
				Me._Button6 = value
				flag = Me._Button6 IsNot Nothing
				If flag Then
					AddHandler Me._Button6.Click, eventHandler
					AddHandler Me._Button6.MouseLeave, eventHandler2
					AddHandler Me._Button6.MouseEnter, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x170004FD RID: 1277
		' (get) Token: 0x06000F12 RID: 3858 RVA: 0x03DDDAE4 File Offset: 0x03DDBEE4
		' (set) Token: 0x06000F13 RID: 3859 RVA: 0x03DDDAFC File Offset: 0x03DDBEFC
		Friend Overridable Property Button7 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button7 = value
			End Set
		End Property

		' Token: 0x170004FE RID: 1278
		' (get) Token: 0x06000F14 RID: 3860 RVA: 0x03DDDB08 File Offset: 0x03DDBF08
		' (set) Token: 0x06000F15 RID: 3861 RVA: 0x03DDDB20 File Offset: 0x03DDBF20
		Friend Overridable Property Button8 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button8 = value
			End Set
		End Property

		' Token: 0x170004FF RID: 1279
		' (get) Token: 0x06000F16 RID: 3862 RVA: 0x03DDDB2C File Offset: 0x03DDBF2C
		' (set) Token: 0x06000F17 RID: 3863 RVA: 0x03DDDB44 File Offset: 0x03DDBF44
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

		' Token: 0x17000500 RID: 1280
		' (get) Token: 0x06000F18 RID: 3864 RVA: 0x03DDDB50 File Offset: 0x03DDBF50
		' (set) Token: 0x06000F19 RID: 3865 RVA: 0x03DDDB68 File Offset: 0x03DDBF68
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

		' Token: 0x17000501 RID: 1281
		' (get) Token: 0x06000F1A RID: 3866 RVA: 0x03DDDB74 File Offset: 0x03DDBF74
		' (set) Token: 0x06000F1B RID: 3867 RVA: 0x03DDDB8C File Offset: 0x03DDBF8C
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

		' Token: 0x17000502 RID: 1282
		' (get) Token: 0x06000F1C RID: 3868 RVA: 0x03DDDB98 File Offset: 0x03DDBF98
		' (set) Token: 0x06000F1D RID: 3869 RVA: 0x03DDDBB0 File Offset: 0x03DDBFB0
		Friend Overridable Property Label6 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label6 = value
			End Set
		End Property

		' Token: 0x17000503 RID: 1283
		' (get) Token: 0x06000F1E RID: 3870 RVA: 0x03DDDBBC File Offset: 0x03DDBFBC
		' (set) Token: 0x06000F1F RID: 3871 RVA: 0x03DDDBD4 File Offset: 0x03DDBFD4
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

		' Token: 0x17000504 RID: 1284
		' (get) Token: 0x06000F20 RID: 3872 RVA: 0x03DDDBE0 File Offset: 0x03DDBFE0
		' (set) Token: 0x06000F21 RID: 3873 RVA: 0x03DDDBF8 File Offset: 0x03DDBFF8
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

		' Token: 0x17000505 RID: 1285
		' (get) Token: 0x06000F22 RID: 3874 RVA: 0x03DDDC04 File Offset: 0x03DDC004
		' (set) Token: 0x06000F23 RID: 3875 RVA: 0x03DDDC1C File Offset: 0x03DDC01C
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

		' Token: 0x17000506 RID: 1286
		' (get) Token: 0x06000F24 RID: 3876 RVA: 0x03DDDC28 File Offset: 0x03DDC028
		' (set) Token: 0x06000F25 RID: 3877 RVA: 0x03DDDC40 File Offset: 0x03DDC040
		Friend Overridable Property Panel1 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.Panel1_MouseDown
				Dim mouseEventHandler2 As MouseEventHandler = AddressOf Me.Panel1_MouseMove
				Dim flag As Boolean = Me._Panel1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Panel1.MouseDown, mouseEventHandler
					RemoveHandler Me._Panel1.MouseMove, mouseEventHandler2
				End If
				Me._Panel1 = value
				flag = Me._Panel1 IsNot Nothing
				If flag Then
					AddHandler Me._Panel1.MouseDown, mouseEventHandler
					AddHandler Me._Panel1.MouseMove, mouseEventHandler2
				End If
			End Set
		End Property

		' Token: 0x17000507 RID: 1287
		' (get) Token: 0x06000F26 RID: 3878 RVA: 0x03DDDCC8 File Offset: 0x03DDC0C8
		' (set) Token: 0x06000F27 RID: 3879 RVA: 0x03DDDCE0 File Offset: 0x03DDC0E0
		Friend Overridable Property Button11 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button11_MouseEnter
				Dim eventHandler2 As EventHandler = AddressOf Me.Button11_Click
				Dim eventHandler3 As EventHandler = AddressOf Me.Button11_MouseLeave
				Dim flag As Boolean = Me._Button11 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button11.MouseEnter, eventHandler
					RemoveHandler Me._Button11.Click, eventHandler2
					RemoveHandler Me._Button11.MouseLeave, eventHandler3
				End If
				Me._Button11 = value
				flag = Me._Button11 IsNot Nothing
				If flag Then
					AddHandler Me._Button11.MouseEnter, eventHandler
					AddHandler Me._Button11.Click, eventHandler2
					AddHandler Me._Button11.MouseLeave, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x17000508 RID: 1288
		' (get) Token: 0x06000F28 RID: 3880 RVA: 0x03DDDD90 File Offset: 0x03DDC190
		' (set) Token: 0x06000F29 RID: 3881 RVA: 0x03DDDDA8 File Offset: 0x03DDC1A8
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

		' Token: 0x17000509 RID: 1289
		' (get) Token: 0x06000F2A RID: 3882 RVA: 0x03DDDE08 File Offset: 0x03DDC208
		' (set) Token: 0x06000F2B RID: 3883 RVA: 0x03DDDE20 File Offset: 0x03DDC220
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

		' Token: 0x1700050A RID: 1290
		' (get) Token: 0x06000F2C RID: 3884 RVA: 0x03DDDE80 File Offset: 0x03DDC280
		' (set) Token: 0x06000F2D RID: 3885 RVA: 0x03DDDE98 File Offset: 0x03DDC298
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

		' Token: 0x1700050B RID: 1291
		' (get) Token: 0x06000F2E RID: 3886 RVA: 0x03DDDEF8 File Offset: 0x03DDC2F8
		' (set) Token: 0x06000F2F RID: 3887 RVA: 0x03DDDF10 File Offset: 0x03DDC310
		Friend Overridable Property Panel2 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.Panel2_MouseDown
				Dim mouseEventHandler2 As MouseEventHandler = AddressOf Me.Panel2_MouseMove
				Dim flag As Boolean = Me._Panel2 IsNot Nothing
				If flag Then
					RemoveHandler Me._Panel2.MouseDown, mouseEventHandler
					RemoveHandler Me._Panel2.MouseMove, mouseEventHandler2
				End If
				Me._Panel2 = value
				flag = Me._Panel2 IsNot Nothing
				If flag Then
					AddHandler Me._Panel2.MouseDown, mouseEventHandler
					AddHandler Me._Panel2.MouseMove, mouseEventHandler2
				End If
			End Set
		End Property

		' Token: 0x1700050C RID: 1292
		' (get) Token: 0x06000F30 RID: 3888 RVA: 0x03DDDF98 File Offset: 0x03DDC398
		' (set) Token: 0x06000F31 RID: 3889 RVA: 0x03DDDFB0 File Offset: 0x03DDC3B0
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

		' Token: 0x1700050D RID: 1293
		' (get) Token: 0x06000F32 RID: 3890 RVA: 0x03DDE010 File Offset: 0x03DDC410
		' (set) Token: 0x06000F33 RID: 3891 RVA: 0x03DDE028 File Offset: 0x03DDC428
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

		' Token: 0x1700050E RID: 1294
		' (get) Token: 0x06000F34 RID: 3892 RVA: 0x03DDE088 File Offset: 0x03DDC488
		' (set) Token: 0x06000F35 RID: 3893 RVA: 0x03DDE0A0 File Offset: 0x03DDC4A0
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

		' Token: 0x06000F36 RID: 3894 RVA: 0x03DDE100 File Offset: 0x03DDC500
		Private Sub OpenFileDialog1_FileOk(sender As Object, e As CancelEventArgs)
			Process.Start(Me.OpenFileDialog1.FileName)
			Dim flag As Boolean = Operators.CompareString(Me.Label1.Text, "Label1", False) = 0
			If flag Then
				Me.Label1.Text = "1"
				Me.Button2.Visible = True
				Me.Button2.Text = Me.OpenFileDialog1.FileName
			Else
				flag = Operators.CompareString(Me.Label2.Text, "Label2", False) = 0
				If flag Then
					Me.Label2.Text = "2"
					Me.Button3.Visible = True
					Me.Button3.Text = Me.OpenFileDialog1.FileName
				Else
					flag = Operators.CompareString(Me.Label3.Text, "Label3", False) = 0
					If flag Then
						Me.Label3.Text = "3"
						Me.Button4.Visible = True
						Me.Button4.Text = Me.OpenFileDialog1.FileName
					Else
						flag = Operators.CompareString(Me.Label4.Text, "Label4", False) = 0
						If flag Then
							Me.Label4.Text = "4"
							Me.Button5.Visible = True
							Me.Button5.Text = Me.OpenFileDialog1.FileName
						Else
							flag = Operators.CompareString(Me.Label5.Text, "Label5", False) = 0
							If flag Then
								Me.Label5.Text = "5"
								Me.Button7.Visible = True
								Me.Button7.Text = Me.OpenFileDialog1.FileName
							Else
								flag = Operators.CompareString(Me.Label6.Text, "Label6", False) = 0
								If flag Then
									Me.Label6.Text = "6"
									Me.Button8.Visible = True
									Me.Button8.Text = Me.OpenFileDialog1.FileName
								Else
									flag = Operators.CompareString(Me.Label7.Text, "Label7", False) = 0
									If flag Then
										Me.Label7.Text = "7"
										Me.Button9.Visible = True
										Me.Button9.Text = Me.OpenFileDialog1.FileName
									Else
										flag = Operators.CompareString(Me.Label8.Text, "Label8", False) = 0
										If flag Then
											Me.Label8.Text = "8"
											Me.Button10.Visible = True
											Me.Button10.Text = Me.OpenFileDialog1.FileName
										End If
									End If
								End If
							End If
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x06000F37 RID: 3895 RVA: 0x03DDE3E4 File Offset: 0x03DDC7E4
		Private Sub Form41_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000F38 RID: 3896 RVA: 0x03DDE3E8 File Offset: 0x03DDC7E8
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.OpenFileDialog1.ShowDialog()
		End Sub

		' Token: 0x06000F39 RID: 3897 RVA: 0x03DDE3F8 File Offset: 0x03DDC7F8
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Button2.Text, "Button2", False) = 0
			If Not flag Then
				Process.Start(Me.Button2.Text)
			End If
		End Sub

		' Token: 0x06000F3A RID: 3898 RVA: 0x03DDE43C File Offset: 0x03DDC83C
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Button3.Text, "Button3", False) = 0
			If Not flag Then
				Process.Start(Me.Button3.Text)
			End If
		End Sub

		' Token: 0x06000F3B RID: 3899 RVA: 0x03DDE480 File Offset: 0x03DDC880
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Button4.Text, "Button4", False) = 0
			If Not flag Then
				Process.Start(Me.Button4.Text)
			End If
		End Sub

		' Token: 0x06000F3C RID: 3900 RVA: 0x03DDE4C4 File Offset: 0x03DDC8C4
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Button5.Text, "Button5", False) = 0
			If Not flag Then
				Process.Start(Me.Button5.Text)
			End If
		End Sub

		' Token: 0x06000F3D RID: 3901 RVA: 0x03DDE508 File Offset: 0x03DDC908
		Private Sub Button6_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000F3E RID: 3902 RVA: 0x03DDE514 File Offset: 0x03DDC914
		Private Sub Button6_MouseEnter(sender As Object, e As EventArgs)
			Me.Button6.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000F3F RID: 3903 RVA: 0x03DDE52C File Offset: 0x03DDC92C
		Private Sub Button6_MouseLeave(sender As Object, e As EventArgs)
			Me.Button6.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000F40 RID: 3904 RVA: 0x03DDE544 File Offset: 0x03DDC944
		Private Sub Button11_MouseLeave(sender As Object, e As EventArgs)
			Me.Button11.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000F41 RID: 3905 RVA: 0x03DDE55C File Offset: 0x03DDC95C
		Private Sub Button11_MouseEnter(sender As Object, e As EventArgs)
			Me.Button11.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000F42 RID: 3906 RVA: 0x03DDE574 File Offset: 0x03DDC974
		Private Sub Button11_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.WindowState = FormWindowState.Normal
			If flag Then
				Me.WindowState = FormWindowState.Maximized
			Else
				Me.WindowState = FormWindowState.Normal
			End If
		End Sub

		' Token: 0x06000F43 RID: 3907 RVA: 0x03DDE5A4 File Offset: 0x03DDC9A4
		Private Sub Button12_Click(sender As Object, e As EventArgs)
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x06000F44 RID: 3908 RVA: 0x03DDE5B0 File Offset: 0x03DDC9B0
		Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs)
			' The following expression was wrapped in a checked-expression
			Me.mouse_move = New Point(0 - e.X, 0 - e.Y)
		End Sub

		' Token: 0x06000F45 RID: 3909 RVA: 0x03DDE5D0 File Offset: 0x03DDC9D0
		Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = e.Button = MouseButtons.Left
			If flag Then
				Dim mousePosition As Point = Control.MousePosition
				mousePosition.Offset(Me.mouse_move.X, Me.mouse_move.Y)
				Me.Location = mousePosition
			End If
		End Sub

		' Token: 0x06000F46 RID: 3910 RVA: 0x03DDE620 File Offset: 0x03DDCA20
		Private Sub Form41_Leave(sender As Object, e As EventArgs)
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x06000F47 RID: 3911 RVA: 0x03DDE62C File Offset: 0x03DDCA2C
		Private Sub Button13_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form55.Show()
		End Sub

		' Token: 0x06000F48 RID: 3912 RVA: 0x03DDE640 File Offset: 0x03DDCA40
		Private Sub Button14_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000F49 RID: 3913 RVA: 0x03DDE64C File Offset: 0x03DDCA4C
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Dim visible As Boolean = MyProject.Forms.Form_1pad.Panel1.Visible
			If visible Then
				Me.Panel2.Visible = True
			End If
			Me.Panel2.BackColor = MyProject.Forms.Form_1pad.Panel1.BackColor
		End Sub

		' Token: 0x06000F4A RID: 3914 RVA: 0x03DDE6A4 File Offset: 0x03DDCAA4
		Private Sub Button15_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.WindowState = FormWindowState.Normal
			If flag Then
				Me.WindowState = FormWindowState.Maximized
			Else
				Me.WindowState = FormWindowState.Normal
			End If
		End Sub

		' Token: 0x06000F4B RID: 3915 RVA: 0x03DDE6D4 File Offset: 0x03DDCAD4
		Private Sub Button16_Click(sender As Object, e As EventArgs)
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x06000F4C RID: 3916 RVA: 0x03DDE6E0 File Offset: 0x03DDCAE0
		Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs)
			' The following expression was wrapped in a checked-expression
			Me.mouse_move = New Point(0 - e.X, 0 - e.Y)
		End Sub

		' Token: 0x06000F4D RID: 3917 RVA: 0x03DDE700 File Offset: 0x03DDCB00
		Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = e.Button = MouseButtons.Left
			If flag Then
				Dim mousePosition As Point = Control.MousePosition
				mousePosition.Offset(Me.mouse_move.X, Me.mouse_move.Y)
				Me.Location = mousePosition
			End If
		End Sub

		' Token: 0x04000586 RID: 1414
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000588 RID: 1416
		<AccessedThroughProperty("OpenFileDialog1")>
		Private _OpenFileDialog1 As OpenFileDialog

		' Token: 0x04000589 RID: 1417
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400058A RID: 1418
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x0400058B RID: 1419
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x0400058C RID: 1420
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x0400058D RID: 1421
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x0400058E RID: 1422
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x0400058F RID: 1423
		<AccessedThroughProperty("FolderBrowserDialog1")>
		Private _FolderBrowserDialog1 As FolderBrowserDialog

		' Token: 0x04000590 RID: 1424
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x04000591 RID: 1425
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x04000592 RID: 1426
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x04000593 RID: 1427
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x04000594 RID: 1428
		<AccessedThroughProperty("Button7")>
		Private _Button7 As Button

		' Token: 0x04000595 RID: 1429
		<AccessedThroughProperty("Button8")>
		Private _Button8 As Button

		' Token: 0x04000596 RID: 1430
		<AccessedThroughProperty("Button9")>
		Private _Button9 As Button

		' Token: 0x04000597 RID: 1431
		<AccessedThroughProperty("Button10")>
		Private _Button10 As Button

		' Token: 0x04000598 RID: 1432
		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		' Token: 0x04000599 RID: 1433
		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		' Token: 0x0400059A RID: 1434
		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		' Token: 0x0400059B RID: 1435
		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		' Token: 0x0400059C RID: 1436
		<AccessedThroughProperty("Label9")>
		Private _Label9 As Label

		' Token: 0x0400059D RID: 1437
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x0400059E RID: 1438
		<AccessedThroughProperty("Button11")>
		Private _Button11 As Button

		' Token: 0x0400059F RID: 1439
		<AccessedThroughProperty("Button12")>
		Private _Button12 As Button

		' Token: 0x040005A0 RID: 1440
		<AccessedThroughProperty("Button13")>
		Private _Button13 As Button

		' Token: 0x040005A1 RID: 1441
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x040005A2 RID: 1442
		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel

		' Token: 0x040005A3 RID: 1443
		<AccessedThroughProperty("Button16")>
		Private _Button16 As Button

		' Token: 0x040005A4 RID: 1444
		<AccessedThroughProperty("Button15")>
		Private _Button15 As Button

		' Token: 0x040005A5 RID: 1445
		<AccessedThroughProperty("Button14")>
		Private _Button14 As Button

		' Token: 0x040005A6 RID: 1446
		Private mouse_move As Point
	End Class
End Namespace
