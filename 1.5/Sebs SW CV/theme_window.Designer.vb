Namespace CV
	' Token: 0x02000077 RID: 119
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class theme_window
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060012C6 RID: 4806 RVA: 0x03DF6C60 File Offset: 0x03DF5060
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

		' Token: 0x060012C7 RID: 4807 RVA: 0x03DF6CB0 File Offset: 0x03DF50B0
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.theme_window))
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.Button3 = New Global.System.Windows.Forms.Button()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.Button4 = New Global.System.Windows.Forms.Button()
			Me.Button5 = New Global.System.Windows.Forms.Button()
			Me.ColorDialog1 = New Global.System.Windows.Forms.ColorDialog()
			Me.Panel1.SuspendLayout()
			Me.SuspendLayout()
			Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Panel1.BackColor = Global.System.Drawing.Color.Silver
			Me.Panel1.Controls.Add(Me.Button3)
			Me.Panel1.Controls.Add(Me.Button1)
			Me.Panel1.Controls.Add(Me.Button2)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(677, 2)
			panel.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(287, 87)
			panel2.Size = size
			Me.Panel1.TabIndex = 0
			Me.Panel1.Visible = False
			Me.Button3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button3.BackColor = Global.System.Drawing.Color.Transparent
			Me.Button3.BackgroundImage = CType(componentResourceManager.GetObject("Button3.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button3.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button3.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button As Global.System.Windows.Forms.Control = Me.Button3
			point = New Global.System.Drawing.Point(6, 0)
			button.Location = point
			Me.Button3.Name = "Button3"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button3
			size = New Global.System.Drawing.Size(88, 87)
			button2.Size = size
			Me.Button3.TabIndex = 3
			Me.Button3.UseVisualStyleBackColor = False
			Me.Button1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Button1.BackgroundImage = CType(componentResourceManager.GetObject("Button1.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button1.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button1
			point = New Global.System.Drawing.Point(194, 0)
			button3.Location = point
			Me.Button1.Name = "Button1"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(88, 87)
			button4.Size = size
			Me.Button1.TabIndex = 1
			Me.Button1.UseVisualStyleBackColor = False
			Me.Button2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button2.BackColor = Global.System.Drawing.Color.Transparent
			Me.Button2.BackgroundImage = CType(componentResourceManager.GetObject("Button2.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button2.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button5 As Global.System.Windows.Forms.Control = Me.Button2
			point = New Global.System.Drawing.Point(100, 0)
			button5.Location = point
			Me.Button2.Name = "Button2"
			Dim button6 As Global.System.Windows.Forms.Control = Me.Button2
			size = New Global.System.Drawing.Size(88, 87)
			button6.Size = size
			Me.Button2.TabIndex = 2
			Me.Button2.UseVisualStyleBackColor = False
			Dim button7 As Global.System.Windows.Forms.Control = Me.Button4
			point = New Global.System.Drawing.Point(12, 18)
			button7.Location = point
			Me.Button4.Name = "Button4"
			Dim button8 As Global.System.Windows.Forms.Control = Me.Button4
			size = New Global.System.Drawing.Size(144, 71)
			button8.Size = size
			Me.Button4.TabIndex = 1
			Me.Button4.Text = "Dark Mode"
			Me.Button4.UseVisualStyleBackColor = True
			Dim button9 As Global.System.Windows.Forms.Control = Me.Button5
			point = New Global.System.Drawing.Point(12, 468)
			button9.Location = point
			Me.Button5.Name = "Button5"
			Dim button10 As Global.System.Windows.Forms.Control = Me.Button5
			size = New Global.System.Drawing.Size(144, 94)
			button10.Size = size
			Me.Button5.TabIndex = 2
			Me.Button5.Text = "Button5"
			Me.Button5.UseVisualStyleBackColor = True
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 16F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Silver
			size = New Global.System.Drawing.Size(966, 574)
			Me.ClientSize = size
			Me.Controls.Add(Me.Button5)
			Me.Controls.Add(Me.Button4)
			Me.Controls.Add(Me.Panel1)
			Me.Font = New Global.System.Drawing.Font("Trebuchet MS", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			Dim padding As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.Margin = padding
			Me.Name = "theme_window"
			Me.Text = "Theme"
			Me.Panel1.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x0400070B RID: 1803
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
