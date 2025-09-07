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
	' Token: 0x02000061 RID: 97
	<DesignerGenerated()>
	Public Partial Class Form5
		Inherits Form

		' Token: 0x0600107F RID: 4223 RVA: 0x03DE76CC File Offset: 0x03DE5ACC
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Form5.__ENCList
			SyncLock _ENCList
				Form5.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000572 RID: 1394
		' (get) Token: 0x06001082 RID: 4226 RVA: 0x03DE7CB8 File Offset: 0x03DE60B8
		' (set) Token: 0x06001083 RID: 4227 RVA: 0x03DE7CD0 File Offset: 0x03DE60D0
		Friend Overridable Property Button1 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button1_Click
				Dim flag As Boolean = Me._Button1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button1.Click, eventHandler
				End If
				Me._Button1 = value
				flag = Me._Button1 IsNot Nothing
				If flag Then
					AddHandler Me._Button1.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000573 RID: 1395
		' (get) Token: 0x06001084 RID: 4228 RVA: 0x03DE7D30 File Offset: 0x03DE6130
		' (set) Token: 0x06001085 RID: 4229 RVA: 0x03DE7D48 File Offset: 0x03DE6148
		Friend Overridable Property Button2 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button2_Click
				Dim flag As Boolean = Me._Button2 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button2.Click, eventHandler
				End If
				Me._Button2 = value
				flag = Me._Button2 IsNot Nothing
				If flag Then
					AddHandler Me._Button2.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000574 RID: 1396
		' (get) Token: 0x06001086 RID: 4230 RVA: 0x03DE7DA8 File Offset: 0x03DE61A8
		' (set) Token: 0x06001087 RID: 4231 RVA: 0x03DE7DC0 File Offset: 0x03DE61C0
		Friend Overridable Property Button3 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button3_Click
				Dim flag As Boolean = Me._Button3 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button3.Click, eventHandler
				End If
				Me._Button3 = value
				flag = Me._Button3 IsNot Nothing
				If flag Then
					AddHandler Me._Button3.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000575 RID: 1397
		' (get) Token: 0x06001088 RID: 4232 RVA: 0x03DE7E20 File Offset: 0x03DE6220
		' (set) Token: 0x06001089 RID: 4233 RVA: 0x03DE7E38 File Offset: 0x03DE6238
		Friend Overridable Property Button4 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button4_Click
				Dim flag As Boolean = Me._Button4 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button4.Click, eventHandler
				End If
				Me._Button4 = value
				flag = Me._Button4 IsNot Nothing
				If flag Then
					AddHandler Me._Button4.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000576 RID: 1398
		' (get) Token: 0x0600108A RID: 4234 RVA: 0x03DE7E98 File Offset: 0x03DE6298
		' (set) Token: 0x0600108B RID: 4235 RVA: 0x03DE7EB0 File Offset: 0x03DE62B0
		Friend Overridable Property Button5 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button5_Click
				Dim flag As Boolean = Me._Button5 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button5.Click, eventHandler
				End If
				Me._Button5 = value
				flag = Me._Button5 IsNot Nothing
				If flag Then
					AddHandler Me._Button5.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000577 RID: 1399
		' (get) Token: 0x0600108C RID: 4236 RVA: 0x03DE7F10 File Offset: 0x03DE6310
		' (set) Token: 0x0600108D RID: 4237 RVA: 0x03DE7F28 File Offset: 0x03DE6328
		Friend Overridable Property Button6 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button6_Click
				Dim flag As Boolean = Me._Button6 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button6.Click, eventHandler
				End If
				Me._Button6 = value
				flag = Me._Button6 IsNot Nothing
				If flag Then
					AddHandler Me._Button6.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000578 RID: 1400
		' (get) Token: 0x0600108E RID: 4238 RVA: 0x03DE7F88 File Offset: 0x03DE6388
		' (set) Token: 0x0600108F RID: 4239 RVA: 0x03DE7FA0 File Offset: 0x03DE63A0
		Friend Overridable Property Button7 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button7_Click
				Dim flag As Boolean = Me._Button7 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button7.Click, eventHandler
				End If
				Me._Button7 = value
				flag = Me._Button7 IsNot Nothing
				If flag Then
					AddHandler Me._Button7.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000579 RID: 1401
		' (get) Token: 0x06001090 RID: 4240 RVA: 0x03DE8000 File Offset: 0x03DE6400
		' (set) Token: 0x06001091 RID: 4241 RVA: 0x03DE8018 File Offset: 0x03DE6418
		Friend Overridable Property Button8 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button8_Click
				Dim flag As Boolean = Me._Button8 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button8.Click, eventHandler
				End If
				Me._Button8 = value
				flag = Me._Button8 IsNot Nothing
				If flag Then
					AddHandler Me._Button8.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x06001092 RID: 4242 RVA: 0x03DE8078 File Offset: 0x03DE6478
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form6.Show()
		End Sub

		' Token: 0x06001093 RID: 4243 RVA: 0x03DE808C File Offset: 0x03DE648C
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form7.Show()
		End Sub

		' Token: 0x06001094 RID: 4244 RVA: 0x03DE80A0 File Offset: 0x03DE64A0
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form20.Show()
		End Sub

		' Token: 0x06001095 RID: 4245 RVA: 0x03DE80B4 File Offset: 0x03DE64B4
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form10.Show()
		End Sub

		' Token: 0x06001096 RID: 4246 RVA: 0x03DE80C8 File Offset: 0x03DE64C8
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form12.Show()
		End Sub

		' Token: 0x06001097 RID: 4247 RVA: 0x03DE80DC File Offset: 0x03DE64DC
		Private Sub Button6_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form21.Show()
		End Sub

		' Token: 0x06001098 RID: 4248 RVA: 0x03DE80F0 File Offset: 0x03DE64F0
		Private Sub Button7_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form22.Show()
		End Sub

		' Token: 0x06001099 RID: 4249 RVA: 0x03DE8104 File Offset: 0x03DE6504
		Private Sub Button8_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form34.Show()
		End Sub

		' Token: 0x0400061C RID: 1564
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400061E RID: 1566
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400061F RID: 1567
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x04000620 RID: 1568
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x04000621 RID: 1569
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x04000622 RID: 1570
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x04000623 RID: 1571
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x04000624 RID: 1572
		<AccessedThroughProperty("Button7")>
		Private _Button7 As Button

		' Token: 0x04000625 RID: 1573
		<AccessedThroughProperty("Button8")>
		Private _Button8 As Button
	End Class
End Namespace
