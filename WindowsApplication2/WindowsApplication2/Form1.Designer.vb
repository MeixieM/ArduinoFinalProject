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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnON = New System.Windows.Forms.Button()
        Me.BtnOff = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.LblPwm = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnON
        '
        Me.BtnON.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnON.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnON.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnON.ForeColor = System.Drawing.Color.White
        Me.BtnON.Location = New System.Drawing.Point(78, 30)
        Me.BtnON.Name = "BtnON"
        Me.BtnON.Size = New System.Drawing.Size(324, 64)
        Me.BtnON.TabIndex = 0
        Me.BtnON.Text = "ON"
        Me.BtnON.UseVisualStyleBackColor = False
        '
        'BtnOff
        '
        Me.BtnOff.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BtnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOff.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOff.ForeColor = System.Drawing.Color.White
        Me.BtnOff.Location = New System.Drawing.Point(78, 104)
        Me.BtnOff.Name = "BtnOff"
        Me.BtnOff.Size = New System.Drawing.Size(324, 67)
        Me.BtnOff.TabIndex = 1
        Me.BtnOff.Text = "OFF"
        Me.BtnOff.UseVisualStyleBackColor = False
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(78, 190)
        Me.TrackBar1.Maximum = 255
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(324, 45)
        Me.TrackBar1.TabIndex = 2
        '
        'LblPwm
        '
        Me.LblPwm.AutoSize = True
        Me.LblPwm.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPwm.Location = New System.Drawing.Point(210, 239)
        Me.LblPwm.Name = "LblPwm"
        Me.LblPwm.Size = New System.Drawing.Size(93, 13)
        Me.LblPwm.TabIndex = 3
        Me.LblPwm.Text = "PWM VALUE: 000"
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 288)
        Me.Controls.Add(Me.LblPwm)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.BtnOff)
        Me.Controls.Add(Me.BtnON)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Smart Car Parking System"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnON As System.Windows.Forms.Button
    Friend WithEvents BtnOff As System.Windows.Forms.Button
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents LblPwm As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort

End Class
