Namespace CV
	' Token: 0x02000065 RID: 101
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form53
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06001109 RID: 4361 RVA: 0x03DEAB30 File Offset: 0x03DE8F30
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

		' Token: 0x0600110A RID: 4362 RVA: 0x03DEAB80 File Offset: 0x03DE8F80
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.Form53))
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.Button6 = New Global.System.Windows.Forms.Button()
			Me.SaveFileDialog1 = New Global.System.Windows.Forms.SaveFileDialog()
			Me.OpenFileDialog1 = New Global.System.Windows.Forms.OpenFileDialog()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.TextBox2 = New Global.System.Windows.Forms.TextBox()
			Me.RichTextBox1 = New Global.System.Windows.Forms.RichTextBox()
			Me.Panel1.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			Me.SuspendLayout()
			Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Panel1.BackColor = Global.System.Drawing.Color.Silver
			Me.Panel1.Controls.Add(Me.Button6)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 1)
			panel.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(700, 93)
			panel2.Size = size
			Me.Panel1.TabIndex = 0
			Me.Button6.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button6.BackgroundImage = CType(componentResourceManager.GetObject("Button6.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button6.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button6.Cursor = Global.System.Windows.Forms.Cursors.Arrow
			Me.Button6.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button As Global.System.Windows.Forms.Control = Me.Button6
			point = New Global.System.Drawing.Point(609, 3)
			button.Location = point
			Me.Button6.Name = "Button6"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button6
			size = New Global.System.Drawing.Size(88, 87)
			button2.Size = size
			Me.Button6.TabIndex = 11
			Me.Button6.UseVisualStyleBackColor = True
			Me.OpenFileDialog1.FileName = "OpenFileDialog1"
			Me.GroupBox1.Controls.Add(Me.TextBox1)
			Me.GroupBox1.Controls.Add(Me.Button1)
			Me.GroupBox1.Enabled = False
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox1
			point = New Global.System.Drawing.Point(30, 110)
			groupBox.Location = point
			Me.GroupBox1.Name = "GroupBox1"
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox1
			size = New Global.System.Drawing.Size(200, 318)
			groupBox2.Size = size
			Me.GroupBox1.TabIndex = 1
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "GroupBox1"
			Me.TextBox1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim textBox As Global.System.Windows.Forms.Control = Me.TextBox1
			point = New Global.System.Drawing.Point(6, 93)
			textBox.Location = point
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.PasswordChar = "*"c
			Dim textBox2 As Global.System.Windows.Forms.Control = Me.TextBox1
			size = New Global.System.Drawing.Size(188, 26)
			textBox2.Size = size
			Me.TextBox1.TabIndex = 4
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button1
			point = New Global.System.Drawing.Point(39, 32)
			button3.Location = point
			Me.Button1.Name = "Button1"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(114, 55)
			button4.Size = size
			Me.Button1.TabIndex = 3
			Me.Button1.Text = "Create User"
			Me.Button1.UseVisualStyleBackColor = True
			Me.GroupBox2.Controls.Add(Me.Button2)
			Me.GroupBox2.Enabled = False
			Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox2
			point = New Global.System.Drawing.Point(497, 110)
			groupBox3.Location = point
			Me.GroupBox2.Name = "GroupBox2"
			Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox2
			size = New Global.System.Drawing.Size(200, 318)
			groupBox4.Size = size
			Me.GroupBox2.TabIndex = 2
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "GroupBox2"
			Me.Button2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button5 As Global.System.Windows.Forms.Control = Me.Button2
			point = New Global.System.Drawing.Point(46, 19)
			button5.Location = point
			Me.Button2.Name = "Button2"
			Dim button6 As Global.System.Windows.Forms.Control = Me.Button2
			size = New Global.System.Drawing.Size(114, 55)
			button6.Size = size
			Me.Button2.TabIndex = 4
			Me.Button2.Text = "Login"
			Me.Button2.UseVisualStyleBackColor = True
			Me.TextBox2.Enabled = False
			Me.TextBox2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim textBox3 As Global.System.Windows.Forms.Control = Me.TextBox2
			point = New Global.System.Drawing.Point(236, 236)
			textBox3.Location = point
			Me.TextBox2.Multiline = True
			Me.TextBox2.Name = "TextBox2"
			Dim textBox4 As Global.System.Windows.Forms.Control = Me.TextBox2
			size = New Global.System.Drawing.Size(255, 160)
			textBox4.Size = size
			Me.TextBox2.TabIndex = 5
			Me.TextBox2.Text = "SEBSSWCV=abcdefghijklmnopqrstuvwxyz" & vbCrLf
			Me.RichTextBox1.Enabled = False
			Dim richTextBox As Global.System.Windows.Forms.Control = Me.RichTextBox1
			point = New Global.System.Drawing.Point(300, 386)
			richTextBox.Location = point
			Me.RichTextBox1.Name = "RichTextBox1"
			Dim richTextBox2 As Global.System.Windows.Forms.Control = Me.RichTextBox1
			size = New Global.System.Drawing.Size(100, 96)
			richTextBox2.Size = size
			Me.RichTextBox1.TabIndex = 6
			Me.RichTextBox1.Text = ""
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(701, 494)
			Me.ClientSize = size
			Me.Controls.Add(Me.RichTextBox1)
			Me.Controls.Add(Me.TextBox2)
			Me.Controls.Add(Me.GroupBox2)
			Me.Controls.Add(Me.GroupBox1)
			Me.Controls.Add(Me.Panel1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			Me.Name = "Form53"
			Me.Text = "Login"
			Me.Panel1.ResumeLayout(False)
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.GroupBox2.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x0400064F RID: 1615
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
