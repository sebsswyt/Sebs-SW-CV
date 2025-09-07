Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x0200000E RID: 14
	<DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox13
		Inherits Form

		' Token: 0x0600012C RID: 300 RVA: 0x03D83BF0 File Offset: 0x03D81FF0
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.AboutBox13_Load
			Dim _ENCList As List(Of WeakReference) = AboutBox13.__ENCList
			SyncLock _ENCList
				AboutBox13.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700007C RID: 124
		' (get) Token: 0x0600012F RID: 303 RVA: 0x03D83EBC File Offset: 0x03D822BC
		' (set) Token: 0x06000130 RID: 304 RVA: 0x03D83ED4 File Offset: 0x03D822D4
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

		' Token: 0x1700007D RID: 125
		' (get) Token: 0x06000131 RID: 305 RVA: 0x03D83F34 File Offset: 0x03D82334
		' (set) Token: 0x06000132 RID: 306 RVA: 0x03D83F4C File Offset: 0x03D8234C
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

		' Token: 0x06000133 RID: 307 RVA: 0x03D83F58 File Offset: 0x03D82358
		Private Sub AboutBox13_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000134 RID: 308 RVA: 0x03D83F5C File Offset: 0x03D8235C
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000135 RID: 309 RVA: 0x03D83F60 File Offset: 0x03D82360
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x04000084 RID: 132
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000086 RID: 134
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000087 RID: 135
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label
	End Class
End Namespace
