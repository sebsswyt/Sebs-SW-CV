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
	' Token: 0x0200006F RID: 111
	<DesignerGenerated()>
	Public Partial Class Form8
		Inherits Form

		' Token: 0x06001229 RID: 4649 RVA: 0x03DF33B8 File Offset: 0x03DF17B8
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form8_Load
			Dim _ENCList As List(Of WeakReference) = Form8.__ENCList
			SyncLock _ENCList
				Form8.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000603 RID: 1539
		' (get) Token: 0x0600122C RID: 4652 RVA: 0x03DF3868 File Offset: 0x03DF1C68
		' (set) Token: 0x0600122D RID: 4653 RVA: 0x03DF3880 File Offset: 0x03DF1C80
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

		' Token: 0x17000604 RID: 1540
		' (get) Token: 0x0600122E RID: 4654 RVA: 0x03DF38E0 File Offset: 0x03DF1CE0
		' (set) Token: 0x0600122F RID: 4655 RVA: 0x03DF38F8 File Offset: 0x03DF1CF8
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

		' Token: 0x17000605 RID: 1541
		' (get) Token: 0x06001230 RID: 4656 RVA: 0x03DF3904 File Offset: 0x03DF1D04
		' (set) Token: 0x06001231 RID: 4657 RVA: 0x03DF391C File Offset: 0x03DF1D1C
		Friend Overridable Property ProgressBar1 As ProgressBar
			<DebuggerNonUserCode()>
			Get
				Return Me._ProgressBar1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ProgressBar)
				Dim eventHandler As EventHandler = AddressOf Me.ProgressBar1_Click
				Dim flag As Boolean = Me._ProgressBar1 IsNot Nothing
				If flag Then
					RemoveHandler Me._ProgressBar1.Click, eventHandler
				End If
				Me._ProgressBar1 = value
				flag = Me._ProgressBar1 IsNot Nothing
				If flag Then
					AddHandler Me._ProgressBar1.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000606 RID: 1542
		' (get) Token: 0x06001232 RID: 4658 RVA: 0x03DF397C File Offset: 0x03DF1D7C
		' (set) Token: 0x06001233 RID: 4659 RVA: 0x03DF3994 File Offset: 0x03DF1D94
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

		' Token: 0x17000607 RID: 1543
		' (get) Token: 0x06001234 RID: 4660 RVA: 0x03DF39F4 File Offset: 0x03DF1DF4
		' (set) Token: 0x06001235 RID: 4661 RVA: 0x03DF3A0C File Offset: 0x03DF1E0C
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

		' Token: 0x17000608 RID: 1544
		' (get) Token: 0x06001236 RID: 4662 RVA: 0x03DF3A6C File Offset: 0x03DF1E6C
		' (set) Token: 0x06001237 RID: 4663 RVA: 0x03DF3A84 File Offset: 0x03DF1E84
		Friend Overridable Property Button3 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button3_Click
				Dim flag As Boolean = Me._Button3 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button3.Click, eventHandler
				End If
				Me._Button3 = value
				flag = Me._Button3 IsNot Nothing
				If flag Then
					AddHandler Me._Button3.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x06001238 RID: 4664 RVA: 0x03DF3AE4 File Offset: 0x03DF1EE4
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.Timer1.Start()
			Me.Button1.Visible = False
			Me.Button3.Visible = True
		End Sub

		' Token: 0x06001239 RID: 4665 RVA: 0x03DF3B10 File Offset: 0x03DF1F10
		Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ProgressBar1.Value = 100
			If flag Then
				Me.Button2.Enabled = True
			End If
		End Sub

		' Token: 0x0600123A RID: 4666 RVA: 0x03DF3B40 File Offset: 0x03DF1F40
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form3.Close()
			MyProject.Forms.Form4.Close()
			MyProject.Forms.Form5.Close()
			MyProject.Forms.Form6.Close()
			MyProject.Forms.Form7.Close()
			MyProject.Forms.Form2.Close()
			MyProject.Forms.Explorer1.Close()
			MyProject.Forms.Form9.Close()
			MyProject.Forms.Form10.Close()
			MyProject.Forms.Form11.Close()
			MyProject.Forms.Form12.Close()
			MyProject.Forms.Form13.Close()
			MyProject.Forms.Form14.Close()
			MyProject.Forms.Form15.Close()
			MyProject.Forms.Errorbox1.Close()
			MyProject.Forms.Restartform.Show()
			Me.Close()
		End Sub

		' Token: 0x0600123B RID: 4667 RVA: 0x03DF3C58 File Offset: 0x03DF2058
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar1.Increment(1)
		End Sub

		' Token: 0x0600123C RID: 4668 RVA: 0x03DF3C6C File Offset: 0x03DF206C
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			Me.Timer1.[Stop]()
			Me.Button3.Visible = False
			Me.Button1.Visible = True
		End Sub

		' Token: 0x0600123D RID: 4669 RVA: 0x03DF3C98 File Offset: 0x03DF2098
		Private Sub Form8_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x040006CB RID: 1739
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040006CD RID: 1741
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040006CE RID: 1742
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x040006CF RID: 1743
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x040006D0 RID: 1744
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x040006D1 RID: 1745
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x040006D2 RID: 1746
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button
	End Class
End Namespace
