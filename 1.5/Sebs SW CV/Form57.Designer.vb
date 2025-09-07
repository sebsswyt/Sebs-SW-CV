Namespace CV
	' Token: 0x02000069 RID: 105
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form57
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06001170 RID: 4464 RVA: 0x03DED498 File Offset: 0x03DEB898
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

		' Token: 0x06001171 RID: 4465 RVA: 0x03DED4E8 File Offset: 0x03DEB8E8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.Form57))
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.PictureBox2 = New Global.System.Windows.Forms.PictureBox()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.RestartTimer = New Global.System.Windows.Forms.Timer(Me.components)
			Me.StartingTimer = New Global.System.Windows.Forms.Timer(Me.components)
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PictureBox2, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel1.SuspendLayout()
			Me.SuspendLayout()
			Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label1.AutoSize = True
			Me.Label1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label1.Font = New Global.System.Drawing.Font("Trebuchet MS", 24F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(161, 241)
			label.Location = point
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(174, 40)
			label2.Size = size
			Me.Label1.TabIndex = 0
			Me.Label1.Text = "Restarting."
			Me.PictureBox1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.PictureBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.PictureBox1.Image = CType(componentResourceManager.GetObject("PictureBox1.Image"), Global.System.Drawing.Image)
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox1
			point = New Global.System.Drawing.Point(177, 80)
			pictureBox.Location = point
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox1
			size = New Global.System.Drawing.Size(146, 144)
			pictureBox2.Size = size
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 1
			Me.PictureBox1.TabStop = False
			Me.PictureBox2.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.PictureBox2.Image = CType(componentResourceManager.GetObject("PictureBox2.Image"), Global.System.Drawing.Image)
			Dim pictureBox3 As Global.System.Windows.Forms.Control = Me.PictureBox2
			point = New Global.System.Drawing.Point(0, 0)
			pictureBox3.Location = point
			Me.PictureBox2.Name = "PictureBox2"
			Dim pictureBox4 As Global.System.Windows.Forms.Control = Me.PictureBox2
			size = New Global.System.Drawing.Size(1509, 695)
			pictureBox4.Size = size
			Me.PictureBox2.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox2.TabIndex = 2
			Me.PictureBox2.TabStop = False
			Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Panel1.BackColor = Global.System.Drawing.Color.DodgerBlue
			Me.Panel1.Controls.Add(Me.ProgressBar1)
			Me.Panel1.Controls.Add(Me.Button1)
			Me.Panel1.Controls.Add(Me.PictureBox1)
			Me.Panel1.Controls.Add(Me.Label1)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(468, 116)
			panel.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(543, 436)
			panel2.Size = size
			Me.Panel1.TabIndex = 3
			Me.ProgressBar1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim progressBar As Global.System.Windows.Forms.Control = Me.ProgressBar1
			point = New Global.System.Drawing.Point(0, 410)
			progressBar.Location = point
			Me.ProgressBar1.Name = "ProgressBar1"
			Dim progressBar2 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			size = New Global.System.Drawing.Size(540, 23)
			progressBar2.Size = size
			Me.ProgressBar1.TabIndex = 3
			Me.Button1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button1.BackgroundImage = CType(componentResourceManager.GetObject("Button1.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button1.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			point = New Global.System.Drawing.Point(467, 0)
			button.Location = point
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(73, 68)
			button2.Size = size
			Me.Button1.TabIndex = 2
			Me.Button1.UseVisualStyleBackColor = True
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(1509, 695)
			Me.ClientSize = size
			Me.Controls.Add(Me.Panel1)
			Me.Controls.Add(Me.PictureBox2)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			Me.Name = "Form57"
			Me.Text = "Form33"
			Me.WindowState = Global.System.Windows.Forms.FormWindowState.Maximized
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PictureBox2, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x0400067A RID: 1658
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
