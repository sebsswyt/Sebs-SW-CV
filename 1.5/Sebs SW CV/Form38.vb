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
	' Token: 0x02000054 RID: 84
	<DesignerGenerated()>
	Public Partial Class Form38
		Inherits Form

		' Token: 0x06000E84 RID: 3716 RVA: 0x03DD8FCC File Offset: 0x03DD73CC
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form38_Load
			Dim _ENCList As List(Of WeakReference) = Form38.__ENCList
			SyncLock _ENCList
				Form38.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170004D2 RID: 1234
		' (get) Token: 0x06000E87 RID: 3719 RVA: 0x03DD966C File Offset: 0x03DD7A6C
		' (set) Token: 0x06000E88 RID: 3720 RVA: 0x03DD9684 File Offset: 0x03DD7A84
		Friend Overridable Property Panel1 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim paintEventHandler As PaintEventHandler = AddressOf Me.Panel1_Paint
				Dim flag As Boolean = Me._Panel1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Panel1.Paint, paintEventHandler
				End If
				Me._Panel1 = value
				flag = Me._Panel1 IsNot Nothing
				If flag Then
					AddHandler Me._Panel1.Paint, paintEventHandler
				End If
			End Set
		End Property

		' Token: 0x170004D3 RID: 1235
		' (get) Token: 0x06000E89 RID: 3721 RVA: 0x03DD96E4 File Offset: 0x03DD7AE4
		' (set) Token: 0x06000E8A RID: 3722 RVA: 0x03DD96FC File Offset: 0x03DD7AFC
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

		' Token: 0x170004D4 RID: 1236
		' (get) Token: 0x06000E8B RID: 3723 RVA: 0x03DD975C File Offset: 0x03DD7B5C
		' (set) Token: 0x06000E8C RID: 3724 RVA: 0x03DD9774 File Offset: 0x03DD7B74
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

		' Token: 0x170004D5 RID: 1237
		' (get) Token: 0x06000E8D RID: 3725 RVA: 0x03DD97D4 File Offset: 0x03DD7BD4
		' (set) Token: 0x06000E8E RID: 3726 RVA: 0x03DD97EC File Offset: 0x03DD7BEC
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

		' Token: 0x170004D6 RID: 1238
		' (get) Token: 0x06000E8F RID: 3727 RVA: 0x03DD984C File Offset: 0x03DD7C4C
		' (set) Token: 0x06000E90 RID: 3728 RVA: 0x03DD9864 File Offset: 0x03DD7C64
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

		' Token: 0x170004D7 RID: 1239
		' (get) Token: 0x06000E91 RID: 3729 RVA: 0x03DD98C4 File Offset: 0x03DD7CC4
		' (set) Token: 0x06000E92 RID: 3730 RVA: 0x03DD98DC File Offset: 0x03DD7CDC
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

		' Token: 0x170004D8 RID: 1240
		' (get) Token: 0x06000E93 RID: 3731 RVA: 0x03DD993C File Offset: 0x03DD7D3C
		' (set) Token: 0x06000E94 RID: 3732 RVA: 0x03DD9954 File Offset: 0x03DD7D54
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

		' Token: 0x170004D9 RID: 1241
		' (get) Token: 0x06000E95 RID: 3733 RVA: 0x03DD99B4 File Offset: 0x03DD7DB4
		' (set) Token: 0x06000E96 RID: 3734 RVA: 0x03DD99CC File Offset: 0x03DD7DCC
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

		' Token: 0x170004DA RID: 1242
		' (get) Token: 0x06000E97 RID: 3735 RVA: 0x03DD99D8 File Offset: 0x03DD7DD8
		' (set) Token: 0x06000E98 RID: 3736 RVA: 0x03DD99F0 File Offset: 0x03DD7DF0
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

		' Token: 0x06000E99 RID: 3737 RVA: 0x03DD99FC File Offset: 0x03DD7DFC
		Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x06000E9A RID: 3738 RVA: 0x03DD9A00 File Offset: 0x03DD7E00
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form19.Show()
			MyProject.Forms.Form19.WebBrowser1.Navigate("https://sebs-web-6.netlify.app/")
		End Sub

		' Token: 0x06000E9B RID: 3739 RVA: 0x03DD9A30 File Offset: 0x03DD7E30
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox1.Show()
		End Sub

		' Token: 0x06000E9C RID: 3740 RVA: 0x03DD9A44 File Offset: 0x03DD7E44
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form19.Show()
		End Sub

		' Token: 0x06000E9D RID: 3741 RVA: 0x03DD9A58 File Offset: 0x03DD7E58
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form2.Show()
		End Sub

		' Token: 0x06000E9E RID: 3742 RVA: 0x03DD9A6C File Offset: 0x03DD7E6C
		Private Sub Button5_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000E9F RID: 3743 RVA: 0x03DD9A70 File Offset: 0x03DD7E70
		Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000EA0 RID: 3744 RVA: 0x03DD9A74 File Offset: 0x03DD7E74
		Private Sub Form38_Load(sender As Object, e As EventArgs)
			Me.Timer1.Enabled = True
		End Sub

		' Token: 0x06000EA1 RID: 3745 RVA: 0x03DD9A88 File Offset: 0x03DD7E88
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Me.Label1.Text = DateTime.Now.ToString("hh:mm:ss")
			Me.Label2.Text = DateTime.Now.ToString("dd-MM-yyyy")
		End Sub

		' Token: 0x0400055E RID: 1374
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000560 RID: 1376
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x04000561 RID: 1377
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000562 RID: 1378
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x04000563 RID: 1379
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x04000564 RID: 1380
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x04000565 RID: 1381
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x04000566 RID: 1382
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x04000567 RID: 1383
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000568 RID: 1384
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label
	End Class
End Namespace
