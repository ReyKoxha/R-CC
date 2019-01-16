Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Public Class cConfig
    Private Declare Ansi Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    <DllImport("kernel32", EntryPoint:="GetPrivateProfileString")>
    Private Shared Function ReadINI(
        ByVal Sektion As String, ByVal Key As String, ByVal StandartVal As String,
        ByVal Result As StringBuilder, ByVal Size As Int32, ByVal Dateiname As String) As Int32
    End Function

    Public ConfigPath As String

    Public Sub New(_ConfigPath As String)
        ConfigPath = _ConfigPath
    End Sub

    Public Function exists()
        If File.Exists(ConfigPath) Then Return True
        Return False
    End Function

    Public Function createConfig()
        File.Create(ConfigPath)
        Return True
    End Function

    Public Function read(Sektion As String, Parameter As String)
        Dim sb As StringBuilder = New StringBuilder(1024)

        ReadINI(Sektion, Parameter, "", sb, sb.Capacity, ConfigPath)
        Return sb.ToString
    End Function

    Public Function write(Sektion As String, Parameter As String, ByVal Value As String) As Boolean
        WritePrivateProfileString(Sektion, Parameter, Value, ConfigPath)
        Return True
    End Function

End Class
