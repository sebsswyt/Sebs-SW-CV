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
	' Token: 0x0200001E RID: 30
	<DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox5
		Inherits Form

		' Token: 0x06000259 RID: 601 RVA: 0x03D8BBB8 File Offset: 0x03D89FB8
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.AboutBox5_Load
			Dim _ENCList As List(Of WeakReference) = AboutBox5.__ENCList
			SyncLock _ENCList
				AboutBox5.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170000D0 RID: 208
		' (get) Token: 0x0600025C RID: 604 RVA: 0x03D8BF0C File Offset: 0x03D8A30C
		' (set) Token: 0x0600025D RID: 605 RVA: 0x03D8BF24 File Offset: 0x03D8A324
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

		' Token: 0x170000D1 RID: 209
		' (get) Token: 0x0600025E RID: 606 RVA: 0x03D8BF84 File Offset: 0x03D8A384
		' (set) Token: 0x0600025F RID: 607 RVA: 0x03D8BF9C File Offset: 0x03D8A39C
		Friend Property Button2 As Button
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

		' Token: 0x170000D2 RID: 210
		' (get) Token: 0x06000260 RID: 608 RVA: 0x03D8BFFC File Offset: 0x03D8A3FC
		' (set) Token: 0x06000261 RID: 609 RVA: 0x03D8C014 File Offset: 0x03D8A414
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

		' Token: 0x06000262 RID: 610 RVA: 0x03D8C074 File Offset: 0x03D8A474
		Private Sub AboutBox5_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000263 RID: 611 RVA: 0x03D8C078 File Offset: 0x03D8A478
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000264 RID: 612 RVA: 0x03D8C07C File Offset: 0x03D8A47C
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form15.Show()
			MyProject.Forms.Form15.Text = "Boot.dll"
			MyProject.Forms.Form15.TextBox1.Text = "Form1.Show() = True "
		End Sub

		' Token: 0x06000265 RID: 613 RVA: 0x03D8C0CC File Offset: 0x03D8A4CC
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000266 RID: 614 RVA: 0x03D8C0D8 File Offset: 0x03D8A4D8
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form15.Show()
			MyProject.Forms.Form15.Text = "Boot.dll"
			MyProject.Forms.Form15.TextBox1.Text = "Form1.Show() = True "
			MyProject.Forms.Form15.TextBox1.[ReadOnly] = False
		End Sub

		' Token: 0x040000F8 RID: 248
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040000FA RID: 250
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040000FB RID: 251
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x040000FC RID: 252
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button
	End Class
End Namespace
