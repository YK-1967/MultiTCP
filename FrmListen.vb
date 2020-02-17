Imports System.IO
Imports System.Net
Imports System.Net.Sockets

Public Class FrmListen
    Public Server As TcpListener

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        Server = New TcpListener(IPAddress.Any, Integer.Parse(txtPort.Text))
        Me.Text = "TCP Listener"
    End Sub

    Private Sub BtnListen_Click(sender As Object, e As EventArgs) Handles BtnListen.Click
        StartServer()
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        StopServer()
    End Sub

    Function StartServer() As Boolean
        Try
            Server.Start()
            Timer1.Enabled = True
            BtnListen.Enabled = False
        Catch ex As Exception
            RichTextBox1.Text += "StartServer Exception:" + ex.Message + vbNewLine
        End Try
        BtnStop.Enabled = True
        Return True
    End Function

    Function StopServer() As Boolean
        BtnStop.Enabled = False
        Try
            Timer1.Enabled = False
            If Server.Pending Then
                Server.Stop()
            End If
        Catch ex As Exception
            RichTextBox1.Text += "StopServer Exception:" + ex.Message + vbNewLine
        End Try
        BtnListen.Enabled = True
        Return True
    End Function

    Function Handler_Client()
        If BtnListen.Enabled = False Then
            Dim TcpServer As New FrmServer
            Using TcpServer.SckClient
                Try
                    TcpServer.MdiParent = FrmMDI
                    TcpServer.Show()
                    TcpServer.SckClient = Server.AcceptTcpClient
                    TcpServer.StartServer()
                    lblTotalClient.Text = 1 + CInt(lblTotalClient.Text)
                Catch ex As Exception
                    RichTextBox1.Text += "Handler_Client Exception:" + ex.Message + vbNewLine
                    TcpServer.Close()
                End Try
            End Using
        End If
        Return True
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If Server.Pending Then
                Timer1.Enabled = False
                Handler_Client()
                Timer1.Enabled = True
            End If
        Catch ex As Exception
            RichTextBox1.Text += "Handler_Client Exception:" + ex.Message + vbNewLine
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        RichTextBox1.Clear()
    End Sub
End Class
