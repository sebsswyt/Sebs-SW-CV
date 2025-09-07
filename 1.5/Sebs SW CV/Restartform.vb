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
	' Token: 0x0200000B RID: 11
	<DesignerGenerated()>
	Public NotInheritable Partial Class Restartform
		Inherits Form

		' Token: 0x06000107 RID: 263 RVA: 0x03D82A68 File Offset: 0x03D80E68
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.AboutBox10_Load
			Dim _ENCList As List(Of WeakReference) = Restartform.__ENCList
			SyncLock _ENCList
				Restartform.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000073 RID: 115
		' (get) Token: 0x0600010A RID: 266 RVA: 0x03D82C90 File Offset: 0x03D81090
		' (set) Token: 0x0600010B RID: 267 RVA: 0x03D82CA8 File Offset: 0x03D810A8
		Friend Property PictureBox1 As PictureBox
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

		' Token: 0x0600010C RID: 268 RVA: 0x03D82D08 File Offset: 0x03D81108
		Private Sub AboutBox10_Load(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.Close()
			Dim flag As Boolean = MyProject.Forms.Form1.PictureBox2.Visible
			If flag Then
				MyProject.Forms.Form1.PictureBox2.Visible = True
				MyProject.Forms.Form1.PictureBox3.Visible = False
				MyProject.Forms.Form1.PictureBox4.Visible = False
				MyProject.Forms.Form1.PictureBox5.Visible = False
				MyProject.Forms.Form1.PictureBox6.Visible = False
				MyProject.Forms.Form1.PictureBox7.Visible = False
				MyProject.Forms.Form1.PictureBox8.Visible = False
				MyProject.Forms.Form1.PictureBox9.Visible = False
			End If
			MyProject.Forms.Form1.Show()
			flag = MyProject.Forms.Form1.PictureBox2.Visible
			If flag Then
				MyProject.Forms.Form1.PictureBox2.Visible = True
				MyProject.Forms.Form1.PictureBox3.Visible = False
				MyProject.Forms.Form1.PictureBox4.Visible = False
				MyProject.Forms.Form1.PictureBox5.Visible = False
				MyProject.Forms.Form1.PictureBox6.Visible = False
				MyProject.Forms.Form1.PictureBox7.Visible = False
				MyProject.Forms.Form1.PictureBox8.Visible = False
				MyProject.Forms.Form1.PictureBox9.Visible = False
			End If
			Me.Close()
		End Sub

		' Token: 0x0600010D RID: 269 RVA: 0x03D82ED8 File Offset: 0x03D812D8
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600010E RID: 270 RVA: 0x03D82EDC File Offset: 0x03D812DC
		Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x04000075 RID: 117
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000077 RID: 119
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox
	End Class
End Namespace
