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
	' Token: 0x02000018 RID: 24
	<DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox22
		Inherits Form

		' Token: 0x060001E5 RID: 485 RVA: 0x03D882D4 File Offset: 0x03D866D4
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.AboutBox22_Load
			Dim _ENCList As List(Of WeakReference) = AboutBox22.__ENCList
			SyncLock _ENCList
				AboutBox22.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170000B0 RID: 176
		' (get) Token: 0x060001E8 RID: 488 RVA: 0x03D88938 File Offset: 0x03D86D38
		' (set) Token: 0x060001E9 RID: 489 RVA: 0x03D88950 File Offset: 0x03D86D50
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

		' Token: 0x170000B1 RID: 177
		' (get) Token: 0x060001EA RID: 490 RVA: 0x03D8895C File Offset: 0x03D86D5C
		' (set) Token: 0x060001EB RID: 491 RVA: 0x03D88974 File Offset: 0x03D86D74
		Friend Property PictureBox2 As PictureBox
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

		' Token: 0x170000B2 RID: 178
		' (get) Token: 0x060001EC RID: 492 RVA: 0x03D88980 File Offset: 0x03D86D80
		' (set) Token: 0x060001ED RID: 493 RVA: 0x03D88998 File Offset: 0x03D86D98
		Friend Property PictureBox3 As PictureBox
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

		' Token: 0x170000B3 RID: 179
		' (get) Token: 0x060001EE RID: 494 RVA: 0x03D889A4 File Offset: 0x03D86DA4
		' (set) Token: 0x060001EF RID: 495 RVA: 0x03D889BC File Offset: 0x03D86DBC
		Friend Property PictureBox4 As PictureBox
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

		' Token: 0x170000B4 RID: 180
		' (get) Token: 0x060001F0 RID: 496 RVA: 0x03D889C8 File Offset: 0x03D86DC8
		' (set) Token: 0x060001F1 RID: 497 RVA: 0x03D889E0 File Offset: 0x03D86DE0
		Friend Property PictureBox5 As PictureBox
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

		' Token: 0x170000B5 RID: 181
		' (get) Token: 0x060001F2 RID: 498 RVA: 0x03D889EC File Offset: 0x03D86DEC
		' (set) Token: 0x060001F3 RID: 499 RVA: 0x03D88A04 File Offset: 0x03D86E04
		Friend Property PictureBox6 As PictureBox
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

		' Token: 0x170000B6 RID: 182
		' (get) Token: 0x060001F4 RID: 500 RVA: 0x03D88A10 File Offset: 0x03D86E10
		' (set) Token: 0x060001F5 RID: 501 RVA: 0x03D88A28 File Offset: 0x03D86E28
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

		' Token: 0x060001F6 RID: 502 RVA: 0x03D88A88 File Offset: 0x03D86E88
		Private Sub AboutBox22_Load(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x060001F7 RID: 503 RVA: 0x03D88A94 File Offset: 0x03D86E94
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060001F8 RID: 504 RVA: 0x03D88A98 File Offset: 0x03D86E98
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Dim flag As Boolean = MyProject.Forms.form1Pad.Picture1.Visible
			If flag Then
				Me.PictureBox1.Visible = True
			Else
				flag = MyProject.Forms.form1Pad.Picture2.Visible
				If flag Then
					Me.PictureBox2.Visible = True
					Me.PictureBox1.Visible = False
				Else
					flag = MyProject.Forms.form1Pad.Picture3.Visible
					If flag Then
						Me.PictureBox3.Visible = True
						Me.PictureBox1.Visible = False
					Else
						flag = MyProject.Forms.form1Pad.Picture4.Visible
						If flag Then
							Me.PictureBox4.Visible = True
							Me.PictureBox1.Visible = False
						Else
							flag = MyProject.Forms.form1Pad.Picture5.Visible
							If flag Then
								Me.PictureBox5.Visible = True
								Me.PictureBox1.Visible = False
							Else
								flag = MyProject.Forms.form1Pad.Picture6.Visible
								If flag Then
									Me.PictureBox6.Visible = True
									Me.PictureBox1.Visible = False
									Me.PictureBox6.Image = MyProject.Forms.form1Pad.Picture6.Image
								End If
							End If
						End If
					End If
				End If
			End If
			flag = Me.PictureBox1.Visible
			If Not flag Then
				flag = Me.PictureBox2.Visible
				If Not flag Then
					flag = Me.PictureBox3.Visible
					If Not flag Then
						flag = Me.PictureBox4.Visible
						If Not flag Then
							flag = Me.PictureBox5.Visible
							If Not flag Then
								flag = Me.PictureBox6.Visible
								If Not flag Then
									MyProject.Forms.form1Pad.Show()
									MyProject.Forms.Form33.Close()
									Me.Close()
								End If
							End If
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x040000CC RID: 204
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040000CE RID: 206
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x040000CF RID: 207
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x040000D0 RID: 208
		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		' Token: 0x040000D1 RID: 209
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x040000D2 RID: 210
		<AccessedThroughProperty("PictureBox5")>
		Private _PictureBox5 As PictureBox

		' Token: 0x040000D3 RID: 211
		<AccessedThroughProperty("PictureBox6")>
		Private _PictureBox6 As PictureBox

		' Token: 0x040000D4 RID: 212
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer
	End Class
End Namespace
