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
	' Token: 0x02000048 RID: 72
	<DesignerGenerated()>
	Public Partial Class Form27
		Inherits Form

		' Token: 0x06000B7B RID: 2939 RVA: 0x03DC5114 File Offset: 0x03DC3514
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form27_Load
			Dim _ENCList As List(Of WeakReference) = Form27.__ENCList
			SyncLock _ENCList
				Form27.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170003CC RID: 972
		' (get) Token: 0x06000B7E RID: 2942 RVA: 0x03DC53B0 File Offset: 0x03DC37B0
		' (set) Token: 0x06000B7F RID: 2943 RVA: 0x03DC53C8 File Offset: 0x03DC37C8
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

		' Token: 0x170003CD RID: 973
		' (get) Token: 0x06000B80 RID: 2944 RVA: 0x03DC53D4 File Offset: 0x03DC37D4
		' (set) Token: 0x06000B81 RID: 2945 RVA: 0x03DC53EC File Offset: 0x03DC37EC
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

		' Token: 0x06000B82 RID: 2946 RVA: 0x03DC544C File Offset: 0x03DC384C
		Private Sub Form27_Load(sender As Object, e As EventArgs)
			Dim visible As Boolean = MyProject.Forms.Form21.Visible
			If visible Then
				Me.Label1.Text = MyProject.Forms.Form21.TextBox2.Text
			End If
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x06000B83 RID: 2947 RVA: 0x03DC5498 File Offset: 0x03DC3898
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Errorbox1.Show()
			MyProject.Forms.Errorbox1.al.Text = "for user Settings"
			MyProject.Forms.Errorbox1.Text = ":) :("
		End Sub

		' Token: 0x0400043D RID: 1085
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400043F RID: 1087
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000440 RID: 1088
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button
	End Class
End Namespace
