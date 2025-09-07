Namespace CV
	' Token: 0x0200005B RID: 91
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form44
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000FC9 RID: 4041 RVA: 0x03DE21D8 File Offset: 0x03DE05D8
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

		' Token: 0x06000FCA RID: 4042 RVA: 0x03DE2228 File Offset: 0x03DE0628
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.Form44))
			Me.OpenFileDialog1 = New Global.System.Windows.Forms.OpenFileDialog()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.OpenFileDialog2 = New Global.System.Windows.Forms.OpenFileDialog()
			Me.TextBox2 = New Global.System.Windows.Forms.TextBox()
			Me.TextBox3 = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Timer2 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.SuspendLayout()
			Me.OpenFileDialog1.FileName = "Load.txt"
			Me.OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt"
			Me.OpenFileDialog1.Title = "Find Load.txt File"
			Me.TextBox1.BackColor = Global.System.Drawing.Color.White
			Dim textBox As Global.System.Windows.Forms.Control = Me.TextBox1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(126, 358)
			textBox.Location = point
			Me.TextBox1.Multiline = True
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.[ReadOnly] = True
			Dim textBox2 As Global.System.Windows.Forms.Control = Me.TextBox1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(381, 179)
			textBox2.Size = size
			Me.TextBox1.TabIndex = 0
			Me.Button1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Button1.BackgroundImage = CType(componentResourceManager.GetObject("Button1.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button1.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			point = New Global.System.Drawing.Point(621, 2)
			button.Location = point
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(85, 83)
			button2.Size = size
			Me.Button1.TabIndex = 1
			Me.Button1.UseVisualStyleBackColor = False
			Me.OpenFileDialog2.FileName = "Load-P.txt"
			Me.OpenFileDialog2.Filter = "Text Files (*.txt)|*.txt"
			Me.OpenFileDialog2.ShowHelp = True
			Me.TextBox2.BackColor = Global.System.Drawing.Color.White
			Dim textBox3 As Global.System.Windows.Forms.Control = Me.TextBox2
			point = New Global.System.Drawing.Point(126, 173)
			textBox3.Location = point
			Me.TextBox2.Multiline = True
			Me.TextBox2.Name = "TextBox2"
			Me.TextBox2.[ReadOnly] = True
			Dim textBox4 As Global.System.Windows.Forms.Control = Me.TextBox2
			size = New Global.System.Drawing.Size(381, 179)
			textBox4.Size = size
			Me.TextBox2.TabIndex = 2
			Me.TextBox2.Visible = False
			Me.TextBox3.BackColor = Global.System.Drawing.Color.White
			Dim textBox5 As Global.System.Windows.Forms.Control = Me.TextBox3
			point = New Global.System.Drawing.Point(126, 2)
			textBox5.Location = point
			Me.TextBox3.Multiline = True
			Me.TextBox3.Name = "TextBox3"
			Me.TextBox3.[ReadOnly] = True
			Dim textBox6 As Global.System.Windows.Forms.Control = Me.TextBox3
			size = New Global.System.Drawing.Size(381, 165)
			textBox6.Size = size
			Me.TextBox3.TabIndex = 3
			Me.TextBox3.Visible = False
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 15.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(638, 112)
			label.Location = point
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(24, 25)
			label2.Size = size
			Me.Label1.TabIndex = 4
			Me.Label1.Text = "0"
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(708, 549)
			Me.ClientSize = size
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.TextBox3)
			Me.Controls.Add(Me.TextBox2)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.TextBox1)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.Name = "Form44"
			Me.Text = "Load Program"
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x040005D5 RID: 1493
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
