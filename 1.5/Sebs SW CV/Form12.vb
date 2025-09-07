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
	' Token: 0x02000036 RID: 54
	<DesignerGenerated()>
	Public Partial Class Form12
		Inherits Form

		' Token: 0x06000600 RID: 1536 RVA: 0x03D9F030 File Offset: 0x03D9D430
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Form12.__ENCList
			SyncLock _ENCList
				Form12.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170001FF RID: 511
		' (get) Token: 0x06000603 RID: 1539 RVA: 0x03D9FD5C File Offset: 0x03D9E15C
		' (set) Token: 0x06000604 RID: 1540 RVA: 0x03D9FD74 File Offset: 0x03D9E174
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

		' Token: 0x17000200 RID: 512
		' (get) Token: 0x06000605 RID: 1541 RVA: 0x03D9FDD4 File Offset: 0x03D9E1D4
		' (set) Token: 0x06000606 RID: 1542 RVA: 0x03D9FDEC File Offset: 0x03D9E1EC
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

		' Token: 0x17000201 RID: 513
		' (get) Token: 0x06000607 RID: 1543 RVA: 0x03D9FE4C File Offset: 0x03D9E24C
		' (set) Token: 0x06000608 RID: 1544 RVA: 0x03D9FE64 File Offset: 0x03D9E264
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

		' Token: 0x17000202 RID: 514
		' (get) Token: 0x06000609 RID: 1545 RVA: 0x03D9FEC4 File Offset: 0x03D9E2C4
		' (set) Token: 0x0600060A RID: 1546 RVA: 0x03D9FEDC File Offset: 0x03D9E2DC
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

		' Token: 0x17000203 RID: 515
		' (get) Token: 0x0600060B RID: 1547 RVA: 0x03D9FF3C File Offset: 0x03D9E33C
		' (set) Token: 0x0600060C RID: 1548 RVA: 0x03D9FF54 File Offset: 0x03D9E354
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

		' Token: 0x17000204 RID: 516
		' (get) Token: 0x0600060D RID: 1549 RVA: 0x03D9FFB4 File Offset: 0x03D9E3B4
		' (set) Token: 0x0600060E RID: 1550 RVA: 0x03D9FFCC File Offset: 0x03D9E3CC
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

		' Token: 0x17000205 RID: 517
		' (get) Token: 0x0600060F RID: 1551 RVA: 0x03DA002C File Offset: 0x03D9E42C
		' (set) Token: 0x06000610 RID: 1552 RVA: 0x03DA0044 File Offset: 0x03D9E444
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

		' Token: 0x17000206 RID: 518
		' (get) Token: 0x06000611 RID: 1553 RVA: 0x03DA00A4 File Offset: 0x03D9E4A4
		' (set) Token: 0x06000612 RID: 1554 RVA: 0x03DA00BC File Offset: 0x03D9E4BC
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

		' Token: 0x17000207 RID: 519
		' (get) Token: 0x06000613 RID: 1555 RVA: 0x03DA00C8 File Offset: 0x03D9E4C8
		' (set) Token: 0x06000614 RID: 1556 RVA: 0x03DA00E0 File Offset: 0x03D9E4E0
		Friend Overridable Property PictureBox3 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox3 = value
			End Set
		End Property

		' Token: 0x17000208 RID: 520
		' (get) Token: 0x06000615 RID: 1557 RVA: 0x03DA00EC File Offset: 0x03D9E4EC
		' (set) Token: 0x06000616 RID: 1558 RVA: 0x03DA0104 File Offset: 0x03D9E504
		Friend Overridable Property PictureBox4 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox4 = value
			End Set
		End Property

		' Token: 0x17000209 RID: 521
		' (get) Token: 0x06000617 RID: 1559 RVA: 0x03DA0110 File Offset: 0x03D9E510
		' (set) Token: 0x06000618 RID: 1560 RVA: 0x03DA0128 File Offset: 0x03D9E528
		Friend Overridable Property PictureBox5 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox5 = value
			End Set
		End Property

		' Token: 0x1700020A RID: 522
		' (get) Token: 0x06000619 RID: 1561 RVA: 0x03DA0134 File Offset: 0x03D9E534
		' (set) Token: 0x0600061A RID: 1562 RVA: 0x03DA014C File Offset: 0x03D9E54C
		Friend Overridable Property PictureBox6 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox6 = value
			End Set
		End Property

		' Token: 0x1700020B RID: 523
		' (get) Token: 0x0600061B RID: 1563 RVA: 0x03DA0158 File Offset: 0x03D9E558
		' (set) Token: 0x0600061C RID: 1564 RVA: 0x03DA0170 File Offset: 0x03D9E570
		Friend Overridable Property PictureBox7 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox7 = value
			End Set
		End Property

		' Token: 0x1700020C RID: 524
		' (get) Token: 0x0600061D RID: 1565 RVA: 0x03DA017C File Offset: 0x03D9E57C
		' (set) Token: 0x0600061E RID: 1566 RVA: 0x03DA0194 File Offset: 0x03D9E594
		Friend Overridable Property PictureBox8 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox8 = value
			End Set
		End Property

		' Token: 0x1700020D RID: 525
		' (get) Token: 0x0600061F RID: 1567 RVA: 0x03DA01A0 File Offset: 0x03D9E5A0
		' (set) Token: 0x06000620 RID: 1568 RVA: 0x03DA01B8 File Offset: 0x03D9E5B8
		Friend Overridable Property Button10 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button10_Click
				Dim flag As Boolean = Me._Button10 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button10.Click, eventHandler
				End If
				Me._Button10 = value
				flag = Me._Button10 IsNot Nothing
				If flag Then
					AddHandler Me._Button10.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700020E RID: 526
		' (get) Token: 0x06000621 RID: 1569 RVA: 0x03DA0218 File Offset: 0x03D9E618
		' (set) Token: 0x06000622 RID: 1570 RVA: 0x03DA0230 File Offset: 0x03D9E630
		Friend Overridable Property PictureBox9 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox9 = value
			End Set
		End Property

		' Token: 0x1700020F RID: 527
		' (get) Token: 0x06000623 RID: 1571 RVA: 0x03DA023C File Offset: 0x03D9E63C
		' (set) Token: 0x06000624 RID: 1572 RVA: 0x03DA0254 File Offset: 0x03D9E654
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

		' Token: 0x17000210 RID: 528
		' (get) Token: 0x06000625 RID: 1573 RVA: 0x03DA0260 File Offset: 0x03D9E660
		' (set) Token: 0x06000626 RID: 1574 RVA: 0x03DA0278 File Offset: 0x03D9E678
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

		' Token: 0x06000627 RID: 1575 RVA: 0x03DA02D8 File Offset: 0x03D9E6D8
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox3.Show()
		End Sub

		' Token: 0x06000628 RID: 1576 RVA: 0x03DA02EC File Offset: 0x03D9E6EC
		Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000629 RID: 1577 RVA: 0x03DA02F0 File Offset: 0x03D9E6F0
		Private Sub CheckBox1_CheckStateChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600062A RID: 1578 RVA: 0x03DA02F4 File Offset: 0x03D9E6F4
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.PictureBox2.Visible = True
			MyProject.Forms.Form1.PictureBox3.Visible = False
			MyProject.Forms.Form1.PictureBox4.Visible = False
			MyProject.Forms.Form1.PictureBox5.Visible = False
			MyProject.Forms.Form1.PictureBox6.Visible = False
			MyProject.Forms.Form1.PictureBox7.Visible = False
			MyProject.Forms.Form1.PictureBox8.Visible = False
			MyProject.Forms.Form1.PictureBox9.Visible = False
		End Sub

		' Token: 0x0600062B RID: 1579 RVA: 0x03DA03B4 File Offset: 0x03D9E7B4
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.PictureBox2.Visible = False
			MyProject.Forms.Form1.PictureBox3.Visible = True
			MyProject.Forms.Form1.PictureBox4.Visible = False
			MyProject.Forms.Form1.PictureBox5.Visible = False
			MyProject.Forms.Form1.PictureBox6.Visible = False
			MyProject.Forms.Form1.PictureBox7.Visible = False
			MyProject.Forms.Form1.PictureBox8.Visible = False
			MyProject.Forms.Form1.PictureBox9.Visible = False
		End Sub

		' Token: 0x0600062C RID: 1580 RVA: 0x03DA0474 File Offset: 0x03D9E874
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.PictureBox2.Visible = False
			MyProject.Forms.Form1.PictureBox3.Visible = False
			MyProject.Forms.Form1.PictureBox4.Visible = True
			MyProject.Forms.Form1.PictureBox5.Visible = False
			MyProject.Forms.Form1.PictureBox6.Visible = False
			MyProject.Forms.Form1.PictureBox7.Visible = False
			MyProject.Forms.Form1.PictureBox8.Visible = False
			MyProject.Forms.Form1.PictureBox9.Visible = False
		End Sub

		' Token: 0x0600062D RID: 1581 RVA: 0x03DA0534 File Offset: 0x03D9E934
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.PictureBox2.Visible = False
			MyProject.Forms.Form1.PictureBox3.Visible = False
			MyProject.Forms.Form1.PictureBox4.Visible = False
			MyProject.Forms.Form1.PictureBox5.Visible = True
			MyProject.Forms.Form1.PictureBox6.Visible = False
			MyProject.Forms.Form1.PictureBox7.Visible = False
			MyProject.Forms.Form1.PictureBox8.Visible = False
			MyProject.Forms.Form1.PictureBox9.Visible = False
		End Sub

		' Token: 0x0600062E RID: 1582 RVA: 0x03DA05F4 File Offset: 0x03D9E9F4
		Private Sub Button6_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.PictureBox2.Visible = False
			MyProject.Forms.Form1.PictureBox3.Visible = False
			MyProject.Forms.Form1.PictureBox4.Visible = False
			MyProject.Forms.Form1.PictureBox5.Visible = False
			MyProject.Forms.Form1.PictureBox6.Visible = True
			MyProject.Forms.Form1.PictureBox7.Visible = False
			MyProject.Forms.Form1.PictureBox8.Visible = False
			MyProject.Forms.Form1.PictureBox9.Visible = False
		End Sub

		' Token: 0x0600062F RID: 1583 RVA: 0x03DA06B4 File Offset: 0x03D9EAB4
		Private Sub Button7_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.PictureBox2.Visible = False
			MyProject.Forms.Form1.PictureBox3.Visible = False
			MyProject.Forms.Form1.PictureBox4.Visible = False
			MyProject.Forms.Form1.PictureBox5.Visible = False
			MyProject.Forms.Form1.PictureBox6.Visible = False
			MyProject.Forms.Form1.PictureBox7.Visible = True
			MyProject.Forms.Form1.PictureBox8.Visible = False
			MyProject.Forms.Form1.PictureBox9.Visible = False
		End Sub

		' Token: 0x06000630 RID: 1584 RVA: 0x03DA0774 File Offset: 0x03D9EB74
		Private Sub Button8_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.PictureBox2.Visible = False
			MyProject.Forms.Form1.PictureBox3.Visible = False
			MyProject.Forms.Form1.PictureBox4.Visible = False
			MyProject.Forms.Form1.PictureBox5.Visible = False
			MyProject.Forms.Form1.PictureBox6.Visible = False
			MyProject.Forms.Form1.PictureBox7.Visible = False
			MyProject.Forms.Form1.PictureBox8.Visible = True
			MyProject.Forms.Form1.PictureBox9.Visible = False
		End Sub

		' Token: 0x06000631 RID: 1585 RVA: 0x03DA0834 File Offset: 0x03D9EC34
		Private Sub Button9_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.PictureBox1.Visible = False
			MyProject.Forms.Form1.PictureBox2.Visible = False
			MyProject.Forms.Form1.PictureBox3.Visible = False
			MyProject.Forms.Form1.PictureBox4.Visible = False
			MyProject.Forms.Form1.PictureBox5.Visible = False
			MyProject.Forms.Form1.PictureBox6.Visible = False
			MyProject.Forms.Form1.PictureBox7.Visible = False
			MyProject.Forms.Form1.PictureBox8.Visible = False
			MyProject.Forms.Form1.PictureBox9.Visible = False
			MyProject.Forms.Form1.Button1.Visible = False
			MyProject.Forms.Form1.Button2.Visible = False
			MyProject.Forms.Form1.Button3.Visible = False
			MyProject.Forms.Form1.Button4.Visible = False
			MyProject.Forms.Form1.Button7.Visible = False
			MyProject.Forms.Form1.Button10.Visible = False
			MyProject.Forms.Form2.Close()
			MyProject.Forms.Form3.Close()
			MyProject.Forms.Form4.Close()
			MyProject.Forms.Form5.Close()
			MyProject.Forms.Form6.Close()
			MyProject.Forms.Form7.Close()
			MyProject.Forms.Form8.Close()
			MyProject.Forms.Form9.Close()
			MyProject.Forms.Form10.Close()
			MyProject.Forms.Form11.Close()
			MyProject.Forms.Form13.Close()
			MyProject.Forms.Form14.Close()
			MyProject.Forms.Form1.Panel2.Visible = True
			Me.Close()
		End Sub

		' Token: 0x06000632 RID: 1586 RVA: 0x03DA0A6C File Offset: 0x03D9EE6C
		Private Sub Button10_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.PictureBox2.Visible = False
			MyProject.Forms.Form1.PictureBox3.Visible = False
			MyProject.Forms.Form1.PictureBox4.Visible = False
			MyProject.Forms.Form1.PictureBox5.Visible = False
			MyProject.Forms.Form1.PictureBox6.Visible = False
			MyProject.Forms.Form1.PictureBox7.Visible = False
			MyProject.Forms.Form1.PictureBox8.Visible = False
			MyProject.Forms.Form1.PictureBox9.Visible = True
		End Sub

		' Token: 0x06000633 RID: 1587 RVA: 0x03DA0B2C File Offset: 0x03D9EF2C
		Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form20.Show()
		End Sub

		' Token: 0x04000246 RID: 582
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000248 RID: 584
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x04000249 RID: 585
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x0400024A RID: 586
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x0400024B RID: 587
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x0400024C RID: 588
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x0400024D RID: 589
		<AccessedThroughProperty("Button7")>
		Private _Button7 As Button

		' Token: 0x0400024E RID: 590
		<AccessedThroughProperty("Button8")>
		Private _Button8 As Button

		' Token: 0x0400024F RID: 591
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x04000250 RID: 592
		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		' Token: 0x04000251 RID: 593
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x04000252 RID: 594
		<AccessedThroughProperty("PictureBox5")>
		Private _PictureBox5 As PictureBox

		' Token: 0x04000253 RID: 595
		<AccessedThroughProperty("PictureBox6")>
		Private _PictureBox6 As PictureBox

		' Token: 0x04000254 RID: 596
		<AccessedThroughProperty("PictureBox7")>
		Private _PictureBox7 As PictureBox

		' Token: 0x04000255 RID: 597
		<AccessedThroughProperty("PictureBox8")>
		Private _PictureBox8 As PictureBox

		' Token: 0x04000256 RID: 598
		<AccessedThroughProperty("Button10")>
		Private _Button10 As Button

		' Token: 0x04000257 RID: 599
		<AccessedThroughProperty("PictureBox9")>
		Private _PictureBox9 As PictureBox

		' Token: 0x04000258 RID: 600
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x04000259 RID: 601
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox
	End Class
End Namespace
