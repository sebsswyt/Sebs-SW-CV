Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x02000020 RID: 32
	<DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox7
		Inherits Form

		' Token: 0x06000273 RID: 627 RVA: 0x03D8C4C8 File Offset: 0x03D8A8C8
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.AboutBox7_Load
			Dim _ENCList As List(Of WeakReference) = AboutBox7.__ENCList
			SyncLock _ENCList
				AboutBox7.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170000D5 RID: 213
		' (get) Token: 0x06000275 RID: 629 RVA: 0x03D8C584 File Offset: 0x03D8A984
		' (set) Token: 0x06000276 RID: 630 RVA: 0x03D8C59C File Offset: 0x03D8A99C
		Friend Property TableLayoutPanel As TableLayoutPanel
			<DebuggerNonUserCode()>
			Get
				Return Me._TableLayoutPanel
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TableLayoutPanel)
				Me._TableLayoutPanel = value
			End Set
		End Property

		' Token: 0x170000D6 RID: 214
		' (get) Token: 0x06000277 RID: 631 RVA: 0x03D8C5A8 File Offset: 0x03D8A9A8
		' (set) Token: 0x06000278 RID: 632 RVA: 0x03D8C5C0 File Offset: 0x03D8A9C0
		Friend Property LogoPictureBox As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._LogoPictureBox
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._LogoPictureBox = value
			End Set
		End Property

		' Token: 0x170000D7 RID: 215
		' (get) Token: 0x06000279 RID: 633 RVA: 0x03D8C5CC File Offset: 0x03D8A9CC
		' (set) Token: 0x0600027A RID: 634 RVA: 0x03D8C5E4 File Offset: 0x03D8A9E4
		Friend Property LabelProductName As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._LabelProductName
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._LabelProductName = value
			End Set
		End Property

		' Token: 0x170000D8 RID: 216
		' (get) Token: 0x0600027B RID: 635 RVA: 0x03D8C5F0 File Offset: 0x03D8A9F0
		' (set) Token: 0x0600027C RID: 636 RVA: 0x03D8C608 File Offset: 0x03D8AA08
		Friend Property LabelVersion As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._LabelVersion
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._LabelVersion = value
			End Set
		End Property

		' Token: 0x170000D9 RID: 217
		' (get) Token: 0x0600027D RID: 637 RVA: 0x03D8C614 File Offset: 0x03D8AA14
		' (set) Token: 0x0600027E RID: 638 RVA: 0x03D8C62C File Offset: 0x03D8AA2C
		Friend Property LabelCompanyName As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._LabelCompanyName
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._LabelCompanyName = value
			End Set
		End Property

		' Token: 0x170000DA RID: 218
		' (get) Token: 0x0600027F RID: 639 RVA: 0x03D8C638 File Offset: 0x03D8AA38
		' (set) Token: 0x06000280 RID: 640 RVA: 0x03D8C650 File Offset: 0x03D8AA50
		Friend Property TextBoxDescription As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBoxDescription
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBoxDescription = value
			End Set
		End Property

		' Token: 0x170000DB RID: 219
		' (get) Token: 0x06000281 RID: 641 RVA: 0x03D8C65C File Offset: 0x03D8AA5C
		' (set) Token: 0x06000282 RID: 642 RVA: 0x03D8C674 File Offset: 0x03D8AA74
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

		' Token: 0x170000DC RID: 220
		' (get) Token: 0x06000283 RID: 643 RVA: 0x03D8C6D4 File Offset: 0x03D8AAD4
		' (set) Token: 0x06000284 RID: 644 RVA: 0x03D8C6EC File Offset: 0x03D8AAEC
		Friend Property LabelCopyright As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._LabelCopyright
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._LabelCopyright = value
			End Set
		End Property

		' Token: 0x06000286 RID: 646 RVA: 0x03D8CF34 File Offset: 0x03D8B334
		Private Sub AboutBox7_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000287 RID: 647 RVA: 0x03D8CF38 File Offset: 0x03D8B338
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x04000101 RID: 257
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000102 RID: 258
		<AccessedThroughProperty("TableLayoutPanel")>
		Private _TableLayoutPanel As TableLayoutPanel

		' Token: 0x04000103 RID: 259
		<AccessedThroughProperty("LogoPictureBox")>
		Private _LogoPictureBox As PictureBox

		' Token: 0x04000104 RID: 260
		<AccessedThroughProperty("LabelProductName")>
		Private _LabelProductName As Label

		' Token: 0x04000105 RID: 261
		<AccessedThroughProperty("LabelVersion")>
		Private _LabelVersion As Label

		' Token: 0x04000106 RID: 262
		<AccessedThroughProperty("LabelCompanyName")>
		Private _LabelCompanyName As Label

		' Token: 0x04000107 RID: 263
		<AccessedThroughProperty("TextBoxDescription")>
		Private _TextBoxDescription As TextBox

		' Token: 0x04000108 RID: 264
		<AccessedThroughProperty("OKButton")>
		Private _OKButton As Button

		' Token: 0x04000109 RID: 265
		<AccessedThroughProperty("LabelCopyright")>
		Private _LabelCopyright As Label
	End Class
End Namespace
