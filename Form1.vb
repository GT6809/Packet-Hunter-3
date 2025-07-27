Imports System.Net
Imports System.Net.Http
Imports System.Net.Sockets
Imports System.Text.RegularExpressions

Public Class Form1

    Dim socketz As New Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.IP)
    Dim bytedata(4096) As Byte
    Dim myip As IPAddress
    Dim started As Boolean = True
    Dim sizediff As Size
    Dim formloaded As Boolean = False
    Dim FilterIPAddress As New IPAddress(0)
    Dim FilterIP As Boolean
    Dim mycomputerconnections() As Net.NetworkInformation.NetworkInterface
    Dim srsprot As String
    Dim destprot As String
    Dim checksumErrorsCount As Integer = 0


    Dim stringz As String = ""
    Dim Typez As String = ""
    Dim ipfrom As IPAddress
    Dim ipto As IPAddress
    Dim destinationport As UInteger
    Dim sourceport As UInteger
    Dim headerss As String = ""


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sizediff.Height = Me.Height - DGV.Height
        sizediff.Width = Me.Width - DGV.Width
        formloaded = True

        mycomputerconnections = Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces

        For i = 0 To mycomputerconnections.Length - 1
            ComboBox1.Items.Add(mycomputerconnections(i).Name)
        Next

    End Sub

    Private Sub OnReceive(ByVal asyncresult As IAsyncResult)

        If started = True Then

            Dim readlength As UInteger = BitConverter.ToUInt16(Byteswap(bytedata, 2), 0)
            sourceport = BitConverter.ToUInt16(Byteswap(bytedata, 22), 0)
            destinationport = BitConverter.ToUInt16(Byteswap(bytedata, 24), 0)


            Dim ipHeaderLength As Integer = (bytedata(0) And 15) * 4
            Dim ipHeaderChecksum As UShort = BitConverter.ToUInt16(bytedata, 10)
            Dim calculatedChecksum As UShort = CalculateIPChecksum(bytedata, 0, ipHeaderLength)


            If calculatedChecksum <> ipHeaderChecksum Then

                Me.Invoke(Sub()
                              checksumErrorsCount += 1
                              Label1.Text = "Checksum Errors: " & checksumErrorsCount
                              Debug.WriteLine("Checksum Error - Calculated: " & calculatedChecksum & ", IP Header: " & ipHeaderChecksum)
                          End Sub)
            End If

            'Get Protocol Type
            If bytedata(9) = 6 Then
                Typez = "TCP"
            ElseIf bytedata(9) = 17 Then
                Typez = "UDP"
            Else
                Typez = "???"
            End If


            ipfrom = New IPAddress(BitConverter.ToUInt32(bytedata, 12))
            ipto = New IPAddress(BitConverter.ToUInt32(bytedata, 16))


            If (ipfrom.Equals(myip) = True Or ipto.Equals(myip) = True) And ipto.Equals(ipfrom) = False Then
                If FilterIP = False Or (FilterIP = True And (FilterIPAddress.Equals(ipfrom) Or FilterIPAddress.Equals(ipto))) Then

                    stringz = ""
                    For i = 26 To readlength - 1
                        If Char.IsLetterOrDigit(Chr(bytedata(i))) = True Then
                            stringz = stringz & Chr(bytedata(i))
                        Else
                            stringz = stringz & "."
                        End If
                    Next


                    If stringz.Contains("HTTP/1.") Then

                        Dim headers As String = ExtractHTTPHeaders(stringz)


                        DGV.Invoke(New MethodInvoker(AddressOf DGVUpdateWithHeaders))

                    Else

                        DGV.Invoke(New MethodInvoker(AddressOf DGVUpdate))
                    End If
                End If
            End If

        End If


        socketz.BeginReceive(bytedata, 0, bytedata.Length, SocketFlags.None, New AsyncCallback(AddressOf OnReceive), Nothing)
    End Sub

    Private Function ExtractHTTPHeaders(data As String) As String
        Dim headerss As String = ""
        Dim headerRegex As New Regex("(.*?: .*?)(?:\r\n|$)")

        Dim headerMatches As MatchCollection = headerRegex.Matches(data)
        For Each headerMatch As Match In headerMatches
            headerss += headerMatch.Value & vbCrLf
        Next

        Return headerss
    End Function

    Private Function CalculateIPChecksum(packet As Byte(), offset As Integer, length As Integer) As UShort
        Dim sum As UInteger = 0

        For i As Integer = offset To offset + length - 1 Step 2
            sum += BitConverter.ToUInt16(packet, i)
        Next


        If length Mod 2 = 1 Then
            sum += packet(offset + length - 1)
        End If

        While (sum >> 16) > 0
            sum = (sum And &HFFFF) + (sum >> 16)
        End While

        Return Not CType(sum, UShort)
    End Function

    Private Sub DGVUpdateWithHeaders()
        srsprot = ""
        destprot = ""

        If DGV.Rows.Count > 50 Then
            DGV.Rows.RemoveAt(0)
        End If

        If (sourceport = 80) Then
            srsprot = "HTTP"
        End If

        If (destinationport = 80) Then
            destprot = "HTTP"
        End If

        If (sourceport = 443) Then
            srsprot = "HTTPS"
        End If

        If (destinationport = 443) Then
            destprot = "HTTPS"
        End If

        DGV.Rows.Add()
        DGV.Rows(DGV.Rows.Count - 1).Cells(0).Value = ipfrom.ToString
        DGV.Rows(DGV.Rows.Count - 1).Cells(1).Value = ipto.ToString
        DGV.Rows(DGV.Rows.Count - 1).Cells(2).Value = sourceport
        DGV.Rows(DGV.Rows.Count - 1).Cells(3).Value = destinationport
        DGV.Rows(DGV.Rows.Count - 1).Cells(4).Value = srsprot
        DGV.Rows(DGV.Rows.Count - 1).Cells(5).Value = destprot
        DGV.Rows(DGV.Rows.Count - 1).Cells(6).Value = Typez
        DGV.Rows(DGV.Rows.Count - 1).Cells(8).Value = stringz
        DGV.Rows(DGV.Rows.Count - 1).Cells(9).Value = headerss
    End Sub

    Private Sub DGVUpdate()
        srsprot = ""
        destprot = ""


        If DGV.Rows.Count > 50 Then
            DGV.Rows.RemoveAt(0)
        End If

        If (sourceport = 80) Then
            srsprot = "HTTP"
        End If

        If (destinationport = 80) Then
            destprot = "HTTP"
        End If

        If (sourceport = 443) Then
            srsprot = "HTTPS"
        End If

        If (destinationport = 443) Then
            destprot = "HTTPS"
        End If

        DGV.Rows.Add()
        DGV.Rows(DGV.Rows.Count - 1).Cells(0).Value = ipfrom.ToString
        DGV.Rows(DGV.Rows.Count - 1).Cells(1).Value = ipto.ToString
        DGV.Rows(DGV.Rows.Count - 1).Cells(2).Value = sourceport
        DGV.Rows(DGV.Rows.Count - 1).Cells(3).Value = destinationport
        DGV.Rows(DGV.Rows.Count - 1).Cells(4).Value = srsprot
        DGV.Rows(DGV.Rows.Count - 1).Cells(5).Value = destprot
        DGV.Rows(DGV.Rows.Count - 1).Cells(6).Value = Typez
        DGV.Rows(DGV.Rows.Count - 1).Cells(8).Value = stringz

    End Sub

    Private Function Byteswap(ByVal bytez() As Byte, ByVal index As UInteger)
        Dim result(1) As Byte
        result(0) = bytez(index + 1)
        result(1) = bytez(index)
        Return result
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If started = True Then
            Button1.Text = "Start"
            started = False
        Else
            Button1.Text = "Stop"
            started = True
        End If
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If formloaded = True Then
            DGV.Size = Me.Size - sizediff
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        Try
            If TextBox1.Text <> "" And TextBox1.Text IsNot Nothing Then
                FilterIPAddress = IPAddress.Parse(TextBox1.Text)
                FilterIP = True
                TextBox1.BackColor = Color.LimeGreen
            Else
                FilterIP = False
                TextBox1.BackColor = Color.White
            End If
        Catch ex As Exception
            FilterIP = False
            TextBox1.BackColor = Color.White
        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        For i = 0 To mycomputerconnections(ComboBox1.SelectedIndex).GetIPProperties.UnicastAddresses.Count - 1

            If mycomputerconnections(ComboBox1.SelectedIndex).GetIPProperties.UnicastAddresses(i).Address.AddressFamily = Net.Sockets.AddressFamily.InterNetwork Then

                myip = mycomputerconnections(ComboBox1.SelectedIndex).GetIPProperties.UnicastAddresses(i).Address

                BindSocket()

            End If

        Next

    End Sub

    Private Sub BindSocket()

        Try
            socketz.Bind(New IPEndPoint(myip, 0))
            socketz.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.HeaderIncluded, True)
            Dim bytrue() As Byte = {1, 0, 0, 0}
            Dim byout() As Byte = {1, 0, 0, 0}
            socketz.IOControl(IOControlCode.ReceiveAll, bytrue, byout)
            socketz.Blocking = False
            ReDim bytedata(socketz.ReceiveBufferSize)
            socketz.BeginReceive(bytedata, 0, bytedata.Length, SocketFlags.None, New AsyncCallback(AddressOf OnReceive), Nothing)
            ComboBox1.Enabled = False
        Catch ex As Exception
            ComboBox1.BackColor = Color.Red
        End Try

    End Sub

End Class