Public Class UI
    Public Shared Function GetInternalWebpage(WebAppName As String, PageName As String) As String
        Dim WebAppFolder As String = My.Application.Info.DirectoryPath & "\WebApps"
        Dim WebApp As String = WebAppFolder & "\" & WebAppName & "\" & PageName
    End Function

    Public Shared Function GetInternalWebpageWebview2(WebAppName As String, PageName As String, Webview2 As Microsoft.Web.WebView2.WinForms.WebView2) As Boolean
        Dim WebAppFolder As String = My.Application.Info.DirectoryPath & "\WebApps"
        Dim WebApp As String = WebAppFolder & "\" & WebAppName & "\" & PageName
        Dim BooleanThing As Boolean = False
        If My.Computer.FileSystem.FileExists(WebApp) Then
            BooleanThing = True
        Else
            BooleanThing = False
        End If
        WebApp = WebApp.Replace("\", "/")
        Webview2.Source = New Uri("file:///" & WebApp)
        'My.Computer.Clipboard.SetText("file:///" & WebApp)
        Return BooleanThing
    End Function
End Class
