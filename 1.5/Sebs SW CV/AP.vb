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
	' Token: 0x02000023 RID: 35
	<DesignerGenerated()>
	Public Partial Class AP
		Inherits Form

		' Token: 0x060002A3 RID: 675 RVA: 0x03D8D774 File Offset: 0x03D8BB74
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = AP.__ENCList
			SyncLock _ENCList
				AP.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170000E2 RID: 226
		' (get) Token: 0x060002A6 RID: 678 RVA: 0x03D8DC04 File Offset: 0x03D8C004
		' (set) Token: 0x060002A7 RID: 679 RVA: 0x03D8DC1C File Offset: 0x03D8C01C
		Friend Overridable Property Button1 As Button
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

		' Token: 0x170000E3 RID: 227
		' (get) Token: 0x060002A8 RID: 680 RVA: 0x03D8DC7C File Offset: 0x03D8C07C
		' (set) Token: 0x060002A9 RID: 681 RVA: 0x03D8DC94 File Offset: 0x03D8C094
		Friend Overridable Property Panel1 As Panel
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

		' Token: 0x170000E4 RID: 228
		' (get) Token: 0x060002AA RID: 682 RVA: 0x03D8DCA0 File Offset: 0x03D8C0A0
		' (set) Token: 0x060002AB RID: 683 RVA: 0x03D8DCB8 File Offset: 0x03D8C0B8
		Friend Overridable Property VLabel As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._VLabel
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim eventHandler As EventHandler = AddressOf Me.VLabel_Click
				Dim flag As Boolean = Me._VLabel IsNot Nothing
				If flag Then
					RemoveHandler Me._VLabel.Click, eventHandler
				End If
				Me._VLabel = value
				flag = Me._VLabel IsNot Nothing
				If flag Then
					AddHandler Me._VLabel.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170000E5 RID: 229
		' (get) Token: 0x060002AC RID: 684 RVA: 0x03D8DD18 File Offset: 0x03D8C118
		' (set) Token: 0x060002AD RID: 685 RVA: 0x03D8DD30 File Offset: 0x03D8C130
		Friend Overridable Property PictureBox1 As PictureBox
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

		' Token: 0x170000E6 RID: 230
		' (get) Token: 0x060002AE RID: 686 RVA: 0x03D8DD3C File Offset: 0x03D8C13C
		' (set) Token: 0x060002AF RID: 687 RVA: 0x03D8DD54 File Offset: 0x03D8C154
		Friend Overridable Property Panel2 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel2 = value
			End Set
		End Property

		' Token: 0x060002B0 RID: 688 RVA: 0x03D8DD60 File Offset: 0x03D8C160
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox1.Show()
			Me.VLabel.Text = MyProject.Forms.AboutBox1.LabelVersion.Text
			Me.VLabel.Text = MyProject.Forms.AboutBox1.LabelVersion.Text
			Me.VLabel.Text = MyProject.Forms.AboutBox1.LabelVersion.Text
			Me.VLabel.Text = MyProject.Forms.AboutBox1.LabelVersion.Text
			MyProject.Forms.AboutBox1.Close()
		End Sub

		' Token: 0x060002B1 RID: 689 RVA: 0x03D8DE10 File Offset: 0x03D8C210
		Private Sub VLabel_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form19.Show()
			MyProject.Forms.Form19.WebBrowser1.Navigate("https://www.google.com")
		End Sub

		' Token: 0x04000114 RID: 276
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000116 RID: 278
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000117 RID: 279
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x04000118 RID: 280
		<AccessedThroughProperty("VLabel")>
		Private _VLabel As Label

		' Token: 0x04000119 RID: 281
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x0400011A RID: 282
		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel
	End Class
End Namespace
