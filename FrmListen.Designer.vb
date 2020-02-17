<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListen
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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.lblTotalClient = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.BtnListen = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(38, 80)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(162, 22)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(100, 22)
        Me.txtPort.TabIndex = 21
        Me.txtPort.Text = "5000"
        Me.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(126, 27)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(30, 12)
        Me.lblPort.TabIndex = 20
        Me.lblPort.Text = "Port :"
        '
        'lblTotalClient
        '
        Me.lblTotalClient.BackColor = System.Drawing.Color.White
        Me.lblTotalClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalClient.Location = New System.Drawing.Point(282, 22)
        Me.lblTotalClient.Name = "lblTotalClient"
        Me.lblTotalClient.Size = New System.Drawing.Size(36, 23)
        Me.lblTotalClient.TabIndex = 19
        Me.lblTotalClient.Text = "0"
        Me.lblTotalClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(128, 53)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(222, 119)
        Me.RichTextBox1.TabIndex = 18
        Me.RichTextBox1.Text = ""
        '
        'BtnStop
        '
        Me.BtnStop.Location = New System.Drawing.Point(38, 51)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(75, 23)
        Me.BtnStop.TabIndex = 17
        Me.BtnStop.Text = "Stop"
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'BtnListen
        '
        Me.BtnListen.Location = New System.Drawing.Point(38, 22)
        Me.BtnListen.Name = "BtnListen"
        Me.BtnListen.Size = New System.Drawing.Size(75, 23)
        Me.BtnListen.TabIndex = 16
        Me.BtnListen.Text = "Listen"
        Me.BtnListen.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'FrmListen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 193)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.lblTotalClient)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.BtnListen)
        Me.Name = "FrmListen"
        Me.Text = "FrmListen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents txtPort As TextBox
    Friend WithEvents lblPort As Label
    Friend WithEvents lblTotalClient As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents BtnStop As Button
    Friend WithEvents BtnListen As Button
    Friend WithEvents Timer1 As Timer
End Class
