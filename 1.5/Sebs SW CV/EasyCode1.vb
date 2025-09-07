Imports System
Imports System.Windows.Forms
Imports CV.My

Namespace CV
	' Token: 0x0200002F RID: 47
	Public Class EasyCode1
		' Token: 0x06000358 RID: 856 RVA: 0x03D7EDA4 File Offset: 0x03D7D1A4
		Public Sub New()
			Me.currentForm = Nothing
		End Sub

		' Token: 0x06000359 RID: 857 RVA: 0x03D7EDB8 File Offset: 0x03D7D1B8
		Public Sub openChildForm(childForm As Form)
			Dim flag As Boolean = Me.currentForm IsNot Nothing
			If flag Then
				Me.currentForm.Close()
			End If
			Me.currentForm = childForm
			childForm.TopLevel = False
			childForm.FormBorderStyle = FormBorderStyle.None
			childForm.Dock = DockStyle.Fill
			MyProject.Forms.Form21.CVCforms.Controls.Add(childForm)
			MyProject.Forms.Form21.CVCforms.Tag = childForm
			childForm.BringToFront()
			childForm.Show()
		End Sub

		' Token: 0x0600035A RID: 858 RVA: 0x03D7EE44 File Offset: 0x03D7D244
		Public Sub segfd()
			MyProject.Forms.form1Pad.Show()
		End Sub

		' Token: 0x0400014A RID: 330
		Public currentForm As Form
	End Class
End Namespace
