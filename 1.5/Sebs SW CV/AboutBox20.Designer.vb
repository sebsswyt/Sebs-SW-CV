Namespace CV
	' Token: 0x02000016 RID: 22
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox20
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060001B5 RID: 437 RVA: 0x03D86E94 File Offset: 0x03D85294
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

		' Token: 0x060001C0 RID: 448 RVA: 0x03D86F98 File Offset: 0x03D85398
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.AboutBox20))
			Me.LabelProductName = New Global.System.Windows.Forms.Label()
			Me.LabelVersion = New Global.System.Windows.Forms.Label()
			Me.LabelCopyright = New Global.System.Windows.Forms.Label()
			Me.LabelCompanyName = New Global.System.Windows.Forms.Label()
			Me.TextBoxDescription = New Global.System.Windows.Forms.TextBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.Button3 = New Global.System.Windows.Forms.Button()
			Me.Panel1.SuspendLayout()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Dim labelProductName As Global.System.Windows.Forms.Control = Me.LabelProductName
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(129, 7)
			labelProductName.Location = point
			Dim labelProductName2 As Global.System.Windows.Forms.Control = Me.LabelProductName
			Dim padding As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(6, 0, 3, 0)
			labelProductName2.Margin = padding
			Dim labelProductName3 As Global.System.Windows.Forms.Control = Me.LabelProductName
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(0, 17)
			labelProductName3.MaximumSize = size
			Me.LabelProductName.Name = "LabelProductName"
			Dim labelProductName4 As Global.System.Windows.Forms.Control = Me.LabelProductName
			size = New Global.System.Drawing.Size(130, 17)
			labelProductName4.Size = size
			Me.LabelProductName.TabIndex = 0
			Me.LabelProductName.Text = "Product Name Sebs SW"
			Me.LabelProductName.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim labelVersion As Global.System.Windows.Forms.Control = Me.LabelVersion
			point = New Global.System.Drawing.Point(129, 41)
			labelVersion.Location = point
			Dim labelVersion2 As Global.System.Windows.Forms.Control = Me.LabelVersion
			padding = New Global.System.Windows.Forms.Padding(6, 0, 3, 0)
			labelVersion2.Margin = padding
			Dim labelVersion3 As Global.System.Windows.Forms.Control = Me.LabelVersion
			size = New Global.System.Drawing.Size(0, 17)
			labelVersion3.MaximumSize = size
			Me.LabelVersion.Name = "LabelVersion"
			Dim labelVersion4 As Global.System.Windows.Forms.Control = Me.LabelVersion
			size = New Global.System.Drawing.Size(166, 17)
			labelVersion4.Size = size
			Me.LabelVersion.TabIndex = 0
			Me.LabelVersion.Text = "Version the Version of Sebs SW"
			Me.LabelVersion.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim labelCopyright As Global.System.Windows.Forms.Control = Me.LabelCopyright
			point = New Global.System.Drawing.Point(129, 58)
			labelCopyright.Location = point
			Dim labelCopyright2 As Global.System.Windows.Forms.Control = Me.LabelCopyright
			padding = New Global.System.Windows.Forms.Padding(6, 0, 3, 0)
			labelCopyright2.Margin = padding
			Dim labelCopyright3 As Global.System.Windows.Forms.Control = Me.LabelCopyright
			size = New Global.System.Drawing.Size(0, 17)
			labelCopyright3.MaximumSize = size
			Me.LabelCopyright.Name = "LabelCopyright"
			Dim labelCopyright4 As Global.System.Windows.Forms.Control = Me.LabelCopyright
			size = New Global.System.Drawing.Size(166, 17)
			labelCopyright4.Size = size
			Me.LabelCopyright.TabIndex = 0
			Me.LabelCopyright.Text = "Copyright 2021 - 2023"
			Me.LabelCopyright.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim labelCompanyName As Global.System.Windows.Forms.Control = Me.LabelCompanyName
			point = New Global.System.Drawing.Point(129, 75)
			labelCompanyName.Location = point
			Dim labelCompanyName2 As Global.System.Windows.Forms.Control = Me.LabelCompanyName
			padding = New Global.System.Windows.Forms.Padding(6, 0, 3, 0)
			labelCompanyName2.Margin = padding
			Dim labelCompanyName3 As Global.System.Windows.Forms.Control = Me.LabelCompanyName
			size = New Global.System.Drawing.Size(0, 17)
			labelCompanyName3.MaximumSize = size
			Me.LabelCompanyName.Name = "LabelCompanyName"
			Dim labelCompanyName4 As Global.System.Windows.Forms.Control = Me.LabelCompanyName
			size = New Global.System.Drawing.Size(166, 17)
			labelCompanyName4.Size = size
			Me.LabelCompanyName.TabIndex = 0
			Me.LabelCompanyName.Text = "Company Name Sebs Web"
			Me.LabelCompanyName.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim textBoxDescription As Global.System.Windows.Forms.Control = Me.TextBoxDescription
			point = New Global.System.Drawing.Point(129, 111)
			textBoxDescription.Location = point
			Dim textBoxDescription2 As Global.System.Windows.Forms.Control = Me.TextBoxDescription
			padding = New Global.System.Windows.Forms.Padding(6, 3, 3, 3)
			textBoxDescription2.Margin = padding
			Me.TextBoxDescription.Multiline = True
			Me.TextBoxDescription.Name = "TextBoxDescription"
			Me.TextBoxDescription.[ReadOnly] = True
			Me.TextBoxDescription.ScrollBars = Global.System.Windows.Forms.ScrollBars.Both
			Dim textBoxDescription3 As Global.System.Windows.Forms.Control = Me.TextBoxDescription
			size = New Global.System.Drawing.Size(254, 134)
			textBoxDescription3.Size = size
			Me.TextBoxDescription.TabIndex = 0
			Me.TextBoxDescription.TabStop = False
			Me.TextBoxDescription.Text = "Description :" & vbCrLf & vbCrLf & "This Program looks like a copy " & vbCrLf & "of Windows 7" & vbCrLf & "Yes" & vbCrLf & "This is based on Windows 7" & vbCrLf & "i Love Windows 7" & vbCrLf & "i use Windows 10 for Home Use" & vbCrLf & "only." & vbCrLf & "but i use Windows 7 on Windows 10" & vbCrLf & vbCrLf & vbCrLf
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			point = New Global.System.Drawing.Point(308, 252)
			button.Location = point
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(75, 23)
			button2.Size = size
			Me.Button1.TabIndex = 1
			Me.Button1.Text = "&OK"
			Me.Button1.UseVisualStyleBackColor = True
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(129, 24)
			label.Location = point
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			padding = New Global.System.Windows.Forms.Padding(6, 0, 3, 0)
			label2.Margin = padding
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(0, 17)
			label3.MaximumSize = size
			Me.Label1.Name = "Label1"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(77, 17)
			label4.Size = size
			Me.Label1.TabIndex = 2
			Me.Label1.Text = "Build 1000.0"
			Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Panel1.Controls.Add(Me.PictureBox1)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Left
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(9, 9)
			panel.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(111, 266)
			panel2.Size = size
			Me.Panel1.TabIndex = 3
			Me.PictureBox1.Dock = Global.System.Windows.Forms.DockStyle.Left
			Me.PictureBox1.Image = CType(componentResourceManager.GetObject("PictureBox1.Image"), Global.System.Drawing.Image)
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox1
			point = New Global.System.Drawing.Point(0, 0)
			pictureBox.Location = point
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox1
			size = New Global.System.Drawing.Size(111, 266)
			pictureBox2.Size = size
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 0
			Me.PictureBox1.TabStop = False
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button2
			point = New Global.System.Drawing.Point(212, 252)
			button3.Location = point
			Me.Button2.Name = "Button2"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button2
			size = New Global.System.Drawing.Size(95, 23)
			button4.Size = size
			Me.Button2.TabIndex = 4
			Me.Button2.Text = "About Window"
			Me.Button2.UseVisualStyleBackColor = True
			Dim button5 As Global.System.Windows.Forms.Control = Me.Button3
			point = New Global.System.Drawing.Point(132, 252)
			button5.Location = point
			Me.Button3.Name = "Button3"
			Dim button6 As Global.System.Windows.Forms.Control = Me.Button3
			size = New Global.System.Drawing.Size(77, 23)
			button6.Size = size
			Me.Button3.TabIndex = 5
			Me.Button3.Text = "System Info"
			Me.Button3.UseVisualStyleBackColor = True
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(437, 284)
			Me.ClientSize = size
			Me.Controls.Add(Me.Button3)
			Me.Controls.Add(Me.Button2)
			Me.Controls.Add(Me.Panel1)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.LabelCompanyName)
			Me.Controls.Add(Me.LabelProductName)
			Me.Controls.Add(Me.TextBoxDescription)
			Me.Controls.Add(Me.LabelCopyright)
			Me.Controls.Add(Me.LabelVersion)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "AboutBox20"
			padding = New Global.System.Windows.Forms.Padding(9)
			Me.Padding = padding
			Me.ShowInTaskbar = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "About Sebs SW ???"
			Me.Panel1.ResumeLayout(False)
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x040000BF RID: 191
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
