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
	' Token: 0x02000055 RID: 85
	<DesignerGenerated()>
	Public Partial Class Form39
		Inherits Form

		' Token: 0x06000EA3 RID: 3747 RVA: 0x03DD9AE4 File Offset: 0x03DD7EE4
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form39_Load
			AddHandler MyBase.Activated, AddressOf Me.Form39_Activated
			Dim _ENCList As List(Of WeakReference) = Form39.__ENCList
			SyncLock _ENCList
				Form39.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170004DB RID: 1243
		' (get) Token: 0x06000EA6 RID: 3750 RVA: 0x03DDAD5C File Offset: 0x03DD915C
		' (set) Token: 0x06000EA7 RID: 3751 RVA: 0x03DDAD74 File Offset: 0x03DD9174
		Friend Overridable Property LinkLabel1 As LinkLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._LinkLabel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim linkLabelLinkClickedEventHandler As LinkLabelLinkClickedEventHandler = AddressOf Me.LinkLabel1_LinkClicked
				Dim flag As Boolean = Me._LinkLabel1 IsNot Nothing
				If flag Then
					RemoveHandler Me._LinkLabel1.LinkClicked, linkLabelLinkClickedEventHandler
				End If
				Me._LinkLabel1 = value
				flag = Me._LinkLabel1 IsNot Nothing
				If flag Then
					AddHandler Me._LinkLabel1.LinkClicked, linkLabelLinkClickedEventHandler
				End If
			End Set
		End Property

		' Token: 0x170004DC RID: 1244
		' (get) Token: 0x06000EA8 RID: 3752 RVA: 0x03DDADD4 File Offset: 0x03DD91D4
		' (set) Token: 0x06000EA9 RID: 3753 RVA: 0x03DDADEC File Offset: 0x03DD91EC
		Friend Overridable Property LinkLabel2 As LinkLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._LinkLabel2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim linkLabelLinkClickedEventHandler As LinkLabelLinkClickedEventHandler = AddressOf Me.LinkLabel2_LinkClicked
				Dim flag As Boolean = Me._LinkLabel2 IsNot Nothing
				If flag Then
					RemoveHandler Me._LinkLabel2.LinkClicked, linkLabelLinkClickedEventHandler
				End If
				Me._LinkLabel2 = value
				flag = Me._LinkLabel2 IsNot Nothing
				If flag Then
					AddHandler Me._LinkLabel2.LinkClicked, linkLabelLinkClickedEventHandler
				End If
			End Set
		End Property

		' Token: 0x170004DD RID: 1245
		' (get) Token: 0x06000EAA RID: 3754 RVA: 0x03DDAE4C File Offset: 0x03DD924C
		' (set) Token: 0x06000EAB RID: 3755 RVA: 0x03DDAE64 File Offset: 0x03DD9264
		Friend Overridable Property LinkLabel3 As LinkLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._LinkLabel3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Me._LinkLabel3 = value
			End Set
		End Property

		' Token: 0x170004DE RID: 1246
		' (get) Token: 0x06000EAC RID: 3756 RVA: 0x03DDAE70 File Offset: 0x03DD9270
		' (set) Token: 0x06000EAD RID: 3757 RVA: 0x03DDAE88 File Offset: 0x03DD9288
		Friend Overridable Property LinkLabel4 As LinkLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._LinkLabel4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim linkLabelLinkClickedEventHandler As LinkLabelLinkClickedEventHandler = AddressOf Me.LinkLabel4_LinkClicked
				Dim flag As Boolean = Me._LinkLabel4 IsNot Nothing
				If flag Then
					RemoveHandler Me._LinkLabel4.LinkClicked, linkLabelLinkClickedEventHandler
				End If
				Me._LinkLabel4 = value
				flag = Me._LinkLabel4 IsNot Nothing
				If flag Then
					AddHandler Me._LinkLabel4.LinkClicked, linkLabelLinkClickedEventHandler
				End If
			End Set
		End Property

		' Token: 0x170004DF RID: 1247
		' (get) Token: 0x06000EAE RID: 3758 RVA: 0x03DDAEE8 File Offset: 0x03DD92E8
		' (set) Token: 0x06000EAF RID: 3759 RVA: 0x03DDAF00 File Offset: 0x03DD9300
		Friend Overridable Property LinkLabel5 As LinkLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._LinkLabel5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim linkLabelLinkClickedEventHandler As LinkLabelLinkClickedEventHandler = AddressOf Me.LinkLabel5_LinkClicked
				Dim flag As Boolean = Me._LinkLabel5 IsNot Nothing
				If flag Then
					RemoveHandler Me._LinkLabel5.LinkClicked, linkLabelLinkClickedEventHandler
				End If
				Me._LinkLabel5 = value
				flag = Me._LinkLabel5 IsNot Nothing
				If flag Then
					AddHandler Me._LinkLabel5.LinkClicked, linkLabelLinkClickedEventHandler
				End If
			End Set
		End Property

		' Token: 0x170004E0 RID: 1248
		' (get) Token: 0x06000EB0 RID: 3760 RVA: 0x03DDAF60 File Offset: 0x03DD9360
		' (set) Token: 0x06000EB1 RID: 3761 RVA: 0x03DDAF78 File Offset: 0x03DD9378
		Friend Overridable Property LinkLabel6 As LinkLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._LinkLabel6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim linkLabelLinkClickedEventHandler As LinkLabelLinkClickedEventHandler = AddressOf Me.LinkLabel6_LinkClicked
				Dim flag As Boolean = Me._LinkLabel6 IsNot Nothing
				If flag Then
					RemoveHandler Me._LinkLabel6.LinkClicked, linkLabelLinkClickedEventHandler
				End If
				Me._LinkLabel6 = value
				flag = Me._LinkLabel6 IsNot Nothing
				If flag Then
					AddHandler Me._LinkLabel6.LinkClicked, linkLabelLinkClickedEventHandler
				End If
			End Set
		End Property

		' Token: 0x170004E1 RID: 1249
		' (get) Token: 0x06000EB2 RID: 3762 RVA: 0x03DDAFD8 File Offset: 0x03DD93D8
		' (set) Token: 0x06000EB3 RID: 3763 RVA: 0x03DDAFF0 File Offset: 0x03DD93F0
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

		' Token: 0x170004E2 RID: 1250
		' (get) Token: 0x06000EB4 RID: 3764 RVA: 0x03DDB0A0 File Offset: 0x03DD94A0
		' (set) Token: 0x06000EB5 RID: 3765 RVA: 0x03DDB0B8 File Offset: 0x03DD94B8
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

		' Token: 0x170004E3 RID: 1251
		' (get) Token: 0x06000EB6 RID: 3766 RVA: 0x03DDB168 File Offset: 0x03DD9568
		' (set) Token: 0x06000EB7 RID: 3767 RVA: 0x03DDB180 File Offset: 0x03DD9580
		Friend Overridable Property Button3 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button3_Click
				Dim eventHandler2 As EventHandler = AddressOf Me.Button3_MouseLeave
				Dim eventHandler3 As EventHandler = AddressOf Me.Button3_MouseEnter
				Dim flag As Boolean = Me._Button3 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button3.Click, eventHandler
					RemoveHandler Me._Button3.MouseLeave, eventHandler2
					RemoveHandler Me._Button3.MouseEnter, eventHandler3
				End If
				Me._Button3 = value
				flag = Me._Button3 IsNot Nothing
				If flag Then
					AddHandler Me._Button3.Click, eventHandler
					AddHandler Me._Button3.MouseLeave, eventHandler2
					AddHandler Me._Button3.MouseEnter, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x170004E4 RID: 1252
		' (get) Token: 0x06000EB8 RID: 3768 RVA: 0x03DDB230 File Offset: 0x03DD9630
		' (set) Token: 0x06000EB9 RID: 3769 RVA: 0x03DDB248 File Offset: 0x03DD9648
		Friend Overridable Property LinkLabel7 As LinkLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._LinkLabel7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim linkLabelLinkClickedEventHandler As LinkLabelLinkClickedEventHandler = AddressOf Me.LinkLabel7_LinkClicked
				Dim flag As Boolean = Me._LinkLabel7 IsNot Nothing
				If flag Then
					RemoveHandler Me._LinkLabel7.LinkClicked, linkLabelLinkClickedEventHandler
				End If
				Me._LinkLabel7 = value
				flag = Me._LinkLabel7 IsNot Nothing
				If flag Then
					AddHandler Me._LinkLabel7.LinkClicked, linkLabelLinkClickedEventHandler
				End If
			End Set
		End Property

		' Token: 0x170004E5 RID: 1253
		' (get) Token: 0x06000EBA RID: 3770 RVA: 0x03DDB2A8 File Offset: 0x03DD96A8
		' (set) Token: 0x06000EBB RID: 3771 RVA: 0x03DDB2C0 File Offset: 0x03DD96C0
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

		' Token: 0x170004E6 RID: 1254
		' (get) Token: 0x06000EBC RID: 3772 RVA: 0x03DDB348 File Offset: 0x03DD9748
		' (set) Token: 0x06000EBD RID: 3773 RVA: 0x03DDB360 File Offset: 0x03DD9760
		Friend Overridable Property LinkLabel8 As LinkLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._LinkLabel8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim linkLabelLinkClickedEventHandler As LinkLabelLinkClickedEventHandler = AddressOf Me.LinkLabel8_LinkClicked
				Dim flag As Boolean = Me._LinkLabel8 IsNot Nothing
				If flag Then
					RemoveHandler Me._LinkLabel8.LinkClicked, linkLabelLinkClickedEventHandler
				End If
				Me._LinkLabel8 = value
				flag = Me._LinkLabel8 IsNot Nothing
				If flag Then
					AddHandler Me._LinkLabel8.LinkClicked, linkLabelLinkClickedEventHandler
				End If
			End Set
		End Property

		' Token: 0x170004E7 RID: 1255
		' (get) Token: 0x06000EBE RID: 3774 RVA: 0x03DDB3C0 File Offset: 0x03DD97C0
		' (set) Token: 0x06000EBF RID: 3775 RVA: 0x03DDB3D8 File Offset: 0x03DD97D8
		Friend Overridable Property LinkLabel9 As LinkLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._LinkLabel9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim linkLabelLinkClickedEventHandler As LinkLabelLinkClickedEventHandler = AddressOf Me.LinkLabel9_LinkClicked
				Dim flag As Boolean = Me._LinkLabel9 IsNot Nothing
				If flag Then
					RemoveHandler Me._LinkLabel9.LinkClicked, linkLabelLinkClickedEventHandler
				End If
				Me._LinkLabel9 = value
				flag = Me._LinkLabel9 IsNot Nothing
				If flag Then
					AddHandler Me._LinkLabel9.LinkClicked, linkLabelLinkClickedEventHandler
				End If
			End Set
		End Property

		' Token: 0x170004E8 RID: 1256
		' (get) Token: 0x06000EC0 RID: 3776 RVA: 0x03DDB438 File Offset: 0x03DD9838
		' (set) Token: 0x06000EC1 RID: 3777 RVA: 0x03DDB450 File Offset: 0x03DD9850
		Friend Overridable Property PictureBox1 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox1_Click
				Dim flag As Boolean = Me._PictureBox1 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox1.Click, eventHandler
				End If
				Me._PictureBox1 = value
				flag = Me._PictureBox1 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox1.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170004E9 RID: 1257
		' (get) Token: 0x06000EC2 RID: 3778 RVA: 0x03DDB4B0 File Offset: 0x03DD98B0
		' (set) Token: 0x06000EC3 RID: 3779 RVA: 0x03DDB4C8 File Offset: 0x03DD98C8
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

		' Token: 0x170004EA RID: 1258
		' (get) Token: 0x06000EC4 RID: 3780 RVA: 0x03DDB4D4 File Offset: 0x03DD98D4
		' (set) Token: 0x06000EC5 RID: 3781 RVA: 0x03DDB4EC File Offset: 0x03DD98EC
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

		' Token: 0x170004EB RID: 1259
		' (get) Token: 0x06000EC6 RID: 3782 RVA: 0x03DDB54C File Offset: 0x03DD994C
		' (set) Token: 0x06000EC7 RID: 3783 RVA: 0x03DDB564 File Offset: 0x03DD9964
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

		' Token: 0x170004EC RID: 1260
		' (get) Token: 0x06000EC8 RID: 3784 RVA: 0x03DDB5C4 File Offset: 0x03DD99C4
		' (set) Token: 0x06000EC9 RID: 3785 RVA: 0x03DDB5DC File Offset: 0x03DD99DC
		Friend Overridable Property PictureBox3 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox3_Click
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

		' Token: 0x170004ED RID: 1261
		' (get) Token: 0x06000ECA RID: 3786 RVA: 0x03DDB63C File Offset: 0x03DD9A3C
		' (set) Token: 0x06000ECB RID: 3787 RVA: 0x03DDB654 File Offset: 0x03DD9A54
		Friend Overridable Property PictureBox6 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox6_Click
				Dim flag As Boolean = Me._PictureBox6 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox6.Click, eventHandler
				End If
				Me._PictureBox6 = value
				flag = Me._PictureBox6 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox6.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170004EE RID: 1262
		' (get) Token: 0x06000ECC RID: 3788 RVA: 0x03DDB6B4 File Offset: 0x03DD9AB4
		' (set) Token: 0x06000ECD RID: 3789 RVA: 0x03DDB6CC File Offset: 0x03DD9ACC
		Friend Overridable Property PictureBox5 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox5_Click
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

		' Token: 0x06000ECE RID: 3790 RVA: 0x03DDB72C File Offset: 0x03DD9B2C
		Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			MyProject.Forms.Form22.Show()
		End Sub

		' Token: 0x06000ECF RID: 3791 RVA: 0x03DDB740 File Offset: 0x03DD9B40
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000ED0 RID: 3792 RVA: 0x03DDB74C File Offset: 0x03DD9B4C
		Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			MyProject.Forms.Form20.Show()
		End Sub

		' Token: 0x06000ED1 RID: 3793 RVA: 0x03DDB760 File Offset: 0x03DD9B60
		Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
		End Sub

		' Token: 0x06000ED2 RID: 3794 RVA: 0x03DDB764 File Offset: 0x03DD9B64
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.WindowState = FormWindowState.Normal
			If flag Then
				Me.WindowState = FormWindowState.Maximized
			Else
				Me.WindowState = FormWindowState.Normal
			End If
		End Sub

		' Token: 0x06000ED3 RID: 3795 RVA: 0x03DDB794 File Offset: 0x03DD9B94
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x06000ED4 RID: 3796 RVA: 0x03DDB7A0 File Offset: 0x03DD9BA0
		Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			MyProject.Forms.Form33.Show()
			MyProject.Forms.Form33.Timer2.Start()
		End Sub

		' Token: 0x06000ED5 RID: 3797 RVA: 0x03DDB7CC File Offset: 0x03DD9BCC
		Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			MyProject.Forms.Form33.Show()
			MyProject.Forms.Form33.Timer1.Start()
		End Sub

		' Token: 0x06000ED6 RID: 3798 RVA: 0x03DDB7F8 File Offset: 0x03DD9BF8
		Private Sub Button1_MouseEnter(sender As Object, e As EventArgs)
			Me.Button1.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000ED7 RID: 3799 RVA: 0x03DDB810 File Offset: 0x03DD9C10
		Private Sub Button1_MouseLeave(sender As Object, e As EventArgs)
			Me.Button1.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000ED8 RID: 3800 RVA: 0x03DDB828 File Offset: 0x03DD9C28
		Private Sub Button3_MouseEnter(sender As Object, e As EventArgs)
			Me.Button3.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000ED9 RID: 3801 RVA: 0x03DDB840 File Offset: 0x03DD9C40
		Private Sub Button3_MouseLeave(sender As Object, e As EventArgs)
			Me.Button3.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000EDA RID: 3802 RVA: 0x03DDB858 File Offset: 0x03DD9C58
		Private Sub Button2_MouseEnter(sender As Object, e As EventArgs)
			Me.Button2.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000EDB RID: 3803 RVA: 0x03DDB870 File Offset: 0x03DD9C70
		Private Sub Button2_MouseLeave(sender As Object, e As EventArgs)
			Me.Button2.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000EDC RID: 3804 RVA: 0x03DDB888 File Offset: 0x03DD9C88
		Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			MyProject.Forms.Form43.Show()
		End Sub

		' Token: 0x06000EDD RID: 3805 RVA: 0x03DDB89C File Offset: 0x03DD9C9C
		Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs)
			' The following expression was wrapped in a checked-expression
			Me.mouse_move = New Point(0 - e.X, 0 - e.Y)
		End Sub

		' Token: 0x06000EDE RID: 3806 RVA: 0x03DDB8BC File Offset: 0x03DD9CBC
		Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = e.Button = MouseButtons.Left
			If flag Then
				Dim mousePosition As Point = Control.MousePosition
				mousePosition.Offset(Me.mouse_move.X, Me.mouse_move.Y)
				Me.Location = mousePosition
			End If
		End Sub

		' Token: 0x06000EDF RID: 3807 RVA: 0x03DDB90C File Offset: 0x03DD9D0C
		Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			MyProject.Forms.Form21.Show()
		End Sub

		' Token: 0x06000EE0 RID: 3808 RVA: 0x03DDB920 File Offset: 0x03DD9D20
		Private Sub LinkLabel9_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			MyProject.Forms.Form51.Show()
		End Sub

		' Token: 0x06000EE1 RID: 3809 RVA: 0x03DDB934 File Offset: 0x03DD9D34
		Private Sub Form39_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000EE2 RID: 3810 RVA: 0x03DDB938 File Offset: 0x03DD9D38
		Private Sub Form39_Activated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Me.LinkLabel1.Enabled
			If flag Then
				Me.LinkLabel1.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Underline)
			End If
			flag = Not Me.LinkLabel2.Enabled
			If flag Then
				Me.LinkLabel2.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Underline)
			End If
			flag = Not Me.LinkLabel3.Enabled
			If flag Then
				Me.LinkLabel3.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Underline)
			End If
			flag = Not Me.LinkLabel4.Enabled
			If flag Then
				Me.LinkLabel4.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Underline)
			End If
			flag = Not Me.LinkLabel5.Enabled
			If flag Then
				Me.LinkLabel5.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Underline)
			End If
			flag = Not Me.LinkLabel6.Enabled
			If flag Then
				Me.LinkLabel6.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Underline)
			End If
			flag = Not Me.LinkLabel7.Enabled
			If flag Then
				Me.LinkLabel7.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Underline)
			End If
			flag = Not Me.LinkLabel8.Enabled
			If flag Then
				Me.LinkLabel8.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Underline)
			End If
			flag = Not Me.LinkLabel9.Enabled
			If flag Then
				Me.LinkLabel9.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Underline)
			End If
		End Sub

		' Token: 0x06000EE3 RID: 3811 RVA: 0x03DDBAF0 File Offset: 0x03DD9EF0
		Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form22.Show()
		End Sub

		' Token: 0x06000EE4 RID: 3812 RVA: 0x03DDBB04 File Offset: 0x03DD9F04
		Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form21.Show()
			easycode.openChildForm(New Form22())
		End Sub

		' Token: 0x06000EE5 RID: 3813 RVA: 0x03DDBB24 File Offset: 0x03DD9F24
		Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form43.Show()
			Dim flag As Boolean = Interaction.MsgBox("New Settings App", MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.Yes
			If flag Then
			End If
			easycode.openChildForm(New theme_window())
		End Sub

		' Token: 0x06000EE6 RID: 3814 RVA: 0x03DDBB64 File Offset: 0x03DD9F64
		Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form51.Show()
		End Sub

		' Token: 0x06000EE7 RID: 3815 RVA: 0x03DDBB78 File Offset: 0x03DD9F78
		Private Sub PictureBox6_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form33.Show()
			MyProject.Forms.Form33.Timer1.Start()
		End Sub

		' Token: 0x06000EE8 RID: 3816 RVA: 0x03DDBBA4 File Offset: 0x03DD9FA4
		Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form33.Show()
			MyProject.Forms.Form33.Timer2.Start()
		End Sub

		' Token: 0x04000569 RID: 1385
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400056B RID: 1387
		<AccessedThroughProperty("LinkLabel1")>
		Private _LinkLabel1 As LinkLabel

		' Token: 0x0400056C RID: 1388
		<AccessedThroughProperty("LinkLabel2")>
		Private _LinkLabel2 As LinkLabel

		' Token: 0x0400056D RID: 1389
		<AccessedThroughProperty("LinkLabel3")>
		Private _LinkLabel3 As LinkLabel

		' Token: 0x0400056E RID: 1390
		<AccessedThroughProperty("LinkLabel4")>
		Private _LinkLabel4 As LinkLabel

		' Token: 0x0400056F RID: 1391
		<AccessedThroughProperty("LinkLabel5")>
		Private _LinkLabel5 As LinkLabel

		' Token: 0x04000570 RID: 1392
		<AccessedThroughProperty("LinkLabel6")>
		Private _LinkLabel6 As LinkLabel

		' Token: 0x04000571 RID: 1393
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000572 RID: 1394
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x04000573 RID: 1395
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x04000574 RID: 1396
		<AccessedThroughProperty("LinkLabel7")>
		Private _LinkLabel7 As LinkLabel

		' Token: 0x04000575 RID: 1397
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x04000576 RID: 1398
		<AccessedThroughProperty("LinkLabel8")>
		Private _LinkLabel8 As LinkLabel

		' Token: 0x04000577 RID: 1399
		<AccessedThroughProperty("LinkLabel9")>
		Private _LinkLabel9 As LinkLabel

		' Token: 0x04000578 RID: 1400
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x04000579 RID: 1401
		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel

		' Token: 0x0400057A RID: 1402
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x0400057B RID: 1403
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x0400057C RID: 1404
		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		' Token: 0x0400057D RID: 1405
		<AccessedThroughProperty("PictureBox6")>
		Private _PictureBox6 As PictureBox

		' Token: 0x0400057E RID: 1406
		<AccessedThroughProperty("PictureBox5")>
		Private _PictureBox5 As PictureBox

		' Token: 0x0400057F RID: 1407
		Private mouse_move As Point
	End Class
End Namespace
