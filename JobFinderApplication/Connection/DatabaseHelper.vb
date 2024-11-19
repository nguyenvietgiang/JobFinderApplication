Public Class DatabaseHelper
    ''' <summary>
    ''' ConnectionString (Lần thứ 1)
    ''' </summary>
    ''' <returns></returns>
    Public Shared ReadOnly Property ConnectionString As String
        Get
            Return "Data Source=DESKTOP-GOAKFLS\SQLEXPRESS;Initial Catalog=GoldenJobDB;Integrated Security=True; TrustServerCertificate=True"
        End Get
    End Property
End Class

