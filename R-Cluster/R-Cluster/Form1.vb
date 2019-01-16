Imports System.IO

Public Class Form1
    ' Form Load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadValues()
    End Sub

    Function LoadValues()
        RedisHost.Text = My.Settings.RedisHostname
        RedisPort.Text = My.Settings.RedisPort
        RedisPass.Text = My.Settings.RedisPassword

        FileInput.Text = My.Settings.IOFile
        FileOutput.Text = My.Settings.OOFile
        WorkerScript.Text = My.Settings.WorkerFile
        MainScript.Text = My.Settings.MainFile
        QueueName.Text = My.Settings.JobName
        ChunkSize.Text = My.Settings.ChunkSize

        RunTime.Checked = My.Settings.Runtime
    End Function

    ' TAB 1
    ' Button Actions
    Private Sub IOFileButton_Click(sender As Object, e As EventArgs) Handles IOFileButton.Click
        If (IOFileDialog.ShowDialog() = DialogResult.OK) Then
            FileInput.Text = IOFileDialog.FileName
        End If
    End Sub

    Private Sub OOFileButton_Click(sender As Object, e As EventArgs) Handles OOFileButton.Click
        If (OOFileDialog.ShowDialog() = DialogResult.OK) Then
            FileOutput.Text = OOFileDialog.FileName
        End If
    End Sub

    Private Sub WorkerButton_Click(sender As Object, e As EventArgs) Handles WorkerButton.Click
        If (WorkerDialog.ShowDialog() = DialogResult.OK) Then
            WorkerScript.Text = WorkerDialog.FileName
        End If
    End Sub

    Private Sub MainButton_Click(sender As Object, e As EventArgs) Handles MainButton.Click
        If (MainScriptDialog.ShowDialog() = DialogResult.OK) Then
            MainScript.Text = MainScriptDialog.FileName
        End If
    End Sub

    Private Sub ImportSettings_Click(sender As Object, e As EventArgs) Handles ImportSettings.Click
        Dim oDialog As New OpenFileDialog
        Dim Divider As String = "="
        oDialog.Filter = "R-Cluster Settings (*.rcluster)|*rcluster"

        If oDialog.ShowDialog() = DialogResult.OK Then

            Using sReader As New StreamReader(oDialog.FileName)
                While sReader.Peek() > 0
                    Dim Input = sReader.ReadLine()
                    Dim DataSplit = Input.Split(CChar(Divider))
                    Select Case DataSplit(0)
                        Case "System.Boolean"
                            My.Settings(DataSplit(1)) = CBool(DataSplit(2))
                        Case "System.String"
                            My.Settings(DataSplit(1)) = DataSplit(2)
                        Case "System.Int32"
                            My.Settings(DataSplit(1)) = CInt(DataSplit(2))
                        Case "System.Double"
                            My.Settings(DataSplit(1)) = CDbl(DataSplit(2))
                    End Select
                End While
            End Using

            My.Settings.Save()
        End If
    End Sub

    Private Sub ExportSettings_Click(sender As Object, e As EventArgs) Handles ExportSettings.Click
        Dim sDialog As New SaveFileDialog()
        Dim Divider As String = "="
        sDialog.DefaultExt = ".rcluster"
        sDialog.Filter = "R-Cluster Settings (*.rcluster)|*rcluster"

        If sDialog.ShowDialog() = DialogResult.OK Then
            Using sWriter As New StreamWriter(sDialog.FileName)
                For Each Setting As System.Configuration.SettingsPropertyValue In My.Settings.PropertyValues
                    sWriter.WriteLine(Setting.Property.PropertyType.ToString & Divider & Setting.Name & Divider & Setting.SerializedValue)
                Next
            End Using
        End If
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        Dim rmaster As New ProcessStartInfo
        rmaster.FileName = "Rscript"
        If RunTime.Checked = True Then
            rmaster.Arguments = "master.R -m " & RedisHost.Text & " -p " & RedisPort.Text & " -w " & RedisPass.Text & " -c " & ChunkSize.Text & " -f " & FileInput.Text & " -i " & WorkerScript.Text & " -o " & FileOutput.Text & " -q " & QueueName.Text & " -s " & MainScript.Text & " -t TRUE" & "&pause"
        Else
            rmaster.Arguments = "master.R -m " & RedisHost.Text & " -p " & RedisPort.Text & " -w  " & RedisPass.Text & " -c " & ChunkSize.Text & " -f " & FileInput.Text & " -i " & WorkerScript.Text & " -o " & FileOutput.Text & " -q " & QueueName.Text & " -s " & MainScript.Text & "&pause"
        End If
        rmaster.UseShellExecute = True
        rmaster.WindowStyle = ProcessWindowStyle.Normal
        Dim proc As Process = Process.Start(rmaster)
    End Sub

    ' TextChanged
    ' REDIS
    Private Sub RedisHost_TextChanged(sender As Object, e As EventArgs) Handles RedisHost.TextChanged
        My.Settings.RedisHostname = RedisHost.Text
        My.Settings.Save()
    End Sub

    Private Sub RedisPort_TextChanged(sender As Object, e As EventArgs) Handles RedisPort.TextChanged
        My.Settings.RedisPort = RedisPort.Text
        My.Settings.Save()
    End Sub

    Private Sub RedisPass_TextChanged(sender As Object, e As EventArgs) Handles RedisPass.TextChanged
        My.Settings.RedisPassword = RedisPass.Text
        My.Settings.Save()
    End Sub

    ' GENERAL
    Private Sub FileInput_TextChanged(sender As Object, e As EventArgs) Handles FileInput.TextChanged
        My.Settings.IOFile = FileInput.Text
        My.Settings.Save()
    End Sub

    Private Sub FileOutput_TextChanged(sender As Object, e As EventArgs) Handles FileOutput.TextChanged
        My.Settings.OOFile = FileOutput.Text
        My.Settings.Save()
    End Sub
    Private Sub WorkerScript_TextChanged(sender As Object, e As EventArgs) Handles WorkerScript.TextChanged
        My.Settings.WorkerFile = WorkerScript.Text
        My.Settings.Save()
    End Sub
    Private Sub QueueName_TextChanged(sender As Object, e As EventArgs) Handles QueueName.TextChanged
        My.Settings.JobName = QueueName.Text
        My.Settings.Save()
    End Sub
    Private Sub MainScript_TextChanged(sender As Object, e As EventArgs) Handles MainScript.TextChanged
        My.Settings.MainFile = MainScript.Text
        My.Settings.Save()
    End Sub
    Private Sub ChunkSize_TextChanged(sender As Object, e As EventArgs) Handles ChunkSize.TextChanged
        My.Settings.ChunkSize = ChunkSize.Text
        My.Settings.Save()
    End Sub
    Private Sub RunTime_CheckedChanged(sender As Object, e As EventArgs) Handles RunTime.CheckedChanged
        My.Settings.Runtime = RunTime.Checked
        My.Settings.Save()
    End Sub

    ' TAB 2
    Private Sub NumOfCores_ValueChanged(sender As Object, e As EventArgs) Handles NumOfCores.ValueChanged
        My.Settings.NumOfCores = NumOfCores.Value
        My.Settings.Save()
    End Sub

    Private Sub ConfigGen_Click(sender As Object, e As EventArgs) Handles ConfigGen.Click
        Dim rworker As New System.Text.StringBuilder

        rworker.AppendLine("[clustercon]")
        rworker.AppendLine("RedisIP=" & RedisHost.Text)
        rworker.AppendLine("RedisPort=" & RedisPort.Text)
        rworker.AppendLine("RedisPassword=" & RedisPass.Text)
        rworker.AppendLine("Cores=" & NumOfCores.Value)

        IO.File.WriteAllText("clustercon.ini", rworker.ToString())

    End Sub
End Class
