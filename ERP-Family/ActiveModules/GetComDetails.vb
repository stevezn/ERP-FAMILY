Imports System.Net

Module GetComDetails
    Sub mac()
        For Each nic As NetworkInformation.NetworkInterface In NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
            MessageBox.Show(String.Format("The MAC address of {0} is{1}{2}", nic.Description, Environment.NewLine, nic.GetPhysicalAddress()))
            Exit For
        Next
    End Sub

    Sub ip()
        Dim strHostName As String
        Dim strIPAddress As String
        strHostName = Dns.GetHostName()
        strIPAddress = Dns.GetHostByName(strHostName).AddressList(0).ToString()
        MessageBox.Show("Host Name: " & strHostName & "; IP Address: " & strIPAddress)
    End Sub
End Module