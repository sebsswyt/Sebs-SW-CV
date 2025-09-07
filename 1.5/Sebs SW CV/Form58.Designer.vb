Namespace CV
	' Token: 0x0200006A RID: 106
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form58
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06001188 RID: 4488 RVA: 0x03DEE3D0 File Offset: 0x03DEC7D0
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

		' Token: 0x06001189 RID: 4489 RVA: 0x03DEE420 File Offset: 0x03DEC820
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.Form58))
			Me.AxWindowsMediaPlayer1 = New Global.AxWMPLib.AxWindowsMediaPlayer()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.AxWindowsMediaPlayer1.BeginInit()
			Me.SuspendLayout()
			Me.AxWindowsMediaPlayer1.Enabled = True
			Dim axWindowsMediaPlayer As Global.System.Windows.Forms.Control = Me.AxWindowsMediaPlayer1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(12, 61)
			axWindowsMediaPlayer.Location = point
			Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
			Me.AxWindowsMediaPlayer1.OcxState = CType(componentResourceManager.GetObject("AxWindowsMediaPlayer1.OcxState"), Global.System.Windows.Forms.AxHost.State)
			Dim axWindowsMediaPlayer2 As Global.System.Windows.Forms.Control = Me.AxWindowsMediaPlayer1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(895, 299)
			axWindowsMediaPlayer2.Size = size
			Me.AxWindowsMediaPlayer1.TabIndex = 0
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(12, 160)
			panel.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(895, 254)
			panel2.Size = size
			Me.Panel1.TabIndex = 1
			Dim progressBar As Global.System.Windows.Forms.Control = Me.ProgressBar1
			point = New Global.System.Drawing.Point(12, 461)
			progressBar.Location = point
			Me.ProgressBar1.Name = "ProgressBar1"
			Dim progressBar2 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			size = New Global.System.Drawing.Size(964, 23)
			progressBar2.Size = size
			Me.ProgressBar1.TabIndex = 2
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(988, 496)
			Me.ClientSize = size
			Me.Controls.Add(Me.ProgressBar1)
			Me.Controls.Add(Me.Panel1)
			Me.Controls.Add(Me.AxWindowsMediaPlayer1)
			Me.Name = "Form58"
			Me.Text = "Form58"
			Me.AxWindowsMediaPlayer1.EndInit()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x04000684 RID: 1668
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
