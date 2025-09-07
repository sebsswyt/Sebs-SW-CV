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
	' Token: 0x02000053 RID: 83
	<DesignerGenerated()>
	Public Partial Class Form37
		Inherits Form

		' Token: 0x06000E53 RID: 3667 RVA: 0x03DD810C File Offset: 0x03DD650C
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Form37.__ENCList
			SyncLock _ENCList
				Form37.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170004C1 RID: 1217
		' (get) Token: 0x06000E56 RID: 3670 RVA: 0x03DD8924 File Offset: 0x03DD6D24
		' (set) Token: 0x06000E57 RID: 3671 RVA: 0x03DD893C File Offset: 0x03DD6D3C
		Friend Overridable Property MenuStrip1 As MenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuStrip1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuStrip)
				Me._MenuStrip1 = value
			End Set
		End Property

		' Token: 0x170004C2 RID: 1218
		' (get) Token: 0x06000E58 RID: 3672 RVA: 0x03DD8948 File Offset: 0x03DD6D48
		' (set) Token: 0x06000E59 RID: 3673 RVA: 0x03DD8960 File Offset: 0x03DD6D60
		Friend Overridable Property FileToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FileToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._FileToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x170004C3 RID: 1219
		' (get) Token: 0x06000E5A RID: 3674 RVA: 0x03DD896C File Offset: 0x03DD6D6C
		' (set) Token: 0x06000E5B RID: 3675 RVA: 0x03DD8984 File Offset: 0x03DD6D84
		Friend Overridable Property SaveToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SaveToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._SaveToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x170004C4 RID: 1220
		' (get) Token: 0x06000E5C RID: 3676 RVA: 0x03DD8990 File Offset: 0x03DD6D90
		' (set) Token: 0x06000E5D RID: 3677 RVA: 0x03DD89A8 File Offset: 0x03DD6DA8
		Friend Overridable Property SaveAsToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SaveAsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.SaveAsToolStripMenuItem_Click
				Dim flag As Boolean = Me._SaveAsToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._SaveAsToolStripMenuItem.Click, eventHandler
				End If
				Me._SaveAsToolStripMenuItem = value
				flag = Me._SaveAsToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._SaveAsToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170004C5 RID: 1221
		' (get) Token: 0x06000E5E RID: 3678 RVA: 0x03DD8A08 File Offset: 0x03DD6E08
		' (set) Token: 0x06000E5F RID: 3679 RVA: 0x03DD8A20 File Offset: 0x03DD6E20
		Friend Overridable Property ExitToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ExitToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.ExitToolStripMenuItem_Click
				Dim flag As Boolean = Me._ExitToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._ExitToolStripMenuItem.Click, eventHandler
				End If
				Me._ExitToolStripMenuItem = value
				flag = Me._ExitToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._ExitToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170004C6 RID: 1222
		' (get) Token: 0x06000E60 RID: 3680 RVA: 0x03DD8A80 File Offset: 0x03DD6E80
		' (set) Token: 0x06000E61 RID: 3681 RVA: 0x03DD8A98 File Offset: 0x03DD6E98
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

		' Token: 0x170004C7 RID: 1223
		' (get) Token: 0x06000E62 RID: 3682 RVA: 0x03DD8AA4 File Offset: 0x03DD6EA4
		' (set) Token: 0x06000E63 RID: 3683 RVA: 0x03DD8ABC File Offset: 0x03DD6EBC
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

		' Token: 0x170004C8 RID: 1224
		' (get) Token: 0x06000E64 RID: 3684 RVA: 0x03DD8B1C File Offset: 0x03DD6F1C
		' (set) Token: 0x06000E65 RID: 3685 RVA: 0x03DD8B34 File Offset: 0x03DD6F34
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

		' Token: 0x170004C9 RID: 1225
		' (get) Token: 0x06000E66 RID: 3686 RVA: 0x03DD8B94 File Offset: 0x03DD6F94
		' (set) Token: 0x06000E67 RID: 3687 RVA: 0x03DD8BAC File Offset: 0x03DD6FAC
		Friend Overridable Property OpenFileToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenFileToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.OpenFileToolStripMenuItem_Click
				Dim flag As Boolean = Me._OpenFileToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._OpenFileToolStripMenuItem.Click, eventHandler
				End If
				Me._OpenFileToolStripMenuItem = value
				flag = Me._OpenFileToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._OpenFileToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170004CA RID: 1226
		' (get) Token: 0x06000E68 RID: 3688 RVA: 0x03DD8C0C File Offset: 0x03DD700C
		' (set) Token: 0x06000E69 RID: 3689 RVA: 0x03DD8C24 File Offset: 0x03DD7024
		Friend Overridable Property ToolStripSeparator1 As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripSeparator1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator1 = value
			End Set
		End Property

		' Token: 0x170004CB RID: 1227
		' (get) Token: 0x06000E6A RID: 3690 RVA: 0x03DD8C30 File Offset: 0x03DD7030
		' (set) Token: 0x06000E6B RID: 3691 RVA: 0x03DD8C48 File Offset: 0x03DD7048
		Friend Overridable Property AboutToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._AboutToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._AboutToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x170004CC RID: 1228
		' (get) Token: 0x06000E6C RID: 3692 RVA: 0x03DD8C54 File Offset: 0x03DD7054
		' (set) Token: 0x06000E6D RID: 3693 RVA: 0x03DD8C6C File Offset: 0x03DD706C
		Friend Overridable Property AboutToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._AboutToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.AboutToolStripMenuItem1_Click
				Dim flag As Boolean = Me._AboutToolStripMenuItem1 IsNot Nothing
				If flag Then
					RemoveHandler Me._AboutToolStripMenuItem1.Click, eventHandler
				End If
				Me._AboutToolStripMenuItem1 = value
				flag = Me._AboutToolStripMenuItem1 IsNot Nothing
				If flag Then
					AddHandler Me._AboutToolStripMenuItem1.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170004CD RID: 1229
		' (get) Token: 0x06000E6E RID: 3694 RVA: 0x03DD8CCC File Offset: 0x03DD70CC
		' (set) Token: 0x06000E6F RID: 3695 RVA: 0x03DD8CE4 File Offset: 0x03DD70E4
		Friend Overridable Property EditToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._EditToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._EditToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x170004CE RID: 1230
		' (get) Token: 0x06000E70 RID: 3696 RVA: 0x03DD8CF0 File Offset: 0x03DD70F0
		' (set) Token: 0x06000E71 RID: 3697 RVA: 0x03DD8D08 File Offset: 0x03DD7108
		Friend Overridable Property CutToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CutToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.CutToolStripMenuItem_Click
				Dim flag As Boolean = Me._CutToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._CutToolStripMenuItem.Click, eventHandler
				End If
				Me._CutToolStripMenuItem = value
				flag = Me._CutToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._CutToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170004CF RID: 1231
		' (get) Token: 0x06000E72 RID: 3698 RVA: 0x03DD8D68 File Offset: 0x03DD7168
		' (set) Token: 0x06000E73 RID: 3699 RVA: 0x03DD8D80 File Offset: 0x03DD7180
		Friend Overridable Property CopyToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CopyToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.CopyToolStripMenuItem_Click
				Dim flag As Boolean = Me._CopyToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._CopyToolStripMenuItem.Click, eventHandler
				End If
				Me._CopyToolStripMenuItem = value
				flag = Me._CopyToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._CopyToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170004D0 RID: 1232
		' (get) Token: 0x06000E74 RID: 3700 RVA: 0x03DD8DE0 File Offset: 0x03DD71E0
		' (set) Token: 0x06000E75 RID: 3701 RVA: 0x03DD8DF8 File Offset: 0x03DD71F8
		Friend Overridable Property PasteToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._PasteToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.PasteToolStripMenuItem_Click
				Dim flag As Boolean = Me._PasteToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._PasteToolStripMenuItem.Click, eventHandler
				End If
				Me._PasteToolStripMenuItem = value
				flag = Me._PasteToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._PasteToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170004D1 RID: 1233
		' (get) Token: 0x06000E76 RID: 3702 RVA: 0x03DD8E58 File Offset: 0x03DD7258
		' (set) Token: 0x06000E77 RID: 3703 RVA: 0x03DD8E70 File Offset: 0x03DD7270
		Friend Overridable Property SelectAllToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SelectAllToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.SelectAllToolStripMenuItem_Click
				Dim flag As Boolean = Me._SelectAllToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._SelectAllToolStripMenuItem.Click, eventHandler
				End If
				Me._SelectAllToolStripMenuItem = value
				flag = Me._SelectAllToolStripMenuItem IsNot Nothing
				If flag Then
					AddHandler Me._SelectAllToolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x06000E78 RID: 3704 RVA: 0x03DD8ED0 File Offset: 0x03DD72D0
		Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000E79 RID: 3705 RVA: 0x03DD8EDC File Offset: 0x03DD72DC
		Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.SaveFileDialog1.ShowDialog()
		End Sub

		' Token: 0x06000E7A RID: 3706 RVA: 0x03DD8EEC File Offset: 0x03DD72EC
		Private Sub SaveFileDialog1_FileOk(sender As Object, e As CancelEventArgs)
			MyProject.Computer.FileSystem.WriteAllText(Me.SaveFileDialog1.FileName, Me.TextBox1.Text, False)
		End Sub

		' Token: 0x06000E7B RID: 3707 RVA: 0x03DD8F18 File Offset: 0x03DD7318
		Private Sub OpenFileDialog1_FileOk(sender As Object, e As CancelEventArgs)
			Me.TextBox1.Text = MyProject.Computer.FileSystem.ReadAllText(Me.OpenFileDialog1.FileName)
		End Sub

		' Token: 0x06000E7C RID: 3708 RVA: 0x03DD8F44 File Offset: 0x03DD7344
		Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.OpenFileDialog1.ShowDialog()
		End Sub

		' Token: 0x06000E7D RID: 3709 RVA: 0x03DD8F54 File Offset: 0x03DD7354
		Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox1.Show()
		End Sub

		' Token: 0x06000E7E RID: 3710 RVA: 0x03DD8F68 File Offset: 0x03DD7368
		Private Sub TheWebToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form9.Show()
		End Sub

		' Token: 0x06000E7F RID: 3711 RVA: 0x03DD8F7C File Offset: 0x03DD737C
		Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.TextBox1.Cut()
		End Sub

		' Token: 0x06000E80 RID: 3712 RVA: 0x03DD8F8C File Offset: 0x03DD738C
		Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.TextBox1.Copy()
		End Sub

		' Token: 0x06000E81 RID: 3713 RVA: 0x03DD8F9C File Offset: 0x03DD739C
		Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.TextBox1.Paste()
		End Sub

		' Token: 0x06000E82 RID: 3714 RVA: 0x03DD8FAC File Offset: 0x03DD73AC
		Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.TextBox1.SelectAll()
		End Sub

		' Token: 0x0400054B RID: 1355
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400054D RID: 1357
		<AccessedThroughProperty("MenuStrip1")>
		Private _MenuStrip1 As MenuStrip

		' Token: 0x0400054E RID: 1358
		<AccessedThroughProperty("FileToolStripMenuItem")>
		Private _FileToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400054F RID: 1359
		<AccessedThroughProperty("SaveToolStripMenuItem")>
		Private _SaveToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000550 RID: 1360
		<AccessedThroughProperty("SaveAsToolStripMenuItem")>
		Private _SaveAsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000551 RID: 1361
		<AccessedThroughProperty("ExitToolStripMenuItem")>
		Private _ExitToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000552 RID: 1362
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x04000553 RID: 1363
		<AccessedThroughProperty("OpenFileDialog1")>
		Private _OpenFileDialog1 As OpenFileDialog

		' Token: 0x04000554 RID: 1364
		<AccessedThroughProperty("SaveFileDialog1")>
		Private _SaveFileDialog1 As SaveFileDialog

		' Token: 0x04000555 RID: 1365
		<AccessedThroughProperty("OpenFileToolStripMenuItem")>
		Private _OpenFileToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000556 RID: 1366
		<AccessedThroughProperty("ToolStripSeparator1")>
		Private _ToolStripSeparator1 As ToolStripSeparator

		' Token: 0x04000557 RID: 1367
		<AccessedThroughProperty("AboutToolStripMenuItem")>
		Private _AboutToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000558 RID: 1368
		<AccessedThroughProperty("AboutToolStripMenuItem1")>
		Private _AboutToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x04000559 RID: 1369
		<AccessedThroughProperty("EditToolStripMenuItem")>
		Private _EditToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400055A RID: 1370
		<AccessedThroughProperty("CutToolStripMenuItem")>
		Private _CutToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400055B RID: 1371
		<AccessedThroughProperty("CopyToolStripMenuItem")>
		Private _CopyToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400055C RID: 1372
		<AccessedThroughProperty("PasteToolStripMenuItem")>
		Private _PasteToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400055D RID: 1373
		<AccessedThroughProperty("SelectAllToolStripMenuItem")>
		Private _SelectAllToolStripMenuItem As ToolStripMenuItem
	End Class
End Namespace
