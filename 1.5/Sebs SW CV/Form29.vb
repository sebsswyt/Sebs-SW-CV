Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x0200004A RID: 74
	<DesignerGenerated()>
	Public Partial Class Form29
		Inherits Form

		' Token: 0x06000B96 RID: 2966 RVA: 0x03DC5B34 File Offset: 0x03DC3F34
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Form29.__ENCList
			SyncLock _ENCList
				Form29.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170003D2 RID: 978
		' (get) Token: 0x06000B99 RID: 2969 RVA: 0x03DC6224 File Offset: 0x03DC4624
		' (set) Token: 0x06000B9A RID: 2970 RVA: 0x03DC623C File Offset: 0x03DC463C
		Friend Overridable Property PictureBox1 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox1 = value
			End Set
		End Property

		' Token: 0x170003D3 RID: 979
		' (get) Token: 0x06000B9B RID: 2971 RVA: 0x03DC6248 File Offset: 0x03DC4648
		' (set) Token: 0x06000B9C RID: 2972 RVA: 0x03DC6260 File Offset: 0x03DC4660
		Friend Overridable Property PictureBox2 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox2 = value
			End Set
		End Property

		' Token: 0x170003D4 RID: 980
		' (get) Token: 0x06000B9D RID: 2973 RVA: 0x03DC626C File Offset: 0x03DC466C
		' (set) Token: 0x06000B9E RID: 2974 RVA: 0x03DC6284 File Offset: 0x03DC4684
		Friend Overridable Property PictureBox3 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox3 = value
			End Set
		End Property

		' Token: 0x170003D5 RID: 981
		' (get) Token: 0x06000B9F RID: 2975 RVA: 0x03DC6290 File Offset: 0x03DC4690
		' (set) Token: 0x06000BA0 RID: 2976 RVA: 0x03DC62A8 File Offset: 0x03DC46A8
		Friend Overridable Property PictureBox4 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox4 = value
			End Set
		End Property

		' Token: 0x170003D6 RID: 982
		' (get) Token: 0x06000BA1 RID: 2977 RVA: 0x03DC62B4 File Offset: 0x03DC46B4
		' (set) Token: 0x06000BA2 RID: 2978 RVA: 0x03DC62CC File Offset: 0x03DC46CC
		Friend Overridable Property PictureBox5 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox5 = value
			End Set
		End Property

		' Token: 0x170003D7 RID: 983
		' (get) Token: 0x06000BA3 RID: 2979 RVA: 0x03DC62D8 File Offset: 0x03DC46D8
		' (set) Token: 0x06000BA4 RID: 2980 RVA: 0x03DC62F0 File Offset: 0x03DC46F0
		Friend Overridable Property PictureBox6 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox6 = value
			End Set
		End Property

		' Token: 0x170003D8 RID: 984
		' (get) Token: 0x06000BA5 RID: 2981 RVA: 0x03DC62FC File Offset: 0x03DC46FC
		' (set) Token: 0x06000BA6 RID: 2982 RVA: 0x03DC6314 File Offset: 0x03DC4714
		Friend Overridable Property PictureBox7 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox7 = value
			End Set
		End Property

		' Token: 0x170003D9 RID: 985
		' (get) Token: 0x06000BA7 RID: 2983 RVA: 0x03DC6320 File Offset: 0x03DC4720
		' (set) Token: 0x06000BA8 RID: 2984 RVA: 0x03DC6338 File Offset: 0x03DC4738
		Friend Overridable Property PictureBox8 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox8 = value
			End Set
		End Property

		' Token: 0x170003DA RID: 986
		' (get) Token: 0x06000BA9 RID: 2985 RVA: 0x03DC6344 File Offset: 0x03DC4744
		' (set) Token: 0x06000BAA RID: 2986 RVA: 0x03DC635C File Offset: 0x03DC475C
		Friend Overridable Property PictureBox9 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox9 = value
			End Set
		End Property

		' Token: 0x04000447 RID: 1095
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000449 RID: 1097
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x0400044A RID: 1098
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x0400044B RID: 1099
		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		' Token: 0x0400044C RID: 1100
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x0400044D RID: 1101
		<AccessedThroughProperty("PictureBox5")>
		Private _PictureBox5 As PictureBox

		' Token: 0x0400044E RID: 1102
		<AccessedThroughProperty("PictureBox6")>
		Private _PictureBox6 As PictureBox

		' Token: 0x0400044F RID: 1103
		<AccessedThroughProperty("PictureBox7")>
		Private _PictureBox7 As PictureBox

		' Token: 0x04000450 RID: 1104
		<AccessedThroughProperty("PictureBox8")>
		Private _PictureBox8 As PictureBox

		' Token: 0x04000451 RID: 1105
		<AccessedThroughProperty("PictureBox9")>
		Private _PictureBox9 As PictureBox
	End Class
End Namespace
