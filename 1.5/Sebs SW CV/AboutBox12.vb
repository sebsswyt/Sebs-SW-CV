Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports CV.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x0200000D RID: 13
	<DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox12
		Inherits Form

		' Token: 0x06000126 RID: 294 RVA: 0x03D839F8 File Offset: 0x03D81DF8
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.AboutBox12_Load
			Dim _ENCList As List(Of WeakReference) = AboutBox12.__ENCList
			SyncLock _ENCList
				AboutBox12.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000129 RID: 297 RVA: 0x03D83B60 File Offset: 0x03D81F60
		Private Sub AboutBox12_Load(sender As Object, e As EventArgs)
			MyProject.Forms.Form1.Close()
			MyProject.Forms.Form1.Show()
			MyProject.Forms.Form1.Button2.Visible = True
			Dim visible As Boolean = MyProject.Forms.Form1.Button10.Visible
			If visible Then
				MyProject.Forms.Form1.Button10.Visible = False
			End If
			Me.Close()
		End Sub

		' Token: 0x0600012A RID: 298 RVA: 0x03D83BDC File Offset: 0x03D81FDC
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x04000082 RID: 130
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
	End Class
End Namespace
