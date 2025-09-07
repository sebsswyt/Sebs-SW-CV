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
	' Token: 0x02000063 RID: 99
	<DesignerGenerated()>
	Public Partial Class Form51
		Inherits Form

		' Token: 0x060010CE RID: 4302 RVA: 0x03DE9484 File Offset: 0x03DE7884
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form51_Load
			Dim _ENCList As List(Of WeakReference) = Form51.__ENCList
			SyncLock _ENCList
				Form51.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700058C RID: 1420
		' (get) Token: 0x060010D1 RID: 4305 RVA: 0x03DEA0F8 File Offset: 0x03DE84F8
		' (set) Token: 0x060010D2 RID: 4306 RVA: 0x03DEA110 File Offset: 0x03DE8510
		Friend Overridable Property TextBox1 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox1 = value
			End Set
		End Property

		' Token: 0x1700058D RID: 1421
		' (get) Token: 0x060010D3 RID: 4307 RVA: 0x03DEA11C File Offset: 0x03DE851C
		' (set) Token: 0x060010D4 RID: 4308 RVA: 0x03DEA134 File Offset: 0x03DE8534
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

		' Token: 0x1700058E RID: 1422
		' (get) Token: 0x060010D5 RID: 4309 RVA: 0x03DEA140 File Offset: 0x03DE8540
		' (set) Token: 0x060010D6 RID: 4310 RVA: 0x03DEA158 File Offset: 0x03DE8558
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

		' Token: 0x1700058F RID: 1423
		' (get) Token: 0x060010D7 RID: 4311 RVA: 0x03DEA164 File Offset: 0x03DE8564
		' (set) Token: 0x060010D8 RID: 4312 RVA: 0x03DEA17C File Offset: 0x03DE857C
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

		' Token: 0x17000590 RID: 1424
		' (get) Token: 0x060010D9 RID: 4313 RVA: 0x03DEA1DC File Offset: 0x03DE85DC
		' (set) Token: 0x060010DA RID: 4314 RVA: 0x03DEA1F4 File Offset: 0x03DE85F4
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

		' Token: 0x17000591 RID: 1425
		' (get) Token: 0x060010DB RID: 4315 RVA: 0x03DEA254 File Offset: 0x03DE8654
		' (set) Token: 0x060010DC RID: 4316 RVA: 0x03DEA26C File Offset: 0x03DE866C
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

		' Token: 0x17000592 RID: 1426
		' (get) Token: 0x060010DD RID: 4317 RVA: 0x03DEA2F4 File Offset: 0x03DE86F4
		' (set) Token: 0x060010DE RID: 4318 RVA: 0x03DEA30C File Offset: 0x03DE870C
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

		' Token: 0x17000593 RID: 1427
		' (get) Token: 0x060010DF RID: 4319 RVA: 0x03DEA36C File Offset: 0x03DE876C
		' (set) Token: 0x060010E0 RID: 4320 RVA: 0x03DEA384 File Offset: 0x03DE8784
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

		' Token: 0x17000594 RID: 1428
		' (get) Token: 0x060010E1 RID: 4321 RVA: 0x03DEA3E4 File Offset: 0x03DE87E4
		' (set) Token: 0x060010E2 RID: 4322 RVA: 0x03DEA3FC File Offset: 0x03DE87FC
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

		' Token: 0x17000595 RID: 1429
		' (get) Token: 0x060010E3 RID: 4323 RVA: 0x03DEA45C File Offset: 0x03DE885C
		' (set) Token: 0x060010E4 RID: 4324 RVA: 0x03DEA474 File Offset: 0x03DE8874
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

		' Token: 0x17000596 RID: 1430
		' (get) Token: 0x060010E5 RID: 4325 RVA: 0x03DEA4D4 File Offset: 0x03DE88D4
		' (set) Token: 0x060010E6 RID: 4326 RVA: 0x03DEA4EC File Offset: 0x03DE88EC
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

		' Token: 0x17000597 RID: 1431
		' (get) Token: 0x060010E7 RID: 4327 RVA: 0x03DEA54C File Offset: 0x03DE894C
		' (set) Token: 0x060010E8 RID: 4328 RVA: 0x03DEA564 File Offset: 0x03DE8964
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

		' Token: 0x17000598 RID: 1432
		' (get) Token: 0x060010E9 RID: 4329 RVA: 0x03DEA5C4 File Offset: 0x03DE89C4
		' (set) Token: 0x060010EA RID: 4330 RVA: 0x03DEA5DC File Offset: 0x03DE89DC
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

		' Token: 0x17000599 RID: 1433
		' (get) Token: 0x060010EB RID: 4331 RVA: 0x03DEA63C File Offset: 0x03DE8A3C
		' (set) Token: 0x060010EC RID: 4332 RVA: 0x03DEA654 File Offset: 0x03DE8A54
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

		' Token: 0x060010ED RID: 4333 RVA: 0x03DEA6B4 File Offset: 0x03DE8AB4
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Interaction.MsgBox("Not on Add list", MsgBoxStyle.Information, Nothing)
		End Sub

		' Token: 0x060010EE RID: 4334 RVA: 0x03DEA6C8 File Offset: 0x03DE8AC8
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.TextBox1.Text, "", False) = 0
			Dim flag2 As Boolean
			If flag Then
				Interaction.MsgBox("Sorry Ned 1 Character", MsgBoxStyle.OkOnly, Nothing)
			Else
				flag = Operators.CompareString(Me.TextBox1.Text, "CVExplorer.exe", False) = 0
				If flag Then
					flag2 = MyProject.Forms.form1Pad.FormBorderStyle = FormBorderStyle.Sizable
					If flag2 Then
						MyProject.Forms.form1Pad.FormBorderStyle = FormBorderStyle.None
					Else
						MyProject.Forms.form1Pad.FormBorderStyle = FormBorderStyle.Sizable
					End If
				Else
					MyProject.Forms.form1Pad.Username1.Text = Me.TextBox1.Text
				End If
			End If
			flag2 = MyProject.Forms.Form1.Panel3.Visible
			If flag2 Then
			End If
		End Sub

		' Token: 0x060010EF RID: 4335 RVA: 0x03DEA79C File Offset: 0x03DE8B9C
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x060010F0 RID: 4336 RVA: 0x03DEA7A8 File Offset: 0x03DE8BA8
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x060010F1 RID: 4337 RVA: 0x03DEA7B4 File Offset: 0x03DE8BB4
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.WindowState = FormWindowState.Normal
			If flag Then
				Me.WindowState = FormWindowState.Maximized
			Else
				Me.WindowState = FormWindowState.Normal
			End If
		End Sub

		' Token: 0x060010F2 RID: 4338 RVA: 0x03DEA7E4 File Offset: 0x03DE8BE4
		Private Sub Form51_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060010F3 RID: 4339 RVA: 0x03DEA7E8 File Offset: 0x03DE8BE8
		Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs)
			' The following expression was wrapped in a checked-expression
			Me.mouse_move = New Point(0 - e.X, 0 - e.Y)
		End Sub

		' Token: 0x060010F4 RID: 4340 RVA: 0x03DEA808 File Offset: 0x03DE8C08
		Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = e.Button = MouseButtons.Left
			If flag Then
				Dim mousePosition As Point = Control.MousePosition
				mousePosition.Offset(Me.mouse_move.X, Me.mouse_move.Y)
				Me.Location = mousePosition
			End If
		End Sub

		' Token: 0x060010F5 RID: 4341 RVA: 0x03DEA858 File Offset: 0x03DE8C58
		Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060010F6 RID: 4342 RVA: 0x03DEA85C File Offset: 0x03DE8C5C
		Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060010F7 RID: 4343 RVA: 0x03DEA860 File Offset: 0x03DE8C60
		Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060010F8 RID: 4344 RVA: 0x03DEA864 File Offset: 0x03DE8C64
		Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060010F9 RID: 4345 RVA: 0x03DEA868 File Offset: 0x03DE8C68
		Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060010FA RID: 4346 RVA: 0x03DEA86C File Offset: 0x03DE8C6C
		Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060010FB RID: 4347 RVA: 0x03DEA870 File Offset: 0x03DE8C70
		Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060010FC RID: 4348 RVA: 0x03DEA874 File Offset: 0x03DE8C74
		Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060010FD RID: 4349 RVA: 0x03DEA878 File Offset: 0x03DE8C78
		Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060010FE RID: 4350 RVA: 0x03DEA87C File Offset: 0x03DE8C7C
		Private Sub Button6_Click(sender As Object, e As EventArgs)
			Me.TextBox1.Text = MyProject.Forms.Form60.TextBox1.Text
		End Sub

		' Token: 0x060010FF RID: 4351 RVA: 0x03DEA8A0 File Offset: 0x03DE8CA0
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Dim visible As Boolean = MyProject.Forms.Form60.Button1.Visible
			If visible Then
				Me.Button6.Visible = True
			Else
				Me.Button6.Visible = False
			End If
			Me.Panel2.BackColor = MyProject.Forms.Form_1pad.Panel1.BackColor
			Me.Panel1.BackColor = MyProject.Forms.Form_1pad.Panel1.BackColor
		End Sub

		' Token: 0x06001100 RID: 4352 RVA: 0x03DEA928 File Offset: 0x03DE8D28
		Private Sub Button7_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form22.Show()
		End Sub

		' Token: 0x06001101 RID: 4353 RVA: 0x03DEA93C File Offset: 0x03DE8D3C
		Private Sub Button8_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form20.Show()
		End Sub

		' Token: 0x06001102 RID: 4354 RVA: 0x03DEA950 File Offset: 0x03DE8D50
		Private Sub Button9_Click(sender As Object, e As EventArgs)
			Dim visible As Boolean = MyProject.Forms.Form_1pad.Label1.Visible
			If visible Then
				MyProject.Forms.Form21.Show()
			Else
				MyProject.Forms.Form43.Show()
			End If
		End Sub

		' Token: 0x0400063B RID: 1595
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400063D RID: 1597
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x0400063E RID: 1598
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x0400063F RID: 1599
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x04000640 RID: 1600
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000641 RID: 1601
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x04000642 RID: 1602
		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel

		' Token: 0x04000643 RID: 1603
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x04000644 RID: 1604
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x04000645 RID: 1605
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x04000646 RID: 1606
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x04000647 RID: 1607
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x04000648 RID: 1608
		<AccessedThroughProperty("Button9")>
		Private _Button9 As Button

		' Token: 0x04000649 RID: 1609
		<AccessedThroughProperty("Button8")>
		Private _Button8 As Button

		' Token: 0x0400064A RID: 1610
		<AccessedThroughProperty("Button7")>
		Private _Button7 As Button

		' Token: 0x0400064B RID: 1611
		Private mouse_move As Point
	End Class
End Namespace
