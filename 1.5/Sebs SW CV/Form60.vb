Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x0200006D RID: 109
	<DesignerGenerated()>
	Public Partial Class Form60
		Inherits Form

		' Token: 0x060011BE RID: 4542 RVA: 0x03DEFA24 File Offset: 0x03DEDE24
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Form60.__ENCList
			SyncLock _ENCList
				Form60.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170005D7 RID: 1495
		' (get) Token: 0x060011C1 RID: 4545 RVA: 0x03DF12F4 File Offset: 0x03DEF6F4
		' (set) Token: 0x060011C2 RID: 4546 RVA: 0x03DF130C File Offset: 0x03DEF70C
		Friend Overridable Property Button1 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button23_Click
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

		' Token: 0x170005D8 RID: 1496
		' (get) Token: 0x060011C3 RID: 4547 RVA: 0x03DF136C File Offset: 0x03DEF76C
		' (set) Token: 0x060011C4 RID: 4548 RVA: 0x03DF1384 File Offset: 0x03DEF784
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

		' Token: 0x170005D9 RID: 1497
		' (get) Token: 0x060011C5 RID: 4549 RVA: 0x03DF1390 File Offset: 0x03DEF790
		' (set) Token: 0x060011C6 RID: 4550 RVA: 0x03DF13A8 File Offset: 0x03DEF7A8
		Friend Overridable Property Button2 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button23_Click
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

		' Token: 0x170005DA RID: 1498
		' (get) Token: 0x060011C7 RID: 4551 RVA: 0x03DF1408 File Offset: 0x03DEF808
		' (set) Token: 0x060011C8 RID: 4552 RVA: 0x03DF1420 File Offset: 0x03DEF820
		Friend Overridable Property Button3 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button23_Click
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

		' Token: 0x170005DB RID: 1499
		' (get) Token: 0x060011C9 RID: 4553 RVA: 0x03DF1480 File Offset: 0x03DEF880
		' (set) Token: 0x060011CA RID: 4554 RVA: 0x03DF1498 File Offset: 0x03DEF898
		Friend Overridable Property Button4 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button23_Click
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

		' Token: 0x170005DC RID: 1500
		' (get) Token: 0x060011CB RID: 4555 RVA: 0x03DF14F8 File Offset: 0x03DEF8F8
		' (set) Token: 0x060011CC RID: 4556 RVA: 0x03DF1510 File Offset: 0x03DEF910
		Friend Overridable Property Button5 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button23_Click
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

		' Token: 0x170005DD RID: 1501
		' (get) Token: 0x060011CD RID: 4557 RVA: 0x03DF1570 File Offset: 0x03DEF970
		' (set) Token: 0x060011CE RID: 4558 RVA: 0x03DF1588 File Offset: 0x03DEF988
		Friend Overridable Property Button6 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button23_Click
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

		' Token: 0x170005DE RID: 1502
		' (get) Token: 0x060011CF RID: 4559 RVA: 0x03DF15E8 File Offset: 0x03DEF9E8
		' (set) Token: 0x060011D0 RID: 4560 RVA: 0x03DF1600 File Offset: 0x03DEFA00
		Friend Overridable Property Button7 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button23_Click
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

		' Token: 0x170005DF RID: 1503
		' (get) Token: 0x060011D1 RID: 4561 RVA: 0x03DF1660 File Offset: 0x03DEFA60
		' (set) Token: 0x060011D2 RID: 4562 RVA: 0x03DF1678 File Offset: 0x03DEFA78
		Friend Overridable Property Button8 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button23_Click
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

		' Token: 0x170005E0 RID: 1504
		' (get) Token: 0x060011D3 RID: 4563 RVA: 0x03DF16D8 File Offset: 0x03DEFAD8
		' (set) Token: 0x060011D4 RID: 4564 RVA: 0x03DF16F0 File Offset: 0x03DEFAF0
		Friend Overridable Property Button9 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button23_Click
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

		' Token: 0x170005E1 RID: 1505
		' (get) Token: 0x060011D5 RID: 4565 RVA: 0x03DF1750 File Offset: 0x03DEFB50
		' (set) Token: 0x060011D6 RID: 4566 RVA: 0x03DF1768 File Offset: 0x03DEFB68
		Friend Overridable Property Button10 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button23_Click
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

		' Token: 0x170005E2 RID: 1506
		' (get) Token: 0x060011D7 RID: 4567 RVA: 0x03DF17C8 File Offset: 0x03DEFBC8
		' (set) Token: 0x060011D8 RID: 4568 RVA: 0x03DF17E0 File Offset: 0x03DEFBE0
		Friend Overridable Property Button12 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button23_Click
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

		' Token: 0x170005E3 RID: 1507
		' (get) Token: 0x060011D9 RID: 4569 RVA: 0x03DF1840 File Offset: 0x03DEFC40
		' (set) Token: 0x060011DA RID: 4570 RVA: 0x03DF1858 File Offset: 0x03DEFC58
		Friend Overridable Property Button13 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button13
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button23_Click
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

		' Token: 0x170005E4 RID: 1508
		' (get) Token: 0x060011DB RID: 4571 RVA: 0x03DF18B8 File Offset: 0x03DEFCB8
		' (set) Token: 0x060011DC RID: 4572 RVA: 0x03DF18D0 File Offset: 0x03DEFCD0
		Friend Overridable Property Button14 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button14
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button23_Click
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

		' Token: 0x170005E5 RID: 1509
		' (get) Token: 0x060011DD RID: 4573 RVA: 0x03DF1930 File Offset: 0x03DEFD30
		' (set) Token: 0x060011DE RID: 4574 RVA: 0x03DF1948 File Offset: 0x03DEFD48
		Friend Overridable Property Button15 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button15
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button23_Click
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

		' Token: 0x170005E6 RID: 1510
		' (get) Token: 0x060011DF RID: 4575 RVA: 0x03DF19A8 File Offset: 0x03DEFDA8
		' (set) Token: 0x060011E0 RID: 4576 RVA: 0x03DF19C0 File Offset: 0x03DEFDC0
		Friend Overridable Property Button16 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button16
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button23_Click
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

		' Token: 0x170005E7 RID: 1511
		' (get) Token: 0x060011E1 RID: 4577 RVA: 0x03DF1A20 File Offset: 0x03DEFE20
		' (set) Token: 0x060011E2 RID: 4578 RVA: 0x03DF1A38 File Offset: 0x03DEFE38
		Friend Overridable Property Button17 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button17
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button23_Click
				Dim flag As Boolean = Me._Button17 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button17.Click, eventHandler
				End If
				Me._Button17 = value
				flag = Me._Button17 IsNot Nothing
				If flag Then
					AddHandler Me._Button17.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170005E8 RID: 1512
		' (get) Token: 0x060011E3 RID: 4579 RVA: 0x03DF1A98 File Offset: 0x03DEFE98
		' (set) Token: 0x060011E4 RID: 4580 RVA: 0x03DF1AB0 File Offset: 0x03DEFEB0
		Friend Overridable Property Button18 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button18
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button23_Click
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

		' Token: 0x170005E9 RID: 1513
		' (get) Token: 0x060011E5 RID: 4581 RVA: 0x03DF1B10 File Offset: 0x03DEFF10
		' (set) Token: 0x060011E6 RID: 4582 RVA: 0x03DF1B28 File Offset: 0x03DEFF28
		Friend Overridable Property Button19 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button19
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button23_Click
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

		' Token: 0x170005EA RID: 1514
		' (get) Token: 0x060011E7 RID: 4583 RVA: 0x03DF1B88 File Offset: 0x03DEFF88
		' (set) Token: 0x060011E8 RID: 4584 RVA: 0x03DF1BA0 File Offset: 0x03DEFFA0
		Friend Overridable Property Button20 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button20
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button23_Click
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

		' Token: 0x170005EB RID: 1515
		' (get) Token: 0x060011E9 RID: 4585 RVA: 0x03DF1C00 File Offset: 0x03DF0000
		' (set) Token: 0x060011EA RID: 4586 RVA: 0x03DF1C18 File Offset: 0x03DF0018
		Friend Overridable Property Buttonback As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Buttonback
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.BC1_Click
				Dim flag As Boolean = Me._Buttonback IsNot Nothing
				If flag Then
					RemoveHandler Me._Buttonback.Click, eventHandler
				End If
				Me._Buttonback = value
				flag = Me._Buttonback IsNot Nothing
				If flag Then
					AddHandler Me._Buttonback.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170005EC RID: 1516
		' (get) Token: 0x060011EB RID: 4587 RVA: 0x03DF1C78 File Offset: 0x03DF0078
		' (set) Token: 0x060011EC RID: 4588 RVA: 0x03DF1C90 File Offset: 0x03DF0090
		Friend Overridable Property BE1 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._BE1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.BC1_Click
				Dim flag As Boolean = Me._BE1 IsNot Nothing
				If flag Then
					RemoveHandler Me._BE1.Click, eventHandler
				End If
				Me._BE1 = value
				flag = Me._BE1 IsNot Nothing
				If flag Then
					AddHandler Me._BE1.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170005ED RID: 1517
		' (get) Token: 0x060011ED RID: 4589 RVA: 0x03DF1CF0 File Offset: 0x03DF00F0
		' (set) Token: 0x060011EE RID: 4590 RVA: 0x03DF1D08 File Offset: 0x03DF0108
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

		' Token: 0x170005EE RID: 1518
		' (get) Token: 0x060011EF RID: 4591 RVA: 0x03DF1D68 File Offset: 0x03DF0168
		' (set) Token: 0x060011F0 RID: 4592 RVA: 0x03DF1D80 File Offset: 0x03DF0180
		Friend Overridable Property Button24 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button24
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button23_Click
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

		' Token: 0x170005EF RID: 1519
		' (get) Token: 0x060011F1 RID: 4593 RVA: 0x03DF1DE0 File Offset: 0x03DF01E0
		' (set) Token: 0x060011F2 RID: 4594 RVA: 0x03DF1DF8 File Offset: 0x03DF01F8
		Friend Overridable Property Button25 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button25
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button23_Click
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

		' Token: 0x170005F0 RID: 1520
		' (get) Token: 0x060011F3 RID: 4595 RVA: 0x03DF1E58 File Offset: 0x03DF0258
		' (set) Token: 0x060011F4 RID: 4596 RVA: 0x03DF1E70 File Offset: 0x03DF0270
		Friend Overridable Property Button26 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button26
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button23_Click
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

		' Token: 0x170005F1 RID: 1521
		' (get) Token: 0x060011F5 RID: 4597 RVA: 0x03DF1ED0 File Offset: 0x03DF02D0
		' (set) Token: 0x060011F6 RID: 4598 RVA: 0x03DF1EE8 File Offset: 0x03DF02E8
		Friend Overridable Property Button27 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button27
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button23_Click
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

		' Token: 0x170005F2 RID: 1522
		' (get) Token: 0x060011F7 RID: 4599 RVA: 0x03DF1F48 File Offset: 0x03DF0348
		' (set) Token: 0x060011F8 RID: 4600 RVA: 0x03DF1F60 File Offset: 0x03DF0360
		Friend Overridable Property Button28 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button28
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button23_Click
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

		' Token: 0x170005F3 RID: 1523
		' (get) Token: 0x060011F9 RID: 4601 RVA: 0x03DF1FC0 File Offset: 0x03DF03C0
		' (set) Token: 0x060011FA RID: 4602 RVA: 0x03DF1FD8 File Offset: 0x03DF03D8
		Friend Overridable Property Button29 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button29
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button23_Click
				Dim flag As Boolean = Me._Button29 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button29.Click, eventHandler
				End If
				Me._Button29 = value
				flag = Me._Button29 IsNot Nothing
				If flag Then
					AddHandler Me._Button29.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170005F4 RID: 1524
		' (get) Token: 0x060011FB RID: 4603 RVA: 0x03DF2038 File Offset: 0x03DF0438
		' (set) Token: 0x060011FC RID: 4604 RVA: 0x03DF2050 File Offset: 0x03DF0450
		Friend Overridable Property BS1 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._BS1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.BC1_Click
				Dim flag As Boolean = Me._BS1 IsNot Nothing
				If flag Then
					RemoveHandler Me._BS1.Click, eventHandler
				End If
				Me._BS1 = value
				flag = Me._BS1 IsNot Nothing
				If flag Then
					AddHandler Me._BS1.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170005F5 RID: 1525
		' (get) Token: 0x060011FD RID: 4605 RVA: 0x03DF20B0 File Offset: 0x03DF04B0
		' (set) Token: 0x060011FE RID: 4606 RVA: 0x03DF20C8 File Offset: 0x03DF04C8
		Friend Overridable Property BC1 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._BC1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.BC1_Click
				Dim flag As Boolean = Me._BC1 IsNot Nothing
				If flag Then
					RemoveHandler Me._BC1.Click, eventHandler
				End If
				Me._BC1 = value
				flag = Me._BC1 IsNot Nothing
				If flag Then
					AddHandler Me._BC1.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170005F6 RID: 1526
		' (get) Token: 0x060011FF RID: 4607 RVA: 0x03DF2128 File Offset: 0x03DF0528
		' (set) Token: 0x06001200 RID: 4608 RVA: 0x03DF2140 File Offset: 0x03DF0540
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

		' Token: 0x170005F7 RID: 1527
		' (get) Token: 0x06001201 RID: 4609 RVA: 0x03DF21A0 File Offset: 0x03DF05A0
		' (set) Token: 0x06001202 RID: 4610 RVA: 0x03DF21B8 File Offset: 0x03DF05B8
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

		' Token: 0x170005F8 RID: 1528
		' (get) Token: 0x06001203 RID: 4611 RVA: 0x03DF2218 File Offset: 0x03DF0618
		' (set) Token: 0x06001204 RID: 4612 RVA: 0x03DF2230 File Offset: 0x03DF0630
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

		' Token: 0x06001205 RID: 4613 RVA: 0x03DF223C File Offset: 0x03DF063C
		Private Sub Button23_Click(sender As Object, e As EventArgs)
			Me.TextBox1.Text = Me.TextBox1.Text + Strings.Replace(Conversions.ToString(NewLateBinding.LateGet(sender, Nothing, "text", New Object(-1) {}, Nothing, Nothing, Nothing)), "Btn", "", 1, -1, CompareMethod.Binary)
		End Sub

		' Token: 0x06001206 RID: 4614 RVA: 0x03DF2294 File Offset: 0x03DF0694
		Private Sub BC1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = sender Is Me.BS1
			If flag Then
				Me.TextBox1.Text = Me.TextBox1.Text + " "
			End If
			flag = sender Is Me.BE1
			If flag Then
				Me.TextBox1.Text = Me.TextBox1.Text + vbCrLf
			End If
			flag = sender Is Me.Buttonback
			If flag Then
				' The following expression was wrapped in a checked-expression
				Me.TextBox1.Text = Me.TextBox1.Text.Substring(0, Me.TextBox1.Text.Length - 1)
			End If
			flag = sender Is Me.BC1
			If flag Then
				Me.TextBox1.Clear()
			End If
		End Sub

		' Token: 0x06001207 RID: 4615 RVA: 0x03DF2354 File Offset: 0x03DF0754
		Private Sub Button11_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Button1.Text, "Q", False) = 0
			If flag Then
				Me.Button1.Text = "q"
				Me.Button2.Text = "w"
				Me.Button3.Text = "e"
				Me.Button4.Text = "r"
				Me.Button5.Text = "t"
				Me.Button6.Text = "y"
				Me.Button7.Text = "u"
				Me.Button8.Text = "i"
				Me.Button9.Text = "o"
				Me.Button10.Text = "p"
				Me.Button12.Text = "l"
				Me.Button13.Text = "k"
				Me.Button14.Text = "j"
				Me.Button15.Text = "h"
				Me.Button16.Text = "g"
				Me.Button17.Text = "f"
				Me.Button18.Text = "d"
				Me.Button19.Text = "s"
				Me.Button20.Text = "a"
				Me.Button23.Text = "m"
				Me.Button24.Text = "n"
				Me.Button25.Text = "b"
				Me.Button26.Text = "v"
				Me.Button27.Text = "c"
				Me.Button28.Text = "x"
				Me.Button29.Text = "z"
			Else
				Me.Button1.Text = "Q"
				Me.Button2.Text = "W"
				Me.Button3.Text = "E"
				Me.Button4.Text = "R"
				Me.Button5.Text = "T"
				Me.Button6.Text = "Y"
				Me.Button7.Text = "U"
				Me.Button8.Text = "I"
				Me.Button9.Text = "O"
				Me.Button10.Text = "P"
				Me.Button12.Text = "L"
				Me.Button13.Text = "K"
				Me.Button14.Text = "J"
				Me.Button15.Text = "H"
				Me.Button16.Text = "G"
				Me.Button17.Text = "F"
				Me.Button18.Text = "D"
				Me.Button19.Text = "S"
				Me.Button20.Text = "A"
				Me.Button23.Text = "M"
				Me.Button24.Text = "N"
				Me.Button25.Text = "B"
				Me.Button26.Text = "V"
				Me.Button27.Text = "C"
				Me.Button28.Text = "X"
				Me.Button29.Text = "Z"
			End If
		End Sub

		' Token: 0x06001208 RID: 4616 RVA: 0x03DF2700 File Offset: 0x03DF0B00
		Private Sub Button21_Click(sender As Object, e As EventArgs)
			Me.TextBox1.Copy()
			Me.TextBox1.Copy()
			Me.TextBox1.Copy()
			Me.TextBox1.Copy()
			Me.TextBox1.Copy()
			Me.TextBox1.Copy()
			Me.TextBox1.Copy()
			Me.TextBox1.Copy()
			Me.TextBox1.Copy()
			Me.TextBox1.Copy()
			Me.TextBox1.Copy()
			Me.TextBox1.Copy()
			Me.TextBox1.Copy()
		End Sub

		' Token: 0x0400069B RID: 1691
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400069D RID: 1693
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400069E RID: 1694
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x0400069F RID: 1695
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x040006A0 RID: 1696
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x040006A1 RID: 1697
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x040006A2 RID: 1698
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x040006A3 RID: 1699
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x040006A4 RID: 1700
		<AccessedThroughProperty("Button7")>
		Private _Button7 As Button

		' Token: 0x040006A5 RID: 1701
		<AccessedThroughProperty("Button8")>
		Private _Button8 As Button

		' Token: 0x040006A6 RID: 1702
		<AccessedThroughProperty("Button9")>
		Private _Button9 As Button

		' Token: 0x040006A7 RID: 1703
		<AccessedThroughProperty("Button10")>
		Private _Button10 As Button

		' Token: 0x040006A8 RID: 1704
		<AccessedThroughProperty("Button12")>
		Private _Button12 As Button

		' Token: 0x040006A9 RID: 1705
		<AccessedThroughProperty("Button13")>
		Private _Button13 As Button

		' Token: 0x040006AA RID: 1706
		<AccessedThroughProperty("Button14")>
		Private _Button14 As Button

		' Token: 0x040006AB RID: 1707
		<AccessedThroughProperty("Button15")>
		Private _Button15 As Button

		' Token: 0x040006AC RID: 1708
		<AccessedThroughProperty("Button16")>
		Private _Button16 As Button

		' Token: 0x040006AD RID: 1709
		<AccessedThroughProperty("Button17")>
		Private _Button17 As Button

		' Token: 0x040006AE RID: 1710
		<AccessedThroughProperty("Button18")>
		Private _Button18 As Button

		' Token: 0x040006AF RID: 1711
		<AccessedThroughProperty("Button19")>
		Private _Button19 As Button

		' Token: 0x040006B0 RID: 1712
		<AccessedThroughProperty("Button20")>
		Private _Button20 As Button

		' Token: 0x040006B1 RID: 1713
		<AccessedThroughProperty("Buttonback")>
		Private _Buttonback As Button

		' Token: 0x040006B2 RID: 1714
		<AccessedThroughProperty("BE1")>
		Private _BE1 As Button

		' Token: 0x040006B3 RID: 1715
		<AccessedThroughProperty("Button23")>
		Private _Button23 As Button

		' Token: 0x040006B4 RID: 1716
		<AccessedThroughProperty("Button24")>
		Private _Button24 As Button

		' Token: 0x040006B5 RID: 1717
		<AccessedThroughProperty("Button25")>
		Private _Button25 As Button

		' Token: 0x040006B6 RID: 1718
		<AccessedThroughProperty("Button26")>
		Private _Button26 As Button

		' Token: 0x040006B7 RID: 1719
		<AccessedThroughProperty("Button27")>
		Private _Button27 As Button

		' Token: 0x040006B8 RID: 1720
		<AccessedThroughProperty("Button28")>
		Private _Button28 As Button

		' Token: 0x040006B9 RID: 1721
		<AccessedThroughProperty("Button29")>
		Private _Button29 As Button

		' Token: 0x040006BA RID: 1722
		<AccessedThroughProperty("BS1")>
		Private _BS1 As Button

		' Token: 0x040006BB RID: 1723
		<AccessedThroughProperty("BC1")>
		Private _BC1 As Button

		' Token: 0x040006BC RID: 1724
		<AccessedThroughProperty("Button11")>
		Private _Button11 As Button

		' Token: 0x040006BD RID: 1725
		<AccessedThroughProperty("Button21")>
		Private _Button21 As Button

		' Token: 0x040006BE RID: 1726
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label
	End Class
End Namespace
