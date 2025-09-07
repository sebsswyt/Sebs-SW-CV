Namespace CV
	' Token: 0x02000014 RID: 20
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox19
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060001A3 RID: 419 RVA: 0x03D86894 File Offset: 0x03D84C94
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

		' Token: 0x060001A4 RID: 420 RVA: 0x03D868E4 File Offset: 0x03D84CE4
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.AboutBox19))
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.SuspendLayout()
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Trebuchet MS", 14.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(12, 9)
			label.Location = point
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(93, 120)
			label2.Size = size
			Me.Label1.TabIndex = 0
			Me.Label1.Text = "Add:" & vbCrLf & vbCrLf & "Updated:" & vbCrLf & vbCrLf & "Removed:"
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(443, 294)
			Me.ClientSize = size
			Me.Controls.Add(Me.Label1)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "AboutBox19"
			Dim padding As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(9)
			Me.Padding = padding
			Me.ShowInTaskbar = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "New Updates"
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x040000B3 RID: 179
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
