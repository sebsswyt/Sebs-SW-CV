Namespace CV
	' Token: 0x02000049 RID: 73
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form28
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000B86 RID: 2950 RVA: 0x03DC5578 File Offset: 0x03DC3978
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

		' Token: 0x06000B87 RID: 2951 RVA: 0x03DC55C8 File Offset: 0x03DC39C8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.Form28))
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.PictureBox1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.PictureBox1.Image = CType(componentResourceManager.GetObject("PictureBox1.Image"), Global.System.Drawing.Image)
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			pictureBox.Location = point
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(1192, 654)
			pictureBox2.Size = size
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 0
			Me.PictureBox1.TabStop = False
			Me.Button1.BackColor = Global.System.Drawing.Color.Chartreuse
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			point = New Global.System.Drawing.Point(12, 12)
			button.Location = point
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(100, 65)
			button2.Size = size
			Me.Button1.TabIndex = 1
			Me.Button1.Text = "???"
			Me.Button1.UseVisualStyleBackColor = False
			Me.Button1.Visible = False
			Dim progressBar As Global.System.Windows.Forms.Control = Me.ProgressBar1
			point = New Global.System.Drawing.Point(13, 619)
			progressBar.Location = point
			Me.ProgressBar1.Name = "ProgressBar1"
			Dim progressBar2 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			size = New Global.System.Drawing.Size(100, 23)
			progressBar2.Size = size
			Me.ProgressBar1.TabIndex = 2
			Me.ProgressBar1.Visible = False
			Me.Timer1.Enabled = True
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(1192, 654)
			Me.ClientSize = size
			Me.Controls.Add(Me.ProgressBar1)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.PictureBox1)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.Name = "Form28"
			Me.Text = "Form1 stop runing"
			Me.WindowState = Global.System.Windows.Forms.FormWindowState.Maximized
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x04000442 RID: 1090
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
