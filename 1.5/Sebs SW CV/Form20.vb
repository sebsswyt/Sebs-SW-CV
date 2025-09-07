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
	' Token: 0x02000041 RID: 65
	<DesignerGenerated()>
	Public Partial Class Form20
		Inherits Form

		' Token: 0x060009C5 RID: 2501 RVA: 0x03DB8B7C File Offset: 0x03DB6F7C
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form20_Load
			Dim _ENCList As List(Of WeakReference) = Form20.__ENCList
			SyncLock _ENCList
				Form20.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000337 RID: 823
		' (get) Token: 0x060009C8 RID: 2504 RVA: 0x03DB97A4 File Offset: 0x03DB7BA4
		' (set) Token: 0x060009C9 RID: 2505 RVA: 0x03DB97BC File Offset: 0x03DB7BBC
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

		' Token: 0x17000338 RID: 824
		' (get) Token: 0x060009CA RID: 2506 RVA: 0x03DB981C File Offset: 0x03DB7C1C
		' (set) Token: 0x060009CB RID: 2507 RVA: 0x03DB9834 File Offset: 0x03DB7C34
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

		' Token: 0x17000339 RID: 825
		' (get) Token: 0x060009CC RID: 2508 RVA: 0x03DB9894 File Offset: 0x03DB7C94
		' (set) Token: 0x060009CD RID: 2509 RVA: 0x03DB98AC File Offset: 0x03DB7CAC
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

		' Token: 0x1700033A RID: 826
		' (get) Token: 0x060009CE RID: 2510 RVA: 0x03DB990C File Offset: 0x03DB7D0C
		' (set) Token: 0x060009CF RID: 2511 RVA: 0x03DB9924 File Offset: 0x03DB7D24
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

		' Token: 0x1700033B RID: 827
		' (get) Token: 0x060009D0 RID: 2512 RVA: 0x03DB9930 File Offset: 0x03DB7D30
		' (set) Token: 0x060009D1 RID: 2513 RVA: 0x03DB9948 File Offset: 0x03DB7D48
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

		' Token: 0x1700033C RID: 828
		' (get) Token: 0x060009D2 RID: 2514 RVA: 0x03DB99A8 File Offset: 0x03DB7DA8
		' (set) Token: 0x060009D3 RID: 2515 RVA: 0x03DB99C0 File Offset: 0x03DB7DC0
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

		' Token: 0x1700033D RID: 829
		' (get) Token: 0x060009D4 RID: 2516 RVA: 0x03DB9A20 File Offset: 0x03DB7E20
		' (set) Token: 0x060009D5 RID: 2517 RVA: 0x03DB9A38 File Offset: 0x03DB7E38
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

		' Token: 0x1700033E RID: 830
		' (get) Token: 0x060009D6 RID: 2518 RVA: 0x03DB9A44 File Offset: 0x03DB7E44
		' (set) Token: 0x060009D7 RID: 2519 RVA: 0x03DB9A5C File Offset: 0x03DB7E5C
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

		' Token: 0x1700033F RID: 831
		' (get) Token: 0x060009D8 RID: 2520 RVA: 0x03DB9ABC File Offset: 0x03DB7EBC
		' (set) Token: 0x060009D9 RID: 2521 RVA: 0x03DB9AD4 File Offset: 0x03DB7ED4
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

		' Token: 0x17000340 RID: 832
		' (get) Token: 0x060009DA RID: 2522 RVA: 0x03DB9B34 File Offset: 0x03DB7F34
		' (set) Token: 0x060009DB RID: 2523 RVA: 0x03DB9B4C File Offset: 0x03DB7F4C
		Friend Overridable Property Button4 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button4_Click
				Dim flag As Boolean = Me._Button4 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button4.Click, eventHandler
				End If
				Me._Button4 = value
				flag = Me._Button4 IsNot Nothing
				If flag Then
					AddHandler Me._Button4.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000341 RID: 833
		' (get) Token: 0x060009DC RID: 2524 RVA: 0x03DB9BAC File Offset: 0x03DB7FAC
		' (set) Token: 0x060009DD RID: 2525 RVA: 0x03DB9BC4 File Offset: 0x03DB7FC4
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

		' Token: 0x17000342 RID: 834
		' (get) Token: 0x060009DE RID: 2526 RVA: 0x03DB9C24 File Offset: 0x03DB8024
		' (set) Token: 0x060009DF RID: 2527 RVA: 0x03DB9C3C File Offset: 0x03DB803C
		Friend Overridable Property Button8 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button8_Click
				Dim flag As Boolean = Me._Button8 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button8.Click, eventHandler
				End If
				Me._Button8 = value
				flag = Me._Button8 IsNot Nothing
				If flag Then
					AddHandler Me._Button8.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000343 RID: 835
		' (get) Token: 0x060009E0 RID: 2528 RVA: 0x03DB9C9C File Offset: 0x03DB809C
		' (set) Token: 0x060009E1 RID: 2529 RVA: 0x03DB9CB4 File Offset: 0x03DB80B4
		Friend Overridable Property Button9 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button9_Click
				Dim flag As Boolean = Me._Button9 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button9.Click, eventHandler
				End If
				Me._Button9 = value
				flag = Me._Button9 IsNot Nothing
				If flag Then
					AddHandler Me._Button9.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000344 RID: 836
		' (get) Token: 0x060009E2 RID: 2530 RVA: 0x03DB9D14 File Offset: 0x03DB8114
		' (set) Token: 0x060009E3 RID: 2531 RVA: 0x03DB9D2C File Offset: 0x03DB812C
		Friend Overridable Property Timer2 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._Timer2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim eventHandler As EventHandler = AddressOf Me.Timer2_Tick
				Dim flag As Boolean = Me._Timer2 IsNot Nothing
				If flag Then
					RemoveHandler Me._Timer2.Tick, eventHandler
				End If
				Me._Timer2 = value
				flag = Me._Timer2 IsNot Nothing
				If flag Then
					AddHandler Me._Timer2.Tick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000345 RID: 837
		' (get) Token: 0x060009E4 RID: 2532 RVA: 0x03DB9D8C File Offset: 0x03DB818C
		' (set) Token: 0x060009E5 RID: 2533 RVA: 0x03DB9DA4 File Offset: 0x03DB81A4
		Friend Overridable Property Panel2 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.Panel2_MouseMove
				Dim mouseEventHandler2 As MouseEventHandler = AddressOf Me.Panel2_MouseDown
				Dim flag As Boolean = Me._Panel2 IsNot Nothing
				If flag Then
					RemoveHandler Me._Panel2.MouseMove, mouseEventHandler
					RemoveHandler Me._Panel2.MouseDown, mouseEventHandler2
				End If
				Me._Panel2 = value
				flag = Me._Panel2 IsNot Nothing
				If flag Then
					AddHandler Me._Panel2.MouseMove, mouseEventHandler
					AddHandler Me._Panel2.MouseDown, mouseEventHandler2
				End If
			End Set
		End Property

		' Token: 0x17000346 RID: 838
		' (get) Token: 0x060009E6 RID: 2534 RVA: 0x03DB9E2C File Offset: 0x03DB822C
		' (set) Token: 0x060009E7 RID: 2535 RVA: 0x03DB9E44 File Offset: 0x03DB8244
		Friend Overridable Property WebBrowser1 As WebBrowser
			<DebuggerNonUserCode()>
			Get
				Return Me._WebBrowser1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As WebBrowser)
				Me._WebBrowser1 = value
			End Set
		End Property

		' Token: 0x060009E8 RID: 2536 RVA: 0x03DB9E50 File Offset: 0x03DB8250
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.Timer1.Start()
			Me.Button3.Visible = True
		End Sub

		' Token: 0x060009E9 RID: 2537 RVA: 0x03DB9E70 File Offset: 0x03DB8270
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar1.Increment(1)
			Dim flag As Boolean = Me.ProgressBar1.Value = Me.ProgressBar1.Maximum
			If flag Then
				Me.Button2.Enabled = True
				Me.WebBrowser1.Visible = True
			End If
		End Sub

		' Token: 0x060009EA RID: 2538 RVA: 0x03DB9EC4 File Offset: 0x03DB82C4
		Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060009EB RID: 2539 RVA: 0x03DB9EC8 File Offset: 0x03DB82C8
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			Me.Timer1.[Stop]()
			Me.Button3.Visible = False
			Me.Button1.Visible = True
		End Sub

		' Token: 0x060009EC RID: 2540 RVA: 0x03DB9EF4 File Offset: 0x03DB82F4
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Button2.Text, "Update is Done ", False) = 0
			If flag Then
				MyProject.Forms.Form28.Show()
			Else
				MyProject.Forms.Form2.Close()
				MyProject.Forms.Form3.Close()
				MyProject.Forms.Form4.Close()
				MyProject.Forms.Form5.Close()
				MyProject.Forms.Form6.Close()
				MyProject.Forms.Form7.Close()
				MyProject.Forms.Explorer1.Close()
				MyProject.Forms.Explorer2.Close()
				MyProject.Forms.Form9.Close()
				MyProject.Forms.Form10.Close()
				MyProject.Forms.Form11.Close()
				MyProject.Forms.Form12.Close()
				MyProject.Forms.Form13.Close()
				MyProject.Forms.Form14.Close()
				MyProject.Forms.Form15.Close()
				MyProject.Forms.Form16.Close()
				MyProject.Forms.Form17.Close()
				MyProject.Forms.Form18.Close()
				MyProject.Forms.Form19.Close()
				MyProject.Forms.Errorbox1.Close()
				MyProject.Forms.AboutBox1.Close()
				MyProject.Forms.AboutBox3.Close()
				MyProject.Forms.AboutBox5.Close()
				MyProject.Forms.AboutBox7.Close()
				MyProject.Forms.AboutBox8.Close()
				flag = Interaction.MsgBox("Restart Program", MsgBoxStyle.OkCancel, Nothing) = MsgBoxResult.Ok
				If flag Then
					MyProject.Forms.Form57.Show()
					MyProject.Forms.Form57.StartingTimer.[Stop]()
					MyProject.Forms.updaterform1.Show()
					MyProject.Forms.updaterform1.Timer1.Start()
					MyProject.Forms.updaterform1.FormBorderStyle = FormBorderStyle.None
					MyProject.Forms.updaterform1.Text = "Update Sebs SW CV"
				End If
			End If
		End Sub

		' Token: 0x060009ED RID: 2541 RVA: 0x03DBA14C File Offset: 0x03DB854C
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form21.Show()
			easycode.openChildForm(New theme_window())
		End Sub

		' Token: 0x060009EE RID: 2542 RVA: 0x03DBA16C File Offset: 0x03DB856C
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form22.Show()
		End Sub

		' Token: 0x060009EF RID: 2543 RVA: 0x03DBA180 File Offset: 0x03DB8580
		Private Sub Button6_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form51.Show()
		End Sub

		' Token: 0x060009F0 RID: 2544 RVA: 0x03DBA194 File Offset: 0x03DB8594
		Private Sub Button9_Click(sender As Object, e As EventArgs)
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x060009F1 RID: 2545 RVA: 0x03DBA1A0 File Offset: 0x03DB85A0
		Private Sub Button8_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.WindowState = FormWindowState.Normal
			If flag Then
				Me.WindowState = FormWindowState.Maximized
			Else
				Me.WindowState = FormWindowState.Normal
			End If
		End Sub

		' Token: 0x060009F2 RID: 2546 RVA: 0x03DBA1D0 File Offset: 0x03DB85D0
		Private Sub Button7_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x060009F3 RID: 2547 RVA: 0x03DBA1DC File Offset: 0x03DB85DC
		Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs)
			' The following expression was wrapped in a checked-expression
			Me.mouse_move = New Point(0 - e.X, 0 - e.Y)
		End Sub

		' Token: 0x060009F4 RID: 2548 RVA: 0x03DBA1FC File Offset: 0x03DB85FC
		Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = e.Button = MouseButtons.Left
			If flag Then
				Dim mousePosition As Point = Control.MousePosition
				mousePosition.Offset(Me.mouse_move.X, Me.mouse_move.Y)
				Me.Location = mousePosition
			End If
		End Sub

		' Token: 0x060009F5 RID: 2549 RVA: 0x03DBA24C File Offset: 0x03DB864C
		Private Sub Timer2_Tick(sender As Object, e As EventArgs)
			Me.Panel2.BackColor = MyProject.Forms.Form_1pad.Panel1.BackColor
		End Sub

		' Token: 0x060009F6 RID: 2550 RVA: 0x03DBA270 File Offset: 0x03DB8670
		Private Sub Form20_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x04000396 RID: 918
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000398 RID: 920
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x04000399 RID: 921
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x0400039A RID: 922
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x0400039B RID: 923
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x0400039C RID: 924
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400039D RID: 925
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x0400039E RID: 926
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x0400039F RID: 927
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x040003A0 RID: 928
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x040003A1 RID: 929
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x040003A2 RID: 930
		<AccessedThroughProperty("Button7")>
		Private _Button7 As Button

		' Token: 0x040003A3 RID: 931
		<AccessedThroughProperty("Button8")>
		Private _Button8 As Button

		' Token: 0x040003A4 RID: 932
		<AccessedThroughProperty("Button9")>
		Private _Button9 As Button

		' Token: 0x040003A5 RID: 933
		<AccessedThroughProperty("Timer2")>
		Private _Timer2 As Timer

		' Token: 0x040003A6 RID: 934
		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel

		' Token: 0x040003A7 RID: 935
		<AccessedThroughProperty("WebBrowser1")>
		Private _WebBrowser1 As WebBrowser

		' Token: 0x040003A8 RID: 936
		Private mouse_move As Point
	End Class
End Namespace
