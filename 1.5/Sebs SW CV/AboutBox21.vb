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
	' Token: 0x02000017 RID: 23
	<DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox21
		Inherits Form

		' Token: 0x060001D4 RID: 468 RVA: 0x03D87A4C File Offset: 0x03D85E4C
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.AboutBox21_Load
			Dim _ENCList As List(Of WeakReference) = AboutBox21.__ENCList
			SyncLock _ENCList
				AboutBox21.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170000AC RID: 172
		' (get) Token: 0x060001D7 RID: 471 RVA: 0x03D87D08 File Offset: 0x03D86108
		' (set) Token: 0x060001D8 RID: 472 RVA: 0x03D87D20 File Offset: 0x03D86120
		Friend Property Button1 As Button
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

		' Token: 0x170000AD RID: 173
		' (get) Token: 0x060001D9 RID: 473 RVA: 0x03D87D80 File Offset: 0x03D86180
		' (set) Token: 0x060001DA RID: 474 RVA: 0x03D87D98 File Offset: 0x03D86198
		Friend Property Timer1 As Timer
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

		' Token: 0x170000AE RID: 174
		' (get) Token: 0x060001DB RID: 475 RVA: 0x03D87DF8 File Offset: 0x03D861F8
		' (set) Token: 0x060001DC RID: 476 RVA: 0x03D87E10 File Offset: 0x03D86210
		Friend Property PictureBox1 As PictureBox
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

		' Token: 0x170000AF RID: 175
		' (get) Token: 0x060001DD RID: 477 RVA: 0x03D87E1C File Offset: 0x03D8621C
		' (set) Token: 0x060001DE RID: 478 RVA: 0x03D87E34 File Offset: 0x03D86234
		Friend Property Timer2 As Timer
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

		' Token: 0x060001DF RID: 479 RVA: 0x03D87E94 File Offset: 0x03D86294
		Private Sub AboutBox21_Load(sender As Object, e As EventArgs)
			Me.Timer1.Start()
			MyProject.Forms.Form1.Close()
			MyProject.Forms.form1Pad.Close()
			MyProject.Forms.Form33.Show()
			MyProject.Forms.Form33.Timer1.Start()
			Dim flag As Boolean = MyProject.Forms.form1Pad.Picture6.Visible
			If flag Then
				Me.Button1.Text = "1"
			End If
			flag = MyProject.Forms.form1Pad.Picture2.Visible
			If flag Then
				Me.Button1.Text = "2"
			Else
				flag = MyProject.Forms.form1Pad.Picture3.Visible
				If flag Then
					Me.Button1.Text = "3"
				Else
					flag = MyProject.Forms.form1Pad.Picture4.Visible
					If flag Then
						Me.Button1.Text = "4"
					Else
						flag = MyProject.Forms.form1Pad.Picture5.Visible
						If flag Then
							Me.Button1.Text = "5"
						Else
							flag = MyProject.Forms.form1Pad.Picture6.Visible
							If flag Then
								Me.PictureBox1.Image = MyProject.Forms.form1Pad.Picture6.Image
								Me.Button1.Text = "6"
							End If
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x060001E0 RID: 480 RVA: 0x03D88024 File Offset: 0x03D86424
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x060001E1 RID: 481 RVA: 0x03D88030 File Offset: 0x03D86430
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Dim flag As Boolean = MyProject.Forms.Form33.ProgressBar1.Value = 97
			If flag Then
				MyProject.Forms.form1Pad.Show()
				flag = Operators.CompareString(Me.Button1.Text, "1", False) = 0
				If flag Then
					MyProject.Forms.Form33.Close()
					Me.Timer2.Start()
				End If
				flag = Operators.CompareString(Me.Button1.Text, "2", False) = 0
				If flag Then
					MyProject.Forms.form1Pad.Picture2.Visible = True
					MyProject.Forms.Form33.Close()
					Me.Timer2.Start()
				Else
					flag = Operators.CompareString(Me.Button1.Text, "3", False) = 0
					If flag Then
						MyProject.Forms.form1Pad.Picture3.Visible = True
						MyProject.Forms.Form33.Close()
						Me.Timer2.Start()
					Else
						flag = Operators.CompareString(Me.Button1.Text, "4", False) = 0
						If flag Then
							MyProject.Forms.Form33.Close()
							Me.Timer2.Start()
							MyProject.Forms.form1Pad.Picture4.Visible = True
						Else
							flag = Operators.CompareString(Me.Button1.Text, "5", False) = 0
							If flag Then
								MyProject.Forms.Form33.Close()
								Me.Timer2.Start()
								MyProject.Forms.form1Pad.Picture5.Visible = True
							Else
								flag = Operators.CompareString(Me.Button1.Text, "6", False) = 0
								If flag Then
									MyProject.Forms.form1Pad.Picture6.Image = Me.PictureBox1.Image
									MyProject.Forms.form1Pad.Picture6.Visible = True
									MyProject.Forms.Form33.Close()
									Me.Timer2.Start()
								End If
							End If
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x060001E2 RID: 482 RVA: 0x03D88270 File Offset: 0x03D86670
		Private Sub Button1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060001E3 RID: 483 RVA: 0x03D88274 File Offset: 0x03D86674
		Private Sub Timer2_Tick(sender As Object, e As EventArgs)
			Dim visible As Boolean = MyProject.Forms.Form1.Button1.Visible
			If visible Then
				MyProject.Forms.Form33.Close()
				MyProject.Forms.Form1.Close()
				Me.Close()
			End If
		End Sub

		' Token: 0x040000C6 RID: 198
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040000C8 RID: 200
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040000C9 RID: 201
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x040000CA RID: 202
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x040000CB RID: 203
		<AccessedThroughProperty("Timer2")>
		Private _Timer2 As Timer
	End Class
End Namespace
