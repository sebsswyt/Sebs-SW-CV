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
	' Token: 0x0200006E RID: 110
	<DesignerGenerated()>
	Public Partial Class Form7
		Inherits Form

		' Token: 0x0600120A RID: 4618 RVA: 0x03DF27BC File Offset: 0x03DF0BBC
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form7_Load
			Dim _ENCList As List(Of WeakReference) = Form7.__ENCList
			SyncLock _ENCList
				Form7.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170005F9 RID: 1529
		' (get) Token: 0x0600120D RID: 4621 RVA: 0x03DF2E44 File Offset: 0x03DF1244
		' (set) Token: 0x0600120E RID: 4622 RVA: 0x03DF2E5C File Offset: 0x03DF125C
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

		' Token: 0x170005FA RID: 1530
		' (get) Token: 0x0600120F RID: 4623 RVA: 0x03DF2E68 File Offset: 0x03DF1268
		' (set) Token: 0x06001210 RID: 4624 RVA: 0x03DF2E80 File Offset: 0x03DF1280
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

		' Token: 0x170005FB RID: 1531
		' (get) Token: 0x06001211 RID: 4625 RVA: 0x03DF2EE0 File Offset: 0x03DF12E0
		' (set) Token: 0x06001212 RID: 4626 RVA: 0x03DF2EF8 File Offset: 0x03DF12F8
		Friend Overridable Property Button3 As Button
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

		' Token: 0x170005FC RID: 1532
		' (get) Token: 0x06001213 RID: 4627 RVA: 0x03DF2F04 File Offset: 0x03DF1304
		' (set) Token: 0x06001214 RID: 4628 RVA: 0x03DF2F1C File Offset: 0x03DF131C
		Friend Overridable Property Button4 As Button
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

		' Token: 0x170005FD RID: 1533
		' (get) Token: 0x06001215 RID: 4629 RVA: 0x03DF2F28 File Offset: 0x03DF1328
		' (set) Token: 0x06001216 RID: 4630 RVA: 0x03DF2F40 File Offset: 0x03DF1340
		Friend Overridable Property Button5 As Button
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

		' Token: 0x170005FE RID: 1534
		' (get) Token: 0x06001217 RID: 4631 RVA: 0x03DF2FA0 File Offset: 0x03DF13A0
		' (set) Token: 0x06001218 RID: 4632 RVA: 0x03DF2FB8 File Offset: 0x03DF13B8
		Friend Overridable Property Button6 As Button
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

		' Token: 0x170005FF RID: 1535
		' (get) Token: 0x06001219 RID: 4633 RVA: 0x03DF3018 File Offset: 0x03DF1418
		' (set) Token: 0x0600121A RID: 4634 RVA: 0x03DF3030 File Offset: 0x03DF1430
		Friend Overridable Property Button2 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button2_Click
				Dim flag As Boolean = Me._Button2 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button2.Click, eventHandler
				End If
				Me._Button2 = value
				flag = Me._Button2 IsNot Nothing
				If flag Then
					AddHandler Me._Button2.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000600 RID: 1536
		' (get) Token: 0x0600121B RID: 4635 RVA: 0x03DF3090 File Offset: 0x03DF1490
		' (set) Token: 0x0600121C RID: 4636 RVA: 0x03DF30A8 File Offset: 0x03DF14A8
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

		' Token: 0x17000601 RID: 1537
		' (get) Token: 0x0600121D RID: 4637 RVA: 0x03DF30B4 File Offset: 0x03DF14B4
		' (set) Token: 0x0600121E RID: 4638 RVA: 0x03DF30CC File Offset: 0x03DF14CC
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

		' Token: 0x17000602 RID: 1538
		' (get) Token: 0x0600121F RID: 4639 RVA: 0x03DF312C File Offset: 0x03DF152C
		' (set) Token: 0x06001220 RID: 4640 RVA: 0x03DF3144 File Offset: 0x03DF1544
		Friend Overridable Property Button7 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button7_Click
				Dim flag As Boolean = Me._Button7 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button7.Click, eventHandler
				End If
				Me._Button7 = value
				flag = Me._Button7 IsNot Nothing
				If flag Then
					AddHandler Me._Button7.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x06001221 RID: 4641 RVA: 0x03DF31A4 File Offset: 0x03DF15A4
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox12.Show()
		End Sub

		' Token: 0x06001222 RID: 4642 RVA: 0x03DF31B8 File Offset: 0x03DF15B8
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form2.Button2.Enabled = False
		End Sub

		' Token: 0x06001223 RID: 4643 RVA: 0x03DF31D4 File Offset: 0x03DF15D4
		Private Sub Button6_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox11.Show()
		End Sub

		' Token: 0x06001224 RID: 4644 RVA: 0x03DF31E8 File Offset: 0x03DF15E8
		Private Sub Form7_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06001225 RID: 4645 RVA: 0x03DF31EC File Offset: 0x03DF15EC
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Me.Timer1.Start()
			Me.Cursor = Cursors.AppStarting
			Me.PictureBox1.Cursor = Cursors.AppStarting
			Me.ProgressBar1.Cursor = Cursors.AppStarting
		End Sub

		' Token: 0x06001226 RID: 4646 RVA: 0x03DF322C File Offset: 0x03DF162C
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar1.Increment(3)
			Dim flag As Boolean = Me.ProgressBar1.Value = 100
			If flag Then
				Me.Cursor = Cursors.[Default]
				Me.PictureBox1.Cursor = Cursors.[Default]
				Me.ProgressBar1.Cursor = Cursors.[Default]
				MyProject.Forms.form1Pad.cvtaskbar.Visible = False
				Me.Button2.Enabled = False
			End If
		End Sub

		' Token: 0x06001227 RID: 4647 RVA: 0x03DF32B0 File Offset: 0x03DF16B0
		Private Sub Button7_Click(sender As Object, e As EventArgs)
			MyProject.Forms.form1Pad.Picture1.Visible = False
			MyProject.Forms.form1Pad.Picture2.Visible = False
			MyProject.Forms.form1Pad.Picture3.Visible = False
			MyProject.Forms.form1Pad.Picture4.Visible = False
			MyProject.Forms.form1Pad.Picture5.Visible = False
			MyProject.Forms.form1Pad.Picture6.Visible = False
			MyProject.Forms.form1Pad.Picture7.Visible = False
			MyProject.Forms.form1Pad.Start_menu.Visible = False
			MyProject.Forms.form1Pad.Panel1.Visible = False
			MyProject.Forms.form1Pad.BackColor = Color.Black
			Interaction.MsgBox("you are dum. you can't start the program again", MsgBoxStyle.OkOnly, Nothing)
		End Sub

		' Token: 0x040006BF RID: 1727
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040006C1 RID: 1729
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x040006C2 RID: 1730
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040006C3 RID: 1731
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x040006C4 RID: 1732
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x040006C5 RID: 1733
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x040006C6 RID: 1734
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x040006C7 RID: 1735
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x040006C8 RID: 1736
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x040006C9 RID: 1737
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x040006CA RID: 1738
		<AccessedThroughProperty("Button7")>
		Private _Button7 As Button
	End Class
End Namespace
