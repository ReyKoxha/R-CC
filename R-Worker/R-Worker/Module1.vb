Imports R_Worker.cUsefulFuncs
Imports R_Worker.cSDK
Module Module1

    Public CheckStatus_thread As Threading.Thread = New Threading.Thread(AddressOf CheckStatus)

    Sub Main()
        Console.Title = "R-Cluster Worker"
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine("")
        Console.WriteLine("          _____          ")
        Console.WriteLine("         /\    \         ")
        Console.WriteLine("        /::\    \        ")
        Console.WriteLine("       /::::\    \       ")
        Console.WriteLine("      /::::::\    \      ")
        Console.WriteLine("     /:::/\:::\    \     ")
        Console.WriteLine("    /:::/__\:::\    \    ")
        Console.WriteLine("   /::::\   \:::\    \   ")
        Console.WriteLine("  /::::::\   \:::\    \  ")
        Console.WriteLine(" /:::/\:::\   \:::\____\ ")
        Console.WriteLine("/:::/  \:::\   \:::|    |")
        Console.WriteLine("\::/   |::::\  /:::|____|")
        Console.WriteLine(" \/____|:::::\/:::/    / ")
        Console.WriteLine("       |:::::::::/    /  ")
        Console.WriteLine("       |::|\::::/    /   ")
        Console.WriteLine("       |::| \::/____/    ")
        Console.WriteLine("       |::|  ~|          ")
        Console.WriteLine("       |::|   |          ")
        Console.WriteLine("       \::|   |          ")
        Console.WriteLine("        \:|   |          ")
        Console.WriteLine("         \|___|          ")
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("================================================================================")
        Console.WriteLine("")

        If Not cfg.exists Then
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("You forgot the clustercon.ini!")
            Settings.Save()
            Console.WriteLine("Created clustercon.ini for you. Please adjust.")
            Console.WriteLine("Exiting in 3 seconds.")
            sleep(3000)
            Environment.Exit(0)
        End If

        Settings.Load()

        Console.Beep()

        CheckStatus_thread.Start()

    End Sub

    Sub CheckStatus()
        While True

            Dim p() As Process

            p = Process.GetProcessesByName("Rscript")
            If p.Count < Settings.Cores Then
                StartWorkers()
            End If

            sleep(1000)
        End While
    End Sub

    Function StartWorkers()
        sleep(15000)
        For i As Integer = 1 To Settings.Cores
            Dim rCluster As New ProcessStartInfo
            rCluster.FileName = "Rscript"
            rCluster.Arguments = "worker.R" & " -m " & Settings.RedisIP & " -p " & Settings.RedisPort & " -w " & Settings.RedisPassword & " -l worker.log"
            rCluster.UseShellExecute = True
            rCluster.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(rCluster)
        Next
    End Function

End Module
