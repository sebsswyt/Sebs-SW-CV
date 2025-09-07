Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Configuration
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV.My
	' Token: 0x02000074 RID: 116
	<EditorBrowsable(EditorBrowsableState.Advanced)>
	<CompilerGenerated()>
	<GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")>
	Friend NotInheritable Partial Class MySettings
		Inherits ApplicationSettingsBase

		' Token: 0x060012A7 RID: 4775 RVA: 0x03D7EF0C File Offset: 0x03D7D30C
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		<DebuggerNonUserCode()>
		Private Shared Sub AutoSaveSettings(sender As Object, e As EventArgs)
			Dim saveMySettingsOnExit As Boolean = MyProject.Application.SaveMySettingsOnExit
			If saveMySettingsOnExit Then
				MySettingsProperty.Settings.Save()
			End If
		End Sub

		' Token: 0x1700062D RID: 1581
		' (get) Token: 0x060012A8 RID: 4776 RVA: 0x03D7EF38 File Offset: 0x03D7D338
		Public Shared ReadOnly Property [Default] As MySettings
			Get
				Dim flag As Boolean = Not MySettings.addedHandler
				If flag Then
					Dim obj As Object = MySettings.addedHandlerLockObject
					ObjectFlowControl.CheckForSyncLockOnValueType(obj)
					SyncLock obj
						flag = Not MySettings.addedHandler
						If flag Then
							AddHandler MyProject.Application.Shutdown, AddressOf MySettings.AutoSaveSettings
							MySettings.addedHandler = True
						End If
					End SyncLock
				End If
				Return MySettings.defaultInstance
			End Get
		End Property

		' Token: 0x1700062E RID: 1582
		' (get) Token: 0x060012A9 RID: 4777 RVA: 0x03D7EFB8 File Offset: 0x03D7D3B8
		<DebuggerNonUserCode()>
		<ApplicationScopedSetting()>
		<DefaultSettingValue("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\Sebastian 7\Documents\Database1.accdb""")>
		<SpecialSetting(SpecialSetting.ConnectionString)>
		Public ReadOnly Property Database1ConnectionString As String
			Get
				Return Conversions.ToString(Me("Database1ConnectionString"))
			End Get
		End Property

		' Token: 0x040006FB RID: 1787
		Private Shared defaultInstance As MySettings = CType(SettingsBase.Synchronized(New MySettings()), MySettings)

		' Token: 0x040006FC RID: 1788
		Private Shared addedHandler As Boolean

		' Token: 0x040006FD RID: 1789
		Private Shared addedHandlerLockObject As Object = RuntimeHelpers.GetObjectValue(New Object())
	End Class
End Namespace
