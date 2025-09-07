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
	' Token: 0x0200004C RID: 76
	<DesignerGenerated()>
	Public Partial Class Form30
		Inherits Form

		' Token: 0x06000C34 RID: 3124 RVA: 0x03DC92B0 File Offset: 0x03DC76B0
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form30_Load
			Dim _ENCList As List(Of WeakReference) = Form30.__ENCList
			SyncLock _ENCList
				Form30.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700040E RID: 1038
		' (get) Token: 0x06000C37 RID: 3127 RVA: 0x03DCAC44 File Offset: 0x03DC9044
		' (set) Token: 0x06000C38 RID: 3128 RVA: 0x03DCAC5C File Offset: 0x03DC905C
		Friend Overridable Property PictureBox1 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox1_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox1_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox1_Click
				Dim flag As Boolean = Me._PictureBox1 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox1.MouseLeave, eventHandler
					RemoveHandler Me._PictureBox1.MouseEnter, eventHandler2
					RemoveHandler Me._PictureBox1.Click, eventHandler3
				End If
				Me._PictureBox1 = value
				flag = Me._PictureBox1 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox1.MouseLeave, eventHandler
					AddHandler Me._PictureBox1.MouseEnter, eventHandler2
					AddHandler Me._PictureBox1.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x1700040F RID: 1039
		' (get) Token: 0x06000C39 RID: 3129 RVA: 0x03DCAD0C File Offset: 0x03DC910C
		' (set) Token: 0x06000C3A RID: 3130 RVA: 0x03DCAD24 File Offset: 0x03DC9124
		Friend Overridable Property PictureBox2 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox2_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox2_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox2_Click
				Dim flag As Boolean = Me._PictureBox2 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox2.MouseLeave, eventHandler
					RemoveHandler Me._PictureBox2.MouseEnter, eventHandler2
					RemoveHandler Me._PictureBox2.Click, eventHandler3
				End If
				Me._PictureBox2 = value
				flag = Me._PictureBox2 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox2.MouseLeave, eventHandler
					AddHandler Me._PictureBox2.MouseEnter, eventHandler2
					AddHandler Me._PictureBox2.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x17000410 RID: 1040
		' (get) Token: 0x06000C3B RID: 3131 RVA: 0x03DCADD4 File Offset: 0x03DC91D4
		' (set) Token: 0x06000C3C RID: 3132 RVA: 0x03DCADEC File Offset: 0x03DC91EC
		Friend Overridable Property PictureBox3 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox3_MouseEnter
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox3_Click
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox3_MouseLeave
				Dim flag As Boolean = Me._PictureBox3 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox3.MouseEnter, eventHandler
					RemoveHandler Me._PictureBox3.Click, eventHandler2
					RemoveHandler Me._PictureBox3.MouseLeave, eventHandler3
				End If
				Me._PictureBox3 = value
				flag = Me._PictureBox3 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox3.MouseEnter, eventHandler
					AddHandler Me._PictureBox3.Click, eventHandler2
					AddHandler Me._PictureBox3.MouseLeave, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x17000411 RID: 1041
		' (get) Token: 0x06000C3D RID: 3133 RVA: 0x03DCAE9C File Offset: 0x03DC929C
		' (set) Token: 0x06000C3E RID: 3134 RVA: 0x03DCAEB4 File Offset: 0x03DC92B4
		Friend Overridable Property PictureBox4 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox4_Click
				Dim flag As Boolean = Me._PictureBox4 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox4.Click, eventHandler
				End If
				Me._PictureBox4 = value
				flag = Me._PictureBox4 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox4.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000412 RID: 1042
		' (get) Token: 0x06000C3F RID: 3135 RVA: 0x03DCAF14 File Offset: 0x03DC9314
		' (set) Token: 0x06000C40 RID: 3136 RVA: 0x03DCAF2C File Offset: 0x03DC932C
		Friend Overridable Property Button1 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button1_Click
				Dim eventHandler2 As EventHandler = AddressOf Me.Button1_MouseLeave
				Dim eventHandler3 As EventHandler = AddressOf Me.Button1_MouseEnter
				Dim flag As Boolean = Me._Button1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button1.Click, eventHandler
					RemoveHandler Me._Button1.MouseLeave, eventHandler2
					RemoveHandler Me._Button1.MouseEnter, eventHandler3
				End If
				Me._Button1 = value
				flag = Me._Button1 IsNot Nothing
				If flag Then
					AddHandler Me._Button1.Click, eventHandler
					AddHandler Me._Button1.MouseLeave, eventHandler2
					AddHandler Me._Button1.MouseEnter, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x17000413 RID: 1043
		' (get) Token: 0x06000C41 RID: 3137 RVA: 0x03DCAFDC File Offset: 0x03DC93DC
		' (set) Token: 0x06000C42 RID: 3138 RVA: 0x03DCAFF4 File Offset: 0x03DC93F4
		Friend Overridable Property Stopmenub As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Stopmenub
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Stopmenub = value
			End Set
		End Property

		' Token: 0x17000414 RID: 1044
		' (get) Token: 0x06000C43 RID: 3139 RVA: 0x03DCB000 File Offset: 0x03DC9400
		' (set) Token: 0x06000C44 RID: 3140 RVA: 0x03DCB018 File Offset: 0x03DC9418
		Friend Overridable Property PictureBox5 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox5_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox5_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox5_Click
				Dim flag As Boolean = Me._PictureBox5 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox5.MouseLeave, eventHandler
					RemoveHandler Me._PictureBox5.MouseEnter, eventHandler2
					RemoveHandler Me._PictureBox5.Click, eventHandler3
				End If
				Me._PictureBox5 = value
				flag = Me._PictureBox5 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox5.MouseLeave, eventHandler
					AddHandler Me._PictureBox5.MouseEnter, eventHandler2
					AddHandler Me._PictureBox5.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x17000415 RID: 1045
		' (get) Token: 0x06000C45 RID: 3141 RVA: 0x03DCB0C8 File Offset: 0x03DC94C8
		' (set) Token: 0x06000C46 RID: 3142 RVA: 0x03DCB0E0 File Offset: 0x03DC94E0
		Friend Overridable Property PictureBox6 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox6_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox6_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox6_Click
				Dim flag As Boolean = Me._PictureBox6 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox6.MouseLeave, eventHandler
					RemoveHandler Me._PictureBox6.MouseEnter, eventHandler2
					RemoveHandler Me._PictureBox6.Click, eventHandler3
				End If
				Me._PictureBox6 = value
				flag = Me._PictureBox6 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox6.MouseLeave, eventHandler
					AddHandler Me._PictureBox6.MouseEnter, eventHandler2
					AddHandler Me._PictureBox6.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x17000416 RID: 1046
		' (get) Token: 0x06000C47 RID: 3143 RVA: 0x03DCB190 File Offset: 0x03DC9590
		' (set) Token: 0x06000C48 RID: 3144 RVA: 0x03DCB1A8 File Offset: 0x03DC95A8
		Friend Overridable Property PictureBox7 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox7_Click
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox7_MouseLeave
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox7_MouseEnter
				Dim flag As Boolean = Me._PictureBox7 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox7.Click, eventHandler
					RemoveHandler Me._PictureBox7.MouseLeave, eventHandler2
					RemoveHandler Me._PictureBox7.MouseEnter, eventHandler3
				End If
				Me._PictureBox7 = value
				flag = Me._PictureBox7 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox7.Click, eventHandler
					AddHandler Me._PictureBox7.MouseLeave, eventHandler2
					AddHandler Me._PictureBox7.MouseEnter, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x17000417 RID: 1047
		' (get) Token: 0x06000C49 RID: 3145 RVA: 0x03DCB258 File Offset: 0x03DC9658
		' (set) Token: 0x06000C4A RID: 3146 RVA: 0x03DCB270 File Offset: 0x03DC9670
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

		' Token: 0x17000418 RID: 1048
		' (get) Token: 0x06000C4B RID: 3147 RVA: 0x03DCB320 File Offset: 0x03DC9720
		' (set) Token: 0x06000C4C RID: 3148 RVA: 0x03DCB338 File Offset: 0x03DC9738
		Friend Overridable Property CMDPanalButton As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._CMDPanalButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._CMDPanalButton = value
			End Set
		End Property

		' Token: 0x17000419 RID: 1049
		' (get) Token: 0x06000C4D RID: 3149 RVA: 0x03DCB344 File Offset: 0x03DC9744
		' (set) Token: 0x06000C4E RID: 3150 RVA: 0x03DCB35C File Offset: 0x03DC975C
		Friend Overridable Property PictureBox9 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.Label1_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.Label1_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox9_Click
				Dim flag As Boolean = Me._PictureBox9 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox9.MouseLeave, eventHandler
					RemoveHandler Me._PictureBox9.MouseEnter, eventHandler2
					RemoveHandler Me._PictureBox9.Click, eventHandler3
				End If
				Me._PictureBox9 = value
				flag = Me._PictureBox9 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox9.MouseLeave, eventHandler
					AddHandler Me._PictureBox9.MouseEnter, eventHandler2
					AddHandler Me._PictureBox9.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x1700041A RID: 1050
		' (get) Token: 0x06000C4F RID: 3151 RVA: 0x03DCB40C File Offset: 0x03DC980C
		' (set) Token: 0x06000C50 RID: 3152 RVA: 0x03DCB424 File Offset: 0x03DC9824
		Friend Overridable Property panalp As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._panalp
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.Label1_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.Label1_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.panalp_Click
				Dim flag As Boolean = Me._panalp IsNot Nothing
				If flag Then
					RemoveHandler Me._panalp.MouseLeave, eventHandler
					RemoveHandler Me._panalp.MouseEnter, eventHandler2
					RemoveHandler Me._panalp.Click, eventHandler3
				End If
				Me._panalp = value
				flag = Me._panalp IsNot Nothing
				If flag Then
					AddHandler Me._panalp.MouseLeave, eventHandler
					AddHandler Me._panalp.MouseEnter, eventHandler2
					AddHandler Me._panalp.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x1700041B RID: 1051
		' (get) Token: 0x06000C51 RID: 3153 RVA: 0x03DCB4D4 File Offset: 0x03DC98D4
		' (set) Token: 0x06000C52 RID: 3154 RVA: 0x03DCB4EC File Offset: 0x03DC98EC
		Friend Overridable Property Label1 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim eventHandler As EventHandler = AddressOf Me.Label1_Click
				Dim eventHandler2 As EventHandler = AddressOf Me.Label1_MouseLeave
				Dim eventHandler3 As EventHandler = AddressOf Me.Label1_MouseEnter
				Dim flag As Boolean = Me._Label1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Label1.Click, eventHandler
					RemoveHandler Me._Label1.MouseLeave, eventHandler2
					RemoveHandler Me._Label1.MouseEnter, eventHandler3
				End If
				Me._Label1 = value
				flag = Me._Label1 IsNot Nothing
				If flag Then
					AddHandler Me._Label1.Click, eventHandler
					AddHandler Me._Label1.MouseLeave, eventHandler2
					AddHandler Me._Label1.MouseEnter, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x1700041C RID: 1052
		' (get) Token: 0x06000C53 RID: 3155 RVA: 0x03DCB59C File Offset: 0x03DC999C
		' (set) Token: 0x06000C54 RID: 3156 RVA: 0x03DCB5B4 File Offset: 0x03DC99B4
		Friend Overridable Property PictureBox10 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox10 = value
			End Set
		End Property

		' Token: 0x1700041D RID: 1053
		' (get) Token: 0x06000C55 RID: 3157 RVA: 0x03DCB5C0 File Offset: 0x03DC99C0
		' (set) Token: 0x06000C56 RID: 3158 RVA: 0x03DCB5D8 File Offset: 0x03DC99D8
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

		' Token: 0x1700041E RID: 1054
		' (get) Token: 0x06000C57 RID: 3159 RVA: 0x03DCB5E4 File Offset: 0x03DC99E4
		' (set) Token: 0x06000C58 RID: 3160 RVA: 0x03DCB5FC File Offset: 0x03DC99FC
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

		' Token: 0x1700041F RID: 1055
		' (get) Token: 0x06000C59 RID: 3161 RVA: 0x03DCB608 File Offset: 0x03DC9A08
		' (set) Token: 0x06000C5A RID: 3162 RVA: 0x03DCB620 File Offset: 0x03DC9A20
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

		' Token: 0x17000420 RID: 1056
		' (get) Token: 0x06000C5B RID: 3163 RVA: 0x03DCB62C File Offset: 0x03DC9A2C
		' (set) Token: 0x06000C5C RID: 3164 RVA: 0x03DCB644 File Offset: 0x03DC9A44
		Friend Overridable Property PictureBox11 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox11 = value
			End Set
		End Property

		' Token: 0x17000421 RID: 1057
		' (get) Token: 0x06000C5D RID: 3165 RVA: 0x03DCB650 File Offset: 0x03DC9A50
		' (set) Token: 0x06000C5E RID: 3166 RVA: 0x03DCB668 File Offset: 0x03DC9A68
		Friend Overridable Property PictureBox12 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox12 = value
			End Set
		End Property

		' Token: 0x17000422 RID: 1058
		' (get) Token: 0x06000C5F RID: 3167 RVA: 0x03DCB674 File Offset: 0x03DC9A74
		' (set) Token: 0x06000C60 RID: 3168 RVA: 0x03DCB68C File Offset: 0x03DC9A8C
		Friend Overridable Property PictureBox13 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox13
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox13 = value
			End Set
		End Property

		' Token: 0x17000423 RID: 1059
		' (get) Token: 0x06000C61 RID: 3169 RVA: 0x03DCB698 File Offset: 0x03DC9A98
		' (set) Token: 0x06000C62 RID: 3170 RVA: 0x03DCB6B0 File Offset: 0x03DC9AB0
		Friend Overridable Property PictureBox14 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox14
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox14 = value
			End Set
		End Property

		' Token: 0x17000424 RID: 1060
		' (get) Token: 0x06000C63 RID: 3171 RVA: 0x03DCB6BC File Offset: 0x03DC9ABC
		' (set) Token: 0x06000C64 RID: 3172 RVA: 0x03DCB6D4 File Offset: 0x03DC9AD4
		Friend Overridable Property PictureBox15 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox15
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox15 = value
			End Set
		End Property

		' Token: 0x17000425 RID: 1061
		' (get) Token: 0x06000C65 RID: 3173 RVA: 0x03DCB6E0 File Offset: 0x03DC9AE0
		' (set) Token: 0x06000C66 RID: 3174 RVA: 0x03DCB6F8 File Offset: 0x03DC9AF8
		Friend Overridable Property Button2 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button2 = value
			End Set
		End Property

		' Token: 0x17000426 RID: 1062
		' (get) Token: 0x06000C67 RID: 3175 RVA: 0x03DCB704 File Offset: 0x03DC9B04
		' (set) Token: 0x06000C68 RID: 3176 RVA: 0x03DCB71C File Offset: 0x03DC9B1C
		Friend Overridable Property PictureBox16 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox16
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox16 = value
			End Set
		End Property

		' Token: 0x17000427 RID: 1063
		' (get) Token: 0x06000C69 RID: 3177 RVA: 0x03DCB728 File Offset: 0x03DC9B28
		' (set) Token: 0x06000C6A RID: 3178 RVA: 0x03DCB740 File Offset: 0x03DC9B40
		Friend Overridable Property PictureBox17 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox17
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox17 = value
			End Set
		End Property

		' Token: 0x17000428 RID: 1064
		' (get) Token: 0x06000C6B RID: 3179 RVA: 0x03DCB74C File Offset: 0x03DC9B4C
		' (set) Token: 0x06000C6C RID: 3180 RVA: 0x03DCB764 File Offset: 0x03DC9B64
		Friend Overridable Property PictureBox18 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox18
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox18 = value
			End Set
		End Property

		' Token: 0x06000C6D RID: 3181 RVA: 0x03DCB770 File Offset: 0x03DC9B70
		Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form31.Show()
		End Sub

		' Token: 0x06000C6E RID: 3182 RVA: 0x03DCB784 File Offset: 0x03DC9B84
		Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form35.Show()
		End Sub

		' Token: 0x06000C6F RID: 3183 RVA: 0x03DCB798 File Offset: 0x03DC9B98
		Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form39.Show()
		End Sub

		' Token: 0x06000C70 RID: 3184 RVA: 0x03DCB7AC File Offset: 0x03DC9BAC
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not MyProject.Forms.Form1.Button1.Visible
			If flag Then
				MyProject.Forms.Form1.Show()
				MyProject.Forms.Form1.Panel3.Visible = True
			Else
				flag = Not MyProject.Forms.Form1.Panel3.Visible
				If flag Then
					MyProject.Forms.Form1.Panel3.Visible = True
				Else
					MyProject.Forms.Form1.Panel3.Visible = False
				End If
			End If
			flag = Not MyProject.Forms.Form1.Panel3.Visible
			If flag Then
				MyProject.Forms.Form1.Panel3.Visible = True
			Else
				MyProject.Forms.Form1.Panel3.Visible = False
			End If
			MyProject.Forms.Form1.Panel3.Visible = True
			MyProject.Forms.Form1.Panel3.Visible = True
			MyProject.Forms.Form1.Panel3.Visible = True
		End Sub

		' Token: 0x06000C71 RID: 3185 RVA: 0x03DCB8D8 File Offset: 0x03DC9CD8
		Private Sub Form30_Load(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Stopmenub.Text, "stop", False) = 0
			If flag Then
				MyProject.Forms.Form2.Show()
				Me.Close()
			End If
			Me.Label2.Text = MyProject.Forms.form1Pad.Username1.Text
		End Sub

		' Token: 0x06000C72 RID: 3186 RVA: 0x03DCB93C File Offset: 0x03DC9D3C
		Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form35.Show()
			MyProject.Forms.Form35.WebBrowser1.Navigate("https://sebs-sw-b.tk/info-sebs-sw-1.html")
		End Sub

		' Token: 0x06000C73 RID: 3187 RVA: 0x03DCB96C File Offset: 0x03DC9D6C
		Private Sub Button1_MouseEnter(sender As Object, e As EventArgs)
			Me.Button1.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000C74 RID: 3188 RVA: 0x03DCB984 File Offset: 0x03DC9D84
		Private Sub Button1_MouseLeave(sender As Object, e As EventArgs)
			Me.Button1.BackColor = Color.LightGray
		End Sub

		' Token: 0x06000C75 RID: 3189 RVA: 0x03DCB99C File Offset: 0x03DC9D9C
		Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox3.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000C76 RID: 3190 RVA: 0x03DCB9B4 File Offset: 0x03DC9DB4
		Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox1.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000C77 RID: 3191 RVA: 0x03DCB9CC File Offset: 0x03DC9DCC
		Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox2.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000C78 RID: 3192 RVA: 0x03DCB9E4 File Offset: 0x03DC9DE4
		Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox1.BackColor = Color.LightGray
		End Sub

		' Token: 0x06000C79 RID: 3193 RVA: 0x03DCB9FC File Offset: 0x03DC9DFC
		Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox2.BackColor = Color.LightGray
		End Sub

		' Token: 0x06000C7A RID: 3194 RVA: 0x03DCBA14 File Offset: 0x03DC9E14
		Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox3.BackColor = Color.LightGray
		End Sub

		' Token: 0x06000C7B RID: 3195 RVA: 0x03DCBA2C File Offset: 0x03DC9E2C
		Private Sub PictureBox6_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000C7C RID: 3196 RVA: 0x03DCBA38 File Offset: 0x03DC9E38
		Private Sub PictureBox6_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox6.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000C7D RID: 3197 RVA: 0x03DCBA50 File Offset: 0x03DC9E50
		Private Sub PictureBox6_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox6.BackColor = Color.LightGray
		End Sub

		' Token: 0x06000C7E RID: 3198 RVA: 0x03DCBA68 File Offset: 0x03DC9E68
		Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Stopmenub.Text, "0", False) = 0
			If flag Then
				Me.Stopmenub.Text = "1"
			Else
				flag = Operators.CompareString(Me.Stopmenub.Text, "1", False) = 0
				If flag Then
					Me.Stopmenub.Text = "2"
				Else
					flag = Operators.CompareString(Me.Stopmenub.Text, "2", False) = 0
					If flag Then
						Me.Stopmenub.Text = "3"
					Else
						flag = Operators.CompareString(Me.Stopmenub.Text, "3", False) = 0
						If flag Then
							Me.Stopmenub.Text = "4"
						Else
							flag = Operators.CompareString(Me.Stopmenub.Text, "4", False) = 0
							If flag Then
								Me.WindowState = FormWindowState.Normal
							End If
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x06000C7F RID: 3199 RVA: 0x03DCBB6C File Offset: 0x03DC9F6C
		Private Sub PictureBox5_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox5.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000C80 RID: 3200 RVA: 0x03DCBB84 File Offset: 0x03DC9F84
		Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox5.BackColor = Color.LightGray
		End Sub

		' Token: 0x06000C81 RID: 3201 RVA: 0x03DCBB9C File Offset: 0x03DC9F9C
		Private Sub PictureBox7_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form20.Show()
		End Sub

		' Token: 0x06000C82 RID: 3202 RVA: 0x03DCBBB0 File Offset: 0x03DC9FB0
		Private Sub PictureBox8_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form22.Show()
		End Sub

		' Token: 0x06000C83 RID: 3203 RVA: 0x03DCBBC4 File Offset: 0x03DC9FC4
		Private Sub PictureBox7_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox7.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000C84 RID: 3204 RVA: 0x03DCBBDC File Offset: 0x03DC9FDC
		Private Sub PictureBox7_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox7.BackColor = Color.LightGray
		End Sub

		' Token: 0x06000C85 RID: 3205 RVA: 0x03DCBBF4 File Offset: 0x03DC9FF4
		Private Sub PictureBox8_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox8.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000C86 RID: 3206 RVA: 0x03DCBC0C File Offset: 0x03DCA00C
		Private Sub PictureBox8_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox8.BackColor = Color.LightGray
		End Sub

		' Token: 0x06000C87 RID: 3207 RVA: 0x03DCBC24 File Offset: 0x03DCA024
		Private Sub panalp_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form17.Show()
		End Sub

		' Token: 0x06000C88 RID: 3208 RVA: 0x03DCBC38 File Offset: 0x03DCA038
		Private Sub Label1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form17.Show()
		End Sub

		' Token: 0x06000C89 RID: 3209 RVA: 0x03DCBC4C File Offset: 0x03DCA04C
		Private Sub PictureBox9_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form17.Show()
		End Sub

		' Token: 0x06000C8A RID: 3210 RVA: 0x03DCBC60 File Offset: 0x03DCA060
		Private Sub Label1_MouseEnter(sender As Object, e As EventArgs)
			Me.CMDPanalButton.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000C8B RID: 3211 RVA: 0x03DCBC78 File Offset: 0x03DCA078
		Private Sub Label1_MouseLeave(sender As Object, e As EventArgs)
			Me.CMDPanalButton.BackColor = Color.LightGray
		End Sub

		' Token: 0x04000487 RID: 1159
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000489 RID: 1161
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x0400048A RID: 1162
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x0400048B RID: 1163
		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		' Token: 0x0400048C RID: 1164
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x0400048D RID: 1165
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400048E RID: 1166
		<AccessedThroughProperty("Stopmenub")>
		Private _Stopmenub As Label

		' Token: 0x0400048F RID: 1167
		<AccessedThroughProperty("PictureBox5")>
		Private _PictureBox5 As PictureBox

		' Token: 0x04000490 RID: 1168
		<AccessedThroughProperty("PictureBox6")>
		Private _PictureBox6 As PictureBox

		' Token: 0x04000491 RID: 1169
		<AccessedThroughProperty("PictureBox7")>
		Private _PictureBox7 As PictureBox

		' Token: 0x04000492 RID: 1170
		<AccessedThroughProperty("PictureBox8")>
		Private _PictureBox8 As PictureBox

		' Token: 0x04000493 RID: 1171
		<AccessedThroughProperty("CMDPanalButton")>
		Private _CMDPanalButton As Panel

		' Token: 0x04000494 RID: 1172
		<AccessedThroughProperty("PictureBox9")>
		Private _PictureBox9 As PictureBox

		' Token: 0x04000495 RID: 1173
		<AccessedThroughProperty("panalp")>
		Private _panalp As PictureBox

		' Token: 0x04000496 RID: 1174
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000497 RID: 1175
		<AccessedThroughProperty("PictureBox10")>
		Private _PictureBox10 As PictureBox

		' Token: 0x04000498 RID: 1176
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x04000499 RID: 1177
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x0400049A RID: 1178
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x0400049B RID: 1179
		<AccessedThroughProperty("PictureBox11")>
		Private _PictureBox11 As PictureBox

		' Token: 0x0400049C RID: 1180
		<AccessedThroughProperty("PictureBox12")>
		Private _PictureBox12 As PictureBox

		' Token: 0x0400049D RID: 1181
		<AccessedThroughProperty("PictureBox13")>
		Private _PictureBox13 As PictureBox

		' Token: 0x0400049E RID: 1182
		<AccessedThroughProperty("PictureBox14")>
		Private _PictureBox14 As PictureBox

		' Token: 0x0400049F RID: 1183
		<AccessedThroughProperty("PictureBox15")>
		Private _PictureBox15 As PictureBox

		' Token: 0x040004A0 RID: 1184
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x040004A1 RID: 1185
		<AccessedThroughProperty("PictureBox16")>
		Private _PictureBox16 As PictureBox

		' Token: 0x040004A2 RID: 1186
		<AccessedThroughProperty("PictureBox17")>
		Private _PictureBox17 As PictureBox

		' Token: 0x040004A3 RID: 1187
		<AccessedThroughProperty("PictureBox18")>
		Private _PictureBox18 As PictureBox
	End Class
End Namespace
