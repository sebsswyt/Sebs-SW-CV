Namespace CV
	' Token: 0x02000063 RID: 99
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form51
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060010CF RID: 4303 RVA: 0x03DE94F0 File Offset: 0x03DE78F0
		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				Dim flag As Boolean = disposing AndAlso Me.components IsNot Nothing
				If flag Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x060010D0 RID: 4304 RVA: 0x03DE9540 File Offset: 0x03DE7940
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.Form51))
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.Panel2 = New Global.System.Windows.Forms.Panel()
			Me.Button5 = New Global.System.Windows.Forms.Button()
			Me.Button3 = New Global.System.Windows.Forms.Button()
			Me.Button4 = New Global.System.Windows.Forms.Button()
			Me.Button6 = New Global.System.Windows.Forms.Button()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Button7 = New Global.System.Windows.Forms.Button()
			Me.Button8 = New Global.System.Windows.Forms.Button()
			Me.Button9 = New Global.System.Windows.Forms.Button()
			Me.Panel1.SuspendLayout()
			Me.Panel2.SuspendLayout()
			Me.SuspendLayout()
			Me.TextBox1.Anchor = Global.System.Windows.Forms.AnchorStyles.None
			Me.TextBox1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 15.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim textBox As Global.System.Windows.Forms.Control = Me.TextBox1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(421, 259)
			textBox.Location = point
			Me.TextBox1.Name = "TextBox1"
			Dim textBox2 As Global.System.Windows.Forms.Control = Me.TextBox1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(454, 31)
			textBox2.Size = size
			Me.TextBox1.TabIndex = 0
			Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.None
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Trebuchet MS", 18F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(536, 196)
			label.Location = point
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(205, 29)
			label2.Size = size
			Me.Label1.TabIndex = 1
			Me.Label1.Text = "New UserName Ui"
			Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
			Me.Panel1.BackColor = Global.System.Drawing.Color.LightGray
			Me.Panel1.Controls.Add(Me.Button9)
			Me.Panel1.Controls.Add(Me.Button8)
			Me.Panel1.Controls.Add(Me.Button7)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(0, 83)
			panel.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(205, 587)
			panel2.Size = size
			Me.Panel1.TabIndex = 2
			Me.Button1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.Button1.BackColor = Global.System.Drawing.Color.LightGray
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.Font = New Global.System.Drawing.Font("Trebuchet MS", 15.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			point = New Global.System.Drawing.Point(602, 579)
			button.Location = point
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(139, 78)
			button2.Size = size
			Me.Button1.TabIndex = 3
			Me.Button1.Text = "Create"
			Me.Button1.UseVisualStyleBackColor = False
			Me.Button1.Visible = False
			Me.Button2.Anchor = Global.System.Windows.Forms.AnchorStyles.None
			Me.Button2.BackColor = Global.System.Drawing.Color.LightGray
			Me.Button2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button2.Font = New Global.System.Drawing.Font("Trebuchet MS", 15.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button2
			point = New Global.System.Drawing.Point(659, 321)
			button3.Location = point
			Me.Button2.Name = "Button2"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button2
			size = New Global.System.Drawing.Size(221, 90)
			button4.Size = size
			Me.Button2.TabIndex = 4
			Me.Button2.Text = "Rename Username"
			Me.Button2.UseVisualStyleBackColor = False
			Me.Panel2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Panel2.BackColor = Global.System.Drawing.Color.Silver
			Me.Panel2.Controls.Add(Me.Button5)
			Me.Panel2.Controls.Add(Me.Button3)
			Me.Panel2.Controls.Add(Me.Button4)
			Dim panel3 As Global.System.Windows.Forms.Control = Me.Panel2
			point = New Global.System.Drawing.Point(0, 1)
			panel3.Location = point
			Me.Panel2.Name = "Panel2"
			Dim panel4 As Global.System.Windows.Forms.Control = Me.Panel2
			size = New Global.System.Drawing.Size(1020, 84)
			panel4.Size = size
			Me.Panel2.TabIndex = 5
			Me.Button5.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button5.BackColor = Global.System.Drawing.Color.Transparent
			Me.Button5.BackgroundImage = CType(componentResourceManager.GetObject("Button5.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button5.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button5.Cursor = Global.System.Windows.Forms.Cursors.Arrow
			Me.Button5.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button5.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 15.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button5 As Global.System.Windows.Forms.Control = Me.Button5
			point = New Global.System.Drawing.Point(749, 3)
			button5.Location = point
			Me.Button5.Name = "Button5"
			Dim button6 As Global.System.Windows.Forms.Control = Me.Button5
			size = New Global.System.Drawing.Size(86, 78)
			button6.Size = size
			Me.Button5.TabIndex = 8
			Me.Button5.UseVisualStyleBackColor = False
			Me.Button3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button3.BackColor = Global.System.Drawing.Color.Transparent
			Me.Button3.BackgroundImage = CType(componentResourceManager.GetObject("Button3.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button3.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button3.Cursor = Global.System.Windows.Forms.Cursors.Arrow
			Me.Button3.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 15.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button7 As Global.System.Windows.Forms.Control = Me.Button3
			point = New Global.System.Drawing.Point(931, 3)
			button7.Location = point
			Me.Button3.Name = "Button3"
			Dim button8 As Global.System.Windows.Forms.Control = Me.Button3
			size = New Global.System.Drawing.Size(86, 78)
			button8.Size = size
			Me.Button3.TabIndex = 6
			Me.Button3.UseVisualStyleBackColor = False
			Me.Button4.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button4.BackColor = Global.System.Drawing.Color.Transparent
			Me.Button4.BackgroundImage = CType(componentResourceManager.GetObject("Button4.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button4.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button4.Cursor = Global.System.Windows.Forms.Cursors.Arrow
			Me.Button4.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button4.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 15.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button9 As Global.System.Windows.Forms.Control = Me.Button4
			point = New Global.System.Drawing.Point(841, 3)
			button9.Location = point
			Me.Button4.Name = "Button4"
			Dim button10 As Global.System.Windows.Forms.Control = Me.Button4
			size = New Global.System.Drawing.Size(86, 78)
			button10.Size = size
			Me.Button4.TabIndex = 7
			Me.Button4.UseVisualStyleBackColor = False
			Me.Button6.Anchor = Global.System.Windows.Forms.AnchorStyles.None
			Me.Button6.BackColor = Global.System.Drawing.Color.LightGray
			Me.Button6.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button6.Font = New Global.System.Drawing.Font("Trebuchet MS", 15.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button11 As Global.System.Windows.Forms.Control = Me.Button6
			point = New Global.System.Drawing.Point(432, 321)
			button11.Location = point
			Me.Button6.Name = "Button6"
			Dim button12 As Global.System.Windows.Forms.Control = Me.Button6
			size = New Global.System.Drawing.Size(221, 90)
			button12.Size = size
			Me.Button6.TabIndex = 6
			Me.Button6.Text = "Paste text"
			Me.Button6.UseVisualStyleBackColor = False
			Me.Button6.Visible = False
			Me.Timer1.Enabled = True
			Me.Button7.BackColor = Global.System.Drawing.Color.Transparent
			Me.Button7.BackgroundImage = CType(componentResourceManager.GetObject("Button7.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button7.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button7.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button13 As Global.System.Windows.Forms.Control = Me.Button7
			point = New Global.System.Drawing.Point(13, 8)
			button13.Location = point
			Me.Button7.Name = "Button7"
			Dim button14 As Global.System.Windows.Forms.Control = Me.Button7
			size = New Global.System.Drawing.Size(180, 181)
			button14.Size = size
			Me.Button7.TabIndex = 0
			Me.Button7.UseVisualStyleBackColor = False
			Me.Button8.BackColor = Global.System.Drawing.Color.Transparent
			Me.Button8.BackgroundImage = CType(componentResourceManager.GetObject("Button8.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button8.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button8.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button15 As Global.System.Windows.Forms.Control = Me.Button8
			point = New Global.System.Drawing.Point(13, 195)
			button15.Location = point
			Me.Button8.Name = "Button8"
			Dim button16 As Global.System.Windows.Forms.Control = Me.Button8
			size = New Global.System.Drawing.Size(180, 174)
			button16.Size = size
			Me.Button8.TabIndex = 1
			Me.Button8.UseVisualStyleBackColor = False
			Me.Button9.BackColor = Global.System.Drawing.Color.Transparent
			Me.Button9.BackgroundImage = CType(componentResourceManager.GetObject("Button9.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button9.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button9.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button17 As Global.System.Windows.Forms.Control = Me.Button9
			point = New Global.System.Drawing.Point(12, 375)
			button17.Location = point
			Me.Button9.Name = "Button9"
			Dim button18 As Global.System.Windows.Forms.Control = Me.Button9
			size = New Global.System.Drawing.Size(180, 168)
			button18.Size = size
			Me.Button9.TabIndex = 2
			Me.Button9.UseVisualStyleBackColor = False
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(1021, 669)
			Me.ClientSize = size
			Me.Controls.Add(Me.Button6)
			Me.Controls.Add(Me.Panel2)
			Me.Controls.Add(Me.Button2)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.Panel1)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.TextBox1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.Name = "Form51"
			Me.Text = "Username Settings"
			Me.Panel1.ResumeLayout(False)
			Me.Panel2.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x0400063C RID: 1596
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
