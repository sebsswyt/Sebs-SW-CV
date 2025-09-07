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
	' Token: 0x02000051 RID: 81
	<DesignerGenerated()>
	Public Partial Class Form35
		Inherits Form

		' Token: 0x06000D9B RID: 3483 RVA: 0x03DD3270 File Offset: 0x03DD1670
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form35_Load
			Dim _ENCList As List(Of WeakReference) = Form35.__ENCList
			SyncLock _ENCList
				Form35.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000485 RID: 1157
		' (get) Token: 0x06000D9E RID: 3486 RVA: 0x03DD5BB8 File Offset: 0x03DD3FB8
		' (set) Token: 0x06000D9F RID: 3487 RVA: 0x03DD5BD0 File Offset: 0x03DD3FD0
		Friend Overridable Property TabPage4 As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage4 = value
			End Set
		End Property

		' Token: 0x17000486 RID: 1158
		' (get) Token: 0x06000DA0 RID: 3488 RVA: 0x03DD5BDC File Offset: 0x03DD3FDC
		' (set) Token: 0x06000DA1 RID: 3489 RVA: 0x03DD5BF4 File Offset: 0x03DD3FF4
		Friend Overridable Property TabPage3 As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage3 = value
			End Set
		End Property

		' Token: 0x17000487 RID: 1159
		' (get) Token: 0x06000DA2 RID: 3490 RVA: 0x03DD5C00 File Offset: 0x03DD4000
		' (set) Token: 0x06000DA3 RID: 3491 RVA: 0x03DD5C18 File Offset: 0x03DD4018
		Friend Overridable Property TabPage2 As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage2 = value
			End Set
		End Property

		' Token: 0x17000488 RID: 1160
		' (get) Token: 0x06000DA4 RID: 3492 RVA: 0x03DD5C24 File Offset: 0x03DD4024
		' (set) Token: 0x06000DA5 RID: 3493 RVA: 0x03DD5C3C File Offset: 0x03DD403C
		Friend Overridable Property TabPage1 As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage1 = value
			End Set
		End Property

		' Token: 0x17000489 RID: 1161
		' (get) Token: 0x06000DA6 RID: 3494 RVA: 0x03DD5C48 File Offset: 0x03DD4048
		' (set) Token: 0x06000DA7 RID: 3495 RVA: 0x03DD5C60 File Offset: 0x03DD4060
		Friend Overridable Property TabControl1 As TabControl
			<DebuggerNonUserCode()>
			Get
				Return Me._TabControl1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabControl)
				Dim keyEventHandler As KeyEventHandler = AddressOf Me.TabControl1_KeyDown
				Dim flag As Boolean = Me._TabControl1 IsNot Nothing
				If flag Then
					RemoveHandler Me._TabControl1.KeyDown, keyEventHandler
				End If
				Me._TabControl1 = value
				flag = Me._TabControl1 IsNot Nothing
				If flag Then
					AddHandler Me._TabControl1.KeyDown, keyEventHandler
				End If
			End Set
		End Property

		' Token: 0x1700048A RID: 1162
		' (get) Token: 0x06000DA8 RID: 3496 RVA: 0x03DD5CC0 File Offset: 0x03DD40C0
		' (set) Token: 0x06000DA9 RID: 3497 RVA: 0x03DD5CD8 File Offset: 0x03DD40D8
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

		' Token: 0x1700048B RID: 1163
		' (get) Token: 0x06000DAA RID: 3498 RVA: 0x03DD5D38 File Offset: 0x03DD4138
		' (set) Token: 0x06000DAB RID: 3499 RVA: 0x03DD5D50 File Offset: 0x03DD4150
		Friend Overridable Property WebBrowser1 As WebBrowser
			<DebuggerNonUserCode()>
			Get
				Return Me._WebBrowser1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As WebBrowser)
				Dim webBrowserNavigatingEventHandler As WebBrowserNavigatingEventHandler = AddressOf Me.WebBrowser1_Navigating
				Dim flag As Boolean = Me._WebBrowser1 IsNot Nothing
				If flag Then
					RemoveHandler Me._WebBrowser1.Navigating, webBrowserNavigatingEventHandler
				End If
				Me._WebBrowser1 = value
				flag = Me._WebBrowser1 IsNot Nothing
				If flag Then
					AddHandler Me._WebBrowser1.Navigating, webBrowserNavigatingEventHandler
				End If
			End Set
		End Property

		' Token: 0x1700048C RID: 1164
		' (get) Token: 0x06000DAC RID: 3500 RVA: 0x03DD5DB0 File Offset: 0x03DD41B0
		' (set) Token: 0x06000DAD RID: 3501 RVA: 0x03DD5DC8 File Offset: 0x03DD41C8
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

		' Token: 0x1700048D RID: 1165
		' (get) Token: 0x06000DAE RID: 3502 RVA: 0x03DD5E28 File Offset: 0x03DD4228
		' (set) Token: 0x06000DAF RID: 3503 RVA: 0x03DD5E40 File Offset: 0x03DD4240
		Friend Overridable Property TextBox1 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim keyEventHandler As KeyEventHandler = AddressOf Me.TextBox1_KeyDown
				Dim flag As Boolean = Me._TextBox1 IsNot Nothing
				If flag Then
					RemoveHandler Me._TextBox1.KeyDown, keyEventHandler
				End If
				Me._TextBox1 = value
				flag = Me._TextBox1 IsNot Nothing
				If flag Then
					AddHandler Me._TextBox1.KeyDown, keyEventHandler
				End If
			End Set
		End Property

		' Token: 0x1700048E RID: 1166
		' (get) Token: 0x06000DB0 RID: 3504 RVA: 0x03DD5EA0 File Offset: 0x03DD42A0
		' (set) Token: 0x06000DB1 RID: 3505 RVA: 0x03DD5EB8 File Offset: 0x03DD42B8
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

		' Token: 0x1700048F RID: 1167
		' (get) Token: 0x06000DB2 RID: 3506 RVA: 0x03DD5F18 File Offset: 0x03DD4318
		' (set) Token: 0x06000DB3 RID: 3507 RVA: 0x03DD5F30 File Offset: 0x03DD4330
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

		' Token: 0x17000490 RID: 1168
		' (get) Token: 0x06000DB4 RID: 3508 RVA: 0x03DD5F90 File Offset: 0x03DD4390
		' (set) Token: 0x06000DB5 RID: 3509 RVA: 0x03DD5FA8 File Offset: 0x03DD43A8
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

		' Token: 0x17000491 RID: 1169
		' (get) Token: 0x06000DB6 RID: 3510 RVA: 0x03DD6008 File Offset: 0x03DD4408
		' (set) Token: 0x06000DB7 RID: 3511 RVA: 0x03DD6020 File Offset: 0x03DD4420
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

		' Token: 0x17000492 RID: 1170
		' (get) Token: 0x06000DB8 RID: 3512 RVA: 0x03DD6080 File Offset: 0x03DD4480
		' (set) Token: 0x06000DB9 RID: 3513 RVA: 0x03DD6098 File Offset: 0x03DD4498
		Friend Overridable Property TextBox2 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim keyEventHandler As KeyEventHandler = AddressOf Me.TextBox2_KeyDown
				Dim flag As Boolean = Me._TextBox2 IsNot Nothing
				If flag Then
					RemoveHandler Me._TextBox2.KeyDown, keyEventHandler
				End If
				Me._TextBox2 = value
				flag = Me._TextBox2 IsNot Nothing
				If flag Then
					AddHandler Me._TextBox2.KeyDown, keyEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000493 RID: 1171
		' (get) Token: 0x06000DBA RID: 3514 RVA: 0x03DD60F8 File Offset: 0x03DD44F8
		' (set) Token: 0x06000DBB RID: 3515 RVA: 0x03DD6110 File Offset: 0x03DD4510
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

		' Token: 0x17000494 RID: 1172
		' (get) Token: 0x06000DBC RID: 3516 RVA: 0x03DD6170 File Offset: 0x03DD4570
		' (set) Token: 0x06000DBD RID: 3517 RVA: 0x03DD6188 File Offset: 0x03DD4588
		Friend Overridable Property WebBrowser2 As WebBrowser
			<DebuggerNonUserCode()>
			Get
				Return Me._WebBrowser2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As WebBrowser)
				Dim webBrowserNavigatingEventHandler As WebBrowserNavigatingEventHandler = AddressOf Me.WebBrowser2_Navigating
				Dim flag As Boolean = Me._WebBrowser2 IsNot Nothing
				If flag Then
					RemoveHandler Me._WebBrowser2.Navigating, webBrowserNavigatingEventHandler
				End If
				Me._WebBrowser2 = value
				flag = Me._WebBrowser2 IsNot Nothing
				If flag Then
					AddHandler Me._WebBrowser2.Navigating, webBrowserNavigatingEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000495 RID: 1173
		' (get) Token: 0x06000DBE RID: 3518 RVA: 0x03DD61E8 File Offset: 0x03DD45E8
		' (set) Token: 0x06000DBF RID: 3519 RVA: 0x03DD6200 File Offset: 0x03DD4600
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

		' Token: 0x17000496 RID: 1174
		' (get) Token: 0x06000DC0 RID: 3520 RVA: 0x03DD6260 File Offset: 0x03DD4660
		' (set) Token: 0x06000DC1 RID: 3521 RVA: 0x03DD6278 File Offset: 0x03DD4678
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

		' Token: 0x17000497 RID: 1175
		' (get) Token: 0x06000DC2 RID: 3522 RVA: 0x03DD62D8 File Offset: 0x03DD46D8
		' (set) Token: 0x06000DC3 RID: 3523 RVA: 0x03DD62F0 File Offset: 0x03DD46F0
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

		' Token: 0x17000498 RID: 1176
		' (get) Token: 0x06000DC4 RID: 3524 RVA: 0x03DD6350 File Offset: 0x03DD4750
		' (set) Token: 0x06000DC5 RID: 3525 RVA: 0x03DD6368 File Offset: 0x03DD4768
		Friend Overridable Property TextBox3 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim keyEventHandler As KeyEventHandler = AddressOf Me.TextBox3_KeyDown
				Dim flag As Boolean = Me._TextBox3 IsNot Nothing
				If flag Then
					RemoveHandler Me._TextBox3.KeyDown, keyEventHandler
				End If
				Me._TextBox3 = value
				flag = Me._TextBox3 IsNot Nothing
				If flag Then
					AddHandler Me._TextBox3.KeyDown, keyEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000499 RID: 1177
		' (get) Token: 0x06000DC6 RID: 3526 RVA: 0x03DD63C8 File Offset: 0x03DD47C8
		' (set) Token: 0x06000DC7 RID: 3527 RVA: 0x03DD63E0 File Offset: 0x03DD47E0
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

		' Token: 0x1700049A RID: 1178
		' (get) Token: 0x06000DC8 RID: 3528 RVA: 0x03DD6440 File Offset: 0x03DD4840
		' (set) Token: 0x06000DC9 RID: 3529 RVA: 0x03DD6458 File Offset: 0x03DD4858
		Friend Overridable Property WebBrowser3 As WebBrowser
			<DebuggerNonUserCode()>
			Get
				Return Me._WebBrowser3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As WebBrowser)
				Dim webBrowserNavigatingEventHandler As WebBrowserNavigatingEventHandler = AddressOf Me.WebBrowser3_Navigating
				Dim flag As Boolean = Me._WebBrowser3 IsNot Nothing
				If flag Then
					RemoveHandler Me._WebBrowser3.Navigating, webBrowserNavigatingEventHandler
				End If
				Me._WebBrowser3 = value
				flag = Me._WebBrowser3 IsNot Nothing
				If flag Then
					AddHandler Me._WebBrowser3.Navigating, webBrowserNavigatingEventHandler
				End If
			End Set
		End Property

		' Token: 0x1700049B RID: 1179
		' (get) Token: 0x06000DCA RID: 3530 RVA: 0x03DD64B8 File Offset: 0x03DD48B8
		' (set) Token: 0x06000DCB RID: 3531 RVA: 0x03DD64D0 File Offset: 0x03DD48D0
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

		' Token: 0x1700049C RID: 1180
		' (get) Token: 0x06000DCC RID: 3532 RVA: 0x03DD6530 File Offset: 0x03DD4930
		' (set) Token: 0x06000DCD RID: 3533 RVA: 0x03DD6548 File Offset: 0x03DD4948
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

		' Token: 0x1700049D RID: 1181
		' (get) Token: 0x06000DCE RID: 3534 RVA: 0x03DD65A8 File Offset: 0x03DD49A8
		' (set) Token: 0x06000DCF RID: 3535 RVA: 0x03DD65C0 File Offset: 0x03DD49C0
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

		' Token: 0x1700049E RID: 1182
		' (get) Token: 0x06000DD0 RID: 3536 RVA: 0x03DD6620 File Offset: 0x03DD4A20
		' (set) Token: 0x06000DD1 RID: 3537 RVA: 0x03DD6638 File Offset: 0x03DD4A38
		Friend Overridable Property TextBox4 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim keyEventHandler As KeyEventHandler = AddressOf Me.TextBox4_KeyDown
				Dim flag As Boolean = Me._TextBox4 IsNot Nothing
				If flag Then
					RemoveHandler Me._TextBox4.KeyDown, keyEventHandler
				End If
				Me._TextBox4 = value
				flag = Me._TextBox4 IsNot Nothing
				If flag Then
					AddHandler Me._TextBox4.KeyDown, keyEventHandler
				End If
			End Set
		End Property

		' Token: 0x1700049F RID: 1183
		' (get) Token: 0x06000DD2 RID: 3538 RVA: 0x03DD6698 File Offset: 0x03DD4A98
		' (set) Token: 0x06000DD3 RID: 3539 RVA: 0x03DD66B0 File Offset: 0x03DD4AB0
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

		' Token: 0x170004A0 RID: 1184
		' (get) Token: 0x06000DD4 RID: 3540 RVA: 0x03DD6710 File Offset: 0x03DD4B10
		' (set) Token: 0x06000DD5 RID: 3541 RVA: 0x03DD6728 File Offset: 0x03DD4B28
		Friend Overridable Property WebBrowser4 As WebBrowser
			<DebuggerNonUserCode()>
			Get
				Return Me._WebBrowser4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As WebBrowser)
				Dim webBrowserNavigatingEventHandler As WebBrowserNavigatingEventHandler = AddressOf Me.WebBrowser4_Navigating
				Dim flag As Boolean = Me._WebBrowser4 IsNot Nothing
				If flag Then
					RemoveHandler Me._WebBrowser4.Navigating, webBrowserNavigatingEventHandler
				End If
				Me._WebBrowser4 = value
				flag = Me._WebBrowser4 IsNot Nothing
				If flag Then
					AddHandler Me._WebBrowser4.Navigating, webBrowserNavigatingEventHandler
				End If
			End Set
		End Property

		' Token: 0x170004A1 RID: 1185
		' (get) Token: 0x06000DD6 RID: 3542 RVA: 0x03DD6788 File Offset: 0x03DD4B88
		' (set) Token: 0x06000DD7 RID: 3543 RVA: 0x03DD67A0 File Offset: 0x03DD4BA0
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

		' Token: 0x170004A2 RID: 1186
		' (get) Token: 0x06000DD8 RID: 3544 RVA: 0x03DD6800 File Offset: 0x03DD4C00
		' (set) Token: 0x06000DD9 RID: 3545 RVA: 0x03DD6818 File Offset: 0x03DD4C18
		Friend Overridable Property Button17 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button17
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button17_Click
				Dim eventHandler2 As EventHandler = AddressOf Me.Button17_MouseLeave
				Dim eventHandler3 As EventHandler = AddressOf Me.Button17_MouseEnter
				Dim flag As Boolean = Me._Button17 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button17.Click, eventHandler
					RemoveHandler Me._Button17.MouseLeave, eventHandler2
					RemoveHandler Me._Button17.MouseEnter, eventHandler3
				End If
				Me._Button17 = value
				flag = Me._Button17 IsNot Nothing
				If flag Then
					AddHandler Me._Button17.Click, eventHandler
					AddHandler Me._Button17.MouseLeave, eventHandler2
					AddHandler Me._Button17.MouseEnter, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x170004A3 RID: 1187
		' (get) Token: 0x06000DDA RID: 3546 RVA: 0x03DD68C8 File Offset: 0x03DD4CC8
		' (set) Token: 0x06000DDB RID: 3547 RVA: 0x03DD68E0 File Offset: 0x03DD4CE0
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

		' Token: 0x170004A4 RID: 1188
		' (get) Token: 0x06000DDC RID: 3548 RVA: 0x03DD68EC File Offset: 0x03DD4CEC
		' (set) Token: 0x06000DDD RID: 3549 RVA: 0x03DD6904 File Offset: 0x03DD4D04
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

		' Token: 0x170004A5 RID: 1189
		' (get) Token: 0x06000DDE RID: 3550 RVA: 0x03DD6910 File Offset: 0x03DD4D10
		' (set) Token: 0x06000DDF RID: 3551 RVA: 0x03DD6928 File Offset: 0x03DD4D28
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

		' Token: 0x170004A6 RID: 1190
		' (get) Token: 0x06000DE0 RID: 3552 RVA: 0x03DD6934 File Offset: 0x03DD4D34
		' (set) Token: 0x06000DE1 RID: 3553 RVA: 0x03DD694C File Offset: 0x03DD4D4C
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

		' Token: 0x170004A7 RID: 1191
		' (get) Token: 0x06000DE2 RID: 3554 RVA: 0x03DD6958 File Offset: 0x03DD4D58
		' (set) Token: 0x06000DE3 RID: 3555 RVA: 0x03DD6970 File Offset: 0x03DD4D70
		Friend Overridable Property Button18 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button18
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button18_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.Button18_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.Button18_Click_1
				Dim flag As Boolean = Me._Button18 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button18.MouseLeave, eventHandler
					RemoveHandler Me._Button18.MouseEnter, eventHandler2
					RemoveHandler Me._Button18.Click, eventHandler3
				End If
				Me._Button18 = value
				flag = Me._Button18 IsNot Nothing
				If flag Then
					AddHandler Me._Button18.MouseLeave, eventHandler
					AddHandler Me._Button18.MouseEnter, eventHandler2
					AddHandler Me._Button18.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x170004A8 RID: 1192
		' (get) Token: 0x06000DE4 RID: 3556 RVA: 0x03DD6A20 File Offset: 0x03DD4E20
		' (set) Token: 0x06000DE5 RID: 3557 RVA: 0x03DD6A38 File Offset: 0x03DD4E38
		Friend Overridable Property Button19 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button19
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button19_Click
				Dim eventHandler2 As EventHandler = AddressOf Me.Button19_MouseLeave
				Dim eventHandler3 As EventHandler = AddressOf Me.Button19_MouseEnter
				Dim flag As Boolean = Me._Button19 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button19.Click, eventHandler
					RemoveHandler Me._Button19.MouseLeave, eventHandler2
					RemoveHandler Me._Button19.MouseEnter, eventHandler3
				End If
				Me._Button19 = value
				flag = Me._Button19 IsNot Nothing
				If flag Then
					AddHandler Me._Button19.Click, eventHandler
					AddHandler Me._Button19.MouseLeave, eventHandler2
					AddHandler Me._Button19.MouseEnter, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x170004A9 RID: 1193
		' (get) Token: 0x06000DE6 RID: 3558 RVA: 0x03DD6AE8 File Offset: 0x03DD4EE8
		' (set) Token: 0x06000DE7 RID: 3559 RVA: 0x03DD6B00 File Offset: 0x03DD4F00
		Friend Overridable Property Panel5 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.Panel5_MouseMove
				Dim mouseEventHandler2 As MouseEventHandler = AddressOf Me.Panel5_MouseDown
				Dim flag As Boolean = Me._Panel5 IsNot Nothing
				If flag Then
					RemoveHandler Me._Panel5.MouseMove, mouseEventHandler
					RemoveHandler Me._Panel5.MouseDown, mouseEventHandler2
				End If
				Me._Panel5 = value
				flag = Me._Panel5 IsNot Nothing
				If flag Then
					AddHandler Me._Panel5.MouseMove, mouseEventHandler
					AddHandler Me._Panel5.MouseDown, mouseEventHandler2
				End If
			End Set
		End Property

		' Token: 0x170004AA RID: 1194
		' (get) Token: 0x06000DE8 RID: 3560 RVA: 0x03DD6B88 File Offset: 0x03DD4F88
		' (set) Token: 0x06000DE9 RID: 3561 RVA: 0x03DD6BA0 File Offset: 0x03DD4FA0
		Friend Overridable Property TabPage5 As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage5 = value
			End Set
		End Property

		' Token: 0x170004AB RID: 1195
		' (get) Token: 0x06000DEA RID: 3562 RVA: 0x03DD6BAC File Offset: 0x03DD4FAC
		' (set) Token: 0x06000DEB RID: 3563 RVA: 0x03DD6BC4 File Offset: 0x03DD4FC4
		Friend Overridable Property TabPage6 As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage6 = value
			End Set
		End Property

		' Token: 0x170004AC RID: 1196
		' (get) Token: 0x06000DEC RID: 3564 RVA: 0x03DD6BD0 File Offset: 0x03DD4FD0
		' (set) Token: 0x06000DED RID: 3565 RVA: 0x03DD6BE8 File Offset: 0x03DD4FE8
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

		' Token: 0x170004AD RID: 1197
		' (get) Token: 0x06000DEE RID: 3566 RVA: 0x03DD6BF4 File Offset: 0x03DD4FF4
		' (set) Token: 0x06000DEF RID: 3567 RVA: 0x03DD6C0C File Offset: 0x03DD500C
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

		' Token: 0x170004AE RID: 1198
		' (get) Token: 0x06000DF0 RID: 3568 RVA: 0x03DD6C6C File Offset: 0x03DD506C
		' (set) Token: 0x06000DF1 RID: 3569 RVA: 0x03DD6C84 File Offset: 0x03DD5084
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

		' Token: 0x170004AF RID: 1199
		' (get) Token: 0x06000DF2 RID: 3570 RVA: 0x03DD6CE4 File Offset: 0x03DD50E4
		' (set) Token: 0x06000DF3 RID: 3571 RVA: 0x03DD6CFC File Offset: 0x03DD50FC
		Friend Overridable Property Button22 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button22
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button22_Click
				Dim flag As Boolean = Me._Button22 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button22.Click, eventHandler
				End If
				Me._Button22 = value
				flag = Me._Button22 IsNot Nothing
				If flag Then
					AddHandler Me._Button22.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170004B0 RID: 1200
		' (get) Token: 0x06000DF4 RID: 3572 RVA: 0x03DD6D5C File Offset: 0x03DD515C
		' (set) Token: 0x06000DF5 RID: 3573 RVA: 0x03DD6D74 File Offset: 0x03DD5174
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

		' Token: 0x170004B1 RID: 1201
		' (get) Token: 0x06000DF6 RID: 3574 RVA: 0x03DD6DD4 File Offset: 0x03DD51D4
		' (set) Token: 0x06000DF7 RID: 3575 RVA: 0x03DD6DEC File Offset: 0x03DD51EC
		Friend Overridable Property TextBox5 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim keyEventHandler As KeyEventHandler = AddressOf Me.TextBox5_KeyDown
				Dim flag As Boolean = Me._TextBox5 IsNot Nothing
				If flag Then
					RemoveHandler Me._TextBox5.KeyDown, keyEventHandler
				End If
				Me._TextBox5 = value
				flag = Me._TextBox5 IsNot Nothing
				If flag Then
					AddHandler Me._TextBox5.KeyDown, keyEventHandler
				End If
			End Set
		End Property

		' Token: 0x170004B2 RID: 1202
		' (get) Token: 0x06000DF8 RID: 3576 RVA: 0x03DD6E4C File Offset: 0x03DD524C
		' (set) Token: 0x06000DF9 RID: 3577 RVA: 0x03DD6E64 File Offset: 0x03DD5264
		Friend Overridable Property WebBrowser5 As WebBrowser
			<DebuggerNonUserCode()>
			Get
				Return Me._WebBrowser5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As WebBrowser)
				Dim webBrowserNavigatingEventHandler As WebBrowserNavigatingEventHandler = AddressOf Me.WebBrowser5_Navigating
				Dim flag As Boolean = Me._WebBrowser5 IsNot Nothing
				If flag Then
					RemoveHandler Me._WebBrowser5.Navigating, webBrowserNavigatingEventHandler
				End If
				Me._WebBrowser5 = value
				flag = Me._WebBrowser5 IsNot Nothing
				If flag Then
					AddHandler Me._WebBrowser5.Navigating, webBrowserNavigatingEventHandler
				End If
			End Set
		End Property

		' Token: 0x170004B3 RID: 1203
		' (get) Token: 0x06000DFA RID: 3578 RVA: 0x03DD6EC4 File Offset: 0x03DD52C4
		' (set) Token: 0x06000DFB RID: 3579 RVA: 0x03DD6EDC File Offset: 0x03DD52DC
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

		' Token: 0x170004B4 RID: 1204
		' (get) Token: 0x06000DFC RID: 3580 RVA: 0x03DD6EE8 File Offset: 0x03DD52E8
		' (set) Token: 0x06000DFD RID: 3581 RVA: 0x03DD6F00 File Offset: 0x03DD5300
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

		' Token: 0x170004B5 RID: 1205
		' (get) Token: 0x06000DFE RID: 3582 RVA: 0x03DD6F60 File Offset: 0x03DD5360
		' (set) Token: 0x06000DFF RID: 3583 RVA: 0x03DD6F78 File Offset: 0x03DD5378
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

		' Token: 0x170004B6 RID: 1206
		' (get) Token: 0x06000E00 RID: 3584 RVA: 0x03DD6FD8 File Offset: 0x03DD53D8
		' (set) Token: 0x06000E01 RID: 3585 RVA: 0x03DD6FF0 File Offset: 0x03DD53F0
		Friend Overridable Property Button26 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button26
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button26_Click
				Dim flag As Boolean = Me._Button26 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button26.Click, eventHandler
				End If
				Me._Button26 = value
				flag = Me._Button26 IsNot Nothing
				If flag Then
					AddHandler Me._Button26.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170004B7 RID: 1207
		' (get) Token: 0x06000E02 RID: 3586 RVA: 0x03DD7050 File Offset: 0x03DD5450
		' (set) Token: 0x06000E03 RID: 3587 RVA: 0x03DD7068 File Offset: 0x03DD5468
		Friend Overridable Property Button27 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button27
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button27_Click
				Dim flag As Boolean = Me._Button27 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button27.Click, eventHandler
				End If
				Me._Button27 = value
				flag = Me._Button27 IsNot Nothing
				If flag Then
					AddHandler Me._Button27.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170004B8 RID: 1208
		' (get) Token: 0x06000E04 RID: 3588 RVA: 0x03DD70C8 File Offset: 0x03DD54C8
		' (set) Token: 0x06000E05 RID: 3589 RVA: 0x03DD70E0 File Offset: 0x03DD54E0
		Friend Overridable Property TextBox6 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim keyEventHandler As KeyEventHandler = AddressOf Me.TextBox6_KeyDown
				Dim flag As Boolean = Me._TextBox6 IsNot Nothing
				If flag Then
					RemoveHandler Me._TextBox6.KeyDown, keyEventHandler
				End If
				Me._TextBox6 = value
				flag = Me._TextBox6 IsNot Nothing
				If flag Then
					AddHandler Me._TextBox6.KeyDown, keyEventHandler
				End If
			End Set
		End Property

		' Token: 0x170004B9 RID: 1209
		' (get) Token: 0x06000E06 RID: 3590 RVA: 0x03DD7140 File Offset: 0x03DD5540
		' (set) Token: 0x06000E07 RID: 3591 RVA: 0x03DD7158 File Offset: 0x03DD5558
		Friend Overridable Property WebBrowser6 As WebBrowser
			<DebuggerNonUserCode()>
			Get
				Return Me._WebBrowser6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As WebBrowser)
				Dim webBrowserNavigatingEventHandler As WebBrowserNavigatingEventHandler = AddressOf Me.WebBrowser6_Navigating
				Dim flag As Boolean = Me._WebBrowser6 IsNot Nothing
				If flag Then
					RemoveHandler Me._WebBrowser6.Navigating, webBrowserNavigatingEventHandler
				End If
				Me._WebBrowser6 = value
				flag = Me._WebBrowser6 IsNot Nothing
				If flag Then
					AddHandler Me._WebBrowser6.Navigating, webBrowserNavigatingEventHandler
				End If
			End Set
		End Property

		' Token: 0x06000E08 RID: 3592 RVA: 0x03DD71B8 File Offset: 0x03DD55B8
		Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000E09 RID: 3593 RVA: 0x03DD71BC File Offset: 0x03DD55BC
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.WebBrowser1.GoBack()
		End Sub

		' Token: 0x06000E0A RID: 3594 RVA: 0x03DD71CC File Offset: 0x03DD55CC
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Me.WebBrowser1.GoForward()
		End Sub

		' Token: 0x06000E0B RID: 3595 RVA: 0x03DD71DC File Offset: 0x03DD55DC
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			Me.WebBrowser1.Navigate(Me.TextBox1.Text)
			Dim flag As Boolean = Operators.CompareString(Me.TextBox1.Text, "CMD", False) = 0
			If flag Then
				MyProject.Forms.Form17.Show()
				Me.WebBrowser1.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
			End If
		End Sub

		' Token: 0x06000E0C RID: 3596 RVA: 0x03DD7244 File Offset: 0x03DD5644
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			Me.WebBrowser1.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
		End Sub

		' Token: 0x06000E0D RID: 3597 RVA: 0x03DD725C File Offset: 0x03DD565C
		Private Sub Button8_Click(sender As Object, e As EventArgs)
			Me.WebBrowser2.GoBack()
		End Sub

		' Token: 0x06000E0E RID: 3598 RVA: 0x03DD726C File Offset: 0x03DD566C
		Private Sub Button7_Click(sender As Object, e As EventArgs)
			Me.WebBrowser2.GoForward()
		End Sub

		' Token: 0x06000E0F RID: 3599 RVA: 0x03DD727C File Offset: 0x03DD567C
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			Me.WebBrowser2.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
		End Sub

		' Token: 0x06000E10 RID: 3600 RVA: 0x03DD7294 File Offset: 0x03DD5694
		Private Sub Button6_Click(sender As Object, e As EventArgs)
			Me.WebBrowser2.Navigate(Me.TextBox2.Text)
			Dim flag As Boolean = Operators.CompareString(Me.TextBox2.Text, "CMD", False) = 0
			If flag Then
				MyProject.Forms.Form17.Show()
				Me.WebBrowser2.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
			End If
		End Sub

		' Token: 0x06000E11 RID: 3601 RVA: 0x03DD72FC File Offset: 0x03DD56FC
		Private Sub Button12_Click(sender As Object, e As EventArgs)
			Me.WebBrowser3.GoBack()
		End Sub

		' Token: 0x06000E12 RID: 3602 RVA: 0x03DD730C File Offset: 0x03DD570C
		Private Sub Button11_Click(sender As Object, e As EventArgs)
			Me.WebBrowser3.GoForward()
		End Sub

		' Token: 0x06000E13 RID: 3603 RVA: 0x03DD731C File Offset: 0x03DD571C
		Private Sub Button9_Click(sender As Object, e As EventArgs)
			Me.WebBrowser3.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
		End Sub

		' Token: 0x06000E14 RID: 3604 RVA: 0x03DD7334 File Offset: 0x03DD5734
		Private Sub Button10_Click(sender As Object, e As EventArgs)
			Me.WebBrowser3.Navigate(Me.TextBox3.Text)
			Dim flag As Boolean = Operators.CompareString(Me.TextBox3.Text, "CMD", False) = 0
			If flag Then
				MyProject.Forms.Form17.Show()
				Me.WebBrowser3.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
			End If
		End Sub

		' Token: 0x06000E15 RID: 3605 RVA: 0x03DD739C File Offset: 0x03DD579C
		Private Sub Button16_Click(sender As Object, e As EventArgs)
			Me.WebBrowser4.GoBack()
		End Sub

		' Token: 0x06000E16 RID: 3606 RVA: 0x03DD73AC File Offset: 0x03DD57AC
		Private Sub Button15_Click(sender As Object, e As EventArgs)
			Me.WebBrowser4.GoForward()
		End Sub

		' Token: 0x06000E17 RID: 3607 RVA: 0x03DD73BC File Offset: 0x03DD57BC
		Private Sub Button13_Click(sender As Object, e As EventArgs)
			Me.WebBrowser4.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
		End Sub

		' Token: 0x06000E18 RID: 3608 RVA: 0x03DD73D4 File Offset: 0x03DD57D4
		Private Sub Button14_Click(sender As Object, e As EventArgs)
			Me.WebBrowser4.Navigate(Me.TextBox4.Text)
			Dim flag As Boolean = Operators.CompareString(Me.TextBox4.Text, "CMD", False) = 0
			If flag Then
				MyProject.Forms.Form17.Show()
				Me.WebBrowser4.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
			End If
		End Sub

		' Token: 0x06000E19 RID: 3609 RVA: 0x03DD743C File Offset: 0x03DD583C
		Private Sub Form35_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000E1A RID: 3610 RVA: 0x03DD7440 File Offset: 0x03DD5840
		Private Sub Button17_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000E1B RID: 3611 RVA: 0x03DD744C File Offset: 0x03DD584C
		Private Sub Button18_Click(sender As Object, e As EventArgs)
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x06000E1C RID: 3612 RVA: 0x03DD7458 File Offset: 0x03DD5858
		Private Sub Button18_Click_1(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.WindowState = FormWindowState.Normal
			If flag Then
				Me.WindowState = FormWindowState.Maximized
			Else
				Me.WindowState = FormWindowState.Normal
			End If
		End Sub

		' Token: 0x06000E1D RID: 3613 RVA: 0x03DD7488 File Offset: 0x03DD5888
		Private Sub Button19_Click(sender As Object, e As EventArgs)
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x06000E1E RID: 3614 RVA: 0x03DD7494 File Offset: 0x03DD5894
		Private Sub Button19_MouseEnter(sender As Object, e As EventArgs)
			Me.Button19.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000E1F RID: 3615 RVA: 0x03DD74AC File Offset: 0x03DD58AC
		Private Sub Button19_MouseLeave(sender As Object, e As EventArgs)
			Me.Button19.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000E20 RID: 3616 RVA: 0x03DD74C4 File Offset: 0x03DD58C4
		Private Sub Button18_MouseEnter(sender As Object, e As EventArgs)
			Me.Button18.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000E21 RID: 3617 RVA: 0x03DD74DC File Offset: 0x03DD58DC
		Private Sub Button18_MouseLeave(sender As Object, e As EventArgs)
			Me.Button18.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000E22 RID: 3618 RVA: 0x03DD74F4 File Offset: 0x03DD58F4
		Private Sub Button17_MouseEnter(sender As Object, e As EventArgs)
			Me.Button17.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000E23 RID: 3619 RVA: 0x03DD750C File Offset: 0x03DD590C
		Private Sub Button17_MouseLeave(sender As Object, e As EventArgs)
			Me.Button17.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000E24 RID: 3620 RVA: 0x03DD7524 File Offset: 0x03DD5924
		Private Sub Panel5_MouseDown(sender As Object, e As MouseEventArgs)
			' The following expression was wrapped in a checked-expression
			Me.mouse_move = New Point(0 - e.X, 0 - e.Y)
		End Sub

		' Token: 0x06000E25 RID: 3621 RVA: 0x03DD7544 File Offset: 0x03DD5944
		Private Sub Panel5_MouseMove(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = e.Button = MouseButtons.Left
			If flag Then
				Dim mousePosition As Point = Control.MousePosition
				mousePosition.Offset(Me.mouse_move.X, Me.mouse_move.Y)
				Me.Location = mousePosition
			End If
		End Sub

		' Token: 0x06000E26 RID: 3622 RVA: 0x03DD7594 File Offset: 0x03DD5994
		Private Sub Button20_Click(sender As Object, e As EventArgs)
			Me.WebBrowser5.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
		End Sub

		' Token: 0x06000E27 RID: 3623 RVA: 0x03DD75AC File Offset: 0x03DD59AC
		Private Sub Button24_Click(sender As Object, e As EventArgs)
			Me.WebBrowser6.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
		End Sub

		' Token: 0x06000E28 RID: 3624 RVA: 0x03DD75C4 File Offset: 0x03DD59C4
		Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = e.KeyCode = Keys.[Return]
			If flag Then
				Me.WebBrowser1.Navigate(Me.TextBox1.Text)
			End If
		End Sub

		' Token: 0x06000E29 RID: 3625 RVA: 0x03DD75FC File Offset: 0x03DD59FC
		Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = e.KeyCode = Keys.[Return]
			If flag Then
				Me.WebBrowser2.Navigate(Me.TextBox1.Text)
			End If
		End Sub

		' Token: 0x06000E2A RID: 3626 RVA: 0x03DD7634 File Offset: 0x03DD5A34
		Private Sub TabControl1_KeyDown(sender As Object, e As KeyEventArgs)
		End Sub

		' Token: 0x06000E2B RID: 3627 RVA: 0x03DD7638 File Offset: 0x03DD5A38
		Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = e.KeyCode = Keys.[Return]
			If flag Then
				Me.WebBrowser3.Navigate(Me.TextBox1.Text)
			End If
		End Sub

		' Token: 0x06000E2C RID: 3628 RVA: 0x03DD7670 File Offset: 0x03DD5A70
		Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = e.KeyCode = Keys.[Return]
			If flag Then
				Me.WebBrowser4.Navigate(Me.TextBox1.Text)
			End If
		End Sub

		' Token: 0x06000E2D RID: 3629 RVA: 0x03DD76A8 File Offset: 0x03DD5AA8
		Private Sub TextBox5_KeyDown(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = e.KeyCode = Keys.[Return]
			If flag Then
				Me.WebBrowser5.Navigate(Me.TextBox1.Text)
			End If
		End Sub

		' Token: 0x06000E2E RID: 3630 RVA: 0x03DD76E0 File Offset: 0x03DD5AE0
		Private Sub TextBox6_KeyDown(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = e.KeyCode = Keys.[Return]
			If flag Then
				Me.WebBrowser6.Navigate(Me.TextBox1.Text)
			End If
		End Sub

		' Token: 0x06000E2F RID: 3631 RVA: 0x03DD7718 File Offset: 0x03DD5B18
		Private Sub Button22_Click(sender As Object, e As EventArgs)
			Me.WebBrowser5.GoBack()
		End Sub

		' Token: 0x06000E30 RID: 3632 RVA: 0x03DD7728 File Offset: 0x03DD5B28
		Private Sub Button21_Click(sender As Object, e As EventArgs)
			Me.WebBrowser5.GoForward()
		End Sub

		' Token: 0x06000E31 RID: 3633 RVA: 0x03DD7738 File Offset: 0x03DD5B38
		Private Sub Button23_Click(sender As Object, e As EventArgs)
			Me.WebBrowser5.Navigate(Me.TextBox5.Text)
		End Sub

		' Token: 0x06000E32 RID: 3634 RVA: 0x03DD7754 File Offset: 0x03DD5B54
		Private Sub Button26_Click(sender As Object, e As EventArgs)
			Me.WebBrowser6.GoBack()
		End Sub

		' Token: 0x06000E33 RID: 3635 RVA: 0x03DD7764 File Offset: 0x03DD5B64
		Private Sub Button25_Click(sender As Object, e As EventArgs)
			Me.WebBrowser6.GoForward()
		End Sub

		' Token: 0x06000E34 RID: 3636 RVA: 0x03DD7774 File Offset: 0x03DD5B74
		Private Sub Button27_Click(sender As Object, e As EventArgs)
			Me.WebBrowser6.Navigate(Me.TextBox6.Text)
		End Sub

		' Token: 0x06000E35 RID: 3637 RVA: 0x03DD7790 File Offset: 0x03DD5B90
		Private Sub WebBrowser1_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs)
			Me.TextBox1.Text = Me.WebBrowser1.Url.ToString()
		End Sub

		' Token: 0x06000E36 RID: 3638 RVA: 0x03DD77B0 File Offset: 0x03DD5BB0
		Private Sub WebBrowser2_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs)
			Me.TextBox2.Text = Me.WebBrowser2.Url.ToString()
		End Sub

		' Token: 0x06000E37 RID: 3639 RVA: 0x03DD77D0 File Offset: 0x03DD5BD0
		Private Sub WebBrowser3_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs)
			Me.TextBox3.Text = Me.WebBrowser3.Url.ToString()
		End Sub

		' Token: 0x06000E38 RID: 3640 RVA: 0x03DD77F0 File Offset: 0x03DD5BF0
		Private Sub WebBrowser4_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs)
			Me.TextBox4.Text = Me.WebBrowser4.Url.ToString()
		End Sub

		' Token: 0x06000E39 RID: 3641 RVA: 0x03DD7810 File Offset: 0x03DD5C10
		Private Sub WebBrowser5_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs)
			Me.TextBox5.Text = Me.WebBrowser5.Url.ToString()
		End Sub

		' Token: 0x06000E3A RID: 3642 RVA: 0x03DD7830 File Offset: 0x03DD5C30
		Private Sub WebBrowser6_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs)
			Me.TextBox6.Text = Me.WebBrowser6.Url.ToString()
		End Sub

		' Token: 0x0400050A RID: 1290
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400050C RID: 1292
		<AccessedThroughProperty("TabPage4")>
		Private _TabPage4 As TabPage

		' Token: 0x0400050D RID: 1293
		<AccessedThroughProperty("TabPage3")>
		Private _TabPage3 As TabPage

		' Token: 0x0400050E RID: 1294
		<AccessedThroughProperty("TabPage2")>
		Private _TabPage2 As TabPage

		' Token: 0x0400050F RID: 1295
		<AccessedThroughProperty("TabPage1")>
		Private _TabPage1 As TabPage

		' Token: 0x04000510 RID: 1296
		<AccessedThroughProperty("TabControl1")>
		Private _TabControl1 As TabControl

		' Token: 0x04000511 RID: 1297
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000512 RID: 1298
		<AccessedThroughProperty("WebBrowser1")>
		Private _WebBrowser1 As WebBrowser

		' Token: 0x04000513 RID: 1299
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x04000514 RID: 1300
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x04000515 RID: 1301
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x04000516 RID: 1302
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x04000517 RID: 1303
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x04000518 RID: 1304
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x04000519 RID: 1305
		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		' Token: 0x0400051A RID: 1306
		<AccessedThroughProperty("Button7")>
		Private _Button7 As Button

		' Token: 0x0400051B RID: 1307
		<AccessedThroughProperty("WebBrowser2")>
		Private _WebBrowser2 As WebBrowser

		' Token: 0x0400051C RID: 1308
		<AccessedThroughProperty("Button8")>
		Private _Button8 As Button

		' Token: 0x0400051D RID: 1309
		<AccessedThroughProperty("Button9")>
		Private _Button9 As Button

		' Token: 0x0400051E RID: 1310
		<AccessedThroughProperty("Button10")>
		Private _Button10 As Button

		' Token: 0x0400051F RID: 1311
		<AccessedThroughProperty("TextBox3")>
		Private _TextBox3 As TextBox

		' Token: 0x04000520 RID: 1312
		<AccessedThroughProperty("Button11")>
		Private _Button11 As Button

		' Token: 0x04000521 RID: 1313
		<AccessedThroughProperty("WebBrowser3")>
		Private _WebBrowser3 As WebBrowser

		' Token: 0x04000522 RID: 1314
		<AccessedThroughProperty("Button12")>
		Private _Button12 As Button

		' Token: 0x04000523 RID: 1315
		<AccessedThroughProperty("Button13")>
		Private _Button13 As Button

		' Token: 0x04000524 RID: 1316
		<AccessedThroughProperty("Button14")>
		Private _Button14 As Button

		' Token: 0x04000525 RID: 1317
		<AccessedThroughProperty("TextBox4")>
		Private _TextBox4 As TextBox

		' Token: 0x04000526 RID: 1318
		<AccessedThroughProperty("Button15")>
		Private _Button15 As Button

		' Token: 0x04000527 RID: 1319
		<AccessedThroughProperty("WebBrowser4")>
		Private _WebBrowser4 As WebBrowser

		' Token: 0x04000528 RID: 1320
		<AccessedThroughProperty("Button16")>
		Private _Button16 As Button

		' Token: 0x04000529 RID: 1321
		<AccessedThroughProperty("Button17")>
		Private _Button17 As Button

		' Token: 0x0400052A RID: 1322
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x0400052B RID: 1323
		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel

		' Token: 0x0400052C RID: 1324
		<AccessedThroughProperty("Panel3")>
		Private _Panel3 As Panel

		' Token: 0x0400052D RID: 1325
		<AccessedThroughProperty("Panel4")>
		Private _Panel4 As Panel

		' Token: 0x0400052E RID: 1326
		<AccessedThroughProperty("Button18")>
		Private _Button18 As Button

		' Token: 0x0400052F RID: 1327
		<AccessedThroughProperty("Button19")>
		Private _Button19 As Button

		' Token: 0x04000530 RID: 1328
		<AccessedThroughProperty("Panel5")>
		Private _Panel5 As Panel

		' Token: 0x04000531 RID: 1329
		<AccessedThroughProperty("TabPage5")>
		Private _TabPage5 As TabPage

		' Token: 0x04000532 RID: 1330
		<AccessedThroughProperty("TabPage6")>
		Private _TabPage6 As TabPage

		' Token: 0x04000533 RID: 1331
		<AccessedThroughProperty("Panel6")>
		Private _Panel6 As Panel

		' Token: 0x04000534 RID: 1332
		<AccessedThroughProperty("Button20")>
		Private _Button20 As Button

		' Token: 0x04000535 RID: 1333
		<AccessedThroughProperty("Button21")>
		Private _Button21 As Button

		' Token: 0x04000536 RID: 1334
		<AccessedThroughProperty("Button22")>
		Private _Button22 As Button

		' Token: 0x04000537 RID: 1335
		<AccessedThroughProperty("Button23")>
		Private _Button23 As Button

		' Token: 0x04000538 RID: 1336
		<AccessedThroughProperty("TextBox5")>
		Private _TextBox5 As TextBox

		' Token: 0x04000539 RID: 1337
		<AccessedThroughProperty("WebBrowser5")>
		Private _WebBrowser5 As WebBrowser

		' Token: 0x0400053A RID: 1338
		<AccessedThroughProperty("Panel7")>
		Private _Panel7 As Panel

		' Token: 0x0400053B RID: 1339
		<AccessedThroughProperty("Button24")>
		Private _Button24 As Button

		' Token: 0x0400053C RID: 1340
		<AccessedThroughProperty("Button25")>
		Private _Button25 As Button

		' Token: 0x0400053D RID: 1341
		<AccessedThroughProperty("Button26")>
		Private _Button26 As Button

		' Token: 0x0400053E RID: 1342
		<AccessedThroughProperty("Button27")>
		Private _Button27 As Button

		' Token: 0x0400053F RID: 1343
		<AccessedThroughProperty("TextBox6")>
		Private _TextBox6 As TextBox

		' Token: 0x04000540 RID: 1344
		<AccessedThroughProperty("WebBrowser6")>
		Private _WebBrowser6 As WebBrowser

		' Token: 0x04000541 RID: 1345
		Private mouse_move As Point
	End Class
End Namespace
