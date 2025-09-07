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
	' Token: 0x0200003E RID: 62
	<DesignerGenerated()>
	Public Partial Class Form1old
		Inherits Form

		' Token: 0x060007DC RID: 2012 RVA: 0x03DAAA5C File Offset: 0x03DA8E5C
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form1old_Load
			Dim _ENCList As List(Of WeakReference) = Form1old.__ENCList
			SyncLock _ENCList
				Form1old.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170002A3 RID: 675
		' (get) Token: 0x060007DF RID: 2015 RVA: 0x03DAE57C File Offset: 0x03DAC97C
		' (set) Token: 0x060007E0 RID: 2016 RVA: 0x03DAE594 File Offset: 0x03DAC994
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

		' Token: 0x170002A4 RID: 676
		' (get) Token: 0x060007E1 RID: 2017 RVA: 0x03DAE5F4 File Offset: 0x03DAC9F4
		' (set) Token: 0x060007E2 RID: 2018 RVA: 0x03DAE60C File Offset: 0x03DACA0C
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

		' Token: 0x170002A5 RID: 677
		' (get) Token: 0x060007E3 RID: 2019 RVA: 0x03DAE66C File Offset: 0x03DACA6C
		' (set) Token: 0x060007E4 RID: 2020 RVA: 0x03DAE684 File Offset: 0x03DACA84
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

		' Token: 0x170002A6 RID: 678
		' (get) Token: 0x060007E5 RID: 2021 RVA: 0x03DAE6E4 File Offset: 0x03DACAE4
		' (set) Token: 0x060007E6 RID: 2022 RVA: 0x03DAE6FC File Offset: 0x03DACAFC
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

		' Token: 0x170002A7 RID: 679
		' (get) Token: 0x060007E7 RID: 2023 RVA: 0x03DAE708 File Offset: 0x03DACB08
		' (set) Token: 0x060007E8 RID: 2024 RVA: 0x03DAE720 File Offset: 0x03DACB20
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

		' Token: 0x170002A8 RID: 680
		' (get) Token: 0x060007E9 RID: 2025 RVA: 0x03DAE72C File Offset: 0x03DACB2C
		' (set) Token: 0x060007EA RID: 2026 RVA: 0x03DAE744 File Offset: 0x03DACB44
		Friend Overridable Property Button4 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button4_Click_1
				Dim flag As Boolean = Me._Button4 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button4.Click, eventHandler
				End If
				Me._Button4 = value
				flag = Me._Button4 IsNot Nothing
				If flag Then
					AddHandler Me._Button4.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002A9 RID: 681
		' (get) Token: 0x060007EB RID: 2027 RVA: 0x03DAE7A4 File Offset: 0x03DACBA4
		' (set) Token: 0x060007EC RID: 2028 RVA: 0x03DAE7BC File Offset: 0x03DACBBC
		Friend Overridable Property Button7 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button7_Click
				Dim flag As Boolean = Me._Button7 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button7.Click, eventHandler
				End If
				Me._Button7 = value
				flag = Me._Button7 IsNot Nothing
				If flag Then
					AddHandler Me._Button7.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002AA RID: 682
		' (get) Token: 0x060007ED RID: 2029 RVA: 0x03DAE81C File Offset: 0x03DACC1C
		' (set) Token: 0x060007EE RID: 2030 RVA: 0x03DAE834 File Offset: 0x03DACC34
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

		' Token: 0x170002AB RID: 683
		' (get) Token: 0x060007EF RID: 2031 RVA: 0x03DAE840 File Offset: 0x03DACC40
		' (set) Token: 0x060007F0 RID: 2032 RVA: 0x03DAE858 File Offset: 0x03DACC58
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

		' Token: 0x170002AC RID: 684
		' (get) Token: 0x060007F1 RID: 2033 RVA: 0x03DAE864 File Offset: 0x03DACC64
		' (set) Token: 0x060007F2 RID: 2034 RVA: 0x03DAE87C File Offset: 0x03DACC7C
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

		' Token: 0x170002AD RID: 685
		' (get) Token: 0x060007F3 RID: 2035 RVA: 0x03DAE888 File Offset: 0x03DACC88
		' (set) Token: 0x060007F4 RID: 2036 RVA: 0x03DAE8A0 File Offset: 0x03DACCA0
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

		' Token: 0x170002AE RID: 686
		' (get) Token: 0x060007F5 RID: 2037 RVA: 0x03DAE8AC File Offset: 0x03DACCAC
		' (set) Token: 0x060007F6 RID: 2038 RVA: 0x03DAE8C4 File Offset: 0x03DACCC4
		Friend Overridable Property PictureBox8 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox8 = value
			End Set
		End Property

		' Token: 0x170002AF RID: 687
		' (get) Token: 0x060007F7 RID: 2039 RVA: 0x03DAE8D0 File Offset: 0x03DACCD0
		' (set) Token: 0x060007F8 RID: 2040 RVA: 0x03DAE8E8 File Offset: 0x03DACCE8
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

		' Token: 0x170002B0 RID: 688
		' (get) Token: 0x060007F9 RID: 2041 RVA: 0x03DAE8F4 File Offset: 0x03DACCF4
		' (set) Token: 0x060007FA RID: 2042 RVA: 0x03DAE90C File Offset: 0x03DACD0C
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

		' Token: 0x170002B1 RID: 689
		' (get) Token: 0x060007FB RID: 2043 RVA: 0x03DAE96C File Offset: 0x03DACD6C
		' (set) Token: 0x060007FC RID: 2044 RVA: 0x03DAE984 File Offset: 0x03DACD84
		Friend Overridable Property Button10 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button10_Click_2
				Dim flag As Boolean = Me._Button10 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button10.Click, eventHandler
				End If
				Me._Button10 = value
				flag = Me._Button10 IsNot Nothing
				If flag Then
					AddHandler Me._Button10.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002B2 RID: 690
		' (get) Token: 0x060007FD RID: 2045 RVA: 0x03DAE9E4 File Offset: 0x03DACDE4
		' (set) Token: 0x060007FE RID: 2046 RVA: 0x03DAE9FC File Offset: 0x03DACDFC
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

		' Token: 0x170002B3 RID: 691
		' (get) Token: 0x060007FF RID: 2047 RVA: 0x03DAEA5C File Offset: 0x03DACE5C
		' (set) Token: 0x06000800 RID: 2048 RVA: 0x03DAEA74 File Offset: 0x03DACE74
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

		' Token: 0x170002B4 RID: 692
		' (get) Token: 0x06000801 RID: 2049 RVA: 0x03DAEA80 File Offset: 0x03DACE80
		' (set) Token: 0x06000802 RID: 2050 RVA: 0x03DAEA98 File Offset: 0x03DACE98
		Friend Overridable Property Button12 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button12_Click_1
				Dim flag As Boolean = Me._Button12 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button12.Click, eventHandler
				End If
				Me._Button12 = value
				flag = Me._Button12 IsNot Nothing
				If flag Then
					AddHandler Me._Button12.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002B5 RID: 693
		' (get) Token: 0x06000803 RID: 2051 RVA: 0x03DAEAF8 File Offset: 0x03DACEF8
		' (set) Token: 0x06000804 RID: 2052 RVA: 0x03DAEB10 File Offset: 0x03DACF10
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

		' Token: 0x170002B6 RID: 694
		' (get) Token: 0x06000805 RID: 2053 RVA: 0x03DAEB1C File Offset: 0x03DACF1C
		' (set) Token: 0x06000806 RID: 2054 RVA: 0x03DAEB34 File Offset: 0x03DACF34
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

		' Token: 0x170002B7 RID: 695
		' (get) Token: 0x06000807 RID: 2055 RVA: 0x03DAEB40 File Offset: 0x03DACF40
		' (set) Token: 0x06000808 RID: 2056 RVA: 0x03DAEB58 File Offset: 0x03DACF58
		Friend Overridable Property Button13 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button13
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button13_Click_1
				Dim flag As Boolean = Me._Button13 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button13.Click, eventHandler
				End If
				Me._Button13 = value
				flag = Me._Button13 IsNot Nothing
				If flag Then
					AddHandler Me._Button13.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002B8 RID: 696
		' (get) Token: 0x06000809 RID: 2057 RVA: 0x03DAEBB8 File Offset: 0x03DACFB8
		' (set) Token: 0x0600080A RID: 2058 RVA: 0x03DAEBD0 File Offset: 0x03DACFD0
		Friend Overridable Property Button14 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button14
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button14_Click_1
				Dim flag As Boolean = Me._Button14 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button14.Click, eventHandler
				End If
				Me._Button14 = value
				flag = Me._Button14 IsNot Nothing
				If flag Then
					AddHandler Me._Button14.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002B9 RID: 697
		' (get) Token: 0x0600080B RID: 2059 RVA: 0x03DAEC30 File Offset: 0x03DAD030
		' (set) Token: 0x0600080C RID: 2060 RVA: 0x03DAEC48 File Offset: 0x03DAD048
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

		' Token: 0x170002BA RID: 698
		' (get) Token: 0x0600080D RID: 2061 RVA: 0x03DAEC54 File Offset: 0x03DAD054
		' (set) Token: 0x0600080E RID: 2062 RVA: 0x03DAEC6C File Offset: 0x03DAD06C
		Friend Overridable Property Button15 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button15
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button15_Click_1
				Dim flag As Boolean = Me._Button15 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button15.Click, eventHandler
				End If
				Me._Button15 = value
				flag = Me._Button15 IsNot Nothing
				If flag Then
					AddHandler Me._Button15.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002BB RID: 699
		' (get) Token: 0x0600080F RID: 2063 RVA: 0x03DAECCC File Offset: 0x03DAD0CC
		' (set) Token: 0x06000810 RID: 2064 RVA: 0x03DAECE4 File Offset: 0x03DAD0E4
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

		' Token: 0x170002BC RID: 700
		' (get) Token: 0x06000811 RID: 2065 RVA: 0x03DAED44 File Offset: 0x03DAD144
		' (set) Token: 0x06000812 RID: 2066 RVA: 0x03DAED5C File Offset: 0x03DAD15C
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

		' Token: 0x170002BD RID: 701
		' (get) Token: 0x06000813 RID: 2067 RVA: 0x03DAED68 File Offset: 0x03DAD168
		' (set) Token: 0x06000814 RID: 2068 RVA: 0x03DAED80 File Offset: 0x03DAD180
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

		' Token: 0x170002BE RID: 702
		' (get) Token: 0x06000815 RID: 2069 RVA: 0x03DAEDE0 File Offset: 0x03DAD1E0
		' (set) Token: 0x06000816 RID: 2070 RVA: 0x03DAEDF8 File Offset: 0x03DAD1F8
		Friend Overridable Property Button5 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button5_Click_4
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

		' Token: 0x170002BF RID: 703
		' (get) Token: 0x06000817 RID: 2071 RVA: 0x03DAEE58 File Offset: 0x03DAD258
		' (set) Token: 0x06000818 RID: 2072 RVA: 0x03DAEE70 File Offset: 0x03DAD270
		Friend Overridable Property Button6 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button6_Click_3
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

		' Token: 0x170002C0 RID: 704
		' (get) Token: 0x06000819 RID: 2073 RVA: 0x03DAEED0 File Offset: 0x03DAD2D0
		' (set) Token: 0x0600081A RID: 2074 RVA: 0x03DAEEE8 File Offset: 0x03DAD2E8
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

		' Token: 0x170002C1 RID: 705
		' (get) Token: 0x0600081B RID: 2075 RVA: 0x03DAEEF4 File Offset: 0x03DAD2F4
		' (set) Token: 0x0600081C RID: 2076 RVA: 0x03DAEF0C File Offset: 0x03DAD30C
		Friend Overridable Property startbutton2 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._startbutton2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.startbutton2_Click
				Dim flag As Boolean = Me._startbutton2 IsNot Nothing
				If flag Then
					RemoveHandler Me._startbutton2.Click, eventHandler
				End If
				Me._startbutton2 = value
				flag = Me._startbutton2 IsNot Nothing
				If flag Then
					AddHandler Me._startbutton2.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002C2 RID: 706
		' (get) Token: 0x0600081D RID: 2077 RVA: 0x03DAEF6C File Offset: 0x03DAD36C
		' (set) Token: 0x0600081E RID: 2078 RVA: 0x03DAEF84 File Offset: 0x03DAD384
		Friend Overridable Property PictureBox12 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox12_Click
				Dim flag As Boolean = Me._PictureBox12 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox12.Click, eventHandler
				End If
				Me._PictureBox12 = value
				flag = Me._PictureBox12 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox12.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002C3 RID: 707
		' (get) Token: 0x0600081F RID: 2079 RVA: 0x03DAEFE4 File Offset: 0x03DAD3E4
		' (set) Token: 0x06000820 RID: 2080 RVA: 0x03DAEFFC File Offset: 0x03DAD3FC
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

		' Token: 0x170002C4 RID: 708
		' (get) Token: 0x06000821 RID: 2081 RVA: 0x03DAF008 File Offset: 0x03DAD408
		' (set) Token: 0x06000822 RID: 2082 RVA: 0x03DAF020 File Offset: 0x03DAD420
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

		' Token: 0x170002C5 RID: 709
		' (get) Token: 0x06000823 RID: 2083 RVA: 0x03DAF02C File Offset: 0x03DAD42C
		' (set) Token: 0x06000824 RID: 2084 RVA: 0x03DAF044 File Offset: 0x03DAD444
		Friend Overridable Property PictureBox11 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox11_Click
				Dim flag As Boolean = Me._PictureBox11 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox11.Click, eventHandler
				End If
				Me._PictureBox11 = value
				flag = Me._PictureBox11 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox11.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002C6 RID: 710
		' (get) Token: 0x06000825 RID: 2085 RVA: 0x03DAF0A4 File Offset: 0x03DAD4A4
		' (set) Token: 0x06000826 RID: 2086 RVA: 0x03DAF0BC File Offset: 0x03DAD4BC
		Friend Overridable Property PictureBox10 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox10_Click
				Dim flag As Boolean = Me._PictureBox10 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox10.Click, eventHandler
				End If
				Me._PictureBox10 = value
				flag = Me._PictureBox10 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox10.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002C7 RID: 711
		' (get) Token: 0x06000827 RID: 2087 RVA: 0x03DAF11C File Offset: 0x03DAD51C
		' (set) Token: 0x06000828 RID: 2088 RVA: 0x03DAF134 File Offset: 0x03DAD534
		Friend Overridable Property Startbutton As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Startbutton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.Startbutton_Click
				Dim flag As Boolean = Me._Startbutton IsNot Nothing
				If flag Then
					RemoveHandler Me._Startbutton.Click, eventHandler
				End If
				Me._Startbutton = value
				flag = Me._Startbutton IsNot Nothing
				If flag Then
					AddHandler Me._Startbutton.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002C8 RID: 712
		' (get) Token: 0x06000829 RID: 2089 RVA: 0x03DAF194 File Offset: 0x03DAD594
		' (set) Token: 0x0600082A RID: 2090 RVA: 0x03DAF1AC File Offset: 0x03DAD5AC
		Friend Overridable Property PictureBox13 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox13
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox13_Click
				Dim flag As Boolean = Me._PictureBox13 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox13.Click, eventHandler
				End If
				Me._PictureBox13 = value
				flag = Me._PictureBox13 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox13.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002C9 RID: 713
		' (get) Token: 0x0600082B RID: 2091 RVA: 0x03DAF20C File Offset: 0x03DAD60C
		' (set) Token: 0x0600082C RID: 2092 RVA: 0x03DAF224 File Offset: 0x03DAD624
		Friend Overridable Property nameline As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._nameline
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._nameline = value
			End Set
		End Property

		' Token: 0x170002CA RID: 714
		' (get) Token: 0x0600082D RID: 2093 RVA: 0x03DAF230 File Offset: 0x03DAD630
		' (set) Token: 0x0600082E RID: 2094 RVA: 0x03DAF248 File Offset: 0x03DAD648
		Friend Overridable Property PictureBox14 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox14
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox14_Click
				Dim flag As Boolean = Me._PictureBox14 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox14.Click, eventHandler
				End If
				Me._PictureBox14 = value
				flag = Me._PictureBox14 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox14.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002CB RID: 715
		' (get) Token: 0x0600082F RID: 2095 RVA: 0x03DAF2A8 File Offset: 0x03DAD6A8
		' (set) Token: 0x06000830 RID: 2096 RVA: 0x03DAF2C0 File Offset: 0x03DAD6C0
		Friend Overridable Property SearchSW As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._SearchSW
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim eventHandler As EventHandler = AddressOf Me.SearchSW_Tick
				Dim flag As Boolean = Me._SearchSW IsNot Nothing
				If flag Then
					RemoveHandler Me._SearchSW.Tick, eventHandler
				End If
				Me._SearchSW = value
				flag = Me._SearchSW IsNot Nothing
				If flag Then
					AddHandler Me._SearchSW.Tick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002CC RID: 716
		' (get) Token: 0x06000831 RID: 2097 RVA: 0x03DAF320 File Offset: 0x03DAD720
		' (set) Token: 0x06000832 RID: 2098 RVA: 0x03DAF338 File Offset: 0x03DAD738
		Friend Overridable Property Panel4 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel4 = value
			End Set
		End Property

		' Token: 0x170002CD RID: 717
		' (get) Token: 0x06000833 RID: 2099 RVA: 0x03DAF344 File Offset: 0x03DAD744
		' (set) Token: 0x06000834 RID: 2100 RVA: 0x03DAF35C File Offset: 0x03DAD75C
		Friend Overridable Property PictureBox18 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox18
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox18_Click
				Dim flag As Boolean = Me._PictureBox18 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox18.Click, eventHandler
				End If
				Me._PictureBox18 = value
				flag = Me._PictureBox18 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox18.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002CE RID: 718
		' (get) Token: 0x06000835 RID: 2101 RVA: 0x03DAF3BC File Offset: 0x03DAD7BC
		' (set) Token: 0x06000836 RID: 2102 RVA: 0x03DAF3D4 File Offset: 0x03DAD7D4
		Friend Overridable Property Label7 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label7 = value
			End Set
		End Property

		' Token: 0x170002CF RID: 719
		' (get) Token: 0x06000837 RID: 2103 RVA: 0x03DAF3E0 File Offset: 0x03DAD7E0
		' (set) Token: 0x06000838 RID: 2104 RVA: 0x03DAF3F8 File Offset: 0x03DAD7F8
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

		' Token: 0x170002D0 RID: 720
		' (get) Token: 0x06000839 RID: 2105 RVA: 0x03DAF458 File Offset: 0x03DAD858
		' (set) Token: 0x0600083A RID: 2106 RVA: 0x03DAF470 File Offset: 0x03DAD870
		Friend Overridable Property PictureBox20 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox20
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox20_Click
				Dim flag As Boolean = Me._PictureBox20 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox20.Click, eventHandler
				End If
				Me._PictureBox20 = value
				flag = Me._PictureBox20 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox20.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002D1 RID: 721
		' (get) Token: 0x0600083B RID: 2107 RVA: 0x03DAF4D0 File Offset: 0x03DAD8D0
		' (set) Token: 0x0600083C RID: 2108 RVA: 0x03DAF4E8 File Offset: 0x03DAD8E8
		Friend Overridable Property PictureBox21 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox21
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox21_Click
				Dim flag As Boolean = Me._PictureBox21 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox21.Click, eventHandler
				End If
				Me._PictureBox21 = value
				flag = Me._PictureBox21 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox21.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002D2 RID: 722
		' (get) Token: 0x0600083D RID: 2109 RVA: 0x03DAF548 File Offset: 0x03DAD948
		' (set) Token: 0x0600083E RID: 2110 RVA: 0x03DAF560 File Offset: 0x03DAD960
		Friend Overridable Property Label8 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label8 = value
			End Set
		End Property

		' Token: 0x170002D3 RID: 723
		' (get) Token: 0x0600083F RID: 2111 RVA: 0x03DAF56C File Offset: 0x03DAD96C
		' (set) Token: 0x06000840 RID: 2112 RVA: 0x03DAF584 File Offset: 0x03DAD984
		Friend Overridable Property Label9 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label9 = value
			End Set
		End Property

		' Token: 0x170002D4 RID: 724
		' (get) Token: 0x06000841 RID: 2113 RVA: 0x03DAF590 File Offset: 0x03DAD990
		' (set) Token: 0x06000842 RID: 2114 RVA: 0x03DAF5A8 File Offset: 0x03DAD9A8
		Friend Overridable Property PictureBox22 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox22
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox22_Click
				Dim flag As Boolean = Me._PictureBox22 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox22.Click, eventHandler
				End If
				Me._PictureBox22 = value
				flag = Me._PictureBox22 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox22.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002D5 RID: 725
		' (get) Token: 0x06000843 RID: 2115 RVA: 0x03DAF608 File Offset: 0x03DADA08
		' (set) Token: 0x06000844 RID: 2116 RVA: 0x03DAF620 File Offset: 0x03DADA20
		Friend Overridable Property PictureBox23 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox23
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox23_Click
				Dim flag As Boolean = Me._PictureBox23 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox23.Click, eventHandler
				End If
				Me._PictureBox23 = value
				flag = Me._PictureBox23 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox23.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002D6 RID: 726
		' (get) Token: 0x06000845 RID: 2117 RVA: 0x03DAF680 File Offset: 0x03DADA80
		' (set) Token: 0x06000846 RID: 2118 RVA: 0x03DAF698 File Offset: 0x03DADA98
		Friend Overridable Property PictureBox24 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox24
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox24_Click
				Dim flag As Boolean = Me._PictureBox24 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox24.Click, eventHandler
				End If
				Me._PictureBox24 = value
				flag = Me._PictureBox24 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox24.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002D7 RID: 727
		' (get) Token: 0x06000847 RID: 2119 RVA: 0x03DAF6F8 File Offset: 0x03DADAF8
		' (set) Token: 0x06000848 RID: 2120 RVA: 0x03DAF710 File Offset: 0x03DADB10
		Friend Overridable Property tabletmodetimer As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._tabletmodetimer
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim eventHandler As EventHandler = AddressOf Me.tabletmodetimer_Tick
				Dim flag As Boolean = Me._tabletmodetimer IsNot Nothing
				If flag Then
					RemoveHandler Me._tabletmodetimer.Tick, eventHandler
				End If
				Me._tabletmodetimer = value
				flag = Me._tabletmodetimer IsNot Nothing
				If flag Then
					AddHandler Me._tabletmodetimer.Tick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002D8 RID: 728
		' (get) Token: 0x06000849 RID: 2121 RVA: 0x03DAF770 File Offset: 0x03DADB70
		' (set) Token: 0x0600084A RID: 2122 RVA: 0x03DAF788 File Offset: 0x03DADB88
		Friend Overridable Property settings1 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._settings1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.settings1_Click
				Dim flag As Boolean = Me._settings1 IsNot Nothing
				If flag Then
					RemoveHandler Me._settings1.Click, eventHandler
				End If
				Me._settings1 = value
				flag = Me._settings1 IsNot Nothing
				If flag Then
					AddHandler Me._settings1.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002D9 RID: 729
		' (get) Token: 0x0600084B RID: 2123 RVA: 0x03DAF7E8 File Offset: 0x03DADBE8
		' (set) Token: 0x0600084C RID: 2124 RVA: 0x03DAF800 File Offset: 0x03DADC00
		Friend Overridable Property lionsexplorer1 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._lionsexplorer1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.lionsexplorer1_Click
				Dim flag As Boolean = Me._lionsexplorer1 IsNot Nothing
				If flag Then
					RemoveHandler Me._lionsexplorer1.Click, eventHandler
				End If
				Me._lionsexplorer1 = value
				flag = Me._lionsexplorer1 IsNot Nothing
				If flag Then
					AddHandler Me._lionsexplorer1.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002DA RID: 730
		' (get) Token: 0x0600084D RID: 2125 RVA: 0x03DAF860 File Offset: 0x03DADC60
		' (set) Token: 0x0600084E RID: 2126 RVA: 0x03DAF878 File Offset: 0x03DADC78
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

		' Token: 0x170002DB RID: 731
		' (get) Token: 0x0600084F RID: 2127 RVA: 0x03DAF884 File Offset: 0x03DADC84
		' (set) Token: 0x06000850 RID: 2128 RVA: 0x03DAF89C File Offset: 0x03DADC9C
		Friend Overridable Property PictureBox16 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox16
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox16_Click
				Dim flag As Boolean = Me._PictureBox16 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox16.Click, eventHandler
				End If
				Me._PictureBox16 = value
				flag = Me._PictureBox16 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox16.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002DC RID: 732
		' (get) Token: 0x06000851 RID: 2129 RVA: 0x03DAF8FC File Offset: 0x03DADCFC
		' (set) Token: 0x06000852 RID: 2130 RVA: 0x03DAF914 File Offset: 0x03DADD14
		Friend Overridable Property PictureBox15 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox15
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox15_Click
				Dim flag As Boolean = Me._PictureBox15 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox15.Click, eventHandler
				End If
				Me._PictureBox15 = value
				flag = Me._PictureBox15 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox15.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002DD RID: 733
		' (get) Token: 0x06000853 RID: 2131 RVA: 0x03DAF974 File Offset: 0x03DADD74
		' (set) Token: 0x06000854 RID: 2132 RVA: 0x03DAF98C File Offset: 0x03DADD8C
		Friend Overridable Property More As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._More
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.More_Click
				Dim flag As Boolean = Me._More IsNot Nothing
				If flag Then
					RemoveHandler Me._More.Click, eventHandler
				End If
				Me._More = value
				flag = Me._More IsNot Nothing
				If flag Then
					AddHandler Me._More.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002DE RID: 734
		' (get) Token: 0x06000855 RID: 2133 RVA: 0x03DAF9EC File Offset: 0x03DADDEC
		' (set) Token: 0x06000856 RID: 2134 RVA: 0x03DAFA04 File Offset: 0x03DADE04
		Friend Overridable Property restartbutton As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._restartbutton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.restartbutton_Click
				Dim flag As Boolean = Me._restartbutton IsNot Nothing
				If flag Then
					RemoveHandler Me._restartbutton.Click, eventHandler
				End If
				Me._restartbutton = value
				flag = Me._restartbutton IsNot Nothing
				If flag Then
					AddHandler Me._restartbutton.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002DF RID: 735
		' (get) Token: 0x06000857 RID: 2135 RVA: 0x03DAFA64 File Offset: 0x03DADE64
		' (set) Token: 0x06000858 RID: 2136 RVA: 0x03DAFA7C File Offset: 0x03DADE7C
		Friend Overridable Property shutdownbutton As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._shutdownbutton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.shutdownbutton_Click
				Dim flag As Boolean = Me._shutdownbutton IsNot Nothing
				If flag Then
					RemoveHandler Me._shutdownbutton.Click, eventHandler
				End If
				Me._shutdownbutton = value
				flag = Me._shutdownbutton IsNot Nothing
				If flag Then
					AddHandler Me._shutdownbutton.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002E0 RID: 736
		' (get) Token: 0x06000859 RID: 2137 RVA: 0x03DAFADC File Offset: 0x03DADEDC
		' (set) Token: 0x0600085A RID: 2138 RVA: 0x03DAFAF4 File Offset: 0x03DADEF4
		Friend Overridable Property Button9 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button9_Click_3
				Dim flag As Boolean = Me._Button9 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button9.Click, eventHandler
				End If
				Me._Button9 = value
				flag = Me._Button9 IsNot Nothing
				If flag Then
					AddHandler Me._Button9.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002E1 RID: 737
		' (get) Token: 0x0600085B RID: 2139 RVA: 0x03DAFB54 File Offset: 0x03DADF54
		' (set) Token: 0x0600085C RID: 2140 RVA: 0x03DAFB6C File Offset: 0x03DADF6C
		Friend Overridable Property Button18 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button18
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button18_Click_1
				Dim flag As Boolean = Me._Button18 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button18.Click, eventHandler
				End If
				Me._Button18 = value
				flag = Me._Button18 IsNot Nothing
				If flag Then
					AddHandler Me._Button18.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002E2 RID: 738
		' (get) Token: 0x0600085D RID: 2141 RVA: 0x03DAFBCC File Offset: 0x03DADFCC
		' (set) Token: 0x0600085E RID: 2142 RVA: 0x03DAFBE4 File Offset: 0x03DADFE4
		Friend Overridable Property PictureBox17 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox17
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox17_Click
				Dim flag As Boolean = Me._PictureBox17 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox17.Click, eventHandler
				End If
				Me._PictureBox17 = value
				flag = Me._PictureBox17 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox17.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002E3 RID: 739
		' (get) Token: 0x0600085F RID: 2143 RVA: 0x03DAFC44 File Offset: 0x03DAE044
		' (set) Token: 0x06000860 RID: 2144 RVA: 0x03DAFC5C File Offset: 0x03DAE05C
		Friend Overridable Property Panel3 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim paintEventHandler As PaintEventHandler = AddressOf Me.Panel3_Paint
				Dim flag As Boolean = Me._Panel3 IsNot Nothing
				If flag Then
					RemoveHandler Me._Panel3.Paint, paintEventHandler
				End If
				Me._Panel3 = value
				flag = Me._Panel3 IsNot Nothing
				If flag Then
					AddHandler Me._Panel3.Paint, paintEventHandler
				End If
			End Set
		End Property

		' Token: 0x170002E4 RID: 740
		' (get) Token: 0x06000861 RID: 2145 RVA: 0x03DAFCBC File Offset: 0x03DAE0BC
		' (set) Token: 0x06000862 RID: 2146 RVA: 0x03DAFCD4 File Offset: 0x03DAE0D4
		Friend Overridable Property PictureBox25 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox25
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox25_Click
				Dim flag As Boolean = Me._PictureBox25 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox25.Click, eventHandler
				End If
				Me._PictureBox25 = value
				flag = Me._PictureBox25 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox25.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002E5 RID: 741
		' (get) Token: 0x06000863 RID: 2147 RVA: 0x03DAFD34 File Offset: 0x03DAE134
		' (set) Token: 0x06000864 RID: 2148 RVA: 0x03DAFD4C File Offset: 0x03DAE14C
		Friend Overridable Property PictureBox26 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox26
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox26_Click
				Dim flag As Boolean = Me._PictureBox26 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox26.Click, eventHandler
				End If
				Me._PictureBox26 = value
				flag = Me._PictureBox26 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox26.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002E6 RID: 742
		' (get) Token: 0x06000865 RID: 2149 RVA: 0x03DAFDAC File Offset: 0x03DAE1AC
		' (set) Token: 0x06000866 RID: 2150 RVA: 0x03DAFDC4 File Offset: 0x03DAE1C4
		Friend Overridable Property PictureBox27 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox27
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox27_Click
				Dim flag As Boolean = Me._PictureBox27 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox27.Click, eventHandler
				End If
				Me._PictureBox27 = value
				flag = Me._PictureBox27 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox27.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002E7 RID: 743
		' (get) Token: 0x06000867 RID: 2151 RVA: 0x03DAFE24 File Offset: 0x03DAE224
		' (set) Token: 0x06000868 RID: 2152 RVA: 0x03DAFE3C File Offset: 0x03DAE23C
		Friend Overridable Property ShutdownB As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._ShutdownB
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim eventHandler As EventHandler = AddressOf Me.Panel5_Click
				Dim flag As Boolean = Me._ShutdownB IsNot Nothing
				If flag Then
					RemoveHandler Me._ShutdownB.Click, eventHandler
				End If
				Me._ShutdownB = value
				flag = Me._ShutdownB IsNot Nothing
				If flag Then
					AddHandler Me._ShutdownB.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002E8 RID: 744
		' (get) Token: 0x06000869 RID: 2153 RVA: 0x03DAFE9C File Offset: 0x03DAE29C
		' (set) Token: 0x0600086A RID: 2154 RVA: 0x03DAFEB4 File Offset: 0x03DAE2B4
		Friend Overridable Property Label10 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim eventHandler As EventHandler = AddressOf Me.Label10_Click
				Dim flag As Boolean = Me._Label10 IsNot Nothing
				If flag Then
					RemoveHandler Me._Label10.Click, eventHandler
				End If
				Me._Label10 = value
				flag = Me._Label10 IsNot Nothing
				If flag Then
					AddHandler Me._Label10.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002E9 RID: 745
		' (get) Token: 0x0600086B RID: 2155 RVA: 0x03DAFF14 File Offset: 0x03DAE314
		' (set) Token: 0x0600086C RID: 2156 RVA: 0x03DAFF2C File Offset: 0x03DAE32C
		Friend Overridable Property RestartB As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._RestartB
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim eventHandler As EventHandler = AddressOf Me.Panel6_Click
				Dim paintEventHandler As PaintEventHandler = AddressOf Me.Panel6_Paint
				Dim flag As Boolean = Me._RestartB IsNot Nothing
				If flag Then
					RemoveHandler Me._RestartB.Click, eventHandler
					RemoveHandler Me._RestartB.Paint, paintEventHandler
				End If
				Me._RestartB = value
				flag = Me._RestartB IsNot Nothing
				If flag Then
					AddHandler Me._RestartB.Click, eventHandler
					AddHandler Me._RestartB.Paint, paintEventHandler
				End If
			End Set
		End Property

		' Token: 0x170002EA RID: 746
		' (get) Token: 0x0600086D RID: 2157 RVA: 0x03DAFFB4 File Offset: 0x03DAE3B4
		' (set) Token: 0x0600086E RID: 2158 RVA: 0x03DAFFCC File Offset: 0x03DAE3CC
		Friend Overridable Property Label11 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim eventHandler As EventHandler = AddressOf Me.Label11_Click
				Dim flag As Boolean = Me._Label11 IsNot Nothing
				If flag Then
					RemoveHandler Me._Label11.Click, eventHandler
				End If
				Me._Label11 = value
				flag = Me._Label11 IsNot Nothing
				If flag Then
					AddHandler Me._Label11.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002EB RID: 747
		' (get) Token: 0x0600086F RID: 2159 RVA: 0x03DB002C File Offset: 0x03DAE42C
		' (set) Token: 0x06000870 RID: 2160 RVA: 0x03DB0044 File Offset: 0x03DAE444
		Friend Overridable Property PictureBox28 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox28
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox28_Click
				Dim flag As Boolean = Me._PictureBox28 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox28.Click, eventHandler
				End If
				Me._PictureBox28 = value
				flag = Me._PictureBox28 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox28.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002EC RID: 748
		' (get) Token: 0x06000871 RID: 2161 RVA: 0x03DB00A4 File Offset: 0x03DAE4A4
		' (set) Token: 0x06000872 RID: 2162 RVA: 0x03DB00BC File Offset: 0x03DAE4BC
		Friend Overridable Property more2 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._more2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.more2_Click
				Dim flag As Boolean = Me._more2 IsNot Nothing
				If flag Then
					RemoveHandler Me._more2.Click, eventHandler
				End If
				Me._more2 = value
				flag = Me._more2 IsNot Nothing
				If flag Then
					AddHandler Me._more2.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002ED RID: 749
		' (get) Token: 0x06000873 RID: 2163 RVA: 0x03DB011C File Offset: 0x03DAE51C
		' (set) Token: 0x06000874 RID: 2164 RVA: 0x03DB0134 File Offset: 0x03DAE534
		Friend Overridable Property kakak As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._kakak
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._kakak = value
			End Set
		End Property

		' Token: 0x170002EE RID: 750
		' (get) Token: 0x06000875 RID: 2165 RVA: 0x03DB0140 File Offset: 0x03DAE540
		' (set) Token: 0x06000876 RID: 2166 RVA: 0x03DB0158 File Offset: 0x03DAE558
		Friend Overridable Property SWBTimer As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._SWBTimer
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim eventHandler As EventHandler = AddressOf Me.SWBTimer_Tick
				Dim flag As Boolean = Me._SWBTimer IsNot Nothing
				If flag Then
					RemoveHandler Me._SWBTimer.Tick, eventHandler
				End If
				Me._SWBTimer = value
				flag = Me._SWBTimer IsNot Nothing
				If flag Then
					AddHandler Me._SWBTimer.Tick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002EF RID: 751
		' (get) Token: 0x06000877 RID: 2167 RVA: 0x03DB01B8 File Offset: 0x03DAE5B8
		' (set) Token: 0x06000878 RID: 2168 RVA: 0x03DB01D0 File Offset: 0x03DAE5D0
		Friend Overridable Property PictureBox29 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox29
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox29_Click
				Dim flag As Boolean = Me._PictureBox29 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox29.Click, eventHandler
				End If
				Me._PictureBox29 = value
				flag = Me._PictureBox29 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox29.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002F0 RID: 752
		' (get) Token: 0x06000879 RID: 2169 RVA: 0x03DB0230 File Offset: 0x03DAE630
		' (set) Token: 0x0600087A RID: 2170 RVA: 0x03DB0248 File Offset: 0x03DAE648
		Friend Overridable Property PictureBox30 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox30
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox30_Click
				Dim flag As Boolean = Me._PictureBox30 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox30.Click, eventHandler
				End If
				Me._PictureBox30 = value
				flag = Me._PictureBox30 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox30.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002F1 RID: 753
		' (get) Token: 0x0600087B RID: 2171 RVA: 0x03DB02A8 File Offset: 0x03DAE6A8
		' (set) Token: 0x0600087C RID: 2172 RVA: 0x03DB02C0 File Offset: 0x03DAE6C0
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

		' Token: 0x170002F2 RID: 754
		' (get) Token: 0x0600087D RID: 2173 RVA: 0x03DB02CC File Offset: 0x03DAE6CC
		' (set) Token: 0x0600087E RID: 2174 RVA: 0x03DB02E4 File Offset: 0x03DAE6E4
		Friend Overridable Property Username2 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Username2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Username2 = value
			End Set
		End Property

		' Token: 0x0600087F RID: 2175 RVA: 0x03DB02F0 File Offset: 0x03DAE6F0
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form2.Show()
		End Sub

		' Token: 0x06000880 RID: 2176 RVA: 0x03DB0304 File Offset: 0x03DAE704
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			Interaction.MsgBox("Fail To Open Old File Explorer", MsgBoxStyle.Critical, Nothing)
		End Sub

		' Token: 0x06000881 RID: 2177 RVA: 0x03DB0318 File Offset: 0x03DAE718
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form9.Show()
		End Sub

		' Token: 0x06000882 RID: 2178 RVA: 0x03DB032C File Offset: 0x03DAE72C
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Explorer1.Show()
		End Sub

		' Token: 0x06000883 RID: 2179 RVA: 0x03DB0340 File Offset: 0x03DAE740
		Private Sub Button5_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000884 RID: 2180 RVA: 0x03DB0344 File Offset: 0x03DAE744
		Private Sub Button9_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000885 RID: 2181 RVA: 0x03DB0348 File Offset: 0x03DAE748
		Private Sub Button8_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000886 RID: 2182 RVA: 0x03DB034C File Offset: 0x03DAE74C
		Private Sub Button11_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000887 RID: 2183 RVA: 0x03DB0350 File Offset: 0x03DAE750
		Private Sub Button10_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000888 RID: 2184 RVA: 0x03DB0354 File Offset: 0x03DAE754
		Private Sub Button4_Click_1(sender As Object, e As EventArgs)
			MyProject.Forms.backgroundBox1.Show()
		End Sub

		' Token: 0x06000889 RID: 2185 RVA: 0x03DB0368 File Offset: 0x03DAE768
		Private Sub Button6_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600088A RID: 2186 RVA: 0x03DB036C File Offset: 0x03DAE76C
		Private Sub Button5_Click_1(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600088B RID: 2187 RVA: 0x03DB0370 File Offset: 0x03DAE770
		Private Sub Button7_Click(sender As Object, e As EventArgs)
			Interaction.MsgBox("fail To Open Not Internet Explorer", MsgBoxStyle.Critical, Nothing)
		End Sub

		' Token: 0x0600088C RID: 2188 RVA: 0x03DB0384 File Offset: 0x03DAE784
		Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x0600088D RID: 2189 RVA: 0x03DB0388 File Offset: 0x03DAE788
		Private Sub Button14_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600088E RID: 2190 RVA: 0x03DB038C File Offset: 0x03DAE78C
		Private Sub Button15_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600088F RID: 2191 RVA: 0x03DB0390 File Offset: 0x03DAE790
		Private Sub Button13_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000890 RID: 2192 RVA: 0x03DB0394 File Offset: 0x03DAE794
		Private Sub Button12_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000891 RID: 2193 RVA: 0x03DB0398 File Offset: 0x03DAE798
		Private Sub Button16_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000892 RID: 2194 RVA: 0x03DB039C File Offset: 0x03DAE79C
		Private Sub Button17_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000893 RID: 2195 RVA: 0x03DB03A0 File Offset: 0x03DAE7A0
		Private Sub Button5_Click_2(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000894 RID: 2196 RVA: 0x03DB03A4 File Offset: 0x03DAE7A4
		Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x06000895 RID: 2197 RVA: 0x03DB03A8 File Offset: 0x03DAE7A8
		Private Sub Button18_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000896 RID: 2198 RVA: 0x03DB03AC File Offset: 0x03DAE7AC
		Private Sub Button19_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000897 RID: 2199 RVA: 0x03DB03B0 File Offset: 0x03DAE7B0
		Private Sub Button11_Click_1(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000898 RID: 2200 RVA: 0x03DB03B4 File Offset: 0x03DAE7B4
		Private Sub Button10_Click_1(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000899 RID: 2201 RVA: 0x03DB03B8 File Offset: 0x03DAE7B8
		Private Sub Button8_Click_1(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600089A RID: 2202 RVA: 0x03DB03BC File Offset: 0x03DAE7BC
		Private Sub Button6_Click_1(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600089B RID: 2203 RVA: 0x03DB03C0 File Offset: 0x03DAE7C0
		Private Sub Button9_Click_1(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600089C RID: 2204 RVA: 0x03DB03C4 File Offset: 0x03DAE7C4
		Private Sub Button5_Click_3(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600089D RID: 2205 RVA: 0x03DB03C8 File Offset: 0x03DAE7C8
		Private Sub Button6_Click_2(sender As Object, e As EventArgs)
			MyProject.Forms.Form3.Close()
			MyProject.Forms.Form4.Close()
			MyProject.Forms.Form5.Close()
			MyProject.Forms.Form6.Close()
			MyProject.Forms.Form7.Close()
			MyProject.Forms.Explorer1.Close()
			MyProject.Forms.Explorer2.Close()
			MyProject.Forms.AboutBox1.Show()
			MyProject.Forms.AboutBox1.Close()
			MyProject.Forms.AboutBox3.Show()
			MyProject.Forms.AboutBox3.Close()
			MyProject.Forms.AboutBox5.Show()
			MyProject.Forms.AboutBox5.Close()
			MyProject.Forms.AboutBox7.Show()
			MyProject.Forms.AboutBox7.Close()
			MyProject.Forms.AboutBox8.Show()
			MyProject.Forms.AboutBox8.Close()
			MyProject.Forms.AboutBox9.Show()
			MyProject.Forms.AboutBox9.Close()
			MyProject.Forms.Form9.Close()
			MyProject.Forms.Form10.Close()
			MyProject.Forms.Form11.Close()
			MyProject.Forms.Form12.Close()
			MyProject.Forms.Form13.Close()
			MyProject.Forms.Form14.Close()
			MyProject.Forms.Form15.Close()
			MyProject.Forms.Form16.Close()
			MyProject.Forms.Form17.Close()
			MyProject.Forms.Form18.Close()
			MyProject.Forms.Form19.Close()
			MyProject.Forms.Form20.Close()
			MyProject.Forms.Form21.Close()
			MyProject.Forms.Errorbox1.Close()
			MyProject.Forms.Restartform.Show()
		End Sub

		' Token: 0x0600089E RID: 2206 RVA: 0x03DB05F8 File Offset: 0x03DAE9F8
		Private Sub Button8_Click_2(sender As Object, e As EventArgs)
			MyProject.Forms.Form9.Show()
		End Sub

		' Token: 0x0600089F RID: 2207 RVA: 0x03DB060C File Offset: 0x03DAEA0C
		Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060008A0 RID: 2208 RVA: 0x03DB0610 File Offset: 0x03DAEA10
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar2.Increment(3)
			Dim flag As Boolean = Me.ProgressBar2.Value = 100
			If flag Then
				Me.Timer1.[Stop]()
				Me.Button13.Visible = True
			End If
		End Sub

		' Token: 0x060008A1 RID: 2209 RVA: 0x03DB065C File Offset: 0x03DAEA5C
		Private Sub Form1old_Load(sender As Object, e As EventArgs)
			Me.Show()
			Me.PictureBox9.Visible = False
			Me.PictureBox4.Visible = True
			Me.SWBTimer.Start()
			Dim flag As Boolean = Operators.CompareString(MyProject.Forms.Form33.rest1.Text, "Normal", False) = 0
			If flag Then
			End If
			flag = MyProject.Forms.Form29.PictureBox1.Visible
			If flag Then
				Me.PictureBox2.Visible = True
				Me.PictureBox3.Visible = False
				Me.PictureBox4.Visible = False
				Me.PictureBox5.Visible = False
				Me.PictureBox6.Visible = False
				Me.PictureBox7.Visible = False
				Me.PictureBox8.Visible = False
				Me.PictureBox9.Visible = False
				MyProject.Forms.Form29.WindowState = FormWindowState.Minimized
			End If
			flag = MyProject.Forms.Form29.PictureBox2.Visible
			If flag Then
				Me.PictureBox2.Visible = False
				Me.PictureBox3.Visible = True
				Me.PictureBox4.Visible = False
				Me.PictureBox5.Visible = False
				Me.PictureBox6.Visible = False
				Me.PictureBox7.Visible = False
				Me.PictureBox8.Visible = False
				Me.PictureBox9.Visible = False
				MyProject.Forms.Form29.WindowState = FormWindowState.Minimized
			End If
			flag = MyProject.Forms.Form29.PictureBox3.Visible
			If flag Then
				Me.PictureBox2.Visible = False
				Me.PictureBox3.Visible = False
				Me.PictureBox4.Visible = True
				Me.PictureBox5.Visible = False
				Me.PictureBox6.Visible = False
				Me.PictureBox7.Visible = False
				Me.PictureBox8.Visible = False
				Me.PictureBox9.Visible = False
				MyProject.Forms.Form29.WindowState = FormWindowState.Minimized
			End If
			flag = MyProject.Forms.Form29.PictureBox4.Visible
			If flag Then
				Me.PictureBox2.Visible = False
				Me.PictureBox3.Visible = False
				Me.PictureBox4.Visible = False
				Me.PictureBox5.Visible = True
				Me.PictureBox6.Visible = False
				Me.PictureBox7.Visible = False
				Me.PictureBox8.Visible = False
				Me.PictureBox9.Visible = False
				MyProject.Forms.Form29.WindowState = FormWindowState.Minimized
			End If
			flag = MyProject.Forms.Form29.PictureBox5.Visible
			If flag Then
				Me.PictureBox2.Visible = False
				Me.PictureBox3.Visible = False
				Me.PictureBox4.Visible = False
				Me.PictureBox5.Visible = False
				Me.PictureBox6.Visible = True
				Me.PictureBox7.Visible = False
				Me.PictureBox8.Visible = False
				Me.PictureBox9.Visible = False
				MyProject.Forms.Form29.WindowState = FormWindowState.Minimized
			End If
			flag = MyProject.Forms.Form29.PictureBox6.Visible
			If flag Then
				Me.PictureBox2.Visible = False
				Me.PictureBox3.Visible = False
				Me.PictureBox4.Visible = False
				Me.PictureBox5.Visible = False
				Me.PictureBox6.Visible = False
				Me.PictureBox7.Visible = True
				Me.PictureBox8.Visible = False
				Me.PictureBox9.Visible = False
				MyProject.Forms.Form29.WindowState = FormWindowState.Minimized
			End If
			flag = MyProject.Forms.Form29.PictureBox7.Visible
			If flag Then
				Me.PictureBox2.Visible = False
				Me.PictureBox3.Visible = False
				Me.PictureBox4.Visible = False
				Me.PictureBox5.Visible = False
				Me.PictureBox6.Visible = False
				Me.PictureBox7.Visible = False
				Me.PictureBox8.Visible = True
				Me.PictureBox9.Visible = False
				MyProject.Forms.Form29.WindowState = FormWindowState.Minimized
			End If
			flag = MyProject.Forms.Form29.PictureBox8.Visible
			If flag Then
				Me.PictureBox2.Visible = False
				Me.PictureBox3.Visible = False
				Me.PictureBox4.Visible = False
				Me.PictureBox5.Visible = False
				Me.PictureBox6.Visible = False
				Me.PictureBox7.Visible = False
				Me.PictureBox8.Visible = False
				Me.PictureBox9.Visible = True
				MyProject.Forms.Form29.WindowState = FormWindowState.Minimized
			End If
		End Sub

		' Token: 0x060008A2 RID: 2210 RVA: 0x03DB0B50 File Offset: 0x03DAEF50
		Private Sub Button9_Click_2(sender As Object, e As EventArgs)
			MyProject.Forms.Form16.Show()
		End Sub

		' Token: 0x060008A3 RID: 2211 RVA: 0x03DB0B64 File Offset: 0x03DAEF64
		Private Sub Button10_Click_2(sender As Object, e As EventArgs)
			MyProject.Forms.Form19.Show()
		End Sub

		' Token: 0x060008A4 RID: 2212 RVA: 0x03DB0B78 File Offset: 0x03DAEF78
		Private Sub Button11_Click_2(sender As Object, e As EventArgs)
			MyProject.Forms.Form19.Show()
		End Sub

		' Token: 0x060008A5 RID: 2213 RVA: 0x03DB0B8C File Offset: 0x03DAEF8C
		Private Sub Button14_Click_1(sender As Object, e As EventArgs)
			Me.Timer1.Start()
			Me.Button14.Text = "Click her"
			Dim flag As Boolean = Me.ProgressBar2.Value = 100
			If flag Then
				Me.Button13.Visible = True
				Me.Button14.Text = "No click her"
			End If
		End Sub

		' Token: 0x060008A6 RID: 2214 RVA: 0x03DB0BEC File Offset: 0x03DAEFEC
		Private Sub Button12_Click_1(sender As Object, e As EventArgs)
			MyProject.Forms.Form16.Show()
		End Sub

		' Token: 0x060008A7 RID: 2215 RVA: 0x03DB0C00 File Offset: 0x03DAF000
		Private Sub Button13_Click_1(sender As Object, e As EventArgs)
			Interaction.MsgBox("???", MsgBoxStyle.OkOnly, Nothing)
		End Sub

		' Token: 0x060008A8 RID: 2216 RVA: 0x03DB0C14 File Offset: 0x03DAF014
		Private Sub Button15_Click_1(sender As Object, e As EventArgs)
			MyProject.Forms.Errorbox1.Show()
			MyProject.Forms.Errorbox1.al.Text = "Bug fix program remove from Sebs SW"
			MyProject.Forms.Errorbox1.Text = "remove from Sebs SW"
		End Sub

		' Token: 0x060008A9 RID: 2217 RVA: 0x03DB0C64 File Offset: 0x03DAF064
		Private Sub Button16_Click_1(sender As Object, e As EventArgs)
			MyProject.Forms.Form9.Show()
		End Sub

		' Token: 0x060008AA RID: 2218 RVA: 0x03DB0C78 File Offset: 0x03DAF078
		Private Sub Button17_Click_1(sender As Object, e As EventArgs)
			MyProject.Forms.Form19.Show()
		End Sub

		' Token: 0x060008AB RID: 2219 RVA: 0x03DB0C8C File Offset: 0x03DAF08C
		Private Sub Timer2_Tick(sender As Object, e As EventArgs)
			Me.Label2.Text = Strings.Format(DateAndTime.Now, "HH:mm:ss")
			Me.Label1.Text = Strings.Format(DateAndTime.Now, "dd-MM-yyyy")
			Me.Label6.Text = Strings.Format(DateAndTime.Now, "HH:mm:ss")
			Me.Label5.Text = Strings.Format(DateAndTime.Now, "dd-MM-yyyy")
			Me.Label8.Text = Strings.Format(DateAndTime.Now, "HH:mm:ss")
			Me.Label9.Text = Strings.Format(DateAndTime.Now, "dd-MM-yyyy")
			Dim flag As Boolean = Operators.CompareString(Me.TextBox1.Text, "", False) = 0
			If flag Then
				Me.SearchSW.[Stop]()
			Else
				Me.SearchSW.Start()
			End If
			flag = Operators.CompareString(Me.Username1.Text, "", False) = 0
			If flag Then
				Me.Username1.Text = "Sebs SW"
			End If
		End Sub

		' Token: 0x060008AC RID: 2220 RVA: 0x03DB0DC4 File Offset: 0x03DAF1C4
		Private Sub Label1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060008AD RID: 2221 RVA: 0x03DB0DC8 File Offset: 0x03DAF1C8
		Private Sub Button5_Click_4(sender As Object, e As EventArgs)
			MyProject.Forms.Form27.Show()
			MyProject.Forms.Form27.Label1.Text = "???"
		End Sub

		' Token: 0x060008AE RID: 2222 RVA: 0x03DB0DF8 File Offset: 0x03DAF1F8
		Private Sub Button8_Click_3(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060008AF RID: 2223 RVA: 0x03DB0DFC File Offset: 0x03DAF1FC
		Private Sub Button6_Click_3(sender As Object, e As EventArgs)
			MyProject.Forms.Form23.Show()
		End Sub

		' Token: 0x060008B0 RID: 2224 RVA: 0x03DB0E10 File Offset: 0x03DAF210
		Private Sub startbutton2_Click(sender As Object, e As EventArgs)
			Me.Panel3.Visible = False
			Me.startbutton2.Visible = False
			Me.Startbutton.Visible = True
		End Sub

		' Token: 0x060008B1 RID: 2225 RVA: 0x03DB0E3C File Offset: 0x03DAF23C
		Private Sub PictureBox10_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form34.Show()
		End Sub

		' Token: 0x060008B2 RID: 2226 RVA: 0x03DB0E50 File Offset: 0x03DAF250
		Private Sub PictureBox11_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form3.Show()
		End Sub

		' Token: 0x060008B3 RID: 2227 RVA: 0x03DB0E64 File Offset: 0x03DAF264
		Private Sub PictureBox12_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form21.Show()
		End Sub

		' Token: 0x060008B4 RID: 2228 RVA: 0x03DB0E78 File Offset: 0x03DAF278
		Private Sub PictureBox13_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form23.Show()
		End Sub

		' Token: 0x060008B5 RID: 2229 RVA: 0x03DB0E8C File Offset: 0x03DAF28C
		Private Sub Startbutton_Click(sender As Object, e As EventArgs)
			Me.Panel3.Visible = True
			Dim flag As Boolean = Operators.CompareString(Me.Username1.Text, "", False) = 0
			If Not flag Then
				Me.Username2.Text = Me.Username1.Text
			End If
			Me.startbutton2.Visible = True
			Me.Startbutton.Visible = False
		End Sub

		' Token: 0x060008B6 RID: 2230 RVA: 0x03DB0EFC File Offset: 0x03DAF2FC
		Private Sub PictureBox14_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form32.Show()
		End Sub

		' Token: 0x060008B7 RID: 2231 RVA: 0x03DB0F10 File Offset: 0x03DAF310
		Private Sub settings1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form21.Show()
		End Sub

		' Token: 0x060008B8 RID: 2232 RVA: 0x03DB0F24 File Offset: 0x03DAF324
		Private Sub lionsexplorer1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form34.Show()
		End Sub

		' Token: 0x060008B9 RID: 2233 RVA: 0x03DB0F38 File Offset: 0x03DAF338
		Private Sub Button9_Click_3(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060008BA RID: 2234 RVA: 0x03DB0F3C File Offset: 0x03DAF33C
		Private Sub More_Click(sender As Object, e As EventArgs)
			Me.ShutdownB.Visible = True
			Me.RestartB.Visible = True
			Me.More.Visible = False
			Me.more2.Visible = True
		End Sub

		' Token: 0x060008BB RID: 2235 RVA: 0x03DB0F74 File Offset: 0x03DAF374
		Private Sub Button18_Click_1(sender As Object, e As EventArgs)
			MyProject.Forms.Form15.Show()
			MyProject.Forms.Form15.TextBox1.[ReadOnly] = True
			MyProject.Forms.Form15.TextBox1.Text = "You can click on the start button " & vbCrLf & "and now you can see all your Programs " & vbCrLf & "do you want to see the web " & vbCrLf & "click on the Lion "
		End Sub

		' Token: 0x060008BC RID: 2236 RVA: 0x03DB0FC4 File Offset: 0x03DAF3C4
		Private Sub PictureBox9_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060008BD RID: 2237 RVA: 0x03DB0FC8 File Offset: 0x03DAF3C8
		Private Sub PictureBox18_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form38.Show()
		End Sub

		' Token: 0x060008BE RID: 2238 RVA: 0x03DB0FDC File Offset: 0x03DAF3DC
		Private Sub tabletmodetimer_Tick(sender As Object, e As EventArgs)
			Dim visible As Boolean = Me.Panel4.Visible
			If visible Then
			End If
		End Sub

		' Token: 0x060008BF RID: 2239 RVA: 0x03DB1000 File Offset: 0x03DAF400
		Private Sub PictureBox24_Click(sender As Object, e As EventArgs)
			Me.Panel3.Visible = True
			Dim flag As Boolean = Operators.CompareString(Me.Username1.Text, "", False) = 0
			If Not flag Then
				Me.Username2.Text = Me.Username1.Text
			End If
			Me.PictureBox24.Visible = False
			Me.PictureBox20.Visible = True
		End Sub

		' Token: 0x060008C0 RID: 2240 RVA: 0x03DB1070 File Offset: 0x03DAF470
		Private Sub restartbutton_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form33.Show()
			MyProject.Forms.Form33.Timer1.Start()
		End Sub

		' Token: 0x060008C1 RID: 2241 RVA: 0x03DB109C File Offset: 0x03DAF49C
		Private Sub shutdownbutton_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form33.Show()
			MyProject.Forms.Form33.Timer2.Start()
		End Sub

		' Token: 0x060008C2 RID: 2242 RVA: 0x03DB10C8 File Offset: 0x03DAF4C8
		Private Sub PictureBox20_Click(sender As Object, e As EventArgs)
			Me.Panel3.Visible = False
			Me.PictureBox24.Visible = True
			Me.PictureBox20.Visible = False
			Me.PictureBox24.Visible = True
			Me.PictureBox20.Visible = False
		End Sub

		' Token: 0x060008C3 RID: 2243 RVA: 0x03DB1118 File Offset: 0x03DAF518
		Private Sub PictureBox23_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form35.Show()
		End Sub

		' Token: 0x060008C4 RID: 2244 RVA: 0x03DB112C File Offset: 0x03DAF52C
		Private Sub PictureBox19_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form36.Show()
		End Sub

		' Token: 0x060008C5 RID: 2245 RVA: 0x03DB1140 File Offset: 0x03DAF540
		Private Sub PictureBox21_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form21.Show()
		End Sub

		' Token: 0x060008C6 RID: 2246 RVA: 0x03DB1154 File Offset: 0x03DAF554
		Private Sub PictureBox22_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form31.Show()
		End Sub

		' Token: 0x060008C7 RID: 2247 RVA: 0x03DB1168 File Offset: 0x03DAF568
		Private Sub SearchSW_Tick(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.TextBox1.Text, "webt", False) = 0
			If flag Then
				Me.PictureBox25.Visible = True
			Else
				Me.PictureBox25.Visible = False
			End If
			flag = Me.Panel4.Visible
			If flag Then
				Me.PictureBox16.Visible = False
			End If
			flag = Operators.CompareString(Me.TextBox1.Text, "Lions", False) = 0
			If flag Then
				Me.PictureBox16.Visible = True
			Else
				Me.PictureBox16.Visible = False
			End If
			flag = Operators.CompareString(Me.TextBox1.Text, "CMD", False) = 0
			If flag Then
				Me.PictureBox26.Visible = True
			Else
				Me.PictureBox26.Visible = False
			End If
			flag = Operators.CompareString(Me.TextBox1.Text, "Run", False) = 0
			If flag Then
				Me.PictureBox17.Visible = True
			Else
				Me.PictureBox17.Visible = False
			End If
			flag = Operators.CompareString(Me.TextBox1.Text, "settings", False) = 0
			If flag Then
				Me.PictureBox15.Visible = True
			Else
				Me.PictureBox15.Visible = False
			End If
			flag = Operators.CompareString(Me.TextBox1.Text, "run", False) = 0
			If flag Then
				Me.PictureBox17.Visible = True
			Else
				Me.PictureBox17.Visible = False
			End If
			flag = Operators.CompareString(Me.TextBox1.Text, "Run", False) = 0
			If flag Then
				Me.PictureBox17.Visible = True
			Else
				Me.PictureBox17.Visible = False
			End If
		End Sub

		' Token: 0x060008C8 RID: 2248 RVA: 0x03DB1334 File Offset: 0x03DAF734
		Private Sub PictureBox26_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form17.Show()
		End Sub

		' Token: 0x060008C9 RID: 2249 RVA: 0x03DB1348 File Offset: 0x03DAF748
		Private Sub PictureBox27_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form33.Show()
			MyProject.Forms.Form33.Timer2.Start()
		End Sub

		' Token: 0x060008CA RID: 2250 RVA: 0x03DB1374 File Offset: 0x03DAF774
		Private Sub Label10_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form33.Show()
			MyProject.Forms.Form33.Timer2.Start()
		End Sub

		' Token: 0x060008CB RID: 2251 RVA: 0x03DB13A0 File Offset: 0x03DAF7A0
		Private Sub Panel5_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form33.Show()
			MyProject.Forms.Form33.Timer2.Start()
		End Sub

		' Token: 0x060008CC RID: 2252 RVA: 0x03DB13CC File Offset: 0x03DAF7CC
		Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x060008CD RID: 2253 RVA: 0x03DB13D0 File Offset: 0x03DAF7D0
		Private Sub Panel6_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox23.Show()
		End Sub

		' Token: 0x060008CE RID: 2254 RVA: 0x03DB13E4 File Offset: 0x03DAF7E4
		Private Sub PictureBox28_Click(sender As Object, e As EventArgs)
			Interaction.MsgBox("Start CV Window and then restart", MsgBoxStyle.OkOnly, Nothing)
		End Sub

		' Token: 0x060008CF RID: 2255 RVA: 0x03DB13F8 File Offset: 0x03DAF7F8
		Private Sub Label11_Click(sender As Object, e As EventArgs)
			Interaction.MsgBox("Start CV Window and then restart", MsgBoxStyle.OkOnly, Nothing)
		End Sub

		' Token: 0x060008D0 RID: 2256 RVA: 0x03DB140C File Offset: 0x03DAF80C
		Private Sub more2_Click(sender As Object, e As EventArgs)
			Me.ShutdownB.Visible = False
			Me.RestartB.Visible = False
			Me.More.Visible = True
			Me.more2.Visible = False
		End Sub

		' Token: 0x060008D1 RID: 2257 RVA: 0x03DB1444 File Offset: 0x03DAF844
		Private Sub PictureBox15_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form21.Show()
		End Sub

		' Token: 0x060008D2 RID: 2258 RVA: 0x03DB1458 File Offset: 0x03DAF858
		Private Sub PictureBox16_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form19.Show()
		End Sub

		' Token: 0x060008D3 RID: 2259 RVA: 0x03DB146C File Offset: 0x03DAF86C
		Private Sub PictureBox17_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox17.Show()
		End Sub

		' Token: 0x060008D4 RID: 2260 RVA: 0x03DB1480 File Offset: 0x03DAF880
		Private Sub PictureBox25_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form34.Show()
		End Sub

		' Token: 0x060008D5 RID: 2261 RVA: 0x03DB1494 File Offset: 0x03DAF894
		Private Sub SWBTimer_Tick(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Text, "Sebs SW B", False) = 0
			If flag Then
				Me.PictureBox18.Visible = True
				Me.PictureBox29.Visible = True
			End If
		End Sub

		' Token: 0x060008D6 RID: 2262 RVA: 0x03DB14D8 File Offset: 0x03DAF8D8
		Private Sub PictureBox29_Click(sender As Object, e As EventArgs)
			Me.Panel4.Visible = True
			Me.Panel1.Visible = False
		End Sub

		' Token: 0x060008D7 RID: 2263 RVA: 0x03DB14F8 File Offset: 0x03DAF8F8
		Private Sub PictureBox30_Click(sender As Object, e As EventArgs)
			Interaction.MsgBox("Start CV Window and then shutdown", MsgBoxStyle.OkOnly, Nothing)
		End Sub

		' Token: 0x060008D8 RID: 2264 RVA: 0x03DB150C File Offset: 0x03DAF90C
		Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x040002FC RID: 764
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040002FE RID: 766
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040002FF RID: 767
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x04000300 RID: 768
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x04000301 RID: 769
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x04000302 RID: 770
		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		' Token: 0x04000303 RID: 771
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x04000304 RID: 772
		<AccessedThroughProperty("Button7")>
		Private _Button7 As Button

		' Token: 0x04000305 RID: 773
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x04000306 RID: 774
		<AccessedThroughProperty("PictureBox5")>
		Private _PictureBox5 As PictureBox

		' Token: 0x04000307 RID: 775
		<AccessedThroughProperty("PictureBox6")>
		Private _PictureBox6 As PictureBox

		' Token: 0x04000308 RID: 776
		<AccessedThroughProperty("PictureBox7")>
		Private _PictureBox7 As PictureBox

		' Token: 0x04000309 RID: 777
		<AccessedThroughProperty("PictureBox8")>
		Private _PictureBox8 As PictureBox

		' Token: 0x0400030A RID: 778
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x0400030B RID: 779
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x0400030C RID: 780
		<AccessedThroughProperty("Button10")>
		Private _Button10 As Button

		' Token: 0x0400030D RID: 781
		<AccessedThroughProperty("PictureBox9")>
		Private _PictureBox9 As PictureBox

		' Token: 0x0400030E RID: 782
		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel

		' Token: 0x0400030F RID: 783
		<AccessedThroughProperty("Button12")>
		Private _Button12 As Button

		' Token: 0x04000310 RID: 784
		<AccessedThroughProperty("ProgressBar2")>
		Private _ProgressBar2 As ProgressBar

		' Token: 0x04000311 RID: 785
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x04000312 RID: 786
		<AccessedThroughProperty("Button13")>
		Private _Button13 As Button

		' Token: 0x04000313 RID: 787
		<AccessedThroughProperty("Button14")>
		Private _Button14 As Button

		' Token: 0x04000314 RID: 788
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x04000315 RID: 789
		<AccessedThroughProperty("Button15")>
		Private _Button15 As Button

		' Token: 0x04000316 RID: 790
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000317 RID: 791
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x04000318 RID: 792
		<AccessedThroughProperty("Timer2")>
		Private _Timer2 As Timer

		' Token: 0x04000319 RID: 793
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x0400031A RID: 794
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x0400031B RID: 795
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x0400031C RID: 796
		<AccessedThroughProperty("startbutton2")>
		Private _startbutton2 As PictureBox

		' Token: 0x0400031D RID: 797
		<AccessedThroughProperty("PictureBox12")>
		Private _PictureBox12 As PictureBox

		' Token: 0x0400031E RID: 798
		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		' Token: 0x0400031F RID: 799
		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		' Token: 0x04000320 RID: 800
		<AccessedThroughProperty("PictureBox11")>
		Private _PictureBox11 As PictureBox

		' Token: 0x04000321 RID: 801
		<AccessedThroughProperty("PictureBox10")>
		Private _PictureBox10 As PictureBox

		' Token: 0x04000322 RID: 802
		<AccessedThroughProperty("Startbutton")>
		Private _Startbutton As PictureBox

		' Token: 0x04000323 RID: 803
		<AccessedThroughProperty("PictureBox13")>
		Private _PictureBox13 As PictureBox

		' Token: 0x04000324 RID: 804
		<AccessedThroughProperty("nameline")>
		Private _nameline As Label

		' Token: 0x04000325 RID: 805
		<AccessedThroughProperty("PictureBox14")>
		Private _PictureBox14 As PictureBox

		' Token: 0x04000326 RID: 806
		<AccessedThroughProperty("SearchSW")>
		Private _SearchSW As Timer

		' Token: 0x04000327 RID: 807
		<AccessedThroughProperty("Panel4")>
		Private _Panel4 As Panel

		' Token: 0x04000328 RID: 808
		<AccessedThroughProperty("PictureBox18")>
		Private _PictureBox18 As PictureBox

		' Token: 0x04000329 RID: 809
		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		' Token: 0x0400032A RID: 810
		<AccessedThroughProperty("PictureBox19")>
		Private _PictureBox19 As PictureBox

		' Token: 0x0400032B RID: 811
		<AccessedThroughProperty("PictureBox20")>
		Private _PictureBox20 As PictureBox

		' Token: 0x0400032C RID: 812
		<AccessedThroughProperty("PictureBox21")>
		Private _PictureBox21 As PictureBox

		' Token: 0x0400032D RID: 813
		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		' Token: 0x0400032E RID: 814
		<AccessedThroughProperty("Label9")>
		Private _Label9 As Label

		' Token: 0x0400032F RID: 815
		<AccessedThroughProperty("PictureBox22")>
		Private _PictureBox22 As PictureBox

		' Token: 0x04000330 RID: 816
		<AccessedThroughProperty("PictureBox23")>
		Private _PictureBox23 As PictureBox

		' Token: 0x04000331 RID: 817
		<AccessedThroughProperty("PictureBox24")>
		Private _PictureBox24 As PictureBox

		' Token: 0x04000332 RID: 818
		<AccessedThroughProperty("tabletmodetimer")>
		Private _tabletmodetimer As Timer

		' Token: 0x04000333 RID: 819
		<AccessedThroughProperty("settings1")>
		Private _settings1 As PictureBox

		' Token: 0x04000334 RID: 820
		<AccessedThroughProperty("lionsexplorer1")>
		Private _lionsexplorer1 As PictureBox

		' Token: 0x04000335 RID: 821
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x04000336 RID: 822
		<AccessedThroughProperty("PictureBox16")>
		Private _PictureBox16 As PictureBox

		' Token: 0x04000337 RID: 823
		<AccessedThroughProperty("PictureBox15")>
		Private _PictureBox15 As PictureBox

		' Token: 0x04000338 RID: 824
		<AccessedThroughProperty("More")>
		Private _More As Button

		' Token: 0x04000339 RID: 825
		<AccessedThroughProperty("restartbutton")>
		Private _restartbutton As Button

		' Token: 0x0400033A RID: 826
		<AccessedThroughProperty("shutdownbutton")>
		Private _shutdownbutton As Button

		' Token: 0x0400033B RID: 827
		<AccessedThroughProperty("Button9")>
		Private _Button9 As Button

		' Token: 0x0400033C RID: 828
		<AccessedThroughProperty("Button18")>
		Private _Button18 As Button

		' Token: 0x0400033D RID: 829
		<AccessedThroughProperty("PictureBox17")>
		Private _PictureBox17 As PictureBox

		' Token: 0x0400033E RID: 830
		<AccessedThroughProperty("Panel3")>
		Private _Panel3 As Panel

		' Token: 0x0400033F RID: 831
		<AccessedThroughProperty("PictureBox25")>
		Private _PictureBox25 As PictureBox

		' Token: 0x04000340 RID: 832
		<AccessedThroughProperty("PictureBox26")>
		Private _PictureBox26 As PictureBox

		' Token: 0x04000341 RID: 833
		<AccessedThroughProperty("PictureBox27")>
		Private _PictureBox27 As PictureBox

		' Token: 0x04000342 RID: 834
		<AccessedThroughProperty("ShutdownB")>
		Private _ShutdownB As Panel

		' Token: 0x04000343 RID: 835
		<AccessedThroughProperty("Label10")>
		Private _Label10 As Label

		' Token: 0x04000344 RID: 836
		<AccessedThroughProperty("RestartB")>
		Private _RestartB As Panel

		' Token: 0x04000345 RID: 837
		<AccessedThroughProperty("Label11")>
		Private _Label11 As Label

		' Token: 0x04000346 RID: 838
		<AccessedThroughProperty("PictureBox28")>
		Private _PictureBox28 As PictureBox

		' Token: 0x04000347 RID: 839
		<AccessedThroughProperty("more2")>
		Private _more2 As Button

		' Token: 0x04000348 RID: 840
		<AccessedThroughProperty("kakak")>
		Private _kakak As Label

		' Token: 0x04000349 RID: 841
		<AccessedThroughProperty("SWBTimer")>
		Private _SWBTimer As Timer

		' Token: 0x0400034A RID: 842
		<AccessedThroughProperty("PictureBox29")>
		Private _PictureBox29 As PictureBox

		' Token: 0x0400034B RID: 843
		<AccessedThroughProperty("PictureBox30")>
		Private _PictureBox30 As PictureBox

		' Token: 0x0400034C RID: 844
		<AccessedThroughProperty("Username1")>
		Private _Username1 As Label

		' Token: 0x0400034D RID: 845
		<AccessedThroughProperty("Username2")>
		Private _Username2 As Label
	End Class
End Namespace
