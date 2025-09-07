Imports System.Reflection
Public Class DebuggerForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFormByName("CV." & TextBox1.Text)
    End Sub


    Public Sub OpenFormByName(formName As String)
        ' Get the current assembly
        Dim asm As Assembly = Assembly.GetExecutingAssembly()

        ' Get the type from the assembly by name
        Dim formType As Type = asm.GetType(formName)

        ' Check if the type exists and is a Form
        If formType IsNot Nothing AndAlso formType.IsSubclassOf(GetType(Form)) Then
            ' Create an instance of the form dynamically
            Dim formInstance As Form = CType(Activator.CreateInstance(formType), Form)
            Try
                formInstance.Show()
            Catch ex As Exception

            End Try
        Else
            MsgBox("Form '" & formName & "' not found or is not a valid Form.")
        End If
    End Sub

    Public Function GetForm(formName As String) As Object
        ' Get the current assembly
        Dim asm As Assembly = Assembly.GetExecutingAssembly()

        ' Get the type from the assembly by name
        Dim formType As Type = asm.GetType(formName)

        ' Check if the type exists and is a Form
        If formType IsNot Nothing AndAlso formType.IsSubclassOf(GetType(Form)) Then
            ' Create an instance of the form dynamically
            Dim formInstance As Form = CType(Activator.CreateInstance(formType), Form)
            'formInstance.Show()
            Return formInstance
        Else
            MsgBox("Form '" & formName & "' not found or is not a valid Form.")
            Return Nothing
        End If
    End Function
End Class