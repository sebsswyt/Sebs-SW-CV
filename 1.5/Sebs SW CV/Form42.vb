Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x02000059 RID: 89
	<DesignerGenerated()>
	Public Partial Class Form42
		Inherits Form

		' Token: 0x06000F4F RID: 3919 RVA: 0x03DDE760 File Offset: 0x03DDCB60
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Form42.__ENCList
			SyncLock _ENCList
				Form42.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700050F RID: 1295
		' (get) Token: 0x06000F52 RID: 3922 RVA: 0x03DDEB38 File Offset: 0x03DDCF38
		' (set) Token: 0x06000F53 RID: 3923 RVA: 0x03DDEB50 File Offset: 0x03DDCF50
		Friend Overridable Property PictureBox1 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox1_Click
				Dim flag As Boolean = Me._PictureBox1 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox1.Click, eventHandler
				End If
				Me._PictureBox1 = value
				flag = Me._PictureBox1 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox1.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000510 RID: 1296
		' (get) Token: 0x06000F54 RID: 3924 RVA: 0x03DDEBB0 File Offset: 0x03DDCFB0
		' (set) Token: 0x06000F55 RID: 3925 RVA: 0x03DDEBC8 File Offset: 0x03DDCFC8
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

		' Token: 0x17000511 RID: 1297
		' (get) Token: 0x06000F56 RID: 3926 RVA: 0x03DDEBD4 File Offset: 0x03DDCFD4
		' (set) Token: 0x06000F57 RID: 3927 RVA: 0x03DDEBEC File Offset: 0x03DDCFEC
		Friend Overridable Property CheckBox1 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox1 = value
			End Set
		End Property

		' Token: 0x17000512 RID: 1298
		' (get) Token: 0x06000F58 RID: 3928 RVA: 0x03DDEBF8 File Offset: 0x03DDCFF8
		' (set) Token: 0x06000F59 RID: 3929 RVA: 0x03DDEC10 File Offset: 0x03DDD010
		Friend Overridable Property Panel2 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.Panel2_MouseMove
				Dim mouseEventHandler2 As MouseEventHandler = AddressOf Me.Panel2_MouseDown
				Dim flag As Boolean = Me._Panel2 IsNot Nothing
				If flag Then
					RemoveHandler Me._Panel2.MouseMove, mouseEventHandler
					RemoveHandler Me._Panel2.MouseDown, mouseEventHandler2
				End If
				Me._Panel2 = value
				flag = Me._Panel2 IsNot Nothing
				If flag Then
					AddHandler Me._Panel2.MouseMove, mouseEventHandler
					AddHandler Me._Panel2.MouseDown, mouseEventHandler2
				End If
			End Set
		End Property

		' Token: 0x06000F5A RID: 3930 RVA: 0x03DDEC98 File Offset: 0x03DDD098
		Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000F5B RID: 3931 RVA: 0x03DDECA4 File Offset: 0x03DDD0A4
		Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs)
			' The following expression was wrapped in a checked-expression
			Me.mouse_move = New Point(0 - e.X, 0 - e.Y)
		End Sub

		' Token: 0x06000F5C RID: 3932 RVA: 0x03DDECC4 File Offset: 0x03DDD0C4
		Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = e.Button = MouseButtons.Left
			If flag Then
				Dim mousePosition As Point = Control.MousePosition
				mousePosition.Offset(Me.mouse_move.X, Me.mouse_move.Y)
				Me.Location = mousePosition
			End If
		End Sub

		' Token: 0x040005A7 RID: 1447
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040005A9 RID: 1449
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x040005AA RID: 1450
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x040005AB RID: 1451
		<AccessedThroughProperty("CheckBox1")>
		Private _CheckBox1 As CheckBox

		' Token: 0x040005AC RID: 1452
		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel

		' Token: 0x040005AD RID: 1453
		Private mouse_move As Point
	End Class
End Namespace
