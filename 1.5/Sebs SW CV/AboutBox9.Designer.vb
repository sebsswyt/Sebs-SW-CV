Namespace CV
	' Token: 0x02000022 RID: 34
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public NotInheritable Partial Class AboutBox9
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000295 RID: 661 RVA: 0x03D8D330 File Offset: 0x03D8B730
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

		' Token: 0x06000296 RID: 662 RVA: 0x03D8D380 File Offset: 0x03D8B780
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.SuspendLayout()
			Dim progressBar As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(42, 117)
			progressBar.Location = point
			Me.ProgressBar1.Name = "ProgressBar1"
			Dim progressBar2 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(312, 23)
			progressBar2.Size = size
			Me.ProgressBar1.TabIndex = 1
			Me.Button1.Enabled = False
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			point = New Global.System.Drawing.Point(158, 146)
			button.Location = point
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(75, 23)
			button2.Size = size
			Me.Button1.TabIndex = 2
			Me.Button1.Text = "Button2"
			Me.Button1.UseVisualStyleBackColor = True
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(414, 276)
			Me.ClientSize = size
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.ProgressBar1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "AboutBox9"
			Dim padding As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(9)
			Me.Padding = padding
			Me.ShowInTaskbar = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "AboutBox9"
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x04000110 RID: 272
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
