Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Net.Sockets

Public Class FrmClient
    Public SckClient As TcpClient
    Dim nstr As NetworkStream
  
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Me.Text = "TCP Client"
    End Sub
    
    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles BtnConnect.Click
       BtnConnect.Enabled = False
        Try
            SckClient = New TcpClient
            SckClient.Connect(txtIP.Text, Integer.Parse(txtPort.Text))
            If (SckClient.Connected And SckClient.Client.Poll(0, SelectMode.SelectRead)) Then
            Else
                StartClient()
            End If
        Catch ex As Exception
            RichTextBox1.Text += "BeginConnect() Exception : " + ex.Message + vbNewLine
            Disconnected()
        End Try
    End Sub

    Public Sub StartClient()
        Try
            BtnDisconnect.Enabled = True
            BtnConnect.Enabled = False
            lblLAN.Text = "CONNECTED"
            txtRemote.Text = SckClient.Client.RemoteEndPoint.ToString
            txtLocal.Text = SckClient.Client.LocalEndPoint.ToString

            Threading.ThreadPool.QueueUserWorkItem(AddressOf Connected)
            Timer1.Enabled = True
        Catch ex As Exception
            RichTextBox1.Text += "BeginConnect() Exception : " + ex.Message + vbNewLine
            Disconnected()
        End Try
    End Sub

    Function Connected() As Boolean
        Dim Buffer(4096) As Byte
        Dim bytesRead As Integer

        Try
            While (SckClient.Connected = True)
                If (((SckClient.Connected = True) And SckClient.Client.Poll(0, SelectMode.SelectRead)) Or (BtnDisconnect.Enabled = False)) Then
                    Exit While
                Else
                    nstr = SckClient.GetStream()
                    If nstr.CanRead Then
                        bytesRead = nstr.Read(Buffer, 0, Buffer.Length)
                        RecvHexFromClients(bytesRead, Buffer)
                    End If
                End If
            End While
        Catch ex As Exception
            RichTextBox1.Text += "Connected() Exception : " + ex.Message + vbNewLine
            Disconnected()
        End Try
        Return True
    End Function

    Sub Disconnected()
        Timer1.Enabled = False
        BtnDisconnect.Enabled = False
        lblLAN.Text = "NOT CONNECTED"
        Try
            If SckClient IsNot Nothing Then
                SckClient.Close()
            End If
        Catch ex As Exception
            RichTextBox1.Text += "Disconnected():" + ex.Message + vbNewLine
        End Try
        BtnConnect.Enabled = True
    End Sub

    Sub RecvHexFromClients(ByVal bytesRead As Integer, ByVal Buffer() As Byte)
        Dim strTemp As String
        Dim i As Integer
        'Dim byteRet(bytesRead) As Byte
        strTemp = ""
        If bytesRead > 0 Then
            For i = 0 To bytesRead - 1
                strTemp = strTemp & " " & Buffer(i).ToString("X02")
                'byteRet(i) = Buffer(i)
            Next
            strTemp = Trim(strTemp)
            ComboBox1.Items.Add("Rx: " + strTemp)
        End If
    End Sub

    Function SendHexToServer(ByVal hex_byte() As Byte) As Boolean
        Try
            Dim nstm As Stream
            nstm = SckClient.GetStream
            If (nstm.CanWrite = True) And (hex_byte.Length > 0) Then
                nstm.Write(hex_byte, 0, hex_byte.Length)
                nstm.Flush()
                ComboBox1.Items.Add("Tx: " + Byte2Hex(hex_byte))
                Return True
            End If
        Catch ex As Exception
            RichTextBox1.Text += "SendHexToServer() Exception" + ex.Message + vbNewLine
        End Try
        Return False
    End Function

    Private Sub BtnDisconnect_Click(sender As Object, e As EventArgs) Handles BtnDisconnect.Click
        Disconnected()
    End Sub

    Private Sub BtnHex_Click(sender As Object, e As EventArgs) Handles BtnHex.Click
        If txtSend.Text.Length > 0 AndAlso Not (txtHex.Text.Length > 0) Then
            txtHex.Text = Text2Hex(txtSend.Text)
        End If

        Dim hex_byte() As Byte = Hex2Byte(txtHex.Text)
        If SendHexToServer(hex_byte) = True Then
            'txtHex.Clear()
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ComboBox1.Items.Clear()
        RichTextBox1.Clear()
    End Sub

    Private Sub FrmClient_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        BtnDisconnect.Enabled = False
        If SckClient IsNot Nothing Then
            SckClient.Close()
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If ((SckClient.Connected = True) And SckClient.Client.Poll(0, SelectMode.SelectRead)) Then
                Debug.Print("time detect stop connet")
                Disconnected()
            End If
        Catch ex As Exception
        End Try
        'lblTick.Text = MyRight(Zero(My.Computer.Clock.TickCount / 100, 4), 4)
    End Sub


End Class
