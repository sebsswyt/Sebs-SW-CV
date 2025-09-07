Namespace CV
	' Token: 0x02000079 RID: 121
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public NotInheritable Partial Class WASD
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060012EB RID: 4843 RVA: 0x03DF7AFC File Offset: 0x03DF5EFC
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

		' Token: 0x060012EC RID: 4844 RVA: 0x03DF7B4C File Offset: 0x03DF5F4C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.SuspendLayout()
			Dim textBox As Global.System.Windows.Forms.Control = Me.TextBox1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(12, 12)
			textBox.Location = point
			Me.TextBox1.Name = "TextBox1"
			Dim textBox2 As Global.System.Windows.Forms.Control = Me.TextBox1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(390, 20)
			textBox2.Size = size
			Me.TextBox1.TabIndex = 0
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(414, 276)
			Me.ClientSize = size
			Me.Controls.Add(Me.TextBox1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "WASD"
			Dim padding As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(9)
			Me.Padding = padding
			Me.ShowInTaskbar = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "WASD"
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x0400071B RID: 1819
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
