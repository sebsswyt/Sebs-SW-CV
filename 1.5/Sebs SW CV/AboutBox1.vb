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
	' Token: 0x0200000A RID: 10
	<DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox1
		Inherits Form

		' Token: 0x060000EF RID: 239 RVA: 0x03D81D7C File Offset: 0x03D8017C
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.AboutBox1_Load
			Dim _ENCList As List(Of WeakReference) = AboutBox1.__ENCList
			SyncLock _ENCList
				AboutBox1.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700006B RID: 107
		' (get) Token: 0x060000F1 RID: 241 RVA: 0x03D81E38 File Offset: 0x03D80238
		' (set) Token: 0x060000F2 RID: 242 RVA: 0x03D81E50 File Offset: 0x03D80250
		Friend Property TableLayoutPanel As TableLayoutPanel
			<DebuggerNonUserCode()>
			Get
				Return Me._TableLayoutPanel
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TableLayoutPanel)
				Dim paintEventHandler As PaintEventHandler = AddressOf Me.TableLayoutPanel_Paint
				Dim flag As Boolean = Me._TableLayoutPanel IsNot Nothing
				If flag Then
					RemoveHandler Me._TableLayoutPanel.Paint, paintEventHandler
				End If
				Me._TableLayoutPanel = value
				flag = Me._TableLayoutPanel IsNot Nothing
				If flag Then
					AddHandler Me._TableLayoutPanel.Paint, paintEventHandler
				End If
			End Set
		End Property

		' Token: 0x1700006C RID: 108
		' (get) Token: 0x060000F3 RID: 243 RVA: 0x03D81EB0 File Offset: 0x03D802B0
		' (set) Token: 0x060000F4 RID: 244 RVA: 0x03D81EC8 File Offset: 0x03D802C8
		Friend Property LogoPictureBox As PictureBox
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

		' Token: 0x1700006D RID: 109
		' (get) Token: 0x060000F5 RID: 245 RVA: 0x03D81ED4 File Offset: 0x03D802D4
		' (set) Token: 0x060000F6 RID: 246 RVA: 0x03D81EEC File Offset: 0x03D802EC
		Friend Property LabelProductName As Label
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

		' Token: 0x1700006E RID: 110
		' (get) Token: 0x060000F7 RID: 247 RVA: 0x03D81EF8 File Offset: 0x03D802F8
		' (set) Token: 0x060000F8 RID: 248 RVA: 0x03D81F10 File Offset: 0x03D80310
		Friend Property LabelVersion As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._LabelVersion
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim eventHandler As EventHandler = AddressOf Me.LabelVersion_Click
				Dim flag As Boolean = Me._LabelVersion IsNot Nothing
				If flag Then
					RemoveHandler Me._LabelVersion.Click, eventHandler
				End If
				Me._LabelVersion = value
				flag = Me._LabelVersion IsNot Nothing
				If flag Then
					AddHandler Me._LabelVersion.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700006F RID: 111
		' (get) Token: 0x060000F9 RID: 249 RVA: 0x03D81F70 File Offset: 0x03D80370
		' (set) Token: 0x060000FA RID: 250 RVA: 0x03D81F88 File Offset: 0x03D80388
		Friend Property LabelCompanyName As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._LabelCompanyName
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._LabelCompanyName = value
			End Set
		End Property

		' Token: 0x17000070 RID: 112
		' (get) Token: 0x060000FB RID: 251 RVA: 0x03D81F94 File Offset: 0x03D80394
		' (set) Token: 0x060000FC RID: 252 RVA: 0x03D81FAC File Offset: 0x03D803AC
		Friend Property TextBoxDescription As TextBox
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

		' Token: 0x17000071 RID: 113
		' (get) Token: 0x060000FD RID: 253 RVA: 0x03D81FB8 File Offset: 0x03D803B8
		' (set) Token: 0x060000FE RID: 254 RVA: 0x03D81FD0 File Offset: 0x03D803D0
		Friend Property OKButton As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._OKButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.OKButton_Click
				Dim flag As Boolean = Me._OKButton IsNot Nothing
				If flag Then
					RemoveHandler Me._OKButton.Click, eventHandler
				End If
				Me._OKButton = value
				flag = Me._OKButton IsNot Nothing
				If flag Then
					AddHandler Me._OKButton.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000072 RID: 114
		' (get) Token: 0x060000FF RID: 255 RVA: 0x03D82030 File Offset: 0x03D80430
		' (set) Token: 0x06000100 RID: 256 RVA: 0x03D82048 File Offset: 0x03D80448
		Friend Property LabelCopyright As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._LabelCopyright
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._LabelCopyright = value
			End Set
		End Property

		' Token: 0x06000102 RID: 258 RVA: 0x03D829B4 File Offset: 0x03D80DB4
		Private Sub AboutBox1_Load(sender As Object, e As EventArgs)
			Me.LabelVersion.Text = String.Format("Version {0}", MyProject.Application.Info.Version.ToString())
		End Sub

		' Token: 0x06000103 RID: 259 RVA: 0x03D829E4 File Offset: 0x03D80DE4
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = MyProject.Forms.Form20.ProgressBar1.Value = 100
			If flag Then
				MyProject.Forms.Form8.Show()
			End If
			Me.Close()
			flag = MyProject.Forms.Form28.PictureBox1.Visible
			If flag Then
				MyProject.Forms.AboutBox20.Show()
			End If
		End Sub

		' Token: 0x06000104 RID: 260 RVA: 0x03D82A50 File Offset: 0x03D80E50
		Private Sub TableLayoutPanel_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x06000105 RID: 261 RVA: 0x03D82A54 File Offset: 0x03D80E54
		Private Sub LabelVersion_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0400006B RID: 107
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400006C RID: 108
		<AccessedThroughProperty("TableLayoutPanel")>
		Private _TableLayoutPanel As TableLayoutPanel

		' Token: 0x0400006D RID: 109
		<AccessedThroughProperty("LogoPictureBox")>
		Private _LogoPictureBox As PictureBox

		' Token: 0x0400006E RID: 110
		<AccessedThroughProperty("LabelProductName")>
		Private _LabelProductName As Label

		' Token: 0x0400006F RID: 111
		<AccessedThroughProperty("LabelVersion")>
		Private _LabelVersion As Label

		' Token: 0x04000070 RID: 112
		<AccessedThroughProperty("LabelCompanyName")>
		Private _LabelCompanyName As Label

		' Token: 0x04000071 RID: 113
		<AccessedThroughProperty("TextBoxDescription")>
		Private _TextBoxDescription As TextBox

		' Token: 0x04000072 RID: 114
		<AccessedThroughProperty("OKButton")>
		Private _OKButton As Button

		' Token: 0x04000073 RID: 115
		<AccessedThroughProperty("LabelCopyright")>
		Private _LabelCopyright As Label
	End Class
End Namespace
