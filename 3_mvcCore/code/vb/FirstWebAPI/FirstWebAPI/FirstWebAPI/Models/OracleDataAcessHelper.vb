Imports Oracle.ManagedDataAccess.Client
Public Class OracleDataAcessHelper
    Public Shared Function GetConnection() As OracleConnection
        Dim connection As New OracleConnection
        connection.ConnectionString =
            "Data Source = localhost:1521/XE; User Id = system; password = 0000"
        connection.Open()
        Return connection
    End Function

End Class
