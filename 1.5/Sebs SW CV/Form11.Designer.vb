Namespace CV
	' Token: 0x02000035 RID: 53
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form11
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060005EA RID: 1514 RVA: 0x03D9E7D4 File Offset: 0x03D9CBD4
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

		' Token: 0x060005EB RID: 1515 RVA: 0x03D9E824 File Offset: 0x03D9CC24
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.Form11))
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.Button3 = New Global.System.Windows.Forms.Button()
			Me.CheckBox1 = New Global.System.Windows.Forms.CheckBox()
			Me.PictureBox2 = New Global.System.Windows.Forms.PictureBox()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PictureBox2, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.PictureBox1.BackColor = Global.System.Drawing.SystemColors.ButtonShadow
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(1, 3)
			pictureBox.Location = point
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(50, 456)
			pictureBox2.Size = size
			Me.PictureBox1.TabIndex = 0
			Me.PictureBox1.TabStop = False
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			point = New Global.System.Drawing.Point(78, 13)
			button.Location = point
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(75, 23)
			button2.Size = size
			Me.Button1.TabIndex = 1
			Me.Button1.Text = "Go back"
			Me.Button1.UseVisualStyleBackColor = True
			Dim textBox As Global.System.Windows.Forms.Control = Me.TextBox1
			point = New Global.System.Drawing.Point(145, 149)
			textBox.Location = point
			Me.TextBox1.Name = "TextBox1"
			Dim textBox2 As Global.System.Windows.Forms.Control = Me.TextBox1
			size = New Global.System.Drawing.Size(355, 20)
			textBox2.Size = size
			Me.TextBox1.TabIndex = 2
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(142, 116)
			label.Location = point
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(106, 18)
			label2.Size = size
			Me.Label1.TabIndex = 3
			Me.Label1.Text = "Name for User"
			Me.Button2.Enabled = False
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button2
			point = New Global.System.Drawing.Point(460, 33)
			button3.Location = point
			Me.Button2.Name = "Button2"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button2
			size = New Global.System.Drawing.Size(75, 23)
			button4.Size = size
			Me.Button2.TabIndex = 4
			Me.Button2.Text = "Create User"
			Me.Button2.UseVisualStyleBackColor = True
			Dim button5 As Global.System.Windows.Forms.Control = Me.Button3
			point = New Global.System.Drawing.Point(506, 149)
			button5.Location = point
			Me.Button3.Name = "Button3"
			Dim button6 As Global.System.Windows.Forms.Control = Me.Button3
			size = New Global.System.Drawing.Size(75, 23)
			button6.Size = size
			Me.Button3.TabIndex = 5
			Me.Button3.Text = "Create"
			Me.Button3.UseVisualStyleBackColor = True
			Me.CheckBox1.AutoSize = True
			Dim checkBox As Global.System.Windows.Forms.Control = Me.CheckBox1
			point = New Global.System.Drawing.Point(281, 284)
			checkBox.Location = point
			Me.CheckBox1.Name = "CheckBox1"
			Dim checkBox2 As Global.System.Windows.Forms.Control = Me.CheckBox1
			size = New Global.System.Drawing.Size(80, 17)
			checkBox2.Size = size
			Me.CheckBox1.TabIndex = 6
			Me.CheckBox1.Text = "Create user"
			Me.CheckBox1.UseVisualStyleBackColor = True
			Me.PictureBox2.BackColor = Global.System.Drawing.SystemColors.ButtonShadow
			Dim pictureBox3 As Global.System.Windows.Forms.Control = Me.PictureBox2
			point = New Global.System.Drawing.Point(655, 3)
			pictureBox3.Location = point
			Me.PictureBox2.Name = "PictureBox2"
			Dim pictureBox4 As Global.System.Windows.Forms.Control = Me.PictureBox2
			size = New Global.System.Drawing.Size(50, 456)
			pictureBox4.Size = size
			Me.PictureBox2.TabIndex = 7
			Me.PictureBox2.TabStop = False
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(708, 461)
			Me.ClientSize = size
			Me.Controls.Add(Me.PictureBox2)
			Me.Controls.Add(Me.CheckBox1)
			Me.Controls.Add(Me.Button3)
			Me.Controls.Add(Me.Button2)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.TextBox1)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.PictureBox1)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.Name = "Form11"
			Me.Text = "Users"
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PictureBox2, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x0400023D RID: 573
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
