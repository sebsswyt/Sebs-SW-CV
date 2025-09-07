Namespace CV
	' Token: 0x0200000B RID: 11
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public NotInheritable Partial Class Restartform
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000108 RID: 264 RVA: 0x03D82AD4 File Offset: 0x03D80ED4
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

		' Token: 0x06000109 RID: 265 RVA: 0x03D82B24 File Offset: 0x03D80F24
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.PictureBox1.BackColor = Global.System.Drawing.SystemColors.Highlight
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(12, 12)
			pictureBox.Location = point
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(19, 252)
			pictureBox2.Size = size
			Me.PictureBox1.TabIndex = 0
			Me.PictureBox1.TabStop = False
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.SystemColors.HotTrack
			size = New Global.System.Drawing.Size(414, 276)
			Me.ClientSize = size
			Me.Controls.Add(Me.PictureBox1)
			Me.Cursor = Global.System.Windows.Forms.Cursors.AppStarting
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Restartform"
			Dim padding As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(9)
			Me.Padding = padding
			Me.ShowInTaskbar = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Restart"
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x04000076 RID: 118
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
