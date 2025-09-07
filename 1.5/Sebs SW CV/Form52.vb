Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x02000064 RID: 100
	<DesignerGenerated()>
	Public Partial Class Form52
		Inherits Form

		' Token: 0x06001104 RID: 4356 RVA: 0x03DEA9AC File Offset: 0x03DE8DAC
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Form52.__ENCList
			SyncLock _ENCList
				Form52.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x0400064C RID: 1612
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
	End Class
End Namespace
