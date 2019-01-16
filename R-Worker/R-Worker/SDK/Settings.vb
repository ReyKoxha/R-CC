Imports R_Worker.cSDK
Public Class cSettings

    '<<< CONFIG >>>'
    Public RedisIP As String = "127.0.0.1"
    Public RedisPort As Integer = 6379
    Public RedisPassword As String = ""
    Public Cores As Integer = 4


    Public Function Load()
        Try
            '<<< CONFIG >>>'
            RedisIP = cfg.read("clustercon", "RedisIP")
            RedisPort = cfg.read("clustercon", "RedisPort")
            RedisPassword = cfg.read("clustercon", "RedisPassword")
            Cores = cfg.read("clustercon", "Cores")

        Catch ex As Exception
            cUsefulFuncs.wl(ex.ToString)
        End Try
    End Function

    Public Function Save()
        '<<< CONFIG >>>'
        cfg.write("clustercon", "RedisIP", RedisIP)
        cfg.write("clustercon", "RedisPort", RedisPort)
        cfg.write("clustercon", "RedisPassword", RedisPassword)
        cfg.write("clustercon", "Cores", Cores)
    End Function
End Class
