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
	' Token: 0x0200005E RID: 94
	<DesignerGenerated()>
	Public Partial Class Form47
		Inherits Form

		' Token: 0x0600102F RID: 4143 RVA: 0x03DE4EFC File Offset: 0x03DE32FC
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form47_Load
			Dim _ENCList As List(Of WeakReference) = Form47.__ENCList
			SyncLock _ENCList
				Form47.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000556 RID: 1366
		' (get) Token: 0x06001032 RID: 4146 RVA: 0x03DE5370 File Offset: 0x03DE3770
		' (set) Token: 0x06001033 RID: 4147 RVA: 0x03DE5388 File Offset: 0x03DE3788
		Friend Overridable Property Timer1 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._Timer1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim eventHandler As EventHandler = AddressOf Me.Timer1_Tick
				Dim flag As Boolean = Me._Timer1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Timer1.Tick, eventHandler
				End If
				Me._Timer1 = value
				flag = Me._Timer1 IsNot Nothing
				If flag Then
					AddHandler Me._Timer1.Tick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000557 RID: 1367
		' (get) Token: 0x06001034 RID: 4148 RVA: 0x03DE53E8 File Offset: 0x03DE37E8
		' (set) Token: 0x06001035 RID: 4149 RVA: 0x03DE5400 File Offset: 0x03DE3800
		Friend Overridable Property ProgressBar1 As ProgressBar
			<DebuggerNonUserCode()>
			Get
				Return Me._ProgressBar1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ProgressBar)
				Me._ProgressBar1 = value
			End Set
		End Property

		' Token: 0x17000558 RID: 1368
		' (get) Token: 0x06001036 RID: 4150 RVA: 0x03DE540C File Offset: 0x03DE380C
		' (set) Token: 0x06001037 RID: 4151 RVA: 0x03DE5424 File Offset: 0x03DE3824
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

		' Token: 0x17000559 RID: 1369
		' (get) Token: 0x06001038 RID: 4152 RVA: 0x03DE5430 File Offset: 0x03DE3830
		' (set) Token: 0x06001039 RID: 4153 RVA: 0x03DE5448 File Offset: 0x03DE3848
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

		' Token: 0x1700055A RID: 1370
		' (get) Token: 0x0600103A RID: 4154 RVA: 0x03DE5454 File Offset: 0x03DE3854
		' (set) Token: 0x0600103B RID: 4155 RVA: 0x03DE546C File Offset: 0x03DE386C
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

		' Token: 0x0600103C RID: 4156 RVA: 0x03DE5478 File Offset: 0x03DE3878
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar1.Increment(3)
			Dim flag As Boolean = Me.ProgressBar1.Value = Me.ProgressBar1.Maximum
			If flag Then
				Dim flag2 As Boolean = Operators.CompareString(Me.Label2.Text, "1", False) = 0
				If flag2 Then
					MyProject.Forms.Form33.Show()
					MyProject.Forms.Form33.Label4.Text = "1"
					MyProject.Forms.Form33.Timer1.Start()
					Me.Close()
				Else
					MyProject.Forms.Form57.Show()
					MyProject.Forms.Form57.StartingTimer.Start()
					Me.Close()
				End If
			End If
		End Sub

		' Token: 0x0600103D RID: 4157 RVA: 0x03DE5548 File Offset: 0x03DE3948
		Private Sub Form47_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x040005FA RID: 1530
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040005FC RID: 1532
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x040005FD RID: 1533
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x040005FE RID: 1534
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x040005FF RID: 1535
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x04000600 RID: 1536
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label
	End Class
End Namespace
