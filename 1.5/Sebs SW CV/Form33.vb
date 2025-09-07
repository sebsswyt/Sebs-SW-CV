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
	' Token: 0x0200004F RID: 79
	<DesignerGenerated()>
	Public Partial Class Form33
		Inherits Form

		' Token: 0x06000D32 RID: 3378 RVA: 0x03DCF8E8 File Offset: 0x03DCDCE8
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form33_Load
			Dim _ENCList As List(Of WeakReference) = Form33.__ENCList
			SyncLock _ENCList
				Form33.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000460 RID: 1120
		' (get) Token: 0x06000D35 RID: 3381 RVA: 0x03DD0810 File Offset: 0x03DCEC10
		' (set) Token: 0x06000D36 RID: 3382 RVA: 0x03DD0828 File Offset: 0x03DCEC28
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

		' Token: 0x17000461 RID: 1121
		' (get) Token: 0x06000D37 RID: 3383 RVA: 0x03DD0834 File Offset: 0x03DCEC34
		' (set) Token: 0x06000D38 RID: 3384 RVA: 0x03DD084C File Offset: 0x03DCEC4C
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

		' Token: 0x17000462 RID: 1122
		' (get) Token: 0x06000D39 RID: 3385 RVA: 0x03DD08AC File Offset: 0x03DCECAC
		' (set) Token: 0x06000D3A RID: 3386 RVA: 0x03DD08C4 File Offset: 0x03DCECC4
		Friend Overridable Property Label1 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim eventHandler As EventHandler = AddressOf Me.Label1_Click
				Dim flag As Boolean = Me._Label1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Label1.Click, eventHandler
				End If
				Me._Label1 = value
				flag = Me._Label1 IsNot Nothing
				If flag Then
					AddHandler Me._Label1.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000463 RID: 1123
		' (get) Token: 0x06000D3B RID: 3387 RVA: 0x03DD0924 File Offset: 0x03DCED24
		' (set) Token: 0x06000D3C RID: 3388 RVA: 0x03DD093C File Offset: 0x03DCED3C
		Friend Overridable Property Label2 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label2 = value
			End Set
		End Property

		' Token: 0x17000464 RID: 1124
		' (get) Token: 0x06000D3D RID: 3389 RVA: 0x03DD0948 File Offset: 0x03DCED48
		' (set) Token: 0x06000D3E RID: 3390 RVA: 0x03DD0960 File Offset: 0x03DCED60
		Friend Overridable Property ProgressBar2 As ProgressBar
			<DebuggerNonUserCode()>
			Get
				Return Me._ProgressBar2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ProgressBar)
				Me._ProgressBar2 = value
			End Set
		End Property

		' Token: 0x17000465 RID: 1125
		' (get) Token: 0x06000D3F RID: 3391 RVA: 0x03DD096C File Offset: 0x03DCED6C
		' (set) Token: 0x06000D40 RID: 3392 RVA: 0x03DD0984 File Offset: 0x03DCED84
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

		' Token: 0x17000466 RID: 1126
		' (get) Token: 0x06000D41 RID: 3393 RVA: 0x03DD09E4 File Offset: 0x03DCEDE4
		' (set) Token: 0x06000D42 RID: 3394 RVA: 0x03DD09FC File Offset: 0x03DCEDFC
		Friend Overridable Property rest1 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._rest1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._rest1 = value
			End Set
		End Property

		' Token: 0x17000467 RID: 1127
		' (get) Token: 0x06000D43 RID: 3395 RVA: 0x03DD0A08 File Offset: 0x03DCEE08
		' (set) Token: 0x06000D44 RID: 3396 RVA: 0x03DD0A20 File Offset: 0x03DCEE20
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

		' Token: 0x17000468 RID: 1128
		' (get) Token: 0x06000D45 RID: 3397 RVA: 0x03DD0A2C File Offset: 0x03DCEE2C
		' (set) Token: 0x06000D46 RID: 3398 RVA: 0x03DD0A44 File Offset: 0x03DCEE44
		Friend Overridable Property Timer3 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._Timer3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim eventHandler As EventHandler = AddressOf Me.Timer3_Tick
				Dim flag As Boolean = Me._Timer3 IsNot Nothing
				If flag Then
					RemoveHandler Me._Timer3.Tick, eventHandler
				End If
				Me._Timer3 = value
				flag = Me._Timer3 IsNot Nothing
				If flag Then
					AddHandler Me._Timer3.Tick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000469 RID: 1129
		' (get) Token: 0x06000D47 RID: 3399 RVA: 0x03DD0AA4 File Offset: 0x03DCEEA4
		' (set) Token: 0x06000D48 RID: 3400 RVA: 0x03DD0ABC File Offset: 0x03DCEEBC
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

		' Token: 0x1700046A RID: 1130
		' (get) Token: 0x06000D49 RID: 3401 RVA: 0x03DD0AC8 File Offset: 0x03DCEEC8
		' (set) Token: 0x06000D4A RID: 3402 RVA: 0x03DD0AE0 File Offset: 0x03DCEEE0
		Friend Overridable Property ToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._ToolStripMenuItem1 = value
			End Set
		End Property

		' Token: 0x1700046B RID: 1131
		' (get) Token: 0x06000D4B RID: 3403 RVA: 0x03DD0AEC File Offset: 0x03DCEEEC
		' (set) Token: 0x06000D4C RID: 3404 RVA: 0x03DD0B04 File Offset: 0x03DCEF04
		Friend Overridable Property ToolStripMenuItem3 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.ToolStripMenuItem3_Click
				Dim flag As Boolean = Me._ToolStripMenuItem3 IsNot Nothing
				If flag Then
					RemoveHandler Me._ToolStripMenuItem3.Click, eventHandler
				End If
				Me._ToolStripMenuItem3 = value
				flag = Me._ToolStripMenuItem3 IsNot Nothing
				If flag Then
					AddHandler Me._ToolStripMenuItem3.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700046C RID: 1132
		' (get) Token: 0x06000D4D RID: 3405 RVA: 0x03DD0B64 File Offset: 0x03DCEF64
		' (set) Token: 0x06000D4E RID: 3406 RVA: 0x03DD0B7C File Offset: 0x03DCEF7C
		Friend Overridable Property V2 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._V2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._V2 = value
			End Set
		End Property

		' Token: 0x1700046D RID: 1133
		' (get) Token: 0x06000D4F RID: 3407 RVA: 0x03DD0B88 File Offset: 0x03DCEF88
		' (set) Token: 0x06000D50 RID: 3408 RVA: 0x03DD0BA0 File Offset: 0x03DCEFA0
		Friend Overridable Property ProgressBar3 As ProgressBar
			<DebuggerNonUserCode()>
			Get
				Return Me._ProgressBar3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ProgressBar)
				Me._ProgressBar3 = value
			End Set
		End Property

		' Token: 0x1700046E RID: 1134
		' (get) Token: 0x06000D51 RID: 3409 RVA: 0x03DD0BAC File Offset: 0x03DCEFAC
		' (set) Token: 0x06000D52 RID: 3410 RVA: 0x03DD0BC4 File Offset: 0x03DCEFC4
		Friend Overridable Property Timer4 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._Timer4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim eventHandler As EventHandler = AddressOf Me.Timer4_Tick
				Dim flag As Boolean = Me._Timer4 IsNot Nothing
				If flag Then
					RemoveHandler Me._Timer4.Tick, eventHandler
				End If
				Me._Timer4 = value
				flag = Me._Timer4 IsNot Nothing
				If flag Then
					AddHandler Me._Timer4.Tick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700046F RID: 1135
		' (get) Token: 0x06000D53 RID: 3411 RVA: 0x03DD0C24 File Offset: 0x03DCF024
		' (set) Token: 0x06000D54 RID: 3412 RVA: 0x03DD0C3C File Offset: 0x03DCF03C
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

		' Token: 0x17000470 RID: 1136
		' (get) Token: 0x06000D55 RID: 3413 RVA: 0x03DD0C48 File Offset: 0x03DCF048
		' (set) Token: 0x06000D56 RID: 3414 RVA: 0x03DD0C60 File Offset: 0x03DCF060
		Friend Overridable Property ToolStripMenuItem4 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.ToolStripMenuItem4_Click
				Dim flag As Boolean = Me._ToolStripMenuItem4 IsNot Nothing
				If flag Then
					RemoveHandler Me._ToolStripMenuItem4.Click, eventHandler
				End If
				Me._ToolStripMenuItem4 = value
				flag = Me._ToolStripMenuItem4 IsNot Nothing
				If flag Then
					AddHandler Me._ToolStripMenuItem4.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000471 RID: 1137
		' (get) Token: 0x06000D57 RID: 3415 RVA: 0x03DD0CC0 File Offset: 0x03DCF0C0
		' (set) Token: 0x06000D58 RID: 3416 RVA: 0x03DD0CD8 File Offset: 0x03DCF0D8
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

		' Token: 0x17000472 RID: 1138
		' (get) Token: 0x06000D59 RID: 3417 RVA: 0x03DD0CE4 File Offset: 0x03DCF0E4
		' (set) Token: 0x06000D5A RID: 3418 RVA: 0x03DD0CFC File Offset: 0x03DCF0FC
		Friend Overridable Property Label4 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label4 = value
			End Set
		End Property

		' Token: 0x17000473 RID: 1139
		' (get) Token: 0x06000D5B RID: 3419 RVA: 0x03DD0D08 File Offset: 0x03DCF108
		' (set) Token: 0x06000D5C RID: 3420 RVA: 0x03DD0D20 File Offset: 0x03DCF120
		Friend Overridable Property Label5 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label5 = value
			End Set
		End Property

		' Token: 0x17000474 RID: 1140
		' (get) Token: 0x06000D5D RID: 3421 RVA: 0x03DD0D2C File Offset: 0x03DCF12C
		' (set) Token: 0x06000D5E RID: 3422 RVA: 0x03DD0D44 File Offset: 0x03DCF144
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

		' Token: 0x17000475 RID: 1141
		' (get) Token: 0x06000D5F RID: 3423 RVA: 0x03DD0D50 File Offset: 0x03DCF150
		' (set) Token: 0x06000D60 RID: 3424 RVA: 0x03DD0D68 File Offset: 0x03DCF168
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

		' Token: 0x17000476 RID: 1142
		' (get) Token: 0x06000D61 RID: 3425 RVA: 0x03DD0D74 File Offset: 0x03DCF174
		' (set) Token: 0x06000D62 RID: 3426 RVA: 0x03DD0D8C File Offset: 0x03DCF18C
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

		' Token: 0x17000477 RID: 1143
		' (get) Token: 0x06000D63 RID: 3427 RVA: 0x03DD0D98 File Offset: 0x03DCF198
		' (set) Token: 0x06000D64 RID: 3428 RVA: 0x03DD0DB0 File Offset: 0x03DCF1B0
		Friend Overridable Property Label6 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label6 = value
			End Set
		End Property

		' Token: 0x06000D65 RID: 3429 RVA: 0x03DD0DBC File Offset: 0x03DCF1BC
		Private Sub Form33_Load(sender As Object, e As EventArgs)
			Dim visible As Boolean = MyProject.Forms.Form50.Button1.Visible
			If visible Then
			End If
			MyProject.Forms.form1Pad.Label7.Text = "ON"
			Me.V2.Text = MyProject.Forms.Form1.V.Text
			Me.Label2.Text = MyProject.Forms.Form27.Label1.Text
			Me.Timer3.Start()
			MyProject.Forms.Form1.Close()
			MyProject.Forms.Form2.Close()
			Me.WindowState = FormWindowState.Maximized
			MyProject.Forms.Form27.Close()
			MyProject.Forms.AboutBox23.Show()
		End Sub

		' Token: 0x06000D66 RID: 3430 RVA: 0x03DD0E94 File Offset: 0x03DCF294
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			MyProject.Forms.Form57.Show()
			MyProject.Forms.Form57.RestartTimer.Start()
			Me.Timer1.[Stop]()
			Me.Close()
			Me.ProgressBar1.Increment(1)
			Dim flag As Boolean = Me.ProgressBar1.Value = 1
			If flag Then
			End If
			flag = Me.ProgressBar1.Value = 2
			If flag Then
			End If
			flag = Me.ProgressBar1.Value = 3
			If flag Then
			End If
			flag = Me.ProgressBar1.Value = 4
			If flag Then
			End If
			flag = Me.ProgressBar1.Value = 5
			If flag Then
			End If
			MyProject.Forms.Form49.PictureBox1.Image = MyProject.Forms.form1Pad.Picture1.Image
			MyProject.Forms.Form49.PictureBox2.Image = MyProject.Forms.form1Pad.Picture2.Image
			MyProject.Forms.Form49.PictureBox3.Image = MyProject.Forms.form1Pad.Picture3.Image
			MyProject.Forms.Form49.PictureBox4.Image = MyProject.Forms.form1Pad.Picture4.Image
			MyProject.Forms.Form49.PictureBox5.Image = MyProject.Forms.form1Pad.Picture5.Image
			MyProject.Forms.Form49.PictureBox6.Image = MyProject.Forms.form1Pad.Picture6.Image
			MyProject.Forms.Form49.PictureBox7.Image = MyProject.Forms.form1Pad.Picture7.Image
			MyProject.Forms.Form49.PictureBox1.Image = MyProject.Forms.form1Pad.Picture1.Image
			MyProject.Forms.Form49.PictureBox2.Image = MyProject.Forms.form1Pad.Picture2.Image
			MyProject.Forms.Form49.PictureBox3.Image = MyProject.Forms.form1Pad.Picture3.Image
			MyProject.Forms.Form49.PictureBox4.Image = MyProject.Forms.form1Pad.Picture4.Image
			MyProject.Forms.Form49.PictureBox5.Image = MyProject.Forms.form1Pad.Picture5.Image
			MyProject.Forms.Form49.PictureBox6.Image = MyProject.Forms.form1Pad.Picture6.Image
			MyProject.Forms.Form49.PictureBox7.Image = MyProject.Forms.form1Pad.Picture7.Image
			MyProject.Forms.Form49.PictureBox1.Image = MyProject.Forms.form1Pad.Picture1.Image
			MyProject.Forms.Form49.PictureBox2.Image = MyProject.Forms.form1Pad.Picture2.Image
			MyProject.Forms.Form49.PictureBox3.Image = MyProject.Forms.form1Pad.Picture3.Image
			MyProject.Forms.Form49.PictureBox4.Image = MyProject.Forms.form1Pad.Picture4.Image
			MyProject.Forms.Form49.PictureBox5.Image = MyProject.Forms.form1Pad.Picture5.Image
			MyProject.Forms.Form49.PictureBox6.Image = MyProject.Forms.form1Pad.Picture6.Image
			MyProject.Forms.Form49.PictureBox7.Image = MyProject.Forms.form1Pad.Picture7.Image
			MyProject.Forms.Form49.PictureBox1.Image = MyProject.Forms.form1Pad.Picture1.Image
			MyProject.Forms.Form49.PictureBox2.Image = MyProject.Forms.form1Pad.Picture2.Image
			MyProject.Forms.Form49.PictureBox3.Image = MyProject.Forms.form1Pad.Picture3.Image
			MyProject.Forms.Form49.PictureBox4.Image = MyProject.Forms.form1Pad.Picture4.Image
			MyProject.Forms.Form49.PictureBox5.Image = MyProject.Forms.form1Pad.Picture5.Image
			MyProject.Forms.Form49.PictureBox6.Image = MyProject.Forms.form1Pad.Picture6.Image
			MyProject.Forms.Form49.PictureBox7.Image = MyProject.Forms.form1Pad.Picture7.Image
			flag = Me.ProgressBar1.Value = 10
			If flag Then
				Me.Label1.Text = "Restarting.."
			End If
			flag = Me.ProgressBar1.Value = 15
			If flag Then
				Me.Label1.Text = "Restarting..."
				MyProject.Forms.form1Pad.Label7.Text = "ON"
				MyProject.Forms.form1Pad.Close()
			End If
			flag = Me.ProgressBar1.Value = 20
			If flag Then
				Me.Label1.Text = "Restarting.."
				MyProject.Forms.form1Pad.Label7.Text = "ON"
				MyProject.Forms.form1Pad.Close()
			End If
			flag = Me.ProgressBar1.Value = 25
			If flag Then
				Me.Label1.Text = "Restarting."
				MyProject.Forms.form1Pad.Label7.Text = "ON"
				MyProject.Forms.form1Pad.Close()
			End If
			flag = Me.ProgressBar1.Value = 30
			If flag Then
				Me.Label1.Text = "Restarting.."
			End If
			flag = Me.ProgressBar1.Value = 35
			If flag Then
				Me.Label1.Text = "Restarting..."
			End If
			flag = Me.ProgressBar1.Value = 40
			If flag Then
				Me.Label1.Text = "Restarting.."
			End If
			flag = Me.ProgressBar1.Value = 45
			If flag Then
				Me.Label1.Text = "Restarting."
			End If
			flag = Me.ProgressBar1.Value = 50
			If flag Then
				Me.Label1.Text = "Restarting.."
			End If
			flag = Me.ProgressBar1.Value = 55
			If flag Then
				Me.Label1.Text = "Restarting..."
			End If
			flag = Me.ProgressBar1.Value = 60
			If flag Then
				Me.Label1.Text = "Restarting.."
			End If
			flag = Me.ProgressBar1.Value = 65
			If flag Then
				Me.Label1.Text = "Restarting."
			End If
			flag = Me.ProgressBar1.Value = 70
			If flag Then
				Me.Label1.Text = "Restarting.."
			End If
			flag = Me.ProgressBar1.Value = 75
			If flag Then
				Me.Label1.Text = "Restarting..."
			End If
			flag = Me.ProgressBar1.Value = 80
			If flag Then
				Me.Label1.Text = "Restarting.."
			End If
			flag = Me.ProgressBar1.Value = 85
			If flag Then
				Me.Label1.Text = "Restarting."
			End If
			flag = Me.ProgressBar1.Value = 90
			If flag Then
				Me.Label1.Text = "Restarting.."
			End If
			flag = Me.ProgressBar1.Value = 95
			If flag Then
				Me.Label1.Text = "Restarting..."
			End If
			MyProject.Forms.Form49.PictureBox1.Image = MyProject.Forms.form1Pad.Picture1.Image
			MyProject.Forms.Form49.PictureBox2.Image = MyProject.Forms.form1Pad.Picture2.Image
			MyProject.Forms.Form49.PictureBox3.Image = MyProject.Forms.form1Pad.Picture3.Image
			MyProject.Forms.Form49.PictureBox4.Image = MyProject.Forms.form1Pad.Picture4.Image
			MyProject.Forms.Form49.PictureBox5.Image = MyProject.Forms.form1Pad.Picture5.Image
			MyProject.Forms.Form49.PictureBox6.Image = MyProject.Forms.form1Pad.Picture6.Image
			MyProject.Forms.Form49.PictureBox7.Image = MyProject.Forms.form1Pad.Picture7.Image
			MyProject.Forms.Form49.PictureBox1.Image = MyProject.Forms.form1Pad.Picture1.Image
			MyProject.Forms.Form49.PictureBox2.Image = MyProject.Forms.form1Pad.Picture2.Image
			MyProject.Forms.Form49.PictureBox3.Image = MyProject.Forms.form1Pad.Picture3.Image
			MyProject.Forms.Form49.PictureBox4.Image = MyProject.Forms.form1Pad.Picture4.Image
			MyProject.Forms.Form49.PictureBox5.Image = MyProject.Forms.form1Pad.Picture5.Image
			MyProject.Forms.Form49.PictureBox6.Image = MyProject.Forms.form1Pad.Picture6.Image
			MyProject.Forms.Form49.PictureBox7.Image = MyProject.Forms.form1Pad.Picture7.Image
			flag = Me.ProgressBar1.Value = Me.ProgressBar1.Maximum
			If flag Then
				MyProject.Forms.form1Pad.Close()
				MyProject.Forms.Form47.Show()
				MyProject.Forms.Form47.Label2.Text = Me.Label4.Text
				Me.Timer1.[Stop]()
				MyProject.Forms.Form1.V.Text = Me.V2.Text
				flag = Operators.CompareString(Me.rest1.Text, "Maximized", False) = 0
				If flag Then
					MyProject.Forms.form1Pad.WindowState = FormWindowState.Maximized
				End If
				Me.Close()
			End If
		End Sub

		' Token: 0x06000D67 RID: 3431 RVA: 0x03DD19DC File Offset: 0x03DCFDDC
		Private Sub Timer2_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar2.Increment(1)
			Me.Timer1.[Stop]()
			Me.Label1.Text = "Shutting down"
			Dim flag As Boolean = Me.ProgressBar2.Value = Me.ProgressBar1.Maximum
			If flag Then
				Me.Timer2.[Stop]()
				ProjectData.EndApp()
			End If
		End Sub

		' Token: 0x06000D68 RID: 3432 RVA: 0x03DD1A44 File Offset: 0x03DCFE44
		Private Sub Label1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.Show()
			MyProject.Forms.Form1.Panel3.Visible = True
		End Sub

		' Token: 0x06000D69 RID: 3433 RVA: 0x03DD1A70 File Offset: 0x03DCFE70
		Private Sub Timer3_Tick(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Label3.Text, "1", False) = 0
			Dim flag2 As Boolean
			If flag Then
				flag2 = Not MyProject.Forms.Form17.RichTextBox1.Visible
				If flag2 Then
					Me.Timer4.Start()
				Else
					Me.Timer4.[Stop]()
				End If
			End If
			flag2 = Not MyProject.Forms.Form1.Panel3.Visible
			If flag2 Then
				Me.Timer1.Start()
			Else
				Me.Timer1.[Stop]()
			End If
			flag2 = Not MyProject.Forms.Form17.RichTextBox1.Visible
			If flag2 Then
				Me.Timer1.Start()
			Else
				Me.Timer1.[Stop]()
			End If
		End Sub

		' Token: 0x06000D6A RID: 3434 RVA: 0x03DD1B48 File Offset: 0x03DCFF48
		Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form17.Show()
			MyProject.Forms.AboutBox17.Show()
		End Sub

		' Token: 0x06000D6B RID: 3435 RVA: 0x03DD1B6C File Offset: 0x03DCFF6C
		Private Sub Timer4_Tick(sender As Object, e As EventArgs)
			MyProject.Forms.Form57.Show()
			MyProject.Forms.Form57.StartingTimer.Start()
			Me.Timer4.[Stop]()
			Me.Close()
			Me.ProgressBar3.Increment(1)
			Dim flag As Boolean = MyProject.Forms.Form54.PictureBox1.Visible
			If flag Then
			End If
			Me.Timer1.[Stop]()
			Me.Timer3.[Stop]()
			flag = Me.ProgressBar3.Value = 5
			If flag Then
				Me.Label1.Text = "Starting up."
			End If
			flag = Me.ProgressBar3.Value = 10
			If flag Then
				Me.Label1.Text = "Starting up.."
			End If
			flag = Me.ProgressBar3.Value = 15
			If flag Then
				Me.Label1.Text = "Starting up..."
			End If
			flag = Me.ProgressBar3.Value = 20
			If flag Then
				Me.Label1.Text = "Starting up.."
			End If
			flag = Me.ProgressBar3.Value = 25
			If flag Then
				Me.Label1.Text = "Starting up."
			End If
			flag = Me.ProgressBar3.Value = 30
			If flag Then
				Me.Label1.Text = "Starting up.."
			End If
			flag = Me.ProgressBar3.Value = 35
			If flag Then
				Me.Label1.Text = "Starting up..."
			End If
			flag = Operators.CompareString(Me.Label1.Text, "Restarting.", False) = 0
			If flag Then
				Me.Label1.Text = "Starting up"
			Else
				flag = Operators.CompareString(Me.Label1.Text, "Restarting..", False) = 0
				If flag Then
					Me.Label1.Text = "Starting up"
				Else
					flag = Operators.CompareString(Me.Label1.Text, "Restarting...", False) = 0
					If flag Then
						Me.Label1.Text = "Starting up"
					End If
				End If
			End If
			flag = Me.ProgressBar3.Value = 40
			If flag Then
				MyProject.Forms.Form48.Show()
				MyProject.Forms.Form54.Close()
				Me.Close()
			End If
		End Sub

		' Token: 0x06000D6C RID: 3436 RVA: 0x03DD1DC4 File Offset: 0x03DD01C4
		Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs)
			Me.Label3.Text = "1"
			Me.Timer3.Start()
			MyProject.Forms.Form17.Show()
		End Sub

		' Token: 0x040004E0 RID: 1248
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040004E2 RID: 1250
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x040004E3 RID: 1251
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x040004E4 RID: 1252
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x040004E5 RID: 1253
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x040004E6 RID: 1254
		<AccessedThroughProperty("ProgressBar2")>
		Private _ProgressBar2 As ProgressBar

		' Token: 0x040004E7 RID: 1255
		<AccessedThroughProperty("Timer2")>
		Private _Timer2 As Timer

		' Token: 0x040004E8 RID: 1256
		<AccessedThroughProperty("rest1")>
		Private _rest1 As Label

		' Token: 0x040004E9 RID: 1257
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x040004EA RID: 1258
		<AccessedThroughProperty("Timer3")>
		Private _Timer3 As Timer

		' Token: 0x040004EB RID: 1259
		<AccessedThroughProperty("MenuStrip1")>
		Private _MenuStrip1 As MenuStrip

		' Token: 0x040004EC RID: 1260
		<AccessedThroughProperty("ToolStripMenuItem1")>
		Private _ToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x040004ED RID: 1261
		<AccessedThroughProperty("ToolStripMenuItem3")>
		Private _ToolStripMenuItem3 As ToolStripMenuItem

		' Token: 0x040004EE RID: 1262
		<AccessedThroughProperty("V2")>
		Private _V2 As Label

		' Token: 0x040004EF RID: 1263
		<AccessedThroughProperty("ProgressBar3")>
		Private _ProgressBar3 As ProgressBar

		' Token: 0x040004F0 RID: 1264
		<AccessedThroughProperty("Timer4")>
		Private _Timer4 As Timer

		' Token: 0x040004F1 RID: 1265
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x040004F2 RID: 1266
		<AccessedThroughProperty("ToolStripMenuItem4")>
		Private _ToolStripMenuItem4 As ToolStripMenuItem

		' Token: 0x040004F3 RID: 1267
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x040004F4 RID: 1268
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x040004F5 RID: 1269
		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		' Token: 0x040004F6 RID: 1270
		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		' Token: 0x040004F7 RID: 1271
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x040004F8 RID: 1272
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x040004F9 RID: 1273
		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label
	End Class
End Namespace
