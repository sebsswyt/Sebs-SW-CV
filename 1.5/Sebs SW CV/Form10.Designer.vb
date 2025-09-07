Namespace CV
	' Token: 0x02000034 RID: 52
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form10
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060005D7 RID: 1495 RVA: 0x03D9E098 File Offset: 0x03D9C498
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

		' Token: 0x060005D8 RID: 1496 RVA: 0x03D9E0E8 File Offset: 0x03D9C4E8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.Form10))
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.ErrorProvider1 = New Global.System.Windows.Forms.ErrorProvider(Me.components)
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ErrorProvider1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 15.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(441, 12)
			button.Location = point
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(207, 72)
			button2.Size = size
			Me.Button1.TabIndex = 0
			Me.Button1.Text = "Create a New User"
			Me.Button1.UseVisualStyleBackColor = True
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 15.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(164, 108)
			label.Location = point
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(88, 25)
			label2.Size = size
			Me.Label1.TabIndex = 1
			Me.Label1.Text = "You are"
			Me.PictureBox1.Image = CType(componentResourceManager.GetObject("PictureBox1.Image"), Global.System.Drawing.Image)
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox1
			point = New Global.System.Drawing.Point(258, 12)
			pictureBox.Location = point
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox1
			size = New Global.System.Drawing.Size(100, 93)
			pictureBox2.Size = size
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 2
			Me.PictureBox1.TabStop = False
			Me.ErrorProvider1.BlinkRate = 2
			Me.ErrorProvider1.BlinkStyle = Global.System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
			Me.ErrorProvider1.ContainerControl = Me
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button2
			point = New Global.System.Drawing.Point(301, 304)
			button3.Location = point
			Me.Button2.Name = "Button2"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button2
			size = New Global.System.Drawing.Size(75, 23)
			button4.Size = size
			Me.Button2.TabIndex = 3
			Me.Button2.Text = "Button2"
			Me.Button2.UseVisualStyleBackColor = True
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 15.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
			point = New Global.System.Drawing.Point(251, 108)
			label3.Location = point
			Me.Label2.Name = "Label2"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(110, 25)
			label4.Size = size
			Me.Label2.TabIndex = 4
			Me.Label2.Text = "--------------"
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			size = New Global.System.Drawing.Size(660, 468)
			Me.ClientSize = size
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.Button2)
			Me.Controls.Add(Me.PictureBox1)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.Button1)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.Name = "Form10"
			Me.Text = "All Users Control Panel"
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ErrorProvider1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x04000235 RID: 565
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
