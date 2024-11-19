Imports Microsoft.Web.WebView2.Core

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebView21.Source = New Uri("http://www.fithou.edu.vn/")
    End Sub

    ''' <summary>
    ''' ConnectionString (Lần thứ 4)
    ''' </summary>
    ''' <returns></returns>
    Private Sub WebView21_NavigationStarting(sender As Object, e As CoreWebView2NavigationStartingEventArgs) Handles WebView21.NavigationStarting
        MessageBox.Show("Đang tải trang: " & e.Uri)
    End Sub

End Class


