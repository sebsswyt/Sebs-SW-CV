Namespace CV
	' Token: 0x02000015 RID: 21
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public NotInheritable Partial Class Errorbox1
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060001AB RID: 427 RVA: 0x03D86B14 File Offset: 0x03D84F14
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

		' Token: 0x060001AC RID: 428 RVA: 0x03D86B64 File Offset: 0x03D84F64
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.OKButton = New Global.System.Windows.Forms.Button()
			Me.al = New Global.System.Windows.Forms.Label()
			Me.SuspendLayout()
			Me.OKButton.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.OKButton.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			Dim okbutton As Global.System.Windows.Forms.Control = Me.OKButton
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(211, 210)
			okbutton.Location = point
			Me.OKButton.Name = "OKButton"
			Dim okbutton2 As Global.System.Windows.Forms.Control = Me.OKButton
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(75, 23)
			okbutton2.Size = size
			Me.OKButton.TabIndex = 0
			Me.OKButton.Text = "&OK"
			Me.al.AutoSize = True
			Me.al.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 15.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim al As Global.System.Windows.Forms.Control = Me.al
			point = New Global.System.Drawing.Point(56, 9)
			al.Location = point
			Me.al.Name = "al"
			Dim al2 As Global.System.Windows.Forms.Control = Me.al
			size = New Global.System.Drawing.Size(192, 75)
			al2.Size = size
			Me.al.TabIndex = 1
			Me.al.Text = "Error no root folder" & vbCrLf & "in V 1.2" & vbCrLf & " and 1.3"
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me.OKButton
			size = New Global.System.Drawing.Size(508, 245)
			Me.ClientSize = size
			Me.Controls.Add(Me.al)
			Me.Controls.Add(Me.OKButton)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Errorbox1"
			Dim padding As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(9)
			Me.Padding = padding
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Error"
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x040000B6 RID: 182
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
