Namespace CV
	' Token: 0x0200006F RID: 111
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form8
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600122A RID: 4650 RVA: 0x03DF3424 File Offset: 0x03DF1824
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

		' Token: 0x0600122B RID: 4651 RVA: 0x03DF3474 File Offset: 0x03DF1874
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.Form8))
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Button3 = New Global.System.Windows.Forms.Button()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(187, 167)
			button.Location = point
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(75, 23)
			button2.Size = size
			Me.Button1.TabIndex = 0
			Me.Button1.Text = "Update"
			Me.Button1.UseVisualStyleBackColor = True
			Me.PictureBox1.BackColor = Global.System.Drawing.SystemColors.ActiveBorder
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox1
			point = New Global.System.Drawing.Point(268, 139)
			pictureBox.Location = point
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox1
			size = New Global.System.Drawing.Size(291, 75)
			pictureBox2.Size = size
			Me.PictureBox1.TabIndex = 2
			Me.PictureBox1.TabStop = False
			Me.PictureBox1.Visible = False
			Me.ProgressBar1.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim progressBar As Global.System.Windows.Forms.Control = Me.ProgressBar1
			point = New Global.System.Drawing.Point(275, 160)
			progressBar.Location = point
			Me.ProgressBar1.Name = "ProgressBar1"
			Me.ProgressBar1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim progressBar2 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			size = New Global.System.Drawing.Size(271, 30)
			progressBar2.Size = size
			Me.ProgressBar1.TabIndex = 3
			Me.Button2.BackColor = Global.System.Drawing.SystemColors.ControlLight
			Me.Button2.Enabled = False
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button2
			point = New Global.System.Drawing.Point(575, 167)
			button3.Location = point
			Me.Button2.Name = "Button2"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button2
			size = New Global.System.Drawing.Size(102, 23)
			button4.Size = size
			Me.Button2.TabIndex = 4
			Me.Button2.Text = "Download is Done"
			Me.Button2.UseVisualStyleBackColor = False
			Dim button5 As Global.System.Windows.Forms.Control = Me.Button3
			point = New Global.System.Drawing.Point(187, 167)
			button5.Location = point
			Me.Button3.Name = "Button3"
			Dim button6 As Global.System.Windows.Forms.Control = Me.Button3
			size = New Global.System.Drawing.Size(75, 23)
			button6.Size = size
			Me.Button3.TabIndex = 5
			Me.Button3.Text = "Stop Update"
			Me.Button3.UseVisualStyleBackColor = True
			Me.Button3.Visible = False
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.SystemColors.Highlight
			size = New Global.System.Drawing.Size(1066, 541)
			Me.ClientSize = size
			Me.Controls.Add(Me.Button3)
			Me.Controls.Add(Me.Button2)
			Me.Controls.Add(Me.ProgressBar1)
			Me.Controls.Add(Me.PictureBox1)
			Me.Controls.Add(Me.Button1)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.Name = "Form8"
			Me.Text = "Sebs SW Update 1.0"
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x040006CC RID: 1740
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
