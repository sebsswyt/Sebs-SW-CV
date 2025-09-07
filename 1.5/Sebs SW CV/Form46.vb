Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports CV.My
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x0200005D RID: 93
	<DesignerGenerated()>
	Public Partial Class Form46
		Inherits Form

		' Token: 0x06001019 RID: 4121 RVA: 0x03DE45EC File Offset: 0x03DE29EC
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form46_Load
			AddHandler MyBase.CausesValidationChanged, AddressOf Me.Form46_CausesValidationChanged
			AddHandler MyBase.Click, AddressOf Me.Form46_Click
			Dim _ENCList As List(Of WeakReference) = Form46.__ENCList
			SyncLock _ENCList
				Form46.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000551 RID: 1361
		' (get) Token: 0x0600101C RID: 4124 RVA: 0x03DE49F4 File Offset: 0x03DE2DF4
		' (set) Token: 0x0600101D RID: 4125 RVA: 0x03DE4A0C File Offset: 0x03DE2E0C
		Friend Overridable Property SaveFileDialog1 As SaveFileDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._SaveFileDialog1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As SaveFileDialog)
				Dim cancelEventHandler As CancelEventHandler = AddressOf Me.SaveFileDialog1_FileOk
				Dim flag As Boolean = Me._SaveFileDialog1 IsNot Nothing
				If flag Then
					RemoveHandler Me._SaveFileDialog1.FileOk, cancelEventHandler
				End If
				Me._SaveFileDialog1 = value
				flag = Me._SaveFileDialog1 IsNot Nothing
				If flag Then
					AddHandler Me._SaveFileDialog1.FileOk, cancelEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000552 RID: 1362
		' (get) Token: 0x0600101E RID: 4126 RVA: 0x03DE4A6C File Offset: 0x03DE2E6C
		' (set) Token: 0x0600101F RID: 4127 RVA: 0x03DE4A84 File Offset: 0x03DE2E84
		Friend Overridable Property TextBox3 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox3 = value
			End Set
		End Property

		' Token: 0x17000553 RID: 1363
		' (get) Token: 0x06001020 RID: 4128 RVA: 0x03DE4A90 File Offset: 0x03DE2E90
		' (set) Token: 0x06001021 RID: 4129 RVA: 0x03DE4AA8 File Offset: 0x03DE2EA8
		Friend Overridable Property SaveFileDialog2 As SaveFileDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._SaveFileDialog2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As SaveFileDialog)
				Dim cancelEventHandler As CancelEventHandler = AddressOf Me.SaveFileDialog2_FileOk
				Dim flag As Boolean = Me._SaveFileDialog2 IsNot Nothing
				If flag Then
					RemoveHandler Me._SaveFileDialog2.FileOk, cancelEventHandler
				End If
				Me._SaveFileDialog2 = value
				flag = Me._SaveFileDialog2 IsNot Nothing
				If flag Then
					AddHandler Me._SaveFileDialog2.FileOk, cancelEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000554 RID: 1364
		' (get) Token: 0x06001022 RID: 4130 RVA: 0x03DE4B08 File Offset: 0x03DE2F08
		' (set) Token: 0x06001023 RID: 4131 RVA: 0x03DE4B20 File Offset: 0x03DE2F20
		Friend Overridable Property TextBox1 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim eventHandler As EventHandler = AddressOf Me.TextBox1_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.TextBox1_Click
				Dim flag As Boolean = Me._TextBox1 IsNot Nothing
				If flag Then
					RemoveHandler Me._TextBox1.MouseLeave, eventHandler
					RemoveHandler Me._TextBox1.Click, eventHandler2
				End If
				Me._TextBox1 = value
				flag = Me._TextBox1 IsNot Nothing
				If flag Then
					AddHandler Me._TextBox1.MouseLeave, eventHandler
					AddHandler Me._TextBox1.Click, eventHandler2
				End If
			End Set
		End Property

		' Token: 0x17000555 RID: 1365
		' (get) Token: 0x06001024 RID: 4132 RVA: 0x03DE4BA8 File Offset: 0x03DE2FA8
		' (set) Token: 0x06001025 RID: 4133 RVA: 0x03DE4BC0 File Offset: 0x03DE2FC0
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

		' Token: 0x06001026 RID: 4134 RVA: 0x03DE4C20 File Offset: 0x03DE3020
		Private Sub Form46_Load(sender As Object, e As EventArgs)
			Dim flag As Boolean = MyProject.Forms.form1Pad.Picture2.Visible
			If flag Then
				Me.TextBox3.Text = "B-2"
			End If
			flag = MyProject.Forms.form1Pad.Picture3.Visible
			If flag Then
				Me.TextBox3.Text = "B-3"
			End If
			flag = MyProject.Forms.form1Pad.Picture4.Visible
			If flag Then
				Me.TextBox3.Text = "B-4"
			End If
			flag = MyProject.Forms.form1Pad.Picture5.Visible
			If flag Then
				Me.TextBox3.Text = "B-5"
			End If
			flag = MyProject.Forms.form1Pad.Picture6.Visible
			If flag Then
				Me.TextBox3.Text = "B-6"
			End If
			Me.SaveFileDialog1.ShowDialog()
		End Sub

		' Token: 0x06001027 RID: 4135 RVA: 0x03DE4D10 File Offset: 0x03DE3110
		Private Sub SaveFileDialog1_FileOk(sender As Object, e As CancelEventArgs)
			Dim flag As Boolean = MyProject.Forms.form1Pad.Picture1.Visible
			If flag Then
				Me.TextBox3.Text = "B-2"
			End If
			flag = MyProject.Forms.form1Pad.Picture2.Visible
			If flag Then
				Me.TextBox3.Text = "B-2"
			End If
			flag = MyProject.Forms.form1Pad.Picture3.Visible
			If flag Then
				Me.TextBox3.Text = "B-3"
			End If
			flag = MyProject.Forms.form1Pad.Picture4.Visible
			If flag Then
				Me.TextBox3.Text = "B-4"
			End If
			flag = MyProject.Forms.form1Pad.Picture5.Visible
			If flag Then
				Me.TextBox3.Text = "B-5"
			End If
			flag = MyProject.Forms.form1Pad.Picture6.Visible
			If flag Then
				Me.TextBox3.Text = "B-6"
				Interaction.MsgBox("Type the Path to the Picture", MsgBoxStyle.OkOnly, Nothing)
			End If
			MyProject.Computer.FileSystem.WriteAllText(Me.SaveFileDialog1.FileName, Me.TextBox3.Text, False)
		End Sub

		' Token: 0x06001028 RID: 4136 RVA: 0x03DE4E50 File Offset: 0x03DE3250
		Private Sub TextBox1_Click(sender As Object, e As EventArgs)
			Me.TextBox1.Text = ""
		End Sub

		' Token: 0x06001029 RID: 4137 RVA: 0x03DE4E68 File Offset: 0x03DE3268
		Private Sub TextBox1_MouseLeave(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600102A RID: 4138 RVA: 0x03DE4E6C File Offset: 0x03DE326C
		Private Sub Form46_CausesValidationChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600102B RID: 4139 RVA: 0x03DE4E70 File Offset: 0x03DE3270
		Private Sub Form46_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.TextBox1.Text, "13213", False) = 0
			If flag Then
				Me.TextBox1.Text = "C:\User\(Your Username)\Pictures\"
			End If
		End Sub

		' Token: 0x0600102C RID: 4140 RVA: 0x03DE4EB0 File Offset: 0x03DE32B0
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.SaveFileDialog2.ShowDialog()
		End Sub

		' Token: 0x0600102D RID: 4141 RVA: 0x03DE4EC0 File Offset: 0x03DE32C0
		Private Sub SaveFileDialog2_FileOk(sender As Object, e As CancelEventArgs)
			MyProject.Computer.FileSystem.WriteAllText(Me.SaveFileDialog1.FileName, Me.TextBox1.Text, False)
		End Sub

		' Token: 0x040005F3 RID: 1523
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040005F5 RID: 1525
		<AccessedThroughProperty("SaveFileDialog1")>
		Private _SaveFileDialog1 As SaveFileDialog

		' Token: 0x040005F6 RID: 1526
		<AccessedThroughProperty("TextBox3")>
		Private _TextBox3 As TextBox

		' Token: 0x040005F7 RID: 1527
		<AccessedThroughProperty("SaveFileDialog2")>
		Private _SaveFileDialog2 As SaveFileDialog

		' Token: 0x040005F8 RID: 1528
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x040005F9 RID: 1529
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button
	End Class
End Namespace
