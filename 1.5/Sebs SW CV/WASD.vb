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
	' Token: 0x02000079 RID: 121
	<DesignerGenerated()>
	Public NotInheritable Partial Class WASD
		Inherits Form

		' Token: 0x060012EA RID: 4842 RVA: 0x03DF7A90 File Offset: 0x03DF5E90
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.WASD_Load
			Dim _ENCList As List(Of WeakReference) = WASD.__ENCList
			SyncLock _ENCList
				WASD.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000646 RID: 1606
		' (get) Token: 0x060012ED RID: 4845 RVA: 0x03DF7C70 File Offset: 0x03DF6070
		' (set) Token: 0x060012EE RID: 4846 RVA: 0x03DF7C88 File Offset: 0x03DF6088
		Friend Property TextBox1 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox1 = value
			End Set
		End Property

		' Token: 0x060012EF RID: 4847 RVA: 0x03DF7C94 File Offset: 0x03DF6094
		Private Sub WASD_Load(sender As Object, e As EventArgs)
			Me.WindowState = FormWindowState.Minimized
			Me.TextBox1.Text = MyProject.Computer.Info.OSFullName
			Me.Close()
		End Sub

		' Token: 0x060012F0 RID: 4848 RVA: 0x03DF7CC4 File Offset: 0x03DF60C4
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0400071A RID: 1818
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400071C RID: 1820
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox
	End Class
End Namespace
