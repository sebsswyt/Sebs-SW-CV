Namespace CV
	' Token: 0x02000017 RID: 23
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox21
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060001D5 RID: 469 RVA: 0x03D87AB8 File Offset: 0x03D85EB8
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

		' Token: 0x060001D6 RID: 470 RVA: 0x03D87B08 File Offset: 0x03D85F08
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.Timer2 = New Global.System.Windows.Forms.Timer(Me.components)
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(120, 45)
			button.Location = point
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(125, 42)
			button2.Size = size
			Me.Button1.TabIndex = 0
			Me.Button1.Text = "Button1"
			Me.Button1.UseVisualStyleBackColor = True
			Me.Timer1.Enabled = True
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox1
			point = New Global.System.Drawing.Point(103, 122)
			pictureBox.Location = point
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox1
			size = New Global.System.Drawing.Size(100, 89)
			pictureBox2.Size = size
			Me.PictureBox1.TabIndex = 1
			Me.PictureBox1.TabStop = False
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(414, 276)
			Me.ClientSize = size
			Me.Controls.Add(Me.PictureBox1)
			Me.Controls.Add(Me.Button1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "AboutBox21"
			Dim padding As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(9)
			Me.Padding = padding
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "AboutBox21"
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x040000C7 RID: 199
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
