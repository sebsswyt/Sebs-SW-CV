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
	' Token: 0x0200001D RID: 29
	<DesignerGenerated()>
	Public NotInheritable Partial Class backgroundBox1
		Inherits Form

		' Token: 0x06000233 RID: 563 RVA: 0x03D8A698 File Offset: 0x03D88A98
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.AboutBox4_Load
			Dim _ENCList As List(Of WeakReference) = backgroundBox1.__ENCList
			SyncLock _ENCList
				backgroundBox1.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170000C5 RID: 197
		' (get) Token: 0x06000236 RID: 566 RVA: 0x03D8AE88 File Offset: 0x03D89288
		' (set) Token: 0x06000237 RID: 567 RVA: 0x03D8AEA0 File Offset: 0x03D892A0
		Friend Property Panel2 As Panel
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

		' Token: 0x170000C6 RID: 198
		' (get) Token: 0x06000238 RID: 568 RVA: 0x03D8AEAC File Offset: 0x03D892AC
		' (set) Token: 0x06000239 RID: 569 RVA: 0x03D8AEC4 File Offset: 0x03D892C4
		Friend Property Button6 As Button
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

		' Token: 0x170000C7 RID: 199
		' (get) Token: 0x0600023A RID: 570 RVA: 0x03D8AF24 File Offset: 0x03D89324
		' (set) Token: 0x0600023B RID: 571 RVA: 0x03D8AF3C File Offset: 0x03D8933C
		Friend Property Button8 As Button
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

		' Token: 0x170000C8 RID: 200
		' (get) Token: 0x0600023C RID: 572 RVA: 0x03D8AF9C File Offset: 0x03D8939C
		' (set) Token: 0x0600023D RID: 573 RVA: 0x03D8AFB4 File Offset: 0x03D893B4
		Friend Property Button9 As Button
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

		' Token: 0x170000C9 RID: 201
		' (get) Token: 0x0600023E RID: 574 RVA: 0x03D8B014 File Offset: 0x03D89414
		' (set) Token: 0x0600023F RID: 575 RVA: 0x03D8B02C File Offset: 0x03D8942C
		Friend Property Button10 As Button
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

		' Token: 0x170000CA RID: 202
		' (get) Token: 0x06000240 RID: 576 RVA: 0x03D8B08C File Offset: 0x03D8948C
		' (set) Token: 0x06000241 RID: 577 RVA: 0x03D8B0A4 File Offset: 0x03D894A4
		Friend Property Button11 As Button
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

		' Token: 0x170000CB RID: 203
		' (get) Token: 0x06000242 RID: 578 RVA: 0x03D8B104 File Offset: 0x03D89504
		' (set) Token: 0x06000243 RID: 579 RVA: 0x03D8B11C File Offset: 0x03D8951C
		Friend Property Button18 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button18
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button18_Click
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

		' Token: 0x170000CC RID: 204
		' (get) Token: 0x06000244 RID: 580 RVA: 0x03D8B17C File Offset: 0x03D8957C
		' (set) Token: 0x06000245 RID: 581 RVA: 0x03D8B194 File Offset: 0x03D89594
		Friend Property Button19 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button19
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button19_Click
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

		' Token: 0x170000CD RID: 205
		' (get) Token: 0x06000246 RID: 582 RVA: 0x03D8B1F4 File Offset: 0x03D895F4
		' (set) Token: 0x06000247 RID: 583 RVA: 0x03D8B20C File Offset: 0x03D8960C
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

		' Token: 0x170000CE RID: 206
		' (get) Token: 0x06000248 RID: 584 RVA: 0x03D8B26C File Offset: 0x03D8966C
		' (set) Token: 0x06000249 RID: 585 RVA: 0x03D8B284 File Offset: 0x03D89684
		Friend Property Button2 As Button
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

		' Token: 0x170000CF RID: 207
		' (get) Token: 0x0600024A RID: 586 RVA: 0x03D8B2E4 File Offset: 0x03D896E4
		' (set) Token: 0x0600024B RID: 587 RVA: 0x03D8B2FC File Offset: 0x03D896FC
		Friend Property Button3 As Button
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

		' Token: 0x0600024C RID: 588 RVA: 0x03D8B35C File Offset: 0x03D8975C
		Private Sub AboutBox4_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600024D RID: 589 RVA: 0x03D8B360 File Offset: 0x03D89760
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600024E RID: 590 RVA: 0x03D8B364 File Offset: 0x03D89764
		Private Sub Button18_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.PictureBox2.Visible = True
			MyProject.Forms.Form1.PictureBox3.Visible = False
			MyProject.Forms.Form1.PictureBox4.Visible = False
			MyProject.Forms.Form1.PictureBox5.Visible = False
			MyProject.Forms.Form1.PictureBox6.Visible = False
			MyProject.Forms.Form1.PictureBox7.Visible = False
			MyProject.Forms.Form1.PictureBox8.Visible = False
			MyProject.Forms.Form1.PictureBox9.Visible = False
		End Sub

		' Token: 0x0600024F RID: 591 RVA: 0x03D8B424 File Offset: 0x03D89824
		Private Sub Button11_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.PictureBox2.Visible = False
			MyProject.Forms.Form1.PictureBox3.Visible = True
			MyProject.Forms.Form1.PictureBox4.Visible = False
			MyProject.Forms.Form1.PictureBox5.Visible = False
			MyProject.Forms.Form1.PictureBox6.Visible = False
			MyProject.Forms.Form1.PictureBox7.Visible = False
			MyProject.Forms.Form1.PictureBox8.Visible = False
			MyProject.Forms.Form1.PictureBox9.Visible = False
		End Sub

		' Token: 0x06000250 RID: 592 RVA: 0x03D8B4E4 File Offset: 0x03D898E4
		Private Sub Button8_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.PictureBox2.Visible = False
			MyProject.Forms.Form1.PictureBox3.Visible = False
			MyProject.Forms.Form1.PictureBox4.Visible = True
			MyProject.Forms.Form1.PictureBox5.Visible = False
			MyProject.Forms.Form1.PictureBox6.Visible = False
			MyProject.Forms.Form1.PictureBox7.Visible = False
			MyProject.Forms.Form1.PictureBox8.Visible = False
			MyProject.Forms.Form1.PictureBox9.Visible = False
		End Sub

		' Token: 0x06000251 RID: 593 RVA: 0x03D8B5A4 File Offset: 0x03D899A4
		Private Sub Button9_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000252 RID: 594 RVA: 0x03D8B5B0 File Offset: 0x03D899B0
		Private Sub Button19_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.PictureBox2.Visible = False
			MyProject.Forms.Form1.PictureBox3.Visible = False
			MyProject.Forms.Form1.PictureBox4.Visible = False
			MyProject.Forms.Form1.PictureBox5.Visible = True
			MyProject.Forms.Form1.PictureBox6.Visible = False
			MyProject.Forms.Form1.PictureBox7.Visible = False
			MyProject.Forms.Form1.PictureBox8.Visible = False
			MyProject.Forms.Form1.PictureBox9.Visible = False
		End Sub

		' Token: 0x06000253 RID: 595 RVA: 0x03D8B670 File Offset: 0x03D89A70
		Private Sub Button10_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.PictureBox2.Visible = False
			MyProject.Forms.Form1.PictureBox3.Visible = False
			MyProject.Forms.Form1.PictureBox4.Visible = False
			MyProject.Forms.Form1.PictureBox5.Visible = False
			MyProject.Forms.Form1.PictureBox6.Visible = True
			MyProject.Forms.Form1.PictureBox7.Visible = False
			MyProject.Forms.Form1.PictureBox8.Visible = False
			MyProject.Forms.Form1.PictureBox9.Visible = False
		End Sub

		' Token: 0x06000254 RID: 596 RVA: 0x03D8B730 File Offset: 0x03D89B30
		Private Sub Button6_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.PictureBox2.Visible = False
			MyProject.Forms.Form1.PictureBox3.Visible = False
			MyProject.Forms.Form1.PictureBox4.Visible = False
			MyProject.Forms.Form1.PictureBox5.Visible = False
			MyProject.Forms.Form1.PictureBox6.Visible = False
			MyProject.Forms.Form1.PictureBox7.Visible = True
			MyProject.Forms.Form1.PictureBox8.Visible = False
			MyProject.Forms.Form1.PictureBox9.Visible = False
		End Sub

		' Token: 0x06000255 RID: 597 RVA: 0x03D8B7F0 File Offset: 0x03D89BF0
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.PictureBox2.Visible = False
			MyProject.Forms.Form1.PictureBox3.Visible = False
			MyProject.Forms.Form1.PictureBox4.Visible = False
			MyProject.Forms.Form1.PictureBox5.Visible = False
			MyProject.Forms.Form1.PictureBox6.Visible = False
			MyProject.Forms.Form1.PictureBox7.Visible = False
			MyProject.Forms.Form1.PictureBox8.Visible = True
			MyProject.Forms.Form1.PictureBox9.Visible = False
		End Sub

		' Token: 0x06000256 RID: 598 RVA: 0x03D8B8B0 File Offset: 0x03D89CB0
		Private Sub Button2_Click(sender As Object, e As EventArgs)
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
			Me.Close()
			MyProject.Forms.Form2.Close()
			MyProject.Forms.Form3.Close()
			MyProject.Forms.Form4.Close()
			MyProject.Forms.Form5.Close()
			MyProject.Forms.Form6.Close()
			MyProject.Forms.Form7.Close()
			MyProject.Forms.Form8.Close()
			MyProject.Forms.Form9.Close()
			MyProject.Forms.Form10.Close()
			MyProject.Forms.Form11.Close()
			MyProject.Forms.Form13.Close()
			MyProject.Forms.Form14.Close()
			MyProject.Forms.Form1.Panel2.Visible = True
		End Sub

		' Token: 0x06000257 RID: 599 RVA: 0x03D8BAE8 File Offset: 0x03D89EE8
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.PictureBox2.Visible = False
			MyProject.Forms.Form1.PictureBox3.Visible = False
			MyProject.Forms.Form1.PictureBox4.Visible = False
			MyProject.Forms.Form1.PictureBox5.Visible = False
			MyProject.Forms.Form1.PictureBox6.Visible = False
			MyProject.Forms.Form1.PictureBox7.Visible = False
			MyProject.Forms.Form1.PictureBox8.Visible = False
			MyProject.Forms.Form1.PictureBox9.Visible = True
		End Sub

		' Token: 0x040000EB RID: 235
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040000ED RID: 237
		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel

		' Token: 0x040000EE RID: 238
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x040000EF RID: 239
		<AccessedThroughProperty("Button8")>
		Private _Button8 As Button

		' Token: 0x040000F0 RID: 240
		<AccessedThroughProperty("Button9")>
		Private _Button9 As Button

		' Token: 0x040000F1 RID: 241
		<AccessedThroughProperty("Button10")>
		Private _Button10 As Button

		' Token: 0x040000F2 RID: 242
		<AccessedThroughProperty("Button11")>
		Private _Button11 As Button

		' Token: 0x040000F3 RID: 243
		<AccessedThroughProperty("Button18")>
		Private _Button18 As Button

		' Token: 0x040000F4 RID: 244
		<AccessedThroughProperty("Button19")>
		Private _Button19 As Button

		' Token: 0x040000F5 RID: 245
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040000F6 RID: 246
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x040000F7 RID: 247
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button
	End Class
End Namespace
