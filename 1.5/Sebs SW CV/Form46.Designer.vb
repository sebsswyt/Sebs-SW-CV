Namespace CV
	' Token: 0x0200005D RID: 93
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form46
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600101A RID: 4122 RVA: 0x03DE4680 File Offset: 0x03DE2A80
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

		' Token: 0x0600101B RID: 4123 RVA: 0x03DE46D0 File Offset: 0x03DE2AD0
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.Form46))
			Me.SaveFileDialog1 = New Global.System.Windows.Forms.SaveFileDialog()
			Me.TextBox3 = New Global.System.Windows.Forms.TextBox()
			Me.SaveFileDialog2 = New Global.System.Windows.Forms.SaveFileDialog()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.SuspendLayout()
			Me.SaveFileDialog1.FileName = "Load.txt"
			Me.SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt"
			Me.SaveFileDialog1.Title = "Save Load.txt"
			Me.TextBox3.BackColor = Global.System.Drawing.Color.White
			Dim textBox As Global.System.Windows.Forms.Control = Me.TextBox3
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(329, 296)
			textBox.Location = point
			Me.TextBox3.Multiline = True
			Me.TextBox3.Name = "TextBox3"
			Me.TextBox3.[ReadOnly] = True
			Dim textBox2 As Global.System.Windows.Forms.Control = Me.TextBox3
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(288, 214)
			textBox2.Size = size
			Me.TextBox3.TabIndex = 0
			Me.SaveFileDialog2.FileName = "Load-path.txt"
			Me.SaveFileDialog2.Filter = "Text Files (*.txt)|*.txt"
			Me.SaveFileDialog2.Title = "Save Load-path.txt"
			Me.TextBox1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 15.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim textBox3 As Global.System.Windows.Forms.Control = Me.TextBox1
			point = New Global.System.Drawing.Point(12, 12)
			textBox3.Location = point
			Me.TextBox1.Multiline = True
			Me.TextBox1.Name = "TextBox1"
			Dim textBox4 As Global.System.Windows.Forms.Control = Me.TextBox1
			size = New Global.System.Drawing.Size(526, 216)
			textBox4.Size = size
			Me.TextBox1.TabIndex = 1
			Me.TextBox1.Text = "C:\User\(Your Username)\Pictures\"
			Me.Button1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			point = New Global.System.Drawing.Point(204, 234)
			button.Location = point
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(97, 50)
			button2.Size = size
			Me.Button1.TabIndex = 2
			Me.Button1.Text = "If Done"
			Me.Button1.UseVisualStyleBackColor = True
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(618, 510)
			Me.ClientSize = size
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.TextBox1)
			Me.Controls.Add(Me.TextBox3)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.Name = "Form46"
			Me.Text = "Load Program-save"
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x040005F4 RID: 1524
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
