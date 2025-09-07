Namespace CV
	' Token: 0x02000071 RID: 113
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Loginz
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600128E RID: 4750 RVA: 0x03DF5AB4 File Offset: 0x03DF3EB4
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

		' Token: 0x0600129D RID: 4765 RVA: 0x03DF5CA8 File Offset: 0x03DF40A8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.Loginz))
			Me.LogoPictureBox = New Global.System.Windows.Forms.PictureBox()
			Me.UsernameLabel = New Global.System.Windows.Forms.Label()
			Me.PasswordLabel = New Global.System.Windows.Forms.Label()
			Me.UsernameTextBox = New Global.System.Windows.Forms.TextBox()
			Me.PasswordTextBox = New Global.System.Windows.Forms.TextBox()
			Me.OK = New Global.System.Windows.Forms.Button()
			Me.Cancel = New Global.System.Windows.Forms.Button()
			CType(Me.LogoPictureBox, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.LogoPictureBox.Image = CType(componentResourceManager.GetObject("LogoPictureBox.Image"), Global.System.Drawing.Image)
			Dim logoPictureBox As Global.System.Windows.Forms.Control = Me.LogoPictureBox
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			logoPictureBox.Location = point
			Me.LogoPictureBox.Name = "LogoPictureBox"
			Dim logoPictureBox2 As Global.System.Windows.Forms.Control = Me.LogoPictureBox
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(123, 193)
			logoPictureBox2.Size = size
			Me.LogoPictureBox.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.LogoPictureBox.TabIndex = 0
			Me.LogoPictureBox.TabStop = False
			Dim usernameLabel As Global.System.Windows.Forms.Control = Me.UsernameLabel
			point = New Global.System.Drawing.Point(129, 0)
			usernameLabel.Location = point
			Me.UsernameLabel.Name = "UsernameLabel"
			Dim usernameLabel2 As Global.System.Windows.Forms.Control = Me.UsernameLabel
			size = New Global.System.Drawing.Size(220, 23)
			usernameLabel2.Size = size
			Me.UsernameLabel.TabIndex = 0
			Me.UsernameLabel.Text = "&User name"
			Me.UsernameLabel.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.UsernameLabel.Visible = False
			Dim passwordLabel As Global.System.Windows.Forms.Control = Me.PasswordLabel
			point = New Global.System.Drawing.Point(133, 59)
			passwordLabel.Location = point
			Me.PasswordLabel.Name = "PasswordLabel"
			Dim passwordLabel2 As Global.System.Windows.Forms.Control = Me.PasswordLabel
			size = New Global.System.Drawing.Size(220, 23)
			passwordLabel2.Size = size
			Me.PasswordLabel.TabIndex = 2
			Me.PasswordLabel.Text = "&BC"
			Me.PasswordLabel.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim usernameTextBox As Global.System.Windows.Forms.Control = Me.UsernameTextBox
			point = New Global.System.Drawing.Point(131, 20)
			usernameTextBox.Location = point
			Me.UsernameTextBox.Name = "UsernameTextBox"
			Dim usernameTextBox2 As Global.System.Windows.Forms.Control = Me.UsernameTextBox
			size = New Global.System.Drawing.Size(220, 20)
			usernameTextBox2.Size = size
			Me.UsernameTextBox.TabIndex = 1
			Me.UsernameTextBox.Visible = False
			Dim passwordTextBox As Global.System.Windows.Forms.Control = Me.PasswordTextBox
			point = New Global.System.Drawing.Point(133, 85)
			passwordTextBox.Location = point
			Me.PasswordTextBox.Name = "PasswordTextBox"
			Me.PasswordTextBox.PasswordChar = "*"c
			Dim passwordTextBox2 As Global.System.Windows.Forms.Control = Me.PasswordTextBox
			size = New Global.System.Drawing.Size(220, 20)
			passwordTextBox2.Size = size
			Me.PasswordTextBox.TabIndex = 3
			Dim ok As Global.System.Windows.Forms.Control = Me.OK
			point = New Global.System.Drawing.Point(155, 161)
			ok.Location = point
			Me.OK.Name = "OK"
			Dim ok2 As Global.System.Windows.Forms.Control = Me.OK
			size = New Global.System.Drawing.Size(94, 23)
			ok2.Size = size
			Me.OK.TabIndex = 4
			Me.OK.Text = "&OK"
			Me.Cancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			Dim cancel As Global.System.Windows.Forms.Control = Me.Cancel
			point = New Global.System.Drawing.Point(258, 161)
			cancel.Location = point
			Me.Cancel.Name = "Cancel"
			Dim cancel2 As Global.System.Windows.Forms.Control = Me.Cancel
			size = New Global.System.Drawing.Size(94, 23)
			cancel2.Size = size
			Me.Cancel.TabIndex = 5
			Me.Cancel.Text = "&Cancel"
			Me.AcceptButton = Me.OK
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me.Cancel
			size = New Global.System.Drawing.Size(361, 192)
			Me.ClientSize = size
			Me.Controls.Add(Me.Cancel)
			Me.Controls.Add(Me.OK)
			Me.Controls.Add(Me.PasswordTextBox)
			Me.Controls.Add(Me.UsernameTextBox)
			Me.Controls.Add(Me.PasswordLabel)
			Me.Controls.Add(Me.UsernameLabel)
			Me.Controls.Add(Me.LogoPictureBox)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Loginz"
			Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Loginz"
			CType(Me.LogoPictureBox, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x040006F8 RID: 1784
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
