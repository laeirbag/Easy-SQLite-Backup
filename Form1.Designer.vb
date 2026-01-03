<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txtSourceLocation = New TextBox()
        lblSource = New Label()
        Label1 = New Label()
        txtBackupLocation = New TextBox()
        chk_appendTimeStamp = New CheckBox()
        btnBackupNow = New Button()
        btnSaveConfig = New Button()
        Panel1 = New Panel()
        chk_writeLog = New CheckBox()
        chk_popupnotificatons = New CheckBox()
        lblNextBackupDisplay = New Label()
        Label5 = New Label()
        pnl_automatedIndicator = New Panel()
        btn_automatedEnabled = New Button()
        chk_startMinimized = New CheckBox()
        chk_automated_runStart = New CheckBox()
        Label3 = New Label()
        lblInterval = New Label()
        numeric_automatedInterval = New NumericUpDown()
        Label2 = New Label()
        Timer1 = New Timer(components)
        radio_vacumm = New RadioButton()
        radio_filecopy = New RadioButton()
        Label6 = New Label()
        chk_zipbackup = New CheckBox()
        NotifyIcon1 = New NotifyIcon(components)
        Panel1.SuspendLayout()
        CType(numeric_automatedInterval, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSourceLocation
        ' 
        txtSourceLocation.Font = New Font("Segoe UI", 9F)
        txtSourceLocation.Location = New Point(45, 38)
        txtSourceLocation.Name = "txtSourceLocation"
        txtSourceLocation.Size = New Size(571, 23)
        txtSourceLocation.TabIndex = 0
        ' 
        ' lblSource
        ' 
        lblSource.AutoSize = True
        lblSource.Font = New Font("Segoe UI", 14F)
        lblSource.Location = New Point(45, 10)
        lblSource.Name = "lblSource"
        lblSource.Size = New Size(105, 25)
        lblSource.TabIndex = 1
        lblSource.Text = "Source file:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F)
        Label1.Location = New Point(40, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 25)
        Label1.TabIndex = 3
        Label1.Text = "Backup location:"
        ' 
        ' txtBackupLocation
        ' 
        txtBackupLocation.Font = New Font("Segoe UI", 9F)
        txtBackupLocation.Location = New Point(46, 93)
        txtBackupLocation.Name = "txtBackupLocation"
        txtBackupLocation.Size = New Size(570, 23)
        txtBackupLocation.TabIndex = 2
        ' 
        ' chk_appendTimeStamp
        ' 
        chk_appendTimeStamp.AutoSize = True
        chk_appendTimeStamp.Checked = True
        chk_appendTimeStamp.CheckState = CheckState.Checked
        chk_appendTimeStamp.Font = New Font("Segoe UI", 12F)
        chk_appendTimeStamp.Location = New Point(268, 160)
        chk_appendTimeStamp.Name = "chk_appendTimeStamp"
        chk_appendTimeStamp.Size = New Size(283, 25)
        chk_appendTimeStamp.TabIndex = 4
        chk_appendTimeStamp.Text = "Append Timestamp (Recommended)"
        chk_appendTimeStamp.UseVisualStyleBackColor = True
        ' 
        ' btnBackupNow
        ' 
        btnBackupNow.Location = New Point(492, 222)
        btnBackupNow.Name = "btnBackupNow"
        btnBackupNow.Size = New Size(170, 37)
        btnBackupNow.TabIndex = 5
        btnBackupNow.Text = "Backup Now"
        btnBackupNow.UseVisualStyleBackColor = True
        ' 
        ' btnSaveConfig
        ' 
        btnSaveConfig.Location = New Point(492, 270)
        btnSaveConfig.Name = "btnSaveConfig"
        btnSaveConfig.Size = New Size(170, 37)
        btnSaveConfig.TabIndex = 6
        btnSaveConfig.Text = "Save Config"
        btnSaveConfig.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LemonChiffon
        Panel1.Controls.Add(chk_writeLog)
        Panel1.Controls.Add(chk_popupnotificatons)
        Panel1.Controls.Add(lblNextBackupDisplay)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(pnl_automatedIndicator)
        Panel1.Controls.Add(btn_automatedEnabled)
        Panel1.Controls.Add(chk_startMinimized)
        Panel1.Controls.Add(chk_automated_runStart)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(lblInterval)
        Panel1.Controls.Add(numeric_automatedInterval)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(44, 218)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(426, 170)
        Panel1.TabIndex = 7
        ' 
        ' chk_writeLog
        ' 
        chk_writeLog.AutoSize = True
        chk_writeLog.Font = New Font("Segoe UI", 9F)
        chk_writeLog.Location = New Point(11, 134)
        chk_writeLog.Name = "chk_writeLog"
        chk_writeLog.Size = New Size(92, 19)
        chk_writeLog.TabIndex = 15
        chk_writeLog.Text = "Write To Log"
        chk_writeLog.UseVisualStyleBackColor = True
        ' 
        ' chk_popupnotificatons
        ' 
        chk_popupnotificatons.AutoSize = True
        chk_popupnotificatons.Font = New Font("Segoe UI", 9F)
        chk_popupnotificatons.Location = New Point(11, 109)
        chk_popupnotificatons.Name = "chk_popupnotificatons"
        chk_popupnotificatons.Size = New Size(132, 19)
        chk_popupnotificatons.TabIndex = 14
        chk_popupnotificatons.Text = "Popup Notifications"
        chk_popupnotificatons.UseVisualStyleBackColor = True
        ' 
        ' lblNextBackupDisplay
        ' 
        lblNextBackupDisplay.AutoSize = True
        lblNextBackupDisplay.Location = New Point(325, 125)
        lblNextBackupDisplay.Name = "lblNextBackupDisplay"
        lblNextBackupDisplay.Size = New Size(17, 15)
        lblNextBackupDisplay.TabIndex = 13
        lblNextBackupDisplay.Text = "--"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(239, 125)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 15)
        Label5.TabIndex = 11
        Label5.Text = "Next Backup: "
        ' 
        ' pnl_automatedIndicator
        ' 
        pnl_automatedIndicator.BackColor = Color.White
        pnl_automatedIndicator.Location = New Point(376, 91)
        pnl_automatedIndicator.Name = "pnl_automatedIndicator"
        pnl_automatedIndicator.Size = New Size(19, 21)
        pnl_automatedIndicator.TabIndex = 10
        ' 
        ' btn_automatedEnabled
        ' 
        btn_automatedEnabled.FlatStyle = FlatStyle.Flat
        btn_automatedEnabled.Location = New Point(237, 88)
        btn_automatedEnabled.Name = "btn_automatedEnabled"
        btn_automatedEnabled.Size = New Size(133, 25)
        btn_automatedEnabled.TabIndex = 9
        btn_automatedEnabled.Text = "Disabled"
        btn_automatedEnabled.UseVisualStyleBackColor = True
        ' 
        ' chk_startMinimized
        ' 
        chk_startMinimized.AutoSize = True
        chk_startMinimized.Font = New Font("Segoe UI", 9F)
        chk_startMinimized.Location = New Point(11, 59)
        chk_startMinimized.Name = "chk_startMinimized"
        chk_startMinimized.Size = New Size(181, 19)
        chk_startMinimized.TabIndex = 8
        chk_startMinimized.Text = "Start minimized (System tray)"
        chk_startMinimized.UseVisualStyleBackColor = True
        ' 
        ' chk_automated_runStart
        ' 
        chk_automated_runStart.AutoSize = True
        chk_automated_runStart.Font = New Font("Segoe UI", 9F)
        chk_automated_runStart.Location = New Point(11, 84)
        chk_automated_runStart.Name = "chk_automated_runStart"
        chk_automated_runStart.Size = New Size(140, 19)
        chk_automated_runStart.TabIndex = 9
        chk_automated_runStart.Text = "Run on Program Start"
        chk_automated_runStart.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(360, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 15)
        Label3.TabIndex = 11
        Label3.Text = "Minutes"
        ' 
        ' lblInterval
        ' 
        lblInterval.AutoSize = True
        lblInterval.Location = New Point(237, 63)
        lblInterval.Name = "lblInterval"
        lblInterval.Size = New Size(49, 15)
        lblInterval.TabIndex = 9
        lblInterval.Text = "Interval:"
        ' 
        ' numeric_automatedInterval
        ' 
        numeric_automatedInterval.Location = New Point(292, 59)
        numeric_automatedInterval.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        numeric_automatedInterval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        numeric_automatedInterval.Name = "numeric_automatedInterval"
        numeric_automatedInterval.Size = New Size(62, 23)
        numeric_automatedInterval.TabIndex = 10
        numeric_automatedInterval.Value = New Decimal(New Integer() {60, 0, 0, 0})
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F)
        Label2.Location = New Point(115, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 25)
        Label2.TabIndex = 9
        Label2.Text = "Automated backup"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' radio_vacumm
        ' 
        radio_vacumm.AutoSize = True
        radio_vacumm.Checked = True
        radio_vacumm.Font = New Font("Segoe UI", 10F)
        radio_vacumm.Location = New Point(53, 160)
        radio_vacumm.Name = "radio_vacumm"
        radio_vacumm.Size = New Size(121, 23)
        radio_vacumm.TabIndex = 10
        radio_vacumm.TabStop = True
        radio_vacumm.Text = "VACUUM INTO"
        radio_vacumm.UseVisualStyleBackColor = True
        ' 
        ' radio_filecopy
        ' 
        radio_filecopy.AutoSize = True
        radio_filecopy.Font = New Font("Segoe UI", 10F)
        radio_filecopy.Location = New Point(54, 189)
        radio_filecopy.Name = "radio_filecopy"
        radio_filecopy.Size = New Size(92, 23)
        radio_filecopy.TabIndex = 12
        radio_filecopy.TabStop = True
        radio_filecopy.Text = "FILE COPY"
        radio_filecopy.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14F)
        Label6.Location = New Point(19, 132)
        Label6.Name = "Label6"
        Label6.Size = New Size(130, 25)
        Label6.TabIndex = 13
        Label6.Text = "Backup mode:"
        ' 
        ' chk_zipbackup
        ' 
        chk_zipbackup.AutoSize = True
        chk_zipbackup.Font = New Font("Segoe UI", 12F)
        chk_zipbackup.Location = New Point(268, 185)
        chk_zipbackup.Name = "chk_zipbackup"
        chk_zipbackup.Size = New Size(187, 25)
        chk_zipbackup.TabIndex = 14
        chk_zipbackup.Text = "Compress (zip) Backup"
        chk_zipbackup.UseVisualStyleBackColor = True
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), Icon)
        NotifyIcon1.Text = "Easy SQL Backup"
        NotifyIcon1.Visible = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(677, 404)
        Controls.Add(chk_zipbackup)
        Controls.Add(Label6)
        Controls.Add(radio_filecopy)
        Controls.Add(radio_vacumm)
        Controls.Add(Panel1)
        Controls.Add(btnSaveConfig)
        Controls.Add(btnBackupNow)
        Controls.Add(chk_appendTimeStamp)
        Controls.Add(Label1)
        Controls.Add(txtBackupLocation)
        Controls.Add(lblSource)
        Controls.Add(txtSourceLocation)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form1"
        Text = "Easy SQLite Backup"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(numeric_automatedInterval, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtSourceLocation As TextBox
    Friend WithEvents lblSource As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBackupLocation As TextBox
    Friend WithEvents chk_appendTimeStamp As CheckBox
    Friend WithEvents btnBackupNow As Button
    Friend WithEvents btnSaveConfig As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chk_startMinimized As CheckBox
    Friend WithEvents chk_automated_runStart As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblInterval As Label
    Friend WithEvents numeric_automatedInterval As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_automatedEnabled As Button
    Friend WithEvents pnl_automatedIndicator As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblNextBackupDisplay As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents radio_vacumm As RadioButton
    Friend WithEvents radio_filecopy As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents chk_zipbackup As CheckBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents chk_popupnotificatons As CheckBox
    Friend WithEvents chk_writeLog As CheckBox

End Class
