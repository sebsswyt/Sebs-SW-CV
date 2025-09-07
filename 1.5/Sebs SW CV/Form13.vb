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
	' Token: 0x02000037 RID: 55
	<DesignerGenerated()>
	Public Partial Class Form13
		Inherits Form

		' Token: 0x06000635 RID: 1589 RVA: 0x03DA0B50 File Offset: 0x03D9EF50
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Form13.__ENCList
			SyncLock _ENCList
				Form13.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000211 RID: 529
		' (get) Token: 0x06000638 RID: 1592 RVA: 0x03DA1248 File Offset: 0x03D9F648
		' (set) Token: 0x06000639 RID: 1593 RVA: 0x03DA1260 File Offset: 0x03D9F660
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

		' Token: 0x17000212 RID: 530
		' (get) Token: 0x0600063A RID: 1594 RVA: 0x03DA126C File Offset: 0x03D9F66C
		' (set) Token: 0x0600063B RID: 1595 RVA: 0x03DA1284 File Offset: 0x03D9F684
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

		' Token: 0x17000213 RID: 531
		' (get) Token: 0x0600063C RID: 1596 RVA: 0x03DA1290 File Offset: 0x03D9F690
		' (set) Token: 0x0600063D RID: 1597 RVA: 0x03DA12A8 File Offset: 0x03D9F6A8
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

		' Token: 0x17000214 RID: 532
		' (get) Token: 0x0600063E RID: 1598 RVA: 0x03DA12B4 File Offset: 0x03D9F6B4
		' (set) Token: 0x0600063F RID: 1599 RVA: 0x03DA12CC File Offset: 0x03D9F6CC
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

		' Token: 0x17000215 RID: 533
		' (get) Token: 0x06000640 RID: 1600 RVA: 0x03DA12D8 File Offset: 0x03D9F6D8
		' (set) Token: 0x06000641 RID: 1601 RVA: 0x03DA12F0 File Offset: 0x03D9F6F0
		Friend Overridable Property SaveAsToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SaveAsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._SaveAsToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000216 RID: 534
		' (get) Token: 0x06000642 RID: 1602 RVA: 0x03DA12FC File Offset: 0x03D9F6FC
		' (set) Token: 0x06000643 RID: 1603 RVA: 0x03DA1314 File Offset: 0x03D9F714
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

		' Token: 0x17000217 RID: 535
		' (get) Token: 0x06000644 RID: 1604 RVA: 0x03DA1320 File Offset: 0x03D9F720
		' (set) Token: 0x06000645 RID: 1605 RVA: 0x03DA1338 File Offset: 0x03D9F738
		Friend Overridable Property PrintToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._PrintToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._PrintToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000218 RID: 536
		' (get) Token: 0x06000646 RID: 1606 RVA: 0x03DA1344 File Offset: 0x03D9F744
		' (set) Token: 0x06000647 RID: 1607 RVA: 0x03DA135C File Offset: 0x03D9F75C
		Friend Overridable Property PrintPreviewToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._PrintPreviewToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._PrintPreviewToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000219 RID: 537
		' (get) Token: 0x06000648 RID: 1608 RVA: 0x03DA1368 File Offset: 0x03D9F768
		' (set) Token: 0x06000649 RID: 1609 RVA: 0x03DA1380 File Offset: 0x03D9F780
		Friend Overridable Property ToolStripSeparator3 As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripSeparator3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator3 = value
			End Set
		End Property

		' Token: 0x1700021A RID: 538
		' (get) Token: 0x0600064A RID: 1610 RVA: 0x03DA138C File Offset: 0x03D9F78C
		' (set) Token: 0x0600064B RID: 1611 RVA: 0x03DA13A4 File Offset: 0x03D9F7A4
		Friend Overridable Property ExitToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ExitToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._ExitToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x1700021B RID: 539
		' (get) Token: 0x0600064C RID: 1612 RVA: 0x03DA13B0 File Offset: 0x03D9F7B0
		' (set) Token: 0x0600064D RID: 1613 RVA: 0x03DA13C8 File Offset: 0x03D9F7C8
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

		' Token: 0x1700021C RID: 540
		' (get) Token: 0x0600064E RID: 1614 RVA: 0x03DA13D4 File Offset: 0x03D9F7D4
		' (set) Token: 0x0600064F RID: 1615 RVA: 0x03DA13EC File Offset: 0x03D9F7EC
		Friend Overridable Property Button1 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button1 = value
			End Set
		End Property

		' Token: 0x1700021D RID: 541
		' (get) Token: 0x06000650 RID: 1616 RVA: 0x03DA13F8 File Offset: 0x03D9F7F8
		' (set) Token: 0x06000651 RID: 1617 RVA: 0x03DA1410 File Offset: 0x03D9F810
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

		' Token: 0x1700021E RID: 542
		' (get) Token: 0x06000652 RID: 1618 RVA: 0x03DA1470 File Offset: 0x03D9F870
		' (set) Token: 0x06000653 RID: 1619 RVA: 0x03DA1488 File Offset: 0x03D9F888
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

		' Token: 0x06000654 RID: 1620 RVA: 0x03DA14E8 File Offset: 0x03D9F8E8
		Private Sub SaveFileDialog1_FileOk(sender As Object, e As CancelEventArgs)
			MyProject.Computer.FileSystem.WriteAllText(Me.SaveFileDialog1.FileName, Me.TextBox1.Text, False)
		End Sub

		' Token: 0x06000655 RID: 1621 RVA: 0x03DA1514 File Offset: 0x03D9F914
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Me.SaveFileDialog1.ShowDialog()
		End Sub

		' Token: 0x0400025A RID: 602
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400025C RID: 604
		<AccessedThroughProperty("NewToolStripMenuItem")>
		Private _NewToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400025D RID: 605
		<AccessedThroughProperty("OpenToolStripMenuItem")>
		Private _OpenToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400025E RID: 606
		<AccessedThroughProperty("ToolStripSeparator1")>
		Private _ToolStripSeparator1 As ToolStripSeparator

		' Token: 0x0400025F RID: 607
		<AccessedThroughProperty("SaveToolStripMenuItem")>
		Private _SaveToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000260 RID: 608
		<AccessedThroughProperty("SaveAsToolStripMenuItem")>
		Private _SaveAsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000261 RID: 609
		<AccessedThroughProperty("ToolStripSeparator2")>
		Private _ToolStripSeparator2 As ToolStripSeparator

		' Token: 0x04000262 RID: 610
		<AccessedThroughProperty("PrintToolStripMenuItem")>
		Private _PrintToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000263 RID: 611
		<AccessedThroughProperty("PrintPreviewToolStripMenuItem")>
		Private _PrintPreviewToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000264 RID: 612
		<AccessedThroughProperty("ToolStripSeparator3")>
		Private _ToolStripSeparator3 As ToolStripSeparator

		' Token: 0x04000265 RID: 613
		<AccessedThroughProperty("ExitToolStripMenuItem")>
		Private _ExitToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000266 RID: 614
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x04000267 RID: 615
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000268 RID: 616
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x04000269 RID: 617
		<AccessedThroughProperty("SaveFileDialog1")>
		Private _SaveFileDialog1 As SaveFileDialog
	End Class
End Namespace
