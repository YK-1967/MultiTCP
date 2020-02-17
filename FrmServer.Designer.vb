<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmServer
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
        Me.components = New System.ComponentModel.Container()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTick = New System.Windows.Forms.Label()
        Me.lblLAN = New System.Windows.Forms.Label()
        Me.txtRemote = New System.Windows.Forms.TextBox()
        Me.txtLocal = New System.Windows.Forms.TextBox()
        Me.BtnDisconnect = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnHex = New System.Windows.Forms.Button()
        Me.txtHex = New System.Windows.Forms.TextBox()
        Me.txtSend = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(109, 139)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(368, 141)
        Me.ComboBox1.TabIndex = 28
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lblTick
        '
        Me.lblTick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTick.Location = New System.Drawing.Point(296, 11)
        Me.lblTick.Name = "lblTick"
        Me.lblTick.Size = New System.Drawing.Size(100, 23)
        Me.lblTick.TabIndex = 39
        Me.lblTick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLAN
        '
        Me.lblLAN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLAN.Location = New System.Drawing.Point(109, 11)
        Me.lblLAN.Name = "lblLAN"
        Me.lblLAN.Size = New System.Drawing.Size(181, 26)
        Me.lblLAN.TabIndex = 38
        Me.lblLAN.Text = "NOT CONNECTED"
        Me.lblLAN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRemote
        '
        Me.txtRemote.Location = New System.Drawing.Point(296, 47)
        Me.txtRemote.Name = "txtRemote"
        Me.txtRemote.Size = New System.Drawing.Size(181, 22)
        Me.txtRemote.TabIndex = 37
        '
        'txtLocal
        '
        Me.txtLocal.Location = New System.Drawing.Point(109, 47)
        Me.txtLocal.Name = "txtLocal"
        Me.txtLocal.Size = New System.Drawing.Size(181, 22)
        Me.txtLocal.TabIndex = 36
        '
        'BtnDisconnect
        '
        Me.BtnDisconnect.Location = New System.Drawing.Point(9, 45)
        Me.BtnDisconnect.Name = "BtnDisconnect"
        Me.BtnDisconnect.Size = New System.Drawing.Size(75, 23)
        Me.BtnDisconnect.TabIndex = 35
        Me.BtnDisconnect.Text = "Disconnect"
        Me.BtnDisconnect.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(9, 137)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 34
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnHex
        '
        Me.BtnHex.Location = New System.Drawing.Point(9, 106)
        Me.BtnHex.Name = "BtnHex"
        Me.BtnHex.Size = New System.Drawing.Size(75, 23)
        Me.BtnHex.TabIndex = 33
        Me.BtnHex.Text = "Hex"
        Me.BtnHex.UseVisualStyleBackColor = True
        '
        'txtHex
        '
        Me.txtHex.Location = New System.Drawing.Point(109, 108)
        Me.txtHex.Multiline = True
        Me.txtHex.Name = "txtHex"
        Me.txtHex.Size = New System.Drawing.Size(368, 23)
        Me.txtHex.TabIndex = 32
        '
        'txtSend
        '
        Me.txtSend.Location = New System.Drawing.Point(109, 79)
        Me.txtSend.Multiline = True
        Me.txtSend.Name = "txtSend"
        Me.txtSend.Size = New System.Drawing.Size(368, 23)
        Me.txtSend.TabIndex = 31
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(109, 281)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(368, 183)
        Me.RichTextBox1.TabIndex = 30
        Me.RichTextBox1.Text = ""
        '
        'FrmServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 468)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblTick)
        Me.Controls.Add(Me.lblLAN)
        Me.Controls.Add(Me.txtRemote)
        Me.Controls.Add(Me.txtLocal)
        Me.Controls.Add(Me.BtnDisconnect)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnHex)
        Me.Controls.Add(Me.txtHex)
        Me.Controls.Add(Me.txtSend)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "FrmServer"
        Me.Text = "FormServer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTick As Label
    Friend WithEvents lblLAN As Label
    Friend WithEvents txtRemote As TextBox
    Friend WithEvents txtLocal As TextBox
    Friend WithEvents BtnDisconnect As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnHex As Button
    Friend WithEvents txtHex As TextBox
    Friend WithEvents txtSend As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
