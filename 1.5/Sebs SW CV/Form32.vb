Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x0200004E RID: 78
	<DesignerGenerated()>
	Public Partial Class Form32
		Inherits Form

		' Token: 0x06000D29 RID: 3369 RVA: 0x03DCF628 File Offset: 0x03DCDA28
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Form32.__ENCList
			SyncLock _ENCList
				Form32.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700045E RID: 1118
		' (get) Token: 0x06000D2C RID: 3372 RVA: 0x03DCF82C File Offset: 0x03DCDC2C
		' (set) Token: 0x06000D2D RID: 3373 RVA: 0x03DCF844 File Offset: 0x03DCDC44
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

		' Token: 0x1700045F RID: 1119
		' (get) Token: 0x06000D2E RID: 3374 RVA: 0x03DCF8A4 File Offset: 0x03DCDCA4
		' (set) Token: 0x06000D2F RID: 3375 RVA: 0x03DCF8BC File Offset: 0x03DCDCBC
		Friend Overridable Property FolderBrowserDialog1 As FolderBrowserDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._FolderBrowserDialog1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FolderBrowserDialog)
				Me._FolderBrowserDialog1 = value
			End Set
		End Property

		' Token: 0x06000D30 RID: 3376 RVA: 0x03DCF8C8 File Offset: 0x03DCDCC8
		Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
			Me.FolderBrowserDialog1.ShowDialog()
		End Sub

		' Token: 0x040004DC RID: 1244
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040004DE RID: 1246
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x040004DF RID: 1247
		<AccessedThroughProperty("FolderBrowserDialog1")>
		Private _FolderBrowserDialog1 As FolderBrowserDialog
	End Class
End Namespace
