Imports System
Imports System.Windows.Forms
Imports CV.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace CV
	' Token: 0x0200002E RID: 46
	Friend NotInheritable Module easycode
		' Token: 0x06000356 RID: 854 RVA: 0x03D7EBAC File Offset: 0x03D7CFAC
		Public Sub openChildForm(childForm As Form)
			Dim flag As Boolean = easycode.currentForm IsNot Nothing
			If flag Then
				easycode.currentForm.Close()
			End If
			easycode.currentForm = childForm
			childForm.TopLevel = False
			childForm.FormBorderStyle = FormBorderStyle.None
			childForm.Dock = DockStyle.Fill
			MyProject.Forms.Form21.CVCforms.Controls.Add(childForm)
			MyProject.Forms.Form21.CVCforms.Tag = childForm
			childForm.BringToFront()
			childForm.Show()
		End Sub

		' Token: 0x06000357 RID: 855 RVA: 0x03D7EC34 File Offset: 0x03D7D034
		Public Sub Start_up_load()
			Dim flag As Boolean = Operators.CompareString(MyProject.Forms.Form49.Label2.Text, "B2", False) = 0
			If Not flag Then
				flag = Operators.CompareString(MyProject.Forms.Form49.Label2.Text, "B3", False) = 0
				If Not flag Then
					flag = Operators.CompareString(MyProject.Forms.Form49.Label2.Text, "B4", False) = 0
					If Not flag Then
						flag = Operators.CompareString(MyProject.Forms.Form49.Label2.Text, "B5", False) = 0
						If Not flag Then
							flag = Operators.CompareString(MyProject.Forms.Form49.Label2.Text, "B6", False) = 0
							If Not flag Then
								flag = Operators.CompareString(MyProject.Forms.Form49.Label2.Text, "B7", False) = 0
								If flag Then
								End If
							End If
						End If
					End If
				End If
			End If
			MyProject.Forms.form1Pad.Picture1.Image = MyProject.Forms.Form49.PictureBox1.Image
			MyProject.Forms.form1Pad.Picture1.Image = MyProject.Forms.Form49.PictureBox1.Image
			MyProject.Forms.AboutBox22.Close()
		End Sub

		' Token: 0x04000149 RID: 329
		Public currentForm As Form = Nothing
	End Module
End Namespace
