Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x02000038 RID: 56
	<DesignerGenerated()>
	Public Partial Class Form14
		Inherits Form

		' Token: 0x06000657 RID: 1623 RVA: 0x03DA1534 File Offset: 0x03D9F934
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Form14.__ENCList
			SyncLock _ENCList
				Form14.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700021F RID: 543
		' (get) Token: 0x0600065A RID: 1626 RVA: 0x03DA1FAC File Offset: 0x03DA03AC
		' (set) Token: 0x0600065B RID: 1627 RVA: 0x03DA1FC4 File Offset: 0x03DA03C4
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

		' Token: 0x17000220 RID: 544
		' (get) Token: 0x0600065C RID: 1628 RVA: 0x03DA1FD0 File Offset: 0x03DA03D0
		' (set) Token: 0x0600065D RID: 1629 RVA: 0x03DA1FE8 File Offset: 0x03DA03E8
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

		' Token: 0x17000221 RID: 545
		' (get) Token: 0x0600065E RID: 1630 RVA: 0x03DA2048 File Offset: 0x03DA0448
		' (set) Token: 0x0600065F RID: 1631 RVA: 0x03DA2060 File Offset: 0x03DA0460
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

		' Token: 0x17000222 RID: 546
		' (get) Token: 0x06000660 RID: 1632 RVA: 0x03DA20C0 File Offset: 0x03DA04C0
		' (set) Token: 0x06000661 RID: 1633 RVA: 0x03DA20D8 File Offset: 0x03DA04D8
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

		' Token: 0x17000223 RID: 547
		' (get) Token: 0x06000662 RID: 1634 RVA: 0x03DA2138 File Offset: 0x03DA0538
		' (set) Token: 0x06000663 RID: 1635 RVA: 0x03DA2150 File Offset: 0x03DA0550
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

		' Token: 0x17000224 RID: 548
		' (get) Token: 0x06000664 RID: 1636 RVA: 0x03DA21B0 File Offset: 0x03DA05B0
		' (set) Token: 0x06000665 RID: 1637 RVA: 0x03DA21C8 File Offset: 0x03DA05C8
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

		' Token: 0x17000225 RID: 549
		' (get) Token: 0x06000666 RID: 1638 RVA: 0x03DA21D4 File Offset: 0x03DA05D4
		' (set) Token: 0x06000667 RID: 1639 RVA: 0x03DA21EC File Offset: 0x03DA05EC
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

		' Token: 0x17000226 RID: 550
		' (get) Token: 0x06000668 RID: 1640 RVA: 0x03DA224C File Offset: 0x03DA064C
		' (set) Token: 0x06000669 RID: 1641 RVA: 0x03DA2264 File Offset: 0x03DA0664
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

		' Token: 0x17000227 RID: 551
		' (get) Token: 0x0600066A RID: 1642 RVA: 0x03DA2270 File Offset: 0x03DA0670
		' (set) Token: 0x0600066B RID: 1643 RVA: 0x03DA2288 File Offset: 0x03DA0688
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

		' Token: 0x17000228 RID: 552
		' (get) Token: 0x0600066C RID: 1644 RVA: 0x03DA22E8 File Offset: 0x03DA06E8
		' (set) Token: 0x0600066D RID: 1645 RVA: 0x03DA2300 File Offset: 0x03DA0700
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

		' Token: 0x17000229 RID: 553
		' (get) Token: 0x0600066E RID: 1646 RVA: 0x03DA2360 File Offset: 0x03DA0760
		' (set) Token: 0x0600066F RID: 1647 RVA: 0x03DA2378 File Offset: 0x03DA0778
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

		' Token: 0x1700022A RID: 554
		' (get) Token: 0x06000670 RID: 1648 RVA: 0x03DA23D8 File Offset: 0x03DA07D8
		' (set) Token: 0x06000671 RID: 1649 RVA: 0x03DA23F0 File Offset: 0x03DA07F0
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

		' Token: 0x1700022B RID: 555
		' (get) Token: 0x06000672 RID: 1650 RVA: 0x03DA2450 File Offset: 0x03DA0850
		' (set) Token: 0x06000673 RID: 1651 RVA: 0x03DA2468 File Offset: 0x03DA0868
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

		' Token: 0x1700022C RID: 556
		' (get) Token: 0x06000674 RID: 1652 RVA: 0x03DA2474 File Offset: 0x03DA0874
		' (set) Token: 0x06000675 RID: 1653 RVA: 0x03DA248C File Offset: 0x03DA088C
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

		' Token: 0x1700022D RID: 557
		' (get) Token: 0x06000676 RID: 1654 RVA: 0x03DA24EC File Offset: 0x03DA08EC
		' (set) Token: 0x06000677 RID: 1655 RVA: 0x03DA2504 File Offset: 0x03DA0904
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

		' Token: 0x1700022E RID: 558
		' (get) Token: 0x06000678 RID: 1656 RVA: 0x03DA2510 File Offset: 0x03DA0910
		' (set) Token: 0x06000679 RID: 1657 RVA: 0x03DA2528 File Offset: 0x03DA0928
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

		' Token: 0x0600067A RID: 1658 RVA: 0x03DA2534 File Offset: 0x03DA0934
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			Me.Panel3.Visible = True
		End Sub

		' Token: 0x0600067B RID: 1659 RVA: 0x03DA2548 File Offset: 0x03DA0948
		Private Sub Button14_Click(sender As Object, e As EventArgs)
			Me.Panel3.Visible = False
		End Sub

		' Token: 0x0600067C RID: 1660 RVA: 0x03DA255C File Offset: 0x03DA095C
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.WebBrowser1.GoBack()
		End Sub

		' Token: 0x0600067D RID: 1661 RVA: 0x03DA256C File Offset: 0x03DA096C
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Me.WebBrowser1.GoForward()
		End Sub

		' Token: 0x0600067E RID: 1662 RVA: 0x03DA257C File Offset: 0x03DA097C
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			Me.WebBrowser1.Refresh()
		End Sub

		' Token: 0x0600067F RID: 1663 RVA: 0x03DA258C File Offset: 0x03DA098C
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			Me.WebBrowser1.Navigate(Me.TextBox1.Text)
		End Sub

		' Token: 0x06000680 RID: 1664 RVA: 0x03DA25A8 File Offset: 0x03DA09A8
		Private Sub Button11_Click(sender As Object, e As EventArgs)
			Me.WebBrowser2.GoBack()
		End Sub

		' Token: 0x06000681 RID: 1665 RVA: 0x03DA25B8 File Offset: 0x03DA09B8
		Private Sub Button12_Click(sender As Object, e As EventArgs)
			Me.WebBrowser2.GoForward()
		End Sub

		' Token: 0x06000682 RID: 1666 RVA: 0x03DA25C8 File Offset: 0x03DA09C8
		Private Sub Button13_Click(sender As Object, e As EventArgs)
			Me.WebBrowser2.Refresh()
		End Sub

		' Token: 0x06000683 RID: 1667 RVA: 0x03DA25D8 File Offset: 0x03DA09D8
		Private Sub Button15_Click(sender As Object, e As EventArgs)
			Me.WebBrowser2.Navigate(Me.TextBox3.Text)
		End Sub

		' Token: 0x0400026A RID: 618
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400026C RID: 620
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x0400026D RID: 621
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400026E RID: 622
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x0400026F RID: 623
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x04000270 RID: 624
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x04000271 RID: 625
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x04000272 RID: 626
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x04000273 RID: 627
		<AccessedThroughProperty("Panel3")>
		Private _Panel3 As Panel

		' Token: 0x04000274 RID: 628
		<AccessedThroughProperty("Button11")>
		Private _Button11 As Button

		' Token: 0x04000275 RID: 629
		<AccessedThroughProperty("Button12")>
		Private _Button12 As Button

		' Token: 0x04000276 RID: 630
		<AccessedThroughProperty("Button13")>
		Private _Button13 As Button

		' Token: 0x04000277 RID: 631
		<AccessedThroughProperty("Button14")>
		Private _Button14 As Button

		' Token: 0x04000278 RID: 632
		<AccessedThroughProperty("TextBox3")>
		Private _TextBox3 As TextBox

		' Token: 0x04000279 RID: 633
		<AccessedThroughProperty("Button15")>
		Private _Button15 As Button

		' Token: 0x0400027A RID: 634
		<AccessedThroughProperty("WebBrowser1")>
		Private _WebBrowser1 As WebBrowser

		' Token: 0x0400027B RID: 635
		<AccessedThroughProperty("WebBrowser2")>
		Private _WebBrowser2 As WebBrowser
	End Class
End Namespace
