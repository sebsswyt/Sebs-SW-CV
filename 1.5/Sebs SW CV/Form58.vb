Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports AxWMPLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x0200006A RID: 106
	<DesignerGenerated()>
	Public Partial Class Form58
		Inherits Form

		' Token: 0x06001187 RID: 4487 RVA: 0x03DEE364 File Offset: 0x03DEC764
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form58_Load
			Dim _ENCList As List(Of WeakReference) = Form58.__ENCList
			SyncLock _ENCList
				Form58.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170005C5 RID: 1477
		' (get) Token: 0x0600118A RID: 4490 RVA: 0x03DEE660 File Offset: 0x03DECA60
		' (set) Token: 0x0600118B RID: 4491 RVA: 0x03DEE678 File Offset: 0x03DECA78
		Friend Overridable Property AxWindowsMediaPlayer1 As AxWindowsMediaPlayer
			<DebuggerNonUserCode()>
			Get
				Return Me._AxWindowsMediaPlayer1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As AxWindowsMediaPlayer)
				Dim wmpocxevents_MediaErrorEventHandler As _WMPOCXEvents_MediaErrorEventHandler = AddressOf Me.AxWindowsMediaPlayer1_MediaError
				Dim flag As Boolean = Me._AxWindowsMediaPlayer1 IsNot Nothing
				If flag Then
					Me._AxWindowsMediaPlayer1.MediaError -= wmpocxevents_MediaErrorEventHandler
				End If
				Me._AxWindowsMediaPlayer1 = value
				flag = Me._AxWindowsMediaPlayer1 IsNot Nothing
				If flag Then
					Me._AxWindowsMediaPlayer1.MediaError += wmpocxevents_MediaErrorEventHandler
				End If
			End Set
		End Property

		' Token: 0x170005C6 RID: 1478
		' (get) Token: 0x0600118C RID: 4492 RVA: 0x03DEE6D8 File Offset: 0x03DECAD8
		' (set) Token: 0x0600118D RID: 4493 RVA: 0x03DEE6F0 File Offset: 0x03DECAF0
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

		' Token: 0x170005C7 RID: 1479
		' (get) Token: 0x0600118E RID: 4494 RVA: 0x03DEE6FC File Offset: 0x03DECAFC
		' (set) Token: 0x0600118F RID: 4495 RVA: 0x03DEE714 File Offset: 0x03DECB14
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

		' Token: 0x170005C8 RID: 1480
		' (get) Token: 0x06001190 RID: 4496 RVA: 0x03DEE774 File Offset: 0x03DECB74
		' (set) Token: 0x06001191 RID: 4497 RVA: 0x03DEE78C File Offset: 0x03DECB8C
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

		' Token: 0x06001192 RID: 4498 RVA: 0x03DEE798 File Offset: 0x03DECB98
		Private Sub Form58_Load(sender As Object, e As EventArgs)
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x06001193 RID: 4499 RVA: 0x03DEE7A4 File Offset: 0x03DECBA4
		Public Sub startup()
		End Sub

		' Token: 0x06001194 RID: 4500 RVA: 0x03DEE7A8 File Offset: 0x03DECBA8
		Public Sub Music1()
		End Sub

		' Token: 0x06001195 RID: 4501 RVA: 0x03DEE7AC File Offset: 0x03DECBAC
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar1.Increment(1)
			Dim flag As Boolean = Me.ProgressBar1.Value = 100
			If flag Then
				Me.Close()
			End If
		End Sub

		' Token: 0x06001196 RID: 4502 RVA: 0x03DEE7E4 File Offset: 0x03DECBE4
		Private Sub AxWindowsMediaPlayer1_MediaError(sender As Object, e As _WMPOCXEvents_MediaErrorEvent)
			Interaction.MsgBox("Can't play Music", MsgBoxStyle.OkOnly, Nothing)
		End Sub

		' Token: 0x04000683 RID: 1667
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000685 RID: 1669
		<AccessedThroughProperty("AxWindowsMediaPlayer1")>
		Private _AxWindowsMediaPlayer1 As AxWindowsMediaPlayer

		' Token: 0x04000686 RID: 1670
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x04000687 RID: 1671
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x04000688 RID: 1672
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar
	End Class
End Namespace
