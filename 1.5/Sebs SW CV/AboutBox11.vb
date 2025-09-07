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
	' Token: 0x0200000C RID: 12
	<DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox11
		Inherits Form

		' Token: 0x06000110 RID: 272 RVA: 0x03D82EF0 File Offset: 0x03D812F0
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.AboutBox11_Load
			Dim _ENCList As List(Of WeakReference) = AboutBox11.__ENCList
			SyncLock _ENCList
				AboutBox11.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000074 RID: 116
		' (get) Token: 0x06000112 RID: 274 RVA: 0x03D82FAC File Offset: 0x03D813AC
		' (set) Token: 0x06000113 RID: 275 RVA: 0x03D82FC4 File Offset: 0x03D813C4
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

		' Token: 0x17000075 RID: 117
		' (get) Token: 0x06000114 RID: 276 RVA: 0x03D82FD0 File Offset: 0x03D813D0
		' (set) Token: 0x06000115 RID: 277 RVA: 0x03D82FE8 File Offset: 0x03D813E8
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

		' Token: 0x17000076 RID: 118
		' (get) Token: 0x06000116 RID: 278 RVA: 0x03D82FF4 File Offset: 0x03D813F4
		' (set) Token: 0x06000117 RID: 279 RVA: 0x03D8300C File Offset: 0x03D8140C
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

		' Token: 0x17000077 RID: 119
		' (get) Token: 0x06000118 RID: 280 RVA: 0x03D83018 File Offset: 0x03D81418
		' (set) Token: 0x06000119 RID: 281 RVA: 0x03D83030 File Offset: 0x03D81430
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

		' Token: 0x17000078 RID: 120
		' (get) Token: 0x0600011A RID: 282 RVA: 0x03D8303C File Offset: 0x03D8143C
		' (set) Token: 0x0600011B RID: 283 RVA: 0x03D83054 File Offset: 0x03D81454
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

		' Token: 0x17000079 RID: 121
		' (get) Token: 0x0600011C RID: 284 RVA: 0x03D83060 File Offset: 0x03D81460
		' (set) Token: 0x0600011D RID: 285 RVA: 0x03D83078 File Offset: 0x03D81478
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

		' Token: 0x1700007A RID: 122
		' (get) Token: 0x0600011E RID: 286 RVA: 0x03D83084 File Offset: 0x03D81484
		' (set) Token: 0x0600011F RID: 287 RVA: 0x03D8309C File Offset: 0x03D8149C
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

		' Token: 0x1700007B RID: 123
		' (get) Token: 0x06000120 RID: 288 RVA: 0x03D830FC File Offset: 0x03D814FC
		' (set) Token: 0x06000121 RID: 289 RVA: 0x03D83114 File Offset: 0x03D81514
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

		' Token: 0x06000123 RID: 291 RVA: 0x03D83960 File Offset: 0x03D81D60
		Private Sub AboutBox11_Load(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.Close()
			MyProject.Forms.Form1.Show()
			MyProject.Forms.Form1.Button10.Visible = True
			Dim visible As Boolean = MyProject.Forms.Form1.Button2.Visible
			If visible Then
				MyProject.Forms.Form1.Button2.Visible = False
			End If
			Me.Close()
		End Sub

		' Token: 0x06000124 RID: 292 RVA: 0x03D839DC File Offset: 0x03D81DDC
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x04000078 RID: 120
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000079 RID: 121
		<AccessedThroughProperty("TableLayoutPanel")>
		Private _TableLayoutPanel As TableLayoutPanel

		' Token: 0x0400007A RID: 122
		<AccessedThroughProperty("LogoPictureBox")>
		Private _LogoPictureBox As PictureBox

		' Token: 0x0400007B RID: 123
		<AccessedThroughProperty("LabelProductName")>
		Private _LabelProductName As Label

		' Token: 0x0400007C RID: 124
		<AccessedThroughProperty("LabelVersion")>
		Private _LabelVersion As Label

		' Token: 0x0400007D RID: 125
		<AccessedThroughProperty("LabelCompanyName")>
		Private _LabelCompanyName As Label

		' Token: 0x0400007E RID: 126
		<AccessedThroughProperty("TextBoxDescription")>
		Private _TextBoxDescription As TextBox

		' Token: 0x0400007F RID: 127
		<AccessedThroughProperty("OKButton")>
		Private _OKButton As Button

		' Token: 0x04000080 RID: 128
		<AccessedThroughProperty("LabelCopyright")>
		Private _LabelCopyright As Label
	End Class
End Namespace
