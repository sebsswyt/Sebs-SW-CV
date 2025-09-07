Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x02000045 RID: 69
	<DesignerGenerated()>
	Public Partial Class Form24
		Inherits Form

		' Token: 0x06000AFA RID: 2810 RVA: 0x03DC1998 File Offset: 0x03DBFD98
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Form24.__ENCList
			SyncLock _ENCList
				Form24.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700039E RID: 926
		' (get) Token: 0x06000AFD RID: 2813 RVA: 0x03DC1DBC File Offset: 0x03DC01BC
		' (set) Token: 0x06000AFE RID: 2814 RVA: 0x03DC1DD4 File Offset: 0x03DC01D4
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

		' Token: 0x1700039F RID: 927
		' (get) Token: 0x06000AFF RID: 2815 RVA: 0x03DC1E34 File Offset: 0x03DC0234
		' (set) Token: 0x06000B00 RID: 2816 RVA: 0x03DC1E4C File Offset: 0x03DC024C
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

		' Token: 0x170003A0 RID: 928
		' (get) Token: 0x06000B01 RID: 2817 RVA: 0x03DC1E58 File Offset: 0x03DC0258
		' (set) Token: 0x06000B02 RID: 2818 RVA: 0x03DC1E70 File Offset: 0x03DC0270
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

		' Token: 0x170003A1 RID: 929
		' (get) Token: 0x06000B03 RID: 2819 RVA: 0x03DC1E7C File Offset: 0x03DC027C
		' (set) Token: 0x06000B04 RID: 2820 RVA: 0x03DC1E94 File Offset: 0x03DC0294
		Friend Overridable Property PictureBox2 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox2 = value
			End Set
		End Property

		' Token: 0x06000B05 RID: 2821 RVA: 0x03DC1EA0 File Offset: 0x03DC02A0
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.Panel1.Visible = True
		End Sub

		' Token: 0x04000409 RID: 1033
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400040B RID: 1035
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400040C RID: 1036
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x0400040D RID: 1037
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x0400040E RID: 1038
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox
	End Class
End Namespace
