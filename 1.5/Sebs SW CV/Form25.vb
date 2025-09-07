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
	' Token: 0x02000046 RID: 70
	<DesignerGenerated()>
	Public Partial Class Form25
		Inherits Form

		' Token: 0x06000B07 RID: 2823 RVA: 0x03DC1EC4 File Offset: 0x03DC02C4
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form25_Load
			Dim _ENCList As List(Of WeakReference) = Form25.__ENCList
			SyncLock _ENCList
				Form25.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170003A2 RID: 930
		' (get) Token: 0x06000B0A RID: 2826 RVA: 0x03DC2944 File Offset: 0x03DC0D44
		' (set) Token: 0x06000B0B RID: 2827 RVA: 0x03DC295C File Offset: 0x03DC0D5C
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

		' Token: 0x170003A3 RID: 931
		' (get) Token: 0x06000B0C RID: 2828 RVA: 0x03DC2968 File Offset: 0x03DC0D68
		' (set) Token: 0x06000B0D RID: 2829 RVA: 0x03DC2980 File Offset: 0x03DC0D80
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

		' Token: 0x170003A4 RID: 932
		' (get) Token: 0x06000B0E RID: 2830 RVA: 0x03DC298C File Offset: 0x03DC0D8C
		' (set) Token: 0x06000B0F RID: 2831 RVA: 0x03DC29A4 File Offset: 0x03DC0DA4
		Friend Overridable Property OptionsToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._OptionsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._OptionsToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x170003A5 RID: 933
		' (get) Token: 0x06000B10 RID: 2832 RVA: 0x03DC29B0 File Offset: 0x03DC0DB0
		' (set) Token: 0x06000B11 RID: 2833 RVA: 0x03DC29C8 File Offset: 0x03DC0DC8
		Friend Overridable Property NewTaskToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._NewTaskToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.NewTaskToolStripMenuItem_Click
				Dim flag As Boolean = Me._NewTaskToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._NewTaskToolStripMenuItem.Click, eventHandler
				End If
				Me._NewTaskToolStripMenuItem = value
				flag = Me._NewTaskToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._NewTaskToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170003A6 RID: 934
		' (get) Token: 0x06000B12 RID: 2834 RVA: 0x03DC2A28 File Offset: 0x03DC0E28
		' (set) Token: 0x06000B13 RID: 2835 RVA: 0x03DC2A40 File Offset: 0x03DC0E40
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

		' Token: 0x170003A7 RID: 935
		' (get) Token: 0x06000B14 RID: 2836 RVA: 0x03DC2AA0 File Offset: 0x03DC0EA0
		' (set) Token: 0x06000B15 RID: 2837 RVA: 0x03DC2AB8 File Offset: 0x03DC0EB8
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

		' Token: 0x170003A8 RID: 936
		' (get) Token: 0x06000B16 RID: 2838 RVA: 0x03DC2AC4 File Offset: 0x03DC0EC4
		' (set) Token: 0x06000B17 RID: 2839 RVA: 0x03DC2ADC File Offset: 0x03DC0EDC
		Friend Overridable Property ProgramToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ProgramToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._ProgramToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x170003A9 RID: 937
		' (get) Token: 0x06000B18 RID: 2840 RVA: 0x03DC2AE8 File Offset: 0x03DC0EE8
		' (set) Token: 0x06000B19 RID: 2841 RVA: 0x03DC2B00 File Offset: 0x03DC0F00
		Friend Overridable Property HelpToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._HelpToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._HelpToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x170003AA RID: 938
		' (get) Token: 0x06000B1A RID: 2842 RVA: 0x03DC2B0C File Offset: 0x03DC0F0C
		' (set) Token: 0x06000B1B RID: 2843 RVA: 0x03DC2B24 File Offset: 0x03DC0F24
		Friend Overridable Property RestartToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RestartToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.RestartToolStripMenuItem_Click
				Dim flag As Boolean = Me._RestartToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._RestartToolStripMenuItem.Click, eventHandler
				End If
				Me._RestartToolStripMenuItem = value
				flag = Me._RestartToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._RestartToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170003AB RID: 939
		' (get) Token: 0x06000B1C RID: 2844 RVA: 0x03DC2B84 File Offset: 0x03DC0F84
		' (set) Token: 0x06000B1D RID: 2845 RVA: 0x03DC2B9C File Offset: 0x03DC0F9C
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

		' Token: 0x170003AC RID: 940
		' (get) Token: 0x06000B1E RID: 2846 RVA: 0x03DC2BFC File Offset: 0x03DC0FFC
		' (set) Token: 0x06000B1F RID: 2847 RVA: 0x03DC2C14 File Offset: 0x03DC1014
		Friend Overridable Property AboutToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._AboutToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.AboutToolStripMenuItem_Click
				Dim flag As Boolean = Me._AboutToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._AboutToolStripMenuItem.Click, eventHandler
				End If
				Me._AboutToolStripMenuItem = value
				flag = Me._AboutToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._AboutToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170003AD RID: 941
		' (get) Token: 0x06000B20 RID: 2848 RVA: 0x03DC2C74 File Offset: 0x03DC1074
		' (set) Token: 0x06000B21 RID: 2849 RVA: 0x03DC2C8C File Offset: 0x03DC108C
		Friend Overridable Property NOMenuToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._NOMenuToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._NOMenuToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x170003AE RID: 942
		' (get) Token: 0x06000B22 RID: 2850 RVA: 0x03DC2C98 File Offset: 0x03DC1098
		' (set) Token: 0x06000B23 RID: 2851 RVA: 0x03DC2CB0 File Offset: 0x03DC10B0
		Friend Overridable Property NOMenuToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._NOMenuToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.NOMenuToolStripMenuItem1_Click
				Dim flag As Boolean = Me._NOMenuToolStripMenuItem1 IsNot Nothing
				If flag Then
					RemoveHandler Me._NOMenuToolStripMenuItem1.Click, eventHandler
				End If
				Me._NOMenuToolStripMenuItem1 = value
				flag = Me._NOMenuToolStripMenuItem1 IsNot Nothing
				If flag Then
					AddHandler Me._NOMenuToolStripMenuItem1.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170003AF RID: 943
		' (get) Token: 0x06000B24 RID: 2852 RVA: 0x03DC2D10 File Offset: 0x03DC1110
		' (set) Token: 0x06000B25 RID: 2853 RVA: 0x03DC2D28 File Offset: 0x03DC1128
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

		' Token: 0x170003B0 RID: 944
		' (get) Token: 0x06000B26 RID: 2854 RVA: 0x03DC2D88 File Offset: 0x03DC1188
		' (set) Token: 0x06000B27 RID: 2855 RVA: 0x03DC2DA0 File Offset: 0x03DC11A0
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

		' Token: 0x170003B1 RID: 945
		' (get) Token: 0x06000B28 RID: 2856 RVA: 0x03DC2E00 File Offset: 0x03DC1200
		' (set) Token: 0x06000B29 RID: 2857 RVA: 0x03DC2E18 File Offset: 0x03DC1218
		Friend Overridable Property Button3 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button3 = value
			End Set
		End Property

		' Token: 0x170003B2 RID: 946
		' (get) Token: 0x06000B2A RID: 2858 RVA: 0x03DC2E24 File Offset: 0x03DC1224
		' (set) Token: 0x06000B2B RID: 2859 RVA: 0x03DC2E3C File Offset: 0x03DC123C
		Friend Overridable Property Button4 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button4 = value
			End Set
		End Property

		' Token: 0x170003B3 RID: 947
		' (get) Token: 0x06000B2C RID: 2860 RVA: 0x03DC2E48 File Offset: 0x03DC1248
		' (set) Token: 0x06000B2D RID: 2861 RVA: 0x03DC2E60 File Offset: 0x03DC1260
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

		' Token: 0x170003B4 RID: 948
		' (get) Token: 0x06000B2E RID: 2862 RVA: 0x03DC2EC0 File Offset: 0x03DC12C0
		' (set) Token: 0x06000B2F RID: 2863 RVA: 0x03DC2ED8 File Offset: 0x03DC12D8
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

		' Token: 0x170003B5 RID: 949
		' (get) Token: 0x06000B30 RID: 2864 RVA: 0x03DC2F38 File Offset: 0x03DC1338
		' (set) Token: 0x06000B31 RID: 2865 RVA: 0x03DC2F50 File Offset: 0x03DC1350
		Friend Overridable Property ProgressBar1 As ProgressBar
			<DebuggerNonUserCode()>
			Get
				Return Me._ProgressBar1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ProgressBar)
				Me._ProgressBar1 = value
			End Set
		End Property

		' Token: 0x170003B6 RID: 950
		' (get) Token: 0x06000B32 RID: 2866 RVA: 0x03DC2F5C File Offset: 0x03DC135C
		' (set) Token: 0x06000B33 RID: 2867 RVA: 0x03DC2F74 File Offset: 0x03DC1374
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

		' Token: 0x06000B34 RID: 2868 RVA: 0x03DC2FD4 File Offset: 0x03DC13D4
		Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Restartform.Show()
		End Sub

		' Token: 0x06000B35 RID: 2869 RVA: 0x03DC2FE8 File Offset: 0x03DC13E8
		Private Sub SToolStripMenuItem_Click(sender As Object, e As EventArgs)
			ProjectData.EndApp()
		End Sub

		' Token: 0x06000B36 RID: 2870 RVA: 0x03DC2FF4 File Offset: 0x03DC13F4
		Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox15.Show()
		End Sub

		' Token: 0x06000B37 RID: 2871 RVA: 0x03DC3008 File Offset: 0x03DC1408
		Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000B38 RID: 2872 RVA: 0x03DC3014 File Offset: 0x03DC1414
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form19.Close()
		End Sub

		' Token: 0x06000B39 RID: 2873 RVA: 0x03DC3028 File Offset: 0x03DC1428
		Private Sub Form25_Load(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not MyProject.Forms.Form19.Button1.Visible
			If flag Then
				Me.Button1.Visible = False
			End If
			flag = Not MyProject.Forms.Form14.Button1.Visible
			If flag Then
				Me.Button2.Visible = False
			End If
			flag = Not MyProject.Forms.Form24.Panel1.Visible
			If flag Then
				Me.Button3.Visible = False
			End If
		End Sub

		' Token: 0x06000B3A RID: 2874 RVA: 0x03DC30B4 File Offset: 0x03DC14B4
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form14.Close()
		End Sub

		' Token: 0x06000B3B RID: 2875 RVA: 0x03DC30C8 File Offset: 0x03DC14C8
		Private Sub NOMenuToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox16.Show()
		End Sub

		' Token: 0x06000B3C RID: 2876 RVA: 0x03DC30DC File Offset: 0x03DC14DC
		Private Sub NewTaskToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox17.Show()
		End Sub

		' Token: 0x06000B3D RID: 2877 RVA: 0x03DC30F0 File Offset: 0x03DC14F0
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			MyProject.Forms.form1Pad.Close()
		End Sub

		' Token: 0x06000B3E RID: 2878 RVA: 0x03DC3104 File Offset: 0x03DC1504
		Private Sub Button6_Click(sender As Object, e As EventArgs)
			Dim visible As Boolean = MyProject.Forms.form1Pad.cvtaskbar.Visible
			If visible Then
				MyProject.Forms.form1Pad.cvtaskbar.Visible = False
				Me.Button6.Text = "form1Pad.exe start taskbar"
			Else
				Me.Cursor = Cursors.AppStarting
				Me.Timer1.Start()
			End If
		End Sub

		' Token: 0x06000B3F RID: 2879 RVA: 0x03DC3170 File Offset: 0x03DC1570
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar1.Increment(2)
			Dim flag As Boolean = Me.ProgressBar1.Value = 5
			If flag Then
				Me.Cursor = Cursors.AppStarting
			End If
			flag = Me.ProgressBar1.Value = 30
			If flag Then
				Me.Cursor = Cursors.[Default]
				MyProject.Forms.form1Pad.cvtaskbar.Visible = True
				Me.Timer1.[Stop]()
				Me.ProgressBar1.Value = 0
				Me.Button6.Text = "form1Pad.exe stop taskbar"
			End If
		End Sub

		' Token: 0x0400040F RID: 1039
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000411 RID: 1041
		<AccessedThroughProperty("MenuStrip1")>
		Private _MenuStrip1 As MenuStrip

		' Token: 0x04000412 RID: 1042
		<AccessedThroughProperty("FileToolStripMenuItem")>
		Private _FileToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000413 RID: 1043
		<AccessedThroughProperty("OptionsToolStripMenuItem")>
		Private _OptionsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000414 RID: 1044
		<AccessedThroughProperty("NewTaskToolStripMenuItem")>
		Private _NewTaskToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000415 RID: 1045
		<AccessedThroughProperty("ExitToolStripMenuItem")>
		Private _ExitToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000416 RID: 1046
		<AccessedThroughProperty("ViewToolStripMenuItem")>
		Private _ViewToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000417 RID: 1047
		<AccessedThroughProperty("ProgramToolStripMenuItem")>
		Private _ProgramToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000418 RID: 1048
		<AccessedThroughProperty("HelpToolStripMenuItem")>
		Private _HelpToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000419 RID: 1049
		<AccessedThroughProperty("RestartToolStripMenuItem")>
		Private _RestartToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400041A RID: 1050
		<AccessedThroughProperty("SToolStripMenuItem")>
		Private _SToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400041B RID: 1051
		<AccessedThroughProperty("AboutToolStripMenuItem")>
		Private _AboutToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400041C RID: 1052
		<AccessedThroughProperty("NOMenuToolStripMenuItem")>
		Private _NOMenuToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400041D RID: 1053
		<AccessedThroughProperty("NOMenuToolStripMenuItem1")>
		Private _NOMenuToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x0400041E RID: 1054
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400041F RID: 1055
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x04000420 RID: 1056
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x04000421 RID: 1057
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x04000422 RID: 1058
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x04000423 RID: 1059
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x04000424 RID: 1060
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x04000425 RID: 1061
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer
	End Class
End Namespace
