Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports CV.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x02000019 RID: 25
	<DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox23
		Inherits Form

		' Token: 0x060001FA RID: 506 RVA: 0x03D88CB8 File Offset: 0x03D870B8
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.AboutBox23_Load
			Dim _ENCList As List(Of WeakReference) = AboutBox23.__ENCList
			SyncLock _ENCList
				AboutBox23.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x060001FD RID: 509 RVA: 0x03D88E20 File Offset: 0x03D87220
		Private Sub AboutBox23_Load(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox1.Close()
			MyProject.Forms.AboutBox3.Close()
			MyProject.Forms.AboutBox5.Close()
			MyProject.Forms.AboutBox7.Close()
			MyProject.Forms.AboutBox8.Close()
			MyProject.Forms.AboutBox9.Close()
			MyProject.Forms.AboutBox11.Close()
			MyProject.Forms.AboutBox12.Close()
			MyProject.Forms.AboutBox13.Close()
			MyProject.Forms.AboutBox14.Close()
			MyProject.Forms.AboutBox15.Close()
			MyProject.Forms.AboutBox16.Close()
			MyProject.Forms.AboutBox17.Close()
			MyProject.Forms.AboutBox18.Close()
			MyProject.Forms.AboutBox19.Close()
			MyProject.Forms.AboutBox20.Close()
			MyProject.Forms.AboutBox21.Close()
			MyProject.Forms.AboutBox22.Close()
			MyProject.Forms.Form1.Close()
			MyProject.Forms.form1Pad.Close()
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
			MyProject.Forms.Form31.Close()
			MyProject.Forms.Form32.Close()
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
			Me.Close()
		End Sub

		' Token: 0x060001FE RID: 510 RVA: 0x03D89198 File Offset: 0x03D87598
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x040000D5 RID: 213
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
	End Class
End Namespace
