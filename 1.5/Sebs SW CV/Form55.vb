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
	' Token: 0x02000067 RID: 103
	<DesignerGenerated()>
	Public Partial Class Form55
		Inherits Form

		' Token: 0x06001135 RID: 4405 RVA: 0x03DEBCE0 File Offset: 0x03DEA0E0
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Form55.__ENCList
			SyncLock _ENCList
				Form55.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170005A9 RID: 1449
		' (get) Token: 0x06001138 RID: 4408 RVA: 0x03DECB48 File Offset: 0x03DEAF48
		' (set) Token: 0x06001139 RID: 4409 RVA: 0x03DECB60 File Offset: 0x03DEAF60
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

		' Token: 0x170005AA RID: 1450
		' (get) Token: 0x0600113A RID: 4410 RVA: 0x03DECB6C File Offset: 0x03DEAF6C
		' (set) Token: 0x0600113B RID: 4411 RVA: 0x03DECB84 File Offset: 0x03DEAF84
		Friend Overridable Property Button1 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button1 = value
			End Set
		End Property

		' Token: 0x170005AB RID: 1451
		' (get) Token: 0x0600113C RID: 4412 RVA: 0x03DECB90 File Offset: 0x03DEAF90
		' (set) Token: 0x0600113D RID: 4413 RVA: 0x03DECBA8 File Offset: 0x03DEAFA8
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

		' Token: 0x170005AC RID: 1452
		' (get) Token: 0x0600113E RID: 4414 RVA: 0x03DECC08 File Offset: 0x03DEB008
		' (set) Token: 0x0600113F RID: 4415 RVA: 0x03DECC20 File Offset: 0x03DEB020
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

		' Token: 0x170005AD RID: 1453
		' (get) Token: 0x06001140 RID: 4416 RVA: 0x03DECC80 File Offset: 0x03DEB080
		' (set) Token: 0x06001141 RID: 4417 RVA: 0x03DECC98 File Offset: 0x03DEB098
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

		' Token: 0x170005AE RID: 1454
		' (get) Token: 0x06001142 RID: 4418 RVA: 0x03DECCF8 File Offset: 0x03DEB0F8
		' (set) Token: 0x06001143 RID: 4419 RVA: 0x03DECD10 File Offset: 0x03DEB110
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

		' Token: 0x170005AF RID: 1455
		' (get) Token: 0x06001144 RID: 4420 RVA: 0x03DECD70 File Offset: 0x03DEB170
		' (set) Token: 0x06001145 RID: 4421 RVA: 0x03DECD88 File Offset: 0x03DEB188
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

		' Token: 0x170005B0 RID: 1456
		' (get) Token: 0x06001146 RID: 4422 RVA: 0x03DECDE8 File Offset: 0x03DEB1E8
		' (set) Token: 0x06001147 RID: 4423 RVA: 0x03DECE00 File Offset: 0x03DEB200
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

		' Token: 0x170005B1 RID: 1457
		' (get) Token: 0x06001148 RID: 4424 RVA: 0x03DECE60 File Offset: 0x03DEB260
		' (set) Token: 0x06001149 RID: 4425 RVA: 0x03DECE78 File Offset: 0x03DEB278
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

		' Token: 0x170005B2 RID: 1458
		' (get) Token: 0x0600114A RID: 4426 RVA: 0x03DECE84 File Offset: 0x03DEB284
		' (set) Token: 0x0600114B RID: 4427 RVA: 0x03DECE9C File Offset: 0x03DEB29C
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

		' Token: 0x170005B3 RID: 1459
		' (get) Token: 0x0600114C RID: 4428 RVA: 0x03DECEA8 File Offset: 0x03DEB2A8
		' (set) Token: 0x0600114D RID: 4429 RVA: 0x03DECEC0 File Offset: 0x03DEB2C0
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

		' Token: 0x170005B4 RID: 1460
		' (get) Token: 0x0600114E RID: 4430 RVA: 0x03DECECC File Offset: 0x03DEB2CC
		' (set) Token: 0x0600114F RID: 4431 RVA: 0x03DECEE4 File Offset: 0x03DEB2E4
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

		' Token: 0x170005B5 RID: 1461
		' (get) Token: 0x06001150 RID: 4432 RVA: 0x03DECEF0 File Offset: 0x03DEB2F0
		' (set) Token: 0x06001151 RID: 4433 RVA: 0x03DECF08 File Offset: 0x03DEB308
		Friend Overridable Property Button9 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button9_Click
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

		' Token: 0x170005B6 RID: 1462
		' (get) Token: 0x06001152 RID: 4434 RVA: 0x03DECF68 File Offset: 0x03DEB368
		' (set) Token: 0x06001153 RID: 4435 RVA: 0x03DECF80 File Offset: 0x03DEB380
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

		' Token: 0x170005B7 RID: 1463
		' (get) Token: 0x06001154 RID: 4436 RVA: 0x03DECFE0 File Offset: 0x03DEB3E0
		' (set) Token: 0x06001155 RID: 4437 RVA: 0x03DECFF8 File Offset: 0x03DEB3F8
		Friend Overridable Property WebBrowser1 As WebBrowser
			<DebuggerNonUserCode()>
			Get
				Return Me._WebBrowser1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As WebBrowser)
				Me._WebBrowser1 = value
			End Set
		End Property

		' Token: 0x170005B8 RID: 1464
		' (get) Token: 0x06001156 RID: 4438 RVA: 0x03DED004 File Offset: 0x03DEB404
		' (set) Token: 0x06001157 RID: 4439 RVA: 0x03DED01C File Offset: 0x03DEB41C
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

		' Token: 0x170005B9 RID: 1465
		' (get) Token: 0x06001158 RID: 4440 RVA: 0x03DED07C File Offset: 0x03DEB47C
		' (set) Token: 0x06001159 RID: 4441 RVA: 0x03DED094 File Offset: 0x03DEB494
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

		' Token: 0x170005BA RID: 1466
		' (get) Token: 0x0600115A RID: 4442 RVA: 0x03DED0F4 File Offset: 0x03DEB4F4
		' (set) Token: 0x0600115B RID: 4443 RVA: 0x03DED10C File Offset: 0x03DEB50C
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

		' Token: 0x170005BB RID: 1467
		' (get) Token: 0x0600115C RID: 4444 RVA: 0x03DED118 File Offset: 0x03DEB518
		' (set) Token: 0x0600115D RID: 4445 RVA: 0x03DED130 File Offset: 0x03DEB530
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

		' Token: 0x0600115E RID: 4446 RVA: 0x03DED13C File Offset: 0x03DEB53C
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form56.Show()
		End Sub

		' Token: 0x0600115F RID: 4447 RVA: 0x03DED150 File Offset: 0x03DEB550
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form56.Show()
			MyProject.Forms.Form56.WebBrowser1.Navigate("https://seb-os-web.netlify.app/SCSW1.0.exe")
		End Sub

		' Token: 0x06001160 RID: 4448 RVA: 0x03DED180 File Offset: 0x03DEB580
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form19.Show()
		End Sub

		' Token: 0x06001161 RID: 4449 RVA: 0x03DED194 File Offset: 0x03DEB594
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form7.Show()
		End Sub

		' Token: 0x06001162 RID: 4450 RVA: 0x03DED1A8 File Offset: 0x03DEB5A8
		Private Sub Button7_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form41.Show()
		End Sub

		' Token: 0x06001163 RID: 4451 RVA: 0x03DED1BC File Offset: 0x03DEB5BC
		Private Sub Button8_Click(sender As Object, e As EventArgs)
			Me.WebBrowser1.GoBack()
		End Sub

		' Token: 0x06001164 RID: 4452 RVA: 0x03DED1CC File Offset: 0x03DEB5CC
		Private Sub Button9_Click(sender As Object, e As EventArgs)
			Me.WebBrowser1.GoForward()
		End Sub

		' Token: 0x06001165 RID: 4453 RVA: 0x03DED1DC File Offset: 0x03DEB5DC
		Private Sub Button10_Click(sender As Object, e As EventArgs)
			Me.WebBrowser1.Navigate("https://app-web.tk")
		End Sub

		' Token: 0x06001166 RID: 4454 RVA: 0x03DED1F4 File Offset: 0x03DEB5F4
		Private Sub Button11_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06001167 RID: 4455 RVA: 0x03DED200 File Offset: 0x03DEB600
		Private Sub Button6_Click(sender As Object, e As EventArgs)
			MyProject.Forms.form1Pad.Panel6.Visible = True
		End Sub

		' Token: 0x04000661 RID: 1633
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000663 RID: 1635
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x04000664 RID: 1636
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000665 RID: 1637
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x04000666 RID: 1638
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x04000667 RID: 1639
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x04000668 RID: 1640
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x04000669 RID: 1641
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x0400066A RID: 1642
		<AccessedThroughProperty("Button7")>
		Private _Button7 As Button

		' Token: 0x0400066B RID: 1643
		<AccessedThroughProperty("TabControl1")>
		Private _TabControl1 As TabControl

		' Token: 0x0400066C RID: 1644
		<AccessedThroughProperty("TabPage1")>
		Private _TabPage1 As TabPage

		' Token: 0x0400066D RID: 1645
		<AccessedThroughProperty("TabPage2")>
		Private _TabPage2 As TabPage

		' Token: 0x0400066E RID: 1646
		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel

		' Token: 0x0400066F RID: 1647
		<AccessedThroughProperty("Button9")>
		Private _Button9 As Button

		' Token: 0x04000670 RID: 1648
		<AccessedThroughProperty("Button8")>
		Private _Button8 As Button

		' Token: 0x04000671 RID: 1649
		<AccessedThroughProperty("WebBrowser1")>
		Private _WebBrowser1 As WebBrowser

		' Token: 0x04000672 RID: 1650
		<AccessedThroughProperty("Button10")>
		Private _Button10 As Button

		' Token: 0x04000673 RID: 1651
		<AccessedThroughProperty("Button11")>
		Private _Button11 As Button

		' Token: 0x04000674 RID: 1652
		<AccessedThroughProperty("Panel3")>
		Private _Panel3 As Panel

		' Token: 0x04000675 RID: 1653
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label
	End Class
End Namespace
