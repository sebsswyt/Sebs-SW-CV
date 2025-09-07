Public Class startmenu_settings

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If CheckBox1.Checked = True Then
            'Form_1pad.
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox2.Checked = False Then
            If CheckBox3.Checked = False Then
                If CheckBox4.Checked = False Then
                    form1Pad.Label13.Text = "Update Now" & vbNewLine _
        & "for Newst "
                End If
            End If
        End If
    End Sub
End Class