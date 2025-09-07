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
	' Token: 0x02000012 RID: 18
	<DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox17
		Inherits Form

		' Token: 0x06000167 RID: 359 RVA: 0x03D852D0 File Offset: 0x03D836D0
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.AboutBox17_Load
			Dim _ENCList As List(Of WeakReference) = AboutBox17.__ENCList
			SyncLock _ENCList
				AboutBox17.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700008C RID: 140
		' (get) Token: 0x0600016A RID: 362 RVA: 0x03D85BE8 File Offset: 0x03D83FE8
		' (set) Token: 0x0600016B RID: 363 RVA: 0x03D85C00 File Offset: 0x03D84000
		Friend Property Button1 As Button
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

		' Token: 0x1700008D RID: 141
		' (get) Token: 0x0600016C RID: 364 RVA: 0x03D85C60 File Offset: 0x03D84060
		' (set) Token: 0x0600016D RID: 365 RVA: 0x03D85C78 File Offset: 0x03D84078
		Friend Property Button2 As Button
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

		' Token: 0x1700008E RID: 142
		' (get) Token: 0x0600016E RID: 366 RVA: 0x03D85CD8 File Offset: 0x03D840D8
		' (set) Token: 0x0600016F RID: 367 RVA: 0x03D85CF0 File Offset: 0x03D840F0
		Friend Property Button3 As Button
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

		' Token: 0x1700008F RID: 143
		' (get) Token: 0x06000170 RID: 368 RVA: 0x03D85D50 File Offset: 0x03D84150
		' (set) Token: 0x06000171 RID: 369 RVA: 0x03D85D68 File Offset: 0x03D84168
		Friend Property Button4 As Button
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

		' Token: 0x17000090 RID: 144
		' (get) Token: 0x06000172 RID: 370 RVA: 0x03D85DC8 File Offset: 0x03D841C8
		' (set) Token: 0x06000173 RID: 371 RVA: 0x03D85DE0 File Offset: 0x03D841E0
		Friend Property Button5 As Button
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

		' Token: 0x17000091 RID: 145
		' (get) Token: 0x06000174 RID: 372 RVA: 0x03D85E40 File Offset: 0x03D84240
		' (set) Token: 0x06000175 RID: 373 RVA: 0x03D85E58 File Offset: 0x03D84258
		Friend Property Panel1 As Panel
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

		' Token: 0x17000092 RID: 146
		' (get) Token: 0x06000176 RID: 374 RVA: 0x03D85E64 File Offset: 0x03D84264
		' (set) Token: 0x06000177 RID: 375 RVA: 0x03D85E7C File Offset: 0x03D8427C
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

		' Token: 0x17000093 RID: 147
		' (get) Token: 0x06000178 RID: 376 RVA: 0x03D85E88 File Offset: 0x03D84288
		' (set) Token: 0x06000179 RID: 377 RVA: 0x03D85EA0 File Offset: 0x03D842A0
		Friend Property Button6 As Button
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

		' Token: 0x17000094 RID: 148
		' (get) Token: 0x0600017A RID: 378 RVA: 0x03D85F00 File Offset: 0x03D84300
		' (set) Token: 0x0600017B RID: 379 RVA: 0x03D85F18 File Offset: 0x03D84318
		Friend Property Button7 As Button
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

		' Token: 0x17000095 RID: 149
		' (get) Token: 0x0600017C RID: 380 RVA: 0x03D85F78 File Offset: 0x03D84378
		' (set) Token: 0x0600017D RID: 381 RVA: 0x03D85F90 File Offset: 0x03D84390
		Friend Property Button8 As Button
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

		' Token: 0x17000096 RID: 150
		' (get) Token: 0x0600017E RID: 382 RVA: 0x03D85FF0 File Offset: 0x03D843F0
		' (set) Token: 0x0600017F RID: 383 RVA: 0x03D86008 File Offset: 0x03D84408
		Friend Property Button9 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button9_Click
				Dim flag As Boolean = Me._Button9 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button9.Click, eventHandler
				End If
				Me._Button9 = value
				flag = Me._Button9 IsNot Nothing
				If flag Then
					AddHandler Me._Button9.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000097 RID: 151
		' (get) Token: 0x06000180 RID: 384 RVA: 0x03D86068 File Offset: 0x03D84468
		' (set) Token: 0x06000181 RID: 385 RVA: 0x03D86080 File Offset: 0x03D84480
		Friend Property Button10 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button10_Click
				Dim flag As Boolean = Me._Button10 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button10.Click, eventHandler
				End If
				Me._Button10 = value
				flag = Me._Button10 IsNot Nothing
				If flag Then
					AddHandler Me._Button10.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000098 RID: 152
		' (get) Token: 0x06000182 RID: 386 RVA: 0x03D860E0 File Offset: 0x03D844E0
		' (set) Token: 0x06000183 RID: 387 RVA: 0x03D860F8 File Offset: 0x03D844F8
		Friend Property Button11 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button11 = value
			End Set
		End Property

		' Token: 0x06000184 RID: 388 RVA: 0x03D86104 File Offset: 0x03D84504
		Private Sub AboutBox17_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000185 RID: 389 RVA: 0x03D86108 File Offset: 0x03D84508
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000186 RID: 390 RVA: 0x03D86114 File Offset: 0x03D84514
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form9.Show()
		End Sub

		' Token: 0x06000187 RID: 391 RVA: 0x03D86128 File Offset: 0x03D84528
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form14.Show()
		End Sub

		' Token: 0x06000188 RID: 392 RVA: 0x03D8613C File Offset: 0x03D8453C
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form31.Show()
		End Sub

		' Token: 0x06000189 RID: 393 RVA: 0x03D86150 File Offset: 0x03D84550
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form5.Show()
		End Sub

		' Token: 0x0600018A RID: 394 RVA: 0x03D86164 File Offset: 0x03D84564
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form21.Show()
		End Sub

		' Token: 0x0600018B RID: 395 RVA: 0x03D86178 File Offset: 0x03D84578
		Private Sub Button6_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form19.Show()
		End Sub

		' Token: 0x0600018C RID: 396 RVA: 0x03D8618C File Offset: 0x03D8458C
		Private Sub Button7_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form31.Show()
		End Sub

		' Token: 0x0600018D RID: 397 RVA: 0x03D861A0 File Offset: 0x03D845A0
		Private Sub Button8_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form18.Show()
		End Sub

		' Token: 0x0600018E RID: 398 RVA: 0x03D861B4 File Offset: 0x03D845B4
		Private Sub Button9_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form5.Show()
		End Sub

		' Token: 0x0600018F RID: 399 RVA: 0x03D861C8 File Offset: 0x03D845C8
		Private Sub Button10_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form21.Show()
		End Sub

		' Token: 0x0400009C RID: 156
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400009E RID: 158
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400009F RID: 159
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x040000A0 RID: 160
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x040000A1 RID: 161
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x040000A2 RID: 162
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x040000A3 RID: 163
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x040000A4 RID: 164
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x040000A5 RID: 165
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x040000A6 RID: 166
		<AccessedThroughProperty("Button7")>
		Private _Button7 As Button

		' Token: 0x040000A7 RID: 167
		<AccessedThroughProperty("Button8")>
		Private _Button8 As Button

		' Token: 0x040000A8 RID: 168
		<AccessedThroughProperty("Button9")>
		Private _Button9 As Button

		' Token: 0x040000A9 RID: 169
		<AccessedThroughProperty("Button10")>
		Private _Button10 As Button

		' Token: 0x040000AA RID: 170
		<AccessedThroughProperty("Button11")>
		Private _Button11 As Button
	End Class
End Namespace
