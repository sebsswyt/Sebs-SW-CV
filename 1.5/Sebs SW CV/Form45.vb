Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x0200005C RID: 92
	<DesignerGenerated()>
	Public Partial Class Form45
		Inherits Form

		' Token: 0x06000FE6 RID: 4070 RVA: 0x03DE2FD8 File Offset: 0x03DE13D8
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Form45.__ENCList
			SyncLock _ENCList
				Form45.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700053F RID: 1343
		' (get) Token: 0x06000FE9 RID: 4073 RVA: 0x03DE3DD4 File Offset: 0x03DE21D4
		' (set) Token: 0x06000FEA RID: 4074 RVA: 0x03DE3DEC File Offset: 0x03DE21EC
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

		' Token: 0x17000540 RID: 1344
		' (get) Token: 0x06000FEB RID: 4075 RVA: 0x03DE3E4C File Offset: 0x03DE224C
		' (set) Token: 0x06000FEC RID: 4076 RVA: 0x03DE3E64 File Offset: 0x03DE2264
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

		' Token: 0x17000541 RID: 1345
		' (get) Token: 0x06000FED RID: 4077 RVA: 0x03DE3EC4 File Offset: 0x03DE22C4
		' (set) Token: 0x06000FEE RID: 4078 RVA: 0x03DE3EDC File Offset: 0x03DE22DC
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

		' Token: 0x17000542 RID: 1346
		' (get) Token: 0x06000FEF RID: 4079 RVA: 0x03DE3F3C File Offset: 0x03DE233C
		' (set) Token: 0x06000FF0 RID: 4080 RVA: 0x03DE3F54 File Offset: 0x03DE2354
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

		' Token: 0x17000543 RID: 1347
		' (get) Token: 0x06000FF1 RID: 4081 RVA: 0x03DE3FB4 File Offset: 0x03DE23B4
		' (set) Token: 0x06000FF2 RID: 4082 RVA: 0x03DE3FCC File Offset: 0x03DE23CC
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

		' Token: 0x17000544 RID: 1348
		' (get) Token: 0x06000FF3 RID: 4083 RVA: 0x03DE402C File Offset: 0x03DE242C
		' (set) Token: 0x06000FF4 RID: 4084 RVA: 0x03DE4044 File Offset: 0x03DE2444
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

		' Token: 0x17000545 RID: 1349
		' (get) Token: 0x06000FF5 RID: 4085 RVA: 0x03DE40A4 File Offset: 0x03DE24A4
		' (set) Token: 0x06000FF6 RID: 4086 RVA: 0x03DE40BC File Offset: 0x03DE24BC
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

		' Token: 0x17000546 RID: 1350
		' (get) Token: 0x06000FF7 RID: 4087 RVA: 0x03DE411C File Offset: 0x03DE251C
		' (set) Token: 0x06000FF8 RID: 4088 RVA: 0x03DE4134 File Offset: 0x03DE2534
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

		' Token: 0x17000547 RID: 1351
		' (get) Token: 0x06000FF9 RID: 4089 RVA: 0x03DE4194 File Offset: 0x03DE2594
		' (set) Token: 0x06000FFA RID: 4090 RVA: 0x03DE41AC File Offset: 0x03DE25AC
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

		' Token: 0x17000548 RID: 1352
		' (get) Token: 0x06000FFB RID: 4091 RVA: 0x03DE420C File Offset: 0x03DE260C
		' (set) Token: 0x06000FFC RID: 4092 RVA: 0x03DE4224 File Offset: 0x03DE2624
		Friend Overridable Property Button10 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button10 = value
			End Set
		End Property

		' Token: 0x17000549 RID: 1353
		' (get) Token: 0x06000FFD RID: 4093 RVA: 0x03DE4230 File Offset: 0x03DE2630
		' (set) Token: 0x06000FFE RID: 4094 RVA: 0x03DE4248 File Offset: 0x03DE2648
		Friend Overridable Property Button11 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button11 = value
			End Set
		End Property

		' Token: 0x1700054A RID: 1354
		' (get) Token: 0x06000FFF RID: 4095 RVA: 0x03DE4254 File Offset: 0x03DE2654
		' (set) Token: 0x06001000 RID: 4096 RVA: 0x03DE426C File Offset: 0x03DE266C
		Friend Overridable Property Button12 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button12 = value
			End Set
		End Property

		' Token: 0x1700054B RID: 1355
		' (get) Token: 0x06001001 RID: 4097 RVA: 0x03DE4278 File Offset: 0x03DE2678
		' (set) Token: 0x06001002 RID: 4098 RVA: 0x03DE4290 File Offset: 0x03DE2690
		Friend Overridable Property Button13 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button13
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button13 = value
			End Set
		End Property

		' Token: 0x1700054C RID: 1356
		' (get) Token: 0x06001003 RID: 4099 RVA: 0x03DE429C File Offset: 0x03DE269C
		' (set) Token: 0x06001004 RID: 4100 RVA: 0x03DE42B4 File Offset: 0x03DE26B4
		Friend Overridable Property Button14 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button14
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button14 = value
			End Set
		End Property

		' Token: 0x1700054D RID: 1357
		' (get) Token: 0x06001005 RID: 4101 RVA: 0x03DE42C0 File Offset: 0x03DE26C0
		' (set) Token: 0x06001006 RID: 4102 RVA: 0x03DE42D8 File Offset: 0x03DE26D8
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

		' Token: 0x1700054E RID: 1358
		' (get) Token: 0x06001007 RID: 4103 RVA: 0x03DE42E4 File Offset: 0x03DE26E4
		' (set) Token: 0x06001008 RID: 4104 RVA: 0x03DE42FC File Offset: 0x03DE26FC
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

		' Token: 0x1700054F RID: 1359
		' (get) Token: 0x06001009 RID: 4105 RVA: 0x03DE435C File Offset: 0x03DE275C
		' (set) Token: 0x0600100A RID: 4106 RVA: 0x03DE4374 File Offset: 0x03DE2774
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

		' Token: 0x17000550 RID: 1360
		' (get) Token: 0x0600100B RID: 4107 RVA: 0x03DE4380 File Offset: 0x03DE2780
		' (set) Token: 0x0600100C RID: 4108 RVA: 0x03DE4398 File Offset: 0x03DE2798
		Friend Overridable Property Button17 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button17
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button17_Click
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

		' Token: 0x0600100D RID: 4109 RVA: 0x03DE43F8 File Offset: 0x03DE27F8
		Private Sub Button9_Click(sender As Object, e As EventArgs)
			Me.TextBox1.Text = Conversions.ToString(Conversions.ToDouble(Me.TextBox1.Text) + 7.0)
		End Sub

		' Token: 0x0600100E RID: 4110 RVA: 0x03DE4428 File Offset: 0x03DE2828
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.TextBox1.Text = Conversions.ToString(Conversions.ToDouble(Me.TextBox1.Text) + 1.0)
		End Sub

		' Token: 0x0600100F RID: 4111 RVA: 0x03DE4458 File Offset: 0x03DE2858
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Me.TextBox1.Text = Conversions.ToString(Conversions.ToDouble(Me.TextBox1.Text) + 2.0)
		End Sub

		' Token: 0x06001010 RID: 4112 RVA: 0x03DE4488 File Offset: 0x03DE2888
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			Me.TextBox1.Text = Conversions.ToString(Conversions.ToDouble(Me.TextBox1.Text) + 3.0)
		End Sub

		' Token: 0x06001011 RID: 4113 RVA: 0x03DE44B8 File Offset: 0x03DE28B8
		Private Sub Button6_Click(sender As Object, e As EventArgs)
			Me.TextBox1.Text = Conversions.ToString(Conversions.ToDouble(Me.TextBox1.Text) + 4.0)
		End Sub

		' Token: 0x06001012 RID: 4114 RVA: 0x03DE44E8 File Offset: 0x03DE28E8
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			Me.TextBox1.Text = Conversions.ToString(Conversions.ToDouble(Me.TextBox1.Text) + 5.0)
		End Sub

		' Token: 0x06001013 RID: 4115 RVA: 0x03DE4518 File Offset: 0x03DE2918
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			Me.TextBox1.Text = Conversions.ToString(Conversions.ToDouble(Me.TextBox1.Text) + 6.0)
		End Sub

		' Token: 0x06001014 RID: 4116 RVA: 0x03DE4548 File Offset: 0x03DE2948
		Private Sub Button8_Click(sender As Object, e As EventArgs)
			Me.TextBox1.Text = Conversions.ToString(Conversions.ToDouble(Me.TextBox1.Text) + 8.0)
		End Sub

		' Token: 0x06001015 RID: 4117 RVA: 0x03DE4578 File Offset: 0x03DE2978
		Private Sub Button7_Click(sender As Object, e As EventArgs)
			Me.TextBox1.Text = Conversions.ToString(Conversions.ToDouble(Me.TextBox1.Text) + 9.0)
		End Sub

		' Token: 0x06001016 RID: 4118 RVA: 0x03DE45A8 File Offset: 0x03DE29A8
		Private Sub Button17_Click(sender As Object, e As EventArgs)
			Me.TextBox1.Text = "0"
		End Sub

		' Token: 0x06001017 RID: 4119 RVA: 0x03DE45C0 File Offset: 0x03DE29C0
		Private Sub Button16_Click(sender As Object, e As EventArgs)
			Dim form As Form1 = New Form1()
			form.Show()
		End Sub

		' Token: 0x040005DF RID: 1503
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040005E1 RID: 1505
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040005E2 RID: 1506
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x040005E3 RID: 1507
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x040005E4 RID: 1508
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x040005E5 RID: 1509
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x040005E6 RID: 1510
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x040005E7 RID: 1511
		<AccessedThroughProperty("Button7")>
		Private _Button7 As Button

		' Token: 0x040005E8 RID: 1512
		<AccessedThroughProperty("Button8")>
		Private _Button8 As Button

		' Token: 0x040005E9 RID: 1513
		<AccessedThroughProperty("Button9")>
		Private _Button9 As Button

		' Token: 0x040005EA RID: 1514
		<AccessedThroughProperty("Button10")>
		Private _Button10 As Button

		' Token: 0x040005EB RID: 1515
		<AccessedThroughProperty("Button11")>
		Private _Button11 As Button

		' Token: 0x040005EC RID: 1516
		<AccessedThroughProperty("Button12")>
		Private _Button12 As Button

		' Token: 0x040005ED RID: 1517
		<AccessedThroughProperty("Button13")>
		Private _Button13 As Button

		' Token: 0x040005EE RID: 1518
		<AccessedThroughProperty("Button14")>
		Private _Button14 As Button

		' Token: 0x040005EF RID: 1519
		<AccessedThroughProperty("Button15")>
		Private _Button15 As Button

		' Token: 0x040005F0 RID: 1520
		<AccessedThroughProperty("Button16")>
		Private _Button16 As Button

		' Token: 0x040005F1 RID: 1521
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x040005F2 RID: 1522
		<AccessedThroughProperty("Button17")>
		Private _Button17 As Button
	End Class
End Namespace
