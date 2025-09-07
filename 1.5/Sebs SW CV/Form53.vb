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
	' Token: 0x02000065 RID: 101
	<DesignerGenerated()>
	Public Partial Class Form53
		Inherits Form

		' Token: 0x06001108 RID: 4360 RVA: 0x03DEAAD8 File Offset: 0x03DE8ED8
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Form53.__ENCList
			SyncLock _ENCList
				Form53.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700059A RID: 1434
		' (get) Token: 0x0600110B RID: 4363 RVA: 0x03DEB288 File Offset: 0x03DE9688
		' (set) Token: 0x0600110C RID: 4364 RVA: 0x03DEB2A0 File Offset: 0x03DE96A0
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

		' Token: 0x1700059B RID: 1435
		' (get) Token: 0x0600110D RID: 4365 RVA: 0x03DEB2AC File Offset: 0x03DE96AC
		' (set) Token: 0x0600110E RID: 4366 RVA: 0x03DEB2C4 File Offset: 0x03DE96C4
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

		' Token: 0x1700059C RID: 1436
		' (get) Token: 0x0600110F RID: 4367 RVA: 0x03DEB324 File Offset: 0x03DE9724
		' (set) Token: 0x06001110 RID: 4368 RVA: 0x03DEB33C File Offset: 0x03DE973C
		Friend Overridable Property SaveFileDialog1 As SaveFileDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._SaveFileDialog1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As SaveFileDialog)
				Me._SaveFileDialog1 = value
			End Set
		End Property

		' Token: 0x1700059D RID: 1437
		' (get) Token: 0x06001111 RID: 4369 RVA: 0x03DEB348 File Offset: 0x03DE9748
		' (set) Token: 0x06001112 RID: 4370 RVA: 0x03DEB360 File Offset: 0x03DE9760
		Friend Overridable Property OpenFileDialog1 As OpenFileDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenFileDialog1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As OpenFileDialog)
				Me._OpenFileDialog1 = value
			End Set
		End Property

		' Token: 0x1700059E RID: 1438
		' (get) Token: 0x06001113 RID: 4371 RVA: 0x03DEB36C File Offset: 0x03DE976C
		' (set) Token: 0x06001114 RID: 4372 RVA: 0x03DEB384 File Offset: 0x03DE9784
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

		' Token: 0x1700059F RID: 1439
		' (get) Token: 0x06001115 RID: 4373 RVA: 0x03DEB3E4 File Offset: 0x03DE97E4
		' (set) Token: 0x06001116 RID: 4374 RVA: 0x03DEB3FC File Offset: 0x03DE97FC
		Friend Overridable Property GroupBox1 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox1 = value
			End Set
		End Property

		' Token: 0x170005A0 RID: 1440
		' (get) Token: 0x06001117 RID: 4375 RVA: 0x03DEB408 File Offset: 0x03DE9808
		' (set) Token: 0x06001118 RID: 4376 RVA: 0x03DEB420 File Offset: 0x03DE9820
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

		' Token: 0x170005A1 RID: 1441
		' (get) Token: 0x06001119 RID: 4377 RVA: 0x03DEB480 File Offset: 0x03DE9880
		' (set) Token: 0x0600111A RID: 4378 RVA: 0x03DEB498 File Offset: 0x03DE9898
		Friend Overridable Property GroupBox2 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Dim eventHandler As EventHandler = AddressOf Me.GroupBox2_LocationChanged
				Dim flag As Boolean = Me._GroupBox2 IsNot Nothing
				If flag Then
					RemoveHandler Me._GroupBox2.LocationChanged, eventHandler
				End If
				Me._GroupBox2 = value
				flag = Me._GroupBox2 IsNot Nothing
				If flag Then
					AddHandler Me._GroupBox2.LocationChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170005A2 RID: 1442
		' (get) Token: 0x0600111B RID: 4379 RVA: 0x03DEB4F8 File Offset: 0x03DE98F8
		' (set) Token: 0x0600111C RID: 4380 RVA: 0x03DEB510 File Offset: 0x03DE9910
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

		' Token: 0x170005A3 RID: 1443
		' (get) Token: 0x0600111D RID: 4381 RVA: 0x03DEB51C File Offset: 0x03DE991C
		' (set) Token: 0x0600111E RID: 4382 RVA: 0x03DEB534 File Offset: 0x03DE9934
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

		' Token: 0x170005A4 RID: 1444
		' (get) Token: 0x0600111F RID: 4383 RVA: 0x03DEB594 File Offset: 0x03DE9994
		' (set) Token: 0x06001120 RID: 4384 RVA: 0x03DEB5AC File Offset: 0x03DE99AC
		Friend Overridable Property TextBox2 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox2 = value
			End Set
		End Property

		' Token: 0x170005A5 RID: 1445
		' (get) Token: 0x06001121 RID: 4385 RVA: 0x03DEB5B8 File Offset: 0x03DE99B8
		' (set) Token: 0x06001122 RID: 4386 RVA: 0x03DEB5D0 File Offset: 0x03DE99D0
		Friend Overridable Property RichTextBox1 As RichTextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._RichTextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Me._RichTextBox1 = value
			End Set
		End Property

		' Token: 0x06001123 RID: 4387 RVA: 0x03DEB5DC File Offset: 0x03DE99DC
		Private Sub Button6_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Interaction.MsgBox("please Log on to Sebs SW CV", MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.No
			If flag Then
				Me.Close()
			End If
		End Sub

		' Token: 0x06001124 RID: 4388 RVA: 0x03DEB608 File Offset: 0x03DE9A08
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.SaveFileDialog1.ShowDialog() = DialogResult.OK
			If flag Then
				MyProject.Computer.FileSystem.WriteAllText(Me.SaveFileDialog1.FileName, Me.TextBox1.Text, False)
			End If
		End Sub

		' Token: 0x06001125 RID: 4389 RVA: 0x03DEB654 File Offset: 0x03DE9A54
		Private Sub GroupBox2_LocationChanged(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-expression
			For i As Integer = 0 To Me.RichTextBox1.Text.LastIndexOf(Me.TextBox1.Text) - 1
				Me.RichTextBox1.Find(Me.TextBox1.Text, i, Me.RichTextBox1.TextLength, RichTextBoxFinds.None)
				Me.RichTextBox1.SelectionBackColor = Color.Blue
			Next
		End Sub

		' Token: 0x06001126 RID: 4390 RVA: 0x03DEB6E0 File Offset: 0x03DE9AE0
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.FormBorderStyle = FormBorderStyle.None
			If flag Then
				Me.Panel1.Visible = True
			Else
				Me.Panel1.Visible = False
			End If
		End Sub

		' Token: 0x06001127 RID: 4391 RVA: 0x03DEB71C File Offset: 0x03DE9B1C
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Me.FormBorderStyle = FormBorderStyle.Sizable
		End Sub

		' Token: 0x0400064E RID: 1614
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000650 RID: 1616
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x04000651 RID: 1617
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x04000652 RID: 1618
		<AccessedThroughProperty("SaveFileDialog1")>
		Private _SaveFileDialog1 As SaveFileDialog

		' Token: 0x04000653 RID: 1619
		<AccessedThroughProperty("OpenFileDialog1")>
		Private _OpenFileDialog1 As OpenFileDialog

		' Token: 0x04000654 RID: 1620
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x04000655 RID: 1621
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x04000656 RID: 1622
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000657 RID: 1623
		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		' Token: 0x04000658 RID: 1624
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x04000659 RID: 1625
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x0400065A RID: 1626
		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		' Token: 0x0400065B RID: 1627
		<AccessedThroughProperty("RichTextBox1")>
		Private _RichTextBox1 As RichTextBox
	End Class
End Namespace
