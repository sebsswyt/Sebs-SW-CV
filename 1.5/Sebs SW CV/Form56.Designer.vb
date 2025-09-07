Namespace CV
	' Token: 0x02000068 RID: 104
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form56
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600116A RID: 4458 RVA: 0x03DED284 File Offset: 0x03DEB684
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

		' Token: 0x0600116B RID: 4459 RVA: 0x03DED2D4 File Offset: 0x03DEB6D4
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.WebBrowser1 = New Global.System.Windows.Forms.WebBrowser()
			Me.SuspendLayout()
			Me.WebBrowser1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim webBrowser As Global.System.Windows.Forms.Control = Me.WebBrowser1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			webBrowser.Location = point
			Dim webBrowser2 As Global.System.Windows.Forms.Control = Me.WebBrowser1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(20, 20)
			webBrowser2.MinimumSize = size
			Me.WebBrowser1.Name = "WebBrowser1"
			Dim webBrowser3 As Global.System.Windows.Forms.Control = Me.WebBrowser1
			size = New Global.System.Drawing.Size(1147, 683)
			webBrowser3.Size = size
			Me.WebBrowser1.TabIndex = 0
			Me.WebBrowser1.Url = New Global.System.Uri("https://www.google.com", Global.System.UriKind.Absolute)
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(1147, 683)
			Me.ClientSize = size
			Me.Controls.Add(Me.WebBrowser1)
			Me.Name = "Form56"
			Me.Text = "Web"
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x04000677 RID: 1655
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
