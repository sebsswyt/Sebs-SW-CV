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
	' Token: 0x02000016 RID: 22
	<DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox20
		Inherits Form

		' Token: 0x060001B4 RID: 436 RVA: 0x03D86E28 File Offset: 0x03D85228
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.AboutBox20_Load
			Dim _ENCList As List(Of WeakReference) = AboutBox20.__ENCList
			SyncLock _ENCList
				AboutBox20.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170000A1 RID: 161
		' (get) Token: 0x060001B6 RID: 438 RVA: 0x03D86EE4 File Offset: 0x03D852E4
		' (set) Token: 0x060001B7 RID: 439 RVA: 0x03D86EFC File Offset: 0x03D852FC
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

		' Token: 0x170000A2 RID: 162
		' (get) Token: 0x060001B8 RID: 440 RVA: 0x03D86F08 File Offset: 0x03D85308
		' (set) Token: 0x060001B9 RID: 441 RVA: 0x03D86F20 File Offset: 0x03D85320
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

		' Token: 0x170000A3 RID: 163
		' (get) Token: 0x060001BA RID: 442 RVA: 0x03D86F2C File Offset: 0x03D8532C
		' (set) Token: 0x060001BB RID: 443 RVA: 0x03D86F44 File Offset: 0x03D85344
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

		' Token: 0x170000A4 RID: 164
		' (get) Token: 0x060001BC RID: 444 RVA: 0x03D86F50 File Offset: 0x03D85350
		' (set) Token: 0x060001BD RID: 445 RVA: 0x03D86F68 File Offset: 0x03D85368
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

		' Token: 0x170000A5 RID: 165
		' (get) Token: 0x060001BE RID: 446 RVA: 0x03D86F74 File Offset: 0x03D85374
		' (set) Token: 0x060001BF RID: 447 RVA: 0x03D86F8C File Offset: 0x03D8538C
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

		' Token: 0x170000A6 RID: 166
		' (get) Token: 0x060001C1 RID: 449 RVA: 0x03D87820 File Offset: 0x03D85C20
		' (set) Token: 0x060001C2 RID: 450 RVA: 0x03D87838 File Offset: 0x03D85C38
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

		' Token: 0x170000A7 RID: 167
		' (get) Token: 0x060001C3 RID: 451 RVA: 0x03D87898 File Offset: 0x03D85C98
		' (set) Token: 0x060001C4 RID: 452 RVA: 0x03D878B0 File Offset: 0x03D85CB0
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

		' Token: 0x170000A8 RID: 168
		' (get) Token: 0x060001C5 RID: 453 RVA: 0x03D878BC File Offset: 0x03D85CBC
		' (set) Token: 0x060001C6 RID: 454 RVA: 0x03D878D4 File Offset: 0x03D85CD4
		Friend Property Panel1 As Panel
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

		' Token: 0x170000A9 RID: 169
		' (get) Token: 0x060001C7 RID: 455 RVA: 0x03D878E0 File Offset: 0x03D85CE0
		' (set) Token: 0x060001C8 RID: 456 RVA: 0x03D878F8 File Offset: 0x03D85CF8
		Friend Property PictureBox1 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox1 = value
			End Set
		End Property

		' Token: 0x170000AA RID: 170
		' (get) Token: 0x060001C9 RID: 457 RVA: 0x03D87904 File Offset: 0x03D85D04
		' (set) Token: 0x060001CA RID: 458 RVA: 0x03D8791C File Offset: 0x03D85D1C
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

		' Token: 0x170000AB RID: 171
		' (get) Token: 0x060001CB RID: 459 RVA: 0x03D8797C File Offset: 0x03D85D7C
		' (set) Token: 0x060001CC RID: 460 RVA: 0x03D87994 File Offset: 0x03D85D94
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

		' Token: 0x060001CD RID: 461 RVA: 0x03D879F4 File Offset: 0x03D85DF4
		Private Sub AboutBox20_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060001CE RID: 462 RVA: 0x03D879F8 File Offset: 0x03D85DF8
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x060001CF RID: 463 RVA: 0x03D87A04 File Offset: 0x03D85E04
		Private Sub Label1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060001D0 RID: 464 RVA: 0x03D87A08 File Offset: 0x03D85E08
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x060001D1 RID: 465 RVA: 0x03D87A14 File Offset: 0x03D85E14
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox1.Show()
		End Sub

		' Token: 0x060001D2 RID: 466 RVA: 0x03D87A28 File Offset: 0x03D85E28
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form22.Show()
		End Sub

		' Token: 0x040000B9 RID: 185
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040000BA RID: 186
		<AccessedThroughProperty("LabelProductName")>
		Private _LabelProductName As Label

		' Token: 0x040000BB RID: 187
		<AccessedThroughProperty("LabelVersion")>
		Private _LabelVersion As Label

		' Token: 0x040000BC RID: 188
		<AccessedThroughProperty("LabelCompanyName")>
		Private _LabelCompanyName As Label

		' Token: 0x040000BD RID: 189
		<AccessedThroughProperty("TextBoxDescription")>
		Private _TextBoxDescription As TextBox

		' Token: 0x040000BE RID: 190
		<AccessedThroughProperty("LabelCopyright")>
		Private _LabelCopyright As Label

		' Token: 0x040000C0 RID: 192
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040000C1 RID: 193
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x040000C2 RID: 194
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x040000C3 RID: 195
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x040000C4 RID: 196
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x040000C5 RID: 197
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button
	End Class
End Namespace
