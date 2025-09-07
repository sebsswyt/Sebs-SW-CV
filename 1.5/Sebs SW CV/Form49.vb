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
	' Token: 0x02000060 RID: 96
	<DesignerGenerated()>
	Public Partial Class Form49
		Inherits Form

		' Token: 0x06001060 RID: 4192 RVA: 0x03DE65A0 File Offset: 0x03DE49A0
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form49_Load
			Dim _ENCList As List(Of WeakReference) = Form49.__ENCList
			SyncLock _ENCList
				Form49.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000566 RID: 1382
		' (get) Token: 0x06001063 RID: 4195 RVA: 0x03DE6EC0 File Offset: 0x03DE52C0
		' (set) Token: 0x06001064 RID: 4196 RVA: 0x03DE6ED8 File Offset: 0x03DE52D8
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

		' Token: 0x17000567 RID: 1383
		' (get) Token: 0x06001065 RID: 4197 RVA: 0x03DE6EE4 File Offset: 0x03DE52E4
		' (set) Token: 0x06001066 RID: 4198 RVA: 0x03DE6EFC File Offset: 0x03DE52FC
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

		' Token: 0x17000568 RID: 1384
		' (get) Token: 0x06001067 RID: 4199 RVA: 0x03DE6F08 File Offset: 0x03DE5308
		' (set) Token: 0x06001068 RID: 4200 RVA: 0x03DE6F20 File Offset: 0x03DE5320
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

		' Token: 0x17000569 RID: 1385
		' (get) Token: 0x06001069 RID: 4201 RVA: 0x03DE6F2C File Offset: 0x03DE532C
		' (set) Token: 0x0600106A RID: 4202 RVA: 0x03DE6F44 File Offset: 0x03DE5344
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

		' Token: 0x1700056A RID: 1386
		' (get) Token: 0x0600106B RID: 4203 RVA: 0x03DE6F50 File Offset: 0x03DE5350
		' (set) Token: 0x0600106C RID: 4204 RVA: 0x03DE6F68 File Offset: 0x03DE5368
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

		' Token: 0x1700056B RID: 1387
		' (get) Token: 0x0600106D RID: 4205 RVA: 0x03DE6F74 File Offset: 0x03DE5374
		' (set) Token: 0x0600106E RID: 4206 RVA: 0x03DE6F8C File Offset: 0x03DE538C
		Friend Overridable Property PictureBox1 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox1 = value
			End Set
		End Property

		' Token: 0x1700056C RID: 1388
		' (get) Token: 0x0600106F RID: 4207 RVA: 0x03DE6F98 File Offset: 0x03DE5398
		' (set) Token: 0x06001070 RID: 4208 RVA: 0x03DE6FB0 File Offset: 0x03DE53B0
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

		' Token: 0x1700056D RID: 1389
		' (get) Token: 0x06001071 RID: 4209 RVA: 0x03DE7010 File Offset: 0x03DE5410
		' (set) Token: 0x06001072 RID: 4210 RVA: 0x03DE7028 File Offset: 0x03DE5428
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

		' Token: 0x1700056E RID: 1390
		' (get) Token: 0x06001073 RID: 4211 RVA: 0x03DE7034 File Offset: 0x03DE5434
		' (set) Token: 0x06001074 RID: 4212 RVA: 0x03DE704C File Offset: 0x03DE544C
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

		' Token: 0x1700056F RID: 1391
		' (get) Token: 0x06001075 RID: 4213 RVA: 0x03DE7058 File Offset: 0x03DE5458
		' (set) Token: 0x06001076 RID: 4214 RVA: 0x03DE7070 File Offset: 0x03DE5470
		Friend Overridable Property Label2 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim eventHandler As EventHandler = AddressOf Me.Label2_Click
				Dim flag As Boolean = Me._Label2 IsNot Nothing
				If flag Then
					RemoveHandler Me._Label2.Click, eventHandler
				End If
				Me._Label2 = value
				flag = Me._Label2 IsNot Nothing
				If flag Then
					AddHandler Me._Label2.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000570 RID: 1392
		' (get) Token: 0x06001077 RID: 4215 RVA: 0x03DE70D0 File Offset: 0x03DE54D0
		' (set) Token: 0x06001078 RID: 4216 RVA: 0x03DE70E8 File Offset: 0x03DE54E8
		Friend Overridable Property Label3 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label3 = value
			End Set
		End Property

		' Token: 0x17000571 RID: 1393
		' (get) Token: 0x06001079 RID: 4217 RVA: 0x03DE70F4 File Offset: 0x03DE54F4
		' (set) Token: 0x0600107A RID: 4218 RVA: 0x03DE710C File Offset: 0x03DE550C
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

		' Token: 0x0600107B RID: 4219 RVA: 0x03DE7118 File Offset: 0x03DE5518
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar1.Increment(1)
			Me.Label1.Text = Conversions.ToString(Me.ProgressBar1.Value)
			Dim flag As Boolean = Me.ProgressBar1.Value = 10
			If flag Then
				Me.Timer1.[Stop]()
				flag = MyProject.Forms.form1Pad.Picture1.Visible
				If flag Then
					Me.PictureBox1.Image = MyProject.Forms.form1Pad.Picture1.Image
				Else
					flag = MyProject.Forms.form1Pad.Picture2.Visible
					If flag Then
						Me.PictureBox2.Image = MyProject.Forms.form1Pad.Picture2.Image
					Else
						flag = MyProject.Forms.form1Pad.Picture3.Visible
						If flag Then
							Me.PictureBox3.Image = MyProject.Forms.form1Pad.Picture3.Image
						Else
							flag = MyProject.Forms.form1Pad.Picture4.Visible
							If flag Then
								Me.PictureBox4.Image = MyProject.Forms.form1Pad.Picture4.Image
							Else
								flag = MyProject.Forms.form1Pad.Picture5.Visible
								If flag Then
									Me.PictureBox5.Image = MyProject.Forms.form1Pad.Picture5.Image
								Else
									Me.PictureBox6.Image = MyProject.Forms.form1Pad.Picture6.Image
								End If
							End If
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x0600107C RID: 4220 RVA: 0x03DE72C8 File Offset: 0x03DE56C8
		Private Sub Form49_Load(sender As Object, e As EventArgs)
			Me.PictureBox1.Image = MyProject.Forms.form1Pad.Picture1.Image
			Me.PictureBox2.Image = MyProject.Forms.form1Pad.Picture2.Image
			Me.PictureBox3.Image = MyProject.Forms.form1Pad.Picture3.Image
			Me.PictureBox4.Image = MyProject.Forms.form1Pad.Picture4.Image
			Me.PictureBox5.Image = MyProject.Forms.form1Pad.Picture5.Image
			Me.PictureBox6.Image = MyProject.Forms.form1Pad.Picture6.Image
			Me.PictureBox7.Image = MyProject.Forms.form1Pad.Picture7.Image
			Dim flag As Boolean = MyProject.Forms.form1Pad.Picture1.Visible
			If flag Then
				Me.Label2.Text = "B1"
			Else
				flag = MyProject.Forms.form1Pad.Picture2.Visible
				If flag Then
					Me.Label2.Text = "B2"
				Else
					flag = MyProject.Forms.form1Pad.Picture3.Visible
					If flag Then
						Me.Label2.Text = "B3"
					Else
						flag = MyProject.Forms.form1Pad.Picture4.Visible
						If flag Then
							Me.Label2.Text = "B4"
						Else
							flag = MyProject.Forms.form1Pad.Picture5.Visible
							If flag Then
								Me.Label2.Text = "B5"
							Else
								flag = MyProject.Forms.form1Pad.Picture6.Visible
								If flag Then
									Me.Label2.Text = "B6"
									Me.PictureBox6.Image = MyProject.Forms.form1Pad.Picture6.Image
								Else
									flag = MyProject.Forms.form1Pad.Picture7.Visible
									If flag Then
										Me.Label2.Text = "B7"
										Me.PictureBox7.Image = MyProject.Forms.form1Pad.Picture7.Image
									Else
										Me.Label2.Text = "B1"
									End If
								End If
							End If
						End If
					End If
				End If
			End If
			flag = MyProject.Forms.form1Pad.Picture1.Visible
			If flag Then
				Me.PictureBox1.Image = MyProject.Forms.form1Pad.Picture1.Image
			Else
				flag = MyProject.Forms.form1Pad.Picture2.Visible
				If flag Then
					Me.PictureBox2.Image = MyProject.Forms.form1Pad.Picture2.Image
				Else
					flag = MyProject.Forms.form1Pad.Picture3.Visible
					If flag Then
						Me.PictureBox3.Image = MyProject.Forms.form1Pad.Picture3.Image
					Else
						flag = MyProject.Forms.form1Pad.Picture4.Visible
						If flag Then
							Me.PictureBox4.Image = MyProject.Forms.form1Pad.Picture4.Image
						Else
							flag = MyProject.Forms.form1Pad.Picture5.Visible
							If flag Then
								Me.PictureBox5.Image = MyProject.Forms.form1Pad.Picture5.Image
							Else
								Me.PictureBox6.Image = MyProject.Forms.form1Pad.Picture6.Image
							End If
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x0600107D RID: 4221 RVA: 0x03DE76A8 File Offset: 0x03DE5AA8
		Private Sub Label2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Loginz.Show()
		End Sub

		' Token: 0x0400060E RID: 1550
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000610 RID: 1552
		<AccessedThroughProperty("PictureBox6")>
		Private _PictureBox6 As PictureBox

		' Token: 0x04000611 RID: 1553
		<AccessedThroughProperty("PictureBox5")>
		Private _PictureBox5 As PictureBox

		' Token: 0x04000612 RID: 1554
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x04000613 RID: 1555
		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		' Token: 0x04000614 RID: 1556
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x04000615 RID: 1557
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x04000616 RID: 1558
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x04000617 RID: 1559
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x04000618 RID: 1560
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000619 RID: 1561
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x0400061A RID: 1562
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x0400061B RID: 1563
		<AccessedThroughProperty("PictureBox7")>
		Private _PictureBox7 As PictureBox
	End Class
End Namespace
