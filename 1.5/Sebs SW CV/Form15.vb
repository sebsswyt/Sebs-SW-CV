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
	' Token: 0x02000039 RID: 57
	<DesignerGenerated()>
	Public Partial Class Form15
		Inherits Form

		' Token: 0x06000685 RID: 1669 RVA: 0x03DA2604 File Offset: 0x03DA0A04
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Form15.__ENCList
			SyncLock _ENCList
				Form15.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700022F RID: 559
		' (get) Token: 0x06000688 RID: 1672 RVA: 0x03DA38C8 File Offset: 0x03DA1CC8
		' (set) Token: 0x06000689 RID: 1673 RVA: 0x03DA38E0 File Offset: 0x03DA1CE0
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

		' Token: 0x17000230 RID: 560
		' (get) Token: 0x0600068A RID: 1674 RVA: 0x03DA38EC File Offset: 0x03DA1CEC
		' (set) Token: 0x0600068B RID: 1675 RVA: 0x03DA3904 File Offset: 0x03DA1D04
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

		' Token: 0x17000231 RID: 561
		' (get) Token: 0x0600068C RID: 1676 RVA: 0x03DA3910 File Offset: 0x03DA1D10
		' (set) Token: 0x0600068D RID: 1677 RVA: 0x03DA3928 File Offset: 0x03DA1D28
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

		' Token: 0x17000232 RID: 562
		' (get) Token: 0x0600068E RID: 1678 RVA: 0x03DA3934 File Offset: 0x03DA1D34
		' (set) Token: 0x0600068F RID: 1679 RVA: 0x03DA394C File Offset: 0x03DA1D4C
		Friend Overridable Property SaveAsToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SaveAsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.SaveAsToolStripMenuItem_Click
				Dim flag As Boolean = Me._SaveAsToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._SaveAsToolStripMenuItem.Click, eventHandler
				End If
				Me._SaveAsToolStripMenuItem = value
				flag = Me._SaveAsToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._SaveAsToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000233 RID: 563
		' (get) Token: 0x06000690 RID: 1680 RVA: 0x03DA39AC File Offset: 0x03DA1DAC
		' (set) Token: 0x06000691 RID: 1681 RVA: 0x03DA39C4 File Offset: 0x03DA1DC4
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

		' Token: 0x17000234 RID: 564
		' (get) Token: 0x06000692 RID: 1682 RVA: 0x03DA3A24 File Offset: 0x03DA1E24
		' (set) Token: 0x06000693 RID: 1683 RVA: 0x03DA3A3C File Offset: 0x03DA1E3C
		Friend Overridable Property TextBox1 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim eventHandler As EventHandler = AddressOf Me.TextBox1_TextChanged
				Dim flag As Boolean = Me._TextBox1 IsNot Nothing
				If flag Then
					RemoveHandler Me._TextBox1.TextChanged, eventHandler
				End If
				Me._TextBox1 = value
				flag = Me._TextBox1 IsNot Nothing
				If flag Then
					AddHandler Me._TextBox1.TextChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000235 RID: 565
		' (get) Token: 0x06000694 RID: 1684 RVA: 0x03DA3A9C File Offset: 0x03DA1E9C
		' (set) Token: 0x06000695 RID: 1685 RVA: 0x03DA3AB4 File Offset: 0x03DA1EB4
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

		' Token: 0x17000236 RID: 566
		' (get) Token: 0x06000696 RID: 1686 RVA: 0x03DA3B14 File Offset: 0x03DA1F14
		' (set) Token: 0x06000697 RID: 1687 RVA: 0x03DA3B2C File Offset: 0x03DA1F2C
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

		' Token: 0x17000237 RID: 567
		' (get) Token: 0x06000698 RID: 1688 RVA: 0x03DA3B8C File Offset: 0x03DA1F8C
		' (set) Token: 0x06000699 RID: 1689 RVA: 0x03DA3BA4 File Offset: 0x03DA1FA4
		Friend Overridable Property OpenFileToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenFileToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.OpenFileToolStripMenuItem_Click
				Dim flag As Boolean = Me._OpenFileToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._OpenFileToolStripMenuItem.Click, eventHandler
				End If
				Me._OpenFileToolStripMenuItem = value
				flag = Me._OpenFileToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._OpenFileToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000238 RID: 568
		' (get) Token: 0x0600069A RID: 1690 RVA: 0x03DA3C04 File Offset: 0x03DA2004
		' (set) Token: 0x0600069B RID: 1691 RVA: 0x03DA3C1C File Offset: 0x03DA201C
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

		' Token: 0x17000239 RID: 569
		' (get) Token: 0x0600069C RID: 1692 RVA: 0x03DA3C28 File Offset: 0x03DA2028
		' (set) Token: 0x0600069D RID: 1693 RVA: 0x03DA3C40 File Offset: 0x03DA2040
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

		' Token: 0x1700023A RID: 570
		' (get) Token: 0x0600069E RID: 1694 RVA: 0x03DA3C4C File Offset: 0x03DA204C
		' (set) Token: 0x0600069F RID: 1695 RVA: 0x03DA3C64 File Offset: 0x03DA2064
		Friend Overridable Property AboutToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._AboutToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.AboutToolStripMenuItem1_Click
				Dim flag As Boolean = Me._AboutToolStripMenuItem1 IsNot Nothing
				If flag Then
					RemoveHandler Me._AboutToolStripMenuItem1.Click, eventHandler
				End If
				Me._AboutToolStripMenuItem1 = value
				flag = Me._AboutToolStripMenuItem1 IsNot Nothing
				If flag Then
					AddHandler Me._AboutToolStripMenuItem1.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700023B RID: 571
		' (get) Token: 0x060006A0 RID: 1696 RVA: 0x03DA3CC4 File Offset: 0x03DA20C4
		' (set) Token: 0x060006A1 RID: 1697 RVA: 0x03DA3CDC File Offset: 0x03DA20DC
		Friend Overridable Property EditToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._EditToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._EditToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x1700023C RID: 572
		' (get) Token: 0x060006A2 RID: 1698 RVA: 0x03DA3CE8 File Offset: 0x03DA20E8
		' (set) Token: 0x060006A3 RID: 1699 RVA: 0x03DA3D00 File Offset: 0x03DA2100
		Friend Overridable Property CopyToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CopyToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.CopyToolStripMenuItem_Click
				Dim flag As Boolean = Me._CopyToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._CopyToolStripMenuItem.Click, eventHandler
				End If
				Me._CopyToolStripMenuItem = value
				flag = Me._CopyToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._CopyToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700023D RID: 573
		' (get) Token: 0x060006A4 RID: 1700 RVA: 0x03DA3D60 File Offset: 0x03DA2160
		' (set) Token: 0x060006A5 RID: 1701 RVA: 0x03DA3D78 File Offset: 0x03DA2178
		Friend Overridable Property PasteToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._PasteToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.PasteToolStripMenuItem_Click
				Dim flag As Boolean = Me._PasteToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._PasteToolStripMenuItem.Click, eventHandler
				End If
				Me._PasteToolStripMenuItem = value
				flag = Me._PasteToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._PasteToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700023E RID: 574
		' (get) Token: 0x060006A6 RID: 1702 RVA: 0x03DA3DD8 File Offset: 0x03DA21D8
		' (set) Token: 0x060006A7 RID: 1703 RVA: 0x03DA3DF0 File Offset: 0x03DA21F0
		Friend Overridable Property CutToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CutToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.CutToolStripMenuItem_Click
				Dim flag As Boolean = Me._CutToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._CutToolStripMenuItem.Click, eventHandler
				End If
				Me._CutToolStripMenuItem = value
				flag = Me._CutToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._CutToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700023F RID: 575
		' (get) Token: 0x060006A8 RID: 1704 RVA: 0x03DA3E50 File Offset: 0x03DA2250
		' (set) Token: 0x060006A9 RID: 1705 RVA: 0x03DA3E68 File Offset: 0x03DA2268
		Friend Overridable Property TToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._TToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.TToolStripMenuItem_Click
				Dim flag As Boolean = Me._TToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._TToolStripMenuItem.Click, eventHandler
				End If
				Me._TToolStripMenuItem = value
				flag = Me._TToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._TToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000240 RID: 576
		' (get) Token: 0x060006AA RID: 1706 RVA: 0x03DA3EC8 File Offset: 0x03DA22C8
		' (set) Token: 0x060006AB RID: 1707 RVA: 0x03DA3EE0 File Offset: 0x03DA22E0
		Friend Overridable Property DToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._DToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.DToolStripMenuItem_Click
				Dim flag As Boolean = Me._DToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._DToolStripMenuItem.Click, eventHandler
				End If
				Me._DToolStripMenuItem = value
				flag = Me._DToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._DToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000241 RID: 577
		' (get) Token: 0x060006AC RID: 1708 RVA: 0x03DA3F40 File Offset: 0x03DA2340
		' (set) Token: 0x060006AD RID: 1709 RVA: 0x03DA3F58 File Offset: 0x03DA2358
		Friend Overridable Property NewToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._NewToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.NewToolStripMenuItem_Click
				Dim flag As Boolean = Me._NewToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._NewToolStripMenuItem.Click, eventHandler
				End If
				Me._NewToolStripMenuItem = value
				flag = Me._NewToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._NewToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000242 RID: 578
		' (get) Token: 0x060006AE RID: 1710 RVA: 0x03DA3FB8 File Offset: 0x03DA23B8
		' (set) Token: 0x060006AF RID: 1711 RVA: 0x03DA3FD0 File Offset: 0x03DA23D0
		Friend Overridable Property FontDialog1 As FontDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._FontDialog1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FontDialog)
				Dim eventHandler As EventHandler = AddressOf Me.FontDialog1_Apply
				Dim flag As Boolean = Me._FontDialog1 IsNot Nothing
				If flag Then
					RemoveHandler Me._FontDialog1.Apply, eventHandler
				End If
				Me._FontDialog1 = value
				flag = Me._FontDialog1 IsNot Nothing
				If flag Then
					AddHandler Me._FontDialog1.Apply, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000243 RID: 579
		' (get) Token: 0x060006B0 RID: 1712 RVA: 0x03DA4030 File Offset: 0x03DA2430
		' (set) Token: 0x060006B1 RID: 1713 RVA: 0x03DA4048 File Offset: 0x03DA2448
		Friend Overridable Property FormatToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FormatToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._FormatToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000244 RID: 580
		' (get) Token: 0x060006B2 RID: 1714 RVA: 0x03DA4054 File Offset: 0x03DA2454
		' (set) Token: 0x060006B3 RID: 1715 RVA: 0x03DA406C File Offset: 0x03DA246C
		Friend Overridable Property FontToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FontToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.FontToolStripMenuItem_Click
				Dim flag As Boolean = Me._FontToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._FontToolStripMenuItem.Click, eventHandler
				End If
				Me._FontToolStripMenuItem = value
				flag = Me._FontToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._FontToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000245 RID: 581
		' (get) Token: 0x060006B4 RID: 1716 RVA: 0x03DA40CC File Offset: 0x03DA24CC
		' (set) Token: 0x060006B5 RID: 1717 RVA: 0x03DA40E4 File Offset: 0x03DA24E4
		Friend Overridable Property ViewToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ViewToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._ViewToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000246 RID: 582
		' (get) Token: 0x060006B6 RID: 1718 RVA: 0x03DA40F0 File Offset: 0x03DA24F0
		' (set) Token: 0x060006B7 RID: 1719 RVA: 0x03DA4108 File Offset: 0x03DA2508
		Friend Overridable Property StatasToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._StatasToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.StatasToolStripMenuItem_Click
				Dim flag As Boolean = Me._StatasToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._StatasToolStripMenuItem.Click, eventHandler
				End If
				Me._StatasToolStripMenuItem = value
				flag = Me._StatasToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._StatasToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000247 RID: 583
		' (get) Token: 0x060006B8 RID: 1720 RVA: 0x03DA4168 File Offset: 0x03DA2568
		' (set) Token: 0x060006B9 RID: 1721 RVA: 0x03DA4180 File Offset: 0x03DA2580
		Friend Overridable Property StatusStrip1 As StatusStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._StatusStrip1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As StatusStrip)
				Me._StatusStrip1 = value
			End Set
		End Property

		' Token: 0x17000248 RID: 584
		' (get) Token: 0x060006BA RID: 1722 RVA: 0x03DA418C File Offset: 0x03DA258C
		' (set) Token: 0x060006BB RID: 1723 RVA: 0x03DA41A4 File Offset: 0x03DA25A4
		Friend Overridable Property ToolStripStatusLabel1 As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripStatusLabel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._ToolStripStatusLabel1 = value
			End Set
		End Property

		' Token: 0x17000249 RID: 585
		' (get) Token: 0x060006BC RID: 1724 RVA: 0x03DA41B0 File Offset: 0x03DA25B0
		' (set) Token: 0x060006BD RID: 1725 RVA: 0x03DA41C8 File Offset: 0x03DA25C8
		Friend Overridable Property ReadOnlyToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ReadOnlyToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.ReadOnlyToolStripMenuItem_Click
				Dim flag As Boolean = Me._ReadOnlyToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._ReadOnlyToolStripMenuItem.Click, eventHandler
				End If
				Me._ReadOnlyToolStripMenuItem = value
				flag = Me._ReadOnlyToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._ReadOnlyToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700024A RID: 586
		' (get) Token: 0x060006BE RID: 1726 RVA: 0x03DA4228 File Offset: 0x03DA2628
		' (set) Token: 0x060006BF RID: 1727 RVA: 0x03DA4240 File Offset: 0x03DA2640
		Friend Overridable Property OpToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._OpToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.OpToolStripMenuItem_Click
				Dim flag As Boolean = Me._OpToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._OpToolStripMenuItem.Click, eventHandler
				End If
				Me._OpToolStripMenuItem = value
				flag = Me._OpToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._OpToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700024B RID: 587
		' (get) Token: 0x060006C0 RID: 1728 RVA: 0x03DA42A0 File Offset: 0x03DA26A0
		' (set) Token: 0x060006C1 RID: 1729 RVA: 0x03DA42B8 File Offset: 0x03DA26B8
		Friend Overridable Property Panel1 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.Panel1_MouseMove
				Dim mouseEventHandler2 As MouseEventHandler = AddressOf Me.Panel1_MouseDown
				Dim flag As Boolean = Me._Panel1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Panel1.MouseMove, mouseEventHandler
					RemoveHandler Me._Panel1.MouseDown, mouseEventHandler2
				End If
				Me._Panel1 = value
				flag = Me._Panel1 IsNot Nothing
				If flag Then
					AddHandler Me._Panel1.MouseMove, mouseEventHandler
					AddHandler Me._Panel1.MouseDown, mouseEventHandler2
				End If
			End Set
		End Property

		' Token: 0x1700024C RID: 588
		' (get) Token: 0x060006C2 RID: 1730 RVA: 0x03DA4340 File Offset: 0x03DA2740
		' (set) Token: 0x060006C3 RID: 1731 RVA: 0x03DA4358 File Offset: 0x03DA2758
		Friend Overridable Property Button1 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button1_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.Button1_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.Button1_Click
				Dim flag As Boolean = Me._Button1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button1.MouseLeave, eventHandler
					RemoveHandler Me._Button1.MouseEnter, eventHandler2
					RemoveHandler Me._Button1.Click, eventHandler3
				End If
				Me._Button1 = value
				flag = Me._Button1 IsNot Nothing
				If flag Then
					AddHandler Me._Button1.MouseLeave, eventHandler
					AddHandler Me._Button1.MouseEnter, eventHandler2
					AddHandler Me._Button1.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x1700024D RID: 589
		' (get) Token: 0x060006C4 RID: 1732 RVA: 0x03DA4408 File Offset: 0x03DA2808
		' (set) Token: 0x060006C5 RID: 1733 RVA: 0x03DA4420 File Offset: 0x03DA2820
		Friend Overridable Property Button2 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button2_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.Button2_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.Button2_Click
				Dim flag As Boolean = Me._Button2 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button2.MouseLeave, eventHandler
					RemoveHandler Me._Button2.MouseEnter, eventHandler2
					RemoveHandler Me._Button2.Click, eventHandler3
				End If
				Me._Button2 = value
				flag = Me._Button2 IsNot Nothing
				If flag Then
					AddHandler Me._Button2.MouseLeave, eventHandler
					AddHandler Me._Button2.MouseEnter, eventHandler2
					AddHandler Me._Button2.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x1700024E RID: 590
		' (get) Token: 0x060006C6 RID: 1734 RVA: 0x03DA44D0 File Offset: 0x03DA28D0
		' (set) Token: 0x060006C7 RID: 1735 RVA: 0x03DA44E8 File Offset: 0x03DA28E8
		Friend Overridable Property PageSetupDialog1 As PageSetupDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._PageSetupDialog1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PageSetupDialog)
				Me._PageSetupDialog1 = value
			End Set
		End Property

		' Token: 0x1700024F RID: 591
		' (get) Token: 0x060006C8 RID: 1736 RVA: 0x03DA44F4 File Offset: 0x03DA28F4
		' (set) Token: 0x060006C9 RID: 1737 RVA: 0x03DA450C File Offset: 0x03DA290C
		Friend Overridable Property ToolStripProgressBar1 As ToolStripProgressBar
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripProgressBar1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripProgressBar)
				Me._ToolStripProgressBar1 = value
			End Set
		End Property

		' Token: 0x17000250 RID: 592
		' (get) Token: 0x060006CA RID: 1738 RVA: 0x03DA4518 File Offset: 0x03DA2918
		' (set) Token: 0x060006CB RID: 1739 RVA: 0x03DA4530 File Offset: 0x03DA2930
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

		' Token: 0x17000251 RID: 593
		' (get) Token: 0x060006CC RID: 1740 RVA: 0x03DA4590 File Offset: 0x03DA2990
		' (set) Token: 0x060006CD RID: 1741 RVA: 0x03DA45A8 File Offset: 0x03DA29A8
		Friend Overridable Property Button3 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button3_Click
				Dim eventHandler2 As EventHandler = AddressOf Me.Button3_MouseLeave
				Dim eventHandler3 As EventHandler = AddressOf Me.Button3_MouseEnter
				Dim flag As Boolean = Me._Button3 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button3.Click, eventHandler
					RemoveHandler Me._Button3.MouseLeave, eventHandler2
					RemoveHandler Me._Button3.MouseEnter, eventHandler3
				End If
				Me._Button3 = value
				flag = Me._Button3 IsNot Nothing
				If flag Then
					AddHandler Me._Button3.Click, eventHandler
					AddHandler Me._Button3.MouseLeave, eventHandler2
					AddHandler Me._Button3.MouseEnter, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x17000252 RID: 594
		' (get) Token: 0x060006CE RID: 1742 RVA: 0x03DA4658 File Offset: 0x03DA2A58
		' (set) Token: 0x060006CF RID: 1743 RVA: 0x03DA4670 File Offset: 0x03DA2A70
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

		' Token: 0x17000253 RID: 595
		' (get) Token: 0x060006D0 RID: 1744 RVA: 0x03DA467C File Offset: 0x03DA2A7C
		' (set) Token: 0x060006D1 RID: 1745 RVA: 0x03DA4694 File Offset: 0x03DA2A94
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

		' Token: 0x17000254 RID: 596
		' (get) Token: 0x060006D2 RID: 1746 RVA: 0x03DA46A0 File Offset: 0x03DA2AA0
		' (set) Token: 0x060006D3 RID: 1747 RVA: 0x03DA46B8 File Offset: 0x03DA2AB8
		Friend Overridable Property PasteTextFromKeybowdToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._PasteTextFromKeybowdToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.PasteTextFromKeybowdToolStripMenuItem_Click
				Dim flag As Boolean = Me._PasteTextFromKeybowdToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._PasteTextFromKeybowdToolStripMenuItem.Click, eventHandler
				End If
				Me._PasteTextFromKeybowdToolStripMenuItem = value
				flag = Me._PasteTextFromKeybowdToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._PasteTextFromKeybowdToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000255 RID: 597
		' (get) Token: 0x060006D4 RID: 1748 RVA: 0x03DA4718 File Offset: 0x03DA2B18
		' (set) Token: 0x060006D5 RID: 1749 RVA: 0x03DA4730 File Offset: 0x03DA2B30
		Friend Overridable Property SToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.SToolStripMenuItem_Click
				Dim flag As Boolean = Me._SToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._SToolStripMenuItem.Click, eventHandler
				End If
				Me._SToolStripMenuItem = value
				flag = Me._SToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._SToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x060006D6 RID: 1750 RVA: 0x03DA4790 File Offset: 0x03DA2B90
		Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x060006D7 RID: 1751 RVA: 0x03DA479C File Offset: 0x03DA2B9C
		Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.SaveFileDialog1.ShowDialog()
		End Sub

		' Token: 0x060006D8 RID: 1752 RVA: 0x03DA47AC File Offset: 0x03DA2BAC
		Private Sub SaveFileDialog1_FileOk(sender As Object, e As CancelEventArgs)
			MyProject.Computer.FileSystem.WriteAllText(Me.SaveFileDialog1.FileName, Me.TextBox1.Text, False)
		End Sub

		' Token: 0x060006D9 RID: 1753 RVA: 0x03DA47D8 File Offset: 0x03DA2BD8
		Private Sub OpenFileDialog1_FileOk(sender As Object, e As CancelEventArgs)
			Me.TextBox1.Text = MyProject.Computer.FileSystem.ReadAllText(Me.OpenFileDialog1.FileName)
		End Sub

		' Token: 0x060006DA RID: 1754 RVA: 0x03DA4804 File Offset: 0x03DA2C04
		Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.OpenFileDialog1.ShowDialog()
		End Sub

		' Token: 0x060006DB RID: 1755 RVA: 0x03DA4814 File Offset: 0x03DA2C14
		Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox1.Show()
			MyProject.Forms.AboutBox1.LabelProductName.Text = "Product Name Text Editor"
		End Sub

		' Token: 0x060006DC RID: 1756 RVA: 0x03DA4844 File Offset: 0x03DA2C44
		Private Sub TheWebToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form9.Show()
		End Sub

		' Token: 0x060006DD RID: 1757 RVA: 0x03DA4858 File Offset: 0x03DA2C58
		Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.TextBox1.Copy()
		End Sub

		' Token: 0x060006DE RID: 1758 RVA: 0x03DA4868 File Offset: 0x03DA2C68
		Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.TextBox1.Paste()
		End Sub

		' Token: 0x060006DF RID: 1759 RVA: 0x03DA4878 File Offset: 0x03DA2C78
		Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.TextBox1.Cut()
		End Sub

		' Token: 0x060006E0 RID: 1760 RVA: 0x03DA4888 File Offset: 0x03DA2C88
		Private Sub TToolStripMenuItem_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060006E1 RID: 1761 RVA: 0x03DA488C File Offset: 0x03DA2C8C
		Private Sub DToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.TextBox1.SelectAll()
		End Sub

		' Token: 0x060006E2 RID: 1762 RVA: 0x03DA489C File Offset: 0x03DA2C9C
		Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060006E3 RID: 1763 RVA: 0x03DA48A0 File Offset: 0x03DA2CA0
		Private Sub FontDialog1_Apply(sender As Object, e As EventArgs)
			Me.TextBox1.Font = Me.FontDialog1.Font
			Me.TextBox1.ForeColor = Me.FontDialog1.Color
		End Sub

		' Token: 0x060006E4 RID: 1764 RVA: 0x03DA48D4 File Offset: 0x03DA2CD4
		Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.FontDialog1.ShowDialog() = DialogResult.OK
			If flag Then
				Me.TextBox1.Font = Me.FontDialog1.Font
				Me.TextBox1.ForeColor = Me.FontDialog1.Color
			End If
		End Sub

		' Token: 0x060006E5 RID: 1765 RVA: 0x03DA4924 File Offset: 0x03DA2D24
		Private Sub ReadOnlyToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim [readOnly] As Boolean = Me.TextBox1.[ReadOnly]
			If [readOnly] Then
				Me.TextBox1.[ReadOnly] = False
			Else
				Me.TextBox1.[ReadOnly] = True
			End If
		End Sub

		' Token: 0x060006E6 RID: 1766 RVA: 0x03DA4960 File Offset: 0x03DA2D60
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x060006E7 RID: 1767 RVA: 0x03DA496C File Offset: 0x03DA2D6C
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.WindowState = FormWindowState.Normal
			If flag Then
				Me.WindowState = FormWindowState.Maximized
			Else
				Me.WindowState = FormWindowState.Normal
			End If
		End Sub

		' Token: 0x060006E8 RID: 1768 RVA: 0x03DA499C File Offset: 0x03DA2D9C
		Private Sub Button1_MouseEnter(sender As Object, e As EventArgs)
			Me.Button1.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x060006E9 RID: 1769 RVA: 0x03DA49B4 File Offset: 0x03DA2DB4
		Private Sub Button1_MouseLeave(sender As Object, e As EventArgs)
			Me.Button1.BackColor = Color.Transparent
		End Sub

		' Token: 0x060006EA RID: 1770 RVA: 0x03DA49CC File Offset: 0x03DA2DCC
		Private Sub Button2_MouseEnter(sender As Object, e As EventArgs)
			Me.Button2.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x060006EB RID: 1771 RVA: 0x03DA49E4 File Offset: 0x03DA2DE4
		Private Sub Button2_MouseLeave(sender As Object, e As EventArgs)
			Me.Button2.BackColor = Color.Transparent
		End Sub

		' Token: 0x060006EC RID: 1772 RVA: 0x03DA49FC File Offset: 0x03DA2DFC
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Me.Panel1.BackColor = MyProject.Forms.Form_1pad.Panel1.BackColor
			Me.Panel3.BackColor = MyProject.Forms.Form_1pad.Panel1.BackColor
			Dim flag As Boolean = Me.TextBox1.ForeColor = Color.White
			If flag Then
				Me.TextBox1.ForeColor = Color.Black
			End If
		End Sub

		' Token: 0x060006ED RID: 1773 RVA: 0x03DA4A78 File Offset: 0x03DA2E78
		Private Sub OpToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form41.Show()
		End Sub

		' Token: 0x060006EE RID: 1774 RVA: 0x03DA4A8C File Offset: 0x03DA2E8C
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x060006EF RID: 1775 RVA: 0x03DA4A98 File Offset: 0x03DA2E98
		Private Sub Button3_MouseEnter(sender As Object, e As EventArgs)
			Me.Button3.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x060006F0 RID: 1776 RVA: 0x03DA4AB0 File Offset: 0x03DA2EB0
		Private Sub Button3_MouseLeave(sender As Object, e As EventArgs)
			Me.Button3.BackColor = Color.Transparent
		End Sub

		' Token: 0x060006F1 RID: 1777 RVA: 0x03DA4AC8 File Offset: 0x03DA2EC8
		Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060006F2 RID: 1778 RVA: 0x03DA4ACC File Offset: 0x03DA2ECC
		Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs)
			' The following expression was wrapped in a checked-expression
			Me.mouse_move = New Point(0 - e.X, 0 - e.Y)
		End Sub

		' Token: 0x060006F3 RID: 1779 RVA: 0x03DA4AEC File Offset: 0x03DA2EEC
		Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = e.Button = MouseButtons.Left
			If flag Then
				Dim mousePosition As Point = Control.MousePosition
				mousePosition.Offset(Me.mouse_move.X, Me.mouse_move.Y)
				Me.Location = mousePosition
			End If
		End Sub

		' Token: 0x060006F4 RID: 1780 RVA: 0x03DA4B3C File Offset: 0x03DA2F3C
		Private Sub StatasToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim visible As Boolean = Me.StatusStrip1.Visible
			If visible Then
				Me.StatusStrip1.Visible = False
			Else
				Me.StatusStrip1.Visible = True
			End If
		End Sub

		' Token: 0x060006F5 RID: 1781 RVA: 0x03DA4B78 File Offset: 0x03DA2F78
		Private Sub PasteTextFromKeybowdToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.TextBox1.Text = MyProject.Forms.Form60.TextBox1.Text
		End Sub

		' Token: 0x060006F6 RID: 1782 RVA: 0x03DA4B9C File Offset: 0x03DA2F9C
		Private Sub SToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Process.Start("notepad.exe")
		End Sub

		' Token: 0x0400027C RID: 636
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400027E RID: 638
		<AccessedThroughProperty("MenuStrip1")>
		Private _MenuStrip1 As MenuStrip

		' Token: 0x0400027F RID: 639
		<AccessedThroughProperty("FileToolStripMenuItem")>
		Private _FileToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000280 RID: 640
		<AccessedThroughProperty("SaveToolStripMenuItem")>
		Private _SaveToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000281 RID: 641
		<AccessedThroughProperty("SaveAsToolStripMenuItem")>
		Private _SaveAsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000282 RID: 642
		<AccessedThroughProperty("ExitToolStripMenuItem")>
		Private _ExitToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000283 RID: 643
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x04000284 RID: 644
		<AccessedThroughProperty("OpenFileDialog1")>
		Private _OpenFileDialog1 As OpenFileDialog

		' Token: 0x04000285 RID: 645
		<AccessedThroughProperty("SaveFileDialog1")>
		Private _SaveFileDialog1 As SaveFileDialog

		' Token: 0x04000286 RID: 646
		<AccessedThroughProperty("OpenFileToolStripMenuItem")>
		Private _OpenFileToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000287 RID: 647
		<AccessedThroughProperty("ToolStripSeparator1")>
		Private _ToolStripSeparator1 As ToolStripSeparator

		' Token: 0x04000288 RID: 648
		<AccessedThroughProperty("AboutToolStripMenuItem")>
		Private _AboutToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000289 RID: 649
		<AccessedThroughProperty("AboutToolStripMenuItem1")>
		Private _AboutToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x0400028A RID: 650
		<AccessedThroughProperty("EditToolStripMenuItem")>
		Private _EditToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400028B RID: 651
		<AccessedThroughProperty("CopyToolStripMenuItem")>
		Private _CopyToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400028C RID: 652
		<AccessedThroughProperty("PasteToolStripMenuItem")>
		Private _PasteToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400028D RID: 653
		<AccessedThroughProperty("CutToolStripMenuItem")>
		Private _CutToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400028E RID: 654
		<AccessedThroughProperty("TToolStripMenuItem")>
		Private _TToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400028F RID: 655
		<AccessedThroughProperty("DToolStripMenuItem")>
		Private _DToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000290 RID: 656
		<AccessedThroughProperty("NewToolStripMenuItem")>
		Private _NewToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000291 RID: 657
		<AccessedThroughProperty("FontDialog1")>
		Private _FontDialog1 As FontDialog

		' Token: 0x04000292 RID: 658
		<AccessedThroughProperty("FormatToolStripMenuItem")>
		Private _FormatToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000293 RID: 659
		<AccessedThroughProperty("FontToolStripMenuItem")>
		Private _FontToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000294 RID: 660
		<AccessedThroughProperty("ViewToolStripMenuItem")>
		Private _ViewToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000295 RID: 661
		<AccessedThroughProperty("StatasToolStripMenuItem")>
		Private _StatasToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000296 RID: 662
		<AccessedThroughProperty("StatusStrip1")>
		Private _StatusStrip1 As StatusStrip

		' Token: 0x04000297 RID: 663
		<AccessedThroughProperty("ToolStripStatusLabel1")>
		Private _ToolStripStatusLabel1 As ToolStripStatusLabel

		' Token: 0x04000298 RID: 664
		<AccessedThroughProperty("ReadOnlyToolStripMenuItem")>
		Private _ReadOnlyToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000299 RID: 665
		<AccessedThroughProperty("OpToolStripMenuItem")>
		Private _OpToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400029A RID: 666
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x0400029B RID: 667
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400029C RID: 668
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x0400029D RID: 669
		<AccessedThroughProperty("PageSetupDialog1")>
		Private _PageSetupDialog1 As PageSetupDialog

		' Token: 0x0400029E RID: 670
		<AccessedThroughProperty("ToolStripProgressBar1")>
		Private _ToolStripProgressBar1 As ToolStripProgressBar

		' Token: 0x0400029F RID: 671
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x040002A0 RID: 672
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x040002A1 RID: 673
		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel

		' Token: 0x040002A2 RID: 674
		<AccessedThroughProperty("Panel3")>
		Private _Panel3 As Panel

		' Token: 0x040002A3 RID: 675
		<AccessedThroughProperty("PasteTextFromKeybowdToolStripMenuItem")>
		Private _PasteTextFromKeybowdToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040002A4 RID: 676
		<AccessedThroughProperty("SToolStripMenuItem")>
		Private _SToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040002A5 RID: 677
		Private mouse_move As Point
	End Class
End Namespace
