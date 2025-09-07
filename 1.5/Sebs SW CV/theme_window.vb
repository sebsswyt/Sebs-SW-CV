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
	' Token: 0x02000077 RID: 119
	<DesignerGenerated()>
	Public Partial Class theme_window
		Inherits Form

		' Token: 0x060012C5 RID: 4805 RVA: 0x03DF6C08 File Offset: 0x03DF5008
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = theme_window.__ENCList
			SyncLock _ENCList
				theme_window.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700063A RID: 1594
		' (get) Token: 0x060012C8 RID: 4808 RVA: 0x03DF71D8 File Offset: 0x03DF55D8
		' (set) Token: 0x060012C9 RID: 4809 RVA: 0x03DF71F0 File Offset: 0x03DF55F0
		Friend Overridable Property Panel1 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel1 = value
			End Set
		End Property

		' Token: 0x1700063B RID: 1595
		' (get) Token: 0x060012CA RID: 4810 RVA: 0x03DF71FC File Offset: 0x03DF55FC
		' (set) Token: 0x060012CB RID: 4811 RVA: 0x03DF7214 File Offset: 0x03DF5614
		Friend Overridable Property Button3 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button3 = value
			End Set
		End Property

		' Token: 0x1700063C RID: 1596
		' (get) Token: 0x060012CC RID: 4812 RVA: 0x03DF7220 File Offset: 0x03DF5620
		' (set) Token: 0x060012CD RID: 4813 RVA: 0x03DF7238 File Offset: 0x03DF5638
		Friend Overridable Property Button1 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button1 = value
			End Set
		End Property

		' Token: 0x1700063D RID: 1597
		' (get) Token: 0x060012CE RID: 4814 RVA: 0x03DF7244 File Offset: 0x03DF5644
		' (set) Token: 0x060012CF RID: 4815 RVA: 0x03DF725C File Offset: 0x03DF565C
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

		' Token: 0x1700063E RID: 1598
		' (get) Token: 0x060012D0 RID: 4816 RVA: 0x03DF72BC File Offset: 0x03DF56BC
		' (set) Token: 0x060012D1 RID: 4817 RVA: 0x03DF72D4 File Offset: 0x03DF56D4
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

		' Token: 0x1700063F RID: 1599
		' (get) Token: 0x060012D2 RID: 4818 RVA: 0x03DF7334 File Offset: 0x03DF5734
		' (set) Token: 0x060012D3 RID: 4819 RVA: 0x03DF734C File Offset: 0x03DF574C
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

		' Token: 0x17000640 RID: 1600
		' (get) Token: 0x060012D4 RID: 4820 RVA: 0x03DF73AC File Offset: 0x03DF57AC
		' (set) Token: 0x060012D5 RID: 4821 RVA: 0x03DF73C4 File Offset: 0x03DF57C4
		Friend Overridable Property ColorDialog1 As ColorDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._ColorDialog1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColorDialog)
				Me._ColorDialog1 = value
			End Set
		End Property

		' Token: 0x060012D6 RID: 4822 RVA: 0x03DF73D0 File Offset: 0x03DF57D0
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form_1pad.Panel1.BackColor = Color.Black
		End Sub

		' Token: 0x060012D7 RID: 4823 RVA: 0x03DF73F0 File Offset: 0x03DF57F0
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.WindowState = FormWindowState.Normal
			If flag Then
				Me.WindowState = FormWindowState.Maximized
			Else
				Me.WindowState = FormWindowState.Normal
			End If
		End Sub

		' Token: 0x060012D8 RID: 4824 RVA: 0x03DF7420 File Offset: 0x03DF5820
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ColorDialog1.ShowDialog() = DialogResult.OK
			If flag Then
				MyProject.Forms.Form_1pad.Panel1.BackColor = Me.ColorDialog1.Color
				MyProject.Forms.Form21.Panel5.BackColor = Me.ColorDialog1.Color
			End If
		End Sub

		' Token: 0x0400070A RID: 1802
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400070C RID: 1804
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x0400070D RID: 1805
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x0400070E RID: 1806
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400070F RID: 1807
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x04000710 RID: 1808
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x04000711 RID: 1809
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x04000712 RID: 1810
		<AccessedThroughProperty("ColorDialog1")>
		Private _ColorDialog1 As ColorDialog
	End Class
End Namespace
