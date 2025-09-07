Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports CV.My
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x02000069 RID: 105
	<DesignerGenerated()>
	Public Partial Class Form57
		Inherits Form

		' Token: 0x0600116F RID: 4463 RVA: 0x03DED42C File Offset: 0x03DEB82C
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form57_Load
			Dim _ENCList As List(Of WeakReference) = Form57.__ENCList
			SyncLock _ENCList
				Form57.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170005BD RID: 1469
		' (get) Token: 0x06001172 RID: 4466 RVA: 0x03DEDA3C File Offset: 0x03DEBE3C
		' (set) Token: 0x06001173 RID: 4467 RVA: 0x03DEDA54 File Offset: 0x03DEBE54
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

		' Token: 0x170005BE RID: 1470
		' (get) Token: 0x06001174 RID: 4468 RVA: 0x03DEDA60 File Offset: 0x03DEBE60
		' (set) Token: 0x06001175 RID: 4469 RVA: 0x03DEDA78 File Offset: 0x03DEBE78
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

		' Token: 0x170005BF RID: 1471
		' (get) Token: 0x06001176 RID: 4470 RVA: 0x03DEDA84 File Offset: 0x03DEBE84
		' (set) Token: 0x06001177 RID: 4471 RVA: 0x03DEDA9C File Offset: 0x03DEBE9C
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

		' Token: 0x170005C0 RID: 1472
		' (get) Token: 0x06001178 RID: 4472 RVA: 0x03DEDAA8 File Offset: 0x03DEBEA8
		' (set) Token: 0x06001179 RID: 4473 RVA: 0x03DEDAC0 File Offset: 0x03DEBEC0
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

		' Token: 0x170005C1 RID: 1473
		' (get) Token: 0x0600117A RID: 4474 RVA: 0x03DEDACC File Offset: 0x03DEBECC
		' (set) Token: 0x0600117B RID: 4475 RVA: 0x03DEDAE4 File Offset: 0x03DEBEE4
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

		' Token: 0x170005C2 RID: 1474
		' (get) Token: 0x0600117C RID: 4476 RVA: 0x03DEDB44 File Offset: 0x03DEBF44
		' (set) Token: 0x0600117D RID: 4477 RVA: 0x03DEDB5C File Offset: 0x03DEBF5C
		Friend Overridable Property RestartTimer As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._RestartTimer
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim eventHandler As EventHandler = AddressOf Me.Timer1_Tick
				Dim flag As Boolean = Me._RestartTimer IsNot Nothing
				If flag Then
					RemoveHandler Me._RestartTimer.Tick, eventHandler
				End If
				Me._RestartTimer = value
				flag = Me._RestartTimer IsNot Nothing
				If flag Then
					AddHandler Me._RestartTimer.Tick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170005C3 RID: 1475
		' (get) Token: 0x0600117E RID: 4478 RVA: 0x03DEDBBC File Offset: 0x03DEBFBC
		' (set) Token: 0x0600117F RID: 4479 RVA: 0x03DEDBD4 File Offset: 0x03DEBFD4
		Friend Overridable Property StartingTimer As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._StartingTimer
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim eventHandler As EventHandler = AddressOf Me.StartingTimer_Tick
				Dim flag As Boolean = Me._StartingTimer IsNot Nothing
				If flag Then
					RemoveHandler Me._StartingTimer.Tick, eventHandler
				End If
				Me._StartingTimer = value
				flag = Me._StartingTimer IsNot Nothing
				If flag Then
					AddHandler Me._StartingTimer.Tick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170005C4 RID: 1476
		' (get) Token: 0x06001180 RID: 4480 RVA: 0x03DEDC34 File Offset: 0x03DEC034
		' (set) Token: 0x06001181 RID: 4481 RVA: 0x03DEDC4C File Offset: 0x03DEC04C
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

		' Token: 0x06001182 RID: 4482 RVA: 0x03DEDC58 File Offset: 0x03DEC058
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Interaction.MsgBox("No Exit Button here", MsgBoxStyle.OkOnly, Nothing)
		End Sub

		' Token: 0x06001183 RID: 4483 RVA: 0x03DEDC6C File Offset: 0x03DEC06C
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar1.Increment(1)
			Dim flag As Boolean = Me.ProgressBar1.Value = 10
			If flag Then
				Me.Label1.Text = "Restarting.."
			End If
			flag = Me.ProgressBar1.Value = 15
			If flag Then
				Me.Label1.Text = "Restarting..."
			End If
			flag = Me.ProgressBar1.Value = 20
			If flag Then
				Me.Label1.Text = "Restarting.."
			End If
			flag = Me.ProgressBar1.Value = 25
			If flag Then
				Me.Label1.Text = "Restarting."
			End If
			flag = Me.ProgressBar1.Value = 30
			If flag Then
				Me.Label1.Text = "Restarting.."
			End If
			flag = Me.ProgressBar1.Value = 35
			If flag Then
				Me.Label1.Text = "Restarting..."
			End If
			flag = Me.ProgressBar1.Value = 40
			If flag Then
				Me.Label1.Text = "Restarting.."
			End If
			flag = Me.ProgressBar1.Value = 45
			If flag Then
				Me.Label1.Text = "Restarting."
			End If
			flag = Me.ProgressBar1.Value = 50
			If flag Then
				Me.Label1.Text = "Restarting.."
				MyProject.Forms.form1Pad.Label7.Text = "ON"
				MyProject.Forms.form1Pad.Close()
			End If
			flag = Me.ProgressBar1.Value = 55
			If flag Then
				Me.Label1.Text = "Restarting..."
			End If
			flag = Me.ProgressBar1.Value = 60
			If flag Then
				Me.Label1.Text = "Restarting.."
			End If
			flag = Me.ProgressBar1.Value = 65
			If flag Then
				Me.Label1.Text = "Restarting."
			End If
			flag = Me.ProgressBar1.Value = 70
			If flag Then
				Me.Label1.Text = "Restarting.."
			End If
			flag = Me.ProgressBar1.Value = 75
			If flag Then
				Me.Label1.Text = "Restarting..."
			End If
			flag = Me.ProgressBar1.Value = 80
			If flag Then
				Me.Label1.Text = "Restarting.."
			End If
			flag = Me.ProgressBar1.Value = 85
			If flag Then
				Me.Label1.Text = "Restarting."
			End If
			flag = Me.ProgressBar1.Value = 90
			If flag Then
				Me.Label1.Text = "Restarting.."
			End If
			flag = Me.ProgressBar1.Value = 95
			If flag Then
				Me.Label1.Text = "Restarting..."
			End If
			flag = Me.ProgressBar1.Value = Me.ProgressBar1.Maximum
			If flag Then
				MyProject.Forms.Form47.Show()
				Me.RestartTimer.[Stop]()
				Me.Close()
			End If
		End Sub

		' Token: 0x06001184 RID: 4484 RVA: 0x03DEDF8C File Offset: 0x03DEC38C
		Private Sub StartingTimer_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar1.Increment(3)
			Me.RestartTimer.[Stop]()
			Dim flag As Boolean = Me.ProgressBar1.Value = 5
			If flag Then
				Me.Label1.Text = "Starting up."
			End If
			flag = Me.ProgressBar1.Value = 10
			If flag Then
				Me.Label1.Text = "Starting up.."
			End If
			flag = Me.ProgressBar1.Value = 15
			If flag Then
				Me.Label1.Text = "Starting up..."
			End If
			flag = Me.ProgressBar1.Value = 20
			If flag Then
				Me.Label1.Text = "Starting up.."
			End If
			flag = Me.ProgressBar1.Value = 25
			If flag Then
				Me.Label1.Text = "Starting up."
			End If
			flag = Me.ProgressBar1.Value = 30
			If flag Then
				Me.Label1.Text = "Starting up.."
			End If
			flag = Me.ProgressBar1.Value = 35
			If flag Then
				Me.Label1.Text = "Starting up..."
			End If
			flag = Me.ProgressBar1.Value = 40
			If flag Then
				Me.Label1.Text = "Starting up.."
			End If
			flag = Me.ProgressBar1.Value = 45
			If flag Then
				Me.Label1.Text = "Starting up."
			End If
			flag = Me.ProgressBar1.Value = 50
			If flag Then
				Me.Label1.Text = "Starting up.."
			End If
			flag = Me.ProgressBar1.Value = 55
			If flag Then
				Me.Label1.Text = "Starting up..."
			End If
			flag = Me.ProgressBar1.Value = 60
			If flag Then
				Me.Label1.Text = "Starting up.."
			End If
			flag = Me.ProgressBar1.Value = 65
			If flag Then
				Me.Label1.Text = "Starting up."
			End If
			flag = Me.ProgressBar1.Value = 70
			If flag Then
				Me.Label1.Text = "Starting up.."
			End If
			flag = Me.ProgressBar1.Value = 75
			If flag Then
				Me.Label1.Text = "Starting up..."
			End If
			flag = Me.ProgressBar1.Value = 80
			If flag Then
				Me.Label1.Text = "Starting up.."
			End If
			flag = Me.ProgressBar1.Value = 85
			If flag Then
				Me.Label1.Text = "Starting up."
			End If
			flag = Me.ProgressBar1.Value = 90
			If flag Then
				Me.Label1.Text = "Starting up.."
			End If
			flag = Me.ProgressBar1.Value = 95
			If flag Then
				Me.Label1.Text = "Starting up..."
			End If
			flag = Operators.CompareString(Me.Label1.Text, "Restarting.", False) = 0
			If flag Then
				Me.Label1.Text = "Starting up"
			Else
				flag = Operators.CompareString(Me.Label1.Text, "Restarting..", False) = 0
				If flag Then
					Me.Label1.Text = "Starting up"
				Else
					flag = Operators.CompareString(Me.Label1.Text, "Restarting...", False) = 0
					If flag Then
						Me.Label1.Text = "Starting up"
					End If
				End If
			End If
			flag = Me.ProgressBar1.Value = 100
			If flag Then
				MyProject.Forms.Form48.Show()
				MyProject.Forms.Form54.Close()
				Me.Close()
			End If
		End Sub

		' Token: 0x06001185 RID: 4485 RVA: 0x03DEE340 File Offset: 0x03DEC740
		Private Sub Form57_Load(sender As Object, e As EventArgs)
			MyProject.Forms.Form49.Show()
		End Sub

		' Token: 0x04000679 RID: 1657
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400067B RID: 1659
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x0400067C RID: 1660
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x0400067D RID: 1661
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x0400067E RID: 1662
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x0400067F RID: 1663
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000680 RID: 1664
		<AccessedThroughProperty("RestartTimer")>
		Private _RestartTimer As Timer

		' Token: 0x04000681 RID: 1665
		<AccessedThroughProperty("StartingTimer")>
		Private _StartingTimer As Timer

		' Token: 0x04000682 RID: 1666
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar
	End Class
End Namespace
