<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RedisHost = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RedisPort = New System.Windows.Forms.TextBox()
        Me.RedisPass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RunTime = New System.Windows.Forms.CheckBox()
        Me.FileInput = New System.Windows.Forms.TextBox()
        Me.FileOutput = New System.Windows.Forms.TextBox()
        Me.WorkerScript = New System.Windows.Forms.TextBox()
        Me.QueueName = New System.Windows.Forms.TextBox()
        Me.MainScript = New System.Windows.Forms.TextBox()
        Me.Start = New System.Windows.Forms.Button()
        Me.IOFileButton = New System.Windows.Forms.Button()
        Me.OOFileButton = New System.Windows.Forms.Button()
        Me.WorkerButton = New System.Windows.Forms.Button()
        Me.MainButton = New System.Windows.Forms.Button()
        Me.IOFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.WorkerDialog = New System.Windows.Forms.OpenFileDialog()
        Me.MainScriptDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ExportSettings = New System.Windows.Forms.Button()
        Me.ImportSettings = New System.Windows.Forms.Button()
        Me.OOFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ChunkSize = New System.Windows.Forms.TextBox()
        Me.GUIControll = New System.Windows.Forms.TabControl()
        Me.MasterTab = New System.Windows.Forms.TabPage()
        Me.WorkerTab = New System.Windows.Forms.TabPage()
        Me.ConfigGen = New System.Windows.Forms.Button()
        Me.NumOfCores = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GUIControll.SuspendLayout()
        Me.MasterTab.SuspendLayout()
        Me.WorkerTab.SuspendLayout()
        CType(Me.NumOfCores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Redis Setup"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hostname/IP"
        '
        'RedisHost
        '
        Me.RedisHost.Location = New System.Drawing.Point(7, 52)
        Me.RedisHost.Name = "RedisHost"
        Me.RedisHost.Size = New System.Drawing.Size(100, 20)
        Me.RedisHost.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(110, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Port"
        '
        'RedisPort
        '
        Me.RedisPort.Location = New System.Drawing.Point(113, 52)
        Me.RedisPort.Name = "RedisPort"
        Me.RedisPort.Size = New System.Drawing.Size(100, 20)
        Me.RedisPort.TabIndex = 4
        '
        'RedisPass
        '
        Me.RedisPass.Location = New System.Drawing.Point(219, 52)
        Me.RedisPass.Name = "RedisPass"
        Me.RedisPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.RedisPass.Size = New System.Drawing.Size(100, 20)
        Me.RedisPass.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(216, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(2, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "General"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Input File"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(110, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Output File"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(216, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "WorkerScript"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 182)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Queue"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(322, 126)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Main Script"
        '
        'RunTime
        '
        Me.RunTime.AutoSize = True
        Me.RunTime.Location = New System.Drawing.Point(165, 235)
        Me.RunTime.Name = "RunTime"
        Me.RunTime.Size = New System.Drawing.Size(104, 17)
        Me.RunTime.TabIndex = 15
        Me.RunTime.Text = "Measure runtime"
        Me.RunTime.UseVisualStyleBackColor = True
        '
        'FileInput
        '
        Me.FileInput.Location = New System.Drawing.Point(7, 142)
        Me.FileInput.Name = "FileInput"
        Me.FileInput.Size = New System.Drawing.Size(77, 20)
        Me.FileInput.TabIndex = 16
        '
        'FileOutput
        '
        Me.FileOutput.Location = New System.Drawing.Point(113, 142)
        Me.FileOutput.Name = "FileOutput"
        Me.FileOutput.Size = New System.Drawing.Size(79, 20)
        Me.FileOutput.TabIndex = 17
        '
        'WorkerScript
        '
        Me.WorkerScript.Location = New System.Drawing.Point(219, 142)
        Me.WorkerScript.Name = "WorkerScript"
        Me.WorkerScript.Size = New System.Drawing.Size(77, 20)
        Me.WorkerScript.TabIndex = 18
        '
        'QueueName
        '
        Me.QueueName.Location = New System.Drawing.Point(7, 198)
        Me.QueueName.Name = "QueueName"
        Me.QueueName.Size = New System.Drawing.Size(100, 20)
        Me.QueueName.TabIndex = 19
        '
        'MainScript
        '
        Me.MainScript.Location = New System.Drawing.Point(325, 142)
        Me.MainScript.Name = "MainScript"
        Me.MainScript.Size = New System.Drawing.Size(77, 20)
        Me.MainScript.TabIndex = 20
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(113, 258)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(205, 50)
        Me.Start.TabIndex = 21
        Me.Start.Text = "Start Master"
        Me.Start.UseVisualStyleBackColor = True
        '
        'IOFileButton
        '
        Me.IOFileButton.Location = New System.Drawing.Point(83, 142)
        Me.IOFileButton.Name = "IOFileButton"
        Me.IOFileButton.Size = New System.Drawing.Size(24, 20)
        Me.IOFileButton.TabIndex = 22
        Me.IOFileButton.Text = "..."
        Me.IOFileButton.UseVisualStyleBackColor = True
        '
        'OOFileButton
        '
        Me.OOFileButton.Location = New System.Drawing.Point(189, 142)
        Me.OOFileButton.Name = "OOFileButton"
        Me.OOFileButton.Size = New System.Drawing.Size(24, 20)
        Me.OOFileButton.TabIndex = 23
        Me.OOFileButton.Text = "..."
        Me.OOFileButton.UseVisualStyleBackColor = True
        '
        'WorkerButton
        '
        Me.WorkerButton.Location = New System.Drawing.Point(295, 142)
        Me.WorkerButton.Name = "WorkerButton"
        Me.WorkerButton.Size = New System.Drawing.Size(24, 20)
        Me.WorkerButton.TabIndex = 24
        Me.WorkerButton.Text = "..."
        Me.WorkerButton.UseVisualStyleBackColor = True
        '
        'MainButton
        '
        Me.MainButton.Location = New System.Drawing.Point(401, 142)
        Me.MainButton.Name = "MainButton"
        Me.MainButton.Size = New System.Drawing.Size(24, 20)
        Me.MainButton.TabIndex = 25
        Me.MainButton.Text = "..."
        Me.MainButton.UseVisualStyleBackColor = True
        '
        'IOFileDialog
        '
        Me.IOFileDialog.FileName = "IOFileDialog"
        '
        'WorkerDialog
        '
        Me.WorkerDialog.FileName = "WorkerDialog"
        '
        'MainScriptDialog
        '
        Me.MainScriptDialog.FileName = "MainScriptDialog"
        '
        'ExportSettings
        '
        Me.ExportSettings.Location = New System.Drawing.Point(353, 313)
        Me.ExportSettings.Name = "ExportSettings"
        Me.ExportSettings.Size = New System.Drawing.Size(75, 23)
        Me.ExportSettings.TabIndex = 26
        Me.ExportSettings.Text = "Export"
        Me.ExportSettings.UseVisualStyleBackColor = True
        '
        'ImportSettings
        '
        Me.ImportSettings.Location = New System.Drawing.Point(272, 313)
        Me.ImportSettings.Name = "ImportSettings"
        Me.ImportSettings.Size = New System.Drawing.Size(75, 23)
        Me.ImportSettings.TabIndex = 27
        Me.ImportSettings.Text = "Import"
        Me.ImportSettings.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(110, 182)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Chunk Size"
        '
        'ChunkSize
        '
        Me.ChunkSize.Location = New System.Drawing.Point(113, 199)
        Me.ChunkSize.Name = "ChunkSize"
        Me.ChunkSize.Size = New System.Drawing.Size(100, 20)
        Me.ChunkSize.TabIndex = 29
        '
        'GUIControll
        '
        Me.GUIControll.Controls.Add(Me.MasterTab)
        Me.GUIControll.Controls.Add(Me.WorkerTab)
        Me.GUIControll.Location = New System.Drawing.Point(-6, 0)
        Me.GUIControll.Name = "GUIControll"
        Me.GUIControll.SelectedIndex = 0
        Me.GUIControll.Size = New System.Drawing.Size(450, 376)
        Me.GUIControll.TabIndex = 30
        '
        'MasterTab
        '
        Me.MasterTab.Controls.Add(Me.Label1)
        Me.MasterTab.Controls.Add(Me.ImportSettings)
        Me.MasterTab.Controls.Add(Me.ChunkSize)
        Me.MasterTab.Controls.Add(Me.ExportSettings)
        Me.MasterTab.Controls.Add(Me.Label2)
        Me.MasterTab.Controls.Add(Me.Start)
        Me.MasterTab.Controls.Add(Me.RunTime)
        Me.MasterTab.Controls.Add(Me.Label12)
        Me.MasterTab.Controls.Add(Me.RedisHost)
        Me.MasterTab.Controls.Add(Me.Label3)
        Me.MasterTab.Controls.Add(Me.RedisPort)
        Me.MasterTab.Controls.Add(Me.MainButton)
        Me.MasterTab.Controls.Add(Me.Label4)
        Me.MasterTab.Controls.Add(Me.WorkerButton)
        Me.MasterTab.Controls.Add(Me.RedisPass)
        Me.MasterTab.Controls.Add(Me.OOFileButton)
        Me.MasterTab.Controls.Add(Me.QueueName)
        Me.MasterTab.Controls.Add(Me.IOFileButton)
        Me.MasterTab.Controls.Add(Me.Label6)
        Me.MasterTab.Controls.Add(Me.Label7)
        Me.MasterTab.Controls.Add(Me.MainScript)
        Me.MasterTab.Controls.Add(Me.Label8)
        Me.MasterTab.Controls.Add(Me.Label9)
        Me.MasterTab.Controls.Add(Me.WorkerScript)
        Me.MasterTab.Controls.Add(Me.Label10)
        Me.MasterTab.Controls.Add(Me.FileOutput)
        Me.MasterTab.Controls.Add(Me.Label11)
        Me.MasterTab.Controls.Add(Me.FileInput)
        Me.MasterTab.Location = New System.Drawing.Point(4, 22)
        Me.MasterTab.Name = "MasterTab"
        Me.MasterTab.Padding = New System.Windows.Forms.Padding(3)
        Me.MasterTab.Size = New System.Drawing.Size(442, 350)
        Me.MasterTab.TabIndex = 0
        Me.MasterTab.Text = "Master Setup"
        Me.MasterTab.UseVisualStyleBackColor = True
        '
        'WorkerTab
        '
        Me.WorkerTab.Controls.Add(Me.ConfigGen)
        Me.WorkerTab.Controls.Add(Me.NumOfCores)
        Me.WorkerTab.Controls.Add(Me.Label13)
        Me.WorkerTab.Controls.Add(Me.Label5)
        Me.WorkerTab.Location = New System.Drawing.Point(4, 22)
        Me.WorkerTab.Name = "WorkerTab"
        Me.WorkerTab.Padding = New System.Windows.Forms.Padding(3)
        Me.WorkerTab.Size = New System.Drawing.Size(442, 350)
        Me.WorkerTab.TabIndex = 1
        Me.WorkerTab.Text = "Worker Setup"
        Me.WorkerTab.UseVisualStyleBackColor = True
        '
        'ConfigGen
        '
        Me.ConfigGen.Location = New System.Drawing.Point(126, 202)
        Me.ConfigGen.Name = "ConfigGen"
        Me.ConfigGen.Size = New System.Drawing.Size(205, 50)
        Me.ConfigGen.TabIndex = 7
        Me.ConfigGen.Text = "Generate Config"
        Me.ConfigGen.UseVisualStyleBackColor = True
        '
        'NumOfCores
        '
        Me.NumOfCores.Location = New System.Drawing.Point(6, 23)
        Me.NumOfCores.Maximum = New Decimal(New Integer() {512, 0, 0, 0})
        Me.NumOfCores.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumOfCores.Name = "NumOfCores"
        Me.NumOfCores.Size = New System.Drawing.Size(35, 20)
        Me.NumOfCores.TabIndex = 5
        Me.NumOfCores.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(2, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Number of Cores"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 370)
        Me.Controls.Add(Me.GUIControll)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Master Client"
        Me.GUIControll.ResumeLayout(False)
        Me.MasterTab.ResumeLayout(False)
        Me.MasterTab.PerformLayout()
        Me.WorkerTab.ResumeLayout(False)
        Me.WorkerTab.PerformLayout()
        CType(Me.NumOfCores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RedisHost As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RedisPort As TextBox
    Friend WithEvents RedisPass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents RunTime As CheckBox
    Friend WithEvents FileInput As TextBox
    Friend WithEvents FileOutput As TextBox
    Friend WithEvents WorkerScript As TextBox
    Friend WithEvents QueueName As TextBox
    Friend WithEvents MainScript As TextBox
    Friend WithEvents Start As Button
    Friend WithEvents IOFileButton As Button
    Friend WithEvents OOFileButton As Button
    Friend WithEvents WorkerButton As Button
    Friend WithEvents MainButton As Button
    Friend WithEvents IOFileDialog As OpenFileDialog
    Friend WithEvents WorkerDialog As OpenFileDialog
    Friend WithEvents MainScriptDialog As OpenFileDialog
    Friend WithEvents ExportSettings As Button
    Friend WithEvents ImportSettings As Button
    Friend WithEvents OOFileDialog As SaveFileDialog
    Friend WithEvents Label12 As Label
    Friend WithEvents ChunkSize As TextBox
    Friend WithEvents GUIControll As TabControl
    Friend WithEvents MasterTab As TabPage
    Friend WithEvents WorkerTab As TabPage
    Friend WithEvents NumOfCores As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ConfigGen As Button
End Class
