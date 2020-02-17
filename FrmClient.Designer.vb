<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClient
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
        Me.lblTick = New System.Windows.Forms.Label()
        Me.txtLocal = New System.Windows.Forms.TextBox()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.lblLAN = New System.Windows.Forms.Label()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.txtRemote = New System.Windows.Forms.TextBox()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.BtnHex = New System.Windows.Forms.Button()
        Me.txtHex = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.BtnDisconnect = New System.Windows.Forms.Button()
        Me.txtSend = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnConnect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTick
        '
        Me.lblTick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTick.Location = New System.Drawing.Point(299, 45)
        Me.lblTick.Name = "lblTick"
        Me.lblTick.Size = New System.Drawing.Size(100, 23)
        Me.lblTick.TabIndex = 33
        Me.lblTick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLocal
        '
        Me.txtLocal.Location = New System.Drawing.Point(94, 74)
        Me.txtLocal.Name = "txtLocal"
        Me.txtLocal.Size = New System.Drawing.Size(188, 22)
        Me.txtLocal.TabIndex = 32
        Me.txtLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(12, 158)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 31
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'lblLAN
        '
        Me.lblLAN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLAN.Location = New System.Drawing.Point(95, 45)
        Me.lblLAN.Name = "lblLAN"
        Me.lblLAN.Size = New System.Drawing.Size(187, 26)
        Me.lblLAN.TabIndex = 30
        Me.lblLAN.Text = "NOT CONNECTED"
        Me.lblLAN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Location = New System.Drawing.Point(106, 18)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(18, 12)
        Me.lblIP.TabIndex = 29
        Me.lblIP.Text = "IP:"
        '
        'txtRemote
        '
        Me.txtRemote.Location = New System.Drawing.Point(288, 74)
        Me.txtRemote.Name = "txtRemote"
        Me.txtRemote.Size = New System.Drawing.Size(188, 22)
        Me.txtRemote.TabIndex = 28
        Me.txtRemote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(253, 16)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(30, 12)
        Me.lblPort.TabIndex = 27
        Me.lblPort.Text = "Port :"
        '
        'BtnHex
        '
        Me.BtnHex.Location = New System.Drawing.Point(12, 128)
        Me.BtnHex.Name = "BtnHex"
        Me.BtnHex.Size = New System.Drawing.Size(75, 23)
        Me.BtnHex.TabIndex = 26
        Me.BtnHex.Text = "Hex"
        Me.BtnHex.UseVisualStyleBackColor = True
        '
        'txtHex
        '
        Me.txtHex.Location = New System.Drawing.Point(94, 130)
        Me.txtHex.Name = "txtHex"
        Me.txtHex.Size = New System.Drawing.Size(382, 22)
        Me.txtHex.TabIndex = 25
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(93, 160)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(383, 188)
        Me.ComboBox1.TabIndex = 24
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(142, 13)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(100, 22)
        Me.txtIP.TabIndex = 23
        Me.txtIP.Text = "127.0.0.1"
        Me.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(301, 14)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(57, 22)
        Me.txtPort.TabIndex = 22
        Me.txtPort.Text = "5000"
        Me.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnDisconnect
        '
        Me.BtnDisconnect.Enabled = False
        Me.BtnDisconnect.Location = New System.Drawing.Point(13, 70)
        Me.BtnDisconnect.Name = "BtnDisconnect"
        Me.BtnDisconnect.Size = New System.Drawing.Size(75, 23)
        Me.BtnDisconnect.TabIndex = 20
        Me.BtnDisconnect.Text = "Disconnect"
        Me.BtnDisconnect.UseVisualStyleBackColor = True
        '
        'txtSend
        '
        Me.txtSend.Location = New System.Drawing.Point(93, 102)
        Me.txtSend.Name = "txtSend"
        Me.txtSend.Size = New System.Drawing.Size(383, 22)
        Me.txtSend.TabIndex = 19
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(95, 354)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(381, 308)
        Me.RichTextBox1.TabIndex = 18
        Me.RichTextBox1.Text = ""
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'BtnConnect
        '
        Me.BtnConnect.Location = New System.Drawing.Point(13, 16)
        Me.BtnConnect.Name = "BtnConnect"
        Me.BtnConnect.Size = New System.Drawing.Size(75, 23)
        Me.BtnConnect.TabIndex = 17
        Me.BtnConnect.Text = "Connect"
        Me.BtnConnect.UseVisualStyleBackColor = True
        '
        'FrmClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 678)
        Me.Controls.Add(Me.lblTick)
        Me.Controls.Add(Me.txtLocal)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.lblLAN)
        Me.Controls.Add(Me.lblIP)
        Me.Controls.Add(Me.txtRemote)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.BtnHex)
        Me.Controls.Add(Me.txtHex)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.BtnDisconnect)
        Me.Controls.Add(Me.txtSend)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.BtnConnect)
        Me.Name = "FrmClient"
        Me.Text = "FrmClient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTick As Label
    Friend WithEvents txtLocal As TextBox
    Friend WithEvents BtnClear As Button
    Friend WithEvents lblLAN As Label
    Friend WithEvents lblIP As Label
    Friend WithEvents txtRemote As TextBox
    Friend WithEvents lblPort As Label
    Friend WithEvents BtnHex As Button
    Friend WithEvents txtHex As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtIP As TextBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents BtnDisconnect As Button
    Friend WithEvents txtSend As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnConnect As Button
End Class
