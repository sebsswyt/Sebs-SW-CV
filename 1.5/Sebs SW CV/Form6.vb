Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x0200006C RID: 108
	<DesignerGenerated()>
	Public Partial Class Form6
		Inherits Form

		' Token: 0x060011A1 RID: 4513 RVA: 0x03DEEF8C File Offset: 0x03DED38C
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form6_Load
			Dim _ENCList As List(Of WeakReference) = Form6.__ENCList
			SyncLock _ENCList
				Form6.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170005CB RID: 1483
		' (get) Token: 0x060011A4 RID: 4516 RVA: 0x03DEF860 File Offset: 0x03DEDC60
		' (set) Token: 0x060011A5 RID: 4517 RVA: 0x03DEF878 File Offset: 0x03DEDC78
		Friend Overridable Property TrackBar1 As TrackBar
			<DebuggerNonUserCode()>
			Get
				Return Me._TrackBar1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TrackBar)
				Me._TrackBar1 = value
			End Set
		End Property

		' Token: 0x170005CC RID: 1484
		' (get) Token: 0x060011A6 RID: 4518 RVA: 0x03DEF884 File Offset: 0x03DEDC84
		' (set) Token: 0x060011A7 RID: 4519 RVA: 0x03DEF89C File Offset: 0x03DEDC9C
		Friend Overridable Property Label1 As Label
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

		' Token: 0x170005CD RID: 1485
		' (get) Token: 0x060011A8 RID: 4520 RVA: 0x03DEF8A8 File Offset: 0x03DEDCA8
		' (set) Token: 0x060011A9 RID: 4521 RVA: 0x03DEF8C0 File Offset: 0x03DEDCC0
		Friend Overridable Property Label2 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label2 = value
			End Set
		End Property

		' Token: 0x170005CE RID: 1486
		' (get) Token: 0x060011AA RID: 4522 RVA: 0x03DEF8CC File Offset: 0x03DEDCCC
		' (set) Token: 0x060011AB RID: 4523 RVA: 0x03DEF8E4 File Offset: 0x03DEDCE4
		Friend Overridable Property Label3 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label3 = value
			End Set
		End Property

		' Token: 0x170005CF RID: 1487
		' (get) Token: 0x060011AC RID: 4524 RVA: 0x03DEF8F0 File Offset: 0x03DEDCF0
		' (set) Token: 0x060011AD RID: 4525 RVA: 0x03DEF908 File Offset: 0x03DEDD08
		Friend Overridable Property Label4 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label4 = value
			End Set
		End Property

		' Token: 0x170005D0 RID: 1488
		' (get) Token: 0x060011AE RID: 4526 RVA: 0x03DEF914 File Offset: 0x03DEDD14
		' (set) Token: 0x060011AF RID: 4527 RVA: 0x03DEF92C File Offset: 0x03DEDD2C
		Friend Overridable Property Label5 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label5 = value
			End Set
		End Property

		' Token: 0x170005D1 RID: 1489
		' (get) Token: 0x060011B0 RID: 4528 RVA: 0x03DEF938 File Offset: 0x03DEDD38
		' (set) Token: 0x060011B1 RID: 4529 RVA: 0x03DEF950 File Offset: 0x03DEDD50
		Friend Overridable Property Label6 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label6 = value
			End Set
		End Property

		' Token: 0x170005D2 RID: 1490
		' (get) Token: 0x060011B2 RID: 4530 RVA: 0x03DEF95C File Offset: 0x03DEDD5C
		' (set) Token: 0x060011B3 RID: 4531 RVA: 0x03DEF974 File Offset: 0x03DEDD74
		Friend Overridable Property Label7 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label7 = value
			End Set
		End Property

		' Token: 0x170005D3 RID: 1491
		' (get) Token: 0x060011B4 RID: 4532 RVA: 0x03DEF980 File Offset: 0x03DEDD80
		' (set) Token: 0x060011B5 RID: 4533 RVA: 0x03DEF998 File Offset: 0x03DEDD98
		Friend Overridable Property Label8 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label8 = value
			End Set
		End Property

		' Token: 0x170005D4 RID: 1492
		' (get) Token: 0x060011B6 RID: 4534 RVA: 0x03DEF9A4 File Offset: 0x03DEDDA4
		' (set) Token: 0x060011B7 RID: 4535 RVA: 0x03DEF9BC File Offset: 0x03DEDDBC
		Friend Overridable Property Label9 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label9 = value
			End Set
		End Property

		' Token: 0x170005D5 RID: 1493
		' (get) Token: 0x060011B8 RID: 4536 RVA: 0x03DEF9C8 File Offset: 0x03DEDDC8
		' (set) Token: 0x060011B9 RID: 4537 RVA: 0x03DEF9E0 File Offset: 0x03DEDDE0
		Friend Overridable Property Label10 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label10 = value
			End Set
		End Property

		' Token: 0x170005D6 RID: 1494
		' (get) Token: 0x060011BA RID: 4538 RVA: 0x03DEF9EC File Offset: 0x03DEDDEC
		' (set) Token: 0x060011BB RID: 4539 RVA: 0x03DEFA04 File Offset: 0x03DEDE04
		Friend Overridable Property Label11 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label11 = value
			End Set
		End Property

		' Token: 0x060011BC RID: 4540 RVA: 0x03DEFA10 File Offset: 0x03DEDE10
		Private Sub Form6_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0400068D RID: 1677
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400068F RID: 1679
		<AccessedThroughProperty("TrackBar1")>
		Private _TrackBar1 As TrackBar

		' Token: 0x04000690 RID: 1680
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000691 RID: 1681
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x04000692 RID: 1682
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x04000693 RID: 1683
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x04000694 RID: 1684
		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		' Token: 0x04000695 RID: 1685
		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		' Token: 0x04000696 RID: 1686
		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		' Token: 0x04000697 RID: 1687
		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		' Token: 0x04000698 RID: 1688
		<AccessedThroughProperty("Label9")>
		Private _Label9 As Label

		' Token: 0x04000699 RID: 1689
		<AccessedThroughProperty("Label10")>
		Private _Label10 As Label

		' Token: 0x0400069A RID: 1690
		<AccessedThroughProperty("Label11")>
		Private _Label11 As Label
	End Class
End Namespace
