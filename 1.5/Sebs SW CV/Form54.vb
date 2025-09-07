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
	' Token: 0x02000066 RID: 102
	<DesignerGenerated()>
	Public Partial Class Form54
		Inherits Form

		' Token: 0x06001129 RID: 4393 RVA: 0x03DEB738 File Offset: 0x03DE9B38
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form54_Load
			Dim _ENCList As List(Of WeakReference) = Form54.__ENCList
			SyncLock _ENCList
				Form54.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170005A6 RID: 1446
		' (get) Token: 0x0600112C RID: 4396 RVA: 0x03DEBA84 File Offset: 0x03DE9E84
		' (set) Token: 0x0600112D RID: 4397 RVA: 0x03DEBA9C File Offset: 0x03DE9E9C
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

		' Token: 0x170005A7 RID: 1447
		' (get) Token: 0x0600112E RID: 4398 RVA: 0x03DEBAA8 File Offset: 0x03DE9EA8
		' (set) Token: 0x0600112F RID: 4399 RVA: 0x03DEBAC0 File Offset: 0x03DE9EC0
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

		' Token: 0x170005A8 RID: 1448
		' (get) Token: 0x06001130 RID: 4400 RVA: 0x03DEBACC File Offset: 0x03DE9ECC
		' (set) Token: 0x06001131 RID: 4401 RVA: 0x03DEBAE4 File Offset: 0x03DE9EE4
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

		' Token: 0x06001132 RID: 4402 RVA: 0x03DEBB44 File Offset: 0x03DE9F44
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Dim flag As Boolean = MyProject.Forms.Form33.ProgressBar3.Value = 5
			If flag Then
				Me.Label1.Text = "Starting up."
			End If
			flag = MyProject.Forms.Form33.ProgressBar3.Value = 10
			If flag Then
				Me.Label1.Text = "Starting up.."
			End If
			flag = MyProject.Forms.Form33.ProgressBar3.Value = 15
			If flag Then
				Me.Label1.Text = "Starting up..."
			End If
			flag = MyProject.Forms.Form33.ProgressBar3.Value = 20
			If flag Then
				Me.Label1.Text = "Starting up.."
			End If
			flag = MyProject.Forms.Form33.ProgressBar3.Value = 25
			If flag Then
				Me.Label1.Text = "Starting up."
			End If
			flag = MyProject.Forms.Form33.ProgressBar3.Value = 30
			If flag Then
				Me.Label1.Text = "Starting up.."
			End If
			flag = MyProject.Forms.Form33.ProgressBar3.Value = 35
			If flag Then
				Me.Label1.Text = "Starting up..."
			End If
			flag = MyProject.Forms.Form33.ProgressBar3.Value = 40
			If flag Then
				Me.Label1.Text = "Starting up.."
			End If
		End Sub

		' Token: 0x06001133 RID: 4403 RVA: 0x03DEBCC4 File Offset: 0x03DEA0C4
		Private Sub Form54_Load(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x0400065C RID: 1628
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400065E RID: 1630
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x0400065F RID: 1631
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000660 RID: 1632
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer
	End Class
End Namespace
