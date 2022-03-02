Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.CenterToParent()
        'SerialPort1.PortName = "COM7"
        'SerialPort1.BaudRate = 9600
        'SerialPort1.Open()
        'Timer1.Start()
        'SerialPort1.Write(TrackBar1.Value & Chr(10))
    End Sub

    Private Sub BtnON_Click(sender As Object, e As EventArgs) Handles BtnON.Click
        TrackBar1.Value = 255
    End Sub

    Private Sub BtnOff_Click(sender As Object, e As EventArgs) Handles BtnOff.Click
        TrackBar1.Value = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim i As Single = SerialPort1.ReadExisting
            LblPwm.Text = "Pwm Value : " & i.ToString
            SerialPort1.Write(TrackBar1.Value & Chr(10))
        Catch ex As Exception

        End Try
    End Sub
End Class
