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
	' Token: 0x02000035 RID: 53
	<DesignerGenerated()>
	Public Partial Class Form11
		Inherits Form

		' Token: 0x060005E9 RID: 1513 RVA: 0x03D9E77C File Offset: 0x03D9CB7C
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Form11.__ENCList
			SyncLock _ENCList
				Form11.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170001F7 RID: 503
		' (get) Token: 0x060005EC RID: 1516 RVA: 0x03D9ED90 File Offset: 0x03D9D190
		' (set) Token: 0x060005ED RID: 1517 RVA: 0x03D9EDA8 File Offset: 0x03D9D1A8
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

		' Token: 0x170001F8 RID: 504
		' (get) Token: 0x060005EE RID: 1518 RVA: 0x03D9EDB4 File Offset: 0x03D9D1B4
		' (set) Token: 0x060005EF RID: 1519 RVA: 0x03D9EDCC File Offset: 0x03D9D1CC
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

		' Token: 0x170001F9 RID: 505
		' (get) Token: 0x060005F0 RID: 1520 RVA: 0x03D9EE2C File Offset: 0x03D9D22C
		' (set) Token: 0x060005F1 RID: 1521 RVA: 0x03D9EE44 File Offset: 0x03D9D244
		Friend Overridable Property TextBox1 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox1 = value
			End Set
		End Property

		' Token: 0x170001FA RID: 506
		' (get) Token: 0x060005F2 RID: 1522 RVA: 0x03D9EE50 File Offset: 0x03D9D250
		' (set) Token: 0x060005F3 RID: 1523 RVA: 0x03D9EE68 File Offset: 0x03D9D268
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

		' Token: 0x170001FB RID: 507
		' (get) Token: 0x060005F4 RID: 1524 RVA: 0x03D9EE74 File Offset: 0x03D9D274
		' (set) Token: 0x060005F5 RID: 1525 RVA: 0x03D9EE8C File Offset: 0x03D9D28C
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

		' Token: 0x170001FC RID: 508
		' (get) Token: 0x060005F6 RID: 1526 RVA: 0x03D9EEEC File Offset: 0x03D9D2EC
		' (set) Token: 0x060005F7 RID: 1527 RVA: 0x03D9EF04 File Offset: 0x03D9D304
		Friend Overridable Property Button3 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button3 = value
			End Set
		End Property

		' Token: 0x170001FD RID: 509
		' (get) Token: 0x060005F8 RID: 1528 RVA: 0x03D9EF10 File Offset: 0x03D9D310
		' (set) Token: 0x060005F9 RID: 1529 RVA: 0x03D9EF28 File Offset: 0x03D9D328
		Friend Overridable Property CheckBox1 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim eventHandler As EventHandler = AddressOf Me.CheckBox1_CheckedChanged
				Dim flag As Boolean = Me._CheckBox1 IsNot Nothing
				If flag Then
					RemoveHandler Me._CheckBox1.CheckedChanged, eventHandler
				End If
				Me._CheckBox1 = value
				flag = Me._CheckBox1 IsNot Nothing
				If flag Then
					AddHandler Me._CheckBox1.CheckedChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001FE RID: 510
		' (get) Token: 0x060005FA RID: 1530 RVA: 0x03D9EF88 File Offset: 0x03D9D388
		' (set) Token: 0x060005FB RID: 1531 RVA: 0x03D9EFA0 File Offset: 0x03D9D3A0
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

		' Token: 0x060005FC RID: 1532 RVA: 0x03D9EFAC File Offset: 0x03D9D3AC
		Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
			Dim enabled As Boolean = Me.CheckBox1.Enabled
			If enabled Then
				Me.Button2.Enabled = True
			End If
		End Sub

		' Token: 0x060005FD RID: 1533 RVA: 0x03D9EFD8 File Offset: 0x03D9D3D8
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x060005FE RID: 1534 RVA: 0x03D9EFE4 File Offset: 0x03D9D3E4
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form2.Close()
			MyProject.Forms.Form3.Close()
			Me.Close()
			MyProject.Forms.Form9.Close()
		End Sub

		' Token: 0x0400023C RID: 572
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400023E RID: 574
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x0400023F RID: 575
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000240 RID: 576
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x04000241 RID: 577
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000242 RID: 578
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x04000243 RID: 579
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x04000244 RID: 580
		<AccessedThroughProperty("CheckBox1")>
		Private _CheckBox1 As CheckBox

		' Token: 0x04000245 RID: 581
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox
	End Class
End Namespace
