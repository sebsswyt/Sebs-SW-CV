Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x02000014 RID: 20
	<DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox19
		Inherits Form

		' Token: 0x060001A2 RID: 418 RVA: 0x03D86828 File Offset: 0x03D84C28
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.AboutBox19_Load
			Dim _ENCList As List(Of WeakReference) = AboutBox19.__ENCList
			SyncLock _ENCList
				AboutBox19.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700009E RID: 158
		' (get) Token: 0x060001A5 RID: 421 RVA: 0x03D86A64 File Offset: 0x03D84E64
		' (set) Token: 0x060001A6 RID: 422 RVA: 0x03D86A7C File Offset: 0x03D84E7C
		Friend Property Label1 As Label
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

		' Token: 0x060001A7 RID: 423 RVA: 0x03D86A88 File Offset: 0x03D84E88
		Private Sub AboutBox19_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060001A8 RID: 424 RVA: 0x03D86A8C File Offset: 0x03D84E8C
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x040000B2 RID: 178
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040000B4 RID: 180
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label
	End Class
End Namespace
