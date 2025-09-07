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
	' Token: 0x02000049 RID: 73
	<DesignerGenerated()>
	Public Partial Class Form28
		Inherits Form

		' Token: 0x06000B85 RID: 2949 RVA: 0x03DC54F8 File Offset: 0x03DC38F8
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form28_Load
			AddHandler MyBase.FormClosing, AddressOf Me.Form28_FormClosing
			Dim _ENCList As List(Of WeakReference) = Form28.__ENCList
			SyncLock _ENCList
				Form28.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170003CE RID: 974
		' (get) Token: 0x06000B88 RID: 2952 RVA: 0x03DC5898 File Offset: 0x03DC3C98
		' (set) Token: 0x06000B89 RID: 2953 RVA: 0x03DC58B0 File Offset: 0x03DC3CB0
		Friend Overridable Property PictureBox1 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox1_Click
				Dim flag As Boolean = Me._PictureBox1 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox1.Click, eventHandler
				End If
				Me._PictureBox1 = value
				flag = Me._PictureBox1 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox1.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170003CF RID: 975
		' (get) Token: 0x06000B8A RID: 2954 RVA: 0x03DC5910 File Offset: 0x03DC3D10
		' (set) Token: 0x06000B8B RID: 2955 RVA: 0x03DC5928 File Offset: 0x03DC3D28
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

		' Token: 0x170003D0 RID: 976
		' (get) Token: 0x06000B8C RID: 2956 RVA: 0x03DC5988 File Offset: 0x03DC3D88
		' (set) Token: 0x06000B8D RID: 2957 RVA: 0x03DC59A0 File Offset: 0x03DC3DA0
		Friend Overridable Property ProgressBar1 As ProgressBar
			<DebuggerNonUserCode()>
			Get
				Return Me._ProgressBar1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ProgressBar)
				Me._ProgressBar1 = value
			End Set
		End Property

		' Token: 0x170003D1 RID: 977
		' (get) Token: 0x06000B8E RID: 2958 RVA: 0x03DC59AC File Offset: 0x03DC3DAC
		' (set) Token: 0x06000B8F RID: 2959 RVA: 0x03DC59C4 File Offset: 0x03DC3DC4
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

		' Token: 0x06000B90 RID: 2960 RVA: 0x03DC5A24 File Offset: 0x03DC3E24
		Private Sub Form28_Load(sender As Object, e As EventArgs)
			MyProject.Forms.Form27.Close()
			MyProject.Forms.form1Pad.Label7.Text = "ON"
			MyProject.Forms.form1Pad.Close()
		End Sub

		' Token: 0x06000B91 RID: 2961 RVA: 0x03DC5A64 File Offset: 0x03DC3E64
		Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000B92 RID: 2962 RVA: 0x03DC5A68 File Offset: 0x03DC3E68
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar1.Increment(2)
			Dim flag As Boolean = Me.ProgressBar1.Value = 40
			If flag Then
				Me.Timer1.[Stop]()
				Me.Button1.Text = "??? "
			End If
		End Sub

		' Token: 0x06000B93 RID: 2963 RVA: 0x03DC5AB8 File Offset: 0x03DC3EB8
		Private Sub Form28_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Button1.Text, "??? ", False) = 0
			If flag Then
				MyProject.Forms.Form1.Show()
				MyProject.Forms.Form1.Timer3.Start()
			Else
				MyProject.Forms.AboutBox25.Show()
			End If
		End Sub

		' Token: 0x06000B94 RID: 2964 RVA: 0x03DC5B20 File Offset: 0x03DC3F20
		Private Sub Button1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x04000441 RID: 1089
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000443 RID: 1091
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x04000444 RID: 1092
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000445 RID: 1093
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x04000446 RID: 1094
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer
	End Class
End Namespace
