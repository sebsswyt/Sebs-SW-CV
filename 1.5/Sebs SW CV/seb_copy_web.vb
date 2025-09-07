Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x02000076 RID: 118
	<DesignerGenerated()>
	Public Partial Class seb_copy_web
		Inherits Form

		' Token: 0x060012AC RID: 4780 RVA: 0x03DF61DC File Offset: 0x03DF45DC
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = seb_copy_web.__ENCList
			SyncLock _ENCList
				seb_copy_web.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000630 RID: 1584
		' (get) Token: 0x060012AF RID: 4783 RVA: 0x03DF6A2C File Offset: 0x03DF4E2C
		' (set) Token: 0x060012B0 RID: 4784 RVA: 0x03DF6A44 File Offset: 0x03DF4E44
		Friend Overridable Property TabControl1 As TabControl
			<DebuggerNonUserCode()>
			Get
				Return Me._TabControl1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabControl)
				Me._TabControl1 = value
			End Set
		End Property

		' Token: 0x17000631 RID: 1585
		' (get) Token: 0x060012B1 RID: 4785 RVA: 0x03DF6A50 File Offset: 0x03DF4E50
		' (set) Token: 0x060012B2 RID: 4786 RVA: 0x03DF6A68 File Offset: 0x03DF4E68
		Friend Overridable Property TabPage1 As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage1 = value
			End Set
		End Property

		' Token: 0x17000632 RID: 1586
		' (get) Token: 0x060012B3 RID: 4787 RVA: 0x03DF6A74 File Offset: 0x03DF4E74
		' (set) Token: 0x060012B4 RID: 4788 RVA: 0x03DF6A8C File Offset: 0x03DF4E8C
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

		' Token: 0x17000633 RID: 1587
		' (get) Token: 0x060012B5 RID: 4789 RVA: 0x03DF6A98 File Offset: 0x03DF4E98
		' (set) Token: 0x060012B6 RID: 4790 RVA: 0x03DF6AB0 File Offset: 0x03DF4EB0
		Friend Overridable Property TabPage2 As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage2 = value
			End Set
		End Property

		' Token: 0x17000634 RID: 1588
		' (get) Token: 0x060012B7 RID: 4791 RVA: 0x03DF6ABC File Offset: 0x03DF4EBC
		' (set) Token: 0x060012B8 RID: 4792 RVA: 0x03DF6AD4 File Offset: 0x03DF4ED4
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

		' Token: 0x17000635 RID: 1589
		' (get) Token: 0x060012B9 RID: 4793 RVA: 0x03DF6AE0 File Offset: 0x03DF4EE0
		' (set) Token: 0x060012BA RID: 4794 RVA: 0x03DF6AF8 File Offset: 0x03DF4EF8
		Friend Overridable Property TabPage3 As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage3 = value
			End Set
		End Property

		' Token: 0x17000636 RID: 1590
		' (get) Token: 0x060012BB RID: 4795 RVA: 0x03DF6B04 File Offset: 0x03DF4F04
		' (set) Token: 0x060012BC RID: 4796 RVA: 0x03DF6B1C File Offset: 0x03DF4F1C
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

		' Token: 0x17000637 RID: 1591
		' (get) Token: 0x060012BD RID: 4797 RVA: 0x03DF6B7C File Offset: 0x03DF4F7C
		' (set) Token: 0x060012BE RID: 4798 RVA: 0x03DF6B94 File Offset: 0x03DF4F94
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

		' Token: 0x17000638 RID: 1592
		' (get) Token: 0x060012BF RID: 4799 RVA: 0x03DF6BA0 File Offset: 0x03DF4FA0
		' (set) Token: 0x060012C0 RID: 4800 RVA: 0x03DF6BB8 File Offset: 0x03DF4FB8
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

		' Token: 0x17000639 RID: 1593
		' (get) Token: 0x060012C1 RID: 4801 RVA: 0x03DF6BC4 File Offset: 0x03DF4FC4
		' (set) Token: 0x060012C2 RID: 4802 RVA: 0x03DF6BDC File Offset: 0x03DF4FDC
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

		' Token: 0x060012C3 RID: 4803 RVA: 0x03DF6BE8 File Offset: 0x03DF4FE8
		Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
			Me.WebBrowser3.Refresh()
		End Sub

		' Token: 0x040006FE RID: 1790
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000700 RID: 1792
		<AccessedThroughProperty("TabControl1")>
		Private _TabControl1 As TabControl

		' Token: 0x04000701 RID: 1793
		<AccessedThroughProperty("TabPage1")>
		Private _TabPage1 As TabPage

		' Token: 0x04000702 RID: 1794
		<AccessedThroughProperty("WebBrowser1")>
		Private _WebBrowser1 As WebBrowser

		' Token: 0x04000703 RID: 1795
		<AccessedThroughProperty("TabPage2")>
		Private _TabPage2 As TabPage

		' Token: 0x04000704 RID: 1796
		<AccessedThroughProperty("WebBrowser2")>
		Private _WebBrowser2 As WebBrowser

		' Token: 0x04000705 RID: 1797
		<AccessedThroughProperty("TabPage3")>
		Private _TabPage3 As TabPage

		' Token: 0x04000706 RID: 1798
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x04000707 RID: 1799
		<AccessedThroughProperty("WebBrowser3")>
		Private _WebBrowser3 As WebBrowser

		' Token: 0x04000708 RID: 1800
		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		' Token: 0x04000709 RID: 1801
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox
	End Class
End Namespace
