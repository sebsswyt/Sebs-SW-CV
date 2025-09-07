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
	' Token: 0x02000024 RID: 36
	<DesignerGenerated()>
	Public Partial Class cmdpad
		Inherits Form

		' Token: 0x060002B3 RID: 691 RVA: 0x03D8DE50 File Offset: 0x03D8C250
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = cmdpad.__ENCList
			SyncLock _ENCList
				cmdpad.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170000E7 RID: 231
		' (get) Token: 0x060002B6 RID: 694 RVA: 0x03D8E598 File Offset: 0x03D8C998
		' (set) Token: 0x060002B7 RID: 695 RVA: 0x03D8E5B0 File Offset: 0x03D8C9B0
		Friend Overridable Property MenuStrip1 As MenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuStrip1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuStrip)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.MenuStrip1_MouseMove
				Dim mouseEventHandler2 As MouseEventHandler = AddressOf Me.MenuStrip1_MouseDown
				Dim flag As Boolean = Me._MenuStrip1 IsNot Nothing
				If flag Then
					RemoveHandler Me._MenuStrip1.MouseMove, mouseEventHandler
					RemoveHandler Me._MenuStrip1.MouseDown, mouseEventHandler2
				End If
				Me._MenuStrip1 = value
				flag = Me._MenuStrip1 IsNot Nothing
				If flag Then
					AddHandler Me._MenuStrip1.MouseMove, mouseEventHandler
					AddHandler Me._MenuStrip1.MouseDown, mouseEventHandler2
				End If
			End Set
		End Property

		' Token: 0x170000E8 RID: 232
		' (get) Token: 0x060002B8 RID: 696 RVA: 0x03D8E638 File Offset: 0x03D8CA38
		' (set) Token: 0x060002B9 RID: 697 RVA: 0x03D8E650 File Offset: 0x03D8CA50
		Friend Overridable Property SettingsToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SettingsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._SettingsToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x170000E9 RID: 233
		' (get) Token: 0x060002BA RID: 698 RVA: 0x03D8E65C File Offset: 0x03D8CA5C
		' (set) Token: 0x060002BB RID: 699 RVA: 0x03D8E674 File Offset: 0x03D8CA74
		Friend Overridable Property FontToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FontToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._FontToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x170000EA RID: 234
		' (get) Token: 0x060002BC RID: 700 RVA: 0x03D8E680 File Offset: 0x03D8CA80
		' (set) Token: 0x060002BD RID: 701 RVA: 0x03D8E698 File Offset: 0x03D8CA98
		Friend Overridable Property WindowsCMDToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._WindowsCMDToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.WindowsCMDToolStripMenuItem_Click
				Dim flag As Boolean = Me._WindowsCMDToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._WindowsCMDToolStripMenuItem.Click, eventHandler
				End If
				Me._WindowsCMDToolStripMenuItem = value
				flag = Me._WindowsCMDToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._WindowsCMDToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170000EB RID: 235
		' (get) Token: 0x060002BE RID: 702 RVA: 0x03D8E6F8 File Offset: 0x03D8CAF8
		' (set) Token: 0x060002BF RID: 703 RVA: 0x03D8E710 File Offset: 0x03D8CB10
		Friend Overridable Property RichTextBox1 As RichTextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._RichTextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Me._RichTextBox1 = value
			End Set
		End Property

		' Token: 0x170000EC RID: 236
		' (get) Token: 0x060002C0 RID: 704 RVA: 0x03D8E71C File Offset: 0x03D8CB1C
		' (set) Token: 0x060002C1 RID: 705 RVA: 0x03D8E734 File Offset: 0x03D8CB34
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

		' Token: 0x170000ED RID: 237
		' (get) Token: 0x060002C2 RID: 706 RVA: 0x03D8E794 File Offset: 0x03D8CB94
		' (set) Token: 0x060002C3 RID: 707 RVA: 0x03D8E7AC File Offset: 0x03D8CBAC
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

		' Token: 0x170000EE RID: 238
		' (get) Token: 0x060002C4 RID: 708 RVA: 0x03D8E80C File Offset: 0x03D8CC0C
		' (set) Token: 0x060002C5 RID: 709 RVA: 0x03D8E824 File Offset: 0x03D8CC24
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

		' Token: 0x170000EF RID: 239
		' (get) Token: 0x060002C6 RID: 710 RVA: 0x03D8E884 File Offset: 0x03D8CC84
		' (set) Token: 0x060002C7 RID: 711 RVA: 0x03D8E89C File Offset: 0x03D8CC9C
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

		' Token: 0x170000F0 RID: 240
		' (get) Token: 0x060002C8 RID: 712 RVA: 0x03D8E8FC File Offset: 0x03D8CCFC
		' (set) Token: 0x060002C9 RID: 713 RVA: 0x03D8E914 File Offset: 0x03D8CD14
		Friend Overridable Property OldCMDToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._OldCMDToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.OldCMDToolStripMenuItem_Click
				Dim flag As Boolean = Me._OldCMDToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._OldCMDToolStripMenuItem.Click, eventHandler
				End If
				Me._OldCMDToolStripMenuItem = value
				flag = Me._OldCMDToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._OldCMDToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x060002CA RID: 714 RVA: 0x03D8E974 File Offset: 0x03D8CD74
		Private Sub WindowsCMDToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Process.Start("cmd.exe")
		End Sub

		' Token: 0x060002CB RID: 715 RVA: 0x03D8E984 File Offset: 0x03D8CD84
		Private Sub MenuStrip1_MouseDown(sender As Object, e As MouseEventArgs)
			' The following expression was wrapped in a checked-expression
			Me.mouse_move = New Point(0 - e.X, 0 - e.Y)
		End Sub

		' Token: 0x060002CC RID: 716 RVA: 0x03D8E9A4 File Offset: 0x03D8CDA4
		Private Sub MenuStrip1_MouseMove(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = e.Button = MouseButtons.Left
			If flag Then
				Dim mousePosition As Point = Control.MousePosition
				mousePosition.Offset(Me.mouse_move.X, Me.mouse_move.Y)
				Me.Location = mousePosition
				flag = Operators.CompareString(Me.RichTextBox1.Text, "Friday", False) = 0
				If Not flag Then
					Me.SettingsToolStripMenuItem.HideDropDown()
				End If
			End If
		End Sub

		' Token: 0x060002CD RID: 717 RVA: 0x03D8EA20 File Offset: 0x03D8CE20
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x060002CE RID: 718 RVA: 0x03D8EA2C File Offset: 0x03D8CE2C
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.WindowState = FormWindowState.Normal
			If flag Then
				Me.WindowState = FormWindowState.Maximized
			Else
				Me.WindowState = FormWindowState.Normal
			End If
		End Sub

		' Token: 0x060002CF RID: 719 RVA: 0x03D8EA5C File Offset: 0x03D8CE5C
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x060002D0 RID: 720 RVA: 0x03D8EA68 File Offset: 0x03D8CE68
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/help", False) = 0
			If flag Then
				MyProject.Forms.Form15.Show()
				MyProject.Forms.Form15.Show()
				MyProject.Forms.Form15.Show()
				MyProject.Forms.Form15.TextBox1.[ReadOnly] = True
				MyProject.Forms.Form15.WindowState = FormWindowState.Normal
				MyProject.Forms.Form15.TextBox1.Text = "C:/Sebs-SW-CV/install .exe" & vbCrLf & "C:/Sebs-SW-CV/explorer" & vbCrLf & "C:/Sebs-SW-CV/install CMD-internet++" & vbCrLf & "C:/Sebs-SW-CV/13.F" & vbCrLf & "C:/Sebs-SW-CV/Time13" & vbCrLf & "C:/Sebs-SW-CV/13.F" & vbCrLf & "C:/Sebs-SW-CV/LogTime13" & vbCrLf & "C:/Sebs-SW-CV/startup"
				MyProject.Forms.Form39.LinkLabel1.Enabled = False
				Me.RichTextBox1.Text = "C:/Sebs-SW-CV/help - Done"
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/taskman", False) = 0
			If flag Then
				MyProject.Forms.Form25.Show()
				Me.RichTextBox1.Text = "C:/Sebs-SW-CV/taskman - Done"
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/Lions explorer2", False) = 0
			If flag Then
				MyProject.Forms.Form19.Show()
				MyProject.Forms.Form19.Button6.Enabled = True
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/install .exe", False) = 0
			If flag Then
				MyProject.Forms.Form41.Show()
				Me.RichTextBox1.Text = "C:/Sebs-SW-CV/install .exe - Done"
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/install .exe", False) = 0
			If flag Then
				MyProject.Forms.Form41.Show()
				Me.RichTextBox1.Text = "C:/Sebs-SW-CV/install .exe - Done"
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/explorer", False) = 0
			If flag Then
				MyProject.Forms.Form1.Show()
				MyProject.Forms.Form1.Timer3.Start()
				Me.RichTextBox1.Text = "C:/Sebs-SW-CV/explorer - Done"
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/install CMD-internet++", False) = 0
			If flag Then
				MyProject.Forms.Form35.Show()
				Me.RichTextBox1.Text = "C:/Sebs-SW-CV/install CMD-internet++ - Done"
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/13.F", False) = 0
			If flag Then
				MyProject.Forms.form1Pad.Panel1.BackColor = Color.DarkGray
				Me.RichTextBox1.Text = "C:/Sebs-SW-CV"
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/Time13", False) = 0
			If flag Then
				MyProject.Forms.form1Pad.Label3.Text = "fredag:13"
				Me.RichTextBox1.Text = "C:/Sebs-SW-CV/Time13 - Done"
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/Time13", False) = 0
			If flag Then
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/LogTime13", False) = 0
			If flag Then
				MyProject.Forms.form1Pad.Panel3.Visible = True
				Me.RichTextBox1.Text = "C:/Sebs-SW-CV/LogTime13 - Done"
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/startup", False) = 0
			Dim flag2 As Boolean
			If flag Then
				flag2 = MyProject.Forms.Form33.Label1.Visible
				If flag2 Then
					Interaction.MsgBox("Sorry Fail to go to Startup", MsgBoxStyle.Critical, Nothing)
					Me.RichTextBox1.Text = "C:/Sebs-SW-CV/startup - Fail"
				Else
					MyProject.Forms.Form48.Show()
					Me.Close()
				End If
				Me.RichTextBox1.Text = "C:/Sebs-SW-CV/install CMD-internet++ - Done"
			End If
			flag2 = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/B1", False) = 0
			If flag2 Then
				MyProject.Forms.Loginz.Show()
			End If
			flag2 = Me.RichTextBox1.ForeColor = Color.Black
			If flag2 Then
				Me.RichTextBox1.ForeColor = Color.White
			End If
		End Sub

		' Token: 0x060002D1 RID: 721 RVA: 0x03D8EE94 File Offset: 0x03D8D294
		Private Sub OldCMDToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form17.Show()
			Me.Close()
		End Sub

		' Token: 0x0400011B RID: 283
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400011D RID: 285
		<AccessedThroughProperty("MenuStrip1")>
		Private _MenuStrip1 As MenuStrip

		' Token: 0x0400011E RID: 286
		<AccessedThroughProperty("SettingsToolStripMenuItem")>
		Private _SettingsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400011F RID: 287
		<AccessedThroughProperty("FontToolStripMenuItem")>
		Private _FontToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000120 RID: 288
		<AccessedThroughProperty("WindowsCMDToolStripMenuItem")>
		Private _WindowsCMDToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000121 RID: 289
		<AccessedThroughProperty("RichTextBox1")>
		Private _RichTextBox1 As RichTextBox

		' Token: 0x04000122 RID: 290
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000123 RID: 291
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x04000124 RID: 292
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x04000125 RID: 293
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x04000126 RID: 294
		<AccessedThroughProperty("OldCMDToolStripMenuItem")>
		Private _OldCMDToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000127 RID: 295
		Private mouse_move As Point
	End Class
End Namespace
