Imports System.IO.Ports

Public Class TestCOM


    Private Sub SetUpSerialConnection()
        '    Try
        'Now we can set up the serial connection
        SerialPortArduino.BaudRate = 9600
        SerialPortArduino.DataBits = 8
        SerialPortArduino.Parity = Parity.None
        SerialPortArduino.StopBits = StopBits.One
        SerialPortArduino.Handshake = Handshake.None
        SerialPortArduino.Encoding = System.Text.Encoding.Default 'very important!
        SerialPortArduino.PortName = "COM5"
        'SerialPortArduino.ReadTimeout = 200

        'Catch ex As Exception
        'TimerForRoutineRegistrationData.Stop()
        'LblStatus.Text = "Connessione seriale non presente"
        'Dim ans = MsgBox("Arduino is not connected", MsgBoxStyle.RetryCancel)
        'If ans = MsgBoxResult.Retry Then
        'SetUpSerialConnection()
        'End If
        'If ans = MsgBoxResult.Cancel Then
        'LblStatus.Text = "Connessione seriale non presente"
        'ButtonRitentaConnessione.Visible = True
        'End If
        'End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SetUpSerialConnection()
        SerialPortArduino.Open()
        Label1.Text = SerialPortArduino.ReadLine()
        SerialPortArduino.Close()
    End Sub
End Class