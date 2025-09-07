Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x02000070 RID: 112
	<DesignerGenerated()>
	Public Partial Class Form9
		Inherits Form

		' Token: 0x0600123F RID: 4671 RVA: 0x03DF3CAC File Offset: 0x03DF20AC
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Form9.__ENCList
			SyncLock _ENCList
				Form9.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000609 RID: 1545
		' (get) Token: 0x06001242 RID: 4674 RVA: 0x03DF4DE8 File Offset: 0x03DF31E8
		' (set) Token: 0x06001243 RID: 4675 RVA: 0x03DF4E00 File Offset: 0x03DF3200
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

		' Token: 0x1700060A RID: 1546
		' (get) Token: 0x06001244 RID: 4676 RVA: 0x03DF4E0C File Offset: 0x03DF320C
		' (set) Token: 0x06001245 RID: 4677 RVA: 0x03DF4E24 File Offset: 0x03DF3224
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

		' Token: 0x1700060B RID: 1547
		' (get) Token: 0x06001246 RID: 4678 RVA: 0x03DF4E30 File Offset: 0x03DF3230
		' (set) Token: 0x06001247 RID: 4679 RVA: 0x03DF4E48 File Offset: 0x03DF3248
		Friend Overridable Property Button1 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button1_Click_1
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

		' Token: 0x1700060C RID: 1548
		' (get) Token: 0x06001248 RID: 4680 RVA: 0x03DF4EA8 File Offset: 0x03DF32A8
		' (set) Token: 0x06001249 RID: 4681 RVA: 0x03DF4EC0 File Offset: 0x03DF32C0
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

		' Token: 0x1700060D RID: 1549
		' (get) Token: 0x0600124A RID: 4682 RVA: 0x03DF4F20 File Offset: 0x03DF3320
		' (set) Token: 0x0600124B RID: 4683 RVA: 0x03DF4F38 File Offset: 0x03DF3338
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

		' Token: 0x1700060E RID: 1550
		' (get) Token: 0x0600124C RID: 4684 RVA: 0x03DF4F98 File Offset: 0x03DF3398
		' (set) Token: 0x0600124D RID: 4685 RVA: 0x03DF4FB0 File Offset: 0x03DF33B0
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

		' Token: 0x1700060F RID: 1551
		' (get) Token: 0x0600124E RID: 4686 RVA: 0x03DF5010 File Offset: 0x03DF3410
		' (set) Token: 0x0600124F RID: 4687 RVA: 0x03DF5028 File Offset: 0x03DF3428
		Friend Overridable Property WebBrowser2 As WebBrowser
			<DebuggerNonUserCode()>
			Get
				Return Me._WebBrowser2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As WebBrowser)
				Me._WebBrowser2 = value
			End Set
		End Property

		' Token: 0x17000610 RID: 1552
		' (get) Token: 0x06001250 RID: 4688 RVA: 0x03DF5034 File Offset: 0x03DF3434
		' (set) Token: 0x06001251 RID: 4689 RVA: 0x03DF504C File Offset: 0x03DF344C
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

		' Token: 0x17000611 RID: 1553
		' (get) Token: 0x06001252 RID: 4690 RVA: 0x03DF50AC File Offset: 0x03DF34AC
		' (set) Token: 0x06001253 RID: 4691 RVA: 0x03DF50C4 File Offset: 0x03DF34C4
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

		' Token: 0x17000612 RID: 1554
		' (get) Token: 0x06001254 RID: 4692 RVA: 0x03DF5124 File Offset: 0x03DF3524
		' (set) Token: 0x06001255 RID: 4693 RVA: 0x03DF513C File Offset: 0x03DF353C
		Friend Overridable Property Panel1 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim paintEventHandler As PaintEventHandler = AddressOf Me.Panel1_Paint
				Dim flag As Boolean = Me._Panel1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Panel1.Paint, paintEventHandler
				End If
				Me._Panel1 = value
				flag = Me._Panel1 IsNot Nothing
				If flag Then
					AddHandler Me._Panel1.Paint, paintEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000613 RID: 1555
		' (get) Token: 0x06001256 RID: 4694 RVA: 0x03DF519C File Offset: 0x03DF359C
		' (set) Token: 0x06001257 RID: 4695 RVA: 0x03DF51B4 File Offset: 0x03DF35B4
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

		' Token: 0x17000614 RID: 1556
		' (get) Token: 0x06001258 RID: 4696 RVA: 0x03DF5214 File Offset: 0x03DF3614
		' (set) Token: 0x06001259 RID: 4697 RVA: 0x03DF522C File Offset: 0x03DF362C
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

		' Token: 0x17000615 RID: 1557
		' (get) Token: 0x0600125A RID: 4698 RVA: 0x03DF528C File Offset: 0x03DF368C
		' (set) Token: 0x0600125B RID: 4699 RVA: 0x03DF52A4 File Offset: 0x03DF36A4
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

		' Token: 0x17000616 RID: 1558
		' (get) Token: 0x0600125C RID: 4700 RVA: 0x03DF5304 File Offset: 0x03DF3704
		' (set) Token: 0x0600125D RID: 4701 RVA: 0x03DF531C File Offset: 0x03DF371C
		Friend Overridable Property TextBox2 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox2 = value
			End Set
		End Property

		' Token: 0x17000617 RID: 1559
		' (get) Token: 0x0600125E RID: 4702 RVA: 0x03DF5328 File Offset: 0x03DF3728
		' (set) Token: 0x0600125F RID: 4703 RVA: 0x03DF5340 File Offset: 0x03DF3740
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

		' Token: 0x17000618 RID: 1560
		' (get) Token: 0x06001260 RID: 4704 RVA: 0x03DF53A0 File Offset: 0x03DF37A0
		' (set) Token: 0x06001261 RID: 4705 RVA: 0x03DF53B8 File Offset: 0x03DF37B8
		Friend Overridable Property Panel2 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim paintEventHandler As PaintEventHandler = AddressOf Me.Panel2_Paint
				Dim flag As Boolean = Me._Panel2 IsNot Nothing
				If flag Then
					RemoveHandler Me._Panel2.Paint, paintEventHandler
				End If
				Me._Panel2 = value
				flag = Me._Panel2 IsNot Nothing
				If flag Then
					AddHandler Me._Panel2.Paint, paintEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000619 RID: 1561
		' (get) Token: 0x06001262 RID: 4706 RVA: 0x03DF5418 File Offset: 0x03DF3818
		' (set) Token: 0x06001263 RID: 4707 RVA: 0x03DF5430 File Offset: 0x03DF3830
		Friend Overridable Property Panel3 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel3 = value
			End Set
		End Property

		' Token: 0x1700061A RID: 1562
		' (get) Token: 0x06001264 RID: 4708 RVA: 0x03DF543C File Offset: 0x03DF383C
		' (set) Token: 0x06001265 RID: 4709 RVA: 0x03DF5454 File Offset: 0x03DF3854
		Friend Overridable Property Button11 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button11_Click
				Dim flag As Boolean = Me._Button11 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button11.Click, eventHandler
				End If
				Me._Button11 = value
				flag = Me._Button11 IsNot Nothing
				If flag Then
					AddHandler Me._Button11.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700061B RID: 1563
		' (get) Token: 0x06001266 RID: 4710 RVA: 0x03DF54B4 File Offset: 0x03DF38B4
		' (set) Token: 0x06001267 RID: 4711 RVA: 0x03DF54CC File Offset: 0x03DF38CC
		Friend Overridable Property Button12 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button12_Click
				Dim flag As Boolean = Me._Button12 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button12.Click, eventHandler
				End If
				Me._Button12 = value
				flag = Me._Button12 IsNot Nothing
				If flag Then
					AddHandler Me._Button12.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700061C RID: 1564
		' (get) Token: 0x06001268 RID: 4712 RVA: 0x03DF552C File Offset: 0x03DF392C
		' (set) Token: 0x06001269 RID: 4713 RVA: 0x03DF5544 File Offset: 0x03DF3944
		Friend Overridable Property Button13 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button13
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button13_Click
				Dim flag As Boolean = Me._Button13 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button13.Click, eventHandler
				End If
				Me._Button13 = value
				flag = Me._Button13 IsNot Nothing
				If flag Then
					AddHandler Me._Button13.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700061D RID: 1565
		' (get) Token: 0x0600126A RID: 4714 RVA: 0x03DF55A4 File Offset: 0x03DF39A4
		' (set) Token: 0x0600126B RID: 4715 RVA: 0x03DF55BC File Offset: 0x03DF39BC
		Friend Overridable Property Button14 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button14
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button14_Click
				Dim flag As Boolean = Me._Button14 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button14.Click, eventHandler
				End If
				Me._Button14 = value
				flag = Me._Button14 IsNot Nothing
				If flag Then
					AddHandler Me._Button14.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700061E RID: 1566
		' (get) Token: 0x0600126C RID: 4716 RVA: 0x03DF561C File Offset: 0x03DF3A1C
		' (set) Token: 0x0600126D RID: 4717 RVA: 0x03DF5634 File Offset: 0x03DF3A34
		Friend Overridable Property WebBrowser3 As WebBrowser
			<DebuggerNonUserCode()>
			Get
				Return Me._WebBrowser3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As WebBrowser)
				Me._WebBrowser3 = value
			End Set
		End Property

		' Token: 0x1700061F RID: 1567
		' (get) Token: 0x0600126E RID: 4718 RVA: 0x03DF5640 File Offset: 0x03DF3A40
		' (set) Token: 0x0600126F RID: 4719 RVA: 0x03DF5658 File Offset: 0x03DF3A58
		Friend Overridable Property TextBox3 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox3 = value
			End Set
		End Property

		' Token: 0x17000620 RID: 1568
		' (get) Token: 0x06001270 RID: 4720 RVA: 0x03DF5664 File Offset: 0x03DF3A64
		' (set) Token: 0x06001271 RID: 4721 RVA: 0x03DF567C File Offset: 0x03DF3A7C
		Friend Overridable Property Button15 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button15
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button15_Click
				Dim flag As Boolean = Me._Button15 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button15.Click, eventHandler
				End If
				Me._Button15 = value
				flag = Me._Button15 IsNot Nothing
				If flag Then
					AddHandler Me._Button15.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000621 RID: 1569
		' (get) Token: 0x06001272 RID: 4722 RVA: 0x03DF56DC File Offset: 0x03DF3ADC
		' (set) Token: 0x06001273 RID: 4723 RVA: 0x03DF56F4 File Offset: 0x03DF3AF4
		Friend Overridable Property Button16 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button16
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button16_Click
				Dim flag As Boolean = Me._Button16 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button16.Click, eventHandler
				End If
				Me._Button16 = value
				flag = Me._Button16 IsNot Nothing
				If flag Then
					AddHandler Me._Button16.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000622 RID: 1570
		' (get) Token: 0x06001274 RID: 4724 RVA: 0x03DF5754 File Offset: 0x03DF3B54
		' (set) Token: 0x06001275 RID: 4725 RVA: 0x03DF576C File Offset: 0x03DF3B6C
		Friend Overridable Property Button17 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button17
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button17_Click
				Dim flag As Boolean = Me._Button17 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button17.Click, eventHandler
				End If
				Me._Button17 = value
				flag = Me._Button17 IsNot Nothing
				If flag Then
					AddHandler Me._Button17.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000623 RID: 1571
		' (get) Token: 0x06001276 RID: 4726 RVA: 0x03DF57CC File Offset: 0x03DF3BCC
		' (set) Token: 0x06001277 RID: 4727 RVA: 0x03DF57E4 File Offset: 0x03DF3BE4
		Friend Overridable Property Button18 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button18
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button18_Click
				Dim flag As Boolean = Me._Button18 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button18.Click, eventHandler
				End If
				Me._Button18 = value
				flag = Me._Button18 IsNot Nothing
				If flag Then
					AddHandler Me._Button18.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x06001278 RID: 4728 RVA: 0x03DF5844 File Offset: 0x03DF3C44
		Private Sub Button1_Click_1(sender As Object, e As EventArgs)
			Me.WebBrowser1.GoBack()
		End Sub

		' Token: 0x06001279 RID: 4729 RVA: 0x03DF5854 File Offset: 0x03DF3C54
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Me.WebBrowser1.GoForward()
		End Sub

		' Token: 0x0600127A RID: 4730 RVA: 0x03DF5864 File Offset: 0x03DF3C64
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			Me.WebBrowser1.Refresh()
		End Sub

		' Token: 0x0600127B RID: 4731 RVA: 0x03DF5874 File Offset: 0x03DF3C74
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			Me.WebBrowser1.Navigate(Me.TextBox1.Text)
		End Sub

		' Token: 0x0600127C RID: 4732 RVA: 0x03DF5890 File Offset: 0x03DF3C90
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			Me.Panel2.Visible = False
			Me.Panel3.Visible = False
			Me.Panel1.Visible = True
		End Sub

		' Token: 0x0600127D RID: 4733 RVA: 0x03DF58BC File Offset: 0x03DF3CBC
		Private Sub Button6_Click(sender As Object, e As EventArgs)
			Me.Panel2.Visible = True
			Me.Panel3.Visible = False
			Me.Panel1.Visible = True
		End Sub

		' Token: 0x0600127E RID: 4734 RVA: 0x03DF58E8 File Offset: 0x03DF3CE8
		Private Sub Button7_Click(sender As Object, e As EventArgs)
			Me.WebBrowser2.GoBack()
		End Sub

		' Token: 0x0600127F RID: 4735 RVA: 0x03DF58F8 File Offset: 0x03DF3CF8
		Private Sub Button8_Click(sender As Object, e As EventArgs)
			Me.WebBrowser2.GoForward()
		End Sub

		' Token: 0x06001280 RID: 4736 RVA: 0x03DF5908 File Offset: 0x03DF3D08
		Private Sub Button9_Click(sender As Object, e As EventArgs)
			Me.WebBrowser2.Refresh()
		End Sub

		' Token: 0x06001281 RID: 4737 RVA: 0x03DF5918 File Offset: 0x03DF3D18
		Private Sub Button10_Click(sender As Object, e As EventArgs)
			Me.WebBrowser2.Navigate(Me.TextBox2.Text)
		End Sub

		' Token: 0x06001282 RID: 4738 RVA: 0x03DF5934 File Offset: 0x03DF3D34
		Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x06001283 RID: 4739 RVA: 0x03DF5938 File Offset: 0x03DF3D38
		Private Sub Button11_Click(sender As Object, e As EventArgs)
			Me.WebBrowser3.GoBack()
		End Sub

		' Token: 0x06001284 RID: 4740 RVA: 0x03DF5948 File Offset: 0x03DF3D48
		Private Sub Button12_Click(sender As Object, e As EventArgs)
			Me.WebBrowser3.GoForward()
		End Sub

		' Token: 0x06001285 RID: 4741 RVA: 0x03DF5958 File Offset: 0x03DF3D58
		Private Sub Button13_Click(sender As Object, e As EventArgs)
			Me.WebBrowser3.Refresh()
		End Sub

		' Token: 0x06001286 RID: 4742 RVA: 0x03DF5968 File Offset: 0x03DF3D68
		Private Sub Button15_Click(sender As Object, e As EventArgs)
			Me.WebBrowser3.Navigate(Me.TextBox1.Text)
		End Sub

		' Token: 0x06001287 RID: 4743 RVA: 0x03DF5984 File Offset: 0x03DF3D84
		Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x06001288 RID: 4744 RVA: 0x03DF5988 File Offset: 0x03DF3D88
		Private Sub Button17_Click(sender As Object, e As EventArgs)
			Me.Panel3.Visible = True
			Me.Panel2.Visible = False
			Me.Panel1.Visible = False
		End Sub

		' Token: 0x06001289 RID: 4745 RVA: 0x03DF59B4 File Offset: 0x03DF3DB4
		Private Sub Button18_Click(sender As Object, e As EventArgs)
			Me.Panel3.Visible = True
			Me.Panel2.Visible = False
			Me.Panel1.Visible = False
		End Sub

		' Token: 0x0600128A RID: 4746 RVA: 0x03DF59E0 File Offset: 0x03DF3DE0
		Private Sub Button14_Click(sender As Object, e As EventArgs)
			Me.Panel2.Visible = True
			Me.Panel1.Visible = True
			Me.Panel3.Visible = False
		End Sub

		' Token: 0x0600128B RID: 4747 RVA: 0x03DF5A0C File Offset: 0x03DF3E0C
		Private Sub Button16_Click(sender As Object, e As EventArgs)
			Me.Panel1.Visible = True
			Me.Panel2.Visible = False
			Me.Panel3.Visible = False
		End Sub

		' Token: 0x040006D3 RID: 1747
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040006D5 RID: 1749
		<AccessedThroughProperty("WebBrowser1")>
		Private _WebBrowser1 As WebBrowser

		' Token: 0x040006D6 RID: 1750
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x040006D7 RID: 1751
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040006D8 RID: 1752
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x040006D9 RID: 1753
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x040006DA RID: 1754
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x040006DB RID: 1755
		<AccessedThroughProperty("WebBrowser2")>
		Private _WebBrowser2 As WebBrowser

		' Token: 0x040006DC RID: 1756
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x040006DD RID: 1757
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x040006DE RID: 1758
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x040006DF RID: 1759
		<AccessedThroughProperty("Button7")>
		Private _Button7 As Button

		' Token: 0x040006E0 RID: 1760
		<AccessedThroughProperty("Button8")>
		Private _Button8 As Button

		' Token: 0x040006E1 RID: 1761
		<AccessedThroughProperty("Button9")>
		Private _Button9 As Button

		' Token: 0x040006E2 RID: 1762
		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		' Token: 0x040006E3 RID: 1763
		<AccessedThroughProperty("Button10")>
		Private _Button10 As Button

		' Token: 0x040006E4 RID: 1764
		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel

		' Token: 0x040006E5 RID: 1765
		<AccessedThroughProperty("Panel3")>
		Private _Panel3 As Panel

		' Token: 0x040006E6 RID: 1766
		<AccessedThroughProperty("Button11")>
		Private _Button11 As Button

		' Token: 0x040006E7 RID: 1767
		<AccessedThroughProperty("Button12")>
		Private _Button12 As Button

		' Token: 0x040006E8 RID: 1768
		<AccessedThroughProperty("Button13")>
		Private _Button13 As Button

		' Token: 0x040006E9 RID: 1769
		<AccessedThroughProperty("Button14")>
		Private _Button14 As Button

		' Token: 0x040006EA RID: 1770
		<AccessedThroughProperty("WebBrowser3")>
		Private _WebBrowser3 As WebBrowser

		' Token: 0x040006EB RID: 1771
		<AccessedThroughProperty("TextBox3")>
		Private _TextBox3 As TextBox

		' Token: 0x040006EC RID: 1772
		<AccessedThroughProperty("Button15")>
		Private _Button15 As Button

		' Token: 0x040006ED RID: 1773
		<AccessedThroughProperty("Button16")>
		Private _Button16 As Button

		' Token: 0x040006EE RID: 1774
		<AccessedThroughProperty("Button17")>
		Private _Button17 As Button

		' Token: 0x040006EF RID: 1775
		<AccessedThroughProperty("Button18")>
		Private _Button18 As Button
	End Class
End Namespace
