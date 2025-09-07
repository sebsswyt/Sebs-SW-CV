Namespace CV
	' Token: 0x02000066 RID: 102
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form54
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600112A RID: 4394 RVA: 0x03DEB7A4 File Offset: 0x03DE9BA4
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

		' Token: 0x0600112B RID: 4395 RVA: 0x03DEB7F4 File Offset: 0x03DE9BF4
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.Form54))
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.PictureBox1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.PictureBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.PictureBox1.Image = CType(componentResourceManager.GetObject("PictureBox1.Image"), Global.System.Drawing.Image)
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(427, 120)
			pictureBox.Location = point
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(199, 198)
			pictureBox2.Size = size
			Me.PictureBox1.TabIndex = 0
			Me.PictureBox1.TabStop = False
			Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label1.AutoSize = True
			Me.Label1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 15.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(422, 332)
			label.Location = point
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(92, 25)
			label2.Size = size
			Me.Label1.TabIndex = 1
			Me.Label1.Text = "Starting."
			Me.Timer1.Enabled = True
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackgroundImage = CType(componentResourceManager.GetObject("$this.BackgroundImage"), Global.System.Drawing.Image)
			Me.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			size = New Global.System.Drawing.Size(1093, 661)
			Me.ClientSize = size
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.PictureBox1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			Me.Name = "Form54"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Startingup"
			Me.WindowState = Global.System.Windows.Forms.FormWindowState.Maximized
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x0400065D RID: 1629
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
