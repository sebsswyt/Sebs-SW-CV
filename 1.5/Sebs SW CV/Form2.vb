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
	' Token: 0x02000040 RID: 64
	<DesignerGenerated()>
	Public Partial Class Form2
		Inherits Form

		' Token: 0x060009A4 RID: 2468 RVA: 0x03DB7A6C File Offset: 0x03DB5E6C
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form2_Load
			Dim _ENCList As List(Of WeakReference) = Form2.__ENCList
			SyncLock _ENCList
				Form2.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700032D RID: 813
		' (get) Token: 0x060009A7 RID: 2471 RVA: 0x03DB82BC File Offset: 0x03DB66BC
		' (set) Token: 0x060009A8 RID: 2472 RVA: 0x03DB82D4 File Offset: 0x03DB66D4
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

		' Token: 0x1700032E RID: 814
		' (get) Token: 0x060009A9 RID: 2473 RVA: 0x03DB8334 File Offset: 0x03DB6734
		' (set) Token: 0x060009AA RID: 2474 RVA: 0x03DB834C File Offset: 0x03DB674C
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

		' Token: 0x1700032F RID: 815
		' (get) Token: 0x060009AB RID: 2475 RVA: 0x03DB83AC File Offset: 0x03DB67AC
		' (set) Token: 0x060009AC RID: 2476 RVA: 0x03DB83C4 File Offset: 0x03DB67C4
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

		' Token: 0x17000330 RID: 816
		' (get) Token: 0x060009AD RID: 2477 RVA: 0x03DB8424 File Offset: 0x03DB6824
		' (set) Token: 0x060009AE RID: 2478 RVA: 0x03DB843C File Offset: 0x03DB683C
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

		' Token: 0x17000331 RID: 817
		' (get) Token: 0x060009AF RID: 2479 RVA: 0x03DB849C File Offset: 0x03DB689C
		' (set) Token: 0x060009B0 RID: 2480 RVA: 0x03DB84B4 File Offset: 0x03DB68B4
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

		' Token: 0x17000332 RID: 818
		' (get) Token: 0x060009B1 RID: 2481 RVA: 0x03DB8514 File Offset: 0x03DB6914
		' (set) Token: 0x060009B2 RID: 2482 RVA: 0x03DB852C File Offset: 0x03DB692C
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

		' Token: 0x17000333 RID: 819
		' (get) Token: 0x060009B3 RID: 2483 RVA: 0x03DB858C File Offset: 0x03DB698C
		' (set) Token: 0x060009B4 RID: 2484 RVA: 0x03DB85A4 File Offset: 0x03DB69A4
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

		' Token: 0x17000334 RID: 820
		' (get) Token: 0x060009B5 RID: 2485 RVA: 0x03DB85B0 File Offset: 0x03DB69B0
		' (set) Token: 0x060009B6 RID: 2486 RVA: 0x03DB85C8 File Offset: 0x03DB69C8
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

		' Token: 0x17000335 RID: 821
		' (get) Token: 0x060009B7 RID: 2487 RVA: 0x03DB85D4 File Offset: 0x03DB69D4
		' (set) Token: 0x060009B8 RID: 2488 RVA: 0x03DB85EC File Offset: 0x03DB69EC
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

		' Token: 0x17000336 RID: 822
		' (get) Token: 0x060009B9 RID: 2489 RVA: 0x03DB864C File Offset: 0x03DB6A4C
		' (set) Token: 0x060009BA RID: 2490 RVA: 0x03DB8664 File Offset: 0x03DB6A64
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

		' Token: 0x060009BB RID: 2491 RVA: 0x03DB86C4 File Offset: 0x03DB6AC4
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			ProjectData.EndApp()
		End Sub

		' Token: 0x060009BC RID: 2492 RVA: 0x03DB86D0 File Offset: 0x03DB6AD0
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Explorer1.Show()
		End Sub

		' Token: 0x060009BD RID: 2493 RVA: 0x03DB86E4 File Offset: 0x03DB6AE4
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form5.Show()
		End Sub

		' Token: 0x060009BE RID: 2494 RVA: 0x03DB86F8 File Offset: 0x03DB6AF8
		Private Sub Form2_Load(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not MyProject.Forms.Form27.Label1.Visible
			If flag Then
				Me.Label1.Text = "CV"
			End If
			flag = Operators.CompareString(MyProject.Forms.Form27.Label1.Text, "???", False) = 0
			If flag Then
				Me.Label1.Text = "???"
			End If
			flag = Not MyProject.Forms.Form21.Label12.Visible
			If flag Then
				Me.Label1.Text = MyProject.Forms.Form27.Label1.Text
			End If
			flag = MyProject.Forms.Form27.Label1.Visible
			If flag Then
				Me.Label1.Text = MyProject.Forms.Form21.TextBox2.Text
			End If
			flag = Operators.CompareString(MyProject.Forms.Form27.Label1.Text, "Display", False) = 0
			If flag Then
				Me.Label1.Text = "???"
			End If
			flag = Operators.CompareString(MyProject.Forms.Form27.Button1.Text, ":) :(", False) = 0
			If flag Then
				Me.Label1.Text = MyProject.Forms.Form27.Label1.Text
			End If
		End Sub

		' Token: 0x060009BF RID: 2495 RVA: 0x03DB8860 File Offset: 0x03DB6C60
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form21.Show()
		End Sub

		' Token: 0x060009C0 RID: 2496 RVA: 0x03DB8874 File Offset: 0x03DB6C74
		Private Sub Button4_Click(sender As Object, e As EventArgs)
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
			MyProject.Forms.AboutBox13.Close()
			MyProject.Forms.AboutBox14.Close()
			MyProject.Forms.AboutBox15.Close()
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
			MyProject.Forms.Form22.Close()
			MyProject.Forms.Form23.Close()
			MyProject.Forms.Form24.Close()
			MyProject.Forms.Form25.Close()
			MyProject.Forms.Errorbox1.Close()
			MyProject.Forms.Form33.Show()
			MyProject.Forms.Form33.Timer1.Start()
			Me.Close()
		End Sub

		' Token: 0x060009C1 RID: 2497 RVA: 0x03DB8B30 File Offset: 0x03DB6F30
		Private Sub Button6_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form25.Show()
		End Sub

		' Token: 0x060009C2 RID: 2498 RVA: 0x03DB8B44 File Offset: 0x03DB6F44
		Private Sub Button7_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox17.Show()
		End Sub

		' Token: 0x060009C3 RID: 2499 RVA: 0x03DB8B58 File Offset: 0x03DB6F58
		Private Sub Button8_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox1.Show()
		End Sub

		' Token: 0x0400038A RID: 906
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400038C RID: 908
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400038D RID: 909
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x0400038E RID: 910
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x0400038F RID: 911
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x04000390 RID: 912
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x04000391 RID: 913
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x04000392 RID: 914
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x04000393 RID: 915
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000394 RID: 916
		<AccessedThroughProperty("Button7")>
		Private _Button7 As Button

		' Token: 0x04000395 RID: 917
		<AccessedThroughProperty("Button8")>
		Private _Button8 As Button
	End Class
End Namespace
