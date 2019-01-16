Imports System.Runtime.InteropServices

Public Class cUsefulFuncs

    <DllImport("user32.dll")>
    Shared Function GetAsyncKeyState(ByVal vKey As Integer) As Short
    End Function

    Public Shared Sub sleep(amount As Integer)
        Threading.Thread.Sleep(amount)
    End Sub
    Public Shared Sub wl(text As String)
        Console.WriteLine(text)
    End Sub

End Class
