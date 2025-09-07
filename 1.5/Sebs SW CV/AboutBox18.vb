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
	' Token: 0x02000013 RID: 19
	<DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox18
		Inherits Form

		' Token: 0x06000191 RID: 401 RVA: 0x03D861EC File Offset: 0x03D845EC
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.AboutBox18_Load
			Dim _ENCList As List(Of WeakReference) = AboutBox18.__ENCList
			SyncLock _ENCList
				AboutBox18.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000099 RID: 153
		' (get) Token: 0x06000194 RID: 404 RVA: 0x03D866D8 File Offset: 0x03D84AD8
		' (set) Token: 0x06000195 RID: 405 RVA: 0x03D866F0 File Offset: 0x03D84AF0
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

		' Token: 0x1700009A RID: 154
		' (get) Token: 0x06000196 RID: 406 RVA: 0x03D86750 File Offset: 0x03D84B50
		' (set) Token: 0x06000197 RID: 407 RVA: 0x03D86768 File Offset: 0x03D84B68
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

		' Token: 0x1700009B RID: 155
		' (get) Token: 0x06000198 RID: 408 RVA: 0x03D86774 File Offset: 0x03D84B74
		' (set) Token: 0x06000199 RID: 409 RVA: 0x03D8678C File Offset: 0x03D84B8C
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

		' Token: 0x1700009C RID: 156
		' (get) Token: 0x0600019A RID: 410 RVA: 0x03D86798 File Offset: 0x03D84B98
		' (set) Token: 0x0600019B RID: 411 RVA: 0x03D867B0 File Offset: 0x03D84BB0
		Friend Property Label2 As Label
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

		' Token: 0x1700009D RID: 157
		' (get) Token: 0x0600019C RID: 412 RVA: 0x03D867BC File Offset: 0x03D84BBC
		' (set) Token: 0x0600019D RID: 413 RVA: 0x03D867D4 File Offset: 0x03D84BD4
		Friend Property Label3 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label3 = value
			End Set
		End Property

		' Token: 0x0600019E RID: 414 RVA: 0x03D867E0 File Offset: 0x03D84BE0
		Private Sub AboutBox18_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600019F RID: 415 RVA: 0x03D867E4 File Offset: 0x03D84BE4
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060001A0 RID: 416 RVA: 0x03D867E8 File Offset: 0x03D84BE8
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Errorbox1.Show()
			MyProject.Forms.Errorbox1.al.Text = "Silan er Sjov"
		End Sub

		' Token: 0x040000AB RID: 171
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040000AD RID: 173
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040000AE RID: 174
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x040000AF RID: 175
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x040000B0 RID: 176
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x040000B1 RID: 177
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label
	End Class
End Namespace
