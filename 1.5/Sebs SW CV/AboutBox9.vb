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
	' Token: 0x02000022 RID: 34
	<DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox9
		Inherits Form

		' Token: 0x06000294 RID: 660 RVA: 0x03D8D2C4 File Offset: 0x03D8B6C4
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.AboutBox9_Load
			Dim _ENCList As List(Of WeakReference) = AboutBox9.__ENCList
			SyncLock _ENCList
				AboutBox9.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170000DF RID: 223
		' (get) Token: 0x06000297 RID: 663 RVA: 0x03D8D55C File Offset: 0x03D8B95C
		' (set) Token: 0x06000298 RID: 664 RVA: 0x03D8D574 File Offset: 0x03D8B974
		Friend Property ProgressBar1 As ProgressBar
			<DebuggerNonUserCode()>
			Get
				Return Me._ProgressBar1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ProgressBar)
				Dim eventHandler As EventHandler = AddressOf Me.ProgressBar1_Click
				Dim flag As Boolean = Me._ProgressBar1 IsNot Nothing
				If flag Then
					RemoveHandler Me._ProgressBar1.Click, eventHandler
				End If
				Me._ProgressBar1 = value
				flag = Me._ProgressBar1 IsNot Nothing
				If flag Then
					AddHandler Me._ProgressBar1.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170000E0 RID: 224
		' (get) Token: 0x06000299 RID: 665 RVA: 0x03D8D5D4 File Offset: 0x03D8B9D4
		' (set) Token: 0x0600029A RID: 666 RVA: 0x03D8D5EC File Offset: 0x03D8B9EC
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

		' Token: 0x170000E1 RID: 225
		' (get) Token: 0x0600029B RID: 667 RVA: 0x03D8D64C File Offset: 0x03D8BA4C
		' (set) Token: 0x0600029C RID: 668 RVA: 0x03D8D664 File Offset: 0x03D8BA64
		Friend Property Timer1 As Timer
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

		' Token: 0x0600029D RID: 669 RVA: 0x03D8D6C4 File Offset: 0x03D8BAC4
		Private Sub AboutBox9_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600029E RID: 670 RVA: 0x03D8D6C8 File Offset: 0x03D8BAC8
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600029F RID: 671 RVA: 0x03D8D6CC File Offset: 0x03D8BACC
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar1.Increment(3)
		End Sub

		' Token: 0x060002A0 RID: 672 RVA: 0x03D8D6E0 File Offset: 0x03D8BAE0
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.Show()
			Me.Close()
			MyProject.Forms.Form20.Timer1.[Stop]()
			MyProject.Forms.Form20.ProgressBar1.Value = 0
		End Sub

		' Token: 0x060002A1 RID: 673 RVA: 0x03D8D734 File Offset: 0x03D8BB34
		Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ProgressBar1.Value = 100
			If flag Then
				Me.Button1.Enabled = True
			End If
		End Sub

		' Token: 0x0400010F RID: 271
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000111 RID: 273
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x04000112 RID: 274
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000113 RID: 275
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer
	End Class
End Namespace
