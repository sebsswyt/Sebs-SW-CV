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
	' Token: 0x02000047 RID: 71
	<DesignerGenerated()>
	Public Partial Class Form26
		Inherits Form

		' Token: 0x06000B41 RID: 2881 RVA: 0x03DC321C File Offset: 0x03DC161C
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Form26.__ENCList
			SyncLock _ENCList
				Form26.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x170003B7 RID: 951
		' (get) Token: 0x06000B44 RID: 2884 RVA: 0x03DC4160 File Offset: 0x03DC2560
		' (set) Token: 0x06000B45 RID: 2885 RVA: 0x03DC4178 File Offset: 0x03DC2578
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

		' Token: 0x170003B8 RID: 952
		' (get) Token: 0x06000B46 RID: 2886 RVA: 0x03DC41D8 File Offset: 0x03DC25D8
		' (set) Token: 0x06000B47 RID: 2887 RVA: 0x03DC41F0 File Offset: 0x03DC25F0
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

		' Token: 0x170003B9 RID: 953
		' (get) Token: 0x06000B48 RID: 2888 RVA: 0x03DC4250 File Offset: 0x03DC2650
		' (set) Token: 0x06000B49 RID: 2889 RVA: 0x03DC4268 File Offset: 0x03DC2668
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

		' Token: 0x170003BA RID: 954
		' (get) Token: 0x06000B4A RID: 2890 RVA: 0x03DC42C8 File Offset: 0x03DC26C8
		' (set) Token: 0x06000B4B RID: 2891 RVA: 0x03DC42E0 File Offset: 0x03DC26E0
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

		' Token: 0x170003BB RID: 955
		' (get) Token: 0x06000B4C RID: 2892 RVA: 0x03DC4340 File Offset: 0x03DC2740
		' (set) Token: 0x06000B4D RID: 2893 RVA: 0x03DC4358 File Offset: 0x03DC2758
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

		' Token: 0x170003BC RID: 956
		' (get) Token: 0x06000B4E RID: 2894 RVA: 0x03DC43B8 File Offset: 0x03DC27B8
		' (set) Token: 0x06000B4F RID: 2895 RVA: 0x03DC43D0 File Offset: 0x03DC27D0
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

		' Token: 0x170003BD RID: 957
		' (get) Token: 0x06000B50 RID: 2896 RVA: 0x03DC4430 File Offset: 0x03DC2830
		' (set) Token: 0x06000B51 RID: 2897 RVA: 0x03DC4448 File Offset: 0x03DC2848
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

		' Token: 0x170003BE RID: 958
		' (get) Token: 0x06000B52 RID: 2898 RVA: 0x03DC44A8 File Offset: 0x03DC28A8
		' (set) Token: 0x06000B53 RID: 2899 RVA: 0x03DC44C0 File Offset: 0x03DC28C0
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

		' Token: 0x170003BF RID: 959
		' (get) Token: 0x06000B54 RID: 2900 RVA: 0x03DC4520 File Offset: 0x03DC2920
		' (set) Token: 0x06000B55 RID: 2901 RVA: 0x03DC4538 File Offset: 0x03DC2938
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

		' Token: 0x170003C0 RID: 960
		' (get) Token: 0x06000B56 RID: 2902 RVA: 0x03DC4544 File Offset: 0x03DC2944
		' (set) Token: 0x06000B57 RID: 2903 RVA: 0x03DC455C File Offset: 0x03DC295C
		Friend Overridable Property Button9 As Button
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

		' Token: 0x170003C1 RID: 961
		' (get) Token: 0x06000B58 RID: 2904 RVA: 0x03DC45BC File Offset: 0x03DC29BC
		' (set) Token: 0x06000B59 RID: 2905 RVA: 0x03DC45D4 File Offset: 0x03DC29D4
		Friend Overridable Property Button10 As Button
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

		' Token: 0x170003C2 RID: 962
		' (get) Token: 0x06000B5A RID: 2906 RVA: 0x03DC4634 File Offset: 0x03DC2A34
		' (set) Token: 0x06000B5B RID: 2907 RVA: 0x03DC464C File Offset: 0x03DC2A4C
		Friend Overridable Property Button11 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button11_Click
				Dim flag As Boolean = Me._Button11 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button11.Click, eventHandler
				End If
				Me._Button11 = value
				flag = Me._Button11 IsNot Nothing
				If flag Then
					AddHandler Me._Button11.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170003C3 RID: 963
		' (get) Token: 0x06000B5C RID: 2908 RVA: 0x03DC46AC File Offset: 0x03DC2AAC
		' (set) Token: 0x06000B5D RID: 2909 RVA: 0x03DC46C4 File Offset: 0x03DC2AC4
		Friend Overridable Property Button12 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button12_Click
				Dim flag As Boolean = Me._Button12 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button12.Click, eventHandler
				End If
				Me._Button12 = value
				flag = Me._Button12 IsNot Nothing
				If flag Then
					AddHandler Me._Button12.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170003C4 RID: 964
		' (get) Token: 0x06000B5E RID: 2910 RVA: 0x03DC4724 File Offset: 0x03DC2B24
		' (set) Token: 0x06000B5F RID: 2911 RVA: 0x03DC473C File Offset: 0x03DC2B3C
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

		' Token: 0x170003C5 RID: 965
		' (get) Token: 0x06000B60 RID: 2912 RVA: 0x03DC4748 File Offset: 0x03DC2B48
		' (set) Token: 0x06000B61 RID: 2913 RVA: 0x03DC4760 File Offset: 0x03DC2B60
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

		' Token: 0x170003C6 RID: 966
		' (get) Token: 0x06000B62 RID: 2914 RVA: 0x03DC476C File Offset: 0x03DC2B6C
		' (set) Token: 0x06000B63 RID: 2915 RVA: 0x03DC4784 File Offset: 0x03DC2B84
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

		' Token: 0x170003C7 RID: 967
		' (get) Token: 0x06000B64 RID: 2916 RVA: 0x03DC4790 File Offset: 0x03DC2B90
		' (set) Token: 0x06000B65 RID: 2917 RVA: 0x03DC47A8 File Offset: 0x03DC2BA8
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

		' Token: 0x170003C8 RID: 968
		' (get) Token: 0x06000B66 RID: 2918 RVA: 0x03DC47B4 File Offset: 0x03DC2BB4
		' (set) Token: 0x06000B67 RID: 2919 RVA: 0x03DC47CC File Offset: 0x03DC2BCC
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

		' Token: 0x170003C9 RID: 969
		' (get) Token: 0x06000B68 RID: 2920 RVA: 0x03DC47D8 File Offset: 0x03DC2BD8
		' (set) Token: 0x06000B69 RID: 2921 RVA: 0x03DC47F0 File Offset: 0x03DC2BF0
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

		' Token: 0x170003CA RID: 970
		' (get) Token: 0x06000B6A RID: 2922 RVA: 0x03DC47FC File Offset: 0x03DC2BFC
		' (set) Token: 0x06000B6B RID: 2923 RVA: 0x03DC4814 File Offset: 0x03DC2C14
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

		' Token: 0x170003CB RID: 971
		' (get) Token: 0x06000B6C RID: 2924 RVA: 0x03DC4820 File Offset: 0x03DC2C20
		' (set) Token: 0x06000B6D RID: 2925 RVA: 0x03DC4838 File Offset: 0x03DC2C38
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

		' Token: 0x06000B6E RID: 2926 RVA: 0x03DC4844 File Offset: 0x03DC2C44
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form29.Show()
			MyProject.Forms.Form29.PictureBox1.Visible = True
			MyProject.Forms.Form1.PictureBox2.Visible = True
			MyProject.Forms.Form1.PictureBox3.Visible = False
			MyProject.Forms.Form1.PictureBox4.Visible = False
			MyProject.Forms.Form1.PictureBox5.Visible = False
			MyProject.Forms.Form1.PictureBox6.Visible = False
			MyProject.Forms.Form1.PictureBox7.Visible = False
			MyProject.Forms.Form1.PictureBox8.Visible = False
			MyProject.Forms.Form1.PictureBox9.Visible = False
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x06000B6F RID: 2927 RVA: 0x03DC4934 File Offset: 0x03DC2D34
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form29.Show()
			MyProject.Forms.Form29.PictureBox2.Visible = True
			MyProject.Forms.Form1.PictureBox2.Visible = False
			MyProject.Forms.Form1.PictureBox3.Visible = True
			MyProject.Forms.Form1.PictureBox4.Visible = False
			MyProject.Forms.Form1.PictureBox5.Visible = False
			MyProject.Forms.Form1.PictureBox6.Visible = False
			MyProject.Forms.Form1.PictureBox7.Visible = False
			MyProject.Forms.Form1.PictureBox8.Visible = False
			MyProject.Forms.Form1.PictureBox9.Visible = False
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x06000B70 RID: 2928 RVA: 0x03DC4A24 File Offset: 0x03DC2E24
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form29.Show()
			MyProject.Forms.Form29.PictureBox3.Visible = True
			MyProject.Forms.Form1.PictureBox2.Visible = False
			MyProject.Forms.Form1.PictureBox3.Visible = False
			MyProject.Forms.Form1.PictureBox4.Visible = True
			MyProject.Forms.Form1.PictureBox5.Visible = False
			MyProject.Forms.Form1.PictureBox6.Visible = False
			MyProject.Forms.Form1.PictureBox7.Visible = False
			MyProject.Forms.Form1.PictureBox8.Visible = False
			MyProject.Forms.Form1.PictureBox9.Visible = False
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x06000B71 RID: 2929 RVA: 0x03DC4B14 File Offset: 0x03DC2F14
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form29.Show()
			MyProject.Forms.Form29.PictureBox4.Visible = True
			MyProject.Forms.Form1.PictureBox2.Visible = False
			MyProject.Forms.Form1.PictureBox3.Visible = False
			MyProject.Forms.Form1.PictureBox4.Visible = False
			MyProject.Forms.Form1.PictureBox5.Visible = True
			MyProject.Forms.Form1.PictureBox6.Visible = False
			MyProject.Forms.Form1.PictureBox7.Visible = False
			MyProject.Forms.Form1.PictureBox8.Visible = False
			MyProject.Forms.Form1.PictureBox9.Visible = False
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x06000B72 RID: 2930 RVA: 0x03DC4C04 File Offset: 0x03DC3004
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form29.Show()
			MyProject.Forms.Form29.PictureBox5.Visible = True
			MyProject.Forms.Form1.PictureBox2.Visible = False
			MyProject.Forms.Form1.PictureBox3.Visible = False
			MyProject.Forms.Form1.PictureBox4.Visible = False
			MyProject.Forms.Form1.PictureBox5.Visible = False
			MyProject.Forms.Form1.PictureBox6.Visible = True
			MyProject.Forms.Form1.PictureBox7.Visible = False
			MyProject.Forms.Form1.PictureBox8.Visible = False
			MyProject.Forms.Form1.PictureBox9.Visible = False
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x06000B73 RID: 2931 RVA: 0x03DC4CF4 File Offset: 0x03DC30F4
		Private Sub Button6_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form29.Show()
			MyProject.Forms.Form29.PictureBox6.Visible = True
			MyProject.Forms.Form1.PictureBox2.Visible = False
			MyProject.Forms.Form1.PictureBox3.Visible = False
			MyProject.Forms.Form1.PictureBox4.Visible = False
			MyProject.Forms.Form1.PictureBox5.Visible = False
			MyProject.Forms.Form1.PictureBox6.Visible = False
			MyProject.Forms.Form1.PictureBox7.Visible = True
			MyProject.Forms.Form1.PictureBox8.Visible = False
			MyProject.Forms.Form1.PictureBox9.Visible = False
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x06000B74 RID: 2932 RVA: 0x03DC4DE4 File Offset: 0x03DC31E4
		Private Sub Button7_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form29.Show()
			MyProject.Forms.Form29.PictureBox7.Visible = True
			MyProject.Forms.Form1.PictureBox2.Visible = False
			MyProject.Forms.Form1.PictureBox3.Visible = False
			MyProject.Forms.Form1.PictureBox4.Visible = False
			MyProject.Forms.Form1.PictureBox5.Visible = False
			MyProject.Forms.Form1.PictureBox6.Visible = False
			MyProject.Forms.Form1.PictureBox7.Visible = False
			MyProject.Forms.Form1.PictureBox8.Visible = True
			MyProject.Forms.Form1.PictureBox9.Visible = False
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x06000B75 RID: 2933 RVA: 0x03DC4ED4 File Offset: 0x03DC32D4
		Private Sub Button8_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form29.Show()
			MyProject.Forms.Form29.PictureBox8.Visible = True
			MyProject.Forms.Form1.PictureBox2.Visible = False
			MyProject.Forms.Form1.PictureBox3.Visible = False
			MyProject.Forms.Form1.PictureBox4.Visible = False
			MyProject.Forms.Form1.PictureBox5.Visible = False
			MyProject.Forms.Form1.PictureBox6.Visible = False
			MyProject.Forms.Form1.PictureBox7.Visible = False
			MyProject.Forms.Form1.PictureBox8.Visible = False
			MyProject.Forms.Form1.PictureBox9.Visible = True
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x06000B76 RID: 2934 RVA: 0x03DC4FC4 File Offset: 0x03DC33C4
		Private Sub Button9_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form20.Show()
		End Sub

		' Token: 0x06000B77 RID: 2935 RVA: 0x03DC4FD8 File Offset: 0x03DC33D8
		Private Sub Button10_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form21.Show()
			MyProject.Forms.Form21.Panel1.Visible = True
			MyProject.Forms.Form21.Panel2.Visible = False
			MyProject.Forms.Form21.ggg.Visible = False
		End Sub

		' Token: 0x06000B78 RID: 2936 RVA: 0x03DC503C File Offset: 0x03DC343C
		Private Sub Button11_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form21.Show()
			MyProject.Forms.Form21.Panel1.Visible = False
			MyProject.Forms.Form21.Panel2.Visible = True
			MyProject.Forms.Form21.ggg.Visible = False
		End Sub

		' Token: 0x06000B79 RID: 2937 RVA: 0x03DC50A0 File Offset: 0x03DC34A0
		Private Sub Button12_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form21.Show()
			MyProject.Forms.Form21.Panel1.Visible = False
			MyProject.Forms.Form21.Panel2.Visible = False
			MyProject.Forms.Form21.ggg.Visible = True
		End Sub

		' Token: 0x04000426 RID: 1062
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000428 RID: 1064
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000429 RID: 1065
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x0400042A RID: 1066
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x0400042B RID: 1067
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x0400042C RID: 1068
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x0400042D RID: 1069
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x0400042E RID: 1070
		<AccessedThroughProperty("Button7")>
		Private _Button7 As Button

		' Token: 0x0400042F RID: 1071
		<AccessedThroughProperty("Button8")>
		Private _Button8 As Button

		' Token: 0x04000430 RID: 1072
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x04000431 RID: 1073
		<AccessedThroughProperty("Button9")>
		Private _Button9 As Button

		' Token: 0x04000432 RID: 1074
		<AccessedThroughProperty("Button10")>
		Private _Button10 As Button

		' Token: 0x04000433 RID: 1075
		<AccessedThroughProperty("Button11")>
		Private _Button11 As Button

		' Token: 0x04000434 RID: 1076
		<AccessedThroughProperty("Button12")>
		Private _Button12 As Button

		' Token: 0x04000435 RID: 1077
		<AccessedThroughProperty("PictureBox6")>
		Private _PictureBox6 As PictureBox

		' Token: 0x04000436 RID: 1078
		<AccessedThroughProperty("PictureBox5")>
		Private _PictureBox5 As PictureBox

		' Token: 0x04000437 RID: 1079
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x04000438 RID: 1080
		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		' Token: 0x04000439 RID: 1081
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x0400043A RID: 1082
		<AccessedThroughProperty("PictureBox9")>
		Private _PictureBox9 As PictureBox

		' Token: 0x0400043B RID: 1083
		<AccessedThroughProperty("PictureBox8")>
		Private _PictureBox8 As PictureBox

		' Token: 0x0400043C RID: 1084
		<AccessedThroughProperty("PictureBox7")>
		Private _PictureBox7 As PictureBox
	End Class
End Namespace
