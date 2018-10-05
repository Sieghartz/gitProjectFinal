Imports System.ComponentModel
Imports System.IO
Imports System.IO.Ports

Public Class Form1

    Dim rxBuff As String
    Dim command As String
    Dim num As Double
    Dim Data_Show As String
    Dim Data_Save As String
    Dim Data_Show_Degree As String
    Dim Step_Motor As Integer
    Dim portCommand As String
    Dim Send_command As String

#Region "Constructor & Destructor"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.WorkerSupportsCancellation = True

        LblDateTime.Text = ""

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False 'แก้ error
        TimeNow.Enabled = True

        '----------------------- connection setting -----------------------------'
        Try
            Dim lists As String() = IO.Ports.SerialPort.GetPortNames
            For i = 0 To lists.Count - 1
                ComboBoxComPort.Items.Add(lists(i))
            Next
            ComboBoxComPort.SelectedIndex = "0"
            SerialPort1.PortName = ComboBoxComPort.Text
            ComboBoxBaudRate.SelectedIndex = "0"
            SerialPort1.BaudRate = ComboBoxBaudRate.Text
            SerialPort1.Parity = IO.Ports.Parity.None
            SerialPort1.StopBits = IO.Ports.StopBits.One
            SerialPort1.DataBits = 8
        Catch ex As Exception
            'msgbox(ex.message)
        End Try
        '----------------------- connection setting -----------------------------'


        '----------------------- process setting --------------------------------'

        ComboBoxDegrees.Enabled = False
        RadioButtonLeft.Enabled = False
        RadioButtonRight.Enabled = False
        ButtonStart.Enabled = False
        ButtonPause.Enabled = False
        ButtonStop.Enabled = False
        ButtonReset.Enabled = True
        ButtonSave.Enabled = False
        ButtonCalculate.Enabled = False
        ButtonReset.Enabled = False

        ''Chart1.Series("Series1").Points.AddXY(0, 0)
    End Sub

#End Region

#Region "Local Function"
    Private Sub UpdateProgress(ByVal counts As Integer)

        'Data_Save = Data_Save & CStr(counts)
        'Data_Show = Data_Show & CStr(counts) & vbCrLf
        'TextBox1.Text = Data_Show
        ' TextBox1.Text = counts

    End Sub
#End Region

#Region "Event"

    Private Sub TmrNow_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeNow.Tick
        LblDateTime.Text = Now.ToString()
    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click

        Try
            Step_Motor = ComboBoxDegrees.SelectedIndex
            Dim Motor_degree As String = ComboBoxDegrees.SelectedItem.ToString()
            num = 0
            Data_Show = ""
            Data_Show_Degree = ""
            Data_Save = ""

            If RadioButtonLeft.Checked = True Then
                command = "l"
            Else
                command = "r"
            End If

            If SerialPort1.IsOpen = True Then
                ' timer1.enabled = true
            Else
                MessageBox.Show("เชื่อมต่อ serial port ก่อน !", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Send_command = Motor_degree & command
            LabelResultStatus.Text = "Processing"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        RadioButtonLeft.Enabled = False
        RadioButtonRight.Enabled = False
        ComboBoxDegrees.Enabled = False
        ButtonStart.Enabled = False
        ButtonPause.Enabled = True
        ButtonStop.Enabled = True

        If BackgroundWorker1.IsBusy <> True And SerialPort1.IsOpen = True Then
            BackgroundWorker1.RunWorkerAsync()
        End If



    End Sub

    Private Sub ButtonStop_Click(sender As Object, e As EventArgs) Handles ButtonStop.Click

        If ButtonStop.Text = "" Then Return
        If ButtonStop.Text = "Stop" Then
            Try
                ComboBoxDegrees.Enabled = True
                RadioButtonLeft.Enabled = True
                RadioButtonRight.Enabled = True
                ButtonSave.Enabled = True
                ButtonPause.Enabled = False
                ButtonStop.Enabled = False
                ButtonReset.Enabled = True
                ButtonStart.Enabled = True
                ButtonCalculate.Enabled = True
                ButtonConnect.Enabled = True
                ButtonPause.Text = "Pause"
                LabelResultStatus.Text = "ready"
                LabelResultStatus.ForeColor = Color.Green
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        If BackgroundWorker1.WorkerSupportsCancellation = True Then
            BackgroundWorker1.CancelAsync()
        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        System.Threading.Thread.Sleep(50)
        num = 0

        While num < 360
            If BackgroundWorker1.CancellationPending Then e.Cancel = True : Return

            Select Case Step_Motor
                Case 0
                    SerialPort1.Write(Send_command)
                    Do
                        rxBuff = ""
                        System.Threading.Thread.Sleep(500)
                        rxBuff = (SerialPort1.ReadExisting)
                        System.Threading.Thread.Sleep(500)

                    Loop While rxBuff = ""
                    Data_Save = Data_Save & CStr(rxBuff)
                    Data_Show = Data_Show & CStr(rxBuff) & vbCrLf
                    TextBox2.Text = Data_Show
                    num = (num + 5)

                Case 1
                    SerialPort1.Write(Send_command)
                    Do
                        rxBuff = ""
                        System.Threading.Thread.Sleep(50)
                        rxBuff = (SerialPort1.ReadExisting)
                        System.Threading.Thread.Sleep(50)

                    Loop While rxBuff = ""
                    Data_Save = Data_Save & CStr(rxBuff)
                    Data_Show = Data_Show & CStr(rxBuff) & vbCrLf
                    TextBox2.Text = Data_Show


                    num = (num + 10)

                Case 2
                    SerialPort1.Write(Send_command)
                    Do
                        rxBuff = ""
                        System.Threading.Thread.Sleep(50)
                        rxBuff = (SerialPort1.ReadExisting)
                        System.Threading.Thread.Sleep(50)

                    Loop While rxBuff = ""
                    Data_Save = Data_Save & CStr(rxBuff)
                    Data_Show = Data_Show & CStr(rxBuff) & vbCrLf
                    TextBox2.Text = Data_Show

                    num = (num + 360)

            End Select

            Data_Show_Degree = Data_Show_Degree & CStr(num) & vbCrLf
            TextBox1.Text = Data_Show_Degree
        End While

        '------------------------- Example --------------------------------------------'
        'Dim intStart As Decimal = 0
        'If e.Argument IsNot Nothing Then intStart = DirectCast(e.Argument, Decimal)

        'For i As Decimal = intStart To 50 Step 5
        '    If BackgroundWorker1.CancellationPending Then e.Cancel = True : Return
        '    Threading.Thread.Sleep(500)  ' Simulate download
        '    BackgroundWorker1.ReportProgress(i)

        '    ' ตัวอย่างการทำให้เกิด Error เพื่อทดสอบการตรวจสอบ Error บน BackgroundWorker
        '    'If i = 10 Then Throw New Exception("ทดสอบ error")
        'Next

        'If e.Argument IsNot Nothing Then intStart(1) = DirectCast(e.Argument, Integer)
        'For i2 As Integer = intStart(1) To 0
        '    If BackgroundWorker1.CancellationPending Then e.Cancel = True : Return
        '    Threading.Thread.Sleep(50)  ' Simulate download
        '    BackgroundWorker1.ReportProgress(i2, 1)
        'Next
        '------------------------- Example --------------------------------------------'

        e.Result = "Process is Complete"

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

        UpdateProgress(e.ProgressPercentage)

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        Select Case True
            Case e.Cancelled
                MessageBox.Show("Stop")
            Case e.Error IsNot Nothing
                MessageBox.Show("Process Error / Error Message = " & e.Error.Message)
            Case Else
                ButtonCalculate.Enabled = True
                ButtonSave.Enabled = True
                ButtonReset.Enabled = True
                ButtonStop.Enabled = False
                ButtonPause.Enabled = False
                ButtonStart.Enabled = False
                RadioButtonLeft.Enabled = True
                RadioButtonRight.Enabled = True
                ComboBoxDegrees.Enabled = True
                LabelResultStatus.Text = "Reset to start"
                MessageBox.Show("Result = " & DirectCast(e.Result, String))
        End Select

    End Sub

    '----------------------- this is No change --------------------
    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click


        '----------------------- Connection Setting -----------------------------'
        ComboBoxComPort.Items.Clear()
        Try
            Dim lists As String() = IO.Ports.SerialPort.GetPortNames
            For i = 0 To lists.Count - 1
                ComboBoxComPort.Items.Add(lists(i))
            Next
            ComboBoxComPort.SelectedIndex = "0"
            SerialPort1.PortName = ComboBoxComPort.Text
            ComboBoxBaudRate.SelectedIndex = "0"
            SerialPort1.BaudRate = ComboBoxBaudRate.Text
            SerialPort1.Parity = IO.Ports.Parity.None
            SerialPort1.StopBits = IO.Ports.StopBits.One
            SerialPort1.DataBits = 8
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        '----------------------- Connection Setting -----------------------------'

        If ButtonConnect.Text = "" Then Return

        If SerialPort1.IsOpen Then SerialPort1.Close()

        If ButtonConnect.Text = "Connect" Then
            Try
                SerialPort1.Open()
                ComboBoxComPort.Enabled = False
                ComboBoxBaudRate.Enabled = False
                ButtonConnect.Text = "Disconnect"
                LabelStatusConnect.Text = "Connect!"
                LabelStatusConnect.ForeColor = Color.Green
                LabelResultStatus.Text = "Ready"
                LabelResultStatus.ForeColor = Color.Green
                LabelStatusPort.Text = ComboBoxComPort.SelectedItem.ToString()
                LabelStatusPort.ForeColor = Color.Green
                LabelStatusBuad.Text = ComboBoxBaudRate.SelectedItem.ToString()
                LabelStatusBuad.ForeColor = Color.Green
                ComboBoxDegrees.SelectedIndex = "0"
                RadioButtonLeft.Checked = True

                ButtonStart.Enabled = True
                ComboBoxDegrees.Enabled = True
                RadioButtonLeft.Enabled = True
                RadioButtonRight.Enabled = True
                ButtonReset.Enabled = False



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        ElseIf ButtonConnect.Text = "Disconnect" Then

            SerialPort1.Close()
            ButtonConnect.Text = "Connect"
            LabelStatusConnect.Text = "Disconnect!"
            LabelStatusConnect.ForeColor = Color.Red
            LabelStatusPort.Text = "None"
            LabelStatusPort.ForeColor = Color.Red
            LabelStatusBuad.Text = "None"
            LabelStatusBuad.ForeColor = Color.Red
            LabelResultStatus.Text = "Waitting Connect!"
            LabelResultStatus.ForeColor = Color.Red

            ComboBoxComPort.Enabled = True
            ComboBoxBaudRate.Enabled = True
            ButtonStart.Enabled = False
            ButtonSave.Enabled = False
            ButtonStop.Enabled = False
            ButtonReset.Enabled = False
            ButtonCalculate.Enabled = False
            ComboBoxDegrees.Enabled = False
            RadioButtonLeft.Enabled = False
            RadioButtonRight.Enabled = False
        End If

    End Sub

    Private Sub ButtonPause_Click(sender As Object, e As EventArgs) Handles ButtonPause.Click

        If ButtonPause.Text = "Pause" Then
            Try
                ButtonPause.Text = "Resume"
                LabelResultStatus.Text = "Pause"
                LabelResultStatus.ForeColor = Color.Red
                ButtonSave.Enabled = True
                ButtonStop.Enabled = True
                ButtonCalculate.Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                LabelResultStatus.Text = "Processing"
                LabelResultStatus.ForeColor = Color.Green
                ButtonPause.Text = "Pause"
                ButtonSave.Enabled = False
                ButtonStop.Enabled = True
                ButtonCalculate.Enabled = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        If ButtonReset.Text = "" Then Return
        If ButtonReset.Text = "Reset" Then
            Try
                'Chart1.Series("Series1").Points.Clear()
                LabelResultStatus.Text = "Reset and Ready"
                LabelResultStatus.ForeColor = Color.Green
                ButtonStart.Enabled = True
                ButtonSave.Enabled = False
                ButtonCalculate.Enabled = False
                TextBox1.Text = ""
                TextBox2.Text = ""

                Data_Save = ""
                Data_Show = ""
                Data_Show_Degree = ""

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click

        'ListBox3.Items.Clear()


        'Try
        '    Dim n As Integer =
        '    Math.Min(ListBox1.Items.Count, ListBox3.Items.Count)

        '    For i As Integer = 0 To n - 1
        '        Dim one As Double = ListBox1.Items(i)
        '        Dim two As Double = ListBox3.Items(i)
        '        Chart1.Series("Series1").Points.AddXY(one, two)
        '    Next
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim writer As New IO.StreamWriter(SaveFileDialog1.FileName) 'Creates the 'writer' 
        writer.Write(Data_Save) 'This will write it.         
        writer.Close() 'Closes it. 
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        SaveFileDialog1.ShowDialog()

    End Sub

#End Region

End Class
