<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ButtonPause = New System.Windows.Forms.Button()
        Me.LabelResultStatus = New System.Windows.Forms.Label()
        Me.RadioButtonRight = New System.Windows.Forms.RadioButton()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.TimeNow = New System.Windows.Forms.Timer(Me.components)
        Me.LabelDegree = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelStatusBuad = New System.Windows.Forms.Label()
        Me.LabelStatusPort = New System.Windows.Forms.Label()
        Me.LabelStatusPortName = New System.Windows.Forms.Label()
        Me.LabelStatusBaudName = New System.Windows.Forms.Label()
        Me.LabelStatusConnect = New System.Windows.Forms.Label()
        Me.LabelStatusName = New System.Windows.Forms.Label()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.ComboBoxBaudRate = New System.Windows.Forms.ComboBox()
        Me.ComboBoxComPort = New System.Windows.Forms.ComboBox()
        Me.LabelBaudRate = New System.Windows.Forms.Label()
        Me.LabelComPort = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadioButtonLeft = New System.Windows.Forms.RadioButton()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.ButtonStop = New System.Windows.Forms.Button()
        Me.ComboBoxDegrees = New System.Windows.Forms.ComboBox()
        Me.LabelStep = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.LblDateTime = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonPause
        '
        Me.ButtonPause.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ButtonPause.Location = New System.Drawing.Point(90, 98)
        Me.ButtonPause.Name = "ButtonPause"
        Me.ButtonPause.Size = New System.Drawing.Size(58, 23)
        Me.ButtonPause.TabIndex = 10
        Me.ButtonPause.Text = "Pause"
        Me.ButtonPause.UseVisualStyleBackColor = True
        '
        'LabelResultStatus
        '
        Me.LabelResultStatus.AutoSize = True
        Me.LabelResultStatus.ForeColor = System.Drawing.Color.Red
        Me.LabelResultStatus.Location = New System.Drawing.Point(52, 210)
        Me.LabelResultStatus.Name = "LabelResultStatus"
        Me.LabelResultStatus.Size = New System.Drawing.Size(100, 13)
        Me.LabelResultStatus.TabIndex = 9
        Me.LabelResultStatus.Text = "Waiting Connection"
        '
        'RadioButtonRight
        '
        Me.RadioButtonRight.AutoSize = True
        Me.RadioButtonRight.ForeColor = System.Drawing.SystemColors.MenuText
        Me.RadioButtonRight.Location = New System.Drawing.Point(90, 65)
        Me.RadioButtonRight.Name = "RadioButtonRight"
        Me.RadioButtonRight.Size = New System.Drawing.Size(50, 17)
        Me.RadioButtonRight.TabIndex = 3
        Me.RadioButtonRight.TabStop = True
        Me.RadioButtonRight.Text = "Right"
        Me.RadioButtonRight.UseVisualStyleBackColor = True
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ButtonCalculate.Location = New System.Drawing.Point(90, 156)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(58, 23)
        Me.ButtonCalculate.TabIndex = 7
        Me.ButtonCalculate.Text = "Calculate"
        Me.ButtonCalculate.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.ListBox3)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox3.Location = New System.Drawing.Point(189, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 451)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Result of Antenna Radiation Measurement"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(148, 52)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(100, 376)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(25, 52)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(100, 376)
        Me.TextBox1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label3.Location = New System.Drawing.Point(270, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Signal strength ( dB ):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label2.Location = New System.Drawing.Point(145, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Power ( Voltage ):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label1.Location = New System.Drawing.Point(22, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Degree:"
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(273, 47)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(103, 381)
        Me.ListBox3.TabIndex = 2
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.ForeColor = System.Drawing.SystemColors.MenuText
        Me.LabelStatus.Location = New System.Drawing.Point(12, 210)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(40, 13)
        Me.LabelStatus.TabIndex = 8
        Me.LabelStatus.Text = "Status:"
        '
        'TimeNow
        '
        '
        'LabelDegree
        '
        Me.LabelDegree.AutoSize = True
        Me.LabelDegree.ForeColor = System.Drawing.SystemColors.MenuText
        Me.LabelDegree.Location = New System.Drawing.Point(116, 30)
        Me.LabelDegree.Name = "LabelDegree"
        Me.LabelDegree.Size = New System.Drawing.Size(42, 13)
        Me.LabelDegree.TabIndex = 2
        Me.LabelDegree.Text = "Degree"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelStatusBuad)
        Me.GroupBox1.Controls.Add(Me.LabelStatusPort)
        Me.GroupBox1.Controls.Add(Me.LabelStatusPortName)
        Me.GroupBox1.Controls.Add(Me.LabelStatusBaudName)
        Me.GroupBox1.Controls.Add(Me.LabelStatusConnect)
        Me.GroupBox1.Controls.Add(Me.LabelStatusName)
        Me.GroupBox1.Controls.Add(Me.ButtonConnect)
        Me.GroupBox1.Controls.Add(Me.ComboBoxBaudRate)
        Me.GroupBox1.Controls.Add(Me.ComboBoxComPort)
        Me.GroupBox1.Controls.Add(Me.LabelBaudRate)
        Me.GroupBox1.Controls.Add(Me.LabelComPort)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(171, 183)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connection Setting"
        '
        'LabelStatusBuad
        '
        Me.LabelStatusBuad.AutoSize = True
        Me.LabelStatusBuad.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.LabelStatusBuad.Location = New System.Drawing.Point(90, 147)
        Me.LabelStatusBuad.Name = "LabelStatusBuad"
        Me.LabelStatusBuad.Size = New System.Drawing.Size(33, 13)
        Me.LabelStatusBuad.TabIndex = 8
        Me.LabelStatusBuad.Text = "None"
        '
        'LabelStatusPort
        '
        Me.LabelStatusPort.AutoSize = True
        Me.LabelStatusPort.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.LabelStatusPort.Location = New System.Drawing.Point(90, 125)
        Me.LabelStatusPort.Name = "LabelStatusPort"
        Me.LabelStatusPort.Size = New System.Drawing.Size(33, 13)
        Me.LabelStatusPort.TabIndex = 6
        Me.LabelStatusPort.Text = "None"
        '
        'LabelStatusPortName
        '
        Me.LabelStatusPortName.AutoSize = True
        Me.LabelStatusPortName.ForeColor = System.Drawing.SystemColors.MenuText
        Me.LabelStatusPortName.Location = New System.Drawing.Point(25, 125)
        Me.LabelStatusPortName.Name = "LabelStatusPortName"
        Me.LabelStatusPortName.Size = New System.Drawing.Size(56, 13)
        Me.LabelStatusPortName.TabIndex = 5
        Me.LabelStatusPortName.Text = "COM Port:"
        '
        'LabelStatusBaudName
        '
        Me.LabelStatusBaudName.AutoSize = True
        Me.LabelStatusBaudName.ForeColor = System.Drawing.SystemColors.MenuText
        Me.LabelStatusBaudName.Location = New System.Drawing.Point(20, 147)
        Me.LabelStatusBaudName.Name = "LabelStatusBaudName"
        Me.LabelStatusBaudName.Size = New System.Drawing.Size(61, 13)
        Me.LabelStatusBaudName.TabIndex = 7
        Me.LabelStatusBaudName.Text = "Baud Rate:"
        '
        'LabelStatusConnect
        '
        Me.LabelStatusConnect.AutoSize = True
        Me.LabelStatusConnect.ForeColor = System.Drawing.Color.Red
        Me.LabelStatusConnect.Location = New System.Drawing.Point(90, 103)
        Me.LabelStatusConnect.Name = "LabelStatusConnect"
        Me.LabelStatusConnect.Size = New System.Drawing.Size(64, 13)
        Me.LabelStatusConnect.TabIndex = 4
        Me.LabelStatusConnect.Text = "Disconnect!"
        '
        'LabelStatusName
        '
        Me.LabelStatusName.AutoSize = True
        Me.LabelStatusName.ForeColor = System.Drawing.SystemColors.MenuText
        Me.LabelStatusName.Location = New System.Drawing.Point(41, 103)
        Me.LabelStatusName.Name = "LabelStatusName"
        Me.LabelStatusName.Size = New System.Drawing.Size(40, 13)
        Me.LabelStatusName.TabIndex = 3
        Me.LabelStatusName.Text = "Status:"
        '
        'ButtonConnect
        '
        Me.ButtonConnect.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ButtonConnect.Location = New System.Drawing.Point(49, 73)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(75, 23)
        Me.ButtonConnect.TabIndex = 1
        Me.ButtonConnect.Text = "Connect"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'ComboBoxBaudRate
        '
        Me.ComboBoxBaudRate.FormattingEnabled = True
        Me.ComboBoxBaudRate.Items.AddRange(New Object() {"9600"})
        Me.ComboBoxBaudRate.Location = New System.Drawing.Point(93, 46)
        Me.ComboBoxBaudRate.Name = "ComboBoxBaudRate"
        Me.ComboBoxBaudRate.Size = New System.Drawing.Size(68, 21)
        Me.ComboBoxBaudRate.TabIndex = 2
        Me.ComboBoxBaudRate.Tag = ""
        '
        'ComboBoxComPort
        '
        Me.ComboBoxComPort.FormattingEnabled = True
        Me.ComboBoxComPort.Location = New System.Drawing.Point(13, 46)
        Me.ComboBoxComPort.Name = "ComboBoxComPort"
        Me.ComboBoxComPort.Size = New System.Drawing.Size(68, 21)
        Me.ComboBoxComPort.TabIndex = 1
        '
        'LabelBaudRate
        '
        Me.LabelBaudRate.AutoSize = True
        Me.LabelBaudRate.ForeColor = System.Drawing.SystemColors.MenuText
        Me.LabelBaudRate.Location = New System.Drawing.Point(90, 30)
        Me.LabelBaudRate.Name = "LabelBaudRate"
        Me.LabelBaudRate.Size = New System.Drawing.Size(61, 13)
        Me.LabelBaudRate.TabIndex = 1
        Me.LabelBaudRate.Text = "Baud Rate:"
        '
        'LabelComPort
        '
        Me.LabelComPort.AutoSize = True
        Me.LabelComPort.ForeColor = System.Drawing.SystemColors.MenuText
        Me.LabelComPort.Location = New System.Drawing.Point(10, 30)
        Me.LabelComPort.Name = "LabelComPort"
        Me.LabelComPort.Size = New System.Drawing.Size(56, 13)
        Me.LabelComPort.TabIndex = 0
        Me.LabelComPort.Text = "COM Port:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.ButtonPause)
        Me.GroupBox2.Controls.Add(Me.LabelResultStatus)
        Me.GroupBox2.Controls.Add(Me.LabelStatus)
        Me.GroupBox2.Controls.Add(Me.RadioButtonRight)
        Me.GroupBox2.Controls.Add(Me.ButtonCalculate)
        Me.GroupBox2.Controls.Add(Me.LabelDegree)
        Me.GroupBox2.Controls.Add(Me.RadioButtonLeft)
        Me.GroupBox2.Controls.Add(Me.ButtonSave)
        Me.GroupBox2.Controls.Add(Me.ButtonStart)
        Me.GroupBox2.Controls.Add(Me.ButtonReset)
        Me.GroupBox2.Controls.Add(Me.ButtonStop)
        Me.GroupBox2.Controls.Add(Me.ComboBoxDegrees)
        Me.GroupBox2.Controls.Add(Me.LabelStep)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 201)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(171, 262)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Process Setting"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(52, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 11
        '
        'RadioButtonLeft
        '
        Me.RadioButtonLeft.AutoSize = True
        Me.RadioButtonLeft.ForeColor = System.Drawing.SystemColors.MenuText
        Me.RadioButtonLeft.Location = New System.Drawing.Point(35, 65)
        Me.RadioButtonLeft.Name = "RadioButtonLeft"
        Me.RadioButtonLeft.Size = New System.Drawing.Size(43, 17)
        Me.RadioButtonLeft.TabIndex = 2
        Me.RadioButtonLeft.TabStop = True
        Me.RadioButtonLeft.Text = "Left"
        Me.RadioButtonLeft.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ButtonSave.Location = New System.Drawing.Point(90, 127)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(58, 23)
        Me.ButtonSave.TabIndex = 6
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonStart
        '
        Me.ButtonStart.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ButtonStart.Location = New System.Drawing.Point(20, 98)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(58, 23)
        Me.ButtonStart.TabIndex = 3
        Me.ButtonStart.Text = "Start"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'ButtonReset
        '
        Me.ButtonReset.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ButtonReset.Location = New System.Drawing.Point(20, 156)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(58, 23)
        Me.ButtonReset.TabIndex = 5
        Me.ButtonReset.Text = "Reset"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'ButtonStop
        '
        Me.ButtonStop.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ButtonStop.Location = New System.Drawing.Point(20, 127)
        Me.ButtonStop.Name = "ButtonStop"
        Me.ButtonStop.Size = New System.Drawing.Size(58, 23)
        Me.ButtonStop.TabIndex = 4
        Me.ButtonStop.Text = "Stop"
        Me.ButtonStop.UseVisualStyleBackColor = True
        '
        'ComboBoxDegrees
        '
        Me.ComboBoxDegrees.FormattingEnabled = True
        Me.ComboBoxDegrees.Items.AddRange(New Object() {"5", "10", "360"})
        Me.ComboBoxDegrees.Location = New System.Drawing.Point(48, 27)
        Me.ComboBoxDegrees.Name = "ComboBoxDegrees"
        Me.ComboBoxDegrees.Size = New System.Drawing.Size(62, 21)
        Me.ComboBoxDegrees.TabIndex = 1
        '
        'LabelStep
        '
        Me.LabelStep.AutoSize = True
        Me.LabelStep.ForeColor = System.Drawing.SystemColors.MenuText
        Me.LabelStep.Location = New System.Drawing.Point(10, 30)
        Me.LabelStep.Name = "LabelStep"
        Me.LabelStep.Size = New System.Drawing.Size(32, 13)
        Me.LabelStep.TabIndex = 0
        Me.LabelStep.Text = "Step:"
        '
        'BackgroundWorker1
        '
        '
        'LblDateTime
        '
        Me.LblDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblDateTime.AutoSize = True
        Me.LblDateTime.Location = New System.Drawing.Point(334, 473)
        Me.LblDateTime.Name = "LblDateTime"
        Me.LblDateTime.Size = New System.Drawing.Size(67, 13)
        Me.LblDateTime.TabIndex = 7
        Me.LblDateTime.Text = "LblDateTime"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(462, 473)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Computer Engineering"
        '
        'SaveFileDialog1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 495)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblDateTime)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form1"
        Me.Text = "Antenna Radiation Pattern Measurement System"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonPause As Button
    Friend WithEvents LabelResultStatus As Label
    Friend WithEvents RadioButtonRight As RadioButton
    Friend WithEvents ButtonCalculate As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents LabelStatus As Label
    Friend WithEvents TimeNow As Timer
    Friend WithEvents LabelDegree As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelStatusBuad As Label
    Friend WithEvents LabelStatusPort As Label
    Friend WithEvents LabelStatusPortName As Label
    Friend WithEvents LabelStatusBaudName As Label
    Friend WithEvents LabelStatusConnect As Label
    Friend WithEvents LabelStatusName As Label
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents ComboBoxBaudRate As ComboBox
    Friend WithEvents ComboBoxComPort As ComboBox
    Friend WithEvents LabelBaudRate As Label
    Friend WithEvents LabelComPort As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButtonLeft As RadioButton
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonStart As Button
    Friend WithEvents ButtonReset As Button
    Friend WithEvents ButtonStop As Button
    Friend WithEvents ComboBoxDegrees As ComboBox
    Friend WithEvents LabelStep As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LblDateTime As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
