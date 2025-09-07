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
	' Token: 0x02000062 RID: 98
	<DesignerGenerated()>
	Public Partial Class Form50
		Inherits Form

		' Token: 0x0600109B RID: 4251 RVA: 0x03DE8128 File Offset: 0x03DE6528
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form50_Load
			Dim _ENCList As List(Of WeakReference) = Form50.__ENCList
			SyncLock _ENCList
				Form50.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700057A RID: 1402
		' (get) Token: 0x0600109E RID: 4254 RVA: 0x03DE89E4 File Offset: 0x03DE6DE4
		' (set) Token: 0x0600109F RID: 4255 RVA: 0x03DE89FC File Offset: 0x03DE6DFC
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

		' Token: 0x1700057B RID: 1403
		' (get) Token: 0x060010A0 RID: 4256 RVA: 0x03DE8A5C File Offset: 0x03DE6E5C
		' (set) Token: 0x060010A1 RID: 4257 RVA: 0x03DE8A74 File Offset: 0x03DE6E74
		Friend Overridable Property Panel1 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.Panel1_MouseDown
				Dim mouseEventHandler2 As MouseEventHandler = AddressOf Me.Panel1_MouseMove
				Dim flag As Boolean = Me._Panel1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Panel1.MouseDown, mouseEventHandler
					RemoveHandler Me._Panel1.MouseMove, mouseEventHandler2
				End If
				Me._Panel1 = value
				flag = Me._Panel1 IsNot Nothing
				If flag Then
					AddHandler Me._Panel1.MouseDown, mouseEventHandler
					AddHandler Me._Panel1.MouseMove, mouseEventHandler2
				End If
			End Set
		End Property

		' Token: 0x1700057C RID: 1404
		' (get) Token: 0x060010A2 RID: 4258 RVA: 0x03DE8AFC File Offset: 0x03DE6EFC
		' (set) Token: 0x060010A3 RID: 4259 RVA: 0x03DE8B14 File Offset: 0x03DE6F14
		Friend Overridable Property Panel2 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel2 = value
			End Set
		End Property

		' Token: 0x1700057D RID: 1405
		' (get) Token: 0x060010A4 RID: 4260 RVA: 0x03DE8B20 File Offset: 0x03DE6F20
		' (set) Token: 0x060010A5 RID: 4261 RVA: 0x03DE8B38 File Offset: 0x03DE6F38
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

		' Token: 0x1700057E RID: 1406
		' (get) Token: 0x060010A6 RID: 4262 RVA: 0x03DE8B98 File Offset: 0x03DE6F98
		' (set) Token: 0x060010A7 RID: 4263 RVA: 0x03DE8BB0 File Offset: 0x03DE6FB0
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

		' Token: 0x1700057F RID: 1407
		' (get) Token: 0x060010A8 RID: 4264 RVA: 0x03DE8C10 File Offset: 0x03DE7010
		' (set) Token: 0x060010A9 RID: 4265 RVA: 0x03DE8C28 File Offset: 0x03DE7028
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

		' Token: 0x17000580 RID: 1408
		' (get) Token: 0x060010AA RID: 4266 RVA: 0x03DE8C88 File Offset: 0x03DE7088
		' (set) Token: 0x060010AB RID: 4267 RVA: 0x03DE8CA0 File Offset: 0x03DE70A0
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

		' Token: 0x17000581 RID: 1409
		' (get) Token: 0x060010AC RID: 4268 RVA: 0x03DE8D00 File Offset: 0x03DE7100
		' (set) Token: 0x060010AD RID: 4269 RVA: 0x03DE8D18 File Offset: 0x03DE7118
		Friend Overridable Property OpenFileDialog1 As OpenFileDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenFileDialog1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As OpenFileDialog)
				Dim cancelEventHandler As CancelEventHandler = AddressOf Me.OpenFileDialog1_FileOk
				Dim flag As Boolean = Me._OpenFileDialog1 IsNot Nothing
				If flag Then
					RemoveHandler Me._OpenFileDialog1.FileOk, cancelEventHandler
				End If
				Me._OpenFileDialog1 = value
				flag = Me._OpenFileDialog1 IsNot Nothing
				If flag Then
					AddHandler Me._OpenFileDialog1.FileOk, cancelEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000582 RID: 1410
		' (get) Token: 0x060010AE RID: 4270 RVA: 0x03DE8D78 File Offset: 0x03DE7178
		' (set) Token: 0x060010AF RID: 4271 RVA: 0x03DE8D90 File Offset: 0x03DE7190
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

		' Token: 0x17000583 RID: 1411
		' (get) Token: 0x060010B0 RID: 4272 RVA: 0x03DE8D9C File Offset: 0x03DE719C
		' (set) Token: 0x060010B1 RID: 4273 RVA: 0x03DE8DB4 File Offset: 0x03DE71B4
		Friend Overridable Property one As OpenFileDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._one
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As OpenFileDialog)
				Dim cancelEventHandler As CancelEventHandler = AddressOf Me.one_FileOk
				Dim flag As Boolean = Me._one IsNot Nothing
				If flag Then
					RemoveHandler Me._one.FileOk, cancelEventHandler
				End If
				Me._one = value
				flag = Me._one IsNot Nothing
				If flag Then
					AddHandler Me._one.FileOk, cancelEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000584 RID: 1412
		' (get) Token: 0x060010B2 RID: 4274 RVA: 0x03DE8E14 File Offset: 0x03DE7214
		' (set) Token: 0x060010B3 RID: 4275 RVA: 0x03DE8E2C File Offset: 0x03DE722C
		Friend Overridable Property two As OpenFileDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._two
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As OpenFileDialog)
				Me._two = value
			End Set
		End Property

		' Token: 0x17000585 RID: 1413
		' (get) Token: 0x060010B4 RID: 4276 RVA: 0x03DE8E38 File Offset: 0x03DE7238
		' (set) Token: 0x060010B5 RID: 4277 RVA: 0x03DE8E50 File Offset: 0x03DE7250
		Friend Overridable Property three As OpenFileDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._three
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As OpenFileDialog)
				Me._three = value
			End Set
		End Property

		' Token: 0x17000586 RID: 1414
		' (get) Token: 0x060010B6 RID: 4278 RVA: 0x03DE8E5C File Offset: 0x03DE725C
		' (set) Token: 0x060010B7 RID: 4279 RVA: 0x03DE8E74 File Offset: 0x03DE7274
		Friend Overridable Property four As OpenFileDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._four
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As OpenFileDialog)
				Me._four = value
			End Set
		End Property

		' Token: 0x17000587 RID: 1415
		' (get) Token: 0x060010B8 RID: 4280 RVA: 0x03DE8E80 File Offset: 0x03DE7280
		' (set) Token: 0x060010B9 RID: 4281 RVA: 0x03DE8E98 File Offset: 0x03DE7298
		Friend Overridable Property five As OpenFileDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._five
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As OpenFileDialog)
				Me._five = value
			End Set
		End Property

		' Token: 0x17000588 RID: 1416
		' (get) Token: 0x060010BA RID: 4282 RVA: 0x03DE8EA4 File Offset: 0x03DE72A4
		' (set) Token: 0x060010BB RID: 4283 RVA: 0x03DE8EBC File Offset: 0x03DE72BC
		Friend Overridable Property six As OpenFileDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._six
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As OpenFileDialog)
				Me._six = value
			End Set
		End Property

		' Token: 0x17000589 RID: 1417
		' (get) Token: 0x060010BC RID: 4284 RVA: 0x03DE8EC8 File Offset: 0x03DE72C8
		' (set) Token: 0x060010BD RID: 4285 RVA: 0x03DE8EE0 File Offset: 0x03DE72E0
		Friend Overridable Property RichTextBox2 As RichTextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._RichTextBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Me._RichTextBox2 = value
			End Set
		End Property

		' Token: 0x1700058A RID: 1418
		' (get) Token: 0x060010BE RID: 4286 RVA: 0x03DE8EEC File Offset: 0x03DE72EC
		' (set) Token: 0x060010BF RID: 4287 RVA: 0x03DE8F04 File Offset: 0x03DE7304
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

		' Token: 0x1700058B RID: 1419
		' (get) Token: 0x060010C0 RID: 4288 RVA: 0x03DE8F64 File Offset: 0x03DE7364
		' (set) Token: 0x060010C1 RID: 4289 RVA: 0x03DE8F7C File Offset: 0x03DE737C
		Friend Overridable Property sev As OpenFileDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._sev
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As OpenFileDialog)
				Me._sev = value
			End Set
		End Property

		' Token: 0x060010C2 RID: 4290 RVA: 0x03DE8F88 File Offset: 0x03DE7388
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.FormBorderStyle = FormBorderStyle.None
			If flag Then
			End If
		End Sub

		' Token: 0x060010C3 RID: 4291 RVA: 0x03DE8FA8 File Offset: 0x03DE73A8
		Private Sub Form50_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060010C4 RID: 4292 RVA: 0x03DE8FAC File Offset: 0x03DE73AC
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x060010C5 RID: 4293 RVA: 0x03DE8FB8 File Offset: 0x03DE73B8
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.WindowState = FormWindowState.Normal
			If flag Then
				Me.WindowState = FormWindowState.Maximized
			Else
				Me.WindowState = FormWindowState.Normal
			End If
		End Sub

		' Token: 0x060010C6 RID: 4294 RVA: 0x03DE8FE8 File Offset: 0x03DE73E8
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x060010C7 RID: 4295 RVA: 0x03DE8FF4 File Offset: 0x03DE73F4
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.OpenFileDialog1.ShowDialog() = DialogResult.OK
			If flag Then
				Me.RichTextBox1.Text = MyProject.Computer.FileSystem.ReadAllText(Me.OpenFileDialog1.FileName)
				flag = Operators.CompareString(Me.RichTextBox1.Text, "id(15264326543=P1)", False) = 0
				Dim flag2 As Boolean
				If flag Then
					flag2 = Me.one.ShowDialog() = DialogResult.OK
					If flag2 Then
						Me.RichTextBox2.Text = Me.one.FileName
						MyProject.Forms.form1Pad.Picture1.Load(Me.RichTextBox2.Text)
						MyProject.Forms.Form49.Show()
						MyProject.Forms.Form49.PictureBox1.Image = MyProject.Forms.form1Pad.Picture1.Image
					End If
				End If
				flag2 = Operators.CompareString(Me.RichTextBox1.Text, "id(152423235343=P2)", False) = 0
				If flag2 Then
					flag = Me.two.ShowDialog() = DialogResult.OK
					If flag Then
						Me.RichTextBox2.Text = Me.two.FileName
						MyProject.Forms.form1Pad.Picture2.Load(Me.RichTextBox2.Text)
						MyProject.Forms.Form49.PictureBox2.Image = MyProject.Forms.form1Pad.Picture2.Image
					End If
				End If
				flag2 = Operators.CompareString(Me.RichTextBox1.Text, "id(1593490575343=P3)", False) = 0
				If flag2 Then
					flag = Me.three.ShowDialog() = DialogResult.OK
					If flag Then
						Me.RichTextBox2.Text = Me.three.FileName
						MyProject.Forms.form1Pad.Picture3.Load(Me.RichTextBox2.Text)
						MyProject.Forms.Form49.PictureBox3.Image = MyProject.Forms.form1Pad.Picture3.Image
					End If
				End If
				flag2 = Operators.CompareString(Me.RichTextBox1.Text, "id(159343467953=P4)", False) = 0
				If flag2 Then
					flag = Me.four.ShowDialog() = DialogResult.OK
					If flag Then
						Me.RichTextBox2.Text = Me.four.FileName
						MyProject.Forms.form1Pad.Picture4.Load(Me.RichTextBox2.Text)
						MyProject.Forms.Form49.PictureBox4.Image = MyProject.Forms.form1Pad.Picture4.Image
					End If
				End If
				flag2 = Operators.CompareString(Me.RichTextBox1.Text, "id(157358323=P5)", False) = 0
				If flag2 Then
					flag = Me.five.ShowDialog() = DialogResult.OK
					If flag Then
						Me.RichTextBox2.Text = Me.five.FileName
						MyProject.Forms.form1Pad.Picture5.Load(Me.RichTextBox2.Text)
						MyProject.Forms.Form49.PictureBox5.Image = MyProject.Forms.form1Pad.Picture5.Image
					End If
				End If
				flag2 = Operators.CompareString(Me.RichTextBox1.Text, "B6-c", False) = 0
				If flag2 Then
					MyProject.Forms.Form43.Show()
				End If
				flag2 = Operators.CompareString(Me.RichTextBox1.Text, "id(15345213=P7)", False) = 0
				If flag2 Then
					flag = Me.sev.ShowDialog() = DialogResult.OK
					If flag Then
						Me.RichTextBox2.Text = Me.sev.FileName
						MyProject.Forms.form1Pad.Picture7.Load(Me.RichTextBox2.Text)
						MyProject.Forms.Form49.PictureBox7.Image = MyProject.Forms.form1Pad.Picture7.Image
					End If
				End If
			End If
		End Sub

		' Token: 0x060010C8 RID: 4296 RVA: 0x03DE93E8 File Offset: 0x03DE77E8
		Private Sub OpenFileDialog1_FileOk(sender As Object, e As CancelEventArgs)
		End Sub

		' Token: 0x060010C9 RID: 4297 RVA: 0x03DE93EC File Offset: 0x03DE77EC
		Private Sub one_FileOk(sender As Object, e As CancelEventArgs)
		End Sub

		' Token: 0x060010CA RID: 4298 RVA: 0x03DE93F0 File Offset: 0x03DE77F0
		Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs)
			' The following expression was wrapped in a checked-expression
			Me.mouse_move = New Point(0 - e.X, 0 - e.Y)
		End Sub

		' Token: 0x060010CB RID: 4299 RVA: 0x03DE9410 File Offset: 0x03DE7810
		Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = e.Button = MouseButtons.Left
			If flag Then
				Dim mousePosition As Point = Control.MousePosition
				mousePosition.Offset(Me.mouse_move.X, Me.mouse_move.Y)
				Me.Location = mousePosition
			End If
		End Sub

		' Token: 0x060010CC RID: 4300 RVA: 0x03DE9460 File Offset: 0x03DE7860
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form43.Show()
		End Sub

		' Token: 0x04000626 RID: 1574
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000628 RID: 1576
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x04000629 RID: 1577
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x0400062A RID: 1578
		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel

		' Token: 0x0400062B RID: 1579
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x0400062C RID: 1580
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x0400062D RID: 1581
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400062E RID: 1582
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x0400062F RID: 1583
		<AccessedThroughProperty("OpenFileDialog1")>
		Private _OpenFileDialog1 As OpenFileDialog

		' Token: 0x04000630 RID: 1584
		<AccessedThroughProperty("RichTextBox1")>
		Private _RichTextBox1 As RichTextBox

		' Token: 0x04000631 RID: 1585
		<AccessedThroughProperty("one")>
		Private _one As OpenFileDialog

		' Token: 0x04000632 RID: 1586
		<AccessedThroughProperty("two")>
		Private _two As OpenFileDialog

		' Token: 0x04000633 RID: 1587
		<AccessedThroughProperty("three")>
		Private _three As OpenFileDialog

		' Token: 0x04000634 RID: 1588
		<AccessedThroughProperty("four")>
		Private _four As OpenFileDialog

		' Token: 0x04000635 RID: 1589
		<AccessedThroughProperty("five")>
		Private _five As OpenFileDialog

		' Token: 0x04000636 RID: 1590
		<AccessedThroughProperty("six")>
		Private _six As OpenFileDialog

		' Token: 0x04000637 RID: 1591
		<AccessedThroughProperty("RichTextBox2")>
		Private _RichTextBox2 As RichTextBox

		' Token: 0x04000638 RID: 1592
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x04000639 RID: 1593
		<AccessedThroughProperty("sev")>
		Private _sev As OpenFileDialog

		' Token: 0x0400063A RID: 1594
		Private mouse_move As Point
	End Class
End Namespace
