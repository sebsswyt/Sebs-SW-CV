Namespace CV
	' Token: 0x02000058 RID: 88
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form41
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000EF8 RID: 3832 RVA: 0x03DDC0E8 File Offset: 0x03DDA4E8
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

		' Token: 0x06000EF9 RID: 3833 RVA: 0x03DDC138 File Offset: 0x03DDA538
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.Form41))
			Me.OpenFileDialog1 = New Global.System.Windows.Forms.OpenFileDialog()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.FolderBrowserDialog1 = New Global.System.Windows.Forms.FolderBrowserDialog()
			Me.Button3 = New Global.System.Windows.Forms.Button()
			Me.Button4 = New Global.System.Windows.Forms.Button()
			Me.Button5 = New Global.System.Windows.Forms.Button()
			Me.Button6 = New Global.System.Windows.Forms.Button()
			Me.Button7 = New Global.System.Windows.Forms.Button()
			Me.Button8 = New Global.System.Windows.Forms.Button()
			Me.Button9 = New Global.System.Windows.Forms.Button()
			Me.Button10 = New Global.System.Windows.Forms.Button()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.Button12 = New Global.System.Windows.Forms.Button()
			Me.Button11 = New Global.System.Windows.Forms.Button()
			Me.Button13 = New Global.System.Windows.Forms.Button()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Button14 = New Global.System.Windows.Forms.Button()
			Me.Button15 = New Global.System.Windows.Forms.Button()
			Me.Panel2 = New Global.System.Windows.Forms.Panel()
			Me.Button16 = New Global.System.Windows.Forms.Button()
			Me.Panel1.SuspendLayout()
			Me.Panel2.SuspendLayout()
			Me.SuspendLayout()
			Me.OpenFileDialog1.Filter = "All exe Files (*.exe)|*.exe"
			Me.OpenFileDialog1.ShowHelp = True
			Me.Button1.Font = New Global.System.Drawing.Font("Trebuchet MS", 15.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(12, 86)
			button.Location = point
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(169, 102)
			button2.Size = size
			Me.Button1.TabIndex = 1
			Me.Button1.Text = "Install Program"
			Me.Button1.UseVisualStyleBackColor = True
			Me.Button2.Font = New Global.System.Drawing.Font("Trebuchet MS", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button2
			point = New Global.System.Drawing.Point(12, 194)
			button3.Location = point
			Me.Button2.Name = "Button2"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button2
			size = New Global.System.Drawing.Size(569, 23)
			button4.Size = size
			Me.Button2.TabIndex = 2
			Me.Button2.Text = "Button2"
			Me.Button2.UseVisualStyleBackColor = True
			Me.Button2.Visible = False
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Trebuchet MS", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(470, 537)
			label.Location = point
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(40, 16)
			label2.Size = size
			Me.Label1.TabIndex = 3
			Me.Label1.Text = "Label1"
			Me.Label1.Visible = False
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("Trebuchet MS", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
			point = New Global.System.Drawing.Point(532, 537)
			label3.Location = point
			Me.Label2.Name = "Label2"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(40, 16)
			label4.Size = size
			Me.Label2.TabIndex = 4
			Me.Label2.Text = "Label2"
			Me.Label2.Visible = False
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("Trebuchet MS", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label3
			point = New Global.System.Drawing.Point(588, 537)
			label5.Location = point
			Me.Label3.Name = "Label3"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(40, 16)
			label6.Size = size
			Me.Label3.TabIndex = 5
			Me.Label3.Text = "Label3"
			Me.Label3.Visible = False
			Me.Label4.AutoSize = True
			Me.Label4.Font = New Global.System.Drawing.Font("Trebuchet MS", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label4
			point = New Global.System.Drawing.Point(643, 537)
			label7.Location = point
			Me.Label4.Name = "Label4"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label4
			size = New Global.System.Drawing.Size(40, 16)
			label8.Size = size
			Me.Label4.TabIndex = 6
			Me.Label4.Text = "Label4"
			Me.Label4.Visible = False
			Me.FolderBrowserDialog1.RootFolder = Global.System.Environment.SpecialFolder.MyComputer
			Me.Button3.Font = New Global.System.Drawing.Font("Trebuchet MS", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button5 As Global.System.Windows.Forms.Control = Me.Button3
			point = New Global.System.Drawing.Point(12, 223)
			button5.Location = point
			Me.Button3.Name = "Button3"
			Dim button6 As Global.System.Windows.Forms.Control = Me.Button3
			size = New Global.System.Drawing.Size(569, 23)
			button6.Size = size
			Me.Button3.TabIndex = 7
			Me.Button3.Text = "Button3"
			Me.Button3.UseVisualStyleBackColor = True
			Me.Button3.Visible = False
			Me.Button4.Font = New Global.System.Drawing.Font("Trebuchet MS", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button7 As Global.System.Windows.Forms.Control = Me.Button4
			point = New Global.System.Drawing.Point(12, 252)
			button7.Location = point
			Me.Button4.Name = "Button4"
			Dim button8 As Global.System.Windows.Forms.Control = Me.Button4
			size = New Global.System.Drawing.Size(569, 23)
			button8.Size = size
			Me.Button4.TabIndex = 8
			Me.Button4.Text = "Button4"
			Me.Button4.UseVisualStyleBackColor = True
			Me.Button4.Visible = False
			Me.Button5.Font = New Global.System.Drawing.Font("Trebuchet MS", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button9 As Global.System.Windows.Forms.Control = Me.Button5
			point = New Global.System.Drawing.Point(12, 281)
			button9.Location = point
			Me.Button5.Name = "Button5"
			Dim button10 As Global.System.Windows.Forms.Control = Me.Button5
			size = New Global.System.Drawing.Size(569, 23)
			button10.Size = size
			Me.Button5.TabIndex = 9
			Me.Button5.Text = "Button5"
			Me.Button5.UseVisualStyleBackColor = True
			Me.Button5.Visible = False
			Me.Button6.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button6.BackgroundImage = CType(componentResourceManager.GetObject("Button6.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button6.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button6.Cursor = Global.System.Windows.Forms.Cursors.Arrow
			Me.Button6.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button11 As Global.System.Windows.Forms.Control = Me.Button6
			point = New Global.System.Drawing.Point(1134, 3)
			button11.Location = point
			Me.Button6.Name = "Button6"
			Dim button12 As Global.System.Windows.Forms.Control = Me.Button6
			size = New Global.System.Drawing.Size(71, 72)
			button12.Size = size
			Me.Button6.TabIndex = 10
			Me.Button6.UseVisualStyleBackColor = True
			Me.Button7.Font = New Global.System.Drawing.Font("Trebuchet MS", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button13 As Global.System.Windows.Forms.Control = Me.Button7
			point = New Global.System.Drawing.Point(12, 310)
			button13.Location = point
			Me.Button7.Name = "Button7"
			Dim button14 As Global.System.Windows.Forms.Control = Me.Button7
			size = New Global.System.Drawing.Size(569, 23)
			button14.Size = size
			Me.Button7.TabIndex = 11
			Me.Button7.Text = "Button7"
			Me.Button7.UseVisualStyleBackColor = True
			Me.Button7.Visible = False
			Me.Button8.Font = New Global.System.Drawing.Font("Trebuchet MS", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button15 As Global.System.Windows.Forms.Control = Me.Button8
			point = New Global.System.Drawing.Point(12, 339)
			button15.Location = point
			Me.Button8.Name = "Button8"
			Dim button16 As Global.System.Windows.Forms.Control = Me.Button8
			size = New Global.System.Drawing.Size(569, 23)
			button16.Size = size
			Me.Button8.TabIndex = 12
			Me.Button8.Text = "Button8"
			Me.Button8.UseVisualStyleBackColor = True
			Me.Button8.Visible = False
			Me.Button9.Font = New Global.System.Drawing.Font("Trebuchet MS", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button17 As Global.System.Windows.Forms.Control = Me.Button9
			point = New Global.System.Drawing.Point(12, 368)
			button17.Location = point
			Me.Button9.Name = "Button9"
			Dim button18 As Global.System.Windows.Forms.Control = Me.Button9
			size = New Global.System.Drawing.Size(569, 23)
			button18.Size = size
			Me.Button9.TabIndex = 13
			Me.Button9.Text = "Button9"
			Me.Button9.UseVisualStyleBackColor = True
			Me.Button9.Visible = False
			Me.Button10.Font = New Global.System.Drawing.Font("Trebuchet MS", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button19 As Global.System.Windows.Forms.Control = Me.Button10
			point = New Global.System.Drawing.Point(12, 397)
			button19.Location = point
			Me.Button10.Name = "Button10"
			Dim button20 As Global.System.Windows.Forms.Control = Me.Button10
			size = New Global.System.Drawing.Size(569, 23)
			button20.Size = size
			Me.Button10.TabIndex = 14
			Me.Button10.Text = "Button10"
			Me.Button10.UseVisualStyleBackColor = True
			Me.Button10.Visible = False
			Me.Label5.AutoSize = True
			Me.Label5.Font = New Global.System.Drawing.Font("Trebuchet MS", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label9 As Global.System.Windows.Forms.Control = Me.Label5
			point = New Global.System.Drawing.Point(425, 537)
			label9.Location = point
			Me.Label5.Name = "Label5"
			Dim label10 As Global.System.Windows.Forms.Control = Me.Label5
			size = New Global.System.Drawing.Size(40, 16)
			label10.Size = size
			Me.Label5.TabIndex = 15
			Me.Label5.Text = "Label5"
			Me.Label5.Visible = False
			Me.Label6.AutoSize = True
			Me.Label6.Font = New Global.System.Drawing.Font("Trebuchet MS", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label11 As Global.System.Windows.Forms.Control = Me.Label6
			point = New Global.System.Drawing.Point(380, 537)
			label11.Location = point
			Me.Label6.Name = "Label6"
			Dim label12 As Global.System.Windows.Forms.Control = Me.Label6
			size = New Global.System.Drawing.Size(40, 16)
			label12.Size = size
			Me.Label6.TabIndex = 16
			Me.Label6.Text = "Label6"
			Me.Label6.Visible = False
			Me.Label7.AutoSize = True
			Me.Label7.Font = New Global.System.Drawing.Font("Trebuchet MS", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label13 As Global.System.Windows.Forms.Control = Me.Label7
			point = New Global.System.Drawing.Point(335, 537)
			label13.Location = point
			Me.Label7.Name = "Label7"
			Dim label14 As Global.System.Windows.Forms.Control = Me.Label7
			size = New Global.System.Drawing.Size(40, 16)
			label14.Size = size
			Me.Label7.TabIndex = 17
			Me.Label7.Text = "Label7"
			Me.Label7.Visible = False
			Me.Label8.AutoSize = True
			Me.Label8.Font = New Global.System.Drawing.Font("Trebuchet MS", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label15 As Global.System.Windows.Forms.Control = Me.Label8
			point = New Global.System.Drawing.Point(290, 537)
			label15.Location = point
			Me.Label8.Name = "Label8"
			Dim label16 As Global.System.Windows.Forms.Control = Me.Label8
			size = New Global.System.Drawing.Size(40, 16)
			label16.Size = size
			Me.Label8.TabIndex = 18
			Me.Label8.Text = "Label8"
			Me.Label8.Visible = False
			Me.Label9.AutoSize = True
			Me.Label9.Font = New Global.System.Drawing.Font("Trebuchet MS", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label17 As Global.System.Windows.Forms.Control = Me.Label9
			point = New Global.System.Drawing.Point(245, 537)
			label17.Location = point
			Me.Label9.Name = "Label9"
			Dim label18 As Global.System.Windows.Forms.Control = Me.Label9
			size = New Global.System.Drawing.Size(40, 16)
			label18.Size = size
			Me.Label9.TabIndex = 19
			Me.Label9.Text = "Label9"
			Me.Label9.Visible = False
			Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Panel1.BackColor = Global.System.Drawing.Color.Silver
			Me.Panel1.Controls.Add(Me.Panel2)
			Me.Panel1.Controls.Add(Me.Button12)
			Me.Panel1.Controls.Add(Me.Button11)
			Me.Panel1.Controls.Add(Me.Button6)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(2, 2)
			panel.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(1208, 78)
			panel2.Size = size
			Me.Panel1.TabIndex = 20
			Me.Button12.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button12.BackColor = Global.System.Drawing.Color.Transparent
			Me.Button12.BackgroundImage = CType(componentResourceManager.GetObject("Button12.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button12.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button12.Cursor = Global.System.Windows.Forms.Cursors.Arrow
			Me.Button12.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button21 As Global.System.Windows.Forms.Control = Me.Button12
			point = New Global.System.Drawing.Point(987, 3)
			button21.Location = point
			Me.Button12.Name = "Button12"
			Dim button22 As Global.System.Windows.Forms.Control = Me.Button12
			size = New Global.System.Drawing.Size(67, 72)
			button22.Size = size
			Me.Button12.TabIndex = 12
			Me.Button12.UseVisualStyleBackColor = False
			Me.Button11.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button11.BackColor = Global.System.Drawing.Color.Transparent
			Me.Button11.BackgroundImage = CType(componentResourceManager.GetObject("Button11.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button11.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button11.Cursor = Global.System.Windows.Forms.Cursors.Arrow
			Me.Button11.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button23 As Global.System.Windows.Forms.Control = Me.Button11
			point = New Global.System.Drawing.Point(1060, 3)
			button23.Location = point
			Me.Button11.Name = "Button11"
			Dim button24 As Global.System.Windows.Forms.Control = Me.Button11
			size = New Global.System.Drawing.Size(68, 72)
			button24.Size = size
			Me.Button11.TabIndex = 11
			Me.Button11.UseVisualStyleBackColor = False
			Me.Button13.Font = New Global.System.Drawing.Font("Trebuchet MS", 15.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button25 As Global.System.Windows.Forms.Control = Me.Button13
			point = New Global.System.Drawing.Point(187, 86)
			button25.Location = point
			Me.Button13.Name = "Button13"
			Dim button26 As Global.System.Windows.Forms.Control = Me.Button13
			size = New Global.System.Drawing.Size(361, 102)
			button26.Size = size
			Me.Button13.TabIndex = 21
			Me.Button13.Text = "More Programs in Sebs SW CV"
			Me.Button13.UseVisualStyleBackColor = True
			Me.Timer1.Enabled = True
			Me.Button14.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button14.BackgroundImage = CType(componentResourceManager.GetObject("Button14.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button14.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button14.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button27 As Global.System.Windows.Forms.Control = Me.Button14
			point = New Global.System.Drawing.Point(1130, 3)
			button27.Location = point
			Me.Button14.Name = "Button14"
			Dim button28 As Global.System.Windows.Forms.Control = Me.Button14
			size = New Global.System.Drawing.Size(75, 72)
			button28.Size = size
			Me.Button14.TabIndex = 0
			Me.Button14.UseVisualStyleBackColor = True
			Me.Button15.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button15.BackgroundImage = CType(componentResourceManager.GetObject("Button15.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button15.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button15.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button29 As Global.System.Windows.Forms.Control = Me.Button15
			point = New Global.System.Drawing.Point(1049, 3)
			button29.Location = point
			Me.Button15.Name = "Button15"
			Dim button30 As Global.System.Windows.Forms.Control = Me.Button15
			size = New Global.System.Drawing.Size(75, 72)
			button30.Size = size
			Me.Button15.TabIndex = 1
			Me.Button15.UseVisualStyleBackColor = True
			Me.Panel2.Controls.Add(Me.Button16)
			Me.Panel2.Controls.Add(Me.Button15)
			Me.Panel2.Controls.Add(Me.Button14)
			Me.Panel2.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim panel3 As Global.System.Windows.Forms.Control = Me.Panel2
			point = New Global.System.Drawing.Point(0, 0)
			panel3.Location = point
			Me.Panel2.Name = "Panel2"
			Dim panel4 As Global.System.Windows.Forms.Control = Me.Panel2
			size = New Global.System.Drawing.Size(1208, 78)
			panel4.Size = size
			Me.Panel2.TabIndex = 22
			Me.Panel2.Visible = False
			Me.Button16.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button16.BackgroundImage = CType(componentResourceManager.GetObject("Button16.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button16.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button16.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button31 As Global.System.Windows.Forms.Control = Me.Button16
			point = New Global.System.Drawing.Point(968, 3)
			button31.Location = point
			Me.Button16.Name = "Button16"
			Dim button32 As Global.System.Windows.Forms.Control = Me.Button16
			size = New Global.System.Drawing.Size(75, 72)
			button32.Size = size
			Me.Button16.TabIndex = 2
			Me.Button16.UseVisualStyleBackColor = True
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(1213, 637)
			Me.ClientSize = size
			Me.Controls.Add(Me.Button13)
			Me.Controls.Add(Me.Panel1)
			Me.Controls.Add(Me.Label9)
			Me.Controls.Add(Me.Label8)
			Me.Controls.Add(Me.Label7)
			Me.Controls.Add(Me.Label6)
			Me.Controls.Add(Me.Label5)
			Me.Controls.Add(Me.Button10)
			Me.Controls.Add(Me.Button9)
			Me.Controls.Add(Me.Button8)
			Me.Controls.Add(Me.Button7)
			Me.Controls.Add(Me.Button5)
			Me.Controls.Add(Me.Button4)
			Me.Controls.Add(Me.Button3)
			Me.Controls.Add(Me.Label4)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.Button2)
			Me.Controls.Add(Me.Button1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.Name = "Form41"
			Me.Text = "OpenProgram"
			Me.WindowState = Global.System.Windows.Forms.FormWindowState.Maximized
			Me.Panel1.ResumeLayout(False)
			Me.Panel2.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x04000587 RID: 1415
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
