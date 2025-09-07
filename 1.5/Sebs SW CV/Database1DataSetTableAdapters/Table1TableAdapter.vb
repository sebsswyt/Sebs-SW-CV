Imports System
Imports System.CodeDom.Compiler
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Data
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Runtime.CompilerServices

Namespace CV.Database1DataSetTableAdapters
	' Token: 0x0200002A RID: 42
	<HelpKeyword("vs.data.TableAdapter")>
	<DataObject(True)>
	<ToolboxItem(True)>
	<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")>
	<DesignerCategory("code")>
	<Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")>
	Public Class Table1TableAdapter
		Inherits Component

		' Token: 0x17000105 RID: 261
		' (get) Token: 0x06000329 RID: 809 RVA: 0x03D7CAF4 File Offset: 0x03D7AEF4
		' (set) Token: 0x0600032A RID: 810 RVA: 0x03D7CB0C File Offset: 0x03D7AF0C
		Private Overridable Property _adapter As OleDbDataAdapter
			<DebuggerNonUserCode()>
			Get
				Return Me.__adapter
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As OleDbDataAdapter)
				Me.__adapter = value
			End Set
		End Property

		' Token: 0x0600032B RID: 811 RVA: 0x03D7CB18 File Offset: 0x03D7AF18
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Table1TableAdapter.__ENCList
			SyncLock _ENCList
				Table1TableAdapter.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.ClearBeforeFill = True
		End Sub

		' Token: 0x17000106 RID: 262
		' (get) Token: 0x0600032C RID: 812 RVA: 0x03D7CB74 File Offset: 0x03D7AF74
		<DebuggerNonUserCode()>
		Protected Friend ReadOnly Property Adapter As OleDbDataAdapter
			Get
				Dim flag As Boolean = Me._adapter Is Nothing
				If flag Then
					Me.InitAdapter()
				End If
				Return Me._adapter
			End Get
		End Property

		' Token: 0x17000107 RID: 263
		' (get) Token: 0x0600032D RID: 813 RVA: 0x03D7CBA4 File Offset: 0x03D7AFA4
		' (set) Token: 0x0600032E RID: 814 RVA: 0x03D7CBD4 File Offset: 0x03D7AFD4
		<DebuggerNonUserCode()>
		Friend Property Connection As OleDbConnection
			Get
				Dim flag As Boolean = Me._connection Is Nothing
				If flag Then
					Me.InitConnection()
				End If
				Return Me._connection
			End Get
			Set(value As OleDbConnection)
				Me._connection = value
				Dim flag As Boolean = Me.Adapter.InsertCommand IsNot Nothing
				If flag Then
					Me.Adapter.InsertCommand.Connection = value
				End If
				flag = Me.Adapter.DeleteCommand IsNot Nothing
				If flag Then
					Me.Adapter.DeleteCommand.Connection = value
				End If
				flag = Me.Adapter.UpdateCommand IsNot Nothing
				If flag Then
					Me.Adapter.UpdateCommand.Connection = value
				End If
				For i As Integer = 0 To Me.CommandCollection.Length - 1
					flag = Me.CommandCollection(i) IsNot Nothing
					If flag Then
						Me.CommandCollection(i).Connection = value
					End If
				Next
			End Set
		End Property

		' Token: 0x17000108 RID: 264
		' (get) Token: 0x0600032F RID: 815 RVA: 0x03D7CC9C File Offset: 0x03D7B09C
		' (set) Token: 0x06000330 RID: 816 RVA: 0x03D7CCB4 File Offset: 0x03D7B0B4
		<DebuggerNonUserCode()>
		Friend Property Transaction As OleDbTransaction
			Get
				Return Me._transaction
			End Get
			Set(value As OleDbTransaction)
				Me._transaction = value
				For i As Integer = 0 To Me.CommandCollection.Length - 1
					Me.CommandCollection(i).Transaction = Me._transaction
				Next
				Dim flag As Boolean = Me.Adapter IsNot Nothing AndAlso Me.Adapter.DeleteCommand IsNot Nothing
				If flag Then
					Me.Adapter.DeleteCommand.Transaction = Me._transaction
				End If
				flag = Me.Adapter IsNot Nothing AndAlso Me.Adapter.InsertCommand IsNot Nothing
				If flag Then
					Me.Adapter.InsertCommand.Transaction = Me._transaction
				End If
				flag = Me.Adapter IsNot Nothing AndAlso Me.Adapter.UpdateCommand IsNot Nothing
				If flag Then
					Me.Adapter.UpdateCommand.Transaction = Me._transaction
				End If
			End Set
		End Property

		' Token: 0x17000109 RID: 265
		' (get) Token: 0x06000331 RID: 817 RVA: 0x03D7CD98 File Offset: 0x03D7B198
		<DebuggerNonUserCode()>
		Protected ReadOnly Property CommandCollection As OleDbCommand()
			Get
				Dim flag As Boolean = Me._commandCollection Is Nothing
				If flag Then
					Me.InitCommandCollection()
				End If
				Return Me._commandCollection
			End Get
		End Property

		' Token: 0x1700010A RID: 266
		' (get) Token: 0x06000332 RID: 818 RVA: 0x03D7CDC8 File Offset: 0x03D7B1C8
		' (set) Token: 0x06000333 RID: 819 RVA: 0x03D7CDE0 File Offset: 0x03D7B1E0
		<DebuggerNonUserCode()>
		Public Property ClearBeforeFill As Boolean
			Get
				Return Me._clearBeforeFill
			End Get
			Set(value As Boolean)
				Me._clearBeforeFill = value
			End Set
		End Property

		' Token: 0x06000334 RID: 820 RVA: 0x03D7CDEC File Offset: 0x03D7B1EC
		<DebuggerNonUserCode()>
		Private Sub InitAdapter()
			Me._adapter = New OleDbDataAdapter()
			Dim dataTableMapping As DataTableMapping = New DataTableMapping()
			dataTableMapping.SourceTable = "Table"
			dataTableMapping.DataSetTable = "Table1"
			dataTableMapping.ColumnMappings.Add("ID", "ID")
			dataTableMapping.ColumnMappings.Add("YourName", "YourName")
			dataTableMapping.ColumnMappings.Add("LastName", "LastName")
			dataTableMapping.ColumnMappings.Add("Phone", "Phone")
			dataTableMapping.ColumnMappings.Add("Email", "Email")
			dataTableMapping.ColumnMappings.Add("Facebook", "Facebook")
			Me._adapter.TableMappings.Add(dataTableMapping)
			Me._adapter.DeleteCommand = New OleDbCommand()
			Me._adapter.DeleteCommand.Connection = Me.Connection
			Me._adapter.DeleteCommand.CommandText = "DELETE FROM `Table1` WHERE ((`ID` = ?) AND ((? = 1 AND `YourName` IS NULL) OR (`YourName` = ?)) AND ((? = 1 AND `LastName` IS NULL) OR (`LastName` = ?)) AND ((? = 1 AND `Phone` IS NULL) OR (`Phone` = ?)) AND ((? = 1 AND `Email` IS NULL) OR (`Email` = ?)) AND ((? = 1 AND `Facebook` IS NULL) OR (`Facebook` = ?)))"
			Me._adapter.DeleteCommand.CommandType = CommandType.Text
			Me._adapter.DeleteCommand.Parameters.Add(New OleDbParameter("Original_ID", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "ID", DataRowVersion.Original, False, Nothing))
			Me._adapter.DeleteCommand.Parameters.Add(New OleDbParameter("IsNull_YourName", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "YourName", DataRowVersion.Original, True, Nothing))
			Me._adapter.DeleteCommand.Parameters.Add(New OleDbParameter("Original_YourName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "YourName", DataRowVersion.Original, False, Nothing))
			Me._adapter.DeleteCommand.Parameters.Add(New OleDbParameter("IsNull_LastName", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "LastName", DataRowVersion.Original, True, Nothing))
			Me._adapter.DeleteCommand.Parameters.Add(New OleDbParameter("Original_LastName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LastName", DataRowVersion.Original, False, Nothing))
			Me._adapter.DeleteCommand.Parameters.Add(New OleDbParameter("IsNull_Phone", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "Phone", DataRowVersion.Original, True, Nothing))
			Me._adapter.DeleteCommand.Parameters.Add(New OleDbParameter("Original_Phone", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Phone", DataRowVersion.Original, False, Nothing))
			Me._adapter.DeleteCommand.Parameters.Add(New OleDbParameter("IsNull_Email", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "Email", DataRowVersion.Original, True, Nothing))
			Me._adapter.DeleteCommand.Parameters.Add(New OleDbParameter("Original_Email", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Email", DataRowVersion.Original, False, Nothing))
			Me._adapter.DeleteCommand.Parameters.Add(New OleDbParameter("IsNull_Facebook", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "Facebook", DataRowVersion.Original, True, Nothing))
			Me._adapter.DeleteCommand.Parameters.Add(New OleDbParameter("Original_Facebook", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Facebook", DataRowVersion.Original, False, Nothing))
			Me._adapter.InsertCommand = New OleDbCommand()
			Me._adapter.InsertCommand.Connection = Me.Connection
			Me._adapter.InsertCommand.CommandText = "INSERT INTO `Table1` (`YourName`, `LastName`, `Phone`, `Email`, `Facebook`) VALUES (?, ?, ?, ?, ?)"
			Me._adapter.InsertCommand.CommandType = CommandType.Text
			Me._adapter.InsertCommand.Parameters.Add(New OleDbParameter("YourName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "YourName", DataRowVersion.Current, False, Nothing))
			Me._adapter.InsertCommand.Parameters.Add(New OleDbParameter("LastName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LastName", DataRowVersion.Current, False, Nothing))
			Me._adapter.InsertCommand.Parameters.Add(New OleDbParameter("Phone", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Phone", DataRowVersion.Current, False, Nothing))
			Me._adapter.InsertCommand.Parameters.Add(New OleDbParameter("Email", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Email", DataRowVersion.Current, False, Nothing))
			Me._adapter.InsertCommand.Parameters.Add(New OleDbParameter("Facebook", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Facebook", DataRowVersion.Current, False, Nothing))
			Me._adapter.UpdateCommand = New OleDbCommand()
			Me._adapter.UpdateCommand.Connection = Me.Connection
			Me._adapter.UpdateCommand.CommandText = "UPDATE `Table1` SET `YourName` = ?, `LastName` = ?, `Phone` = ?, `Email` = ?, `Facebook` = ? WHERE ((`ID` = ?) AND ((? = 1 AND `YourName` IS NULL) OR (`YourName` = ?)) AND ((? = 1 AND `LastName` IS NULL) OR (`LastName` = ?)) AND ((? = 1 AND `Phone` IS NULL) OR (`Phone` = ?)) AND ((? = 1 AND `Email` IS NULL) OR (`Email` = ?)) AND ((? = 1 AND `Facebook` IS NULL) OR (`Facebook` = ?)))"
			Me._adapter.UpdateCommand.CommandType = CommandType.Text
			Me._adapter.UpdateCommand.Parameters.Add(New OleDbParameter("YourName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "YourName", DataRowVersion.Current, False, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New OleDbParameter("LastName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LastName", DataRowVersion.Current, False, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New OleDbParameter("Phone", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Phone", DataRowVersion.Current, False, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New OleDbParameter("Email", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Email", DataRowVersion.Current, False, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New OleDbParameter("Facebook", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Facebook", DataRowVersion.Current, False, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New OleDbParameter("Original_ID", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "ID", DataRowVersion.Original, False, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New OleDbParameter("IsNull_YourName", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "YourName", DataRowVersion.Original, True, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New OleDbParameter("Original_YourName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "YourName", DataRowVersion.Original, False, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New OleDbParameter("IsNull_LastName", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "LastName", DataRowVersion.Original, True, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New OleDbParameter("Original_LastName", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LastName", DataRowVersion.Original, False, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New OleDbParameter("IsNull_Phone", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "Phone", DataRowVersion.Original, True, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New OleDbParameter("Original_Phone", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Phone", DataRowVersion.Original, False, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New OleDbParameter("IsNull_Email", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "Email", DataRowVersion.Original, True, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New OleDbParameter("Original_Email", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Email", DataRowVersion.Original, False, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New OleDbParameter("IsNull_Facebook", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "Facebook", DataRowVersion.Original, True, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New OleDbParameter("Original_Facebook", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Facebook", DataRowVersion.Original, False, Nothing))
		End Sub

		' Token: 0x06000335 RID: 821 RVA: 0x03D7D61C File Offset: 0x03D7BA1C
		<DebuggerNonUserCode()>
		Private Sub InitConnection()
		End Sub

		' Token: 0x06000336 RID: 822 RVA: 0x03D7D620 File Offset: 0x03D7BA20
		<DebuggerNonUserCode()>
		Private Sub InitCommandCollection()
			Me._commandCollection = New OleDbCommand(0) {}
			Me._commandCollection(0) = New OleDbCommand()
			Me._commandCollection(0).Connection = Me.Connection
			Me._commandCollection(0).CommandText = "SELECT ID, YourName, LastName, Phone, Email, Facebook FROM Table1"
			Me._commandCollection(0).CommandType = CommandType.Text
		End Sub

		' Token: 0x06000337 RID: 823 RVA: 0x03D7D680 File Offset: 0x03D7BA80
		<DataObjectMethod(DataObjectMethodType.Fill, True)>
		<HelpKeyword("vs.data.TableAdapter")>
		<DebuggerNonUserCode()>
		Public Overridable Function Fill(dataTable As Database1DataSet.Table1DataTable) As Integer
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			Dim clearBeforeFill As Boolean = Me.ClearBeforeFill
			If clearBeforeFill Then
				dataTable.Clear()
			End If
			Return Me.Adapter.Fill(dataTable)
		End Function

		' Token: 0x06000338 RID: 824 RVA: 0x03D7D6C8 File Offset: 0x03D7BAC8
		<HelpKeyword("vs.data.TableAdapter")>
		<DataObjectMethod(DataObjectMethodType.[Select], True)>
		<DebuggerNonUserCode()>
		Public Overridable Function GetData() As Database1DataSet.Table1DataTable
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			Dim table1DataTable As Database1DataSet.Table1DataTable = New Database1DataSet.Table1DataTable()
			Me.Adapter.Fill(table1DataTable)
			Return table1DataTable
		End Function

		' Token: 0x06000339 RID: 825 RVA: 0x03D7D704 File Offset: 0x03D7BB04
		<DebuggerNonUserCode()>
		<HelpKeyword("vs.data.TableAdapter")>
		Public Overridable Function Update(dataTable As Database1DataSet.Table1DataTable) As Integer
			Return Me.Adapter.Update(dataTable)
		End Function

		' Token: 0x0600033A RID: 826 RVA: 0x03D7D724 File Offset: 0x03D7BB24
		<DebuggerNonUserCode()>
		<HelpKeyword("vs.data.TableAdapter")>
		Public Overridable Function Update(dataSet As Database1DataSet) As Integer
			Return Me.Adapter.Update(dataSet, "Table1")
		End Function

		' Token: 0x0600033B RID: 827 RVA: 0x03D7D748 File Offset: 0x03D7BB48
		<DebuggerNonUserCode()>
		<HelpKeyword("vs.data.TableAdapter")>
		Public Overridable Function Update(dataRow As DataRow) As Integer
			Return Me.Adapter.Update(New DataRow() { dataRow })
		End Function

		' Token: 0x0600033C RID: 828 RVA: 0x03D7D774 File Offset: 0x03D7BB74
		<HelpKeyword("vs.data.TableAdapter")>
		<DebuggerNonUserCode()>
		Public Overridable Function Update(dataRows As DataRow()) As Integer
			Return Me.Adapter.Update(dataRows)
		End Function

		' Token: 0x0600033D RID: 829 RVA: 0x03D7D794 File Offset: 0x03D7BB94
		<DebuggerNonUserCode()>
		<DataObjectMethod(DataObjectMethodType.Delete, True)>
		<HelpKeyword("vs.data.TableAdapter")>
		Public Overridable Function Delete(Original_ID As Integer, Original_YourName As String, Original_LastName As String, Original_Phone As String, Original_Email As String, Original_Facebook As String) As Integer
			Me.Adapter.DeleteCommand.Parameters(0).Value = Original_ID
			Dim flag As Boolean = Original_YourName = Nothing
			If flag Then
				Me.Adapter.DeleteCommand.Parameters(1).Value = 1
				Me.Adapter.DeleteCommand.Parameters(2).Value = DBNull.Value
			Else
				Me.Adapter.DeleteCommand.Parameters(1).Value = 0
				Me.Adapter.DeleteCommand.Parameters(2).Value = Original_YourName
			End If
			flag = Original_LastName = Nothing
			If flag Then
				Me.Adapter.DeleteCommand.Parameters(3).Value = 1
				Me.Adapter.DeleteCommand.Parameters(4).Value = DBNull.Value
			Else
				Me.Adapter.DeleteCommand.Parameters(3).Value = 0
				Me.Adapter.DeleteCommand.Parameters(4).Value = Original_LastName
			End If
			flag = Original_Phone = Nothing
			If flag Then
				Me.Adapter.DeleteCommand.Parameters(5).Value = 1
				Me.Adapter.DeleteCommand.Parameters(6).Value = DBNull.Value
			Else
				Me.Adapter.DeleteCommand.Parameters(5).Value = 0
				Me.Adapter.DeleteCommand.Parameters(6).Value = Original_Phone
			End If
			flag = Original_Email = Nothing
			If flag Then
				Me.Adapter.DeleteCommand.Parameters(7).Value = 1
				Me.Adapter.DeleteCommand.Parameters(8).Value = DBNull.Value
			Else
				Me.Adapter.DeleteCommand.Parameters(7).Value = 0
				Me.Adapter.DeleteCommand.Parameters(8).Value = Original_Email
			End If
			flag = Original_Facebook = Nothing
			If flag Then
				Me.Adapter.DeleteCommand.Parameters(9).Value = 1
				Me.Adapter.DeleteCommand.Parameters(10).Value = DBNull.Value
			Else
				Me.Adapter.DeleteCommand.Parameters(9).Value = 0
				Me.Adapter.DeleteCommand.Parameters(10).Value = Original_Facebook
			End If
			Dim state As ConnectionState = Me.Adapter.DeleteCommand.Connection.State
			flag = (Me.Adapter.DeleteCommand.Connection.State And ConnectionState.Open) <> ConnectionState.Open
			If flag Then
				Me.Adapter.DeleteCommand.Connection.Open()
			End If
			Dim num2 As Integer
			Try
				Dim num As Integer = Me.Adapter.DeleteCommand.ExecuteNonQuery()
				num2 = num
			Finally
				flag = state = ConnectionState.Closed
				If flag Then
					Me.Adapter.DeleteCommand.Connection.Close()
				End If
			End Try
			Return num2
		End Function

		' Token: 0x0600033E RID: 830 RVA: 0x03D7DB30 File Offset: 0x03D7BF30
		<DataObjectMethod(DataObjectMethodType.Insert, True)>
		<DebuggerNonUserCode()>
		<HelpKeyword("vs.data.TableAdapter")>
		Public Overridable Function Insert(YourName As String, LastName As String, Phone As String, Email As String, Facebook As String) As Integer
			Dim flag As Boolean = YourName = Nothing
			If flag Then
				Me.Adapter.InsertCommand.Parameters(0).Value = DBNull.Value
			Else
				Me.Adapter.InsertCommand.Parameters(0).Value = YourName
			End If
			flag = LastName = Nothing
			If flag Then
				Me.Adapter.InsertCommand.Parameters(1).Value = DBNull.Value
			Else
				Me.Adapter.InsertCommand.Parameters(1).Value = LastName
			End If
			flag = Phone = Nothing
			If flag Then
				Me.Adapter.InsertCommand.Parameters(2).Value = DBNull.Value
			Else
				Me.Adapter.InsertCommand.Parameters(2).Value = Phone
			End If
			flag = Email = Nothing
			If flag Then
				Me.Adapter.InsertCommand.Parameters(3).Value = DBNull.Value
			Else
				Me.Adapter.InsertCommand.Parameters(3).Value = Email
			End If
			flag = Facebook = Nothing
			If flag Then
				Me.Adapter.InsertCommand.Parameters(4).Value = DBNull.Value
			Else
				Me.Adapter.InsertCommand.Parameters(4).Value = Facebook
			End If
			Dim state As ConnectionState = Me.Adapter.InsertCommand.Connection.State
			flag = (Me.Adapter.InsertCommand.Connection.State And ConnectionState.Open) <> ConnectionState.Open
			If flag Then
				Me.Adapter.InsertCommand.Connection.Open()
			End If
			Dim num2 As Integer
			Try
				Dim num As Integer = Me.Adapter.InsertCommand.ExecuteNonQuery()
				num2 = num
			Finally
				flag = state = ConnectionState.Closed
				If flag Then
					Me.Adapter.InsertCommand.Connection.Close()
				End If
			End Try
			Return num2
		End Function

		' Token: 0x0600033F RID: 831 RVA: 0x03D7DD50 File Offset: 0x03D7C150
		<HelpKeyword("vs.data.TableAdapter")>
		<DebuggerNonUserCode()>
		<DataObjectMethod(DataObjectMethodType.Update, True)>
		Public Overridable Function Update(YourName As String, LastName As String, Phone As String, Email As String, Facebook As String, Original_ID As Integer, Original_YourName As String, Original_LastName As String, Original_Phone As String, Original_Email As String, Original_Facebook As String) As Integer
			Dim flag As Boolean = YourName = Nothing
			If flag Then
				Me.Adapter.UpdateCommand.Parameters(0).Value = DBNull.Value
			Else
				Me.Adapter.UpdateCommand.Parameters(0).Value = YourName
			End If
			flag = LastName = Nothing
			If flag Then
				Me.Adapter.UpdateCommand.Parameters(1).Value = DBNull.Value
			Else
				Me.Adapter.UpdateCommand.Parameters(1).Value = LastName
			End If
			flag = Phone = Nothing
			If flag Then
				Me.Adapter.UpdateCommand.Parameters(2).Value = DBNull.Value
			Else
				Me.Adapter.UpdateCommand.Parameters(2).Value = Phone
			End If
			flag = Email = Nothing
			If flag Then
				Me.Adapter.UpdateCommand.Parameters(3).Value = DBNull.Value
			Else
				Me.Adapter.UpdateCommand.Parameters(3).Value = Email
			End If
			flag = Facebook = Nothing
			If flag Then
				Me.Adapter.UpdateCommand.Parameters(4).Value = DBNull.Value
			Else
				Me.Adapter.UpdateCommand.Parameters(4).Value = Facebook
			End If
			Me.Adapter.UpdateCommand.Parameters(5).Value = Original_ID
			flag = Original_YourName = Nothing
			If flag Then
				Me.Adapter.UpdateCommand.Parameters(6).Value = 1
				Me.Adapter.UpdateCommand.Parameters(7).Value = DBNull.Value
			Else
				Me.Adapter.UpdateCommand.Parameters(6).Value = 0
				Me.Adapter.UpdateCommand.Parameters(7).Value = Original_YourName
			End If
			flag = Original_LastName = Nothing
			If flag Then
				Me.Adapter.UpdateCommand.Parameters(8).Value = 1
				Me.Adapter.UpdateCommand.Parameters(9).Value = DBNull.Value
			Else
				Me.Adapter.UpdateCommand.Parameters(8).Value = 0
				Me.Adapter.UpdateCommand.Parameters(9).Value = Original_LastName
			End If
			flag = Original_Phone = Nothing
			If flag Then
				Me.Adapter.UpdateCommand.Parameters(10).Value = 1
				Me.Adapter.UpdateCommand.Parameters(11).Value = DBNull.Value
			Else
				Me.Adapter.UpdateCommand.Parameters(10).Value = 0
				Me.Adapter.UpdateCommand.Parameters(11).Value = Original_Phone
			End If
			flag = Original_Email = Nothing
			If flag Then
				Me.Adapter.UpdateCommand.Parameters(12).Value = 1
				Me.Adapter.UpdateCommand.Parameters(13).Value = DBNull.Value
			Else
				Me.Adapter.UpdateCommand.Parameters(12).Value = 0
				Me.Adapter.UpdateCommand.Parameters(13).Value = Original_Email
			End If
			flag = Original_Facebook = Nothing
			If flag Then
				Me.Adapter.UpdateCommand.Parameters(14).Value = 1
				Me.Adapter.UpdateCommand.Parameters(15).Value = DBNull.Value
			Else
				Me.Adapter.UpdateCommand.Parameters(14).Value = 0
				Me.Adapter.UpdateCommand.Parameters(15).Value = Original_Facebook
			End If
			Dim state As ConnectionState = Me.Adapter.UpdateCommand.Connection.State
			flag = (Me.Adapter.UpdateCommand.Connection.State And ConnectionState.Open) <> ConnectionState.Open
			If flag Then
				Me.Adapter.UpdateCommand.Connection.Open()
			End If
			Dim num2 As Integer
			Try
				Dim num As Integer = Me.Adapter.UpdateCommand.ExecuteNonQuery()
				num2 = num
			Finally
				flag = state = ConnectionState.Closed
				If flag Then
					Me.Adapter.UpdateCommand.Connection.Close()
				End If
			End Try
			Return num2
		End Function

		' Token: 0x04000139 RID: 313
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400013A RID: 314
		<AccessedThroughProperty("_adapter")>
		Private __adapter As OleDbDataAdapter

		' Token: 0x0400013B RID: 315
		Private _connection As OleDbConnection

		' Token: 0x0400013C RID: 316
		Private _transaction As OleDbTransaction

		' Token: 0x0400013D RID: 317
		Private _commandCollection As OleDbCommand()

		' Token: 0x0400013E RID: 318
		Private _clearBeforeFill As Boolean
	End Class
End Namespace
