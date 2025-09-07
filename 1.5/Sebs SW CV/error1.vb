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
	' Token: 0x0200001F RID: 31
	<DesignerGenerated()>
	Public NotInheritable Partial Class error1
		Inherits Form

		' Token: 0x06000268 RID: 616 RVA: 0x03D8C14C File Offset: 0x03D8A54C
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.AboutBox6_Load
			Dim _ENCList As List(Of WeakReference) = error1.__ENCList
			SyncLock _ENCList
				error1.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170000D3 RID: 211
		' (get) Token: 0x0600026B RID: 619 RVA: 0x03D8C3F8 File Offset: 0x03D8A7F8
		' (set) Token: 0x0600026C RID: 620 RVA: 0x03D8C410 File Offset: 0x03D8A810
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

		' Token: 0x170000D4 RID: 212
		' (get) Token: 0x0600026D RID: 621 RVA: 0x03D8C470 File Offset: 0x03D8A870
		' (set) Token: 0x0600026E RID: 622 RVA: 0x03D8C488 File Offset: 0x03D8A888
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

		' Token: 0x0600026F RID: 623 RVA: 0x03D8C494 File Offset: 0x03D8A894
		Private Sub AboutBox6_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000270 RID: 624 RVA: 0x03D8C498 File Offset: 0x03D8A898
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000271 RID: 625 RVA: 0x03D8C49C File Offset: 0x03D8A89C
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.Close()
			MyProject.Forms.Form3.Show()
		End Sub

		' Token: 0x040000FD RID: 253
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040000FF RID: 255
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000100 RID: 256
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label
	End Class
End Namespace
