Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x02000010 RID: 16
	<DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox15
		Inherits Form

		' Token: 0x0600014B RID: 331 RVA: 0x03D84684 File Offset: 0x03D82A84
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.AboutBox15_Load
			Dim _ENCList As List(Of WeakReference) = AboutBox15.__ENCList
			SyncLock _ENCList
				AboutBox15.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000084 RID: 132
		' (get) Token: 0x0600014D RID: 333 RVA: 0x03D84740 File Offset: 0x03D82B40
		' (set) Token: 0x0600014E RID: 334 RVA: 0x03D84758 File Offset: 0x03D82B58
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

		' Token: 0x17000085 RID: 133
		' (get) Token: 0x0600014F RID: 335 RVA: 0x03D84764 File Offset: 0x03D82B64
		' (set) Token: 0x06000150 RID: 336 RVA: 0x03D8477C File Offset: 0x03D82B7C
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

		' Token: 0x17000086 RID: 134
		' (get) Token: 0x06000151 RID: 337 RVA: 0x03D84788 File Offset: 0x03D82B88
		' (set) Token: 0x06000152 RID: 338 RVA: 0x03D847A0 File Offset: 0x03D82BA0
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

		' Token: 0x17000087 RID: 135
		' (get) Token: 0x06000153 RID: 339 RVA: 0x03D847AC File Offset: 0x03D82BAC
		' (set) Token: 0x06000154 RID: 340 RVA: 0x03D847C4 File Offset: 0x03D82BC4
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

		' Token: 0x17000088 RID: 136
		' (get) Token: 0x06000155 RID: 341 RVA: 0x03D847D0 File Offset: 0x03D82BD0
		' (set) Token: 0x06000156 RID: 342 RVA: 0x03D847E8 File Offset: 0x03D82BE8
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

		' Token: 0x17000089 RID: 137
		' (get) Token: 0x06000157 RID: 343 RVA: 0x03D847F4 File Offset: 0x03D82BF4
		' (set) Token: 0x06000158 RID: 344 RVA: 0x03D8480C File Offset: 0x03D82C0C
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

		' Token: 0x1700008A RID: 138
		' (get) Token: 0x06000159 RID: 345 RVA: 0x03D84818 File Offset: 0x03D82C18
		' (set) Token: 0x0600015A RID: 346 RVA: 0x03D84830 File Offset: 0x03D82C30
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

		' Token: 0x1700008B RID: 139
		' (get) Token: 0x0600015B RID: 347 RVA: 0x03D84890 File Offset: 0x03D82C90
		' (set) Token: 0x0600015C RID: 348 RVA: 0x03D848A8 File Offset: 0x03D82CA8
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

		' Token: 0x0600015E RID: 350 RVA: 0x03D85100 File Offset: 0x03D83500
		Private Sub AboutBox15_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600015F RID: 351 RVA: 0x03D85104 File Offset: 0x03D83504
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x04000090 RID: 144
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000091 RID: 145
		<AccessedThroughProperty("TableLayoutPanel")>
		Private _TableLayoutPanel As TableLayoutPanel

		' Token: 0x04000092 RID: 146
		<AccessedThroughProperty("LogoPictureBox")>
		Private _LogoPictureBox As PictureBox

		' Token: 0x04000093 RID: 147
		<AccessedThroughProperty("LabelProductName")>
		Private _LabelProductName As Label

		' Token: 0x04000094 RID: 148
		<AccessedThroughProperty("LabelVersion")>
		Private _LabelVersion As Label

		' Token: 0x04000095 RID: 149
		<AccessedThroughProperty("LabelCompanyName")>
		Private _LabelCompanyName As Label

		' Token: 0x04000096 RID: 150
		<AccessedThroughProperty("TextBoxDescription")>
		Private _TextBoxDescription As TextBox

		' Token: 0x04000097 RID: 151
		<AccessedThroughProperty("OKButton")>
		Private _OKButton As Button

		' Token: 0x04000098 RID: 152
		<AccessedThroughProperty("LabelCopyright")>
		Private _LabelCopyright As Label
	End Class
End Namespace
