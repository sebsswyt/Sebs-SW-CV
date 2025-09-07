Namespace CV
	' Token: 0x0200000A RID: 10
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox1
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060000F0 RID: 240 RVA: 0x03D81DE8 File Offset: 0x03D801E8
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

		' Token: 0x06000101 RID: 257 RVA: 0x03D82054 File Offset: 0x03D80454
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.AboutBox1))
			Me.TableLayoutPanel = New Global.System.Windows.Forms.TableLayoutPanel()
			Me.LogoPictureBox = New Global.System.Windows.Forms.PictureBox()
			Me.LabelProductName = New Global.System.Windows.Forms.Label()
			Me.LabelVersion = New Global.System.Windows.Forms.Label()
			Me.LabelCopyright = New Global.System.Windows.Forms.Label()
			Me.LabelCompanyName = New Global.System.Windows.Forms.Label()
			Me.TextBoxDescription = New Global.System.Windows.Forms.TextBox()
			Me.OKButton = New Global.System.Windows.Forms.Button()
			Me.TableLayoutPanel.SuspendLayout()
			CType(Me.LogoPictureBox, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.TableLayoutPanel.ColumnCount = 2
			Me.TableLayoutPanel.ColumnStyles.Add(New Global.System.Windows.Forms.ColumnStyle(Global.System.Windows.Forms.SizeType.Percent, 33F))
			Me.TableLayoutPanel.ColumnStyles.Add(New Global.System.Windows.Forms.ColumnStyle(Global.System.Windows.Forms.SizeType.Percent, 67F))
			Me.TableLayoutPanel.Controls.Add(Me.LogoPictureBox, 0, 0)
			Me.TableLayoutPanel.Controls.Add(Me.LabelProductName, 1, 0)
			Me.TableLayoutPanel.Controls.Add(Me.LabelVersion, 1, 1)
			Me.TableLayoutPanel.Controls.Add(Me.LabelCopyright, 1, 2)
			Me.TableLayoutPanel.Controls.Add(Me.LabelCompanyName, 1, 3)
			Me.TableLayoutPanel.Controls.Add(Me.TextBoxDescription, 1, 4)
			Me.TableLayoutPanel.Controls.Add(Me.OKButton, 1, 5)
			Me.TableLayoutPanel.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim tableLayoutPanel As Global.System.Windows.Forms.Control = Me.TableLayoutPanel
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(9, 11)
			tableLayoutPanel.Location = point
			Dim tableLayoutPanel2 As Global.System.Windows.Forms.Control = Me.TableLayoutPanel
			Dim padding As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			tableLayoutPanel2.Margin = padding
			Me.TableLayoutPanel.Name = "TableLayoutPanel"
			Me.TableLayoutPanel.RowCount = 6
			Me.TableLayoutPanel.RowStyles.Add(New Global.System.Windows.Forms.RowStyle(Global.System.Windows.Forms.SizeType.Percent, 10F))
			Me.TableLayoutPanel.RowStyles.Add(New Global.System.Windows.Forms.RowStyle(Global.System.Windows.Forms.SizeType.Percent, 10F))
			Me.TableLayoutPanel.RowStyles.Add(New Global.System.Windows.Forms.RowStyle(Global.System.Windows.Forms.SizeType.Percent, 10F))
			Me.TableLayoutPanel.RowStyles.Add(New Global.System.Windows.Forms.RowStyle(Global.System.Windows.Forms.SizeType.Percent, 10F))
			Me.TableLayoutPanel.RowStyles.Add(New Global.System.Windows.Forms.RowStyle(Global.System.Windows.Forms.SizeType.Percent, 50F))
			Me.TableLayoutPanel.RowStyles.Add(New Global.System.Windows.Forms.RowStyle(Global.System.Windows.Forms.SizeType.Percent, 10F))
			Dim tableLayoutPanel3 As Global.System.Windows.Forms.Control = Me.TableLayoutPanel
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(396, 267)
			tableLayoutPanel3.Size = size
			Me.TableLayoutPanel.TabIndex = 0
			Me.LogoPictureBox.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.LogoPictureBox.Image = CType(componentResourceManager.GetObject("LogoPictureBox.Image"), Global.System.Drawing.Image)
			Dim logoPictureBox As Global.System.Windows.Forms.Control = Me.LogoPictureBox
			point = New Global.System.Drawing.Point(3, 4)
			logoPictureBox.Location = point
			Dim logoPictureBox2 As Global.System.Windows.Forms.Control = Me.LogoPictureBox
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			logoPictureBox2.Margin = padding
			Me.LogoPictureBox.Name = "LogoPictureBox"
			Me.TableLayoutPanel.SetRowSpan(Me.LogoPictureBox, 6)
			Dim logoPictureBox3 As Global.System.Windows.Forms.Control = Me.LogoPictureBox
			size = New Global.System.Drawing.Size(124, 259)
			logoPictureBox3.Size = size
			Me.LogoPictureBox.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.LogoPictureBox.TabIndex = 0
			Me.LogoPictureBox.TabStop = False
			Me.LabelProductName.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.LabelProductName.Font = New Global.System.Drawing.Font("Trebuchet MS", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim labelProductName As Global.System.Windows.Forms.Control = Me.LabelProductName
			point = New Global.System.Drawing.Point(136, 0)
			labelProductName.Location = point
			Dim labelProductName2 As Global.System.Windows.Forms.Control = Me.LabelProductName
			padding = New Global.System.Windows.Forms.Padding(6, 0, 3, 0)
			labelProductName2.Margin = padding
			Dim labelProductName3 As Global.System.Windows.Forms.Control = Me.LabelProductName
			size = New Global.System.Drawing.Size(0, 21)
			labelProductName3.MaximumSize = size
			Me.LabelProductName.Name = "LabelProductName"
			Dim labelProductName4 As Global.System.Windows.Forms.Control = Me.LabelProductName
			size = New Global.System.Drawing.Size(257, 21)
			labelProductName4.Size = size
			Me.LabelProductName.TabIndex = 0
			Me.LabelProductName.Text = "Product Name Sebs SW CV"
			Me.LabelProductName.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.LabelVersion.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.LabelVersion.Font = New Global.System.Drawing.Font("Trebuchet MS", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim labelVersion As Global.System.Windows.Forms.Control = Me.LabelVersion
			point = New Global.System.Drawing.Point(136, 26)
			labelVersion.Location = point
			Dim labelVersion2 As Global.System.Windows.Forms.Control = Me.LabelVersion
			padding = New Global.System.Windows.Forms.Padding(6, 0, 3, 0)
			labelVersion2.Margin = padding
			Dim labelVersion3 As Global.System.Windows.Forms.Control = Me.LabelVersion
			size = New Global.System.Drawing.Size(0, 21)
			labelVersion3.MaximumSize = size
			Me.LabelVersion.Name = "LabelVersion"
			Dim labelVersion4 As Global.System.Windows.Forms.Control = Me.LabelVersion
			size = New Global.System.Drawing.Size(257, 21)
			labelVersion4.Size = size
			Me.LabelVersion.TabIndex = 0
			Me.LabelVersion.Text = "Version 1.3"
			Me.LabelVersion.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.LabelCopyright.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.LabelCopyright.Font = New Global.System.Drawing.Font("Trebuchet MS", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim labelCopyright As Global.System.Windows.Forms.Control = Me.LabelCopyright
			point = New Global.System.Drawing.Point(136, 52)
			labelCopyright.Location = point
			Dim labelCopyright2 As Global.System.Windows.Forms.Control = Me.LabelCopyright
			padding = New Global.System.Windows.Forms.Padding(6, 0, 3, 0)
			labelCopyright2.Margin = padding
			Dim labelCopyright3 As Global.System.Windows.Forms.Control = Me.LabelCopyright
			size = New Global.System.Drawing.Size(0, 21)
			labelCopyright3.MaximumSize = size
			Me.LabelCopyright.Name = "LabelCopyright"
			Dim labelCopyright4 As Global.System.Windows.Forms.Control = Me.LabelCopyright
			size = New Global.System.Drawing.Size(257, 21)
			labelCopyright4.Size = size
			Me.LabelCopyright.TabIndex = 0
			Me.LabelCopyright.Text = "Copyright Sebs Web 2021"
			Me.LabelCopyright.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.LabelCompanyName.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.LabelCompanyName.Font = New Global.System.Drawing.Font("Trebuchet MS", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim labelCompanyName As Global.System.Windows.Forms.Control = Me.LabelCompanyName
			point = New Global.System.Drawing.Point(136, 78)
			labelCompanyName.Location = point
			Dim labelCompanyName2 As Global.System.Windows.Forms.Control = Me.LabelCompanyName
			padding = New Global.System.Windows.Forms.Padding(6, 0, 3, 0)
			labelCompanyName2.Margin = padding
			Dim labelCompanyName3 As Global.System.Windows.Forms.Control = Me.LabelCompanyName
			size = New Global.System.Drawing.Size(0, 21)
			labelCompanyName3.MaximumSize = size
			Me.LabelCompanyName.Name = "LabelCompanyName"
			Dim labelCompanyName4 As Global.System.Windows.Forms.Control = Me.LabelCompanyName
			size = New Global.System.Drawing.Size(257, 21)
			labelCompanyName4.Size = size
			Me.LabelCompanyName.TabIndex = 0
			Me.LabelCompanyName.Text = "Company Name Sebs Web "
			Me.LabelCompanyName.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.TextBoxDescription.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.TextBoxDescription.Font = New Global.System.Drawing.Font("Trebuchet MS", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim textBoxDescription As Global.System.Windows.Forms.Control = Me.TextBoxDescription
			point = New Global.System.Drawing.Point(136, 108)
			textBoxDescription.Location = point
			Dim textBoxDescription2 As Global.System.Windows.Forms.Control = Me.TextBoxDescription
			padding = New Global.System.Windows.Forms.Padding(6, 4, 3, 4)
			textBoxDescription2.Margin = padding
			Me.TextBoxDescription.Multiline = True
			Me.TextBoxDescription.Name = "TextBoxDescription"
			Me.TextBoxDescription.[ReadOnly] = True
			Me.TextBoxDescription.ScrollBars = Global.System.Windows.Forms.ScrollBars.Both
			Dim textBoxDescription3 As Global.System.Windows.Forms.Control = Me.TextBoxDescription
			size = New Global.System.Drawing.Size(257, 125)
			textBoxDescription3.Size = size
			Me.TextBoxDescription.TabIndex = 0
			Me.TextBoxDescription.TabStop = False
			Me.TextBoxDescription.Text = "Description :" & vbCrLf & vbCrLf & "This Program is touch friendly" & vbCrLf & "and This Program looks like a little IPad"
			Me.OKButton.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.OKButton.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			Dim okbutton As Global.System.Windows.Forms.Control = Me.OKButton
			point = New Global.System.Drawing.Point(318, 241)
			okbutton.Location = point
			Dim okbutton2 As Global.System.Windows.Forms.Control = Me.OKButton
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			okbutton2.Margin = padding
			Me.OKButton.Name = "OKButton"
			Dim okbutton3 As Global.System.Windows.Forms.Control = Me.OKButton
			size = New Global.System.Drawing.Size(75, 22)
			okbutton3.Size = size
			Me.OKButton.TabIndex = 0
			Me.OKButton.Text = "&OK"
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 16F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me.OKButton
			size = New Global.System.Drawing.Size(414, 289)
			Me.ClientSize = size
			Me.Controls.Add(Me.TableLayoutPanel)
			Me.Font = New Global.System.Drawing.Font("Trebuchet MS", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.Margin = padding
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "AboutBox1"
			padding = New Global.System.Windows.Forms.Padding(9, 11, 9, 11)
			Me.Padding = padding
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "About"
			Me.TableLayoutPanel.ResumeLayout(False)
			Me.TableLayoutPanel.PerformLayout()
			CType(Me.LogoPictureBox, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x04000074 RID: 116
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
