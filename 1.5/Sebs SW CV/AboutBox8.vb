Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x02000021 RID: 33
	<DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox8
		Inherits Form

		' Token: 0x06000289 RID: 649 RVA: 0x03D8CF54 File Offset: 0x03D8B354
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.AboutBox8_Load
			Dim _ENCList As List(Of WeakReference) = AboutBox8.__ENCList
			SyncLock _ENCList
				AboutBox8.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170000DD RID: 221
		' (get) Token: 0x0600028C RID: 652 RVA: 0x03D8D204 File Offset: 0x03D8B604
		' (set) Token: 0x0600028D RID: 653 RVA: 0x03D8D21C File Offset: 0x03D8B61C
		Friend Property Label1 As Label
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

		' Token: 0x170000DE RID: 222
		' (get) Token: 0x0600028E RID: 654 RVA: 0x03D8D228 File Offset: 0x03D8B628
		' (set) Token: 0x0600028F RID: 655 RVA: 0x03D8D240 File Offset: 0x03D8B640
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

		' Token: 0x06000290 RID: 656 RVA: 0x03D8D2A0 File Offset: 0x03D8B6A0
		Private Sub AboutBox8_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000291 RID: 657 RVA: 0x03D8D2A4 File Offset: 0x03D8B6A4
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000292 RID: 658 RVA: 0x03D8D2A8 File Offset: 0x03D8B6A8
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x0400010B RID: 267
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400010D RID: 269
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x0400010E RID: 270
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button
	End Class
End Namespace
