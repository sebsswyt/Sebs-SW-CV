Imports System
Imports System.CodeDom.Compiler
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.ApplicationServices

Namespace CV.My
	' Token: 0x02000002 RID: 2
	<EditorBrowsable(EditorBrowsableState.Never)>
	<GeneratedCode("MyTemplate", "8.0.0.0")>
	Friend Class MyApplication
		Inherits WindowsFormsApplicationBase

		' Token: 0x06000002 RID: 2 RVA: 0x03D7F004 File Offset: 0x03D7D404
		<STAThread()>
		<DebuggerHidden()>
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Shared Sub Main(Args As String())
			Try
				Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering)
			Finally
			End Try
			MyProject.Application.Run(Args)
		End Sub

		' Token: 0x06000003 RID: 3 RVA: 0x03D7F040 File Offset: 0x03D7D440
		<DebuggerStepThrough()>
		Public Sub New()
			MyBase.New(AuthenticationMode.Windows)
			Dim _ENCList As List(Of WeakReference) = MyApplication.__ENCList
			SyncLock _ENCList
				MyApplication.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.IsSingleInstance = False
			Me.EnableVisualStyles = True
			Me.SaveMySettingsOnExit = True
			Me.ShutdownStyle = ShutdownMode.AfterAllFormsClose
		End Sub

		' Token: 0x06000004 RID: 4 RVA: 0x03D7F0B4 File Offset: 0x03D7D4B4
		<DebuggerStepThrough()>
		Protected Overrides Sub OnCreateMainForm()
			Me.MainForm = MyProject.Forms.Form47
		End Sub

		' Token: 0x04000001 RID: 1
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
	End Class
End Namespace
