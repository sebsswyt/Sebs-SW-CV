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
	' Token: 0x02000078 RID: 120
	<DesignerGenerated()>
	Public Partial Class updaterform1
		Inherits Form

		' Token: 0x060012DA RID: 4826 RVA: 0x03DF7494 File Offset: 0x03DF5894
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.updaterform1_Load
			Dim _ENCList As List(Of WeakReference) = updaterform1.__ENCList
			SyncLock _ENCList
				updaterform1.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000641 RID: 1601
		' (get) Token: 0x060012DD RID: 4829 RVA: 0x03DF7868 File Offset: 0x03DF5C68
		' (set) Token: 0x060012DE RID: 4830 RVA: 0x03DF7880 File Offset: 0x03DF5C80
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

		' Token: 0x17000642 RID: 1602
		' (get) Token: 0x060012DF RID: 4831 RVA: 0x03DF788C File Offset: 0x03DF5C8C
		' (set) Token: 0x060012E0 RID: 4832 RVA: 0x03DF78A4 File Offset: 0x03DF5CA4
		Friend Overridable Property ProgressBar2 As ProgressBar
			<DebuggerNonUserCode()>
			Get
				Return Me._ProgressBar2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ProgressBar)
				Me._ProgressBar2 = value
			End Set
		End Property

		' Token: 0x17000643 RID: 1603
		' (get) Token: 0x060012E1 RID: 4833 RVA: 0x03DF78B0 File Offset: 0x03DF5CB0
		' (set) Token: 0x060012E2 RID: 4834 RVA: 0x03DF78C8 File Offset: 0x03DF5CC8
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

		' Token: 0x17000644 RID: 1604
		' (get) Token: 0x060012E3 RID: 4835 RVA: 0x03DF7928 File Offset: 0x03DF5D28
		' (set) Token: 0x060012E4 RID: 4836 RVA: 0x03DF7940 File Offset: 0x03DF5D40
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

		' Token: 0x17000645 RID: 1605
		' (get) Token: 0x060012E5 RID: 4837 RVA: 0x03DF794C File Offset: 0x03DF5D4C
		' (set) Token: 0x060012E6 RID: 4838 RVA: 0x03DF7964 File Offset: 0x03DF5D64
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

		' Token: 0x060012E7 RID: 4839 RVA: 0x03DF7970 File Offset: 0x03DF5D70
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar1.Increment(1)
			Dim flag As Boolean = Me.ProgressBar1.Value = 100
			If flag Then
				Me.ProgressBar2.Increment(1)
				flag = Me.ProgressBar2.Value = 100
				If flag Then
					MyProject.Forms.AboutBox19.Show()
					flag = MyProject.Forms.Form57.Label1.Visible
					If flag Then
						MyProject.Forms.Form57.RestartTimer.Start()
						MyProject.Forms.AboutBox19.Close()
					End If
					Me.Close()
				End If
			End If
		End Sub

		' Token: 0x060012E8 RID: 4840 RVA: 0x03DF7A18 File Offset: 0x03DF5E18
		Private Sub updaterform1_Load(sender As Object, e As EventArgs)
			MyProject.Forms.form1Pad.Label7.Text = "ON"
			MyProject.Forms.form1Pad.Close()
			Dim visible As Boolean = MyProject.Forms.Form33.Label1.Visible
			If visible Then
				Me.FormBorderStyle = FormBorderStyle.None
				Me.BackColor = Color.CornflowerBlue
			End If
		End Sub

		' Token: 0x04000713 RID: 1811
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000715 RID: 1813
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x04000716 RID: 1814
		<AccessedThroughProperty("ProgressBar2")>
		Private _ProgressBar2 As ProgressBar

		' Token: 0x04000717 RID: 1815
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x04000718 RID: 1816
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000719 RID: 1817
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label
	End Class
End Namespace
