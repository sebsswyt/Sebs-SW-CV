Namespace CV
	' Token: 0x02000013 RID: 19
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox18
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000192 RID: 402 RVA: 0x03D86258 File Offset: 0x03D84658
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

		' Token: 0x06000193 RID: 403 RVA: 0x03D862A8 File Offset: 0x03D846A8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.AboutBox18))
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(150, 252)
			button.Location = point
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(179, 78)
			button2.Size = size
			Me.Button1.TabIndex = 0
			Me.Button1.Text = "Button1"
			Me.Button1.UseVisualStyleBackColor = True
			Me.PictureBox1.Image = CType(componentResourceManager.GetObject("PictureBox1.Image"), Global.System.Drawing.Image)
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox1
			point = New Global.System.Drawing.Point(150, 105)
			pictureBox.Location = point
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox1
			size = New Global.System.Drawing.Size(179, 132)
			pictureBox2.Size = size
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 1
			Me.PictureBox1.TabStop = False
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(198, 82)
			label.Location = point
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(81, 20)
			label2.Size = size
			Me.Label1.TabIndex = 2
			Me.Label1.Text = "Sebastian"
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
			point = New Global.System.Drawing.Point(335, 151)
			label3.Location = point
			Me.Label2.Name = "Label2"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(86, 20)
			label4.Size = size
			Me.Label2.TabIndex = 3
			Me.Label2.Text = "<- Mikkel B"
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label3
			point = New Global.System.Drawing.Point(82, 134)
			label5.Location = point
			Me.Label3.Name = "Label3"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(62, 20)
			label6.Size = size
			Me.Label3.TabIndex = 4
			Me.Label3.Text = "Silan ->"
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(532, 374)
			Me.ClientSize = size
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.PictureBox1)
			Me.Controls.Add(Me.Button1)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "AboutBox18"
			Dim padding As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(9)
			Me.Padding = padding
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Silans Program"
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x040000AC RID: 172
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
