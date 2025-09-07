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
	' Token: 0x0200003D RID: 61
	<DesignerGenerated()>
	Public Partial Class Form19
		Inherits Form

		' Token: 0x0600077B RID: 1915 RVA: 0x03DA8420 File Offset: 0x03DA6820
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form19_Load
			Dim _ENCList As List(Of WeakReference) = Form19.__ENCList
			SyncLock _ENCList
				Form19.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700027F RID: 639
		' (get) Token: 0x0600077E RID: 1918 RVA: 0x03DA9CC0 File Offset: 0x03DA80C0
		' (set) Token: 0x0600077F RID: 1919 RVA: 0x03DA9CD8 File Offset: 0x03DA80D8
		Friend Overridable Property TabControl1 As TabControl
			<DebuggerNonUserCode()>
			Get
				Return Me._TabControl1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabControl)
				Me._TabControl1 = value
			End Set
		End Property

		' Token: 0x17000280 RID: 640
		' (get) Token: 0x06000780 RID: 1920 RVA: 0x03DA9CE4 File Offset: 0x03DA80E4
		' (set) Token: 0x06000781 RID: 1921 RVA: 0x03DA9CFC File Offset: 0x03DA80FC
		Friend Overridable Property TabPage As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage = value
			End Set
		End Property

		' Token: 0x17000281 RID: 641
		' (get) Token: 0x06000782 RID: 1922 RVA: 0x03DA9D08 File Offset: 0x03DA8108
		' (set) Token: 0x06000783 RID: 1923 RVA: 0x03DA9D20 File Offset: 0x03DA8120
		Friend Overridable Property TextBox1 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox1 = value
			End Set
		End Property

		' Token: 0x17000282 RID: 642
		' (get) Token: 0x06000784 RID: 1924 RVA: 0x03DA9D2C File Offset: 0x03DA812C
		' (set) Token: 0x06000785 RID: 1925 RVA: 0x03DA9D44 File Offset: 0x03DA8144
		Friend Overridable Property TabPage2 As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage2 = value
			End Set
		End Property

		' Token: 0x17000283 RID: 643
		' (get) Token: 0x06000786 RID: 1926 RVA: 0x03DA9D50 File Offset: 0x03DA8150
		' (set) Token: 0x06000787 RID: 1927 RVA: 0x03DA9D68 File Offset: 0x03DA8168
		Friend Overridable Property TabPage3 As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage3 = value
			End Set
		End Property

		' Token: 0x17000284 RID: 644
		' (get) Token: 0x06000788 RID: 1928 RVA: 0x03DA9D74 File Offset: 0x03DA8174
		' (set) Token: 0x06000789 RID: 1929 RVA: 0x03DA9D8C File Offset: 0x03DA818C
		Friend Overridable Property TabPage4 As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage4 = value
			End Set
		End Property

		' Token: 0x17000285 RID: 645
		' (get) Token: 0x0600078A RID: 1930 RVA: 0x03DA9D98 File Offset: 0x03DA8198
		' (set) Token: 0x0600078B RID: 1931 RVA: 0x03DA9DB0 File Offset: 0x03DA81B0
		Friend Overridable Property TabPage5 As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage5 = value
			End Set
		End Property

		' Token: 0x17000286 RID: 646
		' (get) Token: 0x0600078C RID: 1932 RVA: 0x03DA9DBC File Offset: 0x03DA81BC
		' (set) Token: 0x0600078D RID: 1933 RVA: 0x03DA9DD4 File Offset: 0x03DA81D4
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

		' Token: 0x17000287 RID: 647
		' (get) Token: 0x0600078E RID: 1934 RVA: 0x03DA9E34 File Offset: 0x03DA8234
		' (set) Token: 0x0600078F RID: 1935 RVA: 0x03DA9E4C File Offset: 0x03DA824C
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

		' Token: 0x17000288 RID: 648
		' (get) Token: 0x06000790 RID: 1936 RVA: 0x03DA9EAC File Offset: 0x03DA82AC
		' (set) Token: 0x06000791 RID: 1937 RVA: 0x03DA9EC4 File Offset: 0x03DA82C4
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

		' Token: 0x17000289 RID: 649
		' (get) Token: 0x06000792 RID: 1938 RVA: 0x03DA9F24 File Offset: 0x03DA8324
		' (set) Token: 0x06000793 RID: 1939 RVA: 0x03DA9F3C File Offset: 0x03DA833C
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

		' Token: 0x1700028A RID: 650
		' (get) Token: 0x06000794 RID: 1940 RVA: 0x03DA9F9C File Offset: 0x03DA839C
		' (set) Token: 0x06000795 RID: 1941 RVA: 0x03DA9FB4 File Offset: 0x03DA83B4
		Friend Overridable Property WebBrowser1 As WebBrowser
			<DebuggerNonUserCode()>
			Get
				Return Me._WebBrowser1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As WebBrowser)
				Me._WebBrowser1 = value
			End Set
		End Property

		' Token: 0x1700028B RID: 651
		' (get) Token: 0x06000796 RID: 1942 RVA: 0x03DA9FC0 File Offset: 0x03DA83C0
		' (set) Token: 0x06000797 RID: 1943 RVA: 0x03DA9FD8 File Offset: 0x03DA83D8
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

		' Token: 0x1700028C RID: 652
		' (get) Token: 0x06000798 RID: 1944 RVA: 0x03DAA038 File Offset: 0x03DA8438
		' (set) Token: 0x06000799 RID: 1945 RVA: 0x03DAA050 File Offset: 0x03DA8450
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

		' Token: 0x1700028D RID: 653
		' (get) Token: 0x0600079A RID: 1946 RVA: 0x03DAA0B0 File Offset: 0x03DA84B0
		' (set) Token: 0x0600079B RID: 1947 RVA: 0x03DAA0C8 File Offset: 0x03DA84C8
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

		' Token: 0x1700028E RID: 654
		' (get) Token: 0x0600079C RID: 1948 RVA: 0x03DAA128 File Offset: 0x03DA8528
		' (set) Token: 0x0600079D RID: 1949 RVA: 0x03DAA140 File Offset: 0x03DA8540
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

		' Token: 0x1700028F RID: 655
		' (get) Token: 0x0600079E RID: 1950 RVA: 0x03DAA1A0 File Offset: 0x03DA85A0
		' (set) Token: 0x0600079F RID: 1951 RVA: 0x03DAA1B8 File Offset: 0x03DA85B8
		Friend Overridable Property WebBrowser2 As WebBrowser
			<DebuggerNonUserCode()>
			Get
				Return Me._WebBrowser2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As WebBrowser)
				Me._WebBrowser2 = value
			End Set
		End Property

		' Token: 0x17000290 RID: 656
		' (get) Token: 0x060007A0 RID: 1952 RVA: 0x03DAA1C4 File Offset: 0x03DA85C4
		' (set) Token: 0x060007A1 RID: 1953 RVA: 0x03DAA1DC File Offset: 0x03DA85DC
		Friend Overridable Property TextBox2 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox2 = value
			End Set
		End Property

		' Token: 0x17000291 RID: 657
		' (get) Token: 0x060007A2 RID: 1954 RVA: 0x03DAA1E8 File Offset: 0x03DA85E8
		' (set) Token: 0x060007A3 RID: 1955 RVA: 0x03DAA200 File Offset: 0x03DA8600
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

		' Token: 0x17000292 RID: 658
		' (get) Token: 0x060007A4 RID: 1956 RVA: 0x03DAA260 File Offset: 0x03DA8660
		' (set) Token: 0x060007A5 RID: 1957 RVA: 0x03DAA278 File Offset: 0x03DA8678
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

		' Token: 0x17000293 RID: 659
		' (get) Token: 0x060007A6 RID: 1958 RVA: 0x03DAA2D8 File Offset: 0x03DA86D8
		' (set) Token: 0x060007A7 RID: 1959 RVA: 0x03DAA2F0 File Offset: 0x03DA86F0
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

		' Token: 0x17000294 RID: 660
		' (get) Token: 0x060007A8 RID: 1960 RVA: 0x03DAA350 File Offset: 0x03DA8750
		' (set) Token: 0x060007A9 RID: 1961 RVA: 0x03DAA368 File Offset: 0x03DA8768
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

		' Token: 0x17000295 RID: 661
		' (get) Token: 0x060007AA RID: 1962 RVA: 0x03DAA3C8 File Offset: 0x03DA87C8
		' (set) Token: 0x060007AB RID: 1963 RVA: 0x03DAA3E0 File Offset: 0x03DA87E0
		Friend Overridable Property WebBrowser3 As WebBrowser
			<DebuggerNonUserCode()>
			Get
				Return Me._WebBrowser3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As WebBrowser)
				Me._WebBrowser3 = value
			End Set
		End Property

		' Token: 0x17000296 RID: 662
		' (get) Token: 0x060007AC RID: 1964 RVA: 0x03DAA3EC File Offset: 0x03DA87EC
		' (set) Token: 0x060007AD RID: 1965 RVA: 0x03DAA404 File Offset: 0x03DA8804
		Friend Overridable Property TextBox3 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox3 = value
			End Set
		End Property

		' Token: 0x17000297 RID: 663
		' (get) Token: 0x060007AE RID: 1966 RVA: 0x03DAA410 File Offset: 0x03DA8810
		' (set) Token: 0x060007AF RID: 1967 RVA: 0x03DAA428 File Offset: 0x03DA8828
		Friend Overridable Property Button13 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button13
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button13_Click
				Dim flag As Boolean = Me._Button13 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button13.Click, eventHandler
				End If
				Me._Button13 = value
				flag = Me._Button13 IsNot Nothing
				If flag Then
					AddHandler Me._Button13.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000298 RID: 664
		' (get) Token: 0x060007B0 RID: 1968 RVA: 0x03DAA488 File Offset: 0x03DA8888
		' (set) Token: 0x060007B1 RID: 1969 RVA: 0x03DAA4A0 File Offset: 0x03DA88A0
		Friend Overridable Property Button14 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button14
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button14_Click
				Dim flag As Boolean = Me._Button14 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button14.Click, eventHandler
				End If
				Me._Button14 = value
				flag = Me._Button14 IsNot Nothing
				If flag Then
					AddHandler Me._Button14.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000299 RID: 665
		' (get) Token: 0x060007B2 RID: 1970 RVA: 0x03DAA500 File Offset: 0x03DA8900
		' (set) Token: 0x060007B3 RID: 1971 RVA: 0x03DAA518 File Offset: 0x03DA8918
		Friend Overridable Property Button15 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button15
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button15_Click
				Dim flag As Boolean = Me._Button15 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button15.Click, eventHandler
				End If
				Me._Button15 = value
				flag = Me._Button15 IsNot Nothing
				If flag Then
					AddHandler Me._Button15.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700029A RID: 666
		' (get) Token: 0x060007B4 RID: 1972 RVA: 0x03DAA578 File Offset: 0x03DA8978
		' (set) Token: 0x060007B5 RID: 1973 RVA: 0x03DAA590 File Offset: 0x03DA8990
		Friend Overridable Property Button16 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button16
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button16_Click
				Dim flag As Boolean = Me._Button16 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button16.Click, eventHandler
				End If
				Me._Button16 = value
				flag = Me._Button16 IsNot Nothing
				If flag Then
					AddHandler Me._Button16.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700029B RID: 667
		' (get) Token: 0x060007B6 RID: 1974 RVA: 0x03DAA5F0 File Offset: 0x03DA89F0
		' (set) Token: 0x060007B7 RID: 1975 RVA: 0x03DAA608 File Offset: 0x03DA8A08
		Friend Overridable Property WebBrowser4 As WebBrowser
			<DebuggerNonUserCode()>
			Get
				Return Me._WebBrowser4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As WebBrowser)
				Me._WebBrowser4 = value
			End Set
		End Property

		' Token: 0x1700029C RID: 668
		' (get) Token: 0x060007B8 RID: 1976 RVA: 0x03DAA614 File Offset: 0x03DA8A14
		' (set) Token: 0x060007B9 RID: 1977 RVA: 0x03DAA62C File Offset: 0x03DA8A2C
		Friend Overridable Property TextBox4 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox4 = value
			End Set
		End Property

		' Token: 0x1700029D RID: 669
		' (get) Token: 0x060007BA RID: 1978 RVA: 0x03DAA638 File Offset: 0x03DA8A38
		' (set) Token: 0x060007BB RID: 1979 RVA: 0x03DAA650 File Offset: 0x03DA8A50
		Friend Overridable Property Button17 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button17
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button17_Click
				Dim flag As Boolean = Me._Button17 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button17.Click, eventHandler
				End If
				Me._Button17 = value
				flag = Me._Button17 IsNot Nothing
				If flag Then
					AddHandler Me._Button17.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700029E RID: 670
		' (get) Token: 0x060007BC RID: 1980 RVA: 0x03DAA6B0 File Offset: 0x03DA8AB0
		' (set) Token: 0x060007BD RID: 1981 RVA: 0x03DAA6C8 File Offset: 0x03DA8AC8
		Friend Overridable Property Button18 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button18
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button18_Click
				Dim flag As Boolean = Me._Button18 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button18.Click, eventHandler
				End If
				Me._Button18 = value
				flag = Me._Button18 IsNot Nothing
				If flag Then
					AddHandler Me._Button18.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700029F RID: 671
		' (get) Token: 0x060007BE RID: 1982 RVA: 0x03DAA728 File Offset: 0x03DA8B28
		' (set) Token: 0x060007BF RID: 1983 RVA: 0x03DAA740 File Offset: 0x03DA8B40
		Friend Overridable Property Button19 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button19
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button19_Click
				Dim flag As Boolean = Me._Button19 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button19.Click, eventHandler
				End If
				Me._Button19 = value
				flag = Me._Button19 IsNot Nothing
				If flag Then
					AddHandler Me._Button19.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002A0 RID: 672
		' (get) Token: 0x060007C0 RID: 1984 RVA: 0x03DAA7A0 File Offset: 0x03DA8BA0
		' (set) Token: 0x060007C1 RID: 1985 RVA: 0x03DAA7B8 File Offset: 0x03DA8BB8
		Friend Overridable Property Button20 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button20
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button20_Click
				Dim flag As Boolean = Me._Button20 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button20.Click, eventHandler
				End If
				Me._Button20 = value
				flag = Me._Button20 IsNot Nothing
				If flag Then
					AddHandler Me._Button20.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002A1 RID: 673
		' (get) Token: 0x060007C2 RID: 1986 RVA: 0x03DAA818 File Offset: 0x03DA8C18
		' (set) Token: 0x060007C3 RID: 1987 RVA: 0x03DAA830 File Offset: 0x03DA8C30
		Friend Overridable Property WebBrowser5 As WebBrowser
			<DebuggerNonUserCode()>
			Get
				Return Me._WebBrowser5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As WebBrowser)
				Me._WebBrowser5 = value
			End Set
		End Property

		' Token: 0x170002A2 RID: 674
		' (get) Token: 0x060007C4 RID: 1988 RVA: 0x03DAA83C File Offset: 0x03DA8C3C
		' (set) Token: 0x060007C5 RID: 1989 RVA: 0x03DAA854 File Offset: 0x03DA8C54
		Friend Overridable Property TextBox5 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox5 = value
			End Set
		End Property

		' Token: 0x060007C6 RID: 1990 RVA: 0x03DAA860 File Offset: 0x03DA8C60
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.WebBrowser1.GoBack()
		End Sub

		' Token: 0x060007C7 RID: 1991 RVA: 0x03DAA870 File Offset: 0x03DA8C70
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Me.WebBrowser1.GoForward()
		End Sub

		' Token: 0x060007C8 RID: 1992 RVA: 0x03DAA880 File Offset: 0x03DA8C80
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			Me.WebBrowser1.Refresh()
		End Sub

		' Token: 0x060007C9 RID: 1993 RVA: 0x03DAA890 File Offset: 0x03DA8C90
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			Me.WebBrowser1.Navigate(Me.TextBox1.Text)
		End Sub

		' Token: 0x060007CA RID: 1994 RVA: 0x03DAA8AC File Offset: 0x03DA8CAC
		Private Sub Button8_Click(sender As Object, e As EventArgs)
			Me.WebBrowser2.GoBack()
		End Sub

		' Token: 0x060007CB RID: 1995 RVA: 0x03DAA8BC File Offset: 0x03DA8CBC
		Private Sub Button7_Click(sender As Object, e As EventArgs)
			Me.WebBrowser2.GoForward()
		End Sub

		' Token: 0x060007CC RID: 1996 RVA: 0x03DAA8CC File Offset: 0x03DA8CCC
		Private Sub Button6_Click(sender As Object, e As EventArgs)
			Me.WebBrowser2.Refresh()
		End Sub

		' Token: 0x060007CD RID: 1997 RVA: 0x03DAA8DC File Offset: 0x03DA8CDC
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			Me.WebBrowser2.Navigate(Me.TextBox2.Text)
		End Sub

		' Token: 0x060007CE RID: 1998 RVA: 0x03DAA8F8 File Offset: 0x03DA8CF8
		Private Sub Button12_Click(sender As Object, e As EventArgs)
			Me.WebBrowser3.GoBack()
		End Sub

		' Token: 0x060007CF RID: 1999 RVA: 0x03DAA908 File Offset: 0x03DA8D08
		Private Sub Button11_Click(sender As Object, e As EventArgs)
			Me.WebBrowser3.GoForward()
		End Sub

		' Token: 0x060007D0 RID: 2000 RVA: 0x03DAA918 File Offset: 0x03DA8D18
		Private Sub Button10_Click(sender As Object, e As EventArgs)
			Me.WebBrowser3.Refresh()
		End Sub

		' Token: 0x060007D1 RID: 2001 RVA: 0x03DAA928 File Offset: 0x03DA8D28
		Private Sub Button9_Click(sender As Object, e As EventArgs)
			Me.WebBrowser3.Navigate(Me.TextBox3.Text)
		End Sub

		' Token: 0x060007D2 RID: 2002 RVA: 0x03DAA944 File Offset: 0x03DA8D44
		Private Sub Button16_Click(sender As Object, e As EventArgs)
			Me.WebBrowser4.GoBack()
		End Sub

		' Token: 0x060007D3 RID: 2003 RVA: 0x03DAA954 File Offset: 0x03DA8D54
		Private Sub Button15_Click(sender As Object, e As EventArgs)
			Me.WebBrowser4.GoForward()
		End Sub

		' Token: 0x060007D4 RID: 2004 RVA: 0x03DAA964 File Offset: 0x03DA8D64
		Private Sub Button14_Click(sender As Object, e As EventArgs)
			Me.WebBrowser4.Refresh()
		End Sub

		' Token: 0x060007D5 RID: 2005 RVA: 0x03DAA974 File Offset: 0x03DA8D74
		Private Sub Button13_Click(sender As Object, e As EventArgs)
			Me.WebBrowser4.Navigate(Me.TextBox4.Text)
		End Sub

		' Token: 0x060007D6 RID: 2006 RVA: 0x03DAA990 File Offset: 0x03DA8D90
		Private Sub Button20_Click(sender As Object, e As EventArgs)
			Me.WebBrowser5.GoBack()
		End Sub

		' Token: 0x060007D7 RID: 2007 RVA: 0x03DAA9A0 File Offset: 0x03DA8DA0
		Private Sub Button19_Click(sender As Object, e As EventArgs)
			Me.WebBrowser5.GoForward()
		End Sub

		' Token: 0x060007D8 RID: 2008 RVA: 0x03DAA9B0 File Offset: 0x03DA8DB0
		Private Sub Button18_Click(sender As Object, e As EventArgs)
			Me.WebBrowser5.Refresh()
		End Sub

		' Token: 0x060007D9 RID: 2009 RVA: 0x03DAA9C0 File Offset: 0x03DA8DC0
		Private Sub Button17_Click(sender As Object, e As EventArgs)
			Me.WebBrowser5.Navigate(Me.TextBox5.Text)
		End Sub

		' Token: 0x060007DA RID: 2010 RVA: 0x03DAA9DC File Offset: 0x03DA8DDC
		Private Sub Form19_Load(sender As Object, e As EventArgs)
			MyProject.Forms.Form35.Show()
			Dim flag As Boolean = Operators.CompareString(MyProject.Forms.Form35.TextBox1.Text, "", False) = 0
			If Not flag Then
				MyProject.Forms.Form35.WebBrowser1.Navigate(Me.WebBrowser1.Url)
			End If
			Me.Close()
		End Sub

		' Token: 0x040002D6 RID: 726
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040002D8 RID: 728
		<AccessedThroughProperty("TabControl1")>
		Private _TabControl1 As TabControl

		' Token: 0x040002D9 RID: 729
		<AccessedThroughProperty("TabPage")>
		Private _TabPage As TabPage

		' Token: 0x040002DA RID: 730
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x040002DB RID: 731
		<AccessedThroughProperty("TabPage2")>
		Private _TabPage2 As TabPage

		' Token: 0x040002DC RID: 732
		<AccessedThroughProperty("TabPage3")>
		Private _TabPage3 As TabPage

		' Token: 0x040002DD RID: 733
		<AccessedThroughProperty("TabPage4")>
		Private _TabPage4 As TabPage

		' Token: 0x040002DE RID: 734
		<AccessedThroughProperty("TabPage5")>
		Private _TabPage5 As TabPage

		' Token: 0x040002DF RID: 735
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x040002E0 RID: 736
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x040002E1 RID: 737
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x040002E2 RID: 738
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040002E3 RID: 739
		<AccessedThroughProperty("WebBrowser1")>
		Private _WebBrowser1 As WebBrowser

		' Token: 0x040002E4 RID: 740
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x040002E5 RID: 741
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x040002E6 RID: 742
		<AccessedThroughProperty("Button7")>
		Private _Button7 As Button

		' Token: 0x040002E7 RID: 743
		<AccessedThroughProperty("Button8")>
		Private _Button8 As Button

		' Token: 0x040002E8 RID: 744
		<AccessedThroughProperty("WebBrowser2")>
		Private _WebBrowser2 As WebBrowser

		' Token: 0x040002E9 RID: 745
		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		' Token: 0x040002EA RID: 746
		<AccessedThroughProperty("Button9")>
		Private _Button9 As Button

		' Token: 0x040002EB RID: 747
		<AccessedThroughProperty("Button10")>
		Private _Button10 As Button

		' Token: 0x040002EC RID: 748
		<AccessedThroughProperty("Button11")>
		Private _Button11 As Button

		' Token: 0x040002ED RID: 749
		<AccessedThroughProperty("Button12")>
		Private _Button12 As Button

		' Token: 0x040002EE RID: 750
		<AccessedThroughProperty("WebBrowser3")>
		Private _WebBrowser3 As WebBrowser

		' Token: 0x040002EF RID: 751
		<AccessedThroughProperty("TextBox3")>
		Private _TextBox3 As TextBox

		' Token: 0x040002F0 RID: 752
		<AccessedThroughProperty("Button13")>
		Private _Button13 As Button

		' Token: 0x040002F1 RID: 753
		<AccessedThroughProperty("Button14")>
		Private _Button14 As Button

		' Token: 0x040002F2 RID: 754
		<AccessedThroughProperty("Button15")>
		Private _Button15 As Button

		' Token: 0x040002F3 RID: 755
		<AccessedThroughProperty("Button16")>
		Private _Button16 As Button

		' Token: 0x040002F4 RID: 756
		<AccessedThroughProperty("WebBrowser4")>
		Private _WebBrowser4 As WebBrowser

		' Token: 0x040002F5 RID: 757
		<AccessedThroughProperty("TextBox4")>
		Private _TextBox4 As TextBox

		' Token: 0x040002F6 RID: 758
		<AccessedThroughProperty("Button17")>
		Private _Button17 As Button

		' Token: 0x040002F7 RID: 759
		<AccessedThroughProperty("Button18")>
		Private _Button18 As Button

		' Token: 0x040002F8 RID: 760
		<AccessedThroughProperty("Button19")>
		Private _Button19 As Button

		' Token: 0x040002F9 RID: 761
		<AccessedThroughProperty("Button20")>
		Private _Button20 As Button

		' Token: 0x040002FA RID: 762
		<AccessedThroughProperty("WebBrowser5")>
		Private _WebBrowser5 As WebBrowser

		' Token: 0x040002FB RID: 763
		<AccessedThroughProperty("TextBox5")>
		Private _TextBox5 As TextBox
	End Class
End Namespace
