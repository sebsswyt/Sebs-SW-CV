Namespace CV
	' Token: 0x0200005E RID: 94
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form47
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06001030 RID: 4144 RVA: 0x03DE4F68 File Offset: 0x03DE3368
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

		' Token: 0x06001031 RID: 4145 RVA: 0x03DE4FB8 File Offset: 0x03DE33B8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.Panel1.SuspendLayout()
			Me.SuspendLayout()
			Me.Timer1.Enabled = True
			Me.ProgressBar1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim progressBar As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 12)
			progressBar.Location = point
			Me.ProgressBar1.Name = "ProgressBar1"
			Dim progressBar2 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(919, 33)
			progressBar2.Size = size
			Me.ProgressBar1.TabIndex = 0
			Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label1.AutoSize = True
			Me.Label1.BackColor = Global.System.Drawing.Color.Black
			Me.Label1.Font = New Global.System.Drawing.Font("Trebuchet MS", 27.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Global.System.Drawing.Color.White
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(298, 157)
			label.Location = point
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(221, 92)
			label2.Size = size
			Me.Label1.TabIndex = 1
			Me.Label1.Text = "Sebs Web" & vbCrLf & "Sebs SW CV "
			Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Panel1.BackColor = Global.System.Drawing.Color.DimGray
			Me.Panel1.Controls.Add(Me.ProgressBar1)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(1, 0)
			panel.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(922, 59)
			panel2.Size = size
			Me.Panel1.TabIndex = 2
			Me.Label2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label2.AutoSize = True
			Me.Label2.BackColor = Global.System.Drawing.Color.Black
			Me.Label2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 27.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.ForeColor = Global.System.Drawing.Color.White
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
			point = New Global.System.Drawing.Point(298, 369)
			label3.Location = point
			Me.Label2.Name = "Label2"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(54, 42)
			label4.Size = size
			Me.Label2.TabIndex = 3
			Me.Label2.Text = "---"
			Me.Label2.Visible = False
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(924, 607)
			Me.ClientSize = size
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.Panel1)
			Me.Controls.Add(Me.Label1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			Me.Name = "Form47"
			Me.Text = "Form47"
			Me.WindowState = Global.System.Windows.Forms.FormWindowState.Maximized
			Me.Panel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x040005FB RID: 1531
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
