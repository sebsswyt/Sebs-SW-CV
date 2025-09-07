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
	' Token: 0x0200005F RID: 95
	<DesignerGenerated()>
	Public Partial Class Form48
		Inherits Form

		' Token: 0x0600103F RID: 4159 RVA: 0x03DE555C File Offset: 0x03DE395C
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form48_Load
			Dim _ENCList As List(Of WeakReference) = Form48.__ENCList
			SyncLock _ENCList
				Form48.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700055B RID: 1371
		' (get) Token: 0x06001042 RID: 4162 RVA: 0x03DE5E8C File Offset: 0x03DE428C
		' (set) Token: 0x06001043 RID: 4163 RVA: 0x03DE5EA4 File Offset: 0x03DE42A4
		Friend Overridable Property Label1 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label1 = value
			End Set
		End Property

		' Token: 0x1700055C RID: 1372
		' (get) Token: 0x06001044 RID: 4164 RVA: 0x03DE5EB0 File Offset: 0x03DE42B0
		' (set) Token: 0x06001045 RID: 4165 RVA: 0x03DE5EC8 File Offset: 0x03DE42C8
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

		' Token: 0x1700055D RID: 1373
		' (get) Token: 0x06001046 RID: 4166 RVA: 0x03DE5F28 File Offset: 0x03DE4328
		' (set) Token: 0x06001047 RID: 4167 RVA: 0x03DE5F40 File Offset: 0x03DE4340
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

		' Token: 0x1700055E RID: 1374
		' (get) Token: 0x06001048 RID: 4168 RVA: 0x03DE5F4C File Offset: 0x03DE434C
		' (set) Token: 0x06001049 RID: 4169 RVA: 0x03DE5F64 File Offset: 0x03DE4364
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

		' Token: 0x1700055F RID: 1375
		' (get) Token: 0x0600104A RID: 4170 RVA: 0x03DE5FC4 File Offset: 0x03DE43C4
		' (set) Token: 0x0600104B RID: 4171 RVA: 0x03DE5FDC File Offset: 0x03DE43DC
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

		' Token: 0x17000560 RID: 1376
		' (get) Token: 0x0600104C RID: 4172 RVA: 0x03DE5FE8 File Offset: 0x03DE43E8
		' (set) Token: 0x0600104D RID: 4173 RVA: 0x03DE6000 File Offset: 0x03DE4400
		Friend Overridable Property SToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._SToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000561 RID: 1377
		' (get) Token: 0x0600104E RID: 4174 RVA: 0x03DE600C File Offset: 0x03DE440C
		' (set) Token: 0x0600104F RID: 4175 RVA: 0x03DE6024 File Offset: 0x03DE4424
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

		' Token: 0x17000562 RID: 1378
		' (get) Token: 0x06001050 RID: 4176 RVA: 0x03DE6084 File Offset: 0x03DE4484
		' (set) Token: 0x06001051 RID: 4177 RVA: 0x03DE609C File Offset: 0x03DE449C
		Friend Overridable Property ShutdownToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ShutdownToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.ShutdownToolStripMenuItem_Click
				Dim flag As Boolean = Me._ShutdownToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._ShutdownToolStripMenuItem.Click, eventHandler
				End If
				Me._ShutdownToolStripMenuItem = value
				flag = Me._ShutdownToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._ShutdownToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000563 RID: 1379
		' (get) Token: 0x06001052 RID: 4178 RVA: 0x03DE60FC File Offset: 0x03DE44FC
		' (set) Token: 0x06001053 RID: 4179 RVA: 0x03DE6114 File Offset: 0x03DE4514
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

		' Token: 0x17000564 RID: 1380
		' (get) Token: 0x06001054 RID: 4180 RVA: 0x03DE6120 File Offset: 0x03DE4520
		' (set) Token: 0x06001055 RID: 4181 RVA: 0x03DE6138 File Offset: 0x03DE4538
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

		' Token: 0x17000565 RID: 1381
		' (get) Token: 0x06001056 RID: 4182 RVA: 0x03DE6198 File Offset: 0x03DE4598
		' (set) Token: 0x06001057 RID: 4183 RVA: 0x03DE61B0 File Offset: 0x03DE45B0
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

		' Token: 0x06001058 RID: 4184 RVA: 0x03DE6210 File Offset: 0x03DE4610
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.TextBox1.Text, "dev111", False) = 0
			If flag Then
				Interaction.MsgBox("Welcome Dev User to new user interface", MsgBoxStyle.OkOnly, Nothing)
				MyProject.Forms.Form_1pad.Show()
				Me.Close()
			Else
				flag = Operators.CompareString(Me.TextBox1.Text, "CMD", False) = 0
				If flag Then
					Dim form As Form17 = New Form17()
					form.Show()
				Else
					flag = Operators.CompareString(Me.TextBox1.Text, "admin", False) = 0
					If flag Then
						Dim form1Pad As form1Pad = New form1Pad()
						form1Pad.Show()
						form1Pad.NO1.Visible = True
						form1Pad.NO1.Text = "Your a Admin ;)"
					End If
				End If
				MyProject.Forms.form1Pad.Show()
				flag = MyProject.Forms.AboutBox22.PictureBox2.Visible
				If flag Then
					MyProject.Forms.form1Pad.Picture1.Visible = False
					MyProject.Forms.form1Pad.Picture2.Visible = True
				Else
					flag = MyProject.Forms.AboutBox22.PictureBox3.Visible
					If flag Then
						MyProject.Forms.form1Pad.Picture1.Visible = False
						MyProject.Forms.form1Pad.Picture3.Visible = True
					Else
						flag = MyProject.Forms.AboutBox22.PictureBox4.Visible
						If flag Then
							MyProject.Forms.form1Pad.Picture1.Visible = False
							MyProject.Forms.form1Pad.Picture4.Visible = True
						Else
							flag = MyProject.Forms.AboutBox22.PictureBox5.Visible
							If flag Then
								MyProject.Forms.form1Pad.Picture1.Visible = False
								MyProject.Forms.form1Pad.Picture5.Visible = True
							Else
								flag = MyProject.Forms.AboutBox22.PictureBox6.Visible
								If flag Then
									MyProject.Forms.form1Pad.Picture1.Visible = False
									MyProject.Forms.form1Pad.Picture6.Visible = True
									MyProject.Forms.form1Pad.Picture6.Image = MyProject.Forms.AboutBox22.PictureBox6.Image
								End If
							End If
						End If
					End If
				End If
				Me.Close()
			End If
		End Sub

		' Token: 0x06001059 RID: 4185 RVA: 0x03DE6494 File Offset: 0x03DE4894
		Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form57.Show()
			MyProject.Forms.Form57.RestartTimer.Start()
		End Sub

		' Token: 0x0600105A RID: 4186 RVA: 0x03DE64C0 File Offset: 0x03DE48C0
		Private Sub ShutdownToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form33.Show()
			MyProject.Forms.Form33.Timer3.[Stop]()
			MyProject.Forms.Form33.Timer2.Start()
		End Sub

		' Token: 0x0600105B RID: 4187 RVA: 0x03DE6500 File Offset: 0x03DE4900
		Private Sub Form48_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600105C RID: 4188 RVA: 0x03DE6504 File Offset: 0x03DE4904
		Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600105D RID: 4189 RVA: 0x03DE6508 File Offset: 0x03DE4908
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.TextBox1.Text, "admin", False) = 0
			If flag Then
				Interaction.MsgBox("Velkommen Sebastian", MsgBoxStyle.OkOnly, Nothing)
				MyProject.Forms.Form_1pad.Show()
				Me.Close()
			Else
				MyProject.Forms.Form53.Show()
			End If
		End Sub

		' Token: 0x0600105E RID: 4190 RVA: 0x03DE656C File Offset: 0x03DE496C
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Interaction.MsgBox("Restart program", MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.Yes
			If flag Then
			End If
		End Sub

		' Token: 0x04000601 RID: 1537
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000603 RID: 1539
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000604 RID: 1540
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x04000605 RID: 1541
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x04000606 RID: 1542
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000607 RID: 1543
		<AccessedThroughProperty("MenuStrip1")>
		Private _MenuStrip1 As MenuStrip

		' Token: 0x04000608 RID: 1544
		<AccessedThroughProperty("SToolStripMenuItem")>
		Private _SToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000609 RID: 1545
		<AccessedThroughProperty("RestartToolStripMenuItem")>
		Private _RestartToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400060A RID: 1546
		<AccessedThroughProperty("ShutdownToolStripMenuItem")>
		Private _ShutdownToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400060B RID: 1547
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x0400060C RID: 1548
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x0400060D RID: 1549
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button
	End Class
End Namespace
