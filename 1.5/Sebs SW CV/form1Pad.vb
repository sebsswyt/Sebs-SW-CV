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
	' Token: 0x0200003F RID: 63
	<DesignerGenerated()>
	Public Partial Class form1Pad
		Inherits Form

		' Token: 0x060008DA RID: 2266 RVA: 0x03DB1520 File Offset: 0x03DAF920
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.form1Pad_Load
			AddHandler MyBase.FormClosing, AddressOf Me.form1Pad_FormClosing
			Dim _ENCList As List(Of WeakReference) = form1Pad.__ENCList
			SyncLock _ENCList
				form1Pad.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170002F3 RID: 755
		' (get) Token: 0x060008DD RID: 2269 RVA: 0x03DB44C0 File Offset: 0x03DB28C0
		' (set) Token: 0x060008DE RID: 2270 RVA: 0x03DB44D8 File Offset: 0x03DB28D8
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

		' Token: 0x170002F4 RID: 756
		' (get) Token: 0x060008DF RID: 2271 RVA: 0x03DB44E4 File Offset: 0x03DB28E4
		' (set) Token: 0x060008E0 RID: 2272 RVA: 0x03DB44FC File Offset: 0x03DB28FC
		Friend Overridable Property cvtaskbar As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._cvtaskbar
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._cvtaskbar = value
			End Set
		End Property

		' Token: 0x170002F5 RID: 757
		' (get) Token: 0x060008E1 RID: 2273 RVA: 0x03DB4508 File Offset: 0x03DB2908
		' (set) Token: 0x060008E2 RID: 2274 RVA: 0x03DB4520 File Offset: 0x03DB2920
		Friend Overridable Property OpenProgram As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenProgram
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox1_Click
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.OpenProgram_MouseDoubleClick
				Dim eventHandler2 As EventHandler = AddressOf Me.OpenProgram_MouseLeave
				Dim eventHandler3 As EventHandler = AddressOf Me.OpenProgram_MouseEnter
				Dim flag As Boolean = Me._OpenProgram IsNot Nothing
				If flag Then
					RemoveHandler Me._OpenProgram.Click, eventHandler
					RemoveHandler Me._OpenProgram.MouseDoubleClick, mouseEventHandler
					RemoveHandler Me._OpenProgram.MouseLeave, eventHandler2
					RemoveHandler Me._OpenProgram.MouseEnter, eventHandler3
				End If
				Me._OpenProgram = value
				flag = Me._OpenProgram IsNot Nothing
				If flag Then
					AddHandler Me._OpenProgram.Click, eventHandler
					AddHandler Me._OpenProgram.MouseDoubleClick, mouseEventHandler
					AddHandler Me._OpenProgram.MouseLeave, eventHandler2
					AddHandler Me._OpenProgram.MouseEnter, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x170002F6 RID: 758
		' (get) Token: 0x060008E3 RID: 2275 RVA: 0x03DB45FC File Offset: 0x03DB29FC
		' (set) Token: 0x060008E4 RID: 2276 RVA: 0x03DB4614 File Offset: 0x03DB2A14
		Friend Overridable Property settings As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._settings
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.settings_MouseDoubleClick
				Dim eventHandler As EventHandler = AddressOf Me.settings_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.settings_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox2_Click
				Dim flag As Boolean = Me._settings IsNot Nothing
				If flag Then
					RemoveHandler Me._settings.MouseDoubleClick, mouseEventHandler
					RemoveHandler Me._settings.MouseLeave, eventHandler
					RemoveHandler Me._settings.MouseEnter, eventHandler2
					RemoveHandler Me._settings.Click, eventHandler3
				End If
				Me._settings = value
				flag = Me._settings IsNot Nothing
				If flag Then
					AddHandler Me._settings.MouseDoubleClick, mouseEventHandler
					AddHandler Me._settings.MouseLeave, eventHandler
					AddHandler Me._settings.MouseEnter, eventHandler2
					AddHandler Me._settings.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x170002F7 RID: 759
		' (get) Token: 0x060008E5 RID: 2277 RVA: 0x03DB46F0 File Offset: 0x03DB2AF0
		' (set) Token: 0x060008E6 RID: 2278 RVA: 0x03DB4708 File Offset: 0x03DB2B08
		Friend Overridable Property SebsSWbutton As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._SebsSWbutton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.SebsSWbutton_MouseDoubleClick
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox3_Click
				Dim eventHandler2 As EventHandler = AddressOf Me.SebsSWbutton_MouseLeave
				Dim eventHandler3 As EventHandler = AddressOf Me.SebsSWbutton_MouseEnter
				Dim flag As Boolean = Me._SebsSWbutton IsNot Nothing
				If flag Then
					RemoveHandler Me._SebsSWbutton.MouseDoubleClick, mouseEventHandler
					RemoveHandler Me._SebsSWbutton.Click, eventHandler
					RemoveHandler Me._SebsSWbutton.MouseLeave, eventHandler2
					RemoveHandler Me._SebsSWbutton.MouseEnter, eventHandler3
				End If
				Me._SebsSWbutton = value
				flag = Me._SebsSWbutton IsNot Nothing
				If flag Then
					AddHandler Me._SebsSWbutton.MouseDoubleClick, mouseEventHandler
					AddHandler Me._SebsSWbutton.Click, eventHandler
					AddHandler Me._SebsSWbutton.MouseLeave, eventHandler2
					AddHandler Me._SebsSWbutton.MouseEnter, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x170002F8 RID: 760
		' (get) Token: 0x060008E7 RID: 2279 RVA: 0x03DB47E4 File Offset: 0x03DB2BE4
		' (set) Token: 0x060008E8 RID: 2280 RVA: 0x03DB47FC File Offset: 0x03DB2BFC
		Friend Overridable Property Label1 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim eventHandler As EventHandler = AddressOf Me.Label1_DoubleClick
				Dim flag As Boolean = Me._Label1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Label1.DoubleClick, eventHandler
				End If
				Me._Label1 = value
				flag = Me._Label1 IsNot Nothing
				If flag Then
					AddHandler Me._Label1.DoubleClick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002F9 RID: 761
		' (get) Token: 0x060008E9 RID: 2281 RVA: 0x03DB485C File Offset: 0x03DB2C5C
		' (set) Token: 0x060008EA RID: 2282 RVA: 0x03DB4874 File Offset: 0x03DB2C74
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

		' Token: 0x170002FA RID: 762
		' (get) Token: 0x060008EB RID: 2283 RVA: 0x03DB48D4 File Offset: 0x03DB2CD4
		' (set) Token: 0x060008EC RID: 2284 RVA: 0x03DB48EC File Offset: 0x03DB2CEC
		Friend Overridable Property Picture1 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Picture1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox4_Click
				Dim flag As Boolean = Me._Picture1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Picture1.Click, eventHandler
				End If
				Me._Picture1 = value
				flag = Me._Picture1 IsNot Nothing
				If flag Then
					AddHandler Me._Picture1.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002FB RID: 763
		' (get) Token: 0x060008ED RID: 2285 RVA: 0x03DB494C File Offset: 0x03DB2D4C
		' (set) Token: 0x060008EE RID: 2286 RVA: 0x03DB4964 File Offset: 0x03DB2D64
		Friend Overridable Property PictureBox1 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.PictureBox1_MouseDoubleClick
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox1_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox1_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox1_Click_1
				Dim flag As Boolean = Me._PictureBox1 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox1.MouseDoubleClick, mouseEventHandler
					RemoveHandler Me._PictureBox1.MouseLeave, eventHandler
					RemoveHandler Me._PictureBox1.MouseEnter, eventHandler2
					RemoveHandler Me._PictureBox1.Click, eventHandler3
				End If
				Me._PictureBox1 = value
				flag = Me._PictureBox1 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox1.MouseDoubleClick, mouseEventHandler
					AddHandler Me._PictureBox1.MouseLeave, eventHandler
					AddHandler Me._PictureBox1.MouseEnter, eventHandler2
					AddHandler Me._PictureBox1.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x170002FC RID: 764
		' (get) Token: 0x060008EF RID: 2287 RVA: 0x03DB4A40 File Offset: 0x03DB2E40
		' (set) Token: 0x060008F0 RID: 2288 RVA: 0x03DB4A58 File Offset: 0x03DB2E58
		Friend Overridable Property Textbutton As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Textbutton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.Textbutton_DoubleClick
				Dim eventHandler2 As EventHandler = AddressOf Me.Textbutton_MouseLeave
				Dim eventHandler3 As EventHandler = AddressOf Me.Textbutton_MouseEnter
				Dim eventHandler4 As EventHandler = AddressOf Me.PictureBox2_Click_1
				Dim flag As Boolean = Me._Textbutton IsNot Nothing
				If flag Then
					RemoveHandler Me._Textbutton.DoubleClick, eventHandler
					RemoveHandler Me._Textbutton.MouseLeave, eventHandler2
					RemoveHandler Me._Textbutton.MouseEnter, eventHandler3
					RemoveHandler Me._Textbutton.Click, eventHandler4
				End If
				Me._Textbutton = value
				flag = Me._Textbutton IsNot Nothing
				If flag Then
					AddHandler Me._Textbutton.DoubleClick, eventHandler
					AddHandler Me._Textbutton.MouseLeave, eventHandler2
					AddHandler Me._Textbutton.MouseEnter, eventHandler3
					AddHandler Me._Textbutton.Click, eventHandler4
				End If
			End Set
		End Property

		' Token: 0x170002FD RID: 765
		' (get) Token: 0x060008F1 RID: 2289 RVA: 0x03DB4B34 File Offset: 0x03DB2F34
		' (set) Token: 0x060008F2 RID: 2290 RVA: 0x03DB4B4C File Offset: 0x03DB2F4C
		Friend Overridable Property PictureBox2 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox2_Click_2
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox2_MouseLeave
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox2_MouseEnter
				Dim flag As Boolean = Me._PictureBox2 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox2.Click, eventHandler
					RemoveHandler Me._PictureBox2.MouseLeave, eventHandler2
					RemoveHandler Me._PictureBox2.MouseEnter, eventHandler3
				End If
				Me._PictureBox2 = value
				flag = Me._PictureBox2 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox2.Click, eventHandler
					AddHandler Me._PictureBox2.MouseLeave, eventHandler2
					AddHandler Me._PictureBox2.MouseEnter, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x170002FE RID: 766
		' (get) Token: 0x060008F3 RID: 2291 RVA: 0x03DB4BFC File Offset: 0x03DB2FFC
		' (set) Token: 0x060008F4 RID: 2292 RVA: 0x03DB4C14 File Offset: 0x03DB3014
		Friend Overridable Property Picture2 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Picture2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._Picture2 = value
			End Set
		End Property

		' Token: 0x170002FF RID: 767
		' (get) Token: 0x060008F5 RID: 2293 RVA: 0x03DB4C20 File Offset: 0x03DB3020
		' (set) Token: 0x060008F6 RID: 2294 RVA: 0x03DB4C38 File Offset: 0x03DB3038
		Friend Overridable Property Picture3 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Picture3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._Picture3 = value
			End Set
		End Property

		' Token: 0x17000300 RID: 768
		' (get) Token: 0x060008F7 RID: 2295 RVA: 0x03DB4C44 File Offset: 0x03DB3044
		' (set) Token: 0x060008F8 RID: 2296 RVA: 0x03DB4C5C File Offset: 0x03DB305C
		Friend Overridable Property Picture4 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Picture4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._Picture4 = value
			End Set
		End Property

		' Token: 0x17000301 RID: 769
		' (get) Token: 0x060008F9 RID: 2297 RVA: 0x03DB4C68 File Offset: 0x03DB3068
		' (set) Token: 0x060008FA RID: 2298 RVA: 0x03DB4C80 File Offset: 0x03DB3080
		Friend Overridable Property Picture5 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Picture5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._Picture5 = value
			End Set
		End Property

		' Token: 0x17000302 RID: 770
		' (get) Token: 0x060008FB RID: 2299 RVA: 0x03DB4C8C File Offset: 0x03DB308C
		' (set) Token: 0x060008FC RID: 2300 RVA: 0x03DB4CA4 File Offset: 0x03DB30A4
		Friend Overridable Property Picture6 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Picture6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._Picture6 = value
			End Set
		End Property

		' Token: 0x17000303 RID: 771
		' (get) Token: 0x060008FD RID: 2301 RVA: 0x03DB4CB0 File Offset: 0x03DB30B0
		' (set) Token: 0x060008FE RID: 2302 RVA: 0x03DB4CC8 File Offset: 0x03DB30C8
		Friend Overridable Property PictureBox3 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox3_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox3_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox3_Click_1
				Dim flag As Boolean = Me._PictureBox3 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox3.MouseLeave, eventHandler
					RemoveHandler Me._PictureBox3.MouseEnter, eventHandler2
					RemoveHandler Me._PictureBox3.Click, eventHandler3
				End If
				Me._PictureBox3 = value
				flag = Me._PictureBox3 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox3.MouseLeave, eventHandler
					AddHandler Me._PictureBox3.MouseEnter, eventHandler2
					AddHandler Me._PictureBox3.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x17000304 RID: 772
		' (get) Token: 0x060008FF RID: 2303 RVA: 0x03DB4D78 File Offset: 0x03DB3178
		' (set) Token: 0x06000900 RID: 2304 RVA: 0x03DB4D90 File Offset: 0x03DB3190
		Friend Overridable Property PictureBox4 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox4_Click_1
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox4_MouseLeave
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox4_MouseEnter
				Dim flag As Boolean = Me._PictureBox4 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox4.Click, eventHandler
					RemoveHandler Me._PictureBox4.MouseLeave, eventHandler2
					RemoveHandler Me._PictureBox4.MouseEnter, eventHandler3
				End If
				Me._PictureBox4 = value
				flag = Me._PictureBox4 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox4.Click, eventHandler
					AddHandler Me._PictureBox4.MouseLeave, eventHandler2
					AddHandler Me._PictureBox4.MouseEnter, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x17000305 RID: 773
		' (get) Token: 0x06000901 RID: 2305 RVA: 0x03DB4E40 File Offset: 0x03DB3240
		' (set) Token: 0x06000902 RID: 2306 RVA: 0x03DB4E58 File Offset: 0x03DB3258
		Friend Overridable Property PictureBox5 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox5_Click
				Dim flag As Boolean = Me._PictureBox5 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox5.Click, eventHandler
				End If
				Me._PictureBox5 = value
				flag = Me._PictureBox5 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox5.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000306 RID: 774
		' (get) Token: 0x06000903 RID: 2307 RVA: 0x03DB4EB8 File Offset: 0x03DB32B8
		' (set) Token: 0x06000904 RID: 2308 RVA: 0x03DB4ED0 File Offset: 0x03DB32D0
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

		' Token: 0x17000307 RID: 775
		' (get) Token: 0x06000905 RID: 2309 RVA: 0x03DB4F30 File Offset: 0x03DB3330
		' (set) Token: 0x06000906 RID: 2310 RVA: 0x03DB4F48 File Offset: 0x03DB3348
		Friend Overridable Property PictureBox6 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox6_Click
				Dim flag As Boolean = Me._PictureBox6 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox6.Click, eventHandler
				End If
				Me._PictureBox6 = value
				flag = Me._PictureBox6 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox6.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000308 RID: 776
		' (get) Token: 0x06000907 RID: 2311 RVA: 0x03DB4FA8 File Offset: 0x03DB33A8
		' (set) Token: 0x06000908 RID: 2312 RVA: 0x03DB4FC0 File Offset: 0x03DB33C0
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

		' Token: 0x17000309 RID: 777
		' (get) Token: 0x06000909 RID: 2313 RVA: 0x03DB4FCC File Offset: 0x03DB33CC
		' (set) Token: 0x0600090A RID: 2314 RVA: 0x03DB4FE4 File Offset: 0x03DB33E4
		Friend Overridable Property PictureBox7 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox7_DoubleClick
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox7_MouseLeave
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox7_MouseEnter
				Dim eventHandler4 As EventHandler = AddressOf Me.PictureBox7_Click
				Dim flag As Boolean = Me._PictureBox7 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox7.DoubleClick, eventHandler
					RemoveHandler Me._PictureBox7.MouseLeave, eventHandler2
					RemoveHandler Me._PictureBox7.MouseEnter, eventHandler3
					RemoveHandler Me._PictureBox7.Click, eventHandler4
				End If
				Me._PictureBox7 = value
				flag = Me._PictureBox7 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox7.DoubleClick, eventHandler
					AddHandler Me._PictureBox7.MouseLeave, eventHandler2
					AddHandler Me._PictureBox7.MouseEnter, eventHandler3
					AddHandler Me._PictureBox7.Click, eventHandler4
				End If
			End Set
		End Property

		' Token: 0x1700030A RID: 778
		' (get) Token: 0x0600090B RID: 2315 RVA: 0x03DB50C0 File Offset: 0x03DB34C0
		' (set) Token: 0x0600090C RID: 2316 RVA: 0x03DB50D8 File Offset: 0x03DB34D8
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

		' Token: 0x1700030B RID: 779
		' (get) Token: 0x0600090D RID: 2317 RVA: 0x03DB50E4 File Offset: 0x03DB34E4
		' (set) Token: 0x0600090E RID: 2318 RVA: 0x03DB50FC File Offset: 0x03DB34FC
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

		' Token: 0x1700030C RID: 780
		' (get) Token: 0x0600090F RID: 2319 RVA: 0x03DB515C File Offset: 0x03DB355C
		' (set) Token: 0x06000910 RID: 2320 RVA: 0x03DB5174 File Offset: 0x03DB3574
		Friend Overridable Property Label3 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.Label3_MouseDoubleClick
				Dim flag As Boolean = Me._Label3 IsNot Nothing
				If flag Then
					RemoveHandler Me._Label3.MouseDoubleClick, mouseEventHandler
				End If
				Me._Label3 = value
				flag = Me._Label3 IsNot Nothing
				If flag Then
					AddHandler Me._Label3.MouseDoubleClick, mouseEventHandler
				End If
			End Set
		End Property

		' Token: 0x1700030D RID: 781
		' (get) Token: 0x06000911 RID: 2321 RVA: 0x03DB51D4 File Offset: 0x03DB35D4
		' (set) Token: 0x06000912 RID: 2322 RVA: 0x03DB51EC File Offset: 0x03DB35EC
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

		' Token: 0x1700030E RID: 782
		' (get) Token: 0x06000913 RID: 2323 RVA: 0x03DB51F8 File Offset: 0x03DB35F8
		' (set) Token: 0x06000914 RID: 2324 RVA: 0x03DB5210 File Offset: 0x03DB3610
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

		' Token: 0x1700030F RID: 783
		' (get) Token: 0x06000915 RID: 2325 RVA: 0x03DB5270 File Offset: 0x03DB3670
		' (set) Token: 0x06000916 RID: 2326 RVA: 0x03DB5288 File Offset: 0x03DB3688
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

		' Token: 0x17000310 RID: 784
		' (get) Token: 0x06000917 RID: 2327 RVA: 0x03DB5294 File Offset: 0x03DB3694
		' (set) Token: 0x06000918 RID: 2328 RVA: 0x03DB52AC File Offset: 0x03DB36AC
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

		' Token: 0x17000311 RID: 785
		' (get) Token: 0x06000919 RID: 2329 RVA: 0x03DB52B8 File Offset: 0x03DB36B8
		' (set) Token: 0x0600091A RID: 2330 RVA: 0x03DB52D0 File Offset: 0x03DB36D0
		Friend Overridable Property Username1 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Username1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Username1 = value
			End Set
		End Property

		' Token: 0x17000312 RID: 786
		' (get) Token: 0x0600091B RID: 2331 RVA: 0x03DB52DC File Offset: 0x03DB36DC
		' (set) Token: 0x0600091C RID: 2332 RVA: 0x03DB52F4 File Offset: 0x03DB36F4
		Friend Overridable Property Label7 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.Label7_MouseDoubleClick
				Dim flag As Boolean = Me._Label7 IsNot Nothing
				If flag Then
					RemoveHandler Me._Label7.MouseDoubleClick, mouseEventHandler
				End If
				Me._Label7 = value
				flag = Me._Label7 IsNot Nothing
				If flag Then
					AddHandler Me._Label7.MouseDoubleClick, mouseEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000313 RID: 787
		' (get) Token: 0x0600091D RID: 2333 RVA: 0x03DB5354 File Offset: 0x03DB3754
		' (set) Token: 0x0600091E RID: 2334 RVA: 0x03DB536C File Offset: 0x03DB376C
		Friend Overridable Property Label8 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim eventHandler As EventHandler = AddressOf Me.Label8_Click
				Dim flag As Boolean = Me._Label8 IsNot Nothing
				If flag Then
					RemoveHandler Me._Label8.Click, eventHandler
				End If
				Me._Label8 = value
				flag = Me._Label8 IsNot Nothing
				If flag Then
					AddHandler Me._Label8.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000314 RID: 788
		' (get) Token: 0x0600091F RID: 2335 RVA: 0x03DB53CC File Offset: 0x03DB37CC
		' (set) Token: 0x06000920 RID: 2336 RVA: 0x03DB53E4 File Offset: 0x03DB37E4
		Friend Overridable Property Start_menu As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Start_menu
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Start_menu = value
			End Set
		End Property

		' Token: 0x17000315 RID: 789
		' (get) Token: 0x06000921 RID: 2337 RVA: 0x03DB53F0 File Offset: 0x03DB37F0
		' (set) Token: 0x06000922 RID: 2338 RVA: 0x03DB5408 File Offset: 0x03DB3808
		Friend Overridable Property Panel5 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim eventHandler As EventHandler = AddressOf Me.Panel5_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.Panel5_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.Panel5_Click
				Dim flag As Boolean = Me._Panel5 IsNot Nothing
				If flag Then
					RemoveHandler Me._Panel5.MouseLeave, eventHandler
					RemoveHandler Me._Panel5.MouseEnter, eventHandler2
					RemoveHandler Me._Panel5.Click, eventHandler3
				End If
				Me._Panel5 = value
				flag = Me._Panel5 IsNot Nothing
				If flag Then
					AddHandler Me._Panel5.MouseLeave, eventHandler
					AddHandler Me._Panel5.MouseEnter, eventHandler2
					AddHandler Me._Panel5.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x17000316 RID: 790
		' (get) Token: 0x06000923 RID: 2339 RVA: 0x03DB54B8 File Offset: 0x03DB38B8
		' (set) Token: 0x06000924 RID: 2340 RVA: 0x03DB54D0 File Offset: 0x03DB38D0
		Friend Overridable Property Label9 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim eventHandler As EventHandler = AddressOf Me.Label9_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.Label9_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.Label9_Click
				Dim flag As Boolean = Me._Label9 IsNot Nothing
				If flag Then
					RemoveHandler Me._Label9.MouseLeave, eventHandler
					RemoveHandler Me._Label9.MouseEnter, eventHandler2
					RemoveHandler Me._Label9.Click, eventHandler3
				End If
				Me._Label9 = value
				flag = Me._Label9 IsNot Nothing
				If flag Then
					AddHandler Me._Label9.MouseLeave, eventHandler
					AddHandler Me._Label9.MouseEnter, eventHandler2
					AddHandler Me._Label9.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x17000317 RID: 791
		' (get) Token: 0x06000925 RID: 2341 RVA: 0x03DB5580 File Offset: 0x03DB3980
		' (set) Token: 0x06000926 RID: 2342 RVA: 0x03DB5598 File Offset: 0x03DB3998
		Friend Overridable Property PictureBox11 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.Label9_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.Label9_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.Label9_Click
				Dim flag As Boolean = Me._PictureBox11 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox11.MouseLeave, eventHandler
					RemoveHandler Me._PictureBox11.MouseEnter, eventHandler2
					RemoveHandler Me._PictureBox11.Click, eventHandler3
				End If
				Me._PictureBox11 = value
				flag = Me._PictureBox11 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox11.MouseLeave, eventHandler
					AddHandler Me._PictureBox11.MouseEnter, eventHandler2
					AddHandler Me._PictureBox11.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x17000318 RID: 792
		' (get) Token: 0x06000927 RID: 2343 RVA: 0x03DB5648 File Offset: 0x03DB3A48
		' (set) Token: 0x06000928 RID: 2344 RVA: 0x03DB5660 File Offset: 0x03DB3A60
		Friend Overridable Property PictureBox12 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.Label9_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.Label9_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.Label9_Click
				Dim flag As Boolean = Me._PictureBox12 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox12.MouseLeave, eventHandler
					RemoveHandler Me._PictureBox12.MouseEnter, eventHandler2
					RemoveHandler Me._PictureBox12.Click, eventHandler3
				End If
				Me._PictureBox12 = value
				flag = Me._PictureBox12 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox12.MouseLeave, eventHandler
					AddHandler Me._PictureBox12.MouseEnter, eventHandler2
					AddHandler Me._PictureBox12.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x17000319 RID: 793
		' (get) Token: 0x06000929 RID: 2345 RVA: 0x03DB5710 File Offset: 0x03DB3B10
		' (set) Token: 0x0600092A RID: 2346 RVA: 0x03DB5728 File Offset: 0x03DB3B28
		Friend Overridable Property PictureBox13 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox13
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox13_Click
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox13_MouseLeave
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox13_MouseEnter
				Dim flag As Boolean = Me._PictureBox13 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox13.Click, eventHandler
					RemoveHandler Me._PictureBox13.MouseLeave, eventHandler2
					RemoveHandler Me._PictureBox13.MouseEnter, eventHandler3
				End If
				Me._PictureBox13 = value
				flag = Me._PictureBox13 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox13.Click, eventHandler
					AddHandler Me._PictureBox13.MouseLeave, eventHandler2
					AddHandler Me._PictureBox13.MouseEnter, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x1700031A RID: 794
		' (get) Token: 0x0600092B RID: 2347 RVA: 0x03DB57D8 File Offset: 0x03DB3BD8
		' (set) Token: 0x0600092C RID: 2348 RVA: 0x03DB57F0 File Offset: 0x03DB3BF0
		Friend Overridable Property PictureBox14 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox14
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox14_Click
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox14_MouseLeave
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox14_MouseEnter
				Dim flag As Boolean = Me._PictureBox14 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox14.Click, eventHandler
					RemoveHandler Me._PictureBox14.MouseLeave, eventHandler2
					RemoveHandler Me._PictureBox14.MouseEnter, eventHandler3
				End If
				Me._PictureBox14 = value
				flag = Me._PictureBox14 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox14.Click, eventHandler
					AddHandler Me._PictureBox14.MouseLeave, eventHandler2
					AddHandler Me._PictureBox14.MouseEnter, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x1700031B RID: 795
		' (get) Token: 0x0600092D RID: 2349 RVA: 0x03DB58A0 File Offset: 0x03DB3CA0
		' (set) Token: 0x0600092E RID: 2350 RVA: 0x03DB58B8 File Offset: 0x03DB3CB8
		Friend Overridable Property PictureBox15 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox15
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox15_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox15_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox15_Click
				Dim flag As Boolean = Me._PictureBox15 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox15.MouseLeave, eventHandler
					RemoveHandler Me._PictureBox15.MouseEnter, eventHandler2
					RemoveHandler Me._PictureBox15.Click, eventHandler3
				End If
				Me._PictureBox15 = value
				flag = Me._PictureBox15 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox15.MouseLeave, eventHandler
					AddHandler Me._PictureBox15.MouseEnter, eventHandler2
					AddHandler Me._PictureBox15.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x1700031C RID: 796
		' (get) Token: 0x0600092F RID: 2351 RVA: 0x03DB5968 File Offset: 0x03DB3D68
		' (set) Token: 0x06000930 RID: 2352 RVA: 0x03DB5980 File Offset: 0x03DB3D80
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

		' Token: 0x1700031D RID: 797
		' (get) Token: 0x06000931 RID: 2353 RVA: 0x03DB59E0 File Offset: 0x03DB3DE0
		' (set) Token: 0x06000932 RID: 2354 RVA: 0x03DB59F8 File Offset: 0x03DB3DF8
		Friend Overridable Property PictureBox16 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox16
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox16_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox16_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox16_Click
				Dim flag As Boolean = Me._PictureBox16 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox16.MouseLeave, eventHandler
					RemoveHandler Me._PictureBox16.MouseEnter, eventHandler2
					RemoveHandler Me._PictureBox16.Click, eventHandler3
				End If
				Me._PictureBox16 = value
				flag = Me._PictureBox16 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox16.MouseLeave, eventHandler
					AddHandler Me._PictureBox16.MouseEnter, eventHandler2
					AddHandler Me._PictureBox16.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x1700031E RID: 798
		' (get) Token: 0x06000933 RID: 2355 RVA: 0x03DB5AA8 File Offset: 0x03DB3EA8
		' (set) Token: 0x06000934 RID: 2356 RVA: 0x03DB5AC0 File Offset: 0x03DB3EC0
		Friend Overridable Property PictureBox17 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox17
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox17_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox17_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox17_Click
				Dim flag As Boolean = Me._PictureBox17 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox17.MouseLeave, eventHandler
					RemoveHandler Me._PictureBox17.MouseEnter, eventHandler2
					RemoveHandler Me._PictureBox17.Click, eventHandler3
				End If
				Me._PictureBox17 = value
				flag = Me._PictureBox17 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox17.MouseLeave, eventHandler
					AddHandler Me._PictureBox17.MouseEnter, eventHandler2
					AddHandler Me._PictureBox17.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x1700031F RID: 799
		' (get) Token: 0x06000935 RID: 2357 RVA: 0x03DB5B70 File Offset: 0x03DB3F70
		' (set) Token: 0x06000936 RID: 2358 RVA: 0x03DB5B88 File Offset: 0x03DB3F88
		Friend Overridable Property PictureBox18 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox18
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox18_Click
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox18_MouseLeave
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox18_MouseEnter
				Dim flag As Boolean = Me._PictureBox18 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox18.Click, eventHandler
					RemoveHandler Me._PictureBox18.MouseLeave, eventHandler2
					RemoveHandler Me._PictureBox18.MouseEnter, eventHandler3
				End If
				Me._PictureBox18 = value
				flag = Me._PictureBox18 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox18.Click, eventHandler
					AddHandler Me._PictureBox18.MouseLeave, eventHandler2
					AddHandler Me._PictureBox18.MouseEnter, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x17000320 RID: 800
		' (get) Token: 0x06000937 RID: 2359 RVA: 0x03DB5C38 File Offset: 0x03DB4038
		' (set) Token: 0x06000938 RID: 2360 RVA: 0x03DB5C50 File Offset: 0x03DB4050
		Friend Overridable Property Label10 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label10 = value
			End Set
		End Property

		' Token: 0x17000321 RID: 801
		' (get) Token: 0x06000939 RID: 2361 RVA: 0x03DB5C5C File Offset: 0x03DB405C
		' (set) Token: 0x0600093A RID: 2362 RVA: 0x03DB5C74 File Offset: 0x03DB4074
		Friend Overridable Property PictureBox8 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox8_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox8_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox8_Click
				Dim flag As Boolean = Me._PictureBox8 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox8.MouseLeave, eventHandler
					RemoveHandler Me._PictureBox8.MouseEnter, eventHandler2
					RemoveHandler Me._PictureBox8.Click, eventHandler3
				End If
				Me._PictureBox8 = value
				flag = Me._PictureBox8 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox8.MouseLeave, eventHandler
					AddHandler Me._PictureBox8.MouseEnter, eventHandler2
					AddHandler Me._PictureBox8.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x17000322 RID: 802
		' (get) Token: 0x0600093B RID: 2363 RVA: 0x03DB5D24 File Offset: 0x03DB4124
		' (set) Token: 0x0600093C RID: 2364 RVA: 0x03DB5D3C File Offset: 0x03DB413C
		Friend Overridable Property Label11 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label11 = value
			End Set
		End Property

		' Token: 0x17000323 RID: 803
		' (get) Token: 0x0600093D RID: 2365 RVA: 0x03DB5D48 File Offset: 0x03DB4148
		' (set) Token: 0x0600093E RID: 2366 RVA: 0x03DB5D60 File Offset: 0x03DB4160
		Friend Overridable Property Picture7 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Picture7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._Picture7 = value
			End Set
		End Property

		' Token: 0x17000324 RID: 804
		' (get) Token: 0x0600093F RID: 2367 RVA: 0x03DB5D6C File Offset: 0x03DB416C
		' (set) Token: 0x06000940 RID: 2368 RVA: 0x03DB5D84 File Offset: 0x03DB4184
		Friend Overridable Property PictureBox9 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox9_Click
				Dim flag As Boolean = Me._PictureBox9 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox9.Click, eventHandler
				End If
				Me._PictureBox9 = value
				flag = Me._PictureBox9 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox9.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000325 RID: 805
		' (get) Token: 0x06000941 RID: 2369 RVA: 0x03DB5DE4 File Offset: 0x03DB41E4
		' (set) Token: 0x06000942 RID: 2370 RVA: 0x03DB5DFC File Offset: 0x03DB41FC
		Friend Overridable Property PictureBox19 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox19
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox19_Click
				Dim flag As Boolean = Me._PictureBox19 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox19.Click, eventHandler
				End If
				Me._PictureBox19 = value
				flag = Me._PictureBox19 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox19.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000326 RID: 806
		' (get) Token: 0x06000943 RID: 2371 RVA: 0x03DB5E5C File Offset: 0x03DB425C
		' (set) Token: 0x06000944 RID: 2372 RVA: 0x03DB5E74 File Offset: 0x03DB4274
		Friend Overridable Property PictureBox10 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox10_Click
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox10_MouseLeave
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox10_MouseEnter
				Dim flag As Boolean = Me._PictureBox10 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox10.Click, eventHandler
					RemoveHandler Me._PictureBox10.MouseLeave, eventHandler2
					RemoveHandler Me._PictureBox10.MouseEnter, eventHandler3
				End If
				Me._PictureBox10 = value
				flag = Me._PictureBox10 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox10.Click, eventHandler
					AddHandler Me._PictureBox10.MouseLeave, eventHandler2
					AddHandler Me._PictureBox10.MouseEnter, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x17000327 RID: 807
		' (get) Token: 0x06000945 RID: 2373 RVA: 0x03DB5F24 File Offset: 0x03DB4324
		' (set) Token: 0x06000946 RID: 2374 RVA: 0x03DB5F3C File Offset: 0x03DB433C
		Friend Overridable Property Label12 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label12 = value
			End Set
		End Property

		' Token: 0x17000328 RID: 808
		' (get) Token: 0x06000947 RID: 2375 RVA: 0x03DB5F48 File Offset: 0x03DB4348
		' (set) Token: 0x06000948 RID: 2376 RVA: 0x03DB5F60 File Offset: 0x03DB4360
		Friend Overridable Property PictureBox20 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox20
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox20_Click
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox20_MouseLeave
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox20_MouseEnter
				Dim flag As Boolean = Me._PictureBox20 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox20.Click, eventHandler
					RemoveHandler Me._PictureBox20.MouseLeave, eventHandler2
					RemoveHandler Me._PictureBox20.MouseEnter, eventHandler3
				End If
				Me._PictureBox20 = value
				flag = Me._PictureBox20 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox20.Click, eventHandler
					AddHandler Me._PictureBox20.MouseLeave, eventHandler2
					AddHandler Me._PictureBox20.MouseEnter, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x17000329 RID: 809
		' (get) Token: 0x06000949 RID: 2377 RVA: 0x03DB6010 File Offset: 0x03DB4410
		' (set) Token: 0x0600094A RID: 2378 RVA: 0x03DB6028 File Offset: 0x03DB4428
		Friend Overridable Property Label13 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label13
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox20_Click
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox20_MouseLeave
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox20_MouseEnter
				Dim flag As Boolean = Me._Label13 IsNot Nothing
				If flag Then
					RemoveHandler Me._Label13.Click, eventHandler
					RemoveHandler Me._Label13.MouseLeave, eventHandler2
					RemoveHandler Me._Label13.MouseEnter, eventHandler3
				End If
				Me._Label13 = value
				flag = Me._Label13 IsNot Nothing
				If flag Then
					AddHandler Me._Label13.Click, eventHandler
					AddHandler Me._Label13.MouseLeave, eventHandler2
					AddHandler Me._Label13.MouseEnter, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x1700032A RID: 810
		' (get) Token: 0x0600094B RID: 2379 RVA: 0x03DB60D8 File Offset: 0x03DB44D8
		' (set) Token: 0x0600094C RID: 2380 RVA: 0x03DB60F0 File Offset: 0x03DB44F0
		Friend Overridable Property Panel6 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel6 = value
			End Set
		End Property

		' Token: 0x1700032B RID: 811
		' (get) Token: 0x0600094D RID: 2381 RVA: 0x03DB60FC File Offset: 0x03DB44FC
		' (set) Token: 0x0600094E RID: 2382 RVA: 0x03DB6114 File Offset: 0x03DB4514
		Friend Overridable Property PictureBox21 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox21
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox20_Click
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox20_MouseLeave
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox20_MouseEnter
				Dim flag As Boolean = Me._PictureBox21 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox21.Click, eventHandler
					RemoveHandler Me._PictureBox21.MouseLeave, eventHandler2
					RemoveHandler Me._PictureBox21.MouseEnter, eventHandler3
				End If
				Me._PictureBox21 = value
				flag = Me._PictureBox21 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox21.Click, eventHandler
					AddHandler Me._PictureBox21.MouseLeave, eventHandler2
					AddHandler Me._PictureBox21.MouseEnter, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x1700032C RID: 812
		' (get) Token: 0x0600094F RID: 2383 RVA: 0x03DB61C4 File Offset: 0x03DB45C4
		' (set) Token: 0x06000950 RID: 2384 RVA: 0x03DB61DC File Offset: 0x03DB45DC
		Friend Overridable Property NO1 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._NO1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._NO1 = value
			End Set
		End Property

		' Token: 0x06000951 RID: 2385 RVA: 0x03DB61E8 File Offset: 0x03DB45E8
		Private Sub form1Pad_Load(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(MyProject.Forms.Form49.Label2.Text, "B2", False) = 0
			If flag Then
				Me.Picture1.Visible = False
				Me.Picture2.Visible = True
			Else
				flag = Operators.CompareString(MyProject.Forms.Form49.Label2.Text, "B3", False) = 0
				If flag Then
					Me.Picture1.Visible = False
					Me.Picture3.Visible = True
				Else
					flag = Operators.CompareString(MyProject.Forms.Form49.Label2.Text, "B4", False) = 0
					If flag Then
						Me.Picture1.Visible = False
						Me.Picture4.Visible = True
					Else
						flag = Operators.CompareString(MyProject.Forms.Form49.Label2.Text, "B5", False) = 0
						If flag Then
							Me.Picture1.Visible = False
							Me.Picture5.Visible = True
						Else
							flag = Operators.CompareString(MyProject.Forms.Form49.Label2.Text, "B6", False) = 0
							If flag Then
								Me.Picture1.Visible = False
								Me.Picture6.Visible = True
								Me.Picture6.Image = MyProject.Forms.Form49.PictureBox6.Image
							Else
								flag = Operators.CompareString(MyProject.Forms.Form49.Label2.Text, "B7", False) = 0
								If flag Then
									Me.Picture1.Visible = False
									Me.Picture7.Visible = True
								End If
							End If
						End If
					End If
				End If
			End If
			Me.Picture1.Image = MyProject.Forms.Form49.PictureBox1.Image
			Me.Picture2.Image = MyProject.Forms.Form49.PictureBox2.Image
			Me.Picture3.Image = MyProject.Forms.Form49.PictureBox3.Image
			Me.Picture4.Image = MyProject.Forms.Form49.PictureBox4.Image
			Me.Picture5.Image = MyProject.Forms.Form49.PictureBox5.Image
			Me.Picture6.Image = MyProject.Forms.Form49.PictureBox6.Image
			Me.Picture1.Image = MyProject.Forms.Form49.PictureBox1.Image
			Me.Picture2.Image = MyProject.Forms.Form49.PictureBox2.Image
			Me.Picture3.Image = MyProject.Forms.Form49.PictureBox3.Image
			Me.Picture4.Image = MyProject.Forms.Form49.PictureBox4.Image
			Me.Picture5.Image = MyProject.Forms.Form49.PictureBox5.Image
			Me.Picture6.Image = MyProject.Forms.Form49.PictureBox6.Image
			MyProject.Forms.AboutBox22.Close()
			flag = MyProject.Forms.Form33.Label1.Visible
			If Not flag Then
				MyProject.Forms.Form49.Close()
			End If
		End Sub

		' Token: 0x06000952 RID: 2386 RVA: 0x03DB6574 File Offset: 0x03DB4974
		Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = MyProject.Forms.Form41.WindowState = FormWindowState.Minimized
			If flag Then
				MyProject.Forms.Form41.WindowState = FormWindowState.Maximized
			Else
				MyProject.Forms.Form41.Show()
			End If
		End Sub

		' Token: 0x06000953 RID: 2387 RVA: 0x03DB65C0 File Offset: 0x03DB49C0
		Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = MyProject.Forms.Form39.WindowState = FormWindowState.Minimized
			If flag Then
				MyProject.Forms.Form39.WindowState = FormWindowState.Maximized
			Else
				MyProject.Forms.Form39.Show()
			End If
		End Sub

		' Token: 0x06000954 RID: 2388 RVA: 0x03DB660C File Offset: 0x03DB4A0C
		Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.Show()
		End Sub

		' Token: 0x06000955 RID: 2389 RVA: 0x03DB6620 File Offset: 0x03DB4A20
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Me.Label1.Text = Strings.Format(DateAndTime.Now, "HH:mm:ss")
			Dim flag As Boolean = Me.cvtaskbar.BackColor = Color.DarkRed
			If flag Then
				Me.Button2.Visible = True
			Else
				Me.Button2.Visible = False
			End If
			Me.Label5.Text = Strings.Format(DateAndTime.Now, "HH:mm")
			Me.Label12.Text = DateTime.Now.ToString("dd-MM-yyyy")
			Me.Label4.Text = Strings.Format(DateAndTime.Now, "dddd:dd")
			Me.Label8.Text = Strings.Format(DateAndTime.Now, "dd:MMMM")
			flag = Operators.CompareString(Me.Label3.Text, "fredag:13", False) = 0
			If flag Then
				Me.Panel1.BackColor = Color.DarkRed
				Me.cvtaskbar.BackColor = Color.DarkRed
			End If
			flag = Me.cvtaskbar.BackColor = Color.DarkBlue
			If Not flag Then
				flag = Me.cvtaskbar.BackColor = Color.Pink
				If Not flag Then
					flag = Me.cvtaskbar.BackColor = Color.Blue
					If Not flag Then
						flag = Me.cvtaskbar.BackColor = Color.Red
						If Not flag Then
							flag = Me.cvtaskbar.BackColor = Color.DarkGray
							If Not flag Then
								flag = Me.cvtaskbar.BackColor = Color.Gray
								If Not flag Then
									flag = Me.cvtaskbar.BackColor = Color.Silver
									If Not flag Then
										flag = Me.cvtaskbar.BackColor = Color.DarkRed
										If flag Then
										End If
									End If
								End If
							End If
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x06000956 RID: 2390 RVA: 0x03DB6838 File Offset: 0x03DB4C38
		Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000957 RID: 2391 RVA: 0x03DB683C File Offset: 0x03DB4C3C
		Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)
			Dim flag As Boolean = MyProject.Forms.Form20.WindowState = FormWindowState.Minimized
			If flag Then
				MyProject.Forms.Form20.WindowState = FormWindowState.Normal
			Else
				MyProject.Forms.Form20.Show()
			End If
		End Sub

		' Token: 0x06000958 RID: 2392 RVA: 0x03DB6888 File Offset: 0x03DB4C88
		Private Sub SebsSWbutton_MouseEnter(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Label3.Text, "fredag:13", False) = 0
			If flag Then
				Me.SebsSWbutton.BackColor = Color.Red
			Else
				Me.SebsSWbutton.BackColor = Color.AliceBlue
			End If
		End Sub

		' Token: 0x06000959 RID: 2393 RVA: 0x03DB68DC File Offset: 0x03DB4CDC
		Private Sub SebsSWbutton_MouseLeave(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Label3.Text, "fredag:13", False) = 0
			If flag Then
				Me.SebsSWbutton.BackColor = Color.Transparent
			Else
				Me.SebsSWbutton.BackColor = Color.Transparent
			End If
		End Sub

		' Token: 0x0600095A RID: 2394 RVA: 0x03DB6930 File Offset: 0x03DB4D30
		Private Sub OpenProgram_MouseEnter(sender As Object, e As EventArgs)
			Me.OpenProgram.BackColor = Color.AliceBlue
			Dim flag As Boolean = Operators.CompareString(Me.Label3.Text, "fredag:13", False) = 0
			If flag Then
				Me.OpenProgram.BackColor = Color.Red
			Else
				Me.OpenProgram.BackColor = Color.AliceBlue
			End If
			flag = Me.cvtaskbar.BackColor = Color.DarkRed
			If flag Then
				Me.OpenProgram.BackColor = Color.Red
			End If
			flag = Me.cvtaskbar.BackColor = Color.Red
			If flag Then
				Me.OpenProgram.BackColor = Color.DarkRed
			End If
			flag = Me.cvtaskbar.BackColor = Color.Blue
			If flag Then
				Me.OpenProgram.BackColor = Color.DarkBlue
			End If
			flag = Me.cvtaskbar.BackColor = Color.DarkBlue
			If flag Then
				Me.OpenProgram.BackColor = Color.Blue
			End If
		End Sub

		' Token: 0x0600095B RID: 2395 RVA: 0x03DB6A40 File Offset: 0x03DB4E40
		Private Sub OpenProgram_MouseLeave(sender As Object, e As EventArgs)
			Me.OpenProgram.BackColor = Color.Silver
			Dim flag As Boolean = Operators.CompareString(Me.Label3.Text, "fredag:13", False) = 0
			If flag Then
				Me.OpenProgram.BackColor = Color.Transparent
			Else
				Me.OpenProgram.BackColor = Color.Silver
			End If
		End Sub

		' Token: 0x0600095C RID: 2396 RVA: 0x03DB6AA4 File Offset: 0x03DB4EA4
		Private Sub settings_MouseEnter(sender As Object, e As EventArgs)
			Me.settings.BackColor = Color.AliceBlue
			Dim flag As Boolean = Operators.CompareString(Me.Label3.Text, "fredag:13", False) = 0
			If flag Then
				Me.settings.BackColor = Color.Red
			Else
				Me.settings.BackColor = Color.AliceBlue
			End If
			flag = Me.cvtaskbar.BackColor = Color.Red
			If flag Then
				Me.settings.BackColor = Color.DarkRed
			End If
			flag = Me.cvtaskbar.BackColor = Color.DarkRed
			If flag Then
				Me.settings.BackColor = Color.Red
			End If
			flag = Me.cvtaskbar.BackColor = Color.Blue
			If flag Then
				Me.settings.BackColor = Color.DarkBlue
			End If
			flag = Me.cvtaskbar.BackColor = Color.DarkBlue
			If flag Then
				Me.settings.BackColor = Color.Blue
			End If
		End Sub

		' Token: 0x0600095D RID: 2397 RVA: 0x03DB6BB4 File Offset: 0x03DB4FB4
		Private Sub settings_MouseLeave(sender As Object, e As EventArgs)
			Me.settings.BackColor = Color.Silver
			Dim flag As Boolean = Operators.CompareString(Me.Label3.Text, "fredag:13", False) = 0
			If flag Then
				Me.settings.BackColor = Color.Transparent
			Else
				Me.settings.BackColor = Color.Silver
			End If
		End Sub

		' Token: 0x0600095E RID: 2398 RVA: 0x03DB6C18 File Offset: 0x03DB5018
		Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox1.BackColor = Color.AliceBlue
			Dim flag As Boolean = Operators.CompareString(Me.Label3.Text, "fredag:13", False) = 0
			If flag Then
				Me.PictureBox1.BackColor = Color.Red
			Else
				Me.PictureBox1.BackColor = Color.AliceBlue
			End If
			flag = Me.cvtaskbar.BackColor = Color.Red
			If flag Then
				Me.PictureBox1.BackColor = Color.DarkRed
			End If
			flag = Me.cvtaskbar.BackColor = Color.DarkRed
			If flag Then
				Me.PictureBox1.BackColor = Color.Red
			End If
			flag = Me.cvtaskbar.BackColor = Color.Blue
			If flag Then
				Me.PictureBox1.BackColor = Color.DarkBlue
			End If
			flag = Me.cvtaskbar.BackColor = Color.DarkBlue
			If flag Then
				Me.PictureBox1.BackColor = Color.Blue
			End If
		End Sub

		' Token: 0x0600095F RID: 2399 RVA: 0x03DB6D28 File Offset: 0x03DB5128
		Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox1.BackColor = Color.Silver
			Dim flag As Boolean = Operators.CompareString(Me.Label3.Text, "fredag:13", False) = 0
			If flag Then
				Me.PictureBox1.BackColor = Color.Transparent
			Else
				Me.PictureBox1.BackColor = Color.Silver
			End If
		End Sub

		' Token: 0x06000960 RID: 2400 RVA: 0x03DB6D8C File Offset: 0x03DB518C
		Private Sub PictureBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs)
			Interaction.MsgBox("Don't Click so Fast", MsgBoxStyle.Exclamation, Nothing)
		End Sub

		' Token: 0x06000961 RID: 2401 RVA: 0x03DB6DA0 File Offset: 0x03DB51A0
		Private Sub settings_MouseDoubleClick(sender As Object, e As MouseEventArgs)
			Interaction.MsgBox("Don't Click so Fast", MsgBoxStyle.Exclamation, Nothing)
		End Sub

		' Token: 0x06000962 RID: 2402 RVA: 0x03DB6DB4 File Offset: 0x03DB51B4
		Private Sub OpenProgram_MouseDoubleClick(sender As Object, e As MouseEventArgs)
			Interaction.MsgBox("Don't Click so Fast", MsgBoxStyle.Exclamation, Nothing)
		End Sub

		' Token: 0x06000963 RID: 2403 RVA: 0x03DB6DC8 File Offset: 0x03DB51C8
		Private Sub SebsSWbutton_MouseDoubleClick(sender As Object, e As MouseEventArgs)
			Interaction.MsgBox("Don't Click so Fast", MsgBoxStyle.Exclamation, Nothing)
		End Sub

		' Token: 0x06000964 RID: 2404 RVA: 0x03DB6DDC File Offset: 0x03DB51DC
		Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs)
			Dim flag As Boolean = MyProject.Forms.Form15.WindowState = FormWindowState.Minimized
			If flag Then
				MyProject.Forms.Form15.WindowState = FormWindowState.Maximized
			Else
				MyProject.Forms.Form15.Show()
			End If
		End Sub

		' Token: 0x06000965 RID: 2405 RVA: 0x03DB6E28 File Offset: 0x03DB5228
		Private Sub Textbutton_MouseEnter(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Label3.Text, "fredag:13", False) = 0
			If flag Then
				Me.Textbutton.BackColor = Color.Red
			Else
				Me.Textbutton.BackColor = Color.AliceBlue
			End If
			flag = Me.cvtaskbar.BackColor = Color.Red
			If flag Then
				Me.Textbutton.BackColor = Color.DarkRed
			End If
			flag = Me.cvtaskbar.BackColor = Color.DarkRed
			If flag Then
				Me.Textbutton.BackColor = Color.Red
			End If
			flag = Me.cvtaskbar.BackColor = Color.Blue
			If flag Then
				Me.Textbutton.BackColor = Color.DarkBlue
			End If
			flag = Me.cvtaskbar.BackColor = Color.DarkBlue
			If flag Then
				Me.Textbutton.BackColor = Color.Blue
			End If
		End Sub

		' Token: 0x06000966 RID: 2406 RVA: 0x03DB6F28 File Offset: 0x03DB5328
		Private Sub Textbutton_MouseLeave(sender As Object, e As EventArgs)
			Me.Textbutton.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000967 RID: 2407 RVA: 0x03DB6F40 File Offset: 0x03DB5340
		Private Sub Textbutton_DoubleClick(sender As Object, e As EventArgs)
			MyProject.Forms.Form37.Show()
		End Sub

		' Token: 0x06000968 RID: 2408 RVA: 0x03DB6F54 File Offset: 0x03DB5354
		Private Sub PictureBox2_Click_2(sender As Object, e As EventArgs)
			Dim flag As Boolean = MyProject.Forms.Form31.WindowState = FormWindowState.Minimized
			If flag Then
				MyProject.Forms.Form31.WindowState = FormWindowState.Normal
			Else
				MyProject.Forms.Form31.Show()
			End If
		End Sub

		' Token: 0x06000969 RID: 2409 RVA: 0x03DB6FA0 File Offset: 0x03DB53A0
		Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox2.BackColor = Color.AliceBlue
			Dim flag As Boolean = Operators.CompareString(Me.Label3.Text, "fredag:13", False) = 0
			If flag Then
				Me.PictureBox2.BackColor = Color.Red
			Else
				Me.PictureBox2.BackColor = Color.AliceBlue
			End If
			flag = Me.cvtaskbar.BackColor = Color.Red
			If flag Then
				Me.PictureBox2.BackColor = Color.DarkRed
			End If
			flag = Me.cvtaskbar.BackColor = Color.DarkRed
			If flag Then
				Me.PictureBox2.BackColor = Color.Red
			End If
			flag = Me.cvtaskbar.BackColor = Color.Blue
			If flag Then
				Me.PictureBox2.BackColor = Color.DarkBlue
			End If
			flag = Me.cvtaskbar.BackColor = Color.DarkBlue
			If flag Then
				Me.PictureBox2.BackColor = Color.Blue
			End If
			flag = Me.PictureBox2.BackColor = Color.WhiteSmoke
			If flag Then
				Me.PictureBox2.BackColor = Color.White
			End If
		End Sub

		' Token: 0x0600096A RID: 2410 RVA: 0x03DB70DC File Offset: 0x03DB54DC
		Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox2.BackColor = Color.Transparent
		End Sub

		' Token: 0x0600096B RID: 2411 RVA: 0x03DB70F4 File Offset: 0x03DB54F4
		Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs)
			MyProject.Forms.Form35.Show()
		End Sub

		' Token: 0x0600096C RID: 2412 RVA: 0x03DB7108 File Offset: 0x03DB5508
		Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox3.BackColor = Color.AliceBlue
			Dim flag As Boolean = Operators.CompareString(Me.Label3.Text, "fredag:13", False) = 0
			If flag Then
				Me.PictureBox3.BackColor = Color.Red
			End If
			flag = Me.cvtaskbar.BackColor = Color.Red
			If flag Then
				Me.PictureBox3.BackColor = Color.DarkRed
			End If
			flag = Me.cvtaskbar.BackColor = Color.DarkRed
			If flag Then
				Me.PictureBox3.BackColor = Color.Red
			End If
			flag = Me.cvtaskbar.BackColor = Color.Blue
			If flag Then
				Me.PictureBox3.BackColor = Color.DarkBlue
			End If
			flag = Me.cvtaskbar.BackColor = Color.DarkBlue
			If flag Then
				Me.PictureBox3.BackColor = Color.Blue
			End If
		End Sub

		' Token: 0x0600096D RID: 2413 RVA: 0x03DB7204 File Offset: 0x03DB5604
		Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox3.BackColor = Color.Transparent
		End Sub

		' Token: 0x0600096E RID: 2414 RVA: 0x03DB721C File Offset: 0x03DB561C
		Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs)
			Me.Start_menu.Visible = True
			Me.PictureBox8.Visible = True
		End Sub

		' Token: 0x0600096F RID: 2415 RVA: 0x03DB723C File Offset: 0x03DB563C
		Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Label3.Text, "fredag:13", False) = 0
			If flag Then
				Me.PictureBox4.BackColor = Color.Red
			End If
			Me.PictureBox4.BackColor = Color.AliceBlue
			flag = Me.cvtaskbar.BackColor = Color.Red
			If flag Then
				Me.PictureBox4.BackColor = Color.DarkRed
			End If
			flag = Me.cvtaskbar.BackColor = Color.DarkRed
			If flag Then
				Me.PictureBox4.BackColor = Color.Red
			End If
			flag = Me.cvtaskbar.BackColor = Color.Blue
			If flag Then
				Me.PictureBox4.BackColor = Color.DarkBlue
			End If
			flag = Me.cvtaskbar.BackColor = Color.DarkBlue
			If flag Then
				Me.PictureBox4.BackColor = Color.Blue
			End If
		End Sub

		' Token: 0x06000970 RID: 2416 RVA: 0x03DB7338 File Offset: 0x03DB5738
		Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox4.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000971 RID: 2417 RVA: 0x03DB7350 File Offset: 0x03DB5750
		Private Sub Label1_DoubleClick(sender As Object, e As EventArgs)
			Interaction.MsgBox(Strings.Format(DateAndTime.Now, "HH:mm:ss"), MsgBoxStyle.OkOnly, Nothing)
		End Sub

		' Token: 0x06000972 RID: 2418 RVA: 0x03DB7370 File Offset: 0x03DB5770
		Private Sub Timer2_Tick(sender As Object, e As EventArgs)
			Dim flag As Boolean = MyProject.Forms.Form43.WindowState = FormWindowState.Minimized
			If flag Then
			End If
			flag = MyProject.Forms.Form22.WindowState = FormWindowState.Minimized
			If flag Then
			End If
		End Sub

		' Token: 0x06000973 RID: 2419 RVA: 0x03DB73B4 File Offset: 0x03DB57B4
		Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form43.WindowState = FormWindowState.Normal
		End Sub

		' Token: 0x06000974 RID: 2420 RVA: 0x03DB73CC File Offset: 0x03DB57CC
		Private Sub PictureBox6_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form22.WindowState = FormWindowState.Normal
		End Sub

		' Token: 0x06000975 RID: 2421 RVA: 0x03DB73E4 File Offset: 0x03DB57E4
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.Panel3.Visible = False
		End Sub

		' Token: 0x06000976 RID: 2422 RVA: 0x03DB73F8 File Offset: 0x03DB57F8
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Label4.Text, "fredag:13", False) = 0
			If Not flag Then
				Me.Panel1.BackColor = Color.Silver
				Me.cvtaskbar.BackColor = Color.Silver
			End If
		End Sub

		' Token: 0x06000977 RID: 2423 RVA: 0x03DB744C File Offset: 0x03DB584C
		Private Sub PictureBox7_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000978 RID: 2424 RVA: 0x03DB7450 File Offset: 0x03DB5850
		Private Sub form1Pad_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Label7.Text, "ON", False) = 0
			If Not flag Then
				flag = Interaction.MsgBox("Close Program?", MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.No
				If flag Then
					MyProject.Forms.Form57.Show()
					MyProject.Forms.Form57.RestartTimer.Start()
				Else
					Me.Label7.Text = "ON"
					MyProject.Forms.Form33.Show()
					MyProject.Forms.Form33.Timer2.Start()
				End If
			End If
		End Sub

		' Token: 0x06000979 RID: 2425 RVA: 0x03DB74F4 File Offset: 0x03DB58F4
		Private Sub Label3_MouseDoubleClick(sender As Object, e As MouseEventArgs)
			Me.Label7.Text = "ON"
		End Sub

		' Token: 0x0600097A RID: 2426 RVA: 0x03DB750C File Offset: 0x03DB590C
		Private Sub Label7_MouseDoubleClick(sender As Object, e As MouseEventArgs)
			MyProject.Forms.Form52.Show()
		End Sub

		' Token: 0x0600097B RID: 2427 RVA: 0x03DB7520 File Offset: 0x03DB5920
		Private Sub PictureBox7_MouseEnter(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600097C RID: 2428 RVA: 0x03DB7524 File Offset: 0x03DB5924
		Private Sub PictureBox7_MouseLeave(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600097D RID: 2429 RVA: 0x03DB7528 File Offset: 0x03DB5928
		Private Sub PictureBox16_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form39.Show()
		End Sub

		' Token: 0x0600097E RID: 2430 RVA: 0x03DB753C File Offset: 0x03DB593C
		Private Sub PictureBox8_Click(sender As Object, e As EventArgs)
			Me.Start_menu.Visible = False
			Me.PictureBox8.Visible = False
		End Sub

		' Token: 0x0600097F RID: 2431 RVA: 0x03DB755C File Offset: 0x03DB595C
		Private Sub PictureBox8_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox8.BackColor = Color.AliceBlue
			Dim flag As Boolean = Me.cvtaskbar.BackColor = Color.Red
			If flag Then
				Me.PictureBox8.BackColor = Color.DarkRed
			End If
			flag = Me.cvtaskbar.BackColor = Color.DarkRed
			If flag Then
				Me.PictureBox8.BackColor = Color.Red
			End If
			flag = Me.cvtaskbar.BackColor = Color.Blue
			If flag Then
				Me.PictureBox8.BackColor = Color.DarkBlue
			End If
			flag = Me.cvtaskbar.BackColor = Color.DarkBlue
			If flag Then
				Me.PictureBox8.BackColor = Color.Blue
			End If
			flag = Me.PictureBox8.BackColor = Color.WhiteSmoke
			If flag Then
				Me.PictureBox8.BackColor = Color.White
			End If
		End Sub

		' Token: 0x06000980 RID: 2432 RVA: 0x03DB7654 File Offset: 0x03DB5A54
		Private Sub PictureBox8_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox8.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000981 RID: 2433 RVA: 0x03DB766C File Offset: 0x03DB5A6C
		Private Sub Panel5_MouseEnter(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000982 RID: 2434 RVA: 0x03DB7670 File Offset: 0x03DB5A70
		Private Sub Panel5_MouseLeave(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000983 RID: 2435 RVA: 0x03DB7674 File Offset: 0x03DB5A74
		Private Sub Panel5_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000984 RID: 2436 RVA: 0x03DB7678 File Offset: 0x03DB5A78
		Private Sub PictureBox15_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form35.Show()
			MyProject.Forms.Form35.WebBrowser1.Navigate("https://sebs-sw-b.tk/info-sebs-sw-1.html")
		End Sub

		' Token: 0x06000985 RID: 2437 RVA: 0x03DB76A8 File Offset: 0x03DB5AA8
		Private Sub PictureBox14_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form20.Show()
		End Sub

		' Token: 0x06000986 RID: 2438 RVA: 0x03DB76BC File Offset: 0x03DB5ABC
		Private Sub PictureBox13_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form22.Show()
		End Sub

		' Token: 0x06000987 RID: 2439 RVA: 0x03DB76D0 File Offset: 0x03DB5AD0
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form30.Show()
		End Sub

		' Token: 0x06000988 RID: 2440 RVA: 0x03DB76E4 File Offset: 0x03DB5AE4
		Private Sub PictureBox18_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form18.Show()
		End Sub

		' Token: 0x06000989 RID: 2441 RVA: 0x03DB76F8 File Offset: 0x03DB5AF8
		Private Sub PictureBox17_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form35.Show()
		End Sub

		' Token: 0x0600098A RID: 2442 RVA: 0x03DB770C File Offset: 0x03DB5B0C
		Private Sub Label9_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form17.Show()
		End Sub

		' Token: 0x0600098B RID: 2443 RVA: 0x03DB7720 File Offset: 0x03DB5B20
		Private Sub Label9_MouseEnter(sender As Object, e As EventArgs)
			Me.Panel5.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x0600098C RID: 2444 RVA: 0x03DB7738 File Offset: 0x03DB5B38
		Private Sub Label9_MouseLeave(sender As Object, e As EventArgs)
			Me.Panel5.BackColor = Color.Transparent
		End Sub

		' Token: 0x0600098D RID: 2445 RVA: 0x03DB7750 File Offset: 0x03DB5B50
		Private Sub PictureBox15_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox15.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x0600098E RID: 2446 RVA: 0x03DB7768 File Offset: 0x03DB5B68
		Private Sub PictureBox14_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox14.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x0600098F RID: 2447 RVA: 0x03DB7780 File Offset: 0x03DB5B80
		Private Sub PictureBox13_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox13.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000990 RID: 2448 RVA: 0x03DB7798 File Offset: 0x03DB5B98
		Private Sub PictureBox15_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox15.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000991 RID: 2449 RVA: 0x03DB77B0 File Offset: 0x03DB5BB0
		Private Sub PictureBox14_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox14.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000992 RID: 2450 RVA: 0x03DB77C8 File Offset: 0x03DB5BC8
		Private Sub PictureBox13_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox13.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000993 RID: 2451 RVA: 0x03DB77E0 File Offset: 0x03DB5BE0
		Private Sub PictureBox18_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox18.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000994 RID: 2452 RVA: 0x03DB77F8 File Offset: 0x03DB5BF8
		Private Sub PictureBox17_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox17.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000995 RID: 2453 RVA: 0x03DB7810 File Offset: 0x03DB5C10
		Private Sub PictureBox16_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox16.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000996 RID: 2454 RVA: 0x03DB7828 File Offset: 0x03DB5C28
		Private Sub PictureBox18_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox18.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000997 RID: 2455 RVA: 0x03DB7840 File Offset: 0x03DB5C40
		Private Sub PictureBox17_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox17.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000998 RID: 2456 RVA: 0x03DB7858 File Offset: 0x03DB5C58
		Private Sub PictureBox16_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox16.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000999 RID: 2457 RVA: 0x03DB7870 File Offset: 0x03DB5C70
		Private Sub PictureBox9_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form60.Show()
		End Sub

		' Token: 0x0600099A RID: 2458 RVA: 0x03DB7884 File Offset: 0x03DB5C84
		Private Sub PictureBox19_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form57.Show()
			MyProject.Forms.Form57.RestartTimer.Start()
		End Sub

		' Token: 0x0600099B RID: 2459 RVA: 0x03DB78B0 File Offset: 0x03DB5CB0
		Private Sub PictureBox7_DoubleClick(sender As Object, e As EventArgs)
			Me.Panel1.BackColor = Color.DarkGray
			Me.Label3.Text = "fredag:13"
		End Sub

		' Token: 0x0600099C RID: 2460 RVA: 0x03DB78D8 File Offset: 0x03DB5CD8
		Private Sub PictureBox10_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form33.Show()
			MyProject.Forms.Form33.Timer2.Start()
		End Sub

		' Token: 0x0600099D RID: 2461 RVA: 0x03DB7904 File Offset: 0x03DB5D04
		Private Sub PictureBox20_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox20.BackColor = Color.AliceBlue
			Dim flag As Boolean = Operators.CompareString(Me.Label3.Text, "fredag:13", False) = 0
			If flag Then
				Me.Panel6.BackColor = Color.Red
			Else
				Me.Panel6.BackColor = Color.AliceBlue
			End If
			flag = Me.cvtaskbar.BackColor = Color.Red
			If flag Then
				Me.Panel6.BackColor = Color.DarkRed
			End If
			flag = Me.cvtaskbar.BackColor = Color.DarkRed
			If flag Then
				Me.Panel6.BackColor = Color.Red
			End If
			flag = Me.cvtaskbar.BackColor = Color.Blue
			If flag Then
				Me.Panel6.BackColor = Color.DarkBlue
			End If
			flag = Me.cvtaskbar.BackColor = Color.DarkBlue
			If flag Then
				Me.Panel6.BackColor = Color.Blue
			End If
		End Sub

		' Token: 0x0600099E RID: 2462 RVA: 0x03DB7A14 File Offset: 0x03DB5E14
		Private Sub PictureBox20_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox20.BackColor = Color.Transparent
		End Sub

		' Token: 0x0600099F RID: 2463 RVA: 0x03DB7A2C File Offset: 0x03DB5E2C
		Private Sub PictureBox20_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AP.Show()
		End Sub

		' Token: 0x060009A0 RID: 2464 RVA: 0x03DB7A40 File Offset: 0x03DB5E40
		Private Sub PictureBox10_MouseEnter(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060009A1 RID: 2465 RVA: 0x03DB7A44 File Offset: 0x03DB5E44
		Private Sub PictureBox10_MouseLeave(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060009A2 RID: 2466 RVA: 0x03DB7A48 File Offset: 0x03DB5E48
		Private Sub Label8_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form_1pad.Show()
		End Sub

		' Token: 0x0400034E RID: 846
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000350 RID: 848
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x04000351 RID: 849
		<AccessedThroughProperty("cvtaskbar")>
		Private _cvtaskbar As Panel

		' Token: 0x04000352 RID: 850
		<AccessedThroughProperty("OpenProgram")>
		Private _OpenProgram As PictureBox

		' Token: 0x04000353 RID: 851
		<AccessedThroughProperty("settings")>
		Private _settings As PictureBox

		' Token: 0x04000354 RID: 852
		<AccessedThroughProperty("SebsSWbutton")>
		Private _SebsSWbutton As PictureBox

		' Token: 0x04000355 RID: 853
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000356 RID: 854
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x04000357 RID: 855
		<AccessedThroughProperty("Picture1")>
		Private _Picture1 As PictureBox

		' Token: 0x04000358 RID: 856
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x04000359 RID: 857
		<AccessedThroughProperty("Textbutton")>
		Private _Textbutton As PictureBox

		' Token: 0x0400035A RID: 858
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x0400035B RID: 859
		<AccessedThroughProperty("Picture2")>
		Private _Picture2 As PictureBox

		' Token: 0x0400035C RID: 860
		<AccessedThroughProperty("Picture3")>
		Private _Picture3 As PictureBox

		' Token: 0x0400035D RID: 861
		<AccessedThroughProperty("Picture4")>
		Private _Picture4 As PictureBox

		' Token: 0x0400035E RID: 862
		<AccessedThroughProperty("Picture5")>
		Private _Picture5 As PictureBox

		' Token: 0x0400035F RID: 863
		<AccessedThroughProperty("Picture6")>
		Private _Picture6 As PictureBox

		' Token: 0x04000360 RID: 864
		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		' Token: 0x04000361 RID: 865
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x04000362 RID: 866
		<AccessedThroughProperty("PictureBox5")>
		Private _PictureBox5 As PictureBox

		' Token: 0x04000363 RID: 867
		<AccessedThroughProperty("Timer2")>
		Private _Timer2 As Timer

		' Token: 0x04000364 RID: 868
		<AccessedThroughProperty("PictureBox6")>
		Private _PictureBox6 As PictureBox

		' Token: 0x04000365 RID: 869
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x04000366 RID: 870
		<AccessedThroughProperty("PictureBox7")>
		Private _PictureBox7 As PictureBox

		' Token: 0x04000367 RID: 871
		<AccessedThroughProperty("Panel3")>
		Private _Panel3 As Panel

		' Token: 0x04000368 RID: 872
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000369 RID: 873
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x0400036A RID: 874
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x0400036B RID: 875
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x0400036C RID: 876
		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		' Token: 0x0400036D RID: 877
		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		' Token: 0x0400036E RID: 878
		<AccessedThroughProperty("Username1")>
		Private _Username1 As Label

		' Token: 0x0400036F RID: 879
		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		' Token: 0x04000370 RID: 880
		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		' Token: 0x04000371 RID: 881
		<AccessedThroughProperty("Start_menu")>
		Private _Start_menu As Panel

		' Token: 0x04000372 RID: 882
		<AccessedThroughProperty("Panel5")>
		Private _Panel5 As Panel

		' Token: 0x04000373 RID: 883
		<AccessedThroughProperty("Label9")>
		Private _Label9 As Label

		' Token: 0x04000374 RID: 884
		<AccessedThroughProperty("PictureBox11")>
		Private _PictureBox11 As PictureBox

		' Token: 0x04000375 RID: 885
		<AccessedThroughProperty("PictureBox12")>
		Private _PictureBox12 As PictureBox

		' Token: 0x04000376 RID: 886
		<AccessedThroughProperty("PictureBox13")>
		Private _PictureBox13 As PictureBox

		' Token: 0x04000377 RID: 887
		<AccessedThroughProperty("PictureBox14")>
		Private _PictureBox14 As PictureBox

		' Token: 0x04000378 RID: 888
		<AccessedThroughProperty("PictureBox15")>
		Private _PictureBox15 As PictureBox

		' Token: 0x04000379 RID: 889
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x0400037A RID: 890
		<AccessedThroughProperty("PictureBox16")>
		Private _PictureBox16 As PictureBox

		' Token: 0x0400037B RID: 891
		<AccessedThroughProperty("PictureBox17")>
		Private _PictureBox17 As PictureBox

		' Token: 0x0400037C RID: 892
		<AccessedThroughProperty("PictureBox18")>
		Private _PictureBox18 As PictureBox

		' Token: 0x0400037D RID: 893
		<AccessedThroughProperty("Label10")>
		Private _Label10 As Label

		' Token: 0x0400037E RID: 894
		<AccessedThroughProperty("PictureBox8")>
		Private _PictureBox8 As PictureBox

		' Token: 0x0400037F RID: 895
		<AccessedThroughProperty("Label11")>
		Private _Label11 As Label

		' Token: 0x04000380 RID: 896
		<AccessedThroughProperty("Picture7")>
		Private _Picture7 As PictureBox

		' Token: 0x04000381 RID: 897
		<AccessedThroughProperty("PictureBox9")>
		Private _PictureBox9 As PictureBox

		' Token: 0x04000382 RID: 898
		<AccessedThroughProperty("PictureBox19")>
		Private _PictureBox19 As PictureBox

		' Token: 0x04000383 RID: 899
		<AccessedThroughProperty("PictureBox10")>
		Private _PictureBox10 As PictureBox

		' Token: 0x04000384 RID: 900
		<AccessedThroughProperty("Label12")>
		Private _Label12 As Label

		' Token: 0x04000385 RID: 901
		<AccessedThroughProperty("PictureBox20")>
		Private _PictureBox20 As PictureBox

		' Token: 0x04000386 RID: 902
		<AccessedThroughProperty("Label13")>
		Private _Label13 As Label

		' Token: 0x04000387 RID: 903
		<AccessedThroughProperty("Panel6")>
		Private _Panel6 As Panel

		' Token: 0x04000388 RID: 904
		<AccessedThroughProperty("PictureBox21")>
		Private _PictureBox21 As PictureBox

		' Token: 0x04000389 RID: 905
		<AccessedThroughProperty("NO1")>
		Private _NO1 As Label
	End Class
End Namespace
