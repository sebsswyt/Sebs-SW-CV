Namespace CV
	' Token: 0x02000059 RID: 89
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form42
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000F50 RID: 3920 RVA: 0x03DDE7B8 File Offset: 0x03DDCBB8
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

		' Token: 0x06000F51 RID: 3921 RVA: 0x03DDE808 File Offset: 0x03DDCC08
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.Form42))
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.Panel2 = New Global.System.Windows.Forms.Panel()
			Me.CheckBox1 = New Global.System.Windows.Forms.CheckBox()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel1.SuspendLayout()
			Me.SuspendLayout()
			Me.PictureBox1.Image = CType(componentResourceManager.GetObject("PictureBox1.Image"), Global.System.Drawing.Image)
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(1165, 3)
			pictureBox.Location = point
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(67, 68)
			pictureBox2.Size = size
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 0
			Me.PictureBox1.TabStop = False
			Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Panel1.BackColor = Global.System.Drawing.Color.Silver
			Me.Panel1.Controls.Add(Me.Panel2)
			Me.Panel1.Controls.Add(Me.PictureBox1)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(2, 0)
			panel.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(1235, 76)
			panel2.Size = size
			Me.Panel1.TabIndex = 1
			Me.Panel2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim panel3 As Global.System.Windows.Forms.Control = Me.Panel2
			point = New Global.System.Drawing.Point(3, 0)
			panel3.Location = point
			Me.Panel2.Name = "Panel2"
			Dim panel4 As Global.System.Windows.Forms.Control = Me.Panel2
			size = New Global.System.Drawing.Size(1156, 76)
			panel4.Size = size
			Me.Panel2.TabIndex = 1
			Me.CheckBox1.AutoSize = True
			Dim checkBox As Global.System.Windows.Forms.Control = Me.CheckBox1
			point = New Global.System.Drawing.Point(12, 91)
			checkBox.Location = point
			Me.CheckBox1.Name = "CheckBox1"
			Dim checkBox2 As Global.System.Windows.Forms.Control = Me.CheckBox1
			size = New Global.System.Drawing.Size(81, 17)
			checkBox2.Size = size
			Me.CheckBox1.TabIndex = 2
			Me.CheckBox1.Text = "CheckBox1"
			Me.CheckBox1.UseVisualStyleBackColor = True
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(1238, 654)
			Me.ClientSize = size
			Me.Controls.Add(Me.CheckBox1)
			Me.Controls.Add(Me.Panel1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.Name = "Form42"
			Me.Text = "Form42"
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x040005A8 RID: 1448
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
