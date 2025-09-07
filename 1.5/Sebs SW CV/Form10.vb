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
	' Token: 0x02000034 RID: 52
	<DesignerGenerated()>
	Public Partial Class Form10
		Inherits Form

		' Token: 0x060005D6 RID: 1494 RVA: 0x03D9E02C File Offset: 0x03D9C42C
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form10_Load
			Dim _ENCList As List(Of WeakReference) = Form10.__ENCList
			SyncLock _ENCList
				Form10.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170001F1 RID: 497
		' (get) Token: 0x060005D9 RID: 1497 RVA: 0x03D9E558 File Offset: 0x03D9C958
		' (set) Token: 0x060005DA RID: 1498 RVA: 0x03D9E570 File Offset: 0x03D9C970
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

		' Token: 0x170001F2 RID: 498
		' (get) Token: 0x060005DB RID: 1499 RVA: 0x03D9E5D0 File Offset: 0x03D9C9D0
		' (set) Token: 0x060005DC RID: 1500 RVA: 0x03D9E5E8 File Offset: 0x03D9C9E8
		Friend Overridable Property Label1 As Label
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

		' Token: 0x170001F3 RID: 499
		' (get) Token: 0x060005DD RID: 1501 RVA: 0x03D9E5F4 File Offset: 0x03D9C9F4
		' (set) Token: 0x060005DE RID: 1502 RVA: 0x03D9E60C File Offset: 0x03D9CA0C
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

		' Token: 0x170001F4 RID: 500
		' (get) Token: 0x060005DF RID: 1503 RVA: 0x03D9E618 File Offset: 0x03D9CA18
		' (set) Token: 0x060005E0 RID: 1504 RVA: 0x03D9E630 File Offset: 0x03D9CA30
		Friend Overridable Property ErrorProvider1 As ErrorProvider
			<DebuggerNonUserCode()>
			Get
				Return Me._ErrorProvider1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ErrorProvider)
				Me._ErrorProvider1 = value
			End Set
		End Property

		' Token: 0x170001F5 RID: 501
		' (get) Token: 0x060005E1 RID: 1505 RVA: 0x03D9E63C File Offset: 0x03D9CA3C
		' (set) Token: 0x060005E2 RID: 1506 RVA: 0x03D9E654 File Offset: 0x03D9CA54
		Friend Overridable Property Button2 As Button
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

		' Token: 0x170001F6 RID: 502
		' (get) Token: 0x060005E3 RID: 1507 RVA: 0x03D9E6B4 File Offset: 0x03D9CAB4
		' (set) Token: 0x060005E4 RID: 1508 RVA: 0x03D9E6CC File Offset: 0x03D9CACC
		Friend Overridable Property Label2 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label2 = value
			End Set
		End Property

		' Token: 0x060005E5 RID: 1509 RVA: 0x03D9E6D8 File Offset: 0x03D9CAD8
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form11.Show()
		End Sub

		' Token: 0x060005E6 RID: 1510 RVA: 0x03D9E6EC File Offset: 0x03D9CAEC
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Explorer2.Show()
		End Sub

		' Token: 0x060005E7 RID: 1511 RVA: 0x03D9E700 File Offset: 0x03D9CB00
		Private Sub Form10_Load(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(MyProject.Forms.form1Pad.Username1.Text, "CV", False) = 0
			If flag Then
				Me.Label2.Text = "CV"
			Else
				Me.Label2.Text = MyProject.Forms.form1Pad.Username1.Text
			End If
		End Sub

		' Token: 0x04000234 RID: 564
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000236 RID: 566
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000237 RID: 567
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000238 RID: 568
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x04000239 RID: 569
		<AccessedThroughProperty("ErrorProvider1")>
		Private _ErrorProvider1 As ErrorProvider

		' Token: 0x0400023A RID: 570
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x0400023B RID: 571
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label
	End Class
End Namespace
