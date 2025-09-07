Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x02000057 RID: 87
	<DesignerGenerated()>
	Public Partial Class Form40
		Inherits Form

		' Token: 0x06000EF3 RID: 3827 RVA: 0x03DDBF2C File Offset: 0x03DDA32C
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Form40.__ENCList
			SyncLock _ENCList
				Form40.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x04000584 RID: 1412
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
	End Class
End Namespace
