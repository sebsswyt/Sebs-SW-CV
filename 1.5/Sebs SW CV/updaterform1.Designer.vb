Namespace CV
	' Token: 0x02000078 RID: 120
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class updaterform1
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060012DB RID: 4827 RVA: 0x03DF7500 File Offset: 0x03DF5900
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

		' Token: 0x060012DC RID: 4828 RVA: 0x03DF7550 File Offset: 0x03DF5950
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.CV.updaterform1))
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.ProgressBar2 = New Global.System.Windows.Forms.ProgressBar()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.SuspendLayout()
			Dim progressBar As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(182, 174)
			progressBar.Location = point
			Me.ProgressBar1.Name = "ProgressBar1"
			Dim progressBar2 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(471, 38)
			progressBar2.Size = size
			Me.ProgressBar1.TabIndex = 0
			Dim progressBar3 As Global.System.Windows.Forms.Control = Me.ProgressBar2
			point = New Global.System.Drawing.Point(182, 245)
			progressBar3.Location = point
			Me.ProgressBar2.Name = "ProgressBar2"
			Dim progressBar4 As Global.System.Windows.Forms.Control = Me.ProgressBar2
			size = New Global.System.Drawing.Size(471, 23)
			progressBar4.Size = size
			Me.ProgressBar2.TabIndex = 1
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 15.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(348, 146)
			label.Location = point
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(136, 25)
			label2.Size = size
			Me.Label1.TabIndex = 2
			Me.Label1.Text = "Downloading"
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 15.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
			point = New Global.System.Drawing.Point(365, 217)
			label3.Location = point
			Me.Label2.Name = "Label2"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(97, 25)
			label4.Size = size
			Me.Label2.TabIndex = 3
			Me.Label2.Text = "Installing"
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(889, 442)
			Me.ClientSize = size
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.ProgressBar2)
			Me.Controls.Add(Me.ProgressBar1)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.Name = "updaterform1"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Update SCSW 1.1"
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x04000714 RID: 1812
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
