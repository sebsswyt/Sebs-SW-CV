Namespace CV
	' Token: 0x02000044 RID: 68
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form23
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000AF1 RID: 2801 RVA: 0x03DC1620 File Offset: 0x03DBFA20
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

		' Token: 0x06000AF2 RID: 2802 RVA: 0x03DC1670 File Offset: 0x03DBFA70
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.Form23))
			Me.Button11 = New Global.System.Windows.Forms.Button()
			Me.Button8 = New Global.System.Windows.Forms.Button()
			Me.SuspendLayout()
			Me.Button11.BackColor = Global.System.Drawing.SystemColors.Control
			Me.Button11.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button11.Image = CType(componentResourceManager.GetObject("Button11.Image"), Global.System.Drawing.Image)
			Dim button As Global.System.Windows.Forms.Control = Me.Button11
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(12, -1)
			button.Location = point
			Me.Button11.Name = "Button11"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button11
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(75, 48)
			button2.Size = size
			Me.Button11.TabIndex = 26
			Me.Button11.UseVisualStyleBackColor = False
			Me.Button8.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button8.Image = CType(componentResourceManager.GetObject("Button8.Image"), Global.System.Drawing.Image)
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button8
			point = New Global.System.Drawing.Point(12, 9)
			button3.Location = point
			Me.Button8.Name = "Button8"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button8
			size = New Global.System.Drawing.Size(51, 38)
			button4.Size = size
			Me.Button8.TabIndex = 25
			Me.Button8.UseVisualStyleBackColor = True
			Me.Button8.Visible = False
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(721, 472)
			Me.ClientSize = size
			Me.Controls.Add(Me.Button11)
			Me.Controls.Add(Me.Button8)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.Name = "Form23"
			Me.Text = "Desktop"
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x04000406 RID: 1030
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
