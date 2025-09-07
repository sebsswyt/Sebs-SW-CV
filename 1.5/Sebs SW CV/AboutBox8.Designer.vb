Namespace CV
	' Token: 0x02000021 RID: 33
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox8
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600028A RID: 650 RVA: 0x03D8CFC0 File Offset: 0x03D8B3C0
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

		' Token: 0x0600028B RID: 651 RVA: 0x03D8D010 File Offset: 0x03D8B410
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.AboutBox8))
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.SuspendLayout()
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(12, 9)
			label.Location = point
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(0, 18)
			label2.Size = size
			Me.Label1.TabIndex = 0
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			point = New Global.System.Drawing.Point(63, 81)
			button.Location = point
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(75, 23)
			button2.Size = size
			Me.Button1.TabIndex = 1
			Me.Button1.Text = "OK"
			Me.Button1.UseVisualStyleBackColor = True
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(208, 116)
			Me.ClientSize = size
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.Label1)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "AboutBox8"
			Dim padding As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(9)
			Me.Padding = padding
			Me.ShowInTaskbar = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Error"
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x0400010C RID: 268
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
