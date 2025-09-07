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
	' Token: 0x0200003C RID: 60
	<DesignerGenerated()>
	Public Partial Class Form18
		Inherits Form

		' Token: 0x0600074D RID: 1869 RVA: 0x03DA7144 File Offset: 0x03DA5544
		<DebuggerNonUserCode()>
		Public Sub New()
			Dim _ENCList As List(Of WeakReference) = Form18.__ENCList
			SyncLock _ENCList
				Form18.__ENCList.Add(New WeakReference(Me))
			End SyncLock
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000273 RID: 627
		' (get) Token: 0x06000750 RID: 1872 RVA: 0x03DA7C2C File Offset: 0x03DA602C
		' (set) Token: 0x06000751 RID: 1873 RVA: 0x03DA7C44 File Offset: 0x03DA6044
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

		' Token: 0x17000274 RID: 628
		' (get) Token: 0x06000752 RID: 1874 RVA: 0x03DA7CA4 File Offset: 0x03DA60A4
		' (set) Token: 0x06000753 RID: 1875 RVA: 0x03DA7CBC File Offset: 0x03DA60BC
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

		' Token: 0x17000275 RID: 629
		' (get) Token: 0x06000754 RID: 1876 RVA: 0x03DA7D1C File Offset: 0x03DA611C
		' (set) Token: 0x06000755 RID: 1877 RVA: 0x03DA7D34 File Offset: 0x03DA6134
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

		' Token: 0x17000276 RID: 630
		' (get) Token: 0x06000756 RID: 1878 RVA: 0x03DA7D94 File Offset: 0x03DA6194
		' (set) Token: 0x06000757 RID: 1879 RVA: 0x03DA7DAC File Offset: 0x03DA61AC
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

		' Token: 0x17000277 RID: 631
		' (get) Token: 0x06000758 RID: 1880 RVA: 0x03DA7DB8 File Offset: 0x03DA61B8
		' (set) Token: 0x06000759 RID: 1881 RVA: 0x03DA7DD0 File Offset: 0x03DA61D0
		Friend Overridable Property PictureBox1 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox1_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox1_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox1_Click
				Dim flag As Boolean = Me._PictureBox1 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox1.MouseLeave, eventHandler
					RemoveHandler Me._PictureBox1.MouseEnter, eventHandler2
					RemoveHandler Me._PictureBox1.Click, eventHandler3
				End If
				Me._PictureBox1 = value
				flag = Me._PictureBox1 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox1.MouseLeave, eventHandler
					AddHandler Me._PictureBox1.MouseEnter, eventHandler2
					AddHandler Me._PictureBox1.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x17000278 RID: 632
		' (get) Token: 0x0600075A RID: 1882 RVA: 0x03DA7E80 File Offset: 0x03DA6280
		' (set) Token: 0x0600075B RID: 1883 RVA: 0x03DA7E98 File Offset: 0x03DA6298
		Friend Overridable Property PictureBox3 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox3_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox3_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox3_Click
				Dim flag As Boolean = Me._PictureBox3 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox3.MouseLeave, eventHandler
					RemoveHandler Me._PictureBox3.MouseEnter, eventHandler2
					RemoveHandler Me._PictureBox3.Click, eventHandler3
				End If
				Me._PictureBox3 = value
				flag = Me._PictureBox3 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox3.MouseLeave, eventHandler
					AddHandler Me._PictureBox3.MouseEnter, eventHandler2
					AddHandler Me._PictureBox3.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x17000279 RID: 633
		' (get) Token: 0x0600075C RID: 1884 RVA: 0x03DA7F48 File Offset: 0x03DA6348
		' (set) Token: 0x0600075D RID: 1885 RVA: 0x03DA7F60 File Offset: 0x03DA6360
		Friend Overridable Property PictureBox2 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.PictureBox2_MouseLeave
				Dim eventHandler2 As EventHandler = AddressOf Me.PictureBox2_MouseEnter
				Dim eventHandler3 As EventHandler = AddressOf Me.PictureBox2_Click
				Dim flag As Boolean = Me._PictureBox2 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox2.MouseLeave, eventHandler
					RemoveHandler Me._PictureBox2.MouseEnter, eventHandler2
					RemoveHandler Me._PictureBox2.Click, eventHandler3
				End If
				Me._PictureBox2 = value
				flag = Me._PictureBox2 IsNot Nothing
				If flag Then
					AddHandler Me._PictureBox2.MouseLeave, eventHandler
					AddHandler Me._PictureBox2.MouseEnter, eventHandler2
					AddHandler Me._PictureBox2.Click, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x1700027A RID: 634
		' (get) Token: 0x0600075E RID: 1886 RVA: 0x03DA8010 File Offset: 0x03DA6410
		' (set) Token: 0x0600075F RID: 1887 RVA: 0x03DA8028 File Offset: 0x03DA6428
		Friend Overridable Property Panel2 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.Panel2_MouseMove
				Dim mouseEventHandler2 As MouseEventHandler = AddressOf Me.Panel2_MouseDown
				Dim flag As Boolean = Me._Panel2 IsNot Nothing
				If flag Then
					RemoveHandler Me._Panel2.MouseMove, mouseEventHandler
					RemoveHandler Me._Panel2.MouseDown, mouseEventHandler2
				End If
				Me._Panel2 = value
				flag = Me._Panel2 IsNot Nothing
				If flag Then
					AddHandler Me._Panel2.MouseMove, mouseEventHandler
					AddHandler Me._Panel2.MouseDown, mouseEventHandler2
				End If
			End Set
		End Property

		' Token: 0x1700027B RID: 635
		' (get) Token: 0x06000760 RID: 1888 RVA: 0x03DA80B0 File Offset: 0x03DA64B0
		' (set) Token: 0x06000761 RID: 1889 RVA: 0x03DA80C8 File Offset: 0x03DA64C8
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

		' Token: 0x1700027C RID: 636
		' (get) Token: 0x06000762 RID: 1890 RVA: 0x03DA8128 File Offset: 0x03DA6528
		' (set) Token: 0x06000763 RID: 1891 RVA: 0x03DA8140 File Offset: 0x03DA6540
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

		' Token: 0x1700027D RID: 637
		' (get) Token: 0x06000764 RID: 1892 RVA: 0x03DA81A0 File Offset: 0x03DA65A0
		' (set) Token: 0x06000765 RID: 1893 RVA: 0x03DA81B8 File Offset: 0x03DA65B8
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

		' Token: 0x1700027E RID: 638
		' (get) Token: 0x06000766 RID: 1894 RVA: 0x03DA8218 File Offset: 0x03DA6618
		' (set) Token: 0x06000767 RID: 1895 RVA: 0x03DA8230 File Offset: 0x03DA6630
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

		' Token: 0x06000768 RID: 1896 RVA: 0x03DA823C File Offset: 0x03DA663C
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.AboutBox1.Show()
		End Sub

		' Token: 0x06000769 RID: 1897 RVA: 0x03DA8250 File Offset: 0x03DA6650
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form3.Show()
		End Sub

		' Token: 0x0600076A RID: 1898 RVA: 0x03DA8264 File Offset: 0x03DA6664
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form21.Show()
		End Sub

		' Token: 0x0600076B RID: 1899 RVA: 0x03DA8278 File Offset: 0x03DA6678
		Private Sub Button11_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form17.Show()
		End Sub

		' Token: 0x0600076C RID: 1900 RVA: 0x03DA828C File Offset: 0x03DA668C
		Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form31.Show()
		End Sub

		' Token: 0x0600076D RID: 1901 RVA: 0x03DA82A0 File Offset: 0x03DA66A0
		Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form22.Show()
		End Sub

		' Token: 0x0600076E RID: 1902 RVA: 0x03DA82B4 File Offset: 0x03DA66B4
		Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Form39.Show()
		End Sub

		' Token: 0x0600076F RID: 1903 RVA: 0x03DA82C8 File Offset: 0x03DA66C8
		Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox1.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000770 RID: 1904 RVA: 0x03DA82E0 File Offset: 0x03DA66E0
		Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox1.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000771 RID: 1905 RVA: 0x03DA82F8 File Offset: 0x03DA66F8
		Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox2.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000772 RID: 1906 RVA: 0x03DA8310 File Offset: 0x03DA6710
		Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox2.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000773 RID: 1907 RVA: 0x03DA8328 File Offset: 0x03DA6728
		Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs)
			Me.PictureBox3.BackColor = Color.AliceBlue
		End Sub

		' Token: 0x06000774 RID: 1908 RVA: 0x03DA8340 File Offset: 0x03DA6740
		Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs)
			Me.PictureBox3.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000775 RID: 1909 RVA: 0x03DA8358 File Offset: 0x03DA6758
		Private Sub Button17_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000776 RID: 1910 RVA: 0x03DA8364 File Offset: 0x03DA6764
		Private Sub Button18_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.WindowState = FormWindowState.Normal
			If flag Then
				Me.WindowState = FormWindowState.Maximized
			Else
				Me.WindowState = FormWindowState.Normal
			End If
		End Sub

		' Token: 0x06000777 RID: 1911 RVA: 0x03DA8394 File Offset: 0x03DA6794
		Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs)
			' The following expression was wrapped in a checked-expression
			Me.mouse_move = New Point(0 - e.X, 0 - e.Y)
		End Sub

		' Token: 0x06000778 RID: 1912 RVA: 0x03DA83B4 File Offset: 0x03DA67B4
		Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = e.Button = MouseButtons.Left
			If flag Then
				Dim mousePosition As Point = Control.MousePosition
				mousePosition.Offset(Me.mouse_move.X, Me.mouse_move.Y)
				Me.Location = mousePosition
			End If
		End Sub

		' Token: 0x06000779 RID: 1913 RVA: 0x03DA8404 File Offset: 0x03DA6804
		Private Sub Button19_Click(sender As Object, e As EventArgs)
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x040002C7 RID: 711
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040002C9 RID: 713
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x040002CA RID: 714
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x040002CB RID: 715
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040002CC RID: 716
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x040002CD RID: 717
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x040002CE RID: 718
		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		' Token: 0x040002CF RID: 719
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x040002D0 RID: 720
		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel

		' Token: 0x040002D1 RID: 721
		<AccessedThroughProperty("Button19")>
		Private _Button19 As Button

		' Token: 0x040002D2 RID: 722
		<AccessedThroughProperty("Button17")>
		Private _Button17 As Button

		' Token: 0x040002D3 RID: 723
		<AccessedThroughProperty("Button18")>
		Private _Button18 As Button

		' Token: 0x040002D4 RID: 724
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x040002D5 RID: 725
		Private mouse_move As Point
	End Class
End Namespace
