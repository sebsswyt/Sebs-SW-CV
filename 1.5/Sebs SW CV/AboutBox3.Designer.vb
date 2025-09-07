Namespace CV
	' Token: 0x0200001C RID: 28
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox3
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600021D RID: 541 RVA: 0x03D89F40 File Offset: 0x03D88340
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

		' Token: 0x0600021E RID: 542 RVA: 0x03D89F90 File Offset: 0x03D88390
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Button3 = New Global.System.Windows.Forms.Button()
			Me.Button4 = New Global.System.Windows.Forms.Button()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.Panel2 = New Global.System.Windows.Forms.Panel()
			Me.Panel1.SuspendLayout()
			Me.Panel2.SuspendLayout()
			Me.SuspendLayout()
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(53, 101)
			button.Location = point
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(75, 23)
			button2.Size = size
			Me.Button1.TabIndex = 0
			Me.Button1.Text = "OK"
			Me.Button1.UseVisualStyleBackColor = True
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 15.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(12, 24)
			label.Location = point
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(180, 25)
			label2.Size = size
			Me.Label1.TabIndex = 2
			Me.Label1.Text = "A Bug In Program"
			Me.Label1.Visible = False
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button3
			point = New Global.System.Drawing.Point(3, 1)
			button3.Location = point
			Me.Button3.Name = "Button3"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button3
			size = New Global.System.Drawing.Size(75, 26)
			button4.Size = size
			Me.Button3.TabIndex = 3
			Me.Button3.Text = "Open"
			Me.Button3.UseVisualStyleBackColor = True
			Dim button5 As Global.System.Windows.Forms.Control = Me.Button4
			point = New Global.System.Drawing.Point(3, 3)
			button5.Location = point
			Me.Button4.Name = "Button4"
			Dim button6 As Global.System.Windows.Forms.Control = Me.Button4
			size = New Global.System.Drawing.Size(75, 23)
			button6.Size = size
			Me.Button4.TabIndex = 4
			Me.Button4.Text = "Close"
			Me.Button4.UseVisualStyleBackColor = True
			Me.Panel1.BackColor = Global.System.Drawing.SystemColors.AppWorkspace
			Me.Panel1.Controls.Add(Me.Button3)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(12, 52)
			panel.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(81, 29)
			panel2.Size = size
			Me.Panel1.TabIndex = 5
			Me.Panel2.BackColor = Global.System.Drawing.SystemColors.AppWorkspace
			Me.Panel2.Controls.Add(Me.Button4)
			Dim panel3 As Global.System.Windows.Forms.Control = Me.Panel2
			point = New Global.System.Drawing.Point(99, 53)
			panel3.Location = point
			Me.Panel2.Name = "Panel2"
			Dim panel4 As Global.System.Windows.Forms.Control = Me.Panel2
			size = New Global.System.Drawing.Size(84, 29)
			panel4.Size = size
			Me.Panel2.TabIndex = 6
			Me.Panel2.Visible = False
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(199, 136)
			Me.ClientSize = size
			Me.Controls.Add(Me.Panel2)
			Me.Controls.Add(Me.Panel1)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.Button1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "AboutBox3"
			Dim padding As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(9)
			Me.Padding = padding
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Beta Program Error"
			Me.Panel1.ResumeLayout(False)
			Me.Panel2.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x040000E4 RID: 228
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
