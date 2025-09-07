Imports System
Imports System.CodeDom.Compiler
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Data
Imports System.Diagnostics
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.Serialization
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x02000025 RID: 37
	<XmlSchemaProvider("GetTypedDataSetSchema")>
	<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")>
	<ToolboxItem(True)>
	<DesignerCategory("code")>
	<HelpKeyword("vs.data.DataSet")>
	<XmlRoot("Database1DataSet")>
	<Serializable()>
	Public Class Database1DataSet
		Inherits DataSet

		' Token: 0x060002D3 RID: 723 RVA: 0x03D7B480 File Offset: 0x03D79880
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Database1DataSet.__ENCList
			SyncLock _ENCList
				Database1DataSet.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me._schemaSerializationMode = SchemaSerializationMode.IncludeSchema
			Me.BeginInit()
			Me.InitClass()
			Dim collectionChangeEventHandler As CollectionChangeEventHandler = AddressOf Me.SchemaChanged
			AddHandler MyBase.Tables.CollectionChanged, collectionChangeEventHandler
			AddHandler MyBase.Relations.CollectionChanged, collectionChangeEventHandler
			Me.EndInit()
		End Sub

		' Token: 0x060002D4 RID: 724 RVA: 0x03D7B518 File Offset: 0x03D79918
		<DebuggerNonUserCode()>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context, False)
			Dim _ENCList As List(Of WeakReference) = Database1DataSet.__ENCList
			SyncLock _ENCList
				Database1DataSet.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me._schemaSerializationMode = SchemaSerializationMode.IncludeSchema
			Dim flag As Boolean = Me.IsBinarySerialized(info, context)
			If flag Then
				Me.InitVars(False)
				Dim collectionChangeEventHandler As CollectionChangeEventHandler = AddressOf Me.SchemaChanged
				AddHandler Me.Tables.CollectionChanged, collectionChangeEventHandler
				AddHandler Me.Relations.CollectionChanged, collectionChangeEventHandler
			Else
				Dim text As String = Conversions.ToString(info.GetValue("XmlSchema", GetType(String)))
				flag = Me.DetermineSchemaSerializationMode(info, context) = SchemaSerializationMode.IncludeSchema
				If flag Then
					Dim dataSet As DataSet = New DataSet()
					dataSet.ReadXmlSchema(New XmlTextReader(New StringReader(text)))
					flag = dataSet.Tables("Table1") IsNot Nothing
					If flag Then
						MyBase.Tables.Add(New Database1DataSet.Table1DataTable(dataSet.Tables("Table1")))
					End If
					Me.DataSetName = dataSet.DataSetName
					Me.Prefix = dataSet.Prefix
					Me.[Namespace] = dataSet.[Namespace]
					Me.Locale = dataSet.Locale
					Me.CaseSensitive = dataSet.CaseSensitive
					Me.EnforceConstraints = dataSet.EnforceConstraints
					Me.Merge(dataSet, False, MissingSchemaAction.Add)
					Me.InitVars()
				Else
					Me.ReadXmlSchema(New XmlTextReader(New StringReader(text)))
				End If
				Me.GetSerializationData(info, context)
				Dim collectionChangeEventHandler2 As CollectionChangeEventHandler = AddressOf Me.SchemaChanged
				AddHandler MyBase.Tables.CollectionChanged, collectionChangeEventHandler2
				AddHandler Me.Relations.CollectionChanged, collectionChangeEventHandler2
			End If
		End Sub

		' Token: 0x170000F1 RID: 241
		' (get) Token: 0x060002D5 RID: 725 RVA: 0x03D7B6E8 File Offset: 0x03D79AE8
		<Browsable(False)>
		<DebuggerNonUserCode()>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
		Public ReadOnly Property Table1 As Database1DataSet.Table1DataTable
			Get
				Return Me.tableTable1
			End Get
		End Property

		' Token: 0x170000F2 RID: 242
		' (get) Token: 0x060002D6 RID: 726 RVA: 0x03D7B700 File Offset: 0x03D79B00
		' (set) Token: 0x060002D7 RID: 727 RVA: 0x03D7B718 File Offset: 0x03D79B18
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
		<DebuggerNonUserCode()>
		<Browsable(True)>
		Public Overrides Property SchemaSerializationMode As SchemaSerializationMode
			Get
				Return Me._schemaSerializationMode
			End Get
			Set(value As SchemaSerializationMode)
				Me._schemaSerializationMode = value
			End Set
		End Property

		' Token: 0x170000F3 RID: 243
		' (get) Token: 0x060002D8 RID: 728 RVA: 0x03D7B724 File Offset: 0x03D79B24
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		<DebuggerNonUserCode()>
		Public ReadOnly Property Tables As DataTableCollection
			Get
				Return MyBase.Tables
			End Get
		End Property

		' Token: 0x170000F4 RID: 244
		' (get) Token: 0x060002D9 RID: 729 RVA: 0x03D7B73C File Offset: 0x03D79B3C
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		<DebuggerNonUserCode()>
		Public ReadOnly Property Relations As DataRelationCollection
			Get
				Return MyBase.Relations
			End Get
		End Property

		' Token: 0x060002DA RID: 730 RVA: 0x03D7B754 File Offset: 0x03D79B54
		<DebuggerNonUserCode()>
		Protected Overrides Sub InitializeDerivedDataSet()
			Me.BeginInit()
			Me.InitClass()
			Me.EndInit()
		End Sub

		' Token: 0x060002DB RID: 731 RVA: 0x03D7B770 File Offset: 0x03D79B70
		<DebuggerNonUserCode()>
		Public Overrides Function Clone() As DataSet
			Dim database1DataSet As Database1DataSet = CType(MyBase.Clone(), Database1DataSet)
			database1DataSet.InitVars()
			database1DataSet.SchemaSerializationMode = Me.SchemaSerializationMode
			Return database1DataSet
		End Function

		' Token: 0x060002DC RID: 732 RVA: 0x03D7B7A4 File Offset: 0x03D79BA4
		<DebuggerNonUserCode()>
		Protected Overrides Function ShouldSerializeTables() As Boolean
			Return False
		End Function

		' Token: 0x060002DD RID: 733 RVA: 0x03D7B7B8 File Offset: 0x03D79BB8
		<DebuggerNonUserCode()>
		Protected Overrides Function ShouldSerializeRelations() As Boolean
			Return False
		End Function

		' Token: 0x060002DE RID: 734 RVA: 0x03D7B7CC File Offset: 0x03D79BCC
		<DebuggerNonUserCode()>
		Protected Overrides Sub ReadXmlSerializable(reader As XmlReader)
			Dim flag As Boolean = Me.DetermineSchemaSerializationMode(reader) = SchemaSerializationMode.IncludeSchema
			If flag Then
				Me.Reset()
				Dim dataSet As DataSet = New DataSet()
				dataSet.ReadXml(reader)
				flag = dataSet.Tables("Table1") IsNot Nothing
				If flag Then
					MyBase.Tables.Add(New Database1DataSet.Table1DataTable(dataSet.Tables("Table1")))
				End If
				Me.DataSetName = dataSet.DataSetName
				Me.Prefix = dataSet.Prefix
				Me.[Namespace] = dataSet.[Namespace]
				Me.Locale = dataSet.Locale
				Me.CaseSensitive = dataSet.CaseSensitive
				Me.EnforceConstraints = dataSet.EnforceConstraints
				Me.Merge(dataSet, False, MissingSchemaAction.Add)
				Me.InitVars()
			Else
				Me.ReadXml(reader)
				Me.InitVars()
			End If
		End Sub

		' Token: 0x060002DF RID: 735 RVA: 0x03D7B8B0 File Offset: 0x03D79CB0
		<DebuggerNonUserCode()>
		Protected Overrides Function GetSchemaSerializable() As XmlSchema
			Dim memoryStream As MemoryStream = New MemoryStream()
			Me.WriteXmlSchema(New XmlTextWriter(memoryStream, Nothing))
			memoryStream.Position = 0L
			Return XmlSchema.Read(New XmlTextReader(memoryStream), Nothing)
		End Function

		' Token: 0x060002E0 RID: 736 RVA: 0x03D7B8EC File Offset: 0x03D79CEC
		<DebuggerNonUserCode()>
		Friend Sub InitVars()
			Me.InitVars(True)
		End Sub

		' Token: 0x060002E1 RID: 737 RVA: 0x03D7B8F8 File Offset: 0x03D79CF8
		<DebuggerNonUserCode()>
		Friend Sub InitVars(initTable As Boolean)
			Me.tableTable1 = CType(MyBase.Tables("Table1"), Database1DataSet.Table1DataTable)
			If initTable Then
				Dim flag As Boolean = Me.tableTable1 IsNot Nothing
				If flag Then
					Me.tableTable1.InitVars()
				End If
			End If
		End Sub

		' Token: 0x060002E2 RID: 738 RVA: 0x03D7B948 File Offset: 0x03D79D48
		<DebuggerNonUserCode()>
		Private Sub InitClass()
			Me.DataSetName = "Database1DataSet"
			Me.Prefix = ""
			Me.[Namespace] = "http://tempuri.org/Database1DataSet.xsd"
			Me.EnforceConstraints = True
			Me.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			Me.tableTable1 = New Database1DataSet.Table1DataTable()
			MyBase.Tables.Add(Me.tableTable1)
		End Sub

		' Token: 0x060002E3 RID: 739 RVA: 0x03D7B9A8 File Offset: 0x03D79DA8
		<DebuggerNonUserCode()>
		Private Function ShouldSerializeTable1() As Boolean
			Return False
		End Function

		' Token: 0x060002E4 RID: 740 RVA: 0x03D7B9BC File Offset: 0x03D79DBC
		<DebuggerNonUserCode()>
		Private Sub SchemaChanged(sender As Object, e As CollectionChangeEventArgs)
			Dim flag As Boolean = e.Action = CollectionChangeAction.Remove
			If flag Then
				Me.InitVars()
			End If
		End Sub

		' Token: 0x060002E5 RID: 741 RVA: 0x03D7B9E0 File Offset: 0x03D79DE0
		<DebuggerNonUserCode()>
		Public Shared Function GetTypedDataSetSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
			Dim database1DataSet As Database1DataSet = New Database1DataSet()
			Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
			Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
			Dim xmlSchemaAny As XmlSchemaAny = New XmlSchemaAny()
			xmlSchemaAny.[Namespace] = database1DataSet.[Namespace]
			xmlSchemaSequence.Items.Add(xmlSchemaAny)
			xmlSchemaComplexType.Particle = xmlSchemaSequence
			Dim schemaSerializable As XmlSchema = database1DataSet.GetSchemaSerializable()
			Dim flag As Boolean = xs.Contains(schemaSerializable.TargetNamespace)
			If flag Then
				Dim memoryStream As MemoryStream = New MemoryStream()
				Dim memoryStream2 As MemoryStream = New MemoryStream()
				Try
					schemaSerializable.Write(memoryStream)
					For Each obj As Object In xs.Schemas(schemaSerializable.TargetNamespace)
						Dim xmlSchema As XmlSchema = CType(obj, XmlSchema)
						memoryStream2.SetLength(0L)
						xmlSchema.Write(memoryStream2)
						flag = memoryStream.Length = memoryStream2.Length
						If flag Then
							memoryStream.Position = 0L
							memoryStream2.Position = 0L
							While memoryStream.Position <> memoryStream.Length AndAlso memoryStream.ReadByte() = memoryStream2.ReadByte()
							End While
							flag = memoryStream.Position = memoryStream.Length
							If flag Then
								Return xmlSchemaComplexType
							End If
						End If
					Next
				Finally
					flag = memoryStream IsNot Nothing
					If flag Then
						memoryStream.Close()
					End If
					flag = memoryStream2 IsNot Nothing
					If flag Then
						memoryStream2.Close()
					End If
				End Try
			End If
			xs.Add(schemaSerializable)
			Return xmlSchemaComplexType
		End Function

		' Token: 0x04000128 RID: 296
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000129 RID: 297
		Private tableTable1 As Database1DataSet.Table1DataTable

		' Token: 0x0400012A RID: 298
		Private _schemaSerializationMode As SchemaSerializationMode

		' Token: 0x02000026 RID: 38
		' (Invoke) Token: 0x060002E9 RID: 745
		Public Delegate Sub Table1RowChangeEventHandler(sender As Object, e As Database1DataSet.Table1RowChangeEvent)

		' Token: 0x02000027 RID: 39
		<XmlSchemaProvider("GetTypedTableSchema")>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")>
		<Serializable()>
		Public Class Table1DataTable
			Inherits TypedTableBase(Of Database1DataSet.Table1Row)

			' Token: 0x060002EB RID: 747 RVA: 0x03D7BB88 File Offset: 0x03D79F88
			<DebuggerNonUserCode()>
			Public Sub New()
				Dim _ENCList As List(Of WeakReference) = Database1DataSet.Table1DataTable.__ENCList
				SyncLock _ENCList
					Database1DataSet.Table1DataTable.__ENCList.Add(New WeakReference(Me))
				End SyncLock
				Me.TableName = "Table1"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			' Token: 0x060002EC RID: 748 RVA: 0x03D7BBFC File Offset: 0x03D79FFC
			<DebuggerNonUserCode()>
			Friend Sub New(table As DataTable)
				Dim _ENCList As List(Of WeakReference) = Database1DataSet.Table1DataTable.__ENCList
				SyncLock _ENCList
					Database1DataSet.Table1DataTable.__ENCList.Add(New WeakReference(Me))
				End SyncLock
				Me.TableName = table.TableName
				Dim flag As Boolean = table.CaseSensitive <> table.DataSet.CaseSensitive
				If flag Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				flag = Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0
				If flag Then
					Me.Locale = table.Locale
				End If
				flag = Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0
				If flag Then
					Me.[Namespace] = table.[Namespace]
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			' Token: 0x060002ED RID: 749 RVA: 0x03D7BD04 File Offset: 0x03D7A104
			<DebuggerNonUserCode()>
			Protected Sub New(info As SerializationInfo, context As StreamingContext)
				MyBase.New(info, context)
				Dim _ENCList As List(Of WeakReference) = Database1DataSet.Table1DataTable.__ENCList
				SyncLock _ENCList
					Database1DataSet.Table1DataTable.__ENCList.Add(New WeakReference(Me))
				End SyncLock
				Me.InitVars()
			End Sub

			' Token: 0x170000F5 RID: 245
			' (get) Token: 0x060002EE RID: 750 RVA: 0x03D7BD60 File Offset: 0x03D7A160
			<DebuggerNonUserCode()>
			Public ReadOnly Property IDColumn As DataColumn
				Get
					Return Me.columnID
				End Get
			End Property

			' Token: 0x170000F6 RID: 246
			' (get) Token: 0x060002EF RID: 751 RVA: 0x03D7BD78 File Offset: 0x03D7A178
			<DebuggerNonUserCode()>
			Public ReadOnly Property YourNameColumn As DataColumn
				Get
					Return Me.columnYourName
				End Get
			End Property

			' Token: 0x170000F7 RID: 247
			' (get) Token: 0x060002F0 RID: 752 RVA: 0x03D7BD90 File Offset: 0x03D7A190
			<DebuggerNonUserCode()>
			Public ReadOnly Property LastNameColumn As DataColumn
				Get
					Return Me.columnLastName
				End Get
			End Property

			' Token: 0x170000F8 RID: 248
			' (get) Token: 0x060002F1 RID: 753 RVA: 0x03D7BDA8 File Offset: 0x03D7A1A8
			<DebuggerNonUserCode()>
			Public ReadOnly Property PhoneColumn As DataColumn
				Get
					Return Me.columnPhone
				End Get
			End Property

			' Token: 0x170000F9 RID: 249
			' (get) Token: 0x060002F2 RID: 754 RVA: 0x03D7BDC0 File Offset: 0x03D7A1C0
			<DebuggerNonUserCode()>
			Public ReadOnly Property EmailColumn As DataColumn
				Get
					Return Me.columnEmail
				End Get
			End Property

			' Token: 0x170000FA RID: 250
			' (get) Token: 0x060002F3 RID: 755 RVA: 0x03D7BDD8 File Offset: 0x03D7A1D8
			<DebuggerNonUserCode()>
			Public ReadOnly Property FacebookColumn As DataColumn
				Get
					Return Me.columnFacebook
				End Get
			End Property

			' Token: 0x170000FB RID: 251
			' (get) Token: 0x060002F4 RID: 756 RVA: 0x03D7BDF0 File Offset: 0x03D7A1F0
			<DebuggerNonUserCode()>
			<Browsable(False)>
			Public ReadOnly Property Count As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			' Token: 0x170000FC RID: 252
			<DebuggerNonUserCode()>
			Public ReadOnly Default Property Item(index As Integer) As Database1DataSet.Table1Row
				Get
					Return CType(Me.Rows(index), Database1DataSet.Table1Row)
				End Get
			End Property

			' Token: 0x14000001 RID: 1
			' (add) Token: 0x060002F6 RID: 758 RVA: 0x03D7BE34 File Offset: 0x03D7A234
			' (remove) Token: 0x060002F7 RID: 759 RVA: 0x03D7BE50 File Offset: 0x03D7A250
			<DebuggerNonUserCode()>
			Public Event Table1RowChanging As Database1DataSet.Table1RowChangeEventHandler

			' Token: 0x14000002 RID: 2
			' (add) Token: 0x060002F8 RID: 760 RVA: 0x03D7BE6C File Offset: 0x03D7A26C
			' (remove) Token: 0x060002F9 RID: 761 RVA: 0x03D7BE88 File Offset: 0x03D7A288
			<DebuggerNonUserCode()>
			Public Event Table1RowChanged As Database1DataSet.Table1RowChangeEventHandler

			' Token: 0x14000003 RID: 3
			' (add) Token: 0x060002FA RID: 762 RVA: 0x03D7BEA4 File Offset: 0x03D7A2A4
			' (remove) Token: 0x060002FB RID: 763 RVA: 0x03D7BEC0 File Offset: 0x03D7A2C0
			<DebuggerNonUserCode()>
			Public Event Table1RowDeleting As Database1DataSet.Table1RowChangeEventHandler

			' Token: 0x14000004 RID: 4
			' (add) Token: 0x060002FC RID: 764 RVA: 0x03D7BEDC File Offset: 0x03D7A2DC
			' (remove) Token: 0x060002FD RID: 765 RVA: 0x03D7BEF8 File Offset: 0x03D7A2F8
			<DebuggerNonUserCode()>
			Public Event Table1RowDeleted As Database1DataSet.Table1RowChangeEventHandler

			' Token: 0x060002FE RID: 766 RVA: 0x03D7BF14 File Offset: 0x03D7A314
			<DebuggerNonUserCode()>
			Public Sub AddTable1Row(row As Database1DataSet.Table1Row)
				Me.Rows.Add(row)
			End Sub

			' Token: 0x060002FF RID: 767 RVA: 0x03D7BF28 File Offset: 0x03D7A328
			<DebuggerNonUserCode()>
			Public Function AddTable1Row(YourName As String, LastName As String, Phone As String, Email As String, Facebook As String) As Database1DataSet.Table1Row
				Dim table1Row As Database1DataSet.Table1Row = CType(Me.NewRow(), Database1DataSet.Table1Row)
				Dim array As Object() = New Object() { Nothing, YourName, LastName, Phone, Email, Facebook }
				table1Row.ItemArray = array
				Me.Rows.Add(table1Row)
				Return table1Row
			End Function

			' Token: 0x06000300 RID: 768 RVA: 0x03D7BF88 File Offset: 0x03D7A388
			<DebuggerNonUserCode()>
			Public Function FindByID(ID As Integer) As Database1DataSet.Table1Row
				Return CType(Me.Rows.Find(New Object() { ID }), Database1DataSet.Table1Row)
			End Function

			' Token: 0x06000301 RID: 769 RVA: 0x03D7BFBC File Offset: 0x03D7A3BC
			<DebuggerNonUserCode()>
			Public Overrides Function Clone() As DataTable
				Dim table1DataTable As Database1DataSet.Table1DataTable = CType(MyBase.Clone(), Database1DataSet.Table1DataTable)
				table1DataTable.InitVars()
				Return table1DataTable
			End Function

			' Token: 0x06000302 RID: 770 RVA: 0x03D7BFE4 File Offset: 0x03D7A3E4
			<DebuggerNonUserCode()>
			Protected Overrides Function CreateInstance() As DataTable
				Return New Database1DataSet.Table1DataTable()
			End Function

			' Token: 0x06000303 RID: 771 RVA: 0x03D7BFFC File Offset: 0x03D7A3FC
			<DebuggerNonUserCode()>
			Friend Sub InitVars()
				Me.columnID = MyBase.Columns("ID")
				Me.columnYourName = MyBase.Columns("YourName")
				Me.columnLastName = MyBase.Columns("LastName")
				Me.columnPhone = MyBase.Columns("Phone")
				Me.columnEmail = MyBase.Columns("Email")
				Me.columnFacebook = MyBase.Columns("Facebook")
			End Sub

			' Token: 0x06000304 RID: 772 RVA: 0x03D7C090 File Offset: 0x03D7A490
			<DebuggerNonUserCode()>
			Private Sub InitClass()
				Me.columnID = New DataColumn("ID", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnID)
				Me.columnYourName = New DataColumn("YourName", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnYourName)
				Me.columnLastName = New DataColumn("LastName", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnLastName)
				Me.columnPhone = New DataColumn("Phone", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnPhone)
				Me.columnEmail = New DataColumn("Email", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnEmail)
				Me.columnFacebook = New DataColumn("Facebook", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnFacebook)
				Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() { Me.columnID }, True))
				Me.columnID.AutoIncrement = True
				Me.columnID.AutoIncrementSeed = -1L
				Me.columnID.AutoIncrementStep = -1L
				Me.columnID.AllowDBNull = False
				Me.columnID.Unique = True
				Me.columnYourName.MaxLength = 255
				Me.columnLastName.MaxLength = 255
				Me.columnPhone.MaxLength = 255
				Me.columnEmail.MaxLength = 255
				Me.columnFacebook.MaxLength = 255
			End Sub

			' Token: 0x06000305 RID: 773 RVA: 0x03D7C274 File Offset: 0x03D7A674
			<DebuggerNonUserCode()>
			Public Function NewTable1Row() As Database1DataSet.Table1Row
				Return CType(Me.NewRow(), Database1DataSet.Table1Row)
			End Function

			' Token: 0x06000306 RID: 774 RVA: 0x03D7C294 File Offset: 0x03D7A694
			<DebuggerNonUserCode()>
			Protected Overrides Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New Database1DataSet.Table1Row(builder)
			End Function

			' Token: 0x06000307 RID: 775 RVA: 0x03D7C2AC File Offset: 0x03D7A6AC
			<DebuggerNonUserCode()>
			Protected Overrides Function GetRowType() As Type
				Return GetType(Database1DataSet.Table1Row)
			End Function

			' Token: 0x06000308 RID: 776 RVA: 0x03D7C2C8 File Offset: 0x03D7A6C8
			<DebuggerNonUserCode()>
			Protected Overrides Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.Table1RowChangedEvent IsNot Nothing
				If flag Then
					Dim table1RowChangedEvent As Database1DataSet.Table1RowChangeEventHandler = Me.Table1RowChangedEvent
					flag = table1RowChangedEvent IsNot Nothing
					If flag Then
						table1RowChangedEvent(Me, New Database1DataSet.Table1RowChangeEvent(CType(e.Row, Database1DataSet.Table1Row), e.Action))
					End If
				End If
			End Sub

			' Token: 0x06000309 RID: 777 RVA: 0x03D7C320 File Offset: 0x03D7A720
			<DebuggerNonUserCode()>
			Protected Overrides Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.Table1RowChangingEvent IsNot Nothing
				If flag Then
					Dim table1RowChangingEvent As Database1DataSet.Table1RowChangeEventHandler = Me.Table1RowChangingEvent
					flag = table1RowChangingEvent IsNot Nothing
					If flag Then
						table1RowChangingEvent(Me, New Database1DataSet.Table1RowChangeEvent(CType(e.Row, Database1DataSet.Table1Row), e.Action))
					End If
				End If
			End Sub

			' Token: 0x0600030A RID: 778 RVA: 0x03D7C378 File Offset: 0x03D7A778
			<DebuggerNonUserCode()>
			Protected Overrides Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.Table1RowDeletedEvent IsNot Nothing
				If flag Then
					Dim table1RowDeletedEvent As Database1DataSet.Table1RowChangeEventHandler = Me.Table1RowDeletedEvent
					flag = table1RowDeletedEvent IsNot Nothing
					If flag Then
						table1RowDeletedEvent(Me, New Database1DataSet.Table1RowChangeEvent(CType(e.Row, Database1DataSet.Table1Row), e.Action))
					End If
				End If
			End Sub

			' Token: 0x0600030B RID: 779 RVA: 0x03D7C3D0 File Offset: 0x03D7A7D0
			<DebuggerNonUserCode()>
			Protected Overrides Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.Table1RowDeletingEvent IsNot Nothing
				If flag Then
					Dim table1RowDeletingEvent As Database1DataSet.Table1RowChangeEventHandler = Me.Table1RowDeletingEvent
					flag = table1RowDeletingEvent IsNot Nothing
					If flag Then
						table1RowDeletingEvent(Me, New Database1DataSet.Table1RowChangeEvent(CType(e.Row, Database1DataSet.Table1Row), e.Action))
					End If
				End If
			End Sub

			' Token: 0x0600030C RID: 780 RVA: 0x03D7C428 File Offset: 0x03D7A828
			<DebuggerNonUserCode()>
			Public Sub RemoveTable1Row(row As Database1DataSet.Table1Row)
				Me.Rows.Remove(row)
			End Sub

			' Token: 0x0600030D RID: 781 RVA: 0x03D7C43C File Offset: 0x03D7A83C
			<DebuggerNonUserCode()>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim database1DataSet As Database1DataSet = New Database1DataSet()
				Dim xmlSchemaAny As XmlSchemaAny = New XmlSchemaAny()
				xmlSchemaAny.[Namespace] = "http://www.w3.org/2001/XMLSchema"
				Dim xmlSchemaParticle As XmlSchemaParticle = xmlSchemaAny
				Dim num As Decimal = 0D
				xmlSchemaParticle.MinOccurs = num
				xmlSchemaAny.MaxOccurs = Decimal.MaxValue
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax
				xmlSchemaSequence.Items.Add(xmlSchemaAny)
				Dim xmlSchemaAny2 As XmlSchemaAny = New XmlSchemaAny()
				xmlSchemaAny2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
				Dim xmlSchemaParticle2 As XmlSchemaParticle = xmlSchemaAny2
				num = 1D
				xmlSchemaParticle2.MinOccurs = num
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax
				xmlSchemaSequence.Items.Add(xmlSchemaAny2)
				Dim xmlSchemaAttribute As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute.Name = "namespace"
				xmlSchemaAttribute.FixedValue = database1DataSet.[Namespace]
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute)
				Dim xmlSchemaAttribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute2.Name = "tableTypeName"
				xmlSchemaAttribute2.FixedValue = "Table1DataTable"
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2)
				xmlSchemaComplexType.Particle = xmlSchemaSequence
				Dim schemaSerializable As XmlSchema = database1DataSet.GetSchemaSerializable()
				Dim flag As Boolean = xs.Contains(schemaSerializable.TargetNamespace)
				If flag Then
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim memoryStream2 As MemoryStream = New MemoryStream()
					Try
						schemaSerializable.Write(memoryStream)
						For Each obj As Object In xs.Schemas(schemaSerializable.TargetNamespace)
							Dim xmlSchema As XmlSchema = CType(obj, XmlSchema)
							memoryStream2.SetLength(0L)
							xmlSchema.Write(memoryStream2)
							flag = memoryStream.Length = memoryStream2.Length
							If flag Then
								memoryStream.Position = 0L
								memoryStream2.Position = 0L
								While memoryStream.Position <> memoryStream.Length AndAlso memoryStream.ReadByte() = memoryStream2.ReadByte()
								End While
								flag = memoryStream.Position = memoryStream.Length
								If flag Then
									Return xmlSchemaComplexType
								End If
							End If
						Next
					Finally
						flag = memoryStream IsNot Nothing
						If flag Then
							memoryStream.Close()
						End If
						flag = memoryStream2 IsNot Nothing
						If flag Then
							memoryStream2.Close()
						End If
					End Try
				End If
				xs.Add(schemaSerializable)
				Return xmlSchemaComplexType
			End Function

			' Token: 0x0400012B RID: 299
			Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

			' Token: 0x0400012C RID: 300
			Private columnID As DataColumn

			' Token: 0x0400012D RID: 301
			Private columnYourName As DataColumn

			' Token: 0x0400012E RID: 302
			Private columnLastName As DataColumn

			' Token: 0x0400012F RID: 303
			Private columnPhone As DataColumn

			' Token: 0x04000130 RID: 304
			Private columnEmail As DataColumn

			' Token: 0x04000131 RID: 305
			Private columnFacebook As DataColumn
		End Class

		' Token: 0x02000028 RID: 40
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")>
		Public Class Table1Row
			Inherits DataRow

			' Token: 0x0600030E RID: 782 RVA: 0x03D7C6B0 File Offset: 0x03D7AAB0
			<DebuggerNonUserCode()>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.New(rb)
				Me.tableTable1 = CType(Me.Table, Database1DataSet.Table1DataTable)
			End Sub

			' Token: 0x170000FD RID: 253
			' (get) Token: 0x0600030F RID: 783 RVA: 0x03D7C6D0 File Offset: 0x03D7AAD0
			' (set) Token: 0x06000310 RID: 784 RVA: 0x03D7C6F8 File Offset: 0x03D7AAF8
			<DebuggerNonUserCode()>
			Public Property ID As Integer
				Get
					Return Conversions.ToInteger(Me(Me.tableTable1.IDColumn))
				End Get
				Set(value As Integer)
					Me(Me.tableTable1.IDColumn) = value
				End Set
			End Property

			' Token: 0x170000FE RID: 254
			' (get) Token: 0x06000311 RID: 785 RVA: 0x03D7C714 File Offset: 0x03D7AB14
			' (set) Token: 0x06000312 RID: 786 RVA: 0x03D7C76C File Offset: 0x03D7AB6C
			<DebuggerNonUserCode()>
			Public Property YourName As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(Me(Me.tableTable1.YourNameColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'YourName' in table 'Table1' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					Me(Me.tableTable1.YourNameColumn) = value
				End Set
			End Property

			' Token: 0x170000FF RID: 255
			' (get) Token: 0x06000313 RID: 787 RVA: 0x03D7C784 File Offset: 0x03D7AB84
			' (set) Token: 0x06000314 RID: 788 RVA: 0x03D7C7DC File Offset: 0x03D7ABDC
			<DebuggerNonUserCode()>
			Public Property LastName As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(Me(Me.tableTable1.LastNameColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'LastName' in table 'Table1' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					Me(Me.tableTable1.LastNameColumn) = value
				End Set
			End Property

			' Token: 0x17000100 RID: 256
			' (get) Token: 0x06000315 RID: 789 RVA: 0x03D7C7F4 File Offset: 0x03D7ABF4
			' (set) Token: 0x06000316 RID: 790 RVA: 0x03D7C84C File Offset: 0x03D7AC4C
			<DebuggerNonUserCode()>
			Public Property Phone As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(Me(Me.tableTable1.PhoneColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'Phone' in table 'Table1' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					Me(Me.tableTable1.PhoneColumn) = value
				End Set
			End Property

			' Token: 0x17000101 RID: 257
			' (get) Token: 0x06000317 RID: 791 RVA: 0x03D7C864 File Offset: 0x03D7AC64
			' (set) Token: 0x06000318 RID: 792 RVA: 0x03D7C8BC File Offset: 0x03D7ACBC
			<DebuggerNonUserCode()>
			Public Property Email As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(Me(Me.tableTable1.EmailColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'Email' in table 'Table1' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					Me(Me.tableTable1.EmailColumn) = value
				End Set
			End Property

			' Token: 0x17000102 RID: 258
			' (get) Token: 0x06000319 RID: 793 RVA: 0x03D7C8D4 File Offset: 0x03D7ACD4
			' (set) Token: 0x0600031A RID: 794 RVA: 0x03D7C92C File Offset: 0x03D7AD2C
			<DebuggerNonUserCode()>
			Public Property Facebook As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(Me(Me.tableTable1.FacebookColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'Facebook' in table 'Table1' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					Me(Me.tableTable1.FacebookColumn) = value
				End Set
			End Property

			' Token: 0x0600031B RID: 795 RVA: 0x03D7C944 File Offset: 0x03D7AD44
			<DebuggerNonUserCode()>
			Public Function IsYourNameNull() As Boolean
				Return Me.IsNull(Me.tableTable1.YourNameColumn)
			End Function

			' Token: 0x0600031C RID: 796 RVA: 0x03D7C968 File Offset: 0x03D7AD68
			<DebuggerNonUserCode()>
			Public Sub SetYourNameNull()
				Me(Me.tableTable1.YourNameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x0600031D RID: 797 RVA: 0x03D7C988 File Offset: 0x03D7AD88
			<DebuggerNonUserCode()>
			Public Function IsLastNameNull() As Boolean
				Return Me.IsNull(Me.tableTable1.LastNameColumn)
			End Function

			' Token: 0x0600031E RID: 798 RVA: 0x03D7C9AC File Offset: 0x03D7ADAC
			<DebuggerNonUserCode()>
			Public Sub SetLastNameNull()
				Me(Me.tableTable1.LastNameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x0600031F RID: 799 RVA: 0x03D7C9CC File Offset: 0x03D7ADCC
			<DebuggerNonUserCode()>
			Public Function IsPhoneNull() As Boolean
				Return Me.IsNull(Me.tableTable1.PhoneColumn)
			End Function

			' Token: 0x06000320 RID: 800 RVA: 0x03D7C9F0 File Offset: 0x03D7ADF0
			<DebuggerNonUserCode()>
			Public Sub SetPhoneNull()
				Me(Me.tableTable1.PhoneColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06000321 RID: 801 RVA: 0x03D7CA10 File Offset: 0x03D7AE10
			<DebuggerNonUserCode()>
			Public Function IsEmailNull() As Boolean
				Return Me.IsNull(Me.tableTable1.EmailColumn)
			End Function

			' Token: 0x06000322 RID: 802 RVA: 0x03D7CA34 File Offset: 0x03D7AE34
			<DebuggerNonUserCode()>
			Public Sub SetEmailNull()
				Me(Me.tableTable1.EmailColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06000323 RID: 803 RVA: 0x03D7CA54 File Offset: 0x03D7AE54
			<DebuggerNonUserCode()>
			Public Function IsFacebookNull() As Boolean
				Return Me.IsNull(Me.tableTable1.FacebookColumn)
			End Function

			' Token: 0x06000324 RID: 804 RVA: 0x03D7CA78 File Offset: 0x03D7AE78
			<DebuggerNonUserCode()>
			Public Sub SetFacebookNull()
				Me(Me.tableTable1.FacebookColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x04000136 RID: 310
			Private tableTable1 As Database1DataSet.Table1DataTable
		End Class

		' Token: 0x02000029 RID: 41
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")>
		Public Class Table1RowChangeEvent
			Inherits EventArgs

			' Token: 0x06000325 RID: 805 RVA: 0x03D7CA98 File Offset: 0x03D7AE98
			<DebuggerNonUserCode()>
			Public Sub New(row As Database1DataSet.Table1Row, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			' Token: 0x17000103 RID: 259
			' (get) Token: 0x06000326 RID: 806 RVA: 0x03D7CAB4 File Offset: 0x03D7AEB4
			<DebuggerNonUserCode()>
			Public ReadOnly Property Row As Database1DataSet.Table1Row
				Get
					Return Me.eventRow
				End Get
			End Property

			' Token: 0x17000104 RID: 260
			' (get) Token: 0x06000327 RID: 807 RVA: 0x03D7CACC File Offset: 0x03D7AECC
			<DebuggerNonUserCode()>
			Public ReadOnly Property Action As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property

			' Token: 0x04000137 RID: 311
			Private eventRow As Database1DataSet.Table1Row

			' Token: 0x04000138 RID: 312
			Private eventAction As DataRowAction
		End Class
	End Class
End Namespace
