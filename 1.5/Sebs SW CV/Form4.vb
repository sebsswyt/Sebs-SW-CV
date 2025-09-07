Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x02000056 RID: 86
	<DesignerGenerated()>
	Public Partial Class Form4
		Inherits Form

		' Token: 0x06000EEA RID: 3818 RVA: 0x03DDBBE0 File Offset: 0x03DD9FE0
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Form4.__ENCList
			SyncLock _ENCList
				Form4.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170004EF RID: 1263
		' (get) Token: 0x06000EED RID: 3821 RVA: 0x03DDBE74 File Offset: 0x03DDA274
		' (set) Token: 0x06000EEE RID: 3822 RVA: 0x03DDBE8C File Offset: 0x03DDA28C
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

		' Token: 0x170004F0 RID: 1264
		' (get) Token: 0x06000EEF RID: 3823 RVA: 0x03DDBEEC File Offset: 0x03DDA2EC
		' (set) Token: 0x06000EF0 RID: 3824 RVA: 0x03DDBF04 File Offset: 0x03DDA304
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

		' Token: 0x06000EF1 RID: 3825 RVA: 0x03DDBF10 File Offset: 0x03DDA310
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x04000580 RID: 1408
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000582 RID: 1410
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000583 RID: 1411
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label
	End Class
End Namespace
