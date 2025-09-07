Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports CV.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x02000011 RID: 17
	<DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox16
		Inherits Form

		' Token: 0x06000161 RID: 353 RVA: 0x03D85120 File Offset: 0x03D83520
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.AboutBox16_Load
			Dim _ENCList As List(Of WeakReference) = AboutBox16.__ENCList
			SyncLock _ENCList
				AboutBox16.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000164 RID: 356 RVA: 0x03D85288 File Offset: 0x03D83688
		Private Sub AboutBox16_Load(sender As Object, e As EventArgs)
			MyProject.Forms.Form25.Close()
			MyProject.Forms.Form25.Show()
			Me.Close()
		End Sub

		' Token: 0x06000165 RID: 357 RVA: 0x03D852B4 File Offset: 0x03D836B4
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x0400009A RID: 154
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
	End Class
End Namespace
