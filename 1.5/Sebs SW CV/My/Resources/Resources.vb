Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV.My.Resources
	' Token: 0x02000073 RID: 115
	<DebuggerNonUserCode()>
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")>
	<HideModuleName()>
	<CompilerGenerated()>
	Friend NotInheritable Module Resources
		' Token: 0x1700062B RID: 1579
		' (get) Token: 0x060012A2 RID: 4770 RVA: 0x03D7EE6C File Offset: 0x03D7D26C
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend ReadOnly Property ResourceManager As ResourceManager
			Get
				Dim flag As Boolean = Object.ReferenceEquals(Resources.resourceMan, Nothing)
				If flag Then
					Dim resourceManager As ResourceManager = New ResourceManager("Sebs_SW_CV.Resources", GetType(Resources).Assembly)
					Resources.resourceMan = resourceManager
				End If
				Return Resources.resourceMan
			End Get
		End Property

		' Token: 0x1700062C RID: 1580
		' (get) Token: 0x060012A3 RID: 4771 RVA: 0x03D7EEB4 File Offset: 0x03D7D2B4
		' (set) Token: 0x060012A4 RID: 4772 RVA: 0x03D7EECC File Offset: 0x03D7D2CC
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Property Culture As CultureInfo
			Get
				Return Resources.resourceCulture
			End Get
			Set(value As CultureInfo)
				Resources.resourceCulture = value
			End Set
		End Property

		' Token: 0x040006F9 RID: 1785
		Private resourceMan As ResourceManager

		' Token: 0x040006FA RID: 1786
		Private resourceCulture As CultureInfo
	End Module
End Namespace
