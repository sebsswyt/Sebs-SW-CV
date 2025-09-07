Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x0200001C RID: 28
	<DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox3
		Inherits Form

		' Token: 0x0600021C RID: 540 RVA: 0x03D89ED4 File Offset: 0x03D882D4
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.AboutBox3_Load
			Dim _ENCList As List(Of WeakReference) = AboutBox3.__ENCList
			SyncLock _ENCList
				AboutBox3.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170000BF RID: 191
		' (get) Token: 0x0600021F RID: 543 RVA: 0x03D8A3DC File Offset: 0x03D887DC
		' (set) Token: 0x06000220 RID: 544 RVA: 0x03D8A3F4 File Offset: 0x03D887F4
		Friend Property Button1 As Button
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

		' Token: 0x170000C0 RID: 192
		' (get) Token: 0x06000221 RID: 545 RVA: 0x03D8A454 File Offset: 0x03D88854
		' (set) Token: 0x06000222 RID: 546 RVA: 0x03D8A46C File Offset: 0x03D8886C
		Friend Property Label1 As Label
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

		' Token: 0x170000C1 RID: 193
		' (get) Token: 0x06000223 RID: 547 RVA: 0x03D8A4CC File Offset: 0x03D888CC
		' (set) Token: 0x06000224 RID: 548 RVA: 0x03D8A4E4 File Offset: 0x03D888E4
		Friend Property Button3 As Button
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

		' Token: 0x170000C2 RID: 194
		' (get) Token: 0x06000225 RID: 549 RVA: 0x03D8A544 File Offset: 0x03D88944
		' (set) Token: 0x06000226 RID: 550 RVA: 0x03D8A55C File Offset: 0x03D8895C
		Friend Property Button4 As Button
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

		' Token: 0x170000C3 RID: 195
		' (get) Token: 0x06000227 RID: 551 RVA: 0x03D8A5BC File Offset: 0x03D889BC
		' (set) Token: 0x06000228 RID: 552 RVA: 0x03D8A5D4 File Offset: 0x03D889D4
		Friend Property Panel1 As Panel
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

		' Token: 0x170000C4 RID: 196
		' (get) Token: 0x06000229 RID: 553 RVA: 0x03D8A5E0 File Offset: 0x03D889E0
		' (set) Token: 0x0600022A RID: 554 RVA: 0x03D8A5F8 File Offset: 0x03D889F8
		Friend Property Panel2 As Panel
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

		' Token: 0x0600022B RID: 555 RVA: 0x03D8A604 File Offset: 0x03D88A04
		Private Sub AboutBox3_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600022C RID: 556 RVA: 0x03D8A608 File Offset: 0x03D88A08
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x0600022D RID: 557 RVA: 0x03D8A614 File Offset: 0x03D88A14
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x0600022E RID: 558 RVA: 0x03D8A620 File Offset: 0x03D88A20
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			ProjectData.EndApp()
		End Sub

		' Token: 0x0600022F RID: 559 RVA: 0x03D8A62C File Offset: 0x03D88A2C
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			Me.Label1.Visible = True
			Me.Panel1.Visible = False
			Me.Panel2.Visible = True
		End Sub

		' Token: 0x06000230 RID: 560 RVA: 0x03D8A658 File Offset: 0x03D88A58
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			Me.Label1.Visible = False
			Me.Panel2.Visible = False
			Me.Panel1.Visible = True
		End Sub

		' Token: 0x06000231 RID: 561 RVA: 0x03D8A684 File Offset: 0x03D88A84
		Private Sub Label1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x040000E3 RID: 227
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040000E5 RID: 229
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040000E6 RID: 230
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x040000E7 RID: 231
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x040000E8 RID: 232
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x040000E9 RID: 233
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x040000EA RID: 234
		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel
	End Class
End Namespace
