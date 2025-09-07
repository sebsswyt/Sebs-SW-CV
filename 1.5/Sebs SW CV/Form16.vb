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
	' Token: 0x0200003A RID: 58
	<DesignerGenerated()>
	Public Partial Class Form16
		Inherits Form

		' Token: 0x060006F8 RID: 1784 RVA: 0x03DA4BBC File Offset: 0x03DA2FBC
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Form16.__ENCList
			SyncLock _ENCList
				Form16.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000256 RID: 598
		' (get) Token: 0x060006FB RID: 1787 RVA: 0x03DA5378 File Offset: 0x03DA3778
		' (set) Token: 0x060006FC RID: 1788 RVA: 0x03DA5390 File Offset: 0x03DA3790
		Friend Overridable Property MenuStrip1 As MenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuStrip1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuStrip)
				Me._MenuStrip1 = value
			End Set
		End Property

		' Token: 0x17000257 RID: 599
		' (get) Token: 0x060006FD RID: 1789 RVA: 0x03DA539C File Offset: 0x03DA379C
		' (set) Token: 0x060006FE RID: 1790 RVA: 0x03DA53B4 File Offset: 0x03DA37B4
		Friend Overridable Property FileToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FileToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._FileToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000258 RID: 600
		' (get) Token: 0x060006FF RID: 1791 RVA: 0x03DA53C0 File Offset: 0x03DA37C0
		' (set) Token: 0x06000700 RID: 1792 RVA: 0x03DA53D8 File Offset: 0x03DA37D8
		Friend Overridable Property NewToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._NewToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._NewToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000259 RID: 601
		' (get) Token: 0x06000701 RID: 1793 RVA: 0x03DA53E4 File Offset: 0x03DA37E4
		' (set) Token: 0x06000702 RID: 1794 RVA: 0x03DA53FC File Offset: 0x03DA37FC
		Friend Overridable Property SaveToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SaveToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._SaveToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x1700025A RID: 602
		' (get) Token: 0x06000703 RID: 1795 RVA: 0x03DA5408 File Offset: 0x03DA3808
		' (set) Token: 0x06000704 RID: 1796 RVA: 0x03DA5420 File Offset: 0x03DA3820
		Friend Overridable Property AsSaveToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._AsSaveToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.AsSaveToolStripMenuItem_Click
				Dim flag As Boolean = Me._AsSaveToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._AsSaveToolStripMenuItem.Click, eventHandler
				End If
				Me._AsSaveToolStripMenuItem = value
				flag = Me._AsSaveToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._AsSaveToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700025B RID: 603
		' (get) Token: 0x06000705 RID: 1797 RVA: 0x03DA5480 File Offset: 0x03DA3880
		' (set) Token: 0x06000706 RID: 1798 RVA: 0x03DA5498 File Offset: 0x03DA3898
		Friend Overridable Property FormatToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FormatToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.FormatToolStripMenuItem_Click
				Dim flag As Boolean = Me._FormatToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._FormatToolStripMenuItem.Click, eventHandler
				End If
				Me._FormatToolStripMenuItem = value
				flag = Me._FormatToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._FormatToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700025C RID: 604
		' (get) Token: 0x06000707 RID: 1799 RVA: 0x03DA54F8 File Offset: 0x03DA38F8
		' (set) Token: 0x06000708 RID: 1800 RVA: 0x03DA5510 File Offset: 0x03DA3910
		Friend Overridable Property TheWebToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._TheWebToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.TheWebToolStripMenuItem_Click
				Dim flag As Boolean = Me._TheWebToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._TheWebToolStripMenuItem.Click, eventHandler
				End If
				Me._TheWebToolStripMenuItem = value
				flag = Me._TheWebToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._TheWebToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700025D RID: 605
		' (get) Token: 0x06000709 RID: 1801 RVA: 0x03DA5570 File Offset: 0x03DA3970
		' (set) Token: 0x0600070A RID: 1802 RVA: 0x03DA5588 File Offset: 0x03DA3988
		Friend Overridable Property AboutToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._AboutToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._AboutToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x1700025E RID: 606
		' (get) Token: 0x0600070B RID: 1803 RVA: 0x03DA5594 File Offset: 0x03DA3994
		' (set) Token: 0x0600070C RID: 1804 RVA: 0x03DA55AC File Offset: 0x03DA39AC
		Friend Overridable Property AboutUsToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._AboutUsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.AboutUsToolStripMenuItem_Click
				Dim flag As Boolean = Me._AboutUsToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._AboutUsToolStripMenuItem.Click, eventHandler
				End If
				Me._AboutUsToolStripMenuItem = value
				flag = Me._AboutUsToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._AboutUsToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700025F RID: 607
		' (get) Token: 0x0600070D RID: 1805 RVA: 0x03DA560C File Offset: 0x03DA3A0C
		' (set) Token: 0x0600070E RID: 1806 RVA: 0x03DA5624 File Offset: 0x03DA3A24
		Friend Overridable Property FileExplorerToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FileExplorerToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.FileExplorerToolStripMenuItem_Click
				Dim flag As Boolean = Me._FileExplorerToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._FileExplorerToolStripMenuItem.Click, eventHandler
				End If
				Me._FileExplorerToolStripMenuItem = value
				flag = Me._FileExplorerToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._FileExplorerToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000260 RID: 608
		' (get) Token: 0x0600070F RID: 1807 RVA: 0x03DA5684 File Offset: 0x03DA3A84
		' (set) Token: 0x06000710 RID: 1808 RVA: 0x03DA569C File Offset: 0x03DA3A9C
		Friend Overridable Property SaveFileDialog1 As SaveFileDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._SaveFileDialog1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As SaveFileDialog)
				Dim cancelEventHandler As CancelEventHandler = AddressOf Me.SaveFileDialog1_FileOk
				Dim flag As Boolean = Me._SaveFileDialog1 IsNot Nothing
				If flag Then
					RemoveHandler Me._SaveFileDialog1.FileOk, cancelEventHandler
				End If
				Me._SaveFileDialog1 = value
				flag = Me._SaveFileDialog1 IsNot Nothing
				If flag Then
					AddHandler Me._SaveFileDialog1.FileOk, cancelEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000261 RID: 609
		' (get) Token: 0x06000711 RID: 1809 RVA: 0x03DA56FC File Offset: 0x03DA3AFC
		' (set) Token: 0x06000712 RID: 1810 RVA: 0x03DA5714 File Offset: 0x03DA3B14
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

		' Token: 0x17000262 RID: 610
		' (get) Token: 0x06000713 RID: 1811 RVA: 0x03DA5720 File Offset: 0x03DA3B20
		' (set) Token: 0x06000714 RID: 1812 RVA: 0x03DA5738 File Offset: 0x03DA3B38
		Friend Overridable Property OpenToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._OpenToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000263 RID: 611
		' (get) Token: 0x06000715 RID: 1813 RVA: 0x03DA5744 File Offset: 0x03DA3B44
		' (set) Token: 0x06000716 RID: 1814 RVA: 0x03DA575C File Offset: 0x03DA3B5C
		Friend Overridable Property TheWebToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._TheWebToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.TheWebToolStripMenuItem1_Click
				Dim flag As Boolean = Me._TheWebToolStripMenuItem1 IsNot Nothing
				If flag Then
					RemoveHandler Me._TheWebToolStripMenuItem1.Click, eventHandler
				End If
				Me._TheWebToolStripMenuItem1 = value
				flag = Me._TheWebToolStripMenuItem1 IsNot Nothing
				If flag Then
					AddHandler Me._TheWebToolStripMenuItem1.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000264 RID: 612
		' (get) Token: 0x06000717 RID: 1815 RVA: 0x03DA57BC File Offset: 0x03DA3BBC
		' (set) Token: 0x06000718 RID: 1816 RVA: 0x03DA57D4 File Offset: 0x03DA3BD4
		Friend Overridable Property ToolStripSeparator1 As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripSeparator1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator1 = value
			End Set
		End Property

		' Token: 0x17000265 RID: 613
		' (get) Token: 0x06000719 RID: 1817 RVA: 0x03DA57E0 File Offset: 0x03DA3BE0
		' (set) Token: 0x0600071A RID: 1818 RVA: 0x03DA57F8 File Offset: 0x03DA3BF8
		Friend Overridable Property ExitToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ExitToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.ExitToolStripMenuItem_Click
				Dim flag As Boolean = Me._ExitToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._ExitToolStripMenuItem.Click, eventHandler
				End If
				Me._ExitToolStripMenuItem = value
				flag = Me._ExitToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._ExitToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000266 RID: 614
		' (get) Token: 0x0600071B RID: 1819 RVA: 0x03DA5858 File Offset: 0x03DA3C58
		' (set) Token: 0x0600071C RID: 1820 RVA: 0x03DA5870 File Offset: 0x03DA3C70
		Friend Overridable Property ToolStripSeparator2 As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripSeparator2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator2 = value
			End Set
		End Property

		' Token: 0x17000267 RID: 615
		' (get) Token: 0x0600071D RID: 1821 RVA: 0x03DA587C File Offset: 0x03DA3C7C
		' (set) Token: 0x0600071E RID: 1822 RVA: 0x03DA5894 File Offset: 0x03DA3C94
		Friend Overridable Property BSODTestToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._BSODTestToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.BSODTestToolStripMenuItem_Click
				Dim flag As Boolean = Me._BSODTestToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._BSODTestToolStripMenuItem.Click, eventHandler
				End If
				Me._BSODTestToolStripMenuItem = value
				flag = Me._BSODTestToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._BSODTestToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x0600071F RID: 1823 RVA: 0x03DA58F4 File Offset: 0x03DA3CF4
		Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000720 RID: 1824 RVA: 0x03DA58F8 File Offset: 0x03DA3CF8
		Private Sub FormatToolStripMenuItem_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000721 RID: 1825 RVA: 0x03DA58FC File Offset: 0x03DA3CFC
		Private Sub AsSaveToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.SaveFileDialog1.ShowDialog()
		End Sub

		' Token: 0x06000722 RID: 1826 RVA: 0x03DA590C File Offset: 0x03DA3D0C
		Private Sub TheWebToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form19.Show()
		End Sub

		' Token: 0x06000723 RID: 1827 RVA: 0x03DA5920 File Offset: 0x03DA3D20
		Private Sub FileExplorerToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form3.Show()
		End Sub

		' Token: 0x06000724 RID: 1828 RVA: 0x03DA5934 File Offset: 0x03DA3D34
		Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox7.Show()
		End Sub

		' Token: 0x06000725 RID: 1829 RVA: 0x03DA5948 File Offset: 0x03DA3D48
		Private Sub SaveFileDialog1_FileOk(sender As Object, e As CancelEventArgs)
			MyProject.Computer.FileSystem.WriteAllText(Me.SaveFileDialog1.FileName, Me.RichTextBox1.Text, False)
		End Sub

		' Token: 0x06000726 RID: 1830 RVA: 0x03DA5974 File Offset: 0x03DA3D74
		Private Sub TheWebToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form19.Show()
		End Sub

		' Token: 0x06000727 RID: 1831 RVA: 0x03DA5988 File Offset: 0x03DA3D88
		Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000728 RID: 1832 RVA: 0x03DA5994 File Offset: 0x03DA3D94
		Private Sub BSODTestToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.Close()
			MyProject.Forms.Form28.Show()
			MyProject.Forms.AboutBox17.Show()
			MyProject.Forms.Form17.Show()
			Me.Close()
		End Sub

		' Token: 0x040002A6 RID: 678
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040002A8 RID: 680
		<AccessedThroughProperty("MenuStrip1")>
		Private _MenuStrip1 As MenuStrip

		' Token: 0x040002A9 RID: 681
		<AccessedThroughProperty("FileToolStripMenuItem")>
		Private _FileToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040002AA RID: 682
		<AccessedThroughProperty("NewToolStripMenuItem")>
		Private _NewToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040002AB RID: 683
		<AccessedThroughProperty("SaveToolStripMenuItem")>
		Private _SaveToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040002AC RID: 684
		<AccessedThroughProperty("AsSaveToolStripMenuItem")>
		Private _AsSaveToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040002AD RID: 685
		<AccessedThroughProperty("FormatToolStripMenuItem")>
		Private _FormatToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040002AE RID: 686
		<AccessedThroughProperty("TheWebToolStripMenuItem")>
		Private _TheWebToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040002AF RID: 687
		<AccessedThroughProperty("AboutToolStripMenuItem")>
		Private _AboutToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040002B0 RID: 688
		<AccessedThroughProperty("AboutUsToolStripMenuItem")>
		Private _AboutUsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040002B1 RID: 689
		<AccessedThroughProperty("FileExplorerToolStripMenuItem")>
		Private _FileExplorerToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040002B2 RID: 690
		<AccessedThroughProperty("SaveFileDialog1")>
		Private _SaveFileDialog1 As SaveFileDialog

		' Token: 0x040002B3 RID: 691
		<AccessedThroughProperty("RichTextBox1")>
		Private _RichTextBox1 As RichTextBox

		' Token: 0x040002B4 RID: 692
		<AccessedThroughProperty("OpenToolStripMenuItem")>
		Private _OpenToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040002B5 RID: 693
		<AccessedThroughProperty("TheWebToolStripMenuItem1")>
		Private _TheWebToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x040002B6 RID: 694
		<AccessedThroughProperty("ToolStripSeparator1")>
		Private _ToolStripSeparator1 As ToolStripSeparator

		' Token: 0x040002B7 RID: 695
		<AccessedThroughProperty("ExitToolStripMenuItem")>
		Private _ExitToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040002B8 RID: 696
		<AccessedThroughProperty("ToolStripSeparator2")>
		Private _ToolStripSeparator2 As ToolStripSeparator

		' Token: 0x040002B9 RID: 697
		<AccessedThroughProperty("BSODTestToolStripMenuItem")>
		Private _BSODTestToolStripMenuItem As ToolStripMenuItem
	End Class
End Namespace
