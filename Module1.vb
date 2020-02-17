Imports System
Imports System.Text

Module Module1
    Public Function Zero(intHex As Integer, length As Integer) As String
        Dim strResult As String = Hex(intHex)
        If strResult.Length >= length Then
            Return strResult
        End If
        Return strResult.PadLeft(length, "0")
    End Function

    Public Function Text2Hex(ByVal strIn As String) As String
        Dim strOut As String = ""
        Dim DataBytes As Byte() = System.Text.Encoding.UTF8.GetBytes(strIn)
        If DataBytes.Length > 0 Then
            For i = 0 To DataBytes.Length - 1
                strOut = strOut & " " & DataBytes(i).ToString("X02")
            Next
            strOut = Trim(strOut)
        End If
        Return strOut
    End Function

    Public Function Hex2Byte(ByVal strSrc As String) As Byte()
        Dim hex_byte() As Byte = {}
        Dim i As Integer

        If strSrc.Length > 0 Then
            Dim hex_array() As String = Split(Trim(strSrc), " ")
            ReDim hex_byte(hex_array.Length - 1)

            For i = 0 To hex_array.Length - 1
                If hex_array(i).Length < 3 Then
                    hex_byte(i) = "&H0" + hex_array(i)
                Else
                    hex_byte(i) = "&H0" + Mid(hex_array(i), 1, 2)
                End If
            Next
        End If
        Return hex_byte
    End Function

    Public Function Byte2Hex(ByVal strSrc() As Byte) As String
        Dim strOut As String = ""

        If strSrc.Length > 0 Then
            For i = 0 To strSrc.Length - 1
                strOut = strOut & " " & strSrc(i).ToString("X02")
            Next
            strOut = Trim(strOut)
        End If
        Return strOut
    End Function

    Public Function MyRight(param As String, length As Integer) As String
        Dim result As String = param.Substring(param.Length - length, length)
        Return Left(result, 2) & " " & Right(result, 2)
    End Function
End Module
