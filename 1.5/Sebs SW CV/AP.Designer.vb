Namespace CV
	' Token: 0x02000023 RID: 35
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class AP
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060002A4 RID: 676 RVA: 0x03D8D7CC File Offset: 0x03D8BBCC
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

		' Token: 0x060002A5 RID: 677 RVA: 0x03D8D81C File Offset: 0x03D8BC1C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.AP))
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.VLabel = New Global.System.Windows.Forms.Label()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.Panel2 = New Global.System.Windows.Forms.Panel()
			Me.Panel1.SuspendLayout()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel2.SuspendLayout()
			Me.SuspendLayout()
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(3, 3)
			button.Location = point
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(174, 79)
			button2.Size = size
			Me.Button1.TabIndex = 0
			Me.Button1.Text = "Info"
			Me.Button1.UseVisualStyleBackColor = True
			Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Panel1.BackColor = Global.System.Drawing.Color.Silver
			Me.Panel1.Controls.Add(Me.Button1)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(0, 2)
			panel.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(943, 87)
			panel2.Size = size
			Me.Panel1.TabIndex = 1
			Me.VLabel.AutoSize = True
			Me.VLabel.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 15.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim vlabel As Global.System.Windows.Forms.Control = Me.VLabel
			point = New Global.System.Drawing.Point(12, 11)
			vlabel.Location = point
			Me.VLabel.Name = "VLabel"
			Dim vlabel2 As Global.System.Windows.Forms.Control = Me.VLabel
			size = New Global.System.Drawing.Size(26, 25)
			vlabel2.Size = size
			Me.VLabel.TabIndex = 2
			Me.VLabel.Text = "V"
			Me.PictureBox1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.PictureBox1.Image = CType(componentResourceManager.GetObject("PictureBox1.Image"), Global.System.Drawing.Image)
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox1
			point = New Global.System.Drawing.Point(0, 90)
			pictureBox.Location = point
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox1
			size = New Global.System.Drawing.Size(943, 384)
			pictureBox2.Size = size
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 3
			Me.PictureBox1.TabStop = False
			Me.Panel2.Controls.Add(Me.VLabel)
			Dim panel3 As Global.System.Windows.Forms.Control = Me.Panel2
			point = New Global.System.Drawing.Point(114, 105)
			panel3.Location = point
			Me.Panel2.Name = "Panel2"
			Dim panel4 As Global.System.Windows.Forms.Control = Me.Panel2
			size = New Global.System.Drawing.Size(200, 100)
			panel4.Size = size
			Me.Panel2.TabIndex = 4
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(944, 471)
			Me.ClientSize = size
			Me.Controls.Add(Me.Panel2)
			Me.Controls.Add(Me.PictureBox1)
			Me.Controls.Add(Me.Panel1)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.Name = "AP"
			Me.Text = "About Program"
			Me.Panel1.ResumeLayout(False)
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel2.ResumeLayout(False)
			Me.Panel2.PerformLayout()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x04000115 RID: 277
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
