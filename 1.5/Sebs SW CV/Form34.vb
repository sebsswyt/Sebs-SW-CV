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
	' Token: 0x02000050 RID: 80
	<DesignerGenerated()>
	Public Partial Class Form34
		Inherits Form

		' Token: 0x06000D6E RID: 3438 RVA: 0x03DD1E08 File Offset: 0x03DD0208
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Form34.__ENCList
			SyncLock _ENCList
				Form34.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000478 RID: 1144
		' (get) Token: 0x06000D71 RID: 3441 RVA: 0x03DD28B8 File Offset: 0x03DD0CB8
		' (set) Token: 0x06000D72 RID: 3442 RVA: 0x03DD28D0 File Offset: 0x03DD0CD0
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

		' Token: 0x17000479 RID: 1145
		' (get) Token: 0x06000D73 RID: 3443 RVA: 0x03DD2930 File Offset: 0x03DD0D30
		' (set) Token: 0x06000D74 RID: 3444 RVA: 0x03DD2948 File Offset: 0x03DD0D48
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

		' Token: 0x1700047A RID: 1146
		' (get) Token: 0x06000D75 RID: 3445 RVA: 0x03DD29A8 File Offset: 0x03DD0DA8
		' (set) Token: 0x06000D76 RID: 3446 RVA: 0x03DD29C0 File Offset: 0x03DD0DC0
		Friend Overridable Property Panalon As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Panalon
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Panalon_Click
				Dim flag As Boolean = Me._Panalon IsNot Nothing
				If flag Then
					RemoveHandler Me._Panalon.Click, eventHandler
				End If
				Me._Panalon = value
				flag = Me._Panalon IsNot Nothing
				If flag Then
					AddHandler Me._Panalon.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700047B RID: 1147
		' (get) Token: 0x06000D77 RID: 3447 RVA: 0x03DD2A20 File Offset: 0x03DD0E20
		' (set) Token: 0x06000D78 RID: 3448 RVA: 0x03DD2A38 File Offset: 0x03DD0E38
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

		' Token: 0x1700047C RID: 1148
		' (get) Token: 0x06000D79 RID: 3449 RVA: 0x03DD2A44 File Offset: 0x03DD0E44
		' (set) Token: 0x06000D7A RID: 3450 RVA: 0x03DD2A5C File Offset: 0x03DD0E5C
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

		' Token: 0x1700047D RID: 1149
		' (get) Token: 0x06000D7B RID: 3451 RVA: 0x03DD2ABC File Offset: 0x03DD0EBC
		' (set) Token: 0x06000D7C RID: 3452 RVA: 0x03DD2AD4 File Offset: 0x03DD0ED4
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

		' Token: 0x1700047E RID: 1150
		' (get) Token: 0x06000D7D RID: 3453 RVA: 0x03DD2B34 File Offset: 0x03DD0F34
		' (set) Token: 0x06000D7E RID: 3454 RVA: 0x03DD2B4C File Offset: 0x03DD0F4C
		Friend Overridable Property Button6 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button6_Click
				Dim eventHandler2 As EventHandler = AddressOf Me.Button6_MouseEnter
				Dim flag As Boolean = Me._Button6 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button6.Click, eventHandler
					RemoveHandler Me._Button6.MouseEnter, eventHandler2
				End If
				Me._Button6 = value
				flag = Me._Button6 IsNot Nothing
				If flag Then
					AddHandler Me._Button6.Click, eventHandler
					AddHandler Me._Button6.MouseEnter, eventHandler2
				End If
			End Set
		End Property

		' Token: 0x1700047F RID: 1151
		' (get) Token: 0x06000D7F RID: 3455 RVA: 0x03DD2BD4 File Offset: 0x03DD0FD4
		' (set) Token: 0x06000D80 RID: 3456 RVA: 0x03DD2BEC File Offset: 0x03DD0FEC
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

		' Token: 0x17000480 RID: 1152
		' (get) Token: 0x06000D81 RID: 3457 RVA: 0x03DD2C4C File Offset: 0x03DD104C
		' (set) Token: 0x06000D82 RID: 3458 RVA: 0x03DD2C64 File Offset: 0x03DD1064
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

		' Token: 0x17000481 RID: 1153
		' (get) Token: 0x06000D83 RID: 3459 RVA: 0x03DD2CEC File Offset: 0x03DD10EC
		' (set) Token: 0x06000D84 RID: 3460 RVA: 0x03DD2D04 File Offset: 0x03DD1104
		Friend Overridable Property PictureBox1 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox1_Click
				Dim flag As Boolean = Me._PictureBox1 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox1.Click, eventHandler
				End If
				Me._PictureBox1 = value
				flag = Me._PictureBox1 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox1.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000482 RID: 1154
		' (get) Token: 0x06000D85 RID: 3461 RVA: 0x03DD2D64 File Offset: 0x03DD1164
		' (set) Token: 0x06000D86 RID: 3462 RVA: 0x03DD2D7C File Offset: 0x03DD117C
		Friend Overridable Property PictureBox2 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox2_Click
				Dim flag As Boolean = Me._PictureBox2 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox2.Click, eventHandler
				End If
				Me._PictureBox2 = value
				flag = Me._PictureBox2 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox2.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000483 RID: 1155
		' (get) Token: 0x06000D87 RID: 3463 RVA: 0x03DD2DDC File Offset: 0x03DD11DC
		' (set) Token: 0x06000D88 RID: 3464 RVA: 0x03DD2DF4 File Offset: 0x03DD11F4
		Friend Overridable Property PictureBox4 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox4_Click
				Dim flag As Boolean = Me._PictureBox4 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox4.Click, eventHandler
				End If
				Me._PictureBox4 = value
				flag = Me._PictureBox4 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox4.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000484 RID: 1156
		' (get) Token: 0x06000D89 RID: 3465 RVA: 0x03DD2E54 File Offset: 0x03DD1254
		' (set) Token: 0x06000D8A RID: 3466 RVA: 0x03DD2E6C File Offset: 0x03DD126C
		Friend Overridable Property PictureBox3 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox3_Click
				Dim flag As Boolean = Me._PictureBox3 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox3.Click, eventHandler
				End If
				Me._PictureBox3 = value
				flag = Me._PictureBox3 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox3.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x06000D8B RID: 3467 RVA: 0x03DD2ECC File Offset: 0x03DD12CC
		Private Sub Panalon_Click(sender As Object, e As EventArgs)
			Me.Panel1.Visible = True
			Me.Panalon.Visible = False
		End Sub

		' Token: 0x06000D8C RID: 3468 RVA: 0x03DD2EEC File Offset: 0x03DD12EC
		Private Sub Panaloff_Click(sender As Object, e As EventArgs)
			Me.Panel1.Visible = False
			Me.Panalon.Visible = True
		End Sub

		' Token: 0x06000D8D RID: 3469 RVA: 0x03DD2F0C File Offset: 0x03DD130C
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.Panel1.Visible = False
			MyProject.Forms.Form1.Panel3.Visible = False
			MyProject.Forms.Form1.Panel4.Visible = False
			MyProject.Forms.Form1.Panel5.Visible = False
		End Sub

		' Token: 0x06000D8E RID: 3470 RVA: 0x03DD2F74 File Offset: 0x03DD1374
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.Panel1.Visible = True
			MyProject.Forms.Form1.Panel4.Visible = False
			MyProject.Forms.Form1.Panel5.Visible = False
			MyProject.Forms.Form2.Close()
		End Sub

		' Token: 0x06000D8F RID: 3471 RVA: 0x03DD2FD8 File Offset: 0x03DD13D8
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.Panel1.Visible = False
			MyProject.Forms.Form1.Panel3.Visible = False
			MyProject.Forms.Form1.Panel4.Visible = False
			MyProject.Forms.Form1.Panel5.Visible = False
		End Sub

		' Token: 0x06000D90 RID: 3472 RVA: 0x03DD3040 File Offset: 0x03DD1440
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.Panel1.Visible = True
			MyProject.Forms.Form2.Close()
			MyProject.Forms.Form1.Panel4.Visible = False
			MyProject.Forms.Form1.Panel5.Visible = False
		End Sub

		' Token: 0x06000D91 RID: 3473 RVA: 0x03DD30A4 File Offset: 0x03DD14A4
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.Panel1.Visible = False
			MyProject.Forms.Form1.Panel4.Visible = True
			MyProject.Forms.Form1.Panel3.Visible = False
			MyProject.Forms.Form2.Close()
		End Sub

		' Token: 0x06000D92 RID: 3474 RVA: 0x03DD3108 File Offset: 0x03DD1508
		Private Sub Button6_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.Panel1.Visible = False
			MyProject.Forms.Form1.Panel4.Visible = True
			MyProject.Forms.Form1.Panel3.Visible = False
			MyProject.Forms.Form2.Close()
		End Sub

		' Token: 0x06000D93 RID: 3475 RVA: 0x03DD316C File Offset: 0x03DD156C
		Private Sub Button6_MouseEnter(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000D94 RID: 3476 RVA: 0x03DD3170 File Offset: 0x03DD1570
		Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
			Me.Panalon.Visible = True
			Me.Button1.Visible = True
			Me.Button2.Visible = True
			Me.Button5.Visible = True
		End Sub

		' Token: 0x06000D95 RID: 3477 RVA: 0x03DD31A8 File Offset: 0x03DD15A8
		Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000D96 RID: 3478 RVA: 0x03DD31B4 File Offset: 0x03DD15B4
		Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.WindowState = FormWindowState.Normal
			If flag Then
				Me.WindowState = FormWindowState.Maximized
			Else
				Me.WindowState = FormWindowState.Normal
			End If
		End Sub

		' Token: 0x06000D97 RID: 3479 RVA: 0x03DD31E4 File Offset: 0x03DD15E4
		Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x06000D98 RID: 3480 RVA: 0x03DD31F0 File Offset: 0x03DD15F0
		Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs)
			' The following expression was wrapped in a checked-expression
			Me.mouse_move = New Point(0 - e.X, 0 - e.Y)
		End Sub

		' Token: 0x06000D99 RID: 3481 RVA: 0x03DD3210 File Offset: 0x03DD1610
		Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = e.Button = MouseButtons.Left
			If flag Then
				Dim mousePosition As Point = Control.MousePosition
				mousePosition.Offset(Me.mouse_move.X, Me.mouse_move.Y)
				Me.Location = mousePosition
			End If
		End Sub

		' Token: 0x040004FA RID: 1274
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040004FC RID: 1276
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040004FD RID: 1277
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x040004FE RID: 1278
		<AccessedThroughProperty("Panalon")>
		Private _Panalon As Button

		' Token: 0x040004FF RID: 1279
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x04000500 RID: 1280
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x04000501 RID: 1281
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x04000502 RID: 1282
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x04000503 RID: 1283
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x04000504 RID: 1284
		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel

		' Token: 0x04000505 RID: 1285
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x04000506 RID: 1286
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x04000507 RID: 1287
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x04000508 RID: 1288
		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		' Token: 0x04000509 RID: 1289
		Private mouse_move As Point
	End Class
End Namespace
