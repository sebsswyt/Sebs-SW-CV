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
	' Token: 0x0200006B RID: 107
	<DesignerGenerated()>
	Public Partial Class ha
		Inherits Form

		' Token: 0x06001198 RID: 4504 RVA: 0x03DEE808 File Offset: 0x03DECC08
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.ha_Load
			Dim _ENCList As List(Of WeakReference) = ha.__ENCList
			SyncLock _ENCList
				ha.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170005C9 RID: 1481
		' (get) Token: 0x0600119B RID: 4507 RVA: 0x03DEEB14 File Offset: 0x03DECF14
		' (set) Token: 0x0600119C RID: 4508 RVA: 0x03DEEB2C File Offset: 0x03DECF2C
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

		' Token: 0x170005CA RID: 1482
		' (get) Token: 0x0600119D RID: 4509 RVA: 0x03DEEB38 File Offset: 0x03DECF38
		' (set) Token: 0x0600119E RID: 4510 RVA: 0x03DEEB50 File Offset: 0x03DECF50
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

		' Token: 0x0600119F RID: 4511 RVA: 0x03DEEB5C File Offset: 0x03DECF5C
		Private Sub ha_Load(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.Close()
			MyProject.Forms.Form2.Close()
			MyProject.Forms.Form3.Close()
			MyProject.Forms.Form4.Close()
			MyProject.Forms.Form5.Close()
			MyProject.Forms.Form6.Close()
			MyProject.Forms.Form7.Close()
			MyProject.Forms.Form8.Close()
			MyProject.Forms.Form9.Close()
			MyProject.Forms.Form10.Close()
			MyProject.Forms.Form11.Close()
			MyProject.Forms.Form12.Close()
			MyProject.Forms.Form13.Close()
			MyProject.Forms.Form14.Close()
			MyProject.Forms.Form15.Close()
			MyProject.Forms.Form16.Close()
			MyProject.Forms.Form17.Close()
			MyProject.Forms.Form18.Close()
			MyProject.Forms.Form19.Close()
			MyProject.Forms.Form20.Close()
			MyProject.Forms.Form21.Close()
			MyProject.Forms.Form22.Close()
			MyProject.Forms.Form23.Close()
			MyProject.Forms.Form24.Close()
			MyProject.Forms.Form25.Close()
			MyProject.Forms.Form26.Close()
			MyProject.Forms.Form27.Close()
			MyProject.Forms.Form28.Close()
			MyProject.Forms.Form29.Close()
			MyProject.Forms.Form30.Close()
			MyProject.Forms.Form31.Close()
			MyProject.Forms.Form32.Close()
			MyProject.Forms.Form33.Close()
			MyProject.Forms.Form34.Close()
			MyProject.Forms.Form35.Close()
			MyProject.Forms.Form36.Close()
			MyProject.Forms.Form37.Close()
			MyProject.Forms.Form38.Close()
			MyProject.Forms.Form39.Close()
			MyProject.Forms.Form40.Close()
			MyProject.Forms.Form41.Close()
			MyProject.Forms.Form42.Close()
			MyProject.Forms.Form43.Close()
			MyProject.Forms.Form44.Close()
			MyProject.Forms.Form45.Close()
			MyProject.Forms.Form46.Close()
			MyProject.Forms.Form47.Close()
			MyProject.Forms.Form48.Close()
			MyProject.Forms.Form49.Close()
			MyProject.Forms.Form50.Close()
			MyProject.Forms.Form51.Close()
			MyProject.Forms.Form52.Close()
			MyProject.Forms.Form53.Close()
			MyProject.Forms.Form54.Close()
			MyProject.Forms.Form55.Close()
			MyProject.Forms.Form56.Close()
			MyProject.Forms.Form57.Close()
			MyProject.Forms.Form58.Close()
			MyProject.Forms.AP.Close()
			MyProject.Forms.form1Pad.Close()
			MyProject.Forms.updaterform1.Close()
			MyProject.Forms.seb_copy_web.Close()
			MyProject.Forms.Loginz.Close()
			MyProject.Forms.AboutBox1.Close()
			MyProject.Forms.AboutBox19.Close()
		End Sub

		' Token: 0x04000689 RID: 1673
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400068B RID: 1675
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x0400068C RID: 1676
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox
	End Class
End Namespace
