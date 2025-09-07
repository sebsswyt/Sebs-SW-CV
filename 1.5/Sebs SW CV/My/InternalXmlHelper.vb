Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Xml.Linq

Namespace CV.My
	' Token: 0x02000008 RID: 8
	<EditorBrowsable(EditorBrowsableState.Never)>
	<CompilerGenerated()>
	<DebuggerNonUserCode()>
	Friend NotInheritable Class InternalXmlHelper
		' Token: 0x060000DE RID: 222 RVA: 0x03D7B04C File Offset: 0x03D7944C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Private Sub New()
		End Sub

		' Token: 0x17000068 RID: 104
		' (get) Token: 0x060000DF RID: 223 RVA: 0x03D7B058 File Offset: 0x03D79458
		' (set) Token: 0x060000E0 RID: 224 RVA: 0x03D7B0B8 File Offset: 0x03D794B8
		Public Shared Property Value(source As IEnumerable(Of XElement)) As String
			Get
				Try
					Dim enumerator As IEnumerator(Of XElement) = source.GetEnumerator()
					If enumerator.MoveNext() Then
						Dim xelement As XElement = enumerator.Current
						Return xelement.Value
					End If
				Finally
					Dim enumerator As IEnumerator(Of XElement)
					Dim flag As Boolean = enumerator IsNot Nothing
					If flag Then
						enumerator.Dispose()
					End If
				End Try
				Return Nothing
			End Get
			Set(value As String)
				Try
					Dim enumerator As IEnumerator(Of XElement) = source.GetEnumerator()
					If enumerator.MoveNext() Then
						Dim xelement As XElement = enumerator.Current
						xelement.Value = value
					End If
				Finally
					Dim enumerator As IEnumerator(Of XElement)
					Dim flag As Boolean = enumerator IsNot Nothing
					If flag Then
						enumerator.Dispose()
					End If
				End Try
			End Set
		End Property

		' Token: 0x17000069 RID: 105
		' (get) Token: 0x060000E1 RID: 225 RVA: 0x03D7B118 File Offset: 0x03D79518
		' (set) Token: 0x060000E2 RID: 226 RVA: 0x03D7B180 File Offset: 0x03D79580
		Public Shared Property AttributeValue(source As IEnumerable(Of XElement), name As XName) As String
			Get
				Try
					Dim enumerator As IEnumerator(Of XElement) = source.GetEnumerator()
					If enumerator.MoveNext() Then
						Dim xelement As XElement = enumerator.Current
						Return CStr(xelement.Attribute(name))
					End If
				Finally
					Dim enumerator As IEnumerator(Of XElement)
					Dim flag As Boolean = enumerator IsNot Nothing
					If flag Then
						enumerator.Dispose()
					End If
				End Try
				Return Nothing
			End Get
			Set(value As String)
				Try
					Dim enumerator As IEnumerator(Of XElement) = source.GetEnumerator()
					If enumerator.MoveNext() Then
						Dim xelement As XElement = enumerator.Current
						xelement.SetAttributeValue(name, value)
					End If
				Finally
					Dim enumerator As IEnumerator(Of XElement)
					Dim flag As Boolean = enumerator IsNot Nothing
					If flag Then
						enumerator.Dispose()
					End If
				End Try
			End Set
		End Property

		' Token: 0x1700006A RID: 106
		' (get) Token: 0x060000E3 RID: 227 RVA: 0x03D7B1E0 File Offset: 0x03D795E0
		' (set) Token: 0x060000E4 RID: 228 RVA: 0x03D7B200 File Offset: 0x03D79600
		Public Shared Property AttributeValue(source As XElement, name As XName) As String
			Get
				Return CStr(source.Attribute(name))
			End Get
			Set(value As String)
				source.SetAttributeValue(name, value)
			End Set
		End Property

		' Token: 0x060000E5 RID: 229 RVA: 0x03D7B210 File Offset: 0x03D79610
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Shared Function CreateAttribute(name As XName, value As Object) As XAttribute
			Dim flag As Boolean = value Is Nothing
			Dim xattribute As XAttribute
			If flag Then
				xattribute = Nothing
			Else
				xattribute = New XAttribute(name, RuntimeHelpers.GetObjectValue(value))
			End If
			Return xattribute
		End Function

		' Token: 0x060000E6 RID: 230 RVA: 0x03D7B23C File Offset: 0x03D7963C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Shared Function CreateNamespaceAttribute(name As XName, ns As XNamespace) As XAttribute
			Dim xattribute As XAttribute = New XAttribute(name, ns.NamespaceName)
			xattribute.AddAnnotation(ns)
			Return xattribute
		End Function

		' Token: 0x060000E7 RID: 231 RVA: 0x03D7B264 File Offset: 0x03D79664
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Shared Function RemoveNamespaceAttributes(ns As XNamespace(), obj As Object) As Object
			Dim flag As Boolean = ns IsNot Nothing AndAlso obj IsNot Nothing
			If flag Then
				Dim xelement As XElement = TryCast(obj, XElement)
				flag = xelement IsNot Nothing
				If flag Then
					Return InternalXmlHelper.RemoveNamespaceAttributes(ns, xelement)
				End If
				Dim enumerable As IEnumerable = TryCast(obj, IEnumerable)
				flag = enumerable IsNot Nothing
				If flag Then
					Return InternalXmlHelper.RemoveNamespaceAttributes(ns, enumerable)
				End If
			End If
			Return obj
		End Function

		' Token: 0x060000E8 RID: 232 RVA: 0x03D7B2C4 File Offset: 0x03D796C4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Shared Function RemoveNamespaceAttributes(ns As XNamespace(), obj As IEnumerable) As IEnumerable
			Dim flag As Boolean = ns IsNot Nothing AndAlso obj IsNot Nothing
			Dim enumerable2 As IEnumerable
			If flag Then
				Dim enumerable As IEnumerable(Of XElement) = TryCast(obj, IEnumerable(Of XElement))
				flag = enumerable IsNot Nothing
				If flag Then
					enumerable2 = enumerable.[Select](AddressOf New InternalXmlHelper.RemoveNamespaceAttributesClosure(ns).ProcessXElement)
				Else
					enumerable2 = obj.Cast().[Select](AddressOf New InternalXmlHelper.RemoveNamespaceAttributesClosure(ns).ProcessObject)
				End If
			Else
				enumerable2 = obj
			End If
			Return enumerable2
		End Function

		' Token: 0x060000E9 RID: 233 RVA: 0x03D7B338 File Offset: 0x03D79738
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Shared Function RemoveNamespaceAttributes(ns As XNamespace(), e As XElement) As XElement
			Dim flag As Boolean = ns IsNot Nothing AndAlso e IsNot Nothing
			If flag Then
				Dim nextAttribute As XAttribute
				Dim xattribute As XAttribute = e.FirstAttribute
				While xattribute IsNot Nothing
					nextAttribute = xattribute.NextAttribute
					flag = xattribute.IsNamespaceDeclaration
					If flag Then
						Dim xnamespace As XNamespace = xattribute.Annotation(Of XNamespace)()
						flag = xnamespace IsNot Nothing
						If flag Then
							Dim num As Integer = ns.Length - 1
							Dim num2 As Integer = 0
							Dim num3 As Integer = num
							Dim num4 As Integer = num2
							While True
								Dim num5 As Integer = num4
								Dim num6 As Integer = num3
								If num5 > num6 Then
									GoTo IL_7D
								End If
								flag = xnamespace Is ns(num4)
								If flag Then
									Exit For
								End If
								num4 += 1
							End While
							xattribute.Remove()
						End If
						IL_7D:
					End If
					xattribute = nextAttribute
				End While
			End If
			Return e
		End Function

		' Token: 0x060000EA RID: 234 RVA: 0x03D7B3DC File Offset: 0x03D797DC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Shared Function GetNamespace(ByRef xns As XNamespace, ns As String) As XNamespace
			Dim flag As Boolean = xns Is Nothing
			If flag Then
				xns = XNamespace.[Get](ns)
			End If
			Return xns
		End Function

		' Token: 0x02000009 RID: 9
		<EditorBrowsable(EditorBrowsableState.Never)>
		<CompilerGenerated()>
		<DebuggerNonUserCode()>
		Private NotInheritable Class RemoveNamespaceAttributesClosure
			' Token: 0x060000EB RID: 235 RVA: 0x03D7B404 File Offset: 0x03D79804
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Sub New(ns As XNamespace())
				Me.m_ns = ns
			End Sub

			' Token: 0x060000EC RID: 236 RVA: 0x03D7B418 File Offset: 0x03D79818
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function ProcessXElement(elem As XElement) As XElement
				Return InternalXmlHelper.RemoveNamespaceAttributes(Me.m_ns, elem)
			End Function

			' Token: 0x060000ED RID: 237 RVA: 0x03D7B438 File Offset: 0x03D79838
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function ProcessObject(obj As Object) As Object
				Dim xelement As XElement = TryCast(obj, XElement)
				Dim flag As Boolean = xelement IsNot Nothing
				Dim obj2 As Object
				If flag Then
					obj2 = InternalXmlHelper.RemoveNamespaceAttributes(Me.m_ns, xelement)
				Else
					obj2 = obj
				End If
				Return obj2
			End Function

			' Token: 0x0400006A RID: 106
			Private m_ns As XNamespace()
		End Class
	End Class
End Namespace
