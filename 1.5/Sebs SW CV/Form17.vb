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
	' Token: 0x0200003B RID: 59
	<DesignerGenerated()>
	Public Partial Class Form17
		Inherits Form

		' Token: 0x0600072A RID: 1834 RVA: 0x03DA59FC File Offset: 0x03DA3DFC
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form17_Load
			Dim _ENCList As List(Of WeakReference) = Form17.__ENCList
			SyncLock _ENCList
				Form17.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000268 RID: 616
		' (get) Token: 0x0600072D RID: 1837 RVA: 0x03DA5FA0 File Offset: 0x03DA43A0
		' (set) Token: 0x0600072E RID: 1838 RVA: 0x03DA5FB8 File Offset: 0x03DA43B8
		Friend Overridable Property RichTextBox1 As RichTextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._RichTextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Dim eventHandler As EventHandler = AddressOf Me.RichTextBox1_TextChanged
				Dim flag As Boolean = Me._RichTextBox1 IsNot Nothing
				If flag Then
					RemoveHandler Me._RichTextBox1.TextChanged, eventHandler
				End If
				Me._RichTextBox1 = value
				flag = Me._RichTextBox1 IsNot Nothing
				If flag Then
					AddHandler Me._RichTextBox1.TextChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000269 RID: 617
		' (get) Token: 0x0600072F RID: 1839 RVA: 0x03DA6018 File Offset: 0x03DA4418
		' (set) Token: 0x06000730 RID: 1840 RVA: 0x03DA6030 File Offset: 0x03DA4430
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

		' Token: 0x1700026A RID: 618
		' (get) Token: 0x06000731 RID: 1841 RVA: 0x03DA6090 File Offset: 0x03DA4490
		' (set) Token: 0x06000732 RID: 1842 RVA: 0x03DA60A8 File Offset: 0x03DA44A8
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

		' Token: 0x1700026B RID: 619
		' (get) Token: 0x06000733 RID: 1843 RVA: 0x03DA60B4 File Offset: 0x03DA44B4
		' (set) Token: 0x06000734 RID: 1844 RVA: 0x03DA60CC File Offset: 0x03DA44CC
		Friend Overridable Property SettingsToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SettingsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._SettingsToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x1700026C RID: 620
		' (get) Token: 0x06000735 RID: 1845 RVA: 0x03DA60D8 File Offset: 0x03DA44D8
		' (set) Token: 0x06000736 RID: 1846 RVA: 0x03DA60F0 File Offset: 0x03DA44F0
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

		' Token: 0x1700026D RID: 621
		' (get) Token: 0x06000737 RID: 1847 RVA: 0x03DA6150 File Offset: 0x03DA4550
		' (set) Token: 0x06000738 RID: 1848 RVA: 0x03DA6168 File Offset: 0x03DA4568
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

		' Token: 0x1700026E RID: 622
		' (get) Token: 0x06000739 RID: 1849 RVA: 0x03DA61C8 File Offset: 0x03DA45C8
		' (set) Token: 0x0600073A RID: 1850 RVA: 0x03DA61E0 File Offset: 0x03DA45E0
		Friend Overridable Property WindowsCMDToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._WindowsCMDToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.WindowsCMDToolStripMenuItem_Click
				Dim flag As Boolean = Me._WindowsCMDToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._WindowsCMDToolStripMenuItem.Click, eventHandler
				End If
				Me._WindowsCMDToolStripMenuItem = value
				flag = Me._WindowsCMDToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._WindowsCMDToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700026F RID: 623
		' (get) Token: 0x0600073B RID: 1851 RVA: 0x03DA6240 File Offset: 0x03DA4640
		' (set) Token: 0x0600073C RID: 1852 RVA: 0x03DA6258 File Offset: 0x03DA4658
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

		' Token: 0x17000270 RID: 624
		' (get) Token: 0x0600073D RID: 1853 RVA: 0x03DA6264 File Offset: 0x03DA4664
		' (set) Token: 0x0600073E RID: 1854 RVA: 0x03DA627C File Offset: 0x03DA467C
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

		' Token: 0x17000271 RID: 625
		' (get) Token: 0x0600073F RID: 1855 RVA: 0x03DA62DC File Offset: 0x03DA46DC
		' (set) Token: 0x06000740 RID: 1856 RVA: 0x03DA62F4 File Offset: 0x03DA46F4
		Friend Overridable Property ToolStripMenuItem2 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.ToolStripMenuItem2_Click
				Dim flag As Boolean = Me._ToolStripMenuItem2 IsNot Nothing
				If flag Then
					RemoveHandler Me._ToolStripMenuItem2.Click, eventHandler
				End If
				Me._ToolStripMenuItem2 = value
				flag = Me._ToolStripMenuItem2 IsNot Nothing
				If flag Then
					AddHandler Me._ToolStripMenuItem2.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000272 RID: 626
		' (get) Token: 0x06000741 RID: 1857 RVA: 0x03DA6354 File Offset: 0x03DA4754
		' (set) Token: 0x06000742 RID: 1858 RVA: 0x03DA636C File Offset: 0x03DA476C
		Friend Overridable Property Timer2 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._Timer2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim eventHandler As EventHandler = AddressOf Me.Timer2_Tick
				Dim flag As Boolean = Me._Timer2 IsNot Nothing
				If flag Then
					RemoveHandler Me._Timer2.Tick, eventHandler
				End If
				Me._Timer2 = value
				flag = Me._Timer2 IsNot Nothing
				If flag Then
					AddHandler Me._Timer2.Tick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x06000743 RID: 1859 RVA: 0x03DA63CC File Offset: 0x03DA47CC
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/Lions explorer2", False) = 0
			If flag Then
				MyProject.Forms.Form19.Show()
				MyProject.Forms.Form19.Button6.Enabled = True
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/Old-CMD", False) = 0
			If flag Then
				Me.MenuStrip1.Visible = False
				Me.RichTextBox1.Text = "C:/Sebs-SW"
				Me.Text = "CMD"
				Me.Timer2.Start()
				Me.Timer1.[Stop]()
				flag = MyProject.Forms.Form1.Button1.Visible
				If Not flag Then
					flag = Interaction.MsgBox("You need Form1. Start Form1", MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.Yes
					If flag Then
						MyProject.Forms.Form1.Show()
					End If
				End If
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/restart -mi", False) = 0
			If flag Then
				MyProject.Forms.Form33.Show()
				MyProject.Forms.Form33.Label4.Text = "1"
				Me.RichTextBox1.Text = "C:/Sebs-SW-CV/restart -mi - Done"
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/install CP1.0 -1", False) = 0
			If flag Then
				MyProject.Forms.Form5.Show()
				Me.RichTextBox1.Text = "C:/Sebs-SW-CV/install CP1.0 - Done"
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/ONKey", False) = 0
			If flag Then
				MyProject.Forms.Form60.Show()
				Me.RichTextBox1.Text = "C:/Sebs-SW-CV/ONKey - Done"
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/explorer", False) = 0
			If flag Then
				MyProject.Forms.Form1.Show()
				MyProject.Forms.Form1.Timer3.Start()
				Me.RichTextBox1.Text = "C:/Sebs-SW-CV/explorer - Done"
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/install CMD-internet++", False) = 0
			If flag Then
				MyProject.Forms.Form35.Show()
				Me.RichTextBox1.Text = "C:/Sebs-SW-CV/install CMD-internet++ - Done"
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/sebs sw b", False) = 0
			If flag Then
				Me.RichTextBox1.Text = "C:/Sebs-SW-CV/sebs sw b - Done"
				flag = Interaction.MsgBox("back old default wallpaper", MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.Yes
				If flag Then
					MyProject.Forms.form1Pad.Picture6.Visible = False
					MyProject.Forms.form1Pad.Picture1.Visible = True
					MyProject.Forms.form1Pad.Picture6.SizeMode = PictureBoxSizeMode.StretchImage
				End If
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/13.F", False) = 0
			If flag Then
				MyProject.Forms.form1Pad.Panel1.BackColor = Color.DarkGray
				Me.RichTextBox1.Text = "C:/Sebs-SW-CV"
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/taskman", False) = 0
			If flag Then
				MyProject.Forms.Form25.Show()
				Me.RichTextBox1.Text = "C:/Sebs-SW-CV/taskman - Done"
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/Time13", False) = 0
			If flag Then
				MyProject.Forms.form1Pad.Label3.Text = "fredag:13"
				Me.RichTextBox1.Text = "C:/Sebs-SW-CV/Time13 - Done"
				Me.RichTextBox1.Font = New Font("Trebuchet MS", 18F)
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/B1", False) = 0
			If flag Then
				MyProject.Forms.Loginz.Show()
				Me.RichTextBox1.Text = "C:/Sebs-SW-CV/B1 - Done"
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/Time13", False) = 0
			If flag Then
				Me.RichTextBox1.Font = New Font("Trebuchet MS", 18F)
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/CMD2", False) = 0
			If flag Then
				MyProject.Forms.cmdpad.Show()
				Me.RichTextBox1.Text = "C:/Sebs-SW-CV/CMD2 - Done"
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/Dev -d -f exit", False) = 0
			Dim flag2 As Boolean
			If flag Then
				flag2 = Interaction.MsgBox("Exit Yes or No", MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.Yes
				If flag2 Then
					MyProject.Forms.form1Pad.Label11.Text = "Dev = false"
					Me.RichTextBox1.Text = "C:/Sebs-SW-CV/Dev -d -f exit - Done"
				Else
					Me.RichTextBox1.Text = "C:/Sebs-SW-CV/Dev -d -f exit - Stopped"
				End If
			End If
			flag2 = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/LogTime13", False) = 0
			If flag2 Then
				MyProject.Forms.form1Pad.Panel3.Visible = True
				Me.RichTextBox1.Text = "C:/Sebs-SW-CV/LogTime13 - Done"
			End If
			flag2 = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/startup", False) = 0
			If flag2 Then
				flag = MyProject.Forms.Form33.Label1.Visible
				If flag Then
					Me.RichTextBox1.Text = "C:/Sebs-SW-CV/startup - Fail"
					Interaction.MsgBox("Sorry Fail to go to Startup", MsgBoxStyle.Critical, Nothing)
				Else
					MyProject.Forms.Form48.Show()
					Me.Close()
				End If
			End If
			flag2 = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/help", False) = 0
			If flag2 Then
				MyProject.Forms.Form15.Show()
				MyProject.Forms.Form15.Show()
				MyProject.Forms.Form15.Show()
				MyProject.Forms.Form15.TextBox1.[ReadOnly] = True
				MyProject.Forms.Form15.WindowState = FormWindowState.Normal
				MyProject.Forms.Form15.TextBox1.Text = "C:/Sebs-SW-CV/install .exe" & vbCrLf & "C:/Sebs-SW-CV/explorer" & vbCrLf & "C:/Sebs-SW-CV/install CMD-internet++" & vbCrLf & "C:/Sebs-SW-CV/13.F" & vbCrLf & "C:/Sebs-SW-CV/Time13" & vbCrLf & "C:/Sebs-SW-CV/13.F" & vbCrLf & "C:/Sebs-SW-CV/LogTime13" & vbCrLf & "C:/Sebs-SW-CV/startup" & vbCrLf & "C:/Sebs-SW-CV/taskman"
				MyProject.Forms.Form39.LinkLabel1.Enabled = False
				Me.RichTextBox1.Text = "C:/Sebs-SW-CV/help - Done"
			End If
			flag2 = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW-CV/back", False) = 0
			If flag2 Then
				MyProject.Forms.Form15.Show()
				MyProject.Forms.Form15.TextBox1.Text = "Dev 18 - add new Form1-pad"
				MyProject.Forms.Form15.TextBox1.Text = "Dev 18 - add new Form1-pad"
				MyProject.Forms.Form15.TextBox1.Text = "Dev 18 - add new Form1-pad"
				MyProject.Forms.Form15.TextBox1.Text = "Dev 18 - add new Form1-pad"
				MyProject.Forms.Form15.TextBox1.Text = "Dev 18 - add new Form1-pad"
				MyProject.Forms.Form15.TextBox1.[ReadOnly] = True
				Me.RichTextBox1.Text = "C:/"
			End If
			flag2 = Operators.CompareString(Me.RichTextBox1.Text, "C:/Form1_pad", False) = 0
			If flag2 Then
				MyProject.Forms.Form_1pad.Show()
				Me.RichTextBox1.Text = "C:/Dev Error"
			End If
			flag2 = Operators.CompareString(Me.RichTextBox1.Text, "C:/form1pad", False) = 0
			If flag2 Then
				MyProject.Forms.form1Pad.Show()
				Me.RichTextBox1.Text = "C:/Dev Error"
			End If
			flag2 = Operators.CompareString(Me.RichTextBox1.Text, "C:/settings", False) = 0
			If flag2 Then
				Me.RichTextBox1.Text = "C:/settings "
				flag2 = Interaction.MsgBox("New settings", MsgBoxStyle.OkOnly, Nothing) = MsgBoxResult.Yes
				If flag2 Then
					MyProject.Forms.Form39.Show()
				Else
					MyProject.Forms.Form21.Show()
				End If
				Me.RichTextBox1.Text = "C:/Dev Error"
			End If
			flag2 = Me.RichTextBox1.ForeColor = Color.Black
			If flag2 Then
				Me.RichTextBox1.ForeColor = Color.White
			End If
		End Sub

		' Token: 0x06000744 RID: 1860 RVA: 0x03DA6C30 File Offset: 0x03DA5030
		Private Sub Form17_Load(sender As Object, e As EventArgs)
			Me.Timer1.Start()
		End Sub

		' Token: 0x06000745 RID: 1861 RVA: 0x03DA6C40 File Offset: 0x03DA5040
		Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.FontDialog1.ShowDialog() = DialogResult.OK
			If flag Then
				Me.RichTextBox1.Font = Me.FontDialog1.Font
				Me.RichTextBox1.ForeColor = Me.FontDialog1.Color
			End If
		End Sub

		' Token: 0x06000746 RID: 1862 RVA: 0x03DA6C90 File Offset: 0x03DA5090
		Private Sub FontDialog1_Apply(sender As Object, e As EventArgs)
			Me.RichTextBox1.Font = Me.FontDialog1.Font
			Me.RichTextBox1.ForeColor = Me.FontDialog1.Color
		End Sub

		' Token: 0x06000747 RID: 1863 RVA: 0x03DA6CC4 File Offset: 0x03DA50C4
		Private Sub WindowsCMDToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Process.Start("cmd.exe")
		End Sub

		' Token: 0x06000748 RID: 1864 RVA: 0x03DA6CD4 File Offset: 0x03DA50D4
		Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000749 RID: 1865 RVA: 0x03DA6CE0 File Offset: 0x03DA50E0
		Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)
			Me.SettingsToolStripMenuItem.HideDropDown()
		End Sub

		' Token: 0x0600074A RID: 1866 RVA: 0x03DA6CF0 File Offset: 0x03DA50F0
		Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
			Me.RichTextBox1.Text = MyProject.Forms.Form60.TextBox1.Text + Strings.Replace(Conversions.ToString(NewLateBinding.LateGet(sender, Nothing, "text", New Object(-1) {}, Nothing, Nothing, Nothing)), "CmD", "C:/Sebs-SW-CV/", 1, -1, CompareMethod.Binary)
		End Sub

		' Token: 0x0600074B RID: 1867 RVA: 0x03DA6D50 File Offset: 0x03DA5150
		Private Sub Timer2_Tick(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW/Lions explorer2", False) = 0
			If flag Then
				MyProject.Forms.Form19.Show()
				MyProject.Forms.Form19.Button6.Enabled = True
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW/install CP1.0 -1", False) = 0
			If flag Then
				MyProject.Forms.Form5.Show()
				Me.RichTextBox1.Text = "C:/Sebs-SW/install CP1.0 - Done"
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW/restart -mi", False) = 0
			If flag Then
				MyProject.Forms.Form33.Show()
				MyProject.Forms.Form33.Label1.Text = "Restart"
				Me.RichTextBox1.Text = "C:/Sebs-SW/restart -mi - Done"
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW/download update 2.8", False) = 0
			If flag Then
				MyProject.Forms.Form8.Show()
				Me.RichTextBox1.Text = "C:/Sebs-SW/download update 2.8 - Done"
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "SW.???.About", False) = 0
			If flag Then
				Me.RichTextBox1.Text = "C:/Sebs-SW"
				Interaction.MsgBox("??? is an Error for Programs in Sebs SW (Sebs Web)", MsgBoxStyle.OkOnly, Nothing)
				Me.RichTextBox1.Text = "C:/Sebs-SW"
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW/download update sebs sw b -1", False) = 0
			If flag Then
				MyProject.Forms.Form1.Text = "Sebs SW B"
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW/sebs sw b", False) = 0
			If flag Then
				Me.RichTextBox1.Text = "C:/Sebs-SW/sebs sw b - Done"
				Interaction.MsgBox("Program Builder is activated-Sebs SW B", MsgBoxStyle.Information, Nothing)
				MyProject.Forms.Form1.Text = "Sebs SW B"
				Me.RichTextBox1.Text = "C:/Sebs-SW/sebs sw b - Done"
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW/New User Program", False) = 0
			If flag Then
				Me.RichTextBox1.Text = "C:/Sebs-SW/New User Program - Done"
				MyProject.Forms.Form1.Text = "Sebs SW 3.6"
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW/download Lions1.0 -install", False) = 0
			If flag Then
				MyProject.Forms.AboutBox12.Show()
				MyProject.Forms.Form9.Show()
				MyProject.Forms.Form1.Panel1.Visible = False
				MyProject.Forms.Form1.Panel3.Visible = False
				MyProject.Forms.Form1.Panel4.Visible = False
				Me.RichTextBox1.Text = "C:/Sebs-SW/download Lions1.0 -install - Done"
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW/download Lions2.0 -install", False) = 0
			If flag Then
				MyProject.Forms.AboutBox11.Show()
				MyProject.Forms.Form1.Panel1.Visible = False
				MyProject.Forms.Form1.Panel3.Visible = False
				MyProject.Forms.Form1.Panel4.Visible = False
				Me.RichTextBox1.Text = "C:/Sebs-SW/download Lions2.0 -install - Done"
			End If
			flag = Operators.CompareString(Me.RichTextBox1.Text, "C:/Sebs-SW/OLD WEB", False) = 0
			If flag Then
				MyProject.Forms.Form35.Show()
				MyProject.Forms.Form35.Panel5.Visible = False
				Me.RichTextBox1.Text = "C:/Sebs-SW/OLD WEB - Done"
			End If
			flag = Me.RichTextBox1.ForeColor = Color.Black
			If flag Then
				Me.RichTextBox1.ForeColor = Color.White
			End If
		End Sub

		' Token: 0x040002BA RID: 698
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040002BC RID: 700
		<AccessedThroughProperty("RichTextBox1")>
		Private _RichTextBox1 As RichTextBox

		' Token: 0x040002BD RID: 701
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x040002BE RID: 702
		<AccessedThroughProperty("MenuStrip1")>
		Private _MenuStrip1 As MenuStrip

		' Token: 0x040002BF RID: 703
		<AccessedThroughProperty("SettingsToolStripMenuItem")>
		Private _SettingsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040002C0 RID: 704
		<AccessedThroughProperty("FontToolStripMenuItem")>
		Private _FontToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040002C1 RID: 705
		<AccessedThroughProperty("FontDialog1")>
		Private _FontDialog1 As FontDialog

		' Token: 0x040002C2 RID: 706
		<AccessedThroughProperty("WindowsCMDToolStripMenuItem")>
		Private _WindowsCMDToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040002C3 RID: 707
		<AccessedThroughProperty("ToolStripSeparator1")>
		Private _ToolStripSeparator1 As ToolStripSeparator

		' Token: 0x040002C4 RID: 708
		<AccessedThroughProperty("ExitToolStripMenuItem")>
		Private _ExitToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040002C5 RID: 709
		<AccessedThroughProperty("ToolStripMenuItem2")>
		Private _ToolStripMenuItem2 As ToolStripMenuItem

		' Token: 0x040002C6 RID: 710
		<AccessedThroughProperty("Timer2")>
		Private _Timer2 As Timer
	End Class
End Namespace
