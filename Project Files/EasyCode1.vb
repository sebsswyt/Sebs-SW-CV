Public Class EasyCode1

    Public currentForm As Form = Nothing
    Public Sub openChildForm(ByVal childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        'Form21.CVCforms.Controls.Add(childForm)
        'Form21.CVCforms.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        'childForm()

    End Sub

    Public Sub segfd()
        form1Pad.Show()
    End Sub

End Class
