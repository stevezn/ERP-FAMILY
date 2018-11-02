Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports ActiveConnection.log_file

Module Encrypt
    Public Function Encryptio(clearText As String) As String
        Try
            Dim EncryptionKey As String = "MAKV2SPBNI99212
                                           CCBASKD02930210
                                           MMKSALO12909302
                                           CDHAKS200102123
                                           999090909090909
                                           1782STEVE120383
                                           KIM2910290KMBS1
                                           90912MDL0AKSKKS
                                           09201,12033030!"
            Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
            Using encryptor As Aes = Aes.Create()
                Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
             &H65, &H64, &H76, &H65, &H64, &H65,
             &H76})
                encryptor.Key = pdb.GetBytes(32)
                encryptor.IV = pdb.GetBytes(16)
                Using ms As New MemoryStream()
                    Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                        cs.Write(clearBytes, 0, clearBytes.Length)
                        cs.Close()
                    End Using
                    clearText = Convert.ToBase64String(ms.ToArray())
                End Using
            End Using
        Catch ex As Exception
            storedata(Now & "Error -> " & ex.Message)
            MsgBox("Ask your programmer for this error meaning (ENCRYPT.ENCRYPTIO)", MsgBoxStyle.Critical)
        End Try
        Return clearText
    End Function

    Public Function Decrypt(cipherText As String) As String
        Try
            Dim EncryptionKey As String = "MAKV2SPBNI99212
                                           CCBASKD02930210
                                           MMKSALO12909302
                                           CDHAKS200102123
                                           999090909090909
                                           1782STEVE120383
                                           KIM2910290KMBS1
                                           90912MDL0AKSKKS
                                           09201,12033030!"
            Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
            Using encryptor As Aes = Aes.Create()
                Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
             &H65, &H64, &H76, &H65, &H64, &H65,
             &H76})
                encryptor.Key = pdb.GetBytes(32)
                encryptor.IV = pdb.GetBytes(16)
                Using ms As New MemoryStream()
                    Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                        cs.Write(cipherBytes, 0, cipherBytes.Length)
                        cs.Close()
                    End Using
                    cipherText = Encoding.Unicode.GetString(ms.ToArray())
                End Using
            End Using
        Catch ex As Exception
            storedata(Now & "Error -> " & ex.Message)
            MsgBox("Ask your programmer for this error meaning (DECRYPT.DECRYPT)", MsgBoxStyle.Critical)
        End Try
        Return cipherText
    End Function
End Module