<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.prgbarStatus = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.timerTimeout = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimerDisplay = New System.Windows.Forms.Label()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtMinutes = New System.Windows.Forms.TextBox()
        Me.txtSeconds = New System.Windows.Forms.TextBox()
        Me.txtDelaySeconds = New System.Windows.Forms.TextBox()
        Me.txtDelayMinutes = New System.Windows.Forms.TextBox()
        Me.txtDelayHours = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.timerDelay = New System.Windows.Forms.Timer(Me.components)
        Me.btnStop = New System.Windows.Forms.Button()
        Me.lblRunning = New System.Windows.Forms.Label()
        Me.lblWaiting = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(591, 31)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 23)
        Me.btnRun.TabIndex = 0
        Me.btnRun.Text = "Run It"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Which program?"
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(112, 53)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(450, 20)
        Me.txtFile.TabIndex = 2
        Me.txtFile.Text = "HaltingMachine.exe"
        '
        'prgbarStatus
        '
        Me.prgbarStatus.Location = New System.Drawing.Point(252, 102)
        Me.prgbarStatus.Name = "prgbarStatus"
        Me.prgbarStatus.Size = New System.Drawing.Size(395, 23)
        Me.prgbarStatus.Step = 1
        Me.prgbarStatus.TabIndex = 3
        Me.prgbarStatus.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Meiryo UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(237, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 30)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Halting Machine"
        '
        'timerTimeout
        '
        Me.timerTimeout.Interval = 1000
        '
        'lblTimerDisplay
        '
        Me.lblTimerDisplay.AutoSize = True
        Me.lblTimerDisplay.Location = New System.Drawing.Point(445, 144)
        Me.lblTimerDisplay.Name = "lblTimerDisplay"
        Me.lblTimerDisplay.Size = New System.Drawing.Size(0, 13)
        Me.lblTimerDisplay.TabIndex = 5
        Me.lblTimerDisplay.Visible = False
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent.Location = New System.Drawing.Point(445, 105)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(14, 13)
        Me.lblPercent.TabIndex = 6
        Me.lblPercent.Text = "0"
        Me.lblPercent.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "For How Long? (Hours:Minutes:Seconds)"
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(77, 102)
        Me.txtHours.MaxLength = 3
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(42, 20)
        Me.txtHours.TabIndex = 8
        Me.txtHours.Text = "0"
        Me.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMinutes
        '
        Me.txtMinutes.Location = New System.Drawing.Point(125, 102)
        Me.txtMinutes.MaxLength = 3
        Me.txtMinutes.Name = "txtMinutes"
        Me.txtMinutes.Size = New System.Drawing.Size(42, 20)
        Me.txtMinutes.TabIndex = 9
        Me.txtMinutes.Text = "0"
        Me.txtMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSeconds
        '
        Me.txtSeconds.Location = New System.Drawing.Point(173, 102)
        Me.txtSeconds.MaxLength = 3
        Me.txtSeconds.Name = "txtSeconds"
        Me.txtSeconds.Size = New System.Drawing.Size(42, 20)
        Me.txtSeconds.TabIndex = 10
        Me.txtSeconds.Text = "5"
        Me.txtSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDelaySeconds
        '
        Me.txtDelaySeconds.Location = New System.Drawing.Point(173, 146)
        Me.txtDelaySeconds.MaxLength = 3
        Me.txtDelaySeconds.Name = "txtDelaySeconds"
        Me.txtDelaySeconds.Size = New System.Drawing.Size(42, 20)
        Me.txtDelaySeconds.TabIndex = 14
        Me.txtDelaySeconds.Text = "7"
        Me.txtDelaySeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDelayMinutes
        '
        Me.txtDelayMinutes.Location = New System.Drawing.Point(125, 146)
        Me.txtDelayMinutes.MaxLength = 3
        Me.txtDelayMinutes.Name = "txtDelayMinutes"
        Me.txtDelayMinutes.Size = New System.Drawing.Size(42, 20)
        Me.txtDelayMinutes.TabIndex = 13
        Me.txtDelayMinutes.Text = "0"
        Me.txtDelayMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDelayHours
        '
        Me.txtDelayHours.Location = New System.Drawing.Point(77, 146)
        Me.txtDelayHours.MaxLength = 3
        Me.txtDelayHours.Name = "txtDelayHours"
        Me.txtDelayHours.Size = New System.Drawing.Size(42, 20)
        Me.txtDelayHours.TabIndex = 12
        Me.txtDelayHours.Text = "0"
        Me.txtDelayHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Repeat Every (Hours:Minutes:Seconds)"
        '
        'timerDelay
        '
        Me.timerDelay.Interval = 1000
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(591, 60)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 15
        Me.btnStop.Text = "Stop It"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'lblRunning
        '
        Me.lblRunning.AutoSize = True
        Me.lblRunning.Location = New System.Drawing.Point(249, 128)
        Me.lblRunning.Name = "lblRunning"
        Me.lblRunning.Size = New System.Drawing.Size(59, 13)
        Me.lblRunning.TabIndex = 16
        Me.lblRunning.Text = "Running ->"
        Me.lblRunning.Visible = False
        '
        'lblWaiting
        '
        Me.lblWaiting.AutoSize = True
        Me.lblWaiting.Location = New System.Drawing.Point(588, 128)
        Me.lblWaiting.Name = "lblWaiting"
        Me.lblWaiting.Size = New System.Drawing.Size(55, 13)
        Me.lblWaiting.TabIndex = 17
        Me.lblWaiting.Text = "<- Waiting"
        Me.lblWaiting.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 175)
        Me.Controls.Add(Me.lblWaiting)
        Me.Controls.Add(Me.lblRunning)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.txtDelaySeconds)
        Me.Controls.Add(Me.txtDelayMinutes)
        Me.Controls.Add(Me.txtDelayHours)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSeconds)
        Me.Controls.Add(Me.txtMinutes)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.lblTimerDisplay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.prgbarStatus)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRun)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Halting Machine"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents prgbarStatus As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents timerTimeout As System.Windows.Forms.Timer
    Friend WithEvents lblTimerDisplay As System.Windows.Forms.Label
    Friend WithEvents lblPercent As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents txtMinutes As System.Windows.Forms.TextBox
    Friend WithEvents txtSeconds As System.Windows.Forms.TextBox
    Friend WithEvents txtDelaySeconds As System.Windows.Forms.TextBox
    Friend WithEvents txtDelayHours As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents timerDelay As System.Windows.Forms.Timer
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents txtDelayMinutes As System.Windows.Forms.TextBox
    Friend WithEvents lblRunning As System.Windows.Forms.Label
    Friend WithEvents lblWaiting As System.Windows.Forms.Label

End Class
