Public Class DatabaseHelper
    Public Shared ReadOnly Property ConnectionString As String
        Get
            Return "Data Source=DESKTOP-GOAKFLS\SQLEXPRESS;Initial Catalog=GoldenJobDB;Integrated Security=True; TrustServerCertificate=True"
        End Get
    End Property
End Class

