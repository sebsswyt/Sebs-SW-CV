Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports CV.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x0200001A RID: 26
	<DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox24
		Inherits Form

		' Token: 0x06000200 RID: 512 RVA: 0x03D891AC File Offset: 0x03D875AC
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.AboutBox24_Load
			Dim _ENCList As List(Of WeakReference) = AboutBox24.__ENCList
			SyncLock _ENCList
				AboutBox24.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170000B7 RID: 183
		' (get) Token: 0x06000202 RID: 514 RVA: 0x03D89268 File Offset: 0x03D87668
		' (set) Token: 0x06000203 RID: 515 RVA: 0x03D89280 File Offset: 0x03D87680
		Friend Property TableLayoutPanel As TableLayoutPanel
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

		' Token: 0x170000B8 RID: 184
		' (get) Token: 0x06000204 RID: 516 RVA: 0x03D8928C File Offset: 0x03D8768C
		' (set) Token: 0x06000205 RID: 517 RVA: 0x03D892A4 File Offset: 0x03D876A4
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

		' Token: 0x170000B9 RID: 185
		' (get) Token: 0x06000206 RID: 518 RVA: 0x03D892B0 File Offset: 0x03D876B0
		' (set) Token: 0x06000207 RID: 519 RVA: 0x03D892C8 File Offset: 0x03D876C8
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

		' Token: 0x170000BA RID: 186
		' (get) Token: 0x06000208 RID: 520 RVA: 0x03D892D4 File Offset: 0x03D876D4
		' (set) Token: 0x06000209 RID: 521 RVA: 0x03D892EC File Offset: 0x03D876EC
		Friend Property LabelVersion As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._LabelVersion
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._LabelVersion = value
			End Set
		End Property

		' Token: 0x170000BB RID: 187
		' (get) Token: 0x0600020A RID: 522 RVA: 0x03D892F8 File Offset: 0x03D876F8
		' (set) Token: 0x0600020B RID: 523 RVA: 0x03D89310 File Offset: 0x03D87710
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

		' Token: 0x170000BC RID: 188
		' (get) Token: 0x0600020C RID: 524 RVA: 0x03D8931C File Offset: 0x03D8771C
		' (set) Token: 0x0600020D RID: 525 RVA: 0x03D89334 File Offset: 0x03D87734
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

		' Token: 0x170000BD RID: 189
		' (get) Token: 0x0600020E RID: 526 RVA: 0x03D89340 File Offset: 0x03D87740
		' (set) Token: 0x0600020F RID: 527 RVA: 0x03D89358 File Offset: 0x03D87758
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

		' Token: 0x170000BE RID: 190
		' (get) Token: 0x06000210 RID: 528 RVA: 0x03D893B8 File Offset: 0x03D877B8
		' (set) Token: 0x06000211 RID: 529 RVA: 0x03D893D0 File Offset: 0x03D877D0
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

		' Token: 0x06000213 RID: 531 RVA: 0x03D89C1C File Offset: 0x03D8801C
		Private Sub AboutBox24_Load(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(MyProject.Application.Info.Title, "", False) <> 0
			Dim text As String
			If flag Then
				text = MyProject.Application.Info.Title
			Else
				text = Path.GetFileNameWithoutExtension(MyProject.Application.Info.AssemblyName)
			End If
			Me.Text = String.Format("About {0}", text)
			Me.LabelProductName.Text = MyProject.Application.Info.ProductName
			Me.LabelVersion.Text = String.Format("Version {0}", MyProject.Application.Info.Version.ToString())
			Me.LabelCopyright.Text = MyProject.Application.Info.Copyright
			Me.LabelCompanyName.Text = MyProject.Application.Info.CompanyName
			Me.TextBoxDescription.Text = MyProject.Application.Info.Description
		End Sub

		' Token: 0x06000214 RID: 532 RVA: 0x03D89D20 File Offset: 0x03D88120
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x040000D7 RID: 215
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040000D8 RID: 216
		<AccessedThroughProperty("TableLayoutPanel")>
		Private _TableLayoutPanel As TableLayoutPanel

		' Token: 0x040000D9 RID: 217
		<AccessedThroughProperty("LogoPictureBox")>
		Private _LogoPictureBox As PictureBox

		' Token: 0x040000DA RID: 218
		<AccessedThroughProperty("LabelProductName")>
		Private _LabelProductName As Label

		' Token: 0x040000DB RID: 219
		<AccessedThroughProperty("LabelVersion")>
		Private _LabelVersion As Label

		' Token: 0x040000DC RID: 220
		<AccessedThroughProperty("LabelCompanyName")>
		Private _LabelCompanyName As Label

		' Token: 0x040000DD RID: 221
		<AccessedThroughProperty("TextBoxDescription")>
		Private _TextBoxDescription As TextBox

		' Token: 0x040000DE RID: 222
		<AccessedThroughProperty("OKButton")>
		Private _OKButton As Button

		' Token: 0x040000DF RID: 223
		<AccessedThroughProperty("LabelCopyright")>
		Private _LabelCopyright As Label
	End Class
End Namespace
