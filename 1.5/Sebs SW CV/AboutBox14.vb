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
	' Token: 0x0200000F RID: 15
	<DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox14
		Inherits Form

		' Token: 0x06000137 RID: 311 RVA: 0x03D83F7C File Offset: 0x03D8237C
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.AboutBox14_Load
			Dim _ENCList As List(Of WeakReference) = AboutBox14.__ENCList
			SyncLock _ENCList
				AboutBox14.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700007E RID: 126
		' (get) Token: 0x0600013A RID: 314 RVA: 0x03D844B4 File Offset: 0x03D828B4
		' (set) Token: 0x0600013B RID: 315 RVA: 0x03D844CC File Offset: 0x03D828CC
		Friend Property Button1 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button1 = value
			End Set
		End Property

		' Token: 0x1700007F RID: 127
		' (get) Token: 0x0600013C RID: 316 RVA: 0x03D844D8 File Offset: 0x03D828D8
		' (set) Token: 0x0600013D RID: 317 RVA: 0x03D844F0 File Offset: 0x03D828F0
		Friend Property Button2 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button2 = value
			End Set
		End Property

		' Token: 0x17000080 RID: 128
		' (get) Token: 0x0600013E RID: 318 RVA: 0x03D844FC File Offset: 0x03D828FC
		' (set) Token: 0x0600013F RID: 319 RVA: 0x03D84514 File Offset: 0x03D82914
		Friend Property Button3 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button3 = value
			End Set
		End Property

		' Token: 0x17000081 RID: 129
		' (get) Token: 0x06000140 RID: 320 RVA: 0x03D84520 File Offset: 0x03D82920
		' (set) Token: 0x06000141 RID: 321 RVA: 0x03D84538 File Offset: 0x03D82938
		Friend Property Button4 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button4 = value
			End Set
		End Property

		' Token: 0x17000082 RID: 130
		' (get) Token: 0x06000142 RID: 322 RVA: 0x03D84544 File Offset: 0x03D82944
		' (set) Token: 0x06000143 RID: 323 RVA: 0x03D8455C File Offset: 0x03D8295C
		Friend Property Button5 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button5_Click
				Dim flag As Boolean = Me._Button5 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button5.Click, eventHandler
				End If
				Me._Button5 = value
				flag = Me._Button5 IsNot Nothing
				If flag Then
					AddHandler Me._Button5.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000083 RID: 131
		' (get) Token: 0x06000144 RID: 324 RVA: 0x03D845BC File Offset: 0x03D829BC
		' (set) Token: 0x06000145 RID: 325 RVA: 0x03D845D4 File Offset: 0x03D829D4
		Friend Property Button6 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button6_Click
				Dim flag As Boolean = Me._Button6 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button6.Click, eventHandler
				End If
				Me._Button6 = value
				flag = Me._Button6 IsNot Nothing
				If flag Then
					AddHandler Me._Button6.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x06000146 RID: 326 RVA: 0x03D84634 File Offset: 0x03D82A34
		Private Sub AboutBox14_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000147 RID: 327 RVA: 0x03D84638 File Offset: 0x03D82A38
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000148 RID: 328 RVA: 0x03D8463C File Offset: 0x03D82A3C
		Private Sub Button6_Click(sender As Object, e As EventArgs)
			Me.Close()
			MyProject.Forms.Form24.Close()
		End Sub

		' Token: 0x06000149 RID: 329 RVA: 0x03D84658 File Offset: 0x03D82A58
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Restartform.Show()
			Me.Close()
		End Sub

		' Token: 0x04000088 RID: 136
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400008A RID: 138
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400008B RID: 139
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x0400008C RID: 140
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x0400008D RID: 141
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x0400008E RID: 142
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x0400008F RID: 143
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button
	End Class
End Namespace
