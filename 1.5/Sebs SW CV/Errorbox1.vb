Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x02000015 RID: 21
	<DesignerGenerated()>
	Public NotInheritable Partial Class Errorbox1
		Inherits Form

		' Token: 0x060001AA RID: 426 RVA: 0x03D86AA8 File Offset: 0x03D84EA8
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.AboutBox2_Load
			Dim _ENCList As List(Of WeakReference) = Errorbox1.__ENCList
			SyncLock _ENCList
				Errorbox1.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700009F RID: 159
		' (get) Token: 0x060001AD RID: 429 RVA: 0x03D86D6C File Offset: 0x03D8516C
		' (set) Token: 0x060001AE RID: 430 RVA: 0x03D86D84 File Offset: 0x03D85184
		Friend Property OKButton As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._OKButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.OKButton_Click
				Dim flag As Boolean = Me._OKButton IsNot Nothing
				If flag Then
					RemoveHandler Me._OKButton.Click, eventHandler
				End If
				Me._OKButton = value
				flag = Me._OKButton IsNot Nothing
				If flag Then
					AddHandler Me._OKButton.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170000A0 RID: 160
		' (get) Token: 0x060001AF RID: 431 RVA: 0x03D86DE4 File Offset: 0x03D851E4
		' (set) Token: 0x060001B0 RID: 432 RVA: 0x03D86DFC File Offset: 0x03D851FC
		Friend Property al As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._al
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._al = value
			End Set
		End Property

		' Token: 0x060001B1 RID: 433 RVA: 0x03D86E08 File Offset: 0x03D85208
		Private Sub AboutBox2_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060001B2 RID: 434 RVA: 0x03D86E0C File Offset: 0x03D8520C
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x040000B5 RID: 181
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040000B7 RID: 183
		<AccessedThroughProperty("OKButton")>
		Private _OKButton As Button

		' Token: 0x040000B8 RID: 184
		<AccessedThroughProperty("al")>
		Private _al As Label
	End Class
End Namespace
