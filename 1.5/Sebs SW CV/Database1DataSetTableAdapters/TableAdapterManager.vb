Imports System
Imports System.CodeDom.Compiler
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Data
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Diagnostics

Namespace CV.Database1DataSetTableAdapters
	' Token: 0x0200002B RID: 43
	<HelpKeyword("vs.data.TableAdapterManager")>
	<DesignerCategory("code")>
	<ToolboxItem(True)>
	<Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")>
	<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")>
	Public Class TableAdapterManager
		Inherits Component

		' Token: 0x06000341 RID: 833 RVA: 0x03D7E280 File Offset: 0x03D7C680
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = TableAdapterManager.__ENCList
			SyncLock _ENCList
				TableAdapterManager.__ENCList.Add(New WeakReference(Me))
			End SyncLock
		End Sub

		' Token: 0x1700010B RID: 267
		' (get) Token: 0x06000342 RID: 834 RVA: 0x03D7E2D0 File Offset: 0x03D7C6D0
		' (set) Token: 0x06000343 RID: 835 RVA: 0x03D7E2E8 File Offset: 0x03D7C6E8
		<DebuggerNonUserCode()>
		Public Property UpdateOrder As TableAdapterManager.UpdateOrderOption
			Get
				Return Me._updateOrder
			End Get
			Set(value As TableAdapterManager.UpdateOrderOption)
				Me._updateOrder = value
			End Set
		End Property

		' Token: 0x1700010C RID: 268
		' (get) Token: 0x06000344 RID: 836 RVA: 0x03D7E2F4 File Offset: 0x03D7C6F4
		' (set) Token: 0x06000345 RID: 837 RVA: 0x03D7E30C File Offset: 0x03D7C70C
		<Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
		<DebuggerNonUserCode()>
		Public Property Table1TableAdapter As Table1TableAdapter
			Get
				Return Me._table1TableAdapter
			End Get
			Set(value As Table1TableAdapter)
				Me._table1TableAdapter = value
			End Set
		End Property

		' Token: 0x1700010D RID: 269
		' (get) Token: 0x06000346 RID: 838 RVA: 0x03D7E318 File Offset: 0x03D7C718
		' (set) Token: 0x06000347 RID: 839 RVA: 0x03D7E330 File Offset: 0x03D7C730
		<DebuggerNonUserCode()>
		Public Property BackupDataSetBeforeUpdate As Boolean
			Get
				Return Me._backupDataSetBeforeUpdate
			End Get
			Set(value As Boolean)
				Me._backupDataSetBeforeUpdate = value
			End Set
		End Property

		' Token: 0x1700010E RID: 270
		' (get) Token: 0x06000348 RID: 840 RVA: 0x03D7E33C File Offset: 0x03D7C73C
		' (set) Token: 0x06000349 RID: 841 RVA: 0x03D7E398 File Offset: 0x03D7C798
		<DebuggerNonUserCode()>
		<Browsable(False)>
		Public Property Connection As IDbConnection
			Get
				Dim flag As Boolean = Me._connection IsNot Nothing
				Dim dbConnection As IDbConnection
				If flag Then
					dbConnection = Me._connection
				Else
					flag = Me._table1TableAdapter IsNot Nothing AndAlso Me._table1TableAdapter.Connection IsNot Nothing
					If flag Then
						dbConnection = Me._table1TableAdapter.Connection
					Else
						dbConnection = Nothing
					End If
				End If
				Return dbConnection
			End Get
			Set(value As IDbConnection)
				Me._connection = value
			End Set
		End Property

		' Token: 0x1700010F RID: 271
		' (get) Token: 0x0600034A RID: 842 RVA: 0x03D7E3A4 File Offset: 0x03D7C7A4
		<DebuggerNonUserCode()>
		<Browsable(False)>
		Public ReadOnly Property TableAdapterInstanceCount As Integer
			Get
				Dim num As Integer = 0
				Dim flag As Boolean = Me._table1TableAdapter IsNot Nothing
				If flag Then
					num += 1
				End If
				Return num
			End Get
		End Property

		' Token: 0x0600034B RID: 843 RVA: 0x03D7E3D0 File Offset: 0x03D7C7D0
		<DebuggerNonUserCode()>
		Private Function UpdateUpdatedRows(dataSet As Database1DataSet, allChangedRows As List(Of DataRow), allAddedRows As List(Of DataRow)) As Integer
			Dim num As Integer = 0
			Dim flag As Boolean = Me._table1TableAdapter IsNot Nothing
			If flag Then
				Dim array As DataRow() = dataSet.Table1.[Select](Nothing, Nothing, DataViewRowState.ModifiedCurrent)
				array = Me.GetRealUpdatedRows(array, allAddedRows)
				flag = array IsNot Nothing AndAlso 0 < array.Length
				If flag Then
					num += Me._table1TableAdapter.Update(array)
					allChangedRows.AddRange(array)
				End If
			End If
			Return num
		End Function

		' Token: 0x0600034C RID: 844 RVA: 0x03D7E438 File Offset: 0x03D7C838
		<DebuggerNonUserCode()>
		Private Function UpdateInsertedRows(dataSet As Database1DataSet, allAddedRows As List(Of DataRow)) As Integer
			Dim num As Integer = 0
			Dim flag As Boolean = Me._table1TableAdapter IsNot Nothing
			If flag Then
				Dim array As DataRow() = dataSet.Table1.[Select](Nothing, Nothing, DataViewRowState.Added)
				flag = array IsNot Nothing AndAlso 0 < array.Length
				If flag Then
					num += Me._table1TableAdapter.Update(array)
					allAddedRows.AddRange(array)
				End If
			End If
			Return num
		End Function

		' Token: 0x0600034D RID: 845 RVA: 0x03D7E498 File Offset: 0x03D7C898
		<DebuggerNonUserCode()>
		Private Function UpdateDeletedRows(dataSet As Database1DataSet, allChangedRows As List(Of DataRow)) As Integer
			Dim num As Integer = 0
			Dim flag As Boolean = Me._table1TableAdapter IsNot Nothing
			If flag Then
				Dim array As DataRow() = dataSet.Table1.[Select](Nothing, Nothing, DataViewRowState.Deleted)
				flag = array IsNot Nothing AndAlso 0 < array.Length
				If flag Then
					num += Me._table1TableAdapter.Update(array)
					allChangedRows.AddRange(array)
				End If
			End If
			Return num
		End Function

		' Token: 0x0600034E RID: 846 RVA: 0x03D7E4F8 File Offset: 0x03D7C8F8
		<DebuggerNonUserCode()>
		Private Function GetRealUpdatedRows(updatedRows As DataRow(), allAddedRows As List(Of DataRow)) As DataRow()
			Dim flag As Boolean = updatedRows Is Nothing OrElse updatedRows.Length < 1
			Dim array As DataRow()
			If flag Then
				array = updatedRows
			Else
				flag = allAddedRows Is Nothing OrElse allAddedRows.Count < 1
				If flag Then
					array = updatedRows
				Else
					Dim list As List(Of DataRow) = New List(Of DataRow)()
					For Each dataRow As DataRow In updatedRows
						flag = Not allAddedRows.Contains(dataRow)
						If flag Then
							list.Add(dataRow)
						End If
					Next
					array = list.ToArray()
				End If
			End If
			Return array
		End Function

		' Token: 0x0600034F RID: 847 RVA: 0x03D7E57C File Offset: 0x03D7C97C
		<DebuggerNonUserCode()>
		Public Overridable Function UpdateAll(dataSet As Database1DataSet) As Integer
			Dim flag As Boolean = dataSet Is Nothing
			If flag Then
				Throw New ArgumentNullException("dataSet")
			End If
			flag = Not dataSet.HasChanges()
			Dim num As Integer
			If flag Then
				num = 0
			Else
				flag = Me._table1TableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._table1TableAdapter.Connection)
				If flag Then
					Throw New ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
				End If
				Dim connection As IDbConnection = Me.Connection
				flag = connection Is Nothing
				If flag Then
					Throw New ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterManager TableAdapter property to a valid TableAdapter instance.")
				End If
				Dim flag2 As Boolean = False
				flag = (connection.State And ConnectionState.Broken) = ConnectionState.Broken
				If flag Then
					connection.Close()
				End If
				flag = connection.State = ConnectionState.Closed
				If flag Then
					connection.Open()
					flag2 = True
				End If
				Dim dbTransaction As IDbTransaction = connection.BeginTransaction()
				flag = dbTransaction Is Nothing
				If flag Then
					Throw New ApplicationException("The transaction cannot begin. The current data connection does not support transactions or the current state is not allowing the transaction to begin.")
				End If
				Dim list As List(Of DataRow) = New List(Of DataRow)()
				Dim list2 As List(Of DataRow) = New List(Of DataRow)()
				Dim list3 As List(Of DataAdapter) = New List(Of DataAdapter)()
				Dim dictionary As Dictionary(Of Object, IDbConnection) = New Dictionary(Of Object, IDbConnection)()
				Dim num2 As Integer = 0
				Dim dataSet2 As DataSet = Nothing
				flag = Me.BackupDataSetBeforeUpdate
				If flag Then
					dataSet2 = New DataSet()
					dataSet2.Merge(dataSet)
				End If
				Try
					flag = Me._table1TableAdapter IsNot Nothing
					If flag Then
						dictionary.Add(Me._table1TableAdapter, Me._table1TableAdapter.Connection)
						Me._table1TableAdapter.Connection = CType(connection, OleDbConnection)
						Me._table1TableAdapter.Transaction = CType(dbTransaction, OleDbTransaction)
						flag = Me._table1TableAdapter.Adapter.AcceptChangesDuringUpdate
						If flag Then
							Me._table1TableAdapter.Adapter.AcceptChangesDuringUpdate = False
							list3.Add(Me._table1TableAdapter.Adapter)
						End If
					End If
					flag = Me.UpdateOrder = TableAdapterManager.UpdateOrderOption.UpdateInsertDelete
					If flag Then
						num2 += Me.UpdateUpdatedRows(dataSet, list, list2)
						num2 += Me.UpdateInsertedRows(dataSet, list2)
					Else
						num2 += Me.UpdateInsertedRows(dataSet, list2)
						num2 += Me.UpdateUpdatedRows(dataSet, list, list2)
					End If
					num2 += Me.UpdateDeletedRows(dataSet, list)
					dbTransaction.Commit()
					flag = 0 < list2.Count
					If flag Then
						Dim array As DataRow() = New DataRow(list2.Count - 1 + 1 - 1) {}
						list2.CopyTo(array)
						For Each dataRow As DataRow In array
							dataRow.AcceptChanges()
						Next
					End If
					flag = 0 < list.Count
					If flag Then
						Dim array2 As DataRow() = New DataRow(list.Count - 1 + 1 - 1) {}
						list.CopyTo(array2)
						For Each dataRow2 As DataRow In array2
							dataRow2.AcceptChanges()
						Next
					End If
				Catch ex As Exception
					dbTransaction.Rollback()
					flag = Me.BackupDataSetBeforeUpdate
					If flag Then
						Debug.Assert(dataSet2 IsNot Nothing)
						dataSet.Clear()
						dataSet.Merge(dataSet2)
					Else
						flag = 0 < list2.Count
						If flag Then
							Dim array3 As DataRow() = New DataRow(list2.Count - 1 + 1 - 1) {}
							list2.CopyTo(array3)
							For Each dataRow3 As DataRow In array3
								dataRow3.AcceptChanges()
								dataRow3.SetAdded()
							Next
						End If
					End If
					Throw ex
				Finally
					flag = flag2
					If flag Then
						connection.Close()
					End If
					flag = Me._table1TableAdapter IsNot Nothing
					If flag Then
						Me._table1TableAdapter.Connection = CType(dictionary(Me._table1TableAdapter), OleDbConnection)
						Me._table1TableAdapter.Transaction = Nothing
					End If
					flag = 0 < list3.Count
					If flag Then
						Dim array4 As DataAdapter() = New DataAdapter(list3.Count - 1 + 1 - 1) {}
						list3.CopyTo(array4)
						For Each dataAdapter As DataAdapter In array4
							dataAdapter.AcceptChangesDuringUpdate = True
						Next
					End If
				End Try
				num = num2
			End If
			Return num
		End Function

		' Token: 0x06000350 RID: 848 RVA: 0x03D7E9BC File Offset: 0x03D7CDBC
		<DebuggerNonUserCode()>
		Protected Overridable Sub SortSelfReferenceRows(rows As DataRow(), relation As DataRelation, childFirst As Boolean)
			Array.Sort(Of DataRow)(rows, New TableAdapterManager.SelfReferenceComparer(relation, childFirst))
		End Sub

		' Token: 0x06000351 RID: 849 RVA: 0x03D7E9D0 File Offset: 0x03D7CDD0
		<DebuggerNonUserCode()>
		Protected Overridable Function MatchTableAdapterConnection(inputConnection As IDbConnection) As Boolean
			Dim flag As Boolean = Me._connection IsNot Nothing
			Dim flag2 As Boolean
			If flag Then
				flag2 = True
			Else
				flag = Me.Connection Is Nothing OrElse inputConnection Is Nothing
				If flag Then
					flag2 = True
				Else
					flag = String.Equals(Me.Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal)
					flag2 = flag
				End If
			End If
			Return flag2
		End Function

		' Token: 0x0400013F RID: 319
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000140 RID: 320
		Private _updateOrder As TableAdapterManager.UpdateOrderOption

		' Token: 0x04000141 RID: 321
		Private _table1TableAdapter As Table1TableAdapter

		' Token: 0x04000142 RID: 322
		Private _backupDataSetBeforeUpdate As Boolean

		' Token: 0x04000143 RID: 323
		Private _connection As IDbConnection

		' Token: 0x0200002C RID: 44
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")>
		Public Enum UpdateOrderOption
			' Token: 0x04000145 RID: 325
			InsertUpdateDelete
			' Token: 0x04000146 RID: 326
			UpdateInsertDelete
		End Enum

		' Token: 0x0200002D RID: 45
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")>
		Private Class SelfReferenceComparer
			Implements IComparer(Of DataRow)

			' Token: 0x06000352 RID: 850 RVA: 0x03D7EA30 File Offset: 0x03D7CE30
			<DebuggerNonUserCode()>
			Friend Sub New(relation As DataRelation, childFirst As Boolean)
				Me._relation = relation
				If childFirst Then
					Me._childFirst = -1
				Else
					Me._childFirst = 1
				End If
			End Sub

			' Token: 0x06000353 RID: 851 RVA: 0x03D7EA64 File Offset: 0x03D7CE64
			<DebuggerNonUserCode()>
			Private Function IsChildAndParent(child As DataRow, parent As DataRow) As Boolean
				Debug.Assert(child IsNot Nothing)
				Debug.Assert(parent IsNot Nothing)
				Dim dataRow As DataRow = child.GetParentRow(Me._relation, DataRowVersion.[Default])
				While dataRow IsNot Nothing AndAlso Not Object.ReferenceEquals(dataRow, child) AndAlso Not Object.ReferenceEquals(dataRow, parent)
					dataRow = dataRow.GetParentRow(Me._relation, DataRowVersion.[Default])
				End While
				Dim flag As Boolean = dataRow Is Nothing
				If flag Then
					dataRow = child.GetParentRow(Me._relation, DataRowVersion.Original)
					While dataRow IsNot Nothing AndAlso Not Object.ReferenceEquals(dataRow, child) AndAlso Not Object.ReferenceEquals(dataRow, parent)
						dataRow = dataRow.GetParentRow(Me._relation, DataRowVersion.Original)
					End While
				End If
				Return Object.ReferenceEquals(dataRow, parent)
			End Function

			' Token: 0x06000354 RID: 852 RVA: 0x03D7EB34 File Offset: 0x03D7CF34
			<DebuggerNonUserCode()>
			Public Function Compare(row1 As DataRow, row2 As DataRow) As Integer Implements System.Collections.Generic.IComparer(Of System.Data.DataRow).Compare
				Dim flag As Boolean = Object.ReferenceEquals(row1, row2)
				Dim num As Integer
				If flag Then
					num = 0
				Else
					flag = row1 Is Nothing
					If flag Then
						num = -1
					Else
						flag = row2 Is Nothing
						If flag Then
							num = 1
						Else
							flag = Me.IsChildAndParent(row1, row2)
							If flag Then
								num = Me._childFirst
							Else
								flag = Me.IsChildAndParent(row2, row1)
								If flag Then
									' The following expression was wrapped in a checked-expression
									num = -1 * Me._childFirst
								Else
									num = 0
								End If
							End If
						End If
					End If
				End If
				Return num
			End Function

			' Token: 0x04000147 RID: 327
			Private _relation As DataRelation

			' Token: 0x04000148 RID: 328
			Private _childFirst As Integer
		End Class
	End Class
End Namespace
