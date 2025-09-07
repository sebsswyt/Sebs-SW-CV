Namespace CV
	' Token: 0x02000062 RID: 98
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form50
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600109C RID: 4252 RVA: 0x03DE8194 File Offset: 0x03DE6594
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

		' Token: 0x0600109D RID: 4253 RVA: 0x03DE81E4 File Offset: 0x03DE65E4
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.Form50))
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.Panel2 = New Global.System.Windows.Forms.Panel()
			Me.Button3 = New Global.System.Windows.Forms.Button()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Button4 = New Global.System.Windows.Forms.Button()
			Me.OpenFileDialog1 = New Global.System.Windows.Forms.OpenFileDialog()
			Me.RichTextBox1 = New Global.System.Windows.Forms.RichTextBox()
			Me.one = New Global.System.Windows.Forms.OpenFileDialog()
			Me.two = New Global.System.Windows.Forms.OpenFileDialog()
			Me.three = New Global.System.Windows.Forms.OpenFileDialog()
			Me.four = New Global.System.Windows.Forms.OpenFileDialog()
			Me.five = New Global.System.Windows.Forms.OpenFileDialog()
			Me.six = New Global.System.Windows.Forms.OpenFileDialog()
			Me.RichTextBox2 = New Global.System.Windows.Forms.RichTextBox()
			Me.Button5 = New Global.System.Windows.Forms.Button()
			Me.sev = New Global.System.Windows.Forms.OpenFileDialog()
			Me.Panel1.SuspendLayout()
			Me.SuspendLayout()
			Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Panel1.BackColor = Global.System.Drawing.Color.Silver
			Me.Panel1.Controls.Add(Me.Panel2)
			Me.Panel1.Controls.Add(Me.Button3)
			Me.Panel1.Controls.Add(Me.Button2)
			Me.Panel1.Controls.Add(Me.Button1)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 1)
			panel.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(1170, 68)
			panel2.Size = size
			Me.Panel1.TabIndex = 7
			Me.Panel2.BackColor = Global.System.Drawing.Color.Gray
			Dim panel3 As Global.System.Windows.Forms.Control = Me.Panel2
			point = New Global.System.Drawing.Point(0, 102)
			panel3.Location = point
			Me.Panel2.Name = "Panel2"
			Dim panel4 As Global.System.Windows.Forms.Control = Me.Panel2
			size = New Global.System.Drawing.Size(1280, 24)
			panel4.Size = size
			Me.Panel2.TabIndex = 7
			Me.Button3.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button3.BackColor = Global.System.Drawing.Color.Transparent
			Me.Button3.BackgroundImage = CType(componentResourceManager.GetObject("Button3.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button3.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button3.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Button3.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button As Global.System.Windows.Forms.Control = Me.Button3
			point = New Global.System.Drawing.Point(972, 3)
			button.Location = point
			Me.Button3.Name = "Button3"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button3
			size = New Global.System.Drawing.Size(62, 62)
			button2.Size = size
			Me.Button3.TabIndex = 2
			Me.Button3.UseVisualStyleBackColor = False
			Me.Button2.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button2.BackgroundImage = CType(componentResourceManager.GetObject("Button2.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button2.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button2.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Button2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button2
			point = New Global.System.Drawing.Point(1040, 3)
			button3.Location = point
			Me.Button2.Name = "Button2"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button2
			size = New Global.System.Drawing.Size(62, 62)
			button4.Size = size
			Me.Button2.TabIndex = 1
			Me.Button2.UseVisualStyleBackColor = True
			Me.Button1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button1.BackgroundImage = CType(componentResourceManager.GetObject("Button1.BackgroundImage"), Global.System.Drawing.Image)
			Me.Button1.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button1.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button5 As Global.System.Windows.Forms.Control = Me.Button1
			point = New Global.System.Drawing.Point(1105, 3)
			button5.Location = point
			Me.Button1.Name = "Button1"
			Dim button6 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(62, 62)
			button6.Size = size
			Me.Button1.TabIndex = 0
			Me.Button1.UseVisualStyleBackColor = True
			Me.Button4.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 18F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button7 As Global.System.Windows.Forms.Control = Me.Button4
			point = New Global.System.Drawing.Point(394, 93)
			button7.Location = point
			Me.Button4.Name = "Button4"
			Dim button8 As Global.System.Windows.Forms.Control = Me.Button4
			size = New Global.System.Drawing.Size(307, 160)
			button8.Size = size
			Me.Button4.TabIndex = 8
			Me.Button4.Text = "Start??"
			Me.Button4.UseVisualStyleBackColor = True
			Me.OpenFileDialog1.FileName = "OpenFileDialog1"
			Me.OpenFileDialog1.Filter = "All txt Files (*.swfiles)|*.swfiles"
			Dim richTextBox As Global.System.Windows.Forms.Control = Me.RichTextBox1
			point = New Global.System.Drawing.Point(895, 282)
			richTextBox.Location = point
			Me.RichTextBox1.Name = "RichTextBox1"
			Dim richTextBox2 As Global.System.Windows.Forms.Control = Me.RichTextBox1
			size = New Global.System.Drawing.Size(264, 165)
			richTextBox2.Size = size
			Me.RichTextBox1.TabIndex = 9
			Me.RichTextBox1.Text = "Picture only"
			Me.RichTextBox1.Visible = False
			Me.one.Filter = "All jpg Files (*.jpg)|*.jpg"
			Me.two.Filter = "All jpg Files (*.jpg)|*.jpg"
			Me.three.Filter = "All jpg Files (*.jpg)|*.jpg"
			Me.four.Filter = "All jpg Files (*.jpg)|*.jpg"
			Me.five.Filter = "All jpg Files (*.jpg)|*.jpg"
			Me.six.Filter = "All jpg Files (*.jpg)|*.jpg"
			Dim richTextBox3 As Global.System.Windows.Forms.Control = Me.RichTextBox2
			point = New Global.System.Drawing.Point(895, 448)
			richTextBox3.Location = point
			Me.RichTextBox2.Name = "RichTextBox2"
			Dim richTextBox4 As Global.System.Windows.Forms.Control = Me.RichTextBox2
			size = New Global.System.Drawing.Size(264, 165)
			richTextBox4.Size = size
			Me.RichTextBox2.TabIndex = 10
			Me.RichTextBox2.Text = ""
			Me.RichTextBox2.Visible = False
			Me.Button5.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 18F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button9 As Global.System.Windows.Forms.Control = Me.Button5
			point = New Global.System.Drawing.Point(394, 259)
			button9.Location = point
			Me.Button5.Name = "Button5"
			Dim button10 As Global.System.Windows.Forms.Control = Me.Button5
			size = New Global.System.Drawing.Size(307, 160)
			button10.Size = size
			Me.Button5.TabIndex = 11
			Me.Button5.Text = "Start??"
			Me.Button5.UseVisualStyleBackColor = True
			Me.sev.Filter = "All jpg Files (*.jpg)|*.jpg"
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(1171, 677)
			Me.ClientSize = size
			Me.Controls.Add(Me.Button5)
			Me.Controls.Add(Me.RichTextBox2)
			Me.Controls.Add(Me.RichTextBox1)
			Me.Controls.Add(Me.Button4)
			Me.Controls.Add(Me.Panel1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			Me.Name = "Form50"
			Me.Text = "Form50"
			Me.Panel1.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x04000627 RID: 1575
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
