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
	' Token: 0x02000044 RID: 68
	<DesignerGenerated()>
	Public Partial Class Form23
		Inherits Form

		' Token: 0x06000AF0 RID: 2800 RVA: 0x03DC15C8 File Offset: 0x03DBF9C8
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Form23.__ENCList
			SyncLock _ENCList
				Form23.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700039C RID: 924
		' (get) Token: 0x06000AF3 RID: 2803 RVA: 0x03DC1870 File Offset: 0x03DBFC70
		' (set) Token: 0x06000AF4 RID: 2804 RVA: 0x03DC1888 File Offset: 0x03DBFC88
		Friend Overridable Property Button11 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button11_Click
				Dim flag As Boolean = Me._Button11 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button11.Click, eventHandler
				End If
				Me._Button11 = value
				flag = Me._Button11 IsNot Nothing
				If flag Then
					AddHandler Me._Button11.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700039D RID: 925
		' (get) Token: 0x06000AF5 RID: 2805 RVA: 0x03DC18E8 File Offset: 0x03DBFCE8
		' (set) Token: 0x06000AF6 RID: 2806 RVA: 0x03DC1900 File Offset: 0x03DBFD00
		Friend Overridable Property Button8 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button8_Click
				Dim flag As Boolean = Me._Button8 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button8.Click, eventHandler
				End If
				Me._Button8 = value
				flag = Me._Button8 IsNot Nothing
				If flag Then
					AddHandler Me._Button8.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x06000AF7 RID: 2807 RVA: 0x03DC1960 File Offset: 0x03DBFD60
		Private Sub Button8_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form9.Show()
		End Sub

		' Token: 0x06000AF8 RID: 2808 RVA: 0x03DC1974 File Offset: 0x03DBFD74
		Private Sub Button11_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form19.Show()
		End Sub

		' Token: 0x04000405 RID: 1029
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000407 RID: 1031
		<AccessedThroughProperty("Button11")>
		Private _Button11 As Button

		' Token: 0x04000408 RID: 1032
		<AccessedThroughProperty("Button8")>
		Private _Button8 As Button
	End Class
End Namespace
