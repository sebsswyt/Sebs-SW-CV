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
	' Token: 0x02000043 RID: 67
	<DesignerGenerated()>
	Public Partial Class Form22
		Inherits Form

		' Token: 0x06000A9E RID: 2718 RVA: 0x03DBF474 File Offset: 0x03DBD874
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form22_Load
			Dim _ENCList As List(Of WeakReference) = Form22.__ENCList
			SyncLock _ENCList
				Form22.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000383 RID: 899
		' (get) Token: 0x06000AA1 RID: 2721 RVA: 0x03DC097C File Offset: 0x03DBED7C
		' (set) Token: 0x06000AA2 RID: 2722 RVA: 0x03DC0994 File Offset: 0x03DBED94
		Friend Overridable Property TableLayoutPanel As TableLayoutPanel
			<DebuggerNonUserCode()>
			Get
				Return Me._TableLayoutPanel
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TableLayoutPanel)
				Me._TableLayoutPanel = value
			End Set
		End Property

		' Token: 0x17000384 RID: 900
		' (get) Token: 0x06000AA3 RID: 2723 RVA: 0x03DC09A0 File Offset: 0x03DBEDA0
		' (set) Token: 0x06000AA4 RID: 2724 RVA: 0x03DC09B8 File Offset: 0x03DBEDB8
		Friend Overridable Property LogoPictureBox As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._LogoPictureBox
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._LogoPictureBox = value
			End Set
		End Property

		' Token: 0x17000385 RID: 901
		' (get) Token: 0x06000AA5 RID: 2725 RVA: 0x03DC09C4 File Offset: 0x03DBEDC4
		' (set) Token: 0x06000AA6 RID: 2726 RVA: 0x03DC09DC File Offset: 0x03DBEDDC
		Friend Overridable Property LabelProductName As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._LabelProductName
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._LabelProductName = value
			End Set
		End Property

		' Token: 0x17000386 RID: 902
		' (get) Token: 0x06000AA7 RID: 2727 RVA: 0x03DC09E8 File Offset: 0x03DBEDE8
		' (set) Token: 0x06000AA8 RID: 2728 RVA: 0x03DC0A00 File Offset: 0x03DBEE00
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

		' Token: 0x17000387 RID: 903
		' (get) Token: 0x06000AA9 RID: 2729 RVA: 0x03DC0A0C File Offset: 0x03DBEE0C
		' (set) Token: 0x06000AAA RID: 2730 RVA: 0x03DC0A24 File Offset: 0x03DBEE24
		Friend Overridable Property TextBoxDescription As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBoxDescription
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBoxDescription = value
			End Set
		End Property

		' Token: 0x17000388 RID: 904
		' (get) Token: 0x06000AAB RID: 2731 RVA: 0x03DC0A30 File Offset: 0x03DBEE30
		' (set) Token: 0x06000AAC RID: 2732 RVA: 0x03DC0A48 File Offset: 0x03DBEE48
		Friend Overridable Property Process1 As Process
			<DebuggerNonUserCode()>
			Get
				Return Me._Process1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Process)
				Me._Process1 = value
			End Set
		End Property

		' Token: 0x17000389 RID: 905
		' (get) Token: 0x06000AAD RID: 2733 RVA: 0x03DC0A54 File Offset: 0x03DBEE54
		' (set) Token: 0x06000AAE RID: 2734 RVA: 0x03DC0A6C File Offset: 0x03DBEE6C
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

		' Token: 0x1700038A RID: 906
		' (get) Token: 0x06000AAF RID: 2735 RVA: 0x03DC0A78 File Offset: 0x03DBEE78
		' (set) Token: 0x06000AB0 RID: 2736 RVA: 0x03DC0A90 File Offset: 0x03DBEE90
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

		' Token: 0x1700038B RID: 907
		' (get) Token: 0x06000AB1 RID: 2737 RVA: 0x03DC0AF0 File Offset: 0x03DBEEF0
		' (set) Token: 0x06000AB2 RID: 2738 RVA: 0x03DC0B08 File Offset: 0x03DBEF08
		Friend Overridable Property Panel1 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.Panel1_MouseDown
				Dim mouseEventHandler2 As MouseEventHandler = AddressOf Me.Panel1_MouseMove
				Dim flag As Boolean = Me._Panel1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Panel1.MouseDown, mouseEventHandler
					RemoveHandler Me._Panel1.MouseMove, mouseEventHandler2
				End If
				Me._Panel1 = value
				flag = Me._Panel1 IsNot Nothing
				If flag Then
					AddHandler Me._Panel1.MouseDown, mouseEventHandler
					AddHandler Me._Panel1.MouseMove, mouseEventHandler2
				End If
			End Set
		End Property

		' Token: 0x1700038C RID: 908
		' (get) Token: 0x06000AB3 RID: 2739 RVA: 0x03DC0B90 File Offset: 0x03DBEF90
		' (set) Token: 0x06000AB4 RID: 2740 RVA: 0x03DC0BA8 File Offset: 0x03DBEFA8
		Friend Overridable Property Button1 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button1_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.Button1_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.Button1_Click_2
				Dim flag As Boolean = Me._Button1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button1.MouseLeave, eventHandler
					RemoveHandler Me._Button1.MouseEnter, eventHandler2
					RemoveHandler Me._Button1.Click, eventHandler3
				End If
				Me._Button1 = value
				flag = Me._Button1 IsNot Nothing
				If flag Then
					AddHandler Me._Button1.MouseLeave, eventHandler
					AddHandler Me._Button1.MouseEnter, eventHandler2
					AddHandler Me._Button1.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x1700038D RID: 909
		' (get) Token: 0x06000AB5 RID: 2741 RVA: 0x03DC0C58 File Offset: 0x03DBF058
		' (set) Token: 0x06000AB6 RID: 2742 RVA: 0x03DC0C70 File Offset: 0x03DBF070
		Friend Overridable Property Button2 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button2_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.Button2_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.Button2_Click_1
				Dim flag As Boolean = Me._Button2 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button2.MouseLeave, eventHandler
					RemoveHandler Me._Button2.MouseEnter, eventHandler2
					RemoveHandler Me._Button2.Click, eventHandler3
				End If
				Me._Button2 = value
				flag = Me._Button2 IsNot Nothing
				If flag Then
					AddHandler Me._Button2.MouseLeave, eventHandler
					AddHandler Me._Button2.MouseEnter, eventHandler2
					AddHandler Me._Button2.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x1700038E RID: 910
		' (get) Token: 0x06000AB7 RID: 2743 RVA: 0x03DC0D20 File Offset: 0x03DBF120
		' (set) Token: 0x06000AB8 RID: 2744 RVA: 0x03DC0D38 File Offset: 0x03DBF138
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

		' Token: 0x1700038F RID: 911
		' (get) Token: 0x06000AB9 RID: 2745 RVA: 0x03DC0D44 File Offset: 0x03DBF144
		' (set) Token: 0x06000ABA RID: 2746 RVA: 0x03DC0D5C File Offset: 0x03DBF15C
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

		' Token: 0x17000390 RID: 912
		' (get) Token: 0x06000ABB RID: 2747 RVA: 0x03DC0D68 File Offset: 0x03DBF168
		' (set) Token: 0x06000ABC RID: 2748 RVA: 0x03DC0D80 File Offset: 0x03DBF180
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

		' Token: 0x17000391 RID: 913
		' (get) Token: 0x06000ABD RID: 2749 RVA: 0x03DC0D8C File Offset: 0x03DBF18C
		' (set) Token: 0x06000ABE RID: 2750 RVA: 0x03DC0DA4 File Offset: 0x03DBF1A4
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

		' Token: 0x17000392 RID: 914
		' (get) Token: 0x06000ABF RID: 2751 RVA: 0x03DC0DB0 File Offset: 0x03DBF1B0
		' (set) Token: 0x06000AC0 RID: 2752 RVA: 0x03DC0DC8 File Offset: 0x03DBF1C8
		Friend Overridable Property Label6 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim eventHandler As EventHandler = AddressOf Me.Label6_Click
				Dim flag As Boolean = Me._Label6 IsNot Nothing
				If flag Then
					RemoveHandler Me._Label6.Click, eventHandler
				End If
				Me._Label6 = value
				flag = Me._Label6 IsNot Nothing
				If flag Then
					AddHandler Me._Label6.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000393 RID: 915
		' (get) Token: 0x06000AC1 RID: 2753 RVA: 0x03DC0E28 File Offset: 0x03DBF228
		' (set) Token: 0x06000AC2 RID: 2754 RVA: 0x03DC0E40 File Offset: 0x03DBF240
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

		' Token: 0x17000394 RID: 916
		' (get) Token: 0x06000AC3 RID: 2755 RVA: 0x03DC0E4C File Offset: 0x03DBF24C
		' (set) Token: 0x06000AC4 RID: 2756 RVA: 0x03DC0E64 File Offset: 0x03DBF264
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

		' Token: 0x17000395 RID: 917
		' (get) Token: 0x06000AC5 RID: 2757 RVA: 0x03DC0EC4 File Offset: 0x03DBF2C4
		' (set) Token: 0x06000AC6 RID: 2758 RVA: 0x03DC0EDC File Offset: 0x03DBF2DC
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

		' Token: 0x17000396 RID: 918
		' (get) Token: 0x06000AC7 RID: 2759 RVA: 0x03DC0F3C File Offset: 0x03DBF33C
		' (set) Token: 0x06000AC8 RID: 2760 RVA: 0x03DC0F54 File Offset: 0x03DBF354
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

		' Token: 0x17000397 RID: 919
		' (get) Token: 0x06000AC9 RID: 2761 RVA: 0x03DC0F60 File Offset: 0x03DBF360
		' (set) Token: 0x06000ACA RID: 2762 RVA: 0x03DC0F78 File Offset: 0x03DBF378
		Friend Overridable Property PictureBox2 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox2_MouseEnter
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox2_Click
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox2_MouseLeave
				Dim flag As Boolean = Me._PictureBox2 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox2.MouseEnter, eventHandler
					RemoveHandler Me._PictureBox2.Click, eventHandler2
					RemoveHandler Me._PictureBox2.MouseLeave, eventHandler3
				End If
				Me._PictureBox2 = value
				flag = Me._PictureBox2 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox2.MouseEnter, eventHandler
					AddHandler Me._PictureBox2.Click, eventHandler2
					AddHandler Me._PictureBox2.MouseLeave, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x17000398 RID: 920
		' (get) Token: 0x06000ACB RID: 2763 RVA: 0x03DC1028 File Offset: 0x03DBF428
		' (set) Token: 0x06000ACC RID: 2764 RVA: 0x03DC1040 File Offset: 0x03DBF440
		Friend Overridable Property PictureBox4 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox4_Click
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

		' Token: 0x17000399 RID: 921
		' (get) Token: 0x06000ACD RID: 2765 RVA: 0x03DC10F0 File Offset: 0x03DBF4F0
		' (set) Token: 0x06000ACE RID: 2766 RVA: 0x03DC1108 File Offset: 0x03DBF508
		Friend Overridable Property PictureBox3 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox3_Click
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox3_MouseLeave
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox3_MouseEnter
				Dim flag As Boolean = Me._PictureBox3 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox3.Click, eventHandler
					RemoveHandler Me._PictureBox3.MouseLeave, eventHandler2
					RemoveHandler Me._PictureBox3.MouseEnter, eventHandler3
				End If
				Me._PictureBox3 = value
				flag = Me._PictureBox3 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox3.Click, eventHandler
					AddHandler Me._PictureBox3.MouseLeave, eventHandler2
					AddHandler Me._PictureBox3.MouseEnter, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x1700039A RID: 922
		' (get) Token: 0x06000ACF RID: 2767 RVA: 0x03DC11B8 File Offset: 0x03DBF5B8
		' (set) Token: 0x06000AD0 RID: 2768 RVA: 0x03DC11D0 File Offset: 0x03DBF5D0
		Friend Overridable Property WebBrowser1 As WebBrowser
			<DebuggerNonUserCode()>
			Get
				Return Me._WebBrowser1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As WebBrowser)
				Dim webBrowserDocumentCompletedEventHandler As WebBrowserDocumentCompletedEventHandler = AddressOf Me.WebBrowser1_DocumentCompleted
				Dim flag As Boolean = Me._WebBrowser1 IsNot Nothing
				If flag Then
					RemoveHandler Me._WebBrowser1.DocumentCompleted, webBrowserDocumentCompletedEventHandler
				End If
				Me._WebBrowser1 = value
				flag = Me._WebBrowser1 IsNot Nothing
				If flag Then
					AddHandler Me._WebBrowser1.DocumentCompleted, webBrowserDocumentCompletedEventHandler
				End If
			End Set
		End Property

		' Token: 0x1700039B RID: 923
		' (get) Token: 0x06000AD1 RID: 2769 RVA: 0x03DC1230 File Offset: 0x03DBF630
		' (set) Token: 0x06000AD2 RID: 2770 RVA: 0x03DC1248 File Offset: 0x03DBF648
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

		' Token: 0x06000AD3 RID: 2771 RVA: 0x03DC12A8 File Offset: 0x03DBF6A8
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000AD4 RID: 2772 RVA: 0x03DC12B4 File Offset: 0x03DBF6B4
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000AD5 RID: 2773 RVA: 0x03DC12B8 File Offset: 0x03DBF6B8
		Private Sub Button1_Click_1(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000AD6 RID: 2774 RVA: 0x03DC12BC File Offset: 0x03DBF6BC
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox19.Show()
		End Sub

		' Token: 0x06000AD7 RID: 2775 RVA: 0x03DC12D0 File Offset: 0x03DBF6D0
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox1.Show()
		End Sub

		' Token: 0x06000AD8 RID: 2776 RVA: 0x03DC12E4 File Offset: 0x03DBF6E4
		Private Sub Button1_Click_2(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000AD9 RID: 2777 RVA: 0x03DC12F0 File Offset: 0x03DBF6F0
		Private Sub Button2_Click_1(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.WindowState = FormWindowState.Normal
			If flag Then
				Me.WindowState = FormWindowState.Maximized
			Else
				Me.WindowState = FormWindowState.Normal
			End If
		End Sub

		' Token: 0x06000ADA RID: 2778 RVA: 0x03DC1320 File Offset: 0x03DBF720
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Dim flag As Boolean = MyProject.Forms.Form1.Button1.Visible
			If flag Then
				Me.Button3.Visible = True
			End If
			flag = MyProject.Forms.Form21.ONWindow.Visible
			If flag Then
				Me.Panel1.Visible = False
			End If
			Me.Panel1.BackColor = MyProject.Forms.Form_1pad.Panel1.BackColor
		End Sub

		' Token: 0x06000ADB RID: 2779 RVA: 0x03DC13A0 File Offset: 0x03DBF7A0
		Private Sub Button1_MouseEnter(sender As Object, e As EventArgs)
			Me.Button1.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000ADC RID: 2780 RVA: 0x03DC13B8 File Offset: 0x03DBF7B8
		Private Sub Button1_MouseLeave(sender As Object, e As EventArgs)
			Me.Button1.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000ADD RID: 2781 RVA: 0x03DC13D0 File Offset: 0x03DBF7D0
		Private Sub Button2_MouseEnter(sender As Object, e As EventArgs)
			Me.Button2.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000ADE RID: 2782 RVA: 0x03DC13E8 File Offset: 0x03DBF7E8
		Private Sub Button2_MouseLeave(sender As Object, e As EventArgs)
			Me.Button2.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000ADF RID: 2783 RVA: 0x03DC1400 File Offset: 0x03DBF800
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x06000AE0 RID: 2784 RVA: 0x03DC140C File Offset: 0x03DBF80C
		Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs)
			' The following expression was wrapped in a checked-expression
			Me.mouse_move = New Point(0 - e.X, 0 - e.Y)
		End Sub

		' Token: 0x06000AE1 RID: 2785 RVA: 0x03DC142C File Offset: 0x03DBF82C
		Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = e.Button = MouseButtons.Left
			If flag Then
				Dim mousePosition As Point = Control.MousePosition
				mousePosition.Offset(Me.mouse_move.X, Me.mouse_move.Y)
				Me.Location = mousePosition
			End If
		End Sub

		' Token: 0x06000AE2 RID: 2786 RVA: 0x03DC147C File Offset: 0x03DBF87C
		Private Sub Form22_Load(sender As Object, e As EventArgs)
			Me.Label5.Text = String.Format("Version {0}", MyProject.Application.Info.Version.ToString())
			Me.Label7.Text = MyProject.Application.Info.Copyright
		End Sub

		' Token: 0x06000AE3 RID: 2787 RVA: 0x03DC14D0 File Offset: 0x03DBF8D0
		Private Sub Label6_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000AE4 RID: 2788 RVA: 0x03DC14D4 File Offset: 0x03DBF8D4
		Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form20.Show()
		End Sub

		' Token: 0x06000AE5 RID: 2789 RVA: 0x03DC14E8 File Offset: 0x03DBF8E8
		Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form43.Show()
		End Sub

		' Token: 0x06000AE6 RID: 2790 RVA: 0x03DC14FC File Offset: 0x03DBF8FC
		Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form51.Show()
		End Sub

		' Token: 0x06000AE7 RID: 2791 RVA: 0x03DC1510 File Offset: 0x03DBF910
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox19.Show()
		End Sub

		' Token: 0x06000AE8 RID: 2792 RVA: 0x03DC1524 File Offset: 0x03DBF924
		Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)
		End Sub

		' Token: 0x06000AE9 RID: 2793 RVA: 0x03DC1528 File Offset: 0x03DBF928
		Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox2.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000AEA RID: 2794 RVA: 0x03DC1540 File Offset: 0x03DBF940
		Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox2.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000AEB RID: 2795 RVA: 0x03DC1558 File Offset: 0x03DBF958
		Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox3.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000AEC RID: 2796 RVA: 0x03DC1570 File Offset: 0x03DBF970
		Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox3.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000AED RID: 2797 RVA: 0x03DC1588 File Offset: 0x03DBF988
		Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox4.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000AEE RID: 2798 RVA: 0x03DC15A0 File Offset: 0x03DBF9A0
		Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox4.BackColor = Color.Transparent
		End Sub

		' Token: 0x040003E9 RID: 1001
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040003EB RID: 1003
		<AccessedThroughProperty("TableLayoutPanel")>
		Private _TableLayoutPanel As TableLayoutPanel

		' Token: 0x040003EC RID: 1004
		<AccessedThroughProperty("LogoPictureBox")>
		Private _LogoPictureBox As PictureBox

		' Token: 0x040003ED RID: 1005
		<AccessedThroughProperty("LabelProductName")>
		Private _LabelProductName As Label

		' Token: 0x040003EE RID: 1006
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x040003EF RID: 1007
		<AccessedThroughProperty("TextBoxDescription")>
		Private _TextBoxDescription As TextBox

		' Token: 0x040003F0 RID: 1008
		<AccessedThroughProperty("Process1")>
		Private _Process1 As Process

		' Token: 0x040003F1 RID: 1009
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x040003F2 RID: 1010
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x040003F3 RID: 1011
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x040003F4 RID: 1012
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040003F5 RID: 1013
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x040003F6 RID: 1014
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x040003F7 RID: 1015
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x040003F8 RID: 1016
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x040003F9 RID: 1017
		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		' Token: 0x040003FA RID: 1018
		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		' Token: 0x040003FB RID: 1019
		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		' Token: 0x040003FC RID: 1020
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x040003FD RID: 1021
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x040003FE RID: 1022
		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel

		' Token: 0x040003FF RID: 1023
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x04000400 RID: 1024
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x04000401 RID: 1025
		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		' Token: 0x04000402 RID: 1026
		<AccessedThroughProperty("WebBrowser1")>
		Private _WebBrowser1 As WebBrowser

		' Token: 0x04000403 RID: 1027
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x04000404 RID: 1028
		Private mouse_move As Point
	End Class
End Namespace
