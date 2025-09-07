Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV.My
	' Token: 0x02000004 RID: 4
	<HideModuleName()>
	<GeneratedCode("MyTemplate", "8.0.0.0")>
	Friend NotInheritable Module MyProject
		' Token: 0x17000001 RID: 1
		' (get) Token: 0x06000007 RID: 7 RVA: 0x03D7F110 File Offset: 0x03D7D510
		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property Computer As MyComputer
			<DebuggerHidden()>
			Get
				Return MyProject.m_ComputerObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000002 RID: 2
		' (get) Token: 0x06000008 RID: 8 RVA: 0x03D7F12C File Offset: 0x03D7D52C
		<HelpKeyword("My.Application")>
		Friend ReadOnly Property Application As MyApplication
			<DebuggerHidden()>
			Get
				Return MyProject.m_AppObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000003 RID: 3
		' (get) Token: 0x06000009 RID: 9 RVA: 0x03D7F148 File Offset: 0x03D7D548
		<HelpKeyword("My.User")>
		Friend ReadOnly Property User As User
			<DebuggerHidden()>
			Get
				Return MyProject.m_UserObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000004 RID: 4
		' (get) Token: 0x0600000A RID: 10 RVA: 0x03D7F164 File Offset: 0x03D7D564
		<HelpKeyword("My.Forms")>
		Friend ReadOnly Property Forms As MyProject.MyForms
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyFormsObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000005 RID: 5
		' (get) Token: 0x0600000B RID: 11 RVA: 0x03D7F180 File Offset: 0x03D7D580
		<HelpKeyword("My.WebServices")>
		Friend ReadOnly Property WebServices As MyProject.MyWebServices
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyWebServicesObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x04000002 RID: 2
		Private m_ComputerObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyComputer) = New MyProject.ThreadSafeObjectProvider(Of MyComputer)()

		' Token: 0x04000003 RID: 3
		Private m_AppObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyApplication) = New MyProject.ThreadSafeObjectProvider(Of MyApplication)()

		' Token: 0x04000004 RID: 4
		Private m_UserObjectProvider As MyProject.ThreadSafeObjectProvider(Of User) = New MyProject.ThreadSafeObjectProvider(Of User)()

		' Token: 0x04000005 RID: 5
		Private m_MyFormsObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms)()

		' Token: 0x04000006 RID: 6
		Private m_MyWebServicesObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices)()

		' Token: 0x02000005 RID: 5
		<MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class MyForms
			' Token: 0x17000006 RID: 6
			' (get) Token: 0x0600000C RID: 12 RVA: 0x03D7F19C File Offset: 0x03D7D59C
			' (set) Token: 0x0600006D RID: 109 RVA: 0x03D800C4 File Offset: 0x03D7E4C4
			Public Property AboutBox1 As AboutBox1
				<DebuggerNonUserCode()>
				Get
					Me.m_AboutBox1 = MyProject.MyForms.Create__Instance__(Of AboutBox1)(Me.m_AboutBox1)
					Return Me.m_AboutBox1
				End Get
				<DebuggerNonUserCode()>
				Set(value As AboutBox1)
					Dim flag As Boolean = value Is Me.m_AboutBox1
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of AboutBox1)(Me.m_AboutBox1)
					End If
				End Set
			End Property

			' Token: 0x17000007 RID: 7
			' (get) Token: 0x0600000D RID: 13 RVA: 0x03D7F1C4 File Offset: 0x03D7D5C4
			' (set) Token: 0x0600006E RID: 110 RVA: 0x03D80108 File Offset: 0x03D7E508
			Public Property AboutBox11 As AboutBox11
				<DebuggerNonUserCode()>
				Get
					Me.m_AboutBox11 = MyProject.MyForms.Create__Instance__(Of AboutBox11)(Me.m_AboutBox11)
					Return Me.m_AboutBox11
				End Get
				<DebuggerNonUserCode()>
				Set(value As AboutBox11)
					Dim flag As Boolean = value Is Me.m_AboutBox11
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of AboutBox11)(Me.m_AboutBox11)
					End If
				End Set
			End Property

			' Token: 0x17000008 RID: 8
			' (get) Token: 0x0600000E RID: 14 RVA: 0x03D7F1EC File Offset: 0x03D7D5EC
			' (set) Token: 0x0600006F RID: 111 RVA: 0x03D8014C File Offset: 0x03D7E54C
			Public Property AboutBox12 As AboutBox12
				<DebuggerNonUserCode()>
				Get
					Me.m_AboutBox12 = MyProject.MyForms.Create__Instance__(Of AboutBox12)(Me.m_AboutBox12)
					Return Me.m_AboutBox12
				End Get
				<DebuggerNonUserCode()>
				Set(value As AboutBox12)
					Dim flag As Boolean = value Is Me.m_AboutBox12
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of AboutBox12)(Me.m_AboutBox12)
					End If
				End Set
			End Property

			' Token: 0x17000009 RID: 9
			' (get) Token: 0x0600000F RID: 15 RVA: 0x03D7F214 File Offset: 0x03D7D614
			' (set) Token: 0x06000070 RID: 112 RVA: 0x03D80190 File Offset: 0x03D7E590
			Public Property AboutBox13 As AboutBox13
				<DebuggerNonUserCode()>
				Get
					Me.m_AboutBox13 = MyProject.MyForms.Create__Instance__(Of AboutBox13)(Me.m_AboutBox13)
					Return Me.m_AboutBox13
				End Get
				<DebuggerNonUserCode()>
				Set(value As AboutBox13)
					Dim flag As Boolean = value Is Me.m_AboutBox13
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of AboutBox13)(Me.m_AboutBox13)
					End If
				End Set
			End Property

			' Token: 0x1700000A RID: 10
			' (get) Token: 0x06000010 RID: 16 RVA: 0x03D7F23C File Offset: 0x03D7D63C
			' (set) Token: 0x06000071 RID: 113 RVA: 0x03D801D4 File Offset: 0x03D7E5D4
			Public Property AboutBox14 As AboutBox14
				<DebuggerNonUserCode()>
				Get
					Me.m_AboutBox14 = MyProject.MyForms.Create__Instance__(Of AboutBox14)(Me.m_AboutBox14)
					Return Me.m_AboutBox14
				End Get
				<DebuggerNonUserCode()>
				Set(value As AboutBox14)
					Dim flag As Boolean = value Is Me.m_AboutBox14
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of AboutBox14)(Me.m_AboutBox14)
					End If
				End Set
			End Property

			' Token: 0x1700000B RID: 11
			' (get) Token: 0x06000011 RID: 17 RVA: 0x03D7F264 File Offset: 0x03D7D664
			' (set) Token: 0x06000072 RID: 114 RVA: 0x03D80218 File Offset: 0x03D7E618
			Public Property AboutBox15 As AboutBox15
				<DebuggerNonUserCode()>
				Get
					Me.m_AboutBox15 = MyProject.MyForms.Create__Instance__(Of AboutBox15)(Me.m_AboutBox15)
					Return Me.m_AboutBox15
				End Get
				<DebuggerNonUserCode()>
				Set(value As AboutBox15)
					Dim flag As Boolean = value Is Me.m_AboutBox15
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of AboutBox15)(Me.m_AboutBox15)
					End If
				End Set
			End Property

			' Token: 0x1700000C RID: 12
			' (get) Token: 0x06000012 RID: 18 RVA: 0x03D7F28C File Offset: 0x03D7D68C
			' (set) Token: 0x06000073 RID: 115 RVA: 0x03D8025C File Offset: 0x03D7E65C
			Public Property AboutBox16 As AboutBox16
				<DebuggerNonUserCode()>
				Get
					Me.m_AboutBox16 = MyProject.MyForms.Create__Instance__(Of AboutBox16)(Me.m_AboutBox16)
					Return Me.m_AboutBox16
				End Get
				<DebuggerNonUserCode()>
				Set(value As AboutBox16)
					Dim flag As Boolean = value Is Me.m_AboutBox16
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of AboutBox16)(Me.m_AboutBox16)
					End If
				End Set
			End Property

			' Token: 0x1700000D RID: 13
			' (get) Token: 0x06000013 RID: 19 RVA: 0x03D7F2B4 File Offset: 0x03D7D6B4
			' (set) Token: 0x06000074 RID: 116 RVA: 0x03D802A0 File Offset: 0x03D7E6A0
			Public Property AboutBox17 As AboutBox17
				<DebuggerNonUserCode()>
				Get
					Me.m_AboutBox17 = MyProject.MyForms.Create__Instance__(Of AboutBox17)(Me.m_AboutBox17)
					Return Me.m_AboutBox17
				End Get
				<DebuggerNonUserCode()>
				Set(value As AboutBox17)
					Dim flag As Boolean = value Is Me.m_AboutBox17
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of AboutBox17)(Me.m_AboutBox17)
					End If
				End Set
			End Property

			' Token: 0x1700000E RID: 14
			' (get) Token: 0x06000014 RID: 20 RVA: 0x03D7F2DC File Offset: 0x03D7D6DC
			' (set) Token: 0x06000075 RID: 117 RVA: 0x03D802E4 File Offset: 0x03D7E6E4
			Public Property AboutBox18 As AboutBox18
				<DebuggerNonUserCode()>
				Get
					Me.m_AboutBox18 = MyProject.MyForms.Create__Instance__(Of AboutBox18)(Me.m_AboutBox18)
					Return Me.m_AboutBox18
				End Get
				<DebuggerNonUserCode()>
				Set(value As AboutBox18)
					Dim flag As Boolean = value Is Me.m_AboutBox18
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of AboutBox18)(Me.m_AboutBox18)
					End If
				End Set
			End Property

			' Token: 0x1700000F RID: 15
			' (get) Token: 0x06000015 RID: 21 RVA: 0x03D7F304 File Offset: 0x03D7D704
			' (set) Token: 0x06000076 RID: 118 RVA: 0x03D80328 File Offset: 0x03D7E728
			Public Property AboutBox19 As AboutBox19
				<DebuggerNonUserCode()>
				Get
					Me.m_AboutBox19 = MyProject.MyForms.Create__Instance__(Of AboutBox19)(Me.m_AboutBox19)
					Return Me.m_AboutBox19
				End Get
				<DebuggerNonUserCode()>
				Set(value As AboutBox19)
					Dim flag As Boolean = value Is Me.m_AboutBox19
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of AboutBox19)(Me.m_AboutBox19)
					End If
				End Set
			End Property

			' Token: 0x17000010 RID: 16
			' (get) Token: 0x06000016 RID: 22 RVA: 0x03D7F32C File Offset: 0x03D7D72C
			' (set) Token: 0x06000077 RID: 119 RVA: 0x03D8036C File Offset: 0x03D7E76C
			Public Property AboutBox20 As AboutBox20
				<DebuggerNonUserCode()>
				Get
					Me.m_AboutBox20 = MyProject.MyForms.Create__Instance__(Of AboutBox20)(Me.m_AboutBox20)
					Return Me.m_AboutBox20
				End Get
				<DebuggerNonUserCode()>
				Set(value As AboutBox20)
					Dim flag As Boolean = value Is Me.m_AboutBox20
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of AboutBox20)(Me.m_AboutBox20)
					End If
				End Set
			End Property

			' Token: 0x17000011 RID: 17
			' (get) Token: 0x06000017 RID: 23 RVA: 0x03D7F354 File Offset: 0x03D7D754
			' (set) Token: 0x06000078 RID: 120 RVA: 0x03D803B0 File Offset: 0x03D7E7B0
			Public Property AboutBox21 As AboutBox21
				<DebuggerNonUserCode()>
				Get
					Me.m_AboutBox21 = MyProject.MyForms.Create__Instance__(Of AboutBox21)(Me.m_AboutBox21)
					Return Me.m_AboutBox21
				End Get
				<DebuggerNonUserCode()>
				Set(value As AboutBox21)
					Dim flag As Boolean = value Is Me.m_AboutBox21
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of AboutBox21)(Me.m_AboutBox21)
					End If
				End Set
			End Property

			' Token: 0x17000012 RID: 18
			' (get) Token: 0x06000018 RID: 24 RVA: 0x03D7F37C File Offset: 0x03D7D77C
			' (set) Token: 0x06000079 RID: 121 RVA: 0x03D803F4 File Offset: 0x03D7E7F4
			Public Property AboutBox22 As AboutBox22
				<DebuggerNonUserCode()>
				Get
					Me.m_AboutBox22 = MyProject.MyForms.Create__Instance__(Of AboutBox22)(Me.m_AboutBox22)
					Return Me.m_AboutBox22
				End Get
				<DebuggerNonUserCode()>
				Set(value As AboutBox22)
					Dim flag As Boolean = value Is Me.m_AboutBox22
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of AboutBox22)(Me.m_AboutBox22)
					End If
				End Set
			End Property

			' Token: 0x17000013 RID: 19
			' (get) Token: 0x06000019 RID: 25 RVA: 0x03D7F3A4 File Offset: 0x03D7D7A4
			' (set) Token: 0x0600007A RID: 122 RVA: 0x03D80438 File Offset: 0x03D7E838
			Public Property AboutBox23 As AboutBox23
				<DebuggerNonUserCode()>
				Get
					Me.m_AboutBox23 = MyProject.MyForms.Create__Instance__(Of AboutBox23)(Me.m_AboutBox23)
					Return Me.m_AboutBox23
				End Get
				<DebuggerNonUserCode()>
				Set(value As AboutBox23)
					Dim flag As Boolean = value Is Me.m_AboutBox23
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of AboutBox23)(Me.m_AboutBox23)
					End If
				End Set
			End Property

			' Token: 0x17000014 RID: 20
			' (get) Token: 0x0600001A RID: 26 RVA: 0x03D7F3CC File Offset: 0x03D7D7CC
			' (set) Token: 0x0600007B RID: 123 RVA: 0x03D8047C File Offset: 0x03D7E87C
			Public Property AboutBox24 As AboutBox24
				<DebuggerNonUserCode()>
				Get
					Me.m_AboutBox24 = MyProject.MyForms.Create__Instance__(Of AboutBox24)(Me.m_AboutBox24)
					Return Me.m_AboutBox24
				End Get
				<DebuggerNonUserCode()>
				Set(value As AboutBox24)
					Dim flag As Boolean = value Is Me.m_AboutBox24
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of AboutBox24)(Me.m_AboutBox24)
					End If
				End Set
			End Property

			' Token: 0x17000015 RID: 21
			' (get) Token: 0x0600001B RID: 27 RVA: 0x03D7F3F4 File Offset: 0x03D7D7F4
			' (set) Token: 0x0600007C RID: 124 RVA: 0x03D804C0 File Offset: 0x03D7E8C0
			Public Property AboutBox25 As AboutBox25
				<DebuggerNonUserCode()>
				Get
					Me.m_AboutBox25 = MyProject.MyForms.Create__Instance__(Of AboutBox25)(Me.m_AboutBox25)
					Return Me.m_AboutBox25
				End Get
				<DebuggerNonUserCode()>
				Set(value As AboutBox25)
					Dim flag As Boolean = value Is Me.m_AboutBox25
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of AboutBox25)(Me.m_AboutBox25)
					End If
				End Set
			End Property

			' Token: 0x17000016 RID: 22
			' (get) Token: 0x0600001C RID: 28 RVA: 0x03D7F41C File Offset: 0x03D7D81C
			' (set) Token: 0x0600007D RID: 125 RVA: 0x03D80504 File Offset: 0x03D7E904
			Public Property AboutBox3 As AboutBox3
				<DebuggerNonUserCode()>
				Get
					Me.m_AboutBox3 = MyProject.MyForms.Create__Instance__(Of AboutBox3)(Me.m_AboutBox3)
					Return Me.m_AboutBox3
				End Get
				<DebuggerNonUserCode()>
				Set(value As AboutBox3)
					Dim flag As Boolean = value Is Me.m_AboutBox3
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of AboutBox3)(Me.m_AboutBox3)
					End If
				End Set
			End Property

			' Token: 0x17000017 RID: 23
			' (get) Token: 0x0600001D RID: 29 RVA: 0x03D7F444 File Offset: 0x03D7D844
			' (set) Token: 0x0600007E RID: 126 RVA: 0x03D80548 File Offset: 0x03D7E948
			Public Property AboutBox5 As AboutBox5
				<DebuggerNonUserCode()>
				Get
					Me.m_AboutBox5 = MyProject.MyForms.Create__Instance__(Of AboutBox5)(Me.m_AboutBox5)
					Return Me.m_AboutBox5
				End Get
				<DebuggerNonUserCode()>
				Set(value As AboutBox5)
					Dim flag As Boolean = value Is Me.m_AboutBox5
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of AboutBox5)(Me.m_AboutBox5)
					End If
				End Set
			End Property

			' Token: 0x17000018 RID: 24
			' (get) Token: 0x0600001E RID: 30 RVA: 0x03D7F46C File Offset: 0x03D7D86C
			' (set) Token: 0x0600007F RID: 127 RVA: 0x03D8058C File Offset: 0x03D7E98C
			Public Property AboutBox7 As AboutBox7
				<DebuggerNonUserCode()>
				Get
					Me.m_AboutBox7 = MyProject.MyForms.Create__Instance__(Of AboutBox7)(Me.m_AboutBox7)
					Return Me.m_AboutBox7
				End Get
				<DebuggerNonUserCode()>
				Set(value As AboutBox7)
					Dim flag As Boolean = value Is Me.m_AboutBox7
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of AboutBox7)(Me.m_AboutBox7)
					End If
				End Set
			End Property

			' Token: 0x17000019 RID: 25
			' (get) Token: 0x0600001F RID: 31 RVA: 0x03D7F494 File Offset: 0x03D7D894
			' (set) Token: 0x06000080 RID: 128 RVA: 0x03D805D0 File Offset: 0x03D7E9D0
			Public Property AboutBox8 As AboutBox8
				<DebuggerNonUserCode()>
				Get
					Me.m_AboutBox8 = MyProject.MyForms.Create__Instance__(Of AboutBox8)(Me.m_AboutBox8)
					Return Me.m_AboutBox8
				End Get
				<DebuggerNonUserCode()>
				Set(value As AboutBox8)
					Dim flag As Boolean = value Is Me.m_AboutBox8
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of AboutBox8)(Me.m_AboutBox8)
					End If
				End Set
			End Property

			' Token: 0x1700001A RID: 26
			' (get) Token: 0x06000020 RID: 32 RVA: 0x03D7F4BC File Offset: 0x03D7D8BC
			' (set) Token: 0x06000081 RID: 129 RVA: 0x03D80614 File Offset: 0x03D7EA14
			Public Property AboutBox9 As AboutBox9
				<DebuggerNonUserCode()>
				Get
					Me.m_AboutBox9 = MyProject.MyForms.Create__Instance__(Of AboutBox9)(Me.m_AboutBox9)
					Return Me.m_AboutBox9
				End Get
				<DebuggerNonUserCode()>
				Set(value As AboutBox9)
					Dim flag As Boolean = value Is Me.m_AboutBox9
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of AboutBox9)(Me.m_AboutBox9)
					End If
				End Set
			End Property

			' Token: 0x1700001B RID: 27
			' (get) Token: 0x06000021 RID: 33 RVA: 0x03D7F4E4 File Offset: 0x03D7D8E4
			' (set) Token: 0x06000082 RID: 130 RVA: 0x03D80658 File Offset: 0x03D7EA58
			Public Property AP As AP
				<DebuggerNonUserCode()>
				Get
					Me.m_AP = MyProject.MyForms.Create__Instance__(Of AP)(Me.m_AP)
					Return Me.m_AP
				End Get
				<DebuggerNonUserCode()>
				Set(value As AP)
					Dim flag As Boolean = value Is Me.m_AP
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of AP)(Me.m_AP)
					End If
				End Set
			End Property

			' Token: 0x1700001C RID: 28
			' (get) Token: 0x06000022 RID: 34 RVA: 0x03D7F50C File Offset: 0x03D7D90C
			' (set) Token: 0x06000083 RID: 131 RVA: 0x03D8069C File Offset: 0x03D7EA9C
			Public Property backgroundBox1 As backgroundBox1
				<DebuggerNonUserCode()>
				Get
					Me.m_backgroundBox1 = MyProject.MyForms.Create__Instance__(Of backgroundBox1)(Me.m_backgroundBox1)
					Return Me.m_backgroundBox1
				End Get
				<DebuggerNonUserCode()>
				Set(value As backgroundBox1)
					Dim flag As Boolean = value Is Me.m_backgroundBox1
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of backgroundBox1)(Me.m_backgroundBox1)
					End If
				End Set
			End Property

			' Token: 0x1700001D RID: 29
			' (get) Token: 0x06000023 RID: 35 RVA: 0x03D7F534 File Offset: 0x03D7D934
			' (set) Token: 0x06000084 RID: 132 RVA: 0x03D806E0 File Offset: 0x03D7EAE0
			Public Property cmdpad As cmdpad
				<DebuggerNonUserCode()>
				Get
					Me.m_cmdpad = MyProject.MyForms.Create__Instance__(Of cmdpad)(Me.m_cmdpad)
					Return Me.m_cmdpad
				End Get
				<DebuggerNonUserCode()>
				Set(value As cmdpad)
					Dim flag As Boolean = value Is Me.m_cmdpad
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of cmdpad)(Me.m_cmdpad)
					End If
				End Set
			End Property

			' Token: 0x1700001E RID: 30
			' (get) Token: 0x06000024 RID: 36 RVA: 0x03D7F55C File Offset: 0x03D7D95C
			' (set) Token: 0x06000085 RID: 133 RVA: 0x03D80724 File Offset: 0x03D7EB24
			Public Property error1 As error1
				<DebuggerNonUserCode()>
				Get
					Me.m_error1 = MyProject.MyForms.Create__Instance__(Of error1)(Me.m_error1)
					Return Me.m_error1
				End Get
				<DebuggerNonUserCode()>
				Set(value As error1)
					Dim flag As Boolean = value Is Me.m_error1
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of error1)(Me.m_error1)
					End If
				End Set
			End Property

			' Token: 0x1700001F RID: 31
			' (get) Token: 0x06000025 RID: 37 RVA: 0x03D7F584 File Offset: 0x03D7D984
			' (set) Token: 0x06000086 RID: 134 RVA: 0x03D80768 File Offset: 0x03D7EB68
			Public Property Errorbox1 As Errorbox1
				<DebuggerNonUserCode()>
				Get
					Me.m_Errorbox1 = MyProject.MyForms.Create__Instance__(Of Errorbox1)(Me.m_Errorbox1)
					Return Me.m_Errorbox1
				End Get
				<DebuggerNonUserCode()>
				Set(value As Errorbox1)
					Dim flag As Boolean = value Is Me.m_Errorbox1
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Errorbox1)(Me.m_Errorbox1)
					End If
				End Set
			End Property

			' Token: 0x17000020 RID: 32
			' (get) Token: 0x06000026 RID: 38 RVA: 0x03D7F5AC File Offset: 0x03D7D9AC
			' (set) Token: 0x06000087 RID: 135 RVA: 0x03D807AC File Offset: 0x03D7EBAC
			Public Property Explorer1 As Explorer1
				<DebuggerNonUserCode()>
				Get
					Me.m_Explorer1 = MyProject.MyForms.Create__Instance__(Of Explorer1)(Me.m_Explorer1)
					Return Me.m_Explorer1
				End Get
				<DebuggerNonUserCode()>
				Set(value As Explorer1)
					Dim flag As Boolean = value Is Me.m_Explorer1
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Explorer1)(Me.m_Explorer1)
					End If
				End Set
			End Property

			' Token: 0x17000021 RID: 33
			' (get) Token: 0x06000027 RID: 39 RVA: 0x03D7F5D4 File Offset: 0x03D7D9D4
			' (set) Token: 0x06000088 RID: 136 RVA: 0x03D807F0 File Offset: 0x03D7EBF0
			Public Property Explorer2 As Explorer2
				<DebuggerNonUserCode()>
				Get
					Me.m_Explorer2 = MyProject.MyForms.Create__Instance__(Of Explorer2)(Me.m_Explorer2)
					Return Me.m_Explorer2
				End Get
				<DebuggerNonUserCode()>
				Set(value As Explorer2)
					Dim flag As Boolean = value Is Me.m_Explorer2
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Explorer2)(Me.m_Explorer2)
					End If
				End Set
			End Property

			' Token: 0x17000022 RID: 34
			' (get) Token: 0x06000028 RID: 40 RVA: 0x03D7F5FC File Offset: 0x03D7D9FC
			' (set) Token: 0x06000089 RID: 137 RVA: 0x03D80834 File Offset: 0x03D7EC34
			Public Property Form1 As Form1
				<DebuggerNonUserCode()>
				Get
					Me.m_Form1 = MyProject.MyForms.Create__Instance__(Of Form1)(Me.m_Form1)
					Return Me.m_Form1
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form1)
					Dim flag As Boolean = value Is Me.m_Form1
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form1)(Me.m_Form1)
					End If
				End Set
			End Property

			' Token: 0x17000023 RID: 35
			' (get) Token: 0x06000029 RID: 41 RVA: 0x03D7F624 File Offset: 0x03D7DA24
			' (set) Token: 0x0600008A RID: 138 RVA: 0x03D80878 File Offset: 0x03D7EC78
			Public Property Form10 As Form10
				<DebuggerNonUserCode()>
				Get
					Me.m_Form10 = MyProject.MyForms.Create__Instance__(Of Form10)(Me.m_Form10)
					Return Me.m_Form10
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form10)
					Dim flag As Boolean = value Is Me.m_Form10
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form10)(Me.m_Form10)
					End If
				End Set
			End Property

			' Token: 0x17000024 RID: 36
			' (get) Token: 0x0600002A RID: 42 RVA: 0x03D7F64C File Offset: 0x03D7DA4C
			' (set) Token: 0x0600008B RID: 139 RVA: 0x03D808BC File Offset: 0x03D7ECBC
			Public Property Form11 As Form11
				<DebuggerNonUserCode()>
				Get
					Me.m_Form11 = MyProject.MyForms.Create__Instance__(Of Form11)(Me.m_Form11)
					Return Me.m_Form11
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form11)
					Dim flag As Boolean = value Is Me.m_Form11
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form11)(Me.m_Form11)
					End If
				End Set
			End Property

			' Token: 0x17000025 RID: 37
			' (get) Token: 0x0600002B RID: 43 RVA: 0x03D7F674 File Offset: 0x03D7DA74
			' (set) Token: 0x0600008C RID: 140 RVA: 0x03D80900 File Offset: 0x03D7ED00
			Public Property Form12 As Form12
				<DebuggerNonUserCode()>
				Get
					Me.m_Form12 = MyProject.MyForms.Create__Instance__(Of Form12)(Me.m_Form12)
					Return Me.m_Form12
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form12)
					Dim flag As Boolean = value Is Me.m_Form12
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form12)(Me.m_Form12)
					End If
				End Set
			End Property

			' Token: 0x17000026 RID: 38
			' (get) Token: 0x0600002C RID: 44 RVA: 0x03D7F69C File Offset: 0x03D7DA9C
			' (set) Token: 0x0600008D RID: 141 RVA: 0x03D80944 File Offset: 0x03D7ED44
			Public Property Form13 As Form13
				<DebuggerNonUserCode()>
				Get
					Me.m_Form13 = MyProject.MyForms.Create__Instance__(Of Form13)(Me.m_Form13)
					Return Me.m_Form13
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form13)
					Dim flag As Boolean = value Is Me.m_Form13
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form13)(Me.m_Form13)
					End If
				End Set
			End Property

			' Token: 0x17000027 RID: 39
			' (get) Token: 0x0600002D RID: 45 RVA: 0x03D7F6C4 File Offset: 0x03D7DAC4
			' (set) Token: 0x0600008E RID: 142 RVA: 0x03D80988 File Offset: 0x03D7ED88
			Public Property Form14 As Form14
				<DebuggerNonUserCode()>
				Get
					Me.m_Form14 = MyProject.MyForms.Create__Instance__(Of Form14)(Me.m_Form14)
					Return Me.m_Form14
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form14)
					Dim flag As Boolean = value Is Me.m_Form14
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form14)(Me.m_Form14)
					End If
				End Set
			End Property

			' Token: 0x17000028 RID: 40
			' (get) Token: 0x0600002E RID: 46 RVA: 0x03D7F6EC File Offset: 0x03D7DAEC
			' (set) Token: 0x0600008F RID: 143 RVA: 0x03D809CC File Offset: 0x03D7EDCC
			Public Property Form15 As Form15
				<DebuggerNonUserCode()>
				Get
					Me.m_Form15 = MyProject.MyForms.Create__Instance__(Of Form15)(Me.m_Form15)
					Return Me.m_Form15
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form15)
					Dim flag As Boolean = value Is Me.m_Form15
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form15)(Me.m_Form15)
					End If
				End Set
			End Property

			' Token: 0x17000029 RID: 41
			' (get) Token: 0x0600002F RID: 47 RVA: 0x03D7F714 File Offset: 0x03D7DB14
			' (set) Token: 0x06000090 RID: 144 RVA: 0x03D80A10 File Offset: 0x03D7EE10
			Public Property Form16 As Form16
				<DebuggerNonUserCode()>
				Get
					Me.m_Form16 = MyProject.MyForms.Create__Instance__(Of Form16)(Me.m_Form16)
					Return Me.m_Form16
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form16)
					Dim flag As Boolean = value Is Me.m_Form16
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form16)(Me.m_Form16)
					End If
				End Set
			End Property

			' Token: 0x1700002A RID: 42
			' (get) Token: 0x06000030 RID: 48 RVA: 0x03D7F73C File Offset: 0x03D7DB3C
			' (set) Token: 0x06000091 RID: 145 RVA: 0x03D80A54 File Offset: 0x03D7EE54
			Public Property Form17 As Form17
				<DebuggerNonUserCode()>
				Get
					Me.m_Form17 = MyProject.MyForms.Create__Instance__(Of Form17)(Me.m_Form17)
					Return Me.m_Form17
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form17)
					Dim flag As Boolean = value Is Me.m_Form17
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form17)(Me.m_Form17)
					End If
				End Set
			End Property

			' Token: 0x1700002B RID: 43
			' (get) Token: 0x06000031 RID: 49 RVA: 0x03D7F764 File Offset: 0x03D7DB64
			' (set) Token: 0x06000092 RID: 146 RVA: 0x03D80A98 File Offset: 0x03D7EE98
			Public Property Form18 As Form18
				<DebuggerNonUserCode()>
				Get
					Me.m_Form18 = MyProject.MyForms.Create__Instance__(Of Form18)(Me.m_Form18)
					Return Me.m_Form18
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form18)
					Dim flag As Boolean = value Is Me.m_Form18
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form18)(Me.m_Form18)
					End If
				End Set
			End Property

			' Token: 0x1700002C RID: 44
			' (get) Token: 0x06000032 RID: 50 RVA: 0x03D7F78C File Offset: 0x03D7DB8C
			' (set) Token: 0x06000093 RID: 147 RVA: 0x03D80ADC File Offset: 0x03D7EEDC
			Public Property Form19 As Form19
				<DebuggerNonUserCode()>
				Get
					Me.m_Form19 = MyProject.MyForms.Create__Instance__(Of Form19)(Me.m_Form19)
					Return Me.m_Form19
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form19)
					Dim flag As Boolean = value Is Me.m_Form19
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form19)(Me.m_Form19)
					End If
				End Set
			End Property

			' Token: 0x1700002D RID: 45
			' (get) Token: 0x06000033 RID: 51 RVA: 0x03D7F7B4 File Offset: 0x03D7DBB4
			' (set) Token: 0x06000094 RID: 148 RVA: 0x03D80B20 File Offset: 0x03D7EF20
			Public Property Form1old As Form1old
				<DebuggerNonUserCode()>
				Get
					Me.m_Form1old = MyProject.MyForms.Create__Instance__(Of Form1old)(Me.m_Form1old)
					Return Me.m_Form1old
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form1old)
					Dim flag As Boolean = value Is Me.m_Form1old
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form1old)(Me.m_Form1old)
					End If
				End Set
			End Property

			' Token: 0x1700002E RID: 46
			' (get) Token: 0x06000034 RID: 52 RVA: 0x03D7F7DC File Offset: 0x03D7DBDC
			' (set) Token: 0x06000095 RID: 149 RVA: 0x03D80B64 File Offset: 0x03D7EF64
			Public Property form1Pad As form1Pad
				<DebuggerNonUserCode()>
				Get
					Me.m_form1Pad = MyProject.MyForms.Create__Instance__(Of form1Pad)(Me.m_form1Pad)
					Return Me.m_form1Pad
				End Get
				<DebuggerNonUserCode()>
				Set(value As form1Pad)
					Dim flag As Boolean = value Is Me.m_form1Pad
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of form1Pad)(Me.m_form1Pad)
					End If
				End Set
			End Property

			' Token: 0x1700002F RID: 47
			' (get) Token: 0x06000035 RID: 53 RVA: 0x03D7F804 File Offset: 0x03D7DC04
			' (set) Token: 0x06000096 RID: 150 RVA: 0x03D80BA8 File Offset: 0x03D7EFA8
			Public Property Form2 As Form2
				<DebuggerNonUserCode()>
				Get
					Me.m_Form2 = MyProject.MyForms.Create__Instance__(Of Form2)(Me.m_Form2)
					Return Me.m_Form2
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form2)
					Dim flag As Boolean = value Is Me.m_Form2
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form2)(Me.m_Form2)
					End If
				End Set
			End Property

			' Token: 0x17000030 RID: 48
			' (get) Token: 0x06000036 RID: 54 RVA: 0x03D7F82C File Offset: 0x03D7DC2C
			' (set) Token: 0x06000097 RID: 151 RVA: 0x03D80BEC File Offset: 0x03D7EFEC
			Public Property Form20 As Form20
				<DebuggerNonUserCode()>
				Get
					Me.m_Form20 = MyProject.MyForms.Create__Instance__(Of Form20)(Me.m_Form20)
					Return Me.m_Form20
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form20)
					Dim flag As Boolean = value Is Me.m_Form20
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form20)(Me.m_Form20)
					End If
				End Set
			End Property

			' Token: 0x17000031 RID: 49
			' (get) Token: 0x06000037 RID: 55 RVA: 0x03D7F854 File Offset: 0x03D7DC54
			' (set) Token: 0x06000098 RID: 152 RVA: 0x03D80C30 File Offset: 0x03D7F030
			Public Property Form21 As Form21
				<DebuggerNonUserCode()>
				Get
					Me.m_Form21 = MyProject.MyForms.Create__Instance__(Of Form21)(Me.m_Form21)
					Return Me.m_Form21
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form21)
					Dim flag As Boolean = value Is Me.m_Form21
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form21)(Me.m_Form21)
					End If
				End Set
			End Property

			' Token: 0x17000032 RID: 50
			' (get) Token: 0x06000038 RID: 56 RVA: 0x03D7F87C File Offset: 0x03D7DC7C
			' (set) Token: 0x06000099 RID: 153 RVA: 0x03D80C74 File Offset: 0x03D7F074
			Public Property Form22 As Form22
				<DebuggerNonUserCode()>
				Get
					Me.m_Form22 = MyProject.MyForms.Create__Instance__(Of Form22)(Me.m_Form22)
					Return Me.m_Form22
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form22)
					Dim flag As Boolean = value Is Me.m_Form22
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form22)(Me.m_Form22)
					End If
				End Set
			End Property

			' Token: 0x17000033 RID: 51
			' (get) Token: 0x06000039 RID: 57 RVA: 0x03D7F8A4 File Offset: 0x03D7DCA4
			' (set) Token: 0x0600009A RID: 154 RVA: 0x03D80CB8 File Offset: 0x03D7F0B8
			Public Property Form23 As Form23
				<DebuggerNonUserCode()>
				Get
					Me.m_Form23 = MyProject.MyForms.Create__Instance__(Of Form23)(Me.m_Form23)
					Return Me.m_Form23
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form23)
					Dim flag As Boolean = value Is Me.m_Form23
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form23)(Me.m_Form23)
					End If
				End Set
			End Property

			' Token: 0x17000034 RID: 52
			' (get) Token: 0x0600003A RID: 58 RVA: 0x03D7F8CC File Offset: 0x03D7DCCC
			' (set) Token: 0x0600009B RID: 155 RVA: 0x03D80CFC File Offset: 0x03D7F0FC
			Public Property Form24 As Form24
				<DebuggerNonUserCode()>
				Get
					Me.m_Form24 = MyProject.MyForms.Create__Instance__(Of Form24)(Me.m_Form24)
					Return Me.m_Form24
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form24)
					Dim flag As Boolean = value Is Me.m_Form24
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form24)(Me.m_Form24)
					End If
				End Set
			End Property

			' Token: 0x17000035 RID: 53
			' (get) Token: 0x0600003B RID: 59 RVA: 0x03D7F8F4 File Offset: 0x03D7DCF4
			' (set) Token: 0x0600009C RID: 156 RVA: 0x03D80D40 File Offset: 0x03D7F140
			Public Property Form25 As Form25
				<DebuggerNonUserCode()>
				Get
					Me.m_Form25 = MyProject.MyForms.Create__Instance__(Of Form25)(Me.m_Form25)
					Return Me.m_Form25
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form25)
					Dim flag As Boolean = value Is Me.m_Form25
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form25)(Me.m_Form25)
					End If
				End Set
			End Property

			' Token: 0x17000036 RID: 54
			' (get) Token: 0x0600003C RID: 60 RVA: 0x03D7F91C File Offset: 0x03D7DD1C
			' (set) Token: 0x0600009D RID: 157 RVA: 0x03D80D84 File Offset: 0x03D7F184
			Public Property Form26 As Form26
				<DebuggerNonUserCode()>
				Get
					Me.m_Form26 = MyProject.MyForms.Create__Instance__(Of Form26)(Me.m_Form26)
					Return Me.m_Form26
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form26)
					Dim flag As Boolean = value Is Me.m_Form26
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form26)(Me.m_Form26)
					End If
				End Set
			End Property

			' Token: 0x17000037 RID: 55
			' (get) Token: 0x0600003D RID: 61 RVA: 0x03D7F944 File Offset: 0x03D7DD44
			' (set) Token: 0x0600009E RID: 158 RVA: 0x03D80DC8 File Offset: 0x03D7F1C8
			Public Property Form27 As Form27
				<DebuggerNonUserCode()>
				Get
					Me.m_Form27 = MyProject.MyForms.Create__Instance__(Of Form27)(Me.m_Form27)
					Return Me.m_Form27
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form27)
					Dim flag As Boolean = value Is Me.m_Form27
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form27)(Me.m_Form27)
					End If
				End Set
			End Property

			' Token: 0x17000038 RID: 56
			' (get) Token: 0x0600003E RID: 62 RVA: 0x03D7F96C File Offset: 0x03D7DD6C
			' (set) Token: 0x0600009F RID: 159 RVA: 0x03D80E0C File Offset: 0x03D7F20C
			Public Property Form28 As Form28
				<DebuggerNonUserCode()>
				Get
					Me.m_Form28 = MyProject.MyForms.Create__Instance__(Of Form28)(Me.m_Form28)
					Return Me.m_Form28
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form28)
					Dim flag As Boolean = value Is Me.m_Form28
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form28)(Me.m_Form28)
					End If
				End Set
			End Property

			' Token: 0x17000039 RID: 57
			' (get) Token: 0x0600003F RID: 63 RVA: 0x03D7F994 File Offset: 0x03D7DD94
			' (set) Token: 0x060000A0 RID: 160 RVA: 0x03D80E50 File Offset: 0x03D7F250
			Public Property Form29 As Form29
				<DebuggerNonUserCode()>
				Get
					Me.m_Form29 = MyProject.MyForms.Create__Instance__(Of Form29)(Me.m_Form29)
					Return Me.m_Form29
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form29)
					Dim flag As Boolean = value Is Me.m_Form29
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form29)(Me.m_Form29)
					End If
				End Set
			End Property

			' Token: 0x1700003A RID: 58
			' (get) Token: 0x06000040 RID: 64 RVA: 0x03D7F9BC File Offset: 0x03D7DDBC
			' (set) Token: 0x060000A1 RID: 161 RVA: 0x03D80E94 File Offset: 0x03D7F294
			Public Property Form3 As Form3
				<DebuggerNonUserCode()>
				Get
					Me.m_Form3 = MyProject.MyForms.Create__Instance__(Of Form3)(Me.m_Form3)
					Return Me.m_Form3
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form3)
					Dim flag As Boolean = value Is Me.m_Form3
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form3)(Me.m_Form3)
					End If
				End Set
			End Property

			' Token: 0x1700003B RID: 59
			' (get) Token: 0x06000041 RID: 65 RVA: 0x03D7F9E4 File Offset: 0x03D7DDE4
			' (set) Token: 0x060000A2 RID: 162 RVA: 0x03D80ED8 File Offset: 0x03D7F2D8
			Public Property Form30 As Form30
				<DebuggerNonUserCode()>
				Get
					Me.m_Form30 = MyProject.MyForms.Create__Instance__(Of Form30)(Me.m_Form30)
					Return Me.m_Form30
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form30)
					Dim flag As Boolean = value Is Me.m_Form30
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form30)(Me.m_Form30)
					End If
				End Set
			End Property

			' Token: 0x1700003C RID: 60
			' (get) Token: 0x06000042 RID: 66 RVA: 0x03D7FA0C File Offset: 0x03D7DE0C
			' (set) Token: 0x060000A3 RID: 163 RVA: 0x03D80F1C File Offset: 0x03D7F31C
			Public Property Form31 As Form31
				<DebuggerNonUserCode()>
				Get
					Me.m_Form31 = MyProject.MyForms.Create__Instance__(Of Form31)(Me.m_Form31)
					Return Me.m_Form31
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form31)
					Dim flag As Boolean = value Is Me.m_Form31
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form31)(Me.m_Form31)
					End If
				End Set
			End Property

			' Token: 0x1700003D RID: 61
			' (get) Token: 0x06000043 RID: 67 RVA: 0x03D7FA34 File Offset: 0x03D7DE34
			' (set) Token: 0x060000A4 RID: 164 RVA: 0x03D80F60 File Offset: 0x03D7F360
			Public Property Form32 As Form32
				<DebuggerNonUserCode()>
				Get
					Me.m_Form32 = MyProject.MyForms.Create__Instance__(Of Form32)(Me.m_Form32)
					Return Me.m_Form32
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form32)
					Dim flag As Boolean = value Is Me.m_Form32
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form32)(Me.m_Form32)
					End If
				End Set
			End Property

			' Token: 0x1700003E RID: 62
			' (get) Token: 0x06000044 RID: 68 RVA: 0x03D7FA5C File Offset: 0x03D7DE5C
			' (set) Token: 0x060000A5 RID: 165 RVA: 0x03D80FA4 File Offset: 0x03D7F3A4
			Public Property Form33 As Form33
				<DebuggerNonUserCode()>
				Get
					Me.m_Form33 = MyProject.MyForms.Create__Instance__(Of Form33)(Me.m_Form33)
					Return Me.m_Form33
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form33)
					Dim flag As Boolean = value Is Me.m_Form33
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form33)(Me.m_Form33)
					End If
				End Set
			End Property

			' Token: 0x1700003F RID: 63
			' (get) Token: 0x06000045 RID: 69 RVA: 0x03D7FA84 File Offset: 0x03D7DE84
			' (set) Token: 0x060000A6 RID: 166 RVA: 0x03D80FE8 File Offset: 0x03D7F3E8
			Public Property Form34 As Form34
				<DebuggerNonUserCode()>
				Get
					Me.m_Form34 = MyProject.MyForms.Create__Instance__(Of Form34)(Me.m_Form34)
					Return Me.m_Form34
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form34)
					Dim flag As Boolean = value Is Me.m_Form34
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form34)(Me.m_Form34)
					End If
				End Set
			End Property

			' Token: 0x17000040 RID: 64
			' (get) Token: 0x06000046 RID: 70 RVA: 0x03D7FAAC File Offset: 0x03D7DEAC
			' (set) Token: 0x060000A7 RID: 167 RVA: 0x03D8102C File Offset: 0x03D7F42C
			Public Property Form35 As Form35
				<DebuggerNonUserCode()>
				Get
					Me.m_Form35 = MyProject.MyForms.Create__Instance__(Of Form35)(Me.m_Form35)
					Return Me.m_Form35
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form35)
					Dim flag As Boolean = value Is Me.m_Form35
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form35)(Me.m_Form35)
					End If
				End Set
			End Property

			' Token: 0x17000041 RID: 65
			' (get) Token: 0x06000047 RID: 71 RVA: 0x03D7FAD4 File Offset: 0x03D7DED4
			' (set) Token: 0x060000A8 RID: 168 RVA: 0x03D81070 File Offset: 0x03D7F470
			Public Property Form36 As Form36
				<DebuggerNonUserCode()>
				Get
					Me.m_Form36 = MyProject.MyForms.Create__Instance__(Of Form36)(Me.m_Form36)
					Return Me.m_Form36
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form36)
					Dim flag As Boolean = value Is Me.m_Form36
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form36)(Me.m_Form36)
					End If
				End Set
			End Property

			' Token: 0x17000042 RID: 66
			' (get) Token: 0x06000048 RID: 72 RVA: 0x03D7FAFC File Offset: 0x03D7DEFC
			' (set) Token: 0x060000A9 RID: 169 RVA: 0x03D810B4 File Offset: 0x03D7F4B4
			Public Property Form37 As Form37
				<DebuggerNonUserCode()>
				Get
					Me.m_Form37 = MyProject.MyForms.Create__Instance__(Of Form37)(Me.m_Form37)
					Return Me.m_Form37
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form37)
					Dim flag As Boolean = value Is Me.m_Form37
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form37)(Me.m_Form37)
					End If
				End Set
			End Property

			' Token: 0x17000043 RID: 67
			' (get) Token: 0x06000049 RID: 73 RVA: 0x03D7FB24 File Offset: 0x03D7DF24
			' (set) Token: 0x060000AA RID: 170 RVA: 0x03D810F8 File Offset: 0x03D7F4F8
			Public Property Form38 As Form38
				<DebuggerNonUserCode()>
				Get
					Me.m_Form38 = MyProject.MyForms.Create__Instance__(Of Form38)(Me.m_Form38)
					Return Me.m_Form38
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form38)
					Dim flag As Boolean = value Is Me.m_Form38
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form38)(Me.m_Form38)
					End If
				End Set
			End Property

			' Token: 0x17000044 RID: 68
			' (get) Token: 0x0600004A RID: 74 RVA: 0x03D7FB4C File Offset: 0x03D7DF4C
			' (set) Token: 0x060000AB RID: 171 RVA: 0x03D8113C File Offset: 0x03D7F53C
			Public Property Form39 As Form39
				<DebuggerNonUserCode()>
				Get
					Me.m_Form39 = MyProject.MyForms.Create__Instance__(Of Form39)(Me.m_Form39)
					Return Me.m_Form39
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form39)
					Dim flag As Boolean = value Is Me.m_Form39
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form39)(Me.m_Form39)
					End If
				End Set
			End Property

			' Token: 0x17000045 RID: 69
			' (get) Token: 0x0600004B RID: 75 RVA: 0x03D7FB74 File Offset: 0x03D7DF74
			' (set) Token: 0x060000AC RID: 172 RVA: 0x03D81180 File Offset: 0x03D7F580
			Public Property Form4 As Form4
				<DebuggerNonUserCode()>
				Get
					Me.m_Form4 = MyProject.MyForms.Create__Instance__(Of Form4)(Me.m_Form4)
					Return Me.m_Form4
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form4)
					Dim flag As Boolean = value Is Me.m_Form4
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form4)(Me.m_Form4)
					End If
				End Set
			End Property

			' Token: 0x17000046 RID: 70
			' (get) Token: 0x0600004C RID: 76 RVA: 0x03D7FB9C File Offset: 0x03D7DF9C
			' (set) Token: 0x060000AD RID: 173 RVA: 0x03D811C4 File Offset: 0x03D7F5C4
			Public Property Form40 As Form40
				<DebuggerNonUserCode()>
				Get
					Me.m_Form40 = MyProject.MyForms.Create__Instance__(Of Form40)(Me.m_Form40)
					Return Me.m_Form40
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form40)
					Dim flag As Boolean = value Is Me.m_Form40
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form40)(Me.m_Form40)
					End If
				End Set
			End Property

			' Token: 0x17000047 RID: 71
			' (get) Token: 0x0600004D RID: 77 RVA: 0x03D7FBC4 File Offset: 0x03D7DFC4
			' (set) Token: 0x060000AE RID: 174 RVA: 0x03D81208 File Offset: 0x03D7F608
			Public Property Form41 As Form41
				<DebuggerNonUserCode()>
				Get
					Me.m_Form41 = MyProject.MyForms.Create__Instance__(Of Form41)(Me.m_Form41)
					Return Me.m_Form41
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form41)
					Dim flag As Boolean = value Is Me.m_Form41
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form41)(Me.m_Form41)
					End If
				End Set
			End Property

			' Token: 0x17000048 RID: 72
			' (get) Token: 0x0600004E RID: 78 RVA: 0x03D7FBEC File Offset: 0x03D7DFEC
			' (set) Token: 0x060000AF RID: 175 RVA: 0x03D8124C File Offset: 0x03D7F64C
			Public Property Form42 As Form42
				<DebuggerNonUserCode()>
				Get
					Me.m_Form42 = MyProject.MyForms.Create__Instance__(Of Form42)(Me.m_Form42)
					Return Me.m_Form42
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form42)
					Dim flag As Boolean = value Is Me.m_Form42
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form42)(Me.m_Form42)
					End If
				End Set
			End Property

			' Token: 0x17000049 RID: 73
			' (get) Token: 0x0600004F RID: 79 RVA: 0x03D7FC14 File Offset: 0x03D7E014
			' (set) Token: 0x060000B0 RID: 176 RVA: 0x03D81290 File Offset: 0x03D7F690
			Public Property Form43 As Form43
				<DebuggerNonUserCode()>
				Get
					Me.m_Form43 = MyProject.MyForms.Create__Instance__(Of Form43)(Me.m_Form43)
					Return Me.m_Form43
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form43)
					Dim flag As Boolean = value Is Me.m_Form43
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form43)(Me.m_Form43)
					End If
				End Set
			End Property

			' Token: 0x1700004A RID: 74
			' (get) Token: 0x06000050 RID: 80 RVA: 0x03D7FC3C File Offset: 0x03D7E03C
			' (set) Token: 0x060000B1 RID: 177 RVA: 0x03D812D4 File Offset: 0x03D7F6D4
			Public Property Form44 As Form44
				<DebuggerNonUserCode()>
				Get
					Me.m_Form44 = MyProject.MyForms.Create__Instance__(Of Form44)(Me.m_Form44)
					Return Me.m_Form44
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form44)
					Dim flag As Boolean = value Is Me.m_Form44
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form44)(Me.m_Form44)
					End If
				End Set
			End Property

			' Token: 0x1700004B RID: 75
			' (get) Token: 0x06000051 RID: 81 RVA: 0x03D7FC64 File Offset: 0x03D7E064
			' (set) Token: 0x060000B2 RID: 178 RVA: 0x03D81318 File Offset: 0x03D7F718
			Public Property Form45 As Form45
				<DebuggerNonUserCode()>
				Get
					Me.m_Form45 = MyProject.MyForms.Create__Instance__(Of Form45)(Me.m_Form45)
					Return Me.m_Form45
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form45)
					Dim flag As Boolean = value Is Me.m_Form45
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form45)(Me.m_Form45)
					End If
				End Set
			End Property

			' Token: 0x1700004C RID: 76
			' (get) Token: 0x06000052 RID: 82 RVA: 0x03D7FC8C File Offset: 0x03D7E08C
			' (set) Token: 0x060000B3 RID: 179 RVA: 0x03D8135C File Offset: 0x03D7F75C
			Public Property Form46 As Form46
				<DebuggerNonUserCode()>
				Get
					Me.m_Form46 = MyProject.MyForms.Create__Instance__(Of Form46)(Me.m_Form46)
					Return Me.m_Form46
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form46)
					Dim flag As Boolean = value Is Me.m_Form46
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form46)(Me.m_Form46)
					End If
				End Set
			End Property

			' Token: 0x1700004D RID: 77
			' (get) Token: 0x06000053 RID: 83 RVA: 0x03D7FCB4 File Offset: 0x03D7E0B4
			' (set) Token: 0x060000B4 RID: 180 RVA: 0x03D813A0 File Offset: 0x03D7F7A0
			Public Property Form47 As Form47
				<DebuggerNonUserCode()>
				Get
					Me.m_Form47 = MyProject.MyForms.Create__Instance__(Of Form47)(Me.m_Form47)
					Return Me.m_Form47
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form47)
					Dim flag As Boolean = value Is Me.m_Form47
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form47)(Me.m_Form47)
					End If
				End Set
			End Property

			' Token: 0x1700004E RID: 78
			' (get) Token: 0x06000054 RID: 84 RVA: 0x03D7FCDC File Offset: 0x03D7E0DC
			' (set) Token: 0x060000B5 RID: 181 RVA: 0x03D813E4 File Offset: 0x03D7F7E4
			Public Property Form48 As Form48
				<DebuggerNonUserCode()>
				Get
					Me.m_Form48 = MyProject.MyForms.Create__Instance__(Of Form48)(Me.m_Form48)
					Return Me.m_Form48
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form48)
					Dim flag As Boolean = value Is Me.m_Form48
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form48)(Me.m_Form48)
					End If
				End Set
			End Property

			' Token: 0x1700004F RID: 79
			' (get) Token: 0x06000055 RID: 85 RVA: 0x03D7FD04 File Offset: 0x03D7E104
			' (set) Token: 0x060000B6 RID: 182 RVA: 0x03D81428 File Offset: 0x03D7F828
			Public Property Form49 As Form49
				<DebuggerNonUserCode()>
				Get
					Me.m_Form49 = MyProject.MyForms.Create__Instance__(Of Form49)(Me.m_Form49)
					Return Me.m_Form49
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form49)
					Dim flag As Boolean = value Is Me.m_Form49
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form49)(Me.m_Form49)
					End If
				End Set
			End Property

			' Token: 0x17000050 RID: 80
			' (get) Token: 0x06000056 RID: 86 RVA: 0x03D7FD2C File Offset: 0x03D7E12C
			' (set) Token: 0x060000B7 RID: 183 RVA: 0x03D8146C File Offset: 0x03D7F86C
			Public Property Form5 As Form5
				<DebuggerNonUserCode()>
				Get
					Me.m_Form5 = MyProject.MyForms.Create__Instance__(Of Form5)(Me.m_Form5)
					Return Me.m_Form5
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form5)
					Dim flag As Boolean = value Is Me.m_Form5
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form5)(Me.m_Form5)
					End If
				End Set
			End Property

			' Token: 0x17000051 RID: 81
			' (get) Token: 0x06000057 RID: 87 RVA: 0x03D7FD54 File Offset: 0x03D7E154
			' (set) Token: 0x060000B8 RID: 184 RVA: 0x03D814B0 File Offset: 0x03D7F8B0
			Public Property Form50 As Form50
				<DebuggerNonUserCode()>
				Get
					Me.m_Form50 = MyProject.MyForms.Create__Instance__(Of Form50)(Me.m_Form50)
					Return Me.m_Form50
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form50)
					Dim flag As Boolean = value Is Me.m_Form50
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form50)(Me.m_Form50)
					End If
				End Set
			End Property

			' Token: 0x17000052 RID: 82
			' (get) Token: 0x06000058 RID: 88 RVA: 0x03D7FD7C File Offset: 0x03D7E17C
			' (set) Token: 0x060000B9 RID: 185 RVA: 0x03D814F4 File Offset: 0x03D7F8F4
			Public Property Form51 As Form51
				<DebuggerNonUserCode()>
				Get
					Me.m_Form51 = MyProject.MyForms.Create__Instance__(Of Form51)(Me.m_Form51)
					Return Me.m_Form51
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form51)
					Dim flag As Boolean = value Is Me.m_Form51
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form51)(Me.m_Form51)
					End If
				End Set
			End Property

			' Token: 0x17000053 RID: 83
			' (get) Token: 0x06000059 RID: 89 RVA: 0x03D7FDA4 File Offset: 0x03D7E1A4
			' (set) Token: 0x060000BA RID: 186 RVA: 0x03D81538 File Offset: 0x03D7F938
			Public Property Form52 As Form52
				<DebuggerNonUserCode()>
				Get
					Me.m_Form52 = MyProject.MyForms.Create__Instance__(Of Form52)(Me.m_Form52)
					Return Me.m_Form52
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form52)
					Dim flag As Boolean = value Is Me.m_Form52
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form52)(Me.m_Form52)
					End If
				End Set
			End Property

			' Token: 0x17000054 RID: 84
			' (get) Token: 0x0600005A RID: 90 RVA: 0x03D7FDCC File Offset: 0x03D7E1CC
			' (set) Token: 0x060000BB RID: 187 RVA: 0x03D8157C File Offset: 0x03D7F97C
			Public Property Form53 As Form53
				<DebuggerNonUserCode()>
				Get
					Me.m_Form53 = MyProject.MyForms.Create__Instance__(Of Form53)(Me.m_Form53)
					Return Me.m_Form53
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form53)
					Dim flag As Boolean = value Is Me.m_Form53
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form53)(Me.m_Form53)
					End If
				End Set
			End Property

			' Token: 0x17000055 RID: 85
			' (get) Token: 0x0600005B RID: 91 RVA: 0x03D7FDF4 File Offset: 0x03D7E1F4
			' (set) Token: 0x060000BC RID: 188 RVA: 0x03D815C0 File Offset: 0x03D7F9C0
			Public Property Form54 As Form54
				<DebuggerNonUserCode()>
				Get
					Me.m_Form54 = MyProject.MyForms.Create__Instance__(Of Form54)(Me.m_Form54)
					Return Me.m_Form54
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form54)
					Dim flag As Boolean = value Is Me.m_Form54
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form54)(Me.m_Form54)
					End If
				End Set
			End Property

			' Token: 0x17000056 RID: 86
			' (get) Token: 0x0600005C RID: 92 RVA: 0x03D7FE1C File Offset: 0x03D7E21C
			' (set) Token: 0x060000BD RID: 189 RVA: 0x03D81604 File Offset: 0x03D7FA04
			Public Property Form55 As Form55
				<DebuggerNonUserCode()>
				Get
					Me.m_Form55 = MyProject.MyForms.Create__Instance__(Of Form55)(Me.m_Form55)
					Return Me.m_Form55
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form55)
					Dim flag As Boolean = value Is Me.m_Form55
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form55)(Me.m_Form55)
					End If
				End Set
			End Property

			' Token: 0x17000057 RID: 87
			' (get) Token: 0x0600005D RID: 93 RVA: 0x03D7FE44 File Offset: 0x03D7E244
			' (set) Token: 0x060000BE RID: 190 RVA: 0x03D81648 File Offset: 0x03D7FA48
			Public Property Form56 As Form56
				<DebuggerNonUserCode()>
				Get
					Me.m_Form56 = MyProject.MyForms.Create__Instance__(Of Form56)(Me.m_Form56)
					Return Me.m_Form56
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form56)
					Dim flag As Boolean = value Is Me.m_Form56
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form56)(Me.m_Form56)
					End If
				End Set
			End Property

			' Token: 0x17000058 RID: 88
			' (get) Token: 0x0600005E RID: 94 RVA: 0x03D7FE6C File Offset: 0x03D7E26C
			' (set) Token: 0x060000BF RID: 191 RVA: 0x03D8168C File Offset: 0x03D7FA8C
			Public Property Form57 As Form57
				<DebuggerNonUserCode()>
				Get
					Me.m_Form57 = MyProject.MyForms.Create__Instance__(Of Form57)(Me.m_Form57)
					Return Me.m_Form57
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form57)
					Dim flag As Boolean = value Is Me.m_Form57
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form57)(Me.m_Form57)
					End If
				End Set
			End Property

			' Token: 0x17000059 RID: 89
			' (get) Token: 0x0600005F RID: 95 RVA: 0x03D7FE94 File Offset: 0x03D7E294
			' (set) Token: 0x060000C0 RID: 192 RVA: 0x03D816D0 File Offset: 0x03D7FAD0
			Public Property Form58 As Form58
				<DebuggerNonUserCode()>
				Get
					Me.m_Form58 = MyProject.MyForms.Create__Instance__(Of Form58)(Me.m_Form58)
					Return Me.m_Form58
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form58)
					Dim flag As Boolean = value Is Me.m_Form58
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form58)(Me.m_Form58)
					End If
				End Set
			End Property

			' Token: 0x1700005A RID: 90
			' (get) Token: 0x06000060 RID: 96 RVA: 0x03D7FEBC File Offset: 0x03D7E2BC
			' (set) Token: 0x060000C1 RID: 193 RVA: 0x03D81714 File Offset: 0x03D7FB14
			Public Property Form6 As Form6
				<DebuggerNonUserCode()>
				Get
					Me.m_Form6 = MyProject.MyForms.Create__Instance__(Of Form6)(Me.m_Form6)
					Return Me.m_Form6
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form6)
					Dim flag As Boolean = value Is Me.m_Form6
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form6)(Me.m_Form6)
					End If
				End Set
			End Property

			' Token: 0x1700005B RID: 91
			' (get) Token: 0x06000061 RID: 97 RVA: 0x03D7FEE4 File Offset: 0x03D7E2E4
			' (set) Token: 0x060000C2 RID: 194 RVA: 0x03D81758 File Offset: 0x03D7FB58
			Public Property Form60 As Form60
				<DebuggerNonUserCode()>
				Get
					Me.m_Form60 = MyProject.MyForms.Create__Instance__(Of Form60)(Me.m_Form60)
					Return Me.m_Form60
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form60)
					Dim flag As Boolean = value Is Me.m_Form60
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form60)(Me.m_Form60)
					End If
				End Set
			End Property

			' Token: 0x1700005C RID: 92
			' (get) Token: 0x06000062 RID: 98 RVA: 0x03D7FF0C File Offset: 0x03D7E30C
			' (set) Token: 0x060000C3 RID: 195 RVA: 0x03D8179C File Offset: 0x03D7FB9C
			Public Property Form7 As Form7
				<DebuggerNonUserCode()>
				Get
					Me.m_Form7 = MyProject.MyForms.Create__Instance__(Of Form7)(Me.m_Form7)
					Return Me.m_Form7
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form7)
					Dim flag As Boolean = value Is Me.m_Form7
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form7)(Me.m_Form7)
					End If
				End Set
			End Property

			' Token: 0x1700005D RID: 93
			' (get) Token: 0x06000063 RID: 99 RVA: 0x03D7FF34 File Offset: 0x03D7E334
			' (set) Token: 0x060000C4 RID: 196 RVA: 0x03D817E0 File Offset: 0x03D7FBE0
			Public Property Form8 As Form8
				<DebuggerNonUserCode()>
				Get
					Me.m_Form8 = MyProject.MyForms.Create__Instance__(Of Form8)(Me.m_Form8)
					Return Me.m_Form8
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form8)
					Dim flag As Boolean = value Is Me.m_Form8
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form8)(Me.m_Form8)
					End If
				End Set
			End Property

			' Token: 0x1700005E RID: 94
			' (get) Token: 0x06000064 RID: 100 RVA: 0x03D7FF5C File Offset: 0x03D7E35C
			' (set) Token: 0x060000C5 RID: 197 RVA: 0x03D81824 File Offset: 0x03D7FC24
			Public Property Form9 As Form9
				<DebuggerNonUserCode()>
				Get
					Me.m_Form9 = MyProject.MyForms.Create__Instance__(Of Form9)(Me.m_Form9)
					Return Me.m_Form9
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form9)
					Dim flag As Boolean = value Is Me.m_Form9
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form9)(Me.m_Form9)
					End If
				End Set
			End Property

			' Token: 0x1700005F RID: 95
			' (get) Token: 0x06000065 RID: 101 RVA: 0x03D7FF84 File Offset: 0x03D7E384
			' (set) Token: 0x060000C6 RID: 198 RVA: 0x03D81868 File Offset: 0x03D7FC68
			Public Property Form_1pad As Form_1pad
				<DebuggerNonUserCode()>
				Get
					Me.m_Form_1pad = MyProject.MyForms.Create__Instance__(Of Form_1pad)(Me.m_Form_1pad)
					Return Me.m_Form_1pad
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form_1pad)
					Dim flag As Boolean = value Is Me.m_Form_1pad
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form_1pad)(Me.m_Form_1pad)
					End If
				End Set
			End Property

			' Token: 0x17000060 RID: 96
			' (get) Token: 0x06000066 RID: 102 RVA: 0x03D7FFAC File Offset: 0x03D7E3AC
			' (set) Token: 0x060000C7 RID: 199 RVA: 0x03D818AC File Offset: 0x03D7FCAC
			Public Property ha As ha
				<DebuggerNonUserCode()>
				Get
					Me.m_ha = MyProject.MyForms.Create__Instance__(Of ha)(Me.m_ha)
					Return Me.m_ha
				End Get
				<DebuggerNonUserCode()>
				Set(value As ha)
					Dim flag As Boolean = value Is Me.m_ha
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of ha)(Me.m_ha)
					End If
				End Set
			End Property

			' Token: 0x17000061 RID: 97
			' (get) Token: 0x06000067 RID: 103 RVA: 0x03D7FFD4 File Offset: 0x03D7E3D4
			' (set) Token: 0x060000C8 RID: 200 RVA: 0x03D818F0 File Offset: 0x03D7FCF0
			Public Property Loginz As Loginz
				<DebuggerNonUserCode()>
				Get
					Me.m_Loginz = MyProject.MyForms.Create__Instance__(Of Loginz)(Me.m_Loginz)
					Return Me.m_Loginz
				End Get
				<DebuggerNonUserCode()>
				Set(value As Loginz)
					Dim flag As Boolean = value Is Me.m_Loginz
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Loginz)(Me.m_Loginz)
					End If
				End Set
			End Property

			' Token: 0x17000062 RID: 98
			' (get) Token: 0x06000068 RID: 104 RVA: 0x03D7FFFC File Offset: 0x03D7E3FC
			' (set) Token: 0x060000C9 RID: 201 RVA: 0x03D81934 File Offset: 0x03D7FD34
			Public Property Restartform As Restartform
				<DebuggerNonUserCode()>
				Get
					Me.m_Restartform = MyProject.MyForms.Create__Instance__(Of Restartform)(Me.m_Restartform)
					Return Me.m_Restartform
				End Get
				<DebuggerNonUserCode()>
				Set(value As Restartform)
					Dim flag As Boolean = value Is Me.m_Restartform
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Restartform)(Me.m_Restartform)
					End If
				End Set
			End Property

			' Token: 0x17000063 RID: 99
			' (get) Token: 0x06000069 RID: 105 RVA: 0x03D80024 File Offset: 0x03D7E424
			' (set) Token: 0x060000CA RID: 202 RVA: 0x03D81978 File Offset: 0x03D7FD78
			Public Property seb_copy_web As seb_copy_web
				<DebuggerNonUserCode()>
				Get
					Me.m_seb_copy_web = MyProject.MyForms.Create__Instance__(Of seb_copy_web)(Me.m_seb_copy_web)
					Return Me.m_seb_copy_web
				End Get
				<DebuggerNonUserCode()>
				Set(value As seb_copy_web)
					Dim flag As Boolean = value Is Me.m_seb_copy_web
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of seb_copy_web)(Me.m_seb_copy_web)
					End If
				End Set
			End Property

			' Token: 0x17000064 RID: 100
			' (get) Token: 0x0600006A RID: 106 RVA: 0x03D8004C File Offset: 0x03D7E44C
			' (set) Token: 0x060000CB RID: 203 RVA: 0x03D819BC File Offset: 0x03D7FDBC
			Public Property theme_window As theme_window
				<DebuggerNonUserCode()>
				Get
					Me.m_theme_window = MyProject.MyForms.Create__Instance__(Of theme_window)(Me.m_theme_window)
					Return Me.m_theme_window
				End Get
				<DebuggerNonUserCode()>
				Set(value As theme_window)
					Dim flag As Boolean = value Is Me.m_theme_window
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of theme_window)(Me.m_theme_window)
					End If
				End Set
			End Property

			' Token: 0x17000065 RID: 101
			' (get) Token: 0x0600006B RID: 107 RVA: 0x03D80074 File Offset: 0x03D7E474
			' (set) Token: 0x060000CC RID: 204 RVA: 0x03D81A00 File Offset: 0x03D7FE00
			Public Property updaterform1 As updaterform1
				<DebuggerNonUserCode()>
				Get
					Me.m_updaterform1 = MyProject.MyForms.Create__Instance__(Of updaterform1)(Me.m_updaterform1)
					Return Me.m_updaterform1
				End Get
				<DebuggerNonUserCode()>
				Set(value As updaterform1)
					Dim flag As Boolean = value Is Me.m_updaterform1
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of updaterform1)(Me.m_updaterform1)
					End If
				End Set
			End Property

			' Token: 0x17000066 RID: 102
			' (get) Token: 0x0600006C RID: 108 RVA: 0x03D8009C File Offset: 0x03D7E49C
			' (set) Token: 0x060000CD RID: 205 RVA: 0x03D81A44 File Offset: 0x03D7FE44
			Public Property WASD As WASD
				<DebuggerNonUserCode()>
				Get
					Me.m_WASD = MyProject.MyForms.Create__Instance__(Of WASD)(Me.m_WASD)
					Return Me.m_WASD
				End Get
				<DebuggerNonUserCode()>
				Set(value As WASD)
					Dim flag As Boolean = value Is Me.m_WASD
					If Not flag Then
						flag = value IsNot Nothing
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of WASD)(Me.m_WASD)
					End If
				End Set
			End Property

			' Token: 0x060000CE RID: 206 RVA: 0x03D81A88 File Offset: 0x03D7FE88
			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As{Form, New})(Instance As T) As T
				Dim flag As Boolean = Instance Is Nothing OrElse Instance.IsDisposed
				If flag Then
					Dim flag2 As Boolean = MyProject.MyForms.m_FormBeingCreated IsNot Nothing
					If flag2 Then
						Dim flag3 As Boolean = MyProject.MyForms.m_FormBeingCreated.ContainsKey(GetType(T))
						If flag3 Then
							Throw New InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", New String(-1) {}))
						End If
					Else
						MyProject.MyForms.m_FormBeingCreated = New Hashtable()
					End If
					MyProject.MyForms.m_FormBeingCreated.Add(GetType(T), Nothing)
					Try
						Return New T()
					Catch ex As TargetInvocationException When ex.InnerException IsNot Nothing
						Dim resourceString As String = Utils.GetResourceString("WinForms_SeeInnerException", New String() { ex.InnerException.Message })
						Throw New InvalidOperationException(resourceString, ex.InnerException)
					Finally
						MyProject.MyForms.m_FormBeingCreated.Remove(GetType(T))
					End Try
				End If
				Return Instance
			End Function

			' Token: 0x060000CF RID: 207 RVA: 0x03D81BC4 File Offset: 0x03D7FFC4
			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T As Form)(ByRef instance As T)
				instance.Dispose()
				instance = Nothing
			End Sub

			' Token: 0x060000D0 RID: 208 RVA: 0x03D81BF0 File Offset: 0x03D7FFF0
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub

			' Token: 0x060000D1 RID: 209 RVA: 0x03D81BFC File Offset: 0x03D7FFFC
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			' Token: 0x060000D2 RID: 210 RVA: 0x03D81C1C File Offset: 0x03D8001C
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x060000D3 RID: 211 RVA: 0x03D81C34 File Offset: 0x03D80034
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyForms)
			End Function

			' Token: 0x060000D4 RID: 212 RVA: 0x03D81C50 File Offset: 0x03D80050
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x04000007 RID: 7
			Public m_AboutBox1 As AboutBox1

			' Token: 0x04000008 RID: 8
			Public m_AboutBox11 As AboutBox11

			' Token: 0x04000009 RID: 9
			Public m_AboutBox12 As AboutBox12

			' Token: 0x0400000A RID: 10
			Public m_AboutBox13 As AboutBox13

			' Token: 0x0400000B RID: 11
			Public m_AboutBox14 As AboutBox14

			' Token: 0x0400000C RID: 12
			Public m_AboutBox15 As AboutBox15

			' Token: 0x0400000D RID: 13
			Public m_AboutBox16 As AboutBox16

			' Token: 0x0400000E RID: 14
			Public m_AboutBox17 As AboutBox17

			' Token: 0x0400000F RID: 15
			Public m_AboutBox18 As AboutBox18

			' Token: 0x04000010 RID: 16
			Public m_AboutBox19 As AboutBox19

			' Token: 0x04000011 RID: 17
			Public m_AboutBox20 As AboutBox20

			' Token: 0x04000012 RID: 18
			Public m_AboutBox21 As AboutBox21

			' Token: 0x04000013 RID: 19
			Public m_AboutBox22 As AboutBox22

			' Token: 0x04000014 RID: 20
			Public m_AboutBox23 As AboutBox23

			' Token: 0x04000015 RID: 21
			Public m_AboutBox24 As AboutBox24

			' Token: 0x04000016 RID: 22
			Public m_AboutBox25 As AboutBox25

			' Token: 0x04000017 RID: 23
			Public m_AboutBox3 As AboutBox3

			' Token: 0x04000018 RID: 24
			Public m_AboutBox5 As AboutBox5

			' Token: 0x04000019 RID: 25
			Public m_AboutBox7 As AboutBox7

			' Token: 0x0400001A RID: 26
			Public m_AboutBox8 As AboutBox8

			' Token: 0x0400001B RID: 27
			Public m_AboutBox9 As AboutBox9

			' Token: 0x0400001C RID: 28
			Public m_AP As AP

			' Token: 0x0400001D RID: 29
			Public m_backgroundBox1 As backgroundBox1

			' Token: 0x0400001E RID: 30
			Public m_cmdpad As cmdpad

			' Token: 0x0400001F RID: 31
			Public m_error1 As error1

			' Token: 0x04000020 RID: 32
			Public m_Errorbox1 As Errorbox1

			' Token: 0x04000021 RID: 33
			Public m_Explorer1 As Explorer1

			' Token: 0x04000022 RID: 34
			Public m_Explorer2 As Explorer2

			' Token: 0x04000023 RID: 35
			Public m_Form1 As Form1

			' Token: 0x04000024 RID: 36
			Public m_Form10 As Form10

			' Token: 0x04000025 RID: 37
			Public m_Form11 As Form11

			' Token: 0x04000026 RID: 38
			Public m_Form12 As Form12

			' Token: 0x04000027 RID: 39
			Public m_Form13 As Form13

			' Token: 0x04000028 RID: 40
			Public m_Form14 As Form14

			' Token: 0x04000029 RID: 41
			Public m_Form15 As Form15

			' Token: 0x0400002A RID: 42
			Public m_Form16 As Form16

			' Token: 0x0400002B RID: 43
			Public m_Form17 As Form17

			' Token: 0x0400002C RID: 44
			Public m_Form18 As Form18

			' Token: 0x0400002D RID: 45
			Public m_Form19 As Form19

			' Token: 0x0400002E RID: 46
			Public m_Form1old As Form1old

			' Token: 0x0400002F RID: 47
			Public m_form1Pad As form1Pad

			' Token: 0x04000030 RID: 48
			Public m_Form2 As Form2

			' Token: 0x04000031 RID: 49
			Public m_Form20 As Form20

			' Token: 0x04000032 RID: 50
			Public m_Form21 As Form21

			' Token: 0x04000033 RID: 51
			Public m_Form22 As Form22

			' Token: 0x04000034 RID: 52
			Public m_Form23 As Form23

			' Token: 0x04000035 RID: 53
			Public m_Form24 As Form24

			' Token: 0x04000036 RID: 54
			Public m_Form25 As Form25

			' Token: 0x04000037 RID: 55
			Public m_Form26 As Form26

			' Token: 0x04000038 RID: 56
			Public m_Form27 As Form27

			' Token: 0x04000039 RID: 57
			Public m_Form28 As Form28

			' Token: 0x0400003A RID: 58
			Public m_Form29 As Form29

			' Token: 0x0400003B RID: 59
			Public m_Form3 As Form3

			' Token: 0x0400003C RID: 60
			Public m_Form30 As Form30

			' Token: 0x0400003D RID: 61
			Public m_Form31 As Form31

			' Token: 0x0400003E RID: 62
			Public m_Form32 As Form32

			' Token: 0x0400003F RID: 63
			Public m_Form33 As Form33

			' Token: 0x04000040 RID: 64
			Public m_Form34 As Form34

			' Token: 0x04000041 RID: 65
			Public m_Form35 As Form35

			' Token: 0x04000042 RID: 66
			Public m_Form36 As Form36

			' Token: 0x04000043 RID: 67
			Public m_Form37 As Form37

			' Token: 0x04000044 RID: 68
			Public m_Form38 As Form38

			' Token: 0x04000045 RID: 69
			Public m_Form39 As Form39

			' Token: 0x04000046 RID: 70
			Public m_Form4 As Form4

			' Token: 0x04000047 RID: 71
			Public m_Form40 As Form40

			' Token: 0x04000048 RID: 72
			Public m_Form41 As Form41

			' Token: 0x04000049 RID: 73
			Public m_Form42 As Form42

			' Token: 0x0400004A RID: 74
			Public m_Form43 As Form43

			' Token: 0x0400004B RID: 75
			Public m_Form44 As Form44

			' Token: 0x0400004C RID: 76
			Public m_Form45 As Form45

			' Token: 0x0400004D RID: 77
			Public m_Form46 As Form46

			' Token: 0x0400004E RID: 78
			Public m_Form47 As Form47

			' Token: 0x0400004F RID: 79
			Public m_Form48 As Form48

			' Token: 0x04000050 RID: 80
			Public m_Form49 As Form49

			' Token: 0x04000051 RID: 81
			Public m_Form5 As Form5

			' Token: 0x04000052 RID: 82
			Public m_Form50 As Form50

			' Token: 0x04000053 RID: 83
			Public m_Form51 As Form51

			' Token: 0x04000054 RID: 84
			Public m_Form52 As Form52

			' Token: 0x04000055 RID: 85
			Public m_Form53 As Form53

			' Token: 0x04000056 RID: 86
			Public m_Form54 As Form54

			' Token: 0x04000057 RID: 87
			Public m_Form55 As Form55

			' Token: 0x04000058 RID: 88
			Public m_Form56 As Form56

			' Token: 0x04000059 RID: 89
			Public m_Form57 As Form57

			' Token: 0x0400005A RID: 90
			Public m_Form58 As Form58

			' Token: 0x0400005B RID: 91
			Public m_Form6 As Form6

			' Token: 0x0400005C RID: 92
			Public m_Form60 As Form60

			' Token: 0x0400005D RID: 93
			Public m_Form7 As Form7

			' Token: 0x0400005E RID: 94
			Public m_Form8 As Form8

			' Token: 0x0400005F RID: 95
			Public m_Form9 As Form9

			' Token: 0x04000060 RID: 96
			Public m_Form_1pad As Form_1pad

			' Token: 0x04000061 RID: 97
			Public m_ha As ha

			' Token: 0x04000062 RID: 98
			Public m_Loginz As Loginz

			' Token: 0x04000063 RID: 99
			Public m_Restartform As Restartform

			' Token: 0x04000064 RID: 100
			Public m_seb_copy_web As seb_copy_web

			' Token: 0x04000065 RID: 101
			Public m_theme_window As theme_window

			' Token: 0x04000066 RID: 102
			Public m_updaterform1 As updaterform1

			' Token: 0x04000067 RID: 103
			Public m_WASD As WASD

			' Token: 0x04000068 RID: 104
			<ThreadStatic()>
			Private Shared m_FormBeingCreated As Hashtable
		End Class

		' Token: 0x02000006 RID: 6
		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class MyWebServices
			' Token: 0x060000D5 RID: 213 RVA: 0x03D81C68 File Offset: 0x03D80068
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			' Token: 0x060000D6 RID: 214 RVA: 0x03D81C88 File Offset: 0x03D80088
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x060000D7 RID: 215 RVA: 0x03D81CA0 File Offset: 0x03D800A0
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyWebServices)
			End Function

			' Token: 0x060000D8 RID: 216 RVA: 0x03D81CBC File Offset: 0x03D800BC
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x060000D9 RID: 217 RVA: 0x03D81CD4 File Offset: 0x03D800D4
			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As New)(instance As T) As T
				Dim flag As Boolean = instance Is Nothing
				Dim t As T
				If flag Then
					t = New T()
				Else
					t = instance
				End If
				Return t
			End Function

			' Token: 0x060000DA RID: 218 RVA: 0x03D81D00 File Offset: 0x03D80100
			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T)(ByRef instance As T)
				instance = Nothing
			End Sub

			' Token: 0x060000DB RID: 219 RVA: 0x03D81D20 File Offset: 0x03D80120
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub
		End Class

		' Token: 0x02000007 RID: 7
		<EditorBrowsable(EditorBrowsableState.Never)>
		<ComVisible(False)>
		Friend NotInheritable Class ThreadSafeObjectProvider(Of T As New)
			' Token: 0x17000067 RID: 103
			' (get) Token: 0x060000DC RID: 220 RVA: 0x03D81D2C File Offset: 0x03D8012C
			Friend ReadOnly Property GetInstance As T
				<DebuggerHidden()>
				Get
					Dim flag As Boolean = MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue Is Nothing
					If flag Then
						MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue = New T()
					End If
					Return MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue
				End Get
			End Property

			' Token: 0x060000DD RID: 221 RVA: 0x03D81D60 File Offset: 0x03D80160
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub

			' Token: 0x04000069 RID: 105
			<ThreadStatic()>
			<CompilerGenerated()>
			Private Shared m_ThreadStaticValue As T
		End Class
	End Module
End Namespace
