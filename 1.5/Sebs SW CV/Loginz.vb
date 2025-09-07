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
	' Token: 0x02000071 RID: 113
	<DesignerGenerated()>
	Public Partial Class Loginz
		Inherits Form

		' Token: 0x0600128D RID: 4749 RVA: 0x03DF5A48 File Offset: 0x03DF3E48
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Loginz_Load
			Dim _ENCList As List(Of WeakReference) = Loginz.__ENCList
			SyncLock _ENCList
				Loginz.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000624 RID: 1572
		' (get) Token: 0x0600128F RID: 4751 RVA: 0x03DF5B04 File Offset: 0x03DF3F04
		' (set) Token: 0x06001290 RID: 4752 RVA: 0x03DF5B1C File Offset: 0x03DF3F1C
		Friend Overridable Property LogoPictureBox As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._LogoPictureBox
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._LogoPictureBox = value
			End Set
		End Property

		' Token: 0x17000625 RID: 1573
		' (get) Token: 0x06001291 RID: 4753 RVA: 0x03DF5B28 File Offset: 0x03DF3F28
		' (set) Token: 0x06001292 RID: 4754 RVA: 0x03DF5B40 File Offset: 0x03DF3F40
		Friend Overridable Property UsernameLabel As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._UsernameLabel
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._UsernameLabel = value
			End Set
		End Property

		' Token: 0x17000626 RID: 1574
		' (get) Token: 0x06001293 RID: 4755 RVA: 0x03DF5B4C File Offset: 0x03DF3F4C
		' (set) Token: 0x06001294 RID: 4756 RVA: 0x03DF5B64 File Offset: 0x03DF3F64
		Friend Overridable Property PasswordLabel As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._PasswordLabel
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._PasswordLabel = value
			End Set
		End Property

		' Token: 0x17000627 RID: 1575
		' (get) Token: 0x06001295 RID: 4757 RVA: 0x03DF5B70 File Offset: 0x03DF3F70
		' (set) Token: 0x06001296 RID: 4758 RVA: 0x03DF5B88 File Offset: 0x03DF3F88
		Friend Overridable Property UsernameTextBox As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._UsernameTextBox
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._UsernameTextBox = value
			End Set
		End Property

		' Token: 0x17000628 RID: 1576
		' (get) Token: 0x06001297 RID: 4759 RVA: 0x03DF5B94 File Offset: 0x03DF3F94
		' (set) Token: 0x06001298 RID: 4760 RVA: 0x03DF5BAC File Offset: 0x03DF3FAC
		Friend Overridable Property PasswordTextBox As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PasswordTextBox
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._PasswordTextBox = value
			End Set
		End Property

		' Token: 0x17000629 RID: 1577
		' (get) Token: 0x06001299 RID: 4761 RVA: 0x03DF5BB8 File Offset: 0x03DF3FB8
		' (set) Token: 0x0600129A RID: 4762 RVA: 0x03DF5BD0 File Offset: 0x03DF3FD0
		Friend Overridable Property OK As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._OK
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.OK_Click
				Dim flag As Boolean = Me._OK IsNot Nothing
				If flag Then
					RemoveHandler Me._OK.Click, eventHandler
				End If
				Me._OK = value
				flag = Me._OK IsNot Nothing
				If flag Then
					AddHandler Me._OK.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700062A RID: 1578
		' (get) Token: 0x0600129B RID: 4763 RVA: 0x03DF5C30 File Offset: 0x03DF4030
		' (set) Token: 0x0600129C RID: 4764 RVA: 0x03DF5C48 File Offset: 0x03DF4048
		Friend Overridable Property Cancel As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Cancel
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Cancel_Click
				Dim flag As Boolean = Me._Cancel IsNot Nothing
				If flag Then
					RemoveHandler Me._Cancel.Click, eventHandler
				End If
				Me._Cancel = value
				flag = Me._Cancel IsNot Nothing
				If flag Then
					AddHandler Me._Cancel.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x0600129E RID: 4766 RVA: 0x03DF617C File Offset: 0x03DF457C
		Private Sub OK_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.PasswordTextBox.Text, "YAG", False) = 0
			If flag Then
				MyProject.Forms.Form50.Show()
			End If
		End Sub

		' Token: 0x0600129F RID: 4767 RVA: 0x03DF61BC File Offset: 0x03DF45BC
		Private Sub Cancel_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x060012A0 RID: 4768 RVA: 0x03DF61C8 File Offset: 0x03DF45C8
		Private Sub Loginz_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x040006F0 RID: 1776
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040006F1 RID: 1777
		<AccessedThroughProperty("LogoPictureBox")>
		Private _LogoPictureBox As PictureBox

		' Token: 0x040006F2 RID: 1778
		<AccessedThroughProperty("UsernameLabel")>
		Private _UsernameLabel As Label

		' Token: 0x040006F3 RID: 1779
		<AccessedThroughProperty("PasswordLabel")>
		Private _PasswordLabel As Label

		' Token: 0x040006F4 RID: 1780
		<AccessedThroughProperty("UsernameTextBox")>
		Private _UsernameTextBox As TextBox

		' Token: 0x040006F5 RID: 1781
		<AccessedThroughProperty("PasswordTextBox")>
		Private _PasswordTextBox As TextBox

		' Token: 0x040006F6 RID: 1782
		<AccessedThroughProperty("OK")>
		Private _OK As Button

		' Token: 0x040006F7 RID: 1783
		<AccessedThroughProperty("Cancel")>
		Private _Cancel As Button
	End Class
End Namespace
