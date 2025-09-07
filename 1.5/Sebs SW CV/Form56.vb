Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x02000068 RID: 104
	<DesignerGenerated()>
	Public Partial Class Form56
		Inherits Form

		' Token: 0x06001169 RID: 4457 RVA: 0x03DED22C File Offset: 0x03DEB62C
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Form56.__ENCList
			SyncLock _ENCList
				Form56.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170005BC RID: 1468
		' (get) Token: 0x0600116C RID: 4460 RVA: 0x03DED3F8 File Offset: 0x03DEB7F8
		' (set) Token: 0x0600116D RID: 4461 RVA: 0x03DED410 File Offset: 0x03DEB810
		Friend Overridable Property WebBrowser1 As WebBrowser
			<DebuggerNonUserCode()>
			Get
				Return Me._WebBrowser1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As WebBrowser)
				Me._WebBrowser1 = value
			End Set
		End Property

		' Token: 0x04000676 RID: 1654
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000678 RID: 1656
		<AccessedThroughProperty("WebBrowser1")>
		Private _WebBrowser1 As WebBrowser
	End Class
End Namespace
