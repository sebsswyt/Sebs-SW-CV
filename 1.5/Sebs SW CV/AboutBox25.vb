Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports CV.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x0200001B RID: 27
	<DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox25
		Inherits Form

		' Token: 0x06000216 RID: 534 RVA: 0x03D89D3C File Offset: 0x03D8813C
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.AboutBox25_Load
			Dim _ENCList As List(Of WeakReference) = AboutBox25.__ENCList
			SyncLock _ENCList
				AboutBox25.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000219 RID: 537 RVA: 0x03D89EA4 File Offset: 0x03D882A4
		Private Sub AboutBox25_Load(sender As Object, e As EventArgs)
			MyProject.Forms.Form28.Show()
			Me.Close()
		End Sub

		' Token: 0x0600021A RID: 538 RVA: 0x03D89EC0 File Offset: 0x03D882C0
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x040000E1 RID: 225
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
	End Class
End Namespace
