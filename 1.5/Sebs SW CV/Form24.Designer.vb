Namespace CV
	' Token: 0x02000045 RID: 69
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form24
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000AFB RID: 2811 RVA: 0x03DC19F0 File Offset: 0x03DBFDF0
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

		' Token: 0x06000AFC RID: 2812 RVA: 0x03DC1A40 File Offset: 0x03DBFE40
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.Form24))
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.PictureBox2 = New Global.System.Windows.Forms.PictureBox()
			Me.Panel1.SuspendLayout()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PictureBox2, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.Button1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 15.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(15, 245)
			button.Location = point
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(136, 50)
			button2.Size = size
			Me.Button1.TabIndex = 0
			Me.Button1.Text = "Start mod"
			Me.Button1.UseVisualStyleBackColor = True
			Me.Panel1.Controls.Add(Me.PictureBox1)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(12, 12)
			panel.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(326, 227)
			panel2.Size = size
			Me.Panel1.TabIndex = 1
			Me.Panel1.Visible = False
			Me.PictureBox1.Image = CType(componentResourceManager.GetObject("PictureBox1.Image"), Global.System.Drawing.Image)
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox1
			point = New Global.System.Drawing.Point(3, 3)
			pictureBox.Location = point
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox1
			size = New Global.System.Drawing.Size(320, 221)
			pictureBox2.Size = size
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 0
			Me.PictureBox1.TabStop = False
			Me.PictureBox2.Image = CType(componentResourceManager.GetObject("PictureBox2.Image"), Global.System.Drawing.Image)
			Dim pictureBox3 As Global.System.Windows.Forms.Control = Me.PictureBox2
			point = New Global.System.Drawing.Point(355, 12)
			pictureBox3.Location = point
			Me.PictureBox2.Name = "PictureBox2"
			Dim pictureBox4 As Global.System.Windows.Forms.Control = Me.PictureBox2
			size = New Global.System.Drawing.Size(279, 157)
			pictureBox4.Size = size
			Me.PictureBox2.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox2.TabIndex = 2
			Me.PictureBox2.TabStop = False
			Me.PictureBox2.Visible = False
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(681, 520)
			Me.ClientSize = size
			Me.Controls.Add(Me.PictureBox2)
			Me.Controls.Add(Me.Panel1)
			Me.Controls.Add(Me.Button1)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.Name = "Form24"
			Me.Text = "Sebs SW bug fix"
			Me.Panel1.ResumeLayout(False)
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PictureBox2, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x0400040A RID: 1034
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
