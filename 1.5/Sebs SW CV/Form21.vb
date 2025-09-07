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
	' Token: 0x02000042 RID: 66
	<DesignerGenerated()>
	Public Partial Class Form21
		Inherits Form

		' Token: 0x060009F8 RID: 2552 RVA: 0x03DBA284 File Offset: 0x03DB8684
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form21_Load
			Dim _ENCList As List(Of WeakReference) = Form21.__ENCList
			SyncLock _ENCList
				Form21.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.currentForm = Nothing
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000347 RID: 839
		' (get) Token: 0x060009FB RID: 2555 RVA: 0x03DBCF40 File Offset: 0x03DBB340
		' (set) Token: 0x060009FC RID: 2556 RVA: 0x03DBCF58 File Offset: 0x03DBB358
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

		' Token: 0x17000348 RID: 840
		' (get) Token: 0x060009FD RID: 2557 RVA: 0x03DBCFB8 File Offset: 0x03DBB3B8
		' (set) Token: 0x060009FE RID: 2558 RVA: 0x03DBCFD0 File Offset: 0x03DBB3D0
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

		' Token: 0x17000349 RID: 841
		' (get) Token: 0x060009FF RID: 2559 RVA: 0x03DBD030 File Offset: 0x03DBB430
		' (set) Token: 0x06000A00 RID: 2560 RVA: 0x03DBD048 File Offset: 0x03DBB448
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

		' Token: 0x1700034A RID: 842
		' (get) Token: 0x06000A01 RID: 2561 RVA: 0x03DBD0A8 File Offset: 0x03DBB4A8
		' (set) Token: 0x06000A02 RID: 2562 RVA: 0x03DBD0C0 File Offset: 0x03DBB4C0
		Friend Overridable Property Button4 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button4_Click
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

		' Token: 0x1700034B RID: 843
		' (get) Token: 0x06000A03 RID: 2563 RVA: 0x03DBD120 File Offset: 0x03DBB520
		' (set) Token: 0x06000A04 RID: 2564 RVA: 0x03DBD138 File Offset: 0x03DBB538
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

		' Token: 0x1700034C RID: 844
		' (get) Token: 0x06000A05 RID: 2565 RVA: 0x03DBD144 File Offset: 0x03DBB544
		' (set) Token: 0x06000A06 RID: 2566 RVA: 0x03DBD15C File Offset: 0x03DBB55C
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

		' Token: 0x1700034D RID: 845
		' (get) Token: 0x06000A07 RID: 2567 RVA: 0x03DBD1BC File Offset: 0x03DBB5BC
		' (set) Token: 0x06000A08 RID: 2568 RVA: 0x03DBD1D4 File Offset: 0x03DBB5D4
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

		' Token: 0x1700034E RID: 846
		' (get) Token: 0x06000A09 RID: 2569 RVA: 0x03DBD1E0 File Offset: 0x03DBB5E0
		' (set) Token: 0x06000A0A RID: 2570 RVA: 0x03DBD1F8 File Offset: 0x03DBB5F8
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

		' Token: 0x1700034F RID: 847
		' (get) Token: 0x06000A0B RID: 2571 RVA: 0x03DBD204 File Offset: 0x03DBB604
		' (set) Token: 0x06000A0C RID: 2572 RVA: 0x03DBD21C File Offset: 0x03DBB61C
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

		' Token: 0x17000350 RID: 848
		' (get) Token: 0x06000A0D RID: 2573 RVA: 0x03DBD228 File Offset: 0x03DBB628
		' (set) Token: 0x06000A0E RID: 2574 RVA: 0x03DBD240 File Offset: 0x03DBB640
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

		' Token: 0x17000351 RID: 849
		' (get) Token: 0x06000A0F RID: 2575 RVA: 0x03DBD24C File Offset: 0x03DBB64C
		' (set) Token: 0x06000A10 RID: 2576 RVA: 0x03DBD264 File Offset: 0x03DBB664
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

		' Token: 0x17000352 RID: 850
		' (get) Token: 0x06000A11 RID: 2577 RVA: 0x03DBD270 File Offset: 0x03DBB670
		' (set) Token: 0x06000A12 RID: 2578 RVA: 0x03DBD288 File Offset: 0x03DBB688
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

		' Token: 0x17000353 RID: 851
		' (get) Token: 0x06000A13 RID: 2579 RVA: 0x03DBD294 File Offset: 0x03DBB694
		' (set) Token: 0x06000A14 RID: 2580 RVA: 0x03DBD2AC File Offset: 0x03DBB6AC
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

		' Token: 0x17000354 RID: 852
		' (get) Token: 0x06000A15 RID: 2581 RVA: 0x03DBD2B8 File Offset: 0x03DBB6B8
		' (set) Token: 0x06000A16 RID: 2582 RVA: 0x03DBD2D0 File Offset: 0x03DBB6D0
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

		' Token: 0x17000355 RID: 853
		' (get) Token: 0x06000A17 RID: 2583 RVA: 0x03DBD2DC File Offset: 0x03DBB6DC
		' (set) Token: 0x06000A18 RID: 2584 RVA: 0x03DBD2F4 File Offset: 0x03DBB6F4
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

		' Token: 0x17000356 RID: 854
		' (get) Token: 0x06000A19 RID: 2585 RVA: 0x03DBD300 File Offset: 0x03DBB700
		' (set) Token: 0x06000A1A RID: 2586 RVA: 0x03DBD318 File Offset: 0x03DBB718
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

		' Token: 0x17000357 RID: 855
		' (get) Token: 0x06000A1B RID: 2587 RVA: 0x03DBD324 File Offset: 0x03DBB724
		' (set) Token: 0x06000A1C RID: 2588 RVA: 0x03DBD33C File Offset: 0x03DBB73C
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

		' Token: 0x17000358 RID: 856
		' (get) Token: 0x06000A1D RID: 2589 RVA: 0x03DBD348 File Offset: 0x03DBB748
		' (set) Token: 0x06000A1E RID: 2590 RVA: 0x03DBD360 File Offset: 0x03DBB760
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

		' Token: 0x17000359 RID: 857
		' (get) Token: 0x06000A1F RID: 2591 RVA: 0x03DBD36C File Offset: 0x03DBB76C
		' (set) Token: 0x06000A20 RID: 2592 RVA: 0x03DBD384 File Offset: 0x03DBB784
		Friend Overridable Property TrackBar1 As TrackBar
			<DebuggerNonUserCode()>
			Get
				Return Me._TrackBar1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TrackBar)
				Me._TrackBar1 = value
			End Set
		End Property

		' Token: 0x1700035A RID: 858
		' (get) Token: 0x06000A21 RID: 2593 RVA: 0x03DBD390 File Offset: 0x03DBB790
		' (set) Token: 0x06000A22 RID: 2594 RVA: 0x03DBD3A8 File Offset: 0x03DBB7A8
		Friend Overridable Property Button11 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button11_Click
				Dim flag As Boolean = Me._Button11 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button11.Click, eventHandler
				End If
				Me._Button11 = value
				flag = Me._Button11 IsNot Nothing
				If flag Then
					AddHandler Me._Button11.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700035B RID: 859
		' (get) Token: 0x06000A23 RID: 2595 RVA: 0x03DBD408 File Offset: 0x03DBB808
		' (set) Token: 0x06000A24 RID: 2596 RVA: 0x03DBD420 File Offset: 0x03DBB820
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

		' Token: 0x1700035C RID: 860
		' (get) Token: 0x06000A25 RID: 2597 RVA: 0x03DBD480 File Offset: 0x03DBB880
		' (set) Token: 0x06000A26 RID: 2598 RVA: 0x03DBD498 File Offset: 0x03DBB898
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

		' Token: 0x1700035D RID: 861
		' (get) Token: 0x06000A27 RID: 2599 RVA: 0x03DBD4F8 File Offset: 0x03DBB8F8
		' (set) Token: 0x06000A28 RID: 2600 RVA: 0x03DBD510 File Offset: 0x03DBB910
		Friend Overridable Property Button10 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button10_Click
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

		' Token: 0x1700035E RID: 862
		' (get) Token: 0x06000A29 RID: 2601 RVA: 0x03DBD570 File Offset: 0x03DBB970
		' (set) Token: 0x06000A2A RID: 2602 RVA: 0x03DBD588 File Offset: 0x03DBB988
		Friend Overridable Property Button9 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button9 = value
			End Set
		End Property

		' Token: 0x1700035F RID: 863
		' (get) Token: 0x06000A2B RID: 2603 RVA: 0x03DBD594 File Offset: 0x03DBB994
		' (set) Token: 0x06000A2C RID: 2604 RVA: 0x03DBD5AC File Offset: 0x03DBB9AC
		Friend Overridable Property Button8 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button8_Click
				Dim flag As Boolean = Me._Button8 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button8.Click, eventHandler
				End If
				Me._Button8 = value
				flag = Me._Button8 IsNot Nothing
				If flag Then
					AddHandler Me._Button8.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000360 RID: 864
		' (get) Token: 0x06000A2D RID: 2605 RVA: 0x03DBD60C File Offset: 0x03DBBA0C
		' (set) Token: 0x06000A2E RID: 2606 RVA: 0x03DBD624 File Offset: 0x03DBBA24
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

		' Token: 0x17000361 RID: 865
		' (get) Token: 0x06000A2F RID: 2607 RVA: 0x03DBD630 File Offset: 0x03DBBA30
		' (set) Token: 0x06000A30 RID: 2608 RVA: 0x03DBD648 File Offset: 0x03DBBA48
		Friend Overridable Property Button13 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button13
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button13_Click
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

		' Token: 0x17000362 RID: 866
		' (get) Token: 0x06000A31 RID: 2609 RVA: 0x03DBD6A8 File Offset: 0x03DBBAA8
		' (set) Token: 0x06000A32 RID: 2610 RVA: 0x03DBD6C0 File Offset: 0x03DBBAC0
		Friend Overridable Property Button15 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button15
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button15 = value
			End Set
		End Property

		' Token: 0x17000363 RID: 867
		' (get) Token: 0x06000A33 RID: 2611 RVA: 0x03DBD6CC File Offset: 0x03DBBACC
		' (set) Token: 0x06000A34 RID: 2612 RVA: 0x03DBD6E4 File Offset: 0x03DBBAE4
		Friend Overridable Property Button16 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button16
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button16_Click
				Dim flag As Boolean = Me._Button16 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button16.Click, eventHandler
				End If
				Me._Button16 = value
				flag = Me._Button16 IsNot Nothing
				If flag Then
					AddHandler Me._Button16.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000364 RID: 868
		' (get) Token: 0x06000A35 RID: 2613 RVA: 0x03DBD744 File Offset: 0x03DBBB44
		' (set) Token: 0x06000A36 RID: 2614 RVA: 0x03DBD75C File Offset: 0x03DBBB5C
		Friend Overridable Property Button17 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button17
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button17_Click
				Dim eventHandler2 As EventHandler = AddressOf Me.Button17_MouseLeave
				Dim eventHandler3 As EventHandler = AddressOf Me.Button17_MouseEnter
				Dim flag As Boolean = Me._Button17 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button17.Click, eventHandler
					RemoveHandler Me._Button17.MouseLeave, eventHandler2
					RemoveHandler Me._Button17.MouseEnter, eventHandler3
				End If
				Me._Button17 = value
				flag = Me._Button17 IsNot Nothing
				If flag Then
					AddHandler Me._Button17.Click, eventHandler
					AddHandler Me._Button17.MouseLeave, eventHandler2
					AddHandler Me._Button17.MouseEnter, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x17000365 RID: 869
		' (get) Token: 0x06000A37 RID: 2615 RVA: 0x03DBD80C File Offset: 0x03DBBC0C
		' (set) Token: 0x06000A38 RID: 2616 RVA: 0x03DBD824 File Offset: 0x03DBBC24
		Friend Overridable Property ggg As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._ggg
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._ggg = value
			End Set
		End Property

		' Token: 0x17000366 RID: 870
		' (get) Token: 0x06000A39 RID: 2617 RVA: 0x03DBD830 File Offset: 0x03DBBC30
		' (set) Token: 0x06000A3A RID: 2618 RVA: 0x03DBD848 File Offset: 0x03DBBC48
		Friend Overridable Property Label15 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label15
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label15 = value
			End Set
		End Property

		' Token: 0x17000367 RID: 871
		' (get) Token: 0x06000A3B RID: 2619 RVA: 0x03DBD854 File Offset: 0x03DBBC54
		' (set) Token: 0x06000A3C RID: 2620 RVA: 0x03DBD86C File Offset: 0x03DBBC6C
		Friend Overridable Property Button21 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button21
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button21_Click
				Dim flag As Boolean = Me._Button21 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button21.Click, eventHandler
				End If
				Me._Button21 = value
				flag = Me._Button21 IsNot Nothing
				If flag Then
					AddHandler Me._Button21.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000368 RID: 872
		' (get) Token: 0x06000A3D RID: 2621 RVA: 0x03DBD8CC File Offset: 0x03DBBCCC
		' (set) Token: 0x06000A3E RID: 2622 RVA: 0x03DBD8E4 File Offset: 0x03DBBCE4
		Friend Overridable Property Button22 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button22
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button22_Click
				Dim flag As Boolean = Me._Button22 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button22.Click, eventHandler
				End If
				Me._Button22 = value
				flag = Me._Button22 IsNot Nothing
				If flag Then
					AddHandler Me._Button22.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000369 RID: 873
		' (get) Token: 0x06000A3F RID: 2623 RVA: 0x03DBD944 File Offset: 0x03DBBD44
		' (set) Token: 0x06000A40 RID: 2624 RVA: 0x03DBD95C File Offset: 0x03DBBD5C
		Friend Overridable Property Label16 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label16
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label16 = value
			End Set
		End Property

		' Token: 0x1700036A RID: 874
		' (get) Token: 0x06000A41 RID: 2625 RVA: 0x03DBD968 File Offset: 0x03DBBD68
		' (set) Token: 0x06000A42 RID: 2626 RVA: 0x03DBD980 File Offset: 0x03DBBD80
		Friend Overridable Property TextBox2 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox2 = value
			End Set
		End Property

		' Token: 0x1700036B RID: 875
		' (get) Token: 0x06000A43 RID: 2627 RVA: 0x03DBD98C File Offset: 0x03DBBD8C
		' (set) Token: 0x06000A44 RID: 2628 RVA: 0x03DBD9A4 File Offset: 0x03DBBDA4
		Friend Overridable Property Button23 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button23
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button23_Click
				Dim flag As Boolean = Me._Button23 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button23.Click, eventHandler
				End If
				Me._Button23 = value
				flag = Me._Button23 IsNot Nothing
				If flag Then
					AddHandler Me._Button23.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700036C RID: 876
		' (get) Token: 0x06000A45 RID: 2629 RVA: 0x03DBDA04 File Offset: 0x03DBBE04
		' (set) Token: 0x06000A46 RID: 2630 RVA: 0x03DBDA1C File Offset: 0x03DBBE1C
		Friend Overridable Property Button12 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button12_Click_2
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

		' Token: 0x1700036D RID: 877
		' (get) Token: 0x06000A47 RID: 2631 RVA: 0x03DBDA7C File Offset: 0x03DBBE7C
		' (set) Token: 0x06000A48 RID: 2632 RVA: 0x03DBDA94 File Offset: 0x03DBBE94
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

		' Token: 0x1700036E RID: 878
		' (get) Token: 0x06000A49 RID: 2633 RVA: 0x03DBDAA0 File Offset: 0x03DBBEA0
		' (set) Token: 0x06000A4A RID: 2634 RVA: 0x03DBDAB8 File Offset: 0x03DBBEB8
		Friend Overridable Property Button14 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button14
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button14_Click_2
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

		' Token: 0x1700036F RID: 879
		' (get) Token: 0x06000A4B RID: 2635 RVA: 0x03DBDB18 File Offset: 0x03DBBF18
		' (set) Token: 0x06000A4C RID: 2636 RVA: 0x03DBDB30 File Offset: 0x03DBBF30
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

		' Token: 0x17000370 RID: 880
		' (get) Token: 0x06000A4D RID: 2637 RVA: 0x03DBDB3C File Offset: 0x03DBBF3C
		' (set) Token: 0x06000A4E RID: 2638 RVA: 0x03DBDB54 File Offset: 0x03DBBF54
		Friend Overridable Property Label13 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label13
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label13 = value
			End Set
		End Property

		' Token: 0x17000371 RID: 881
		' (get) Token: 0x06000A4F RID: 2639 RVA: 0x03DBDB60 File Offset: 0x03DBBF60
		' (set) Token: 0x06000A50 RID: 2640 RVA: 0x03DBDB78 File Offset: 0x03DBBF78
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

		' Token: 0x17000372 RID: 882
		' (get) Token: 0x06000A51 RID: 2641 RVA: 0x03DBDBD8 File Offset: 0x03DBBFD8
		' (set) Token: 0x06000A52 RID: 2642 RVA: 0x03DBDBF0 File Offset: 0x03DBBFF0
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

		' Token: 0x17000373 RID: 883
		' (get) Token: 0x06000A53 RID: 2643 RVA: 0x03DBDC50 File Offset: 0x03DBC050
		' (set) Token: 0x06000A54 RID: 2644 RVA: 0x03DBDC68 File Offset: 0x03DBC068
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

		' Token: 0x17000374 RID: 884
		' (get) Token: 0x06000A55 RID: 2645 RVA: 0x03DBDC74 File Offset: 0x03DBC074
		' (set) Token: 0x06000A56 RID: 2646 RVA: 0x03DBDC8C File Offset: 0x03DBC08C
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

		' Token: 0x17000375 RID: 885
		' (get) Token: 0x06000A57 RID: 2647 RVA: 0x03DBDC98 File Offset: 0x03DBC098
		' (set) Token: 0x06000A58 RID: 2648 RVA: 0x03DBDCB0 File Offset: 0x03DBC0B0
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

		' Token: 0x17000376 RID: 886
		' (get) Token: 0x06000A59 RID: 2649 RVA: 0x03DBDCBC File Offset: 0x03DBC0BC
		' (set) Token: 0x06000A5A RID: 2650 RVA: 0x03DBDCD4 File Offset: 0x03DBC0D4
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

		' Token: 0x17000377 RID: 887
		' (get) Token: 0x06000A5B RID: 2651 RVA: 0x03DBDCE0 File Offset: 0x03DBC0E0
		' (set) Token: 0x06000A5C RID: 2652 RVA: 0x03DBDCF8 File Offset: 0x03DBC0F8
		Friend Overridable Property CVCforms As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._CVCforms
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._CVCforms = value
			End Set
		End Property

		' Token: 0x17000378 RID: 888
		' (get) Token: 0x06000A5D RID: 2653 RVA: 0x03DBDD04 File Offset: 0x03DBC104
		' (set) Token: 0x06000A5E RID: 2654 RVA: 0x03DBDD1C File Offset: 0x03DBC11C
		Friend Overridable Property Button19 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button19
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button19_Click_1
				Dim flag As Boolean = Me._Button19 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button19.Click, eventHandler
				End If
				Me._Button19 = value
				flag = Me._Button19 IsNot Nothing
				If flag Then
					AddHandler Me._Button19.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000379 RID: 889
		' (get) Token: 0x06000A5F RID: 2655 RVA: 0x03DBDD7C File Offset: 0x03DBC17C
		' (set) Token: 0x06000A60 RID: 2656 RVA: 0x03DBDD94 File Offset: 0x03DBC194
		Friend Overridable Property Panel5 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.Panel5_MouseMove
				Dim mouseEventHandler2 As MouseEventHandler = AddressOf Me.Panel5_MouseDown
				Dim flag As Boolean = Me._Panel5 IsNot Nothing
				If flag Then
					RemoveHandler Me._Panel5.MouseMove, mouseEventHandler
					RemoveHandler Me._Panel5.MouseDown, mouseEventHandler2
				End If
				Me._Panel5 = value
				flag = Me._Panel5 IsNot Nothing
				If flag Then
					AddHandler Me._Panel5.MouseMove, mouseEventHandler
					AddHandler Me._Panel5.MouseDown, mouseEventHandler2
				End If
			End Set
		End Property

		' Token: 0x1700037A RID: 890
		' (get) Token: 0x06000A61 RID: 2657 RVA: 0x03DBDE1C File Offset: 0x03DBC21C
		' (set) Token: 0x06000A62 RID: 2658 RVA: 0x03DBDE34 File Offset: 0x03DBC234
		Friend Overridable Property Button20 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button20
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button20_Click_1
				Dim flag As Boolean = Me._Button20 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button20.Click, eventHandler
				End If
				Me._Button20 = value
				flag = Me._Button20 IsNot Nothing
				If flag Then
					AddHandler Me._Button20.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700037B RID: 891
		' (get) Token: 0x06000A63 RID: 2659 RVA: 0x03DBDE94 File Offset: 0x03DBC294
		' (set) Token: 0x06000A64 RID: 2660 RVA: 0x03DBDEAC File Offset: 0x03DBC2AC
		Friend Overridable Property Button25 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button25
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button25_Click
				Dim flag As Boolean = Me._Button25 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button25.Click, eventHandler
				End If
				Me._Button25 = value
				flag = Me._Button25 IsNot Nothing
				If flag Then
					AddHandler Me._Button25.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700037C RID: 892
		' (get) Token: 0x06000A65 RID: 2661 RVA: 0x03DBDF0C File Offset: 0x03DBC30C
		' (set) Token: 0x06000A66 RID: 2662 RVA: 0x03DBDF24 File Offset: 0x03DBC324
		Friend Overridable Property Button24 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button24
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button24_Click
				Dim flag As Boolean = Me._Button24 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button24.Click, eventHandler
				End If
				Me._Button24 = value
				flag = Me._Button24 IsNot Nothing
				If flag Then
					AddHandler Me._Button24.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700037D RID: 893
		' (get) Token: 0x06000A67 RID: 2663 RVA: 0x03DBDF84 File Offset: 0x03DBC384
		' (set) Token: 0x06000A68 RID: 2664 RVA: 0x03DBDF9C File Offset: 0x03DBC39C
		Friend Overridable Property Button26 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button26
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button26_Click
				Dim flag As Boolean = Me._Button26 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button26.Click, eventHandler
				End If
				Me._Button26 = value
				flag = Me._Button26 IsNot Nothing
				If flag Then
					AddHandler Me._Button26.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700037E RID: 894
		' (get) Token: 0x06000A69 RID: 2665 RVA: 0x03DBDFFC File Offset: 0x03DBC3FC
		' (set) Token: 0x06000A6A RID: 2666 RVA: 0x03DBE014 File Offset: 0x03DBC414
		Friend Overridable Property Button27 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button27
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button27_Click
				Dim flag As Boolean = Me._Button27 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button27.Click, eventHandler
				End If
				Me._Button27 = value
				flag = Me._Button27 IsNot Nothing
				If flag Then
					AddHandler Me._Button27.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700037F RID: 895
		' (get) Token: 0x06000A6B RID: 2667 RVA: 0x03DBE074 File Offset: 0x03DBC474
		' (set) Token: 0x06000A6C RID: 2668 RVA: 0x03DBE08C File Offset: 0x03DBC48C
		Friend Overridable Property Button28 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button28
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button28_Click
				Dim flag As Boolean = Me._Button28 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button28.Click, eventHandler
				End If
				Me._Button28 = value
				flag = Me._Button28 IsNot Nothing
				If flag Then
					AddHandler Me._Button28.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000380 RID: 896
		' (get) Token: 0x06000A6D RID: 2669 RVA: 0x03DBE0EC File Offset: 0x03DBC4EC
		' (set) Token: 0x06000A6E RID: 2670 RVA: 0x03DBE104 File Offset: 0x03DBC504
		Friend Overridable Property ONWindow As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._ONWindow
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._ONWindow = value
			End Set
		End Property

		' Token: 0x17000381 RID: 897
		' (get) Token: 0x06000A6F RID: 2671 RVA: 0x03DBE110 File Offset: 0x03DBC510
		' (set) Token: 0x06000A70 RID: 2672 RVA: 0x03DBE128 File Offset: 0x03DBC528
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

		' Token: 0x17000382 RID: 898
		' (get) Token: 0x06000A71 RID: 2673 RVA: 0x03DBE134 File Offset: 0x03DBC534
		' (set) Token: 0x06000A72 RID: 2674 RVA: 0x03DBE14C File Offset: 0x03DBC54C
		Friend Overridable Property Label14 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label14
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim eventHandler As EventHandler = AddressOf Me.Label14_Click
				Dim flag As Boolean = Me._Label14 IsNot Nothing
				If flag Then
					RemoveHandler Me._Label14.Click, eventHandler
				End If
				Me._Label14 = value
				flag = Me._Label14 IsNot Nothing
				If flag Then
					AddHandler Me._Label14.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x06000A73 RID: 2675 RVA: 0x03DBE1AC File Offset: 0x03DBC5AC
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form20.Show()
			Me.Panel1.Visible = False
			Me.Panel2.Visible = False
			Me.ggg.Visible = False
			Me.Panel3.Visible = False
		End Sub

		' Token: 0x06000A74 RID: 2676 RVA: 0x03DBE200 File Offset: 0x03DBC600
		Private Sub Button2_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000A75 RID: 2677 RVA: 0x03DBE204 File Offset: 0x03DBC604
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			Me.Panel1.Visible = False
			Me.Panel2.Visible = False
			Me.ggg.Visible = False
		End Sub

		' Token: 0x06000A76 RID: 2678 RVA: 0x03DBE230 File Offset: 0x03DBC630
		Private Sub Button7_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox12.Show()
		End Sub

		' Token: 0x06000A77 RID: 2679 RVA: 0x03DBE244 File Offset: 0x03DBC644
		Private Sub Button6_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox11.Show()
		End Sub

		' Token: 0x06000A78 RID: 2680 RVA: 0x03DBE258 File Offset: 0x03DBC658
		Private Sub Button10_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form2.Button2.Enabled = False
		End Sub

		' Token: 0x06000A79 RID: 2681 RVA: 0x03DBE274 File Offset: 0x03DBC674
		Private Sub Button8_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form2.Close()
			MyProject.Forms.Form3.Close()
			MyProject.Forms.Form4.Close()
			MyProject.Forms.Form5.Close()
			MyProject.Forms.Form6.Close()
			MyProject.Forms.Form7.Close()
			MyProject.Forms.Explorer1.Close()
			MyProject.Forms.Explorer2.Close()
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
			MyProject.Forms.Errorbox1.Close()
			MyProject.Forms.AboutBox1.Close()
			MyProject.Forms.AboutBox3.Close()
			MyProject.Forms.AboutBox5.Close()
			MyProject.Forms.AboutBox7.Close()
			MyProject.Forms.AboutBox8.Close()
			MyProject.Forms.Form1.Show()
			MyProject.Forms.Form1.Panel2.Visible = True
			MyProject.Forms.Form1.PictureBox1.Visible = False
			MyProject.Forms.Form1.PictureBox2.Visible = False
			MyProject.Forms.Form1.PictureBox3.Visible = False
			MyProject.Forms.Form1.PictureBox4.Visible = False
			MyProject.Forms.Form1.PictureBox5.Visible = False
			MyProject.Forms.Form1.PictureBox6.Visible = False
			MyProject.Forms.Form1.PictureBox7.Visible = False
			MyProject.Forms.Form1.PictureBox8.Visible = False
			MyProject.Forms.Form1.PictureBox9.Visible = False
			MyProject.Forms.Form1.Button1.Visible = False
			MyProject.Forms.Form1.Button2.Visible = False
			MyProject.Forms.Form1.Button3.Visible = False
			MyProject.Forms.Form1.Button4.Visible = False
			MyProject.Forms.Form1.Button7.Visible = False
			MyProject.Forms.Form1.Button10.Visible = False
			MyProject.Forms.Form1.Panel2.Visible = True
			MyProject.Forms.Form1.Label1.Visible = False
			MyProject.Forms.Form1.Label2.Visible = False
			MyProject.Forms.Form1.Text = "Stopped Desktroy Error"
			Me.Close()
		End Sub

		' Token: 0x06000A7A RID: 2682 RVA: 0x03DBE5F4 File Offset: 0x03DBC9F4
		Private Sub Button11_Click(sender As Object, e As EventArgs)
			Me.Panel2.Visible = False
		End Sub

		' Token: 0x06000A7B RID: 2683 RVA: 0x03DBE608 File Offset: 0x03DBCA08
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			Me.Panel1.Visible = False
			Me.Panel2.Visible = True
			Me.ggg.Visible = False
			Me.Panel3.Visible = False
		End Sub

		' Token: 0x06000A7C RID: 2684 RVA: 0x03DBE640 File Offset: 0x03DBCA40
		Private Sub Button12_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form10.Show()
		End Sub

		' Token: 0x06000A7D RID: 2685 RVA: 0x03DBE654 File Offset: 0x03DBCA54
		Private Sub Button14_Click(sender As Object, e As EventArgs)
			Me.Panel2.Visible = False
		End Sub

		' Token: 0x06000A7E RID: 2686 RVA: 0x03DBE668 File Offset: 0x03DBCA68
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form43.Show()
		End Sub

		' Token: 0x06000A7F RID: 2687 RVA: 0x03DBE67C File Offset: 0x03DBCA7C
		Private Sub Button13_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form22.Show()
		End Sub

		' Token: 0x06000A80 RID: 2688 RVA: 0x03DBE690 File Offset: 0x03DBCA90
		Private Sub Button16_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.Button15.Visible = True
		End Sub

		' Token: 0x06000A81 RID: 2689 RVA: 0x03DBE6AC File Offset: 0x03DBCAAC
		Private Sub Button19_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000A82 RID: 2690 RVA: 0x03DBE6B0 File Offset: 0x03DBCAB0
		Private Sub Button20_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000A83 RID: 2691 RVA: 0x03DBE6B4 File Offset: 0x03DBCAB4
		Private Sub Button14_Click_1(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000A84 RID: 2692 RVA: 0x03DBE6B8 File Offset: 0x03DBCAB8
		Private Sub Button18_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000A85 RID: 2693 RVA: 0x03DBE6BC File Offset: 0x03DBCABC
		Private Sub Button12_Click_1(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000A86 RID: 2694 RVA: 0x03DBE6C0 File Offset: 0x03DBCAC0
		Private Sub Button17_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000A87 RID: 2695 RVA: 0x03DBE6C4 File Offset: 0x03DBCAC4
		Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x06000A88 RID: 2696 RVA: 0x03DBE6C8 File Offset: 0x03DBCAC8
		Private Sub Button23_Click(sender As Object, e As EventArgs)
			Me.Panel1.Visible = False
			Me.Panel2.Visible = False
			Me.ggg.Visible = False
			Me.Button21.Enabled = False
			Me.Label15.Visible = False
			Me.Panel3.Visible = False
		End Sub

		' Token: 0x06000A89 RID: 2697 RVA: 0x03DBE728 File Offset: 0x03DBCB28
		Private Sub Button22_Click(sender As Object, e As EventArgs)
			Me.Button21.Enabled = True
		End Sub

		' Token: 0x06000A8A RID: 2698 RVA: 0x03DBE73C File Offset: 0x03DBCB3C
		Private Sub Button21_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not MyProject.Forms.AboutBox1.OKButton.Visible
			If flag Then
				MyProject.Forms.Form27.Close()
				Me.Button21.Enabled = False
				flag = Operators.CompareString(Me.TextBox2.Text, "Silan", False) = 0
				If flag Then
					MyProject.Forms.AboutBox18.Show()
				End If
				flag = Operators.CompareString(Me.TextBox2.Text, "silan", False) = 0
				If flag Then
					MyProject.Forms.AboutBox18.Show()
				End If
				flag = Operators.CompareString(Me.TextBox2.Text, "Display", False) = 0
				If flag Then
					MyProject.Forms.Form6.Show()
				End If
				flag = Operators.CompareString(Me.TextBox2.Text, "display", False) = 0
				If flag Then
					MyProject.Forms.Form6.Show()
				End If
				flag = Operators.CompareString(Me.TextBox2.Text, "Programs", False) = 0
				If flag Then
					MyProject.Forms.Form7.Show()
				End If
				flag = Operators.CompareString(Me.TextBox2.Text, "programs", False) = 0
				If flag Then
					MyProject.Forms.Form7.Show()
				End If
				flag = Operators.CompareString(Me.TextBox2.Text, "User", False) = 0
				If flag Then
					MyProject.Forms.Form10.Show()
				End If
				flag = Operators.CompareString(Me.TextBox2.Text, "user", False) = 0
				If flag Then
					MyProject.Forms.Form10.Show()
				End If
				flag = Operators.CompareString(Me.TextBox2.Text, "Desktroy", False) = 0
				If flag Then
					MyProject.Forms.Form12.Show()
				End If
				flag = Operators.CompareString(Me.TextBox2.Text, "desktroy", False) = 0
				If flag Then
					MyProject.Forms.Form12.Show()
				End If
				Me.Label12.Text = Me.TextBox2.Text
				MyProject.Forms.Form2.Label1.Text = Me.TextBox2.Text
				MyProject.Forms.Form27.Show()
				flag = Operators.CompareString(Me.TextBox2.Text, "???", False) = 0
				If flag Then
					MyProject.Forms.Form27.Close()
				End If
				flag = Operators.CompareString(Me.TextBox2.Text, "???", False) = 0
				If flag Then
					MyProject.Forms.Errorbox1.Show()
					MyProject.Forms.Errorbox1.al.Text = "Can't Display User Name!"
					MyProject.Forms.Form2.Label1.Text = "CV"
					Me.Label12.Text = "CV"
				End If
				flag = Operators.CompareString(MyProject.Forms.Form27.Label1.Text, "Display", False) = 0
				If flag Then
					MyProject.Forms.Form27.Label1.Text = "???"
					MyProject.Forms.Form2.Label1.Text = MyProject.Forms.Form27.Label1.Text
					Me.Label12.Text = MyProject.Forms.Form27.Label1.Text
				End If
				flag = Operators.CompareString(MyProject.Forms.Form27.Label1.Text, "display", False) = 0
				If flag Then
					MyProject.Forms.Form27.Label1.Text = "???"
					Me.Label12.Text = MyProject.Forms.Form27.Label1.Text
				End If
				flag = Operators.CompareString(MyProject.Forms.Form27.Label1.Text, "User", False) = 0
				If flag Then
					MyProject.Forms.Form27.Label1.Text = "???"
					MyProject.Forms.Form2.Label1.Text = MyProject.Forms.Form27.Label1.Text
					Me.Label12.Text = MyProject.Forms.Form27.Label1.Text
				End If
				flag = Operators.CompareString(MyProject.Forms.Form27.Label1.Text, "user", False) = 0
				If flag Then
					MyProject.Forms.Form27.Label1.Text = "???"
					MyProject.Forms.Form2.Label1.Text = MyProject.Forms.Form27.Label1.Text
					Me.Label12.Text = MyProject.Forms.Form27.Label1.Text
				End If
				flag = Operators.CompareString(MyProject.Forms.Form27.Label1.Text, "Programs", False) = 0
				If flag Then
					MyProject.Forms.Form27.Label1.Text = "???"
					MyProject.Forms.Form2.Label1.Text = MyProject.Forms.Form27.Label1.Text
					Me.Label12.Text = MyProject.Forms.Form27.Label1.Text
				End If
				flag = Operators.CompareString(MyProject.Forms.Form27.Label1.Text, "programs", False) = 0
				If flag Then
					MyProject.Forms.Form27.Label1.Text = "???"
					MyProject.Forms.Form2.Label1.Text = MyProject.Forms.Form27.Label1.Text
					Me.Label12.Text = MyProject.Forms.Form27.Label1.Text
				End If
				flag = Operators.CompareString(MyProject.Forms.Form27.Label1.Text, "Desktroy", False) = 0
				If flag Then
					MyProject.Forms.Form27.Label1.Text = "???"
					MyProject.Forms.Form2.Label1.Text = MyProject.Forms.Form27.Label1.Text
					Me.Label12.Text = MyProject.Forms.Form27.Label1.Text
				End If
				flag = Operators.CompareString(MyProject.Forms.Form27.Label1.Text, "desktroy", False) = 0
				If flag Then
					MyProject.Forms.Form27.Label1.Text = "???"
					MyProject.Forms.Form2.Label1.Text = MyProject.Forms.Form27.Label1.Text
					Me.Label12.Text = MyProject.Forms.Form27.Label1.Text
				End If
			Else
				Interaction.MsgBox("???", MsgBoxStyle.Critical, Nothing)
			End If
		End Sub

		' Token: 0x06000A8B RID: 2699 RVA: 0x03DBEE74 File Offset: 0x03DBD274
		Private Sub Button12_Click_2(sender As Object, e As EventArgs)
			Me.Panel1.Visible = False
			Me.Panel2.Visible = False
			Me.ggg.Visible = False
			Me.Panel3.Visible = False
		End Sub

		' Token: 0x06000A8C RID: 2700 RVA: 0x03DBEEAC File Offset: 0x03DBD2AC
		Private Sub Form21_Load(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not MyProject.Forms.Form27.Label1.Visible
			If flag Then
				Me.Label1.Text = "CV"
			End If
			flag = MyProject.Forms.Form27.Label1.Visible
			If flag Then
				Me.Label1.Text = Me.TextBox2.Text
			Else
				Me.Label1.Text = "CV"
			End If
			flag = Operators.CompareString(MyProject.Forms.Form27.Button1.Text, ":) :(", False) = 0
			If flag Then
				Me.Label12.Text = MyProject.Forms.Form27.Label1.Text
			End If
			Me.Panel5.BackColor = MyProject.Forms.Form_1pad.Panel5.BackColor
		End Sub

		' Token: 0x06000A8D RID: 2701 RVA: 0x03DBEF94 File Offset: 0x03DBD394
		Private Sub Button18_Click_1(sender As Object, e As EventArgs)
			Me.Panel1.Visible = False
			Me.Panel2.Visible = False
			Me.ggg.Visible = False
			Me.Panel3.Visible = False
		End Sub

		' Token: 0x06000A8E RID: 2702 RVA: 0x03DBEFCC File Offset: 0x03DBD3CC
		Private Sub Button14_Click_2(sender As Object, e As EventArgs)
			Dim flag As Boolean = Interaction.MsgBox("Go to New Theme App", MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.Yes
			If flag Then
				Me.Panel1.Visible = False
				Me.Panel2.Visible = False
				Me.ggg.Visible = False
				Me.Panel3.Visible = False
				MyProject.Forms.theme_window.Show()
			Else
				Me.Panel1.Visible = False
				Me.Panel2.Visible = False
				Me.ggg.Visible = False
				Me.Panel3.Visible = False
				MyProject.Forms.Form43.Show()
			End If
		End Sub

		' Token: 0x06000A8F RID: 2703 RVA: 0x03DBF07C File Offset: 0x03DBD47C
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Me.Panel5.BackColor = MyProject.Forms.Form_1pad.Panel1.BackColor
			Dim visible As Boolean = MyProject.Forms.Form1.Button1.Visible
			If visible Then
				Me.Button6.Enabled = True
				Me.Button7.Enabled = True
				Me.Button8.Enabled = True
				Me.Button9.Enabled = True
				Me.Button10.Enabled = True
				Me.Button16.Enabled = True
			Else
				Me.Button6.Enabled = False
				Me.Button7.Enabled = False
				Me.Button8.Enabled = False
				Me.Button9.Enabled = False
				Me.Button10.Enabled = False
				Me.Button16.Enabled = False
			End If
		End Sub

		' Token: 0x06000A90 RID: 2704 RVA: 0x03DBF164 File Offset: 0x03DBD564
		Private Sub Button17_MouseEnter(sender As Object, e As EventArgs)
			Me.Cursor = Cursors.No
		End Sub

		' Token: 0x06000A91 RID: 2705 RVA: 0x03DBF174 File Offset: 0x03DBD574
		Private Sub Button17_MouseLeave(sender As Object, e As EventArgs)
			Me.Cursor = Cursors.Arrow
		End Sub

		' Token: 0x06000A92 RID: 2706 RVA: 0x03DBF184 File Offset: 0x03DBD584
		Private Sub Button19_Click_1(sender As Object, e As EventArgs)
			easycode.openChildForm(New theme_window())
		End Sub

		' Token: 0x06000A93 RID: 2707 RVA: 0x03DBF194 File Offset: 0x03DBD594
		Public Sub openChildForm(childForm As Form)
			Dim flag As Boolean = Me.currentForm IsNot Nothing
			If flag Then
				Me.currentForm.Close()
			End If
			Me.currentForm = childForm
			childForm.TopLevel = False
			childForm.FormBorderStyle = FormBorderStyle.None
			childForm.Dock = DockStyle.Fill
			Me.CVCforms.Controls.Add(childForm)
			Me.CVCforms.Tag = childForm
			childForm.BringToFront()
			childForm.Show()
		End Sub

		' Token: 0x06000A94 RID: 2708 RVA: 0x03DBF20C File Offset: 0x03DBD60C
		Private Sub Button20_Click_1(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000A95 RID: 2709 RVA: 0x03DBF218 File Offset: 0x03DBD618
		Private Sub Panel5_MouseDown(sender As Object, e As MouseEventArgs)
			' The following expression was wrapped in a checked-expression
			Me.mouse_move = New Point(0 - e.X, 0 - e.Y)
		End Sub

		' Token: 0x06000A96 RID: 2710 RVA: 0x03DBF238 File Offset: 0x03DBD638
		Private Sub Panel5_MouseMove(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = e.Button = MouseButtons.Left
			If flag Then
				Dim mousePosition As Point = Control.MousePosition
				mousePosition.Offset(Me.mouse_move.X, Me.mouse_move.Y)
				Me.Location = mousePosition
			End If
		End Sub

		' Token: 0x06000A97 RID: 2711 RVA: 0x03DBF288 File Offset: 0x03DBD688
		Private Sub Button24_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.WindowState = FormWindowState.Normal
			If flag Then
				Me.WindowState = FormWindowState.Maximized
			Else
				Me.WindowState = FormWindowState.Normal
			End If
		End Sub

		' Token: 0x06000A98 RID: 2712 RVA: 0x03DBF2B8 File Offset: 0x03DBD6B8
		Private Sub Button25_Click(sender As Object, e As EventArgs)
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x06000A99 RID: 2713 RVA: 0x03DBF2C4 File Offset: 0x03DBD6C4
		Private Sub Button26_Click(sender As Object, e As EventArgs)
			Me.openChildForm(New Form20())
			MyProject.Forms.Form20.Panel2.Visible = False
			MyProject.Forms.Form20.Panel2.Visible = False
			MyProject.Forms.Form20.Panel2.Visible = False
			MyProject.Forms.Form20.Panel2.Visible = False
			MyProject.Forms.Form20.Panel2.Visible = False
			MyProject.Forms.Form20.Panel2.Visible = False
		End Sub

		' Token: 0x06000A9A RID: 2714 RVA: 0x03DBF364 File Offset: 0x03DBD764
		Private Sub Button27_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Interaction.MsgBox("In Window mode", MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.Yes
			If flag Then
				MyProject.Forms.Form22.Show()
				Me.ONWindow.Visible = True
			Else
				Me.openChildForm(New Form22())
				MyProject.Forms.Form22.Panel1.Visible = False
				MyProject.Forms.Form22.Panel1.Visible = False
				MyProject.Forms.Form22.Panel1.Visible = False
				MyProject.Forms.Form22.Panel1.Visible = False
				MyProject.Forms.Form22.Panel1.Visible = False
				MyProject.Forms.Form22.Panel1.Visible = False
			End If
		End Sub

		' Token: 0x06000A9B RID: 2715 RVA: 0x03DBF43C File Offset: 0x03DBD83C
		Private Sub Button28_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form53.Show()
		End Sub

		' Token: 0x06000A9C RID: 2716 RVA: 0x03DBF450 File Offset: 0x03DBD850
		Private Sub Label14_Click(sender As Object, e As EventArgs)
			Me.Panel6.Visible = False
		End Sub

		' Token: 0x040003A9 RID: 937
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040003AB RID: 939
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040003AC RID: 940
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x040003AD RID: 941
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x040003AE RID: 942
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x040003AF RID: 943
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x040003B0 RID: 944
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x040003B1 RID: 945
		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel

		' Token: 0x040003B2 RID: 946
		<AccessedThroughProperty("Label11")>
		Private _Label11 As Label

		' Token: 0x040003B3 RID: 947
		<AccessedThroughProperty("Label10")>
		Private _Label10 As Label

		' Token: 0x040003B4 RID: 948
		<AccessedThroughProperty("Label9")>
		Private _Label9 As Label

		' Token: 0x040003B5 RID: 949
		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		' Token: 0x040003B6 RID: 950
		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		' Token: 0x040003B7 RID: 951
		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		' Token: 0x040003B8 RID: 952
		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		' Token: 0x040003B9 RID: 953
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x040003BA RID: 954
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x040003BB RID: 955
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x040003BC RID: 956
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x040003BD RID: 957
		<AccessedThroughProperty("TrackBar1")>
		Private _TrackBar1 As TrackBar

		' Token: 0x040003BE RID: 958
		<AccessedThroughProperty("Button11")>
		Private _Button11 As Button

		' Token: 0x040003BF RID: 959
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x040003C0 RID: 960
		<AccessedThroughProperty("Button7")>
		Private _Button7 As Button

		' Token: 0x040003C1 RID: 961
		<AccessedThroughProperty("Button10")>
		Private _Button10 As Button

		' Token: 0x040003C2 RID: 962
		<AccessedThroughProperty("Button9")>
		Private _Button9 As Button

		' Token: 0x040003C3 RID: 963
		<AccessedThroughProperty("Button8")>
		Private _Button8 As Button

		' Token: 0x040003C4 RID: 964
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x040003C5 RID: 965
		<AccessedThroughProperty("Button13")>
		Private _Button13 As Button

		' Token: 0x040003C6 RID: 966
		<AccessedThroughProperty("Button15")>
		Private _Button15 As Button

		' Token: 0x040003C7 RID: 967
		<AccessedThroughProperty("Button16")>
		Private _Button16 As Button

		' Token: 0x040003C8 RID: 968
		<AccessedThroughProperty("Button17")>
		Private _Button17 As Button

		' Token: 0x040003C9 RID: 969
		<AccessedThroughProperty("ggg")>
		Private _ggg As Panel

		' Token: 0x040003CA RID: 970
		<AccessedThroughProperty("Label15")>
		Private _Label15 As Label

		' Token: 0x040003CB RID: 971
		<AccessedThroughProperty("Button21")>
		Private _Button21 As Button

		' Token: 0x040003CC RID: 972
		<AccessedThroughProperty("Button22")>
		Private _Button22 As Button

		' Token: 0x040003CD RID: 973
		<AccessedThroughProperty("Label16")>
		Private _Label16 As Label

		' Token: 0x040003CE RID: 974
		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		' Token: 0x040003CF RID: 975
		<AccessedThroughProperty("Button23")>
		Private _Button23 As Button

		' Token: 0x040003D0 RID: 976
		<AccessedThroughProperty("Button12")>
		Private _Button12 As Button

		' Token: 0x040003D1 RID: 977
		<AccessedThroughProperty("Label12")>
		Private _Label12 As Label

		' Token: 0x040003D2 RID: 978
		<AccessedThroughProperty("Button14")>
		Private _Button14 As Button

		' Token: 0x040003D3 RID: 979
		<AccessedThroughProperty("Panel3")>
		Private _Panel3 As Panel

		' Token: 0x040003D4 RID: 980
		<AccessedThroughProperty("Label13")>
		Private _Label13 As Label

		' Token: 0x040003D5 RID: 981
		<AccessedThroughProperty("Button18")>
		Private _Button18 As Button

		' Token: 0x040003D6 RID: 982
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x040003D7 RID: 983
		<AccessedThroughProperty("TabControl1")>
		Private _TabControl1 As TabControl

		' Token: 0x040003D8 RID: 984
		<AccessedThroughProperty("TabPage1")>
		Private _TabPage1 As TabPage

		' Token: 0x040003D9 RID: 985
		<AccessedThroughProperty("TabPage2")>
		Private _TabPage2 As TabPage

		' Token: 0x040003DA RID: 986
		<AccessedThroughProperty("Panel4")>
		Private _Panel4 As Panel

		' Token: 0x040003DB RID: 987
		<AccessedThroughProperty("CVCforms")>
		Private _CVCforms As Panel

		' Token: 0x040003DC RID: 988
		<AccessedThroughProperty("Button19")>
		Private _Button19 As Button

		' Token: 0x040003DD RID: 989
		<AccessedThroughProperty("Panel5")>
		Private _Panel5 As Panel

		' Token: 0x040003DE RID: 990
		<AccessedThroughProperty("Button20")>
		Private _Button20 As Button

		' Token: 0x040003DF RID: 991
		<AccessedThroughProperty("Button25")>
		Private _Button25 As Button

		' Token: 0x040003E0 RID: 992
		<AccessedThroughProperty("Button24")>
		Private _Button24 As Button

		' Token: 0x040003E1 RID: 993
		<AccessedThroughProperty("Button26")>
		Private _Button26 As Button

		' Token: 0x040003E2 RID: 994
		<AccessedThroughProperty("Button27")>
		Private _Button27 As Button

		' Token: 0x040003E3 RID: 995
		<AccessedThroughProperty("Button28")>
		Private _Button28 As Button

		' Token: 0x040003E4 RID: 996
		<AccessedThroughProperty("ONWindow")>
		Private _ONWindow As PictureBox

		' Token: 0x040003E5 RID: 997
		<AccessedThroughProperty("Panel6")>
		Private _Panel6 As Panel

		' Token: 0x040003E6 RID: 998
		<AccessedThroughProperty("Label14")>
		Private _Label14 As Label

		' Token: 0x040003E7 RID: 999
		Private mouse_move As Point

		' Token: 0x040003E8 RID: 1000
		Public currentForm As Form
	End Class
End Namespace
