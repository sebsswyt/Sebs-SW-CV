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
	' Token: 0x02000052 RID: 82
	<DesignerGenerated()>
	Public Partial Class Form36
		Inherits Form

		' Token: 0x06000E3C RID: 3644 RVA: 0x03DD7860 File Offset: 0x03DD5C60
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form36_Load
			Dim _ENCList As List(Of WeakReference) = Form36.__ENCList
			SyncLock _ENCList
				Form36.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170004BA RID: 1210
		' (get) Token: 0x06000E3F RID: 3647 RVA: 0x03DD7DF8 File Offset: 0x03DD61F8
		' (set) Token: 0x06000E40 RID: 3648 RVA: 0x03DD7E10 File Offset: 0x03DD6210
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

		' Token: 0x170004BB RID: 1211
		' (get) Token: 0x06000E41 RID: 3649 RVA: 0x03DD7E1C File Offset: 0x03DD621C
		' (set) Token: 0x06000E42 RID: 3650 RVA: 0x03DD7E34 File Offset: 0x03DD6234
		Friend Overridable Property Button1 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button1 = value
			End Set
		End Property

		' Token: 0x170004BC RID: 1212
		' (get) Token: 0x06000E43 RID: 3651 RVA: 0x03DD7E40 File Offset: 0x03DD6240
		' (set) Token: 0x06000E44 RID: 3652 RVA: 0x03DD7E58 File Offset: 0x03DD6258
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

		' Token: 0x170004BD RID: 1213
		' (get) Token: 0x06000E45 RID: 3653 RVA: 0x03DD7EB8 File Offset: 0x03DD62B8
		' (set) Token: 0x06000E46 RID: 3654 RVA: 0x03DD7ED0 File Offset: 0x03DD62D0
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

		' Token: 0x170004BE RID: 1214
		' (get) Token: 0x06000E47 RID: 3655 RVA: 0x03DD7F30 File Offset: 0x03DD6330
		' (set) Token: 0x06000E48 RID: 3656 RVA: 0x03DD7F48 File Offset: 0x03DD6348
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

		' Token: 0x170004BF RID: 1215
		' (get) Token: 0x06000E49 RID: 3657 RVA: 0x03DD7FA8 File Offset: 0x03DD63A8
		' (set) Token: 0x06000E4A RID: 3658 RVA: 0x03DD7FC0 File Offset: 0x03DD63C0
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

		' Token: 0x170004C0 RID: 1216
		' (get) Token: 0x06000E4B RID: 3659 RVA: 0x03DD8020 File Offset: 0x03DD6420
		' (set) Token: 0x06000E4C RID: 3660 RVA: 0x03DD8038 File Offset: 0x03DD6438
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

		' Token: 0x06000E4D RID: 3661 RVA: 0x03DD8044 File Offset: 0x03DD6444
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form30.Show()
		End Sub

		' Token: 0x06000E4E RID: 3662 RVA: 0x03DD8058 File Offset: 0x03DD6458
		Private Sub Button2_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000E4F RID: 3663 RVA: 0x03DD805C File Offset: 0x03DD645C
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form19.Show()
		End Sub

		' Token: 0x06000E50 RID: 3664 RVA: 0x03DD8070 File Offset: 0x03DD6470
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			Dim visible As Boolean = MyProject.Forms.Form21.Button1.Visible
			If visible Then
				MyProject.Forms.Form21.Close()
				MyProject.Forms.Form21.Show()
				MyProject.Forms.Form21.Panel2.Visible = True
			Else
				MyProject.Forms.Form21.Show()
				MyProject.Forms.Form21.Panel2.Visible = True
			End If
		End Sub

		' Token: 0x06000E51 RID: 3665 RVA: 0x03DD80F8 File Offset: 0x03DD64F8
		Private Sub Form36_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x04000542 RID: 1346
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000544 RID: 1348
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x04000545 RID: 1349
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000546 RID: 1350
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x04000547 RID: 1351
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x04000548 RID: 1352
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x04000549 RID: 1353
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x0400054A RID: 1354
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button
	End Class
End Namespace
