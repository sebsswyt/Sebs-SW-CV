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
	' Token: 0x0200005B RID: 91
	<DesignerGenerated()>
	Public Partial Class Form44
		Inherits Form

		' Token: 0x06000FC8 RID: 4040 RVA: 0x03DE216C File Offset: 0x03DE056C
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form44_Load
			Dim _ENCList As List(Of WeakReference) = Form44.__ENCList
			SyncLock _ENCList
				Form44.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000536 RID: 1334
		' (get) Token: 0x06000FCB RID: 4043 RVA: 0x03DE26E0 File Offset: 0x03DE0AE0
		' (set) Token: 0x06000FCC RID: 4044 RVA: 0x03DE26F8 File Offset: 0x03DE0AF8
		Friend Overridable Property OpenFileDialog1 As OpenFileDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenFileDialog1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As OpenFileDialog)
				Dim cancelEventHandler As CancelEventHandler = AddressOf Me.OpenFileDialog1_FileOk
				Dim flag As Boolean = Me._OpenFileDialog1 IsNot Nothing
				If flag Then
					RemoveHandler Me._OpenFileDialog1.FileOk, cancelEventHandler
				End If
				Me._OpenFileDialog1 = value
				flag = Me._OpenFileDialog1 IsNot Nothing
				If flag Then
					AddHandler Me._OpenFileDialog1.FileOk, cancelEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000537 RID: 1335
		' (get) Token: 0x06000FCD RID: 4045 RVA: 0x03DE2758 File Offset: 0x03DE0B58
		' (set) Token: 0x06000FCE RID: 4046 RVA: 0x03DE2770 File Offset: 0x03DE0B70
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

		' Token: 0x17000538 RID: 1336
		' (get) Token: 0x06000FCF RID: 4047 RVA: 0x03DE277C File Offset: 0x03DE0B7C
		' (set) Token: 0x06000FD0 RID: 4048 RVA: 0x03DE2794 File Offset: 0x03DE0B94
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

		' Token: 0x17000539 RID: 1337
		' (get) Token: 0x06000FD1 RID: 4049 RVA: 0x03DE27F4 File Offset: 0x03DE0BF4
		' (set) Token: 0x06000FD2 RID: 4050 RVA: 0x03DE280C File Offset: 0x03DE0C0C
		Friend Overridable Property OpenFileDialog2 As OpenFileDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenFileDialog2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As OpenFileDialog)
				Dim cancelEventHandler As CancelEventHandler = AddressOf Me.OpenFileDialog2_FileOk
				Dim eventHandler As EventHandler = AddressOf Me.OpenFileDialog2_HelpRequest
				Dim flag As Boolean = Me._OpenFileDialog2 IsNot Nothing
				If flag Then
					RemoveHandler Me._OpenFileDialog2.FileOk, cancelEventHandler
					RemoveHandler Me._OpenFileDialog2.HelpRequest, eventHandler
				End If
				Me._OpenFileDialog2 = value
				flag = Me._OpenFileDialog2 IsNot Nothing
				If flag Then
					AddHandler Me._OpenFileDialog2.FileOk, cancelEventHandler
					AddHandler Me._OpenFileDialog2.HelpRequest, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700053A RID: 1338
		' (get) Token: 0x06000FD3 RID: 4051 RVA: 0x03DE2894 File Offset: 0x03DE0C94
		' (set) Token: 0x06000FD4 RID: 4052 RVA: 0x03DE28AC File Offset: 0x03DE0CAC
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

		' Token: 0x1700053B RID: 1339
		' (get) Token: 0x06000FD5 RID: 4053 RVA: 0x03DE28B8 File Offset: 0x03DE0CB8
		' (set) Token: 0x06000FD6 RID: 4054 RVA: 0x03DE28D0 File Offset: 0x03DE0CD0
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

		' Token: 0x1700053C RID: 1340
		' (get) Token: 0x06000FD7 RID: 4055 RVA: 0x03DE28DC File Offset: 0x03DE0CDC
		' (set) Token: 0x06000FD8 RID: 4056 RVA: 0x03DE28F4 File Offset: 0x03DE0CF4
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

		' Token: 0x1700053D RID: 1341
		' (get) Token: 0x06000FD9 RID: 4057 RVA: 0x03DE2900 File Offset: 0x03DE0D00
		' (set) Token: 0x06000FDA RID: 4058 RVA: 0x03DE2918 File Offset: 0x03DE0D18
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

		' Token: 0x1700053E RID: 1342
		' (get) Token: 0x06000FDB RID: 4059 RVA: 0x03DE2978 File Offset: 0x03DE0D78
		' (set) Token: 0x06000FDC RID: 4060 RVA: 0x03DE2990 File Offset: 0x03DE0D90
		Friend Overridable Property Timer2 As Timer
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

		' Token: 0x06000FDD RID: 4061 RVA: 0x03DE29F0 File Offset: 0x03DE0DF0
		Private Sub Form44_Load(sender As Object, e As EventArgs)
			Me.TextBox3.Text = ""
			Me.TextBox3.Text = ""
			Me.TextBox3.Text = ""
			Me.TextBox3.Text = ""
			Me.TextBox3.Text = ""
			Me.TextBox3.Text = ""
			Me.TextBox3.Text = ""
			Me.Timer1.[Stop]()
			Me.Timer2.[Stop]()
			Dim flag As Boolean = Operators.CompareString(MyProject.Forms.Form31.Button22.Text, "0", False) = 0
			If flag Then
				Me.Timer1.Start()
			End If
			flag = Operators.CompareString(MyProject.Forms.Form31.Button22.Text, "1", False) = 0
			If flag Then
				Me.Timer2.Start()
			End If
		End Sub

		' Token: 0x06000FDE RID: 4062 RVA: 0x03DE2AF4 File Offset: 0x03DE0EF4
		Private Sub OpenFileDialog1_FileOk(sender As Object, e As CancelEventArgs)
			Me.TextBox1.Text = MyProject.Computer.FileSystem.ReadAllText(Me.OpenFileDialog1.FileName)
		End Sub

		' Token: 0x06000FDF RID: 4063 RVA: 0x03DE2B20 File Offset: 0x03DE0F20
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000FE0 RID: 4064 RVA: 0x03DE2B2C File Offset: 0x03DE0F2C
		Private Sub SaveFileDialog1_FileOk(sender As Object, e As CancelEventArgs)
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
		End Sub

		' Token: 0x06000FE1 RID: 4065 RVA: 0x03DE2BBC File Offset: 0x03DE0FBC
		Private Sub OpenFileDialog2_FileOk(sender As Object, e As CancelEventArgs)
			Me.TextBox2.Visible = True
			Me.TextBox2.Text = MyProject.Computer.FileSystem.ReadAllText(Me.OpenFileDialog2.FileName)
			MyProject.Forms.form1Pad.Picture6.Load(Me.TextBox2.Text)
			Me.Close()
		End Sub

		' Token: 0x06000FE2 RID: 4066 RVA: 0x03DE2C28 File Offset: 0x03DE1028
		Private Sub OpenFileDialog2_HelpRequest(sender As Object, e As EventArgs)
			MyProject.Forms.Form15.Show()
			MyProject.Forms.Form15.Close()
			MyProject.Forms.Form15.Show()
			MyProject.Forms.Form15.TextBox1.Text = "Make a text document with Path to the Picture"
		End Sub

		' Token: 0x06000FE3 RID: 4067 RVA: 0x03DE2C84 File Offset: 0x03DE1084
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Me.Timer1.[Stop]()
			Me.OpenFileDialog1.ShowDialog()
			Dim flag As Boolean = Operators.CompareString(Me.TextBox1.Text, "", False) = 0
			If flag Then
				Me.OpenFileDialog1.ShowDialog()
			End If
			flag = Operators.CompareString(Me.TextBox1.Text, "B-2", False) = 0
			If flag Then
				MyProject.Forms.form1Pad.Picture1.Visible = False
				MyProject.Forms.form1Pad.Picture2.Visible = True
			End If
			flag = Operators.CompareString(Me.TextBox1.Text, "B-3", False) = 0
			If flag Then
				MyProject.Forms.form1Pad.Picture1.Visible = False
				MyProject.Forms.form1Pad.Picture3.Visible = True
			End If
			flag = Operators.CompareString(Me.TextBox1.Text, "B-4", False) = 0
			If flag Then
				MyProject.Forms.form1Pad.Picture1.Visible = False
				MyProject.Forms.form1Pad.Picture4.Visible = True
			End If
			flag = Operators.CompareString(Me.TextBox1.Text, "B-5", False) = 0
			If flag Then
				MyProject.Forms.form1Pad.Picture1.Visible = False
				MyProject.Forms.form1Pad.Picture5.Visible = True
			End If
			flag = Operators.CompareString(Me.TextBox1.Text, "B-6", False) = 0
			If flag Then
				MyProject.Forms.form1Pad.Picture1.Visible = False
				MyProject.Forms.form1Pad.Picture6.Visible = True
				MyProject.Forms.Form43.Show()
				flag = MyProject.Forms.Form43.OpenFileDialog1.ShowDialog() = DialogResult.OK
				If flag Then
					MyProject.Forms.form1Pad.Picture1.Visible = False
					MyProject.Forms.form1Pad.Picture2.Visible = False
					MyProject.Forms.form1Pad.Picture3.Visible = False
					MyProject.Forms.form1Pad.Picture4.Visible = False
					MyProject.Forms.form1Pad.Picture5.Visible = False
					MyProject.Forms.form1Pad.Picture6.Visible = True
					MyProject.Forms.form1Pad.Picture6.Load(MyProject.Forms.Form43.OpenFileDialog1.FileName)
					MyProject.Forms.Form43.Close()
					Me.Close()
				End If
			End If
			flag = Operators.CompareString(Me.TextBox1.Text, "B-7" & vbCrLf & "B-7-N" & vbCrLf, False) = 0
			If flag Then
				MyProject.Forms.form1Pad.Picture1.Visible = False
				MyProject.Forms.form1Pad.Picture6.Visible = True
				Me.OpenFileDialog2.ShowDialog()
			End If
			Me.Timer2.[Stop]()
			Me.Timer1.[Stop]()
		End Sub

		' Token: 0x06000FE4 RID: 4068 RVA: 0x03DE2FAC File Offset: 0x03DE13AC
		Private Sub Timer2_Tick(sender As Object, e As EventArgs)
			Me.Timer2.[Stop]()
			Me.Timer2.[Stop]()
		End Sub

		' Token: 0x040005D4 RID: 1492
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040005D6 RID: 1494
		<AccessedThroughProperty("OpenFileDialog1")>
		Private _OpenFileDialog1 As OpenFileDialog

		' Token: 0x040005D7 RID: 1495
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x040005D8 RID: 1496
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040005D9 RID: 1497
		<AccessedThroughProperty("OpenFileDialog2")>
		Private _OpenFileDialog2 As OpenFileDialog

		' Token: 0x040005DA RID: 1498
		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		' Token: 0x040005DB RID: 1499
		<AccessedThroughProperty("TextBox3")>
		Private _TextBox3 As TextBox

		' Token: 0x040005DC RID: 1500
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x040005DD RID: 1501
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x040005DE RID: 1502
		<AccessedThroughProperty("Timer2")>
		Private _Timer2 As Timer
	End Class
End Namespace
